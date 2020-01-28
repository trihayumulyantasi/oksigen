Imports TokoKlontong.Koneksi
Imports MySql.Data.MySqlClient
Public Class LaporanSupplier
    Private Sub statuspembersih()
        tbidlaporan.Text = ""
        cbidbarang.Text = ""
        cbidsupplier.Text = ""
        cbstatus.Text = ""
        cbusername.Text = ""
    End Sub
    Private Sub tampildata()
        Dim dt As DataTable
        Dim adapter As MySqlDataAdapter
        Dim query As String
        Dim data As Integer

        query = "select id_laporan, nama_supplier, nama_barang, tanggal_masuk, tanggal_jatuhtempo, status, username from laporan_supplier"
        adapter = New MySqlDataAdapter(query, conn)
        dt = New DataTable
        data = adapter.Fill(dt)

        If data > 0 Then
            datalaporansupplier.DataSource = dt
            datalaporansupplier.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
            datalaporansupplier.Columns(0).HeaderText = "Id Laporan"
            datalaporansupplier.Columns(1).HeaderText = "Nama Supplier"
            datalaporansupplier.Columns(2).HeaderText = "Nama Barang"
            datalaporansupplier.Columns(3).HeaderText = "Tanggal Masuk"
            datalaporansupplier.Columns(3).HeaderText = "Tanggal Jatuh Tempo"
            datalaporansupplier.Columns(4).HeaderText = "Status"
            datalaporansupplier.Columns(5).HeaderText = "Username"

        Else
            datalaporansupplier.DataSource = Nothing
        End If
    End Sub
    Private Sub statusInput(idlaporan As Boolean, idsupplier As Boolean, idbarang As Boolean, status As Boolean, username As Boolean, masuk As Boolean, tempo As Boolean)
        tbidlaporan.Enabled = idlaporan
        cbidsupplier.Enabled = idsupplier
        cbidbarang.Enabled = idbarang
        tglmasuk.Enabled = masuk
        tgljatuhtempo.Enabled = tempo
        cbstatus.Enabled = status
        cbusername.Enabled = username
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
    Sub tampilcomboidbarang()
        If (conn.State) <> ConnectionState.Closed Then conn.Close()
        KoneksiBuka()
        CMD.Connection = conn
        Dim str As String
        str = "Select nama_barang from barang"
        CMD = New MySqlCommand(str, conn)

        MySQLReader = CMD.ExecuteReader
        If MySQLReader.HasRows Then
            Do While MySQLReader.Read
                cbidbarang.Items.Add(MySQLReader("nama_barang"))
            Loop
        End If
    End Sub
    Sub tampilcombousername()
        If (conn.State) <> ConnectionState.Closed Then conn.Close()
        KoneksiBuka()
        CMD.Connection = conn
        Dim str As String
        str = "Select username from admin"
        CMD = New MySqlCommand(str, conn)

        MySQLReader = CMD.ExecuteReader
        If MySQLReader.HasRows Then
            Do While MySQLReader.Read
                cbusername.Items.Add(MySQLReader("username"))
            Loop
        End If
    End Sub
    Sub tampilcombostatus()
        If (conn.State) <> ConnectionState.Closed Then conn.Close()
        KoneksiBuka()
        cbstatus.Items.Add("Belum Bayar")
        cbstatus.Items.Add("Sudah Bayar")
    End Sub

    Private Sub LaporanSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (conn.State) <> ConnectionState.Closed Then conn.Close()
        KoneksiBuka()

        CMD = New MySqlCommand(str, conn)
        CMD.ExecuteNonQuery()

        tampildata()

        statusInput(False, False, False, False, False, False, False)
        statustombol(True, False, False)
        tampilcomboidsupplier()
        tampilcomboidbarang()
        tampilcombostatus()
        tampilcombousername()
    End Sub

    Private Sub bttambah_Click(sender As Object, e As EventArgs) Handles bttambah.Click
        If (conn.State) <> ConnectionState.Closed Then conn.Close()
        KoneksiBuka()
        If bttambah.Text = "&Tambah" Then
            statusInput(True, True, True, True, True, True, True)
            statustombol(True, False, True)
            bthapus.Text = "Batal"
            bttambah.Text = "Simpan"
        ElseIf bttambah.Text = "&Batal" Then
            statuspembersih()
            statustombol(True, False, False)
            statusInput(False, False, False, False, False, False, False)
            bttambah.Text = "&Tambah"
        ElseIf bttambah.Text = "Simpan" Then
            If tbidlaporan.Text = "" Then
                MsgBox("ID Laporan Harus diisi", MsgBoxStyle.Information, "Informasi")
                tbidlaporan.Focus()
                Exit Sub
            ElseIf cbidsupplier.Text = "" Then
                MsgBox("Nama Supplier Harus diisi", MsgBoxStyle.Information, "Informasi")
                cbidsupplier.Focus()
                Exit Sub
            ElseIf cbidbarang.Text = "" Then
                MsgBox("Nama Barang harus diisi", MsgBoxStyle.Information, "Informasi")
                cbidbarang.Focus()
                Exit Sub
            ElseIf cbstatus.Text = "" Then
                MsgBox("Status Harus Diisi", MsgBoxStyle.Information, "Informasi")
                cbstatus.Focus()
                Exit Sub
            ElseIf cbusername.Text = "" Then
                MsgBox("Username Harus Diisi", MsgBoxStyle.Information, "Informasi")
                cbusername.Focus()
                Exit Sub
            End If
            'conn.Open()
            Try
                Dim qinsert As String
                CMD.CommandType = CommandType.Text
                qinsert = "insert into laporan_supplier(id_laporan, nama_supplier, nama_barang, tanggal_masuk, tanggal_jatuhtempo, status, username)"
                qinsert = qinsert & "values('" & tbidlaporan.Text & "', '" & cbidsupplier.Text & "', '" & cbidbarang.Text & "', '" & tglmasuk.Value.ToString("yyyy-MM-dd") & "', '" & tgljatuhtempo.Value.ToString("yyyy-MM-dd") & "', '" & cbstatus.Text & "', '" & cbusername.Text & "')"
                CMD.CommandType = CommandType.Text
                CMD.CommandText = qinsert
                CMD.Connection = conn
                CMD.ExecuteNonQuery()

                tampildata()
            Catch ex As Exception
                MsgBox("Gagal Simpan " + ex.Message, MsgBoxStyle.Critical, "Terjadi Kesalahan")

            End Try
            bttambah.Text = "&Tambah"
            statusInput(False, False, False, False, False, False, False)
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
            statusInput(False, True, True, True, True, True, True)
        ElseIf btedit.Text = "&Simpan" Then
            Try
                Dim qUpdate As String
                qUpdate = "update laporan_supplier set nama_supplier='" & cbidsupplier.Text & "', nama_barang='" & cbidbarang.Text & "', tanggal_masuk ='" & tglmasuk.Value.ToString("yyyy-MM-dd") & "', tanggal_jatuhtempo ='" & tgljatuhtempo.Value.ToString("yyyy-MM-dd") & "', status='" & cbstatus.Text & "', username='" & cbusername.Text & "' where id_laporan='" & tbidlaporan.Text & "'"
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
            statusInput(False, False, False, False, False, False, False)
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
                    qDelete = "delete from laporan_supplier where id_laporan ='" & tbidlaporan.Text & "'"
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
            statusInput(False, False, False, False, False, False, False)
            statustombol(True, False, False)
            statuspembersih()
        End If
    End Sub

    Private Sub datalaporansupplier_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalaporansupplier.CellClick
        Dim i As Integer
        i = Me.datalaporansupplier.CurrentRow.Index
        With datalaporansupplier.Rows.Item(i)
            tbidlaporan.Text = .Cells(0).Value
            cbidsupplier.Text = .Cells(1).Value
            cbidbarang.Text = .Cells(2).Value
            tglmasuk.Text = .Cells(3).Value
            tgljatuhtempo.Text = .Cells(4).Value
            cbstatus.Text = .Cells(5).Value
            cbusername.Text = .Cells(6).Value

        End With
        statustombol(True, True, True)
        bthapus.Text = "&Hapus"
        bttambah.Text = "&Batal"
        ''bttambah.Text = "Batal"
        statusInput(False, False, False, False, False, False, False)
    End Sub

    Private Sub btncari_Click(sender As Object, e As EventArgs) Handles btncari.Click
        If (conn.State) <> ConnectionState.Closed Then conn.Close()
        KoneksiBuka()
        Dim dt As DataTable
        Dim adapter As MySqlDataAdapter
        Dim query As String
        Dim data As Integer

        query = "select * from laporan_supplier where status like '%" & tbcari.Text & "%'"
        adapter = New MySqlDataAdapter(query, conn)
        dt = New DataTable
        data = adapter.Fill(dt)

        If data > 0 Then
            datalaporansupplier.DataSource = dt
            datalaporansupplier.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
            datalaporansupplier.Columns(0).HeaderText = "Id Laporan"
            datalaporansupplier.Columns(1).HeaderText = "Nama Supplier"
            datalaporansupplier.Columns(2).HeaderText = "Nama Barang"
            datalaporansupplier.Columns(3).HeaderText = "Tanggal Masuk"
            datalaporansupplier.Columns(3).HeaderText = "Tanggal Jatuh Tempo"
            datalaporansupplier.Columns(4).HeaderText = "Status"
            datalaporansupplier.Columns(5).HeaderText = "Username"

        Else
            datalaporansupplier.DataSource = Nothing
        End If
        tbcari.Text = ""
    End Sub
End Class