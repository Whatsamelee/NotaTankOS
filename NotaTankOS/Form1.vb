Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = My.Settings.Username And TextBox2.Text = My.Settings.Password Then
            Form2.Show()
            Me.Close()
        Else
            MsgBox("Username / Password incorrect")
        End If

           End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form7.Show()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.Username = Nothing And My.Settings.Password = Nothing Then
            MsgBox("Please Register before using.")
            Form7.Show()
            Me.Close()
        End If
    End Sub
End Class
