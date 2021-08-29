<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddBooking
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
        Me.txbCustGivenName = New System.Windows.Forms.TextBox()
        Me.btnReturnMainMenu = New System.Windows.Forms.Button()
        Me.btnAddCustomerToFile = New System.Windows.Forms.Button()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblCustomerDetails = New System.Windows.Forms.Label()
        Me.txbCustSurname = New System.Windows.Forms.TextBox()
        Me.lblSurname = New System.Windows.Forms.Label()
        Me.txbCustStreet = New System.Windows.Forms.TextBox()
        Me.lblStreetAddress = New System.Windows.Forms.Label()
        Me.txbCustSuburb = New System.Windows.Forms.TextBox()
        Me.lblSuburb = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.txbCustPostcode = New System.Windows.Forms.TextBox()
        Me.lblPostcode = New System.Windows.Forms.Label()
        Me.txbCustMobileNum = New System.Windows.Forms.TextBox()
        Me.lblMobileNumber = New System.Windows.Forms.Label()
        Me.lblCustomerRating = New System.Windows.Forms.Label()
        Me.cbxCustRating = New System.Windows.Forms.ComboBox()
        Me.cbxStates = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'txbCustGivenName
        '
        Me.txbCustGivenName.Location = New System.Drawing.Point(16, 107)
        Me.txbCustGivenName.Name = "txbCustGivenName"
        Me.txbCustGivenName.Size = New System.Drawing.Size(179, 23)
        Me.txbCustGivenName.TabIndex = 17
        '
        'btnReturnMainMenu
        '
        Me.btnReturnMainMenu.Location = New System.Drawing.Point(410, 233)
        Me.btnReturnMainMenu.Name = "btnReturnMainMenu"
        Me.btnReturnMainMenu.Size = New System.Drawing.Size(169, 51)
        Me.btnReturnMainMenu.TabIndex = 15
        Me.btnReturnMainMenu.Text = "Return to Main Menu"
        Me.btnReturnMainMenu.UseVisualStyleBackColor = True
        '
        'btnAddCustomerToFile
        '
        Me.btnAddCustomerToFile.Location = New System.Drawing.Point(410, 107)
        Me.btnAddCustomerToFile.Name = "btnAddCustomerToFile"
        Me.btnAddCustomerToFile.Size = New System.Drawing.Size(169, 45)
        Me.btnAddCustomerToFile.TabIndex = 14
        Me.btnAddCustomerToFile.Text = "Add Customer to File"
        Me.btnAddCustomerToFile.UseVisualStyleBackColor = True
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(16, 89)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(72, 15)
        Me.lblFirstName.TabIndex = 11
        Me.lblFirstName.Text = "Given Name"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.Location = New System.Drawing.Point(16, 17)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(278, 28)
        Me.lblTitle.TabIndex = 10
        Me.lblTitle.Text = "Mr Mac's Magnificent Hotel"
        '
        'lblCustomerDetails
        '
        Me.lblCustomerDetails.AutoSize = True
        Me.lblCustomerDetails.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCustomerDetails.Location = New System.Drawing.Point(16, 59)
        Me.lblCustomerDetails.Name = "lblCustomerDetails"
        Me.lblCustomerDetails.Size = New System.Drawing.Size(179, 21)
        Me.lblCustomerDetails.TabIndex = 20
        Me.lblCustomerDetails.Text = "New Customer Details"
        '
        'txbCustSurname
        '
        Me.txbCustSurname.Location = New System.Drawing.Point(201, 107)
        Me.txbCustSurname.Name = "txbCustSurname"
        Me.txbCustSurname.Size = New System.Drawing.Size(185, 23)
        Me.txbCustSurname.TabIndex = 22
        '
        'lblSurname
        '
        Me.lblSurname.AutoSize = True
        Me.lblSurname.Location = New System.Drawing.Point(201, 89)
        Me.lblSurname.Name = "lblSurname"
        Me.lblSurname.Size = New System.Drawing.Size(54, 15)
        Me.lblSurname.TabIndex = 21
        Me.lblSurname.Text = "Surname"
        '
        'txbCustStreet
        '
        Me.txbCustStreet.Location = New System.Drawing.Point(16, 155)
        Me.txbCustStreet.Name = "txbCustStreet"
        Me.txbCustStreet.Size = New System.Drawing.Size(370, 23)
        Me.txbCustStreet.TabIndex = 24
        '
        'lblStreetAddress
        '
        Me.lblStreetAddress.AutoSize = True
        Me.lblStreetAddress.Location = New System.Drawing.Point(16, 137)
        Me.lblStreetAddress.Name = "lblStreetAddress"
        Me.lblStreetAddress.Size = New System.Drawing.Size(82, 15)
        Me.lblStreetAddress.TabIndex = 23
        Me.lblStreetAddress.Text = "Street Address"
        '
        'txbCustSuburb
        '
        Me.txbCustSuburb.Location = New System.Drawing.Point(16, 210)
        Me.txbCustSuburb.Name = "txbCustSuburb"
        Me.txbCustSuburb.Size = New System.Drawing.Size(179, 23)
        Me.txbCustSuburb.TabIndex = 26
        '
        'lblSuburb
        '
        Me.lblSuburb.AutoSize = True
        Me.lblSuburb.Location = New System.Drawing.Point(16, 192)
        Me.lblSuburb.Name = "lblSuburb"
        Me.lblSuburb.Size = New System.Drawing.Size(45, 15)
        Me.lblSuburb.TabIndex = 25
        Me.lblSuburb.Text = "Suburb"
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Location = New System.Drawing.Point(201, 192)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(33, 15)
        Me.lblState.TabIndex = 27
        Me.lblState.Text = "State"
        '
        'txbCustPostcode
        '
        Me.txbCustPostcode.Location = New System.Drawing.Point(313, 210)
        Me.txbCustPostcode.Name = "txbCustPostcode"
        Me.txbCustPostcode.Size = New System.Drawing.Size(72, 23)
        Me.txbCustPostcode.TabIndex = 30
        '
        'lblPostcode
        '
        Me.lblPostcode.AutoSize = True
        Me.lblPostcode.Location = New System.Drawing.Point(313, 192)
        Me.lblPostcode.Name = "lblPostcode"
        Me.lblPostcode.Size = New System.Drawing.Size(56, 15)
        Me.lblPostcode.TabIndex = 29
        Me.lblPostcode.Text = "Postcode"
        '
        'txbCustMobileNum
        '
        Me.txbCustMobileNum.Location = New System.Drawing.Point(16, 261)
        Me.txbCustMobileNum.Name = "txbCustMobileNum"
        Me.txbCustMobileNum.Size = New System.Drawing.Size(179, 23)
        Me.txbCustMobileNum.TabIndex = 32
        '
        'lblMobileNumber
        '
        Me.lblMobileNumber.AutoSize = True
        Me.lblMobileNumber.Location = New System.Drawing.Point(16, 243)
        Me.lblMobileNumber.Name = "lblMobileNumber"
        Me.lblMobileNumber.Size = New System.Drawing.Size(91, 15)
        Me.lblMobileNumber.TabIndex = 31
        Me.lblMobileNumber.Text = "Mobile Number"
        '
        'lblCustomerRating
        '
        Me.lblCustomerRating.AutoSize = True
        Me.lblCustomerRating.Location = New System.Drawing.Point(201, 243)
        Me.lblCustomerRating.Name = "lblCustomerRating"
        Me.lblCustomerRating.Size = New System.Drawing.Size(96, 15)
        Me.lblCustomerRating.TabIndex = 33
        Me.lblCustomerRating.Text = "Customer Rating"
        '
        'cbxCustRating
        '
        Me.cbxCustRating.FormattingEnabled = True
        Me.cbxCustRating.Items.AddRange(New Object() {"Silver", "Gold", "Platinum"})
        Me.cbxCustRating.Location = New System.Drawing.Point(201, 261)
        Me.cbxCustRating.Name = "cbxCustRating"
        Me.cbxCustRating.Size = New System.Drawing.Size(184, 23)
        Me.cbxCustRating.TabIndex = 34
        '
        'cbxStates
        '
        Me.cbxStates.FormattingEnabled = True
        Me.cbxStates.Items.AddRange(New Object() {"VIC", "NSW", "QLD", "NT", "WA", "SA"})
        Me.cbxStates.Location = New System.Drawing.Point(201, 210)
        Me.cbxStates.Name = "cbxStates"
        Me.cbxStates.Size = New System.Drawing.Size(106, 23)
        Me.cbxStates.TabIndex = 35
        '
        'FrmAddBooking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(600, 320)
        Me.Controls.Add(Me.cbxStates)
        Me.Controls.Add(Me.cbxCustRating)
        Me.Controls.Add(Me.lblCustomerRating)
        Me.Controls.Add(Me.txbCustMobileNum)
        Me.Controls.Add(Me.lblMobileNumber)
        Me.Controls.Add(Me.txbCustPostcode)
        Me.Controls.Add(Me.lblPostcode)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.txbCustSuburb)
        Me.Controls.Add(Me.lblSuburb)
        Me.Controls.Add(Me.txbCustStreet)
        Me.Controls.Add(Me.lblStreetAddress)
        Me.Controls.Add(Me.txbCustSurname)
        Me.Controls.Add(Me.lblSurname)
        Me.Controls.Add(Me.lblCustomerDetails)
        Me.Controls.Add(Me.txbCustGivenName)
        Me.Controls.Add(Me.btnReturnMainMenu)
        Me.Controls.Add(Me.btnAddCustomerToFile)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "FrmAddBooking"
        Me.Text = "FrmAddBooking"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txbCustGivenName As TextBox
    Friend WithEvents btnReturnMainMenu As Button
    Friend WithEvents btnAddCustomerToFile As Button
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblCustomerDetails As Label
    Friend WithEvents txbCustSurname As TextBox
    Friend WithEvents lblSurname As Label
    Friend WithEvents txbCustStreet As TextBox
    Friend WithEvents lblStreetAddress As Label
    Friend WithEvents txbCustSuburb As TextBox
    Friend WithEvents lblSuburb As Label
    Friend WithEvents lblState As Label
    Friend WithEvents txbCustPostcode As TextBox
    Friend WithEvents lblPostcode As Label
    Friend WithEvents txbCustMobileNum As TextBox
    Friend WithEvents lblMobileNumber As Label
    Friend WithEvents lblCustomerRating As Label
    Friend WithEvents cbxCustRating As ComboBox
    Friend WithEvents cbxStates As ComboBox
End Class
