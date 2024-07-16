<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutAFG
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents TextBoxDescription As System.Windows.Forms.TextBox

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AboutAFG))
        LogoPictureBox = New PictureBox()
        TxtProductName = New TextBox()
        TxtVersion = New TextBox()
        TxtCopyright = New TextBox()
        TextBoxDescription = New TextBox()
        Panel2 = New Panel()
        LblXToClose = New Label()
        LblTitle = New Label()
        Panel1 = New Panel()
        BtnExit = New Button()
        CType(LogoPictureBox, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' LogoPictureBox
        ' 
        LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), Image)
        LogoPictureBox.Location = New Point(0, 43)
        LogoPictureBox.Margin = New Padding(4, 3, 4, 3)
        LogoPictureBox.Name = "LogoPictureBox"
        LogoPictureBox.Size = New Size(149, 286)
        LogoPictureBox.SizeMode = PictureBoxSizeMode.CenterImage
        LogoPictureBox.TabIndex = 0
        LogoPictureBox.TabStop = False
        ' 
        ' TxtProductName
        ' 
        TxtProductName.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        TxtProductName.BorderStyle = BorderStyle.None
        TxtProductName.Font = New Font("Segoe UI", 14.25F)
        TxtProductName.ForeColor = Color.White
        TxtProductName.Location = New Point(155, 52)
        TxtProductName.Margin = New Padding(7, 3, 4, 3)
        TxtProductName.Multiline = True
        TxtProductName.Name = "TxtProductName"
        TxtProductName.ReadOnly = True
        TxtProductName.Size = New Size(309, 24)
        TxtProductName.TabIndex = 1
        TxtProductName.TabStop = False
        TxtProductName.Text = "Product Name:"
        ' 
        ' TxtVersion
        ' 
        TxtVersion.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        TxtVersion.BorderStyle = BorderStyle.None
        TxtVersion.Font = New Font("Segoe UI", 14.25F)
        TxtVersion.ForeColor = Color.White
        TxtVersion.Location = New Point(155, 82)
        TxtVersion.Margin = New Padding(7, 3, 4, 3)
        TxtVersion.Multiline = True
        TxtVersion.Name = "TxtVersion"
        TxtVersion.ReadOnly = True
        TxtVersion.Size = New Size(309, 24)
        TxtVersion.TabIndex = 2
        TxtVersion.TabStop = False
        TxtVersion.Text = "Version:"
        ' 
        ' TxtCopyright
        ' 
        TxtCopyright.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        TxtCopyright.BorderStyle = BorderStyle.None
        TxtCopyright.Font = New Font("Segoe UI", 14.25F)
        TxtCopyright.ForeColor = Color.White
        TxtCopyright.Location = New Point(155, 112)
        TxtCopyright.Margin = New Padding(7, 3, 4, 3)
        TxtCopyright.Multiline = True
        TxtCopyright.Name = "TxtCopyright"
        TxtCopyright.ReadOnly = True
        TxtCopyright.Size = New Size(309, 24)
        TxtCopyright.TabIndex = 3
        TxtCopyright.TabStop = False
        TxtCopyright.Text = "Copyright:"
        ' 
        ' TextBoxDescription
        ' 
        TextBoxDescription.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        TextBoxDescription.BorderStyle = BorderStyle.None
        TextBoxDescription.Font = New Font("Segoe UI", 14.25F)
        TextBoxDescription.ForeColor = Color.White
        TextBoxDescription.Location = New Point(155, 152)
        TextBoxDescription.Margin = New Padding(7, 3, 4, 3)
        TextBoxDescription.Multiline = True
        TextBoxDescription.Name = "TextBoxDescription"
        TextBoxDescription.ReadOnly = True
        TextBoxDescription.Size = New Size(303, 135)
        TextBoxDescription.TabIndex = 0
        TextBoxDescription.TabStop = False
        TextBoxDescription.Text = "What it does..." & vbCrLf & vbCrLf & "Generates subfolders in a chosen repo folder."
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.DarkGreen
        Panel2.Controls.Add(LblXToClose)
        Panel2.Controls.Add(LblTitle)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Margin = New Padding(0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(458, 43)
        Panel2.TabIndex = 12
        ' 
        ' LblXToClose
        ' 
        LblXToClose.AutoSize = True
        LblXToClose.BackColor = Color.DarkGreen
        LblXToClose.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblXToClose.ForeColor = Color.White
        LblXToClose.Location = New Point(430, 11)
        LblXToClose.Name = "LblXToClose"
        LblXToClose.Size = New Size(24, 24)
        LblXToClose.TabIndex = 1
        LblXToClose.Text = "&X"
        ' 
        ' LblTitle
        ' 
        LblTitle.AutoSize = True
        LblTitle.Font = New Font("Microsoft Sans Serif", 14.25F)
        LblTitle.ForeColor = Color.White
        LblTitle.Location = New Point(11, 12)
        LblTitle.Name = "LblTitle"
        LblTitle.Size = New Size(194, 24)
        LblTitle.TabIndex = 0
        LblTitle.Text = "App Folder Generator"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkGreen
        Panel1.Location = New Point(194, 145)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(223, 5)
        Panel1.TabIndex = 13
        ' 
        ' BtnExit
        ' 
        BtnExit.BackColor = Color.DarkGreen
        BtnExit.FlatAppearance.BorderSize = 0
        BtnExit.FlatAppearance.MouseOverBackColor = Color.Green
        BtnExit.FlatStyle = FlatStyle.Flat
        BtnExit.Font = New Font("Segoe UI", 14.25F)
        BtnExit.ForeColor = Color.White
        BtnExit.Location = New Point(325, 290)
        BtnExit.Margin = New Padding(0)
        BtnExit.Name = "BtnExit"
        BtnExit.Size = New Size(129, 32)
        BtnExit.TabIndex = 10
        BtnExit.Text = "E&xit"
        BtnExit.UseVisualStyleBackColor = False
        ' 
        ' AboutAFG
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(458, 329)
        Controls.Add(BtnExit)
        Controls.Add(Panel1)
        Controls.Add(TextBoxDescription)
        Controls.Add(TxtCopyright)
        Controls.Add(TxtVersion)
        Controls.Add(TxtProductName)
        Controls.Add(LogoPictureBox)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 3, 4, 3)
        MaximizeBox = False
        MinimizeBox = False
        Name = "AboutAFG"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "About App Folder Generator"
        CType(LogoPictureBox, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents LblXToClose As Label
    Friend WithEvents LblTitle As Label
    Friend WithEvents TxtProductName As TextBox
    Friend WithEvents TxtVersion As TextBox
    Friend WithEvents TxtCopyright As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnExit As Button

End Class
