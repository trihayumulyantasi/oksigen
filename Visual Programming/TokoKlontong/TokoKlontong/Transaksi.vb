Imports TokoKlontong.Koneksi
Imports MySql.Data.MySqlClient
Public Class Transaksi
    Sub statusbersih()
        lbtanggal.Text = Today
        tbdiskon.Text = ""
        tbpembayaran.Text = ""
        lbkembalian.Text = ""
        lbtotalbayar.Text = ""
        lbtotalitem.Text = ""
        lbidbarang.Text = ""
        lbnamabarang.Text = ""
        lbhargabarang.Text = ""
    End Sub

    Private Sub tampildata()
        If (conn.State) <> ConnectionState.Closed Then conn.Close()
        KoneksiBuka()
        Dim dt As DataTable
        Dim adapter As MySqlDataAdapter
        Dim query As String
        Dim data As Integer

        query = "select id_barang, nama_barang, harga_jual, stock from barang"
        adapter = New MySqlDataAdapter(query, conn)
        dt = New DataTable
        data = adapter.Fill(dt)

        If data > 0 Then
            databarang.DataSource = dt
            databarang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
            databarang.Columns(0).HeaderText = "Id Barang"
            databarang.Columns(1).HeaderText = "Nama Barang"
            databarang.Columns(2).HeaderText = "Harga"
            databarang.Columns(3).HeaderText = "Stock"

        Else
            databarang.DataSource = Nothing
        End If
    End Sub

    Private Sub tbcari_TextChanged(sender As Object, e As EventArgs) Handles tbcari.TextChanged
        If (conn.State) <> ConnectionState.Closed Then conn.Close()
        KoneksiBuka()
        Dim dt As DataTable
        Dim adapter As MySqlDataAdapter
        Dim query As String
        Dim data As Integer

        query = "select * from barang where nama_barang like '%" & tbcari.Text & "%'"
        adapter = New MySqlDataAdapter(query, conn)
        dt = New DataTable
        data = adapter.Fill(dt)

        If data > 0 Then
            databarang.DataSource = dt
            databarang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
            databarang.Columns(0).HeaderText = "Id Barang"
            databarang.Columns(1).HeaderText = "Nama Barang"
            databarang.Columns(2).HeaderText = "Harga Jual"
            databarang.Columns(3).HeaderText = "Harga Supplier"
            databarang.Columns(4).HeaderText = "Stock"
            databarang.Columns(5).HeaderText = "Nama Supplier"
            databarang.Columns(6).HeaderText = "Waktu Input"
            databarang.Columns(7).HeaderText = "Nama Admin"

        Else
            databarang.DataSource = Nothing
        End If
    End Sub

    Private Sub Transaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        statusbersih()
        tampildata()
        nofaktur()
    End Sub
    Sub notransaksi()
     
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbjam.Text = TimeOfDay
    End Sub

    Sub nofaktur()
        Try
            KoneksiBuka()
            CMD = New MySqlCommand
            CMD.Connection = conn
            str = "select * from transaksi where id_transaksi in(select max(id_transaksi) from transaksi) order by id_transaksi DESC"
            CMD.CommandText = str
            MySQLReader = CMD.ExecuteReader
            MySQLReader.Read()

            If Not MySQLReader.HasRows Then
                tbnotrans.Text = Format(Now, "yyMMdd") + "0001"
            Else
                If Microsoft.VisualBasic.Left(MySQLReader.GetString(0), 6) <> Format(Now, "yyMMdd") Then
                    tbnotrans.Text = Format(Now, "yyMMdd") + "0001"
                Else
                    tbnotrans.Text = MySQLReader.Item("id_transaksi") + 1

                End If
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub databarang_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles databarang.CellMouseClick
        lbidbarang.Text = databarang.Rows(e.RowIndex).Cells(0).Value
        lbnamabarang.Text = databarang.Rows(e.RowIndex).Cells(1).Value
        lbhargabarang.Text = databarang.Rows(e.RowIndex).Cells(2).Value

        For i As Integer = 0 To datadibeli.RowCount - 1
            For j As Integer = i + 1 To datadibeli.RowCount - 1
                If datadibeli.Rows(i).Cells(0).Value = datadibeli.Rows(j).Cells(0).Value Then
                    MessageBox.Show("Kode barang " & datadibeli.Rows(i).Cells(0).Value & " Sudah di entri")
                    SendKeys.Send("{UP}")
                    datadibeli.Rows(j).Cells(0).Value = ""
                    datadibeli.Rows(j).Cells(1).Value = ""
                    datadibeli.Rows(j).Cells(2).Value = ""
                    datadibeli.Rows(j).Cells(3).Value = ""
                    datadibeli.Rows(j).Cells(4).Value = ""
                    datadibeli.Rows.RemoveAt(j)
                    Exit Sub
                End If
            Next
        Next

        Call totalitem()
        Call totalbayar()

    End Sub
    Sub totalitem()
        Dim hitung As Integer = 0
        For baris As Integer = 0 To datadibeli.RowCount - 1
            hitung = hitung + datadibeli.Rows(baris).Cells(3).Value
            lbtotalitem.Text = hitung
        Next
    End Sub
    Sub totalbayar()
        Dim hitung As Integer = 0
        For baris As Integer = 0 To datadibeli.RowCount - 1
            hitung = hitung + datadibeli.Rows(baris).Cells(4).Value
            lbtotalbayar.Text = hitung
        Next
    End Sub


    Private Sub datadibeli_KeyPress(sender As Object, e As KeyPressEventArgs) Handles datadibeli.KeyPress
        On Error Resume Next
        If e.KeyChar = Chr(27) Then
            Dim yakinhapus As MsgBoxResult = MessageBox.Show("Yakin mau dihapus", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If yakinhapus = vbYes Then
                datadibeli.Rows.Remove(datadibeli.CurrentRow)
            End If
            Call totalitem()
            Call totalbayar()
        End If
    End Sub

    Private Sub datadibeli_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles datadibeli.CellEndEdit
        If e.ColumnIndex = 3 Then
            Try
                datadibeli.Rows(e.RowIndex).Cells(4).Value = datadibeli.Rows(e.RowIndex).Cells(2).Value * datadibeli.Rows(e.RowIndex).Cells(3).Value
            Catch ex As Exception
                MsgBox("Masukkan angka saja")
                SendKeys.Send("{UP}")
                datadibeli.Rows(e.RowIndex).Cells(3).Value = 1
                
            End Try

        End If
        Call totalbayar()
        Call totalitem()
    End Sub

    Private Sub tbdiskon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbdiskon.KeyPress
        If Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
        If e.KeyChar = Chr(13) Then
            lbtotalbayar.Text = Val(lbtotalbayar.Text) - (Val(lbtotalbayar.Text) * Val(tbdiskon.Text) / 100)
        End If
    End Sub

    Private Sub tbpembayaran_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbpembayaran.KeyPress
        If Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
        If e.KeyChar = Chr(13) Then
            If Val(tbpembayaran.Text) < Val(lbtotalbayar.Text) Then
                MsgBox("Pembayaran Kurang")
                tbpembayaran.Text = ""
                Exit Sub
            ElseIf Val(tbpembayaran.Text) = Val(lbtotalbayar.Text) Then
                lbkembalian.Text = 0
            ElseIf Val(tbpembayaran.Text) > Val(lbtotalbayar.Text) Then
                lbkembalian.Text = Val(tbpembayaran.Text) - Val(lbtotalbayar.Text)
            End If
        End If
    End Sub

    Private Sub btnmenuutaman_Click(sender As Object, e As EventArgs) Handles btnmenuutaman.Click
        Menuaja.Show()
        Me.Close()
    End Sub

    Private Sub btnbersih_Click(sender As Object, e As EventArgs) Handles btnbersih.Click
        statusbersih()
        datadibeli.Rows.Clear()
        tbnotrans.Text = ""
    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        If (conn.State) <> ConnectionState.Closed Then conn.Close()
        KoneksiBuka()
        Try
            Dim qinsert As String
            CMD.CommandType = CommandType.Text
            qinsert = "insert into transaksi(id_transaksi, tanggal, waktu, total_item, diskon, total_harga, pembayaran, kembalian)"
            qinsert = qinsert & "values('" & tbnotrans.Text & "', '" & lbtanggal.Text & "', '" & lbjam.Text & "', '" & lbtotalitem.Text & "', '" & tbdiskon.Text & "', '" & lbtotalbayar.Text & "', '" & tbpembayaran.Text & "', '" & lbkembalian.Text & "')"
            CMD.CommandType = CommandType.Text
            CMD.CommandText = qinsert
            CMD.Connection = conn
            CMD.ExecuteNonQuery()

            tampildata()
        Catch ex As Exception
            MsgBox("Gagal Simpan " + ex.Message, MsgBoxStyle.Critical, "Terjadi Kesalahan")

        End Try
    End Sub
    Private Sub btninput_Click(sender As Object, e As EventArgs) Handles btninput.Click
        If tbjumlah.Text = "" Then
            MsgBox("Masukkan jumlah barang terlebih dahulu")
            tbjumlah.Focus()
        Else
            Dim harga As Integer
            harga = Val(lbhargabarang.Text) * Val(tbjumlah.Text)
            datadibeli.Rows.Add(New String() {lbidbarang.Text, lbnamabarang.Text, lbhargabarang.Text, tbjumlah.Text, harga})

            Try
                Dim qinsert As String
                CMD.CommandType = CommandType.Text
                qinsert = "insert into detail_transaksi(id_detailtrans, tanggal, waktu, nama_barang, harga_barang, jumlah)"
                qinsert = qinsert & "values('" & tbnotrans.Text & "', '" & lbtanggal.Text & "', '" & lbjam.Text & "', '" & lbnamabarang.Text & "', '" & lbhargabarang.Text & "', '" & tbjumlah.Text & "')"
                CMD.CommandType = CommandType.Text
                CMD.CommandText = qinsert
                CMD.Connection = conn
                CMD.ExecuteNonQuery()
            Catch ex As Exception

            End Try
        End If
        
        lbidbarang.Text = ""
        lbnamabarang.Text = ""
        lbhargabarang.Text = ""
        tbjumlah.Text = ""
        Call totalbayar()
        Call totalitem()
    End Sub
End Class