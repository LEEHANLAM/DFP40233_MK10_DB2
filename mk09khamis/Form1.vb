Imports MySql.Data.MySqlClient

Public Class Form1
    Private conn As MySqlConnection

    Private Sub FormKelas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New MySqlConnection("Server=172.20.10.3;Database=mk9;Uid=username;Pwd=password;")
        LoadDataKelas()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LoadDataKelas() ' Refresh the data every tick (every minute)
    End Sub

    Private Sub LoadDataKelas()
        Dim query As String = "SELECT * FROM kelas"
        Dim cmd As MySqlCommand = New MySqlCommand(query, conn)
        Dim adapter As New MySqlDataAdapter(cmd)
        Dim table As New DataTable()

        Try
            conn.Open()
            adapter.Fill(table)
            dataGridViewKelas.DataSource = table
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnAddKelas_Click(sender As Object, e As EventArgs) Handles btnAddKelas.Click
        Dim query As String = "INSERT INTO kelas (idkelas, namakelas) VALUES (@idkelas, @namakelas)"
        Dim cmd As MySqlCommand = New MySqlCommand(query, conn)

        cmd.Parameters.AddWithValue("@idkelas", txtIdKelas.Text)
        cmd.Parameters.AddWithValue("@namakelas", txtNamaKelas.Text)

        Try
            conn.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Kelas added successfully.")
            LoadDataKelas()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnUpdateKelas_Click(sender As Object, e As EventArgs) Handles btnUpdateKelas.Click
        Dim query As String = "UPDATE kelas SET namakelas = @namakelas WHERE idkelas = @idkelas"
        Dim cmd As MySqlCommand = New MySqlCommand(query, conn)

        cmd.Parameters.AddWithValue("@idkelas", txtIdKelas.Text)
        cmd.Parameters.AddWithValue("@namakelas", txtNamaKelas.Text)

        Try
            conn.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Kelas updated successfully.")
            LoadDataKelas()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnDeleteKelas_Click(sender As Object, e As EventArgs) Handles btnDeleteKelas.Click
        Dim query As String = "DELETE FROM kelas WHERE idkelas = @idkelas"
        Dim cmd As MySqlCommand = New MySqlCommand(query, conn)

        cmd.Parameters.AddWithValue("@idkelas", txtIdKelas.Text)

        Try
            conn.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Kelas deleted successfully.")
            LoadDataKelas()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub dataGridViewKelas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridViewKelas.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dataGridViewKelas.Rows(e.RowIndex)
            txtIdKelas.Text = row.Cells("idkelas").Value.ToString()
            txtNamaKelas.Text = row.Cells("namakelas").Value.ToString()
        End If
    End Sub


End Class
