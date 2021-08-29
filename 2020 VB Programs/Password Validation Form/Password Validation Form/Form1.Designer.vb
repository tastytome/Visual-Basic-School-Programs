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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnHidePW = New System.Windows.Forms.Button()
        Me.btnHideConfirmPW = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.txtConfirmPW = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnShowConfirmPW = New System.Windows.Forms.Button()
        Me.btnShowPW = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnHidePW
        '
        Me.btnHidePW.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnHidePW.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnHidePW.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btnHidePW.Image = CType(resources.GetObject("btnHidePW.Image"), System.Drawing.Image)
        Me.btnHidePW.Location = New System.Drawing.Point(961, 581)
        Me.btnHidePW.Name = "btnHidePW"
        Me.btnHidePW.Size = New System.Drawing.Size(53, 49)
        Me.btnHidePW.TabIndex = 72
        Me.btnHidePW.UseVisualStyleBackColor = False
        '
        'btnHideConfirmPW
        '
        Me.btnHideConfirmPW.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnHideConfirmPW.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnHideConfirmPW.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btnHideConfirmPW.Image = CType(resources.GetObject("btnHideConfirmPW.Image"), System.Drawing.Image)
        Me.btnHideConfirmPW.Location = New System.Drawing.Point(961, 672)
        Me.btnHideConfirmPW.Name = "btnHideConfirmPW"
        Me.btnHideConfirmPW.Size = New System.Drawing.Size(53, 49)
        Me.btnHideConfirmPW.TabIndex = 73
        Me.btnHideConfirmPW.UseVisualStyleBackColor = False
        '
        'btnSubmit
        '
        Me.btnSubmit.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(1219, 672)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(139, 49)
        Me.btnSubmit.TabIndex = 71
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'txtConfirmPW
        '
        Me.txtConfirmPW.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmPW.Location = New System.Drawing.Point(383, 672)
        Me.txtConfirmPW.Name = "txtConfirmPW"
        Me.txtConfirmPW.Size = New System.Drawing.Size(567, 49)
        Me.txtConfirmPW.TabIndex = 70
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(383, 581)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(566, 49)
        Me.txtPassword.TabIndex = 69
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label9.Location = New System.Drawing.Point(378, 530)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(332, 25)
        Me.Label9.TabIndex = 68
        Me.Label9.Text = "and be at least 8 characters long."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label8.Location = New System.Drawing.Point(378, 505)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(467, 25)
        Me.Label8.TabIndex = 67
        Me.Label8.Text = "Password needs to contain letters and numbers"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label7.Font = New System.Drawing.Font("Corbel", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(53, 671)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(312, 45)
        Me.Label7.TabIndex = 66
        Me.Label7.Text = "Confirm Password"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label6.Font = New System.Drawing.Font("Corbel", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(53, 575)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(318, 45)
        Me.Label6.TabIndex = 65
        Me.Label6.Text = "Member Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(956, 300)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(184, 25)
        Me.Label5.TabIndex = 64
        Me.Label5.Text = "Eg. 04-1111-1111"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(956, 274)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(403, 25)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = "Enter Phone Number with Dash Hyphens"
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(382, 372)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(977, 49)
        Me.txtEmail.TabIndex = 62
        '
        'txtPhone
        '
        Me.txtPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.Location = New System.Drawing.Point(382, 276)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(568, 49)
        Me.txtPhone.TabIndex = 61
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(382, 172)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(976, 49)
        Me.txtName.TabIndex = 60
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.BackColor = System.Drawing.Color.LightSkyBlue
        Me.lblHeading.Font = New System.Drawing.Font("Corbel", 22.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblHeading.Location = New System.Drawing.Point(371, 50)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(695, 72)
        Me.lblHeading.TabIndex = 59
        Me.lblHeading.Text = "Password Validation Form"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label3.Font = New System.Drawing.Font("Corbel", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(53, 367)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(246, 45)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "Email Address"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label2.Font = New System.Drawing.Font("Corbel", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(53, 271)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(240, 45)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Mobile Phone"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label1.Font = New System.Drawing.Font("Corbel", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(53, 172)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(260, 45)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Member Name"
        '
        'btnShowConfirmPW
        '
        Me.btnShowConfirmPW.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnShowConfirmPW.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnShowConfirmPW.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btnShowConfirmPW.Image = CType(resources.GetObject("btnShowConfirmPW.Image"), System.Drawing.Image)
        Me.btnShowConfirmPW.Location = New System.Drawing.Point(961, 672)
        Me.btnShowConfirmPW.Name = "btnShowConfirmPW"
        Me.btnShowConfirmPW.Size = New System.Drawing.Size(53, 49)
        Me.btnShowConfirmPW.TabIndex = 75
        Me.btnShowConfirmPW.UseVisualStyleBackColor = False
        '
        'btnShowPW
        '
        Me.btnShowPW.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnShowPW.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnShowPW.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btnShowPW.Image = CType(resources.GetObject("btnShowPW.Image"), System.Drawing.Image)
        Me.btnShowPW.Location = New System.Drawing.Point(961, 581)
        Me.btnShowPW.Name = "btnShowPW"
        Me.btnShowPW.Size = New System.Drawing.Size(53, 49)
        Me.btnShowPW.TabIndex = 74
        Me.btnShowPW.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(1412, 787)
        Me.Controls.Add(Me.btnHidePW)
        Me.Controls.Add(Me.btnHideConfirmPW)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtConfirmPW)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnShowConfirmPW)
        Me.Controls.Add(Me.btnShowPW)
        Me.Name = "Form1"
        Me.Text = "Password Validation Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnHidePW As Button
    Friend WithEvents btnHideConfirmPW As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents txtConfirmPW As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblHeading As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnShowConfirmPW As Button
    Friend WithEvents btnShowPW As Button
End Class
