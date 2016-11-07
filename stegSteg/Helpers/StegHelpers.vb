Public Class StegHelpers

    Public Shared Sub AddSteggedText(picFileStream As System.IO.FileStream, picBuffer As System.IO.FileInfo)
        Dim PicBytes As Long = picFileStream.Length
        Dim PicExt As String = picBuffer.Extension
        Dim PicByteArray(PicBytes) As Byte
        picFileStream.Read(PicByteArray, 0, PicBytes)
        Dim SentinelString() As Byte = {73, 116, 83, 116, 97, 114, 116, 115, 72, 101, 114, 101}

        Dim plainText As String = Form1.txtPlaintext.Text
        plainText = plainText.Replace("'", "")
        plainText = plainText.Replace("""", "")
        plainText = plainText.Replace("…", "")
        Dim PlainTextByteArray(plainText.Length) As Byte
        For i As Integer = 0 To (plainText.Length - 1)
            PlainTextByteArray(i) = CByte(AscW(plainText.Chars(i)))
            Application.DoEvents()
        Next
        Dim PicAndText(PicBytes + plainText.Length + SentinelString.Length) As Byte
        For t As Long = 0 To (PicBytes - 1)
            PicAndText(t) = PicByteArray(t)
        Next
        Dim count As Integer = 0
        For r As Long = PicBytes To (PicBytes + (SentinelString.Length) - 1)
            PicAndText(r) = SentinelString(count)
            count += 1
        Next
        count = 0
        For q As Long = (PicBytes + SentinelString.Length) To (PicBytes + SentinelString.Length + plainText.Length - 1)
            PicAndText(q) = PlainTextByteArray(count)
            count += 1
        Next
        With Form1.buildPic
            .Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif"
            Select Case picBuffer.Extension
                Case ".jpg"
                    .FilterIndex = 1
                Case ".bmp"
                    .FilterIndex = 2
                Case ".gif"
                    .FilterIndex = 3
            End Select
            .FileName = picBuffer.Name
            .Title = "Save Stegg'd Image File As"
            .ShowDialog()
        End With
        If Form1.buildPic.FileName <> "" Then
            Dim NewFileName As String = Form1.buildPic.FileName
            'If Not NewFileName Like "*" & picBuffer.Extension Then NewFileName = NewFileName & "." & picBuffer.Extension
            My.Computer.FileSystem.WriteAllBytes(NewFileName, PicAndText, False)
        End If
    End Sub

    Public Shared Sub RecoverSteggedText(picFileStream As System.IO.FileStream, picBuffer As System.IO.FileInfo)
        Try
            Dim PicBytes As Long = picFileStream.Length
            Dim PicExt As String = picBuffer.Extension
            Dim PicByteArray(PicBytes) As Byte
            picFileStream.Read(PicByteArray, 0, PicBytes)
            Dim SentinelString() As Byte = {73, 116, 83, 116, 97, 114, 116, 115, 72, 101, 114, 101}
            Dim OutterSearch, InnerSearch, StopSearch As Boolean
            OutterSearch = True
            InnerSearch = True
            StopSearch = False
            Dim count As Long = 0
            Dim leftCounter As Long
            Dim rightCounter As Integer
            leftCounter = 0
            rightCounter = 0
            Do While (count < (PicBytes - SentinelString.Length) And StopSearch = False)
                If (PicByteArray(count) = SentinelString(0)) Then
                    leftCounter = count + 1
                    rightCounter = 1
                    InnerSearch = True
                    Do While (InnerSearch = True) And (rightCounter < SentinelString.Length) _
                And (leftCounter < PicByteArray.Length)
                        If (PicByteArray(leftCounter) = SentinelString(rightCounter)) Then
                            rightCounter += 1
                            leftCounter += 1
                            If (rightCounter = (SentinelString.Length - 1)) Then
                                StopSearch = True
                            End If
                        Else
                            InnerSearch = False
                            count += 1
                        End If
                    Loop
                Else
                    count += 1
                End If
            Loop
            If StopSearch = True Then
                'leftCounter contains the starting string that is being retrieved
                Do While (leftCounter < PicBytes)
                    'Bytes need to be converted to an integer 
                    'then to an unicode character which will be the plaintext
                    Form1.updateTxtRecoveredTextSafe(Form1.txtRecoveredText.Text & ChrW(CInt(PicByteArray(leftCounter))))
                    'Form1.txtRecoveredText.AppendText(ChrW(CInt(PicByteArray(leftCounter))))
                    leftCounter += 1
                Loop
            Else
                Form1.updateTxtRecoveredTextSafe("The Picture does not contain any text")
            End If
        Catch ex As Exception
            Form1.updateTxtRecoveredTextSafe("The picture does not contain any text and/or the tool was not able to read it")
        End Try
    End Sub
End Class
