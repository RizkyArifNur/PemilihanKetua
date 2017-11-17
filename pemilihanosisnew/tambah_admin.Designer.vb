<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tambah_admin
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.CustomHeaderTextboxMD2 = New MyCustomControl1.CustomHeaderTextboxMD()
        Me.CustomHeaderTextboxMD4 = New MyCustomControl1.CustomHeaderTextboxMD()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(320, 50)
        Me.Panel1.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(6, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tambah Admin"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 50)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1, 227)
        Me.Panel2.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Silver
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(319, 50)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1, 227)
        Me.Panel3.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Silver
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(1, 276)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(318, 1)
        Me.Panel4.TabIndex = 4
        '
        'CustomHeaderTextboxMD2
        '
        Me.CustomHeaderTextboxMD2.DataError = False
        Me.CustomHeaderTextboxMD2.Effect = True
        Me.CustomHeaderTextboxMD2.FormatCurrency = False
        Me.CustomHeaderTextboxMD2.HeaderText = "Password"
        Me.CustomHeaderTextboxMD2.JustRead = False
        Me.CustomHeaderTextboxMD2.Location = New System.Drawing.Point(12, 141)
        Me.CustomHeaderTextboxMD2.Name = "CustomHeaderTextboxMD2"
        Me.CustomHeaderTextboxMD2.NumberOnly = False
        Me.CustomHeaderTextboxMD2.RangeNumber = False
        Me.CustomHeaderTextboxMD2.Size = New System.Drawing.Size(289, 79)
        Me.CustomHeaderTextboxMD2.TabIndex = 2
        Me.CustomHeaderTextboxMD2.TextBoxText = ""
        Me.CustomHeaderTextboxMD2.UsingPasswordChar = False
        Me.CustomHeaderTextboxMD2.WaterMarkText = "Password"
        '
        'CustomHeaderTextboxMD4
        '
        Me.CustomHeaderTextboxMD4.DataError = False
        Me.CustomHeaderTextboxMD4.Effect = True
        Me.CustomHeaderTextboxMD4.FormatCurrency = False
        Me.CustomHeaderTextboxMD4.HeaderText = "Username"
        Me.CustomHeaderTextboxMD4.JustRead = False
        Me.CustomHeaderTextboxMD4.Location = New System.Drawing.Point(12, 56)
        Me.CustomHeaderTextboxMD4.Name = "CustomHeaderTextboxMD4"
        Me.CustomHeaderTextboxMD4.NumberOnly = False
        Me.CustomHeaderTextboxMD4.RangeNumber = False
        Me.CustomHeaderTextboxMD4.Size = New System.Drawing.Size(289, 79)
        Me.CustomHeaderTextboxMD4.TabIndex = 1
        Me.CustomHeaderTextboxMD4.TextBoxText = ""
        Me.CustomHeaderTextboxMD4.UsingPasswordChar = False
        Me.CustomHeaderTextboxMD4.WaterMarkText = "Username"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(79, 228)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 37)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Simpan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(190, 228)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(105, 37)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Batal"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'tambah_admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(320, 277)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CustomHeaderTextboxMD4)
        Me.Controls.Add(Me.CustomHeaderTextboxMD2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "tambah_admin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "tambah_admin"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents CustomHeaderTextboxMD2 As MyCustomControl1.CustomHeaderTextboxMD
    Friend WithEvents CustomHeaderTextboxMD4 As MyCustomControl1.CustomHeaderTextboxMD
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
