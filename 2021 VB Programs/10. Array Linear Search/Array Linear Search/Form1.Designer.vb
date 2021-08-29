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
        Me.btnListNames = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnMsgBox = New System.Windows.Forms.Button()
        Me.lblLoadFinished = New System.Windows.Forms.Label()
        Me.lstNames = New System.Windows.Forms.ListBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnFindName = New System.Windows.Forms.Button()
        Me.txtSearchRequest = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblSearchResultMsg = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(18, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(266, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Array Linear Search"
        '
        'btnListNames
        '
        Me.btnListNames.Location = New System.Drawing.Point(27, 84)
        Me.btnListNames.Name = "btnListNames"
        Me.btnListNames.Size = New System.Drawing.Size(124, 37)
        Me.btnListNames.TabIndex = 1
        Me.btnListNames.Text = "List Names"
        Me.btnListNames.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnListNames)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(356, 136)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnMsgBox)
        Me.GroupBox2.Controls.Add(Me.lblLoadFinished)
        Me.GroupBox2.Controls.Add(Me.lstNames)
        Me.GroupBox2.Location = New System.Drawing.Point(396, 35)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(202, 299)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ArrayItem Names"
        '
        'btnMsgBox
        '
        Me.btnMsgBox.Location = New System.Drawing.Point(16, 247)
        Me.btnMsgBox.Name = "btnMsgBox"
        Me.btnMsgBox.Size = New System.Drawing.Size(172, 37)
        Me.btnMsgBox.TabIndex = 2
        Me.btnMsgBox.Text = "MessageBox"
        Me.btnMsgBox.UseVisualStyleBackColor = True
        '
        'lblLoadFinished
        '
        Me.lblLoadFinished.BackColor = System.Drawing.SystemColors.Control
        Me.lblLoadFinished.Location = New System.Drawing.Point(16, 210)
        Me.lblLoadFinished.Name = "lblLoadFinished"
        Me.lblLoadFinished.Size = New System.Drawing.Size(172, 23)
        Me.lblLoadFinished.TabIndex = 1
        '
        'lstNames
        '
        Me.lstNames.FormattingEnabled = True
        Me.lstNames.ItemHeight = 15
        Me.lstNames.Location = New System.Drawing.Point(16, 23)
        Me.lstNames.Name = "lstNames"
        Me.lstNames.Size = New System.Drawing.Size(172, 169)
        Me.lstNames.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnFindName)
        Me.GroupBox3.Controls.Add(Me.txtSearchRequest)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.lblSearchResultMsg)
        Me.GroupBox3.Location = New System.Drawing.Point(23, 180)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(356, 243)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Search For ArrayItems"
        '
        'btnFindName
        '
        Me.btnFindName.Location = New System.Drawing.Point(168, 102)
        Me.btnFindName.Name = "btnFindName"
        Me.btnFindName.Size = New System.Drawing.Size(172, 37)
        Me.btnFindName.TabIndex = 3
        Me.btnFindName.Text = "Find Item"
        Me.btnFindName.UseVisualStyleBackColor = True
        '
        'txtSearchRequest
        '
        Me.txtSearchRequest.Location = New System.Drawing.Point(18, 65)
        Me.txtSearchRequest.Name = "txtSearchRequest"
        Me.txtSearchRequest.Size = New System.Drawing.Size(322, 23)
        Me.txtSearchRequest.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Enter Names"
        '
        'lblSearchResultMsg
        '
        Me.lblSearchResultMsg.BackColor = System.Drawing.SystemColors.Control
        Me.lblSearchResultMsg.Location = New System.Drawing.Point(18, 152)
        Me.lblSearchResultMsg.Name = "lblSearchResultMsg"
        Me.lblSearchResultMsg.Size = New System.Drawing.Size(322, 74)
        Me.lblSearchResultMsg.TabIndex = 3
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnExit)
        Me.GroupBox4.Controls.Add(Me.btnClear)
        Me.GroupBox4.Controls.Add(Me.btnReset)
        Me.GroupBox4.Location = New System.Drawing.Point(396, 349)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(202, 159)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Reset / Clear"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(38, 104)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(120, 35)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(38, 63)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(120, 35)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(38, 22)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(120, 35)
        Me.btnReset.TabIndex = 3
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(615, 520)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnListNames As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lstNames As ListBox
    Friend WithEvents lblLoadFinished As Label
    Friend WithEvents btnMsgBox As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblSearchResultMsg As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents txtSearchRequest As TextBox
    Friend WithEvents btnFindName As Button
End Class
