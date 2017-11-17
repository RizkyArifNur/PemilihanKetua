Imports System.Data.SqlClient
Imports System.IO
Public Class tambahkandidat
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
    Sub bersih()
        CustomHeaderTextboxMD2.TextBoxText = ""
        CustomHeaderTextboxMD4.TextBoxText = ""
        PictureBox1.Image = Global.pemilihanosisnew.My.Resources.Resources.no_avatar
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            PictureBox1.ImageLocation = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        buka()
        Try
            Dim imagebytes() As Byte
            Using mstream As New MemoryStream
                PictureBox1.Image.Save(mstream, PictureBox1.Image.RawFormat)
                imagebytes = mstream.ToArray()
            End Using
            Dim jk As Integer
            If ComboBox1.SelectedItem = "Laki-Laki" Then
                jk = 1
            Else
                jk = 0
            End If
            cmd = New SqlCommand(String.Format("INSERT INTO datakandidat(nama1,kelas1,gambar1,jekel) VALUES('{0}','{1}',@gambar1,'{2}')", CustomHeaderTextboxMD4.TextBoxText, CustomHeaderTextboxMD2.TextBoxText, jk), cnn)
            With cmd.Parameters.Add("@gambar1", SqlDbType.Image)
                .Value = imagebytes
                .Size = imagebytes.Length
            End With
            cmd.ExecuteNonQuery()
            MsgBox("Data Sukses Di Simpan", MsgBoxStyle.Information)
            Form1.Datakandidat1.isi()
            bersih()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class