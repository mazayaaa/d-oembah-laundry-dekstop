Imports System.Data.Odbc
Imports System.Globalization
Public Class Dashboard

    Dim username As String

    'METHOD'
    Sub totalPendapatan()
        Call Koneksi()
        Cmd = New OdbcCommand("SELECT SUM(total) hasil FROM tbl_transaksi", Conn)
        RD = Cmd.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            Label1.Text = Decimal.Parse(RD!hasil).ToString("C", CultureInfo.CreateSpecificCulture("id-ID"))
        End If
    End Sub

    Sub jumlahLayanan()
        Call Koneksi()
        Cmd = New OdbcCommand("Select COUNT(id)jumlah FROM tbl_layanan", Conn)
        RD = Cmd.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            Label2.Text = RD!jumlah.ToString()
        End If
    End Sub

    Sub jumlahPelanggan()
        Call Koneksi()
        Cmd = New OdbcCommand("Select COUNT(id)jumlah FROM tbl_pelanggan", Conn)
        RD = Cmd.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            Label3.Text = RD!jumlah.ToString()
        End If
    End Sub

    'PROGRAM DASHBOARD'
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Koneksi()
        LblOwner.Text = Login.nameUser
        totalPendapatan()
        jumlahLayanan()
        jumlahPelanggan()
    End Sub

    Private Sub btnTransaksi_Click(sender As Object, e As EventArgs) Handles btnTransaksi.Click
        Transaksi.Show()
        Me.Hide()
    End Sub

    Private Sub btnLayanan_Click(sender As Object, e As EventArgs) Handles btnLayanan.Click
        Layanan.Show()
        Me.Hide()
    End Sub

    Private Sub btnPelanggan_Click(sender As Object, e As EventArgs) Handles btnPelanggan.Click
        Pelanggan.Show()
        Me.Hide()
    End Sub

    Private Sub btnLaporan_Click(sender As Object, e As EventArgs) Handles btnLaporan.Click
        Laporan.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Login.Show()
        Me.Hide()
    End Sub


End Class
