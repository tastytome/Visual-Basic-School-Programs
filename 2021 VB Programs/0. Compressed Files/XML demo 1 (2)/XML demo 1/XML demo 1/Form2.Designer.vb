<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.btnDisplayCD = New System.Windows.Forms.Button()
        Me.lsbPriceCD = New System.Windows.Forms.ListBox()
        Me.lsbYearCD = New System.Windows.Forms.ListBox()
        Me.lsbCompaniesCD = New System.Windows.Forms.ListBox()
        Me.lsbCountriesCD = New System.Windows.Forms.ListBox()
        Me.lsbArtistCD = New System.Windows.Forms.ListBox()
        Me.lsbTitleCD = New System.Windows.Forms.ListBox()
        Me.btnSwitch = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAppend = New System.Windows.Forms.Button()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtCountry = New System.Windows.Forms.TextBox()
        Me.txtArtist = New System.Windows.Forms.TextBox()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtCompany = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnDisplayCD
        '
        Me.btnDisplayCD.Location = New System.Drawing.Point(13, 22)
        Me.btnDisplayCD.Name = "btnDisplayCD"
        Me.btnDisplayCD.Size = New System.Drawing.Size(128, 23)
        Me.btnDisplayCD.TabIndex = 50
        Me.btnDisplayCD.Text = "Display CDs"
        Me.btnDisplayCD.UseVisualStyleBackColor = True
        '
        'lsbPriceCD
        '
        Me.lsbPriceCD.FormattingEnabled = True
        Me.lsbPriceCD.Location = New System.Drawing.Point(712, 51)
        Me.lsbPriceCD.Name = "lsbPriceCD"
        Me.lsbPriceCD.Size = New System.Drawing.Size(169, 160)
        Me.lsbPriceCD.TabIndex = 49
        '
        'lsbYearCD
        '
        Me.lsbYearCD.FormattingEnabled = True
        Me.lsbYearCD.Location = New System.Drawing.Point(887, 51)
        Me.lsbYearCD.Name = "lsbYearCD"
        Me.lsbYearCD.Size = New System.Drawing.Size(169, 160)
        Me.lsbYearCD.TabIndex = 48
        '
        'lsbCompaniesCD
        '
        Me.lsbCompaniesCD.FormattingEnabled = True
        Me.lsbCompaniesCD.Location = New System.Drawing.Point(537, 51)
        Me.lsbCompaniesCD.Name = "lsbCompaniesCD"
        Me.lsbCompaniesCD.Size = New System.Drawing.Size(169, 160)
        Me.lsbCompaniesCD.TabIndex = 47
        '
        'lsbCountriesCD
        '
        Me.lsbCountriesCD.FormattingEnabled = True
        Me.lsbCountriesCD.Location = New System.Drawing.Point(362, 51)
        Me.lsbCountriesCD.Name = "lsbCountriesCD"
        Me.lsbCountriesCD.Size = New System.Drawing.Size(169, 160)
        Me.lsbCountriesCD.TabIndex = 46
        '
        'lsbArtistCD
        '
        Me.lsbArtistCD.FormattingEnabled = True
        Me.lsbArtistCD.Location = New System.Drawing.Point(188, 51)
        Me.lsbArtistCD.Name = "lsbArtistCD"
        Me.lsbArtistCD.Size = New System.Drawing.Size(168, 160)
        Me.lsbArtistCD.TabIndex = 45
        '
        'lsbTitleCD
        '
        Me.lsbTitleCD.FormattingEnabled = True
        Me.lsbTitleCD.Location = New System.Drawing.Point(13, 51)
        Me.lsbTitleCD.Name = "lsbTitleCD"
        Me.lsbTitleCD.Size = New System.Drawing.Size(169, 160)
        Me.lsbTitleCD.TabIndex = 44
        '
        'btnSwitch
        '
        Me.btnSwitch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnSwitch.Location = New System.Drawing.Point(21, 25)
        Me.btnSwitch.Name = "btnSwitch"
        Me.btnSwitch.Size = New System.Drawing.Size(96, 23)
        Me.btnSwitch.TabIndex = 53
        Me.btnSwitch.Text = "Switch Form"
        Me.btnSwitch.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(21, 52)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(96, 23)
        Me.btnClear.TabIndex = 52
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(267, 33)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "XML Stuff - CD File"
        '
        'btnAppend
        '
        Me.btnAppend.Location = New System.Drawing.Point(272, 52)
        Me.btnAppend.Name = "btnAppend"
        Me.btnAppend.Size = New System.Drawing.Size(75, 23)
        Me.btnAppend.TabIndex = 64
        Me.btnAppend.Text = "Append"
        Me.btnAppend.UseVisualStyleBackColor = True
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(272, 103)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(75, 23)
        Me.btnShow.TabIndex = 63
        Me.btnShow.Text = "Show"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(272, 27)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 61
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtCountry
        '
        Me.txtCountry.Location = New System.Drawing.Point(64, 80)
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.Size = New System.Drawing.Size(192, 20)
        Me.txtCountry.TabIndex = 60
        '
        'txtArtist
        '
        Me.txtArtist.Location = New System.Drawing.Point(64, 54)
        Me.txtArtist.Name = "txtArtist"
        Me.txtArtist.Size = New System.Drawing.Size(192, 20)
        Me.txtArtist.TabIndex = 59
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(64, 29)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(192, 20)
        Me.txtTitle.TabIndex = 58
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(64, 157)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(192, 20)
        Me.txtYear.TabIndex = 67
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(64, 131)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(192, 20)
        Me.txtPrice.TabIndex = 66
        '
        'txtCompany
        '
        Me.txtCompany.Location = New System.Drawing.Point(64, 106)
        Me.txtCompany.Name = "txtCompany"
        Me.txtCompany.Size = New System.Drawing.Size(192, 20)
        Me.txtCompany.TabIndex = 65
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "Title"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 69
        Me.Label3.Text = "Artist"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "Price"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 71
        Me.Label5.Text = "Company"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(33, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 72
        Me.Label6.Text = "Year"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 73
        Me.Label7.Text = "Country"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.txtArtist)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtTitle)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtCountry)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btnShow)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btnAppend)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtCompany)
        Me.GroupBox1.Controls.Add(Me.txtYear)
        Me.GroupBox1.Controls.Add(Me.txtPrice)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 74)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(367, 199)
        Me.GroupBox1.TabIndex = 74
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Edit"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(272, 78)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 75
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lsbCompaniesCD)
        Me.GroupBox2.Controls.Add(Me.lsbTitleCD)
        Me.GroupBox2.Controls.Add(Me.lsbArtistCD)
        Me.GroupBox2.Controls.Add(Me.lsbCountriesCD)
        Me.GroupBox2.Controls.Add(Me.lsbYearCD)
        Me.GroupBox2.Controls.Add(Me.btnDisplayCD)
        Me.GroupBox2.Controls.Add(Me.lsbPriceCD)
        Me.GroupBox2.Location = New System.Drawing.Point(24, 279)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1069, 224)
        Me.GroupBox2.TabIndex = 75
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Display"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnExit)
        Me.GroupBox3.Controls.Add(Me.btnSwitch)
        Me.GroupBox3.Controls.Add(Me.btnClear)
        Me.GroupBox3.Location = New System.Drawing.Point(407, 152)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 121)
        Me.GroupBox3.TabIndex = 76
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Utility"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(21, 79)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(96, 23)
        Me.btnExit.TabIndex = 54
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(1113, 515)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDisplayCD As Button
    Friend WithEvents lsbPriceCD As ListBox
    Friend WithEvents lsbYearCD As ListBox
    Friend WithEvents lsbCompaniesCD As ListBox
    Friend WithEvents lsbCountriesCD As ListBox
    Friend WithEvents lsbArtistCD As ListBox
    Friend WithEvents lsbTitleCD As ListBox
    Friend WithEvents btnSwitch As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAppend As Button
    Friend WithEvents btnShow As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents txtCountry As TextBox
    Friend WithEvents txtArtist As TextBox
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents txtYear As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtCompany As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnExit As Button
End Class
