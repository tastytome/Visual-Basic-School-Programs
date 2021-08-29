Imports System.IO
Imports System.Text
Public Class FrmAddBooking
    'AUTHOR: Thomas Khai Tran
    'DATE: 19/3/21
    'TITLE: U3O1 Part II Folio SAC

    '--sets Validation boolean as false by default
    Dim blnInputDataOK = False

    '--when button is clicked, runs DoValidation subroutine, then DoActions subroutine if data is correct
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAddCustomerToFile.Click
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
        If (String.IsNullOrEmpty(txbCustGivenName.Text)) Then
            MessageBox.Show("Enter a given name", "Error")
            txbCustGivenName.Focus()
        ElseIf (String.IsNullOrEmpty(txbCustSurname.Text)) Then
            MessageBox.Show("Enter a surname", "Error")
            txbCustSurname.Focus()
        ElseIf (String.IsNullOrEmpty(txbCustStreet.Text)) Then
            MessageBox.Show("Enter an address", "Error")
            txbCustStreet.Focus()
        ElseIf (String.IsNullOrEmpty(txbCustSuburb.Text)) Then
            MessageBox.Show("Enter a suburb", "Error")
            txbCustSuburb.Focus()
        ElseIf (String.IsNullOrEmpty(cbxStates.Text)) Then
            MessageBox.Show("Enter a state", "Error")
            cbxStates.Focus()
        ElseIf (String.IsNullOrEmpty(txbCustPostcode.Text)) Then
            MessageBox.Show("Enter a postcode", "Error")
            txbCustPostcode.Focus()
        ElseIf (String.IsNullOrEmpty(txbCustMobileNum.Text)) Then
            MessageBox.Show("Enter a mobile number", "Error")
            txbCustMobileNum.Focus()
        ElseIf (String.IsNullOrEmpty(cbxCustRating.Text)) Then
            MessageBox.Show("Enter a rating", "Error")
            cbxCustRating.Focus()


            '--type checks
        ElseIf (IsNumeric(txbCustGivenName.Text)) = True Then
            MessageBox.Show("Input letters for given name", "Error")
            txbCustGivenName.Focus()
        ElseIf (IsNumeric(txbCustSurname.Text)) = True Then
            MessageBox.Show("Input letters for surname", "Error")
            txbCustSurname.Focus()
        ElseIf (IsNumeric(txbCustSuburb.Text)) = True Then
            MessageBox.Show("Input letters for suburb", "Error")
            txbCustSuburb.Focus()
        ElseIf (IsNumeric(cbxStates.Text)) = True Then
            MessageBox.Show("Input letters for state", "Error")
            cbxStates.Focus()
        ElseIf (IsNumeric(txbCustPostcode.Text)) = False Then
            MessageBox.Show("Input numbers for postcode", "Error")
            txbCustPostcode.Focus()
        ElseIf (IsNumeric(txbCustMobileNum.Text)) = False Then
            MessageBox.Show("Input numbers for mobile", "Error")
            txbCustMobileNum.Focus()
        ElseIf (IsNumeric(cbxCustRating.Text)) = True Then
            MessageBox.Show("Input letters for rating", "Error")
            cbxCustRating.Focus()

            '--range checks
        ElseIf (txbCustPostcode.Text >= 10000) Then
            MessageBox.Show("Input a valid postcode number with 4 digits", "Error")
            txbCustPostcode.Focus()
        ElseIf (txbCustMobileNum.Text >= 1000000000) Then
            MessageBox.Show("Input a valid phone number with 10 digits", "Error")
            txbCustPostcode.Focus()

            '--makes InputDataOK True if all validations are correct
        Else
            blnInputDataOK = True
        End If

    End Sub

    '--action subroutine to write inputs to textfile
    Private Sub DoActions()
        Dim NamesFile As StreamWriter = File.AppendText("CustomerDetails.txt")
        'appends (adds to textfile) input
        NamesFile.WriteLine(txbCustGivenName.Text)
        NamesFile.WriteLine(txbCustSurname.Text)
        NamesFile.WriteLine(txbCustStreet.Text)
        NamesFile.WriteLine(txbCustSuburb.Text)
        NamesFile.WriteLine(cbxStates.Text)
        NamesFile.WriteLine(txbCustPostcode.Text)
        NamesFile.WriteLine(txbCustMobileNum.Text)
        NamesFile.WriteLine(cbxCustRating.Text)
        MessageBox.Show("Customer details have been added to the inventory file")
        NamesFile.Close()
    End Sub

    '--when button is clicked, switches to main menu form
    Private Sub btnReturnMainMenu_Click(sender As Object, e As EventArgs) Handles btnReturnMainMenu.Click
        FrmMainMenu.Show()
        Me.Hide()
    End Sub
End Class
