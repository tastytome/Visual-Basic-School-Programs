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
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.lbxGuesses = New System.Windows.Forms.ListBox()
        Me.pbxWin = New System.Windows.Forms.PictureBox()
        Me.pbxLose = New System.Windows.Forms.PictureBox()
        CType(Me.pbxWin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxLose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(127, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(681, 55)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Can You Guess the Number?"
        '
        'btnPlay
        '
        Me.btnPlay.Location = New System.Drawing.Point(408, 120)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(126, 50)
        Me.btnPlay.TabIndex = 1
        Me.btnPlay.Text = "Play Now"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'lbxGuesses
        '
        Me.lbxGuesses.BackColor = System.Drawing.SystemColors.MenuText
        Me.lbxGuesses.ForeColor = System.Drawing.Color.Lime
        Me.lbxGuesses.FormattingEnabled = True
        Me.lbxGuesses.ItemHeight = 25
        Me.lbxGuesses.Location = New System.Drawing.Point(137, 192)
        Me.lbxGuesses.Name = "lbxGuesses"
        Me.lbxGuesses.Size = New System.Drawing.Size(333, 304)
        Me.lbxGuesses.TabIndex = 2
        '
        'pbxWin
        '
        Me.pbxWin.Image = CType(resources.GetObject("pbxWin.Image"), System.Drawing.Image)
        Me.pbxWin.Location = New System.Drawing.Point(498, 192)
        Me.pbxWin.Name = "pbxWin"
        Me.pbxWin.Size = New System.Drawing.Size(401, 304)
        Me.pbxWin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxWin.TabIndex = 3
        Me.pbxWin.TabStop = False
        '
        'pbxLose
        '
        Me.pbxLose.Image = CType(resources.GetObject("pbxLose.Image"), System.Drawing.Image)
        Me.pbxLose.Location = New System.Drawing.Point(498, 192)
        Me.pbxLose.Name = "pbxLose"
        Me.pbxLose.Size = New System.Drawing.Size(401, 304)
        Me.pbxLose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxLose.TabIndex = 4
        Me.pbxLose.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(959, 578)
        Me.Controls.Add(Me.pbxLose)
        Me.Controls.Add(Me.pbxWin)
        Me.Controls.Add(Me.lbxGuesses)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pbxWin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxLose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnPlay As Button
    Friend WithEvents lbxGuesses As ListBox
    Friend WithEvents pbxWin As PictureBox
    Friend WithEvents pbxLose As PictureBox
End Class
