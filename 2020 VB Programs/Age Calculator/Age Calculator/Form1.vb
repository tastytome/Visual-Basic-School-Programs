Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim strName As String = txtName.Text

        Today_Dtp.Value = DateTime.Now
     
        Dim DateAge As Integer = DateDiff(DateInterval.Year, Birthday_Dtp.Value, Today_Dtp.Value)

        MsgBox(strName & " you are " & DateAge & " years old.")

    End Sub
End Class
