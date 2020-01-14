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
        CType(Me.datasupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nama Supplier"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Alamat"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "No HandPhone"
        '
        'tbidsupplier
        '
        Me.tbidsupplier.Location = New System.Drawing.Point(98, 23)
        Me.tbidsupplier.Multiline = True
        Me.tbidsupplier.Name = "tbidsupplier"
        Me.tbidsupplier.Size = New System.Drawing.Size(161, 20)
        Me.tbidsupplier.TabIndex = 1
        '
        'tbnamasupplier
        '
        Me.tbnamasupplier.Location = New System.Drawing.Point(99, 54)
        Me.tbnamasupplier.Multiline = True
        Me.tbnamasupplier.Name = "tbnamasupplier"
        Me.tbnamasupplier.Size = New System.Drawing.Size(161, 20)
        Me.tbnamasupplier.TabIndex = 1
        '
        'tbnohp
        '
        Me.tbnohp.Location = New System.Drawing.Point(98, 151)
        Me.tbnohp.Multiline = True
        Me.tbnohp.Name = "tbnohp"
        Me.tbnohp.Size = New System.Drawing.Size(161, 20)
        Me.tbnohp.TabIndex = 1
        '
        'tbalamatsupplier
        '
        Me.tbalamatsupplier.Location = New System.Drawing.Point(99, 89)
        Me.tbalamatsupplier.Multiline = True
        Me.tbalamatsupplier.Name = "tbalamatsupplier"
        Me.tbalamatsupplier.Size = New System.Drawing.Size(161, 47)
        Me.tbalamatsupplier.TabIndex = 1
        '
        'btdelete
        '
        Me.btdelete.Location = New System.Drawing.Point(297, 127)
        Me.btdelete.Name = "btdelete"
        Me.btdelete.Size = New System.Drawing.Size(75, 44)
        Me.btdelete.TabIndex = 2
        Me.btdelete.Text = "&Delete"
        Me.btdelete.UseVisualStyleBackColor = True
        '
        'btedit
        '
        Me.btedit.Location = New System.Drawing.Point(297, 76)
        Me.btedit.Name = "btedit"
        Me.btedit.Size = New System.Drawing.Size(75, 44)
        Me.btedit.TabIndex = 3
        Me.btedit.Text = "&Edit"
        Me.btedit.UseVisualStyleBackColor = True
        '
        'bttambah
        '
        Me.bttambah.Location = New System.Drawing.Point(297, 23)
        Me.bttambah.Name = "bttambah"
        Me.bttambah.Size = New System.Drawing.Size(75, 44)
        Me.bttambah.TabIndex = 4
        Me.bttambah.Text = "&Tambah"
        Me.bttambah.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Supplier"
        '
        'datasupplier
        '
        Me.datasupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datasupplier.Location = New System.Drawing.Point(10, 177)
        Me.datasupplier.Name = "datasupplier"
        Me.datasupplier.Size = New System.Drawing.Size(360, 104)
        Me.datasupplier.TabIndex = 5
        '
        'frmSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 293)
        Me.Controls.Add(Me.datasupplier)
        Me.Controls.Add(Me.btdelete)
        Me.Controls.Add(Me.btedit)
        Me.Controls.Add(Me.bttambah)
        Me.Controls.Add(Me.tbalamatsupplier)
        Me.Controls.Add(Me.tbnohp)
        Me.Controls.Add(Me.tbnamasupplier)
        Me.Controls.Add(Me.tbidsupplier)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmSupplier"
        Me.Text = "Supplier"
        CType(Me.datasupplier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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

End Class
