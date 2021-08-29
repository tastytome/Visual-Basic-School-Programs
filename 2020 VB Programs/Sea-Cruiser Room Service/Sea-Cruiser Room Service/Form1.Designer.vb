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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRoom = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbxEntree = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbxDessert = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbxMain = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbtWater = New System.Windows.Forms.RadioButton()
        Me.rbtChocolate = New System.Windows.Forms.RadioButton()
        Me.rbtCoke = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbtMember = New System.Windows.Forms.RadioButton()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 19.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(72, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1117, 64)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Sea-Cruiser Room-Service Meal Ordering"
        '
        'txtRoom
        '
        Me.txtRoom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoom.Location = New System.Drawing.Point(309, 155)
        Me.txtRoom.Name = "txtRoom"
        Me.txtRoom.Size = New System.Drawing.Size(198, 38)
        Me.txtRoom.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(77, 158)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(226, 35)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Room Number"
        '
        'cbxEntree
        '
        Me.cbxEntree.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxEntree.FormattingEnabled = True
        Me.cbxEntree.Items.AddRange(New Object() {"Squid $5.50", "Prawn Cocktail $9.00", "Chicken Salad $10.50", "Honey Prawns $8.80"})
        Me.cbxEntree.Location = New System.Drawing.Point(83, 403)
        Me.cbxEntree.Name = "cbxEntree"
        Me.cbxEntree.Size = New System.Drawing.Size(424, 39)
        Me.cbxEntree.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(78, 312)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(504, 25)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Select ONE Entree, ONE Main, and ONE Dessert"
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Tahoma", 10.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(635, 531)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(554, 62)
        Me.btnCalculate.TabIndex = 18
        Me.btnCalculate.Text = "Calculate Price"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'txtCost
        '
        Me.txtCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCost.Location = New System.Drawing.Point(961, 618)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(228, 38)
        Me.txtCost.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 10.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(629, 618)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(315, 35)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Your Order Will Cost"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(77, 365)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 35)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Entree"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(77, 576)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 35)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Dessert"
        '
        'cbxDessert
        '
        Me.cbxDessert.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxDessert.FormattingEnabled = True
        Me.cbxDessert.Items.AddRange(New Object() {"Apple Pie $11.00", "Golden Syrup Dumplng $15.50", "Fruit Salad $9.50", "Lemon Pancakes $12.00", "Sticky Date Pudding $16.50"})
        Me.cbxDessert.Location = New System.Drawing.Point(83, 614)
        Me.cbxDessert.Name = "cbxDessert"
        Me.cbxDessert.Size = New System.Drawing.Size(424, 39)
        Me.cbxDessert.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(77, 470)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 35)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Main"
        '
        'cbxMain
        '
        Me.cbxMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxMain.FormattingEnabled = True
        Me.cbxMain.Items.AddRange(New Object() {"Lasagna $25.00", "Chicken Burger $18.50", "Fish & Chips $20.50", "Vegan Pizza $19.00"})
        Me.cbxMain.Location = New System.Drawing.Point(83, 508)
        Me.cbxMain.Name = "cbxMain"
        Me.cbxMain.Size = New System.Drawing.Size(424, 39)
        Me.cbxMain.TabIndex = 22
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbtWater)
        Me.GroupBox1.Controls.Add(Me.rbtChocolate)
        Me.GroupBox1.Controls.Add(Me.rbtCoke)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(635, 312)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(554, 193)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Drinks"
        '
        'rbtWater
        '
        Me.rbtWater.AutoSize = True
        Me.rbtWater.Font = New System.Drawing.Font("Tahoma", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtWater.Location = New System.Drawing.Point(38, 126)
        Me.rbtWater.Name = "rbtWater"
        Me.rbtWater.Size = New System.Drawing.Size(172, 29)
        Me.rbtWater.TabIndex = 1
        Me.rbtWater.TabStop = True
        Me.rbtWater.Text = "Water ($4.00)"
        Me.rbtWater.UseVisualStyleBackColor = True
        '
        'rbtChocolate
        '
        Me.rbtChocolate.AutoSize = True
        Me.rbtChocolate.Font = New System.Drawing.Font("Tahoma", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtChocolate.Location = New System.Drawing.Point(38, 91)
        Me.rbtChocolate.Name = "rbtChocolate"
        Me.rbtChocolate.Size = New System.Drawing.Size(303, 29)
        Me.rbtChocolate.TabIndex = 2
        Me.rbtChocolate.TabStop = True
        Me.rbtChocolate.Text = "Chocolate Milkshake ($6.00)"
        Me.rbtChocolate.UseVisualStyleBackColor = True
        '
        'rbtCoke
        '
        Me.rbtCoke.AutoSize = True
        Me.rbtCoke.Font = New System.Drawing.Font("Tahoma", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtCoke.Location = New System.Drawing.Point(38, 53)
        Me.rbtCoke.Name = "rbtCoke"
        Me.rbtCoke.Size = New System.Drawing.Size(161, 29)
        Me.rbtCoke.TabIndex = 3
        Me.rbtCoke.TabStop = True
        Me.rbtCoke.Text = "Coke ($5.00)"
        Me.rbtCoke.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbtMember)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(635, 158)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(554, 148)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Check this box if you are a Member"
        '
        'rbtMember
        '
        Me.rbtMember.AutoSize = True
        Me.rbtMember.Font = New System.Drawing.Font("Tahoma", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtMember.Location = New System.Drawing.Point(38, 43)
        Me.rbtMember.Name = "rbtMember"
        Me.rbtMember.Size = New System.Drawing.Size(308, 29)
        Me.rbtMember.TabIndex = 0
        Me.rbtMember.TabStop = True
        Me.rbtMember.Text = "Member Discount (10% Off)"
        Me.rbtMember.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Tahoma", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(961, 670)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(228, 49)
        Me.btnReset.TabIndex = 27
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(1247, 746)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cbxMain)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbxDessert)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtCost)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbxEntree)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtRoom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Room Service"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtRoom As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbxEntree As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents txtCost As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cbxDessert As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cbxMain As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbtWater As RadioButton
    Friend WithEvents rbtChocolate As RadioButton
    Friend WithEvents rbtCoke As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rbtMember As RadioButton
    Friend WithEvents btnReset As Button
End Class
