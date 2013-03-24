Imports System.Data.OleDb
Imports System.Security.Cryptography
Imports System.IO

Public Class Form6

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "ae310-391sk-dlzkm-al039" Then
            My.Settings.RegKey = TextBox1.Text

            My.Settings.Save()
            Form2.Text = "Home"
            MsgBox("Thank you for purchasing Notatank OS!")
            Form2.LinkLabel2.Hide()
            Form2.Button2.Enabled = True
            Form2.Button12.Enabled = True
            Form2.Button11.Enabled = True
            Form2.Button13.Enabled = True
            My.Computer.Audio.Play(My.Resources.Wat, AudioPlayMode.BackgroundLoop)
            Me.Close()
        ElseIf TextBox1.Text = "IP3tQ-rMI5R-Ds2Uw-1uu61" Then
            My.Settings.RegKey = TextBox1.Text

            My.Settings.Save()
            Form2.Text = "Home"
            MsgBox("Thank you for purchasing Notatank OS!")
            Form2.LinkLabel2.Hide()
            Form2.Button2.Enabled = True
            Form2.Button12.Enabled = True
            Form2.Button11.Enabled = True
            Form2.Button13.Enabled = True
            My.Computer.Audio.Play(My.Resources.Wat, AudioPlayMode.BackgroundLoop)
            Me.Close()
        Else
            MsgBox("Serial Key Invalid.")
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If My.Settings.RegKey = "" Then
            MsgBox("No former registration key found.")
        Else
            MsgBox("Your key is: " & My.Settings.RegKey)
        End If
    End Sub
End Class