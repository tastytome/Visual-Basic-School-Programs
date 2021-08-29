Public Class Form1

    Dim strName As String
    Dim strOutputMessage
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        strName = txtInputName.Text
        strOutputMessage = "Hello " & strName & " Welcome to Visual Basic 2020"

        txtOutputMsg.Text = strOutputMessage

        txtOutputMsg.Visible = True
        PictureBox1.Visible = True

    End Sub
End Class