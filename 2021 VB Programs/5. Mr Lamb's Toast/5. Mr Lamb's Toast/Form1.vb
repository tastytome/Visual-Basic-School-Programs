Public Class Form1
    'Author: Thomas Khai Tran
    'Program: 5. Mr Lamb's Toast

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Definitions and assigning values from textboxes
        Dim NumSlicesPerBfast As Integer = txtNumSlices.Text
        Dim NumBfastsPerWkn As Integer = txtNumBreakfastsPerWk.Text
        Dim NumWksPerYr As Integer = txtNumWks.Text
        Dim NumYrs As Integer = txtNumYrs.Text
        Dim TotalNumSlices As Integer
        Dim TotalNumLoaves As Double
        Dim TotalLoafLength As Double
        Dim SliceThickness As Integer
        Dim DisplayUnits As Double

        'Assign slice thickness based on radio button checked
        If rbtThinSlice.Checked = True Then SliceThickness = 0.7
        If rbtThickSlice.Checked = True Then SliceThickness = 1.0
        If rbtRaisinToast.Checked = True Then SliceThickness = 1.2

        'Calculations for output values
        TotalNumSlices = NumSlicesPerBfast * NumBfastsPerWkn * NumWksPerYr * NumYrs
        TotalNumLoaves = TotalNumSlices / 30
        TotalLoafLength = TotalNumSlices * SliceThickness / 1000

        'Displaying different output based on case chosen
        Select Case cbxDisplayUnits.SelectedIndex
            Case 0
                DisplayUnits = TotalNumSlices
                lsbDisplay.Items.Clear()
                lsbDisplay.Items.Add("You ate " & TotalNumSlices & " slices of toast!")
            Case 1
                DisplayUnits = TotalNumLoaves
                lsbDisplay.Items.Clear()
                lsbDisplay.Items.Add("You ate " & TotalNumLoaves & " loaves of toast!")
            Case 2
                DisplayUnits = TotalLoafLength
                lsbDisplay.Items.Clear()
                lsbDisplay.Items.Add("You ate " & TotalLoafLength & " metres worth of toast!")
        End Select
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear all textboxes
        txtNumBreakfastsPerWk.Clear()
        txtNumSlices.Clear()
        txtNumWks.Clear()
        txtNumYrs.Clear()
        lsbDisplay.Items.Clear()
        cbxDisplayUnits.Text = ""
        rbtRaisinToast.Checked = False
        rbtThickSlice.Checked = False
        rbtThinSlice.Checked = False
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Prompts program exit confirmation
        Dim Response As Integer
        Response = MessageBox.Show("Do you really want to exit?", "",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Response = vbYes Then
            Me.Close()
        End If
    End Sub

End Class
