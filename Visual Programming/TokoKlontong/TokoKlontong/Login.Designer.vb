<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.tbusername = New System.Windows.Forms.TextBox()
        Me.tbpassword = New System.Windows.Forms.TextBox()
        Me.btlogin = New System.Windows.Forms.Button()
        Me.btbatal = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Desktop
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label1.Location = New System.Drawing.Point(94, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Silahkan Login Terlebih Dahulu"
        '
        'tbusername
        '
        Me.tbusername.BackColor = System.Drawing.SystemColors.HighlightText
        Me.tbusername.Location = New System.Drawing.Point(110, 167)
        Me.tbusername.Multiline = True
        Me.tbusername.Name = "tbusername"
        Me.tbusername.Size = New System.Drawing.Size(169, 27)
        Me.tbusername.TabIndex = 3
        Me.tbusername.Text = "username"
        Me.tbusername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tbusername.WordWrap = False
        '
        'tbpassword
        '
        Me.tbpassword.BackColor = System.Drawing.SystemColors.HighlightText
        Me.tbpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbpassword.Location = New System.Drawing.Point(110, 231)
        Me.tbpassword.Multiline = True
        Me.tbpassword.Name = "tbpassword"
        Me.tbpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbpassword.Size = New System.Drawing.Size(169, 30)
        Me.tbpassword.TabIndex = 4
        Me.tbpassword.Text = "password"
        Me.tbpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tbpassword.WordWrap = False
        '
        'btlogin
        '
        Me.btlogin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btlogin.Location = New System.Drawing.Point(204, 319)
        Me.btlogin.Name = "btlogin"
        Me.btlogin.Size = New System.Drawing.Size(75, 23)
        Me.btlogin.TabIndex = 5
        Me.btlogin.Text = "&Login"
        Me.btlogin.UseVisualStyleBackColor = True
        '
        'btbatal
        '
        Me.btbatal.Location = New System.Drawing.Point(110, 319)
        Me.btbatal.Name = "btbatal"
        Me.btbatal.Size = New System.Drawing.Size(75, 23)
        Me.btbatal.TabIndex = 6
        Me.btbatal.Text = "&Batal"
        Me.btbatal.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.SystemColors.Desktop
        Me.CheckBox1.Font = New System.Drawing.Font("Gadugi", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.SystemColors.GrayText
        Me.CheckBox1.Location = New System.Drawing.Point(110, 276)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(146, 20)
        Me.CheckBox1.TabIndex = 30
        Me.CheckBox1.Text = "Tampilkan Password"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.BackgroundImage = Global.TokoKlontong.My.Resources.Resources.LoginOksigen2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(386, 390)
        Me.ControlBox = False
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.btbatal)
        Me.Controls.Add(Me.btlogin)
        Me.Controls.Add(Me.tbpassword)
        Me.Controls.Add(Me.tbusername)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Name = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbusername As System.Windows.Forms.TextBox
    Friend WithEvents tbpassword As System.Windows.Forms.TextBox
    Friend WithEvents btlogin As System.Windows.Forms.Button
    Friend WithEvents btbatal As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
End Class
