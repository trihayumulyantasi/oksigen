
Imports MySql.Data.MySqlClient
Module Koneksi
    Public conn As New MySqlConnection
    Public MySQLReader As MySqlDataReader
    Public CMD As New MySqlCommand
    Public DA As New MySqlDataAdapter


    Public Sub KoneksiBuka()
        If conn.State = ConnectionState.Closed Then
            Dim myString As String
            myString = "server=localhost;user=root;password=;database=db_oksigen"
            Try
                conn.ConnectionString = myString
                conn.Open()
            Catch ex As Exception
                MsgBox("Koneksi Gagal!", MsgBoxStyle.Critical, "Error")
            End Try
        End If
        ''MsgBox("Sekarang Buka Koneksi")
    End Sub

    Public Sub KoneksiTutup()
        MsgBox("Sekarang Tutup Koneksi")
    End Sub
End Module

