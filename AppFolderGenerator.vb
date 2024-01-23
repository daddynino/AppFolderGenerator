Imports System.IO
Public Class AppFolderGenerator
    Private Sub AppFolderGenerator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtSourceLocation.Text = GetDocLocation()

        'GetYears()

    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Shared Function GetDocLocation() As String
        Return Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)

    End Function

    'Sub GetYears()

    '    Try
    '        Dim nowYear As Integer = Date.Now.Year
    '        Dim StartYear As Integer
    '        Dim MaxYear As Integer

    '        StartYear = nowYear - 3
    '        MaxYear = StartYear + 6

    '        While StartYear <= MaxYear
    '            LstYears.Items.Add(StartYear)
    '            StartYear += 1
    '        End While
    '        LstYears.SelectedIndex = 3 ' DEFAULTS TO CURRENT YEAR
    '    Catch ex As Exception
    '        MessageBox.Show("test" & vbCrLf & ex.Message, "Error with dates")
    '    End Try

    'End Sub

    Private Sub BtnDefaults_Click(sender As Object, e As EventArgs) Handles BtnDefaults.Click
        TxtSourceLocation.Text = GetDocLocation()
        'LstYears.Items.Clear()
        'Call GetYears()
        'LstYears.SelectedIndex = 3
    End Sub

    Private Sub BtnSelectSource_Click(sender As Object, e As EventArgs) Handles BtnSelectSource.Click
        Using frm = New OpenFolderDialog()
            If frm.ShowDialog(Me) = DialogResult.OK Then
                'MessageBox.Show(Me, frm.Folder)
                TxtSourceLocation.Text = frm.Folder
            End If
        End Using
    End Sub

    Private Sub BtnGenerate_Click(sender As Object, e As EventArgs) Handles BtnGenerate.Click
        'MessageBox.Show(LstYears.SelectedItem)
        Dim FullPath = TxtSourceLocation.Text
        'If IO.Directory.Exists(FullPath) = True Then
        'MessageBox.Show("That folder already exists")
        'Exit Sub
        'Else
        Try
            'IO.Directory.CreateDirectory(FullPath)
            IO.Directory.CreateDirectory(FullPath & "\Forms")
            IO.Directory.CreateDirectory(FullPath & "\Images")
            IO.Directory.CreateDirectory(FullPath & "\Modules")
            IO.Directory.CreateDirectory(FullPath & "\SrcFiles")

            MessageBox.Show("Folders created successfully." & vbCrLf & "You're now ready to start developing in " & FullPath, "Aye, Captain...")

        Catch ex As Exception
            MessageBox.Show("Error creating folder " & FullPath & vbCrLf & ex.Message)
        End Try
        'End If



    End Sub



    Private Sub BtnAbout_Click(sender As Object, e As EventArgs) Handles BtnAbout.Click
        Dim aboutbox As New AboutTFG
        aboutbox.Show()
    End Sub
End Class
