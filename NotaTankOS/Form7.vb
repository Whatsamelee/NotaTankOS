Public Class Form7

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.Username = TextBox1.Text
        My.Settings.Password = TextBox3.Text
        My.Settings.Save()
        MsgBox("User created, thank you.", MsgBoxStyle.Information, "Registration Successful!")
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class