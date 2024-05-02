<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Layanan
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.idLayanan = New System.Windows.Forms.TextBox()
        Me.namaLayanan = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.durasi = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.harga = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnLogout = New Guna.UI2.WinForms.Guna2Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Guna2DateTimePickerLayanan = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnKembali = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.DGVLayanan = New System.Windows.Forms.DataGridView()
        Me.id_layanan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_layanan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.durasi_layanan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga_layanan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVLayanan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Swis721 LtEx BT", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 198)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 21)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "ID Layanan"
        '
        'idLayanan
        '
        Me.idLayanan.Enabled = False
        Me.idLayanan.Font = New System.Drawing.Font("Swis721 LtEx BT", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idLayanan.Location = New System.Drawing.Point(244, 195)
        Me.idLayanan.Name = "idLayanan"
        Me.idLayanan.Size = New System.Drawing.Size(242, 29)
        Me.idLayanan.TabIndex = 2
        '
        'namaLayanan
        '
        Me.namaLayanan.Enabled = False
        Me.namaLayanan.Font = New System.Drawing.Font("Swis721 LtEx BT", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.namaLayanan.Location = New System.Drawing.Point(244, 242)
        Me.namaLayanan.Name = "namaLayanan"
        Me.namaLayanan.Size = New System.Drawing.Size(242, 29)
        Me.namaLayanan.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Swis721 LtEx BT", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 245)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 21)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Nama Layanan"
        '
        'durasi
        '
        Me.durasi.Enabled = False
        Me.durasi.Font = New System.Drawing.Font("Swis721 LtEx BT", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.durasi.Location = New System.Drawing.Point(244, 292)
        Me.durasi.Name = "durasi"
        Me.durasi.Size = New System.Drawing.Size(177, 29)
        Me.durasi.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Swis721 LtEx BT", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 295)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 21)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Durasi"
        '
        'harga
        '
        Me.harga.Enabled = False
        Me.harga.Font = New System.Drawing.Font("Swis721 LtEx BT", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.harga.Location = New System.Drawing.Point(285, 343)
        Me.harga.Name = "harga"
        Me.harga.Size = New System.Drawing.Size(201, 29)
        Me.harga.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Swis721 LtEx BT", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(31, 346)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 21)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Harga"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Swis721 LtEx BT", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(240, 346)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 21)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Rp"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Swis721 LtEx BT", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(433, 295)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 21)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Hari"
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
        Me.btnLogout.Location = New System.Drawing.Point(1067, 14)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(127, 35)
        Me.btnLogout.TabIndex = 13
        Me.btnLogout.Text = "LogOut"
        Me.btnLogout.UseTransparentBackground = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Swis721 Blk BT", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(175, 107)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(170, 36)
        Me.Label12.TabIndex = 55
        Me.Label12.Text = "LAYANAN"
        '
        'Guna2DateTimePickerLayanan
        '
        Me.Guna2DateTimePickerLayanan.Checked = True
        Me.Guna2DateTimePickerLayanan.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2DateTimePickerLayanan.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.Guna2DateTimePickerLayanan.Location = New System.Drawing.Point(896, 83)
        Me.Guna2DateTimePickerLayanan.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.Guna2DateTimePickerLayanan.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.Guna2DateTimePickerLayanan.Name = "Guna2DateTimePickerLayanan"
        Me.Guna2DateTimePickerLayanan.Size = New System.Drawing.Size(290, 36)
        Me.Guna2DateTimePickerLayanan.TabIndex = 1
        Me.Guna2DateTimePickerLayanan.Value = New Date(2023, 12, 23, 18, 4, 43, 644)
        '
        'btnBatal
        '
        Me.btnBatal.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnBatal.Enabled = False
        Me.btnBatal.Font = New System.Drawing.Font("Swis721 Hv BT", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBatal.Location = New System.Drawing.Point(274, 551)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(109, 41)
        Me.btnBatal.TabIndex = 10
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = False
        '
        'btnKembali
        '
        Me.btnKembali.Font = New System.Drawing.Font("Swis721 Hv BT", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKembali.Location = New System.Drawing.Point(1074, 601)
        Me.btnKembali.Name = "btnKembali"
        Me.btnKembali.Size = New System.Drawing.Size(105, 30)
        Me.btnKembali.TabIndex = 12
        Me.btnKembali.Text = "Kembali"
        Me.btnKembali.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.btnTambah.Font = New System.Drawing.Font("Swis721 Hv BT", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambah.Location = New System.Drawing.Point(56, 434)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(109, 82)
        Me.btnTambah.TabIndex = 6
        Me.btnTambah.Text = "Tambah Layanan"
        Me.btnTambah.UseVisualStyleBackColor = False
        '
        'btnUbah
        '
        Me.btnUbah.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnUbah.Font = New System.Drawing.Font("Swis721 Hv BT", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUbah.Location = New System.Drawing.Point(202, 434)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(109, 82)
        Me.btnUbah.TabIndex = 7
        Me.btnUbah.Text = "Ubah Layanan"
        Me.btnUbah.UseVisualStyleBackColor = False
        '
        'btnHapus
        '
        Me.btnHapus.BackColor = System.Drawing.Color.LightCoral
        Me.btnHapus.Font = New System.Drawing.Font("Swis721 Hv BT", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapus.Location = New System.Drawing.Point(349, 434)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(109, 82)
        Me.btnHapus.TabIndex = 8
        Me.btnHapus.Text = "Hapus Layanan"
        Me.btnHapus.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.FP_PEMDES.My.Resources.Resources.panel_atas
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1212, 63)
        Me.PictureBox2.TabIndex = 56
        Me.PictureBox2.TabStop = False
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.LightGreen
        Me.btnSimpan.Enabled = False
        Me.btnSimpan.Font = New System.Drawing.Font("Swis721 Hv BT", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.Location = New System.Drawing.Point(127, 551)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(109, 41)
        Me.btnSimpan.TabIndex = 10
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'DGVLayanan
        '
        Me.DGVLayanan.AllowUserToAddRows = False
        Me.DGVLayanan.AllowUserToDeleteRows = False
        Me.DGVLayanan.AllowUserToResizeColumns = False
        Me.DGVLayanan.AllowUserToResizeRows = False
        Me.DGVLayanan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Swis721 LtEx BT", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVLayanan.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DGVLayanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVLayanan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_layanan, Me.nama_layanan, Me.durasi_layanan, Me.harga_layanan})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Swis721 LtEx BT", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVLayanan.DefaultCellStyle = DataGridViewCellStyle4
        Me.DGVLayanan.Location = New System.Drawing.Point(525, 147)
        Me.DGVLayanan.Margin = New System.Windows.Forms.Padding(4)
        Me.DGVLayanan.Name = "DGVLayanan"
        Me.DGVLayanan.RowHeadersVisible = False
        Me.DGVLayanan.RowHeadersWidth = 51
        Me.DGVLayanan.Size = New System.Drawing.Size(654, 434)
        Me.DGVLayanan.TabIndex = 58
        '
        'id_layanan
        '
        Me.id_layanan.HeaderText = "Id Layanan"
        Me.id_layanan.MinimumWidth = 6
        Me.id_layanan.Name = "id_layanan"
        '
        'nama_layanan
        '
        Me.nama_layanan.HeaderText = "Nama Layanan"
        Me.nama_layanan.MinimumWidth = 6
        Me.nama_layanan.Name = "nama_layanan"
        '
        'durasi_layanan
        '
        Me.durasi_layanan.HeaderText = "Durasi"
        Me.durasi_layanan.MinimumWidth = 6
        Me.durasi_layanan.Name = "durasi_layanan"
        '
        'harga_layanan
        '
        Me.harga_layanan.HeaderText = "Harga"
        Me.harga_layanan.MinimumWidth = 6
        Me.harga_layanan.Name = "harga_layanan"
        '
        'Layanan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1213, 653)
        Me.Controls.Add(Me.DGVLayanan)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnKembali)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnUbah)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Guna2DateTimePickerLayanan)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.harga)
        Me.Controls.Add(Me.durasi)
        Me.Controls.Add(Me.namaLayanan)
        Me.Controls.Add(Me.idLayanan)
        Me.Name = "Layanan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Layanan"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVLayanan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents idLayanan As TextBox
    Friend WithEvents namaLayanan As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents durasi As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents harga As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnLogout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Guna2DateTimePickerLayanan As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnKembali As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents DGVLayanan As DataGridView
    Friend WithEvents id_layanan As DataGridViewTextBoxColumn
    Friend WithEvents nama_layanan As DataGridViewTextBoxColumn
    Friend WithEvents durasi_layanan As DataGridViewTextBoxColumn
    Friend WithEvents harga_layanan As DataGridViewTextBoxColumn
End Class
