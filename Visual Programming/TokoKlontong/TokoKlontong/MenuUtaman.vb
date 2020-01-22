Imports TokoKlontong.Koneksi
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Public Class MenuUtaman
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
        Login.Show()
    End Sub

    Private Sub AdminToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdminToolStripMenuItem.Click
        Dim formCollection = System.Windows.Forms.Application.OpenForms
        If formCollection.OfType(Of admin).Any Then

        Else
            Dim admin As New admin
            admin.Show()
            admin.MdiParent = Me
        End If
    End Sub

    Private Sub BarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BarangToolStripMenuItem.Click
        Dim formCollection = System.Windows.Forms.Application.OpenForms
        If formCollection.OfType(Of Barang).Any Then

        Else
            Dim barang As New Barang
            barang.Show()
            barang.MdiParent = Me
        End If
    End Sub

    Private Sub SupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupplierToolStripMenuItem.Click
        Dim formCollection = System.Windows.Forms.Application.OpenForms
        If formCollection.OfType(Of frmSupplier).Any Then

        Else
            Dim supplier As New frmSupplier
            supplier.Show()
            supplier.MdiParent = Me
        End If
    End Sub

    'Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
    'Me.BackColor = Nothing
    'AllowTransparency = Enabled
    ' Me.SendToBack.Enabled()
    'End Sub

    Private Sub LaporanSupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanSupplierToolStripMenuItem.Click
        Dim formCollection = System.Windows.Forms.Application.OpenForms
        If formCollection.OfType(Of LaporanSupplier).Any Then

        Else
            Dim laporansupplier As New LaporanSupplier
            laporansupplier.Show()
            laporansupplier.MdiParent = Me
        End If
    End Sub

    Private Sub PanduanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PanduanToolStripMenuItem.Click
        Dim formCollection = System.Windows.Forms.Application.OpenForms
        If formCollection.OfType(Of panduan).Any Then

        Else
            Dim panduan As New panduan
            panduan.Show()
            panduan.MdiParent = Me
        End If
    End Sub

    Private Sub TentangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TentangToolStripMenuItem.Click
        Dim formCollection = System.Windows.Forms.Application.OpenForms
        If formCollection.OfType(Of Tentang).Any Then

        Else
            Dim Tentang As New Tentang
            Tentang.Show()
            Tentang.MdiParent = Me
        End If
    End Sub
End Class
