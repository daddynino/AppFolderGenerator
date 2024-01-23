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
        BtnExit = New Button()
        FolderBrowserDialog1 = New FolderBrowserDialog()
        BtnAbout = New Button()
        SuspendLayout()
        ' 
        ' LblSourceFolder
        ' 
        LblSourceFolder.AutoSize = True
        LblSourceFolder.Location = New Point(51, 30)
        LblSourceFolder.Name = "LblSourceFolder"
        LblSourceFolder.Size = New Size(79, 15)
        LblSourceFolder.TabIndex = 0
        LblSourceFolder.Text = "Source Folder"
        ' 
        ' TxtSourceLocation
        ' 
        TxtSourceLocation.Location = New Point(51, 48)
        TxtSourceLocation.Name = "TxtSourceLocation"
        TxtSourceLocation.Size = New Size(277, 23)
        TxtSourceLocation.TabIndex = 1
        ' 
        ' BtnSelectSource
        ' 
        BtnSelectSource.Location = New Point(334, 47)
        BtnSelectSource.Name = "BtnSelectSource"
        BtnSelectSource.Size = New Size(75, 23)
        BtnSelectSource.TabIndex = 2
        BtnSelectSource.Text = "&Select"
        BtnSelectSource.UseVisualStyleBackColor = True
        ' 
        ' BtnGenerate
        ' 
        BtnGenerate.Location = New Point(146, 295)
        BtnGenerate.Name = "BtnGenerate"
        BtnGenerate.Size = New Size(140, 23)
        BtnGenerate.TabIndex = 4
        BtnGenerate.Text = "&Generate"
        BtnGenerate.UseVisualStyleBackColor = True
        ' 
        ' BtnDefaults
        ' 
        BtnDefaults.Location = New Point(146, 339)
        BtnDefaults.Name = "BtnDefaults"
        BtnDefaults.Size = New Size(140, 23)
        BtnDefaults.TabIndex = 5
        BtnDefaults.Text = "Restore &Defaults"
        BtnDefaults.UseVisualStyleBackColor = True
        ' 
        ' BtnExit
        ' 
        BtnExit.Location = New Point(146, 364)
        BtnExit.Name = "BtnExit"
        BtnExit.Size = New Size(140, 23)
        BtnExit.TabIndex = 6
        BtnExit.Text = "E&xit"
        BtnExit.UseVisualStyleBackColor = True
        ' 
        ' BtnAbout
        ' 
        BtnAbout.FlatAppearance.BorderSize = 0
        BtnAbout.FlatStyle = FlatStyle.Flat
        BtnAbout.Location = New Point(399, 395)
        BtnAbout.Margin = New Padding(0)
        BtnAbout.Name = "BtnAbout"
        BtnAbout.Size = New Size(50, 26)
        BtnAbout.TabIndex = 9
        BtnAbout.Text = "&About"
        BtnAbout.UseVisualStyleBackColor = True
        ' 
        ' AppFolderGenerator
        ' 
        AcceptButton = BtnSelectSource
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(446, 420)
        Controls.Add(BtnAbout)
        Controls.Add(BtnExit)
        Controls.Add(BtnDefaults)
        Controls.Add(BtnGenerate)
        Controls.Add(BtnSelectSource)
        Controls.Add(TxtSourceLocation)
        Controls.Add(LblSourceFolder)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "AppFolderGenerator"
        Text = "App Folder Generator"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents LblSourceFolder As Label
    Friend WithEvents TxtSourceLocation As TextBox
    Friend WithEvents BtnSelectSource As Button
    Friend WithEvents BtnGenerate As Button
    Friend WithEvents BtnDefaults As Button
    Friend WithEvents BtnExit As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents BtnAbout As Button
End Class
