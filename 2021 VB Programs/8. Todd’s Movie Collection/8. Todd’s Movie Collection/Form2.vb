Imports System.IO
Imports System.Text
Public Class Form2
    'AUTHOR: Thomas Khai Tran
    'DATE: 19/3/21
    'TITLE: U3O1 Part II Folio SAC

    '--sets Validation boolean as false by default and defines SelectedRating for later use
    Dim blnInputDataOK = False
    Dim SelectedRating As String

    '--when basic display button is clicked, displays contents of textfile via streamreader
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        lsbDisplay.Items.Clear()
        Dim Names1File As StreamReader = File.OpenText("NamesData.txt")
        Dim Name As String
        Dim Rating As String
        Dim Year As String
        '--opens textfile loops through data until complete
        Do While Names1File.Peek <> -1
            Name = Names1File.ReadLine()
            Rating = Names1File.ReadLine()
            Year = Names1File.ReadLine()
            '--outputs data to listbox in one line
            lsbDisplay.Items.Add(Name & ", " & Rating & ", " & Year)
        Loop
        '--closes file
        Names1File.Close()
    End Sub

    '--when sort button is clicked, runs DoSelection & DoValidation subroutine, then DoActions subroutine if data is correct
    Private Sub btnRating_Click(sender As Object, e As EventArgs) Handles btnRating.Click
        blnInputDataOK = False
        DoSelection()
        DoValidation()
        'checks if IF statements in DoValidation subroutine are fulfilled and runs DoActions
        If blnInputDataOK = True Then
            DoActionSelection()
        End If
    End Sub

    '--saves value of combobox selection via Select Case
    Private Sub DoSelection()
        SelectedRating = cbxRating.SelectedItem
        '--uses Select Case to assign value
        Select Case SelectedRating
            Case "G"
                SelectedRating = ("G")
            Case "PG"
                SelectedRating = ("PG")
            Case "MA"
                SelectedRating = ("MA")
            Case "R18+"
                SelectedRating = ("R18+")

            Case Else
                SelectedRating = ("Valid Rating Not Found")
        End Select
    End Sub

    '--validates combobox selection via IF statement
    Private Sub DoValidation()
        '--existence check
        If (String.IsNullOrEmpty(cbxRating.Text)) Then
            MessageBox.Show("Enter a rating", "Error")
            cbxRating.Focus()
        Else
            blnInputDataOK = True
        End If
    End Sub

    '-- sorted action subroutine reads file and uses IF statement for sort
    Private Sub DoActionSelection()
        'Reads file
        lsbDisplay.Items.Clear()
        Dim Names1File As StreamReader = File.OpenText("NamesData.txt")
        Dim Name As String
        Dim Rating As String
        Dim Year As String
        '--loops through textfile 
        Do While Names1File.Peek <> -1
            Name = Names1File.ReadLine()
            Rating = Names1File.ReadLine
            Year = Names1File.ReadLine
            '--IF statement checking if selected combobox rating matches data input and outputs if matches 
            If Rating = SelectedRating Then
                lsbDisplay.Items.Add(Name & ", " & Rating & ", " & Year)
            End If
        Loop
        Names1File.Close()
    End Sub

    '--when button clicked, switches to form 1
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form1.Show()
        Me.Hide()
    End Sub

End Class