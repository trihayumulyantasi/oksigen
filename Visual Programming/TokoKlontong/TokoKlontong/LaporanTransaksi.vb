Imports TokoKlontong.Koneksi
Imports MySql.Data.MySqlClient
Public Class LaporanTransaksi
    Private Sub LaporanTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      
    End Sub

    Private Sub dtp1_Click(sender As Object, e As EventArgs) Handles dtp1.Click
        Dim dt As DataTable
        Dim adapter As MySqlDataAdapter
        Dim query As String
        Dim data As String

        query = "select * from transaksi where tanggal = '" & Format(DateTimePicker1.Value.ToString("yyyy/MM/dd")) & "'"
        adapter = New MySqlDataAdapter(query, conn)
        dt = New DataTable
        data = adapter.Fill(dt)

        If data > 0 Then
            DataGridView1.DataSource = dt
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
            DataGridView1.Columns(0).HeaderText = "ID Transaksi"
            DataGridView1.Columns(1).HeaderText = "Tanggal"
            DataGridView1.Columns(2).HeaderText = "Waktu"
            DataGridView1.Columns(3).HeaderText = "Total Item"
            DataGridView1.Columns(4).HeaderText = "Diskon"
            DataGridView1.Columns(5).HeaderText = "Total Harga"
        Else
            DataGridView1.DataSource = Nothing
        End If
    End Sub
End Class