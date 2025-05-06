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
        Me.LoadUsermaps = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BuildVer = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chk_CreateCSV = New System.Windows.Forms.CheckBox()
        Me.chk_SubDR = New System.Windows.Forms.CheckBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.copyBuildConfig = New System.Windows.Forms.Button()
        Me.copyBuild = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnH3ODST = New System.Windows.Forms.RadioButton()
        Me.btnH3 = New System.Windows.Forms.RadioButton()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.rememberSettings = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbx_optional = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbx_skipafterveto = New System.Windows.Forms.ComboBox()
        Me.minPlayerCount = New System.Windows.Forms.NumericUpDown()
        Me.entryWeight = New System.Windows.Forms.NumericUpDown()
        Me.gvFileName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CSV_Textbox = New System.Windows.Forms.RichTextBox()
        Me.BuildDir = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.minPlayerCount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.entryWeight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LoadUsermaps
        '
        Me.LoadUsermaps.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoadUsermaps.Location = New System.Drawing.Point(374, 294)
        Me.LoadUsermaps.Name = "LoadUsermaps"
        Me.LoadUsermaps.Size = New System.Drawing.Size(189, 34)
        Me.LoadUsermaps.TabIndex = 2
        Me.LoadUsermaps.Text = "Load Usermaps"
        Me.LoadUsermaps.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(9, 10)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.ScrollAlwaysVisible = True
        Me.ListBox1.Size = New System.Drawing.Size(270, 329)
        Me.ListBox1.TabIndex = 3
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(286, 324)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 19)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "0"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(310, 711)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Build:"
        '
        'BuildVer
        '
        Me.BuildVer.AutoSize = True
        Me.BuildVer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BuildVer.ForeColor = System.Drawing.Color.Blue
        Me.BuildVer.Location = New System.Drawing.Point(902, 475)
        Me.BuildVer.Name = "BuildVer"
        Me.BuildVer.Size = New System.Drawing.Size(163, 13)
        Me.BuildVer.TabIndex = 12
        Me.BuildVer.Text = "12070.08.09.05.2031.halo3_ship"
        Me.BuildVer.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chk_CreateCSV)
        Me.GroupBox1.Controls.Add(Me.chk_SubDR)
        Me.GroupBox1.Location = New System.Drawing.Point(297, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(338, 63)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Preferences"
        '
        'chk_CreateCSV
        '
        Me.chk_CreateCSV.AutoSize = True
        Me.chk_CreateCSV.Location = New System.Drawing.Point(174, 28)
        Me.chk_CreateCSV.Name = "chk_CreateCSV"
        Me.chk_CreateCSV.Size = New System.Drawing.Size(126, 17)
        Me.chk_CreateCSV.TabIndex = 8
        Me.chk_CreateCSV.Text = "Create game_set.csv"
        Me.chk_CreateCSV.UseVisualStyleBackColor = True
        '
        'chk_SubDR
        '
        Me.chk_SubDR.AutoSize = True
        Me.chk_SubDR.Location = New System.Drawing.Point(37, 28)
        Me.chk_SubDR.Name = "chk_SubDR"
        Me.chk_SubDR.Size = New System.Drawing.Size(109, 17)
        Me.chk_SubDR.TabIndex = 7
        Me.chk_SubDR.Text = "Set Sub Directory"
        Me.chk_SubDR.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(8, 8)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(662, 374)
        Me.TabControl1.TabIndex = 36
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.LoadUsermaps)
        Me.TabPage1.Controls.Add(Me.ListBox1)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(654, 348)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Main"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.copyBuildConfig)
        Me.GroupBox3.Controls.Add(Me.copyBuild)
        Me.GroupBox3.Location = New System.Drawing.Point(299, 174)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(338, 105)
        Me.GroupBox3.TabIndex = 28
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Copy To Clipboard Commands"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(286, 13)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Import commands are copied as per selections in the listbox"
        '
        'copyBuildConfig
        '
        Me.copyBuildConfig.Location = New System.Drawing.Point(46, 54)
        Me.copyBuildConfig.Name = "copyBuildConfig"
        Me.copyBuildConfig.Size = New System.Drawing.Size(247, 23)
        Me.copyBuildConfig.TabIndex = 1
        Me.copyBuildConfig.Text = "Build Title Storage Config"
        Me.copyBuildConfig.UseVisualStyleBackColor = True
        '
        'copyBuild
        '
        Me.copyBuild.Location = New System.Drawing.Point(46, 26)
        Me.copyBuild.Name = "copyBuild"
        Me.copyBuild.Size = New System.Drawing.Size(247, 23)
        Me.copyBuild.TabIndex = 0
        Me.copyBuild.Text = "Build Title Storage"
        Me.copyBuild.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnH3ODST)
        Me.GroupBox2.Controls.Add(Me.btnH3)
        Me.GroupBox2.Location = New System.Drawing.Point(299, 78)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(338, 90)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Build String"
        '
        'btnH3ODST
        '
        Me.btnH3ODST.AutoSize = True
        Me.btnH3ODST.Location = New System.Drawing.Point(62, 51)
        Me.btnH3ODST.Name = "btnH3ODST"
        Me.btnH3ODST.Size = New System.Drawing.Size(192, 17)
        Me.btnH3ODST.TabIndex = 27
        Me.btnH3ODST.TabStop = True
        Me.btnH3ODST.Text = "13895.09.04.27.2201.atlas_release"
        Me.btnH3ODST.UseVisualStyleBackColor = True
        '
        'btnH3
        '
        Me.btnH3.AutoSize = True
        Me.btnH3.Checked = True
        Me.btnH3.Location = New System.Drawing.Point(62, 27)
        Me.btnH3.Name = "btnH3"
        Me.btnH3.Size = New System.Drawing.Size(181, 17)
        Me.btnH3.TabIndex = 26
        Me.btnH3.TabStop = True
        Me.btnH3.Text = "12070.08.09.05.2031.halo3_ship"
        Me.btnH3.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.rememberSettings)
        Me.TabPage3.Controls.Add(Me.Label11)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.Label9)
        Me.TabPage3.Controls.Add(Me.cmbx_optional)
        Me.TabPage3.Controls.Add(Me.Label8)
        Me.TabPage3.Controls.Add(Me.Label7)
        Me.TabPage3.Controls.Add(Me.Label6)
        Me.TabPage3.Controls.Add(Me.Label5)
        Me.TabPage3.Controls.Add(Me.cmbx_skipafterveto)
        Me.TabPage3.Controls.Add(Me.minPlayerCount)
        Me.TabPage3.Controls.Add(Me.entryWeight)
        Me.TabPage3.Controls.Add(Me.gvFileName)
        Me.TabPage3.Controls.Add(Me.Label4)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(654, 348)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "CSV Defaults"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'rememberSettings
        '
        Me.rememberSettings.AutoSize = True
        Me.rememberSettings.Location = New System.Drawing.Point(486, 17)
        Me.rememberSettings.Name = "rememberSettings"
        Me.rememberSettings.Size = New System.Drawing.Size(151, 17)
        Me.rememberSettings.TabIndex = 51
        Me.rememberSettings.Text = "Remember These Settings"
        Me.rememberSettings.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(18, 276)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(519, 15)
        Me.Label11.TabIndex = 50
        Me.Label11.Text = "CSV will be created upon loading usermaps with the ""Create game_set.csv"" checkbox" &
    " selected"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(26, 212)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 49
        Me.Label10.Text = "Optional:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(26, 185)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 13)
        Me.Label9.TabIndex = 48
        Me.Label9.Text = "Skip After Veto:"
        '
        'cmbx_optional
        '
        Me.cmbx_optional.AccessibleName = ""
        Me.cmbx_optional.FormattingEnabled = True
        Me.cmbx_optional.Items.AddRange(New Object() {"true", "false"})
        Me.cmbx_optional.Location = New System.Drawing.Point(175, 209)
        Me.cmbx_optional.Name = "cmbx_optional"
        Me.cmbx_optional.Size = New System.Drawing.Size(55, 21)
        Me.cmbx_optional.TabIndex = 47
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(26, 158)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 13)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "Minimum Player Count:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(26, 132)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 13)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Game Entry Weight:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(18, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(283, 15)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "You probably want to edit these later in a notepad..."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(206, 16)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Default Settings for game_set.csv"
        '
        'cmbx_skipafterveto
        '
        Me.cmbx_skipafterveto.AccessibleName = ""
        Me.cmbx_skipafterveto.FormattingEnabled = True
        Me.cmbx_skipafterveto.Items.AddRange(New Object() {"true", "false"})
        Me.cmbx_skipafterveto.Location = New System.Drawing.Point(175, 182)
        Me.cmbx_skipafterveto.Name = "cmbx_skipafterveto"
        Me.cmbx_skipafterveto.Size = New System.Drawing.Size(55, 21)
        Me.cmbx_skipafterveto.TabIndex = 42
        '
        'minPlayerCount
        '
        Me.minPlayerCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minPlayerCount.Location = New System.Drawing.Point(175, 156)
        Me.minPlayerCount.Maximum = New Decimal(New Integer() {16, 0, 0, 0})
        Me.minPlayerCount.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.minPlayerCount.Name = "minPlayerCount"
        Me.minPlayerCount.Size = New System.Drawing.Size(55, 20)
        Me.minPlayerCount.TabIndex = 41
        Me.minPlayerCount.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'entryWeight
        '
        Me.entryWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.entryWeight.Location = New System.Drawing.Point(175, 130)
        Me.entryWeight.Maximum = New Decimal(New Integer() {16, 0, 0, 0})
        Me.entryWeight.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.entryWeight.Name = "entryWeight"
        Me.entryWeight.Size = New System.Drawing.Size(55, 20)
        Me.entryWeight.TabIndex = 40
        Me.entryWeight.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'gvFileName
        '
        Me.gvFileName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvFileName.Location = New System.Drawing.Point(175, 104)
        Me.gvFileName.Name = "gvFileName"
        Me.gvFileName.Size = New System.Drawing.Size(106, 20)
        Me.gvFileName.TabIndex = 1
        Me.gvFileName.Text = "placeholder"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Game Variant File Name:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DataGridView1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(654, 348)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "MVAR Origin Finder"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column4, Me.Column3})
        Me.DataGridView1.Location = New System.Drawing.Point(8, 6)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 55
        Me.DataGridView1.Size = New System.Drawing.Size(639, 336)
        Me.DataGridView1.TabIndex = 32
        '
        'Column1
        '
        Me.Column1.HeaderText = "Map Name"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 138
        '
        'Column2
        '
        Me.Column2.HeaderText = "Map Origin"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 95
        '
        'Column4
        '
        Me.Column4.HeaderText = "Author"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Path"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 283
        '
        'CSV_Textbox
        '
        Me.CSV_Textbox.Location = New System.Drawing.Point(725, 30)
        Me.CSV_Textbox.Name = "CSV_Textbox"
        Me.CSV_Textbox.ReadOnly = True
        Me.CSV_Textbox.Size = New System.Drawing.Size(576, 352)
        Me.CSV_Textbox.TabIndex = 37
        Me.CSV_Textbox.Text = "map_variant_file_name,game_variant_file_name,weight,minimum_player_count,skip_aft" &
    "er_veto,optional" & Global.Microsoft.VisualBasic.ChrW(10)
        Me.CSV_Textbox.Visible = False
        '
        'BuildDir
        '
        Me.BuildDir.AutoSize = True
        Me.BuildDir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BuildDir.ForeColor = System.Drawing.Color.Blue
        Me.BuildDir.Location = New System.Drawing.Point(902, 488)
        Me.BuildDir.Name = "BuildDir"
        Me.BuildDir.Size = New System.Drawing.Size(40, 13)
        Me.BuildDir.TabIndex = 39
        Me.BuildDir.Text = "12070 "
        Me.BuildDir.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(676, 388)
        Me.Controls.Add(Me.BuildDir)
        Me.Controls.Add(Me.CSV_Textbox)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.BuildVer)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "BLF CLI Import Helper"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.minPlayerCount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.entryWeight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LoadUsermaps As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BuildVer As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chk_CreateCSV As CheckBox
    Friend WithEvents chk_SubDR As CheckBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnH3ODST As RadioButton
    Friend WithEvents btnH3 As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents copyBuild As Button
    Friend WithEvents copyBuildConfig As Button
    Friend WithEvents CSV_Textbox As RichTextBox
    Friend WithEvents BuildDir As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Label4 As Label
    Friend WithEvents gvFileName As TextBox
    Friend WithEvents entryWeight As NumericUpDown
    Friend WithEvents minPlayerCount As NumericUpDown
    Friend WithEvents cmbx_skipafterveto As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbx_optional As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents rememberSettings As CheckBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
End Class
