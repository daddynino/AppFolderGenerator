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
        LblSourceFolder = New Label()
        TxtSourceLocation = New TextBox()
        BtnSelectSource = New Button()
        BtnGenerate = New Button()
        BtnDefaults = New Button()
        FolderBrowserDialog1 = New FolderBrowserDialog()
        BtnAbout = New Button()
        Panel1 = New Panel()
        LblVersion = New Label()
        BtnExit = New Button()
        Panel2 = New Panel()
        LblXToClose = New Label()
        LblTitle = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' LblSourceFolder
        ' 
        LblSourceFolder.AutoSize = True
        LblSourceFolder.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        LblSourceFolder.ForeColor = Color.White
        LblSourceFolder.Location = New Point(32, 12)
        LblSourceFolder.Name = "LblSourceFolder"
        LblSourceFolder.Size = New Size(116, 25)
        LblSourceFolder.TabIndex = 0
        LblSourceFolder.Text = "Repo Folder:"
        ' 
        ' TxtSourceLocation
        ' 
        TxtSourceLocation.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TxtSourceLocation.Location = New Point(14, 46)
        TxtSourceLocation.Name = "TxtSourceLocation"
        TxtSourceLocation.Size = New Size(277, 29)
        TxtSourceLocation.TabIndex = 1
        ' 
        ' BtnSelectSource
        ' 
        BtnSelectSource.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        BtnSelectSource.Location = New Point(162, 9)
        BtnSelectSource.Name = "BtnSelectSource"
        BtnSelectSource.Size = New Size(129, 31)
        BtnSelectSource.TabIndex = 2
        BtnSelectSource.Text = "&Select"
        BtnSelectSource.UseVisualStyleBackColor = True
        ' 
        ' BtnGenerate
        ' 
        BtnGenerate.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        BtnGenerate.Location = New Point(14, 81)
        BtnGenerate.Name = "BtnGenerate"
        BtnGenerate.Size = New Size(129, 31)
        BtnGenerate.TabIndex = 4
        BtnGenerate.Text = "&Generate"
        BtnGenerate.UseVisualStyleBackColor = True
        ' 
        ' BtnDefaults
        ' 
        BtnDefaults.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        BtnDefaults.Location = New Point(162, 81)
        BtnDefaults.Name = "BtnDefaults"
        BtnDefaults.Size = New Size(129, 31)
        BtnDefaults.TabIndex = 5
        BtnDefaults.Text = "&Defaults"
        BtnDefaults.UseVisualStyleBackColor = True
        ' 
        ' BtnAbout
        ' 
        BtnAbout.FlatAppearance.BorderSize = 0
        BtnAbout.FlatStyle = FlatStyle.Flat
        BtnAbout.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        BtnAbout.ForeColor = Color.White
        BtnAbout.Location = New Point(43, 117)
        BtnAbout.Margin = New Padding(0)
        BtnAbout.Name = "BtnAbout"
        BtnAbout.Size = New Size(77, 32)
        BtnAbout.TabIndex = 9
        BtnAbout.Text = "&About"
        BtnAbout.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(LblVersion)
        Panel1.Controls.Add(BtnExit)
        Panel1.Controls.Add(LblSourceFolder)
        Panel1.Controls.Add(BtnAbout)
        Panel1.Controls.Add(TxtSourceLocation)
        Panel1.Controls.Add(BtnSelectSource)
        Panel1.Controls.Add(BtnDefaults)
        Panel1.Controls.Add(BtnGenerate)
        Panel1.Location = New Point(12, 49)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(306, 206)
        Panel1.TabIndex = 10
        ' 
        ' LblVersion
        ' 
        LblVersion.AutoSize = True
        LblVersion.Dock = DockStyle.Bottom
        LblVersion.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        LblVersion.ForeColor = Color.White
        LblVersion.Location = New Point(0, 181)
        LblVersion.Name = "LblVersion"
        LblVersion.Size = New Size(44, 25)
        LblVersion.TabIndex = 11
        LblVersion.Text = "Ver:"
        ' 
        ' BtnExit
        ' 
        BtnExit.FlatAppearance.BorderSize = 0
        BtnExit.FlatStyle = FlatStyle.Flat
        BtnExit.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        BtnExit.ForeColor = Color.White
        BtnExit.Location = New Point(185, 117)
        BtnExit.Margin = New Padding(0)
        BtnExit.Name = "BtnExit"
        BtnExit.Size = New Size(77, 32)
        BtnExit.TabIndex = 10
        BtnExit.Text = "E&xit"
        BtnExit.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Green
        Panel2.Controls.Add(LblXToClose)
        Panel2.Controls.Add(LblTitle)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(328, 43)
        Panel2.TabIndex = 11
        ' 
        ' LblXToClose
        ' 
        LblXToClose.AutoSize = True
        LblXToClose.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        LblXToClose.ForeColor = Color.White
        LblXToClose.Location = New Point(295, 8)
        LblXToClose.Name = "LblXToClose"
        LblXToClose.Size = New Size(23, 23)
        LblXToClose.TabIndex = 1
        LblXToClose.Text = "&X"
        ' 
        ' LblTitle
        ' 
        LblTitle.AutoSize = True
        LblTitle.Font = New Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        LblTitle.ForeColor = Color.White
        LblTitle.Location = New Point(11, 12)
        LblTitle.Name = "LblTitle"
        LblTitle.Size = New Size(213, 22)
        LblTitle.TabIndex = 0
        LblTitle.Text = "App Folder Generator"
        ' 
        ' AppFolderGenerator
        ' 
        AcceptButton = BtnSelectSource
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ClientSize = New Size(328, 264)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        Name = "AppFolderGenerator"
        StartPosition = FormStartPosition.CenterScreen
        Text = "App Folder Generator"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents LblSourceFolder As Label
    Friend WithEvents TxtSourceLocation As TextBox
    Friend WithEvents BtnSelectSource As Button
    Friend WithEvents BtnGenerate As Button
    Friend WithEvents BtnDefaults As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents BtnAbout As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LblTitle As Label
    Friend WithEvents LblXToClose As Label
    Friend WithEvents BtnExit As Button
    Friend WithEvents LblVersion As Label
End Class
