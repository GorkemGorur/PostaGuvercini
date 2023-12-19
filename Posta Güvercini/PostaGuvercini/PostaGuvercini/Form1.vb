Imports System.Net
Imports System.Net.Mail
Public Class Form1
    Private Kapat As Boolean = False
    Private KimdenEPosta, KimdenSifre As String
    Public Sub New()
        Dim KimdenEPostaFormu As New KimdenBilgiFormu
        If KimdenEPostaFormu.ShowDialog = DialogResult.OK Then
            Kapat = False
            KimdenEPosta = KimdenEPostaFormu.EPostaTBox.Text.Trim
            KimdenSifre = KimdenEPostaFormu.SifreTBox.Text
        Else
            Kapat = True
        End If
        InitializeComponent()
    End Sub

    Private Sub DosyaEkleBtn_Click(sender As Object, e As EventArgs) Handles DosyaEkleBtn.Click
        'DosyaSecOFD'ye ait tüm özellikler Properties kısmından düzenlendi
        If DosyaSecOFD.ShowDialog = DialogResult.OK Then
            Dim Muzik() As String = {".mp3", ".wav", " m4a", ".mov", ".wma"}
            Dim Resim() As String = {".jpg", ".jpeg", ".bmp", ".png", ".giff", ".raw", ".webp"}
            Dim Zipli() As String = {".zip", ".rar", ".7z", ".gz"}
            For Each Dosya As String In DosyaSecOFD.FileNames
                Dim Eleman As New ListViewItem
                Eleman.Text = IO.Path.GetFileName(Dosya)
                Eleman.Tag = Dosya
                Dim Uzanti As String = IO.Path.GetExtension(Dosya)
                If Muzik.Contains(Uzanti) Then
                    Eleman.ImageIndex = 1
                ElseIf Resim.Contains(Uzanti) Then
                    Eleman.ImageIndex = 2
                ElseIf Zipli.Contains(Uzanti) Then
                    Eleman.ImageIndex = 3
                Else
                    Eleman.ImageIndex = 0
                End If
                DosyaEkiLV.Items.Add(Eleman)
            Next
        End If
    End Sub

    Private Sub BüyükSimgelerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BüyükSimgelerToolStripMenuItem.Click
        DosyaEkiLV.View = View.LargeIcon
        For Each MenuEleman As ToolStripMenuItem In DosyaGorunumCMenu.Items
            MenuEleman.Checked = False
        Next
        Dim Menu As ToolStripMenuItem = sender
        Menu.Checked = True
    End Sub

    Private Sub KüçükSimgelerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KüçükSimgelerToolStripMenuItem.Click
        DosyaEkiLV.View = View.SmallIcon
        For Each MenuEleman As ToolStripMenuItem In DosyaGorunumCMenu.Items
            MenuEleman.Checked = False
        Next
        Dim Menu As ToolStripMenuItem = sender
        Menu.Checked = True
    End Sub

    Private Sub ListeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListeToolStripMenuItem.Click
        DosyaEkiLV.View = View.List
        For Each MenuEleman As ToolStripMenuItem In DosyaGorunumCMenu.Items
            MenuEleman.Checked = False
        Next
        Dim Menu As ToolStripMenuItem = sender
        Menu.Checked = True
    End Sub

    Private Sub DosyaCikartBtn_Click(sender As Object, e As EventArgs) Handles DosyaCikartBtn.Click
        For Each Eleman As ListViewItem In DosyaEkiLV.SelectedItems
            Eleman.Remove()
        Next
    End Sub

    Private Sub GonderBtn_Click(sender As Object, e As EventArgs) Handles GonderBtn.Click
        'EPosta nesnesini oluştur
        Dim EPostaMesaj As New MailMessage
        EPostaMesaj.From = New MailAddress(KimdenEPosta)
        Dim Kime As String = KimeTBox.Text.Trim
        Dim Bilgi As String = BilgiTBox.Text.Trim
        Dim Gizli As String = GizliTBox.Text.Trim
        If Not String.IsNullOrWhiteSpace(Kime) Then
            If TopluEPostaKontrolu(Kime) Then
                EPostaMesaj.To.Add(Kime)
            Else
                MessageBox.Show("Kime kısmına yazılan E-Posta adresi veya adresleri hatalı. Lütfen Kontrol Ediniz.", "Hata")
                Exit Sub
            End If
        End If
        If Not String.IsNullOrWhiteSpace(Bilgi) Then
            If TopluEPostaKontrolu(Bilgi) Then
                EPostaMesaj.CC.Add(Bilgi)
            Else
                MessageBox.Show("Bilgi kısmına yazılan E-Posta adresi veya adresleri hatalı. Lütfen Kontrol Ediniz.", "Hata")
                Exit Sub
            End If
        End If
        If Not String.IsNullOrWhiteSpace(Gizli) Then
            If TopluEPostaKontrolu(Gizli) Then
                EPostaMesaj.Bcc.Add(Gizli)
            Else
                MessageBox.Show("Gizli kısmına yazılan E-Posta adresi veya adresleri hatalı. Lütfen Kontrol Ediniz.", "Hata")
                Exit Sub
            End If
        End If
        If String.IsNullOrEmpty(Kime) And String.IsNullOrEmpty(Bilgi) And String.IsNullOrEmpty(Gizli) Then
            MessageBox.Show("Kime, Bilgi veya Gizli kısımlarından en az birine E-Posta adresi girmelisiniz.", "Eksik Veri Girişi")
            Exit Sub
        End If
        'Konuyu Ekle
        Dim Konu As String = KonuTBox.Text.Trim
        EPostaMesaj.Subject = Konu
        'Mesaj Metnini Ekle
        EPostaMesaj.IsBodyHtml = True
        EPostaMesaj.Body = MesajMetinHEC.InnerHtml
        'Dosya Eklerini Ekle
        For Each Eleman As ListViewItem In DosyaEkiLV.Items
            Dim Dosya As New IO.FileInfo(Eleman.Tag)
            If Dosya.Exists Then
                EPostaMesaj.Attachments.Add(New Attachment(Eleman.Tag))
            End If
        Next
        'E-Posta Göndermek için SMTP sucnucusuna Bağlan
        Dim SMTPistemci As New SmtpClient
        SMTPistemci.Host = "smtp.gmail.com"
        SMTPistemci.Port = 587
        SMTPistemci.EnableSsl = True
        Try
            SMTPistemci.Credentials = New NetworkCredential(KimdenEPosta, KimdenSifre)
            SMTPistemci.Send(EPostaMesaj)
            MessageBox.Show("E-Posta iletiniz başarı ile gönderildi.", "Bilgi")
            KimeTBox.Clear()
            BilgiTBox.Clear()
            GizliTBox.Clear()
            KonuTBox.Clear()
            MesajMetinHEC.InnerHtml = String.Empty
            DosyaEkiLV.Clear()
        Catch ex As Exception
            MessageBox.Show("Hata oluştu. E-Posta iletiniz gönderilemedi. Hata: " & ex.Message, "Hata")
        End Try
    End Sub

    Private Function TopluEPostaKontrolu(EPostaAdresleri As String) As Boolean
        Dim Sonuc As Boolean = True
        Dim EPostaDizisi() As String = EPostaAdresleri.Split(",")
        For Each EPosta As String In EPostaDizisi
            If Not IsValidEmail(EPosta) Then
                Sonuc = False
            End If
        Next
        Return Sonuc
    End Function

    Private Sub KimdenBilgisiniDeğiştirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KimdenBilgisiniDeğiştirToolStripMenuItem.Click
        Dim KimdenEPostaFormu As New KimdenBilgiFormu
        If KimdenEPostaFormu.ShowDialog = DialogResult.OK Then
            KimdenEPosta = KimdenEPostaFormu.EPostaTBox.Text.Trim
            KimdenSifre = KimdenEPostaFormu.SifreTBox.Text
        Else
            MessageBox.Show("Kimden bilgisi değiştirilmedi. Önceki bilgiler kullanılacak.", "Bilgi")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Kapat Then
            Me.Close()
        End If
    End Sub
End Class
