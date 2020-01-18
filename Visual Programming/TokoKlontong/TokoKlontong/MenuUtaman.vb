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
End Class
