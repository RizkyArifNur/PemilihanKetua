Imports System.Data.SqlClient
Public Class tambah_admin
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
    Sub hapus()
        CustomHeaderTextboxMD2.TextBoxText = ""
        CustomHeaderTextboxMD4.TextBoxText = ""
    End Sub
    Private Sub btn1_click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not CustomHeaderTextboxMD4.DataError Then
            buka()
            Try
                cmd = New SqlCommand("INSERT INTO dataadmin(username,password) VALUES('" & CustomHeaderTextboxMD4.TextBoxText & "', '" & CustomHeaderTextboxMD2.TextBoxText & "')", cnn)
                cmd.ExecuteNonQuery()
                Form1.Dataadmin1.isi()
                MsgBox("Data Sukses Disimpan", MsgBoxStyle.Information)
                hapus()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Form1.Dataadmin1.isi()
    End Sub

    Private Sub CustomHeaderTextboxMD4_LostFocus(sender As Object, e As EventArgs) Handles CustomHeaderTextboxMD4.LostFocus
        buka()
        Try
            cmd = New SqlCommand("SELECT username FROM dataadmin WHERE username='" & CustomHeaderTextboxMD4.TextBoxText & "'", cnn)
            baca = cmd.ExecuteReader
            If baca.HasRows Then
                CustomHeaderTextboxMD4.DataError = True
            Else
                CustomHeaderTextboxMD4.DataError = False
            End If


        Catch ex As Exception

        End Try
    End Sub
End Class