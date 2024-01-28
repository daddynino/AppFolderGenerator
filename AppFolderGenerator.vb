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
        Try
            ' Attempt to get the path to the "My Documents" folder
            Dim myDocumentsPath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)

            ' Check if the directory exists before returning the path
            If Directory.Exists(myDocumentsPath) Then
                Return myDocumentsPath
            Else
                ' If the directory doesn't exist, handle the error appropriately
                Console.WriteLine("Error: My Documents folder does not exist.")
                ' You might want to log this error or take other appropriate actions
                Return String.Empty ' Or throw an exception, depending on your requirements
            End If
        Catch ex As Exception
            ' Handle any other exceptions that might occur
            Console.WriteLine("An error occurred: " & ex.Message)
            ' You might want to log this error or take other appropriate actions
            Return String.Empty ' Or throw an exception, depending on your requirements
        End Try
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
        Try
            ' Attempt to set the text of TxtSourceLocation to the path of the "My Documents" folder
            TxtSourceLocation.Text = GetDocLocation()
        Catch ex As Exception
            ' Handle the exception (display an error message, log the error, etc.)
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnSelectSource_Click(sender As Object, e As EventArgs) Handles BtnSelectSource.Click
        Try
            Using frm As New OpenFolderDialog()
                If frm.ShowDialog(Me) = DialogResult.OK Then
                    'MessageBox.Show(Me, frm.Folder)
                    TxtSourceLocation.Text = frm.Folder
                End If
            End Using
        Catch ex As Exception
            ' Handle the exception (display an error message, log the error, etc.)
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnGenerate_Click(sender As Object, e As EventArgs) Handles BtnGenerate.Click
        Dim FullPath = TxtSourceLocation.Text

        ' Check if FullPath is a valid path
        If String.IsNullOrWhiteSpace(FullPath) OrElse Not IO.Path.IsPathRooted(FullPath) Then
            MessageBox.Show("Invalid path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            ' Check if the directories already exist
            If Not Directory.Exists(FullPath & "\Data") Then
                IO.Directory.CreateDirectory(FullPath & "\Data")
            End If

            If Not Directory.Exists(FullPath & "\Forms") Then
                IO.Directory.CreateDirectory(FullPath & "\Forms")
            End If

            If Not Directory.Exists(FullPath & "\Images") Then
                IO.Directory.CreateDirectory(FullPath & "\Images")
            End If

            If Not Directory.Exists(FullPath & "\Modules") Then
                IO.Directory.CreateDirectory(FullPath & "\Modules")
            End If

            If Not Directory.Exists(FullPath & "\SrcFiles") Then
                IO.Directory.CreateDirectory(FullPath & "\SrcFiles")
            End If

            MessageBox.Show("Folders created successfully." & vbCrLf & "You're now ready to start developing in " & FullPath, "Success")
        Catch ex As Exception
            MessageBox.Show("Error creating folders: " & vbCrLf & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub




    Private Sub BtnAbout_Click(sender As Object, e As EventArgs) Handles BtnAbout.Click
        Try
            Using aboutbox As New AboutTFG()
                aboutbox.ShowDialog()
            End Using
        Catch ex As Exception
            ' Handle unexpected errors
            MessageBox.Show($"An error occurred while opening the About box: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
