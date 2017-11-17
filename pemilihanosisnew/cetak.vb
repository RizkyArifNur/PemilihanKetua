Public Class cetak
    Private Sub cetak_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'pemilihanosisDataSet.datapemilih' table. You can move, or remove it, as needed.
        buka()
        Me.datapemilihTableAdapter.Connection = cnn
        Me.datapemilihTableAdapter.Fill(Me.pemilihanosisDataSet.datapemilih)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class