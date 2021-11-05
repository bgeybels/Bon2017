<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Searchfakt
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
        Me.components = New System.ComponentModel.Container()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TSBexit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.TSBdelete = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.TSBexport = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.TSBprint = New System.Windows.Forms.ToolStripButton()
        Me.TSBtopten = New System.Windows.Forms.ToolStripButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TBResultFAKTL = New System.Windows.Forms.TextBox()
        Me.TBResultFAKT = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupFilter = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.CBfilterdatum = New System.Windows.Forms.CheckBox()
        Me.Fltdatumtot = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.FltDatumvan = New System.Windows.Forms.DateTimePicker()
        Me.CBcnrC = New System.Windows.Forms.CheckBox()
        Me.CBcnrD = New System.Windows.Forms.CheckBox()
        Me.ChkBType = New System.Windows.Forms.CheckBox()
        Me.NFltCBtype = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CBfilterwyear = New System.Windows.Forms.CheckBox()
        Me.FltWJR = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Fltusernrq = New System.Windows.Forms.TextBox()
        Me.CBfilteryear = New System.Windows.Forms.CheckBox()
        Me.BTN_FilterReset = New System.Windows.Forms.Button()
        Me.Fltbonjr = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Fltnr = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Fltwerf = New System.Windows.Forms.TextBox()
        Me.Fltknaam = New System.Windows.Forms.TextBox()
        Me.GrBDetailBon = New System.Windows.Forms.GroupBox()
        Me.DGREC = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToonFaktuurlijnenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.VerwijderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.GroupFilter.SuspendLayout()
        CType(Me.FltWJR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fltbonjr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrBDetailBon.SuspendLayout()
        CType(Me.DGREC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackgroundImage = Global.Bon2017.My.Resources.Resources.canvas_fakturen
        Me.ToolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSBexit, Me.ToolStripLabel4, Me.TSBdelete, Me.ToolStripLabel2, Me.TSBexport, Me.ToolStripLabel3, Me.TSBprint, Me.TSBtopten})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1268, 31)
        Me.ToolStrip1.TabIndex = 5
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'TSBexit
        '
        Me.TSBexit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSBexit.Image = Global.Bon2017.My.Resources.Resources.home
        Me.TSBexit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSBexit.Name = "TSBexit"
        Me.TSBexit.Size = New System.Drawing.Size(28, 28)
        Me.TSBexit.Text = "Exit"
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(16, 28)
        Me.ToolStripLabel4.Text = "   "
        '
        'TSBdelete
        '
        Me.TSBdelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSBdelete.Image = Global.Bon2017.My.Resources.Resources.itemdelete
        Me.TSBdelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSBdelete.Name = "TSBdelete"
        Me.TSBdelete.Size = New System.Drawing.Size(28, 28)
        Me.TSBdelete.Text = "Verwijder"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(16, 28)
        Me.ToolStripLabel2.Text = "   "
        '
        'TSBexport
        '
        Me.TSBexport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSBexport.Image = Global.Bon2017.My.Resources.Resources.excel
        Me.TSBexport.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSBexport.Name = "TSBexport"
        Me.TSBexport.Size = New System.Drawing.Size(28, 28)
        Me.TSBexport.Text = "Exporteer"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(16, 28)
        Me.ToolStripLabel3.Text = "   "
        '
        'TSBprint
        '
        Me.TSBprint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSBprint.Enabled = False
        Me.TSBprint.Image = Global.Bon2017.My.Resources.Resources.print
        Me.TSBprint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSBprint.Name = "TSBprint"
        Me.TSBprint.Size = New System.Drawing.Size(28, 28)
        Me.TSBprint.Text = "Print"
        Me.TSBprint.Visible = False
        '
        'TSBtopten
        '
        Me.TSBtopten.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSBtopten.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSBtopten.Name = "TSBtopten"
        Me.TSBtopten.Size = New System.Drawing.Size(23, 28)
        Me.TSBtopten.Text = "ToolStripButton1"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 31)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1268, 447)
        Me.TableLayoutPanel1.TabIndex = 7
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TBResultFAKTL, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TBResultFAKT, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1262, 114)
        Me.TableLayoutPanel2.TabIndex = 15
        '
        'TBResultFAKTL
        '
        Me.TBResultFAKTL.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TBResultFAKTL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TBResultFAKTL.Enabled = False
        Me.TBResultFAKTL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBResultFAKTL.Location = New System.Drawing.Point(634, 3)
        Me.TBResultFAKTL.Multiline = True
        Me.TBResultFAKTL.Name = "TBResultFAKTL"
        Me.TBResultFAKTL.Size = New System.Drawing.Size(625, 108)
        Me.TBResultFAKTL.TabIndex = 17
        '
        'TBResultFAKT
        '
        Me.TBResultFAKT.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TBResultFAKT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TBResultFAKT.Enabled = False
        Me.TBResultFAKT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBResultFAKT.Location = New System.Drawing.Point(3, 3)
        Me.TBResultFAKT.Multiline = True
        Me.TBResultFAKT.Name = "TBResultFAKT"
        Me.TBResultFAKT.Size = New System.Drawing.Size(625, 108)
        Me.TBResultFAKT.TabIndex = 16
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.Controls.Add(Me.GroupFilter, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.GrBDetailBon, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 123)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1262, 346)
        Me.TableLayoutPanel3.TabIndex = 16
        '
        'GroupFilter
        '
        Me.GroupFilter.AutoSize = True
        Me.GroupFilter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupFilter.Controls.Add(Me.Label7)
        Me.GroupFilter.Controls.Add(Me.Label13)
        Me.GroupFilter.Controls.Add(Me.CBfilterdatum)
        Me.GroupFilter.Controls.Add(Me.Fltdatumtot)
        Me.GroupFilter.Controls.Add(Me.Label8)
        Me.GroupFilter.Controls.Add(Me.FltDatumvan)
        Me.GroupFilter.Controls.Add(Me.CBcnrC)
        Me.GroupFilter.Controls.Add(Me.CBcnrD)
        Me.GroupFilter.Controls.Add(Me.ChkBType)
        Me.GroupFilter.Controls.Add(Me.NFltCBtype)
        Me.GroupFilter.Controls.Add(Me.Label5)
        Me.GroupFilter.Controls.Add(Me.Label4)
        Me.GroupFilter.Controls.Add(Me.CBfilterwyear)
        Me.GroupFilter.Controls.Add(Me.FltWJR)
        Me.GroupFilter.Controls.Add(Me.Label3)
        Me.GroupFilter.Controls.Add(Me.Fltusernrq)
        Me.GroupFilter.Controls.Add(Me.CBfilteryear)
        Me.GroupFilter.Controls.Add(Me.BTN_FilterReset)
        Me.GroupFilter.Controls.Add(Me.Fltbonjr)
        Me.GroupFilter.Controls.Add(Me.Label6)
        Me.GroupFilter.Controls.Add(Me.Fltnr)
        Me.GroupFilter.Controls.Add(Me.Label11)
        Me.GroupFilter.Controls.Add(Me.Label2)
        Me.GroupFilter.Controls.Add(Me.Label1)
        Me.GroupFilter.Controls.Add(Me.Fltwerf)
        Me.GroupFilter.Controls.Add(Me.Fltknaam)
        Me.GroupFilter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupFilter.Location = New System.Drawing.Point(3, 3)
        Me.GroupFilter.Name = "GroupFilter"
        Me.GroupFilter.Size = New System.Drawing.Size(169, 340)
        Me.GroupFilter.TabIndex = 16
        Me.GroupFilter.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(44, 102)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 13)
        Me.Label7.TabIndex = 69
        Me.Label7.Text = "Filter op datum?"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(15, 150)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(23, 13)
        Me.Label13.TabIndex = 68
        Me.Label13.Text = "Tot"
        '
        'CBfilterdatum
        '
        Me.CBfilterdatum.AutoSize = True
        Me.CBfilterdatum.Location = New System.Drawing.Point(132, 103)
        Me.CBfilterdatum.Name = "CBfilterdatum"
        Me.CBfilterdatum.Size = New System.Drawing.Size(15, 14)
        Me.CBfilterdatum.TabIndex = 67
        Me.CBfilterdatum.TabStop = False
        Me.CBfilterdatum.UseVisualStyleBackColor = True
        '
        'Fltdatumtot
        '
        Me.Fltdatumtot.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Fltdatumtot.Location = New System.Drawing.Point(45, 146)
        Me.Fltdatumtot.Name = "Fltdatumtot"
        Me.Fltdatumtot.Size = New System.Drawing.Size(102, 20)
        Me.Fltdatumtot.TabIndex = 66
        Me.Fltdatumtot.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 124)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(26, 13)
        Me.Label8.TabIndex = 65
        Me.Label8.Text = "Van"
        '
        'FltDatumvan
        '
        Me.FltDatumvan.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FltDatumvan.Location = New System.Drawing.Point(45, 120)
        Me.FltDatumvan.Name = "FltDatumvan"
        Me.FltDatumvan.Size = New System.Drawing.Size(102, 20)
        Me.FltDatumvan.TabIndex = 64
        Me.FltDatumvan.TabStop = False
        Me.FltDatumvan.Value = New Date(2018, 6, 10, 10, 1, 7, 0)
        '
        'CBcnrC
        '
        Me.CBcnrC.AutoSize = True
        Me.CBcnrC.Location = New System.Drawing.Point(78, 230)
        Me.CBcnrC.Name = "CBcnrC"
        Me.CBcnrC.Size = New System.Drawing.Size(33, 17)
        Me.CBcnrC.TabIndex = 45
        Me.CBcnrC.Text = "C"
        Me.CBcnrC.UseVisualStyleBackColor = True
        '
        'CBcnrD
        '
        Me.CBcnrD.AutoSize = True
        Me.CBcnrD.Location = New System.Drawing.Point(45, 230)
        Me.CBcnrD.Name = "CBcnrD"
        Me.CBcnrD.Size = New System.Drawing.Size(34, 17)
        Me.CBcnrD.TabIndex = 44
        Me.CBcnrD.Text = "D"
        Me.CBcnrD.UseVisualStyleBackColor = True
        '
        'ChkBType
        '
        Me.ChkBType.AutoSize = True
        Me.ChkBType.Location = New System.Drawing.Point(21, 313)
        Me.ChkBType.Name = "ChkBType"
        Me.ChkBType.Size = New System.Drawing.Size(15, 14)
        Me.ChkBType.TabIndex = 39
        Me.ChkBType.UseVisualStyleBackColor = True
        '
        'NFltCBtype
        '
        Me.NFltCBtype.AllowDrop = True
        Me.NFltCBtype.FormattingEnabled = True
        Me.NFltCBtype.Items.AddRange(New Object() {"Bouw", "Verkoop", "Transport", "Container", "Nazorg", "Groenonderhoud", "Onbekend"})
        Me.NFltCBtype.Location = New System.Drawing.Point(42, 306)
        Me.NFltCBtype.Name = "NFltCBtype"
        Me.NFltCBtype.Size = New System.Drawing.Size(121, 21)
        Me.NFltCBtype.TabIndex = 38
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "WJR"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 13)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "JR"
        '
        'CBfilterwyear
        '
        Me.CBfilterwyear.AutoSize = True
        Me.CBfilterwyear.Location = New System.Drawing.Point(105, 77)
        Me.CBfilterwyear.Name = "CBfilterwyear"
        Me.CBfilterwyear.Size = New System.Drawing.Size(15, 14)
        Me.CBfilterwyear.TabIndex = 35
        Me.CBfilterwyear.UseVisualStyleBackColor = True
        '
        'FltWJR
        '
        Me.FltWJR.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FltWJR.Location = New System.Drawing.Point(46, 74)
        Me.FltWJR.Maximum = New Decimal(New Integer() {2090, 0, 0, 0})
        Me.FltWJR.Minimum = New Decimal(New Integer() {1980, 0, 0, 0})
        Me.FltWJR.Name = "FltWJR"
        Me.FltWJR.Size = New System.Drawing.Size(56, 20)
        Me.FltWJR.TabIndex = 34
        Me.FltWJR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.FltWJR.Value = New Decimal(New Integer() {2012, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 284)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Wie"
        '
        'Fltusernrq
        '
        Me.Fltusernrq.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Fltusernrq.Location = New System.Drawing.Point(44, 280)
        Me.Fltusernrq.Name = "Fltusernrq"
        Me.Fltusernrq.Size = New System.Drawing.Size(64, 20)
        Me.Fltusernrq.TabIndex = 32
        '
        'CBfilteryear
        '
        Me.CBfilteryear.AutoSize = True
        Me.CBfilteryear.Checked = True
        Me.CBfilteryear.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CBfilteryear.Location = New System.Drawing.Point(105, 51)
        Me.CBfilteryear.Name = "CBfilteryear"
        Me.CBfilteryear.Size = New System.Drawing.Size(15, 14)
        Me.CBfilteryear.TabIndex = 31
        Me.CBfilteryear.UseVisualStyleBackColor = True
        '
        'BTN_FilterReset
        '
        Me.BTN_FilterReset.Image = Global.Bon2017.My.Resources.Resources.reload
        Me.BTN_FilterReset.Location = New System.Drawing.Point(128, 10)
        Me.BTN_FilterReset.Name = "BTN_FilterReset"
        Me.BTN_FilterReset.Size = New System.Drawing.Size(35, 35)
        Me.BTN_FilterReset.TabIndex = 30
        Me.BTN_FilterReset.UseVisualStyleBackColor = True
        '
        'Fltbonjr
        '
        Me.Fltbonjr.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Fltbonjr.Location = New System.Drawing.Point(46, 48)
        Me.Fltbonjr.Maximum = New Decimal(New Integer() {2090, 0, 0, 0})
        Me.Fltbonjr.Minimum = New Decimal(New Integer() {1980, 0, 0, 0})
        Me.Fltbonjr.Name = "Fltbonjr"
        Me.Fltbonjr.Size = New System.Drawing.Size(56, 20)
        Me.Fltbonjr.TabIndex = 25
        Me.Fltbonjr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Fltbonjr.Value = New Decimal(New Integer() {2012, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 258)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "BonNr"
        '
        'Fltnr
        '
        Me.Fltnr.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Fltnr.Location = New System.Drawing.Point(44, 254)
        Me.Fltnr.Name = "Fltnr"
        Me.Fltnr.Size = New System.Drawing.Size(64, 20)
        Me.Fltnr.TabIndex = 28
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(3, 231)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(27, 13)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "D/C"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 205)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Werf"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 179)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Klant"
        '
        'Fltwerf
        '
        Me.Fltwerf.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Fltwerf.Location = New System.Drawing.Point(44, 201)
        Me.Fltwerf.Name = "Fltwerf"
        Me.Fltwerf.Size = New System.Drawing.Size(64, 20)
        Me.Fltwerf.TabIndex = 7
        '
        'Fltknaam
        '
        Me.Fltknaam.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Fltknaam.Location = New System.Drawing.Point(44, 175)
        Me.Fltknaam.Name = "Fltknaam"
        Me.Fltknaam.Size = New System.Drawing.Size(64, 20)
        Me.Fltknaam.TabIndex = 6
        '
        'GrBDetailBon
        '
        Me.GrBDetailBon.AutoSize = True
        Me.GrBDetailBon.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GrBDetailBon.Controls.Add(Me.DGREC)
        Me.GrBDetailBon.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrBDetailBon.Location = New System.Drawing.Point(178, 3)
        Me.GrBDetailBon.Name = "GrBDetailBon"
        Me.GrBDetailBon.Size = New System.Drawing.Size(1081, 340)
        Me.GrBDetailBon.TabIndex = 15
        Me.GrBDetailBon.TabStop = False
        '
        'DGREC
        '
        Me.DGREC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGREC.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DGREC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGREC.Location = New System.Drawing.Point(3, 16)
        Me.DGREC.MultiSelect = False
        Me.DGREC.Name = "DGREC"
        Me.DGREC.Size = New System.Drawing.Size(1075, 321)
        Me.DGREC.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToonFaktuurlijnenToolStripMenuItem, Me.ToolStripSeparator1, Me.VerwijderToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(241, 54)
        '
        'ToonFaktuurlijnenToolStripMenuItem
        '
        Me.ToonFaktuurlijnenToolStripMenuItem.Name = "ToonFaktuurlijnenToolStripMenuItem"
        Me.ToonFaktuurlijnenToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
        Me.ToonFaktuurlijnenToolStripMenuItem.Text = "Toon Faktuurlijnen"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(237, 6)
        '
        'VerwijderToolStripMenuItem
        '
        Me.VerwijderToolStripMenuItem.Image = Global.Bon2017.My.Resources.Resources.itemdelete
        Me.VerwijderToolStripMenuItem.Name = "VerwijderToolStripMenuItem"
        Me.VerwijderToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
        Me.VerwijderToolStripMenuItem.Text = "Verwijder geselecteerde Faktuur"
        '
        'Searchfakt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1268, 478)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "Searchfakt"
        Me.Text = "Fakturen: Overzicht"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.GroupFilter.ResumeLayout(False)
        Me.GroupFilter.PerformLayout()
        CType(Me.FltWJR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fltbonjr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrBDetailBon.ResumeLayout(False)
        CType(Me.DGREC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents TSBexit As ToolStripButton
    Friend WithEvents ToolStripLabel4 As ToolStripLabel
    Friend WithEvents TSBdelete As ToolStripButton
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents TSBexport As ToolStripButton
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents TSBprint As ToolStripButton
    Friend WithEvents TSBtopten As ToolStripButton
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TBResultFAKTL As TextBox
    Friend WithEvents TBResultFAKT As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents VerwijderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToonFaktuurlijnenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents GroupFilter As GroupBox
    Friend WithEvents CBfilterwyear As CheckBox
    Friend WithEvents FltWJR As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents Fltusernrq As TextBox
    Friend WithEvents CBfilteryear As CheckBox
    Friend WithEvents BTN_FilterReset As Button
    Friend WithEvents Fltbonjr As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents Fltnr As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Fltwerf As TextBox
    Friend WithEvents Fltknaam As TextBox
    Friend WithEvents GrBDetailBon As GroupBox
    Friend WithEvents DGREC As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents NFltCBtype As ComboBox
    Friend WithEvents ChkBType As CheckBox
    Friend WithEvents CBcnrC As CheckBox
    Friend WithEvents CBcnrD As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents CBfilterdatum As CheckBox
    Friend WithEvents Fltdatumtot As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents FltDatumvan As DateTimePicker
End Class
