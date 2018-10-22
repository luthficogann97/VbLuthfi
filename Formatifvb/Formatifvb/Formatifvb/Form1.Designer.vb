<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.tbid = New System.Windows.Forms.TextBox()
        Me.bthapus = New System.Windows.Forms.Button()
        Me.btedit = New System.Windows.Forms.Button()
        Me.lvpengajuan = New System.Windows.Forms.ListView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btclose = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbbidang = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbkeperluan = New System.Windows.Forms.TextBox()
        Me.RBgiro = New System.Windows.Forms.RadioButton()
        Me.RBcek = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbpermintaab = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btsave = New System.Windows.Forms.Button()
        Me.RbTunai = New System.Windows.Forms.RadioButton()
        Me.tbnama = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 12)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(591, 334)
        Me.TextBox1.TabIndex = 70
        '
        'tbid
        '
        Me.tbid.Location = New System.Drawing.Point(41, 179)
        Me.tbid.Name = "tbid"
        Me.tbid.Size = New System.Drawing.Size(33, 20)
        Me.tbid.TabIndex = 92
        '
        'bthapus
        '
        Me.bthapus.Location = New System.Drawing.Point(496, 239)
        Me.bthapus.Name = "bthapus"
        Me.bthapus.Size = New System.Drawing.Size(75, 23)
        Me.bthapus.TabIndex = 91
        Me.bthapus.Text = "Hapus"
        Me.bthapus.UseVisualStyleBackColor = True
        '
        'btedit
        '
        Me.btedit.Location = New System.Drawing.Point(338, 239)
        Me.btedit.Name = "btedit"
        Me.btedit.Size = New System.Drawing.Size(75, 23)
        Me.btedit.TabIndex = 90
        Me.btedit.Text = "Edit"
        Me.btedit.UseVisualStyleBackColor = True
        '
        'lvpengajuan
        '
        Me.lvpengajuan.Location = New System.Drawing.Point(321, 50)
        Me.lvpengajuan.Name = "lvpengajuan"
        Me.lvpengajuan.Size = New System.Drawing.Size(267, 183)
        Me.lvpengajuan.TabIndex = 89
        Me.lvpengajuan.UseCompatibleStateImageBehavior = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(143, 209)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(26, 13)
        Me.Label9.TabIndex = 88
        Me.Label9.Text = "Giro"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(143, 186)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 13)
        Me.Label8.TabIndex = 87
        Me.Label8.Text = "Cek bank"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(143, 163)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 86
        Me.Label7.Text = "Tunai"
        '
        'btclose
        '
        Me.btclose.Location = New System.Drawing.Point(227, 325)
        Me.btclose.Name = "btclose"
        Me.btclose.Size = New System.Drawing.Size(75, 23)
        Me.btclose.TabIndex = 85
        Me.btclose.Text = "Close"
        Me.btclose.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(27, 163)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 84
        Me.Label6.Text = "Bentuk dana"
        '
        'cbbidang
        '
        Me.cbbidang.FormattingEnabled = True
        Me.cbbidang.Items.AddRange(New Object() {"ICT", "Akademik", "Keuangan", "Marketing"})
        Me.cbbidang.Location = New System.Drawing.Point(123, 84)
        Me.cbbidang.Name = "cbbidang"
        Me.cbbidang.Size = New System.Drawing.Size(179, 21)
        Me.cbbidang.TabIndex = 83
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 87)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 82
        Me.Label5.Text = "Bidang"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 242)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 81
        Me.Label4.Text = "Keperluan"
        '
        'tbkeperluan
        '
        Me.tbkeperluan.Location = New System.Drawing.Point(123, 242)
        Me.tbkeperluan.Multiline = True
        Me.tbkeperluan.Name = "tbkeperluan"
        Me.tbkeperluan.Size = New System.Drawing.Size(179, 77)
        Me.tbkeperluan.TabIndex = 80
        '
        'RBgiro
        '
        Me.RBgiro.AutoSize = True
        Me.RBgiro.Location = New System.Drawing.Point(123, 209)
        Me.RBgiro.Name = "RBgiro"
        Me.RBgiro.Size = New System.Drawing.Size(14, 13)
        Me.RBgiro.TabIndex = 79
        Me.RBgiro.TabStop = True
        Me.RBgiro.UseVisualStyleBackColor = True
        '
        'RBcek
        '
        Me.RBcek.AutoSize = True
        Me.RBcek.Location = New System.Drawing.Point(123, 186)
        Me.RBcek.Name = "RBcek"
        Me.RBcek.Size = New System.Drawing.Size(14, 13)
        Me.RBcek.TabIndex = 78
        Me.RBcek.TabStop = True
        Me.RBcek.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 77
        Me.Label3.Text = "Jml Permintaan"
        '
        'tbpermintaab
        '
        Me.tbpermintaab.Location = New System.Drawing.Point(123, 122)
        Me.tbpermintaab.Name = "tbpermintaab"
        Me.tbpermintaab.Size = New System.Drawing.Size(179, 20)
        Me.tbpermintaab.TabIndex = 76
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 75
        Me.Label2.Text = "Nama Pelaksana"
        '
        'btsave
        '
        Me.btsave.Location = New System.Drawing.Point(123, 325)
        Me.btsave.Name = "btsave"
        Me.btsave.Size = New System.Drawing.Size(75, 23)
        Me.btsave.TabIndex = 74
        Me.btsave.Text = "Add"
        Me.btsave.UseVisualStyleBackColor = True
        '
        'RbTunai
        '
        Me.RbTunai.AutoSize = True
        Me.RbTunai.Location = New System.Drawing.Point(123, 163)
        Me.RbTunai.Name = "RbTunai"
        Me.RbTunai.Size = New System.Drawing.Size(14, 13)
        Me.RbTunai.TabIndex = 73
        Me.RbTunai.TabStop = True
        Me.RbTunai.UseVisualStyleBackColor = True
        '
        'tbnama
        '
        Me.tbnama.Location = New System.Drawing.Point(123, 50)
        Me.tbnama.Name = "tbnama"
        Me.tbnama.Size = New System.Drawing.Size(179, 20)
        Me.tbnama.TabIndex = 72
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(260, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 16)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "Pengajuan Dana"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(342, 302)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 93
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(615, 358)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.tbid)
        Me.Controls.Add(Me.bthapus)
        Me.Controls.Add(Me.btedit)
        Me.Controls.Add(Me.lvpengajuan)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btclose)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbbidang)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbkeperluan)
        Me.Controls.Add(Me.RBgiro)
        Me.Controls.Add(Me.RBcek)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbpermintaab)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btsave)
        Me.Controls.Add(Me.RbTunai)
        Me.Controls.Add(Me.tbnama)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents tbid As System.Windows.Forms.TextBox
    Friend WithEvents bthapus As System.Windows.Forms.Button
    Friend WithEvents btedit As System.Windows.Forms.Button
    Friend WithEvents lvpengajuan As System.Windows.Forms.ListView
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btclose As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbbidang As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbkeperluan As System.Windows.Forms.TextBox
    Friend WithEvents RBgiro As System.Windows.Forms.RadioButton
    Friend WithEvents RBcek As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbpermintaab As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btsave As System.Windows.Forms.Button
    Friend WithEvents RbTunai As System.Windows.Forms.RadioButton
    Friend WithEvents tbnama As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker

End Class
