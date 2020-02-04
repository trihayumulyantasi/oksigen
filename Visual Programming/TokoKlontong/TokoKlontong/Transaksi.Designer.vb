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
        Me.components = New System.ComponentModel.Container()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbnotrans = New System.Windows.Forms.TextBox()
        Me.lbjam = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbtanggal = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btninput = New System.Windows.Forms.Button()
        Me.tbjumlah = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lbhargabarang = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lbnamabarang = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lbidbarang = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.btnbersih = New System.Windows.Forms.Button()
        Me.tbpembayaran = New System.Windows.Forms.TextBox()
        Me.tbdiskon = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbkembalian = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lbpembayaran = New System.Windows.Forms.Label()
        Me.lbtotalitem = New System.Windows.Forms.Label()
        Me.lbtotalbayar = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnmenuutaman = New System.Windows.Forms.Button()
        Me.tbcari = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.datadibeli = New System.Windows.Forms.DataGridView()
        Me.idbarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.databarang = New System.Windows.Forms.DataGridView()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.datadibeli, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.databarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(272, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(220, 25)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Toko Kelontong O2"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gray
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Location = New System.Drawing.Point(6, -3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(795, 54)
        Me.Panel2.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(-10, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(808, 70)
        Me.Panel1.TabIndex = 28
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.GroupBox1.Controls.Add(Me.tbnotrans)
        Me.GroupBox1.Controls.Add(Me.lbjam)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lbtanggal)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Location = New System.Drawing.Point(12, 75)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(768, 67)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detail"
        '
        'tbnotrans
        '
        Me.tbnotrans.Location = New System.Drawing.Point(118, 26)
        Me.tbnotrans.Name = "tbnotrans"
        Me.tbnotrans.Size = New System.Drawing.Size(100, 20)
        Me.tbnotrans.TabIndex = 1
        '
        'lbjam
        '
        Me.lbjam.AutoSize = True
        Me.lbjam.BackColor = System.Drawing.SystemColors.Control
        Me.lbjam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbjam.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbjam.Location = New System.Drawing.Point(680, 27)
        Me.lbjam.Name = "lbjam"
        Me.lbjam.Size = New System.Drawing.Size(43, 18)
        Me.lbjam.TabIndex = 0
        Me.lbjam.Text = "lbjam"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(607, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 18)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Jam"
        '
        'lbtanggal
        '
        Me.lbtanggal.AutoSize = True
        Me.lbtanggal.BackColor = System.Drawing.SystemColors.Control
        Me.lbtanggal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbtanggal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbtanggal.Location = New System.Drawing.Point(412, 27)
        Me.lbtanggal.Name = "lbtanggal"
        Me.lbtanggal.Size = New System.Drawing.Size(66, 18)
        Me.lbtanggal.TabIndex = 0
        Me.lbtanggal.Text = "lbtanggal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(315, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tanggal"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No Transaksi"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(219, 2)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(322, 25)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Transaksi Penjualan Barang"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Location = New System.Drawing.Point(14, 148)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(764, 30)
        Me.Panel4.TabIndex = 30
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel3.Controls.Add(Me.btninput)
        Me.Panel3.Controls.Add(Me.tbjumlah)
        Me.Panel3.Controls.Add(Me.Label16)
        Me.Panel3.Controls.Add(Me.lbhargabarang)
        Me.Panel3.Controls.Add(Me.Label15)
        Me.Panel3.Controls.Add(Me.lbnamabarang)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.lbidbarang)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.btnsimpan)
        Me.Panel3.Controls.Add(Me.btnbersih)
        Me.Panel3.Controls.Add(Me.tbpembayaran)
        Me.Panel3.Controls.Add(Me.tbdiskon)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.lbkembalian)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.lbpembayaran)
        Me.Panel3.Controls.Add(Me.lbtotalitem)
        Me.Panel3.Controls.Add(Me.lbtotalbayar)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.btnmenuutaman)
        Me.Panel3.Controls.Add(Me.tbcari)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.datadibeli)
        Me.Panel3.Controls.Add(Me.databarang)
        Me.Panel3.Location = New System.Drawing.Point(14, 177)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(764, 491)
        Me.Panel3.TabIndex = 31
        '
        'btninput
        '
        Me.btninput.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btninput.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btninput.Location = New System.Drawing.Point(645, 159)
        Me.btninput.Name = "btninput"
        Me.btninput.Size = New System.Drawing.Size(75, 23)
        Me.btninput.TabIndex = 35
        Me.btninput.Text = "&Input"
        Me.btninput.UseVisualStyleBackColor = False
        '
        'tbjumlah
        '
        Me.tbjumlah.Location = New System.Drawing.Point(504, 187)
        Me.tbjumlah.Name = "tbjumlah"
        Me.tbjumlah.Size = New System.Drawing.Size(90, 20)
        Me.tbjumlah.TabIndex = 34
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.SystemColors.Control
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(376, 189)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(95, 18)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "Jumlah"
        '
        'lbhargabarang
        '
        Me.lbhargabarang.BackColor = System.Drawing.SystemColors.Control
        Me.lbhargabarang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbhargabarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbhargabarang.Location = New System.Drawing.Point(504, 159)
        Me.lbhargabarang.Name = "lbhargabarang"
        Me.lbhargabarang.Size = New System.Drawing.Size(90, 18)
        Me.lbhargabarang.TabIndex = 1
        Me.lbhargabarang.Text = "hb"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.SystemColors.Control
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(376, 159)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(95, 18)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "Harga Barang"
        '
        'lbnamabarang
        '
        Me.lbnamabarang.BackColor = System.Drawing.SystemColors.Control
        Me.lbnamabarang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbnamabarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbnamabarang.Location = New System.Drawing.Point(146, 189)
        Me.lbnamabarang.Name = "lbnamabarang"
        Me.lbnamabarang.Size = New System.Drawing.Size(112, 18)
        Me.lbnamabarang.TabIndex = 1
        Me.lbnamabarang.Text = "nb"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.SystemColors.Control
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(27, 189)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(94, 18)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Nama Barang"
        '
        'lbidbarang
        '
        Me.lbidbarang.BackColor = System.Drawing.SystemColors.Control
        Me.lbidbarang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbidbarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbidbarang.Location = New System.Drawing.Point(146, 158)
        Me.lbidbarang.Name = "lbidbarang"
        Me.lbidbarang.Size = New System.Drawing.Size(112, 18)
        Me.lbidbarang.TabIndex = 1
        Me.lbidbarang.Text = "id"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.Control
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(27, 158)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(95, 18)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "ID Barang"
        '
        'btnsimpan
        '
        Me.btnsimpan.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnsimpan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsimpan.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnsimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsimpan.Location = New System.Drawing.Point(539, 374)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(88, 42)
        Me.btnsimpan.TabIndex = 33
        Me.btnsimpan.Text = "&Simpan"
        Me.btnsimpan.UseVisualStyleBackColor = False
        '
        'btnbersih
        '
        Me.btnbersih.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnbersih.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnbersih.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnbersih.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbersih.Location = New System.Drawing.Point(633, 374)
        Me.btnbersih.Name = "btnbersih"
        Me.btnbersih.Size = New System.Drawing.Size(88, 42)
        Me.btnbersih.TabIndex = 33
        Me.btnbersih.Text = "&Bersih"
        Me.btnbersih.UseVisualStyleBackColor = False
        '
        'tbpembayaran
        '
        Me.tbpembayaran.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbpembayaran.Location = New System.Drawing.Point(376, 374)
        Me.tbpembayaran.Name = "tbpembayaran"
        Me.tbpembayaran.Size = New System.Drawing.Size(100, 20)
        Me.tbpembayaran.TabIndex = 32
        '
        'tbdiskon
        '
        Me.tbdiskon.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbdiskon.Location = New System.Drawing.Point(125, 374)
        Me.tbdiskon.Name = "tbdiskon"
        Me.tbdiskon.Size = New System.Drawing.Size(100, 20)
        Me.tbdiskon.TabIndex = 32
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 226)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(140, 16)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Data Barang Dibeli"
        '
        'lbkembalian
        '
        Me.lbkembalian.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbkembalian.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbkembalian.Location = New System.Drawing.Point(376, 395)
        Me.lbkembalian.Name = "lbkembalian"
        Me.lbkembalian.Size = New System.Drawing.Size(100, 21)
        Me.lbkembalian.TabIndex = 30
        Me.lbkembalian.Text = "lbkembalian"
        '
        'Label13
        '
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(273, 395)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(100, 21)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Kembalian"
        '
        'lbpembayaran
        '
        Me.lbpembayaran.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbpembayaran.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbpembayaran.Location = New System.Drawing.Point(273, 374)
        Me.lbpembayaran.Name = "lbpembayaran"
        Me.lbpembayaran.Size = New System.Drawing.Size(100, 21)
        Me.lbpembayaran.TabIndex = 30
        Me.lbpembayaran.Text = "Pembayaran"
        '
        'lbtotalitem
        '
        Me.lbtotalitem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbtotalitem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbtotalitem.Location = New System.Drawing.Point(125, 416)
        Me.lbtotalitem.Name = "lbtotalitem"
        Me.lbtotalitem.Size = New System.Drawing.Size(100, 21)
        Me.lbtotalitem.TabIndex = 30
        Me.lbtotalitem.Text = "lbtotalitem"
        '
        'lbtotalbayar
        '
        Me.lbtotalbayar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbtotalbayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbtotalbayar.Location = New System.Drawing.Point(125, 395)
        Me.lbtotalbayar.Name = "lbtotalbayar"
        Me.lbtotalbayar.Size = New System.Drawing.Size(100, 21)
        Me.lbtotalbayar.TabIndex = 30
        Me.lbtotalbayar.Text = "lbtotalbayar"
        '
        'Label11
        '
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(24, 416)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(93, 21)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Total Item"
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(24, 395)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(93, 21)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "Total Bayar"
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(25, 374)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 21)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Diskon"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(227, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Nama Barang"
        '
        'btnmenuutaman
        '
        Me.btnmenuutaman.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnmenuutaman.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnmenuutaman.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnmenuutaman.Location = New System.Drawing.Point(597, 450)
        Me.btnmenuutaman.Name = "btnmenuutaman"
        Me.btnmenuutaman.Size = New System.Drawing.Size(124, 23)
        Me.btnmenuutaman.TabIndex = 29
        Me.btnmenuutaman.Text = "<<Menu Utama"
        Me.btnmenuutaman.UseVisualStyleBackColor = False
        '
        'tbcari
        '
        Me.tbcari.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbcari.Location = New System.Drawing.Point(325, 18)
        Me.tbcari.Multiline = True
        Me.tbcari.Name = "tbcari"
        Me.tbcari.Size = New System.Drawing.Size(283, 20)
        Me.tbcari.TabIndex = 27
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Data Barang"
        '
        'datadibeli
        '
        Me.datadibeli.AllowUserToAddRows = False
        Me.datadibeli.BackgroundColor = System.Drawing.Color.Snow
        Me.datadibeli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datadibeli.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idbarang, Me.nama, Me.harga, Me.jumlah, Me.total})
        Me.datadibeli.Location = New System.Drawing.Point(24, 254)
        Me.datadibeli.Name = "datadibeli"
        Me.datadibeli.Size = New System.Drawing.Size(696, 104)
        Me.datadibeli.TabIndex = 5
        '
        'idbarang
        '
        Me.idbarang.HeaderText = "ID Barang"
        Me.idbarang.Name = "idbarang"
        Me.idbarang.ReadOnly = True
        '
        'nama
        '
        Me.nama.HeaderText = "Nama Barang"
        Me.nama.Name = "nama"
        Me.nama.ReadOnly = True
        '
        'harga
        '
        Me.harga.HeaderText = "Harga"
        Me.harga.Name = "harga"
        Me.harga.ReadOnly = True
        '
        'jumlah
        '
        Me.jumlah.HeaderText = "Jumlah"
        Me.jumlah.Name = "jumlah"
        Me.jumlah.ReadOnly = True
        '
        'total
        '
        Me.total.HeaderText = "Total"
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        '
        'databarang
        '
        Me.databarang.AllowUserToAddRows = False
        Me.databarang.BackgroundColor = System.Drawing.Color.Snow
        Me.databarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.databarang.Location = New System.Drawing.Point(25, 44)
        Me.databarang.Name = "databarang"
        Me.databarang.Size = New System.Drawing.Size(696, 104)
        Me.databarang.TabIndex = 5
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Transaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 680)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Transaksi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaksi"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.datadibeli, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.databarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbjam As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbtanggal As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents tbpembayaran As System.Windows.Forms.TextBox
    Friend WithEvents tbdiskon As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lbkembalian As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lbpembayaran As System.Windows.Forms.Label
    Friend WithEvents lbtotalbayar As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnmenuutaman As System.Windows.Forms.Button
    Friend WithEvents tbcari As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents datadibeli As System.Windows.Forms.DataGridView
    Friend WithEvents databarang As System.Windows.Forms.DataGridView
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lbtotalitem As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents btnbersih As System.Windows.Forms.Button
    Friend WithEvents tbjumlah As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lbhargabarang As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lbnamabarang As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lbidbarang As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btninput As System.Windows.Forms.Button
    Friend WithEvents idbarang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nama As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents harga As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jumlah As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tbnotrans As System.Windows.Forms.TextBox
End Class
