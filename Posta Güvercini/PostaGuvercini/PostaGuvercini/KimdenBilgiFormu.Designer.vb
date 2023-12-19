<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class KimdenBilgiFormu
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
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents EPostaTBox As System.Windows.Forms.TextBox
    Friend WithEvents SifreTBox As System.Windows.Forms.TextBox
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.EPostaTBox = New System.Windows.Forms.TextBox()
        Me.SifreTBox = New System.Windows.Forms.TextBox()
        Me.OK = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Dock = System.Windows.Forms.DockStyle.Left
        Me.LogoPictureBox.Image = Global.PostaGuvercini.My.Resources.Resources.Giris
        Me.LogoPictureBox.Location = New System.Drawing.Point(0, 0)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(165, 139)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.LogoPictureBox.TabIndex = 0
        Me.LogoPictureBox.TabStop = False
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Location = New System.Drawing.Point(172, 9)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(220, 23)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "&E-Posta Adresi:"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Location = New System.Drawing.Point(172, 54)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(220, 23)
        Me.PasswordLabel.TabIndex = 2
        Me.PasswordLabel.Text = "Ş&ifre:"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EPostaTBox
        '
        Me.EPostaTBox.Location = New System.Drawing.Point(174, 29)
        Me.EPostaTBox.Name = "EPostaTBox"
        Me.EPostaTBox.Size = New System.Drawing.Size(220, 20)
        Me.EPostaTBox.TabIndex = 1
        '
        'SifreTBox
        '
        Me.SifreTBox.Location = New System.Drawing.Point(174, 74)
        Me.SifreTBox.Name = "SifreTBox"
        Me.SifreTBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.SifreTBox.Size = New System.Drawing.Size(220, 20)
        Me.SifreTBox.TabIndex = 3
        '
        'OK
        '
        Me.OK.Location = New System.Drawing.Point(197, 100)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(94, 34)
        Me.OK.TabIndex = 4
        Me.OK.Text = "&Tamam"
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Location = New System.Drawing.Point(300, 100)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(94, 34)
        Me.Cancel.TabIndex = 5
        Me.Cancel.Text = "&Vazgeç"
        '
        'KimdenBilgiFormu
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(401, 139)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.SifreTBox)
        Me.Controls.Add(Me.EPostaTBox)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "KimdenBilgiFormu"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Kimden Bilgileri"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

End Class
