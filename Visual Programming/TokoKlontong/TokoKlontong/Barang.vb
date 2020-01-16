Imports TokoKlontong.Koneksi
Imports MySql.Data.MySqlClient
Public Class Barang
    Private Sub statuspembersih()
        tbidbarang.Text = ""
        tbnamabarang.Text = ""
        tbharga.Text = ""
        tbstock.Text = ""
    End Sub

    Private Sub tampildata()
        Dim dt As DataTable
        Dim adapter As MySqlDataAdapter
        Dim query As String
        Dim data As Integer

        query = "select id_barang, nama_barang, harga, stock, id_supplier from barang"
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
            databarang.Columns(3).HeaderText = "ID Supplier"

        Else
            databarang.DataSource = Nothing
        End If
    End Sub

    Private Sub statusInput(idbarang As Boolean, namabarang As Boolean, harga As Boolean, stock As Boolean, idsupplier As Boolean)
        tbidbarang.Enabled = idbarang
        tbnamabarang.Enabled = namabarang
        tbharga.Enabled = harga
        tbstock.Enabled = stock
        cbidsupplier.Enabled = idsupplier
    End Sub

    Private Sub statustombol(tambah As Boolean, edit As Boolean, hapus As Boolean)
        bttambah.Enabled = tambah
        btedit.Enabled = edit
        bthapus.Enabled = hapus
    End Sub

    Sub tampilcomboidsupplier()
        CMD.Connection = conn
        Dim str As String
        str = "Select id_supplier from supplier"
        CMD = New MySqlCommand(str, conn)

        MySQLReader = CMD.ExecuteReader
        If MySQLReader.HasRows Then
            Do While MySQLReader.Read
                cbidsupplier.Items.Add(MySQLReader("id_supplier"))
            Loop
        End If
    End Sub
    Private Sub Barang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (conn.State) <> ConnectionState.Closed Then conn.Close()
        KoneksiBuka()

        CMD = New MySqlCommand(str, conn)
        CMD.ExecuteNonQuery()

        tampildata()

        statusInput(False, False, False, False, False)
        statustombol(True, False, False)
        tampilcomboidsupplier()
    End Sub

    Private Sub bttambah_Click(sender As Object, e As EventArgs) Handles bttambah.Click
        If (conn.State) <> ConnectionState.Closed Then conn.Close()
        KoneksiBuka()
        If bttambah.Text = "&Tambah" Then
            statusInput(True, True, True, True, True)
            statustombol(True, False, True)
            bthapus.Text = "Batal"
            bttambah.Text = "Simpan"
        ElseIf bttambah.Text = "Simpan" Then
            If tbidbarang.Text = "" Then
                MsgBox("ID Barang Harus diisi", MsgBoxStyle.Information, "Informasi")
                tbidbarang.Focus()
                Exit Sub
            ElseIf tbnamabarang.Text = "" Then
                MsgBox("Nama Barang Harus diisi", MsgBoxStyle.Information, "Informasi")
                tbnamabarang.Focus()
                Exit Sub
            ElseIf tbharga.Text = "" Then
                MsgBox("Harga harus diisi", MsgBoxStyle.Information, "Informasi")
                tbharga.Focus()
                Exit Sub
            ElseIf tbstock.Text = "" Then
                MsgBox("Stock Harus Diisi", MsgBoxStyle.Information, "Informasi")
                tbstock.Focus()
                Exit Sub
            ElseIf cbidsupplier.Text = "" Then
                MsgBox("ID Supplier Harus Diisi", MsgBoxStyle.Information, "Informasi")
                cbidsupplier.Focus()
                Exit Sub
            End If
            'conn.Open()
            Try
                Dim qinsert As String
                CMD.CommandType = CommandType.Text
                qinsert = "insert into barang(id_barang, nama_barang, harga, stock, id_supplier)"
                qinsert = qinsert & "values('" & tbidbarang.Text & "', '" & tbnamabarang.Text & "', '" & tbharga.Text & "', '" & tbstock.Text & "', '" & cbidsupplier.Text & "')"
                CMD.CommandType = CommandType.Text
                CMD.CommandText = qinsert
                CMD.Connection = conn
                CMD.ExecuteNonQuery()

                tampildata()
            Catch ex As Exception
                MsgBox("Gagal Simpan " + ex.Message, MsgBoxStyle.Critical, "Terjadi Kesalahan")

            End Try
            bttambah.Text = "&Tambah"
            statusInput(False, False, False, False, False)
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
            statusInput(False, True, True, True, True)
        ElseIf btedit.Text = "&Simpan" Then
            Try
                Dim qUpdate As String
                qUpdate = "update barang set nama_barang='" & tbnamabarang.Text & "', harga='" & tbharga.Text & "', stock='" & tbstock.Text & "', id_supplier='" & cbidsupplier.Text & "' where id_barang='" & tbidbarang.Text & "'"
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
            statusInput(False, False, False, False, False)
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
            statusInput(False, False, False, False, False)
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
            tbharga.Text = .Cells(2).Value
            tbstock.Text = .Cells(3).Value
            cbidsupplier.Text = .Cells(4).Value

        End With
        statustombol(True, True, True)
        bthapus.Text = "&Hapus"
        ''bttambah.Text = "Batal"
        statusInput(False, False, False, False, False)
    End Sub
End Class