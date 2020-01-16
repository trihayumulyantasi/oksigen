Imports TokoKlontong.Koneksi
Imports MySql.Data.MySqlClient
Public Class MenuUtama
    Private Sub btsupplier_Click(sender As Object, e As EventArgs) Handles btsupplier.Click
        frmSupplier.Show()
    End Sub

    Private Sub btbarang_Click(sender As Object, e As EventArgs) Handles btbarang.Click
        Barang.Show()
    End Sub
End Class