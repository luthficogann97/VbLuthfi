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
        Me.tbother = New System.Windows.Forms.TextBox()
        Me.btupdate = New System.Windows.Forms.Button()
        Me.btdelet = New System.Windows.Forms.Button()
        Me.btedit = New System.Windows.Forms.Button()
        Me.tbid = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lvrequest = New System.Windows.Forms.ListView()
        Me.btsend = New System.Windows.Forms.Button()
        Me.tbphone = New System.Windows.Forms.TextBox()
        Me.cbtrans = New System.Windows.Forms.ComboBox()
        Me.tbac = New System.Windows.Forms.TextBox()
        Me.tbto = New System.Windows.Forms.TextBox()
        Me.tbinstruc = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.tbunit = New System.Windows.Forms.TextBox()
        Me.tbidnum = New System.Windows.Forms.TextBox()
        Me.tbname = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tbother
        '
        Me.tbother.Location = New System.Drawing.Point(727, 121)
        Me.tbother.Name = "tbother"
        Me.tbother.Size = New System.Drawing.Size(132, 20)
        Me.tbother.TabIndex = 54
        '
        'btupdate
        '
        Me.btupdate.Location = New System.Drawing.Point(363, 293)
        Me.btupdate.Name = "btupdate"
        Me.btupdate.Size = New System.Drawing.Size(115, 23)
        Me.btupdate.TabIndex = 53
        Me.btupdate.Text = "Update"
        Me.btupdate.UseVisualStyleBackColor = True
        '
        'btdelet
        '
        Me.btdelet.Location = New System.Drawing.Point(641, 293)
        Me.btdelet.Name = "btdelet"
        Me.btdelet.Size = New System.Drawing.Size(115, 23)
        Me.btdelet.TabIndex = 52
        Me.btdelet.Text = "Deleted"
        Me.btdelet.UseVisualStyleBackColor = True
        '
        'btedit
        '
        Me.btedit.Location = New System.Drawing.Point(503, 293)
        Me.btedit.Name = "btedit"
        Me.btedit.Size = New System.Drawing.Size(115, 23)
        Me.btedit.TabIndex = 51
        Me.btedit.Text = "Edit"
        Me.btedit.UseVisualStyleBackColor = True
        '
        'tbid
        '
        Me.tbid.Location = New System.Drawing.Point(108, 233)
        Me.tbid.Name = "tbid"
        Me.tbid.Size = New System.Drawing.Size(23, 20)
        Me.tbid.TabIndex = 50
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(370, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(118, 13)
        Me.Label11.TabIndex = 49
        Me.Label11.Text = "Transportation Request"
        '
        'lvrequest
        '
        Me.lvrequest.Location = New System.Drawing.Point(232, 322)
        Me.lvrequest.Name = "lvrequest"
        Me.lvrequest.Size = New System.Drawing.Size(612, 134)
        Me.lvrequest.TabIndex = 48
        Me.lvrequest.UseCompatibleStateImageBehavior = False
        '
        'btsend
        '
        Me.btsend.Location = New System.Drawing.Point(232, 293)
        Me.btsend.Name = "btsend"
        Me.btsend.Size = New System.Drawing.Size(115, 23)
        Me.btsend.TabIndex = 47
        Me.btsend.Text = "Send Request"
        Me.btsend.UseVisualStyleBackColor = True
        '
        'tbphone
        '
        Me.tbphone.Location = New System.Drawing.Point(590, 160)
        Me.tbphone.Name = "tbphone"
        Me.tbphone.Size = New System.Drawing.Size(100, 20)
        Me.tbphone.TabIndex = 46
        '
        'cbtrans
        '
        Me.cbtrans.FormattingEnabled = True
        Me.cbtrans.Location = New System.Drawing.Point(590, 121)
        Me.cbtrans.Name = "cbtrans"
        Me.cbtrans.Size = New System.Drawing.Size(121, 21)
        Me.cbtrans.TabIndex = 45
        '
        'tbac
        '
        Me.tbac.Location = New System.Drawing.Point(590, 76)
        Me.tbac.Name = "tbac"
        Me.tbac.Size = New System.Drawing.Size(100, 20)
        Me.tbac.TabIndex = 44
        '
        'tbto
        '
        Me.tbto.Location = New System.Drawing.Point(590, 41)
        Me.tbto.Name = "tbto"
        Me.tbto.Size = New System.Drawing.Size(100, 20)
        Me.tbto.TabIndex = 43
        '
        'tbinstruc
        '
        Me.tbinstruc.Location = New System.Drawing.Point(232, 196)
        Me.tbinstruc.Multiline = True
        Me.tbinstruc.Name = "tbinstruc"
        Me.tbinstruc.Size = New System.Drawing.Size(479, 91)
        Me.tbinstruc.TabIndex = 42
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "yyyy/MM/dd HH:mm:ss"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(232, 157)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 41
        Me.DateTimePicker1.Value = New Date(2018, 10, 17, 15, 17, 6, 0)
        '
        'tbunit
        '
        Me.tbunit.Location = New System.Drawing.Point(232, 118)
        Me.tbunit.Name = "tbunit"
        Me.tbunit.Size = New System.Drawing.Size(100, 20)
        Me.tbunit.TabIndex = 40
        '
        'tbidnum
        '
        Me.tbidnum.Location = New System.Drawing.Point(232, 80)
        Me.tbidnum.Name = "tbidnum"
        Me.tbidnum.Size = New System.Drawing.Size(100, 20)
        Me.tbidnum.TabIndex = 39
        '
        'tbname
        '
        Me.tbname.Location = New System.Drawing.Point(232, 44)
        Me.tbname.Name = "tbname"
        Me.tbname.Size = New System.Drawing.Size(100, 20)
        Me.tbname.TabIndex = 38
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(472, 83)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "A/C Reg"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(525, 290)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 13)
        Me.Label9.TabIndex = 36
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(105, 83)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "ID Number"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(105, 121)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(26, 13)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Unit"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(105, 157)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Date of Issue"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(105, 196)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Instructions"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(472, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 13)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "to Unit/Destination"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(472, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Transportation"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(472, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Ext, Phone/Hp"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(105, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Name of Requestor"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(965, 464)
        Me.Controls.Add(Me.tbother)
        Me.Controls.Add(Me.btupdate)
        Me.Controls.Add(Me.btdelet)
        Me.Controls.Add(Me.btedit)
        Me.Controls.Add(Me.tbid)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lvrequest)
        Me.Controls.Add(Me.btsend)
        Me.Controls.Add(Me.tbphone)
        Me.Controls.Add(Me.cbtrans)
        Me.Controls.Add(Me.tbac)
        Me.Controls.Add(Me.tbto)
        Me.Controls.Add(Me.tbinstruc)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.tbunit)
        Me.Controls.Add(Me.tbidnum)
        Me.Controls.Add(Me.tbname)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbother As System.Windows.Forms.TextBox
    Friend WithEvents btupdate As System.Windows.Forms.Button
    Friend WithEvents btdelet As System.Windows.Forms.Button
    Friend WithEvents btedit As System.Windows.Forms.Button
    Friend WithEvents tbid As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lvrequest As System.Windows.Forms.ListView
    Friend WithEvents btsend As System.Windows.Forms.Button
    Friend WithEvents tbphone As System.Windows.Forms.TextBox
    Friend WithEvents cbtrans As System.Windows.Forms.ComboBox
    Friend WithEvents tbac As System.Windows.Forms.TextBox
    Friend WithEvents tbto As System.Windows.Forms.TextBox
    Friend WithEvents tbinstruc As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents tbunit As System.Windows.Forms.TextBox
    Friend WithEvents tbidnum As System.Windows.Forms.TextBox
    Friend WithEvents tbname As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
