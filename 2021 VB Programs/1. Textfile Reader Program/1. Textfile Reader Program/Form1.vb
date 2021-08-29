Imports System.IO
Imports System.Text
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim TestScores(19)
        Dim names(19) As String
        Dim itemCounter As Integer
        Dim ScoreTotal As Integer
        Dim AverageScore As Double = 90
        Dim HighestScore As Integer = -1
        Dim LowestScore As Integer = 101
        Dim myTextFile As Object = "TestScores.txt"
        Dim srdTestScoresFile As IO.StreamReader
        '--Open the Input File to be read using the VB Stream Reader
        srdTestScoresFile = New IO.StreamReader("TestScores.txt")
        Do While Not srdTestScoresFile.EndOfStream
            names(itemCounter) = srdTestScoresFile.ReadLine
            TestScores(itemCounter) = srdTestScoresFile.ReadLine
            itemCounter = itemCounter + 1
        Loop
        '--Close the file after looping has finished
        srdTestScoresFile.Close()
        '--Display the contents of the array
        For i = 0 To itemCounter - 1
            lstData.Items.Add(names(i) & " " & TestScores(i))
            ScoreTotal = ScoreTotal + TestScores(i)
        Next
        AverageScore = ScoreTotal / itemCounter
        lstData.Items.Add("The average test score is " & AverageScore)
        '--Find the highest score
        For i = 0 To itemCounter - 1
            If TestScores(i) > HighestScore Then
                HighestScore = TestScores(i)
            End If
        Next
        lstData.Items.Add("The highest test score is " & HighestScore)
        '--Find the lowest score
        For i = 0 To itemCounter - 1
            If TestScores(i) < HighestScore Then
                LowestScore = TestScores(i)
            End If
        Next
        lstData.Items.Add("The lowest test score is " & LowestScore)
    End Sub
End Class
