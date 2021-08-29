Public Class Form1

    Private Sub btnFunctionate_Click(sender As Object, e As EventArgs) Handles btnFunctionate.Click


        '--VB Code to Triple a Number with and without Using a Function
        Dim intNumberA As Integer = 1
        Dim intNumberB As Integer = 3 * intNumberA   '--to triple the number 
        MessageBox.Show("Hard Coded Value of " & intNumberA & " tripled = " & intNumberB, "Done by Pgm Code")
        '--Now Use a VB Function to Triple a Number (See below for the Function Code)
        Dim intNumberInput As Integer = 1
        Dim intNumberOutput As Integer
        '--Call the Function to triple the number
        intNumberOutput = TripleTheInteger(intNumberInput)
        MessageBox.Show("Passed Value of " & intNumberInput & " tripled with Function = " & intNumberOutput, "Function")


        '--The Function is called "CalculateGST" and it needs to be passed a Dollar Price
        Dim dblWholesalePrice As Double = 25.0  '<--set the Price as $25 
        '--Dimension a Variable that can store the Returned GST Value
        Dim dblGST As Double
        '--Call the Function to Calculate the GST (see below for the Function Code) 
        dblGST = CalculateGST(dblWholesalePrice)
        '--Format the Returned GST Value into Currency $ Format 
        Dim strOutputGST As String = FormatCurrency(dblGST, 2, TriState.True, TriState.False)
        '--Output the Results using a Message Box 
        MessageBox.Show("Passed Value of Price= " & dblWholesalePrice & vbCrLf _
                      & "GST from Function = " & strOutputGST, "GST Function")
        Dim dtDateOne As Date = "20-03-2019"  '<--set the Start Date
        Dim dtDateTwo As Date = "28-03-2019"  '<--set the End Date
        '--Dimension a Variable that can store the Returned Number of Days Value
        Dim intNbrOfDays As Double
        '--Call the Function to Calculate the Dates (see below for the Function Code) 
        intNbrOfDays = DaysDifference(dtDateOne, dtDateTwo)
        MessageBox.Show("First Date = " & dtDateOne & vbCrLf _
                        & "Second Date = " & dtDateTwo & vbCrLf _
                        & "Days Difference = " & intNbrOfDays & " days", "Days Function")
    End Sub


    Public Function TripleTheInteger(ByVal intInputInteger As Integer) As Integer

        '--This function needs to be passed an Integer number. 
        '--The Function will Return 3 times the Number so it is "Tripled". 

        TripleTheInteger = 3 * intInputInteger

        '--Set the Function RETURN VALUE to be the result we got for the calculation.
        Return TripleTheInteger

    End Function


    Public Function CalculateGST(ByVal dblInputPrice As Double) As Double
        '--This function needs to be passed a Double Value that is a $ value. 
        '--The Function will Return the GST Amount for the passed in Price. 
        '--The GST is currently set by the Australian Government at 10% = 0.10. 

        '--local variable declaration for the result of the calculation below. 
        Dim dblGSTResult As Double
        dblGSTResult = 0.1 * dblInputPrice

        '--Set the Function RETURN VALUE to be the result we got for the calculation
        CalculateGST = dblGSTResult
        '--Exit this function and Return to its caller code the value in "CalculateGST".
        '--Return is like an "Exit Sub" command and exits the function. We could actually
        '--leave this last line of code below out, and the function still works okay. 
        Return CalculateGST
    End Function



    Public Function DaysDifference(ByVal dtStartDate As Date, ByVal dtEndDate As Date) As Integer
        '--local variable declaration for the result of the calculation below. 
        Dim intResultDays As Integer

        '--Math.Floor takes a positive value and discards the decimal fraction.
        '--Math.Floor does essentially the same as Truncating. 

        intResultDays = Math.Floor(dtEndDate.Subtract(dtStartDate).TotalDays)

        '--Set the Function RETURN VALUE to be the result we got for the calculation
        DaysDifference = intResultDays

        '--Return is like an "Exit Sub" command and exits the function. We could actually
        '--leave this last line of code below out, and the function still works okay. 
        Return DaysDifference
    End Function

End Class
