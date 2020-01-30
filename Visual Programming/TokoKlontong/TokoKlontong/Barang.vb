Imports TokoKlontong.Koneksi
Imports MySql.Data.MySqlClient
Public Class Barang
    Private Sub statuspembersih()
        tbidbarang.Text = ""
        tbnamabarang.Text = ""
        tbhargajual.Text = ""
        tbhargasupplier.Text = ""
        tbstock.Text = ""
        cbidsupplier.Text = ""
        cbidadmin.Text = ""
    End Sub

    Private Sub tampildata()
        Dim dt As DataTable
        Dim adapter As MySqlDataAdapter
        Dim query As String
        Dim data As Integer

        query = "select id_barang, nama_barang, harga_jual, harga_supplier, stock, nama_supplier, waktu_input, nama_admin from barang"
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

    Private Sub statusInput(idbarang As Boolean, namabarang As Boolean, jual As Boolean, hargasup As Boolean, stock As Boolean, idsupplier As Boolean, waktu As Boolean, adm As Boolean)
        tbidbarang.Enabled = idbarang
        tbnamabarang.Enabled = namabarang
        tbhargajual.Enabled = jual
        tbhargasupplier.Enabled = hargasup
        tbstock.Enabled = stock
        cbidsupplier.Enabled = idsupplier
        tglinput.Enabled = waktu
        cbidadmin.Enabled = adm
    End Sub

    Private Sub statustombol(tambah As Boolean, edit As Boolean, hapus As Boolean)
        bttambah.Enabled = tambah
        btedit.Enabled = edit
        bthapus.Enabled = hapus
    End Sub

    Sub tampilcomboidsupplier()
        If (conn.State) <> ConnectionState.Closed Then conn.Close()
        KoneksiBuka()
        CMD.Connection = conn
        Dim str As String
        str = "Select nama_supplier from supplier"
        CMD = New MySqlCommand(str, conn)

        MySQLReader = CMD.ExecuteReader
        If MySQLReader.HasRows Then
            Do While MySQLReader.Read
                cbidsupplier.Items.Add(MySQLReader("nama_supplier"))
            Loop
        End If
    End Sub
    Sub tampilcomboidadmin()
        If (conn.State) <> ConnectionState.Closed Then conn.Close()
        KoneksiBuka()
        CMD.Connection = conn
        Dim str As String
        str = "Select username from admin"
        CMD = New MySqlCommand(str, conn)

        MySQLReader = CMD.ExecuteReader
        If MySQLReader.HasRows Then
            Do While MySQLReader.Read
                cbidadmin.Items.Add(MySQLReader("username"))
            Loop
        End If
    End Sub
    Private Sub Barang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (conn.State) <> ConnectionState.Closed Then conn.Close()
        KoneksiBuka()

        CMD = New MySqlCommand(str, conn)
        CMD.ExecuteNonQuery()

        tampildata()

        statusInput(False, False, False, False, False, False, False, False)
        statustombol(True, False, False)
        tampilcomboidsupplier()
        tampilcomboidadmin()
    End Sub

    Private Sub bttambah_Click(sender As Object, e As EventArgs) Handles bttambah.Click
        If (conn.State) <> ConnectionState.Closed Then conn.Close()
        KoneksiBuka()
        If bttambah.Text = "&Tambah" Then
            statusInput(True, True, True, True, True, True, True, True)
            statustombol(True, False, True)
            bthapus.Text = "Batal"
            bttambah.Text = "Simpan"
        ElseIf bttambah.Text = "&Batal" Then
            statuspembersih()
            statustombol(True, False, False)
            statusInput(False, False, False, False, False, False, False, False)
            bttambah.Text = "&Tambah"
        ElseIf bttambah.Text = "Simpan" Then
            If tbidbarang.Text = "" Then
                MsgBox("ID Barang Harus diisi", MsgBoxStyle.Information, "Informasi")
                tbidbarang.Focus()
                Exit Sub
            ElseIf tbnamabarang.Text = "" Then
                MsgBox("Nama Barang Harus diisi", MsgBoxStyle.Information, "Informasi")
                tbnamabarang.Focus()
                Exit Sub
            ElseIf tbhargajual.Text = "" Then
                MsgBox("Harga Jual harus diisi", MsgBoxStyle.Information, "Informasi")
                tbhargajual.Focus()
                Exit Sub
            ElseIf tbhargasupplier.Text = "" Then
                MsgBox("Harga Supplier harus diisi", MsgBoxStyle.Information, "Informasi")
                tbhargasupplier.Focus()
                Exit Sub
            ElseIf tbstock.Text = "" Then
                MsgBox("Stock Harus Diisi", MsgBoxStyle.Information, "Informasi")
                tbstock.Focus()
                Exit Sub
            ElseIf cbidsupplier.Text = "" Then
                MsgBox("Nama Supplier Harus Diisi", MsgBoxStyle.Information, "Informasi")
                cbidsupplier.Focus()
                Exit Sub
            ElseIf cbidadmin.Text = "" Then
                MsgBox("Nama Admin harus diisi", MsgBoxStyle.Information, "Informasi")
                cbidadmin.Focus()
                Exit Sub
            End If
            'conn.Open()
            Try
                Dim qinsert As String
                CMD.CommandType = CommandType.Text
                qinsert = "insert into barang(id_barang, nama_barang, harga_jual, harga_supplier, stock, nama_supplier, waktu_input, nama_admin)"
                qinsert = qinsert & "values('" & tbidbarang.Text & "', '" & tbnamabarang.Text & "', '" & tbhargajual.Text & "', '" & tbhargasupplier.Text & "', '" & tbstock.Text & "', '" & cbidsupplier.Text & "', '" & tglinput.Value.ToString("yyyy-MM-dd") & "', '" & cbidadmin.Text & "')"
                CMD.CommandType = CommandType.Text
                CMD.CommandText = qinsert
                CMD.Connection = conn
                CMD.ExecuteNonQuery()

                tampildata()
            Catch ex As Exception
                MsgBox("Gagal Simpan " + ex.Message, MsgBoxStyle.Critical, "Terjadi Kesalahan")

            End Try
            bttambah.Text = "&Tambah"
            statusInput(False, False, False, False, False, False, False, False)
            statustombol(True, False, False)
            statuspembersih()
        End If

        'conn.Close()
    End Sub

    Private Sub btedit_Click(sender As Object, e As EventArgs) Handles btedit.Click
        If (conn.State) <> ConnectionState.Closed Then conn.Close()
        KoneksiBuka()
        If btedit.Text = "&Edit" Then
            statustombol(False, True, False)
            btedit.Text = "&Simpan"
            statusInput(False, True, True, True, True, True, True, True)
        ElseIf btedit.Text = "&Simpan" Then
            Try
                Dim qUpdate As String
                qUpdate = "update barang set nama_barang='" & tbnamabarang.Text & "', harga_jual='" & tbhargajual.Text & "', harga_supplier='" & tbhargajual.Text & "', stock='" & tbstock.Text & "', nama_supplier='" & cbidsupplier.Text & "', waktu_input='" & tglinput.Value.ToString("yyyy-MM-dd") & "', nama_admin='" & cbidadmin.Text & "' where id_barang='" & tbidbarang.Text & "'"
                CMD.CommandType = CommandType.Text
                CMD.CommandText = qUpdate
                CMD.Connection = conn
                CMD.ExecuteNonQuery()

                MsgBox("Data berhasil di Update", MsgBoxStyle.Information, "Informasi")
                tampildata()

                btedit.Text = "&Edit"
            Catch ex As Exception
                MsgBox("Gagal update Data " + ex.Message, MsgBoxStyle.Critical, "Terjadi Kesalahan")
            End Try
            statusInput(False, False, False, False, False, False, False, False)
            statustombol(True, False, False)
            statuspembersih()
        End If
    End Sub

    Private Sub bthapus_Click(sender As Object, e As EventArgs) Handles bthapus.Click
        If (conn.State) <> ConnectionState.Closed Then conn.Close()
        KoneksiBuka()
        If bthapus.Text = "&Hapus" Then
            Dim yakinhapus As MsgBoxResult = MessageBox.Show("Yakin mau dihapus", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If yakinhapus = vbYes Then
                Try
                    Dim qDelete As String
                    qDelete = "delete from barang where id_barang ='" & tbidbarang.Text & "'"
                    CMD.CommandType = CommandType.Text
                    CMD.CommandText = qDelete
                    CMD.Connection = conn
                    CMD.ExecuteNonQuery()

                    tampildata()
                    ''statuspembersih()
                Catch ex As Exception
                    MsgBox("Gagal hapus Data " + ex.Message, MsgBoxStyle.Critical, "Terjadi Kesalahan")
                End Try
                statuspembersih()
                statustombol(True, False, False)
            End If
        End If

        If bthapus.Text = "Batal" Then
            bthapus.Text = "&Hapus"
            bttambah.Text = "&Tambah"
            statusInput(False, False, False, False, False, False, False, False)
            statustombol(True, False, False)
            statuspembersih()
        End If
    End Sub

    Private Sub databarang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles databarang.CellClick
        Dim i As Integer
        i = Me.databarang.CurrentRow.Index
        With databarang.Rows.Item(i)
            tbidbarang.Text = .Cells(0).Value
            tbnamabarang.Text = .Cells(1).Value
            tbhargajual.Text = .Cells(2).Value
            tbhargasupplier.Text = .Cells(3).Value
            tbstock.Text = .Cells(4).Value
            cbidsupplier.Text = .Cells(5).Value
            tglinput.Text = .Cells(6).Value
            cbidadmin.Text = .Cells(7).Value

        End With
        statustombol(True, True, True)
        bthapus.Text = "&Hapus"
        bttambah.Text = "&Batal"
        ''bttambah.Text = "Batal"
        statusInput(False, False, False, False, False, False, False, False)
    End Sub

    Private Sub btncari_Click(sender As Object, e As EventArgs) Handles btncari.Click
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
        tbcari.Text = ""
    End Sub

    Private Sub btnmenuutaman_Click(sender As Object, e As EventArgs) Handles btnmenuutaman.Click
        Me.Close()
        Menuaja.Show()
    End Sub
End Class