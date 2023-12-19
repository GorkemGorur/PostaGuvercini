Public Class KimdenBilgiFormu

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim EPosta, Sifre As String
        EPosta = EPostaTBox.Text.Trim
        Sifre = SifreTBox.Text
        If IsValidEmail(EPosta) And Sifre.Count > 2 Then
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Else
            MessageBox.Show("E-Posta adersiniz hatalý veya þifreniz yeterli uzunlukta deðil.", "Hata")
        End If

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

End Class
