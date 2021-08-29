Public Class Form1

    '--Define and Load a String Type Array with the names of the four Team Members
    Dim strMembers() As String = {"Thomas", "Raffy", "Amy", "Jasper"}

    Private Sub btnListNames_Click(sender As Object, e As EventArgs) Handles btnListNames.Click

        '--Define a String variable for the Output List of Names to go into
        Dim strOutputName As String = ""

        '--Use a For...Next Loop to go through the Array from the start
        '--at strMembers(0) through to the end at strMembers(3).
        '--Each time we add another name to the output List Box group of Items it contains. 

        For intSubscript = 0 To 3
            '--Add the current strMembers Array Element into the ListBox "lstNames" indexed Item
            lstNames.Items.Add(strMembers(intSubscript))

            '--Does this alternative coding work - NOPE!!!! crashes and says index of zero is invalid 
            '>> lstNames.Items(intSubscript) = strMembers(intSubscript)
        Next

        '--Output Message into the Label under the List Box
        lblLoadFinished.Text = "List Box Loaded"

    End Sub

    Private Sub btnMsgBox_Click(sender As Object, e As EventArgs) Handles btnMsgBox.Click

        '--Define a String variable for the Output List of Names to go into
        Dim strOutputName As String = ""

        '--Use a For...Next Loop to go through the LIST BOX from the start
        '--at lstNames.Items(0) through to the end at lstNames.Items(3).
        '--Each time through the Loop we output another name to the Output Name variable.
        '--We also add a line return so that the next name processed will be on a new line.  
        '--The &= makes sure that we keep adding names to the output variable, and we
        '--do not overwrite the previous name that was placed into the variable. 

        For intSubscript = 0 To 3
            strOutputName &= lstNames.Items(intSubscript) & vbNewLine
        Next
        '--Use two commas and then put a Title Name for the top of the Message Box.
        MsgBox(strOutputName, , "List Box Names")
    End Sub

    Private Sub btnFindName_Click(sender As Object, e As EventArgs) Handles btnFindName.Click

        '--Linear Search of Array from start to finish of array until item Found OR End of Array.

        '--Initialise variables 
        Dim blnItemFound As Boolean = False
        Dim blnEndOfArray As Boolean = False
        Dim intSubscript As Integer = 0
        Dim intMaxSubscript As Integer
        '--Determine the end of array Max Subscript by doing Array Length minus 1 because 
        '--First Subscript in Visual Basic is 0 and not 1. 
        intMaxSubscript = strMembers.Length - 1

        '--Get the User Input Search request from the Form Text Box. 
        Dim strSearchRequestItem As String
        strSearchRequestItem = txtSearchRequest.Text

        '--Use a While Loop to do a Linear Search of the Array
        While blnItemFound = False And blnEndOfArray = False
            If strSearchRequestItem = strMembers(intSubscript) Then
                blnItemFound = True

            ElseIf intSubscript = intMaxSubscript Then
                blnEndOfArray = True

            Else
                intSubscript = intSubscript + 1
            End If
        End While

        '--Output the results into the Label on the Form 
        If blnItemFound = True Then
            lblSearchResultMsg.Text = strSearchRequestItem & " is in the array"
        Else
            lblSearchResultMsg.Text = "Item " & strSearchRequestItem & " was Not Found"

        End If

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        '--Clear the List Box 
        lstNames.Items.Clear()

        '--Also clear the List Box Loaded Message label
        lblLoadFinished.Text = ""

        '--Clear the Search textbox and results label
        txtSearchRequest.Text = ""
        lblSearchResultMsg.Text = Nothing
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        '--Clear the List Box 
        lstNames.Items.Clear()

        '--Also clear the List Box Loaded Message label
        lblLoadFinished.Text = ""

        '--Clear the Search textbox and results label
        txtSearchRequest.Text = Nothing
        lblSearchResultMsg.Text = Nothing
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        '--Exit button to close down the application, with an Are You Sure message 
        Dim confirm_msg As Integer
        confirm_msg = MessageBox.Show("Are you sure you want to exit?", "Exit and Close",
                      MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If confirm_msg = vbYes Then
            Me.Close()
        Else
            Exit Sub
        End If

    End Sub

End Class

