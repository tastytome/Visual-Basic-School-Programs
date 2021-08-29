Imports System.Text

Public Class Form1
    '- AUTHOR: Thomas Tran
    '- Date Modified: 29/05/2020

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        '-Calculate Cost of Meal Order

        '- Declare Variables
        Dim dblEntree As Double
        Dim dblMain As Double
        Dim dblDessert As Double
        Dim dblDrink As Double
        Dim dblCost As Double

        '- Get entree from textbox
        Select Case cbxEntree.SelectedIndex
            Case 0
                dblEntree = 5.5
            Case 1
                dblEntree = 9.0
            Case 2
                dblEntree = 10.5
            Case 3
                dblEntree = 8.8
        End Select

        '- Get main from textbox
        Select Case cbxMain.SelectedIndex
            Case 0
                dblMain = 25.0
            Case 1
                dblMain = 18.5
            Case 2
                dblMain = 20.5
            Case 3
                dblMain = 19.0
        End Select

        '- Get dessert from textbox
        Select Case cbxDessert.SelectedIndex
            Case 0
                dblDessert = 11.0
            Case 1
                dblDessert = 15.5
            Case 2
                dblDessert = 9.5
            Case 3
                dblDessert = 12.0
            Case 4
                dblDessert = 16.5
        End Select

        '- Determine type of drink selected
        If rbtCoke.Checked = True Then dblDrink = 5
        If rbtChocolate.Checked = True Then dblDrink = 6
        If rbtWater.Checked = True Then dblDrink = 4

        '- Calculate the cost
        dblCost = dblEntree + dblMain + dblDessert + dblDrink

        '- Calculate cost and member discount
        If rbtMember.Checked = True Then
            dblCost = (0.9 * (dblEntree + dblMain + dblDessert + dblDrink))
        Else
            dblCost = dblEntree + dblMain + dblDessert + dblDrink
        End If

        '- Display the cost
        txtCost.Text = "$" & dblCost

    End Sub



    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        '- Reset radio buttons and selections for trials

        rbtMember.Checked = False
        rbtCoke.Checked = False
        rbtWater.Checked = False
        rbtChocolate.Checked = False
        cbxDessert.Text = Nothing
        cbxEntree.Text = Nothing
        cbxMain.Text = Nothing
        txtRoom.Text = Nothing
        txtCost.Text = Nothing

    End Sub
End Class