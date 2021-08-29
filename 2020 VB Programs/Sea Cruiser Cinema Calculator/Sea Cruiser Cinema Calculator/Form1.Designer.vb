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
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.rbnMember = New System.Windows.Forms.RadioButton()
        Me.cbxMovie = New System.Windows.Forms.ComboBox()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.txtMovie = New System.Windows.Forms.TextBox()
        Me.txtChild = New System.Windows.Forms.TextBox()
        Me.txtAdult = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtConcession = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Tahoma", 16.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(569, 464)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(840, 97)
        Me.btnCalculate.TabIndex = 31
        Me.btnCalculate.Text = "Calculate Ticketing Cost"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'rbnMember
        '
        Me.rbnMember.AutoSize = True
        Me.rbnMember.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnMember.Location = New System.Drawing.Point(896, 232)
        Me.rbnMember.Name = "rbnMember"
        Me.rbnMember.Size = New System.Drawing.Size(341, 46)
        Me.rbnMember.TabIndex = 28
        Me.rbnMember.TabStop = True
        Me.rbnMember.Text = "Member Discount"
        Me.rbnMember.UseVisualStyleBackColor = True
        '
        'cbxMovie
        '
        Me.cbxMovie.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxMovie.FormattingEnabled = True
        Me.cbxMovie.Items.AddRange(New Object() {"General: Batman versus Godzilla", "Gold Class: Batman versus Godzilla", "General: Spiderman and The Fly", "Gold Class: Spiderman and The Fly", "General: Wonder Woman Saves the World", "Gold Class: Wonder Woman Saves the World"})
        Me.cbxMovie.Location = New System.Drawing.Point(855, 381)
        Me.cbxMovie.Name = "cbxMovie"
        Me.cbxMovie.Size = New System.Drawing.Size(554, 39)
        Me.cbxMovie.TabIndex = 27
        '
        'txtCost
        '
        Me.txtCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCost.Location = New System.Drawing.Point(569, 733)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(840, 56)
        Me.txtCost.TabIndex = 26
        '
        'txtMovie
        '
        Me.txtMovie.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMovie.Location = New System.Drawing.Point(569, 628)
        Me.txtMovie.Name = "txtMovie"
        Me.txtMovie.Size = New System.Drawing.Size(840, 56)
        Me.txtMovie.TabIndex = 25
        '
        'txtChild
        '
        Me.txtChild.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChild.Location = New System.Drawing.Point(569, 284)
        Me.txtChild.Name = "txtChild"
        Me.txtChild.Size = New System.Drawing.Size(198, 56)
        Me.txtChild.TabIndex = 24
        '
        'txtAdult
        '
        Me.txtAdult.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdult.Location = New System.Drawing.Point(569, 189)
        Me.txtAdult.Name = "txtAdult"
        Me.txtAdult.Size = New System.Drawing.Size(198, 56)
        Me.txtAdult.TabIndex = 23
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(858, 189)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(466, 25)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Check the box if you are a Cinema Member"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(102, 637)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(431, 42)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "You have chosen to see:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(146, 733)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(387, 42)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Your ticket(s) will cost:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(856, 313)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(244, 42)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Select Movie"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(137, 299)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(383, 37)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Number of Child Tickets"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(137, 204)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(384, 37)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Number of Adult Tickets"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(214, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1075, 90)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Sea-Cruiser Cinema Tickets"
        '
        'txtConcession
        '
        Me.txtConcession.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConcession.Location = New System.Drawing.Point(569, 375)
        Me.txtConcession.Name = "txtConcession"
        Me.txtConcession.Size = New System.Drawing.Size(198, 56)
        Me.txtConcession.TabIndex = 33
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(38, 396)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(482, 37)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Number of Concession Tickets"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(1449, 829)
        Me.Controls.Add(Me.txtConcession)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.rbnMember)
        Me.Controls.Add(Me.cbxMovie)
        Me.Controls.Add(Me.txtCost)
        Me.Controls.Add(Me.txtMovie)
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
        Me.Text = "Ticket Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalculate As Button
    Friend WithEvents rbnMember As RadioButton
    Friend WithEvents cbxMovie As ComboBox
    Friend WithEvents txtCost As TextBox
    Friend WithEvents txtMovie As TextBox
    Friend WithEvents txtChild As TextBox
    Friend WithEvents txtAdult As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtConcession As TextBox
    Friend WithEvents Label8 As Label
End Class
