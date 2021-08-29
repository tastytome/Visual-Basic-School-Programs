Public Class Form1
    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        Dim Guess As Integer
        Dim CountDown As Integer

        Dim Answer As Integer
        Dim RandomNumber As New Random
        Answer = RandomNumber.Next(0, 10)

        pbxLose.Visible = False
        pbxWin.Visible = False

        For i = 1 To 3
            CountDown = 3 - i
            Guess = InputBox("Guess the Number! ")

            If Guess = Answer Then
                pbxWin.Visible = True
                Exit For
            ElseIf Guess < Answer Then
                MsgBox("Higher! You have " & CountDown & " guesses left.")
                lbxGuesses.Items.Add(Guess)
            ElseIf Guess > Answer Then
                MsgBox("Lower! You have " & CountDown & " guesses left.")
                lbxGuesses.Items.Add(Guess)
            End If
        Next
        pbxLose.Visible = True
    End Sub
End Class
