<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditCode
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditCode))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TSBexit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.TSBsave = New System.Windows.Forms.ToolStripButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GRPAlgemeen = New System.Windows.Forms.GroupBox()
        Me.ICMBaoms = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ICMBcodgp = New System.Windows.Forms.ComboBox()
        Me.TBomscode = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TBsort = New System.Windows.Forms.TextBox()
        Me.TBcode = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.GRPAdres = New System.Windows.Forms.GroupBox()
        Me.TBmaxstock = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TBminstock = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TBperc = New System.Windows.Forms.NumericUpDown()
        Me.TBstock = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBeenhp = New System.Windows.Forms.TextBox()
        Me.TBaankp = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GRPWerf = New System.Windows.Forms.GroupBox()
        Me.CBkmheffing = New System.Windows.Forms.CheckBox()
        Me.CBgratis = New System.Windows.Forms.CheckBox()
        Me.CBnotstock = New System.Windows.Forms.CheckBox()
        Me.CBbesteld = New System.Windows.Forms.CheckBox()
        Me.GRPContact = New System.Windows.Forms.GroupBox()
        Me.ICMBlev = New System.Windows.Forms.ComboBox()
        Me.ICMBoaanm = New System.Windows.Forms.ComboBox()
        Me.ICMBper = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBkemail = New System.Windows.Forms.TextBox()
        Me.TBplmagazijn = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BewerkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BewerkGroepToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NieuwToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GRPAlgemeen.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.GRPAdres.SuspendLayout()
        CType(Me.TBperc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GRPWerf.SuspendLayout()
        Me.GRPContact.SuspendLayout()
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
        Me.ToolStrip1.Size = New System.Drawing.Size(786, 31)
        Me.ToolStrip1.TabIndex = 2
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
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.GRPAlgemeen, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.GRPContact, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 31)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(786, 428)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'GRPAlgemeen
        '
        Me.GRPAlgemeen.AutoSize = True
        Me.GRPAlgemeen.BackColor = System.Drawing.SystemColors.Control
        Me.GRPAlgemeen.Controls.Add(Me.ICMBaoms)
        Me.GRPAlgemeen.Controls.Add(Me.Label2)
        Me.GRPAlgemeen.Controls.Add(Me.ICMBcodgp)
        Me.GRPAlgemeen.Controls.Add(Me.TBomscode)
        Me.GRPAlgemeen.Controls.Add(Me.Label14)
        Me.GRPAlgemeen.Controls.Add(Me.Label15)
        Me.GRPAlgemeen.Controls.Add(Me.TBsort)
        Me.GRPAlgemeen.Controls.Add(Me.TBcode)
        Me.GRPAlgemeen.Controls.Add(Me.Label4)
        Me.GRPAlgemeen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GRPAlgemeen.Location = New System.Drawing.Point(3, 3)
        Me.GRPAlgemeen.Name = "GRPAlgemeen"
        Me.GRPAlgemeen.Size = New System.Drawing.Size(780, 128)
        Me.GRPAlgemeen.TabIndex = 0
        Me.GRPAlgemeen.TabStop = False
        '
        'ICMBaoms
        '
        Me.ICMBaoms.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ICMBaoms.BackColor = System.Drawing.SystemColors.Window
        Me.ICMBaoms.FormattingEnabled = True
        Me.ICMBaoms.Location = New System.Drawing.Point(410, 88)
        Me.ICMBaoms.Name = "ICMBaoms"
        Me.ICMBaoms.Size = New System.Drawing.Size(92, 21)
        Me.ICMBaoms.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Groep"
        '
        'ICMBcodgp
        '
        Me.ICMBcodgp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ICMBcodgp.BackColor = System.Drawing.SystemColors.Window
        Me.ICMBcodgp.FormattingEnabled = True
        Me.ICMBcodgp.Location = New System.Drawing.Point(98, 10)
        Me.ICMBcodgp.Name = "ICMBcodgp"
        Me.ICMBcodgp.Size = New System.Drawing.Size(290, 21)
        Me.ICMBcodgp.TabIndex = 10
        '
        'TBomscode
        '
        Me.TBomscode.Location = New System.Drawing.Point(98, 89)
        Me.TBomscode.Name = "TBomscode"
        Me.TBomscode.Size = New System.Drawing.Size(290, 20)
        Me.TBomscode.TabIndex = 16
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(12, 93)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(67, 13)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "Omschrijving"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(12, 41)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(49, 13)
        Me.Label15.TabIndex = 27
        Me.Label15.Text = "Sortering"
        '
        'TBsort
        '
        Me.TBsort.Location = New System.Drawing.Point(98, 37)
        Me.TBsort.Name = "TBsort"
        Me.TBsort.Size = New System.Drawing.Size(290, 20)
        Me.TBsort.TabIndex = 12
        '
        'TBcode
        '
        Me.TBcode.Location = New System.Drawing.Point(98, 63)
        Me.TBcode.Name = "TBcode"
        Me.TBcode.Size = New System.Drawing.Size(290, 20)
        Me.TBcode.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Code"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoSize = True
        Me.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.Controls.Add(Me.GRPAdres, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.GRPWerf, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 137)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(780, 145)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'GRPAdres
        '
        Me.GRPAdres.AutoSize = True
        Me.GRPAdres.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GRPAdres.Controls.Add(Me.TBmaxstock)
        Me.GRPAdres.Controls.Add(Me.Label8)
        Me.GRPAdres.Controls.Add(Me.TBminstock)
        Me.GRPAdres.Controls.Add(Me.Label7)
        Me.GRPAdres.Controls.Add(Me.TBperc)
        Me.GRPAdres.Controls.Add(Me.TBstock)
        Me.GRPAdres.Controls.Add(Me.Label3)
        Me.GRPAdres.Controls.Add(Me.TBeenhp)
        Me.GRPAdres.Controls.Add(Me.TBaankp)
        Me.GRPAdres.Controls.Add(Me.Label6)
        Me.GRPAdres.Controls.Add(Me.Label5)
        Me.GRPAdres.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GRPAdres.Location = New System.Drawing.Point(3, 3)
        Me.GRPAdres.Name = "GRPAdres"
        Me.GRPAdres.Size = New System.Drawing.Size(640, 139)
        Me.GRPAdres.TabIndex = 0
        Me.GRPAdres.TabStop = False
        '
        'TBmaxstock
        '
        Me.TBmaxstock.Location = New System.Drawing.Point(222, 66)
        Me.TBmaxstock.Name = "TBmaxstock"
        Me.TBmaxstock.Size = New System.Drawing.Size(71, 20)
        Me.TBmaxstock.TabIndex = 38
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(170, 69)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 13)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Maximum"
        '
        'TBminstock
        '
        Me.TBminstock.Location = New System.Drawing.Point(95, 66)
        Me.TBminstock.Name = "TBminstock"
        Me.TBminstock.Size = New System.Drawing.Size(71, 20)
        Me.TBminstock.TabIndex = 36
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 69)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Minimum"
        '
        'TBperc
        '
        Me.TBperc.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TBperc.Location = New System.Drawing.Point(172, 12)
        Me.TBperc.Maximum = New Decimal(New Integer() {300, 0, 0, 0})
        Me.TBperc.Name = "TBperc"
        Me.TBperc.Size = New System.Drawing.Size(46, 20)
        Me.TBperc.TabIndex = 26
        Me.TBperc.TabStop = False
        Me.TBperc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TBstock
        '
        Me.TBstock.Location = New System.Drawing.Point(95, 40)
        Me.TBstock.Name = "TBstock"
        Me.TBstock.Size = New System.Drawing.Size(71, 20)
        Me.TBstock.TabIndex = 34
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Stock"
        '
        'TBeenhp
        '
        Me.TBeenhp.Location = New System.Drawing.Point(299, 12)
        Me.TBeenhp.Name = "TBeenhp"
        Me.TBeenhp.Size = New System.Drawing.Size(71, 20)
        Me.TBeenhp.TabIndex = 32
        '
        'TBaankp
        '
        Me.TBaankp.Location = New System.Drawing.Point(95, 11)
        Me.TBaankp.Name = "TBaankp"
        Me.TBaankp.Size = New System.Drawing.Size(71, 20)
        Me.TBaankp.TabIndex = 30
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(228, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Verkoopprijs"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Aankoopprijs"
        '
        'GRPWerf
        '
        Me.GRPWerf.AutoSize = True
        Me.GRPWerf.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GRPWerf.Controls.Add(Me.CBkmheffing)
        Me.GRPWerf.Controls.Add(Me.CBgratis)
        Me.GRPWerf.Controls.Add(Me.CBnotstock)
        Me.GRPWerf.Controls.Add(Me.CBbesteld)
        Me.GRPWerf.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GRPWerf.Location = New System.Drawing.Point(649, 3)
        Me.GRPWerf.Name = "GRPWerf"
        Me.GRPWerf.Size = New System.Drawing.Size(128, 139)
        Me.GRPWerf.TabIndex = 1
        Me.GRPWerf.TabStop = False
        '
        'CBkmheffing
        '
        Me.CBkmheffing.Location = New System.Drawing.Point(6, 96)
        Me.CBkmheffing.Name = "CBkmheffing"
        Me.CBkmheffing.Size = New System.Drawing.Size(116, 24)
        Me.CBkmheffing.TabIndex = 17
        Me.CBkmheffing.TabStop = False
        Me.CBkmheffing.Text = "Kilometerheffing"
        Me.CBkmheffing.UseVisualStyleBackColor = True
        '
        'CBgratis
        '
        Me.CBgratis.Location = New System.Drawing.Point(6, 66)
        Me.CBgratis.Name = "CBgratis"
        Me.CBgratis.Size = New System.Drawing.Size(83, 23)
        Me.CBgratis.TabIndex = 16
        Me.CBgratis.TabStop = False
        Me.CBgratis.Text = "Gratis      "
        Me.CBgratis.UseVisualStyleBackColor = True
        '
        'CBnotstock
        '
        Me.CBnotstock.Location = New System.Drawing.Point(6, 37)
        Me.CBnotstock.Name = "CBnotstock"
        Me.CBnotstock.Size = New System.Drawing.Size(116, 23)
        Me.CBnotstock.TabIndex = 15
        Me.CBnotstock.TabStop = False
        Me.CBnotstock.Text = "Niet in Stock "
        Me.CBnotstock.UseVisualStyleBackColor = True
        '
        'CBbesteld
        '
        Me.CBbesteld.Location = New System.Drawing.Point(6, 8)
        Me.CBbesteld.Name = "CBbesteld"
        Me.CBbesteld.Size = New System.Drawing.Size(116, 23)
        Me.CBbesteld.TabIndex = 14
        Me.CBbesteld.TabStop = False
        Me.CBbesteld.Text = "In Bestelling  "
        Me.CBbesteld.UseVisualStyleBackColor = True
        '
        'GRPContact
        '
        Me.GRPContact.AutoSize = True
        Me.GRPContact.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GRPContact.Controls.Add(Me.ICMBlev)
        Me.GRPContact.Controls.Add(Me.ICMBoaanm)
        Me.GRPContact.Controls.Add(Me.ICMBper)
        Me.GRPContact.Controls.Add(Me.Label1)
        Me.GRPContact.Controls.Add(Me.TBkemail)
        Me.GRPContact.Controls.Add(Me.TBplmagazijn)
        Me.GRPContact.Controls.Add(Me.Label13)
        Me.GRPContact.Controls.Add(Me.Label12)
        Me.GRPContact.Controls.Add(Me.Label10)
        Me.GRPContact.Controls.Add(Me.Label9)
        Me.GRPContact.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GRPContact.Location = New System.Drawing.Point(3, 288)
        Me.GRPContact.Name = "GRPContact"
        Me.GRPContact.Size = New System.Drawing.Size(780, 137)
        Me.GRPContact.TabIndex = 2
        Me.GRPContact.TabStop = False
        '
        'ICMBlev
        '
        Me.ICMBlev.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ICMBlev.FormattingEnabled = True
        Me.ICMBlev.Location = New System.Drawing.Point(97, 16)
        Me.ICMBlev.Name = "ICMBlev"
        Me.ICMBlev.Size = New System.Drawing.Size(291, 21)
        Me.ICMBlev.TabIndex = 63
        Me.ICMBlev.TabStop = False
        '
        'ICMBoaanm
        '
        Me.ICMBoaanm.FormattingEnabled = True
        Me.ICMBoaanm.Location = New System.Drawing.Point(97, 91)
        Me.ICMBoaanm.Name = "ICMBoaanm"
        Me.ICMBoaanm.Size = New System.Drawing.Size(291, 21)
        Me.ICMBoaanm.TabIndex = 31
        Me.ICMBoaanm.TabStop = False
        '
        'ICMBper
        '
        Me.ICMBper.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ICMBper.FormattingEnabled = True
        Me.ICMBper.Location = New System.Drawing.Point(97, 65)
        Me.ICMBper.Name = "ICMBper"
        Me.ICMBper.Size = New System.Drawing.Size(291, 21)
        Me.ICMBper.TabIndex = 30
        Me.ICMBper.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Leverancier"
        '
        'TBkemail
        '
        Me.TBkemail.Location = New System.Drawing.Point(432, -89)
        Me.TBkemail.Name = "TBkemail"
        Me.TBkemail.Size = New System.Drawing.Size(242, 20)
        Me.TBkemail.TabIndex = 24
        '
        'TBplmagazijn
        '
        Me.TBplmagazijn.Location = New System.Drawing.Point(98, 40)
        Me.TBplmagazijn.Name = "TBplmagazijn"
        Me.TBplmagazijn.Size = New System.Drawing.Size(290, 20)
        Me.TBplmagazijn.TabIndex = 62
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(12, 93)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(83, 13)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "Onderaannemer"
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
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 68)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 13)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Personeel"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 45)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Plaats"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BewerkToolStripMenuItem, Me.BewerkGroepToolStripMenuItem, Me.NieuwToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(181, 92)
        '
        'BewerkToolStripMenuItem
        '
        Me.BewerkToolStripMenuItem.Enabled = False
        Me.BewerkToolStripMenuItem.Image = Global.Bon2017.My.Resources.Resources.itemedit
        Me.BewerkToolStripMenuItem.Name = "BewerkToolStripMenuItem"
        Me.BewerkToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BewerkToolStripMenuItem.Text = "Bewerk:"
        '
        'BewerkGroepToolStripMenuItem
        '
        Me.BewerkGroepToolStripMenuItem.Name = "BewerkGroepToolStripMenuItem"
        Me.BewerkGroepToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BewerkGroepToolStripMenuItem.Text = "Wijzig Groep"
        '
        'NieuwToolStripMenuItem
        '
        Me.NieuwToolStripMenuItem.Name = "NieuwToolStripMenuItem"
        Me.NieuwToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.NieuwToolStripMenuItem.Text = "Nieuw Groep"
        '
        'EditCode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(786, 459)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ControlBox = False
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EditCode"
        Me.Text = "Code: bewerken"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.GRPAlgemeen.ResumeLayout(False)
        Me.GRPAlgemeen.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.GRPAdres.ResumeLayout(False)
        Me.GRPAdres.PerformLayout()
        CType(Me.TBperc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GRPWerf.ResumeLayout(False)
        Me.GRPContact.ResumeLayout(False)
        Me.GRPContact.PerformLayout()
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
    Friend WithEvents TBeenhp As TextBox
    Friend WithEvents TBaankp As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GRPWerf As GroupBox
    Friend WithEvents GRPContact As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TBkemail As TextBox
    Friend WithEvents TBplmagazijn As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents GRPAlgemeen As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ICMBcodgp As ComboBox
    Friend WithEvents TBomscode As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents TBsort As TextBox
    Friend WithEvents TBcode As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CBgratis As CheckBox
    Friend WithEvents CBnotstock As CheckBox
    Friend WithEvents CBbesteld As CheckBox
    Friend WithEvents ICMBper As ComboBox
    Friend WithEvents ICMBoaanm As ComboBox
    Friend WithEvents TBstock As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TBmaxstock As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TBminstock As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TBperc As NumericUpDown
    Friend WithEvents ICMBaoms As ComboBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents CBkmheffing As CheckBox
    Friend WithEvents ICMBlev As ComboBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents BewerkToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BewerkGroepToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NieuwToolStripMenuItem As ToolStripMenuItem
End Class
