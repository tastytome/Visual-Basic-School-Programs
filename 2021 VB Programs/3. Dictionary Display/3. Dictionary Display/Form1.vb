﻿Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Module Module 1
        'Sub Main(ByVal args as String())
        ' Create a new dictionary with int keys and string values.
        Dim dct As Dictionary(Of Integer, String) = New Dictionary(Of Integer, String)()
        ' Add elements to the dictionary object
        ' No duplicate keys allowed but values can be duplicate
        dct.Add(1, "Suresh")
        dct.Add(4, "Rohini")
        dct.Add(2, "Trishi")
        dct.Add(3, Nothing)

        Dim ThingNum As Integer
        Dim PersonName As String
        ThingNum = InputBox("Enter Number")
        PersonName = InputBox("Enter Name")
        dct.Add(ThingNum, PersonName)

        ' Another way to add elements.
        ' If key Not exist, then that key adds a new key/value pair.
        dct(5) = "Trishi"
        ' Add method throws an exception if key already in the dictionary
        Try
            dct.Add(2, "Praveen")
        Catch __unusedArgumentException1__ As ArgumentException
            'Console.WriteLine("An element with Key = '2' already exists.")
            lsbDisplay.Items.Add("An element with Key = '2' already exists.")
        End Try
        'Console.WriteLine("*********Dictionary1 Elements********")
        lsbDisplay.Items.Add("*********Dictionary1 Elements********")
        ' Accessing elements as KeyValuePair objects
        For Each item As KeyValuePair(Of Integer, String) In dct
            'Console.WriteLine("Key = {0}, Value = {1}", item.Key, item.Value)
            lsbDisplay.Items.Add("Key = {0}" & "Value = {1}" & " " & item.Key & " " & item.Value)
        Next
        ' Creating and initializing dictionary
        Dim dct2 As Dictionary(Of String, Integer?) = New Dictionary(Of String, Integer?) From {
                {"msg2", 1},
                {"msg3", 20},
                {"msg4", 100},
                {"msg1", Nothing}
            }
        'Console.WriteLine("*********Dictionary2 Elements********")
        lsbDisplay.Items.Add("*********Dictionary2 Elements********")
        ' Accessing elements as KeyValuePair objects
        For Each item As KeyValuePair(Of String, Integer?) In dct2
            'Console.WriteLine("Key = {0}, Value = {1}", item.Key, item.Value)
            lsbDisplay.Items.Add("Key = {0}" & "Value = {1}" & item.Key & item.Value)
        Next
        'Console.ReadLine()
    End Sub
    'End Module

End Class


