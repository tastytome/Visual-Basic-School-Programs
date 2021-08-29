Imports System.IO
Imports System.Text
Public Class Form2
    'AUTHOR: Thomas Tran
    'DATE: 16/3/21
    'NAME: TextFile Example

    Dim blnInputDataOK = False

    'Validates text
    Private Sub DoInputValidation()

        'Existence check
        If (String.IsNullOrEmpty(txtName.Text)) Then
            MessageBox.Show("Enter a name", "Error")
            txtName.Focus()
            'Type check
        ElseIf (IsNumeric(txtName.Text)) = True Then
            MessageBox.Show("Input letters for the name", "Error")
            txtName.Focus()
        Else
            blnInputDataOK = True
        End If

    End Sub

    'Adds name to textfile by running DoActions IF validated
    Private Sub btnAddName_Click(sender As Object, e As EventArgs) Handles btnAddName.Click
        blnInputDataOK = False
        DoInputValidation()

        If blnInputDataOK = True Then
            DoActions()
        End If
    End Sub

    'Subroutine to add names
    Private Sub DoActions()
        Dim NamesFile As StreamWriter = File.AppendText("NamesData.txt")
        'append means add to the text file
        NamesFile.WriteLine(txtName.Text)
        MessageBox.Show("This name has been added to the inventory file")
        NamesFile.Close()
    End Sub

    'Displays contents of textfile
    Private Sub btnDisplayNames_Click(sender As Object, e As EventArgs) Handles btnDisplayNames.Click
        lsbDisplay.Items.Clear()
        Dim Names1File As StreamReader = File.OpenText("NamesData.txt")
        Dim Name As String
        Do While Names1File.Peek <> -1
            Name = Names1File.ReadLine()
            lsbDisplay.Items.Add(Name)
        Loop
        Names1File.Close()
    End Sub

    'Goes to previous form 
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form1.Show()
        Me.Hide()
    End Sub

    'Clears form
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtName.Clear()
        lsbDisplay.Items.Clear()
    End Sub

    'Prompts program exit confirmation via messagebox  yes/no response
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim Response As Integer
        Response = MessageBox.Show("Do you really want to exit?", "",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Response = vbYes Then
            Me.Close()
        End If
    End Sub

End Class
