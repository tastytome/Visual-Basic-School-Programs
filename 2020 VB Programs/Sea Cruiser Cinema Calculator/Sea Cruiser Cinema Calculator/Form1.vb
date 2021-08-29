Public Class Form1

    '================================================== (Definitions)

    Dim intMember As Integer
    Dim strMovie As String
    Dim intMovieChild As Integer
    Dim intMovieAdult As Integer
    Dim intMovieConcession As Integer
    Dim dblCost As Double

    '==================================================  (Vehicle Fares)

    Private Sub rbnMember_CheckedChanged(sender As Object, e As EventArgs) Handles rbnMember.CheckedChanged
        intMember = -5
    End Sub

    '==================================================  (Child & Adult Fares)

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim intAdult As Integer = Val(txtAdult.Text)
        Dim intChild As Integer = Val(txtChild.Text)
        Dim intConcession As Integer = Val(txtConcession.Text)

        '================================================== (Movie Costs)

        Select Case cbxMovie.SelectedIndex
            Case 0
                strMovie = "General: Batman versus Godzilla"
                intMovieChild = 15 * intChild
                intMovieAdult = 25 * intAdult
                intMovieConcession = 10 * intConcession
            Case 1
                strMovie = "Gold Class: Batman versus Godzilla"
                intMovieChild = 30 * intChild
                intMovieAdult = 50 * intAdult
                intMovieConcession = 20 * intConcession
            Case 2
                strMovie = "General: Spiderman and the Fly"
                intMovieChild = 15 * intChild
                intMovieAdult = 25 * intAdult
                intMovieConcession = 10 * intConcession
            Case 3
                strMovie = "Gold Class: Spiderman and the Fly"
                intMovieChild = 30 * intChild
                intMovieAdult = 50 * intAdult
                intMovieConcession = 20 * intConcession
            Case 4
                strMovie = "General: Wonder Woman Saves the World"
                intMovieChild = 15 * intChild
                intMovieAdult = 25 * intAdult
                intMovieConcession = 10 * intConcession
            Case 5
                strMovie = "Gold Class: Wonder Woman Saves the World"
                intMovieChild = 30 * intChild
                intMovieAdult = 50 * intAdult
                intMovieConcession = 20 * intConcession

        End Select

        '================================================== (Output Info)

        txtMovie.Text = strMovie

        dblCost = intMember + intMovieAdult + intMovieChild + intMovieConcession
        txtCost.Text = "$" & dblCost

    End Sub

End Class