Imports System.Data.SqlClient
Public Class controlcandidat
    Public nomorkandidat As Integer
    Public jekel As Integer
    Public mati As Boolean
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If MsgBox("Apakah Anda Ingin Memilih '" & nama1.Text & "'", vbYesNo, "Pilih Kandidat") = vbYes Then
            buka()
            Try
                cmd = New SqlCommand("SELECT idkandidat FROM hasil WHERE idkandidat='" & nomorkandidat & "'", cnn)
                baca = cmd.ExecuteReader
                baca.Read()
                If baca.HasRows Then
                    buka()
                    cmd = New SqlCommand("UPDATE hasil SET jumlah=jumlah+1 WHERE idkandidat='" & nomorkandidat & "'", cnn)
                    cmd.ExecuteNonQuery()
                    MsgBox("Anda Sudah Memilih Kandidat " & nomorkandidat)
                Else
                    buka()
                    cmd = New SqlCommand("INSERT INTO hasil VALUES('" & nomorkandidat & "','1')", cnn)
                    cmd.ExecuteNonQuery()
                    MsgBox("Anda Sudah Memilih Kandidat " & nomorkandidat)
                End If
                buka()
                cmd = New SqlCommand("UPDATE datapemilih SET status='1' WHERE username='" & Form1.usernya & "'", cnn)
                cmd.ExecuteNonQuery()

                For Each ctrl As controlcandidat In Me.Parent.Controls
                    If ctrl.jekel = Me.jekel Then
                        ctrl.Enabled = False
                    End If
                Next
                ttlpilih += 1
                If ttlpilih = 1 Then
                    Form1.TileBarItem2.Enabled = False
                ElseIf ttlpilih = 2 Then
                    ttlpilih = 0
                    Form1.Close()
                    login.Show()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub
End Class
