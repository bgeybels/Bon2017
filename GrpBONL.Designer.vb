﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GrpBONL
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GrpBONL))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TSBexit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.TSBsave = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel6 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel5 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.TSBverplaats = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.TSBdelete = New System.Windows.Forms.ToolStripButton()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CMBoaanm = New System.Windows.Forms.ComboBox()
        Me.CBoaanm = New System.Windows.Forms.CheckBox()
        Me.CBcode = New System.Windows.Forms.CheckBox()
        Me.ZoekCodeIM = New System.Windows.Forms.TextBox()
        Me.lblCODEinfo = New System.Windows.Forms.Label()
        Me.ZoekCode = New System.Windows.Forms.Button()
        Me.CMBper = New System.Windows.Forms.ComboBox()
        Me.TBboneenhp = New System.Windows.Forms.TextBox()
        Me.DTPdatum = New System.Windows.Forms.DateTimePicker()
        Me.CMBbtw = New System.Windows.Forms.ComboBox()
        Me.CBpersoneel = New System.Windows.Forms.CheckBox()
        Me.CBprijs = New System.Windows.Forms.CheckBox()
        Me.CBdatum = New System.Windows.Forms.CheckBox()
        Me.CBbtw = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.DGBON = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Fltbonnr = New System.Windows.Forms.TextBox()
        Me.Fltbonjr = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Fltwerf = New System.Windows.Forms.TextBox()
        Me.Fltklant = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.DGREC = New System.Windows.Forms.DataGridView()
        Me.CBfnr = New System.Windows.Forms.CheckBox()
        Me.ToolStrip1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.DGBON, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Fltbonjr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DGREC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSBexit, Me.ToolStripLabel4, Me.TSBsave, Me.ToolStripLabel6, Me.ToolStripLabel5, Me.ToolStripLabel1, Me.TSBverplaats, Me.ToolStripLabel3, Me.ToolStripLabel2, Me.TSBdelete})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1192, 31)
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
        'TSBsave
        '
        Me.TSBsave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSBsave.Image = CType(resources.GetObject("TSBsave.Image"), System.Drawing.Image)
        Me.TSBsave.ImageTransparentColor = System.Drawing.Color.Black
        Me.TSBsave.Name = "TSBsave"
        Me.TSBsave.Size = New System.Drawing.Size(28, 28)
        Me.TSBsave.Text = "Bewaar"
        '
        'ToolStripLabel6
        '
        Me.ToolStripLabel6.Name = "ToolStripLabel6"
        Me.ToolStripLabel6.Size = New System.Drawing.Size(16, 28)
        Me.ToolStripLabel6.Text = "   "
        '
        'ToolStripLabel5
        '
        Me.ToolStripLabel5.Name = "ToolStripLabel5"
        Me.ToolStripLabel5.Size = New System.Drawing.Size(16, 28)
        Me.ToolStripLabel5.Text = "   "
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(16, 28)
        Me.ToolStripLabel1.Text = "   "
        '
        'TSBverplaats
        '
        Me.TSBverplaats.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSBverplaats.Image = Global.Bon2017.My.Resources.Resources.itemnext
        Me.TSBverplaats.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSBverplaats.Name = "TSBverplaats"
        Me.TSBverplaats.Size = New System.Drawing.Size(28, 28)
        Me.TSBverplaats.Text = "Verplaats/Copieer geselecteerde bonlijnen"
        Me.TSBverplaats.ToolTipText = "Verplaats/Copieer geselecteerde bonlijnen"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(16, 28)
        Me.ToolStripLabel3.Text = "   "
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(16, 28)
        Me.ToolStripLabel2.Text = "   "
        '
        'TSBdelete
        '
        Me.TSBdelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSBdelete.Image = Global.Bon2017.My.Resources.Resources.itemdelete
        Me.TSBdelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSBdelete.Name = "TSBdelete"
        Me.TSBdelete.Size = New System.Drawing.Size(28, 28)
        Me.TSBdelete.Text = "Verwijder geslecteerde bonlijnen"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoSize = True
        Me.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.Controls.Add(Me.GroupBox1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1186, 286)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox1.Controls.Add(Me.CMBoaanm)
        Me.GroupBox1.Controls.Add(Me.CBoaanm)
        Me.GroupBox1.Controls.Add(Me.CBcode)
        Me.GroupBox1.Controls.Add(Me.ZoekCodeIM)
        Me.GroupBox1.Controls.Add(Me.lblCODEinfo)
        Me.GroupBox1.Controls.Add(Me.ZoekCode)
        Me.GroupBox1.Controls.Add(Me.CMBper)
        Me.GroupBox1.Controls.Add(Me.TBboneenhp)
        Me.GroupBox1.Controls.Add(Me.DTPdatum)
        Me.GroupBox1.Controls.Add(Me.CMBbtw)
        Me.GroupBox1.Controls.Add(Me.CBpersoneel)
        Me.GroupBox1.Controls.Add(Me.CBprijs)
        Me.GroupBox1.Controls.Add(Me.CBdatum)
        Me.GroupBox1.Controls.Add(Me.CBbtw)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(364, 280)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'CMBoaanm
        '
        Me.CMBoaanm.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CMBoaanm.FormattingEnabled = True
        Me.CMBoaanm.Location = New System.Drawing.Point(82, 121)
        Me.CMBoaanm.Name = "CMBoaanm"
        Me.CMBoaanm.Size = New System.Drawing.Size(232, 21)
        Me.CMBoaanm.TabIndex = 87
        '
        'CBoaanm
        '
        Me.CBoaanm.AutoSize = True
        Me.CBoaanm.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CBoaanm.Location = New System.Drawing.Point(15, 123)
        Me.CBoaanm.Name = "CBoaanm"
        Me.CBoaanm.Size = New System.Drawing.Size(61, 17)
        Me.CBoaanm.TabIndex = 86
        Me.CBoaanm.Text = "OAanm"
        Me.CBoaanm.UseVisualStyleBackColor = True
        '
        'CBcode
        '
        Me.CBcode.AutoSize = True
        Me.CBcode.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CBcode.Location = New System.Drawing.Point(25, 146)
        Me.CBcode.Name = "CBcode"
        Me.CBcode.Size = New System.Drawing.Size(51, 17)
        Me.CBcode.TabIndex = 85
        Me.CBcode.Text = "Code"
        Me.CBcode.UseVisualStyleBackColor = True
        '
        'ZoekCodeIM
        '
        Me.ZoekCodeIM.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ZoekCodeIM.Location = New System.Drawing.Point(84, 147)
        Me.ZoekCodeIM.Name = "ZoekCodeIM"
        Me.ZoekCodeIM.Size = New System.Drawing.Size(46, 20)
        Me.ZoekCodeIM.TabIndex = 84
        Me.ZoekCodeIM.TabStop = False
        '
        'lblCODEinfo
        '
        Me.lblCODEinfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCODEinfo.ForeColor = System.Drawing.Color.Gray
        Me.lblCODEinfo.Location = New System.Drawing.Point(15, 182)
        Me.lblCODEinfo.Name = "lblCODEinfo"
        Me.lblCODEinfo.Size = New System.Drawing.Size(343, 95)
        Me.lblCODEinfo.TabIndex = 83
        '
        'ZoekCode
        '
        Me.ZoekCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ZoekCode.Image = Global.Bon2017.My.Resources.Resources.search
        Me.ZoekCode.Location = New System.Drawing.Point(136, 144)
        Me.ZoekCode.Name = "ZoekCode"
        Me.ZoekCode.Size = New System.Drawing.Size(36, 35)
        Me.ZoekCode.TabIndex = 82
        Me.ZoekCode.TabStop = False
        Me.ZoekCode.UseVisualStyleBackColor = False
        '
        'CMBper
        '
        Me.CMBper.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CMBper.FormattingEnabled = True
        Me.CMBper.Location = New System.Drawing.Point(82, 96)
        Me.CMBper.Name = "CMBper"
        Me.CMBper.Size = New System.Drawing.Size(232, 21)
        Me.CMBper.TabIndex = 73
        '
        'TBboneenhp
        '
        Me.TBboneenhp.Location = New System.Drawing.Point(82, 70)
        Me.TBboneenhp.Name = "TBboneenhp"
        Me.TBboneenhp.Size = New System.Drawing.Size(56, 20)
        Me.TBboneenhp.TabIndex = 71
        '
        'DTPdatum
        '
        Me.DTPdatum.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPdatum.Location = New System.Drawing.Point(82, 44)
        Me.DTPdatum.Name = "DTPdatum"
        Me.DTPdatum.Size = New System.Drawing.Size(107, 20)
        Me.DTPdatum.TabIndex = 70
        '
        'CMBbtw
        '
        Me.CMBbtw.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CMBbtw.FormattingEnabled = True
        Me.CMBbtw.Location = New System.Drawing.Point(82, 17)
        Me.CMBbtw.Name = "CMBbtw"
        Me.CMBbtw.Size = New System.Drawing.Size(276, 21)
        Me.CMBbtw.TabIndex = 69
        '
        'CBpersoneel
        '
        Me.CBpersoneel.AutoSize = True
        Me.CBpersoneel.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CBpersoneel.Location = New System.Drawing.Point(3, 98)
        Me.CBpersoneel.Name = "CBpersoneel"
        Me.CBpersoneel.Size = New System.Drawing.Size(73, 17)
        Me.CBpersoneel.TabIndex = 4
        Me.CBpersoneel.Text = "Personeel"
        Me.CBpersoneel.UseVisualStyleBackColor = True
        '
        'CBprijs
        '
        Me.CBprijs.AutoSize = True
        Me.CBprijs.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CBprijs.Location = New System.Drawing.Point(31, 70)
        Me.CBprijs.Name = "CBprijs"
        Me.CBprijs.Size = New System.Drawing.Size(45, 17)
        Me.CBprijs.TabIndex = 2
        Me.CBprijs.Text = "Prijs"
        Me.CBprijs.UseVisualStyleBackColor = True
        '
        'CBdatum
        '
        Me.CBdatum.AutoSize = True
        Me.CBdatum.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CBdatum.Location = New System.Drawing.Point(19, 46)
        Me.CBdatum.Name = "CBdatum"
        Me.CBdatum.Size = New System.Drawing.Size(57, 17)
        Me.CBdatum.TabIndex = 1
        Me.CBdatum.Text = "Datum"
        Me.CBdatum.UseVisualStyleBackColor = True
        '
        'CBbtw
        '
        Me.CBbtw.AutoSize = True
        Me.CBbtw.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CBbtw.Location = New System.Drawing.Point(25, 19)
        Me.CBbtw.Name = "CBbtw"
        Me.CBbtw.Size = New System.Drawing.Size(51, 17)
        Me.CBbtw.TabIndex = 0
        Me.CBbtw.Text = "BTW"
        Me.CBbtw.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.AutoSize = True
        Me.TableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.DGBON, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.GroupBox2, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(373, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(810, 280)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'DGBON
        '
        Me.DGBON.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGBON.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGBON.Location = New System.Drawing.Point(3, 68)
        Me.DGBON.Name = "DGBON"
        Me.DGBON.Size = New System.Drawing.Size(804, 210)
        Me.DGBON.TabIndex = 32
        '
        'GroupBox2
        '
        Me.GroupBox2.AutoSize = True
        Me.GroupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox2.Controls.Add(Me.CBfnr)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Fltbonnr)
        Me.GroupBox2.Controls.Add(Me.Fltbonjr)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Fltwerf)
        Me.GroupBox2.Controls.Add(Me.Fltklant)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(804, 59)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(79, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "BonNr"
        '
        'Fltbonnr
        '
        Me.Fltbonnr.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Fltbonnr.Location = New System.Drawing.Point(127, 20)
        Me.Fltbonnr.Name = "Fltbonnr"
        Me.Fltbonnr.Size = New System.Drawing.Size(53, 20)
        Me.Fltbonnr.TabIndex = 31
        '
        'Fltbonjr
        '
        Me.Fltbonjr.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Fltbonjr.Location = New System.Drawing.Point(17, 19)
        Me.Fltbonjr.Maximum = New Decimal(New Integer() {2090, 0, 0, 0})
        Me.Fltbonjr.Minimum = New Decimal(New Integer() {1980, 0, 0, 0})
        Me.Fltbonjr.Name = "Fltbonjr"
        Me.Fltbonjr.Size = New System.Drawing.Size(56, 20)
        Me.Fltbonjr.TabIndex = 30
        Me.Fltbonjr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Fltbonjr.Value = New Decimal(New Integer() {2012, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(291, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "OmsBon"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(186, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Klant"
        '
        'Fltwerf
        '
        Me.Fltwerf.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Fltwerf.Location = New System.Drawing.Point(339, 19)
        Me.Fltwerf.Name = "Fltwerf"
        Me.Fltwerf.Size = New System.Drawing.Size(53, 20)
        Me.Fltwerf.TabIndex = 27
        '
        'Fltklant
        '
        Me.Fltklant.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Fltklant.Location = New System.Drawing.Point(219, 19)
        Me.Fltklant.Name = "Fltklant"
        Me.Fltklant.Size = New System.Drawing.Size(66, 20)
        Me.Fltklant.TabIndex = 26
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.DGREC, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 31)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1192, 532)
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'DGREC
        '
        Me.DGREC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGREC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGREC.Location = New System.Drawing.Point(3, 295)
        Me.DGREC.Name = "DGREC"
        Me.DGREC.Size = New System.Drawing.Size(1186, 234)
        Me.DGREC.TabIndex = 1
        '
        'CBfnr
        '
        Me.CBfnr.AutoSize = True
        Me.CBfnr.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CBfnr.Location = New System.Drawing.Point(410, 21)
        Me.CBfnr.Name = "CBfnr"
        Me.CBfnr.Size = New System.Drawing.Size(62, 17)
        Me.CBfnr.TabIndex = 33
        Me.CBfnr.Text = "Factuur"
        Me.CBfnr.UseVisualStyleBackColor = True
        '
        'GrpBONL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1192, 563)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "GrpBONL"
        Me.Text = "Groepsbeheer BonLijnen"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.DGBON, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Fltbonjr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.DGREC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents TSBexit As ToolStripButton
    Friend WithEvents ToolStripLabel4 As ToolStripLabel
    Friend WithEvents TSBsave As ToolStripButton
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CBpersoneel As CheckBox
    Friend WithEvents CBprijs As CheckBox
    Friend WithEvents CBdatum As CheckBox
    Friend WithEvents CBbtw As CheckBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents DGREC As DataGridView
    Friend WithEvents CMBbtw As ComboBox
    Friend WithEvents DTPdatum As DateTimePicker
    Friend WithEvents TBboneenhp As TextBox
    Friend WithEvents CMBper As ComboBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents DGBON As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Fltbonjr As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Fltwerf As TextBox
    Friend WithEvents Fltklant As TextBox
    Friend WithEvents TSBdelete As ToolStripButton
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents ToolStripLabel6 As ToolStripLabel
    Friend WithEvents ToolStripLabel5 As ToolStripLabel
    Friend WithEvents TSBverplaats As ToolStripButton
    Friend WithEvents CBcode As CheckBox
    Friend WithEvents ZoekCodeIM As TextBox
    Friend WithEvents lblCODEinfo As Label
    Friend WithEvents ZoekCode As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Fltbonnr As TextBox
    Friend WithEvents CMBoaanm As ComboBox
    Friend WithEvents CBoaanm As CheckBox
    Friend WithEvents CBfnr As CheckBox
End Class
