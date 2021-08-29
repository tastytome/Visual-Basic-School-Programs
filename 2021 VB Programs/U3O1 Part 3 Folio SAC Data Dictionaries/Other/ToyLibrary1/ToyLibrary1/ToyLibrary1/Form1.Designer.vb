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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lsbDisplay = New System.Windows.Forms.ListBox()
        Me.cbxToysList = New System.Windows.Forms.ComboBox()
        Me.cbxMembersList = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnListToyLibraryMembers = New System.Windows.Forms.Button()
        Me.btnSearchMemberName = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(130, 215)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(210, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Borrow a Toy"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(432, 365)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(220, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Display Borrowed Toys"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lsbDisplay
        '
        Me.lsbDisplay.FormattingEnabled = True
        Me.lsbDisplay.ItemHeight = 15
        Me.lsbDisplay.Location = New System.Drawing.Point(432, 85)
        Me.lsbDisplay.Name = "lsbDisplay"
        Me.lsbDisplay.Size = New System.Drawing.Size(220, 274)
        Me.lsbDisplay.TabIndex = 2
        '
        'cbxToysList
        '
        Me.cbxToysList.FormattingEnabled = True
        Me.cbxToysList.Items.AddRange(New Object() {"bicycle", "train", "doll", "ball", "teddy bear", "kite", "rubber ducky", "airplane"})
        Me.cbxToysList.Location = New System.Drawing.Point(130, 94)
        Me.cbxToysList.Name = "cbxToysList"
        Me.cbxToysList.Size = New System.Drawing.Size(210, 23)
        Me.cbxToysList.TabIndex = 3
        '
        'cbxMembersList
        '
        Me.cbxMembersList.FormattingEnabled = True
        Me.cbxMembersList.Items.AddRange(New Object() {"Anna", "Barry", "Craig", "David", "Ella", "Frank", "Girthy", "Hilda", "Isla", "Jenny", "Karen"})
        Me.cbxMembersList.Location = New System.Drawing.Point(130, 172)
        Me.cbxMembersList.Name = "cbxMembersList"
        Me.cbxMembersList.Size = New System.Drawing.Size(210, 23)
        Me.cbxMembersList.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(130, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 21)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Select a toy from the list"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(130, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 21)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Select the Member"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(130, 260)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(210, 23)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Return Toy to Library"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(130, 306)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(210, 23)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "Search by toy"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'btnListToyLibraryMembers
        '
        Me.btnListToyLibraryMembers.Location = New System.Drawing.Point(130, 351)
        Me.btnListToyLibraryMembers.Name = "btnListToyLibraryMembers"
        Me.btnListToyLibraryMembers.Size = New System.Drawing.Size(210, 23)
        Me.btnListToyLibraryMembers.TabIndex = 9
        Me.btnListToyLibraryMembers.Text = "List Toy Library members"
        Me.btnListToyLibraryMembers.UseVisualStyleBackColor = True
        '
        'btnSearchMemberName
        '
        Me.btnSearchMemberName.Location = New System.Drawing.Point(130, 381)
        Me.btnSearchMemberName.Name = "btnSearchMemberName"
        Me.btnSearchMemberName.Size = New System.Drawing.Size(210, 23)
        Me.btnSearchMemberName.TabIndex = 10
        Me.btnSearchMemberName.Text = "Search for a Member's Name"
        Me.btnSearchMemberName.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(863, 450)
        Me.Controls.Add(Me.btnSearchMemberName)
        Me.Controls.Add(Me.btnListToyLibraryMembers)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbxMembersList)
        Me.Controls.Add(Me.cbxToysList)
        Me.Controls.Add(Me.lsbDisplay)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents lsbDisplay As ListBox
    Friend WithEvents cbxToysList As ComboBox
    Friend WithEvents cbxMembersList As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents btnListToyLibraryMembers As Button
    Friend WithEvents btnSearchMemberName As Button
End Class
