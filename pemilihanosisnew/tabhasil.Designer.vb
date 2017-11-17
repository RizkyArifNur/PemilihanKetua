<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class tabhasil
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CustomHeaderTextboxMD4 = New MyCustomControl1.CustomHeaderTextboxMD()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.SimpleButton7 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton6 = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(855, 81)
        Me.Panel1.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Silver
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 80)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(855, 1)
        Me.Panel4.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sistem Pemilihan"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.CustomHeaderTextboxMD4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 81)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(855, 497)
        Me.Panel2.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(16, 93)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 26)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Refresh"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CustomHeaderTextboxMD4
        '
        Me.CustomHeaderTextboxMD4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CustomHeaderTextboxMD4.DataError = False
        Me.CustomHeaderTextboxMD4.Effect = True
        Me.CustomHeaderTextboxMD4.FormatCurrency = False
        Me.CustomHeaderTextboxMD4.HeaderText = "Alamat Server"
        Me.CustomHeaderTextboxMD4.JustRead = False
        Me.CustomHeaderTextboxMD4.Location = New System.Drawing.Point(14, 18)
        Me.CustomHeaderTextboxMD4.Name = "CustomHeaderTextboxMD4"
        Me.CustomHeaderTextboxMD4.NumberOnly = False
        Me.CustomHeaderTextboxMD4.RangeNumber = False
        Me.CustomHeaderTextboxMD4.Size = New System.Drawing.Size(827, 79)
        Me.CustomHeaderTextboxMD4.TabIndex = 2
        Me.CustomHeaderTextboxMD4.TextBoxText = ""
        Me.CustomHeaderTextboxMD4.UsingPasswordChar = False
        Me.CustomHeaderTextboxMD4.WaterMarkText = "Alamat Server"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.SimpleButton6)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.SimpleButton7)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 515)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(855, 63)
        Me.Panel3.TabIndex = 2
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Silver
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(855, 1)
        Me.Panel5.TabIndex = 23
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
        Me.SimpleButton7.Location = New System.Drawing.Point(695, 13)
        Me.SimpleButton7.Name = "SimpleButton7"
        Me.SimpleButton7.Size = New System.Drawing.Size(151, 36)
        Me.SimpleButton7.TabIndex = 21
        Me.SimpleButton7.Text = "Simpan"
        '
        'SimpleButton6
        '
        Me.SimpleButton6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton6.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SimpleButton6.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SimpleButton6.Appearance.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton6.Appearance.ForeColor = System.Drawing.Color.White
        Me.SimpleButton6.Appearance.Options.UseBackColor = True
        Me.SimpleButton6.Appearance.Options.UseBorderColor = True
        Me.SimpleButton6.Appearance.Options.UseFont = True
        Me.SimpleButton6.Appearance.Options.UseForeColor = True
        Me.SimpleButton6.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SimpleButton6.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SimpleButton6.AppearanceHovered.Options.UseBackColor = True
        Me.SimpleButton6.AppearanceHovered.Options.UseBorderColor = True
        Me.SimpleButton6.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SimpleButton6.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SimpleButton6.AppearancePressed.Options.UseBackColor = True
        Me.SimpleButton6.AppearancePressed.Options.UseBorderColor = True
        Me.SimpleButton6.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.SimpleButton6.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.SimpleButton6.Location = New System.Drawing.Point(536, 13)
        Me.SimpleButton6.Name = "SimpleButton6"
        Me.SimpleButton6.Size = New System.Drawing.Size(153, 36)
        Me.SimpleButton6.TabIndex = 24
        Me.SimpleButton6.Text = "Reset Semua Data"
        '
        'tabhasil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "tabhasil"
        Me.Size = New System.Drawing.Size(855, 578)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents CustomHeaderTextboxMD4 As MyCustomControl1.CustomHeaderTextboxMD
    Friend WithEvents SimpleButton7 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents SimpleButton6 As DevExpress.XtraEditors.SimpleButton
End Class
