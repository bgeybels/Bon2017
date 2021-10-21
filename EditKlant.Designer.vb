<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditKlant
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditKlant))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TSBexit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.TSBsave = New System.Windows.Forms.ToolStripButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GRPAlgemeen = New System.Windows.Forms.GroupBox()
        Me.TBkbtwnr = New System.Windows.Forms.TextBox()
        Me.TBktav = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TBconvin_nr = New System.Windows.Forms.TextBox()
        Me.TBknaam = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.GRPAdres = New System.Windows.Forms.GroupBox()
        Me.TBkadres = New System.Windows.Forms.TextBox()
        Me.TBkstraat = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GRPWerf = New System.Windows.Forms.GroupBox()
        Me.TBkwadres = New System.Windows.Forms.TextBox()
        Me.TBkwstraat = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GRPContact = New System.Windows.Forms.GroupBox()
        Me.TBkemail = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBkfax = New System.Windows.Forms.TextBox()
        Me.TBkgsm = New System.Windows.Forms.TextBox()
        Me.TBktel = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GRPAlgemeen.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.GRPAdres.SuspendLayout()
        Me.GRPWerf.SuspendLayout()
        Me.GRPContact.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSBexit, Me.ToolStripLabel4, Me.TSBsave})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(685, 31)
        Me.ToolStrip1.TabIndex = 1
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(685, 291)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'GRPAlgemeen
        '
        Me.GRPAlgemeen.AutoSize = True
        Me.GRPAlgemeen.BackColor = System.Drawing.SystemColors.Control
        Me.GRPAlgemeen.Controls.Add(Me.TBkbtwnr)
        Me.GRPAlgemeen.Controls.Add(Me.TBktav)
        Me.GRPAlgemeen.Controls.Add(Me.Label14)
        Me.GRPAlgemeen.Controls.Add(Me.Label11)
        Me.GRPAlgemeen.Controls.Add(Me.Label15)
        Me.GRPAlgemeen.Controls.Add(Me.TBconvin_nr)
        Me.GRPAlgemeen.Controls.Add(Me.TBknaam)
        Me.GRPAlgemeen.Controls.Add(Me.Label4)
        Me.GRPAlgemeen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GRPAlgemeen.Location = New System.Drawing.Point(3, 3)
        Me.GRPAlgemeen.Name = "GRPAlgemeen"
        Me.GRPAlgemeen.Size = New System.Drawing.Size(679, 87)
        Me.GRPAlgemeen.TabIndex = 0
        Me.GRPAlgemeen.TabStop = False
        '
        'TBkbtwnr
        '
        Me.TBkbtwnr.Location = New System.Drawing.Point(420, 48)
        Me.TBkbtwnr.Name = "TBkbtwnr"
        Me.TBkbtwnr.Size = New System.Drawing.Size(242, 20)
        Me.TBkbtwnr.TabIndex = 16
        '
        'TBktav
        '
        Me.TBktav.Location = New System.Drawing.Point(69, 45)
        Me.TBktav.Name = "TBktav"
        Me.TBktav.Size = New System.Drawing.Size(242, 20)
        Me.TBktav.TabIndex = 12
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(356, 51)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(41, 13)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "BTWnr"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(5, 48)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(26, 13)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Tav"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(356, 22)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(46, 13)
        Me.Label15.TabIndex = 27
        Me.Label15.Text = "CONVnr"
        '
        'TBconvin_nr
        '
        Me.TBconvin_nr.Location = New System.Drawing.Point(420, 19)
        Me.TBconvin_nr.Name = "TBconvin_nr"
        Me.TBconvin_nr.Size = New System.Drawing.Size(242, 20)
        Me.TBconvin_nr.TabIndex = 14
        '
        'TBknaam
        '
        Me.TBknaam.Location = New System.Drawing.Point(69, 19)
        Me.TBknaam.Name = "TBknaam"
        Me.TBknaam.Size = New System.Drawing.Size(242, 20)
        Me.TBknaam.TabIndex = 10
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
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.GRPAdres, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.GRPWerf, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 96)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(679, 100)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'GRPAdres
        '
        Me.GRPAdres.AutoSize = True
        Me.GRPAdres.Controls.Add(Me.TBkadres)
        Me.GRPAdres.Controls.Add(Me.TBkstraat)
        Me.GRPAdres.Controls.Add(Me.Label6)
        Me.GRPAdres.Controls.Add(Me.Label5)
        Me.GRPAdres.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GRPAdres.Location = New System.Drawing.Point(3, 3)
        Me.GRPAdres.Name = "GRPAdres"
        Me.GRPAdres.Size = New System.Drawing.Size(333, 94)
        Me.GRPAdres.TabIndex = 0
        Me.GRPAdres.TabStop = False
        Me.GRPAdres.Text = "Adres"
        '
        'TBkadres
        '
        Me.TBkadres.Location = New System.Drawing.Point(66, 60)
        Me.TBkadres.Name = "TBkadres"
        Me.TBkadres.Size = New System.Drawing.Size(242, 20)
        Me.TBkadres.TabIndex = 32
        '
        'TBkstraat
        '
        Me.TBkstraat.Location = New System.Drawing.Point(66, 34)
        Me.TBkstraat.Name = "TBkstraat"
        Me.TBkstraat.Size = New System.Drawing.Size(242, 20)
        Me.TBkstraat.TabIndex = 30
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(2, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Adres"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(2, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Straat"
        '
        'GRPWerf
        '
        Me.GRPWerf.AutoSize = True
        Me.GRPWerf.Controls.Add(Me.TBkwadres)
        Me.GRPWerf.Controls.Add(Me.TBkwstraat)
        Me.GRPWerf.Controls.Add(Me.Label8)
        Me.GRPWerf.Controls.Add(Me.Label7)
        Me.GRPWerf.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GRPWerf.Location = New System.Drawing.Point(342, 3)
        Me.GRPWerf.Name = "GRPWerf"
        Me.GRPWerf.Size = New System.Drawing.Size(334, 94)
        Me.GRPWerf.TabIndex = 1
        Me.GRPWerf.TabStop = False
        Me.GRPWerf.Text = "WerfAdres"
        '
        'TBkwadres
        '
        Me.TBkwadres.Location = New System.Drawing.Point(75, 60)
        Me.TBkwadres.Name = "TBkwadres"
        Me.TBkwadres.Size = New System.Drawing.Size(242, 20)
        Me.TBkwadres.TabIndex = 36
        '
        'TBkwstraat
        '
        Me.TBkwstraat.Location = New System.Drawing.Point(75, 34)
        Me.TBkwstraat.Name = "TBkwstraat"
        Me.TBkwstraat.Size = New System.Drawing.Size(242, 20)
        Me.TBkwstraat.TabIndex = 34
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 63)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Werfadres"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 37)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Werfstraat"
        '
        'GRPContact
        '
        Me.GRPContact.AutoSize = True
        Me.GRPContact.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GRPContact.Controls.Add(Me.TBkemail)
        Me.GRPContact.Controls.Add(Me.Label1)
        Me.GRPContact.Controls.Add(Me.TBkfax)
        Me.GRPContact.Controls.Add(Me.TBkgsm)
        Me.GRPContact.Controls.Add(Me.TBktel)
        Me.GRPContact.Controls.Add(Me.Label13)
        Me.GRPContact.Controls.Add(Me.Label10)
        Me.GRPContact.Controls.Add(Me.Label9)
        Me.GRPContact.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GRPContact.Location = New System.Drawing.Point(3, 202)
        Me.GRPContact.Name = "GRPContact"
        Me.GRPContact.Size = New System.Drawing.Size(679, 86)
        Me.GRPContact.TabIndex = 2
        Me.GRPContact.TabStop = False
        Me.GRPContact.Text = "Contactgegevens"
        '
        'TBkemail
        '
        Me.TBkemail.Location = New System.Drawing.Point(69, 15)
        Me.TBkemail.Name = "TBkemail"
        Me.TBkemail.Size = New System.Drawing.Size(242, 20)
        Me.TBkemail.TabIndex = 50
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "EMail"
        '
        'TBkfax
        '
        Me.TBkfax.Location = New System.Drawing.Point(420, 45)
        Me.TBkfax.Name = "TBkfax"
        Me.TBkfax.Size = New System.Drawing.Size(242, 20)
        Me.TBkfax.TabIndex = 56
        '
        'TBkgsm
        '
        Me.TBkgsm.Location = New System.Drawing.Point(420, 19)
        Me.TBkgsm.Name = "TBkgsm"
        Me.TBkgsm.Size = New System.Drawing.Size(242, 20)
        Me.TBkgsm.TabIndex = 54
        '
        'TBktel
        '
        Me.TBktel.Location = New System.Drawing.Point(69, 41)
        Me.TBktel.Name = "TBktel"
        Me.TBktel.Size = New System.Drawing.Size(242, 20)
        Me.TBktel.TabIndex = 52
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
        Me.Label9.Location = New System.Drawing.Point(5, 44)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Telefoon"
        '
        'EditKlant
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(685, 322)
        Me.ControlBox = False
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EditKlant"
        Me.Text = "Klant: bewerken"
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
        Me.GRPWerf.ResumeLayout(False)
        Me.GRPWerf.PerformLayout()
        Me.GRPContact.ResumeLayout(False)
        Me.GRPContact.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents GRPAlgemeen As GroupBox
    Friend WithEvents TBkbtwnr As TextBox
    Friend WithEvents TBktav As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents TBconvin_nr As TextBox
    Friend WithEvents TBknaam As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents GRPAdres As GroupBox
    Friend WithEvents TBkadres As TextBox
    Friend WithEvents TBkstraat As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GRPWerf As GroupBox
    Friend WithEvents TBkwadres As TextBox
    Friend WithEvents TBkwstraat As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GRPContact As GroupBox
    Friend WithEvents TBkemail As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TBkfax As TextBox
    Friend WithEvents TBkgsm As TextBox
    Friend WithEvents TBktel As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TSBexit As ToolStripButton
    Friend WithEvents ToolStripLabel4 As ToolStripLabel
    Friend WithEvents TSBsave As ToolStripButton
End Class
