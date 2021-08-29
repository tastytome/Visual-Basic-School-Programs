Imports System.IO
Imports System.Text
Public Class Form1
    'AUTHOR: Thomas Khai Tran
    'DATE: 30/4/21 & 4/5/21
    'TITLE: U3O1 Part III Folio SAC

    'NOTE: Room availability search and guest booking search function only AFTER a booking has been made

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

    '--Select Case statements suitable as allowed for a specific block of code to be executed out of seleceted radiobox options.
    '--This was used for the 3 search options to execute different coded for each search.

    '--For...Next statements were suitable as it is an iterative, incremental loop statement used to repeat sequence of
    '--statements for specific number of circumstances. Was used for searches to check whether items were borrowed, requiring only
    '--one line to be published to the listbox as an output rather than multiple, which could be specified by this statement. Also
    '--used to read through 100 lines of names in textbox and added to them an array.

    'VALIDATION: 
    'Comboboxes validated via private action subroutine for validation and actions run when book room button is clicked
    'using type, range, and existence checks

    'defines new dictionary and boolean for further use
    Dim Roomdct As Dictionary(Of String, String) = New Dictionary(Of String, String)()
    Dim bothBoxesSelected As Boolean
    '--sets Validation boolean as false by default
    Dim blnInputDataOK = False

    'form load handles populating comboboxes with name data
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'For NAMES: clears existing items
        cbxNamesList.Items.Clear()
        Dim name As String
        'opens textfile
        Dim ExampleFile As StreamReader = File.OpenText("MemberNames.txt")
        'adds names to combobox
        Do While ExampleFile.Peek <> -1
            name = ExampleFile.ReadLine()
            cbxNamesList.Items.Add(name)
        Loop
        ExampleFile.Close()
    End Sub

    'button handles booking rooms and validation; when button is clicked, 
    'runs DoValidation subroutine, Then DoActions subroutine If data Is correct
    Private Sub btnBookRoom_Click(sender As Object, e As EventArgs) Handles btnBookRoom.Click
        blnInputDataOK = False
        DoValidation()

        'checks if IF statements in DoValidation subroutine are fulfilled and runs DoActions
        If blnInputDataOK = True Then
            DoActions()
        End If
    End Sub

    'action subroutine handles validation of combobox inputs via IF statement
    Private Sub DoValidation()

        '--existence checks
        If (String.IsNullOrEmpty(cbxNamesList.Text)) Then
            MessageBox.Show("Enter a name", "Error")
            cbxNamesList.Focus()
        ElseIf (String.IsNullOrEmpty(cbxItemsList.Text)) Then
            MessageBox.Show("Enter a room", "Error")
            cbxItemsList.Focus()

            '--type checks
        ElseIf (IsNumeric(cbxNamesList.Text)) = True Then
            MessageBox.Show("Input letters for name", "Error")
            cbxNamesList.Focus()
        ElseIf (IsNumeric(cbxItemsList.Text)) = False Then
            MessageBox.Show("Input numbers for room", "Error")
            cbxItemsList.Focus()

            '--range checks
        ElseIf (cbxItemsList.Text <= 0) Then
            MessageBox.Show("Input a value Greater than 0", "Error")
            cbxItemsList.Focus()

        Else
            blnInputDataOK = True
        End If

    End Sub


    'action subroutine handles adding key/value pairs (booking rooms) after validation 
    Private Sub DoActions()
        'check to see if both combo boxes have been selected 
        'via IF statement And boolean
        If (cbxItemsList.SelectedItem = Nothing) Or (cbxNamesList.SelectedItem = Nothing) Then
            MsgBox("Ensure that a room and guest has been selected .")
            bothBoxesSelected = False
        Else
            bothBoxesSelected = True
        End If
        'if an item and key has been selected add to dictionary.
        'Error message if the room has already been booked.
        If bothBoxesSelected = True Then
            Try
                Roomdct.Add(cbxItemsList.SelectedItem, cbxNamesList.SelectedItem)
                MsgBox("Booking Successful")
                'Catches exceptions to try
            Catch __unusedArgumentException1__ As ArgumentException
                MsgBox("That room has already been booked.")
            End Try
        End If
    End Sub

    'button handles removing key/value pairs (making rooms available)
    Private Sub btnMakeRoomAvailable_Click(sender As Object, e As EventArgs) Handles btnMakeRoomAvailable.Click
        'prompts inputbox for user to enter item
        Dim roomBorrowed As String = InputBox("Enter the room to make available", "roomBooked Room")
        'removes item from dictionary 
        MsgBox("Room Availability Changed")
        Roomdct.Remove(roomBorrowed)
    End Sub

    'button handles linear search of textfile based on radiobuton search criteria case selected
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        'uses select case for different radio button search options
        Select Case True

                'case for radiobutton checks if item has / does not have a pair (searching if room borrowed)
            Case rbtRoomAvailability.Checked

                'prompts inputbox for room name to check
                Dim searchRoom As String = InputBox("Enter the requested room availability", "roomSearch")
                'for/next statement for each key value pair (member / toy) result
                For Each item As KeyValuePair(Of String, String) In Roomdct
                    'IF statement to listbox displaying whether borrow successful
                    If item.Key = searchRoom Then
                        lsbDisplay.Items.Clear()
                        lsbDisplay.Items.Add("====Room Availability Results====")
                        lsbDisplay.Items.Add(item.Key & " is booked by " & item.Value)
                    Else
                        lsbDisplay.Items.Clear()
                        lsbDisplay.Items.Add("====Room Availability Results====")
                        lsbDisplay.Items.Add(searchRoom & " is not currently booked")
                    End If
                Next

                'case for radiobutton checks if guest has made a booking
            Case rbtBookedGuest.Checked

                'prompts inputbox for room name to check
                Dim searchGuest As String = InputBox("Enter the requested guest booking status", "guestSearch")
                'for/next statement for each key value pair (member / toy) result
                For Each item As KeyValuePair(Of String, String) In Roomdct
                    'IF statement to listbox displaying whether borrow successful
                    If item.Value = searchGuest Then
                        lsbDisplay.Items.Clear()
                        lsbDisplay.Items.Add("====Guest Booking Results====")
                        lsbDisplay.Items.Add(item.Value & " has booked " & item.Key)
                    Else
                        lsbDisplay.Items.Clear()
                        lsbDisplay.Items.Add("====Guest Booking Results====")
                        lsbDisplay.Items.Add(searchGuest & " has not currently booked a room")
                    End If
                Next

                'case for radiobutton checks if guest is on textfile (registered)
            Case rbtRegisteredGuest.Checked
                '--Linear Search of Array from start to finish of array until item Found Or End of Array.
                '--Add code to read the textfile of member names into an array of 100 names
                Dim strMembers(99) As String
                Dim ExampleFile As StreamReader = File.OpenText("MemberNames.txt")
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
                    lsbDisplay.Items.Add("====Registered Guest Results====")
                    lsbDisplay.Items.Add(strSearchRequestItem & " is a registered guest")
                Else
                    lsbDisplay.Items.Clear()
                    lsbDisplay.Items.Add("====Registered Guest Results====")
                    lsbDisplay.Items.Add("Registered Guest " & strSearchRequestItem & " was Not Found")
                End If
        End Select

    End Sub

    'button handles displaying all key/value pairs (borrowed booked rooms and guests)
    Private Sub btnDisplayBkdRms_Click(sender As Object, e As EventArgs) Handles btnDisplayBkdRms.Click
        lsbDisplay.Items.Clear()
        lsbDisplay.Items.Add("====Displaying Booked Rooms====")
        'displays key value pairs of associative array dictionary
        For Each item As KeyValuePair(Of String, String) In Roomdct
            lsbDisplay.Items.Add("Room " & item.Key & " has been booked by " & item.Value)
        Next
    End Sub

    'button handles displaying all available rooms
    Private Sub btnDisplayAvailableRooms_Click(sender As Object, e As EventArgs) Handles btnDisplayAvailableRooms.Click
        Dim name As String
        'opens textfile
        Dim ExampleFile As StreamReader = File.OpenText("RoomNames.txt")
        lsbDisplay.Items.Clear()
        lsbDisplay.Items.Add("====Displaying Available Rooms====")
        'adds room to listbox
        Do While ExampleFile.Peek <> -1
            name = ExampleFile.ReadLine()
            lsbDisplay.Items.Add(name)
        Loop
        ExampleFile.Close()
    End Sub

    '(utility) button handles clearing listboxes and comboboxes
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lsbDisplay.Items.Clear()
        cbxNamesList.Text = Nothing
        cbxItemsList.Text = Nothing
    End Sub

    '(utility) button handles exiting program
    Private Sub btnExit_Click_1(sender As Object, e As EventArgs) Handles btnExit.Click

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

'The End :P
