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
        Me.txtInputName = New System.Windows.Forms.TextBox()
        Me.txtOutputMsg = New System.Windows.Forms.TextBox()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(59, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(469, 55)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Hello World Program"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(62, 175)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(266, 37)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter Your Name"
        '
        'txtInputName
        '
        Me.txtInputName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInputName.Location = New System.Drawing.Point(357, 172)
        Me.txtInputName.Name = "txtInputName"
        Me.txtInputName.Size = New System.Drawing.Size(589, 44)
        Me.txtInputName.TabIndex = 2
        '
        'txtOutputMsg
        '
        Me.txtOutputMsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOutputMsg.Location = New System.Drawing.Point(69, 277)
        Me.txtOutputMsg.Name = "txtOutputMsg"
        Me.txtOutputMsg.Size = New System.Drawing.Size(877, 44)
        Me.txtOutputMsg.TabIndex = 3
        Me.txtOutputMsg.Visible = False
        '
        'btnStart
        '
        Me.btnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnStart.Location = New System.Drawing.Point(69, 372)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(172, 60)
        Me.btnStart.TabIndex = 4
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Hello_World_Test_Program.My.Resources.Resources.Tran_Empire
        Me.PictureBox1.Location = New System.Drawing.Point(1012, 172)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(441, 429)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1491, 792)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.txtOutputMsg)
        Me.Controls.Add(Me.txtInputName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Hello Program"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtInputName As TextBox
    Friend WithEvents txtOutputMsg As TextBox
    Friend WithEvents btnStart As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
