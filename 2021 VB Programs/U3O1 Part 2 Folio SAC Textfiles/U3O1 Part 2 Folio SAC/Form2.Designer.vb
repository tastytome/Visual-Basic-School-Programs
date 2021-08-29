<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReports
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
        Me.cbxStates = New System.Windows.Forms.ComboBox()
        Me.lsbCustomerList = New System.Windows.Forms.ListBox()
        Me.btnReturnMainMenu = New System.Windows.Forms.Button()
        Me.btnListCustByState = New System.Windows.Forms.Button()
        Me.btnListAllCustomerDetails = New System.Windows.Forms.Button()
        Me.lblSelect = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnListPlatinumCust = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cbxStates
        '
        Me.cbxStates.FormattingEnabled = True
        Me.cbxStates.Items.AddRange(New Object() {"VIC", "NSW", "QLD", "NT", "WA", "SA"})
        Me.cbxStates.Location = New System.Drawing.Point(246, 78)
        Me.cbxStates.Name = "cbxStates"
        Me.cbxStates.Size = New System.Drawing.Size(111, 23)
        Me.cbxStates.TabIndex = 19
        '
        'lsbCustomerList
        '
        Me.lsbCustomerList.FormattingEnabled = True
        Me.lsbCustomerList.ItemHeight = 15
        Me.lsbCustomerList.Location = New System.Drawing.Point(12, 108)
        Me.lsbCustomerList.Name = "lsbCustomerList"
        Me.lsbCustomerList.Size = New System.Drawing.Size(462, 289)
        Me.lsbCustomerList.TabIndex = 18
        '
        'btnReturnMainMenu
        '
        Me.btnReturnMainMenu.Location = New System.Drawing.Point(480, 359)
        Me.btnReturnMainMenu.Name = "btnReturnMainMenu"
        Me.btnReturnMainMenu.Size = New System.Drawing.Size(111, 38)
        Me.btnReturnMainMenu.TabIndex = 17
        Me.btnReturnMainMenu.Text = "Return to Main Form"
        Me.btnReturnMainMenu.UseVisualStyleBackColor = True
        '
        'btnListCustByState
        '
        Me.btnListCustByState.Location = New System.Drawing.Point(129, 54)
        Me.btnListCustByState.Name = "btnListCustByState"
        Me.btnListCustByState.Size = New System.Drawing.Size(111, 48)
        Me.btnListCustByState.TabIndex = 16
        Me.btnListCustByState.Text = "List All Customers by State"
        Me.btnListCustByState.UseVisualStyleBackColor = True
        '
        'btnListAllCustomerDetails
        '
        Me.btnListAllCustomerDetails.Location = New System.Drawing.Point(12, 54)
        Me.btnListAllCustomerDetails.Name = "btnListAllCustomerDetails"
        Me.btnListAllCustomerDetails.Size = New System.Drawing.Size(111, 48)
        Me.btnListAllCustomerDetails.TabIndex = 15
        Me.btnListAllCustomerDetails.Text = "List All Customer Details"
        Me.btnListAllCustomerDetails.UseVisualStyleBackColor = True
        '
        'lblSelect
        '
        Me.lblSelect.AutoSize = True
        Me.lblSelect.Location = New System.Drawing.Point(246, 54)
        Me.lblSelect.Name = "lblSelect"
        Me.lblSelect.Size = New System.Drawing.Size(67, 15)
        Me.lblSelect.TabIndex = 14
        Me.lblSelect.Text = "Select State"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.Location = New System.Drawing.Point(12, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(362, 28)
        Me.lblTitle.TabIndex = 20
        Me.lblTitle.Text = "Mr Mac's Magnificent Motel Reports"
        '
        'btnListPlatinumCust
        '
        Me.btnListPlatinumCust.Location = New System.Drawing.Point(363, 54)
        Me.btnListPlatinumCust.Name = "btnListPlatinumCust"
        Me.btnListPlatinumCust.Size = New System.Drawing.Size(111, 47)
        Me.btnListPlatinumCust.TabIndex = 21
        Me.btnListPlatinumCust.Text = "List of Platinum Customers"
        Me.btnListPlatinumCust.UseVisualStyleBackColor = True
        '
        'FrmReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(603, 413)
        Me.Controls.Add(Me.btnListPlatinumCust)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.cbxStates)
        Me.Controls.Add(Me.lsbCustomerList)
        Me.Controls.Add(Me.btnReturnMainMenu)
        Me.Controls.Add(Me.btnListCustByState)
        Me.Controls.Add(Me.btnListAllCustomerDetails)
        Me.Controls.Add(Me.lblSelect)
        Me.Name = "FrmReports"
        Me.Text = "FrmReports"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbxStates As ComboBox
    Friend WithEvents lsbCustomerList As ListBox
    Friend WithEvents btnReturnMainMenu As Button
    Friend WithEvents btnListCustByState As Button
    Friend WithEvents btnListAllCustomerDetails As Button
    Friend WithEvents lblSelect As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnListPlatinumCust As Button
End Class
