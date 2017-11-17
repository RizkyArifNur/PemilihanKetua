Public Class login

#Region "geser"
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        AddHandler Panel1.MouseDown, AddressOf onmousepressed
        AddHandler Panel1.MouseUp, AddressOf onctlmouseup
        AddHandler Panel1.MouseMove, AddressOf ctlmousemove
    End Sub
    Private mousepressed As Boolean
    Private oldx, oldy As Integer

    Private Sub onmousepressed(sender As Object, e As MouseEventArgs)
        Dim ts As Point = Me.PointToScreen(e.Location)
        oldx = ts.X
        oldy = ts.Y
        mousepressed = True
    End Sub

    Private Sub onctlmouseup(sender As Object, e As MouseEventArgs)
        mousepressed = False
    End Sub

    Private Sub ctlmousemove(sender As Object, e As MouseEventArgs)
        If mousepressed Then
            Dim ts As Point = Me.PointToScreen(e.Location)
            Me.Location = New Point(Me.Location.X + (ts.X - oldx), Me.Location.Y + (ts.Y - oldy))
            oldx = ts.X
            oldy = ts.Y
        End If
    End Sub


#End Region
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        CustomHeaderTextboxMD1.UsingPasswordChar = Not CheckBox1.Checked
    End Sub

    Private Sub SimpleButton7_Click(sender As Object, e As EventArgs) Handles SimpleButton7.Click
        buka()
        Try
            cmd = New SqlClient.SqlCommand("SELECT username,password FROM datapemilih WHERE username ='" & CustomHeaderTextboxMD4.TextBoxText & "' AND password='" & CustomHeaderTextboxMD1.TextBoxText & "' AND status='0'", cnn)
            baca = cmd.ExecuteReader
            baca.Read()
            If baca.HasRows Then
                Me.Hide()
                Form1.usernya = baca.Item("username")
                Form1.awal(False)
                Form1.Show()

            Else
                buka()
                cmd = New SqlClient.SqlCommand("SELECT username,password FROM dataadmin WHERE username ='" & CustomHeaderTextboxMD4.TextBoxText & "' AND password='" & CustomHeaderTextboxMD1.TextBoxText & "'", cnn)
                baca = cmd.ExecuteReader
                baca.Read()

                If baca.HasRows Then
                    Me.Hide()
                    Form1.usernya = baca.Item("username")
                    Form1.awal(True)
                    Form1.Show()
                Else
                    MsgBox("Akun Anda Tidak Terdaftar Atau Anda Sudah Pernah Memilih Sebelumnya, Silahkan Hubungi Administrator", MsgBoxStyle.Exclamation, "Akun Tidak Valid")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class