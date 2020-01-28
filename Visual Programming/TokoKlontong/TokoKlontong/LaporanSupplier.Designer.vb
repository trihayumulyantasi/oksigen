<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LaporanSupplier
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
        Me.lbidlaporan = New System.Windows.Forms.Label()
        Me.lbidsupplier = New System.Windows.Forms.Label()
        Me.lbidbarang = New System.Windows.Forms.Label()
        Me.lbtglmasuk = New System.Windows.Forms.Label()
        Me.lbjatuhtempo = New System.Windows.Forms.Label()
        Me.lbstatus = New System.Windows.Forms.Label()
        Me.lbusername = New System.Windows.Forms.Label()
        Me.tbidlaporan = New System.Windows.Forms.TextBox()
        Me.cbidsupplier = New System.Windows.Forms.ComboBox()
        Me.cbidbarang = New System.Windows.Forms.ComboBox()
        Me.cbusername = New System.Windows.Forms.ComboBox()
        Me.cbstatus = New System.Windows.Forms.ComboBox()
        Me.tglmasuk = New System.Windows.Forms.DateTimePicker()
        Me.tgljatuhtempo = New System.Windows.Forms.DateTimePicker()
        Me.bttambah = New System.Windows.Forms.Button()
        Me.btedit = New System.Windows.Forms.Button()
        Me.bthapus = New System.Windows.Forms.Button()
        Me.datalaporansupplier = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnmenuutaman = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btncari = New System.Windows.Forms.Button()
        Me.tbcari = New System.Windows.Forms.TextBox()
        CType(Me.datalaporansupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbidlaporan
        '
        Me.lbidlaporan.AutoSize = True
        Me.lbidlaporan.Location = New System.Drawing.Point(10, 21)
        Me.lbidlaporan.Name = "lbidlaporan"
        Me.lbidlaporan.Size = New System.Drawing.Size(60, 13)
        Me.lbidlaporan.TabIndex = 2
        Me.lbidlaporan.Text = "ID Laporan"
        '
        'lbidsupplier
        '
        Me.lbidsupplier.AutoSize = True
        Me.lbidsupplier.Location = New System.Drawing.Point(10, 49)
        Me.lbidsupplier.Name = "lbidsupplier"
        Me.lbidsupplier.Size = New System.Drawing.Size(76, 13)
        Me.lbidsupplier.TabIndex = 3
        Me.lbidsupplier.Text = "Nama Supplier"
        '
        'lbidbarang
        '
        Me.lbidbarang.AutoSize = True
        Me.lbidbarang.Location = New System.Drawing.Point(10, 80)
        Me.lbidbarang.Name = "lbidbarang"
        Me.lbidbarang.Size = New System.Drawing.Size(72, 13)
        Me.lbidbarang.TabIndex = 4
        Me.lbidbarang.Text = "Nama Barang"
        '
        'lbtglmasuk
        '
        Me.lbtglmasuk.AutoSize = True
        Me.lbtglmasuk.Location = New System.Drawing.Point(10, 108)
        Me.lbtglmasuk.Name = "lbtglmasuk"
        Me.lbtglmasuk.Size = New System.Drawing.Size(81, 13)
        Me.lbtglmasuk.TabIndex = 5
        Me.lbtglmasuk.Text = "Tanggal Masuk"
        '
        'lbjatuhtempo
        '
        Me.lbjatuhtempo.AutoSize = True
        Me.lbjatuhtempo.Location = New System.Drawing.Point(10, 139)
        Me.lbjatuhtempo.Name = "lbjatuhtempo"
        Me.lbjatuhtempo.Size = New System.Drawing.Size(111, 13)
        Me.lbjatuhtempo.TabIndex = 6
        Me.lbjatuhtempo.Text = "Tanggal Jatuh Tempo"
        '
        'lbstatus
        '
        Me.lbstatus.AutoSize = True
        Me.lbstatus.Location = New System.Drawing.Point(397, 21)
        Me.lbstatus.Name = "lbstatus"
        Me.lbstatus.Size = New System.Drawing.Size(37, 13)
        Me.lbstatus.TabIndex = 7
        Me.lbstatus.Text = "Status"
        '
        'lbusername
        '
        Me.lbusername.AutoSize = True
        Me.lbusername.Location = New System.Drawing.Point(397, 53)
        Me.lbusername.Name = "lbusername"
        Me.lbusername.Size = New System.Drawing.Size(55, 13)
        Me.lbusername.TabIndex = 8
        Me.lbusername.Text = "Username"
        '
        'tbidlaporan
        '
        Me.tbidlaporan.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbidlaporan.Location = New System.Drawing.Point(181, 18)
        Me.tbidlaporan.Multiline = True
        Me.tbidlaporan.Name = "tbidlaporan"
        Me.tbidlaporan.Size = New System.Drawing.Size(200, 20)
        Me.tbidlaporan.TabIndex = 9
        '
        'cbidsupplier
        '
        Me.cbidsupplier.FormattingEnabled = True
        Me.cbidsupplier.Location = New System.Drawing.Point(181, 46)
        Me.cbidsupplier.Name = "cbidsupplier"
        Me.cbidsupplier.Size = New System.Drawing.Size(200, 21)
        Me.cbidsupplier.TabIndex = 10
        '
        'cbidbarang
        '
        Me.cbidbarang.FormattingEnabled = True
        Me.cbidbarang.Location = New System.Drawing.Point(181, 77)
        Me.cbidbarang.Name = "cbidbarang"
        Me.cbidbarang.Size = New System.Drawing.Size(200, 21)
        Me.cbidbarang.TabIndex = 11
        '
        'cbusername
        '
        Me.cbusername.FormattingEnabled = True
        Me.cbusername.Location = New System.Drawing.Point(531, 50)
        Me.cbusername.Name = "cbusername"
        Me.cbusername.Size = New System.Drawing.Size(200, 21)
        Me.cbusername.TabIndex = 12
        '
        'cbstatus
        '
        Me.cbstatus.FormattingEnabled = True
        Me.cbstatus.Location = New System.Drawing.Point(531, 18)
        Me.cbstatus.Name = "cbstatus"
        Me.cbstatus.Size = New System.Drawing.Size(200, 21)
        Me.cbstatus.TabIndex = 13
        '
        'tglmasuk
        '
        Me.tglmasuk.Location = New System.Drawing.Point(181, 102)
        Me.tglmasuk.Name = "tglmasuk"
        Me.tglmasuk.Size = New System.Drawing.Size(200, 20)
        Me.tglmasuk.TabIndex = 14
        '
        'tgljatuhtempo
        '
        Me.tgljatuhtempo.Location = New System.Drawing.Point(181, 133)
        Me.tgljatuhtempo.Name = "tgljatuhtempo"
        Me.tgljatuhtempo.Size = New System.Drawing.Size(200, 20)
        Me.tgljatuhtempo.TabIndex = 15
        '
        'bttambah
        '
        Me.bttambah.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.bttambah.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bttambah.Location = New System.Drawing.Point(420, 92)
        Me.bttambah.Name = "bttambah"
        Me.bttambah.Size = New System.Drawing.Size(75, 37)
        Me.bttambah.TabIndex = 16
        Me.bttambah.Text = "&Tambah"
        Me.bttambah.UseVisualStyleBackColor = False
        '
        'btedit
        '
        Me.btedit.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btedit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btedit.Location = New System.Drawing.Point(531, 92)
        Me.btedit.Name = "btedit"
        Me.btedit.Size = New System.Drawing.Size(75, 37)
        Me.btedit.TabIndex = 17
        Me.btedit.Text = "&Edit"
        Me.btedit.UseVisualStyleBackColor = False
        '
        'bthapus
        '
        Me.bthapus.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.bthapus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bthapus.Location = New System.Drawing.Point(656, 92)
        Me.bthapus.Name = "bthapus"
        Me.bthapus.Size = New System.Drawing.Size(75, 37)
        Me.bthapus.TabIndex = 18
        Me.bthapus.Text = "&Hapus"
        Me.bthapus.UseVisualStyleBackColor = False
        '
        'datalaporansupplier
        '
        Me.datalaporansupplier.AllowUserToAddRows = False
        Me.datalaporansupplier.BackgroundColor = System.Drawing.Color.Snow
        Me.datalaporansupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalaporansupplier.Location = New System.Drawing.Point(13, 174)
        Me.datalaporansupplier.Name = "datalaporansupplier"
        Me.datalaporansupplier.Size = New System.Drawing.Size(718, 150)
        Me.datalaporansupplier.TabIndex = 19
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(-9, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(808, 70)
        Me.Panel1.TabIndex = 22
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gray
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(6, -2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(795, 54)
        Me.Panel2.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(272, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(220, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Toko Kelontong O2"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Location = New System.Drawing.Point(15, 87)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(765, 30)
        Me.Panel4.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(186, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(358, 25)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Form Manage Laporan Supplier"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel3.Controls.Add(Me.btnmenuutaman)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.btncari)
        Me.Panel3.Controls.Add(Me.tbcari)
        Me.Panel3.Controls.Add(Me.tbidlaporan)
        Me.Panel3.Controls.Add(Me.lbidlaporan)
        Me.Panel3.Controls.Add(Me.datalaporansupplier)
        Me.Panel3.Controls.Add(Me.lbidsupplier)
        Me.Panel3.Controls.Add(Me.cbstatus)
        Me.Panel3.Controls.Add(Me.cbusername)
        Me.Panel3.Controls.Add(Me.bthapus)
        Me.Panel3.Controls.Add(Me.lbusername)
        Me.Panel3.Controls.Add(Me.lbidbarang)
        Me.Panel3.Controls.Add(Me.lbstatus)
        Me.Panel3.Controls.Add(Me.btedit)
        Me.Panel3.Controls.Add(Me.lbtglmasuk)
        Me.Panel3.Controls.Add(Me.bttambah)
        Me.Panel3.Controls.Add(Me.lbjatuhtempo)
        Me.Panel3.Controls.Add(Me.tgljatuhtempo)
        Me.Panel3.Controls.Add(Me.cbidsupplier)
        Me.Panel3.Controls.Add(Me.tglmasuk)
        Me.Panel3.Controls.Add(Me.cbidbarang)
        Me.Panel3.Location = New System.Drawing.Point(15, 117)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(764, 402)
        Me.Panel3.TabIndex = 25
        '
        'btnmenuutaman
        '
        Me.btnmenuutaman.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnmenuutaman.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnmenuutaman.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnmenuutaman.Location = New System.Drawing.Point(607, 346)
        Me.btnmenuutaman.Name = "btnmenuutaman"
        Me.btnmenuutaman.Size = New System.Drawing.Size(124, 23)
        Me.btnmenuutaman.TabIndex = 26
        Me.btnmenuutaman.Text = "<<Menu Utama"
        Me.btnmenuutaman.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(68, 352)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Status"
        '
        'btncari
        '
        Me.btncari.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btncari.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncari.Location = New System.Drawing.Point(470, 347)
        Me.btncari.Name = "btncari"
        Me.btncari.Size = New System.Drawing.Size(75, 23)
        Me.btncari.TabIndex = 24
        Me.btncari.Text = "&Cari"
        Me.btncari.UseVisualStyleBackColor = False
        '
        'tbcari
        '
        Me.tbcari.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbcari.Location = New System.Drawing.Point(151, 349)
        Me.tbcari.Multiline = True
        Me.tbcari.Name = "tbcari"
        Me.tbcari.Size = New System.Drawing.Size(283, 20)
        Me.tbcari.TabIndex = 23
        '
        'LaporanSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(795, 531)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LaporanSupplier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LaporanSupplier"
        CType(Me.datalaporansupplier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbidlaporan As System.Windows.Forms.Label
    Friend WithEvents lbidsupplier As System.Windows.Forms.Label
    Friend WithEvents lbidbarang As System.Windows.Forms.Label
    Friend WithEvents lbtglmasuk As System.Windows.Forms.Label
    Friend WithEvents lbjatuhtempo As System.Windows.Forms.Label
    Friend WithEvents lbstatus As System.Windows.Forms.Label
    Friend WithEvents lbusername As System.Windows.Forms.Label
    Friend WithEvents tbidlaporan As System.Windows.Forms.TextBox
    Friend WithEvents cbidsupplier As System.Windows.Forms.ComboBox
    Friend WithEvents cbidbarang As System.Windows.Forms.ComboBox
    Friend WithEvents cbusername As System.Windows.Forms.ComboBox
    Friend WithEvents cbstatus As System.Windows.Forms.ComboBox
    Friend WithEvents tglmasuk As System.Windows.Forms.DateTimePicker
    Friend WithEvents tgljatuhtempo As System.Windows.Forms.DateTimePicker
    Friend WithEvents bttambah As System.Windows.Forms.Button
    Friend WithEvents btedit As System.Windows.Forms.Button
    Friend WithEvents bthapus As System.Windows.Forms.Button
    Friend WithEvents datalaporansupplier As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btncari As System.Windows.Forms.Button
    Friend WithEvents tbcari As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnmenuutaman As System.Windows.Forms.Button
End Class
