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
        Me.txtTeacher1Name = New System.Windows.Forms.TextBox()
        Me.txtTeacher2Name = New System.Windows.Forms.TextBox()
        Me.txtTeacher1Day = New System.Windows.Forms.TextBox()
        Me.txtTeacher1Duty = New System.Windows.Forms.TextBox()
        Me.txtTeacher2Day = New System.Windows.Forms.TextBox()
        Me.txtTeacher2Duty = New System.Windows.Forms.TextBox()
        Me.btnSwap = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.chkDay = New System.Windows.Forms.CheckBox()
        Me.chkDuty = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(293, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Yard Duty"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(66, 165)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Teacher I"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(66, 217)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Teacher II"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(331, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Day"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(456, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(19, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = " "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(444, 123)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 25)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Duty"
        '
        'txtTeacher1Name
        '
        Me.txtTeacher1Name.Location = New System.Drawing.Point(189, 165)
        Me.txtTeacher1Name.Name = "txtTeacher1Name"
        Me.txtTeacher1Name.Size = New System.Drawing.Size(100, 23)
        Me.txtTeacher1Name.TabIndex = 8
        '
        'txtTeacher2Name
        '
        Me.txtTeacher2Name.Location = New System.Drawing.Point(189, 217)
        Me.txtTeacher2Name.Name = "txtTeacher2Name"
        Me.txtTeacher2Name.Size = New System.Drawing.Size(100, 23)
        Me.txtTeacher2Name.TabIndex = 9
        '
        'txtTeacher1Day
        '
        Me.txtTeacher1Day.Location = New System.Drawing.Point(307, 165)
        Me.txtTeacher1Day.Name = "txtTeacher1Day"
        Me.txtTeacher1Day.Size = New System.Drawing.Size(100, 23)
        Me.txtTeacher1Day.TabIndex = 10
        '
        'txtTeacher1Duty
        '
        Me.txtTeacher1Duty.Location = New System.Drawing.Point(420, 165)
        Me.txtTeacher1Duty.Name = "txtTeacher1Duty"
        Me.txtTeacher1Duty.Size = New System.Drawing.Size(100, 23)
        Me.txtTeacher1Duty.TabIndex = 11
        '
        'txtTeacher2Day
        '
        Me.txtTeacher2Day.Location = New System.Drawing.Point(307, 217)
        Me.txtTeacher2Day.Name = "txtTeacher2Day"
        Me.txtTeacher2Day.Size = New System.Drawing.Size(100, 23)
        Me.txtTeacher2Day.TabIndex = 12
        '
        'txtTeacher2Duty
        '
        Me.txtTeacher2Duty.Location = New System.Drawing.Point(420, 217)
        Me.txtTeacher2Duty.Name = "txtTeacher2Duty"
        Me.txtTeacher2Duty.Size = New System.Drawing.Size(100, 23)
        Me.txtTeacher2Duty.TabIndex = 13
        '
        'btnSwap
        '
        Me.btnSwap.Location = New System.Drawing.Point(200, 297)
        Me.btnSwap.Name = "btnSwap"
        Me.btnSwap.Size = New System.Drawing.Size(75, 23)
        Me.btnSwap.TabIndex = 14
        Me.btnSwap.Text = "Swap"
        Me.btnSwap.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(318, 297)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 15
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(433, 297)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 16
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'chkDay
        '
        Me.chkDay.AutoSize = True
        Me.chkDay.Location = New System.Drawing.Point(318, 259)
        Me.chkDay.Name = "chkDay"
        Me.chkDay.Size = New System.Drawing.Size(77, 19)
        Me.chkDay.TabIndex = 17
        Me.chkDay.Text = "Swap Day"
        Me.chkDay.UseVisualStyleBackColor = True
        '
        'chkDuty
        '
        Me.chkDuty.AutoSize = True
        Me.chkDuty.Location = New System.Drawing.Point(433, 259)
        Me.chkDuty.Name = "chkDuty"
        Me.chkDuty.Size = New System.Drawing.Size(82, 19)
        Me.chkDuty.TabIndex = 18
        Me.chkDuty.Text = "Swap Duty"
        Me.chkDuty.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(726, 389)
        Me.Controls.Add(Me.chkDuty)
        Me.Controls.Add(Me.chkDay)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSwap)
        Me.Controls.Add(Me.txtTeacher2Duty)
        Me.Controls.Add(Me.txtTeacher2Day)
        Me.Controls.Add(Me.txtTeacher1Duty)
        Me.Controls.Add(Me.txtTeacher1Day)
        Me.Controls.Add(Me.txtTeacher2Name)
        Me.Controls.Add(Me.txtTeacher1Name)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Yard Duty Slave Labour"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtTeacher1Name As TextBox
    Friend WithEvents txtTeacher2Name As TextBox
    Friend WithEvents txtTeacher1Day As TextBox
    Friend WithEvents txtTeacher1Duty As TextBox
    Friend WithEvents txtTeacher2Day As TextBox
    Friend WithEvents txtTeacher2Duty As TextBox
    Friend WithEvents btnSwap As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents chkDay As CheckBox
    Friend WithEvents chkDuty As CheckBox
End Class
