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
        Me.Label1 = New System.Windows.Forms.Label()
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
        CType(Me.datalaporansupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(180, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(203, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Laporan Supplier"
        '
        'lbidlaporan
        '
        Me.lbidlaporan.AutoSize = True
        Me.lbidlaporan.Location = New System.Drawing.Point(12, 57)
        Me.lbidlaporan.Name = "lbidlaporan"
        Me.lbidlaporan.Size = New System.Drawing.Size(60, 13)
        Me.lbidlaporan.TabIndex = 2
        Me.lbidlaporan.Text = "ID Laporan"
        '
        'lbidsupplier
        '
        Me.lbidsupplier.AutoSize = True
        Me.lbidsupplier.Location = New System.Drawing.Point(12, 85)
        Me.lbidsupplier.Name = "lbidsupplier"
        Me.lbidsupplier.Size = New System.Drawing.Size(59, 13)
        Me.lbidsupplier.TabIndex = 3
        Me.lbidsupplier.Text = "ID Supplier"
        '
        'lbidbarang
        '
        Me.lbidbarang.AutoSize = True
        Me.lbidbarang.Location = New System.Drawing.Point(12, 116)
        Me.lbidbarang.Name = "lbidbarang"
        Me.lbidbarang.Size = New System.Drawing.Size(55, 13)
        Me.lbidbarang.TabIndex = 4
        Me.lbidbarang.Text = "ID Barang"
        '
        'lbtglmasuk
        '
        Me.lbtglmasuk.AutoSize = True
        Me.lbtglmasuk.Location = New System.Drawing.Point(12, 144)
        Me.lbtglmasuk.Name = "lbtglmasuk"
        Me.lbtglmasuk.Size = New System.Drawing.Size(81, 13)
        Me.lbtglmasuk.TabIndex = 5
        Me.lbtglmasuk.Text = "Tanggal Masuk"
        '
        'lbjatuhtempo
        '
        Me.lbjatuhtempo.AutoSize = True
        Me.lbjatuhtempo.Location = New System.Drawing.Point(12, 175)
        Me.lbjatuhtempo.Name = "lbjatuhtempo"
        Me.lbjatuhtempo.Size = New System.Drawing.Size(111, 13)
        Me.lbjatuhtempo.TabIndex = 6
        Me.lbjatuhtempo.Text = "Tanggal Jatuh Tempo"
        '
        'lbstatus
        '
        Me.lbstatus.AutoSize = True
        Me.lbstatus.Location = New System.Drawing.Point(12, 206)
        Me.lbstatus.Name = "lbstatus"
        Me.lbstatus.Size = New System.Drawing.Size(37, 13)
        Me.lbstatus.TabIndex = 7
        Me.lbstatus.Text = "Status"
        '
        'lbusername
        '
        Me.lbusername.AutoSize = True
        Me.lbusername.Location = New System.Drawing.Point(12, 238)
        Me.lbusername.Name = "lbusername"
        Me.lbusername.Size = New System.Drawing.Size(55, 13)
        Me.lbusername.TabIndex = 8
        Me.lbusername.Text = "Username"
        '
        'tbidlaporan
        '
        Me.tbidlaporan.Location = New System.Drawing.Point(183, 54)
        Me.tbidlaporan.Name = "tbidlaporan"
        Me.tbidlaporan.Size = New System.Drawing.Size(200, 20)
        Me.tbidlaporan.TabIndex = 9
        '
        'cbidsupplier
        '
        Me.cbidsupplier.FormattingEnabled = True
        Me.cbidsupplier.Location = New System.Drawing.Point(183, 82)
        Me.cbidsupplier.Name = "cbidsupplier"
        Me.cbidsupplier.Size = New System.Drawing.Size(200, 21)
        Me.cbidsupplier.TabIndex = 10
        '
        'cbidbarang
        '
        Me.cbidbarang.FormattingEnabled = True
        Me.cbidbarang.Location = New System.Drawing.Point(183, 113)
        Me.cbidbarang.Name = "cbidbarang"
        Me.cbidbarang.Size = New System.Drawing.Size(200, 21)
        Me.cbidbarang.TabIndex = 11
        '
        'cbusername
        '
        Me.cbusername.FormattingEnabled = True
        Me.cbusername.Location = New System.Drawing.Point(183, 235)
        Me.cbusername.Name = "cbusername"
        Me.cbusername.Size = New System.Drawing.Size(200, 21)
        Me.cbusername.TabIndex = 12
        '
        'cbstatus
        '
        Me.cbstatus.FormattingEnabled = True
        Me.cbstatus.Location = New System.Drawing.Point(183, 203)
        Me.cbstatus.Name = "cbstatus"
        Me.cbstatus.Size = New System.Drawing.Size(200, 21)
        Me.cbstatus.TabIndex = 13
        '
        'tglmasuk
        '
        Me.tglmasuk.Location = New System.Drawing.Point(183, 138)
        Me.tglmasuk.Name = "tglmasuk"
        Me.tglmasuk.Size = New System.Drawing.Size(200, 20)
        Me.tglmasuk.TabIndex = 14
        '
        'tgljatuhtempo
        '
        Me.tgljatuhtempo.Location = New System.Drawing.Point(183, 169)
        Me.tgljatuhtempo.Name = "tgljatuhtempo"
        Me.tgljatuhtempo.Size = New System.Drawing.Size(200, 20)
        Me.tgljatuhtempo.TabIndex = 15
        '
        'bttambah
        '
        Me.bttambah.Location = New System.Drawing.Point(435, 54)
        Me.bttambah.Name = "bttambah"
        Me.bttambah.Size = New System.Drawing.Size(98, 44)
        Me.bttambah.TabIndex = 16
        Me.bttambah.Text = "&Tambah"
        Me.bttambah.UseVisualStyleBackColor = True
        '
        'btedit
        '
        Me.btedit.Location = New System.Drawing.Point(435, 113)
        Me.btedit.Name = "btedit"
        Me.btedit.Size = New System.Drawing.Size(98, 44)
        Me.btedit.TabIndex = 17
        Me.btedit.Text = "&Edit"
        Me.btedit.UseVisualStyleBackColor = True
        '
        'bthapus
        '
        Me.bthapus.Location = New System.Drawing.Point(435, 175)
        Me.bthapus.Name = "bthapus"
        Me.bthapus.Size = New System.Drawing.Size(98, 44)
        Me.bthapus.TabIndex = 18
        Me.bthapus.Text = "&Hapus"
        Me.bthapus.UseVisualStyleBackColor = True
        '
        'datalaporansupplier
        '
        Me.datalaporansupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalaporansupplier.Location = New System.Drawing.Point(12, 264)
        Me.datalaporansupplier.Name = "datalaporansupplier"
        Me.datalaporansupplier.Size = New System.Drawing.Size(521, 150)
        Me.datalaporansupplier.TabIndex = 19
        '
        'LaporanSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(548, 430)
        Me.Controls.Add(Me.datalaporansupplier)
        Me.Controls.Add(Me.bthapus)
        Me.Controls.Add(Me.btedit)
        Me.Controls.Add(Me.bttambah)
        Me.Controls.Add(Me.tgljatuhtempo)
        Me.Controls.Add(Me.tglmasuk)
        Me.Controls.Add(Me.cbstatus)
        Me.Controls.Add(Me.cbusername)
        Me.Controls.Add(Me.cbidbarang)
        Me.Controls.Add(Me.cbidsupplier)
        Me.Controls.Add(Me.tbidlaporan)
        Me.Controls.Add(Me.lbusername)
        Me.Controls.Add(Me.lbstatus)
        Me.Controls.Add(Me.lbjatuhtempo)
        Me.Controls.Add(Me.lbtglmasuk)
        Me.Controls.Add(Me.lbidbarang)
        Me.Controls.Add(Me.lbidsupplier)
        Me.Controls.Add(Me.lbidlaporan)
        Me.Controls.Add(Me.Label1)
        Me.Name = "LaporanSupplier"
        Me.Text = "LaporanSupplier"
        CType(Me.datalaporansupplier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
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
End Class
