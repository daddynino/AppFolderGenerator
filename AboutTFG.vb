Public NotInheritable Class AboutTFG
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

End Class
