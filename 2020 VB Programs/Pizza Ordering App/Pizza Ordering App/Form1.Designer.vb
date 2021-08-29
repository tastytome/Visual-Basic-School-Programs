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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RbnXLarge = New System.Windows.Forms.RadioButton()
        Me.RbnLarge = New System.Windows.Forms.RadioButton()
        Me.RbnMedium = New System.Windows.Forms.RadioButton()
        Me.RbnSmall = New System.Windows.Forms.RadioButton()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.CbxPizzas = New System.Windows.Forms.ComboBox()
        Me.ChxDelivery = New System.Windows.Forms.CheckBox()
        Me.BtnOrder = New System.Windows.Forms.Button()
        Me.LblCost = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RbnXLarge)
        Me.GroupBox1.Controls.Add(Me.RbnLarge)
        Me.GroupBox1.Controls.Add(Me.RbnMedium)
        Me.GroupBox1.Controls.Add(Me.RbnSmall)
        Me.GroupBox1.Location = New System.Drawing.Point(90, 161)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(300, 378)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pizza Size"
        '
        'RbnXLarge
        '
        Me.RbnXLarge.AutoSize = True
        Me.RbnXLarge.Location = New System.Drawing.Point(46, 301)
        Me.RbnXLarge.Name = "RbnXLarge"
        Me.RbnXLarge.Size = New System.Drawing.Size(154, 29)
        Me.RbnXLarge.TabIndex = 3
        Me.RbnXLarge.TabStop = True
        Me.RbnXLarge.Text = "Extra Large"
        Me.RbnXLarge.UseVisualStyleBackColor = True
        '
        'RbnLarge
        '
        Me.RbnLarge.AutoSize = True
        Me.RbnLarge.Location = New System.Drawing.Point(46, 223)
        Me.RbnLarge.Name = "RbnLarge"
        Me.RbnLarge.Size = New System.Drawing.Size(98, 29)
        Me.RbnLarge.TabIndex = 2
        Me.RbnLarge.TabStop = True
        Me.RbnLarge.Text = "Large"
        Me.RbnLarge.UseVisualStyleBackColor = True
        '
        'RbnMedium
        '
        Me.RbnMedium.AutoSize = True
        Me.RbnMedium.Location = New System.Drawing.Point(46, 148)
        Me.RbnMedium.Name = "RbnMedium"
        Me.RbnMedium.Size = New System.Drawing.Size(119, 29)
        Me.RbnMedium.TabIndex = 1
        Me.RbnMedium.TabStop = True
        Me.RbnMedium.Text = "Medium"
        Me.RbnMedium.UseVisualStyleBackColor = True
        '
        'RbnSmall
        '
        Me.RbnSmall.AutoSize = True
        Me.RbnSmall.Location = New System.Drawing.Point(46, 68)
        Me.RbnSmall.Name = "RbnSmall"
        Me.RbnSmall.Size = New System.Drawing.Size(96, 29)
        Me.RbnSmall.TabIndex = 0
        Me.RbnSmall.TabStop = True
        Me.RbnSmall.Text = "Small"
        Me.RbnSmall.UseVisualStyleBackColor = True
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Font = New System.Drawing.Font("Trebuchet MS", 25.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.Location = New System.Drawing.Point(75, 42)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(699, 86)
        Me.LblTitle.TabIndex = 1
        Me.LblTitle.Text = "TRAN EMPIRE PIZZAS"
        '
        'CbxPizzas
        '
        Me.CbxPizzas.FormattingEnabled = True
        Me.CbxPizzas.Items.AddRange(New Object() {"Hawaiian", "Capricciosa", "Aussie", "Meat Lovers", "Four Seasons", "Supreme", "Margarita"})
        Me.CbxPizzas.Location = New System.Drawing.Point(424, 225)
        Me.CbxPizzas.Name = "CbxPizzas"
        Me.CbxPizzas.Size = New System.Drawing.Size(337, 33)
        Me.CbxPizzas.TabIndex = 2
        '
        'ChxDelivery
        '
        Me.ChxDelivery.AutoSize = True
        Me.ChxDelivery.Location = New System.Drawing.Point(424, 293)
        Me.ChxDelivery.Name = "ChxDelivery"
        Me.ChxDelivery.Size = New System.Drawing.Size(134, 29)
        Me.ChxDelivery.TabIndex = 3
        Me.ChxDelivery.Text = "Delivery?"
        Me.ChxDelivery.UseVisualStyleBackColor = True
        '
        'BtnOrder
        '
        Me.BtnOrder.Location = New System.Drawing.Point(585, 284)
        Me.BtnOrder.Name = "BtnOrder"
        Me.BtnOrder.Size = New System.Drawing.Size(176, 45)
        Me.BtnOrder.TabIndex = 4
        Me.BtnOrder.Text = "Order Now!"
        Me.BtnOrder.UseVisualStyleBackColor = True
        '
        'LblCost
        '
        Me.LblCost.AutoSize = True
        Me.LblCost.Location = New System.Drawing.Point(432, 345)
        Me.LblCost.Name = "LblCost"
        Me.LblCost.Size = New System.Drawing.Size(0, 25)
        Me.LblCost.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Yellow
        Me.ClientSize = New System.Drawing.Size(959, 615)
        Me.Controls.Add(Me.LblCost)
        Me.Controls.Add(Me.BtnOrder)
        Me.Controls.Add(Me.ChxDelivery)
        Me.Controls.Add(Me.CbxPizzas)
        Me.Controls.Add(Me.LblTitle)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Pizza Ordering App"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RbnXLarge As RadioButton
    Friend WithEvents RbnLarge As RadioButton
    Friend WithEvents RbnMedium As RadioButton
    Friend WithEvents RbnSmall As RadioButton
    Friend WithEvents LblTitle As Label
    Friend WithEvents CbxPizzas As ComboBox
    Friend WithEvents ChxDelivery As CheckBox
    Friend WithEvents BtnOrder As Button
    Friend WithEvents LblCost As Label
End Class
