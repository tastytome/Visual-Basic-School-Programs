<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnRating = New System.Windows.Forms.Button()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.lsbDisplay = New System.Windows.Forms.ListBox()
        Me.cbxRating = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(29, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(238, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Todd's Movie Collection"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Display Movie Details"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(377, 233)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Select Rating"
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(377, 408)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(111, 38)
        Me.btnBack.TabIndex = 9
        Me.btnBack.Text = "Return to Main Form"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnRating
        '
        Me.btnRating.Location = New System.Drawing.Point(377, 175)
        Me.btnRating.Name = "btnRating"
        Me.btnRating.Size = New System.Drawing.Size(111, 42)
        Me.btnRating.TabIndex = 8
        Me.btnRating.Text = "Display Movies by Selected Rating"
        Me.btnRating.UseVisualStyleBackColor = True
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(377, 112)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(111, 48)
        Me.btnDisplay.TabIndex = 7
        Me.btnDisplay.Text = "Display Movies in Catalogue"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'lsbDisplay
        '
        Me.lsbDisplay.FormattingEnabled = True
        Me.lsbDisplay.ItemHeight = 15
        Me.lsbDisplay.Location = New System.Drawing.Point(29, 112)
        Me.lsbDisplay.Name = "lsbDisplay"
        Me.lsbDisplay.Size = New System.Drawing.Size(333, 334)
        Me.lsbDisplay.TabIndex = 10
        '
        'cbxRating
        '
        Me.cbxRating.FormattingEnabled = True
        Me.cbxRating.Items.AddRange(New Object() {"G", "PG", "MA", "R18+"})
        Me.cbxRating.Location = New System.Drawing.Point(377, 252)
        Me.cbxRating.Name = "cbxRating"
        Me.cbxRating.Size = New System.Drawing.Size(111, 23)
        Me.cbxRating.TabIndex = 11
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 473)
        Me.Controls.Add(Me.cbxRating)
        Me.Controls.Add(Me.lsbDisplay)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnRating)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents btnRating As Button
    Friend WithEvents btnDisplay As Button
    Friend WithEvents lsbDisplay As ListBox
    Friend WithEvents cbxRating As ComboBox
End Class
