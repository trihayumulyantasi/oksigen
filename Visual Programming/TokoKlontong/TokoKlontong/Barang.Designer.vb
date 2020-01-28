<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Barang
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
        Me.lbidbarang = New System.Windows.Forms.Label()
        Me.lbnamabarang = New System.Windows.Forms.Label()
        Me.lbhargajual = New System.Windows.Forms.Label()
        Me.lbstock = New System.Windows.Forms.Label()
        Me.lbidsupplier = New System.Windows.Forms.Label()
        Me.tbidbarang = New System.Windows.Forms.TextBox()
        Me.tbnamabarang = New System.Windows.Forms.TextBox()
        Me.tbhargajual = New System.Windows.Forms.TextBox()
        Me.tbstock = New System.Windows.Forms.TextBox()
        Me.cbidsupplier = New System.Windows.Forms.ComboBox()
        Me.bttambah = New System.Windows.Forms.Button()
        Me.btedit = New System.Windows.Forms.Button()
        Me.bthapus = New System.Windows.Forms.Button()
        Me.databarang = New System.Windows.Forms.DataGridView()
        Me.tbhargasupplier = New System.Windows.Forms.TextBox()
        Me.lbhargasupplier = New System.Windows.Forms.Label()
        Me.lbwaktuinput = New System.Windows.Forms.Label()
        Me.lbidadmin = New System.Windows.Forms.Label()
        Me.tglinput = New System.Windows.Forms.DateTimePicker()
        Me.cbidadmin = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnmenuutaman = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btncari = New System.Windows.Forms.Button()
        Me.tbcari = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.databarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(272, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Toko Kelontong O2"
        '
        'lbidbarang
        '
        Me.lbidbarang.AutoSize = True
        Me.lbidbarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbidbarang.Location = New System.Drawing.Point(18, 28)
        Me.lbidbarang.Name = "lbidbarang"
        Me.lbidbarang.Size = New System.Drawing.Size(55, 13)
        Me.lbidbarang.TabIndex = 1
        Me.lbidbarang.Text = "ID Barang"
        '
        'lbnamabarang
        '
        Me.lbnamabarang.AutoSize = True
        Me.lbnamabarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbnamabarang.Location = New System.Drawing.Point(18, 60)
        Me.lbnamabarang.Name = "lbnamabarang"
        Me.lbnamabarang.Size = New System.Drawing.Size(72, 13)
        Me.lbnamabarang.TabIndex = 2
        Me.lbnamabarang.Text = "Nama Barang"
        '
        'lbhargajual
        '
        Me.lbhargajual.AutoSize = True
        Me.lbhargajual.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbhargajual.Location = New System.Drawing.Point(18, 93)
        Me.lbhargajual.Name = "lbhargajual"
        Me.lbhargajual.Size = New System.Drawing.Size(58, 13)
        Me.lbhargajual.TabIndex = 3
        Me.lbhargajual.Text = "Harga Jual"
        '
        'lbstock
        '
        Me.lbstock.AutoSize = True
        Me.lbstock.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbstock.Location = New System.Drawing.Point(15, 166)
        Me.lbstock.Name = "lbstock"
        Me.lbstock.Size = New System.Drawing.Size(35, 13)
        Me.lbstock.TabIndex = 4
        Me.lbstock.Text = "Stock"
        '
        'lbidsupplier
        '
        Me.lbidsupplier.AutoSize = True
        Me.lbidsupplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbidsupplier.Location = New System.Drawing.Point(402, 28)
        Me.lbidsupplier.Name = "lbidsupplier"
        Me.lbidsupplier.Size = New System.Drawing.Size(76, 13)
        Me.lbidsupplier.TabIndex = 5
        Me.lbidsupplier.Text = "Nama Supplier"
        '
        'tbidbarang
        '
        Me.tbidbarang.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbidbarang.Location = New System.Drawing.Point(134, 25)
        Me.tbidbarang.Multiline = True
        Me.tbidbarang.Name = "tbidbarang"
        Me.tbidbarang.Size = New System.Drawing.Size(206, 20)
        Me.tbidbarang.TabIndex = 6
        '
        'tbnamabarang
        '
        Me.tbnamabarang.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbnamabarang.Location = New System.Drawing.Point(134, 57)
        Me.tbnamabarang.Multiline = True
        Me.tbnamabarang.Name = "tbnamabarang"
        Me.tbnamabarang.Size = New System.Drawing.Size(206, 20)
        Me.tbnamabarang.TabIndex = 7
        '
        'tbhargajual
        '
        Me.tbhargajual.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbhargajual.Location = New System.Drawing.Point(134, 90)
        Me.tbhargajual.Multiline = True
        Me.tbhargajual.Name = "tbhargajual"
        Me.tbhargajual.Size = New System.Drawing.Size(206, 20)
        Me.tbhargajual.TabIndex = 8
        '
        'tbstock
        '
        Me.tbstock.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbstock.Location = New System.Drawing.Point(134, 163)
        Me.tbstock.Multiline = True
        Me.tbstock.Name = "tbstock"
        Me.tbstock.Size = New System.Drawing.Size(206, 20)
        Me.tbstock.TabIndex = 9
        '
        'cbidsupplier
        '
        Me.cbidsupplier.FormattingEnabled = True
        Me.cbidsupplier.Location = New System.Drawing.Point(531, 25)
        Me.cbidsupplier.Name = "cbidsupplier"
        Me.cbidsupplier.Size = New System.Drawing.Size(206, 21)
        Me.cbidsupplier.TabIndex = 10
        '
        'bttambah
        '
        Me.bttambah.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.bttambah.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bttambah.Location = New System.Drawing.Point(405, 142)
        Me.bttambah.Name = "bttambah"
        Me.bttambah.Size = New System.Drawing.Size(75, 37)
        Me.bttambah.TabIndex = 11
        Me.bttambah.Text = "&Tambah"
        Me.bttambah.UseVisualStyleBackColor = False
        '
        'btedit
        '
        Me.btedit.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btedit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btedit.Location = New System.Drawing.Point(531, 142)
        Me.btedit.Name = "btedit"
        Me.btedit.Size = New System.Drawing.Size(75, 37)
        Me.btedit.TabIndex = 12
        Me.btedit.Text = "&Edit"
        Me.btedit.UseVisualStyleBackColor = False
        '
        'bthapus
        '
        Me.bthapus.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.bthapus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bthapus.Location = New System.Drawing.Point(662, 142)
        Me.bthapus.Name = "bthapus"
        Me.bthapus.Size = New System.Drawing.Size(75, 37)
        Me.bthapus.TabIndex = 13
        Me.bthapus.Text = "&Hapus"
        Me.bthapus.UseVisualStyleBackColor = False
        '
        'databarang
        '
        Me.databarang.AllowUserToAddRows = False
        Me.databarang.BackgroundColor = System.Drawing.Color.Snow
        Me.databarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.databarang.Location = New System.Drawing.Point(21, 200)
        Me.databarang.Name = "databarang"
        Me.databarang.Size = New System.Drawing.Size(716, 131)
        Me.databarang.TabIndex = 14
        '
        'tbhargasupplier
        '
        Me.tbhargasupplier.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbhargasupplier.Location = New System.Drawing.Point(134, 124)
        Me.tbhargasupplier.Multiline = True
        Me.tbhargasupplier.Name = "tbhargasupplier"
        Me.tbhargasupplier.Size = New System.Drawing.Size(206, 20)
        Me.tbhargasupplier.TabIndex = 16
        '
        'lbhargasupplier
        '
        Me.lbhargasupplier.AutoSize = True
        Me.lbhargasupplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbhargasupplier.Location = New System.Drawing.Point(16, 127)
        Me.lbhargasupplier.Name = "lbhargasupplier"
        Me.lbhargasupplier.Size = New System.Drawing.Size(77, 13)
        Me.lbhargasupplier.TabIndex = 15
        Me.lbhargasupplier.Text = "Harga Supplier"
        '
        'lbwaktuinput
        '
        Me.lbwaktuinput.AutoSize = True
        Me.lbwaktuinput.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbwaktuinput.Location = New System.Drawing.Point(401, 64)
        Me.lbwaktuinput.Name = "lbwaktuinput"
        Me.lbwaktuinput.Size = New System.Drawing.Size(66, 13)
        Me.lbwaktuinput.TabIndex = 17
        Me.lbwaktuinput.Text = "Waktu Input"
        '
        'lbidadmin
        '
        Me.lbidadmin.AutoSize = True
        Me.lbidadmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbidadmin.Location = New System.Drawing.Point(401, 99)
        Me.lbidadmin.Name = "lbidadmin"
        Me.lbidadmin.Size = New System.Drawing.Size(67, 13)
        Me.lbidadmin.TabIndex = 18
        Me.lbidadmin.Text = "Nama Admin"
        '
        'tglinput
        '
        Me.tglinput.Enabled = False
        Me.tglinput.Location = New System.Drawing.Point(531, 58)
        Me.tglinput.Name = "tglinput"
        Me.tglinput.Size = New System.Drawing.Size(206, 20)
        Me.tglinput.TabIndex = 19
        '
        'cbidadmin
        '
        Me.cbidadmin.FormattingEnabled = True
        Me.cbidadmin.Location = New System.Drawing.Point(531, 96)
        Me.cbidadmin.Name = "cbidadmin"
        Me.cbidadmin.Size = New System.Drawing.Size(206, 21)
        Me.cbidadmin.TabIndex = 20
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(-10, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(808, 70)
        Me.Panel1.TabIndex = 21
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gray
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(6, -2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(795, 54)
        Me.Panel2.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel3.Controls.Add(Me.btnmenuutaman)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.btncari)
        Me.Panel3.Controls.Add(Me.tbcari)
        Me.Panel3.Controls.Add(Me.lbidadmin)
        Me.Panel3.Controls.Add(Me.cbidadmin)
        Me.Panel3.Controls.Add(Me.tglinput)
        Me.Panel3.Controls.Add(Me.lbwaktuinput)
        Me.Panel3.Controls.Add(Me.cbidsupplier)
        Me.Panel3.Controls.Add(Me.tbhargasupplier)
        Me.Panel3.Controls.Add(Me.databarang)
        Me.Panel3.Controls.Add(Me.lbhargasupplier)
        Me.Panel3.Controls.Add(Me.bthapus)
        Me.Panel3.Controls.Add(Me.btedit)
        Me.Panel3.Controls.Add(Me.bttambah)
        Me.Panel3.Controls.Add(Me.tbstock)
        Me.Panel3.Controls.Add(Me.tbhargajual)
        Me.Panel3.Controls.Add(Me.tbnamabarang)
        Me.Panel3.Controls.Add(Me.tbidbarang)
        Me.Panel3.Controls.Add(Me.lbidsupplier)
        Me.Panel3.Controls.Add(Me.lbstock)
        Me.Panel3.Controls.Add(Me.lbhargajual)
        Me.Panel3.Controls.Add(Me.lbnamabarang)
        Me.Panel3.Controls.Add(Me.lbidbarang)
        Me.Panel3.Location = New System.Drawing.Point(12, 116)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(765, 383)
        Me.Panel3.TabIndex = 22
        '
        'btnmenuutaman
        '
        Me.btnmenuutaman.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnmenuutaman.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnmenuutaman.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnmenuutaman.Location = New System.Drawing.Point(613, 346)
        Me.btnmenuutaman.Name = "btnmenuutaman"
        Me.btnmenuutaman.Size = New System.Drawing.Size(124, 23)
        Me.btnmenuutaman.TabIndex = 24
        Me.btnmenuutaman.Text = "<<Menu Utama"
        Me.btnmenuutaman.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 350)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Nama Barang"
        '
        'btncari
        '
        Me.btncari.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btncari.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncari.Location = New System.Drawing.Point(450, 346)
        Me.btncari.Name = "btncari"
        Me.btncari.Size = New System.Drawing.Size(75, 23)
        Me.btncari.TabIndex = 22
        Me.btncari.Text = "&Cari"
        Me.btncari.UseVisualStyleBackColor = False
        '
        'tbcari
        '
        Me.tbcari.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbcari.Location = New System.Drawing.Point(131, 348)
        Me.tbcari.Multiline = True
        Me.tbcari.Name = "tbcari"
        Me.tbcari.Size = New System.Drawing.Size(283, 20)
        Me.tbcari.TabIndex = 21
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Location = New System.Drawing.Point(12, 86)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(765, 30)
        Me.Panel4.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(258, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(244, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Form Manage Barang"
        '
        'Barang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(789, 527)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Barang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Barang"
        CType(Me.databarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbidbarang As System.Windows.Forms.Label
    Friend WithEvents lbnamabarang As System.Windows.Forms.Label
    Friend WithEvents lbhargajual As System.Windows.Forms.Label
    Friend WithEvents lbstock As System.Windows.Forms.Label
    Friend WithEvents lbidsupplier As System.Windows.Forms.Label
    Friend WithEvents tbidbarang As System.Windows.Forms.TextBox
    Friend WithEvents tbnamabarang As System.Windows.Forms.TextBox
    Friend WithEvents tbhargajual As System.Windows.Forms.TextBox
    Friend WithEvents tbstock As System.Windows.Forms.TextBox
    Friend WithEvents cbidsupplier As System.Windows.Forms.ComboBox
    Friend WithEvents bttambah As System.Windows.Forms.Button
    Friend WithEvents btedit As System.Windows.Forms.Button
    Friend WithEvents bthapus As System.Windows.Forms.Button
    Friend WithEvents databarang As System.Windows.Forms.DataGridView
    Friend WithEvents tbhargasupplier As System.Windows.Forms.TextBox
    Friend WithEvents lbhargasupplier As System.Windows.Forms.Label
    Friend WithEvents lbwaktuinput As System.Windows.Forms.Label
    Friend WithEvents lbidadmin As System.Windows.Forms.Label
    Friend WithEvents tglinput As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbidadmin As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btncari As System.Windows.Forms.Button
    Friend WithEvents tbcari As System.Windows.Forms.TextBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnmenuutaman As System.Windows.Forms.Button
End Class
