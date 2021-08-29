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
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.Today_Dtp = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Birthday_Dtp = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(49, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(630, 73)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "AGE CALCULATOR"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(55, 162)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(266, 37)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter Your Name"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(524, 162)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(574, 44)
        Me.txtName.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(55, 254)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(370, 37)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "What Is the Date Today?"
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(801, 480)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(297, 65)
        Me.btnCalculate.TabIndex = 5
        Me.btnCalculate.Text = "Calculate My Age"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'Today_Dtp
        '
        Me.Today_Dtp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Today_Dtp.Location = New System.Drawing.Point(524, 254)
        Me.Today_Dtp.Name = "Today_Dtp"
        Me.Today_Dtp.Size = New System.Drawing.Size(574, 44)
        Me.Today_Dtp.TabIndex = 6
        Me.Today_Dtp.Value = New Date(2020, 4, 23, 12, 16, 44, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(55, 343)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(434, 37)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "What Year Where You Born?"
        '
        'Birthday_Dtp
        '
        Me.Birthday_Dtp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Birthday_Dtp.Location = New System.Drawing.Point(524, 343)
        Me.Birthday_Dtp.Name = "Birthday_Dtp"
        Me.Birthday_Dtp.Size = New System.Drawing.Size(574, 44)
        Me.Birthday_Dtp.TabIndex = 8
        Me.Birthday_Dtp.Value = New Date(2020, 4, 23, 12, 16, 44, 0)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1185, 622)
        Me.Controls.Add(Me.Birthday_Dtp)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Today_Dtp)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents Today_Dtp As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Birthday_Dtp As DateTimePicker
End Class
