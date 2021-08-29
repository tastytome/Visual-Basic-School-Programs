Imports System.IO
Imports System.Text
Public Class FrmReports
    'AUTHOR: Thomas Khai Tran
    'DATE: 19/3/21
    'TITLE: U3O1 Part II Folio SAC

    '--sets Validation boolean as false by default and defines values for later use
    Dim blnInputDataOK = False
    Dim SelectedState As String
    Dim custGivenName As String
    Dim custSurname As String
    Dim custStreetAddress As String
    Dim custSuburb As String
    Dim custState As String
    Dim custPostCode As Integer
    Dim custMobileNum As Integer
    Dim custRating As String

    '--when list all customer details button is clicked, displays contents of textfile via streamreader
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnListAllCustomerDetails.Click
        '--clears list and defines values
        lsbCustomerList.Items.Clear()
        Dim CustomerDetails As StreamReader = File.OpenText("CustomerDetails.txt")
        '--opens textfile loops through data until complete
        Do While CustomerDetails.Peek <> -1
            custGivenName = CustomerDetails.ReadLine()
            custSurname = CustomerDetails.ReadLine()
            custStreetAddress = CustomerDetails.ReadLine()
            custSuburb = CustomerDetails.ReadLine()
            custState = CustomerDetails.ReadLine
            custPostCode = CustomerDetails.ReadLine()
            custMobileNum = CustomerDetails.ReadLine()
            custRating = CustomerDetails.ReadLine()
            '--display output information using listbox via adding items
            lsbCustomerList.Items.Add(custGivenName & " " & custSurname & ", " & custStreetAddress & ", " & custSuburb & ", " & custState & ", " & custPostCode & ", " & custMobileNum & ", " & custRating)
        Loop
        '--closes file
        CustomerDetails.Close()
    End Sub

    '--when list by state button is clicked, runs DoSelection & DoValidation subroutine, then DoActions subroutine if data is correct
    Private Sub btnRating_Click(sender As Object, e As EventArgs) Handles btnListCustByState.Click
        blnInputDataOK = False
        DoSelection()
        DoValidation()
        'checks if IF statements in DoValidation subroutine are fulfilled and runs DoActions
        If blnInputDataOK = True Then
            DoActions()
        End If
    End Sub

    '--subroutine saves value of combobox selection via Select Case
    Private Sub DoSelection()
        SelectedState = cbxStates.SelectedItem
        '--uses Select Case to assign value
        Select Case SelectedState
            Case "VIC"
                SelectedState = ("VIC")
            Case "NSW"
                SelectedState = ("NSW")
            Case "QLD"
                SelectedState = ("QLD")
            Case "NT"
                SelectedState = ("NT")
            Case "WA"
                SelectedState = ("WA")
            Case "SA"
                SelectedState = ("SA")

            Case Else
                SelectedState = ("Valid State Not Found")
        End Select
    End Sub

    '--subroutine validates state selection via IF statement
    Private Sub DoValidation()
        '--existence check
        If (String.IsNullOrEmpty(cbxStates.Text)) Then
            MessageBox.Show("Enter a state", "Error")
            cbxStates.Focus()
        Else
            blnInputDataOK = True
        End If
    End Sub

    '--subroutine for state sort reads file and uses IF statement to sort
    Private Sub DoActions()
        '--clears list and defines values
        lsbCustomerList.Items.Clear()
        Dim CustomerDetails As StreamReader = File.OpenText("CustomerDetails.txt")
        '--opens textfile loops through data until complete
        Do While CustomerDetails.Peek <> -1
            custGivenName = CustomerDetails.ReadLine()
            custSurname = CustomerDetails.ReadLine()
            custStreetAddress = CustomerDetails.ReadLine()
            custSuburb = CustomerDetails.ReadLine()
            custState = CustomerDetails.ReadLine
            custPostCode = CustomerDetails.ReadLine()
            custMobileNum = CustomerDetails.ReadLine()
            custRating = CustomerDetails.ReadLine()
            '--IF statement checking if selected combobox rating matches data input and outputs if matches 
            If custState = SelectedState Then
                '--display output information using listbox via adding items
                lsbCustomerList.Items.Add(custGivenName & " " & custSurname & ", " & custStreetAddress & ", " & custSuburb & ", " & custState & ", " & custPostCode & ", " & custMobileNum & ", " & custRating)
            End If
        Loop
        '--closes file
        CustomerDetails.Close()
    End Sub

    '--when list platinum button is clicked, displays contents of textfile via streamreader and sorts via IF
    Private Sub btnListPlatinumCust_Click(sender As Object, e As EventArgs) Handles btnListPlatinumCust.Click
        '--clears list and defines values
        lsbCustomerList.Items.Clear()
        '--sets platinum start number at 0 and defines platinum
        Dim PlatinumCust As String = "platinum"
        Dim NumPlatinumCust As Integer = 0
        '--other definitions
        Dim CustomerDetails As StreamReader = File.OpenText("CustomerDetails.txt")
        '--opens textfile loops through data until complete
        Do While CustomerDetails.Peek <> -1
            custGivenName = CustomerDetails.ReadLine()
            custSurname = CustomerDetails.ReadLine()
            custStreetAddress = CustomerDetails.ReadLine()
            custSuburb = CustomerDetails.ReadLine()
            custState = CustomerDetails.ReadLine
            custPostCode = CustomerDetails.ReadLine()
            custMobileNum = CustomerDetails.ReadLine()
            custRating = CustomerDetails.ReadLine()
            '--IF statement checking if selected combobox rating matches data input and outputs if matches 
            If custRating = "Platinum" Then
                '--display platinum customers names via adding items
                lsbCustomerList.Items.Add(custGivenName & " " & custSurname)
                '--adds one to platinum customer count
                NumPlatinumCust = NumPlatinumCust + 1
            End If
        Loop
        lsbCustomerList.Items.Add("There are " & NumPlatinumCust & " Platinum Customers")
        '--closes file
        CustomerDetails.Close()
    End Sub

    '--when main menu button is clicked, switches to main menu form
    Private Sub btnReturnMainMenu_Click(sender As Object, e As EventArgs) Handles btnReturnMainMenu.Click
        FrmMainMenu.Show()
        Me.Hide()
    End Sub

End Class