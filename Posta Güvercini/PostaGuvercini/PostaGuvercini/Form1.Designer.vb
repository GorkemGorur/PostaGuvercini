<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.AnaMenu = New System.Windows.Forms.MenuStrip()
        Me.ProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DurumCubugu = New System.Windows.Forms.StatusStrip()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GonderBtn = New System.Windows.Forms.Button()
        Me.DosyaCikartBtn = New System.Windows.Forms.Button()
        Me.DosyaEkleBtn = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DosyaEkiLV = New System.Windows.Forms.ListView()
        Me.KonuTBox = New System.Windows.Forms.TextBox()
        Me.GizliTBox = New System.Windows.Forms.TextBox()
        Me.BilgiTBox = New System.Windows.Forms.TextBox()
        Me.KimeTBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MesajMetinHEC = New MSDN.Html.Editor.HtmlEditorControl()
        Me.DosyaSecOFD = New System.Windows.Forms.OpenFileDialog()
        Me.DosyaikonListesiBuyuk = New System.Windows.Forms.ImageList(Me.components)
        Me.DosyaikonListesiKucuk = New System.Windows.Forms.ImageList(Me.components)
        Me.DosyaGorunumCMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BüyükSimgelerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KüçükSimgelerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyarlarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KimdenBilgisiniDeğiştirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnaMenu.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.DosyaGorunumCMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'AnaMenu
        '
        Me.AnaMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgramToolStripMenuItem, Me.AyarlarToolStripMenuItem})
        Me.AnaMenu.Location = New System.Drawing.Point(0, 0)
        Me.AnaMenu.Name = "AnaMenu"
        Me.AnaMenu.Size = New System.Drawing.Size(817, 24)
        Me.AnaMenu.TabIndex = 0
        Me.AnaMenu.Text = "MenuStrip1"
        '
        'ProgramToolStripMenuItem
        '
        Me.ProgramToolStripMenuItem.Name = "ProgramToolStripMenuItem"
        Me.ProgramToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ProgramToolStripMenuItem.Text = "&Program"
        '
        'DurumCubugu
        '
        Me.DurumCubugu.Location = New System.Drawing.Point(0, 571)
        Me.DurumCubugu.Name = "DurumCubugu"
        Me.DurumCubugu.Size = New System.Drawing.Size(817, 22)
        Me.DurumCubugu.TabIndex = 1
        Me.DurumCubugu.Text = "StatusStrip1"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 24)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GonderBtn)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DosyaCikartBtn)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DosyaEkleBtn)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DosyaEkiLV)
        Me.SplitContainer1.Panel1.Controls.Add(Me.KonuTBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GizliTBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.BilgiTBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.KimeTBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.MesajMetinHEC)
        Me.SplitContainer1.Size = New System.Drawing.Size(817, 547)
        Me.SplitContainer1.SplitterDistance = 220
        Me.SplitContainer1.TabIndex = 2
        '
        'GonderBtn
        '
        Me.GonderBtn.Location = New System.Drawing.Point(739, 18)
        Me.GonderBtn.Name = "GonderBtn"
        Me.GonderBtn.Size = New System.Drawing.Size(66, 188)
        Me.GonderBtn.TabIndex = 13
        Me.GonderBtn.Text = "E-Posta Gönder"
        Me.GonderBtn.UseVisualStyleBackColor = True
        '
        'DosyaCikartBtn
        '
        Me.DosyaCikartBtn.Location = New System.Drawing.Point(700, 13)
        Me.DosyaCikartBtn.Name = "DosyaCikartBtn"
        Me.DosyaCikartBtn.Size = New System.Drawing.Size(33, 23)
        Me.DosyaCikartBtn.TabIndex = 12
        Me.DosyaCikartBtn.Text = "-"
        Me.DosyaCikartBtn.UseVisualStyleBackColor = True
        '
        'DosyaEkleBtn
        '
        Me.DosyaEkleBtn.Location = New System.Drawing.Point(667, 13)
        Me.DosyaEkleBtn.Name = "DosyaEkleBtn"
        Me.DosyaEkleBtn.Size = New System.Drawing.Size(33, 23)
        Me.DosyaEkleBtn.TabIndex = 11
        Me.DosyaEkleBtn.Text = "+"
        Me.DosyaEkleBtn.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(586, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Dosya Eki:"
        '
        'DosyaEkiLV
        '
        Me.DosyaEkiLV.ContextMenuStrip = Me.DosyaGorunumCMenu
        Me.DosyaEkiLV.HideSelection = False
        Me.DosyaEkiLV.LargeImageList = Me.DosyaikonListesiBuyuk
        Me.DosyaEkiLV.Location = New System.Drawing.Point(586, 37)
        Me.DosyaEkiLV.Name = "DosyaEkiLV"
        Me.DosyaEkiLV.Size = New System.Drawing.Size(147, 166)
        Me.DosyaEkiLV.SmallImageList = Me.DosyaikonListesiKucuk
        Me.DosyaEkiLV.TabIndex = 9
        Me.DosyaEkiLV.UseCompatibleStateImageBehavior = False
        '
        'KonuTBox
        '
        Me.KonuTBox.Location = New System.Drawing.Point(53, 183)
        Me.KonuTBox.Name = "KonuTBox"
        Me.KonuTBox.Size = New System.Drawing.Size(527, 20)
        Me.KonuTBox.TabIndex = 7
        '
        'GizliTBox
        '
        Me.GizliTBox.Location = New System.Drawing.Point(53, 127)
        Me.GizliTBox.Multiline = True
        Me.GizliTBox.Name = "GizliTBox"
        Me.GizliTBox.Size = New System.Drawing.Size(527, 50)
        Me.GizliTBox.TabIndex = 6
        '
        'BilgiTBox
        '
        Me.BilgiTBox.Location = New System.Drawing.Point(53, 71)
        Me.BilgiTBox.Multiline = True
        Me.BilgiTBox.Name = "BilgiTBox"
        Me.BilgiTBox.Size = New System.Drawing.Size(527, 50)
        Me.BilgiTBox.TabIndex = 5
        '
        'KimeTBox
        '
        Me.KimeTBox.Location = New System.Drawing.Point(53, 15)
        Me.KimeTBox.Multiline = True
        Me.KimeTBox.Name = "KimeTBox"
        Me.KimeTBox.Size = New System.Drawing.Size(527, 50)
        Me.KimeTBox.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 186)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Konu"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Gizli:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Bilgi:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kime:"
        '
        'MesajMetinHEC
        '
        Me.MesajMetinHEC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MesajMetinHEC.InnerText = Nothing
        Me.MesajMetinHEC.Location = New System.Drawing.Point(0, 0)
        Me.MesajMetinHEC.Name = "MesajMetinHEC"
        Me.MesajMetinHEC.Size = New System.Drawing.Size(817, 323)
        Me.MesajMetinHEC.TabIndex = 0
        '
        'DosyaSecOFD
        '
        Me.DosyaSecOFD.Filter = "Tüm Dosyalar|*.*"
        Me.DosyaSecOFD.Multiselect = True
        Me.DosyaSecOFD.RestoreDirectory = True
        Me.DosyaSecOFD.Title = "Gönderilecek Dosyaları Seç"
        '
        'DosyaikonListesiBuyuk
        '
        Me.DosyaikonListesiBuyuk.ImageStream = CType(resources.GetObject("DosyaikonListesiBuyuk.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.DosyaikonListesiBuyuk.TransparentColor = System.Drawing.Color.Transparent
        Me.DosyaikonListesiBuyuk.Images.SetKeyName(0, "Dosya48.png")
        Me.DosyaikonListesiBuyuk.Images.SetKeyName(1, "Muzik48.png")
        Me.DosyaikonListesiBuyuk.Images.SetKeyName(2, "Resim48.png")
        Me.DosyaikonListesiBuyuk.Images.SetKeyName(3, "Zipli48.png")
        '
        'DosyaikonListesiKucuk
        '
        Me.DosyaikonListesiKucuk.ImageStream = CType(resources.GetObject("DosyaikonListesiKucuk.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.DosyaikonListesiKucuk.TransparentColor = System.Drawing.Color.Transparent
        Me.DosyaikonListesiKucuk.Images.SetKeyName(0, "Dosya24.png")
        Me.DosyaikonListesiKucuk.Images.SetKeyName(1, "Muzik24.png")
        Me.DosyaikonListesiKucuk.Images.SetKeyName(2, "Resim24.png")
        Me.DosyaikonListesiKucuk.Images.SetKeyName(3, "Zipli24.png")
        '
        'DosyaGorunumCMenu
        '
        Me.DosyaGorunumCMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BüyükSimgelerToolStripMenuItem, Me.KüçükSimgelerToolStripMenuItem, Me.ListeToolStripMenuItem})
        Me.DosyaGorunumCMenu.Name = "DosyaGorunumCMenu"
        Me.DosyaGorunumCMenu.Size = New System.Drawing.Size(157, 70)
        '
        'BüyükSimgelerToolStripMenuItem
        '
        Me.BüyükSimgelerToolStripMenuItem.Checked = True
        Me.BüyükSimgelerToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.BüyükSimgelerToolStripMenuItem.Name = "BüyükSimgelerToolStripMenuItem"
        Me.BüyükSimgelerToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.BüyükSimgelerToolStripMenuItem.Text = "Büyük Simgeler"
        '
        'KüçükSimgelerToolStripMenuItem
        '
        Me.KüçükSimgelerToolStripMenuItem.Name = "KüçükSimgelerToolStripMenuItem"
        Me.KüçükSimgelerToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.KüçükSimgelerToolStripMenuItem.Text = "Küçük Simgeler"
        '
        'ListeToolStripMenuItem
        '
        Me.ListeToolStripMenuItem.Name = "ListeToolStripMenuItem"
        Me.ListeToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ListeToolStripMenuItem.Text = "Liste"
        '
        'AyarlarToolStripMenuItem
        '
        Me.AyarlarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KimdenBilgisiniDeğiştirToolStripMenuItem})
        Me.AyarlarToolStripMenuItem.Name = "AyarlarToolStripMenuItem"
        Me.AyarlarToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.AyarlarToolStripMenuItem.Text = "&Ayarlar"
        '
        'KimdenBilgisiniDeğiştirToolStripMenuItem
        '
        Me.KimdenBilgisiniDeğiştirToolStripMenuItem.Name = "KimdenBilgisiniDeğiştirToolStripMenuItem"
        Me.KimdenBilgisiniDeğiştirToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.KimdenBilgisiniDeğiştirToolStripMenuItem.Text = "Kimden Bilgisini Değiştir"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(817, 593)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.DurumCubugu)
        Me.Controls.Add(Me.AnaMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.AnaMenu
        Me.Name = "Form1"
        Me.Text = "Posta Güvercini"
        Me.AnaMenu.ResumeLayout(False)
        Me.AnaMenu.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.DosyaGorunumCMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AnaMenu As MenuStrip
    Friend WithEvents ProgramToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DurumCubugu As StatusStrip
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents GonderBtn As Button
    Friend WithEvents DosyaCikartBtn As Button
    Friend WithEvents DosyaEkleBtn As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents DosyaEkiLV As ListView
    Friend WithEvents KonuTBox As TextBox
    Friend WithEvents GizliTBox As TextBox
    Friend WithEvents BilgiTBox As TextBox
    Friend WithEvents KimeTBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DosyaSecOFD As OpenFileDialog
    Friend WithEvents DosyaikonListesiBuyuk As ImageList
    Friend WithEvents DosyaikonListesiKucuk As ImageList
    Friend WithEvents MesajMetinHEC As MSDN.Html.Editor.HtmlEditorControl
    Friend WithEvents DosyaGorunumCMenu As ContextMenuStrip
    Friend WithEvents BüyükSimgelerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KüçükSimgelerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyarlarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KimdenBilgisiniDeğiştirToolStripMenuItem As ToolStripMenuItem
End Class
