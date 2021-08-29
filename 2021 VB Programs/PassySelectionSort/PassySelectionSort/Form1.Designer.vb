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
        Me.ListBoxUnsorted = New System.Windows.Forms.ListBox()
        Me.ListBoxSORTED = New System.Windows.Forms.ListBox()
        Me.btnSort = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSort2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(136, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Selection Sort"
        '
        'ListBoxUnsorted
        '
        Me.ListBoxUnsorted.FormattingEnabled = True
        Me.ListBoxUnsorted.Location = New System.Drawing.Point(40, 59)
        Me.ListBoxUnsorted.Name = "ListBoxUnsorted"
        Me.ListBoxUnsorted.Size = New System.Drawing.Size(159, 225)
        Me.ListBoxUnsorted.TabIndex = 1
        '
        'ListBoxSORTED
        '
        Me.ListBoxSORTED.FormattingEnabled = True
        Me.ListBoxSORTED.Location = New System.Drawing.Point(245, 59)
        Me.ListBoxSORTED.Name = "ListBoxSORTED"
        Me.ListBoxSORTED.Size = New System.Drawing.Size(154, 225)
        Me.ListBoxSORTED.TabIndex = 2
        '
        'btnSort
        '
        Me.btnSort.Location = New System.Drawing.Point(60, 290)
        Me.btnSort.Name = "btnSort"
        Me.btnSort.Size = New System.Drawing.Size(110, 32)
        Me.btnSort.TabIndex = 3
        Me.btnSort.Text = "Sort Data"
        Me.btnSort.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(272, 321)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(101, 34)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(87, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Unsorted "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(294, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Sorted"
        '
        'btnSort2
        '
        Me.btnSort2.Location = New System.Drawing.Point(60, 331)
        Me.btnSort2.Name = "btnSort2"
        Me.btnSort2.Size = New System.Drawing.Size(110, 38)
        Me.btnSort2.TabIndex = 7
        Me.btnSort2.Text = "Sort Two items"
        Me.btnSort2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 395)
        Me.Controls.Add(Me.btnSort2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSort)
        Me.Controls.Add(Me.ListBoxSORTED)
        Me.Controls.Add(Me.ListBoxUnsorted)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ListBoxUnsorted As System.Windows.Forms.ListBox
    Friend WithEvents ListBoxSORTED As System.Windows.Forms.ListBox
    Friend WithEvents btnSort As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnSort2 As System.Windows.Forms.Button

End Class
