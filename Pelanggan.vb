Imports System.Data.Odbc

Public Class Pelanggan

    Dim condition As Integer

    'METHOD'
    Private Sub clearData()
        idPelanggan.Clear()
        namaPelanggan.Clear()
        noWhatsApp.Clear()
        alamat.Clear()
    End Sub

    Sub enable()
        namaPelanggan.Enabled = True
        noWhatsApp.Enabled = True
        alamat.Enabled = True
        btnSimpan.Enabled = True
        btnBatal.Enabled = True
        btnTambah.Enabled = False
        btnUbah.Enabled = False
        btnHapus.Enabled = False
    End Sub

    Sub disable()
        namaPelanggan.Enabled = False
        noWhatsApp.Enabled = False
        alamat.Enabled = False
        btnSimpan.Enabled = False
        btnBatal.Enabled = False
        btnTambah.Enabled = True
        btnUbah.Enabled = True
        btnHapus.Enabled = True
    End Sub

    Sub tampilData()
        Koneksi()
        Cmd = New OdbcCommand("SELECT * FROM tbl_pelanggan", Conn)
        RD = Cmd.ExecuteReader
        DGVPelanggan.Rows.Clear()

        Do While RD.Read = True
            DGVPelanggan.Rows.Add(RD(0), RD(1), RD(2), RD(3))
        Loop
    End Sub

    Sub tambahPelanggan()
        Try
            Koneksi()
            Cmd = New OdbcCommand("INSERT INTO tbl_pelanggan (nama_pelanggan, no_hppelanggan, alamat_pelanggan) VALUES (?, ?, ?)", Conn)
            Cmd.Parameters.AddWithValue("@nilai2", namaPelanggan.Text)
            Cmd.Parameters.AddWithValue("@nilai3", noWhatsApp.Text)
            Cmd.Parameters.AddWithValue("@nilai4", alamat.Text)
            Cmd.ExecuteNonQuery()
            MessageBox.Show("Data berhasil ditambahkan!")
            Conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try
    End Sub

    Sub ubahPelanggan()
        Try
            Koneksi()
            Cmd = New OdbcCommand("UPDATE tbl_pelanggan SET nama_pelanggan = ?, no_hppelanggan = ?, alamat_pelanggan = ? WHERE id = ? ", Conn)
            Cmd.Parameters.AddWithValue("@nilai1", namaPelanggan.Text)
            Cmd.Parameters.AddWithValue("@nilai2", noWhatsApp.Text)
            Cmd.Parameters.AddWithValue("@nilai3", alamat.Text)
            Cmd.Parameters.AddWithValue("@nilai4", idPelanggan.Text)
            Cmd.ExecuteNonQuery()
            MessageBox.Show("Data berhasil diubah!")
            Conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try
    End Sub

    Sub hapusPelanggan()
        Try
            Koneksi()
            Cmd = New OdbcCommand("DELETE FROM tbl_pelanggan WHERE id = ?", Conn)
            Cmd.Parameters.AddWithValue("@nilai1", idPelanggan.Text)
            Cmd.ExecuteNonQuery()
            MessageBox.Show("Data berhasil dihapus!")
            Conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try
    End Sub

    'PROGRAM PELANGGAN'
    Private Sub Pelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Koneksi()
        tampilData()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If condition = 0 Then
            tambahPelanggan()
        ElseIf condition = 1 Then
            ubahPelanggan()
        End If
        disable()
        clearData()
        tampilData()
    End Sub

    Private Sub DGVPelanggan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVPelanggan.CellClick
        Dim index As DataGridViewRow
        If e.RowIndex >= 0 Then

            index = DGVPelanggan.Rows(e.RowIndex)
            idPelanggan.Text = index.Cells(0).Value.ToString()
            namaPelanggan.Text = index.Cells(1).Value.ToString()
            noWhatsApp.Text = index.Cells(2).Value.ToString()
            alamat.Text = index.Cells(3).Value.ToString()
        End If

    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        enable()
        clearData()
        condition = 0
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If String.IsNullOrEmpty(idPelanggan.Text) Then
            MessageBox.Show("Pilih layanan terlebih dahulu!")
            Return
        End If
        enable()
        condition = 1
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If String.IsNullOrEmpty(idPelanggan.Text) Then
            MessageBox.Show("Pilih layanan terlebih dahulu!")
            Return
        End If
        If MessageBox.Show("Apakah anda yakin untuk menghapus?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            hapusPelanggan()
            clearData()
            tampilData()
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        disable()
        clearData()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Dim frm As Dashboard = New Dashboard()
        frm.Show()
        Me.Hide()
    End Sub

End Class