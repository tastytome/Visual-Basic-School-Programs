Public Class Form1
    '- AUTHOR: Thomas Tran
    '- Date Modified: 04/06/2020
    '- Purpose: Applied Computing SAC Task
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        '-Calculate Health Level

        '- Declare Variables
        Dim intStartScore, intAge, intAgePoints, intDiet, intSmoker, intRegular As Integer
        Dim dblPoints As Double

        '- Determine if smoker or regular exerciser
        If chkSmoker.Checked = True Then intSmoker = -40
        If chkRegular.Checked = True Then intRegular = 20

        '-Determine Age points
        intAge = Val(txtAge.Text)
        If intAge <= 30 Then
            intAgePoints = 20
        ElseIf intAge >= 60 Then
            intAgePoints = -30
        Else
            intAgePoints = 0
        End If


        '- Determine diet rating points
        Select Case cbxDiet.SelectedIndex
            Case 0
                intDiet = -30
            Case 1
                intDiet = -10
            Case 2
                intDiet = 30
        End Select

        '- Calculate total points
        intStartScore = 100
        dblPoints = intStartScore + (intSmoker + intRegular + intAgePoints + intDiet)
        txtMark.Text = dblPoints

        '- Display message based on total points
        Dim dblMark As Double
        dblMark = Val(dblPoints)
        If dblMark < 80 Then
            txtRating.Text = "Your score is less than 100. Your health needs attention!"
        ElseIf dblMark >= 80 And dblMark <= 99 Then
            txtRating.Text = "Your score is between 80 and 99. You are in good health."
        ElseIf dblMark >= 100 And dblMark <= 140 Then
            txtRating.Text = "Your score is greater than 100. Congratulations!"
        ElseIf dblMark > 140 Then
            txtRating.Text = "Your score is greater than 140. You are in great shape!"
        End If

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        '- Reset program for faster testing convenience

        chkSmoker.Checked = False
        chkRegular.Checked = False
        cbxDiet.Text = Nothing
        txtName.Text = Nothing
        txtAge.Text = Nothing
        txtRating.Text = Nothing

    End Sub

End Class