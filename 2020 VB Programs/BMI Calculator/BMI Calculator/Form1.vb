Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim height, weight, bmi As String
        height = txtHeight.Text
        weight = txtWeight.Text
        bmi = (weight) / (height ^ 2)
        txtBmi.Text = bmi

        If bmi <= 18.5 Then
            MsgBox("You are underweight")
        Else
            If bmi > 18.5 And bmi <= 24.9 Then
                MsgBox("You are normal weight")
            Else
                If bmi > 25 And bmi <= 29.9 Then
                    MsgBox("You are overweightweight")
                Else
                    If bmi >= 30 Then
                        MsgBox("You are obese")
                    End If
                End If
            End If
        End If

    End Sub
End Class