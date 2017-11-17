Imports System.Data.SqlClient
Public Class Dataadmin
    Dim dv As DataView
    Dim dt As DataTable

    Sub isi()
        buka()
        Try
            da = New SqlDataAdapter("SELECT * FROM dataadmin", cnn)
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
            .Columns("idadmin").ReadOnly = True
            .Columns("username").ReadOnly = True
            .Columns("edit").ReadOnly = True
            .Columns("idadmin").HeaderText = "ID Admin"
            .Columns("username").HeaderText = "Username"
            .Columns("password").HeaderText = "Password"
            .Columns("hapus").HeaderText = "Hapus"
            .Columns("edit").HeaderText = "Teredit"
            .ColumnHeadersDefaultCellStyle.Font = New Font("Century Gothic", 10)
            .Columns("hapus").Width = 70
            .Columns("edit").Width = 70
            .AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(222, 222, 222)
        End With
    End Sub

    Private Sub SimpleButton6_Click(sender As Object, e As EventArgs) Handles SimpleButton6.Click
        isi()

    End Sub

    Private Sub CustomTextbox1_TextChanged(sender As Object, e As EventArgs) Handles CustomTextbox1.TextChanged
        dv.RowFilter = "username LIKE '%" & CustomTextbox1.TextBoxText & "%'"
        DataGridView1.DataSource = dv
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

    Private Sub Dataadmin_Load(sender As Object, e As EventArgs) Handles Me.Load
        isi()
        sorting()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        If e.ColumnIndex = DataGridView1.Columns("hapus").Index Then
            CustomTextbox1.Focus()
        End If


    End Sub

    Private Sub SimpleButton7_Click(sender As Object, e As EventArgs) Handles SimpleButton7.Click
        buka()
        Try
            For Each row As DataGridViewRow In DataGridView1.Rows
                If row.Cells("edit").Value Then
                    cmd = New SqlCommand("UPDATE dataadmin SET password='" & row.Cells("password").Value & "' WHERE username='" & row.Cells("username").Value & "'", cnn)
                    cmd.ExecuteNonQuery()
                ElseIf row.Cells("hapus").Value Then
                    cmd = New SqlCommand("DELETE FROM dataadmin WHERE username='" & row.Cells("username").Value & "'", cnn)
                    cmd.ExecuteNonQuery()
                End If
            Next
            MsgBox("Data sukses di simpan")
            isi()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
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

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        tambah_admin.ShowDialog()

    End Sub
End Class
