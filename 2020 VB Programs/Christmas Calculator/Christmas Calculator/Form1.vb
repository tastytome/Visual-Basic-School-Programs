Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Today_Dtp.Value = DateTime.Now

        Dim DateChristmas As Integer = DateDiff(DateInterval.Day, Today_Dtp.Value, Christmas_Dtp.Value)

        MsgBox(" There are " & DateChristmas & " Days until Christmas.")

    End Sub
End Class
