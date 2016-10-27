'By manipulating the bytes in a picture file this program adds strings to the picture file
'Without distorting the image
Imports System.Threading
Imports StegSteg.StegHelpers

Public Class Form1
    Dim t1 As Thread
    Dim PicBuffer As System.IO.FileInfo
    Dim PicFileStream As System.IO.FileStream

#Region "Thread-safe GUI Updaters"
    Public Delegate Sub setTextSafeCallback([theText] As String)
    Public Delegate Sub clearImageSafeCallback([theImagePath] As String)

    Private Sub clearPBoxSafe(theImagePath As String)
        Try
            With PictureBox1
                If .InvokeRequired Then
                    Dim d As New clearImageSafeCallback(AddressOf clearPBoxSafe)
                    Me.Invoke(d, New Object() {[theImagePath]})
                    d = Nothing
                Else
                    .Image = Nothing
                    .Refresh()
                    .Invalidate()
                End If
            End With
        Catch exAll As Exception : End Try
    End Sub

    Public Sub updateTxtPlaintextSafe(theText As String)
        Try
            With txtPlaintext
                If .InvokeRequired Then
                    Dim d As New setTextSafeCallback(AddressOf updateTxtPlaintextSafe)
                    Me.Invoke(d, New Object() {[theText]})
                    d = Nothing
                Else
                    .Text = theText
                    .Refresh()
                    .Invalidate()
                End If
            End With
        Catch exAll As Exception : End Try
    End Sub
    Public Sub updateTxtRecoveredTextSafe(theText As String)
        Try
            With txtRecoveredText
                If .InvokeRequired Then
                    Dim d As New setTextSafeCallback(AddressOf updateTxtRecoveredTextSafe)
                    Me.Invoke(d, New Object() {[theText]})
                    d = Nothing
                Else
                    .Text = theText
                    .Refresh()
                    .Invalidate()
                End If
            End With
        Catch exAll As Exception : End Try
    End Sub

    Private Sub updateTxtFilenameSafe(theText As String)
        Try
            With txtFilename
                If .InvokeRequired Then
                    Dim d As New setTextSafeCallback(AddressOf updateTxtFilenameSafe)
                    Me.Invoke(d, New Object() {[theText]})
                    d = Nothing
                Else
                    .Text = theText
                    .Refresh()
                    .Invalidate()
                End If
            End With
        Catch exAll As Exception : End Try

    End Sub
#End Region

    Private Sub btnFromFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFromFile.Click
        With openPic
            .Title = "Open Picture From File"
            .Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif"
            .ShowDialog()
        End With
        If openPic.FileName <> "" Then
            updateTxtPlaintextSafe(String.Empty)
            updateTxtRecoveredTextSafe(String.Empty)
            PicFileStream = PicBuffer.OpenRead
            RecoverSteggedText(PicFileStream, PicBuffer)
        End If
    End Sub

    Private Sub openPic_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles openPic.FileOk
        PictureBox1.Image = Image.FromFile(openPic.FileName)
        PicBuffer = New System.IO.FileInfo(openPic.FileName)
        ResizeFileName(openPic.FileName, PicBuffer.Name)
    End Sub

    Private Sub btnFromImgur_Click(sender As Object, e As EventArgs) Handles btnFromImgur.Click
        t1 = Nothing
        t1 = New Thread(AddressOf imgurDownloader, 8000000)
        With t1
            .IsBackground = True
            .Priority = ThreadPriority.Lowest
            .SetApartmentState(ApartmentState.STA)
            .Start()
        End With
    End Sub

    Private Sub imgurDownloader()
        clearPBoxSafe("asdf")
        updateTxtRecoveredTextSafe(String.Empty)
        updateTxtPlaintextSafe(String.Empty)
        updateTxtFilenameSafe("Loading random Imgur image... please be patient")
        Dim dlLocation As String = Environment.GetFolderPath(Environment.SpecialFolder.InternetCache) & "\"
        Dim getImgurImage As New StegSteg.ImgurHelpers
        Dim randPicPath As String = getImgurImage.GetRandomImg
        PictureBox1.Image = getImgurImage.webDownloadImage(randPicPath, True, dlLocation)
        PicBuffer = New System.IO.FileInfo(dlLocation & Split(randPicPath, "/")(3))
        ResizeFileName(dlLocation & randPicPath, Split(randPicPath, "/")(3))
        RecoverSteggedText(PicFileStream, PicBuffer)
    End Sub

    Private Sub btnDoSteg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDoSteg.Click
        Dim Ready As Boolean = True
        Try
            PicFileStream = PicBuffer.OpenRead
        Catch ex As Exception
            Ready = False
            updateTxtFilenameSafe("Please load a picture before clicking proceed")
        End Try
        If Ready = True Then
            If radAdd.Checked = True Then
                If txtPlaintext.Text = "" Then
                    updateTxtFilenameSafe("Please specify the plaintext to add to the image via steganography")
                Else
                    AddSteggedText(PicFileStream, PicBuffer)
                End If
            ElseIf radRead.Checked Then
                updateTxtRecoveredTextSafe(String.Empty)
                RecoverSteggedText(PicFileStream, PicBuffer)

            End If
        End If

    End Sub

    Sub ResizeFileName(ByVal LongFileName As String, ByVal ShortFileName As String)
        If LongFileName.Length > 65 Then
            Dim LongFileNameSize As Integer = LongFileName.Length
            Dim ShortFileNameSize As Integer = ShortFileName.Length
            Dim Cut As Integer = 65 - (5 + ShortFileNameSize)
            Dim i As Integer
            updateTxtFilenameSafe(String.Empty)
            For i = 0 To (Cut) - 1
                updateTxtFilenameSafe(txtFilename.Text & LongFileName.Chars(i))
            Next
            For i = 0 To 4
                updateTxtFilenameSafe(txtFilename.Text & ".")
            Next
            For i = 0 To (ShortFileNameSize - 1)
                updateTxtFilenameSafe(txtFilename.Text & ShortFileName(i))
            Next
        Else
            updateTxtFilenameSafe(LongFileName)
        End If

    End Sub

    Private Sub radRead_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radRead.CheckedChanged
        txtPlaintext.Enabled = False
        updateTxtRecoveredTextSafe(String.Empty)
    End Sub

    Private Sub radAdd_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radAdd.CheckedChanged
        txtPlaintext.Enabled = True
        updateTxtRecoveredTextSafe(String.Empty)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        radAdd.Checked = True
        txtPlaintext.Enabled = True
        txtFilename.Text = "Begin by opening an image from file or from Imgur:"
    End Sub

    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
        End
    End Sub

    Private Sub OpenTempFolderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenTempFolderToolStripMenuItem.Click
        Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.InternetCache))
    End Sub

End Class
