Imports TokoKlontong.Koneksi
Imports MySql.Data.MySqlClient
Public Class Menuaja

    Private Sub btnadmin_Click(sender As Object, e As EventArgs) Handles btnadmin.Click
        Me.Close()
        admin.Show()
    End Sub

    Private Sub btnbarang_Click(sender As Object, e As EventArgs) Handles btnbarang.Click
        Me.Close()
        Barang.Show()
    End Sub

    Private Sub btnsupplier_Click(sender As Object, e As EventArgs) Handles btnsupplier.Click
        Me.Close()
        frmSupplier.Show()
    End Sub

    Private Sub btnlapsupplier_Click(sender As Object, e As EventArgs) Handles btnlapsupplier.Click
        Me.Close()
        LaporanSupplier.Show()
    End Sub

    Private Sub btnpanduan_Click(sender As Object, e As EventArgs) Handles btnpanduan.Click
        Me.Close()
        panduan.Show()
    End Sub

    Private Sub btntentang_Click(sender As Object, e As EventArgs) Handles btntentang.Click
        Me.Close()
        Tentang.Show()
    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        If (conn.State) <> ConnectionState.Closed Then conn.Close()
        KoneksiBuka()
        Dim yakinhapus As MsgBoxResult = MessageBox.Show("Yakin mau logout?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If yakinhapus = vbYes Then
            Me.Close()
            Login.Show()
        End If
    End Sub

    Private Sub btntransaksi_Click(sender As Object, e As EventArgs) Handles btntransaksi.Click
        Transaksi.Show()
        Me.Close()
    End Sub

    Private Sub btnlapbulanan_Click(sender As Object, e As EventArgs) Handles btnlapbulanan.Click
        LaporanTransaksi.Show()
        Me.Close()
    End Sub
End Class