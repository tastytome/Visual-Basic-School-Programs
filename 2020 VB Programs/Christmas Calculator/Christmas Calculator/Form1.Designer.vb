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
        Me.Today_Dtp = New System.Windows.Forms.DateTimePicker()
        Me.Christmas_Dtp = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!)
        Me.Label1.Location = New System.Drawing.Point(52, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(579, 67)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Christmas Calculator"
        '
        'Today_Dtp
        '
        Me.Today_Dtp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Today_Dtp.Location = New System.Drawing.Point(64, 158)
        Me.Today_Dtp.Name = "Today_Dtp"
        Me.Today_Dtp.Size = New System.Drawing.Size(567, 44)
        Me.Today_Dtp.TabIndex = 1
        Me.Today_Dtp.Value = New Date(2020, 4, 23, 12, 29, 38, 0)
        '
        'Christmas_Dtp
        '
        Me.Christmas_Dtp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Christmas_Dtp.Location = New System.Drawing.Point(64, 245)
        Me.Christmas_Dtp.Name = "Christmas_Dtp"
        Me.Christmas_Dtp.Size = New System.Drawing.Size(567, 44)
        Me.Christmas_Dtp.TabIndex = 2
        Me.Christmas_Dtp.Value = New Date(2020, 12, 25, 0, 0, 0, 0)
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(64, 338)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(567, 58)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "How Many Days Till Christmas"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1027, 634)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Christmas_Dtp)
        Me.Controls.Add(Me.Today_Dtp)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Today_Dtp As DateTimePicker
    Friend WithEvents Christmas_Dtp As DateTimePicker
    Friend WithEvents Button1 As Button
End Class
