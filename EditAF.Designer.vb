<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditAF
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditAF))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TSBexit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.TSBsave = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BTNopenlink = New System.Windows.Forms.Button()
        Me.BTNgetfile = New System.Windows.Forms.Button()
        Me.CBafap = New System.Windows.Forms.CheckBox()
        Me.TBafnr = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CMBaft = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.DTPafdatum = New System.Windows.Forms.DateTimePicker()
        Me.CMBafr = New System.Windows.Forms.ComboBox()
        Me.TBaflink = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TBafstart = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TBafwerfl = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TBafopm = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TBafcalc = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TBafbedr = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBafoff = New System.Windows.Forms.TextBox()
        Me.TBafsend = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TBafafspr = New System.Windows.Forms.TextBox()
        Me.ToolStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSBexit, Me.ToolStripLabel4, Me.TSBsave, Me.ToolStripLabel2, Me.ToolStripLabel3, Me.ToolStripLabel1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(897, 31)
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
        Me.ToolStripLabel4.Enabled = False
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
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(16, 28)
        Me.ToolStripLabel2.Text = "   "
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(16, 28)
        Me.ToolStripLabel3.Text = "   "
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(16, 28)
        Me.ToolStripLabel1.Text = "   "
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 31)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(897, 336)
        Me.TableLayoutPanel1.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.TBafafspr)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.BTNopenlink)
        Me.GroupBox1.Controls.Add(Me.BTNgetfile)
        Me.GroupBox1.Controls.Add(Me.CBafap)
        Me.GroupBox1.Controls.Add(Me.TBafnr)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.CMBaft)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.DTPafdatum)
        Me.GroupBox1.Controls.Add(Me.CMBafr)
        Me.GroupBox1.Controls.Add(Me.TBaflink)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(891, 185)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 40)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 13)
        Me.Label10.TabIndex = 67
        Me.Label10.Text = "Datum"
        '
        'BTNopenlink
        '
        Me.BTNopenlink.Location = New System.Drawing.Point(841, 64)
        Me.BTNopenlink.Name = "BTNopenlink"
        Me.BTNopenlink.Size = New System.Drawing.Size(41, 23)
        Me.BTNopenlink.TabIndex = 66
        Me.BTNopenlink.Text = "Open"
        Me.BTNopenlink.UseVisualStyleBackColor = True
        '
        'BTNgetfile
        '
        Me.BTNgetfile.Location = New System.Drawing.Point(841, 90)
        Me.BTNgetfile.Name = "BTNgetfile"
        Me.BTNgetfile.Size = New System.Drawing.Size(41, 23)
        Me.BTNgetfile.TabIndex = 65
        Me.BTNgetfile.Text = "Zoek"
        Me.BTNgetfile.UseVisualStyleBackColor = True
        '
        'CBafap
        '
        Me.CBafap.AutoSize = True
        Me.CBafap.Location = New System.Drawing.Point(162, 15)
        Me.CBafap.Name = "CBafap"
        Me.CBafap.Size = New System.Drawing.Size(72, 17)
        Me.CBafap.TabIndex = 64
        Me.CBafap.TabStop = False
        Me.CBafap.Text = "Particulier"
        Me.CBafap.UseVisualStyleBackColor = True
        '
        'TBafnr
        '
        Me.TBafnr.Location = New System.Drawing.Point(72, 13)
        Me.TBafnr.Name = "TBafnr"
        Me.TBafnr.Size = New System.Drawing.Size(84, 20)
        Me.TBafnr.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "Nummer"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Type"
        '
        'CMBaft
        '
        Me.CMBaft.AllowDrop = True
        Me.CMBaft.FormattingEnabled = True
        Me.CMBaft.Items.AddRange(New Object() {"Bouw", "Verkoop", "Transport", "Container", "Nazorg", "Groenonderhoud", "Onbekend"})
        Me.CMBaft.Location = New System.Drawing.Point(72, 93)
        Me.CMBaft.Name = "CMBaft"
        Me.CMBaft.Size = New System.Drawing.Size(197, 21)
        Me.CMBaft.TabIndex = 12
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(6, 64)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(39, 13)
        Me.Label18.TabIndex = 55
        Me.Label18.Text = "Reden"
        '
        'DTPafdatum
        '
        Me.DTPafdatum.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPafdatum.Location = New System.Drawing.Point(72, 40)
        Me.DTPafdatum.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.DTPafdatum.Name = "DTPafdatum"
        Me.DTPafdatum.Size = New System.Drawing.Size(107, 20)
        Me.DTPafdatum.TabIndex = 1
        Me.DTPafdatum.Value = New Date(2019, 12, 28, 0, 0, 0, 0)
        '
        'CMBafr
        '
        Me.CMBafr.FormattingEnabled = True
        Me.CMBafr.Location = New System.Drawing.Point(72, 66)
        Me.CMBafr.Name = "CMBafr"
        Me.CMBafr.Size = New System.Drawing.Size(197, 21)
        Me.CMBafr.TabIndex = 11
        '
        'TBaflink
        '
        Me.TBaflink.Location = New System.Drawing.Point(72, 120)
        Me.TBaflink.Name = "TBaflink"
        Me.TBaflink.Size = New System.Drawing.Size(763, 20)
        Me.TBaflink.TabIndex = 13
        Me.TBaflink.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Link"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoSize = True
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.Controls.Add(Me.GroupBox2, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.GroupBox3, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 194)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(891, 139)
        Me.TableLayoutPanel2.TabIndex = 4
        '
        'GroupBox2
        '
        Me.GroupBox2.AutoSize = True
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.TBafstart)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.TBafwerfl)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.TBafopm)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TBafcalc)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(415, 127)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 91)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 13)
        Me.Label9.TabIndex = 72
        Me.Label9.Text = "Start"
        '
        'TBafstart
        '
        Me.TBafstart.Location = New System.Drawing.Point(69, 88)
        Me.TBafstart.MaxLength = 20
        Me.TBafstart.Name = "TBafstart"
        Me.TBafstart.Size = New System.Drawing.Size(340, 20)
        Me.TBafstart.TabIndex = 35
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 39)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 13)
        Me.Label8.TabIndex = 70
        Me.Label8.Text = "Werfleider"
        '
        'TBafwerfl
        '
        Me.TBafwerfl.Location = New System.Drawing.Point(69, 35)
        Me.TBafwerfl.MaxLength = 20
        Me.TBafwerfl.Name = "TBafwerfl"
        Me.TBafwerfl.Size = New System.Drawing.Size(340, 20)
        Me.TBafwerfl.TabIndex = 25
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 13)
        Me.Label7.TabIndex = 68
        Me.Label7.Text = "Opmerking"
        '
        'TBafopm
        '
        Me.TBafopm.Location = New System.Drawing.Point(69, 62)
        Me.TBafopm.MaxLength = 20
        Me.TBafopm.Name = "TBafopm"
        Me.TBafopm.Size = New System.Drawing.Size(340, 20)
        Me.TBafopm.TabIndex = 30
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "Calculator"
        '
        'TBafcalc
        '
        Me.TBafcalc.Location = New System.Drawing.Point(69, 9)
        Me.TBafcalc.MaxLength = 20
        Me.TBafcalc.Name = "TBafcalc"
        Me.TBafcalc.Size = New System.Drawing.Size(340, 20)
        Me.TBafcalc.TabIndex = 20
        '
        'GroupBox3
        '
        Me.GroupBox3.AutoSize = True
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.TBafbedr)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.TBafoff)
        Me.GroupBox3.Controls.Add(Me.TBafsend)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox3.Location = New System.Drawing.Point(424, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(464, 100)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(8, 65)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(41, 13)
        Me.Label14.TabIndex = 72
        Me.Label14.Text = "Bedrag"
        '
        'TBafbedr
        '
        Me.TBafbedr.Location = New System.Drawing.Point(71, 61)
        Me.TBafbedr.MaxLength = 20
        Me.TBafbedr.Name = "TBafbedr"
        Me.TBafbedr.Size = New System.Drawing.Size(340, 20)
        Me.TBafbedr.TabIndex = 75
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "Offerte"
        '
        'TBafoff
        '
        Me.TBafoff.Location = New System.Drawing.Point(71, 35)
        Me.TBafoff.MaxLength = 20
        Me.TBafoff.Name = "TBafoff"
        Me.TBafoff.Size = New System.Drawing.Size(340, 20)
        Me.TBafoff.TabIndex = 65
        '
        'TBafsend
        '
        Me.TBafsend.Location = New System.Drawing.Point(71, 9)
        Me.TBafsend.MaxLength = 20
        Me.TBafsend.Name = "TBafsend"
        Me.TBafsend.Size = New System.Drawing.Size(340, 20)
        Me.TBafsend.TabIndex = 55
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 66
        Me.Label6.Text = "Verstuurd"
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 150)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 13)
        Me.Label11.TabIndex = 76
        Me.Label11.Text = "Afspraak"
        '
        'TBafafspr
        '
        Me.TBafafspr.Location = New System.Drawing.Point(72, 146)
        Me.TBafafspr.MaxLength = 20
        Me.TBafafspr.Name = "TBafafspr"
        Me.TBafafspr.Size = New System.Drawing.Size(340, 20)
        Me.TBafafspr.TabIndex = 75
        '
        'EditAF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(897, 367)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "EditAF"
        Me.Text = "Af te handelen: Bewerken"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents TSBexit As ToolStripButton
    Friend WithEvents ToolStripLabel4 As ToolStripLabel
    Friend WithEvents TSBsave As ToolStripButton
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TBafnr As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CMBaft As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents DTPafdatum As DateTimePicker
    Friend WithEvents CMBafr As ComboBox
    Friend WithEvents CBafap As CheckBox
    Friend WithEvents TBaflink As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TBafstart As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TBafwerfl As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TBafopm As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TBafcalc As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TBafbedr As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TBafoff As TextBox
    Friend WithEvents TBafsend As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents BTNgetfile As Button
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents BTNopenlink As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TBafafspr As TextBox
End Class
