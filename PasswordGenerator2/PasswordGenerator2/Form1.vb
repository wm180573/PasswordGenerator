Public Class Form1
    Private Sub BtnGenerate_Click(sender As Object, e As EventArgs) Handles BtnGenerate.Click
        If txtFirstName.Text = "" Or txtSurname.Text = "" Or txtYearBorn.Text = "" Or txtStreetName.Text = "" Or txtShoeSize.Text = "" Then
            MessageBox.Show("Error, you have left one or more fields blank, please ensure that all fields are filled", "Error while compiling values")
        Else
            txtPassword.Text = txtFirstName.Text.Substring(0, 1) + Mid(txtSurname.Text, 2, 1) + Mid(txtYearBorn.Text, 3, 4) + Mid(txtFavColour.Text, 2, 3) + txtStreetName.Text.Substring(0, 3) + txtShoeSize.Text + "VB"
            MessageBox.Show("Password generated", "Values compiled successfully")
        End If

    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        txtPassword.Text = ""
        txtFirstName.Text = ""
        txtSurname.Text = ""
        txtYearBorn.Text = ""
        txtFavColour.Text = ""
        txtStreetName.Text = ""
        txtShoeSize.Text = ""
    End Sub
End Class
