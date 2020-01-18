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
        CType(Me.databarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(142, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(244, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Manage Form Barang"
        '
        'lbidbarang
        '
        Me.lbidbarang.AutoSize = True
        Me.lbidbarang.Location = New System.Drawing.Point(12, 64)
        Me.lbidbarang.Name = "lbidbarang"
        Me.lbidbarang.Size = New System.Drawing.Size(55, 13)
        Me.lbidbarang.TabIndex = 1
        Me.lbidbarang.Text = "ID Barang"
        '
        'lbnamabarang
        '
        Me.lbnamabarang.AutoSize = True
        Me.lbnamabarang.Location = New System.Drawing.Point(12, 96)
        Me.lbnamabarang.Name = "lbnamabarang"
        Me.lbnamabarang.Size = New System.Drawing.Size(72, 13)
        Me.lbnamabarang.TabIndex = 2
        Me.lbnamabarang.Text = "Nama Barang"
        '
        'lbhargajual
        '
        Me.lbhargajual.AutoSize = True
        Me.lbhargajual.Location = New System.Drawing.Point(12, 129)
        Me.lbhargajual.Name = "lbhargajual"
        Me.lbhargajual.Size = New System.Drawing.Size(58, 13)
        Me.lbhargajual.TabIndex = 3
        Me.lbhargajual.Text = "Harga Jual"
        '
        'lbstock
        '
        Me.lbstock.AutoSize = True
        Me.lbstock.Location = New System.Drawing.Point(9, 202)
        Me.lbstock.Name = "lbstock"
        Me.lbstock.Size = New System.Drawing.Size(35, 13)
        Me.lbstock.TabIndex = 4
        Me.lbstock.Text = "Stock"
        '
        'lbidsupplier
        '
        Me.lbidsupplier.AutoSize = True
        Me.lbidsupplier.Location = New System.Drawing.Point(9, 238)
        Me.lbidsupplier.Name = "lbidsupplier"
        Me.lbidsupplier.Size = New System.Drawing.Size(59, 13)
        Me.lbidsupplier.TabIndex = 5
        Me.lbidsupplier.Text = "ID Supplier"
        '
        'tbidbarang
        '
        Me.tbidbarang.Location = New System.Drawing.Point(147, 61)
        Me.tbidbarang.Name = "tbidbarang"
        Me.tbidbarang.Size = New System.Drawing.Size(206, 20)
        Me.tbidbarang.TabIndex = 6
        '
        'tbnamabarang
        '
        Me.tbnamabarang.Location = New System.Drawing.Point(147, 93)
        Me.tbnamabarang.Name = "tbnamabarang"
        Me.tbnamabarang.Size = New System.Drawing.Size(206, 20)
        Me.tbnamabarang.TabIndex = 7
        '
        'tbhargajual
        '
        Me.tbhargajual.Location = New System.Drawing.Point(147, 126)
        Me.tbhargajual.Name = "tbhargajual"
        Me.tbhargajual.Size = New System.Drawing.Size(206, 20)
        Me.tbhargajual.TabIndex = 8
        '
        'tbstock
        '
        Me.tbstock.Location = New System.Drawing.Point(144, 199)
        Me.tbstock.Name = "tbstock"
        Me.tbstock.Size = New System.Drawing.Size(206, 20)
        Me.tbstock.TabIndex = 9
        '
        'cbidsupplier
        '
        Me.cbidsupplier.FormattingEnabled = True
        Me.cbidsupplier.Location = New System.Drawing.Point(144, 235)
        Me.cbidsupplier.Name = "cbidsupplier"
        Me.cbidsupplier.Size = New System.Drawing.Size(206, 21)
        Me.cbidsupplier.TabIndex = 10
        '
        'bttambah
        '
        Me.bttambah.Location = New System.Drawing.Point(406, 61)
        Me.bttambah.Name = "bttambah"
        Me.bttambah.Size = New System.Drawing.Size(75, 37)
        Me.bttambah.TabIndex = 11
        Me.bttambah.Text = "&Tambah"
        Me.bttambah.UseVisualStyleBackColor = True
        '
        'btedit
        '
        Me.btedit.Location = New System.Drawing.Point(406, 117)
        Me.btedit.Name = "btedit"
        Me.btedit.Size = New System.Drawing.Size(75, 37)
        Me.btedit.TabIndex = 12
        Me.btedit.Text = "&Edit"
        Me.btedit.UseVisualStyleBackColor = True
        '
        'bthapus
        '
        Me.bthapus.Location = New System.Drawing.Point(406, 177)
        Me.bthapus.Name = "bthapus"
        Me.bthapus.Size = New System.Drawing.Size(75, 37)
        Me.bthapus.TabIndex = 13
        Me.bthapus.Text = "&Hapus"
        Me.bthapus.UseVisualStyleBackColor = True
        '
        'databarang
        '
        Me.databarang.AllowUserToAddRows = False
        Me.databarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.databarang.Location = New System.Drawing.Point(15, 365)
        Me.databarang.Name = "databarang"
        Me.databarang.Size = New System.Drawing.Size(466, 131)
        Me.databarang.TabIndex = 14
        '
        'tbhargasupplier
        '
        Me.tbhargasupplier.Location = New System.Drawing.Point(145, 160)
        Me.tbhargasupplier.Name = "tbhargasupplier"
        Me.tbhargasupplier.Size = New System.Drawing.Size(206, 20)
        Me.tbhargasupplier.TabIndex = 16
        '
        'lbhargasupplier
        '
        Me.lbhargasupplier.AutoSize = True
        Me.lbhargasupplier.Location = New System.Drawing.Point(10, 163)
        Me.lbhargasupplier.Name = "lbhargasupplier"
        Me.lbhargasupplier.Size = New System.Drawing.Size(77, 13)
        Me.lbhargasupplier.TabIndex = 15
        Me.lbhargasupplier.Text = "Harga Supplier"
        '
        'lbwaktuinput
        '
        Me.lbwaktuinput.AutoSize = True
        Me.lbwaktuinput.Location = New System.Drawing.Point(8, 274)
        Me.lbwaktuinput.Name = "lbwaktuinput"
        Me.lbwaktuinput.Size = New System.Drawing.Size(66, 13)
        Me.lbwaktuinput.TabIndex = 17
        Me.lbwaktuinput.Text = "Waktu Input"
        '
        'lbidadmin
        '
        Me.lbidadmin.AutoSize = True
        Me.lbidadmin.Location = New System.Drawing.Point(8, 309)
        Me.lbidadmin.Name = "lbidadmin"
        Me.lbidadmin.Size = New System.Drawing.Size(50, 13)
        Me.lbidadmin.TabIndex = 18
        Me.lbidadmin.Text = "ID Admin"
        '
        'tglinput
        '
        Me.tglinput.Location = New System.Drawing.Point(144, 268)
        Me.tglinput.Name = "tglinput"
        Me.tglinput.Size = New System.Drawing.Size(206, 20)
        Me.tglinput.TabIndex = 19
        '
        'cbidadmin
        '
        Me.cbidadmin.FormattingEnabled = True
        Me.cbidadmin.Location = New System.Drawing.Point(144, 306)
        Me.cbidadmin.Name = "cbidadmin"
        Me.cbidadmin.Size = New System.Drawing.Size(206, 21)
        Me.cbidadmin.TabIndex = 20
        '
        'Barang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 508)
        Me.Controls.Add(Me.cbidadmin)
        Me.Controls.Add(Me.tglinput)
        Me.Controls.Add(Me.lbidadmin)
        Me.Controls.Add(Me.lbwaktuinput)
        Me.Controls.Add(Me.tbhargasupplier)
        Me.Controls.Add(Me.lbhargasupplier)
        Me.Controls.Add(Me.databarang)
        Me.Controls.Add(Me.bthapus)
        Me.Controls.Add(Me.btedit)
        Me.Controls.Add(Me.bttambah)
        Me.Controls.Add(Me.cbidsupplier)
        Me.Controls.Add(Me.tbstock)
        Me.Controls.Add(Me.tbhargajual)
        Me.Controls.Add(Me.tbnamabarang)
        Me.Controls.Add(Me.tbidbarang)
        Me.Controls.Add(Me.lbidsupplier)
        Me.Controls.Add(Me.lbstock)
        Me.Controls.Add(Me.lbhargajual)
        Me.Controls.Add(Me.lbnamabarang)
        Me.Controls.Add(Me.lbidbarang)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Barang"
        Me.Text = "Barang"
        CType(Me.databarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
End Class
