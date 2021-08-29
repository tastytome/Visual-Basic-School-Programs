Public Class Form1

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Prompts program exit confirmation
        Dim Response As Integer
        Response = MessageBox.Show("Do you really want to exit?", "",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Response = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear all textboxes
        txtTeacher1Name.Clear()
        txtTeacher2Name.Clear()
        txtTeacher1Day.Clear()
        txtTeacher2Day.Clear()
        txtTeacher1Duty.Clear()
        txtTeacher2Duty.Clear()
        chkDay.Checked = False
        chkDuty.Checked = False
    End Sub

    Private Sub btnSwap_Click(sender As Object, e As EventArgs) Handles btnSwap.Click
        'Swap values when checkbox checked
        Dim teacherSwapDay As String
        If chkDay.Checked = True Then
            teacherSwapDay = txtTeacher1Day.Text
            txtTeacher1Day.Text = txtTeacher2Day.Text
            txtTeacher2Day.Text = teacherSwapDay
        End If
        Dim teacherSwapDuty As String
        If chkDuty.Checked = True Then
            teacherSwapDuty = txtTeacher1Duty.Text
            txtTeacher1Duty.Text = txtTeacher2Duty.Text
            txtTeacher2Duty.Text = teacherSwapDuty
        End If
    End Sub
End Class
