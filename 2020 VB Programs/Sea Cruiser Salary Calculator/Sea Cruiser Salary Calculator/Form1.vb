Public Class Form1

    '==================================================  (Definitions)

    Dim strName As String
    Dim intWeekend As Integer
    Dim intCategory As Integer
    Dim strCategory As String
    Dim dblPay As Double
    Dim dblHours As Double

    '==================================================  (Weekend Pay)

    Private Sub rbnWeekend_CheckedChanged(sender As Object, e As EventArgs) Handles rbnWeekend.CheckedChanged
        intWeekend = 100.0
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        '==================================================  (Hours)

        Dim fltHours As Double = Val(txtHours.Text)

        '==================================================  (Category & Pay)

        Select Case cbxCategory.SelectedIndex
            Case 0
                strCategory = "Senior"
                If fltHours >= 40 Then
                    dblHours = 50 * fltHours
                Else
                    dblHours = 35 * fltHours
                End If
            Case 1
                strCategory = "General"
                If fltHours >= 40 Then
                    dblHours = 60 * fltHours
                Else
                    dblHours = 45 * fltHours
                End If
            Case 2
                strCategory = "Casual"
                dblHours = 40 * fltHours
        End Select

        '==================================================  (Outputs)

        strName = txtName.Text
        Dim strDisplay = "The weekly pay for " & strName & " will be"
        lblDisplay.Text = strDisplay

        dblPay = dblHours + intWeekend
        txtPay.Text = "$" & dblPay

    End Sub

End Class
