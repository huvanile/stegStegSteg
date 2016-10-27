<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnFromFile = New System.Windows.Forms.Button()
        Me.openPic = New System.Windows.Forms.OpenFileDialog()
        Me.txtPlaintext = New System.Windows.Forms.TextBox()
        Me.txtFilename = New System.Windows.Forms.TextBox()
        Me.radAdd = New System.Windows.Forms.RadioButton()
        Me.btnDoSteg = New System.Windows.Forms.Button()
        Me.radRead = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.buildPic = New System.Windows.Forms.SaveFileDialog()
        Me.txtRecoveredText = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnFromImgur = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenTempFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(12, 37)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(377, 272)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnFromFile
        '
        Me.btnFromFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFromFile.Location = New System.Drawing.Point(12, 341)
        Me.btnFromFile.Name = "btnFromFile"
        Me.btnFromFile.Size = New System.Drawing.Size(178, 37)
        Me.btnFromFile.TabIndex = 0
        Me.btnFromFile.Text = "Load Image From File"
        Me.btnFromFile.UseVisualStyleBackColor = True
        '
        'openPic
        '
        Me.openPic.DefaultExt = "*.jpg"
        Me.openPic.Filter = "JPEG|*.jpg|Bitmap|*.bmp|GIF|*.gif"
        Me.openPic.RestoreDirectory = True
        '
        'txtPlaintext
        '
        Me.txtPlaintext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPlaintext.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlaintext.Location = New System.Drawing.Point(18, 49)
        Me.txtPlaintext.Multiline = True
        Me.txtPlaintext.Name = "txtPlaintext"
        Me.txtPlaintext.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPlaintext.Size = New System.Drawing.Size(358, 150)
        Me.txtPlaintext.TabIndex = 0
        '
        'txtFilename
        '
        Me.txtFilename.Location = New System.Drawing.Point(12, 315)
        Me.txtFilename.Name = "txtFilename"
        Me.txtFilename.ReadOnly = True
        Me.txtFilename.Size = New System.Drawing.Size(379, 20)
        Me.txtFilename.TabIndex = 7
        Me.txtFilename.TabStop = False
        '
        'radAdd
        '
        Me.radAdd.AutoSize = True
        Me.radAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radAdd.Location = New System.Drawing.Point(19, 23)
        Me.radAdd.Name = "radAdd"
        Me.radAdd.Size = New System.Drawing.Size(101, 17)
        Me.radAdd.TabIndex = 0
        Me.radAdd.TabStop = True
        Me.radAdd.Text = "Add Steg'd Text"
        Me.radAdd.UseVisualStyleBackColor = True
        '
        'btnDoSteg
        '
        Me.btnDoSteg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDoSteg.Location = New System.Drawing.Point(266, 384)
        Me.btnDoSteg.Name = "btnDoSteg"
        Me.btnDoSteg.Size = New System.Drawing.Size(123, 53)
        Me.btnDoSteg.TabIndex = 3
        Me.btnDoSteg.Text = "Proceed"
        Me.btnDoSteg.UseVisualStyleBackColor = True
        '
        'radRead
        '
        Me.radRead.AutoSize = True
        Me.radRead.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radRead.Location = New System.Drawing.Point(124, 23)
        Me.radRead.Name = "radRead"
        Me.radRead.Size = New System.Drawing.Size(108, 17)
        Me.radRead.TabIndex = 1
        Me.radRead.TabStop = True
        Me.radRead.Text = "Read Steg'd Text"
        Me.radRead.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radRead)
        Me.GroupBox1.Controls.Add(Me.radAdd)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(15, 384)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(239, 53)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Steganography Action"
        '
        'txtRecoveredText
        '
        Me.txtRecoveredText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRecoveredText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecoveredText.Location = New System.Drawing.Point(18, 233)
        Me.txtRecoveredText.Multiline = True
        Me.txtRecoveredText.Name = "txtRecoveredText"
        Me.txtRecoveredText.ReadOnly = True
        Me.txtRecoveredText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRecoveredText.Size = New System.Drawing.Size(358, 144)
        Me.txtRecoveredText.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Enter Plain Text Message Here"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 214)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(185, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Text Message Retrieved From Picture"
        '
        'btnFromImgur
        '
        Me.btnFromImgur.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFromImgur.Location = New System.Drawing.Point(197, 341)
        Me.btnFromImgur.Name = "btnFromImgur"
        Me.btnFromImgur.Size = New System.Drawing.Size(194, 37)
        Me.btnFromImgur.TabIndex = 1
        Me.btnFromImgur.Text = "Load Random Imgur Image"
        Me.btnFromImgur.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(818, 24)
        Me.MenuStrip1.TabIndex = 14
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenTempFolderToolStripMenuItem, Me.QuitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenTempFolderToolStripMenuItem
        '
        Me.OpenTempFolderToolStripMenuItem.Name = "OpenTempFolderToolStripMenuItem"
        Me.OpenTempFolderToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.OpenTempFolderToolStripMenuItem.Text = "Open Temp Folder"
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.QuitToolStripMenuItem.Text = "Quit"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtPlaintext)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtRecoveredText)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(410, 37)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(395, 400)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Secret Messages"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(818, 451)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnFromImgur)
        Me.Controls.Add(Me.btnDoSteg)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtFilename)
        Me.Controls.Add(Me.btnFromFile)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "stegSteg"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnFromFile As System.Windows.Forms.Button
    Friend WithEvents openPic As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtPlaintext As System.Windows.Forms.TextBox
    Friend WithEvents txtFilename As System.Windows.Forms.TextBox
    Friend WithEvents radAdd As System.Windows.Forms.RadioButton
    Friend WithEvents btnDoSteg As System.Windows.Forms.Button
    Friend WithEvents radRead As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents buildPic As System.Windows.Forms.SaveFileDialog
    Friend WithEvents txtRecoveredText As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnFromImgur As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenTempFolderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox2 As GroupBox
End Class
