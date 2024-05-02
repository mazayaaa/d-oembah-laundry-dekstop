<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transaksi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.faktur = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LblNamaPelanggan = New System.Windows.Forms.Label()
        Me.LblNoWA = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LblAlamat = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tglTransaksi = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbxNamaLayanan = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cbxMetode = New System.Windows.Forms.ComboBox()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnCetak = New System.Windows.Forms.Button()
        Me.btnKembali = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.total = New System.Windows.Forms.TextBox()
        Me.kembalian = New System.Windows.Forms.TextBox()
        Me.btnLogout = New Guna.UI2.WinForms.Guna2Button()
        Me.cbxIdPelanggan = New System.Windows.Forms.ComboBox()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.txtQty = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.DGVTransaksi = New System.Windows.Forms.DataGridView()
        Me.txtBayar = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.txtQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVTransaksi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBayar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'faktur
        '
        Me.faktur.Font = New System.Drawing.Font("Swis721 LtEx BT", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.faktur.Location = New System.Drawing.Point(248, 137)
        Me.faktur.Name = "faktur"
        Me.faktur.Size = New System.Drawing.Size(242, 29)
        Me.faktur.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Swis721 LtEx BT", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 140)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 21)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Faktur"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Swis721 LtEx BT", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 182)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 21)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "ID Pelanggan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Swis721 LtEx BT", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(35, 223)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(172, 21)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Nama Pelanggan"
        '
        'LblNamaPelanggan
        '
        Me.LblNamaPelanggan.AutoSize = True
        Me.LblNamaPelanggan.Font = New System.Drawing.Font("Swis721 LtEx BT", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNamaPelanggan.Location = New System.Drawing.Point(244, 223)
        Me.LblNamaPelanggan.Name = "LblNamaPelanggan"
        Me.LblNamaPelanggan.Size = New System.Drawing.Size(18, 21)
        Me.LblNamaPelanggan.TabIndex = 3
        Me.LblNamaPelanggan.Text = "-"
        '
        'LblNoWA
        '
        Me.LblNoWA.AutoSize = True
        Me.LblNoWA.Font = New System.Drawing.Font("Swis721 LtEx BT", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNoWA.Location = New System.Drawing.Point(244, 264)
        Me.LblNoWA.Name = "LblNoWA"
        Me.LblNoWA.Size = New System.Drawing.Size(18, 21)
        Me.LblNoWA.TabIndex = 4
        Me.LblNoWA.Text = "-"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Swis721 LtEx BT", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(35, 264)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(145, 21)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "No. WhatsApp"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Swis721 LtEx BT", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(711, 681)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(167, 21)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Total Bayar = Rp"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Swis721 LtEx BT", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(518, 245)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(206, 21)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Metode Pembayaran"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Swis721 LtEx BT", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(518, 192)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 21)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Kuantitas"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Swis721 LtEx BT", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(518, 140)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 21)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Layanan"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Swis721 LtEx BT", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(711, 725)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(168, 21)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Kembalian  = Rp"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Swis721 LtEx BT", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(922, 192)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 21)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Kg"
        '
        'LblAlamat
        '
        Me.LblAlamat.AutoSize = True
        Me.LblAlamat.Font = New System.Drawing.Font("Swis721 LtEx BT", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAlamat.Location = New System.Drawing.Point(244, 302)
        Me.LblAlamat.Name = "LblAlamat"
        Me.LblAlamat.Size = New System.Drawing.Size(18, 21)
        Me.LblAlamat.TabIndex = 5
        Me.LblAlamat.Text = "-"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Swis721 LtEx BT", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(35, 302)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(76, 21)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Alamat"
        '
        'tglTransaksi
        '
        Me.tglTransaksi.Checked = True
        Me.tglTransaksi.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tglTransaksi.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.tglTransaksi.Location = New System.Drawing.Point(824, 78)
        Me.tglTransaksi.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.tglTransaksi.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.tglTransaksi.Name = "tglTransaksi"
        Me.tglTransaksi.Size = New System.Drawing.Size(290, 36)
        Me.tglTransaksi.TabIndex = 10
        Me.tglTransaksi.Value = New Date(2023, 12, 23, 18, 4, 43, 644)
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Swis721 Blk BT", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(26, 78)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(202, 36)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "TRANSAKSI"
        '
        'cbxNamaLayanan
        '
        Me.cbxNamaLayanan.Font = New System.Drawing.Font("Swis721 LtEx BT", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxNamaLayanan.FormattingEnabled = True
        Me.cbxNamaLayanan.Location = New System.Drawing.Point(771, 137)
        Me.cbxNamaLayanan.Name = "cbxNamaLayanan"
        Me.cbxNamaLayanan.Size = New System.Drawing.Size(269, 29)
        Me.cbxNamaLayanan.TabIndex = 6
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Swis721 LtEx BT", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(361, 688)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(113, 21)
        Me.Label14.TabIndex = 38
        Me.Label14.Text = "Total = Rp "
        '
        'cbxMetode
        '
        Me.cbxMetode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxMetode.Font = New System.Drawing.Font("Swis721 LtEx BT", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxMetode.FormattingEnabled = True
        Me.cbxMetode.Items.AddRange(New Object() {"Tunai", "BCA", "QRIS"})
        Me.cbxMetode.Location = New System.Drawing.Point(771, 242)
        Me.cbxMetode.Name = "cbxMetode"
        Me.cbxMetode.Size = New System.Drawing.Size(269, 29)
        Me.cbxMetode.TabIndex = 9
        '
        'btnSimpan
        '
        Me.btnSimpan.Font = New System.Drawing.Font("Swis721 Hv BT", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.Location = New System.Drawing.Point(81, 672)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(109, 41)
        Me.btnSimpan.TabIndex = 12
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnCetak
        '
        Me.btnCetak.Font = New System.Drawing.Font("Swis721 Hv BT", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCetak.Location = New System.Drawing.Point(81, 731)
        Me.btnCetak.Name = "btnCetak"
        Me.btnCetak.Size = New System.Drawing.Size(236, 41)
        Me.btnCetak.TabIndex = 14
        Me.btnCetak.Text = "Cetak"
        Me.btnCetak.UseVisualStyleBackColor = True
        '
        'btnKembali
        '
        Me.btnKembali.Font = New System.Drawing.Font("Swis721 Hv BT", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKembali.Location = New System.Drawing.Point(1006, 765)
        Me.btnKembali.Name = "btnKembali"
        Me.btnKembali.Size = New System.Drawing.Size(105, 30)
        Me.btnKembali.TabIndex = 18
        Me.btnKembali.Text = "Kembali"
        Me.btnKembali.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Font = New System.Drawing.Font("Swis721 Hv BT", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBatal.Location = New System.Drawing.Point(208, 672)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(109, 41)
        Me.btnBatal.TabIndex = 13
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'total
        '
        Me.total.Font = New System.Drawing.Font("Swis721 LtEx BT", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total.Location = New System.Drawing.Point(485, 685)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(203, 29)
        Me.total.TabIndex = 15
        '
        'kembalian
        '
        Me.kembalian.Font = New System.Drawing.Font("Swis721 LtEx BT", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kembalian.Location = New System.Drawing.Point(906, 722)
        Me.kembalian.Name = "kembalian"
        Me.kembalian.Size = New System.Drawing.Size(203, 29)
        Me.kembalian.TabIndex = 17
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Transparent
        Me.btnLogout.BorderColor = System.Drawing.Color.Transparent
        Me.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnLogout.FillColor = System.Drawing.Color.Transparent
        Me.btnLogout.Font = New System.Drawing.Font("Swis721 Hv BT", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(995, 14)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(127, 35)
        Me.btnLogout.TabIndex = 53
        Me.btnLogout.Text = "LogOut"
        Me.btnLogout.UseTransparentBackground = True
        '
        'cbxIdPelanggan
        '
        Me.cbxIdPelanggan.Font = New System.Drawing.Font("Swis721 LtEx BT", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxIdPelanggan.FormattingEnabled = True
        Me.cbxIdPelanggan.Location = New System.Drawing.Point(248, 179)
        Me.cbxIdPelanggan.Name = "cbxIdPelanggan"
        Me.cbxIdPelanggan.Size = New System.Drawing.Size(242, 29)
        Me.cbxIdPelanggan.TabIndex = 2
        '
        'btnHapus
        '
        Me.btnHapus.Font = New System.Drawing.Font("Swis721 Hv BT", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapus.Location = New System.Drawing.Point(947, 293)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(144, 40)
        Me.btnHapus.TabIndex = 54
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'txtQty
        '
        Me.txtQty.BackColor = System.Drawing.Color.Transparent
        Me.txtQty.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtQty.Font = New System.Drawing.Font("Swis721 LtEx BT", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty.Location = New System.Drawing.Point(770, 185)
        Me.txtQty.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(145, 37)
        Me.txtQty.TabIndex = 78
        '
        'btnTambah
        '
        Me.btnTambah.Font = New System.Drawing.Font("Swis721 Hv BT", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambah.Location = New System.Drawing.Point(771, 293)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(144, 40)
        Me.btnTambah.TabIndex = 79
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'DGVTransaksi
        '
        Me.DGVTransaksi.AllowUserToAddRows = False
        Me.DGVTransaksi.AllowUserToDeleteRows = False
        Me.DGVTransaksi.AllowUserToResizeColumns = False
        Me.DGVTransaksi.AllowUserToResizeRows = False
        Me.DGVTransaksi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Swis721 LtEx BT", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVTransaksi.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Swis721 LtEx BT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVTransaksi.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGVTransaksi.Location = New System.Drawing.Point(39, 353)
        Me.DGVTransaksi.Margin = New System.Windows.Forms.Padding(4)
        Me.DGVTransaksi.Name = "DGVTransaksi"
        Me.DGVTransaksi.RowHeadersVisible = False
        Me.DGVTransaksi.RowHeadersWidth = 51
        Me.DGVTransaksi.Size = New System.Drawing.Size(1072, 305)
        Me.DGVTransaksi.TabIndex = 80
        '
        'txtBayar
        '
        Me.txtBayar.BackColor = System.Drawing.Color.Transparent
        Me.txtBayar.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBayar.Font = New System.Drawing.Font("Swis721 LtEx BT", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBayar.Location = New System.Drawing.Point(905, 672)
        Me.txtBayar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtBayar.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.txtBayar.Name = "txtBayar"
        Me.txtBayar.Size = New System.Drawing.Size(204, 35)
        Me.txtBayar.TabIndex = 81
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.FP_PEMDES.My.Resources.Resources.panel_atas
        Me.PictureBox2.Location = New System.Drawing.Point(-1, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1143, 63)
        Me.PictureBox2.TabIndex = 52
        Me.PictureBox2.TabStop = False
        '
        'Transaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1143, 812)
        Me.Controls.Add(Me.txtBayar)
        Me.Controls.Add(Me.DGVTransaksi)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.cbxIdPelanggan)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.kembalian)
        Me.Controls.Add(Me.total)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnKembali)
        Me.Controls.Add(Me.btnCetak)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.cbxMetode)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.cbxNamaLayanan)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.tglTransaksi)
        Me.Controls.Add(Me.LblAlamat)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LblNoWA)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LblNamaPelanggan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.faktur)
        Me.Name = "Transaksi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaksi"
        CType(Me.txtQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVTransaksi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBayar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents faktur As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LblNamaPelanggan As Label
    Friend WithEvents LblNoWA As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents LblAlamat As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents tglTransaksi As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label12 As Label
    Friend WithEvents cbxNamaLayanan As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents cbxMetode As ComboBox
    Friend WithEvents Guna2DataGridViewStyler1 As Guna.UI2.WinForms.Guna2DataGridViewStyler
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnCetak As Button
    Friend WithEvents btnKembali As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents total As TextBox
    Friend WithEvents kembalian As TextBox
    Friend WithEvents btnLogout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents cbxIdPelanggan As ComboBox
    Friend WithEvents btnHapus As Button
    Friend WithEvents txtQty As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents btnTambah As Button
    Friend WithEvents DGVTransaksi As DataGridView
    Friend WithEvents txtBayar As Guna.UI2.WinForms.Guna2NumericUpDown
End Class
