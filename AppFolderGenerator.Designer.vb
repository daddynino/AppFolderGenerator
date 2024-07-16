<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AppFolderGenerator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AppFolderGenerator))
        LblSourceFolder = New Label()
        TxtSourceLocation = New TextBox()
        BtnSelectSource = New Button()
        BtnGenerate = New Button()
        BtnDefaults = New Button()
        FolderBrowserDialog1 = New FolderBrowserDialog()
        BtnAbout = New Button()
        LblVersion = New Label()
        BtnExit = New Button()
        Panel2 = New Panel()
        LblXToClose = New Label()
        LblTitle = New Label()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' LblSourceFolder
        ' 
        LblSourceFolder.AutoSize = True
        LblSourceFolder.BackColor = Color.Transparent
        LblSourceFolder.FlatStyle = FlatStyle.Popup
        LblSourceFolder.Font = New Font("Segoe UI", 14.25F)
        LblSourceFolder.ForeColor = Color.White
        LblSourceFolder.Location = New Point(59, 74)
        LblSourceFolder.Name = "LblSourceFolder"
        LblSourceFolder.Size = New Size(116, 25)
        LblSourceFolder.TabIndex = 0
        LblSourceFolder.Text = "Repo Folder:"
        ' 
        ' TxtSourceLocation
        ' 
        TxtSourceLocation.Font = New Font("Segoe UI", 12F)
        TxtSourceLocation.Location = New Point(59, 105)
        TxtSourceLocation.Name = "TxtSourceLocation"
        TxtSourceLocation.Size = New Size(277, 29)
        TxtSourceLocation.TabIndex = 1
        ' 
        ' BtnSelectSource
        ' 
        BtnSelectSource.BackColor = Color.DarkGreen
        BtnSelectSource.FlatAppearance.BorderSize = 0
        BtnSelectSource.FlatStyle = FlatStyle.Flat
        BtnSelectSource.Font = New Font("Segoe UI", 14.25F)
        BtnSelectSource.ForeColor = Color.White
        BtnSelectSource.Location = New Point(207, 68)
        BtnSelectSource.Name = "BtnSelectSource"
        BtnSelectSource.Size = New Size(129, 31)
        BtnSelectSource.TabIndex = 2
        BtnSelectSource.Text = "&Select"
        BtnSelectSource.UseVisualStyleBackColor = True
        ' 
        ' BtnGenerate
        ' 
        BtnGenerate.BackColor = Color.DarkGreen
        BtnGenerate.FlatAppearance.BorderSize = 0
        BtnGenerate.FlatStyle = FlatStyle.Flat
        BtnGenerate.Font = New Font("Segoe UI", 14.25F)
        BtnGenerate.ForeColor = Color.White
        BtnGenerate.Location = New Point(59, 140)
        BtnGenerate.Name = "BtnGenerate"
        BtnGenerate.Size = New Size(129, 31)
        BtnGenerate.TabIndex = 4
        BtnGenerate.Text = "&Generate"
        BtnGenerate.UseVisualStyleBackColor = False
        ' 
        ' BtnDefaults
        ' 
        BtnDefaults.BackColor = Color.DarkGreen
        BtnDefaults.FlatAppearance.BorderSize = 0
        BtnDefaults.FlatStyle = FlatStyle.Flat
        BtnDefaults.Font = New Font("Segoe UI", 14.25F)
        BtnDefaults.ForeColor = Color.White
        BtnDefaults.Location = New Point(207, 140)
        BtnDefaults.Name = "BtnDefaults"
        BtnDefaults.Size = New Size(129, 31)
        BtnDefaults.TabIndex = 5
        BtnDefaults.Text = "&Defaults"
        BtnDefaults.UseVisualStyleBackColor = False
        ' 
        ' BtnAbout
        ' 
        BtnAbout.BackColor = Color.DarkGreen
        BtnAbout.FlatAppearance.BorderSize = 0
        BtnAbout.FlatAppearance.MouseOverBackColor = Color.Green
        BtnAbout.FlatStyle = FlatStyle.Flat
        BtnAbout.Font = New Font("Segoe UI", 14.25F)
        BtnAbout.ForeColor = Color.White
        BtnAbout.Location = New Point(59, 176)
        BtnAbout.Margin = New Padding(0)
        BtnAbout.Name = "BtnAbout"
        BtnAbout.Size = New Size(129, 32)
        BtnAbout.TabIndex = 9
        BtnAbout.Text = "&About"
        BtnAbout.UseVisualStyleBackColor = False
        ' 
        ' LblVersion
        ' 
        LblVersion.AutoSize = True
        LblVersion.BackColor = Color.Transparent
        LblVersion.Dock = DockStyle.Bottom
        LblVersion.FlatStyle = FlatStyle.Popup
        LblVersion.Font = New Font("Segoe UI", 14.25F)
        LblVersion.ForeColor = Color.White
        LblVersion.Location = New Point(0, 240)
        LblVersion.Name = "LblVersion"
        LblVersion.Size = New Size(44, 25)
        LblVersion.TabIndex = 11
        LblVersion.Text = "Ver:"
        ' 
        ' BtnExit
        ' 
        BtnExit.BackColor = Color.DarkGreen
        BtnExit.FlatAppearance.BorderSize = 0
        BtnExit.FlatAppearance.MouseOverBackColor = Color.Green
        BtnExit.FlatStyle = FlatStyle.Flat
        BtnExit.Font = New Font("Segoe UI", 14.25F)
        BtnExit.ForeColor = Color.White
        BtnExit.Location = New Point(207, 176)
        BtnExit.Margin = New Padding(0)
        BtnExit.Name = "BtnExit"
        BtnExit.Size = New Size(129, 32)
        BtnExit.TabIndex = 10
        BtnExit.Text = "E&xit"
        BtnExit.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.DarkGreen
        Panel2.Controls.Add(LblXToClose)
        Panel2.Controls.Add(LblTitle)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(388, 43)
        Panel2.TabIndex = 11
        ' 
        ' LblXToClose
        ' 
        LblXToClose.AutoSize = True
        LblXToClose.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblXToClose.ForeColor = Color.White
        LblXToClose.Location = New Point(358, 10)
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
        ' AppFolderGenerator
        ' 
        AcceptButton = BtnSelectSource
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(388, 265)
        Controls.Add(LblVersion)
        Controls.Add(Panel2)
        Controls.Add(BtnExit)
        Controls.Add(LblSourceFolder)
        Controls.Add(BtnAbout)
        Controls.Add(BtnGenerate)
        Controls.Add(TxtSourceLocation)
        Controls.Add(BtnDefaults)
        Controls.Add(BtnSelectSource)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "AppFolderGenerator"
        StartPosition = FormStartPosition.CenterScreen
        Text = "App Folder Generator"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents LblSourceFolder As Label
    Friend WithEvents TxtSourceLocation As TextBox
    Friend WithEvents BtnSelectSource As Button
    Friend WithEvents BtnGenerate As Button
    Friend WithEvents BtnDefaults As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents BtnAbout As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LblTitle As Label
    Friend WithEvents LblXToClose As Label
    Friend WithEvents BtnExit As Button
    Friend WithEvents LblVersion As Label
End Class
