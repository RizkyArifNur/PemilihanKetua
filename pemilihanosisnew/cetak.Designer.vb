﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cetak
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.pemilihanosisDataSet = New pemilihanosisnew.pemilihanosisDataSet()
        Me.datapemilihBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.datapemilihTableAdapter = New pemilihanosisnew.pemilihanosisDataSetTableAdapters.datapemilihTableAdapter()
        CType(Me.pemilihanosisDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datapemilihBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.datapemilihBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "pemilihanosisnew.cetakdatapemilih.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(592, 489)
        Me.ReportViewer1.TabIndex = 0
        '
        'pemilihanosisDataSet
        '
        Me.pemilihanosisDataSet.DataSetName = "pemilihanosisDataSet"
        Me.pemilihanosisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'datapemilihBindingSource
        '
        Me.datapemilihBindingSource.DataMember = "datapemilih"
        Me.datapemilihBindingSource.DataSource = Me.pemilihanosisDataSet
        '
        'datapemilihTableAdapter
        '
        Me.datapemilihTableAdapter.ClearBeforeFill = True
        '
        'cetak
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 489)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "cetak"
        Me.Text = "cetak"
        CType(Me.pemilihanosisDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datapemilihBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents datapemilihBindingSource As BindingSource
    Friend WithEvents pemilihanosisDataSet As pemilihanosisDataSet
    Friend WithEvents datapemilihTableAdapter As pemilihanosisDataSetTableAdapters.datapemilihTableAdapter
End Class
