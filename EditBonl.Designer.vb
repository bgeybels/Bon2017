<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Editbonl
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Editbonl))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TSBexit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.TSBsave = New System.Windows.Forms.ToolStripButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.GRPAdres = New System.Windows.Forms.GroupBox()
        Me.CMBlev = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TBlevnm = New System.Windows.Forms.TextBox()
        Me.Lblomstijd = New System.Windows.Forms.Label()
        Me.CMBper = New System.Windows.Forms.ComboBox()
        Me.CMBoaanm = New System.Windows.Forms.ComboBox()
        Me.TBpernm = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TBoaanmnm = New System.Windows.Forms.TextBox()
        Me.BTNtijd = New System.Windows.Forms.Button()
        Me.LBLaoms = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TBaantal = New System.Windows.Forms.TextBox()
        Me.TBboneenhp = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GRPWerf = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TBbwadres = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBbwstraat = New System.Windows.Forms.TextBox()
        Me.CBselect = New System.Windows.Forms.CheckBox()
        Me.GRPContact = New System.Windows.Forms.GroupBox()
        Me.TBmemo = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ZoekCodeIM = New System.Windows.Forms.TextBox()
        Me.CMBbtw = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBextnr = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBvolgorde = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblCODEinfo = New System.Windows.Forms.Label()
        Me.LBLbonlinfo = New System.Windows.Forms.Label()
        Me.ZoekCode = New System.Windows.Forms.Button()
        Me.DTPdatum = New System.Windows.Forms.DateTimePicker()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BewerkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BewerkCodeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BTWToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BewerkPersoneelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OnderaannemerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LeverancierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.GRPAdres.SuspendLayout()
        Me.GRPWerf.SuspendLayout()
        Me.GRPContact.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSBexit, Me.ToolStripLabel4, Me.TSBsave})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(948, 31)
        Me.ToolStrip1.TabIndex = 4
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
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.GRPContact, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 31)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(948, 433)
        Me.TableLayoutPanel1.TabIndex = 5
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoSize = True
        Me.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.Controls.Add(Me.GRPAdres, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.GRPWerf, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 170)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(942, 164)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'GRPAdres
        '
        Me.GRPAdres.AutoSize = True
        Me.GRPAdres.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GRPAdres.Controls.Add(Me.CMBlev)
        Me.GRPAdres.Controls.Add(Me.Label7)
        Me.GRPAdres.Controls.Add(Me.TBlevnm)
        Me.GRPAdres.Controls.Add(Me.Lblomstijd)
        Me.GRPAdres.Controls.Add(Me.CMBper)
        Me.GRPAdres.Controls.Add(Me.CMBoaanm)
        Me.GRPAdres.Controls.Add(Me.TBpernm)
        Me.GRPAdres.Controls.Add(Me.Label16)
        Me.GRPAdres.Controls.Add(Me.Label17)
        Me.GRPAdres.Controls.Add(Me.TBoaanmnm)
        Me.GRPAdres.Controls.Add(Me.BTNtijd)
        Me.GRPAdres.Controls.Add(Me.LBLaoms)
        Me.GRPAdres.Controls.Add(Me.Label8)
        Me.GRPAdres.Controls.Add(Me.TBaantal)
        Me.GRPAdres.Controls.Add(Me.TBboneenhp)
        Me.GRPAdres.Controls.Add(Me.Label13)
        Me.GRPAdres.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GRPAdres.Location = New System.Drawing.Point(3, 3)
        Me.GRPAdres.Name = "GRPAdres"
        Me.GRPAdres.Size = New System.Drawing.Size(490, 158)
        Me.GRPAdres.TabIndex = 0
        Me.GRPAdres.TabStop = False
        '
        'CMBlev
        '
        Me.CMBlev.FormattingEnabled = True
        Me.CMBlev.Location = New System.Drawing.Point(284, 118)
        Me.CMBlev.Name = "CMBlev"
        Me.CMBlev.Size = New System.Drawing.Size(200, 21)
        Me.CMBlev.TabIndex = 83
        Me.CMBlev.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 122)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 85
        Me.Label7.Text = "Leverancier"
        '
        'TBlevnm
        '
        Me.TBlevnm.Location = New System.Drawing.Point(81, 118)
        Me.TBlevnm.MaxLength = 100
        Me.TBlevnm.Name = "TBlevnm"
        Me.TBlevnm.Size = New System.Drawing.Size(197, 20)
        Me.TBlevnm.TabIndex = 84
        '
        'Lblomstijd
        '
        Me.Lblomstijd.AutoSize = True
        Me.Lblomstijd.Location = New System.Drawing.Point(281, 41)
        Me.Lblomstijd.Name = "Lblomstijd"
        Me.Lblomstijd.Size = New System.Drawing.Size(41, 13)
        Me.Lblomstijd.TabIndex = 82
        Me.Lblomstijd.Text = "Omstijd"
        '
        'CMBper
        '
        Me.CMBper.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CMBper.FormattingEnabled = True
        Me.CMBper.Location = New System.Drawing.Point(284, 65)
        Me.CMBper.Name = "CMBper"
        Me.CMBper.Size = New System.Drawing.Size(200, 21)
        Me.CMBper.TabIndex = 16
        Me.CMBper.TabStop = False
        '
        'CMBoaanm
        '
        Me.CMBoaanm.FormattingEnabled = True
        Me.CMBoaanm.Location = New System.Drawing.Point(284, 92)
        Me.CMBoaanm.Name = "CMBoaanm"
        Me.CMBoaanm.Size = New System.Drawing.Size(200, 21)
        Me.CMBoaanm.TabIndex = 17
        Me.CMBoaanm.TabStop = False
        '
        'TBpernm
        '
        Me.TBpernm.Location = New System.Drawing.Point(81, 66)
        Me.TBpernm.MaxLength = 100
        Me.TBpernm.Name = "TBpernm"
        Me.TBpernm.Size = New System.Drawing.Size(197, 20)
        Me.TBpernm.TabIndex = 20
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 70)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(54, 13)
        Me.Label16.TabIndex = 79
        Me.Label16.Text = "Personeel"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 96)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(72, 13)
        Me.Label17.TabIndex = 81
        Me.Label17.Text = "OnderAannm."
        '
        'TBoaanmnm
        '
        Me.TBoaanmnm.Location = New System.Drawing.Point(81, 92)
        Me.TBoaanmnm.MaxLength = 100
        Me.TBoaanmnm.Name = "TBoaanmnm"
        Me.TBoaanmnm.Size = New System.Drawing.Size(197, 20)
        Me.TBoaanmnm.TabIndex = 21
        '
        'BTNtijd
        '
        Me.BTNtijd.Location = New System.Drawing.Point(340, 13)
        Me.BTNtijd.Name = "BTNtijd"
        Me.BTNtijd.Size = New System.Drawing.Size(55, 23)
        Me.BTNtijd.TabIndex = 75
        Me.BTNtijd.TabStop = False
        Me.BTNtijd.Text = "Tijd"
        Me.BTNtijd.UseVisualStyleBackColor = True
        '
        'LBLaoms
        '
        Me.LBLaoms.AutoSize = True
        Me.LBLaoms.Location = New System.Drawing.Point(141, 18)
        Me.LBLaoms.Name = "LBLaoms"
        Me.LBLaoms.Size = New System.Drawing.Size(52, 13)
        Me.LBLaoms.TabIndex = 74
        Me.LBLaoms.Text = "VOLUME"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 13)
        Me.Label8.TabIndex = 73
        Me.Label8.Text = "Aantal"
        '
        'TBaantal
        '
        Me.TBaantal.Location = New System.Drawing.Point(82, 14)
        Me.TBaantal.Name = "TBaantal"
        Me.TBaantal.Size = New System.Drawing.Size(55, 20)
        Me.TBaantal.TabIndex = 14
        '
        'TBboneenhp
        '
        Me.TBboneenhp.Location = New System.Drawing.Point(279, 14)
        Me.TBboneenhp.Name = "TBboneenhp"
        Me.TBboneenhp.Size = New System.Drawing.Size(56, 20)
        Me.TBboneenhp.TabIndex = 15
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(252, 18)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(21, 13)
        Me.Label13.TabIndex = 70
        Me.Label13.Text = "VP"
        '
        'GRPWerf
        '
        Me.GRPWerf.AutoSize = True
        Me.GRPWerf.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GRPWerf.Controls.Add(Me.Label5)
        Me.GRPWerf.Controls.Add(Me.TBbwadres)
        Me.GRPWerf.Controls.Add(Me.Label3)
        Me.GRPWerf.Controls.Add(Me.TBbwstraat)
        Me.GRPWerf.Controls.Add(Me.CBselect)
        Me.GRPWerf.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GRPWerf.Location = New System.Drawing.Point(499, 3)
        Me.GRPWerf.Name = "GRPWerf"
        Me.GRPWerf.Size = New System.Drawing.Size(440, 158)
        Me.GRPWerf.TabIndex = 1
        Me.GRPWerf.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 82
        Me.Label5.Text = "Werfadres"
        '
        'TBbwadres
        '
        Me.TBbwadres.Location = New System.Drawing.Point(91, 65)
        Me.TBbwadres.MaxLength = 50
        Me.TBbwadres.Name = "TBbwadres"
        Me.TBbwadres.Size = New System.Drawing.Size(253, 20)
        Me.TBbwadres.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 80
        Me.Label3.Text = "Werfstraat"
        '
        'TBbwstraat
        '
        Me.TBbwstraat.Location = New System.Drawing.Point(91, 39)
        Me.TBbwstraat.MaxLength = 50
        Me.TBbwstraat.Name = "TBbwstraat"
        Me.TBbwstraat.Size = New System.Drawing.Size(253, 20)
        Me.TBbwstraat.TabIndex = 30
        '
        'CBselect
        '
        Me.CBselect.AutoSize = True
        Me.CBselect.Location = New System.Drawing.Point(91, 16)
        Me.CBselect.Name = "CBselect"
        Me.CBselect.Size = New System.Drawing.Size(71, 17)
        Me.CBselect.TabIndex = 58
        Me.CBselect.TabStop = False
        Me.CBselect.Text = "Selecteer"
        Me.CBselect.UseVisualStyleBackColor = True
        '
        'GRPContact
        '
        Me.GRPContact.AutoSize = True
        Me.GRPContact.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GRPContact.Controls.Add(Me.TBmemo)
        Me.GRPContact.Controls.Add(Me.Label12)
        Me.GRPContact.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GRPContact.Location = New System.Drawing.Point(3, 340)
        Me.GRPContact.Name = "GRPContact"
        Me.GRPContact.Size = New System.Drawing.Size(942, 90)
        Me.GRPContact.TabIndex = 2
        Me.GRPContact.TabStop = False
        '
        'TBmemo
        '
        Me.TBmemo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TBmemo.Location = New System.Drawing.Point(3, 16)
        Me.TBmemo.Multiline = True
        Me.TBmemo.Name = "TBmemo"
        Me.TBmemo.Size = New System.Drawing.Size(936, 71)
        Me.TBmemo.TabIndex = 44
        Me.TBmemo.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(368, -86)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(33, 13)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "EMail"
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox1.Controls.Add(Me.ZoekCodeIM)
        Me.GroupBox1.Controls.Add(Me.CMBbtw)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TBextnr)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TBvolgorde)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lblCODEinfo)
        Me.GroupBox1.Controls.Add(Me.LBLbonlinfo)
        Me.GroupBox1.Controls.Add(Me.ZoekCode)
        Me.GroupBox1.Controls.Add(Me.DTPdatum)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(942, 161)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'ZoekCodeIM
        '
        Me.ZoekCodeIM.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ZoekCodeIM.Location = New System.Drawing.Point(248, 48)
        Me.ZoekCodeIM.Name = "ZoekCodeIM"
        Me.ZoekCodeIM.Size = New System.Drawing.Size(46, 20)
        Me.ZoekCodeIM.TabIndex = 81
        Me.ZoekCodeIM.TabStop = False
        '
        'CMBbtw
        '
        Me.CMBbtw.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CMBbtw.FormattingEnabled = True
        Me.CMBbtw.Location = New System.Drawing.Point(84, 96)
        Me.CMBbtw.Name = "CMBbtw"
        Me.CMBbtw.Size = New System.Drawing.Size(253, 21)
        Me.CMBbtw.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 100)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 80
        Me.Label6.Text = "BTW"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 74
        Me.Label2.Text = "ENr"
        '
        'TBextnr
        '
        Me.TBextnr.Location = New System.Drawing.Point(84, 122)
        Me.TBextnr.MaxLength = 10
        Me.TBextnr.Name = "TBextnr"
        Me.TBextnr.Size = New System.Drawing.Size(107, 20)
        Me.TBextnr.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "Volgorde"
        '
        'TBvolgorde
        '
        Me.TBvolgorde.Location = New System.Drawing.Point(84, 40)
        Me.TBvolgorde.Name = "TBvolgorde"
        Me.TBvolgorde.Size = New System.Drawing.Size(38, 20)
        Me.TBvolgorde.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "Datum"
        '
        'lblCODEinfo
        '
        Me.lblCODEinfo.AutoSize = True
        Me.lblCODEinfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCODEinfo.ForeColor = System.Drawing.Color.Gray
        Me.lblCODEinfo.Location = New System.Drawing.Point(350, 46)
        Me.lblCODEinfo.Name = "lblCODEinfo"
        Me.lblCODEinfo.Size = New System.Drawing.Size(137, 20)
        Me.lblCODEinfo.TabIndex = 59
        Me.lblCODEinfo.Text = "Code-informatie"
        '
        'LBLbonlinfo
        '
        Me.LBLbonlinfo.AutoSize = True
        Me.LBLbonlinfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLbonlinfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LBLbonlinfo.Location = New System.Drawing.Point(2, 14)
        Me.LBLbonlinfo.Name = "LBLbonlinfo"
        Me.LBLbonlinfo.Size = New System.Drawing.Size(95, 20)
        Me.LBLbonlinfo.TabIndex = 56
        Me.LBLbonlinfo.Text = "BonlijnInfo"
        '
        'ZoekCode
        '
        Me.ZoekCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ZoekCode.Image = Global.Bon2017.My.Resources.Resources.search
        Me.ZoekCode.Location = New System.Drawing.Point(300, 45)
        Me.ZoekCode.Name = "ZoekCode"
        Me.ZoekCode.Size = New System.Drawing.Size(36, 35)
        Me.ZoekCode.TabIndex = 54
        Me.ZoekCode.TabStop = False
        Me.ToolTip1.SetToolTip(Me.ZoekCode, "Zoek naar Code")
        Me.ZoekCode.UseVisualStyleBackColor = False
        '
        'DTPdatum
        '
        Me.DTPdatum.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPdatum.Location = New System.Drawing.Point(84, 68)
        Me.DTPdatum.Name = "DTPdatum"
        Me.DTPdatum.Size = New System.Drawing.Size(107, 20)
        Me.DTPdatum.TabIndex = 11
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BewerkToolStripMenuItem, Me.BewerkCodeToolStripMenuItem, Me.BTWToolStripMenuItem, Me.BewerkPersoneelToolStripMenuItem, Me.OnderaannemerToolStripMenuItem, Me.LeverancierToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(181, 158)
        '
        'BewerkToolStripMenuItem
        '
        Me.BewerkToolStripMenuItem.Enabled = False
        Me.BewerkToolStripMenuItem.Image = Global.Bon2017.My.Resources.Resources.itemedit
        Me.BewerkToolStripMenuItem.Name = "BewerkToolStripMenuItem"
        Me.BewerkToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BewerkToolStripMenuItem.Text = "Bewerk:"
        '
        'BewerkCodeToolStripMenuItem
        '
        Me.BewerkCodeToolStripMenuItem.Name = "BewerkCodeToolStripMenuItem"
        Me.BewerkCodeToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BewerkCodeToolStripMenuItem.Text = "Code"
        '
        'BTWToolStripMenuItem
        '
        Me.BTWToolStripMenuItem.Name = "BTWToolStripMenuItem"
        Me.BTWToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BTWToolStripMenuItem.Text = "BTW"
        '
        'BewerkPersoneelToolStripMenuItem
        '
        Me.BewerkPersoneelToolStripMenuItem.Name = "BewerkPersoneelToolStripMenuItem"
        Me.BewerkPersoneelToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BewerkPersoneelToolStripMenuItem.Text = "Personeel"
        '
        'OnderaannemerToolStripMenuItem
        '
        Me.OnderaannemerToolStripMenuItem.Name = "OnderaannemerToolStripMenuItem"
        Me.OnderaannemerToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.OnderaannemerToolStripMenuItem.Text = "Onderaannemer"
        '
        'LeverancierToolStripMenuItem
        '
        Me.LeverancierToolStripMenuItem.Name = "LeverancierToolStripMenuItem"
        Me.LeverancierToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.LeverancierToolStripMenuItem.Text = "Leverancier"
        '
        'Editbonl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(948, 464)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "Editbonl"
        Me.Text = "BonLijn: Bewerken"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.GRPAdres.ResumeLayout(False)
        Me.GRPAdres.PerformLayout()
        Me.GRPWerf.ResumeLayout(False)
        Me.GRPWerf.PerformLayout()
        Me.GRPContact.ResumeLayout(False)
        Me.GRPContact.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents TSBexit As ToolStripButton
    Friend WithEvents ToolStripLabel4 As ToolStripLabel
    Friend WithEvents TSBsave As ToolStripButton
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents GRPAdres As GroupBox
    Friend WithEvents TBmemo As TextBox
    Friend WithEvents GRPWerf As GroupBox
    Friend WithEvents CBselect As CheckBox
    Friend WithEvents GRPContact As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblCODEinfo As Label
    Friend WithEvents LBLbonlinfo As Label
    Friend WithEvents ZoekCode As Button
    Friend WithEvents DTPdatum As DateTimePicker
    Friend WithEvents Label13 As Label
    Friend WithEvents TBboneenhp As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TBextnr As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TBvolgorde As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TBaantal As TextBox
    Friend WithEvents LBLaoms As Label
    Friend WithEvents BTNtijd As Button
    Friend WithEvents CMBper As ComboBox
    Friend WithEvents CMBoaanm As ComboBox
    Friend WithEvents TBpernm As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents TBoaanmnm As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TBbwadres As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TBbwstraat As TextBox
    Friend WithEvents CMBbtw As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Lblomstijd As Label
    Friend WithEvents ZoekCodeIM As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents BewerkCodeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BewerkPersoneelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BewerkToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BTWToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OnderaannemerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CMBlev As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TBlevnm As TextBox
    Friend WithEvents LeverancierToolStripMenuItem As ToolStripMenuItem
End Class
