Imports TokoKlontong.Koneksi
Imports MySql.Data.MySqlClient
Public Class frmSupplier

    Private Sub statuspembersih()
        tbidsupplier.Text = ""
        tbnamasupplier.Text = ""
        tbalamatsupplier.Text = ""
        tbnohp.Text = ""
    End Sub

    Private Sub tampildata()
        Dim dt As DataTable
        Dim adapter As MySqlDataAdapter
        Dim query As String
        Dim data As Integer

        query = "select id_supplier, nama_supplier, alamat_supplier, no_telp, tanggal_input from supplier"
        adapter = New MySqlDataAdapter(query, conn)
        dt = New DataTable
        data = adapter.Fill(dt)

        If data > 0 Then
            datasupplier.DataSource = dt
            datasupplier.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
            datasupplier.Columns(0).HeaderText = "Id Supplier"
            datasupplier.Columns(1).HeaderText = "Nama Supplier"
            datasupplier.Columns(2).HeaderText = "Alamat Supplier"
            datasupplier.Columns(3).HeaderText = "No Hp"
            datasupplier.Columns(4).HeaderText = "Tanggal Input"
        Else
            datasupplier.DataSource = Nothing
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (conn.State) <> ConnectionState.Closed Then conn.Close()
        KoneksiBuka()

        CMD = New MySqlCommand(str, conn)
        CMD.ExecuteNonQuery()

        tampildata()

        statusInput(False, False, False, False)
        statustombol(True, False, False)

    End Sub

    Private Sub statusInput(id_supp As Boolean, nama_supp As Boolean, alamat_supp As Boolean, no_hp As Boolean)
        tbidsupplier.Enabled = id_supp
        tbnamasupplier.Enabled = nama_supp
        tbalamatsupplier.Enabled = alamat_supp
        tbnohp.Enabled = no_hp
    End Sub
    Private Sub statustombol(tambah As Boolean, ubah As Boolean, hapus As Boolean)
        btedit.Enabled = ubah
        btdelete.Enabled = hapus
        bttambah.Enabled = tambah
    End Sub


    Private Sub bttambah_Click(sender As Object, e As EventArgs) Handles bttambah.Click
        If (conn.State) <> ConnectionState.Closed Then conn.Close()
        KoneksiBuka()
        If bttambah.Text = "&Tambah" Then
            statusInput(True, True, True, True)
            statustombol(True, False, True)
            btdelete.Text = "Batal"
            bttambah.Text = "Simpan"
        ElseIf bttambah.Text = "&Batal" Then
            statuspembersih()
            statustombol(True, False, False)
            statusInput(False, False, False, False)
            bttambah.Text = "&Tambah"
        ElseIf bttambah.Text = "Simpan" Then
            If tbidsupplier.Text = "" Then
                MsgBox("Kode Harus diisi", MsgBoxStyle.Information, "Informasi")
                tbidsupplier.Focus()
                Exit Sub
            ElseIf tbnamasupplier.Text = "" Then
                MsgBox("Nama Harus diisi", MsgBoxStyle.Information, "Informasi")
                tbnamasupplier.Focus()
                Exit Sub
            ElseIf tbalamatsupplier.Text = "" Then
                MsgBox("Alamat supplier harus diisi", MsgBoxStyle.Information, "Informasi")
                tbalamatsupplier.Focus()
            ElseIf tbnohp.Text = "" Then
                MsgBox("No Handphone Harus Diisi", MsgBoxStyle.Information, "Informasi")
                tbnohp.Focus()
                Exit Sub
            End If
            'conn.Open()
            Try
                Dim qinsert As String
                CMD.CommandType = CommandType.Text
                qinsert = "insert into supplier(id_supplier, nama_supplier, alamat_supplier, no_telp, tanggal_input)"
                qinsert = qinsert & "values('" & tbidsupplier.Text & "', '" & tbnamasupplier.Text & "', '" & tbalamatsupplier.Text & "', '" & tbnohp.Text & "', '" & tglinput.Value.ToString("yyyy-MM-dd") & "')"
                CMD.CommandType = CommandType.Text
                CMD.CommandText = qinsert
                CMD.Connection = conn
                CMD.ExecuteNonQuery()

                tampildata()
            Catch ex As Exception
                MsgBox("Gagal Simpan " + ex.Message, MsgBoxStyle.Critical, "Terjadi Kesalahan")

            End Try
            bttambah.Text = "&Tambah"
            statusInput(False, False, False, False)
            statustombol(True, False, False)
            statuspembersih()
        End If
       
        'conn.Close()
    End Sub

    Private Sub btdelete_Click(sender As Object, e As EventArgs) Handles btdelete.Click
        If (conn.State) <> ConnectionState.Closed Then conn.Close()
        KoneksiBuka()
        If btdelete.Text = "&Hapus" Then
            Dim yakinhapus As MsgBoxResult = MessageBox.Show("Yakin mau dihapus", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If yakinhapus = vbYes Then
                Try
                    Dim qDelete As String
                    qDelete = "delete from supplier where id_supplier ='" & tbidsupplier.Text & "'"
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

        If btdelete.Text = "Batal" Then
            btdelete.Text = "&Hapus"
            bttambah.Text = "&Tambah"
            statusInput(False, False, False, False)
            statustombol(True, False, False)
            statuspembersih()
        End If
    End Sub

    Private Sub datasupplier_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datasupplier.CellClick
        Dim i As Integer
        i = Me.datasupplier.CurrentRow.Index
        With datasupplier.Rows.Item(i)
            tbidsupplier.Text = .Cells(0).Value
            tbnamasupplier.Text = .Cells(1).Value
            tbalamatsupplier.Text = .Cells(2).Value
            tbnohp.Text = .Cells(3).Value
            tglinput.Text = .Cells(4).Value
        End With
        statustombol(True, True, True)
        btdelete.Text = "&Hapus"
        bttambah.Text = "&Batal"
        ''bttambah.Text = "Batal"
        statusInput(False, False, False, False)
    End Sub

    Private Sub btedit_Click(sender As Object, e As EventArgs) Handles btedit.Click
        If (conn.State) <> ConnectionState.Closed Then conn.Close()
        KoneksiBuka()
        If btedit.Text = "&Edit" Then
            statustombol(False, True, False)
            btedit.Text = "&Simpan"
            statusInput(False, True, True, True)
        ElseIf btedit.Text = "&Simpan" Then
            Try
                Dim qUpdate As String
                qUpdate = "update supplier set nama_supplier='" & tbnamasupplier.Text & "', alamat_supplier='" & tbalamatsupplier.Text & "', no_telp='" & tbnohp.Text & "', tanggal_input='" & tglinput.Value.ToString("yyyy-MM-dd") & "' where id_supplier='" & tbidsupplier.Text & "'"
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
            statusInput(False, False, False, False)
            statustombol(True, False, False)
            statuspembersih()
        End If
    End Sub

    Private Sub btncari_Click(sender As Object, e As EventArgs) Handles btncari.Click
        If (conn.State) <> ConnectionState.Closed Then conn.Close()
        KoneksiBuka()
        Dim dt As DataTable
        Dim adapter As MySqlDataAdapter
        Dim query As String
        Dim data As Integer

        query = "select * from supplier where nama_supplier like '%" & tbcari.Text & "%'"
        adapter = New MySqlDataAdapter(query, conn)
        dt = New DataTable
        data = adapter.Fill(dt)

        If data > 0 Then
            datasupplier.DataSource = dt
            datasupplier.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
            datasupplier.Columns(0).HeaderText = "Id Supplier"
            datasupplier.Columns(1).HeaderText = "Nama Supplier"
            datasupplier.Columns(2).HeaderText = "Alamat Supplier"
            datasupplier.Columns(3).HeaderText = "No Hp"
            datasupplier.Columns(4).HeaderText = "Tanggal Input"
        Else
            datasupplier.DataSource = Nothing
        End If
        tbcari.Text = ""
    End Sub

    Private Sub btnmenuutaman_Click(sender As Object, e As EventArgs) Handles btnmenuutaman.Click
        Me.Close()
        Menuaja.Show()
    End Sub
End Class

