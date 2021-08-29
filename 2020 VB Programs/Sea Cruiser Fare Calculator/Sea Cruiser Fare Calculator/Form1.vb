Public Class Form1

    '================================================== (Definitions)

    Dim intVehicle As Integer
    Dim strSeason As String
    Dim intSeasonChild As Integer
    Dim intSeasonAdult As Integer
    Dim dblFare As Double

    '==================================================  (Vehicle Fares)

    Private Sub rbnNone_CheckedChanged(sender As Object, e As EventArgs) Handles rbnNone.CheckedChanged
        intVehicle = 0.0
    End Sub
    Private Sub rbnCar_CheckedChanged(sender As Object, e As EventArgs) Handles rbnCar.CheckedChanged
        intVehicle = 99.0
    End Sub
    Private Sub rbnMotorcycle_CheckedChanged(sender As Object, e As EventArgs) Handles rbnMotorcycle.CheckedChanged
        intVehicle = 30.0
    End Sub

    '==================================================  (Child & Adult Fares)

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim fltAdult As Integer = Val(txtAdult.Text)
        Dim fltChild As Integer = Val(txtChild.Text)
        Dim intAdult As Integer = 250 * fltAdult
        Dim intChild As Integer = 150 * fltChild

        '================================================== (Seasonal Fares)

        Select Case cbxSeason.SelectedIndex
            Case 0
                strSeason = "Summer"
                intSeasonChild = 30 * fltChild
                intSeasonAdult = 50 * fltAdult
            Case 1
                strSeason = "Autumn"
                intSeasonChild = 0
                intSeasonAdult = 0
            Case 2
                strSeason = "Winter"
                intSeasonChild = -30 * fltChild
                intSeasonAdult = -50 * fltAdult
            Case 3
                strSeason = "Spring"
                intSeasonChild = 0
                intSeasonAdult = 0

        End Select

        '================================================== (Output Info)

        txtSeason.Text = strSeason

        dblFare = intVehicle + intAdult + intChild + intSeasonAdult + intSeasonChild
        txtFare.Text = "$" & dblFare

    End Sub

End Class
