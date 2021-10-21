<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditEigenaar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditEigenaar))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TSBexit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.TSBsave = New System.Windows.Forms.ToolStripButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GRPAlgemeen = New System.Windows.Forms.GroupBox()
        Me.TBereknr = New System.Windows.Forms.TextBox()
        Me.TBefirma = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TBebtwnr = New System.Windows.Forms.TextBox()
        Me.TBenaam = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GRPContact = New System.Windows.Forms.GroupBox()
        Me.TBeemail = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBefax = New System.Windows.Forms.TextBox()
        Me.TBkemail = New System.Windows.Forms.TextBox()
        Me.TBegsm = New System.Windows.Forms.TextBox()
        Me.TBetel = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TBeadres = New System.Windows.Forms.TextBox()
        Me.TBestraat = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GRPAlgemeen.SuspendLayout()
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
        Me.ToolStrip1.Size = New System.Drawing.Size(695, 31)
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
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.GRPContact, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.GRPAlgemeen, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 31)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(695, 274)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'GRPAlgemeen
        '
        Me.GRPAlgemeen.AutoSize = True
        Me.GRPAlgemeen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GRPAlgemeen.BackColor = System.Drawing.SystemColors.Control
        Me.GRPAlgemeen.Controls.Add(Me.TBereknr)
        Me.GRPAlgemeen.Controls.Add(Me.TBefirma)
        Me.GRPAlgemeen.Controls.Add(Me.Label14)
        Me.GRPAlgemeen.Controls.Add(Me.Label11)
        Me.GRPAlgemeen.Controls.Add(Me.Label15)
        Me.GRPAlgemeen.Controls.Add(Me.TBebtwnr)
        Me.GRPAlgemeen.Controls.Add(Me.TBenaam)
        Me.GRPAlgemeen.Controls.Add(Me.Label4)
        Me.GRPAlgemeen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GRPAlgemeen.Location = New System.Drawing.Point(3, 3)
        Me.GRPAlgemeen.Name = "GRPAlgemeen"
        Me.GRPAlgemeen.Size = New System.Drawing.Size(689, 87)
        Me.GRPAlgemeen.TabIndex = 1
        Me.GRPAlgemeen.TabStop = False
        '
        'TBereknr
        '
        Me.TBereknr.Location = New System.Drawing.Point(420, 48)
        Me.TBereknr.Name = "TBereknr"
        Me.TBereknr.Size = New System.Drawing.Size(242, 20)
        Me.TBereknr.TabIndex = 16
        '
        'TBefirma
        '
        Me.TBefirma.Location = New System.Drawing.Point(69, 45)
        Me.TBefirma.Name = "TBefirma"
        Me.TBefirma.Size = New System.Drawing.Size(242, 20)
        Me.TBefirma.TabIndex = 12
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(356, 51)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(53, 13)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "Rekening"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(5, 48)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(32, 13)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Firma"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(356, 22)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(41, 13)
        Me.Label15.TabIndex = 27
        Me.Label15.Text = "BTWnr"
        '
        'TBebtwnr
        '
        Me.TBebtwnr.Location = New System.Drawing.Point(420, 19)
        Me.TBebtwnr.Name = "TBebtwnr"
        Me.TBebtwnr.Size = New System.Drawing.Size(242, 20)
        Me.TBebtwnr.TabIndex = 14
        '
        'TBenaam
        '
        Me.TBenaam.Location = New System.Drawing.Point(69, 19)
        Me.TBenaam.Name = "TBenaam"
        Me.TBenaam.Size = New System.Drawing.Size(242, 20)
        Me.TBenaam.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Naam"
        '
        'GRPContact
        '
        Me.GRPContact.AutoSize = True
        Me.GRPContact.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GRPContact.Controls.Add(Me.TBeemail)
        Me.GRPContact.Controls.Add(Me.Label1)
        Me.GRPContact.Controls.Add(Me.TBefax)
        Me.GRPContact.Controls.Add(Me.TBkemail)
        Me.GRPContact.Controls.Add(Me.TBegsm)
        Me.GRPContact.Controls.Add(Me.TBetel)
        Me.GRPContact.Controls.Add(Me.Label13)
        Me.GRPContact.Controls.Add(Me.Label12)
        Me.GRPContact.Controls.Add(Me.Label10)
        Me.GRPContact.Controls.Add(Me.Label9)
        Me.GRPContact.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GRPContact.Location = New System.Drawing.Point(3, 187)
        Me.GRPContact.Name = "GRPContact"
        Me.GRPContact.Size = New System.Drawing.Size(689, 84)
        Me.GRPContact.TabIndex = 3
        Me.GRPContact.TabStop = False
        Me.GRPContact.Text = "Contactgegevens"
        '
        'TBeemail
        '
        Me.TBeemail.Location = New System.Drawing.Point(69, 19)
        Me.TBeemail.Name = "TBeemail"
        Me.TBeemail.Size = New System.Drawing.Size(242, 20)
        Me.TBeemail.TabIndex = 50
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "EMail"
        '
        'TBefax
        '
        Me.TBefax.Location = New System.Drawing.Point(420, 45)
        Me.TBefax.Name = "TBefax"
        Me.TBefax.Size = New System.Drawing.Size(242, 20)
        Me.TBefax.TabIndex = 56
        '
        'TBkemail
        '
        Me.TBkemail.Location = New System.Drawing.Point(432, -89)
        Me.TBkemail.Name = "TBkemail"
        Me.TBkemail.Size = New System.Drawing.Size(242, 20)
        Me.TBkemail.TabIndex = 24
        '
        'TBegsm
        '
        Me.TBegsm.Location = New System.Drawing.Point(420, 19)
        Me.TBegsm.Name = "TBegsm"
        Me.TBegsm.Size = New System.Drawing.Size(242, 20)
        Me.TBegsm.TabIndex = 54
        '
        'TBetel
        '
        Me.TBetel.Location = New System.Drawing.Point(69, 45)
        Me.TBetel.Name = "TBetel"
        Me.TBetel.Size = New System.Drawing.Size(242, 20)
        Me.TBetel.TabIndex = 52
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(363, 48)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(24, 13)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "Fax"
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
        Me.Label10.Location = New System.Drawing.Point(356, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(31, 13)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "GSM"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(5, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Telefoon"
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox1.Controls.Add(Me.TBeadres)
        Me.GroupBox1.Controls.Add(Me.TBestraat)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(3, 96)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(689, 85)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Adres"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(-53, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Adres"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(-53, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Straat"
        '
        'TBeadres
        '
        Me.TBeadres.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock
        Me.TBeadres.Location = New System.Drawing.Point(69, 45)
        Me.TBeadres.Name = "TBeadres"
        Me.TBeadres.Size = New System.Drawing.Size(242, 20)
        Me.TBeadres.TabIndex = 40
        '
        'TBestraat
        '
        Me.TBestraat.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock
        Me.TBestraat.Location = New System.Drawing.Point(69, 19)
        Me.TBestraat.Name = "TBestraat"
        Me.TBestraat.Size = New System.Drawing.Size(242, 20)
        Me.TBestraat.TabIndex = 39
        '
        'Label2
        '
        Me.Label2.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Adres"
        '
        'Label3
        '
        Me.Label3.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Straat"
        '
        'EditEigenaar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(695, 305)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "EditEigenaar"
        Me.Text = "Eigenaar: Bewerken"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.GRPAlgemeen.ResumeLayout(False)
        Me.GRPAlgemeen.PerformLayout()
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
    Friend WithEvents GRPAlgemeen As GroupBox
    Friend WithEvents TBereknr As TextBox
    Friend WithEvents TBefirma As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents TBebtwnr As TextBox
    Friend WithEvents TBenaam As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GRPContact As GroupBox
    Friend WithEvents TBeemail As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TBefax As TextBox
    Friend WithEvents TBkemail As TextBox
    Friend WithEvents TBegsm As TextBox
    Friend WithEvents TBetel As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TBeadres As TextBox
    Friend WithEvents TBestraat As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
