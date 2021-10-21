<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditParameters
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TBGRIDcellnotused = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TBDISPtextboxbackcolor = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TBDISPtextboxerror = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TBGRIDforecolorodd = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBGRIDforecoloreven = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBGRIDrowsodd = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBGRIDrowseven = New System.Windows.Forms.TextBox()
        Me.TPStock = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CBSTOCKupdateclosed = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TBSTOCKstandaardtrans = New System.Windows.Forms.TextBox()
        Me.TPFakt = New System.Windows.Forms.TabPage()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TBfirstfnr = New System.Windows.Forms.TextBox()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.ToolStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TPKleuren.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TPStock.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TPFakt.SuspendLayout()
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
        Me.TBreset.Image = CType(resources.GetObject("TBreset.Image"), System.Drawing.Image)
        Me.TBreset.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TBreset.Name = "TBreset"
        Me.TBreset.Size = New System.Drawing.Size(28, 28)
        Me.TBreset.Text = "RESET"
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(719, 367)
        Me.TableLayoutPanel1.TabIndex = 5
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TPKleuren)
        Me.TabControl1.Controls.Add(Me.TPStock)
        Me.TabControl1.Controls.Add(Me.TPFakt)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(3, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(713, 361)
        Me.TabControl1.TabIndex = 0
        '
        'TPKleuren
        '
        Me.TPKleuren.Controls.Add(Me.GroupBox1)
        Me.TPKleuren.Location = New System.Drawing.Point(4, 22)
        Me.TPKleuren.Name = "TPKleuren"
        Me.TPKleuren.Padding = New System.Windows.Forms.Padding(3)
        Me.TPKleuren.Size = New System.Drawing.Size(705, 335)
        Me.TPKleuren.TabIndex = 1
        Me.TPKleuren.Text = "Kleuren"
        Me.TPKleuren.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TBGRIDcellnotused)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TBDISPtextboxbackcolor)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TBDISPtextboxerror)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TBGRIDforecolorodd)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TBGRIDforecoloreven)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TBGRIDrowsodd)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TBGRIDrowseven)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(699, 329)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 219)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Controle GridCel"
        '
        'TBGRIDcellnotused
        '
        Me.TBGRIDcellnotused.BackColor = System.Drawing.SystemColors.Window
        Me.TBGRIDcellnotused.Location = New System.Drawing.Point(139, 216)
        Me.TBGRIDcellnotused.Name = "TBGRIDcellnotused"
        Me.TBGRIDcellnotused.Size = New System.Drawing.Size(121, 20)
        Me.TBGRIDcellnotused.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 179)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Achtergrond geen fout"
        '
        'TBDISPtextboxbackcolor
        '
        Me.TBDISPtextboxbackcolor.BackColor = System.Drawing.SystemColors.Window
        Me.TBDISPtextboxbackcolor.Location = New System.Drawing.Point(139, 176)
        Me.TBDISPtextboxbackcolor.Name = "TBDISPtextboxbackcolor"
        Me.TBDISPtextboxbackcolor.Size = New System.Drawing.Size(121, 20)
        Me.TBDISPtextboxbackcolor.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Achtergrond bij Fout"
        '
        'TBDISPtextboxerror
        '
        Me.TBDISPtextboxerror.BackColor = System.Drawing.SystemColors.Window
        Me.TBDISPtextboxerror.Location = New System.Drawing.Point(139, 150)
        Me.TBDISPtextboxerror.Name = "TBDISPtextboxerror"
        Me.TBDISPtextboxerror.Size = New System.Drawing.Size(121, 20)
        Me.TBDISPtextboxerror.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "GridOnEvenVoorgrond"
        '
        'TBGRIDforecolorodd
        '
        Me.TBGRIDforecolorodd.BackColor = System.Drawing.SystemColors.Window
        Me.TBGRIDforecolorodd.Location = New System.Drawing.Point(139, 112)
        Me.TBGRIDforecolorodd.Name = "TBGRIDforecolorodd"
        Me.TBGRIDforecolorodd.Size = New System.Drawing.Size(121, 20)
        Me.TBGRIDforecolorodd.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "GridOnEvenVoorgrond"
        '
        'TBGRIDforecoloreven
        '
        Me.TBGRIDforecoloreven.BackColor = System.Drawing.SystemColors.Window
        Me.TBGRIDforecoloreven.Location = New System.Drawing.Point(139, 86)
        Me.TBGRIDforecoloreven.Name = "TBGRIDforecoloreven"
        Me.TBGRIDforecoloreven.Size = New System.Drawing.Size(121, 20)
        Me.TBGRIDforecoloreven.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "GridOnEvenAchtergrond"
        '
        'TBGRIDrowsodd
        '
        Me.TBGRIDrowsodd.BackColor = System.Drawing.SystemColors.Window
        Me.TBGRIDrowsodd.Location = New System.Drawing.Point(139, 45)
        Me.TBGRIDrowsodd.Name = "TBGRIDrowsodd"
        Me.TBGRIDrowsodd.Size = New System.Drawing.Size(121, 20)
        Me.TBGRIDrowsodd.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "GridEvenAchtergrond"
        '
        'TBGRIDrowseven
        '
        Me.TBGRIDrowseven.BackColor = System.Drawing.SystemColors.Window
        Me.TBGRIDrowseven.Location = New System.Drawing.Point(139, 19)
        Me.TBGRIDrowseven.Name = "TBGRIDrowseven"
        Me.TBGRIDrowseven.Size = New System.Drawing.Size(121, 20)
        Me.TBGRIDrowseven.TabIndex = 2
        '
        'TPStock
        '
        Me.TPStock.Controls.Add(Me.GroupBox2)
        Me.TPStock.Location = New System.Drawing.Point(4, 22)
        Me.TPStock.Name = "TPStock"
        Me.TPStock.Padding = New System.Windows.Forms.Padding(3)
        Me.TPStock.Size = New System.Drawing.Size(705, 335)
        Me.TPStock.TabIndex = 0
        Me.TPStock.Text = "Stock"
        Me.TPStock.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CBSTOCKupdateclosed)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.TBSTOCKstandaardtrans)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(699, 329)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'CBSTOCKupdateclosed
        '
        Me.CBSTOCKupdateclosed.AutoSize = True
        Me.CBSTOCKupdateclosed.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CBSTOCKupdateclosed.Location = New System.Drawing.Point(9, 59)
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
        Me.TPFakt.Size = New System.Drawing.Size(705, 335)
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
        'EditParameters
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 398)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "EditParameters"
        Me.Text = "EditParameters"
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
    Friend WithEvents Label1 As Label
    Friend WithEvents TBGRIDrowseven As TextBox
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents Label2 As Label
    Friend WithEvents TBGRIDrowsodd As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TBGRIDforecolorodd As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TBGRIDforecoloreven As TextBox
    Friend WithEvents TBreset As ToolStripButton
    Friend WithEvents Label6 As Label
    Friend WithEvents TBDISPtextboxbackcolor As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TBDISPtextboxerror As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TBGRIDcellnotused As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TBSTOCKstandaardtrans As TextBox
    Friend WithEvents CBSTOCKupdateclosed As CheckBox
    Friend WithEvents TPFakt As TabPage
    Friend WithEvents Label9 As Label
    Friend WithEvents TBfirstfnr As TextBox
End Class
