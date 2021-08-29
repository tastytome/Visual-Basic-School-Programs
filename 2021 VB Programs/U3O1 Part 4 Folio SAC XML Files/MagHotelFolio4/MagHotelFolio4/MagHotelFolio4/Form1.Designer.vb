<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnAddCustomer = New System.Windows.Forms.Button()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txbGiven = New System.Windows.Forms.TextBox()
        Me.txbSuburb = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txbRating = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txbMobile = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txbPostcode = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txbStreet = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txbSurname = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lsbName = New System.Windows.Forms.ListBox()
        Me.lsbSurname = New System.Windows.Forms.ListBox()
        Me.lsbAddress = New System.Windows.Forms.ListBox()
        Me.lsbSuburb = New System.Windows.Forms.ListBox()
        Me.lsbPostcode = New System.Windows.Forms.ListBox()
        Me.lsbMobile = New System.Windows.Forms.ListBox()
        Me.lsbRating = New System.Windows.Forms.ListBox()
        Me.btnRating = New System.Windows.Forms.Button()
        Me.cbxRating = New System.Windows.Forms.ComboBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAddCustomer
        '
        Me.btnAddCustomer.Location = New System.Drawing.Point(115, 350)
        Me.btnAddCustomer.Name = "btnAddCustomer"
        Me.btnAddCustomer.Size = New System.Drawing.Size(114, 23)
        Me.btnAddCustomer.TabIndex = 0
        Me.btnAddCustomer.Text = "Add Customer"
        Me.btnAddCustomer.UseVisualStyleBackColor = True
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(235, 350)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(75, 23)
        Me.btnDisplay.TabIndex = 1
        Me.btnDisplay.Text = "Display"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Given Name"
        '
        'txbGiven
        '
        Me.txbGiven.Location = New System.Drawing.Point(115, 72)
        Me.txbGiven.Name = "txbGiven"
        Me.txbGiven.Size = New System.Drawing.Size(158, 23)
        Me.txbGiven.TabIndex = 3
        '
        'txbSuburb
        '
        Me.txbSuburb.Location = New System.Drawing.Point(115, 190)
        Me.txbSuburb.Name = "txbSuburb"
        Me.txbSuburb.Size = New System.Drawing.Size(158, 23)
        Me.txbSuburb.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 308)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Rating"
        '
        'txbRating
        '
        Me.txbRating.Location = New System.Drawing.Point(115, 305)
        Me.txbRating.Name = "txbRating"
        Me.txbRating.Size = New System.Drawing.Size(158, 23)
        Me.txbRating.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 274)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Mobile Number"
        '
        'txbMobile
        '
        Me.txbMobile.Location = New System.Drawing.Point(115, 266)
        Me.txbMobile.Name = "txbMobile"
        Me.txbMobile.Size = New System.Drawing.Size(158, 23)
        Me.txbMobile.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(39, 226)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Postcode"
        '
        'txbPostcode
        '
        Me.txbPostcode.Location = New System.Drawing.Point(115, 226)
        Me.txbPostcode.Name = "txbPostcode"
        Me.txbPostcode.Size = New System.Drawing.Size(158, 23)
        Me.txbPostcode.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(39, 193)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 15)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Suburb"
        '
        'txbStreet
        '
        Me.txbStreet.Location = New System.Drawing.Point(115, 152)
        Me.txbStreet.Name = "txbStreet"
        Me.txbStreet.Size = New System.Drawing.Size(158, 23)
        Me.txbStreet.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 155)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 15)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Street Address"
        '
        'txbSurname
        '
        Me.txbSurname.Location = New System.Drawing.Point(115, 111)
        Me.txbSurname.Name = "txbSurname"
        Me.txbSurname.Size = New System.Drawing.Size(158, 23)
        Me.txbSurname.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(39, 119)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 15)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Surname"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(15, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(375, 37)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Mr Mac's Magnificent Hotel"
        '
        'lsbName
        '
        Me.lsbName.FormattingEnabled = True
        Me.lsbName.ItemHeight = 15
        Me.lsbName.Location = New System.Drawing.Point(289, 72)
        Me.lsbName.Name = "lsbName"
        Me.lsbName.Size = New System.Drawing.Size(111, 259)
        Me.lsbName.TabIndex = 17
        '
        'lsbSurname
        '
        Me.lsbSurname.FormattingEnabled = True
        Me.lsbSurname.ItemHeight = 15
        Me.lsbSurname.Location = New System.Drawing.Point(406, 72)
        Me.lsbSurname.Name = "lsbSurname"
        Me.lsbSurname.Size = New System.Drawing.Size(111, 259)
        Me.lsbSurname.TabIndex = 18
        '
        'lsbAddress
        '
        Me.lsbAddress.FormattingEnabled = True
        Me.lsbAddress.ItemHeight = 15
        Me.lsbAddress.Location = New System.Drawing.Point(523, 72)
        Me.lsbAddress.Name = "lsbAddress"
        Me.lsbAddress.Size = New System.Drawing.Size(111, 259)
        Me.lsbAddress.TabIndex = 19
        '
        'lsbSuburb
        '
        Me.lsbSuburb.FormattingEnabled = True
        Me.lsbSuburb.ItemHeight = 15
        Me.lsbSuburb.Location = New System.Drawing.Point(640, 72)
        Me.lsbSuburb.Name = "lsbSuburb"
        Me.lsbSuburb.Size = New System.Drawing.Size(111, 259)
        Me.lsbSuburb.TabIndex = 20
        '
        'lsbPostcode
        '
        Me.lsbPostcode.FormattingEnabled = True
        Me.lsbPostcode.ItemHeight = 15
        Me.lsbPostcode.Location = New System.Drawing.Point(757, 72)
        Me.lsbPostcode.Name = "lsbPostcode"
        Me.lsbPostcode.Size = New System.Drawing.Size(111, 259)
        Me.lsbPostcode.TabIndex = 21
        '
        'lsbMobile
        '
        Me.lsbMobile.FormattingEnabled = True
        Me.lsbMobile.ItemHeight = 15
        Me.lsbMobile.Location = New System.Drawing.Point(874, 72)
        Me.lsbMobile.Name = "lsbMobile"
        Me.lsbMobile.Size = New System.Drawing.Size(111, 259)
        Me.lsbMobile.TabIndex = 22
        '
        'lsbRating
        '
        Me.lsbRating.FormattingEnabled = True
        Me.lsbRating.ItemHeight = 15
        Me.lsbRating.Location = New System.Drawing.Point(991, 72)
        Me.lsbRating.Name = "lsbRating"
        Me.lsbRating.Size = New System.Drawing.Size(111, 259)
        Me.lsbRating.TabIndex = 23
        '
        'btnRating
        '
        Me.btnRating.Location = New System.Drawing.Point(486, 350)
        Me.btnRating.Name = "btnRating"
        Me.btnRating.Size = New System.Drawing.Size(125, 23)
        Me.btnRating.TabIndex = 24
        Me.btnRating.Text = "Display by Rating"
        Me.btnRating.UseVisualStyleBackColor = True
        '
        'cbxRating
        '
        Me.cbxRating.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxRating.FormattingEnabled = True
        Me.cbxRating.Items.AddRange(New Object() {"Bronze", "Silver", "Gold", "Platinum"})
        Me.cbxRating.Location = New System.Drawing.Point(317, 350)
        Me.cbxRating.Name = "cbxRating"
        Me.cbxRating.Size = New System.Drawing.Size(163, 23)
        Me.cbxRating.TabIndex = 25
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(991, 346)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(112, 27)
        Me.btnExit.TabIndex = 56
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(874, 346)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(112, 27)
        Me.btnClear.TabIndex = 55
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(1129, 401)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.cbxRating)
        Me.Controls.Add(Me.btnRating)
        Me.Controls.Add(Me.lsbRating)
        Me.Controls.Add(Me.lsbMobile)
        Me.Controls.Add(Me.lsbPostcode)
        Me.Controls.Add(Me.lsbSuburb)
        Me.Controls.Add(Me.lsbAddress)
        Me.Controls.Add(Me.lsbSurname)
        Me.Controls.Add(Me.lsbName)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txbSurname)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txbStreet)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txbPostcode)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txbMobile)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txbRating)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txbSuburb)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txbGiven)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.btnAddCustomer)
        Me.Name = "Form1"
        Me.Text = "Display by Rating"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAddCustomer As Button
    Friend WithEvents btnDisplay As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txbGiven As TextBox
    Friend WithEvents txbSuburb As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txbRating As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txbMobile As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txbPostcode As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txbStreet As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txbSurname As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lsbName As ListBox
    Friend WithEvents lsbSurname As ListBox
    Friend WithEvents lsbAddress As ListBox
    Friend WithEvents lsbSuburb As ListBox
    Friend WithEvents lsbPostcode As ListBox
    Friend WithEvents lsbMobile As ListBox
    Friend WithEvents lsbRating As ListBox
    Friend WithEvents btnRating As Button
    Friend WithEvents cbxRating As ComboBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnClear As Button
End Class
