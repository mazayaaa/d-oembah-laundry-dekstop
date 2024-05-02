<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pelanggan
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
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnKembali = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnLogout = New Guna.UI2.WinForms.Guna2Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Guna2DateTimePickerPelanggan = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.alamat = New System.Windows.Forms.TextBox()
        Me.noWhatsApp = New System.Windows.Forms.TextBox()
        Me.namaPelanggan = New System.Windows.Forms.TextBox()
        Me.idPelanggan = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.DGVPelanggan = New System.Windows.Forms.DataGridView()
        Me.id_pelanggan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_pelanggan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.no_whatsapp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.alamat_pelanggan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVPelanggan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBatal
        '
        Me.btnBatal.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnBatal.Enabled = False
        Me.btnBatal.Font = New System.Drawing.Font("Swis721 Hv BT", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBatal.Location = New System.Drawing.Point(283, 552)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(109, 41)
        Me.btnBatal.TabIndex = 9
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = False
        '
        'btnKembali
        '
        Me.btnKembali.Font = New System.Drawing.Font("Swis721 Hv BT", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKembali.Location = New System.Drawing.Point(1080, 607)
        Me.btnKembali.Name = "btnKembali"
        Me.btnKembali.Size = New System.Drawing.Size(105, 30)
        Me.btnKembali.TabIndex = 12
        Me.btnKembali.Text = "Kembali"
        Me.btnKembali.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.BackColor = System.Drawing.Color.LightCoral
        Me.btnHapus.Font = New System.Drawing.Font("Swis721 Hv BT", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapus.Location = New System.Drawing.Point(349, 434)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(126, 82)
        Me.btnHapus.TabIndex = 7
        Me.btnHapus.Text = "Hapus Pelanggan"
        Me.btnHapus.UseVisualStyleBackColor = False
        '
        'btnUbah
        '
        Me.btnUbah.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnUbah.Font = New System.Drawing.Font("Swis721 Hv BT", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUbah.Location = New System.Drawing.Point(202, 434)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(126, 82)
        Me.btnUbah.TabIndex = 6
        Me.btnUbah.Text = "Ubah Pelanggan"
        Me.btnUbah.UseVisualStyleBackColor = False
        '
        'btnTambah
        '
        Me.btnTambah.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.btnTambah.Font = New System.Drawing.Font("Swis721 Hv BT", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambah.Location = New System.Drawing.Point(56, 434)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(126, 82)
        Me.btnTambah.TabIndex = 5
        Me.btnTambah.Text = "Tambah Pelanggan"
        Me.btnTambah.UseVisualStyleBackColor = False
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
        Me.btnLogout.Location = New System.Drawing.Point(1066, 14)
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
        Me.Label12.Size = New System.Drawing.Size(217, 36)
        Me.Label12.TabIndex = 73
        Me.Label12.Text = "PELANGGAN"
        '
        'Guna2DateTimePickerPelanggan
        '
        Me.Guna2DateTimePickerPelanggan.Checked = True
        Me.Guna2DateTimePickerPelanggan.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2DateTimePickerPelanggan.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.Guna2DateTimePickerPelanggan.Location = New System.Drawing.Point(899, 85)
        Me.Guna2DateTimePickerPelanggan.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.Guna2DateTimePickerPelanggan.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.Guna2DateTimePickerPelanggan.Name = "Guna2DateTimePickerPelanggan"
        Me.Guna2DateTimePickerPelanggan.Size = New System.Drawing.Size(290, 36)
        Me.Guna2DateTimePickerPelanggan.TabIndex = 10
        Me.Guna2DateTimePickerPelanggan.Value = New Date(2023, 12, 23, 18, 4, 43, 644)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Swis721 LtEx BT", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(31, 346)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 21)
        Me.Label4.TabIndex = 68
        Me.Label4.Text = "Alamat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Swis721 LtEx BT", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 295)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 21)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "No. WhatsApp"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Swis721 LtEx BT", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 245)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(172, 21)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "Nama Pelanggan"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Swis721 LtEx BT", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 198)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 21)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "ID Pelanggan"
        '
        'alamat
        '
        Me.alamat.Enabled = False
        Me.alamat.Font = New System.Drawing.Font("Swis721 LtEx BT", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.alamat.Location = New System.Drawing.Point(244, 343)
        Me.alamat.Name = "alamat"
        Me.alamat.Size = New System.Drawing.Size(242, 29)
        Me.alamat.TabIndex = 4
        '
        'noWhatsApp
        '
        Me.noWhatsApp.Enabled = False
        Me.noWhatsApp.Font = New System.Drawing.Font("Swis721 LtEx BT", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.noWhatsApp.Location = New System.Drawing.Point(244, 292)
        Me.noWhatsApp.Name = "noWhatsApp"
        Me.noWhatsApp.Size = New System.Drawing.Size(242, 29)
        Me.noWhatsApp.TabIndex = 3
        '
        'namaPelanggan
        '
        Me.namaPelanggan.Enabled = False
        Me.namaPelanggan.Font = New System.Drawing.Font("Swis721 LtEx BT", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.namaPelanggan.Location = New System.Drawing.Point(244, 242)
        Me.namaPelanggan.Name = "namaPelanggan"
        Me.namaPelanggan.Size = New System.Drawing.Size(242, 29)
        Me.namaPelanggan.TabIndex = 2
        '
        'idPelanggan
        '
        Me.idPelanggan.Enabled = False
        Me.idPelanggan.Font = New System.Drawing.Font("Swis721 LtEx BT", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idPelanggan.Location = New System.Drawing.Point(244, 195)
        Me.idPelanggan.Name = "idPelanggan"
        Me.idPelanggan.Size = New System.Drawing.Size(242, 29)
        Me.idPelanggan.TabIndex = 1
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.FP_PEMDES.My.Resources.Resources.panel_atas
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1213, 63)
        Me.PictureBox2.TabIndex = 74
        Me.PictureBox2.TabStop = False
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.LightGreen
        Me.btnSimpan.Enabled = False
        Me.btnSimpan.Font = New System.Drawing.Font("Swis721 Hv BT", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.Location = New System.Drawing.Point(138, 552)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(109, 41)
        Me.btnSimpan.TabIndex = 75
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'DGVPelanggan
        '
        Me.DGVPelanggan.AllowUserToAddRows = False
        Me.DGVPelanggan.AllowUserToDeleteRows = False
        Me.DGVPelanggan.AllowUserToResizeColumns = False
        Me.DGVPelanggan.AllowUserToResizeRows = False
        Me.DGVPelanggan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Swis721 LtEx BT", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVPelanggan.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVPelanggan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVPelanggan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_pelanggan, Me.nama_pelanggan, Me.no_whatsapp, Me.alamat_pelanggan})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Swis721 LtEx BT", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVPelanggan.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGVPelanggan.Location = New System.Drawing.Point(508, 156)
        Me.DGVPelanggan.Margin = New System.Windows.Forms.Padding(4)
        Me.DGVPelanggan.Name = "DGVPelanggan"
        Me.DGVPelanggan.RowHeadersVisible = False
        Me.DGVPelanggan.RowHeadersWidth = 51
        Me.DGVPelanggan.Size = New System.Drawing.Size(681, 434)
        Me.DGVPelanggan.TabIndex = 76
        '
        'id_pelanggan
        '
        Me.id_pelanggan.HeaderText = "Id Pelanggan"
        Me.id_pelanggan.MinimumWidth = 6
        Me.id_pelanggan.Name = "id_pelanggan"
        '
        'nama_pelanggan
        '
        Me.nama_pelanggan.HeaderText = "Nama Pelanggan"
        Me.nama_pelanggan.MinimumWidth = 6
        Me.nama_pelanggan.Name = "nama_pelanggan"
        '
        'no_whatsapp
        '
        Me.no_whatsapp.HeaderText = "No. WhatsApp"
        Me.no_whatsapp.MinimumWidth = 6
        Me.no_whatsapp.Name = "no_whatsapp"
        '
        'alamat_pelanggan
        '
        Me.alamat_pelanggan.HeaderText = "Alamat"
        Me.alamat_pelanggan.MinimumWidth = 6
        Me.alamat_pelanggan.Name = "alamat_pelanggan"
        '
        'Pelanggan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1213, 653)
        Me.Controls.Add(Me.DGVPelanggan)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnKembali)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnUbah)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Guna2DateTimePickerPelanggan)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.alamat)
        Me.Controls.Add(Me.noWhatsApp)
        Me.Controls.Add(Me.namaPelanggan)
        Me.Controls.Add(Me.idPelanggan)
        Me.Name = "Pelanggan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pelanggan"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVPelanggan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnKembali As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnLogout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Guna2DateTimePickerPelanggan As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents alamat As TextBox
    Friend WithEvents noWhatsApp As TextBox
    Friend WithEvents namaPelanggan As TextBox
    Friend WithEvents idPelanggan As TextBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents DGVPelanggan As DataGridView
    Friend WithEvents id_pelanggan As DataGridViewTextBoxColumn
    Friend WithEvents nama_pelanggan As DataGridViewTextBoxColumn
    Friend WithEvents no_whatsapp As DataGridViewTextBoxColumn
    Friend WithEvents alamat_pelanggan As DataGridViewTextBoxColumn
End Class
