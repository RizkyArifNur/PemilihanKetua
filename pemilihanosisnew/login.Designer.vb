<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CustomHeaderTextboxMD4 = New MyCustomControl1.CustomHeaderTextboxMD()
        Me.CustomHeaderTextboxMD1 = New MyCustomControl1.CustomHeaderTextboxMD()
        Me.SimpleButton7 = New DevExpress.XtraEditors.SimpleButton()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(378, 50)
        Me.Panel1.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(6, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Form Login"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Silver
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(1, 465)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(378, 1)
        Me.Panel4.TabIndex = 17
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Silver
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(379, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1, 466)
        Me.Panel3.TabIndex = 16
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1, 466)
        Me.Panel2.TabIndex = 15
        '
        'CustomHeaderTextboxMD4
        '
        Me.CustomHeaderTextboxMD4.DataError = False
        Me.CustomHeaderTextboxMD4.Effect = True
        Me.CustomHeaderTextboxMD4.FormatCurrency = False
        Me.CustomHeaderTextboxMD4.HeaderText = "Username"
        Me.CustomHeaderTextboxMD4.JustRead = False
        Me.CustomHeaderTextboxMD4.Location = New System.Drawing.Point(13, 158)
        Me.CustomHeaderTextboxMD4.Name = "CustomHeaderTextboxMD4"
        Me.CustomHeaderTextboxMD4.NumberOnly = False
        Me.CustomHeaderTextboxMD4.RangeNumber = False
        Me.CustomHeaderTextboxMD4.Size = New System.Drawing.Size(356, 79)
        Me.CustomHeaderTextboxMD4.TabIndex = 19
        Me.CustomHeaderTextboxMD4.TextBoxText = ""
        Me.CustomHeaderTextboxMD4.UsingPasswordChar = False
        Me.CustomHeaderTextboxMD4.WaterMarkText = "Username"
        '
        'CustomHeaderTextboxMD1
        '
        Me.CustomHeaderTextboxMD1.DataError = False
        Me.CustomHeaderTextboxMD1.Effect = True
        Me.CustomHeaderTextboxMD1.FormatCurrency = False
        Me.CustomHeaderTextboxMD1.HeaderText = "Password"
        Me.CustomHeaderTextboxMD1.JustRead = False
        Me.CustomHeaderTextboxMD1.Location = New System.Drawing.Point(12, 255)
        Me.CustomHeaderTextboxMD1.Name = "CustomHeaderTextboxMD1"
        Me.CustomHeaderTextboxMD1.NumberOnly = False
        Me.CustomHeaderTextboxMD1.RangeNumber = False
        Me.CustomHeaderTextboxMD1.Size = New System.Drawing.Size(356, 79)
        Me.CustomHeaderTextboxMD1.TabIndex = 20
        Me.CustomHeaderTextboxMD1.TextBoxText = ""
        Me.CustomHeaderTextboxMD1.UsingPasswordChar = True
        Me.CustomHeaderTextboxMD1.WaterMarkText = "Password"
        '
        'SimpleButton7
        '
        Me.SimpleButton7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton7.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.SimpleButton7.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.SimpleButton7.Appearance.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton7.Appearance.ForeColor = System.Drawing.Color.White
        Me.SimpleButton7.Appearance.Options.UseBackColor = True
        Me.SimpleButton7.Appearance.Options.UseBorderColor = True
        Me.SimpleButton7.Appearance.Options.UseFont = True
        Me.SimpleButton7.Appearance.Options.UseForeColor = True
        Me.SimpleButton7.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.SimpleButton7.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.SimpleButton7.AppearanceHovered.Options.UseBackColor = True
        Me.SimpleButton7.AppearanceHovered.Options.UseBorderColor = True
        Me.SimpleButton7.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.SimpleButton7.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.SimpleButton7.AppearancePressed.Options.UseBackColor = True
        Me.SimpleButton7.AppearancePressed.Options.UseBorderColor = True
        Me.SimpleButton7.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.SimpleButton7.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.SimpleButton7.Location = New System.Drawing.Point(17, 363)
        Me.SimpleButton7.Name = "SimpleButton7"
        Me.SimpleButton7.Size = New System.Drawing.Size(345, 44)
        Me.SimpleButton7.TabIndex = 22
        Me.SimpleButton7.Text = "Masuk"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(166, 419)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(40, 13)
        Me.LinkLabel1.TabIndex = 23
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Cancel"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label2.Location = New System.Drawing.Point(41, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(306, 19)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Selamat Datang di Aplikasi ""Pilihanku"""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.Location = New System.Drawing.Point(65, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(258, 17)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Silahkan Masukan Username dan Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label4.Location = New System.Drawing.Point(109, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(178, 17)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Yang Telah Di Berikan panitia"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(1, 441)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(378, 24)
        Me.Panel5.TabIndex = 27
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label5.Location = New System.Drawing.Point(111, 4)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(163, 17)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Copyright © 2017 KTI SMEA"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(17, 333)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(124, 17)
        Me.CheckBox1.TabIndex = 28
        Me.CheckBox1.Text = "Tampilkan Password"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(380, 466)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.SimpleButton7)
        Me.Controls.Add(Me.CustomHeaderTextboxMD1)
        Me.Controls.Add(Me.CustomHeaderTextboxMD4)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents CustomHeaderTextboxMD4 As MyCustomControl1.CustomHeaderTextboxMD
    Friend WithEvents CustomHeaderTextboxMD1 As MyCustomControl1.CustomHeaderTextboxMD
    Friend WithEvents SimpleButton7 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents CheckBox1 As CheckBox
End Class
