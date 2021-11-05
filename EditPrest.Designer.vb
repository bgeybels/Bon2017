<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditPrest
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditPrest))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TSBexit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.TSBsave = New System.Windows.Forms.ToolStripButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CBexfeestdagen = New System.Windows.Forms.CheckBox()
        Me.CBexweekend = New System.Windows.Forms.CheckBox()
        Me.BtnCalc = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DTPprdateu = New System.Windows.Forms.DateTimePicker()
        Me.DTPprdate = New System.Windows.Forms.DateTimePicker()
        Me.CBpttot = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CMBtype = New System.Windows.Forms.ComboBox()
        Me.LBLboninfo = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBpraantal = New System.Windows.Forms.TextBox()
        Me.CMBsector = New System.Windows.Forms.ComboBox()
        Me.ToolStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSBexit, Me.ToolStripLabel4, Me.TSBsave})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(366, 31)
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
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 31)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(366, 310)
        Me.TableLayoutPanel1.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox1.Controls.Add(Me.CBexfeestdagen)
        Me.GroupBox1.Controls.Add(Me.CBexweekend)
        Me.GroupBox1.Controls.Add(Me.BtnCalc)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.DTPprdateu)
        Me.GroupBox1.Controls.Add(Me.DTPprdate)
        Me.GroupBox1.Controls.Add(Me.CBpttot)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.CMBtype)
        Me.GroupBox1.Controls.Add(Me.LBLboninfo)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TBpraantal)
        Me.GroupBox1.Controls.Add(Me.CMBsector)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(360, 304)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'CBexfeestdagen
        '
        Me.CBexfeestdagen.Checked = True
        Me.CBexfeestdagen.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CBexfeestdagen.Location = New System.Drawing.Point(66, 78)
        Me.CBexfeestdagen.Name = "CBexfeestdagen"
        Me.CBexfeestdagen.Size = New System.Drawing.Size(245, 23)
        Me.CBexfeestdagen.TabIndex = 66
        Me.CBexfeestdagen.TabStop = False
        Me.CBexfeestdagen.Text = "Exclusief feestdagen"
        Me.CBexfeestdagen.UseVisualStyleBackColor = True
        '
        'CBexweekend
        '
        Me.CBexweekend.Checked = True
        Me.CBexweekend.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CBexweekend.Location = New System.Drawing.Point(66, 61)
        Me.CBexweekend.Name = "CBexweekend"
        Me.CBexweekend.Size = New System.Drawing.Size(245, 23)
        Me.CBexweekend.TabIndex = 65
        Me.CBexweekend.TabStop = False
        Me.CBexweekend.Text = "Exclusief weekend"
        Me.CBexweekend.UseVisualStyleBackColor = True
        '
        'BtnCalc
        '
        Me.BtnCalc.Image = Global.Bon2017.My.Resources.Resources.calculator
        Me.BtnCalc.Location = New System.Drawing.Point(317, 40)
        Me.BtnCalc.Name = "BtnCalc"
        Me.BtnCalc.Size = New System.Drawing.Size(23, 23)
        Me.BtnCalc.TabIndex = 64
        Me.BtnCalc.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(179, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 13)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "tot"
        '
        'DTPprdateu
        '
        Me.DTPprdateu.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPprdateu.Location = New System.Drawing.Point(204, 41)
        Me.DTPprdateu.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.DTPprdateu.Name = "DTPprdateu"
        Me.DTPprdateu.Size = New System.Drawing.Size(107, 20)
        Me.DTPprdateu.TabIndex = 62
        Me.DTPprdateu.Value = New Date(2019, 12, 28, 0, 0, 0, 0)
        '
        'DTPprdate
        '
        Me.DTPprdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPprdate.Location = New System.Drawing.Point(66, 41)
        Me.DTPprdate.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.DTPprdate.Name = "DTPprdate"
        Me.DTPprdate.Size = New System.Drawing.Size(107, 20)
        Me.DTPprdate.TabIndex = 1
        Me.DTPprdate.Value = New Date(2019, 12, 28, 0, 0, 0, 0)
        '
        'CBpttot
        '
        Me.CBpttot.Location = New System.Drawing.Point(66, 186)
        Me.CBpttot.Name = "CBpttot"
        Me.CBpttot.Size = New System.Drawing.Size(107, 23)
        Me.CBpttot.TabIndex = 61
        Me.CBpttot.TabStop = False
        Me.CBpttot.Text = "Totaliseren"
        Me.CBpttot.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "Datum"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 162)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Type"
        '
        'CMBtype
        '
        Me.CMBtype.AllowDrop = True
        Me.CMBtype.FormattingEnabled = True
        Me.CMBtype.Items.AddRange(New Object() {"Bouw", "Verkoop", "Transport", "Container", "Nazorg", "Groenonderhoud", "Onbekend"})
        Me.CMBtype.Location = New System.Drawing.Point(66, 159)
        Me.CMBtype.Name = "CMBtype"
        Me.CMBtype.Size = New System.Drawing.Size(245, 21)
        Me.CMBtype.TabIndex = 4
        '
        'LBLboninfo
        '
        Me.LBLboninfo.AutoSize = True
        Me.LBLboninfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLboninfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LBLboninfo.Location = New System.Drawing.Point(62, 13)
        Me.LBLboninfo.Name = "LBLboninfo"
        Me.LBLboninfo.Size = New System.Drawing.Size(128, 20)
        Me.LBLboninfo.TabIndex = 56
        Me.LBLboninfo.Text = "Personeelsinfo"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(9, 107)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(38, 13)
        Me.Label18.TabIndex = 55
        Me.Label18.Text = "Sector"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Aantal"
        '
        'TBpraantal
        '
        Me.TBpraantal.Location = New System.Drawing.Point(66, 133)
        Me.TBpraantal.Name = "TBpraantal"
        Me.TBpraantal.Size = New System.Drawing.Size(58, 20)
        Me.TBpraantal.TabIndex = 3
        '
        'CMBsector
        '
        Me.CMBsector.FormattingEnabled = True
        Me.CMBsector.Location = New System.Drawing.Point(66, 104)
        Me.CMBsector.Name = "CMBsector"
        Me.CMBsector.Size = New System.Drawing.Size(245, 21)
        Me.CMBsector.TabIndex = 2
        '
        'EditPrest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(366, 341)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "EditPrest"
        Me.Text = "Prestaties: Bewerken"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents TSBexit As ToolStripButton
    Friend WithEvents ToolStripLabel4 As ToolStripLabel
    Friend WithEvents TSBsave As ToolStripButton
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CMBtype As ComboBox
    Friend WithEvents LBLboninfo As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents DTPprdate As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents TBpraantal As TextBox
    Friend WithEvents CMBsector As ComboBox
    Friend WithEvents CBpttot As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DTPprdateu As DateTimePicker
    Friend WithEvents BtnCalc As Button
    Friend WithEvents CBexweekend As CheckBox
    Friend WithEvents CBexfeestdagen As CheckBox
End Class
