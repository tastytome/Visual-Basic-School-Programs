Imports System.IO
Imports System.Text
Public Class Form1
    'AUTHOR: Thomas Khai Tran
    'DATE: 19/3/21
    'TITLE: U3O1 Part II Folio SAC

    '--sets Validation boolean as false by default
    Dim blnInputDataOK = False

    '--when button is clicked, runs DoValidation subroutine, then DoActions subroutine if data is correct
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        blnInputDataOK = False
        DoValidation()

        'checks if IF statements in DoValidation subroutine are fulfilled and runs DoActions
        If blnInputDataOK = True Then
            DoActions()
        End If
    End Sub

    '--validation subroutine via IF statement
    Private Sub DoValidation()

        '--existence checks
        If (String.IsNullOrEmpty(txtName.Text)) Then
            MessageBox.Show("Enter a name", "Error")
            txtName.Focus()
        ElseIf (String.IsNullOrEmpty(cbxRating.Text)) Then
            MessageBox.Show("Enter a rating", "Error")
            txtName.Focus()
        ElseIf (String.IsNullOrEmpty(txtYear.Text)) Then
            MessageBox.Show("Enter a year", "Error")
            txtName.Focus()


            '--type checks
        ElseIf (IsNumeric(txtName.Text)) = True Then
            MessageBox.Show("Input letters for name", "Error")
            txtName.Focus()
        ElseIf (IsNumeric(txtYear.Text)) = False Then
            MessageBox.Show("Input numbers for year", "Error")
            txtName.Focus()

            '--range checks
        ElseIf (txtYear.Text <= 0) Then
            MessageBox.Show("Input a value Greater than 0", "Error")
            txtYear.Focus()
        Else
            blnInputDataOK = True
        End If

    End Sub

    '--action subroutine to write inputs to textfile
    Private Sub DoActions()
        Dim NamesFile As StreamWriter = File.AppendText("NamesData.txt")
        'appends (addd to textfile) input
        NamesFile.WriteLine(txtName.Text)
        NamesFile.WriteLine(cbxRating.Text)
        NamesFile.WriteLine(txtYear.Text)
        MessageBox.Show("This item has been added to the inventory file")
        NamesFile.Close()
    End Sub

    '--when button is clicked, switches to form 2
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Form2.Show()
        Me.Hide()
    End Sub

    '--prompts program exit confirmation via messagebox yes/no response
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim Response As Integer
        Response = MessageBox.Show("Do you really want to exit?", "",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Response = vbYes Then
            Me.Close()
        End If
    End Sub

End Class
