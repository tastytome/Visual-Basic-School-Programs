Imports System.IO
Imports System.Text
Public Class Form1
    'AUTHOR: Thomas Khai Tran
    'DATE: 30/3/21
    'TITLE: U3O1 Part III Folio SAC

    'JUSTIFICATIONS:

    '--Visual Basic .NET framework was suitable given built-in features such as ability to easily read and save
    '--data from textfiles via StreamReader, and GUI creation options.

    '--Do...While Loop statements were suitable as it is a control flow statement that can execute a block of code repeatedly until
    '--meeting a condition at the end of the block. This was used as part of adding names from the textbox into the combobox,
    '--looping through until the last name had been added, and in other subroutines.

    '--IF...Else statements were suitable as it allowed execution of code given specified criteria was met (TRUE), while
    '--another set of code evaluated FALSE. IF statements were used in conjunction with boolean Yes/No to add key/value pairs when
    '--borrowing items and in other subroutines.

    '--Try...Catch statements were suitable as it allowed a block of code to be tested for errors, and for another block of code to 
    '--be executed if an error did occur in the try statement via the catch. This was used to check if the user input both a key and
    '--a value into the comboboxes, and prompt a msgbox telling them they had not if an error occured.

    '--For...Next statements were suitable as it is an iterative, incremental loop statement used to repeat sequence of
    '--statements for specific number of circumstances. Was used for searches to check whether items were borrowed, requiring only
    '--one line to be published to the listbox as an output rather than multiple, which could be specified by this statement. Also
    '--used to read through 100 lines of names in textbox and added to them an array.

    'VALIDATION: Validation for comboboxes was integrated into program code, as a boolean yes/no served as an existence check for the
    'input key / value to be paired during borrowing.
    'The DropDownStyle property of the combobox was changed to DropDownList, which meant users could only input list items,
    'not allowing any free user input, thereby circumventing the need for type/range validation code checks.

    'defines new dictionary and boolean for further use
    Dim Toydct As Dictionary(Of String, String) = New Dictionary(Of String, String)()
    Dim bothBoxesSelected As Boolean

    'form load handles populating comboboxes with name data
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'clears existing items
        cbxNamesList.Items.Clear()
        Dim name As String
        'opens textfile
        Dim ExampleFile As StreamReader = File.OpenText("ToyLibraryMemberNames.txt")
        'adds names to combobox
        Do While ExampleFile.Peek <> -1
            name = ExampleFile.ReadLine()
            cbxNamesList.Items.Add(name)
        Loop
        ExampleFile.Close()
    End Sub

    'button handles adding key/value pairs (borrowing items)
    Private Sub BtnBorrowToy_Click(sender As Object, e As EventArgs) Handles btnBorrowToy.Click
        'check to see if both combo boxes have been selected 
        'via IF statement And boolean
        If (cbxItemsList.SelectedItem = Nothing) Or (cbxNamesList.SelectedItem = Nothing) Then
            MsgBox("Ensure that a toy and member has been selected .")
            bothBoxesSelected = False
        Else
            bothBoxesSelected = True
        End If
        'if an item and member has been selected add to dictionary.
        'Error message if the toy has already been borrowed.
        If bothBoxesSelected = True Then
            Try
                Toydct.Add(cbxItemsList.SelectedItem, cbxNamesList.SelectedItem)
                MsgBox("Borrow Successful")
                'Catches exceptions to try
            Catch __unusedArgumentException1__ As ArgumentException
                MsgBox("That toy has already been borrowed.")
            End Try
        End If
    End Sub

    'button handles removing key/value pairs (returning items)
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        'prompts inputbox for user to enter item
        Dim toyBorrowed As String = InputBox("Enter the toy borrowed", "toyBorrowed Toy")
        'removes item from dictionary 
        Toydct.Remove(toyBorrowed)
    End Sub

    'button handles determing if item has / does not have a pair (searching if toy borrowed)
    Private Sub btnSearchItem_Click(sender As Object, e As EventArgs) Handles btnSearchItem.Click

        'prompts inputbox for toy name to check
        Dim searchToy As String = InputBox("Enter the requested toy name", "toySearch")
        lsbDisplay.Items.Clear()
        'for/next statement for each key value pair (member / toy) result
        For Each item As KeyValuePair(Of String, String) In Toydct
            'IF statement to listbox displaying whether borrow successful
            If item.Key = searchToy Then
                lsbDisplay.Items.Clear()
                lsbDisplay.Items.Add("====Search Item Results====")
                lsbDisplay.Items.Add(item.Key & " is borrowed by " & item.Value)
            Else
                lsbDisplay.Items.Clear()
                lsbDisplay.Items.Add("====Search Item Results====")
                lsbDisplay.Items.Add(item.Key & " is not currently borrowed")
            End If
        Next
    End Sub

    'button handles linear search of textfile to state whether item is in the file (for input name)
    Private Sub btnSearchName_Click(sender As Object, e As EventArgs) Handles btnSearchName.Click
        '--Linear Search of Array from start to finish of array until item Found Or End of Array.
        '--Add code to read the textfile of member names into an array of 100 names
        Dim strMembers(99) As String
        Dim ExampleFile As StreamReader = File.OpenText("ToyLibraryMemberNames.txt")
        For i = 0 To 99
            strMembers(i) = ExampleFile.ReadLine()
        Next
        ExampleFile.Close()
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
        strSearchRequestItem = InputBox("enter the Member name for search", "search name")
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
        '--Output the results into the listbox on the Form
        If blnItemFound = True Then
            lsbDisplay.Items.Clear()
            lsbDisplay.Items.Add("====Search Name Results====")
            lsbDisplay.Items.Add(strSearchRequestItem & " is a Member")
        Else
            lsbDisplay.Items.Clear()
            lsbDisplay.Items.Add("====Search Name Results====")
            lsbDisplay.Items.Add("Member " & strSearchRequestItem & " was Not Found")
        End If
    End Sub

    'button handles listing all names from textfile
    Private Sub btnListNames_Click(sender As Object, e As EventArgs) Handles btnListNames.Click
        Dim name As String
        'opens textfile
        Dim ExampleFile As StreamReader = File.OpenText("ToyLibraryMemberNames.txt")
        lsbDisplay.Items.Clear()
        lsbDisplay.Items.Add("====Listing Names====")
        'adds all names to listbox
        Do While ExampleFile.Peek <> -1
            name = ExampleFile.ReadLine()
            lsbDisplay.Items.Add(name)
        Loop
        ExampleFile.Close()
    End Sub

    'button handles displaying all key/value pairs (borrowed items and borrowers)
    Private Sub btnDisplayItems_Click(sender As Object, e As EventArgs) Handles btnDisplayItems.Click
        lsbDisplay.Items.Clear()
        lsbDisplay.Items.Add("====Displaying Borrowed Items====")
        'displays key value pairs of associative array dictionary
        For Each item As KeyValuePair(Of String, String) In Toydct
            lsbDisplay.Items.Add(item.Key & " has been borrowed by " & item.Value)
        Next
    End Sub

    '(utility) button handles clearing listboxes and comboboxes
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lsbDisplay.Items.Clear()
        cbxNamesList.Text = Nothing
        cbxItemsList.Text = Nothing
    End Sub

    '(utility) button handles exiting program
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

'The End :)