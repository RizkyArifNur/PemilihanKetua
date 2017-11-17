Imports System.Data.SqlClient
Public Class datapemilih1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        buka()
        Try
            FlowLayoutPanel1.Controls.Clear()
            cmd = New SqlCommand("SELECT hasil.jumlah,datakandidat.nama1 FROM datakandidat,hasil WHERE datakandidat.idkandidat = hasil.idkandidat", cnn)
            baca = cmd.ExecuteReader
            Chart1.Series("anu").Points.Clear()
            Dim rdm As New Random
            Dim x As Integer = 0
            Dim jmlhsuara As Integer
            Dim clrplt() As Color
            clrplt = {Color.FromArgb(22, 160, 133), Color.FromArgb(231, 76, 60), Color.FromArgb(52, 152, 219), Color.FromArgb(52, 73, 94), Color.FromArgb(155, 89, 182), Color.FromArgb(41, 128, 185)}
            While baca.Read
                If x >= 5 Then
                    x = 0
                End If
                Dim header, isi As New Label
                header.Font = New Font("Century Gothic", 13)
                isi.Font = New Font("Century Gothic", 10)
                header.AutoSize = True
                isi.AutoSize = True
                isi.Margin = New Padding(0, 0, 0, 20)
                Chart1.Series("anu").Points.AddXY(baca.Item("nama1"), baca.Item("jumlah"))
                Chart1.Series("anu").Points(x).Color = clrplt(x)
                header.Text = baca.Item("nama1")
                isi.Text = "Jumlah Suara : " & baca.Item("jumlah")
                header.ForeColor = clrplt(x)

                FlowLayoutPanel1.Controls.Add(header)
                FlowLayoutPanel1.Controls.Add(isi)
                jmlhsuara += baca.Item("jumlah")
                x += 1
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
