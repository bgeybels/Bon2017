<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Editperl
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Editperl))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TSBexit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.TSBsave = New System.Windows.Forms.ToolStripButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.GRPAdres = New System.Windows.Forms.GroupBox()
        Me.CBinbezit = New System.Windows.Forms.CheckBox()
        Me.LBLaoms = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TBaantal = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ZoekCodeIM = New System.Windows.Forms.TextBox()
        Me.CBselrec = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblCODEinfo = New System.Windows.Forms.Label()
        Me.LBLperlinfo = New System.Windows.Forms.Label()
        Me.ZoekCode = New System.Windows.Forms.Button()
        Me.DTPstartdate = New System.Windows.Forms.DateTimePicker()
        Me.ToolStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.GRPAdres.SuspendLayout()
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
        Me.ToolStrip1.Size = New System.Drawing.Size(908, 31)
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
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 31)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(908, 440)
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoSize = True
        Me.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.Controls.Add(Me.GRPAdres, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 139)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(902, 298)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'GRPAdres
        '
        Me.GRPAdres.AutoSize = True
        Me.GRPAdres.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GRPAdres.Controls.Add(Me.CBinbezit)
        Me.GRPAdres.Controls.Add(Me.LBLaoms)
        Me.GRPAdres.Controls.Add(Me.Label8)
        Me.GRPAdres.Controls.Add(Me.TBaantal)
        Me.GRPAdres.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GRPAdres.Location = New System.Drawing.Point(3, 3)
        Me.GRPAdres.Name = "GRPAdres"
        Me.GRPAdres.Size = New System.Drawing.Size(896, 292)
        Me.GRPAdres.TabIndex = 0
        Me.GRPAdres.TabStop = False
        '
        'CBinbezit
        '
        Me.CBinbezit.AutoSize = True
        Me.CBinbezit.Location = New System.Drawing.Point(82, 42)
        Me.CBinbezit.Name = "CBinbezit"
        Me.CBinbezit.Size = New System.Drawing.Size(58, 17)
        Me.CBinbezit.TabIndex = 76
        Me.CBinbezit.TabStop = False
        Me.CBinbezit.Text = "InBezit"
        Me.CBinbezit.UseVisualStyleBackColor = True
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
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox1.Controls.Add(Me.ZoekCodeIM)
        Me.GroupBox1.Controls.Add(Me.CBselrec)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lblCODEinfo)
        Me.GroupBox1.Controls.Add(Me.LBLperlinfo)
        Me.GroupBox1.Controls.Add(Me.ZoekCode)
        Me.GroupBox1.Controls.Add(Me.DTPstartdate)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(902, 130)
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
        '
        'CBselrec
        '
        Me.CBselrec.AutoSize = True
        Me.CBselrec.Location = New System.Drawing.Point(85, 94)
        Me.CBselrec.Name = "CBselrec"
        Me.CBselrec.Size = New System.Drawing.Size(71, 17)
        Me.CBselrec.TabIndex = 75
        Me.CBselrec.TabStop = False
        Me.CBselrec.Text = "Selecteer"
        Me.CBselrec.UseVisualStyleBackColor = True
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
        'LBLperlinfo
        '
        Me.LBLperlinfo.AutoSize = True
        Me.LBLperlinfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLperlinfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LBLperlinfo.Location = New System.Drawing.Point(2, 14)
        Me.LBLperlinfo.Name = "LBLperlinfo"
        Me.LBLperlinfo.Size = New System.Drawing.Size(128, 20)
        Me.LBLperlinfo.TabIndex = 56
        Me.LBLperlinfo.Text = "Personeelsinfo"
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
        Me.ZoekCode.UseVisualStyleBackColor = False
        '
        'DTPstartdate
        '
        Me.DTPstartdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPstartdate.Location = New System.Drawing.Point(84, 68)
        Me.DTPstartdate.Name = "DTPstartdate"
        Me.DTPstartdate.Size = New System.Drawing.Size(107, 20)
        Me.DTPstartdate.TabIndex = 11
        '
        'Editperl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(908, 471)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "Editperl"
        Me.Text = "Editperl"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.GRPAdres.ResumeLayout(False)
        Me.GRPAdres.PerformLayout()
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
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents GRPAdres As GroupBox
    Friend WithEvents LBLaoms As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TBaantal As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ZoekCodeIM As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblCODEinfo As Label
    Friend WithEvents LBLperlinfo As Label
    Friend WithEvents ZoekCode As Button
    Friend WithEvents DTPstartdate As DateTimePicker
    Friend WithEvents CBinbezit As CheckBox
    Friend WithEvents CBselrec As CheckBox
End Class
