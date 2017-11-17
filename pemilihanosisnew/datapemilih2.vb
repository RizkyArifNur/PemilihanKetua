Imports System.Data.SqlClient
Public Class datapemilih2
    Dim dt As DataTable
    Dim dv As DataView

    Sub randomuser(ByVal banyakdata As Integer)
        Dim ketemu As Boolean
        For datanya As Integer = 0 To banyakdata - 1
            ketemu = False
            Dim str As String
            While ketemu = False
                str = ""
                Dim rdm As New Random
                Dim a As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890"
                For i As Integer = 0 To 4
                    Dim x As Integer = rdm.Next(0, 34)
                    str &= a.Substring(x, 1)
                Next
                Try
                    cnn.Close()
                    buka()
                    cmd = New SqlCommand("SELECT username FROM datapemilih WHERE username='" & str.ToString & "'", cnn)
                    baca = cmd.ExecuteReader

                    If Not baca.HasRows Then
                        ketemu = True
                        buka()
                        Try
                            cmd = New SqlCommand("INSERT INTO datapemilih(username,password,status) VALUES('" & str.ToString & "','" & str.ToString & "','0')", cnn)
                            cmd.ExecuteNonQuery()
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End While
        Next
        isi()
    End Sub
    Sub isi()
        buka()
        Try
            da = New SqlDataAdapter("SELECT * FROM datapemilih", cnn)
            dt = New DataTable
            da.Fill(dt)
            dt.Columns.Add(New DataColumn("hapus", GetType(Boolean)))
            dt.Columns.Add(New DataColumn("edit", GetType(Boolean)))
            For i As Integer = 0 To dt.Rows.Count - 1
                dt.Rows(i).Item("hapus") = False
                dt.Rows(i).Item("edit") = False
            Next
            dv = New DataView(dt)
            DataGridView1.DataSource = dv
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub



    Private Sub datapemilih_Load(sender As Object, e As EventArgs) Handles Me.Load
        isi()
        ' sorting()
    End Sub

    Private Sub DataGridView1_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DataGridView1.DataBindingComplete
        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Cells("hapus").Value = True Then
                row.DefaultCellStyle.BackColor = Color.PaleVioletRed
            ElseIf row.Cells("edit").Value = True Then
                row.DefaultCellStyle.BackColor = Color.LightGreen
            Else
                row.DefaultCellStyle.BackColor = Color.White
            End If
        Next
    End Sub


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.ColumnIndex = DataGridView1.Columns("hapus").Index Then
            CustomTextbox1.Focus()
        End If
    End Sub

    Private Sub CheckButton3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckButton3.CheckedChanged
        For Each row As DataGridViewRow In DataGridView1.Rows
            row.Cells("hapus").Value = CheckButton3.Checked
        Next
    End Sub

    Private Sub CheckButton1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckButton1.CheckedChanged
        If CheckButton2.Checked And CheckButton1.Checked Then
            dv.RowFilter = "hapus=" & True & " and edit =" & True & ""
        ElseIf CheckButton1.Checked Then
            dv.RowFilter = "edit =" & True & ""
        ElseIf CheckButton2.Checked Then
            dv.RowFilter = "hapus=" & True & ""
        Else
            dv.RowFilter = ""
        End If
    End Sub

    Private Sub CheckButton2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckButton2.CheckedChanged
        If CheckButton2.Checked And CheckButton1.Checked Then
            dv.RowFilter = "hapus=" & True & " and edit =" & True & ""
        ElseIf CheckButton1.Checked Then
            dv.RowFilter = "edit =" & True & ""
        ElseIf CheckButton2.Checked Then
            dv.RowFilter = "hapus=" & True & ""
        Else
            dv.RowFilter = ""
        End If
    End Sub

    Private Sub SimpleButton6_Click(sender As Object, e As EventArgs) Handles SimpleButton6.Click
        isi()
    End Sub

    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        If e.ColumnIndex = DataGridView1.Columns("hapus").Index Then
            CustomTextbox1.Focus()
        End If
    End Sub

    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        If e.ColumnIndex <> DataGridView1.Columns("hapus").Index Then
            DataGridView1.Rows(e.RowIndex).Cells("edit").Value = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        randomuser(InputBox("Masukan Banyaknya Data", "Pembuatan Random User"))
    End Sub

    Private Sub SimpleButton7_Click(sender As Object, e As EventArgs) Handles SimpleButton7.Click
        buka()
        Try
            For Each row As DataGridViewRow In DataGridView1.Rows
                If row.Cells("edit").Value Then
                    cmd = New SqlCommand(String.Format("UPDATE datapemilih SET password='{0}',status='{1}' WHERE id='{2}'", row.Cells("password").Value, row.Cells("status").Value, row.Cells("id").Value), cnn)
                    cmd.ExecuteNonQuery()
                ElseIf row.Cells("hapus").Value Then
                    cmd = New SqlCommand("DELETE FROM datapemilih WHERE id='" & row.Cells("id").Value & "'", cnn)
                    cmd.ExecuteNonQuery()
                End If
            Next
            MsgBox("Data sukses di simpan")
            isi()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cetak.ShowDialog()

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        tambahdatapemilih.ShowDialog()
    End Sub

    Private Sub CustomTextbox1_TextChanged(sender As Object, e As EventArgs) Handles CustomTextbox1.TextChanged
        dv.RowFilter = "username LIKE '%" & CustomTextbox1.TextBoxText & "%'"
        DataGridView1.DataSource = dv
    End Sub
End Class
