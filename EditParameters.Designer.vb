<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditParameters
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditParameters))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TSBexit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.TSBsave = New System.Windows.Forms.ToolStripButton()
        Me.TBreset = New System.Windows.Forms.ToolStripButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TPKleuren = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BTNmemo = New System.Windows.Forms.Button()
        Me.TBGRIDcellmemo = New System.Windows.Forms.TextBox()
        Me.BTNgratis = New System.Windows.Forms.Button()
        Me.TBGRIDcellgratis = New System.Windows.Forms.TextBox()
        Me.BTNGridSelectieAchtergrond = New System.Windows.Forms.Button()
        Me.BTNGridSelectieVoorgrond = New System.Windows.Forms.Button()
        Me.TBGridSelectieAchtergrond = New System.Windows.Forms.TextBox()
        Me.TBGridSelectieVoorgrond = New System.Windows.Forms.TextBox()
        Me.BTNcodenietgebruikt = New System.Windows.Forms.Button()
        Me.BTNAchtergrondgeenfout = New System.Windows.Forms.Button()
        Me.BTNAchtergrondbijFout = New System.Windows.Forms.Button()
        Me.BTNGridOnEvenVoorgrond = New System.Windows.Forms.Button()
        Me.BTNGridEvenVoorgrond = New System.Windows.Forms.Button()
        Me.BTNGridOnEvenAchtergrond = New System.Windows.Forms.Button()
        Me.BTNGridEvenAchtergrond = New System.Windows.Forms.Button()
        Me.TBGRIDcellnotused = New System.Windows.Forms.TextBox()
        Me.TBDISPtextboxbackcolor = New System.Windows.Forms.TextBox()
        Me.TBDISPtextboxerror = New System.Windows.Forms.TextBox()
        Me.TBGRIDforecolorodd = New System.Windows.Forms.TextBox()
        Me.TBGRIDforecoloreven = New System.Windows.Forms.TextBox()
        Me.TBGRIDrowsodd = New System.Windows.Forms.TextBox()
        Me.TBGRIDrowseven = New System.Windows.Forms.TextBox()
        Me.TPStock = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BTNresetostock = New System.Windows.Forms.Button()
        Me.BTNresetstock = New System.Windows.Forms.Button()
        Me.CBSTOCKupdateclosed = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TBSTOCKstandaardtrans = New System.Windows.Forms.TextBox()
        Me.TPFakt = New System.Windows.Forms.TabPage()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TBfirstfnr = New System.Windows.Forms.TextBox()
        Me.TPBon = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBTotalsAllowed = New System.Windows.Forms.TextBox()
        Me.TBjaarcopy = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TPCode = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CMBcodgp = New System.Windows.Forms.ComboBox()
        Me.TPlocks = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupFilter = New System.Windows.Forms.GroupBox()
        Me.BTN_DropLocks = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.FltUnaam = New System.Windows.Forms.TextBox()
        Me.FltType = New System.Windows.Forms.TextBox()
        Me.DGREC = New System.Windows.Forms.DataGridView()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TPKleuren.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TPStock.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TPFakt.SuspendLayout()
        Me.TPBon.SuspendLayout()
        CType(Me.TBjaarcopy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TPCode.SuspendLayout()
        Me.TPlocks.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.GroupFilter.SuspendLayout()
        CType(Me.DGREC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSBexit, Me.ToolStripLabel4, Me.TSBsave, Me.TBreset})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(719, 31)
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
        'TBreset
        '
        Me.TBreset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TBreset.Image = Global.Bon2017.My.Resources.Resources.redo
        Me.TBreset.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TBreset.Name = "TBreset"
        Me.TBreset.Size = New System.Drawing.Size(28, 28)
        Me.TBreset.Text = "RESET"
        Me.TBreset.ToolTipText = "RESET de waardes"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TabControl1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 31)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(719, 412)
        Me.TableLayoutPanel1.TabIndex = 5
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TPKleuren)
        Me.TabControl1.Controls.Add(Me.TPStock)
        Me.TabControl1.Controls.Add(Me.TPFakt)
        Me.TabControl1.Controls.Add(Me.TPBon)
        Me.TabControl1.Controls.Add(Me.TPCode)
        Me.TabControl1.Controls.Add(Me.TPlocks)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(3, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(713, 406)
        Me.TabControl1.TabIndex = 0
        '
        'TPKleuren
        '
        Me.TPKleuren.Controls.Add(Me.GroupBox1)
        Me.TPKleuren.Location = New System.Drawing.Point(4, 22)
        Me.TPKleuren.Name = "TPKleuren"
        Me.TPKleuren.Padding = New System.Windows.Forms.Padding(3)
        Me.TPKleuren.Size = New System.Drawing.Size(705, 380)
        Me.TPKleuren.TabIndex = 1
        Me.TPKleuren.Text = "Kleuren"
        Me.TPKleuren.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BTNmemo)
        Me.GroupBox1.Controls.Add(Me.TBGRIDcellmemo)
        Me.GroupBox1.Controls.Add(Me.BTNgratis)
        Me.GroupBox1.Controls.Add(Me.TBGRIDcellgratis)
        Me.GroupBox1.Controls.Add(Me.BTNGridSelectieAchtergrond)
        Me.GroupBox1.Controls.Add(Me.BTNGridSelectieVoorgrond)
        Me.GroupBox1.Controls.Add(Me.TBGridSelectieAchtergrond)
        Me.GroupBox1.Controls.Add(Me.TBGridSelectieVoorgrond)
        Me.GroupBox1.Controls.Add(Me.BTNcodenietgebruikt)
        Me.GroupBox1.Controls.Add(Me.BTNAchtergrondgeenfout)
        Me.GroupBox1.Controls.Add(Me.BTNAchtergrondbijFout)
        Me.GroupBox1.Controls.Add(Me.BTNGridOnEvenVoorgrond)
        Me.GroupBox1.Controls.Add(Me.BTNGridEvenVoorgrond)
        Me.GroupBox1.Controls.Add(Me.BTNGridOnEvenAchtergrond)
        Me.GroupBox1.Controls.Add(Me.BTNGridEvenAchtergrond)
        Me.GroupBox1.Controls.Add(Me.TBGRIDcellnotused)
        Me.GroupBox1.Controls.Add(Me.TBDISPtextboxbackcolor)
        Me.GroupBox1.Controls.Add(Me.TBDISPtextboxerror)
        Me.GroupBox1.Controls.Add(Me.TBGRIDforecolorodd)
        Me.GroupBox1.Controls.Add(Me.TBGRIDforecoloreven)
        Me.GroupBox1.Controls.Add(Me.TBGRIDrowsodd)
        Me.GroupBox1.Controls.Add(Me.TBGRIDrowseven)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(699, 374)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'BTNmemo
        '
        Me.BTNmemo.Location = New System.Drawing.Point(13, 329)
        Me.BTNmemo.Name = "BTNmemo"
        Me.BTNmemo.Size = New System.Drawing.Size(151, 20)
        Me.BTNmemo.TabIndex = 30
        Me.BTNmemo.Text = "Cel Memo"
        Me.BTNmemo.UseVisualStyleBackColor = True
        '
        'TBGRIDcellmemo
        '
        Me.TBGRIDcellmemo.BackColor = System.Drawing.SystemColors.Window
        Me.TBGRIDcellmemo.Location = New System.Drawing.Point(175, 329)
        Me.TBGRIDcellmemo.Name = "TBGRIDcellmemo"
        Me.TBGRIDcellmemo.Size = New System.Drawing.Size(152, 20)
        Me.TBGRIDcellmemo.TabIndex = 29
        '
        'BTNgratis
        '
        Me.BTNgratis.Location = New System.Drawing.Point(13, 303)
        Me.BTNgratis.Name = "BTNgratis"
        Me.BTNgratis.Size = New System.Drawing.Size(151, 20)
        Me.BTNgratis.TabIndex = 28
        Me.BTNgratis.Text = "Cel Gratis"
        Me.BTNgratis.UseVisualStyleBackColor = True
        '
        'TBGRIDcellgratis
        '
        Me.TBGRIDcellgratis.BackColor = System.Drawing.SystemColors.Window
        Me.TBGRIDcellgratis.Location = New System.Drawing.Point(175, 303)
        Me.TBGRIDcellgratis.Name = "TBGRIDcellgratis"
        Me.TBGRIDcellgratis.Size = New System.Drawing.Size(152, 20)
        Me.TBGRIDcellgratis.TabIndex = 27
        '
        'BTNGridSelectieAchtergrond
        '
        Me.BTNGridSelectieAchtergrond.Location = New System.Drawing.Point(13, 175)
        Me.BTNGridSelectieAchtergrond.Name = "BTNGridSelectieAchtergrond"
        Me.BTNGridSelectieAchtergrond.Size = New System.Drawing.Size(151, 20)
        Me.BTNGridSelectieAchtergrond.TabIndex = 26
        Me.BTNGridSelectieAchtergrond.Text = "GridSelectieAchtergrond"
        Me.BTNGridSelectieAchtergrond.UseVisualStyleBackColor = True
        '
        'BTNGridSelectieVoorgrond
        '
        Me.BTNGridSelectieVoorgrond.Location = New System.Drawing.Point(13, 149)
        Me.BTNGridSelectieVoorgrond.Name = "BTNGridSelectieVoorgrond"
        Me.BTNGridSelectieVoorgrond.Size = New System.Drawing.Size(151, 20)
        Me.BTNGridSelectieVoorgrond.TabIndex = 25
        Me.BTNGridSelectieVoorgrond.Text = "GridSelectieVoorgrond"
        Me.BTNGridSelectieVoorgrond.UseVisualStyleBackColor = True
        '
        'TBGridSelectieAchtergrond
        '
        Me.TBGridSelectieAchtergrond.BackColor = System.Drawing.SystemColors.Window
        Me.TBGridSelectieAchtergrond.Location = New System.Drawing.Point(175, 175)
        Me.TBGridSelectieAchtergrond.Name = "TBGridSelectieAchtergrond"
        Me.TBGridSelectieAchtergrond.Size = New System.Drawing.Size(152, 20)
        Me.TBGridSelectieAchtergrond.TabIndex = 24
        '
        'TBGridSelectieVoorgrond
        '
        Me.TBGridSelectieVoorgrond.BackColor = System.Drawing.SystemColors.Window
        Me.TBGridSelectieVoorgrond.Location = New System.Drawing.Point(175, 149)
        Me.TBGridSelectieVoorgrond.Name = "TBGridSelectieVoorgrond"
        Me.TBGridSelectieVoorgrond.Size = New System.Drawing.Size(152, 20)
        Me.TBGridSelectieVoorgrond.TabIndex = 23
        '
        'BTNcodenietgebruikt
        '
        Me.BTNcodenietgebruikt.Location = New System.Drawing.Point(13, 277)
        Me.BTNcodenietgebruikt.Name = "BTNcodenietgebruikt"
        Me.BTNcodenietgebruikt.Size = New System.Drawing.Size(151, 20)
        Me.BTNcodenietgebruikt.TabIndex = 22
        Me.BTNcodenietgebruikt.Text = "Cel Code niet gebruikt"
        Me.BTNcodenietgebruikt.UseVisualStyleBackColor = True
        '
        'BTNAchtergrondgeenfout
        '
        Me.BTNAchtergrondgeenfout.Location = New System.Drawing.Point(13, 237)
        Me.BTNAchtergrondgeenfout.Name = "BTNAchtergrondgeenfout"
        Me.BTNAchtergrondgeenfout.Size = New System.Drawing.Size(151, 20)
        Me.BTNAchtergrondgeenfout.TabIndex = 21
        Me.BTNAchtergrondgeenfout.Text = "Achtergrond geen fout"
        Me.BTNAchtergrondgeenfout.UseVisualStyleBackColor = True
        '
        'BTNAchtergrondbijFout
        '
        Me.BTNAchtergrondbijFout.Location = New System.Drawing.Point(13, 210)
        Me.BTNAchtergrondbijFout.Name = "BTNAchtergrondbijFout"
        Me.BTNAchtergrondbijFout.Size = New System.Drawing.Size(151, 20)
        Me.BTNAchtergrondbijFout.TabIndex = 20
        Me.BTNAchtergrondbijFout.Text = "Achtergrond bij Fout"
        Me.BTNAchtergrondbijFout.UseVisualStyleBackColor = True
        '
        'BTNGridOnEvenVoorgrond
        '
        Me.BTNGridOnEvenVoorgrond.Location = New System.Drawing.Point(13, 112)
        Me.BTNGridOnEvenVoorgrond.Name = "BTNGridOnEvenVoorgrond"
        Me.BTNGridOnEvenVoorgrond.Size = New System.Drawing.Size(151, 20)
        Me.BTNGridOnEvenVoorgrond.TabIndex = 19
        Me.BTNGridOnEvenVoorgrond.Text = "GridOnEvenVoorgrond"
        Me.BTNGridOnEvenVoorgrond.UseVisualStyleBackColor = True
        '
        'BTNGridEvenVoorgrond
        '
        Me.BTNGridEvenVoorgrond.Location = New System.Drawing.Point(13, 86)
        Me.BTNGridEvenVoorgrond.Name = "BTNGridEvenVoorgrond"
        Me.BTNGridEvenVoorgrond.Size = New System.Drawing.Size(151, 20)
        Me.BTNGridEvenVoorgrond.TabIndex = 18
        Me.BTNGridEvenVoorgrond.Text = "GridEvenVoorgrond"
        Me.BTNGridEvenVoorgrond.UseVisualStyleBackColor = True
        '
        'BTNGridOnEvenAchtergrond
        '
        Me.BTNGridOnEvenAchtergrond.Location = New System.Drawing.Point(13, 44)
        Me.BTNGridOnEvenAchtergrond.Name = "BTNGridOnEvenAchtergrond"
        Me.BTNGridOnEvenAchtergrond.Size = New System.Drawing.Size(151, 20)
        Me.BTNGridOnEvenAchtergrond.TabIndex = 17
        Me.BTNGridOnEvenAchtergrond.Text = "GridOnEvenAchtergrond"
        Me.BTNGridOnEvenAchtergrond.UseVisualStyleBackColor = True
        '
        'BTNGridEvenAchtergrond
        '
        Me.BTNGridEvenAchtergrond.Location = New System.Drawing.Point(13, 19)
        Me.BTNGridEvenAchtergrond.Name = "BTNGridEvenAchtergrond"
        Me.BTNGridEvenAchtergrond.Size = New System.Drawing.Size(151, 20)
        Me.BTNGridEvenAchtergrond.TabIndex = 16
        Me.BTNGridEvenAchtergrond.Text = "GridEvenAchtergrond"
        Me.BTNGridEvenAchtergrond.UseVisualStyleBackColor = True
        '
        'TBGRIDcellnotused
        '
        Me.TBGRIDcellnotused.BackColor = System.Drawing.SystemColors.Window
        Me.TBGRIDcellnotused.Location = New System.Drawing.Point(175, 277)
        Me.TBGRIDcellnotused.Name = "TBGRIDcellnotused"
        Me.TBGRIDcellnotused.Size = New System.Drawing.Size(152, 20)
        Me.TBGRIDcellnotused.TabIndex = 14
        '
        'TBDISPtextboxbackcolor
        '
        Me.TBDISPtextboxbackcolor.BackColor = System.Drawing.SystemColors.Window
        Me.TBDISPtextboxbackcolor.Location = New System.Drawing.Point(175, 237)
        Me.TBDISPtextboxbackcolor.Name = "TBDISPtextboxbackcolor"
        Me.TBDISPtextboxbackcolor.Size = New System.Drawing.Size(152, 20)
        Me.TBDISPtextboxbackcolor.TabIndex = 12
        '
        'TBDISPtextboxerror
        '
        Me.TBDISPtextboxerror.BackColor = System.Drawing.SystemColors.Window
        Me.TBDISPtextboxerror.Location = New System.Drawing.Point(175, 211)
        Me.TBDISPtextboxerror.Name = "TBDISPtextboxerror"
        Me.TBDISPtextboxerror.Size = New System.Drawing.Size(152, 20)
        Me.TBDISPtextboxerror.TabIndex = 10
        '
        'TBGRIDforecolorodd
        '
        Me.TBGRIDforecolorodd.BackColor = System.Drawing.SystemColors.Window
        Me.TBGRIDforecolorodd.Location = New System.Drawing.Point(175, 112)
        Me.TBGRIDforecolorodd.Name = "TBGRIDforecolorodd"
        Me.TBGRIDforecolorodd.Size = New System.Drawing.Size(152, 20)
        Me.TBGRIDforecolorodd.TabIndex = 8
        '
        'TBGRIDforecoloreven
        '
        Me.TBGRIDforecoloreven.BackColor = System.Drawing.SystemColors.Window
        Me.TBGRIDforecoloreven.Location = New System.Drawing.Point(175, 86)
        Me.TBGRIDforecoloreven.Name = "TBGRIDforecoloreven"
        Me.TBGRIDforecoloreven.Size = New System.Drawing.Size(152, 20)
        Me.TBGRIDforecoloreven.TabIndex = 6
        '
        'TBGRIDrowsodd
        '
        Me.TBGRIDrowsodd.BackColor = System.Drawing.SystemColors.Window
        Me.TBGRIDrowsodd.Location = New System.Drawing.Point(175, 45)
        Me.TBGRIDrowsodd.Name = "TBGRIDrowsodd"
        Me.TBGRIDrowsodd.Size = New System.Drawing.Size(152, 20)
        Me.TBGRIDrowsodd.TabIndex = 4
        '
        'TBGRIDrowseven
        '
        Me.TBGRIDrowseven.BackColor = System.Drawing.SystemColors.Window
        Me.TBGRIDrowseven.Location = New System.Drawing.Point(175, 19)
        Me.TBGRIDrowseven.Name = "TBGRIDrowseven"
        Me.TBGRIDrowseven.Size = New System.Drawing.Size(152, 20)
        Me.TBGRIDrowseven.TabIndex = 2
        '
        'TPStock
        '
        Me.TPStock.Controls.Add(Me.GroupBox2)
        Me.TPStock.Location = New System.Drawing.Point(4, 22)
        Me.TPStock.Name = "TPStock"
        Me.TPStock.Padding = New System.Windows.Forms.Padding(3)
        Me.TPStock.Size = New System.Drawing.Size(705, 380)
        Me.TPStock.TabIndex = 0
        Me.TPStock.Text = "Stock"
        Me.TPStock.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BTNresetostock)
        Me.GroupBox2.Controls.Add(Me.BTNresetstock)
        Me.GroupBox2.Controls.Add(Me.CBSTOCKupdateclosed)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.TBSTOCKstandaardtrans)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(699, 374)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'BTNresetostock
        '
        Me.BTNresetostock.Location = New System.Drawing.Point(561, 56)
        Me.BTNresetostock.Name = "BTNresetostock"
        Me.BTNresetostock.Size = New System.Drawing.Size(123, 23)
        Me.BTNresetostock.TabIndex = 22
        Me.BTNresetostock.Text = "Reset Oude Stock"
        Me.BTNresetostock.UseVisualStyleBackColor = True
        '
        'BTNresetstock
        '
        Me.BTNresetstock.Location = New System.Drawing.Point(561, 22)
        Me.BTNresetstock.Name = "BTNresetstock"
        Me.BTNresetstock.Size = New System.Drawing.Size(123, 23)
        Me.BTNresetstock.TabIndex = 21
        Me.BTNresetstock.Text = "Reset Stock"
        Me.BTNresetstock.UseVisualStyleBackColor = True
        '
        'CBSTOCKupdateclosed
        '
        Me.CBSTOCKupdateclosed.AutoSize = True
        Me.CBSTOCKupdateclosed.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CBSTOCKupdateclosed.Location = New System.Drawing.Point(6, 56)
        Me.CBSTOCKupdateclosed.Name = "CBSTOCKupdateclosed"
        Me.CBSTOCKupdateclosed.Size = New System.Drawing.Size(136, 17)
        Me.CBSTOCKupdateclosed.TabIndex = 20
        Me.CBSTOCKupdateclosed.Text = "Aanpassen OudeStock"
        Me.CBSTOCKupdateclosed.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Standaard Transactie"
        '
        'TBSTOCKstandaardtrans
        '
        Me.TBSTOCKstandaardtrans.BackColor = System.Drawing.SystemColors.Window
        Me.TBSTOCKstandaardtrans.Location = New System.Drawing.Point(135, 19)
        Me.TBSTOCKstandaardtrans.Name = "TBSTOCKstandaardtrans"
        Me.TBSTOCKstandaardtrans.Size = New System.Drawing.Size(121, 20)
        Me.TBSTOCKstandaardtrans.TabIndex = 16
        '
        'TPFakt
        '
        Me.TPFakt.Controls.Add(Me.Label9)
        Me.TPFakt.Controls.Add(Me.TBfirstfnr)
        Me.TPFakt.Location = New System.Drawing.Point(4, 22)
        Me.TPFakt.Name = "TPFakt"
        Me.TPFakt.Size = New System.Drawing.Size(705, 380)
        Me.TPFakt.TabIndex = 2
        Me.TPFakt.Text = "Faktuur"
        Me.TPFakt.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 17)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(113, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Eerste Factuurnummer"
        '
        'TBfirstfnr
        '
        Me.TBfirstfnr.BackColor = System.Drawing.SystemColors.Window
        Me.TBfirstfnr.Location = New System.Drawing.Point(144, 14)
        Me.TBfirstfnr.Name = "TBfirstfnr"
        Me.TBfirstfnr.Size = New System.Drawing.Size(121, 20)
        Me.TBfirstfnr.TabIndex = 18
        '
        'TPBon
        '
        Me.TPBon.Controls.Add(Me.Label4)
        Me.TPBon.Controls.Add(Me.Label2)
        Me.TPBon.Controls.Add(Me.TBTotalsAllowed)
        Me.TPBon.Controls.Add(Me.TBjaarcopy)
        Me.TPBon.Controls.Add(Me.Label1)
        Me.TPBon.Location = New System.Drawing.Point(4, 22)
        Me.TPBon.Name = "TPBon"
        Me.TPBon.Size = New System.Drawing.Size(705, 380)
        Me.TPBon.TabIndex = 3
        Me.TPBon.Text = "Bon"
        Me.TPBon.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Toon Totalen"
        '
        'TBTotalsAllowed
        '
        Me.TBTotalsAllowed.BackColor = System.Drawing.SystemColors.Window
        Me.TBTotalsAllowed.Location = New System.Drawing.Point(145, 51)
        Me.TBTotalsAllowed.Name = "TBTotalsAllowed"
        Me.TBTotalsAllowed.Size = New System.Drawing.Size(542, 20)
        Me.TBTotalsAllowed.TabIndex = 36
        Me.TBTotalsAllowed.Tag = "MAC-nrs gescheiden door #"
        '
        'TBjaarcopy
        '
        Me.TBjaarcopy.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TBjaarcopy.Location = New System.Drawing.Point(145, 25)
        Me.TBjaarcopy.Maximum = New Decimal(New Integer() {2090, 0, 0, 0})
        Me.TBjaarcopy.Minimum = New Decimal(New Integer() {1980, 0, 0, 0})
        Me.TBjaarcopy.Name = "TBjaarcopy"
        Me.TBjaarcopy.Size = New System.Drawing.Size(56, 20)
        Me.TBjaarcopy.TabIndex = 35
        Me.TBjaarcopy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TBjaarcopy.Value = New Decimal(New Integer() {2012, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Jaar copy bon:"
        '
        'TPCode
        '
        Me.TPCode.Controls.Add(Me.Label3)
        Me.TPCode.Controls.Add(Me.CMBcodgp)
        Me.TPCode.Location = New System.Drawing.Point(4, 22)
        Me.TPCode.Name = "TPCode"
        Me.TPCode.Padding = New System.Windows.Forms.Padding(3)
        Me.TPCode.Size = New System.Drawing.Size(705, 380)
        Me.TPCode.TabIndex = 4
        Me.TPCode.Text = "Code"
        Me.TPCode.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Groep"
        '
        'CMBcodgp
        '
        Me.CMBcodgp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CMBcodgp.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CMBcodgp.FormattingEnabled = True
        Me.CMBcodgp.Location = New System.Drawing.Point(62, 6)
        Me.CMBcodgp.Name = "CMBcodgp"
        Me.CMBcodgp.Size = New System.Drawing.Size(169, 21)
        Me.CMBcodgp.TabIndex = 26
        '
        'TPlocks
        '
        Me.TPlocks.Controls.Add(Me.TableLayoutPanel2)
        Me.TPlocks.Location = New System.Drawing.Point(4, 22)
        Me.TPlocks.Name = "TPlocks"
        Me.TPlocks.Padding = New System.Windows.Forms.Padding(3)
        Me.TPlocks.Size = New System.Drawing.Size(705, 380)
        Me.TPlocks.TabIndex = 5
        Me.TPlocks.Text = "Locks"
        Me.TPlocks.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.Controls.Add(Me.GroupFilter, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.DGREC, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(699, 374)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'GroupFilter
        '
        Me.GroupFilter.AutoSize = True
        Me.GroupFilter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupFilter.Controls.Add(Me.BTN_DropLocks)
        Me.GroupFilter.Controls.Add(Me.Label6)
        Me.GroupFilter.Controls.Add(Me.Label7)
        Me.GroupFilter.Controls.Add(Me.FltUnaam)
        Me.GroupFilter.Controls.Add(Me.FltType)
        Me.GroupFilter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupFilter.Location = New System.Drawing.Point(3, 3)
        Me.GroupFilter.Name = "GroupFilter"
        Me.GroupFilter.Size = New System.Drawing.Size(132, 368)
        Me.GroupFilter.TabIndex = 4
        Me.GroupFilter.TabStop = False
        '
        'BTN_DropLocks
        '
        Me.BTN_DropLocks.Image = Global.Bon2017.My.Resources.Resources.recycle
        Me.BTN_DropLocks.Location = New System.Drawing.Point(91, 12)
        Me.BTN_DropLocks.Name = "BTN_DropLocks"
        Me.BTN_DropLocks.Size = New System.Drawing.Size(35, 35)
        Me.BTN_DropLocks.TabIndex = 17
        Me.BTN_DropLocks.TabStop = False
        Me.BTN_DropLocks.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(4, 82)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Gebruiker"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(4, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Type"
        '
        'FltUnaam
        '
        Me.FltUnaam.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FltUnaam.Location = New System.Drawing.Point(60, 79)
        Me.FltUnaam.Name = "FltUnaam"
        Me.FltUnaam.Size = New System.Drawing.Size(66, 20)
        Me.FltUnaam.TabIndex = 11
        '
        'FltType
        '
        Me.FltType.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FltType.Location = New System.Drawing.Point(60, 53)
        Me.FltType.Name = "FltType"
        Me.FltType.Size = New System.Drawing.Size(66, 20)
        Me.FltType.TabIndex = 10
        '
        'DGREC
        '
        Me.DGREC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGREC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGREC.Location = New System.Drawing.Point(141, 3)
        Me.DGREC.Name = "DGREC"
        Me.DGREC.Size = New System.Drawing.Size(555, 368)
        Me.DGREC.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(143, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(164, 13)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "MacNummers gescheiden door #"
        '
        'EditParameters
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 443)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "EditParameters"
        Me.Text = "Parameters: Bewerken"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TPKleuren.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TPStock.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TPFakt.ResumeLayout(False)
        Me.TPFakt.PerformLayout()
        Me.TPBon.ResumeLayout(False)
        Me.TPBon.PerformLayout()
        CType(Me.TBjaarcopy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TPCode.ResumeLayout(False)
        Me.TPCode.PerformLayout()
        Me.TPlocks.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.GroupFilter.ResumeLayout(False)
        Me.GroupFilter.PerformLayout()
        CType(Me.DGREC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents TSBexit As ToolStripButton
    Friend WithEvents ToolStripLabel4 As ToolStripLabel
    Friend WithEvents TSBsave As ToolStripButton
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TPStock As TabPage
    Friend WithEvents TPKleuren As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TBGRIDrowseven As TextBox
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents TBGRIDrowsodd As TextBox
    Friend WithEvents TBGRIDforecolorodd As TextBox
    Friend WithEvents TBGRIDforecoloreven As TextBox
    Friend WithEvents TBreset As ToolStripButton
    Friend WithEvents TBDISPtextboxbackcolor As TextBox
    Friend WithEvents TBDISPtextboxerror As TextBox
    Friend WithEvents TBGRIDcellnotused As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TBSTOCKstandaardtrans As TextBox
    Friend WithEvents CBSTOCKupdateclosed As CheckBox
    Friend WithEvents TPFakt As TabPage
    Friend WithEvents Label9 As Label
    Friend WithEvents TBfirstfnr As TextBox
    Friend WithEvents BTNGridEvenAchtergrond As Button
    Friend WithEvents BTNGridOnEvenAchtergrond As Button
    Friend WithEvents BTNGridEvenVoorgrond As Button
    Friend WithEvents BTNGridOnEvenVoorgrond As Button
    Friend WithEvents BTNAchtergrondbijFout As Button
    Friend WithEvents BTNcodenietgebruikt As Button
    Friend WithEvents BTNAchtergrondgeenfout As Button
    Friend WithEvents BTNGridSelectieAchtergrond As Button
    Friend WithEvents BTNGridSelectieVoorgrond As Button
    Friend WithEvents TBGridSelectieAchtergrond As TextBox
    Friend WithEvents TBGridSelectieVoorgrond As TextBox
    Friend WithEvents BTNmemo As Button
    Friend WithEvents TBGRIDcellmemo As TextBox
    Friend WithEvents BTNgratis As Button
    Friend WithEvents TBGRIDcellgratis As TextBox
    Friend WithEvents TPBon As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents TBjaarcopy As NumericUpDown
    Friend WithEvents TPCode As TabPage
    Friend WithEvents Label3 As Label
    Friend WithEvents CMBcodgp As ComboBox
    Friend WithEvents BTNresetostock As Button
    Friend WithEvents BTNresetstock As Button
    Friend WithEvents TPlocks As TabPage
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents GroupFilter As GroupBox
    Friend WithEvents BTN_DropLocks As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents FltUnaam As TextBox
    Friend WithEvents FltType As TextBox
    Friend WithEvents DGREC As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents TBTotalsAllowed As TextBox
    Friend WithEvents Label4 As Label
End Class
