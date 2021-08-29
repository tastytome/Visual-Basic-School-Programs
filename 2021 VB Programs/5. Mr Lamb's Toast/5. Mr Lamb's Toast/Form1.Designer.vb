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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.gbxToastType = New System.Windows.Forms.GroupBox()
        Me.rbtRaisinToast = New System.Windows.Forms.RadioButton()
        Me.rbtThickSlice = New System.Windows.Forms.RadioButton()
        Me.rbtThinSlice = New System.Windows.Forms.RadioButton()
        Me.txtNumSlices = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNumBreakfastsPerWk = New System.Windows.Forms.TextBox()
        Me.txtNumWks = New System.Windows.Forms.TextBox()
        Me.txtNumYrs = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbxDisplayUnits = New System.Windows.Forms.ComboBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.lsbDisplay = New System.Windows.Forms.ListBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.gbxToastType.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.Location = New System.Drawing.Point(156, 32)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(370, 31)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Mr Lamb's Toast Calculator"
        '
        'gbxToastType
        '
        Me.gbxToastType.Controls.Add(Me.rbtRaisinToast)
        Me.gbxToastType.Controls.Add(Me.rbtThickSlice)
        Me.gbxToastType.Controls.Add(Me.rbtThinSlice)
        Me.gbxToastType.Location = New System.Drawing.Point(41, 95)
        Me.gbxToastType.Name = "gbxToastType"
        Me.gbxToastType.Size = New System.Drawing.Size(154, 134)
        Me.gbxToastType.TabIndex = 1
        Me.gbxToastType.TabStop = False
        Me.gbxToastType.Text = "Toast Type"
        '
        'rbtRaisinToast
        '
        Me.rbtRaisinToast.AutoSize = True
        Me.rbtRaisinToast.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.rbtRaisinToast.Location = New System.Drawing.Point(26, 81)
        Me.rbtRaisinToast.Name = "rbtRaisinToast"
        Me.rbtRaisinToast.Size = New System.Drawing.Size(105, 21)
        Me.rbtRaisinToast.TabIndex = 2
        Me.rbtRaisinToast.TabStop = True
        Me.rbtRaisinToast.Text = "Raisin Toast"
        Me.rbtRaisinToast.UseVisualStyleBackColor = True
        '
        'rbtThickSlice
        '
        Me.rbtThickSlice.AutoSize = True
        Me.rbtThickSlice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.rbtThickSlice.Location = New System.Drawing.Point(26, 56)
        Me.rbtThickSlice.Name = "rbtThickSlice"
        Me.rbtThickSlice.Size = New System.Drawing.Size(94, 21)
        Me.rbtThickSlice.TabIndex = 1
        Me.rbtThickSlice.TabStop = True
        Me.rbtThickSlice.Text = "Thick Slice"
        Me.rbtThickSlice.UseVisualStyleBackColor = True
        '
        'rbtThinSlice
        '
        Me.rbtThinSlice.AutoSize = True
        Me.rbtThinSlice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.rbtThinSlice.Location = New System.Drawing.Point(26, 31)
        Me.rbtThinSlice.Name = "rbtThinSlice"
        Me.rbtThinSlice.Size = New System.Drawing.Size(88, 21)
        Me.rbtThinSlice.TabIndex = 0
        Me.rbtThinSlice.TabStop = True
        Me.rbtThinSlice.Text = "Thin Slice"
        Me.rbtThinSlice.UseVisualStyleBackColor = True
        '
        'txtNumSlices
        '
        Me.txtNumSlices.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtNumSlices.Location = New System.Drawing.Point(433, 105)
        Me.txtNumSlices.Name = "txtNumSlices"
        Me.txtNumSlices.Size = New System.Drawing.Size(57, 23)
        Me.txtNumSlices.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(212, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Number of Slices per Breakfast"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(212, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(210, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Number of Breakfasts per Week"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(212, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(180, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Number of Weeks per Year"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(212, 208)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Number of Years"
        '
        'txtNumBreakfastsPerWk
        '
        Me.txtNumBreakfastsPerWk.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtNumBreakfastsPerWk.Location = New System.Drawing.Point(433, 140)
        Me.txtNumBreakfastsPerWk.Name = "txtNumBreakfastsPerWk"
        Me.txtNumBreakfastsPerWk.Size = New System.Drawing.Size(57, 23)
        Me.txtNumBreakfastsPerWk.TabIndex = 7
        '
        'txtNumWks
        '
        Me.txtNumWks.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtNumWks.Location = New System.Drawing.Point(433, 172)
        Me.txtNumWks.Name = "txtNumWks"
        Me.txtNumWks.Size = New System.Drawing.Size(57, 23)
        Me.txtNumWks.TabIndex = 8
        '
        'txtNumYrs
        '
        Me.txtNumYrs.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtNumYrs.Location = New System.Drawing.Point(433, 206)
        Me.txtNumYrs.Name = "txtNumYrs"
        Me.txtNumYrs.Size = New System.Drawing.Size(57, 23)
        Me.txtNumYrs.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(514, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Display Units"
        '
        'cbxDisplayUnits
        '
        Me.cbxDisplayUnits.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cbxDisplayUnits.FormattingEnabled = True
        Me.cbxDisplayUnits.Items.AddRange(New Object() {"By Number of Slices", "By Number of Loaves", "By Loaf Size In Metres"})
        Me.cbxDisplayUnits.Location = New System.Drawing.Point(514, 123)
        Me.cbxDisplayUnits.Name = "cbxDisplayUnits"
        Me.cbxDisplayUnits.Size = New System.Drawing.Size(190, 24)
        Me.cbxDisplayUnits.TabIndex = 11
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnCalculate.Location = New System.Drawing.Point(572, 192)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(132, 37)
        Me.btnCalculate.TabIndex = 12
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblResult.Location = New System.Drawing.Point(41, 265)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(164, 20)
        Me.lblResult.TabIndex = 13
        Me.lblResult.Text = "Calculation Results"
        '
        'lsbDisplay
        '
        Me.lsbDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lsbDisplay.FormattingEnabled = True
        Me.lsbDisplay.ItemHeight = 16
        Me.lsbDisplay.Location = New System.Drawing.Point(212, 265)
        Me.lsbDisplay.Name = "lsbDisplay"
        Me.lsbDisplay.Size = New System.Drawing.Size(492, 52)
        Me.lsbDisplay.TabIndex = 14
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnClear.Location = New System.Drawing.Point(41, 339)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(80, 37)
        Me.btnClear.TabIndex = 15
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnExit.Location = New System.Drawing.Point(624, 339)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(80, 37)
        Me.btnExit.TabIndex = 16
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(742, 412)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lsbDisplay)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.cbxDisplayUnits)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtNumYrs)
        Me.Controls.Add(Me.txtNumWks)
        Me.Controls.Add(Me.txtNumBreakfastsPerWk)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNumSlices)
        Me.Controls.Add(Me.gbxToastType)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "Form1"
        Me.Text = "Number of Weeks per Year"
        Me.gbxToastType.ResumeLayout(False)
        Me.gbxToastType.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents gbxToastType As GroupBox
    Friend WithEvents rbtRaisinToast As RadioButton
    Friend WithEvents rbtThickSlice As RadioButton
    Friend WithEvents rbtThinSlice As RadioButton
    Friend WithEvents txtNumSlices As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNumBreakfastsPerWk As TextBox
    Friend WithEvents txtNumWks As TextBox
    Friend WithEvents txtNumYrs As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cbxDisplayUnits As ComboBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblResult As Label
    Friend WithEvents lsbDisplay As ListBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
