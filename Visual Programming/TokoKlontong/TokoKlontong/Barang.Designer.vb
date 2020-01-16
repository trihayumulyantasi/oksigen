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
        Me.lbharga = New System.Windows.Forms.Label()
        Me.lbstock = New System.Windows.Forms.Label()
        Me.lbidsupplier = New System.Windows.Forms.Label()
        Me.tbidbarang = New System.Windows.Forms.TextBox()
        Me.tbnamabarang = New System.Windows.Forms.TextBox()
        Me.tbharga = New System.Windows.Forms.TextBox()
        Me.tbstock = New System.Windows.Forms.TextBox()
        Me.cbidsupplier = New System.Windows.Forms.ComboBox()
        Me.bttambah = New System.Windows.Forms.Button()
        Me.btedit = New System.Windows.Forms.Button()
        Me.bthapus = New System.Windows.Forms.Button()
        Me.databarang = New System.Windows.Forms.DataGridView()
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
        'lbharga
        '
        Me.lbharga.AutoSize = True
        Me.lbharga.Location = New System.Drawing.Point(12, 129)
        Me.lbharga.Name = "lbharga"
        Me.lbharga.Size = New System.Drawing.Size(36, 13)
        Me.lbharga.TabIndex = 3
        Me.lbharga.Text = "Harga"
        '
        'lbstock
        '
        Me.lbstock.AutoSize = True
        Me.lbstock.Location = New System.Drawing.Point(12, 160)
        Me.lbstock.Name = "lbstock"
        Me.lbstock.Size = New System.Drawing.Size(35, 13)
        Me.lbstock.TabIndex = 4
        Me.lbstock.Text = "Stock"
        '
        'lbidsupplier
        '
        Me.lbidsupplier.AutoSize = True
        Me.lbidsupplier.Location = New System.Drawing.Point(12, 196)
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
        'tbharga
        '
        Me.tbharga.Location = New System.Drawing.Point(147, 126)
        Me.tbharga.Name = "tbharga"
        Me.tbharga.Size = New System.Drawing.Size(206, 20)
        Me.tbharga.TabIndex = 8
        '
        'tbstock
        '
        Me.tbstock.Location = New System.Drawing.Point(147, 157)
        Me.tbstock.Name = "tbstock"
        Me.tbstock.Size = New System.Drawing.Size(206, 20)
        Me.tbstock.TabIndex = 9
        '
        'cbidsupplier
        '
        Me.cbidsupplier.FormattingEnabled = True
        Me.cbidsupplier.Location = New System.Drawing.Point(147, 193)
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
        Me.databarang.Location = New System.Drawing.Point(15, 236)
        Me.databarang.Name = "databarang"
        Me.databarang.Size = New System.Drawing.Size(466, 131)
        Me.databarang.TabIndex = 14
        '
        'Barang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 379)
        Me.Controls.Add(Me.databarang)
        Me.Controls.Add(Me.bthapus)
        Me.Controls.Add(Me.btedit)
        Me.Controls.Add(Me.bttambah)
        Me.Controls.Add(Me.cbidsupplier)
        Me.Controls.Add(Me.tbstock)
        Me.Controls.Add(Me.tbharga)
        Me.Controls.Add(Me.tbnamabarang)
        Me.Controls.Add(Me.tbidbarang)
        Me.Controls.Add(Me.lbidsupplier)
        Me.Controls.Add(Me.lbstock)
        Me.Controls.Add(Me.lbharga)
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
    Friend WithEvents lbharga As System.Windows.Forms.Label
    Friend WithEvents lbstock As System.Windows.Forms.Label
    Friend WithEvents lbidsupplier As System.Windows.Forms.Label
    Friend WithEvents tbidbarang As System.Windows.Forms.TextBox
    Friend WithEvents tbnamabarang As System.Windows.Forms.TextBox
    Friend WithEvents tbharga As System.Windows.Forms.TextBox
    Friend WithEvents tbstock As System.Windows.Forms.TextBox
    Friend WithEvents cbidsupplier As System.Windows.Forms.ComboBox
    Friend WithEvents bttambah As System.Windows.Forms.Button
    Friend WithEvents btedit As System.Windows.Forms.Button
    Friend WithEvents bthapus As System.Windows.Forms.Button
    Friend WithEvents databarang As System.Windows.Forms.DataGridView
End Class
