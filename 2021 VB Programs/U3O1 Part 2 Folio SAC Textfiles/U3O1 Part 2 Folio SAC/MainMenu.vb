Imports System.IO
Imports System.Text
Public Class FrmMainMenu
    'AUTHOR: Thomas Khai Tran
    'DATE: 19/3/21
    'TITLE: U3O1 Part II Folio SAC

    '--when button clicked, switches to booking form
    Private Sub btnAddNewCustomer_Click(sender As Object, e As EventArgs) Handles btnAddNewCustomer.Click
        FrmAddBooking.Show()
        Me.Hide()
    End Sub

    '--when button is clicked, switches to reports form
    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        FrmReports.Show()
        Me.Hide()
    End Sub

    '--when button is clicked prompts program exit confirmation via messagebox yes/no response
    Private Sub btnExit_Click_1(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim Response As Integer
        Response = MessageBox.Show("Do you really want to exit?", "",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Response = vbYes Then
            Me.Close()
        End If
    End Sub

End Class