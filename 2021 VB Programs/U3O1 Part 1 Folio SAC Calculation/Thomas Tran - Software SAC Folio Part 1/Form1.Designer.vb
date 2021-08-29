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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblCustomerDetails = New System.Windows.Forms.Label()
        Me.lblBfastSelection = New System.Windows.Forms.Label()
        Me.lblRmExtras = New System.Windows.Forms.Label()
        Me.lblRoomRequestCost = New System.Windows.Forms.Label()
        Me.lblRoomType = New System.Windows.Forms.Label()
        Me.lblNumNights = New System.Windows.Forms.Label()
        Me.lblNumGuests = New System.Windows.Forms.Label()
        Me.lblCustSurname = New System.Windows.Forms.Label()
        Me.lblCustFirstName = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.LsbDisplay = New System.Windows.Forms.ListBox()
        Me.cbxRoomType = New System.Windows.Forms.ComboBox()
        Me.chbPillows = New System.Windows.Forms.CheckBox()
        Me.chbFoodBasket = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbtSuperior = New System.Windows.Forms.RadioButton()
        Me.rbtDeluxe = New System.Windows.Forms.RadioButton()
        Me.rbtStandard = New System.Windows.Forms.RadioButton()
        Me.txbCustFirstName = New System.Windows.Forms.TextBox()
        Me.txbCustSurname = New System.Windows.Forms.TextBox()
        Me.txbNumGuests = New System.Windows.Forms.TextBox()
        Me.txbNumNights = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.Location = New System.Drawing.Point(131, 33)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(301, 26)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Mr Mac's Magnificent Motel"
        '
        'lblCustomerDetails
        '
        Me.lblCustomerDetails.AutoSize = True
        Me.lblCustomerDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCustomerDetails.Location = New System.Drawing.Point(41, 76)
        Me.lblCustomerDetails.Name = "lblCustomerDetails"
        Me.lblCustomerDetails.Size = New System.Drawing.Size(131, 17)
        Me.lblCustomerDetails.TabIndex = 1
        Me.lblCustomerDetails.Text = "Customer Details"
        '
        'lblBfastSelection
        '
        Me.lblBfastSelection.AutoSize = True
        Me.lblBfastSelection.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblBfastSelection.Location = New System.Drawing.Point(358, 74)
        Me.lblBfastSelection.Name = "lblBfastSelection"
        Me.lblBfastSelection.Size = New System.Drawing.Size(149, 17)
        Me.lblBfastSelection.TabIndex = 2
        Me.lblBfastSelection.Text = "Breakfast Selection"
        '
        'lblRmExtras
        '
        Me.lblRmExtras.AutoSize = True
        Me.lblRmExtras.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblRmExtras.Location = New System.Drawing.Point(260, 258)
        Me.lblRmExtras.Name = "lblRmExtras"
        Me.lblRmExtras.Size = New System.Drawing.Size(247, 17)
        Me.lblRmExtras.TabIndex = 3
        Me.lblRmExtras.Text = "Room extras (Select your option)"
        '
        'lblRoomRequestCost
        '
        Me.lblRoomRequestCost.AutoSize = True
        Me.lblRoomRequestCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblRoomRequestCost.Location = New System.Drawing.Point(41, 323)
        Me.lblRoomRequestCost.Name = "lblRoomRequestCost"
        Me.lblRoomRequestCost.Size = New System.Drawing.Size(195, 24)
        Me.lblRoomRequestCost.TabIndex = 4
        Me.lblRoomRequestCost.Text = "Room Request Cost"
        '
        'lblRoomType
        '
        Me.lblRoomType.AutoSize = True
        Me.lblRoomType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblRoomType.Location = New System.Drawing.Point(41, 258)
        Me.lblRoomType.Name = "lblRoomType"
        Me.lblRoomType.Size = New System.Drawing.Size(90, 17)
        Me.lblRoomType.TabIndex = 5
        Me.lblRoomType.Text = "Room Type"
        '
        'lblNumNights
        '
        Me.lblNumNights.AutoSize = True
        Me.lblNumNights.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblNumNights.Location = New System.Drawing.Point(42, 213)
        Me.lblNumNights.Name = "lblNumNights"
        Me.lblNumNights.Size = New System.Drawing.Size(87, 13)
        Me.lblNumNights.TabIndex = 6
        Me.lblNumNights.Text = "Number of nights"
        '
        'lblNumGuests
        '
        Me.lblNumGuests.AutoSize = True
        Me.lblNumGuests.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblNumGuests.Location = New System.Drawing.Point(41, 178)
        Me.lblNumGuests.Name = "lblNumGuests"
        Me.lblNumGuests.Size = New System.Drawing.Size(90, 13)
        Me.lblNumGuests.TabIndex = 7
        Me.lblNumGuests.Text = "Number of guests"
        '
        'lblCustSurname
        '
        Me.lblCustSurname.AutoSize = True
        Me.lblCustSurname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCustSurname.Location = New System.Drawing.Point(41, 144)
        Me.lblCustSurname.Name = "lblCustSurname"
        Me.lblCustSurname.Size = New System.Drawing.Size(96, 13)
        Me.lblCustSurname.TabIndex = 8
        Me.lblCustSurname.Text = "Customer Surname"
        '
        'lblCustFirstName
        '
        Me.lblCustFirstName.AutoSize = True
        Me.lblCustFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCustFirstName.Location = New System.Drawing.Point(41, 109)
        Me.lblCustFirstName.Name = "lblCustFirstName"
        Me.lblCustFirstName.Size = New System.Drawing.Size(104, 13)
        Me.lblCustFirstName.TabIndex = 9
        Me.lblCustFirstName.Text = "Customer First Name"
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnCalculate.Location = New System.Drawing.Point(576, 131)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(151, 34)
        Me.btnCalculate.TabIndex = 10
        Me.btnCalculate.Text = "Calculate Price"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnReset.Location = New System.Drawing.Point(576, 181)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(151, 34)
        Me.btnReset.TabIndex = 11
        Me.btnReset.Text = "Reset Form (Clear)"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnExit.Location = New System.Drawing.Point(661, 476)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(66, 34)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'LsbDisplay
        '
        Me.LsbDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LsbDisplay.FormattingEnabled = True
        Me.LsbDisplay.Location = New System.Drawing.Point(41, 350)
        Me.LsbDisplay.Name = "LsbDisplay"
        Me.LsbDisplay.Size = New System.Drawing.Size(602, 160)
        Me.LsbDisplay.TabIndex = 13
        '
        'cbxRoomType
        '
        Me.cbxRoomType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cbxRoomType.FormattingEnabled = True
        Me.cbxRoomType.Items.AddRange(New Object() {"Single - $100/night", "Double - $150/night", "Family - $250/night", "Penthouse Suite - $500/night"})
        Me.cbxRoomType.Location = New System.Drawing.Point(41, 285)
        Me.cbxRoomType.Name = "cbxRoomType"
        Me.cbxRoomType.Size = New System.Drawing.Size(121, 21)
        Me.cbxRoomType.TabIndex = 14
        '
        'chbPillows
        '
        Me.chbPillows.AutoSize = True
        Me.chbPillows.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.chbPillows.Location = New System.Drawing.Point(260, 280)
        Me.chbPillows.Name = "chbPillows"
        Me.chbPillows.Size = New System.Drawing.Size(141, 17)
        Me.chbPillows.TabIndex = 15
        Me.chbPillows.Text = "Superior pillows Fee $50"
        Me.chbPillows.UseVisualStyleBackColor = True
        '
        'chbFoodBasket
        '
        Me.chbFoodBasket.AutoSize = True
        Me.chbFoodBasket.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.chbFoodBasket.Location = New System.Drawing.Point(260, 303)
        Me.chbFoodBasket.Name = "chbFoodBasket"
        Me.chbFoodBasket.Size = New System.Drawing.Size(198, 17)
        Me.chbFoodBasket.TabIndex = 16
        Me.chbFoodBasket.Text = "Gourmet Food Welcome Basket $30"
        Me.chbFoodBasket.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbtSuperior)
        Me.GroupBox1.Controls.Add(Me.rbtDeluxe)
        Me.GroupBox1.Controls.Add(Me.rbtStandard)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(358, 107)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(167, 108)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Options"
        '
        'rbtSuperior
        '
        Me.rbtSuperior.AutoSize = True
        Me.rbtSuperior.Location = New System.Drawing.Point(18, 74)
        Me.rbtSuperior.Name = "rbtSuperior"
        Me.rbtSuperior.Size = New System.Drawing.Size(100, 17)
        Me.rbtSuperior.TabIndex = 2
        Me.rbtSuperior.TabStop = True
        Me.rbtSuperior.Text = "Superior $40 pp"
        Me.rbtSuperior.UseVisualStyleBackColor = True
        '
        'rbtDeluxe
        '
        Me.rbtDeluxe.AutoSize = True
        Me.rbtDeluxe.Location = New System.Drawing.Point(18, 49)
        Me.rbtDeluxe.Name = "rbtDeluxe"
        Me.rbtDeluxe.Size = New System.Drawing.Size(94, 17)
        Me.rbtDeluxe.TabIndex = 1
        Me.rbtDeluxe.TabStop = True
        Me.rbtDeluxe.Text = "Deluxe $30 pp"
        Me.rbtDeluxe.UseVisualStyleBackColor = True
        '
        'rbtStandard
        '
        Me.rbtStandard.AutoSize = True
        Me.rbtStandard.Location = New System.Drawing.Point(18, 23)
        Me.rbtStandard.Name = "rbtStandard"
        Me.rbtStandard.Size = New System.Drawing.Size(104, 17)
        Me.rbtStandard.TabIndex = 0
        Me.rbtStandard.TabStop = True
        Me.rbtStandard.Text = "Standard $20 pp"
        Me.rbtStandard.UseVisualStyleBackColor = True
        '
        'txbCustFirstName
        '
        Me.txbCustFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txbCustFirstName.Location = New System.Drawing.Point(158, 109)
        Me.txbCustFirstName.Name = "txbCustFirstName"
        Me.txbCustFirstName.Size = New System.Drawing.Size(194, 20)
        Me.txbCustFirstName.TabIndex = 18
        '
        'txbCustSurname
        '
        Me.txbCustSurname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txbCustSurname.Location = New System.Drawing.Point(158, 141)
        Me.txbCustSurname.Name = "txbCustSurname"
        Me.txbCustSurname.Size = New System.Drawing.Size(194, 20)
        Me.txbCustSurname.TabIndex = 19
        '
        'txbNumGuests
        '
        Me.txbNumGuests.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txbNumGuests.Location = New System.Drawing.Point(158, 175)
        Me.txbNumGuests.Name = "txbNumGuests"
        Me.txbNumGuests.Size = New System.Drawing.Size(78, 20)
        Me.txbNumGuests.TabIndex = 20
        '
        'txbNumNights
        '
        Me.txbNumNights.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txbNumNights.Location = New System.Drawing.Point(158, 210)
        Me.txbNumNights.Name = "txbNumNights"
        Me.txbNumNights.Size = New System.Drawing.Size(78, 20)
        Me.txbNumNights.TabIndex = 21
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(764, 533)
        Me.Controls.Add(Me.txbNumNights)
        Me.Controls.Add(Me.txbNumGuests)
        Me.Controls.Add(Me.txbCustSurname)
        Me.Controls.Add(Me.txbCustFirstName)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.chbFoodBasket)
        Me.Controls.Add(Me.chbPillows)
        Me.Controls.Add(Me.cbxRoomType)
        Me.Controls.Add(Me.LsbDisplay)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblCustFirstName)
        Me.Controls.Add(Me.lblCustSurname)
        Me.Controls.Add(Me.lblNumGuests)
        Me.Controls.Add(Me.lblNumNights)
        Me.Controls.Add(Me.lblRoomType)
        Me.Controls.Add(Me.lblRoomRequestCost)
        Me.Controls.Add(Me.lblRmExtras)
        Me.Controls.Add(Me.lblBfastSelection)
        Me.Controls.Add(Me.lblCustomerDetails)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblCustomerDetails As Label
    Friend WithEvents lblBfastSelection As Label
    Friend WithEvents lblRmExtras As Label
    Friend WithEvents lblRoomRequestCost As Label
    Friend WithEvents lblRoomType As Label
    Friend WithEvents lblNumNights As Label
    Friend WithEvents lblNumGuests As Label
    Friend WithEvents lblCustSurname As Label
    Friend WithEvents lblCustFirstName As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents LsbDisplay As ListBox
    Friend WithEvents cbxRoomType As ComboBox
    Friend WithEvents chbPillows As CheckBox
    Friend WithEvents chbFoodBasket As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbtSuperior As RadioButton
    Friend WithEvents rbtDeluxe As RadioButton
    Friend WithEvents rbtStandard As RadioButton
    Friend WithEvents txbCustFirstName As TextBox
    Friend WithEvents txbCustSurname As TextBox
    Friend WithEvents txbNumGuests As TextBox
    Friend WithEvents txbNumNights As TextBox
End Class
