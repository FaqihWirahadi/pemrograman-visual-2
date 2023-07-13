Public Class Tugas5_Menentukan_Nilai_Mutu_By_Reza_Ramadhan

    Private Function Hitung_Nilai_Mhs(N_K As Integer, N_T As Integer, N_UTS As Integer, N_UAS As Integer) As Integer
        Dim Hitung As Integer
        Hitung = (25% x N_K) + (35% x N_T) + (20% x N_UTS) + (20% x N_UAS)       
        Return Hitung
    End Function

    Private Function Penggunaan_if(N_K As Integer, N_T As Integer, N_UTS As Integer, N_UAS As Integer) As Integer
        Dim Mutu As Integer
        If (Str(txtNilai_Akhir.Text) >= 85) Then
            txtNilai_Mutu.Text = "A"
            txtKeterangan.Text = "Nilai Bagus Anda Lulus "
        ElseIf (txtNilai_Akhir.Text >= 71) Then
            txtNilai_Mutu.Text = "B"
            txtKeterangan.Text = "Anda Lulus Nilai Standar"
        ElseIf (txtNilai_Akhir.Text >= 60) Then
            txtNilai_Mutu.Text = "C"
            txtKeterangan.Text = "Anda Lulus Dengan Nilai"
        ElseIf (txtNilai_Akhir.Text >= 50) Then
            txtNilai_Mutu.Text = "D"
            txtKeterangan.Text = "Maaf Anda Tidak Lulus"
        Else
            txtNilai_Mutu.Text = "E"
        End If
    End Function

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Nim, Nama, Prodi, N_K, N_T, N_UTS, N_UAS, N_A As Decimal

        Nim = Val(txtNim.Text)
        Nama = Val(txtNama.Text)
        Prodi = Val(txtProdi.Text)
        N_K = Val(txtNilai_Kehadiran.Text)
        N_T = Val(txtNilai_Tugas.Text)
        N_UTS = Val(txtNilai_UTS.Text)
        N_UAS = Val(txtNilai_UAS.Text)

        Nilai_Mutu = Hitung_Nilai_Mhs(N_K, N_T, N_UTS, N_UAS)
        Nilai_Mutu2 = Penggunaan_if(N_K, N_T, N_UTS, N_UAS)


        txtNilai_Akhir.Text = Str(Nilai_Mutu) And Str(Nilai_Mutu2)
        txtNama2.Text = Str(Nama)
        txtProdi2.Text = Str(Prodi)
    End Sub
End Class
