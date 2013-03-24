Imports System.Net
Imports System.IO
Imports System.Resources

Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label1.Text = TimeOfDay
        Button10.Hide()
        If My.Settings.RegKey = Nothing Then
            My.Computer.Audio.Play(My.Resources.NotaOS_Theme, AudioPlayMode.Background)
            Button2.Enabled = False
            Button12.Enabled = False
            Button11.Enabled = False
            Button13.Enabled = False
        Else
            Me.Text = "Home"
            My.Computer.Audio.Play(My.Resources.Wat, AudioPlayMode.BackgroundLoop)
            Button2.Enabled = True
            Button13.Enabled = True
            Button11.Enabled = True
            Button12.Enabled = True
        End If
        

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form4.Show()


    End Sub

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim Hostname As IPHostEntry = Dns.GetHostEntry(TextBox1.Text)
        Dim ip As IPAddress() = Hostname.AddressList
        MsgBox(ip(0).ToString)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form5.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        If NetworkInformation.NetworkInterface.GetIsNetworkAvailable Then
            MsgBox("Internet connection detected")
        Else
            MsgBox("No internet connection detected")
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form10.Show()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        If Me.Text = "Home [Unactivated]" Then
            Form6.Show()
        Else
            MsgBox("Your version of NotaTank OS is already registered!")
        End If
    End Sub

    Private Function req() As Object
        Throw New NotImplementedException
    End Function

    Private Sub Button6_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs)
        MsgBox(TimeOfDay)


    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        My.Settings.Username = Nothing
        My.Settings.Password = Nothing
            My.Settings.Save()
            MsgBox("User successfully deleted.")
        My.Computer.Audio.Stop()
        My.Settings.Save()
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        My.Computer.Audio.Stop()
        My.Settings.Save()
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button9_Click_1(sender As Object, e As EventArgs) Handles Button9.Click
        Call Shell("Shutdown /s")

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Form8.Show()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Form9.Show()

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        My.Computer.Audio.Stop()

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If Me.Text = "Home [Unactivated]" Then
            My.Computer.Audio.Play(My.Resources.NotaOS_Theme, AudioPlayMode.Background)
        Else
            My.Computer.Audio.Play(My.Resources.Wat, AudioPlayMode.BackgroundLoop)
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        
    End Sub

    Private Sub Label1_TextChanged(sender As Object, e As EventArgs) Handles Label1.TextChanged

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = TimeOfDay

    End Sub

    Private Sub Button6_Click_2(sender As Object, e As EventArgs) Handles Button6.Click
        MsgBox("Thanks for using NotaTank")
        End

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        MsgBox("Registration successfully removed.")
        My.Settings.RegKey = Nothing
        My.Settings.Save()
        My.Computer.Audio.Stop()
        Form1.Show()
        Me.Close()


    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Form11.Show()

    End Sub
End Class