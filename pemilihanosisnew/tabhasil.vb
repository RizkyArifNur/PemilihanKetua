Imports System.Data.SqlClient
Public Class tabhasil
    Private Sub SimpleButton7_Click(sender As Object, e As EventArgs) Handles SimpleButton7.Click
        Try
            System.IO.File.WriteAllText(Application.StartupPath & "\setting.txt", CustomHeaderTextboxMD4.TextBoxText)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try


    End Sub

    Private Sub tabhasil_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            CustomHeaderTextboxMD4.TextBoxText = System.IO.File.ReadAllText(Application.StartupPath & "\setting.txt")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            CustomHeaderTextboxMD4.TextBoxText = System.IO.File.ReadAllText(Application.StartupPath & "\setting.txt")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub SimpleButton6_Click(sender As Object, e As EventArgs) Handles SimpleButton6.Click
        If MsgBox("Apakah Anda Yakin Akan Mereset Semua Data ?", vbYesNo, "Reset Data") = vbYes Then
            buka()
            Try
                cmd = New SqlCommand("DELETE FROM datakandidat;DELETE FROM hasil; DBCC CHECKIDENT (""datakandidat"",RESEED, 0); DBCC CHECKIDENT (""datapemilih"",RESEED, 0);DELETE FROM datapemilih", cnn)
                cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil Di reset", MsgBoxStyle.Information)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            End Try
        End If

    End Sub
End Class
