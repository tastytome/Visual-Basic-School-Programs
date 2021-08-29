Imports System.Xml
Public Class Form1
    'AUTHOR: Thomas Khai Tran
    'DATE: 14.05.2021
    'TITLE: U3O1 Part IV Folio SAC

    'JUSTIFICATIONS:

    '--Visual Basic .NET framework was suitable given built-in features such as ability to convert string values to integers via Val/CDbl

    '--Do...While Loop statements were suitable as it is a control flow statement that can execute a block of code repeatedly until
    '--meeting a condition at the end of the block. 

    '--Select Case statements suitable as allowed for a specific block of code to be executed out of selected combobox options for rating

    '--IF...Else statements were suitable as it allowed execution of code given specified criteria was met (TRUE), while
    '--another set of code evaluated FALSE. IF statements were used in conjunction with boolean Yes/No to verify validation 

    '--For Each...Next statements were suitable as it is an iterative, incremental loop statement used to repeat sequence of
    '--statements for specific number of circumstances. Was used to read and publish to .xml file for each node

    'VALIDATION: 
    'Textbox inputs validated using type, range, and existence checks


    Dim blnInputDataOK As Boolean = False

    Dim strMessage As String

    Dim SelectedRating As String

    Dim strGiven As String
    Dim strSurname As String
    Dim strStreet As String
    Dim strSuburb As String
    Dim strPostcode As Integer
    Dim strMobile As Integer
    Dim strRating As String

    Dim Given(100) As String
    Dim Surname(100) As String
    Dim Street(100) As String
    Dim Suburb(100) As String
    Dim Postcode(100) As Integer
    Dim Mobile(100) As Integer
    Dim Rating(100) As String

    Dim total As Double = 0

    'Button runs validation and saves new XML file
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        blnInputDataOK = False
        DoValidation()

        'checks if IF statements in DoValidation subroutine are fulfilled and runs DoActions
        If blnInputDataOK = True Then
            DoSave()
        End If
    End Sub

    'Button overwrites XML data and creates new entry
    Private Sub DoSave()
        strGiven = txbGiven.Text
        strSurname = txbSurname.Text
        strStreet = txbStreet.Text
        strSuburb = txbSuburb.Text
        strPostcode = txbPostcode.Text
        strMobile = txbMobile.Text
        strRating = txbRating.Text
        'Dim writer As New XmlTextWriter
        Dim writer As New XmlTextWriter("XMLCustomers", System.Text.Encoding.UTF8)
        writer.Formatting = Formatting.Indented
        writer.Indentation = 2
        writer.WriteStartElement("Records")
        CreateXMLRec(strGiven, strSurname, strStreet, strSuburb, strPostcode, strMobile, strRating, writer)
        writer.WriteEndElement()
        writer.Close()
        MsgBox("Record saved successfully")
    End Sub

    'Button creates and opens XML file for usage
    Private Function CreateXMLRec(ByVal IncomingGiven As String, ByVal IncomingSurname As String, ByVal IncomingStreet As String, ByVal IncomingSuburb As String, ByVal IncomingPostcode As Integer, ByVal IncomingMobile As Integer, ByVal IncomingRating As String, ByVal writer As XmlTextWriter)

        writer.WriteStartElement("Records")

        writer.WriteStartElement("CUSTOMER")

        writer.WriteStartElement("GIVEN")
        writer.WriteString(IncomingGiven)
        writer.WriteEndElement()

        writer.WriteStartElement("SURNAME")
        writer.WriteString(IncomingSurname)
        writer.WriteEndElement()

        writer.WriteStartElement("STREET")
        writer.WriteString(IncomingStreet)
        writer.WriteEndElement()

        writer.WriteStartElement("SUBURB")
        writer.WriteString(IncomingSuburb)
        writer.WriteEndElement()

        writer.WriteStartElement("POSTCODE")
        writer.WriteString(IncomingPostcode)
        writer.WriteEndElement()

        writer.WriteStartElement("MOBILE")
        writer.WriteString(IncomingMobile)
        writer.WriteEndElement()

        writer.WriteStartElement("RATING")
        writer.WriteString(IncomingRating)
        writer.WriteEndElement()

        writer.WriteEndElement()

        writer.WriteEndElement()

    End Function

    'Button runs validation by adding customer
    Private Sub btnAddCustomer_Click(sender As Object, e As EventArgs) Handles btnAddCustomer.Click
        blnInputDataOK = False
        DoValidation()

        'checks if IF statements in DoValidation subroutine are fulfilled and runs DoActions
        If blnInputDataOK = True Then
            DoAppend()
        End If
    End Sub

    'action subroutine handles validation of combobox inputs via IF statement
    Private Sub DoValidation()

        blnInputDataOK = False

        '--existence checks
        If (String.IsNullOrEmpty(txbGiven.Text)) Then
            MessageBox.Show("Enter a given name", "Error")
            txbGiven.Focus()
        ElseIf (String.IsNullOrEmpty(txbSurname.Text)) Then
            MessageBox.Show("Enter a surname", "Error")
            txbSurname.Focus()
        ElseIf (String.IsNullOrEmpty(txbStreet.Text)) Then
            MessageBox.Show("Enter an street address", "Error")
            txbStreet.Focus()
        ElseIf (String.IsNullOrEmpty(txbSuburb.Text)) Then
            MessageBox.Show("Enter a suburb", "Error")
            txbSuburb.Focus()
        ElseIf (String.IsNullOrEmpty(txbPostcode.Text)) Then
            MessageBox.Show("Enter a postcode", "Error")
            txbPostcode.Focus()
        ElseIf (String.IsNullOrEmpty(txbMobile.Text)) Then
            MessageBox.Show("Enter a mobile", "Error")
            txbMobile.Focus()
        ElseIf (String.IsNullOrEmpty(txbRating.Text)) Then
            MessageBox.Show("Enter a rating", "Error")
            txbRating.Focus()

            '--type checks
        ElseIf (IsNumeric(txbGiven.Text)) = True Then
            MessageBox.Show("Input letters for given name", "Error")
            txbGiven.Focus()
        ElseIf (IsNumeric(txbSurname.Text)) = True Then
            MessageBox.Show("Input letters for surname", "Error")
            txbSurname.Focus()
        ElseIf (IsNumeric(txbSuburb.Text)) = True Then
            MessageBox.Show("Input letters for suburb", "Error")
            txbSuburb.Focus()
        ElseIf (IsNumeric(txbPostcode.Text)) = False Then
            MessageBox.Show("Input numbers for postcode", "Error")
            txbPostcode.Focus()
        ElseIf (IsNumeric(txbMobile.Text)) = False Then
            MessageBox.Show("Input numbers for mobile", "Error")
            txbMobile.Focus()
        ElseIf (IsNumeric(txbRating.Text)) = True Then
            MessageBox.Show("Input letter for rating", "Error")
            txbRating.Focus()

            '--range checks
        ElseIf (txbPostcode.Text <= 0) Then
            MessageBox.Show("Input a valid number for postcode", "Error")
            txbPostcode.Focus()
        ElseIf (txbMobile.Text >= 9999999999) Then
            MessageBox.Show("Input a nine-digit number for mobile", "Error")
            txbMobile.Focus()

        Else
            blnInputDataOK = True
        End If

    End Sub

    'Subroutine appends (adds new customer) to the xml file
    Private Sub DoAppend()
        strGiven = txbGiven.Text
        strSurname = txbSurname.Text
        strStreet = txbStreet.Text
        strSuburb = txbSuburb.Text
        strPostcode = txbPostcode.Text
        strMobile = txbMobile.Text
        strRating = txbRating.Text
        Dim cr As String = Environment.NewLine
        Dim newCD As String =
    "   <CUSTOMER>" & cr &
    "    <GIVEN>" & strGiven & "</GIVEN>" & cr &
    "    <SURNAME>" & strSurname & "</SURNAME>" & cr &
    "    <STREET>" & strStreet & "</STREET>" & cr &
    "    <SUBURB>" & strSuburb & "</SUBURB>" & cr &
    "    <POSTCODE>" & strPostcode & "</POSTCODE>" & cr &
    "    <MOBILE>" & strMobile & "</MOBILE>" & cr &
    "    <RATING>" & strRating & "</RATING>" & cr &
    "  </CUSTOMER> "
        Dim xd As New XmlDocument()
        xd.Load("XMLCustomers")

        ' Create a new XmlDocumentFragment for our document.
        Dim docFrag As XmlDocumentFragment = xd.CreateDocumentFragment()
        ' The Xml for this fragment is our newPerson string.
        docFrag.InnerXml = newCD
        ' The root element of our file is found using
        ' the DocumentElement property of the XmlDocument.
        Dim root As XmlNode = xd.DocumentElement
        ' Append our new Person to the root element.
        root.AppendChild(docFrag)
        'Save the Xml.
        xd.Save("XMLCustomers")
        MsgBox("Customer record saved successfully")
    End Sub

    'button displays contents of xml file based on tags to lisbtboxes
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim m_xmld As XmlDocument
        Dim m_nodelist As XmlNodeList
        Dim m_node As XmlNode

        lsbName.Items.Clear()
        lsbSurname.Items.Clear()
        lsbAddress.Items.Clear()
        lsbSuburb.Items.Clear()
        lsbPostcode.Items.Clear()
        lsbMobile.Items.Clear()
        lsbRating.Items.Clear()

        total = 0

        'Reads through XML file
        m_xmld = New XmlDocument
        m_xmld.Load("XMLCustomers")
        m_nodelist = m_xmld.GetElementsByTagName("CUSTOMER")
        Dim i As Integer = 0
        For Each m_node In m_nodelist
            strGiven = m_node.Item("GIVEN").InnerText
            strSurname = m_node.Item("SURNAME").InnerText
            strStreet = m_node.Item("STREET").InnerText
            strSuburb = m_node.Item("SUBURB").InnerText
            strPostcode = m_node.Item("POSTCODE").InnerText
            strMobile = m_node.Item("MOBILE").InnerText
            strRating = m_node.Item("RATING").InnerText

            lsbName.Items.Add(strGiven)
            lsbSurname.Items.Add(strSurname)
            lsbAddress.Items.Add(strStreet)
            lsbSuburb.Items.Add(strSuburb)
            lsbPostcode.Items.Add(strPostcode)
            lsbMobile.Items.Add(strMobile)
            lsbRating.Items.Add(strRating)

            '--read items into arrays
            Given(i) = strGiven
            Surname(i) = strSurname
            Street(i) = strStreet
            Suburb(i) = strSuburb
            Postcode(i) = strPostcode
            Mobile(i) = strMobile
            Rating(i) = strRating

            'Displays total amount of customers 
            total = total + 1
        Next
        MsgBox("The total number of customers is: " & total)

    End Sub

    'Button displays customers by rating 
    Private Sub btnRating_Click(sender As Object, e As EventArgs) Handles btnRating.Click
        '--subroutine saves value of combobox selection via Select Case
        SelectedRating = cbxRating.SelectedItem
        '--uses Select Case to assign value
        Select Case SelectedRating
            Case "Bronze"
                SelectedRating = ("Bronze")
            Case "Silver"
                SelectedRating = ("Silver")
            Case "Gold"
                SelectedRating = ("Gold")
            Case "Platinum"
                SelectedRating = ("Platinum")

            Case Else
                SelectedRating = ("Valid Rating Not Found")
        End Select

        Dim m_xmld As XmlDocument
        Dim m_nodelist As XmlNodeList
        Dim m_node As XmlNode

        'clears items
        lsbName.Items.Clear()
        lsbSurname.Items.Clear()
        lsbAddress.Items.Clear()
        lsbSuburb.Items.Clear()
        lsbPostcode.Items.Clear()
        lsbMobile.Items.Clear()
        lsbRating.Items.Clear()

        m_xmld = New XmlDocument
        m_xmld.Load("XMLCustomers")
        m_nodelist = m_xmld.GetElementsByTagName("CUSTOMER")
        Dim i As Integer = 0

        For Each m_node In m_nodelist
            '--IF statement checking if selected combobox rating matches data input and outputs if matches 
            'reads through XML file 
            If strRating = SelectedRating Then
                strGiven = m_node.Item("GIVEN").InnerText
                strSurname = m_node.Item("SURNAME").InnerText
                strStreet = m_node.Item("STREET").InnerText
                strSuburb = m_node.Item("SUBURB").InnerText
                strPostcode = m_node.Item("POSTCODE").InnerText
                strMobile = m_node.Item("MOBILE").InnerText
                strRating = m_node.Item("RATING").InnerText

                'adds results to listbox
                lsbName.Items.Add(strGiven)
                lsbSurname.Items.Add(strSurname)
                lsbAddress.Items.Add(strStreet)
                lsbSuburb.Items.Add(strSuburb)
                lsbPostcode.Items.Add(strPostcode)
                lsbMobile.Items.Add(strMobile)
                lsbRating.Items.Add(strRating)
            End If
        Next

    End Sub

    'button clears listboxes and textboxes
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txbGiven.Clear()
        txbSurname.Clear()
        txbStreet.Clear()
        txbSuburb.Clear()
        txbPostcode.Clear()
        txbMobile.Clear()
        txbRating.Clear()

        lsbName.Items.Clear()
        lsbSurname.Items.Clear()
        lsbAddress.Items.Clear()
        lsbSuburb.Items.Clear()
        lsbPostcode.Items.Clear()
        lsbMobile.Items.Clear()
        lsbRating.Items.Clear()

        total = 0

    End Sub

    'button closes program
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        '--Exit button to close down the application, with an Are You Sure message 
        Dim confirm_msg As Integer
        confirm_msg = MessageBox.Show("Are you sure you want to exit?", "Exit and Close",
                      MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If confirm_msg = vbYes Then
            Me.Close()
        Else
            Exit Sub
        End If
    End Sub

End Class
