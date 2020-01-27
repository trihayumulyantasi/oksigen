<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSupplier
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbidsupplier = New System.Windows.Forms.TextBox()
        Me.tbnamasupplier = New System.Windows.Forms.TextBox()
        Me.tbnohp = New System.Windows.Forms.TextBox()
        Me.tbalamatsupplier = New System.Windows.Forms.TextBox()
        Me.btdelete = New System.Windows.Forms.Button()
        Me.btedit = New System.Windows.Forms.Button()
        Me.bttambah = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.datasupplier = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnmenuutaman = New System.Windows.Forms.Button()
        Me.btncari = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.datasupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nama Supplier"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Alamat"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(441, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "No HandPhone"
        '
        'tbidsupplier
        '
        Me.tbidsupplier.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbidsupplier.Location = New System.Drawing.Point(98, 16)
        Me.tbidsupplier.Multiline = True
        Me.tbidsupplier.Name = "tbidsupplier"
        Me.tbidsupplier.Size = New System.Drawing.Size(249, 20)
        Me.tbidsupplier.TabIndex = 1
        '
        'tbnamasupplier
        '
        Me.tbnamasupplier.BackColor = System.Drawing.SystemColors.Window
        Me.tbnamasupplier.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbnamasupplier.Location = New System.Drawing.Point(99, 47)
        Me.tbnamasupplier.Multiline = True
        Me.tbnamasupplier.Name = "tbnamasupplier"
        Me.tbnamasupplier.Size = New System.Drawing.Size(249, 20)
        Me.tbnamasupplier.TabIndex = 1
        '
        'tbnohp
        '
        Me.tbnohp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbnohp.Location = New System.Drawing.Point(531, 13)
        Me.tbnohp.Multiline = True
        Me.tbnohp.Name = "tbnohp"
        Me.tbnohp.Size = New System.Drawing.Size(189, 20)
        Me.tbnohp.TabIndex = 1
        '
        'tbalamatsupplier
        '
        Me.tbalamatsupplier.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbalamatsupplier.Location = New System.Drawing.Point(98, 82)
        Me.tbalamatsupplier.Multiline = True
        Me.tbalamatsupplier.Name = "tbalamatsupplier"
        Me.tbalamatsupplier.Size = New System.Drawing.Size(249, 47)
        Me.tbalamatsupplier.TabIndex = 1
        '
        'btdelete
        '
        Me.btdelete.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btdelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btdelete.Location = New System.Drawing.Point(645, 70)
        Me.btdelete.Name = "btdelete"
        Me.btdelete.Size = New System.Drawing.Size(75, 37)
        Me.btdelete.TabIndex = 2
        Me.btdelete.Text = "&Delete"
        Me.btdelete.UseVisualStyleBackColor = False
        '
        'btedit
        '
        Me.btedit.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btedit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btedit.Location = New System.Drawing.Point(552, 70)
        Me.btedit.Name = "btedit"
        Me.btedit.Size = New System.Drawing.Size(75, 37)
        Me.btedit.TabIndex = 3
        Me.btedit.Text = "&Edit"
        Me.btedit.UseVisualStyleBackColor = False
        '
        'bttambah
        '
        Me.bttambah.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.bttambah.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bttambah.Location = New System.Drawing.Point(447, 70)
        Me.bttambah.Name = "bttambah"
        Me.bttambah.Size = New System.Drawing.Size(75, 37)
        Me.bttambah.TabIndex = 4
        Me.bttambah.Text = "&Tambah"
        Me.bttambah.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Supplier"
        '
        'datasupplier
        '
        Me.datasupplier.AllowUserToAddRows = False
        Me.datasupplier.BackgroundColor = System.Drawing.Color.Snow
        Me.datasupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datasupplier.Location = New System.Drawing.Point(24, 146)
        Me.datasupplier.Name = "datasupplier"
        Me.datasupplier.Size = New System.Drawing.Size(696, 104)
        Me.datasupplier.TabIndex = 5
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(-8, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(808, 70)
        Me.Panel1.TabIndex = 27
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
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Location = New System.Drawing.Point(13, 85)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(764, 30)
        Me.Panel4.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(236, 1)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(260, 25)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Form Manage Supplier"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.btnmenuutaman)
        Me.Panel3.Controls.Add(Me.btncari)
        Me.Panel3.Controls.Add(Me.TextBox1)
        Me.Panel3.Controls.Add(Me.tbidsupplier)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.datasupplier)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.tbnohp)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.btdelete)
        Me.Panel3.Controls.Add(Me.tbnamasupplier)
        Me.Panel3.Controls.Add(Me.btedit)
        Me.Panel3.Controls.Add(Me.tbalamatsupplier)
        Me.Panel3.Controls.Add(Me.bttambah)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Location = New System.Drawing.Point(13, 114)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(764, 317)
        Me.Panel3.TabIndex = 29
        '
        'btnmenuutaman
        '
        Me.btnmenuutaman.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnmenuutaman.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnmenuutaman.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnmenuutaman.Location = New System.Drawing.Point(596, 265)
        Me.btnmenuutaman.Name = "btnmenuutaman"
        Me.btnmenuutaman.Size = New System.Drawing.Size(124, 23)
        Me.btnmenuutaman.TabIndex = 29
        Me.btnmenuutaman.Text = "<<Menu Utama"
        Me.btnmenuutaman.UseVisualStyleBackColor = False
        '
        'btncari
        '
        Me.btncari.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btncari.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncari.Location = New System.Drawing.Point(447, 266)
        Me.btncari.Name = "btncari"
        Me.btncari.Size = New System.Drawing.Size(75, 23)
        Me.btncari.TabIndex = 28
        Me.btncari.Text = "&Cari"
        Me.btncari.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Location = New System.Drawing.Point(128, 268)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(283, 20)
        Me.TextBox1.TabIndex = 27
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(30, 270)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 13)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Nama Supplier"
        '
        'frmSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 443)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSupplier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Supplier"
        CType(Me.datasupplier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbidsupplier As System.Windows.Forms.TextBox
    Friend WithEvents tbnamasupplier As System.Windows.Forms.TextBox
    Friend WithEvents tbnohp As System.Windows.Forms.TextBox
    Friend WithEvents tbalamatsupplier As System.Windows.Forms.TextBox
    Friend WithEvents btdelete As System.Windows.Forms.Button
    Friend WithEvents btedit As System.Windows.Forms.Button
    Friend WithEvents bttambah As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents datasupplier As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnmenuutaman As System.Windows.Forms.Button
    Friend WithEvents btncari As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox

End Class
