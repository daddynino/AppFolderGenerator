Public NotInheritable Class AboutTFG

    Dim dragging As Boolean
    Dim startPoint As Point

    Const AppTitle = "App Folder Generator"
    Const Description = "Generates subfolders in a chosen repo folder"
    Private Sub AboutTFG_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Set the title of the form.
        Me.Text = String.Format("About {0}", AppTitle)

        Me.TxtProductName.Text = AppTitle
        Me.TxtVersion.Text = String.Format("Version {0}", My.Application.Info.Version.ToString)
        Me.TxtCopyright.Text = "© 2024 Neil Saunders"
        Me.TextBoxDescription.Text = "What it does..." & vbCrLf & vbCrLf & Description
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub

    Private Sub LblXToClose_Click(sender As Object, e As EventArgs) Handles LblXToClose.Click
        Me.Close()
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
