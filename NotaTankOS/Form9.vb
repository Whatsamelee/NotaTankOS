Imports System.Math
Public Class Form9

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label2.Text = Val(TextBox1.Text ^ (1 / 3))
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label3.Text = Val(TextBox2.Text ^ (1 / 2))
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim answer As Double
        answer = TextBox3.Text - TextBox4.Text
        Label5.Text = answer
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox2.Text = ""
        Label3.Text = ""
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox3.Text = ""
        TextBox4.Text = ""
        Label5.Text = ""
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim answer As Double
        answer = TextBox10.Text * TextBox9.Text
        Label15.Text = answer
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        TextBox10.Text = ""
        TextBox9.Text = ""
        Label15.Text = ""
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim answer As Double
        answer = TextBox8.Text / TextBox7.Text
        Label12.Text = answer
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox8.Text = ""
        TextBox7.Text = ""
        Label12.Text = ""
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim answer As Double
        answer = TextBox6.Text + TextBox5.Text
        Label9.Text = answer
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox6.Text = ""
        TextBox5.Text = ""
        Label9.Text = ""
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Label2.Text = ""
        TextBox1.Text = ""
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Dim answer As Double
        answer = TextBox12.Text ^ TextBox11.Text
        Label18.Text = answer
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        TextBox12.Text = ""
        TextBox11.Text = ""
        Label18.Text = ""
    End Sub
End Class