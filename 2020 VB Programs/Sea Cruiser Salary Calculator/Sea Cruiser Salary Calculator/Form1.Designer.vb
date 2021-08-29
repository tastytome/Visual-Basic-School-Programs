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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.cbxCategory = New System.Windows.Forms.ComboBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtHours = New System.Windows.Forms.TextBox()
        Me.txtPay = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.rbnWeekend = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(127, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1144, 90)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Sea-Cruiser Salary Calculator"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(158, 214)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(306, 42)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Employee Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(763, 214)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(363, 42)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Employee Category"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(158, 418)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(269, 42)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Hours of Work"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(763, 418)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(286, 42)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Weekend Work"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(158, 503)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(383, 37)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Number of Hours Worked"
        '
        'lblDisplay
        '
        Me.lblDisplay.AutoSize = True
        Me.lblDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplay.Location = New System.Drawing.Point(158, 737)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(821, 37)
        Me.lblDisplay.TabIndex = 8
        Me.lblDisplay.Text = "The weekly pay for [display employee name here] will be:"
        '
        'cbxCategory
        '
        Me.cbxCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxCategory.FormattingEnabled = True
        Me.cbxCategory.Items.AddRange(New Object() {"Senior", "General", "Casual"})
        Me.cbxCategory.Location = New System.Drawing.Point(770, 280)
        Me.cbxCategory.Name = "cbxCategory"
        Me.cbxCategory.Size = New System.Drawing.Size(454, 59)
        Me.cbxCategory.TabIndex = 12
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(165, 283)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(517, 56)
        Me.txtName.TabIndex = 13
        '
        'txtHours
        '
        Me.txtHours.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHours.Location = New System.Drawing.Point(568, 488)
        Me.txtHours.Name = "txtHours"
        Me.txtHours.Size = New System.Drawing.Size(114, 56)
        Me.txtHours.TabIndex = 14
        '
        'txtPay
        '
        Me.txtPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPay.Location = New System.Drawing.Point(1026, 722)
        Me.txtPay.Name = "txtPay"
        Me.txtPay.Size = New System.Drawing.Size(198, 56)
        Me.txtPay.TabIndex = 16
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Tahoma", 16.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(165, 588)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(1059, 97)
        Me.btnCalculate.TabIndex = 17
        Me.btnCalculate.Text = "Calculate Salary"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'rbnWeekend
        '
        Me.rbnWeekend.AutoSize = True
        Me.rbnWeekend.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnWeekend.Location = New System.Drawing.Point(770, 494)
        Me.rbnWeekend.Name = "rbnWeekend"
        Me.rbnWeekend.Size = New System.Drawing.Size(114, 46)
        Me.rbnWeekend.TabIndex = 15
        Me.rbnWeekend.TabStop = True
        Me.rbnWeekend.Text = "Yes"
        Me.rbnWeekend.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(1358, 920)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtPay)
        Me.Controls.Add(Me.rbnWeekend)
        Me.Controls.Add(Me.txtHours)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.cbxCategory)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Salary Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblDisplay As Label
    Friend WithEvents cbxCategory As ComboBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtHours As TextBox
    Friend WithEvents txtPay As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents rbnWeekend As RadioButton
End Class
