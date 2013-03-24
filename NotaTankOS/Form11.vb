Public Class Form11

    Private Sub ToolStripTextBox1_Click(sender As Object, e As EventArgs) Handles ToolStripTextBox1.Click


    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub ToolStripLabel6_Click(sender As Object, e As EventArgs) Handles ToolStripLabel6.Click
        WebBrowser1.Navigate(ToolStripTextBox1.Text)
    End Sub

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub ToolStripLabel4_Click(sender As Object, e As EventArgs) Handles ToolStripLabel4.Click
        WebBrowser1.Refresh()

    End Sub

    Private Sub ToolStripLabel5_Click(sender As Object, e As EventArgs) Handles ToolStripLabel5.Click
        WebBrowser1.Navigate("http://www.google.com/")
    End Sub

    Private Sub ToolStripLabel3_Click(sender As Object, e As EventArgs) Handles ToolStripLabel3.Click
        WebBrowser1.GoForward()
    End Sub

    Private Sub ToolStripLabel2_Click(sender As Object, e As EventArgs) Handles ToolStripLabel2.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub PasteToolStripButton_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripLabel1_Click_1(sender As Object, e As EventArgs)
    End Sub

    Private Sub CutToolStripButton_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CopyToolStripButton_Click(sender As Object, e As EventArgs) Handles CopyToolStripButton.Click
        Clipboard.GetText()
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
    End Sub
End Class