Imports System.IO
Imports System.Text

Public Class Form1
    Dim Toydct As Dictionary(Of String, String) = New Dictionary(Of String, String)()
    Dim bothBoxesSelected As Boolean
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'check to see if both combo boxes have been selected
        If (cbxToysList.SelectedItem = Nothing) Or (cbxMembersList.SelectedItem = Nothing) Then
            MsgBox("Ensure that a toy and member has been selected .")
            bothBoxesSelected = False
        Else
            bothBoxesSelected = True
        End If
        'if a toy and member has been selected add to dictionary.
        'Error message if the toy has already been borrowed.
        If bothBoxesSelected = True Then
            Try
                Toydct.Add(cbxToysList.SelectedItem, cbxMembersList.SelectedItem)
            Catch __unusedArgumentException1__ As ArgumentException
                lsbDisplay.Items.Add("That toy has already been borrowed.")
            End Try
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        lsbDisplay.Items.Clear()
        For Each item As KeyValuePair(Of String, String) In Toydct
            lsbDisplay.Items.Add(item.Key & " " & item.Value)
        Next

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim toyBorrowed As String = InputBox("Enter the toy borrowed", "toyBorrowed Toy")
        Toydct.Remove(toyBorrowed)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim searchToy As String = InputBox("Enter the requested toy name", "toySearch")
        For Each item As KeyValuePair(Of String, String) In Toydct
            If item.Key = searchToy Then
                lsbDisplay.Items.Add(item.Key & " is borrowed by " & item.Value)
            Else
                lsbDisplay.Items.Add(item.Key & " is not currently borrowed")
            End If

        Next
    End Sub

    Private Sub btnListToyLibraryMembers_Click(sender As Object, e As EventArgs) Handles btnListToyLibraryMembers.Click
        Dim name As String
        Dim ExampleFile As StreamReader = File.OpenText("ToyLibraryMemberNames.txt")
        lsbDisplay.Items.Clear()
        Do While ExampleFile.Peek <> -1
            name = ExampleFile.ReadLine()
            lsbDisplay.Items.Add(name)
        Loop
        ExampleFile.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxMembersList.Items.Clear()
        Dim name As String
        Dim ExampleFile As StreamReader = File.OpenText("ToyLibraryMemberNames.txt")
        Do While ExampleFile.Peek <> -1
            name = ExampleFile.ReadLine()
            cbxMembersList.Items.Add(name)
        Loop
        ExampleFile.Close()

    End Sub

    Private Sub btnSearchMemberName_Click(sender As Object, e As EventArgs) Handles btnSearchMemberName.Click
        '--Linear Search of Array from start to finish of array until item Found OR End of Array.
        '--Add code to read the textfile of member names into an array of 100 names


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
            lblSearchResultMsg.Text = strSearchRequestItem & " is a Member of the Toy Library"
        Else
            lblSearchResultMsg.Text = "Member " & strSearchRequestItem & " was Not Found"

        End If
    End Sub
End Class
