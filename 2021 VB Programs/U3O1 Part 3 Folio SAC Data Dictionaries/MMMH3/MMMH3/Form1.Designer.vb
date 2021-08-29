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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lsbDisplay = New System.Windows.Forms.ListBox()
        Me.btnDisplayBkdRms = New System.Windows.Forms.Button()
        Me.btnBookRoom = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbtRegisteredGuest = New System.Windows.Forms.RadioButton()
        Me.rbtBookedGuest = New System.Windows.Forms.RadioButton()
        Me.rbtRoomAvailability = New System.Windows.Forms.RadioButton()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnDisplayAvailableRooms = New System.Windows.Forms.Button()
        Me.btnMakeRoomAvailable = New System.Windows.Forms.Button()
        Me.gbxControls = New System.Windows.Forms.GroupBox()
        Me.cbxNamesList = New System.Windows.Forms.ComboBox()
        Me.cbxItemsList = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.gbxControls.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(451, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mr Mac's Magnificent Hotel Booking System"
        '
        'lsbDisplay
        '
        Me.lsbDisplay.FormattingEnabled = True
        Me.lsbDisplay.ItemHeight = 15
        Me.lsbDisplay.Location = New System.Drawing.Point(569, 50)
        Me.lsbDisplay.Name = "lsbDisplay"
        Me.lsbDisplay.Size = New System.Drawing.Size(273, 319)
        Me.lsbDisplay.TabIndex = 1
        '
        'btnDisplayBkdRms
        '
        Me.btnDisplayBkdRms.Location = New System.Drawing.Point(15, 31)
        Me.btnDisplayBkdRms.Name = "btnDisplayBkdRms"
        Me.btnDisplayBkdRms.Size = New System.Drawing.Size(245, 22)
        Me.btnDisplayBkdRms.TabIndex = 2
        Me.btnDisplayBkdRms.Text = "Display Booked Rooms"
        Me.btnDisplayBkdRms.UseVisualStyleBackColor = True
        '
        'btnBookRoom
        '
        Me.btnBookRoom.Location = New System.Drawing.Point(20, 145)
        Me.btnBookRoom.Name = "btnBookRoom"
        Me.btnBookRoom.Size = New System.Drawing.Size(210, 29)
        Me.btnBookRoom.TabIndex = 3
        Me.btnBookRoom.Text = "Book Room"
        Me.btnBookRoom.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbtRegisteredGuest)
        Me.GroupBox1.Controls.Add(Me.rbtBookedGuest)
        Me.GroupBox1.Controls.Add(Me.rbtRoomAvailability)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(263, 117)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Options"
        '
        'rbtRegisteredGuest
        '
        Me.rbtRegisteredGuest.AutoSize = True
        Me.rbtRegisteredGuest.Location = New System.Drawing.Point(7, 75)
        Me.rbtRegisteredGuest.Name = "rbtRegisteredGuest"
        Me.rbtRegisteredGuest.Size = New System.Drawing.Size(182, 19)
        Me.rbtRegisteredGuest.TabIndex = 2
        Me.rbtRegisteredGuest.TabStop = True
        Me.rbtRegisteredGuest.Text = "Is a person a registered guest?"
        Me.rbtRegisteredGuest.UseVisualStyleBackColor = True
        '
        'rbtBookedGuest
        '
        Me.rbtBookedGuest.AutoSize = True
        Me.rbtBookedGuest.Location = New System.Drawing.Point(7, 50)
        Me.rbtBookedGuest.Name = "rbtBookedGuest"
        Me.rbtBookedGuest.Size = New System.Drawing.Size(180, 19)
        Me.rbtBookedGuest.TabIndex = 1
        Me.rbtBookedGuest.TabStop = True
        Me.rbtBookedGuest.Text = "Has a guest made a booking?"
        Me.rbtBookedGuest.UseVisualStyleBackColor = True
        '
        'rbtRoomAvailability
        '
        Me.rbtRoomAvailability.AutoSize = True
        Me.rbtRoomAvailability.Location = New System.Drawing.Point(7, 23)
        Me.rbtRoomAvailability.Name = "rbtRoomAvailability"
        Me.rbtRoomAvailability.Size = New System.Drawing.Size(253, 19)
        Me.rbtRoomAvailability.TabIndex = 0
        Me.rbtRoomAvailability.TabStop = True
        Me.rbtRoomAvailability.Text = "Room status (Available / Currently Booked)"
        Me.rbtRoomAvailability.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(6, 145)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(64, 23)
        Me.btnSearch.TabIndex = 23
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnDisplayAvailableRooms
        '
        Me.btnDisplayAvailableRooms.Location = New System.Drawing.Point(15, 59)
        Me.btnDisplayAvailableRooms.Name = "btnDisplayAvailableRooms"
        Me.btnDisplayAvailableRooms.Size = New System.Drawing.Size(245, 24)
        Me.btnDisplayAvailableRooms.TabIndex = 6
        Me.btnDisplayAvailableRooms.Text = "Display Available Rooms"
        Me.btnDisplayAvailableRooms.UseVisualStyleBackColor = True
        '
        'btnMakeRoomAvailable
        '
        Me.btnMakeRoomAvailable.Location = New System.Drawing.Point(21, 180)
        Me.btnMakeRoomAvailable.Name = "btnMakeRoomAvailable"
        Me.btnMakeRoomAvailable.Size = New System.Drawing.Size(210, 28)
        Me.btnMakeRoomAvailable.TabIndex = 7
        Me.btnMakeRoomAvailable.Text = "Make Room Available"
        Me.btnMakeRoomAvailable.UseVisualStyleBackColor = True
        '
        'gbxControls
        '
        Me.gbxControls.Controls.Add(Me.btnMakeRoomAvailable)
        Me.gbxControls.Controls.Add(Me.cbxNamesList)
        Me.gbxControls.Controls.Add(Me.btnBookRoom)
        Me.gbxControls.Controls.Add(Me.cbxItemsList)
        Me.gbxControls.Controls.Add(Me.Label2)
        Me.gbxControls.Controls.Add(Me.Label3)
        Me.gbxControls.Location = New System.Drawing.Point(12, 50)
        Me.gbxControls.Name = "gbxControls"
        Me.gbxControls.Size = New System.Drawing.Size(247, 225)
        Me.gbxControls.TabIndex = 17
        Me.gbxControls.TabStop = False
        Me.gbxControls.Text = "Booking / Unbooking"
        '
        'cbxNamesList
        '
        Me.cbxNamesList.FormattingEnabled = True
        Me.cbxNamesList.Location = New System.Drawing.Point(21, 47)
        Me.cbxNamesList.Name = "cbxNamesList"
        Me.cbxNamesList.Size = New System.Drawing.Size(209, 23)
        Me.cbxNamesList.TabIndex = 11
        '
        'cbxItemsList
        '
        Me.cbxItemsList.FormattingEnabled = True
        Me.cbxItemsList.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25"})
        Me.cbxItemsList.Location = New System.Drawing.Point(21, 106)
        Me.cbxItemsList.Name = "cbxItemsList"
        Me.cbxItemsList.Size = New System.Drawing.Size(209, 23)
        Me.cbxItemsList.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Enter Guest Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 15)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Enter Room"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(130, 30)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(102, 23)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(22, 30)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(102, 23)
        Me.btnClear.TabIndex = 14
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnSearch)
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(273, 50)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(281, 174)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Searches"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(279, 337)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(267, 15)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "NOTE: Searches for availability and guest booking"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnDisplayBkdRms)
        Me.GroupBox3.Controls.Add(Me.btnDisplayAvailableRooms)
        Me.GroupBox3.Location = New System.Drawing.Point(279, 230)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(275, 97)
        Me.GroupBox3.TabIndex = 19
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Displays"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnExit)
        Me.GroupBox4.Controls.Add(Me.btnClear)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 281)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(249, 71)
        Me.GroupBox4.TabIndex = 20
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Utility"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(311, 352)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(227, 15)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "function only AFTER any booking is made"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(854, 387)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.lsbDisplay)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gbxControls)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Go"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbxControls.ResumeLayout(False)
        Me.gbxControls.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lsbDisplay As ListBox
    Friend WithEvents btnDisplayBkdRms As Button
    Friend WithEvents btnBookRoom As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbtRegisteredGuest As RadioButton
    Friend WithEvents rbtBookedGuest As RadioButton
    Friend WithEvents rbtRoomAvailability As RadioButton
    Friend WithEvents btnDisplayAvailableRooms As Button
    Friend WithEvents btnMakeRoomAvailable As Button
    Friend WithEvents gbxControls As GroupBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents cbxNamesList As ComboBox
    Friend WithEvents cbxItemsList As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
