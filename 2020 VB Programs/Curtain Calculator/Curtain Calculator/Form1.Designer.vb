<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblWinWidth = New System.Windows.Forms.Label()
        Me.lblWinHeight = New System.Windows.Forms.Label()
        Me.lblFloorDropHeight = New System.Windows.Forms.Label()
        Me.lblCurtainWidth = New System.Windows.Forms.Label()
        Me.lblCurtainLength = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtWinWidth = New System.Windows.Forms.TextBox()
        Me.txtWinHeight = New System.Windows.Forms.TextBox()
        Me.txtFloorDropHeight = New System.Windows.Forms.TextBox()
        Me.txtCurtainWidth = New System.Windows.Forms.TextBox()
        Me.txtCurtainLength = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(45, 55)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(687, 73)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Curtain Size Calculator"
        '
        'lblWinWidth
        '
        Me.lblWinWidth.AutoSize = True
        Me.lblWinWidth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblWinWidth.Location = New System.Drawing.Point(51, 187)
        Me.lblWinWidth.Name = "lblWinWidth"
        Me.lblWinWidth.Size = New System.Drawing.Size(224, 37)
        Me.lblWinWidth.TabIndex = 1
        Me.lblWinWidth.Text = "Window Width"
        '
        'lblWinHeight
        '
        Me.lblWinHeight.AutoSize = True
        Me.lblWinHeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblWinHeight.Location = New System.Drawing.Point(51, 277)
        Me.lblWinHeight.Name = "lblWinHeight"
        Me.lblWinHeight.Size = New System.Drawing.Size(233, 37)
        Me.lblWinHeight.TabIndex = 2
        Me.lblWinHeight.Text = "Window Height"
        '
        'lblFloorDropHeight
        '
        Me.lblFloorDropHeight.AutoSize = True
        Me.lblFloorDropHeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblFloorDropHeight.Location = New System.Drawing.Point(51, 375)
        Me.lblFloorDropHeight.Name = "lblFloorDropHeight"
        Me.lblFloorDropHeight.Size = New System.Drawing.Size(271, 37)
        Me.lblFloorDropHeight.TabIndex = 3
        Me.lblFloorDropHeight.Text = "Floor Drop Height"
        '
        'lblCurtainWidth
        '
        Me.lblCurtainWidth.AutoSize = True
        Me.lblCurtainWidth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblCurtainWidth.Location = New System.Drawing.Point(602, 187)
        Me.lblCurtainWidth.Name = "lblCurtainWidth"
        Me.lblCurtainWidth.Size = New System.Drawing.Size(350, 37)
        Me.lblCurtainWidth.TabIndex = 4
        Me.lblCurtainWidth.Text = "Curtain Width Required"
        '
        'lblCurtainLength
        '
        Me.lblCurtainLength.AutoSize = True
        Me.lblCurtainLength.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblCurtainLength.Location = New System.Drawing.Point(602, 277)
        Me.lblCurtainLength.Name = "lblCurtainLength"
        Me.lblCurtainLength.Size = New System.Drawing.Size(365, 37)
        Me.lblCurtainLength.TabIndex = 5
        Me.lblCurtainLength.Text = "Curtain Length Required"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(994, 361)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(235, 51)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate Curtain"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'txtWinWidth
        '
        Me.txtWinWidth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWinWidth.Location = New System.Drawing.Point(345, 184)
        Me.txtWinWidth.Name = "txtWinWidth"
        Me.txtWinWidth.Size = New System.Drawing.Size(220, 44)
        Me.txtWinWidth.TabIndex = 7
        '
        'txtWinHeight
        '
        Me.txtWinHeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWinHeight.Location = New System.Drawing.Point(345, 270)
        Me.txtWinHeight.Name = "txtWinHeight"
        Me.txtWinHeight.Size = New System.Drawing.Size(220, 44)
        Me.txtWinHeight.TabIndex = 8
        '
        'txtFloorDropHeight
        '
        Me.txtFloorDropHeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFloorDropHeight.Location = New System.Drawing.Point(345, 368)
        Me.txtFloorDropHeight.Name = "txtFloorDropHeight"
        Me.txtFloorDropHeight.Size = New System.Drawing.Size(220, 44)
        Me.txtFloorDropHeight.TabIndex = 9
        '
        'txtCurtainWidth
        '
        Me.txtCurtainWidth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurtainWidth.Location = New System.Drawing.Point(994, 180)
        Me.txtCurtainWidth.Name = "txtCurtainWidth"
        Me.txtCurtainWidth.Size = New System.Drawing.Size(220, 44)
        Me.txtCurtainWidth.TabIndex = 11
        '
        'txtCurtainLength
        '
        Me.txtCurtainLength.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurtainLength.Location = New System.Drawing.Point(994, 270)
        Me.txtCurtainLength.Name = "txtCurtainLength"
        Me.txtCurtainLength.Size = New System.Drawing.Size(220, 44)
        Me.txtCurtainLength.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1367, 593)
        Me.Controls.Add(Me.txtCurtainWidth)
        Me.Controls.Add(Me.txtCurtainLength)
        Me.Controls.Add(Me.txtFloorDropHeight)
        Me.Controls.Add(Me.txtWinHeight)
        Me.Controls.Add(Me.txtWinWidth)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblCurtainLength)
        Me.Controls.Add(Me.lblCurtainWidth)
        Me.Controls.Add(Me.lblFloorDropHeight)
        Me.Controls.Add(Me.lblWinHeight)
        Me.Controls.Add(Me.lblWinWidth)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "Form1"
        Me.Text = "Floor Drop Height"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblWinWidth As Label
    Friend WithEvents lblWinHeight As Label
    Friend WithEvents lblFloorDropHeight As Label
    Friend WithEvents lblCurtainWidth As Label
    Friend WithEvents lblCurtainLength As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents txtWinWidth As TextBox
    Friend WithEvents txtWinHeight As TextBox
    Friend WithEvents txtFloorDropHeight As TextBox
    Friend WithEvents txtCurtainWidth As TextBox
    Friend WithEvents txtCurtainLength As TextBox
End Class
