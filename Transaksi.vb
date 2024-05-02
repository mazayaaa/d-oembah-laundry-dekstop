Imports System.Data.Odbc

Public Class Transaksi

    Dim dt As DataTable
    Dim hargaLayanan As Integer
    Dim durasiLayanan As Integer
    Dim rowIndex As Integer
    Dim durasiTerbesar As Integer

    'METHOD'
    Sub tampilInvoice()
        Koneksi()
        Dim query As String = "SELECT CONCAT('INV/',
                        CASE 
                        WHEN MAX(CONVERT(SUBSTRING(faktur, 5, 3), UNSIGNED)) IS NULL THEN '001' 
                        ELSE LPAD(MAX(CONVERT(SUBSTRING(faktur, 5, 3), UNSIGNED)) + 1, 3, '0') 
                        END
                        ,'/',LPAD(MONTH(NOW()), 2, '0'),'/',YEAR(NOW())) AS nomor 
                        FROM ( SELECT 
                        MAX(CONVERT(SUBSTRING(faktur, 9, 2), UNSIGNED)) AS bln, 
                        MAX(CONVERT(SUBSTRING(faktur, 12, 4), UNSIGNED)) AS thn, 
                        faktur FROM tbl_transaksi GROUP BY faktur) a LIMIT 0, 25;"

        Cmd = New OdbcCommand(query, Conn)
        RD = Cmd.ExecuteReader
        If RD.HasRows Then
            RD.Read()
            Dim nmr As String = RD.Item("nomor").ToString
            RD.Close()
            Cmd.Dispose()
            faktur.Text = nmr
        End If
    End Sub

    Sub clear()
        cbxIdPelanggan.Text = "PILIH PELANGGAN"
        LblNamaPelanggan.Text = "-"
        LblNoWA.Text = "-"
        LblAlamat.Text = "-"
        cbxNamaLayanan.Text = "PILIH LAYANAN"
        txtQty.Value = 0
        cbxMetode.SelectedIndex = 0
        dt.Rows.Clear()
        total.Text = "0"
        kembalian.Text = "0"
        txtBayar.Value = 0
        tampilInvoice()
    End Sub

    Sub cbPelanggan()
        Koneksi()
        Cmd = New OdbcCommand("SELECT * FROM tbl_pelanggan", Conn)
        dt = New DataTable
        Dim da As New OdbcDataAdapter(Cmd)
        da.Fill(dt)
        cbxIdPelanggan.DataSource = dt
        cbxIdPelanggan.DisplayMember = "nama_pelanggan"
        cbxIdPelanggan.ValueMember = "id"
        cbxIdPelanggan.Text = "PILIH PELANGGAN"
    End Sub

    Sub cbLayanan()
        Call Koneksi()
        Cmd = New OdbcCommand("SELECT * FROM tbl_layanan", Conn)
        dt = New DataTable
        Dim da As New OdbcDataAdapter(Cmd)
        da.Fill(dt)
        cbxNamaLayanan.DataSource = dt
        cbxNamaLayanan.DisplayMember = "nama_layanan"
        cbxNamaLayanan.ValueMember = "id"
        cbxNamaLayanan.Text = "PILIH LAYANAN"
    End Sub

    Private Function validasiCB(cb1 As ComboBox, cb2 As ComboBox) As Boolean
        If (cb1.Text = "PILIH PELANGGAN") Then
            MessageBox.Show("PILIH PELANGGAN TERLEBIH DAHULU")
            Return False
        ElseIf (cb2.Text = "PILIH LAYANAN") Then
            MessageBox.Show("PILIH LAYANAN TERLEBIH DAHULU")
            Return False
        End If
        Return True
    End Function

    Sub addCart()
        If (cbxNamaLayanan.Text.Equals("PILIH LAYANAN")) Then
            MessageBox.Show("PILIH LAYANAN TERLEBIH DAHULU")
            Return
        End If
        If txtQty.Value = 0 Or txtQty.Text.Trim() = "" Then
            MessageBox.Show("Kuantitas Tidak Boleh Kosong")
            Return
        Else
            Dim dr As DataRow = dt.NewRow()
            dr(0) = Convert.ToInt32(cbxNamaLayanan.SelectedValue)
            dr(1) = cbxNamaLayanan.Text
            dr(2) = txtQty.Value
            dr(3) = hargaLayanan
            dr(4) = durasiLayanan
            dr(5) = hargaLayanan * Convert.ToInt32(txtQty.Value)
            dt.Rows.Add(dr)
        End If
    End Sub

    Sub showCart()
        dt = New DataTable
        dt.Columns.Add("ID LAYANAN")
        dt.Columns.Add("NAMA LAYANAN")
        dt.Columns.Add("KUANTITAS")
        dt.Columns.Add("HARGA")
        dt.Columns.Add("DURASI")
        dt.Columns.Add("TOTAL HARGA")
        DGVTransaksi.DataSource = dt
        DGVTransaksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Sub hitungTotal()
        Dim GrandTotal As Integer = 0
        For i As Integer = 0 To DGVTransaksi.Rows.Count - 1
            GrandTotal += Convert.ToInt32(DGVTransaksi.Rows(i).Cells(5).Value)
        Next
        total.Text = GrandTotal.ToString()
    End Sub

    Function GetMaxValue(dataTable As DataTable, columnName As String) As Integer
        ' Menggunakan metode Compute untuk mendapatkan nilai terbesar
        Dim result As Object = dataTable.Compute("MAX(" & columnName & ")", String.Empty)
        ' Memastikan hasil tidak null sebelum mengonversi ke Integer
        If result IsNot DBNull.Value AndAlso result IsNot Nothing Then
            Return Convert.ToInt32(result)
        Else
            ' Mengembalikan nilai default jika tidak ada data atau hasil null
            Return 0
        End If
    End Function

    'PROGRAM TRANSAKSI'
    Private Sub Transaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Koneksi()
        tampilInvoice()
        cbPelanggan()
        cbLayanan()
        showCart()
        cbxMetode.SelectedIndex = 0
        DGVTransaksi.Columns(0).Visible = False
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Dim frm As Dashboard = New Dashboard()
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub cbxIdPelanggan_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbxIdPelanggan.SelectionChangeCommitted
        Koneksi()
        Cmd = New OdbcCommand("Select * From tbl_pelanggan where id='" & cbxIdPelanggan.SelectedValue & "'", Conn)
        RD = Cmd.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            LblNamaPelanggan.Text = RD!nama_pelanggan
            LblNoWA.Text = RD!no_hppelanggan
            LblAlamat.Text = RD!alamat_pelanggan
        End If
    End Sub

    Private Sub cbxNamaLayanan_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbxNamaLayanan.SelectionChangeCommitted
        Cmd = New OdbcCommand("Select * From tbl_layanan where id='" & cbxNamaLayanan.SelectedValue & "'", Conn)
        RD = Cmd.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            hargaLayanan = RD!harga_layanan
            durasiLayanan = RD!durasi_layanan
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Try
            If validasiCB(cbxIdPelanggan, cbxNamaLayanan) = False Then
                Return
            End If

            If DGVTransaksi.Rows.Count = 0 Then
                MessageBox.Show("Keranjang Kosong!")
                Return
            End If
            If Convert.ToInt32(txtBayar.Value) < Convert.ToInt32(total.Text) Then
                MessageBox.Show("Uang Bayar Kurang!")
                Return

            End If

            Dim durasiTerbesar As Integer = GetMaxValue(dt, "Durasi")

            Call Koneksi()

            Cmd = New OdbcCommand("INSERT INTO tbl_transaksi (faktur, id_pelanggan, tgl_transaksi,tgl_selesai, metode_pembayaran, total,total_bayar,kembalian) VALUES (?,?,?,?,?,?,?,?);", Conn)
            Cmd.Parameters.AddWithValue("@nilai1", faktur.Text)
            Cmd.Parameters.AddWithValue("@nilai2", Convert.ToInt32(cbxIdPelanggan.SelectedValue))
            Cmd.Parameters.AddWithValue("@nilai3", DateTime.Now)
            Cmd.Parameters.AddWithValue("@nilai4", DateTime.Now.AddDays(durasiTerbesar))
            Cmd.Parameters.AddWithValue("@nilai5", cbxMetode.Text)
            Cmd.Parameters.AddWithValue("@nilai6", Convert.ToInt32(total.Text))
            Cmd.Parameters.AddWithValue("@nilai7", Convert.ToInt32(txtBayar.Value))
            Cmd.Parameters.AddWithValue("@nilai8", Convert.ToInt32(kembalian.Text))

            Cmd.ExecuteNonQuery()

            For i As Integer = 0 To DGVTransaksi.Rows.Count - 1
                Cmd = New OdbcCommand("INSERT INTO tbl_detailtransaksi (id_transaksi, id_layanan, kuantitas, total) VALUES ( ?, ?, ?, ?);", Conn)
                Cmd.Parameters.AddWithValue("@nilai1", faktur.Text)
                Cmd.Parameters.AddWithValue("@nilai2", Convert.ToInt32(DGVTransaksi.Rows(i).Cells(0).Value))
                Cmd.Parameters.AddWithValue("@nilai3", Convert.ToInt32(DGVTransaksi.Rows(i).Cells(2).Value))
                Cmd.Parameters.AddWithValue("@nilai4", Convert.ToInt32(DGVTransaksi.Rows(i).Cells(5).Value))
                Cmd.ExecuteNonQuery()
            Next


            MessageBox.Show("Transaksi Berhasil!")
            clear()

            Conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())

        End Try
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim validasi = False
        '1. Cek jika data kosong
        If DGVTransaksi.Rows.Count = 0 Then

            addCart()
            validasi = True

            '2. Cek apakah data ada yang sama
        Else
            For i As Integer = 0 To DGVTransaksi.Rows.Count - 1
                If DGVTransaksi.Rows(i).Cells(0).Value.ToString() = cbxNamaLayanan.SelectedValue Then
                    Dim qty As Integer = Convert.ToInt32(DGVTransaksi.Rows(i).Cells(2).Value)

                    Dim totalQty As Integer = qty + Convert.ToInt32(txtQty.Value)
                    DGVTransaksi.Rows(i).Cells(2).Value = totalQty
                    DGVTransaksi.Rows(i).Cells(5).Value = totalQty * Convert.ToInt32(hargaLayanan)
                    hitungTotal()
                    validasi = True
                    Return
                End If
            Next

        End If

        '3. jika tidak sama maka buat baru
        If validasi = False Then
            addCart()
        End If
        hitungTotal()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If DGVTransaksi.Rows.Count > 0 Then
            If rowIndex >= 0 Then
                dt.Rows.RemoveAt(rowIndex)

                hitungTotal()
            Else
                MessageBox.Show("Pilih data!")
            End If
        Else
            MessageBox.Show("Keranjang Kosong!")
        End If
    End Sub

    Private Sub DGVTransaksi_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVTransaksi.CellClick
        Dim index As DataGridViewRow
        If e.RowIndex >= 0 Then
            rowIndex = e.RowIndex
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        clear()
    End Sub

    Private Sub txtBayar_ValueChanged(sender As Object, e As EventArgs) Handles txtBayar.ValueChanged
        kembalian.Text = Convert.ToInt32(txtBayar.Value) - Convert.ToInt32(total.Text)
    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        Laporan.Show()
    End Sub
End Class