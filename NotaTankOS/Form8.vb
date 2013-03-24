Imports System.IO
Imports System.Net
Imports System.Web
Imports System.Math
Public Class Form8

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim a As String = TextBox1.Text
        Dim c As String = a + " -n 1 -l 65500"

        Do
            Shell(c)
        Loop
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class