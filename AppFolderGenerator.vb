Imports System.IO

Public Class AppFolderGenerator
    Dim dragging As Boolean
    Dim startPoint As Point
    Private Sub AppFolderGenerator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtSourceLocation.Text = GetDocLocation()
        Me.LblVersion.Text = String.Format("Ver: {0}", My.Application.Info.Version.ToString)
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
            Using frm As New FolderBrowserDialog
                If frm.ShowDialog(Me) = DialogResult.OK Then
                    'MessageBox.Show(Me, frm.Folder)
                    TxtSourceLocation.Text = frm.SelectedPath
                End If
            End Using
        Catch ex As Exception
            ' Handle the exception (display an error message, log the error, etc.)
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Throw
        End Try
    End Sub

    Private Sub BtnGenerate_Click(sender As Object, e As EventArgs) Handles BtnGenerate.Click
        Dim fullpath = TxtSourceLocation.Text

        ' Check if FullPath is a valid path
        If String.IsNullOrWhiteSpace(fullpath) OrElse Not Path.IsPathRooted(fullpath) Then
            MessageBox.Show("Invalid path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            ' List of folders to create
            Dim foldersToCreate As String() = {"Backup", "Config", "Data", "Docs", "Forms", "Icons", "Images", "Libs", "Modules", "SrcFiles"}

            ' Create each folder if it doesn't exist
            For Each folderName In foldersToCreate
                Dim folderPath = Path.Combine(fullpath, folderName)
                If Not Directory.Exists(folderPath) Then
                    Directory.CreateDirectory(folderPath)
                End If
            Next

            MessageBox.Show("Folders created successfully." & vbCrLf & "You're now ready to start developing in " & fullpath, "Success")
        Catch ex As Exception
            MessageBox.Show("Error creating folders: " & vbCrLf & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Throw
        End Try
    End Sub


    Private Sub BtnAbout_Click(sender As Object, e As EventArgs) Handles BtnAbout.Click
        Try
            Using aboutbox As New AboutAFG()
                aboutbox.ShowDialog()
            End Using
        Catch ex As Exception
            ' Handle unexpected errors
            MessageBox.Show($"An error occurred while opening the About box: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Throw
        End Try
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles LblXToClose.Click
        Me.Close()
    End Sub

    Private Sub AppFolderGenerator_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        If e.Button = MouseButtons.Left Then
            dragging = True
            startPoint = New Point(e.X, e.Y)
        End If
    End Sub

    Private Sub AppFolderGenerator_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If dragging Then
            Dim p As Point = Me.PointToScreen(New Point(e.X, e.Y))
            Me.Location = New Point(p.X - startPoint.X, p.Y - startPoint.Y)
        End If
    End Sub

    Private Sub AppFolderGenerator_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        If e.Button = MouseButtons.Left Then
            dragging = False
        End If
    End Sub

    Private Sub Panel2_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel2.MouseDown
        If e.Button = MouseButtons.Left Then
            dragging = True
            startPoint = New Point(e.X, e.Y)
        End If
    End Sub

    Private Sub Panel2_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel2.MouseMove
        If dragging Then
            Dim p As Point = Me.PointToScreen(New Point(e.X, e.Y))
            Me.Location = New Point(p.X - startPoint.X, p.Y - startPoint.Y)
        End If
    End Sub

    Private Sub Panel2_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel2.MouseUp
        If e.Button = MouseButtons.Left Then
            dragging = False
        End If
    End Sub

    Private Sub LblTitle_MouseDown(sender As Object, e As MouseEventArgs) Handles LblTitle.MouseDown
        If e.Button = MouseButtons.Left Then
            dragging = True
            startPoint = New Point(e.X, e.Y)
        End If
    End Sub

    Private Sub LblTitle_MouseMove(sender As Object, e As MouseEventArgs) Handles LblTitle.MouseMove
        If dragging Then
            Dim p As Point = Me.PointToScreen(New Point(e.X, e.Y))
            Me.Location = New Point(p.X - startPoint.X, p.Y - startPoint.Y)
        End If
    End Sub

    Private Sub LblTitle_MouseUp(sender As Object, e As MouseEventArgs) Handles LblTitle.MouseUp
        If e.Button = MouseButtons.Left Then
            dragging = False
        End If
    End Sub
End Class