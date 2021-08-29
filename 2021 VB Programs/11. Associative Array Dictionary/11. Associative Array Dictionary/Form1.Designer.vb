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
        Me.btnBorrowToy = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbxItemsList = New System.Windows.Forms.ComboBox()
        Me.lsbDisplay = New System.Windows.Forms.ListBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.gbxControls = New System.Windows.Forms.GroupBox()
        Me.btnSearchName = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnListNames = New System.Windows.Forms.Button()
        Me.cbxNamesList = New System.Windows.Forms.ComboBox()
        Me.btnSearchItem = New System.Windows.Forms.Button()
        Me.btnDisplayItems = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.gbxControls.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBorrowToy
        '
        Me.btnBorrowToy.Location = New System.Drawing.Point(21, 158)
        Me.btnBorrowToy.Name = "btnBorrowToy"
        Me.btnBorrowToy.Size = New System.Drawing.Size(101, 23)
        Me.btnBorrowToy.TabIndex = 5
        Me.btnBorrowToy.Text = "Borrow Item"
        Me.btnBorrowToy.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 15)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Enter Your Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(210, 15)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Select an Item from the Dropdown List"
        '
        'cbxItemsList
        '
        Me.cbxItemsList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxItemsList.FormattingEnabled = True
        Me.cbxItemsList.Items.AddRange(New Object() {"bicycle", "train", "doll", "ball", "teddy bear", "kite", "rubber ducky", "airplane"})
        Me.cbxItemsList.Location = New System.Drawing.Point(21, 106)
        Me.cbxItemsList.Name = "cbxItemsList"
        Me.cbxItemsList.Size = New System.Drawing.Size(209, 23)
        Me.cbxItemsList.TabIndex = 10
        '
        'lsbDisplay
        '
        Me.lsbDisplay.FormattingEnabled = True
        Me.lsbDisplay.ItemHeight = 15
        Me.lsbDisplay.Location = New System.Drawing.Point(13, 20)
        Me.lsbDisplay.Name = "lsbDisplay"
        Me.lsbDisplay.Size = New System.Drawing.Size(361, 379)
        Me.lsbDisplay.TabIndex = 11
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(128, 410)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(102, 23)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(4, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(389, 37)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Associative Array Dictionary "
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(21, 410)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(102, 23)
        Me.btnClear.TabIndex = 14
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'gbxControls
        '
        Me.gbxControls.Controls.Add(Me.btnExit)
        Me.gbxControls.Controls.Add(Me.btnClear)
        Me.gbxControls.Controls.Add(Me.btnSearchName)
        Me.gbxControls.Controls.Add(Me.btnReturn)
        Me.gbxControls.Controls.Add(Me.btnListNames)
        Me.gbxControls.Controls.Add(Me.cbxNamesList)
        Me.gbxControls.Controls.Add(Me.btnSearchItem)
        Me.gbxControls.Controls.Add(Me.cbxItemsList)
        Me.gbxControls.Controls.Add(Me.btnBorrowToy)
        Me.gbxControls.Controls.Add(Me.Label1)
        Me.gbxControls.Controls.Add(Me.Label2)
        Me.gbxControls.Location = New System.Drawing.Point(12, 79)
        Me.gbxControls.Name = "gbxControls"
        Me.gbxControls.Size = New System.Drawing.Size(247, 448)
        Me.gbxControls.TabIndex = 16
        Me.gbxControls.TabStop = False
        Me.gbxControls.Text = "Controls"
        '
        'btnSearchName
        '
        Me.btnSearchName.Location = New System.Drawing.Point(20, 274)
        Me.btnSearchName.Name = "btnSearchName"
        Me.btnSearchName.Size = New System.Drawing.Size(210, 23)
        Me.btnSearchName.TabIndex = 22
        Me.btnSearchName.Text = "Search for a Name"
        Me.btnSearchName.UseVisualStyleBackColor = True
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(128, 158)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(102, 23)
        Me.btnReturn.TabIndex = 12
        Me.btnReturn.Text = "Return Item"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'btnListNames
        '
        Me.btnListNames.Location = New System.Drawing.Point(20, 245)
        Me.btnListNames.Name = "btnListNames"
        Me.btnListNames.Size = New System.Drawing.Size(210, 23)
        Me.btnListNames.TabIndex = 21
        Me.btnListNames.Text = "List Names"
        Me.btnListNames.UseVisualStyleBackColor = True
        '
        'cbxNamesList
        '
        Me.cbxNamesList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxNamesList.FormattingEnabled = True
        Me.cbxNamesList.Items.AddRange(New Object() {"Anna", "Barry", "Craig", "David", "Ella", "Frank", "Girthy", "Hilda", "Isla", "Jenny", "Karen"})
        Me.cbxNamesList.Location = New System.Drawing.Point(21, 47)
        Me.cbxNamesList.Name = "cbxNamesList"
        Me.cbxNamesList.Size = New System.Drawing.Size(209, 23)
        Me.cbxNamesList.TabIndex = 11
        '
        'btnSearchItem
        '
        Me.btnSearchItem.Location = New System.Drawing.Point(21, 187)
        Me.btnSearchItem.Name = "btnSearchItem"
        Me.btnSearchItem.Size = New System.Drawing.Size(210, 23)
        Me.btnSearchItem.TabIndex = 20
        Me.btnSearchItem.Text = "Check If Item Borrowed"
        Me.btnSearchItem.UseVisualStyleBackColor = True
        '
        'btnDisplayItems
        '
        Me.btnDisplayItems.Location = New System.Drawing.Point(13, 410)
        Me.btnDisplayItems.Name = "btnDisplayItems"
        Me.btnDisplayItems.Size = New System.Drawing.Size(361, 23)
        Me.btnDisplayItems.TabIndex = 19
        Me.btnDisplayItems.Text = "Display Borrowed Items"
        Me.btnDisplayItems.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lsbDisplay)
        Me.GroupBox3.Controls.Add(Me.btnDisplayItems)
        Me.GroupBox3.Location = New System.Drawing.Point(265, 79)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(393, 448)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Display"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(646, 61)
        Me.GroupBox4.TabIndex = 18
        Me.GroupBox4.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(670, 491)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.gbxControls)
        Me.Name = "Form1"
        Me.Text = "Dictionary"
        Me.gbxControls.ResumeLayout(False)
        Me.gbxControls.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBorrowToy As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txbBorrowerName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbxItemsList As ComboBox
    Friend WithEvents lsbDisplay As ListBox
    Friend WithEvents btnExit As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents gbxControls As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents cbxNamesList As ComboBox
    Friend WithEvents btnReturn As Button
    Friend WithEvents btnDisplayItems As Button
    Friend WithEvents btnSearchName As Button
    Friend WithEvents btnListNames As Button
    Friend WithEvents btnSearchItem As Button
End Class
