Imports System.IO
Imports System.Text

Public Class Form1
    Dim MyStream As IO.StreamReader
    Private arrName(11) As String 'Array to Hold Employee's Names
    Private arrPosition(11) As String 'Array to Hold Employee's Positions
    Private arrContract(11) As String 'Array To Hold Contract's Names
    Private arrFrom(11) As String 'Each Contract's Starting Date
    Private arrTo(11) As String 'Each Contract's Ending Date

    Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        lstStock.View = View.Details
        lstStock.Columns.Add("Item Name", 200, HorizontalAlignment.Center)
        lstStock.Columns.Add("Price", 140, HorizontalAlignment.Center)
        lstStock.Columns.Add("Stock Available", 140, HorizontalAlignment.Center)
        lstStock.Columns.Add("Total Value", 145, HorizontalAlignment.Center)
        'Set up listview table columns for inventory

        'Populate Employees
        arrName(0) = "McPherson"
        arrName(1) = "Thomas"
        arrName(2) = "Khanh"
        arrName(3) = "Raffy"
        arrName(4) = "Daria"
        arrName(5) = "Alexi"
        arrName(6) = "Xavier"
        arrName(7) = "Noellie"
        arrName(8) = "Zak"
        arrName(9) = "Yomiyu"
        arrName(10) = "Jude"
        arrName(11) = "Amy"

        'Populate Positions
        arrPosition(0) = "Overseer"
        arrPosition(1) = "CEO"
        arrPosition(2) = "CTO"
        arrPosition(3) = "CFO"
        arrPosition(4) = "IT Support"
        arrPosition(5) = "Manager"
        arrPosition(6) = "Assistant Manager"
        arrPosition(7) = "PR"
        arrPosition(8) = "Marketing"
        arrPosition(9) = "Accountant"
        arrPosition(10) = "Warehouse Worker"
        arrPosition(11) = "Warehouse Worker"

        'Popluate Contracts
        arrContract(0) = "Banana Inc."
        arrContract(1) = "Tran Technologies"
        arrContract(2) = "Tran Empire Inc."
        arrContract(3) = "Nguyen Clinic"
        arrContract(4) = "Alonso's Pizza"
        arrContract(5) = "Auburn High School"
        arrContract(6) = "Rice Fields"
        arrContract(7) = "Locale Commons"
        arrContract(8) = "AMG Constructions"
        arrContract(9) = "Anonymous Client"
        arrContract(10) = "Anonymous Client"
        arrContract(11) = "Anonymous Client"

        'Popluate Starting Dates
        arrFrom(0) = "21 March"
        arrFrom(1) = "20 April"
        arrFrom(2) = "21 May"
        arrFrom(3) = "21 June"
        arrFrom(4) = "23 July"
        arrFrom(5) = "23 August"
        arrFrom(6) = "23 September"
        arrFrom(7) = "23 October"
        arrFrom(8) = "22 November"
        arrFrom(9) = "22 December"
        arrFrom(10) = "20 January"
        arrFrom(11) = "19 February"

        'Populate Ending Dates
        arrTo(0) = "19 April"
        arrTo(1) = "20 May"
        arrTo(2) = "20 June"
        arrTo(3) = "22 July"
        arrTo(4) = "22 August"
        arrTo(5) = "22 September"
        arrTo(6) = "22 October"
        arrTo(7) = "21 November"
        arrTo(8) = "21 December"
        arrTo(9) = "19 January"
        arrTo(10) = "18 February"
        arrTo(11) = "20 March"

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'Handles message acknowledging employee's name
        Dim strName As String
        Dim strOutputMessage

        strName = txtInputName.Text
        strOutputMessage = "Greetings " & strName & ", Welcome back to TKR Industries Shipping Co."

        'Output messagebox
        MsgBox(strOutputMessage)

    End Sub
    Private Sub btnSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click
        'Handles inventory stock listview
        Dim TempTotalStock As Integer = 0
        Dim TempTotalValue As Decimal = 0
        'Define value holders for totals calculations later
        Dim myTextFile As Object = "stock.txt"
        'Specific stock text input file 
        'Does not need long path as is already in bin\debug foler of projject

        Try

            'Open streamreader and read file from bin\debug 
            Dim MyStream As New StreamReader("stock.txt")
            Dim strTemp() As String

            Using MyStream

                Do While MyStream.Peek <> -1

                    strTemp = MyStream.ReadLine.Split(Chr(45))
                    'Read separate .txt file subitems via ASCII Chr 45 (-)

                    Dim LVItem As New ListViewItem
                    lstStock.Items.Add(LVItem)

                    LVItem.Text = strTemp(0).ToString
                    LVItem.SubItems.Add(String.Format("{0:C}", CDec(strTemp(1))))
                    LVItem.SubItems.Add(strTemp(2).ToString)
                    LVItem.SubItems.Add(String.Format("{0:C}", CDec(strTemp(1) * strTemp(2))))
                    'Open file and loop through adding items/subitems to table until complete

                    'Calculate Total Stock
                    TempTotalStock = strTemp(2) + TempTotalStock

                    'Calculate Total Value
                    TempTotalValue = strTemp(1) * strTemp(2) + TempTotalValue

                Loop

            End Using

        Catch noFileEx As FileNotFoundException
            MessageBox.Show("Can't find the data file")
            'Display notification if stock file not found

        Catch ex As Exception

        End Try

        'Output totals to textboxes
        Dim TotalStock As Integer = TempTotalStock
        Dim TotalValue As Decimal = TempTotalValue
        txtTotalStock.Text = TotalStock & " Items"
        txtTotalValue.Text = "$" & TotalValue

    End Sub

    Private Sub btnEmployee_Click(sender As System.Object, e As System.EventArgs) Handles btnEmployee.Click
        'Handles employee directory listview

        'Add Three Columns To ListView 
        lstEmployee.Columns.Add("Name", 100, HorizontalAlignment.Center) 'Column 1
        lstEmployee.Columns.Add("Position", 100, HorizontalAlignment.Left) 'Column 2
        lstEmployee.Columns.Add("To", 100, HorizontalAlignment.Right) 'Column 3

        'Declare Array For ListView Items
        Dim arrLVItem(11) As ListViewItem

        Dim j As Integer 'Loop Counter

        'Loop Through Each ListViewItem Array Item
        For j = 0 To arrLVItem.Length - 1

            'Initialize ListViewItem Array
            arrLVItem(j) = New ListViewItem

            'Add Text To First ListView Item 
            arrLVItem(j).SubItems(0).Text = arrName(j)

            'Add From and To SubItems On ListView Item
            arrLVItem(j).SubItems.Add(arrPosition(j))
            arrLVItem(j).SubItems.Add(arrTo(j))

        Next j

        'Add Completed Arrays To ListView
        lstEmployee.Items.AddRange(arrLVItem)

    End Sub

    Private Sub btnContracts_Click(sender As System.Object, e As System.EventArgs) Handles btnContract.Click
        'Handles contracts listview

        'Add Three Columns To ListView 2
        lstContract.Columns.Add("Contract", 150, HorizontalAlignment.Center) 'Column 1
        lstContract.Columns.Add("From", 100, HorizontalAlignment.Left) 'Column 2
        lstContract.Columns.Add("To", 100, HorizontalAlignment.Right) 'Column 3

        'Declare Array For ListView Items
        Dim arrLVItem(11) As ListViewItem

        Dim j As Integer 'Loop Counter

        'Loop Through Each ListViewItem Array Item
        For j = 0 To arrLVItem.Length - 1

            'Initialize ListViewItem Array
            arrLVItem(j) = New ListViewItem

            'Add Text To First ListView Item
            arrLVItem(j).SubItems(0).Text = arrContract(j)

            'Add From and To SubItems On ListView Item
            arrLVItem(j).SubItems.Add(arrFrom(j))
            arrLVItem(j).SubItems.Add(arrTo(j))

        Next j

        'Add Completed Arrays To ListView
        lstContract.Items.AddRange(arrLVItem)

    End Sub

End Class

'OTHER SOLUTION INFORMATION:

'Element Names:
'lstStock
'lstContract
'lstEmployee
'cbxCategory
'btnSearch
'btnEmployee
'btnLogin
'btnContract
'txtTotalValue
'txtTotalStock
'txtName

'Categories:
'Electronics
'Furniture
'Stationary
'Clothing
'Food

'Text File Format:
'Name,Price,Stock

'IPhone X  - 899.99 - 10
'Surface Pro 4 - 315.49 - 13
'Apple Watch Series 1 - 150.99 - 14
'Airpods -125.99 - 20
'Leather Couch - 250.49 - 15
'Plastic Chair - 50.55 - 18
'DIY Bed - 265.43 - 10
'Small Desk - 100.54 - 10
'Pencil Case - 15.01 - 20
'Eraser -1.99 - 25
'Art Kit - 30.25 - 5
'Pen Set - 5.99 - 15
'Large Banana - 3.99 - 15
'Red Apple - 2 - 4.99 - 20
'Ramen Noodles - 4.99 - 10
'Steamed Dumpings - 6.99 - 13