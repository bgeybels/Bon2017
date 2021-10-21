<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Editfakt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Editfakt))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TSBexit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.TSBsave = New System.Windows.Forms.ToolStripButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.GRPAdres = New System.Windows.Forms.GroupBox()
        Me.TBcnr = New System.Windows.Forms.TextBox()
        Me.TBfnr = New System.Windows.Forms.TextBox()
        Me.CBcok = New System.Windows.Forms.CheckBox()
        Me.CBfok = New System.Windows.Forms.CheckBox()
        Me.TBomsbon = New System.Windows.Forms.TextBox()
        Me.GRPContact = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DTPdtot = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.DTPdvan = New System.Windows.Forms.DateTimePicker()
        Me.TBkemail = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CMBtype = New System.Windows.Forms.ComboBox()
        Me.LBLfaktinfo = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.DTPdatin = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBtav = New System.Windows.Forms.TextBox()
        Me.CMBeigenaar = New System.Windows.Forms.ComboBox()
        Me.ToolStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.GRPAdres.SuspendLayout()
        Me.GRPContact.SuspendLayout()
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
        Me.ToolStrip1.Size = New System.Drawing.Size(794, 31)
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(794, 364)
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
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 170)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(788, 187)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'GRPAdres
        '
        Me.GRPAdres.AutoSize = True
        Me.GRPAdres.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GRPAdres.Controls.Add(Me.TBcnr)
        Me.GRPAdres.Controls.Add(Me.TBfnr)
        Me.GRPAdres.Controls.Add(Me.CBcok)
        Me.GRPAdres.Controls.Add(Me.CBfok)
        Me.GRPAdres.Controls.Add(Me.TBomsbon)
        Me.GRPAdres.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GRPAdres.Location = New System.Drawing.Point(3, 3)
        Me.GRPAdres.Name = "GRPAdres"
        Me.GRPAdres.Size = New System.Drawing.Size(336, 181)
        Me.GRPAdres.TabIndex = 0
        Me.GRPAdres.TabStop = False
        '
        'TBcnr
        '
        Me.TBcnr.Location = New System.Drawing.Point(89, 46)
        Me.TBcnr.Name = "TBcnr"
        Me.TBcnr.Size = New System.Drawing.Size(60, 20)
        Me.TBcnr.TabIndex = 48
        '
        'TBfnr
        '
        Me.TBfnr.Location = New System.Drawing.Point(89, 19)
        Me.TBfnr.Name = "TBfnr"
        Me.TBfnr.Size = New System.Drawing.Size(60, 20)
        Me.TBfnr.TabIndex = 47
        '
        'CBcok
        '
        Me.CBcok.AutoSize = True
        Me.CBcok.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CBcok.Location = New System.Drawing.Point(9, 48)
        Me.CBcok.Name = "CBcok"
        Me.CBcok.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CBcok.Size = New System.Drawing.Size(74, 17)
        Me.CBcok.TabIndex = 46
        Me.CBcok.Text = "Creditnota"
        Me.CBcok.UseVisualStyleBackColor = True
        '
        'CBfok
        '
        Me.CBfok.AutoSize = True
        Me.CBfok.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CBfok.Location = New System.Drawing.Point(9, 21)
        Me.CBfok.Name = "CBfok"
        Me.CBfok.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CBfok.Size = New System.Drawing.Size(62, 17)
        Me.CBfok.TabIndex = 45
        Me.CBfok.Text = "Factuur"
        Me.CBfok.UseVisualStyleBackColor = True
        '
        'TBomsbon
        '
        Me.TBomsbon.Location = New System.Drawing.Point(9, 78)
        Me.TBomsbon.Multiline = True
        Me.TBomsbon.Name = "TBomsbon"
        Me.TBomsbon.Size = New System.Drawing.Size(321, 84)
        Me.TBomsbon.TabIndex = 44
        '
        'GRPContact
        '
        Me.GRPContact.AutoSize = True
        Me.GRPContact.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GRPContact.Controls.Add(Me.Label3)
        Me.GRPContact.Controls.Add(Me.DTPdtot)
        Me.GRPContact.Controls.Add(Me.Label14)
        Me.GRPContact.Controls.Add(Me.DTPdvan)
        Me.GRPContact.Controls.Add(Me.TBkemail)
        Me.GRPContact.Controls.Add(Me.Label12)
        Me.GRPContact.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GRPContact.Location = New System.Drawing.Point(3, 363)
        Me.GRPContact.Name = "GRPContact"
        Me.GRPContact.Size = New System.Drawing.Size(788, 58)
        Me.GRPContact.TabIndex = 2
        Me.GRPContact.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(237, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 66
        Me.Label3.Text = "laatste:"
        '
        'DTPdtot
        '
        Me.DTPdtot.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPdtot.Location = New System.Drawing.Point(278, 19)
        Me.DTPdtot.Name = "DTPdtot"
        Me.DTPdtot.Size = New System.Drawing.Size(107, 20)
        Me.DTPdtot.TabIndex = 65
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(9, 22)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(106, 13)
        Me.Label14.TabIndex = 64
        Me.Label14.Text = "Datum bonlijn eerste:"
        '
        'DTPdvan
        '
        Me.DTPdvan.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPdvan.Location = New System.Drawing.Point(120, 19)
        Me.DTPdvan.Name = "DTPdvan"
        Me.DTPdvan.Size = New System.Drawing.Size(107, 20)
        Me.DTPdvan.TabIndex = 63
        '
        'TBkemail
        '
        Me.TBkemail.Location = New System.Drawing.Point(432, -89)
        Me.TBkemail.Name = "TBkemail"
        Me.TBkemail.Size = New System.Drawing.Size(242, 20)
        Me.TBkemail.TabIndex = 24
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
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.CMBtype)
        Me.GroupBox1.Controls.Add(Me.LBLfaktinfo)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.DTPdatin)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TBtav)
        Me.GroupBox1.Controls.Add(Me.CMBeigenaar)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(788, 161)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
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
        Me.Label1.Location = New System.Drawing.Point(9, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Type"
        '
        'CMBtype
        '
        Me.CMBtype.AllowDrop = True
        Me.CMBtype.FormattingEnabled = True
        Me.CMBtype.Items.AddRange(New Object() {"Bouw", "Verkoop", "Transport", "Container", "Onbekend"})
        Me.CMBtype.Location = New System.Drawing.Point(66, 121)
        Me.CMBtype.Name = "CMBtype"
        Me.CMBtype.Size = New System.Drawing.Size(121, 21)
        Me.CMBtype.TabIndex = 57
        '
        'LBLfaktinfo
        '
        Me.LBLfaktinfo.AutoSize = True
        Me.LBLfaktinfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLfaktinfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LBLfaktinfo.Location = New System.Drawing.Point(62, 13)
        Me.LBLfaktinfo.Name = "LBLfaktinfo"
        Me.LBLfaktinfo.Size = New System.Drawing.Size(105, 20)
        Me.LBLfaktinfo.TabIndex = 56
        Me.LBLfaktinfo.Text = "FAktuurInfo"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(9, 69)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(49, 13)
        Me.Label18.TabIndex = 55
        Me.Label18.Text = "Eigenaar"
        '
        'DTPdatin
        '
        Me.DTPdatin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPdatin.Location = New System.Drawing.Point(66, 41)
        Me.DTPdatin.Name = "DTPdatin"
        Me.DTPdatin.Size = New System.Drawing.Size(107, 20)
        Me.DTPdatin.TabIndex = 53
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Tav"
        '
        'TBtav
        '
        Me.TBtav.Location = New System.Drawing.Point(66, 95)
        Me.TBtav.Name = "TBtav"
        Me.TBtav.Size = New System.Drawing.Size(197, 20)
        Me.TBtav.TabIndex = 51
        '
        'CMBeigenaar
        '
        Me.CMBeigenaar.FormattingEnabled = True
        Me.CMBeigenaar.Location = New System.Drawing.Point(66, 66)
        Me.CMBeigenaar.Name = "CMBeigenaar"
        Me.CMBeigenaar.Size = New System.Drawing.Size(197, 21)
        Me.CMBeigenaar.TabIndex = 50
        '
        'Editfakt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 395)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "Editfakt"
        Me.Text = "Faktuur: Bewerken"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.GRPAdres.ResumeLayout(False)
        Me.GRPAdres.PerformLayout()
        Me.GRPContact.ResumeLayout(False)
        Me.GRPContact.PerformLayout()
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
    Friend WithEvents TBcnr As TextBox
    Friend WithEvents TBfnr As TextBox
    Friend WithEvents CBcok As CheckBox
    Friend WithEvents CBfok As CheckBox
    Friend WithEvents TBomsbon As TextBox
    Friend WithEvents GRPContact As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DTPdtot As DateTimePicker
    Friend WithEvents Label14 As Label
    Friend WithEvents DTPdvan As DateTimePicker
    Friend WithEvents TBkemail As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CMBtype As ComboBox
    Friend WithEvents LBLfaktinfo As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents DTPdatin As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents TBtav As TextBox
    Friend WithEvents CMBeigenaar As ComboBox
End Class
