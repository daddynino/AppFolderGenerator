<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TaxFolderGenerator
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
        Me.LblSourceFolder = New System.Windows.Forms.Label()
        Me.TxtSourceLocation = New System.Windows.Forms.TextBox()
        Me.LstYears = New System.Windows.Forms.ListBox()
        Me.LblYears = New System.Windows.Forms.Label()
        Me.BtnSelectSource = New System.Windows.Forms.Button()
        Me.BtnGenerate = New System.Windows.Forms.Button()
        Me.BtnDefaults = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.LblSubfolderNotice = New System.Windows.Forms.Label()
        Me.BtnAbout = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblSourceFolder
        '
        Me.LblSourceFolder.AutoSize = True
        Me.LblSourceFolder.Location = New System.Drawing.Point(51, 30)
        Me.LblSourceFolder.Name = "LblSourceFolder"
        Me.LblSourceFolder.Size = New System.Drawing.Size(79, 15)
        Me.LblSourceFolder.TabIndex = 0
        Me.LblSourceFolder.Text = "Source Folder"
        '
        'TxtSourceLocation
        '
        Me.TxtSourceLocation.Location = New System.Drawing.Point(51, 48)
        Me.TxtSourceLocation.Name = "TxtSourceLocation"
        Me.TxtSourceLocation.Size = New System.Drawing.Size(277, 23)
        Me.TxtSourceLocation.TabIndex = 1
        '
        'LstYears
        '
        Me.LstYears.FormattingEnabled = True
        Me.LstYears.ItemHeight = 15
        Me.LstYears.Location = New System.Drawing.Point(146, 120)
        Me.LstYears.Name = "LstYears"
        Me.LstYears.Size = New System.Drawing.Size(140, 169)
        Me.LstYears.TabIndex = 3
        '
        'LblYears
        '
        Me.LblYears.AutoSize = True
        Me.LblYears.Location = New System.Drawing.Point(146, 98)
        Me.LblYears.Name = "LblYears"
        Me.LblYears.Size = New System.Drawing.Size(63, 15)
        Me.LblYears.TabIndex = 3
        Me.LblYears.Text = "Select Year"
        '
        'BtnSelectSource
        '
        Me.BtnSelectSource.Location = New System.Drawing.Point(334, 47)
        Me.BtnSelectSource.Name = "BtnSelectSource"
        Me.BtnSelectSource.Size = New System.Drawing.Size(75, 23)
        Me.BtnSelectSource.TabIndex = 2
        Me.BtnSelectSource.Text = "&Select"
        Me.BtnSelectSource.UseVisualStyleBackColor = True
        '
        'BtnGenerate
        '
        Me.BtnGenerate.Location = New System.Drawing.Point(146, 295)
        Me.BtnGenerate.Name = "BtnGenerate"
        Me.BtnGenerate.Size = New System.Drawing.Size(140, 23)
        Me.BtnGenerate.TabIndex = 4
        Me.BtnGenerate.Text = "&Generate"
        Me.BtnGenerate.UseVisualStyleBackColor = True
        '
        'BtnDefaults
        '
        Me.BtnDefaults.Location = New System.Drawing.Point(146, 339)
        Me.BtnDefaults.Name = "BtnDefaults"
        Me.BtnDefaults.Size = New System.Drawing.Size(140, 23)
        Me.BtnDefaults.TabIndex = 5
        Me.BtnDefaults.Text = "Restore &Defaults"
        Me.BtnDefaults.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(146, 364)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(140, 23)
        Me.BtnExit.TabIndex = 6
        Me.BtnExit.Text = "E&xit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'LblSubfolderNotice
        '
        Me.LblSubfolderNotice.AutoSize = True
        Me.LblSubfolderNotice.Location = New System.Drawing.Point(56, 77)
        Me.LblSubfolderNotice.Name = "LblSubfolderNotice"
        Me.LblSubfolderNotice.Size = New System.Drawing.Size(259, 15)
        Me.LblSubfolderNotice.TabIndex = 8
        Me.LblSubfolderNotice.Text = "A subfolder of \TaxReturns\XXXX will be created"
        '
        'BtnAbout
        '
        Me.BtnAbout.FlatAppearance.BorderSize = 0
        Me.BtnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAbout.Location = New System.Drawing.Point(399, 395)
        Me.BtnAbout.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnAbout.Name = "BtnAbout"
        Me.BtnAbout.Size = New System.Drawing.Size(50, 26)
        Me.BtnAbout.TabIndex = 9
        Me.BtnAbout.Text = "&About"
        Me.BtnAbout.UseVisualStyleBackColor = True
        '
        'TaxFolderGenerator
        '
        Me.AcceptButton = Me.BtnSelectSource
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(446, 420)
        Me.Controls.Add(Me.BtnAbout)
        Me.Controls.Add(Me.LblSubfolderNotice)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnDefaults)
        Me.Controls.Add(Me.BtnGenerate)
        Me.Controls.Add(Me.BtnSelectSource)
        Me.Controls.Add(Me.LblYears)
        Me.Controls.Add(Me.LstYears)
        Me.Controls.Add(Me.TxtSourceLocation)
        Me.Controls.Add(Me.LblSourceFolder)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "TaxFolderGenerator"
        Me.Text = "Tax Folder Generator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblSourceFolder As Label
    Friend WithEvents TxtSourceLocation As TextBox
    Friend WithEvents LstYears As ListBox
    Friend WithEvents LblYears As Label
    Friend WithEvents BtnSelectSource As Button
    Friend WithEvents BtnGenerate As Button
    Friend WithEvents BtnDefaults As Button
    Friend WithEvents BtnExit As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents LblSubfolderNotice As Label
    Friend WithEvents BtnAbout As Button
End Class
