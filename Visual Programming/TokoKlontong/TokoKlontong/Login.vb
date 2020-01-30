Imports TokoKlontong.Koneksi
Imports MySql.Data.MySqlClient
Public Class Login
    Sub kondisibersih()
        tbusername.Text = ""
        tbpassword.Text = ""
        tbusername.Focus()
    End Sub

    Private Sub btlogin_Click(sender As Object, e As EventArgs) Handles btlogin.Click
        If tbusername.Text = "" Or tbpassword.Text = "" Then
            MsgBox("Data yang anda isi Belum lengkap")
            kondisibersih()
            Exit Sub
        Else

            CMD.Connection = conn
            str = " SELECT username, password FROM admin WHERE username= '" & tbusername.Text & "' AND password = '" & tbpassword.Text & "'"
            CMD = New MySqlCommand(str, conn)

            KoneksiBuka()
            MySQLReader = CMD.ExecuteReader

            If MySQLReader.HasRows Then
                tbusername.Text = ""
                tbpassword.Text = ""
                Menuaja.Show()
                Me.Hide()
            Else
                'agar dapat mengulang ketika salah memasukkan username dan password
                CMD.Dispose()
                MySQLReader.Dispose()
                MessageBox.Show("Login Gagal, Username dan Password Tidak Sesuai", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                kondisibersih()
            End If
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            tbpassword.PasswordChar = ""
        Else
            tbpassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub btbatal_Click(sender As Object, e As EventArgs) Handles btbatal.Click
        Dim result As Integer = MessageBox.Show("Anda yakin akan keluar?", "Peringatan", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbusername.TextAlign = HorizontalAlignment.Center
        tbpassword.TextAlign = HorizontalAlignment.Center
    End Sub
End Class