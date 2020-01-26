Public Class panduan

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub btlogout_Click(sender As Object, e As EventArgs) Handles btlogout.Click
        Dim result As Integer = MessageBox.Show("Anda yakin akan keluar?", "Peringatan", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class