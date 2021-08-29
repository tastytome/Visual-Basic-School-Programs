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

    Dim strTitleCD As String
    Dim strArtistCD As String
    Dim strCountriesCD As String
    Dim strCompaniesCD As String
    Dim strPriceCD As String
    Dim strYearCD As String

    Dim TitleCD(100) As String
    Dim ArtistCD(100) As String
    Dim CountriesCD(100) As String
    Dim CompaniesCD(100) As String
    Dim PriceCD(100) As Double
    Dim YearCD(100) As String
    Dim totalValueCD As Double = 0

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        blnInputDataOK = False
        DoValidation()

        'checks if IF statements in DoValidation subroutine are fulfilled and runs DoActions
        If blnInputDataOK = True Then
            DoSave()
        End If
    End Sub

    Private Sub DoSave()
        strTitleCD = txtTitle.Text
        strArtistCD = txtArtist.Text
        strCountriesCD = txtCountry.Text
        strCompaniesCD = txtCompany.Text
        strPriceCD = txtPrice.Text
        strYearCD = txtYear.Text
        'Dim writer As New XmlTextWriter
        Dim writer As New XmlTextWriter("XML_CD_Collection.xml", System.Text.Encoding.UTF8)
        writer.Formatting = Formatting.Indented
        writer.Indentation = 2
        writer.WriteStartElement("Records")
        CreateXMLRec(strTitleCD, strArtistCD, strCountriesCD, strCompaniesCD, strPriceCD, strYearCD, writer)
        writer.WriteEndElement()
        writer.Close()
        MsgBox("Record saved successfully")
    End Sub

    Private Function CreateXMLRec(ByVal IncomingTitle As String, ByVal IncomingArtist As String, ByVal IncomingCountry As String, ByVal IncomingCompany As String, ByVal IncomingPrice As Double, ByVal IncomingYear As Integer, ByVal writer As XmlTextWriter)

        writer.WriteStartElement("Record")

        writer.WriteStartElement("CD")

        writer.WriteStartElement("TITLE")
        writer.WriteString(IncomingTitle)
        writer.WriteEndElement()

        writer.WriteStartElement("ARTIST")
        writer.WriteString(IncomingArtist)
        writer.WriteEndElement()

        writer.WriteStartElement("COUNTRY")
        writer.WriteString(IncomingCountry)
        writer.WriteEndElement()

        writer.WriteStartElement("COMPANY")
        writer.WriteString(IncomingCompany)
        writer.WriteEndElement()

        writer.WriteStartElement("PRICE")
        writer.WriteString(IncomingPrice)
        writer.WriteEndElement()

        writer.WriteStartElement("YEAR")
        writer.WriteString(IncomingYear)
        writer.WriteEndElement()

        writer.WriteEndElement()

        writer.WriteEndElement()

    End Function

    'action subroutine handles validation of combobox inputs via IF statement
    Private Sub DoValidation()

        blnInputDataOK = False

        '--existence checks
        If (String.IsNullOrEmpty(txtTitle.Text)) Then
            MessageBox.Show("Enter a title", "Error")
            txtTitle.Focus()
        ElseIf (String.IsNullOrEmpty(txtArtist.Text)) Then
            MessageBox.Show("Enter an artist", "Error")
            txtArtist.Focus()
        ElseIf (String.IsNullOrEmpty(txtCountry.Text)) Then
            MessageBox.Show("Enter a country", "Error")
            txtCountry.Focus()
        ElseIf (String.IsNullOrEmpty(txtCompany.Text)) Then
            MessageBox.Show("Enter a company", "Error")
            txtCompany.Focus()
        ElseIf (String.IsNullOrEmpty(txtPrice.Text)) Then
            MessageBox.Show("Enter a price", "Error")
            txtPrice.Focus()
        ElseIf (String.IsNullOrEmpty(txtYear.Text)) Then
            MessageBox.Show("Enter a year", "Error")
            txtYear.Focus()

            '--type checks
        ElseIf (IsNumeric(txtTitle.Text)) = True Then
            MessageBox.Show("Input letters for title", "Error")
            txtTitle.Focus()
        ElseIf (IsNumeric(txtArtist.Text)) = True Then
            MessageBox.Show("Input letters for artist", "Error")
            txtArtist.Focus()
        ElseIf (IsNumeric(txtCountry.Text)) = True Then
            MessageBox.Show("Input letters for country", "Error")
            txtCountry.Focus()
        ElseIf (IsNumeric(txtCompany.Text)) = True Then
            MessageBox.Show("Input letters for company", "Error")
            txtCompany.Focus()
        ElseIf (IsNumeric(txtPrice.Text)) = False Then
            MessageBox.Show("Input numbers for price", "Error")
            txtPrice.Focus()
        ElseIf (IsNumeric(txtYear.Text)) = False Then
            MessageBox.Show("Input numbers for year", "Error")
            txtYear.Focus()

            '--range checks
        ElseIf (txtPrice.Text <= 0) Then
            MessageBox.Show("Input a value Greater than 0 for price", "Error")
            txtPrice.Focus()
        ElseIf (txtYear.Text <= 0) Then
            MessageBox.Show("Input a value Greater than 0 for year", "Error")
            txtYear.Focus()

        Else
            blnInputDataOK = True
        End If

    End Sub

    Private Sub btnAppend_Click(sender As Object, e As EventArgs) Handles btnAppend.Click
        blnInputDataOK = False
        DoValidation()

        'checks if IF statements in DoValidation subroutine are fulfilled and runs DoActions
        If blnInputDataOK = True Then
            DoAppend()
        End If
    End Sub

    Private Sub DoAppend()
        strTitleCD = txtTitle.Text
        strArtistCD = txtArtist.Text
        strCountriesCD = txtCountry.Text
        strCompaniesCD = txtCompany.Text
        strPriceCD = txtPrice.Text
        strYearCD = txtYear.Text
        Dim cr As String = Environment.NewLine
        Dim newCD As String =
    "   <CD>" & cr &
    "    <TITLE>" & strTitleCD & "</TITLE>" & cr &
    "    <ARTIST>" & strArtistCD & "</ARTIST>" & cr &
    "    <COUNTRY>" & strCountriesCD & "</COUNTRY>" & cr &
    "    <COMPANY>" & strCompaniesCD & "</COMPANY>" & cr &
    "    <PRICE>" & strPriceCD & "</PRICE>" & cr &
    "    <YEAR>" & strYearCD & "</YEAR>" & cr &
    "  </CD> "
        Dim xd As New XmlDocument()
        xd.Load("XML_CD_Collection.xml")

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
        xd.Save("XML_CD_Collection.xml")
        MsgBox("CD record saved successfully")
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        Dim m_xmld As XmlDocument
        Dim m_nodelist As XmlNodeList
        Dim m_node As XmlNode

        m_xmld = New XmlDocument
        'm_xmld.Load
        m_xmld.Load("XML_CD_Collection.xml")
        m_nodelist = m_xmld.GetElementsByTagName("CD")
        For Each m_node In m_nodelist
            strTitleCD = m_node.Item("TITLE").InnerText
            strArtistCD = m_node.Item("ARTIST").InnerText
            strCountriesCD = m_node.Item("COUNTRY").InnerText
            strCompaniesCD = m_node.Item("COMPANY").InnerText
            strPriceCD = m_node.Item("PRICE").InnerText
            strYearCD = m_node.Item("YEAR").InnerText

            strMessage = "Title:      " & strTitleCD & vbCrLf & "Artist:      " & strArtistCD & vbCrLf & "Country:     " & strCountriesCD & vbCrLf & "Company:      " & strCompaniesCD & vbCrLf & "Price:      " & strPriceCD & vbCrLf & "Year:      " & strYearCD
            MsgBox(strMessage)
        Next

    End Sub

    Private Sub btnDisplayCD_Click_1(sender As Object, e As EventArgs) Handles btnDisplayCD.Click
        Dim m_xmld As XmlDocument
        Dim m_nodelist As XmlNodeList
        Dim m_node As XmlNode

        m_xmld = New XmlDocument
        m_xmld.Load("XML_CD_Collection.xml")
        m_nodelist = m_xmld.GetElementsByTagName("CD")
        Dim i As Integer = 0
        For Each m_node In m_nodelist
            strTitleCD = m_node.Item("TITLE").InnerText
            strArtistCD = m_node.Item("ARTIST").InnerText
            strCountriesCD = m_node.Item("COUNTRY").InnerText
            strCompaniesCD = m_node.Item("COMPANY").InnerText
            strPriceCD = m_node.Item("PRICE").InnerText
            strYearCD = m_node.Item("YEAR").InnerText

            lsbTitleCD.Items.Add(strTitleCD)
            lsbArtistCD.Items.Add(strArtistCD)
            lsbCountriesCD.Items.Add(strCountriesCD)
            lsbCompaniesCD.Items.Add(strCompaniesCD)
            lsbPriceCD.Items.Add(strPriceCD)
            lsbYearCD.Items.Add(strYearCD)

            '--read items into arrays
            TitleCD(i) = strTitleCD
            ArtistCD(i) = strArtistCD
            CountriesCD(i) = strCountriesCD
            CompaniesCD(i) = strCompaniesCD
            'PriceB(i) = CDbl(strPriceB)
            PriceCD(i) = Val(strPriceCD)
            YearCD(i) = strYearCD
            totalValueCD = totalValueCD + PriceCD(i)
            i = i + 1
        Next
        Math.Round(totalValueCD)
        MsgBox("The total value is: " & totalValueCD)

        Dim lowestPrice As Double = 999
        For i = 0 To 25
            If PriceCD(i) < lowestPrice Then lowestPrice = PriceCD(i)
        Next
        MsgBox("The lowest price  is: " & lowestPrice)

        Dim highestPrice As Double = 0
        For i = 0 To 25
            If PriceCD(i) > highestPrice Then highestPrice = PriceCD(i)
        Next
        MsgBox("The highest price  is: " & highestPrice)

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtTitle.Clear()
        txtArtist.Clear()
        txtCountry.Clear()
        txtCompany.Clear()
        txtPrice.Clear()
        txtYear.Clear()

        lsbTitleCD.Items.Clear()
        lsbArtistCD.Items.Clear()
        lsbCountriesCD.Items.Clear()
        lsbCompaniesCD.Items.Clear()
        lsbPriceCD.Items.Clear()
        lsbYearCD.Items.Clear()

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