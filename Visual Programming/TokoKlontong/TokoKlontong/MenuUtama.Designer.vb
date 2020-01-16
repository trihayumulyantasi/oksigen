<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuUtama
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
        Me.btsupplier = New System.Windows.Forms.Button()
        Me.btbarang = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btsupplier
        '
        Me.btsupplier.Location = New System.Drawing.Point(68, 120)
        Me.btsupplier.Name = "btsupplier"
        Me.btsupplier.Size = New System.Drawing.Size(75, 23)
        Me.btsupplier.TabIndex = 0
        Me.btsupplier.Text = "&Supplier"
        Me.btsupplier.UseVisualStyleBackColor = True
        '
        'btbarang
        '
        Me.btbarang.Location = New System.Drawing.Point(287, 136)
        Me.btbarang.Name = "btbarang"
        Me.btbarang.Size = New System.Drawing.Size(75, 23)
        Me.btbarang.TabIndex = 1
        Me.btbarang.Text = "&Barang"
        Me.btbarang.UseVisualStyleBackColor = True
        '
        'MenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 261)
        Me.Controls.Add(Me.btbarang)
        Me.Controls.Add(Me.btsupplier)
        Me.Name = "MenuUtama"
        Me.Text = "MenuUtama"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btsupplier As System.Windows.Forms.Button
    Friend WithEvents btbarang As System.Windows.Forms.Button
End Class
