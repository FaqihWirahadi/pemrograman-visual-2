Public Class Tugas5_Menentukan_Nilai_Mhs_faqih

    Private Function Hitung_Nilai_Mhs(N_K As Integer, N_T As Integer, N_UTS As Integer, N_UAS As Integer) As Integer
        Dim Hitung As Integer
        Hitung = (25% x KHD) + (35% x TGS) + (20% x UTS) + (20% x UAS)       
        Return Hitung
    End Function

    Private Function Penggunaan_if(N_M As Integer, N_A As Integer, N_M As Integer, K As Integer) As Integer
        Dim Keterangan As Integer
        If (Str(N_A) >= 85) Then
            N_M = "A"
            K = "Nilai Bagus Anda Lulus "
        ElseIf (N_A >= 71) Then
            N_M = "B"
            K = "Anda Lulus Nilai Standar"
        ElseIf (N_A >= 60) Then
            N_M = "C"
            K = "Anda Lulus Dengan Nilai"
        ElseIf (N_A >= 50) Then
            N_M = "D"
            K = "Maaf Anda Tidak Lulus"
        Else
            N_M = "E"
            K = "Maaf Anda Tidak Lulus"
        End If
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Nim, Nama, Prodi, N_K, N_T, N_UTS, N_UAS, N_M, N_A, K As Decimal

        Nim = Val(txtNim.Text)
        Nama = Val(txtNama.Text)
        Prodi = Val(txtProdi.Text)
        N_K = Val(txtNilai_Kehadiran.Text)
        N_T = Val(txtNilai_Tugas.Text)
        N_UTS = Val(txtNilai_UTS.Text)
        N_UAS = Val(txtNilai_UAS.Text)

        Tugas5_Menentukan_Nilai_Mhs = Hitung_Nilai_Mh, Penggunaan_If(N_K, N_T, N_UTS, N_UAS, N_M)
        Pengguna_If = Penggunaan_if(N_M, N_A, N_A, K)

        txtNilai_Akhir.Text = Str(Tugas5_Menentukan_Nilai_Mhs, Penggunaan_if)
        txtNim2.Text = Str(Nim)
        txtNama2.Text = Str(Nama)
        txtProdi2.Text = Str(Prodi)
    End Sub
End Class