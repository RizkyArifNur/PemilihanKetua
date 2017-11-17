Imports System.Data.SqlClient
Public Class datakandidat
    Dim dt As DataTable
    Dim dv As DataView

    Sub isi()
        buka()
        Try
            da = New SqlDataAdapter("SELECT * FROM datakandidat", cnn)
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

        End Try
    End Sub

    Sub sorting()

        With DataGridView1
            .Columns("idkandidat").ReadOnly = True
            .Columns("edit").ReadOnly = True
            .Columns("idkandidat").HeaderText = "ID Kandidat"
            .Columns("nama1").HeaderText = "Nama Kandidat 1"
            .Columns("kelas1").HeaderText = "Kelas 1"
            .Columns("gambar1").HeaderText = "Foto 1"
            .Columns("hapus").HeaderText = "Hapus"
            .Columns("edit").HeaderText = "Teredit"
            .ColumnHeadersDefaultCellStyle.Font = New Font("Century Gothic", 10)
            .Columns("hapus").Width = 70
            .Columns("edit").Width = 70
            .AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(222, 222, 222)
        End With
    End Sub

    Private Sub datakandidat_Load(sender As Object, e As EventArgs) Handles Me.Load
        isi()
        sorting()
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

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        tambahkandidat.ShowDialog()
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

    Private Sub SimpleButton7_Click(sender As Object, e As EventArgs) Handles SimpleButton7.Click
        buka()
        Try
            For Each row As DataGridViewRow In DataGridView1.Rows
                If row.Cells("edit").Value Then
                    cmd = New SqlCommand(String.Format("UPDATE datakandidat SET nama1='{0}',kelas1='{2}' WHERE idkandidat='{3}'", row.Cells("nama1").Value, row.Cells("kelas1").Value, row.Cells("idkandidat")), cnn)
                    cmd.ExecuteNonQuery()
                ElseIf row.Cells("hapus").Value Then
                    cmd = New SqlCommand("DELETE FROM datakandidat WHERE idkandidat='" & row.Cells("idkandidat").Value & "'", cnn)
                    cmd.ExecuteNonQuery()
                End If
            Next
            MsgBox("Data sukses di simpan")
            isi()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub CustomTextbox1_TextChanged(sender As Object, e As EventArgs) Handles CustomTextbox1.TextChanged
        dv.RowFilter = "nama1 LIKE '%" & CustomTextbox1.TextBoxText & "%'"
        DataGridView1.DataSource = dv
    End Sub
End Class
