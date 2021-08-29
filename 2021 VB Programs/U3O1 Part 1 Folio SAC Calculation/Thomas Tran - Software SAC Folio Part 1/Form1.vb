Public Class Form1
    'AUTHOR: Thomas Tran
    'DATE: 5/03/2021
    'PURPOSE: Software Development U3O1 Folio Part 1 SAC

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Button calculates booking details and displays results to listbox 

        '- Declares Variables
        Dim custFirstName As String = txbCustFirstName.Text
        Dim custSurname As String = txbCustSurname.Text
        Dim NumGuests As Integer = txbNumGuests.Text
        Dim NumNights As Integer = txbNumNights.Text
        Dim roomExtrasCost As Double = 0
        Dim bfastCost As Double
        Dim roomCost As Double
        Dim totalCost As Double

        '- Determines type of breakfast selected and assigns value via Select Case for radio buttons
        Select Case True
            Case rbtStandard.Checked
                bfastCost = 20 * NumGuests
            Case rbtDeluxe.Checked
                bfastCost = 30 * NumGuests
            Case rbtSuperior.Checked
                bfastCost = 40 * NumGuests
        End Select
        bfastCost = bfastCost * NumNights

        '- Determines if room extras are selected and assigns values via If statements for checkbox
        If chbPillows.Checked = True Then roomExtrasCost = roomExtrasCost + 50
        If chbFoodBasket.Checked = True Then roomExtrasCost = roomExtrasCost + 30

        '- Determines room type and assigns cost via Case Select for combobox
        Select Case cbxRoomType.SelectedIndex
            Case 0
                roomCost = 100
            Case 1
                roomCost = 150
            Case 2
                roomCost = 250
            Case 3
                roomCost = 500
        End Select
        roomCost = roomCost * NumNights

        'Calculates total cost value
        totalCost = bfastCost + roomExtrasCost + roomCost

        'Dispay output information using listbox via adding items
        LsbDisplay.Items.Clear()
        LsbDisplay.Items.Add("    ")
        LsbDisplay.Items.Add("Booking cost details for " & custFirstName & " " & custSurname)
        LsbDisplay.Items.Add("===================================================")
        LsbDisplay.Items.Add("    ")
        LsbDisplay.Items.Add("The number of guests is: " & NumGuests)
        LsbDisplay.Items.Add("The number of nights requested is: " & NumNights)
        LsbDisplay.Items.Add("The room extras cost is: $" & roomExtrasCost)
        LsbDisplay.Items.Add("The breakfast cost is: $" & bfastCost)
        LsbDisplay.Items.Add("    ")
        LsbDisplay.Items.Add("The TOTAL cost is: $" & totalCost)
        LsbDisplay.Items.Add("===================================================")

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'Clears all selections
        txbCustFirstName.Clear()
        txbCustSurname.Clear()
        txbNumGuests.Clear()
        txbNumNights.Clear()
        LsbDisplay.Items.Clear()
        cbxRoomType.Text = ""
        rbtStandard.Checked = False
        rbtDeluxe.Checked = False
        rbtSuperior.Checked = False
        chbFoodBasket.Checked = False
        chbPillows.Checked = False
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Prompts program exit confirmation via messagebox  yes/no response
        Dim Response As Integer
        Response = MessageBox.Show("Do you really want to exit?", "",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Response = vbYes Then
            Me.Close()
        End If
    End Sub



End Class