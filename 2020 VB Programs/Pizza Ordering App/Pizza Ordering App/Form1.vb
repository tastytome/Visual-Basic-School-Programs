Public Class Form1
    Dim DblSize As Double
    Dim StrPizza As String
    Dim DblType As Double
    Dim DblDelivery As Double
    Dim DblPrice As Double

    Private Sub RbnSmall_CheckedChanged(sender As Object, e As EventArgs) Handles RbnSmall.CheckedChanged
        DblSize = 10.5
    End Sub
    Private Sub RbnMedium_CheckedChanged(sender As Object, e As EventArgs) Handles RbnMedium.CheckedChanged
        DblSize = 11.5
    End Sub
    Private Sub RbnLarge_CheckedChanged(sender As Object, e As EventArgs) Handles RbnLarge.CheckedChanged
        DblSize = 2.0
    End Sub
    Private Sub RbnXLarge_CheckedChanged(sender As Object, e As EventArgs) Handles RbnXLarge.CheckedChanged
        DblSize = 15.5
    End Sub

    Private Sub BtnOrder_Click(sender As Object, e As EventArgs) Handles BtnOrder.Click

        Select Case CbxPizzas.SelectedIndex
            Case 0
                StrPizza = "Hawaiian"
            Case 1
                StrPizza = "Capricciosa"
            Case 2
                StrPizza = "Aussie"
            Case 3
                StrPizza = "Meat Lovers"
                DblType = 2.5
                MsgBox("There will be an extra charge of $2.50")
            Case 4
                StrPizza = "Four Seasons"
            Case 5
                StrPizza = "Supreme"
                DblType = 3.0
                MsgBox("There will be an extra charge of $3.00")
            Case 6
                StrPizza = "Margarita"

        End Select

        If ChxDelivery.Checked = True Then
            DblDelivery = 5
        Else
            DblDelivery = 0
        End If

        DblPrice = DblSize + DblType + DblDelivery

        LblCost.Text = "You have ordered a " & StrPizza & " at $" & DblPrice

    End Sub

End Class