Imports TokoKlontong.Koneksi
Imports MySql.Data.MySqlClient
Public Class admin

    Private Sub statuspembersih()
        tbidadmin.Text = ""
        tbusername.Text = ""
        tbpassword.Text = ""
        tbalamat.Text = ""
        tbnohp.Text = ""
        cbjk.Text = ""
        tbjabatan.Text = ""
    End Sub

    Private Sub tampildata()
        Dim dt As DataTable
        Dim adapter As MySqlDataAdapter
        Dim query As String
        Dim data As Integer

        query = "select id_admin, username, password, alamat, no_telp, jk, jabatan from admin"
        adapter = New MySqlDataAdapter(query, conn)
        dt = New DataTable
        data = adapter.Fill(dt)

        If data > 0 Then
            dataadmin.DataSource = dt
            dataadmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
            dataadmin.Columns(0).HeaderText = "Id Admin"
            dataadmin.Columns(1).HeaderText = "Username"
            dataadmin.Columns(2).HeaderText = "Password"
            dataadmin.Columns(3).HeaderText = "Alamat"
            dataadmin.Columns(4).HeaderText = "No Hp"
            dataadmin.Columns(5).HeaderText = "Jenis Kelamin"
            dataadmin.Columns(6).HeaderText = "Jabatan"

        Else
            dataadmin.DataSource = Nothing
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (conn.State) <> ConnectionState.Closed Then conn.Close()
        KoneksiBuka()

        CMD = New MySqlCommand(str, conn)
        CMD.ExecuteNonQuery()

        tampildata()

        statusInput(False, False, False, False, False, False, False)
        statustombol(True, False, False)

    End Sub

    Private Sub statusInput(id_adm As Boolean, username As Boolean, password As Boolean, alamat As Boolean, no_hp As Boolean, jk As Boolean, jabatan As Boolean)
        tbidadmin.Enabled = id_adm
        tbusername.Enabled = username
        tbpassword.Enabled = password
        tbalamat.Enabled = alamat
        tbnohp.Enabled = no_hp
        cbjk.Enabled = jk
        tbjabatan.Enabled = jabatan
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
            statusInput(True, True, True, True, True, True, True)
            statustombol(True, False, True)
            btdelete.Text = "Batal"
            bttambah.Text = "Simpan"
        ElseIf bttambah.Text = "Simpan" Then
            If tbidadmin.Text = "" Then
                MsgBox("Id Admin Harus diisi", MsgBoxStyle.Information, "Informasi")
                tbidadmin.Focus()
                Exit Sub
            ElseIf tbusername.Text = "" Then
                MsgBox("Username Harus diisi", MsgBoxStyle.Information, "Informasi")
                tbusername.Focus()
                Exit Sub
            ElseIf tbpassword.Text = "" Then
                MsgBox("Password Mu harus diisi", MsgBoxStyle.Information, "Informasi")
                tbpassword.Focus()
                Exit Sub
            ElseIf tbalamat.Text = "" Then
                MsgBox("Alamat Harus diisi", MsgBoxStyle.Information, "Informasi")
                tbalamat.Focus()
                Exit Sub
            ElseIf tbnohp.Text = "" Then
                MsgBox("No Handphone Harus Diisi", MsgBoxStyle.Information, "Informasi")
                tbnohp.Focus()
                Exit Sub
            ElseIf cbjk.Text = "" Then
                MsgBox("Jenis Kelamin Harus dipilih", MsgBoxStyle.Information, "Information")
                cbjk.Focus()
                Exit Sub
            ElseIf tbjabatan.Text = "" Then
                MsgBox("Jabatan Harus Diisi", MsgBoxStyle.Information, "Information")
                tbjabatan.Focus()
                Exit Sub
            End If
            'conn.Open()
            Try
                Dim qinsert As String
                CMD.CommandType = CommandType.Text
                qinsert = "insert into admin(id_admin, username, password, alamat, no_telp, jk, jabatan)"
                qinsert = qinsert & "values('" & tbidadmin.Text & "', '" & tbusername.Text & "', '" & tbpassword.Text & "', '" & tbalamat.Text & "', '" & tbnohp.Text & "', '" & cbjk.Text & "', '" & tbjabatan.Text & "')"
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

    Private Sub btdelete_Click(sender As Object, e As EventArgs) Handles btdelete.Click
        If (conn.State) <> ConnectionState.Closed Then conn.Close()
        KoneksiBuka()
        If btdelete.Text = "&Hapus" Then
            Dim yakinhapus As MsgBoxResult = MessageBox.Show("Yakin mau dihapus", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If yakinhapus = vbYes Then
                Try
                    Dim qDelete As String
                    qDelete = "delete from admin where id_admin ='" & tbidadmin.Text & "'"
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
            statusInput(False, False, False, False, False, False, False)
            statustombol(True, False, False)
            statuspembersih()
        End If
    End Sub

    Private Sub dataadmin_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataadmin.CellClick
        Dim i As Integer
        i = Me.dataadmin.CurrentRow.Index
        With dataadmin.Rows.Item(i)
            tbidadmin.Text = .Cells(0).Value
            tbusername.Text = .Cells(1).Value
            tbpassword.Text = .Cells(2).Value
            tbnohp.Text = .Cells(3).Value
            cbjk.Text = .Cells(4).Value
            tbjabatan.Text = .Cells(5).Value
        End With
        statustombol(True, True, True)
        btdelete.Text = "&Hapus"
        ''bttambah.Text = "Batal"
        statusInput(False, False, False, False, False, False, False)
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
                qUpdate = "update admin set username='" & tbusername.Text & "', password='" & tbpassword.Text & "', alamat='" & tbalamat.Text & "', no_telp='" & tbnohp.Text & "', jk='" & cbjk.Text & "', jabatan='" & tbjabatan.Text & "' where id_admin='" & tbidadmin.Text & "'"
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
End Class