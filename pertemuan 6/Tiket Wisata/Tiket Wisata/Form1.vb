Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_d_a.Items.Clear()
        cmb_d_a.Items.Add("dewasa")
        cmb_d_a.Items.Add("anak-anak")
    End Sub

    Private Function harga_tiket(tb As Integer, wd As Integer, sv As Integer, sc As Integer, cmd As Integer) As Integer
        Dim Tiket As Integer
        Tiket = tb - cmd
        Tiket = wd - cmd
        Tiket = sv - cmd
        Tiket = sc - cmd
        Return Tiket
    End Function

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Dim tb, wd, sv, sc, cmd As Integer
        tb = Val(rb_telaga_biru.Checked)
        wd = Val(rb_waaduk_darma.Checked)
        sv = Val(rb_sukageuri_view.Checked)
        sc = Val(rb_situ_cicerem.Checked)
        cmd = Val(cmd_d_a.Text)

        tb = 10000
        wd = 5000
        sv = 6000
        sc = 7000
        cmd = 1000

        Tiket = harga_tiket(tb, wd, sv, sc, cmd)

        txtHarga.Text = Str(Tiket)

    End Sub
End Class
