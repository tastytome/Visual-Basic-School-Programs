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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtAdult = New System.Windows.Forms.TextBox()
        Me.txtChild = New System.Windows.Forms.TextBox()
        Me.txtSeason = New System.Windows.Forms.TextBox()
        Me.txtFare = New System.Windows.Forms.TextBox()
        Me.cbxSeason = New System.Windows.Forms.ComboBox()
        Me.rbnNone = New System.Windows.Forms.RadioButton()
        Me.rbnMotorcycle = New System.Windows.Forms.RadioButton()
        Me.rbnCar = New System.Windows.Forms.RadioButton()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(279, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1074, 90)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sea-Cruiser Fare Calculator"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(72, 229)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(521, 42)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Number of Adult Passengers"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(72, 324)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(521, 42)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Number of Child Passengers"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(904, 259)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(438, 42)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Select Season of Travel"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(723, 757)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(478, 42)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Your Ship Ahoy Fare will be"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(498, 661)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(703, 42)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "You have chosen to Travel in the Season"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(72, 485)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(368, 42)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Select Vehicle Type"
        '
        'txtAdult
        '
        Me.txtAdult.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdult.Location = New System.Drawing.Point(625, 229)
        Me.txtAdult.Name = "txtAdult"
        Me.txtAdult.Size = New System.Drawing.Size(198, 56)
        Me.txtAdult.TabIndex = 7
        '
        'txtChild
        '
        Me.txtChild.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChild.Location = New System.Drawing.Point(625, 324)
        Me.txtChild.Name = "txtChild"
        Me.txtChild.Size = New System.Drawing.Size(198, 56)
        Me.txtChild.TabIndex = 8
        '
        'txtSeason
        '
        Me.txtSeason.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSeason.Location = New System.Drawing.Point(1259, 652)
        Me.txtSeason.Name = "txtSeason"
        Me.txtSeason.Size = New System.Drawing.Size(198, 56)
        Me.txtSeason.TabIndex = 9
        '
        'txtFare
        '
        Me.txtFare.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFare.Location = New System.Drawing.Point(1259, 757)
        Me.txtFare.Name = "txtFare"
        Me.txtFare.Size = New System.Drawing.Size(198, 56)
        Me.txtFare.TabIndex = 10
        '
        'cbxSeason
        '
        Me.cbxSeason.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxSeason.FormattingEnabled = True
        Me.cbxSeason.Items.AddRange(New Object() {"Summer", "Autumn", "Winter", "Spring"})
        Me.cbxSeason.Location = New System.Drawing.Point(911, 324)
        Me.cbxSeason.Name = "cbxSeason"
        Me.cbxSeason.Size = New System.Drawing.Size(546, 59)
        Me.cbxSeason.TabIndex = 11
        '
        'rbnNone
        '
        Me.rbnNone.AutoSize = True
        Me.rbnNone.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnNone.Location = New System.Drawing.Point(112, 572)
        Me.rbnNone.Name = "rbnNone"
        Me.rbnNone.Size = New System.Drawing.Size(139, 46)
        Me.rbnNone.TabIndex = 12
        Me.rbnNone.TabStop = True
        Me.rbnNone.Text = "None"
        Me.rbnNone.UseVisualStyleBackColor = True
        '
        'rbnMotorcycle
        '
        Me.rbnMotorcycle.AutoSize = True
        Me.rbnMotorcycle.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnMotorcycle.Location = New System.Drawing.Point(112, 748)
        Me.rbnMotorcycle.Name = "rbnMotorcycle"
        Me.rbnMotorcycle.Size = New System.Drawing.Size(230, 46)
        Me.rbnMotorcycle.TabIndex = 13
        Me.rbnMotorcycle.TabStop = True
        Me.rbnMotorcycle.Text = "Motorcycle"
        Me.rbnMotorcycle.UseVisualStyleBackColor = True
        '
        'rbnCar
        '
        Me.rbnCar.AutoSize = True
        Me.rbnCar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnCar.Location = New System.Drawing.Point(112, 657)
        Me.rbnCar.Name = "rbnCar"
        Me.rbnCar.Size = New System.Drawing.Size(222, 46)
        Me.rbnCar.TabIndex = 14
        Me.rbnCar.TabStop = True
        Me.rbnCar.Text = "Car / 4WD"
        Me.rbnCar.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Tahoma", 16.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(625, 485)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(832, 97)
        Me.btnCalculate.TabIndex = 15
        Me.btnCalculate.Text = "Calculate Fare"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(1572, 965)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.rbnCar)
        Me.Controls.Add(Me.rbnMotorcycle)
        Me.Controls.Add(Me.rbnNone)
        Me.Controls.Add(Me.cbxSeason)
        Me.Controls.Add(Me.txtFare)
        Me.Controls.Add(Me.txtSeason)
        Me.Controls.Add(Me.txtChild)
        Me.Controls.Add(Me.txtAdult)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Fare Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtAdult As TextBox
    Friend WithEvents txtChild As TextBox
    Friend WithEvents txtSeason As TextBox
    Friend WithEvents txtFare As TextBox
    Friend WithEvents cbxSeason As ComboBox
    Friend WithEvents rbnNone As RadioButton
    Friend WithEvents rbnMotorcycle As RadioButton
    Friend WithEvents rbnCar As RadioButton
    Friend WithEvents btnCalculate As Button
End Class
