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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRead = New System.Windows.Forms.Button()
        Me.lstData = New System.Windows.Forms.ListBox()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnReadBin = New System.Windows.Forms.Button()
        Me.btnHouse = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnReset = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(356, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Textfile Reader Program"
        '
        'btnRead
        '
        Me.btnRead.Location = New System.Drawing.Point(18, 97)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(109, 23)
        Me.btnRead.TabIndex = 1
        Me.btnRead.Text = "Read Textfile"
        Me.btnRead.UseVisualStyleBackColor = True
        '
        'lstData
        '
        Me.lstData.FormattingEnabled = True
        Me.lstData.Location = New System.Drawing.Point(133, 68)
        Me.lstData.Name = "lstData"
        Me.lstData.Size = New System.Drawing.Size(235, 316)
        Me.lstData.TabIndex = 2
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(18, 68)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(109, 23)
        Me.btnCreate.TabIndex = 3
        Me.btnCreate.Text = "Create Textfile"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'btnReadBin
        '
        Me.btnReadBin.Location = New System.Drawing.Point(18, 126)
        Me.btnReadBin.Name = "btnReadBin"
        Me.btnReadBin.Size = New System.Drawing.Size(109, 45)
        Me.btnReadBin.TabIndex = 4
        Me.btnReadBin.Text = "Read Textfile from Project BIN "
        Me.btnReadBin.UseVisualStyleBackColor = True
        '
        'btnHouse
        '
        Me.btnHouse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHouse.Location = New System.Drawing.Point(18, 177)
        Me.btnHouse.Name = "btnHouse"
        Me.btnHouse.Size = New System.Drawing.Size(109, 23)
        Me.btnHouse.TabIndex = 5
        Me.btnHouse.Text = "House Points"
        Me.btnHouse.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(18, 206)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(109, 45)
        Me.btnSearch.TabIndex = 6
        Me.btnSearch.Text = "Find a Name (Linear Search)"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(18, 286)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(109, 99)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(18, 257)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(109, 23)
        Me.btnReset.TabIndex = 8
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(381, 400)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnHouse)
        Me.Controls.Add(Me.btnReadBin)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.lstData)
        Me.Controls.Add(Me.btnRead)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Textfile Program"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnRead As Button
    Friend WithEvents lstData As ListBox
    Friend WithEvents btnCreate As Button
    Friend WithEvents btnReadBin As Button
    Friend WithEvents btnHouse As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnReset As Button
End Class
