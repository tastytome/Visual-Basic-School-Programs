Imports System.Xml
Public Class Form1
    'AUTHOR: Thomas Khai Tran
    'DATE: 14.05.2021
    'TITLE: U3O1 Part IV Folio SAC

    'JUSTIFICATIONS:

    '--Visual Basic .NET framework was suitable given built-in features such as ability to convert string values to integers via Val/CDbl

    '--Do...While Loop statements were suitable as it is a control flow statement that can execute a block of code repeatedly until
    '--meeting a condition at the end of the block. 

    '--IF...Else statements were suitable as it allowed execution of code given specified criteria was met (TRUE), while
    '--another set of code evaluated FALSE. IF statements were used in conjunction with boolean Yes/No to verify validation 

    '--For Each...Next statements were suitable as it is an iterative, incremental loop statement used to repeat sequence of
    '--statements for specific number of circumstances. Was used to read and publish to .xml file

    Dim blnInputDataOK As Boolean = False

    Dim strMessage As String

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

    Dim totalValueCD As Double = 0

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
        ElseIf (txbMobile.Text <= 0) Then
            MessageBox.Show("Input a value number for mobile", "Error")
            txbMobile.Focus()

        Else
            blnInputDataOK = True
        End If

    End Sub

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

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim m_xmld As XmlDocument
        Dim m_nodelist As XmlNodeList
        Dim m_node As XmlNode

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
        Next

    End Sub

    Private Sub btnRating_Click(sender As Object, e As EventArgs) Handles btnRating.Click

    End Sub

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

        totalValueCD = 0

    End Sub

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
