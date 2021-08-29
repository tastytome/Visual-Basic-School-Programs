Public Class Form1
    Dim blnInputDataOK = False

    Private Sub DoInputValidation()

        'Existence check
        If (String.IsNullOrEmpty(txtFirst.Text)) Then
            MessageBox.Show("Enter Values for both numbers", "Error")
            txtFirst.Focus()
        ElseIf (String.IsNullOrEmpty(txtSecond.Text)) Then
            MessageBox.Show("Enter Values for both numbers", "Error")
            txtSecond.Focus()

            'Type check
        ElseIf (IsNumeric(txtFirst.Text)) = False Then
            MessageBox.Show("Input Whole Numbers or Decimals for both numbers", "Error")
            txtFirst.Focus()
        ElseIf (IsNumeric(txtSecond.Text)) = False Then
            MessageBox.Show("Input Whole Numbers or Decimals for both numbers", "Error")
            txtSecond.Focus()

            'Range check
        ElseIf (txtFirst.Text <= 0) Then
            MessageBox.Show("Input a value Greater than Zero", "Error")
            txtFirst.Focus()
        ElseIf (txtSecond.Text <= 0) Then
            MessageBox.Show("Input a value greater than Zero", "Error")
            txtSecond.Focus()

            'Existence check II
        ElseIf cbxOp.Text = Nothing Then
            MessageBox.Show("Choose operation", "Operation Not Selected")
            cbxOp.Focus()

        Else
            blnInputDataOK = True
        End If

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        blnInputDataOK = False
        DoInputValidation()

        If blnInputDataOK = True Then
            DoCalculations()
        End If

    End Sub

    Private Sub DoCalculations()

        Dim firstNum As Double = txtFirst.Text
        Dim secondNum As Double = txtSecond.Text
        Dim answer As Double = 0

        Select Case cbxOp.SelectedIndex
            Case 0
                answer = firstNum + secondNum
            Case 1
                answer = firstNum - secondNum
            Case 2
                answer = firstNum * secondNum
        End Select

        lsbAnswer.Items.Clear()
        lsbAnswer.Items.Add(answer)

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtFirst.Clear()
        txtSecond.Clear()
        lsbAnswer.Items.Clear()
        cbxOp.Text = ""
    End Sub

End Class


'Instructions:

'First Number, Second Number are textboxes
'Answer Is a listbox
'The Combo box options are: the words : " plus", "minus", "times"
'The user Is To enter an Integer into the "First Number" And an Integer into the "Second Number" textboxes.
'The user Is To Select an operation from the ComboBox.
'When the user clicks the "Calculate" button, the listbox will display the appropriate answer.
'Add code that validates (existence, type And range checks) the input data.
'Submit your project folder To the Learning Task "Week 7 Formative Assessment Task - #Validation"