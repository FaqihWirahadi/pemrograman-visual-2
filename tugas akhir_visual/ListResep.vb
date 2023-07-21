Option Explicit On
Option Strict On
Imports MySql.Data.MySqlClient
Public Class ListResep
    Public Property ID As String
    Private Sub FormPemeriksaanDokter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
    End Sub

    Private Sub loadData(Optional keyword As String = "")
        SQL = "SELECT * FROM tb_resep WHERE id_rekam=" & Me.ID & " ORDER BY nama ASC "


        Cmd = New MySqlCommand(SQL, Con)
        Cmd.Parameters.Clear()

        Dim dt As DataTable = PerformCRUD(Cmd)

        ListBox2.DataSource = dt

        ListBox2.DisplayMember = "nama"



    End Sub



End Class