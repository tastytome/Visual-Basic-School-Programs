<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.cbxRating = New System.Windows.Forms.ComboBox()
        Me.btnRating = New System.Windows.Forms.Button()
        Me.lsbRating = New System.Windows.Forms.ListBox()
        Me.lsbMobile = New System.Windows.Forms.ListBox()
        Me.lsbPostcode = New System.Windows.Forms.ListBox()
        Me.lsbSuburb = New System.Windows.Forms.ListBox()
        Me.lsbAddress = New System.Windows.Forms.ListBox()
        Me.lsbSurname = New System.Windows.Forms.ListBox()
        Me.lsbName = New System.Windows.Forms.ListBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txbSurname = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txbStreet = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txbPostcode = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txbMobile = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txbRating = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txbSuburb = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txbGiven = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnAddCustomer = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(1054, 411)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(112, 27)
        Me.btnExit.TabIndex = 84
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(937, 411)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(112, 27)
        Me.btnClear.TabIndex = 83
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'cbxRating
        '
        Me.cbxRating.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxRating.FormattingEnabled = True
        Me.cbxRating.Items.AddRange(New Object() {"Bronze", "Silver", "Gold", "Platinum"})
        Me.cbxRating.Location = New System.Drawing.Point(479, 411)
        Me.cbxRating.Name = "cbxRating"
        Me.cbxRating.Size = New System.Drawing.Size(163, 23)
        Me.cbxRating.TabIndex = 82
        '
        'btnRating
        '
        Me.btnRating.Location = New System.Drawing.Point(479, 438)
        Me.btnRating.Name = "btnRating"
        Me.btnRating.Size = New System.Drawing.Size(163, 30)
        Me.btnRating.TabIndex = 81
        Me.btnRating.Text = "Display by Rating"
        Me.btnRating.UseVisualStyleBackColor = True
        '
        'lsbRating
        '
        Me.lsbRating.FormattingEnabled = True
        Me.lsbRating.ItemHeight = 15
        Me.lsbRating.Location = New System.Drawing.Point(1054, 137)
        Me.lsbRating.Name = "lsbRating"
        Me.lsbRating.Size = New System.Drawing.Size(111, 259)
        Me.lsbRating.TabIndex = 80
        '
        'lsbMobile
        '
        Me.lsbMobile.FormattingEnabled = True
        Me.lsbMobile.ItemHeight = 15
        Me.lsbMobile.Location = New System.Drawing.Point(937, 137)
        Me.lsbMobile.Name = "lsbMobile"
        Me.lsbMobile.Size = New System.Drawing.Size(111, 259)
        Me.lsbMobile.TabIndex = 79
        '
        'lsbPostcode
        '
        Me.lsbPostcode.FormattingEnabled = True
        Me.lsbPostcode.ItemHeight = 15
        Me.lsbPostcode.Location = New System.Drawing.Point(820, 137)
        Me.lsbPostcode.Name = "lsbPostcode"
        Me.lsbPostcode.Size = New System.Drawing.Size(111, 259)
        Me.lsbPostcode.TabIndex = 78
        '
        'lsbSuburb
        '
        Me.lsbSuburb.FormattingEnabled = True
        Me.lsbSuburb.ItemHeight = 15
        Me.lsbSuburb.Location = New System.Drawing.Point(703, 137)
        Me.lsbSuburb.Name = "lsbSuburb"
        Me.lsbSuburb.Size = New System.Drawing.Size(111, 259)
        Me.lsbSuburb.TabIndex = 77
        '
        'lsbAddress
        '
        Me.lsbAddress.FormattingEnabled = True
        Me.lsbAddress.ItemHeight = 15
        Me.lsbAddress.Location = New System.Drawing.Point(586, 137)
        Me.lsbAddress.Name = "lsbAddress"
        Me.lsbAddress.Size = New System.Drawing.Size(111, 259)
        Me.lsbAddress.TabIndex = 76
        '
        'lsbSurname
        '
        Me.lsbSurname.FormattingEnabled = True
        Me.lsbSurname.ItemHeight = 15
        Me.lsbSurname.Location = New System.Drawing.Point(469, 137)
        Me.lsbSurname.Name = "lsbSurname"
        Me.lsbSurname.Size = New System.Drawing.Size(111, 259)
        Me.lsbSurname.TabIndex = 75
        '
        'lsbName
        '
        Me.lsbName.FormattingEnabled = True
        Me.lsbName.ItemHeight = 15
        Me.lsbName.Location = New System.Drawing.Point(352, 137)
        Me.lsbName.Name = "lsbName"
        Me.lsbName.Size = New System.Drawing.Size(111, 259)
        Me.lsbName.TabIndex = 74
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(78, 81)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(375, 37)
        Me.Label8.TabIndex = 73
        Me.Label8.Text = "Mr Mac's Magnificent Hotel"
        '
        'txbSurname
        '
        Me.txbSurname.Location = New System.Drawing.Point(178, 176)
        Me.txbSurname.Name = "txbSurname"
        Me.txbSurname.Size = New System.Drawing.Size(158, 23)
        Me.txbSurname.TabIndex = 72
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(102, 184)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 15)
        Me.Label7.TabIndex = 71
        Me.Label7.Text = "Surname"
        '
        'txbStreet
        '
        Me.txbStreet.Location = New System.Drawing.Point(178, 217)
        Me.txbStreet.Name = "txbStreet"
        Me.txbStreet.Size = New System.Drawing.Size(158, 23)
        Me.txbStreet.TabIndex = 70
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(87, 220)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 15)
        Me.Label6.TabIndex = 69
        Me.Label6.Text = "Street Address"
        '
        'txbPostcode
        '
        Me.txbPostcode.Location = New System.Drawing.Point(178, 291)
        Me.txbPostcode.Name = "txbPostcode"
        Me.txbPostcode.Size = New System.Drawing.Size(158, 23)
        Me.txbPostcode.TabIndex = 68
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(102, 258)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 15)
        Me.Label5.TabIndex = 67
        Me.Label5.Text = "Suburb"
        '
        'txbMobile
        '
        Me.txbMobile.Location = New System.Drawing.Point(178, 331)
        Me.txbMobile.Name = "txbMobile"
        Me.txbMobile.Size = New System.Drawing.Size(158, 23)
        Me.txbMobile.TabIndex = 66
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(102, 291)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 15)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "Postcode"
        '
        'txbRating
        '
        Me.txbRating.Location = New System.Drawing.Point(178, 370)
        Me.txbRating.Name = "txbRating"
        Me.txbRating.Size = New System.Drawing.Size(158, 23)
        Me.txbRating.TabIndex = 64
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(78, 339)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 15)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "Mobile Number"
        '
        'txbSuburb
        '
        Me.txbSuburb.Location = New System.Drawing.Point(178, 255)
        Me.txbSuburb.Name = "txbSuburb"
        Me.txbSuburb.Size = New System.Drawing.Size(158, 23)
        Me.txbSuburb.TabIndex = 62
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(102, 373)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 15)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "Rating"
        '
        'txbGiven
        '
        Me.txbGiven.Location = New System.Drawing.Point(178, 137)
        Me.txbGiven.Name = "txbGiven"
        Me.txbGiven.Size = New System.Drawing.Size(158, 23)
        Me.txbGiven.TabIndex = 60
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(87, 145)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 15)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Given Name"
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(349, 411)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(114, 50)
        Me.btnDisplay.TabIndex = 58
        Me.btnDisplay.Text = "Display"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnAddCustomer
        '
        Me.btnAddCustomer.Location = New System.Drawing.Point(179, 411)
        Me.btnAddCustomer.Name = "btnAddCustomer"
        Me.btnAddCustomer.Size = New System.Drawing.Size(157, 23)
        Me.btnAddCustomer.TabIndex = 57
        Me.btnAddCustomer.Text = "Add Customer"
        Me.btnAddCustomer.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(240, 438)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(96, 23)
        Me.btnSave.TabIndex = 85
        Me.btnSave.Text = "Save New XML"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(1244, 519)
        Me.Controls.Add(Me.btnSave)
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
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents cbxRating As ComboBox
    Friend WithEvents btnRating As Button
    Friend WithEvents lsbRating As ListBox
    Friend WithEvents lsbMobile As ListBox
    Friend WithEvents lsbPostcode As ListBox
    Friend WithEvents lsbSuburb As ListBox
    Friend WithEvents lsbAddress As ListBox
    Friend WithEvents lsbSurname As ListBox
    Friend WithEvents lsbName As ListBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txbSurname As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txbStreet As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txbPostcode As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txbMobile As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txbRating As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txbSuburb As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txbGiven As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnDisplay As Button
    Friend WithEvents btnAddCustomer As Button
    Friend WithEvents btnSave As Button
End Class
