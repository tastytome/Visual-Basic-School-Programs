Public Class Form1
    '--Program to do "Selection Sort" on an Array containing Integer Whole Numbers

    '---SELECTION SORT TO SORT AN ARRAY OF TEN NUMBERS INTO ASCENDING ORDER---

    '--Setup an Array that can hold ten whole numbers. 
    '--Note that we if we were not filling in the array with data we would need to 
    '--use a 9 And Not a 10 For the Array definition as: Dim NbrsArray(9) As Integer
    '--Because indexing starts at Zero, we have 0 to 9 = 10 items capacity in Array. 

    Dim NbrsArray() As Integer = {14, 13, 20, 18, 17, 15, 16, 12, 11, 19}

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '--Load up the Unsorted Listbox on the Form with a Heading followed the Array Data.
        ListBoxUnsorted.Items.Add("--------------------------")
        ListBoxUnsorted.Items.Add("Unsorted Array")
        ListBoxUnsorted.Items.Add("--------------------------")

        For i = 0 To NbrsArray.Count - 1
            ListBoxUnsorted.Items.Add(NbrsArray(i))
        Next

        '--Note for the above Loop through the Array from start to finish we could
        '--also have used the lower and upper Bounds: eg. For LBound(NbrsArray) To UBound(NbrsArray)

    End Sub

    Private Sub btnSort_Click(sender As Object, e As EventArgs) Handles btnSort.Click
        '--We now apply the Selection Sort Algorithm to sort the Array into Ascending Order. 

        Dim lowerbound As Integer = LBound(NbrsArray) '--start index of array

        Dim upperbound As Integer = UBound(NbrsArray) '--end Index of Array

        Dim i As Integer = 0   '--Main Loop Counter for array processing

        Dim j As Integer = 0   '--Index counter Value to shuffle along 1 index step

        Dim intMinValueIndex As Integer     '--Index to move Minimum Value to  
        Dim intSwapValueIndex As Integer    '--Index Value that Min Value is found at
        Dim intSwapValue As Integer         '--Actual value of the found Minimum

        '--Now Use a Loop to go through the array doing Selection Sort Passes. 

        For i = lowerbound To upperbound

            intMinValueIndex = i
            '--Reset the saved Swap Values from the last Pass of the Array
            intSwapValue = 0
            intSwapValueIndex = 0

            For j = i + 1 To upperbound

                'START DEBUG DISPLAYS
                'MsgBox("intMinValueIndex = " & intMinValueIndex)
                'MsgBox("i value Pass Nbr = " & i)
                'MsgBox("j value = " & j)
                'MsgBox("NbrsArray(j) = " & NbrsArray(j))
                'MsgBox("NbrsArray(intMinValueIndex) = " & NbrsArray(intMinValueIndex))
                'MsgBox("NbrsArray(intSwapValueIndex) = " & NbrsArray(intSwapValueIndex))
                'END DEBUG DISPLAYS

                '--Search and find the lowest value remaining in the array 
                If NbrsArray(j) < NbrsArray(intMinValueIndex) Then

                    '--A value smaller than the current min position value has been found
                    '--so possibly store its value and its position in the array.
                    '--HOWEVER we may already have the smallest one sitting there stored.
                    '--So only overwrite and store it if it is smaller than the stored one,
                    '--except for if this is the first time a smaller found this pass.

                    '--First check for first time finding a smaller value, 
                    '--then check if smallest so far.
                    If intSwapValue = 0 Then
                        intSwapValue = NbrsArray(j)
                        intSwapValueIndex = j
                    Else
                        If NbrsArray(j) < intSwapValue Then
                            intSwapValue = NbrsArray(j)
                            intSwapValueIndex = j
                        End If
                    End If

                    '

                    'START DEBUG DISPLAYS
                    'MsgBox("Found Smaller -- NbrsArray(j) = " & NbrsArray(j) & vbCrLf &
                    '         "j = " & j & "IntSwapValueIndex = " & intSwapValueIndex & vbCrLf &
                    '         "NbrsArray(intMinValueIndex) = " & NbrsArray(intMinValueIndex) & vbCrLf &
                    '         "NbrsArray(intSwapValueIndex) = " & NbrsArray(intSwapValueIndex))
                    'END DEBUG DISPLAYS

                End If
            Next j

            If intSwapValue <> 0 Then
                '--During the current pass we have found a smaller value in the remaining array.
                '--We need to swap the value at min index to where the found swap value is
                '--and move the saved found swap value to the current min index      

                NbrsArray(intSwapValueIndex) = NbrsArray(intMinValueIndex)
                NbrsArray(intMinValueIndex) = intSwapValue

                'START DEBUG DISPLAYS
                'MsgBox("AFTER THE SWAP -- IntMinValueIndex = " & intMinValueIndex & vbCrLf &
                '         "j = " & j & "IntSwapValueIndex = " & intSwapValueIndex & vbCrLf &
                '         "NbrsArray(intMinValueIndex) = " & NbrsArray(intMinValueIndex) & vbCrLf &
                '         "NbrsArray(intSwapValueIndex) = " & NbrsArray(intSwapValueIndex))
                'END DEBUG DISPLAYS


            End If

            'Display Load of Sorted Listbox for the current Pass
            '--First clear out the previous Pass display data 
            ListBoxSORTED.Items.Clear()
            Dim strCurrentPassInfo As String = "Array Pass i = " & CStr(i)
            ListBoxSORTED.Items.Add("--------------------------")
            ListBoxSORTED.Items.Add(strCurrentPassInfo)
            ListBoxSORTED.Items.Add("--------------------------")

            For k = 0 To NbrsArray.Count - 1
                ListBoxSORTED.Items.Add(NbrsArray(k))
            Next k

            MsgBox("Click OK to continue")

            'End Debug

        Next i


        '--The Array should now be fully sorted into ascending order. 
        '--Load up the Sorted Array into the Sorted List Box to display on the Form. 

        '--First clear out the previous Pass display data 
        ListBoxSORTED.Items.Clear()
        '--Load up the Sorted Listbox on the Form with a Heading followed the Array Data.
        ListBoxSORTED.Items.Add("--------------------------")
        ListBoxSORTED.Items.Add("Final Sorted Array")
        ListBoxSORTED.Items.Add("--------------------------")

        For c = 0 To NbrsArray.Count - 1
            ListBoxSORTED.Items.Add(NbrsArray(c))
        Next

        '--Debug
        'MsgBox("the program has reached its end")


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnSort2_Click(sender As Object, e As EventArgs) Handles btnSort2.Click

        '--load data from textfile into arrays
        Dim Names(9) As String
        Dim Ages(9) As Integer
        Dim srdTestFile As IO.StreamReader
        '--Open the Input File to be read using the VB StreamReader
        srdTestFile = New IO.StreamReader("SortData2.txt")
        '--Use a Loop to read through all of the Lines in the Input File
        Dim ItemCounter As Integer = 0
        Do While Not srdTestFile.EndOfStream
            Names(ItemCounter) = srdTestFile.ReadLine
            Ages(ItemCounter) = srdTestFile.ReadLine
            ItemCounter = ItemCounter + 1
        Loop
        '--Close the file now we have finished looping through it 
        srdTestFile.Close()

        '--Display items in listbox
        ListBoxUnsorted.Items.Clear()
        ListBoxUnsorted.Items.Add("--------------------------")
        ListBoxUnsorted.Items.Add("Unsorted Array")
        ListBoxUnsorted.Items.Add("--------------------------")
        Dim p As Integer
        For p = 0 To ItemCounter - 1
            ListBoxUnsorted.Items.Add(Names(p) & ":  " & Ages(p))
        Next


        '--We now apply the Selection Sort Algorithm to sort the Array into Ascending Order. 
        Dim lowerbound As Integer = LBound(Ages) '--start index of array
        Dim upperbound As Integer = UBound(Ages) '--end Index of Array

        Dim i As Integer = 0   '--Main Loop Counter for array processing
        Dim j As Integer = 0   '--Index counter Value to shuffle along 1 index step

        Dim intMinValueIndex As Integer     '--Index to move Minimum Value to  
        Dim intSwapValueIndex As Integer    '--Index Value that Min Value is found at
        Dim intSwapValue As Integer         '--Actual value of the found Minimum
        Dim strSwapName As String

        '--Now Use a Loop to go through the array doing Selection Sort Passes. 

        For i = lowerbound To upperbound
            intMinValueIndex = i
            '--Reset the saved Swap Values from the last Pass of the Array
            intSwapValue = 0
            intSwapValueIndex = 0
            For j = i + 1 To upperbound
                '--Search and find the lowest value remaining in the array 
                If Ages(j) < Ages(intMinValueIndex) Then
                    '--First check for first time finding a smaller value, 
                    '--then check if smallest so far.
                    If intSwapValue = 0 Then
                        intSwapValue = Ages(j)
                        strSwapName = Names(j)
                        intSwapValueIndex = j
                    Else
                        If Ages(j) < intSwapValue Then
                            intSwapValue = Ages(j)
                            strSwapName = Names(j)
                            intSwapValueIndex = j
                        End If
                    End If
                End If
            Next j

            If intSwapValue <> 0 Then
                Ages(intSwapValueIndex) = Ages(intMinValueIndex)
                Names(intSwapValueIndex) = Names(intMinValueIndex)
                Ages(intMinValueIndex) = intSwapValue
                Names(intMinValueIndex) = strSwapName
            End If

            'Display Load of Sorted Listbox for the current Pass
            '--First clear out the previous Pass display data 
            ListBoxSORTED.Items.Clear()
            Dim strCurrentPassInfo As String = "Array Pass i = " & CStr(i)
            ListBoxSORTED.Items.Add("--------------------------")
            ListBoxSORTED.Items.Add(strCurrentPassInfo)
            ListBoxSORTED.Items.Add("--------------------------")
            For k = 0 To NbrsArray.Count - 1
                ListBoxSORTED.Items.Add(Ages(k) & ":  " & Names(k))
            Next k
            MsgBox("Click OK to continue")
        Next i


        '--The Array should now be fully sorted into ascending order. 
        '--Load up the Sorted Array into the Sorted List Box to display on the Form. 

        '--First clear out the previous Pass display data 
        ListBoxSORTED.Items.Clear()
        '--Load up the Sorted Listbox on the Form with a Heading followed the Array Data.
        ListBoxSORTED.Items.Add("--------------------------")
        ListBoxSORTED.Items.Add("Final Sorted Array")
        ListBoxSORTED.Items.Add("--------------------------")
        For c = 0 To Ages.Count - 1
            ListBoxSORTED.Items.Add(Ages(c) & ":  " & Names(c))
        Next
    End Sub
End Class
