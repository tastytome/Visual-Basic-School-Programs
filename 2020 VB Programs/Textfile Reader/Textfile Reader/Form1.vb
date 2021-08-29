Imports System.IO
Imports System.Text

Public Class Form1

    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        Dim TestScores(2) As Integer
        Dim names(2) As String
        Dim ExampleFile As StreamReader = File.OpenText("C:\Users\TRA0028\Desktop\TestScoresData.txt")
        lstData.Items.Clear()
        For i = 0 To 2
            names(i) = ExampleFile.ReadLine()
            TestScores(i) = ExampleFile.ReadLine()
            lstData.Items.Add(names(i) & "   " & TestScores(i))
        Next
        ExampleFile.Close()
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Dim ExampleFile As StreamWriter = File.CreateText("C:\Users\TRA0028\Desktop\TestScoresData.txt")
        Dim TestScore As Integer
        Dim Name As String
        For i = 0 To 2
            Name = InputBox("Enter the student name", "Name")
            ExampleFile.WriteLine(Name)
            TestScore = InputBox("Enter the test score out of 100", "Score")
            ExampleFile.WriteLine(TestScore)
        Next
        ExampleFile.Close()
    End Sub

    Private Sub btnReadBin_Click(sender As Object, e As EventArgs) Handles btnReadBin.Click
        Dim names(2) As String
        Dim TestScores(2) As Integer
        Dim ItemCounter As Integer

        lstData.Items.Clear()

        '--Specify the TestScoresData text input file needed by the program
        '--MANUALLY COPY THIS TEXT FILE INTO THE BIN\DEBUG FOLDER OF THIS PROJECT
        '--and then we do NOT need to use a path name like D:\MyPgms\Horoscopes.txt
        Dim myTextFile As Object = "TestScoresData.txt"
        Dim srdTestScoresFile As IO.StreamReader

        '--Open the Input File to be read using the VB StreamReader
        srdTestScoresFile = New IO.StreamReader("TestScoresData.txt")

        '--Use a Loop to read through all of the Lines in the Input File
        '--and add each line to the arrays
        ItemCounter = 0
        Do While Not srdTestScoresFile.EndOfStream
            names(ItemCounter) = srdTestScoresFile.ReadLine
            TestScores(ItemCounter) = srdTestScoresFile.ReadLine
            ItemCounter = ItemCounter + 1
        Loop
        '--Close the file now we have finished looping through it 
        srdTestScoresFile.Close()
        '--display the contents of the arrays
        For i = 0 To ItemCounter - 1
            lstData.Items.Add(names(i) & " scored " & TestScores(i))
        Next
    End Sub


    Private Sub btnHouse_Click(sender As Object, e As EventArgs) Handles btnHouse.Click
        Dim names(10) As String
        Dim houses(10) As String
        Dim points(10) As Integer
        Dim ItemCounter As Integer

        lstData.Items.Clear()

        Dim myTextFile As Object = "HousePointsData.txt"
        Dim srdHousePointsFile As IO.StreamReader

        srdHousePointsFile = New IO.StreamReader("HousePointsData.txt")

        ItemCounter = 0
        Do While Not srdHousePointsFile.EndOfStream
            names(ItemCounter) = srdHousePointsFile.ReadLine
            houses(ItemCounter) = srdHousePointsFile.ReadLine
            points(ItemCounter) = srdHousePointsFile.ReadLine
            ItemCounter = ItemCounter + 1
        Loop

        srdHousePointsFile.Close()

        For i = 0 To ItemCounter - 1
            lstData.Items.Add(names(i) & " scored " & points(i) & " for " & houses(i))

        Next

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        '--read data from textfile into array - coppied from previous button
        Dim name As String
        Dim score As Integer
        Dim names() As String
        Dim TestScores() As Integer
        Dim ItemCounter As Integer
        lstData.Items.Clear()
        '--Specify the TestScoresData text input file needed by the program
        '--MANUALLY COPY THIS TEXT FILE INTO THE BIN\DEBUG FOLDER OF THIS PROJECT
        Dim myTextFile As Object = "TestScoresData.txt"
        Dim srdTestScoresFile As IO.StreamReader
        '--Open the Input File to be read using the VB StreamReader
        srdTestScoresFile = New IO.StreamReader("TestScoresData.txt")
        '--Use a Loop to read through all of the Lines in the Input File
        ItemCounter = 0
        Do While Not srdTestScoresFile.EndOfStream
            name = srdTestScoresFile.ReadLine
            score = srdTestScoresFile.ReadLine
            ItemCounter = ItemCounter + 1
        Loop
        '--Close the file now we have finished looping through it 
        srdTestScoresFile.Close()
        ReDim names(ItemCounter)
        ReDim TestScores(ItemCounter)
        srdTestScoresFile = New IO.StreamReader("TestScoresData.txt")
        For i = 0 To ItemCounter
            names(i) = srdTestScoresFile.ReadLine
            TestScores(i) = srdTestScoresFile.ReadLine
        Next
        '--display the contents of the arrays
        For i = 0 To ItemCounter - 1
            lstData.Items.Add(names(i) & " scored " & TestScores(i))
        Next

        '--Linear Search of Array from start to finish of array until item Found OR End of Array.
        '--Initialise variables 
        Dim blnItemFound As Boolean = False
        Dim blnEndOfArray As Boolean = False
        Dim intSubscript As Integer = 0
        Dim intMaxSubscript As Integer
        '--Determine the end of array Max Subscript by doing Array Length minus 1 because 
        '--First Subscript in Visual Basic is 0 and not 1. 
        intMaxSubscript = ItemCounter - 1
        '--Get the User Input Search request from the Form Text Box. 
        Dim strSearchRequestItem As String
        strSearchRequestItem = InputBox("Please enter the name you wish to search for:", "Name Search")

        '--Use a While Loop to do a Linear Search of the Array
        While blnItemFound = False And blnEndOfArray = False
            If strSearchRequestItem = names(intSubscript) Then
                blnItemFound = True

            ElseIf intSubscript = intMaxSubscript Then
                blnEndOfArray = True
            Else
                intSubscript = intSubscript + 1
            End If
        End While
        '--Output the results into the Label on the Form 
        If blnItemFound = True Then
            lstData.Items.Add(strSearchRequestItem & " is in the textfile")
        Else
            lstData.Items.Add(strSearchRequestItem & " was Not Found")
        End If
    End Sub
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        '- Reset program for faster testing convenience

        lstData.Items.Clear()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class