Imports System.Data.Odbc

Public Class Layanan

    Dim condition As Integer

    'METHOD'
    Private Sub clearData()
        idLayanan.Clear()
        namaLayanan.Clear()
        durasi.Clear()
        harga.Clear()
    End Sub

    Sub enable()
        namaLayanan.Enabled = True
        harga.Enabled = True
        durasi.Enabled = True
        btnSimpan.Enabled = True
        btnBatal.Enabled = True
        btnTambah.Enabled = False
        btnUbah.Enabled = False
        btnHapus.Enabled = False
    End Sub

    Sub disable()
        namaLayanan.Enabled = False
        harga.Enabled = False
        durasi.Enabled = False
        btnSimpan.Enabled = False
        btnBatal.Enabled = False
        btnTambah.Enabled = True
        btnUbah.Enabled = True
        btnHapus.Enabled = True
    End Sub

    Sub tampilData()
        Koneksi()
        Cmd = New OdbcCommand("SELECT * FROM tbl_layanan", Conn)
        RD = Cmd.ExecuteReader
        DGVLayanan.Rows.Clear()

        Do While RD.Read = True
            DGVLayanan.Rows.Add(RD(0), RD(1), RD(2), RD(3))
        Loop
    End Sub

    Sub tambahLayanan()
        Try
            Koneksi()
            Cmd = New OdbcCommand("INSERT INTO tbl_layanan (nama_layanan, durasi_layanan, harga_layanan) VALUES (?, ?, ?)", Conn)
            Cmd.Parameters.AddWithValue("@nilai2", namaLayanan.Text)
            Cmd.Parameters.AddWithValue("@nilai3", durasi.Text)
            Cmd.Parameters.AddWithValue("@nilai4", harga.Text)
            Cmd.ExecuteNonQuery()
            MessageBox.Show("Data berhasil ditambahkan!")
            Conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try
    End Sub

    Sub ubahLayanan()
        Try
            Koneksi()
            Cmd = New OdbcCommand("UPDATE tbl_layanan SET nama_layanan = ?, durasi_layanan = ?, harga_layanan = ? WHERE id = ? ", Conn)
            Cmd.Parameters.AddWithValue("@nilai1", namaLayanan.Text)
            Cmd.Parameters.AddWithValue("@nilai2", durasi.Text)
            Cmd.Parameters.AddWithValue("@nilai3", harga.Text)
            Cmd.Parameters.AddWithValue("@nilai4", idLayanan.Text)
            Cmd.ExecuteNonQuery()
            MessageBox.Show("Data berhasil diubah!")
            Conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try
    End Sub

    Sub hapusLayanan()
        Try
            Koneksi()
            Cmd = New OdbcCommand("DELETE FROM tbl_layanan WHERE id = ?", Conn)
            Cmd.Parameters.AddWithValue("@nilai1", idLayanan.Text)
            Cmd.ExecuteNonQuery()
            MessageBox.Show("Data berhasil dihapus!")
            Conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try
    End Sub

    'PROGRAM LAYANAN'
    Private Sub Layanan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Koneksi()
        tampilData()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If condition = 0 Then
            tambahLayanan()
        ElseIf condition = 1 Then
            ubahLayanan()
        End If
        disable()
        clearData()
        tampilData()
    End Sub

    Private Sub DGVLayanan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVLayanan.CellClick
        Dim index As DataGridViewRow
        If e.RowIndex >= 0 Then
            index = DGVLayanan.Rows(e.RowIndex)
            idLayanan.Text = index.Cells(0).Value.ToString()
            namaLayanan.Text = index.Cells(1).Value.ToString()
            durasi.Text = index.Cells(2).Value.ToString()
            harga.Text = index.Cells(3).Value.ToString()
        End If
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        enable()
        clearData()
        condition = 0
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If String.IsNullOrEmpty(idLayanan.Text) Then
            MessageBox.Show("Pilih layanan terlebih dahulu!")
            Return
        End If
        enable()
        condition = 1
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If String.IsNullOrEmpty(idLayanan.Text) Then
            MessageBox.Show("Pilih layanan terlebih dahulu!")
            Return
        End If
        If MessageBox.Show("Apakah anda yakin untuk menghapus?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            hapusLayanan()
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