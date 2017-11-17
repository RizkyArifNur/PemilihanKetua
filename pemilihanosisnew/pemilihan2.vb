Imports System.Data.SqlClient
Public Class pemilihan2

    Public Sub controladd1()
        buka()
        Try
            cmd = New SqlCommand("SELECT * FROM datakandidat", cnn)
            baca = cmd.ExecuteReader
            While baca.Read
                Dim a As New controlcandidat
                a.nama1.Text = baca.Item("nama1")
                a.kelas1.Text = baca.Item("kelas1")
                a.nomorkandidat = baca.Item("idkandidat")
                a.Label1.Text = "KANDIDAT " & baca.Item("idkandidat")
                a.jekel = baca.Item("jekel")
                Dim image2() As Byte
                image2 = baca.Item("gambar1")
                Dim mstr As System.IO.MemoryStream = New IO.MemoryStream(image2)
                a.PictureBox1.Image = Image.FromStream(mstr)
                FlowLayoutPanel1.Controls.Add(a)
            End While
        Catch ex As Exception

        End Try
    End Sub

    Private Sub pemilihan2_Load(sender As Object, e As EventArgs) Handles Me.Load
        controladd1()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        FlowLayoutPanel1.Controls.Clear()

        controladd1()

    End Sub
End Class
