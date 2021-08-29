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
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("")
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTotalValue = New System.Windows.Forms.TextBox()
        Me.lstStock = New System.Windows.Forms.ListView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTotalStock = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnContract = New System.Windows.Forms.Button()
        Me.btnEmployee = New System.Windows.Forms.Button()
        Me.lstEmployee = New System.Windows.Forms.ListView()
        Me.lstContract = New System.Windows.Forms.ListView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtInputName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(17, 38)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(243, 58)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.Text = "Stock Inventory"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(755, 565)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(180, 37)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Total Value"
        '
        'txtTotalValue
        '
        Me.txtTotalValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalValue.Location = New System.Drawing.Point(29, 227)
        Me.txtTotalValue.Name = "txtTotalValue"
        Me.txtTotalValue.Size = New System.Drawing.Size(223, 44)
        Me.txtTotalValue.TabIndex = 5
        '
        'lstStock
        '
        Me.lstStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstStock.HideSelection = False
        Me.lstStock.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem2})
        Me.lstStock.Location = New System.Drawing.Point(45, 264)
        Me.lstStock.Name = "lstStock"
        Me.lstStock.Size = New System.Drawing.Size(1253, 439)
        Me.lstStock.TabIndex = 9
        Me.lstStock.UseCompatibleStateImageBehavior = False
        Me.lstStock.View = System.Windows.Forms.View.Details
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(32, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(1584, 77)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "TKR Industries Shipping Co. Employee Interface"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtTotalStock)
        Me.GroupBox1.Controls.Add(Me.txtTotalValue)
        Me.GroupBox1.Location = New System.Drawing.Point(1316, 264)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(300, 439)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Inventory Summary"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 25)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Total Value"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 25)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Total Stock"
        '
        'txtTotalStock
        '
        Me.txtTotalStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalStock.Location = New System.Drawing.Point(29, 89)
        Me.txtTotalStock.Name = "txtTotalStock"
        Me.txtTotalStock.Size = New System.Drawing.Size(223, 44)
        Me.txtTotalStock.TabIndex = 12
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnContract)
        Me.GroupBox2.Controls.Add(Me.btnEmployee)
        Me.GroupBox2.Controls.Add(Me.btnSearch)
        Me.GroupBox2.Location = New System.Drawing.Point(805, 131)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(811, 115)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Controls"
        '
        'btnContract
        '
        Me.btnContract.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContract.Location = New System.Drawing.Point(528, 40)
        Me.btnContract.Name = "btnContract"
        Me.btnContract.Size = New System.Drawing.Size(253, 58)
        Me.btnContract.TabIndex = 18
        Me.btnContract.Text = "Important Contracts"
        Me.btnContract.UseVisualStyleBackColor = True
        '
        'btnEmployee
        '
        Me.btnEmployee.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmployee.Location = New System.Drawing.Point(266, 38)
        Me.btnEmployee.Name = "btnEmployee"
        Me.btnEmployee.Size = New System.Drawing.Size(256, 58)
        Me.btnEmployee.TabIndex = 17
        Me.btnEmployee.Text = "Employee Directory"
        Me.btnEmployee.UseVisualStyleBackColor = True
        '
        'lstEmployee
        '
        Me.lstEmployee.HideSelection = False
        Me.lstEmployee.Location = New System.Drawing.Point(45, 728)
        Me.lstEmployee.Margin = New System.Windows.Forms.Padding(6)
        Me.lstEmployee.Name = "lstEmployee"
        Me.lstEmployee.Size = New System.Drawing.Size(768, 332)
        Me.lstEmployee.TabIndex = 15
        Me.lstEmployee.UseCompatibleStateImageBehavior = False
        Me.lstEmployee.View = System.Windows.Forms.View.Tile
        '
        'lstContract
        '
        Me.lstContract.HideSelection = False
        Me.lstContract.Location = New System.Drawing.Point(842, 728)
        Me.lstContract.Margin = New System.Windows.Forms.Padding(6)
        Me.lstContract.Name = "lstContract"
        Me.lstContract.Size = New System.Drawing.Size(774, 332)
        Me.lstContract.TabIndex = 14
        Me.lstContract.UseCompatibleStateImageBehavior = False
        Me.lstContract.View = System.Windows.Forms.View.Details
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.btnLogin)
        Me.GroupBox3.Controls.Add(Me.txtInputName)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Location = New System.Drawing.Point(45, 131)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(736, 115)
        Me.GroupBox3.TabIndex = 19
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Login"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 25)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Enter"
        '
        'btnLogin
        '
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Location = New System.Drawing.Point(633, 38)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(87, 58)
        Me.btnLogin.TabIndex = 19
        Me.btnLogin.Text = "Log"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'txtInputName
        '
        Me.txtInputName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInputName.Location = New System.Drawing.Point(198, 44)
        Me.txtInputName.Name = "txtInputName"
        Me.txtInputName.Size = New System.Drawing.Size(418, 44)
        Me.txtInputName.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(175, 25)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Employee Name:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(1692, 1109)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.lstEmployee)
        Me.Controls.Add(Me.lstContract)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lstStock)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Form1"
        Me.Text = "TKR Industries Shipping Co. Employee Interface"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents btnSearch As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTotalValue As TextBox
    Friend WithEvents lstStock As ListView
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTotalStock As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Public WithEvents btnContract As Button
    Public WithEvents btnEmployee As Button
    Friend WithEvents lstEmployee As ListView
    Friend WithEvents lstContract As ListView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtInputName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Public WithEvents btnLogin As Button
End Class
