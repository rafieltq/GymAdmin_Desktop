<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_UtileriaReporte
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.GymDataDataSet = New GymAdmin.GymDataDataSet()
        Me.PagosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PagosTableAdapter = New GymAdmin.GymDataDataSetTableAdapters.PagosTableAdapter()
        Me.UtileriaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UtileriaTableAdapter = New GymAdmin.GymDataDataSetTableAdapters.UtileriaTableAdapter()
        CType(Me.GymDataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UtileriaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.UtileriaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "GymAdmin.rpt_Utileria.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(618, 484)
        Me.ReportViewer1.TabIndex = 0
        '
        'GymDataDataSet
        '
        Me.GymDataDataSet.DataSetName = "GymDataDataSet"
        Me.GymDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PagosBindingSource
        '
        Me.PagosBindingSource.DataMember = "Pagos"
        Me.PagosBindingSource.DataSource = Me.GymDataDataSet
        '
        'PagosTableAdapter
        '
        Me.PagosTableAdapter.ClearBeforeFill = True
        '
        'UtileriaBindingSource
        '
        Me.UtileriaBindingSource.DataMember = "Utileria"
        Me.UtileriaBindingSource.DataSource = Me.GymDataDataSet
        '
        'UtileriaTableAdapter
        '
        Me.UtileriaTableAdapter.ClearBeforeFill = True
        '
        'frm_UtileriaReporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(618, 484)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frm_UtileriaReporte"
        Me.Text = "Utileria"
        CType(Me.GymDataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UtileriaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents PagosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GymDataDataSet As GymAdmin.GymDataDataSet
    Friend WithEvents PagosTableAdapter As GymAdmin.GymDataDataSetTableAdapters.PagosTableAdapter
    Friend WithEvents UtileriaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UtileriaTableAdapter As GymAdmin.GymDataDataSetTableAdapters.UtileriaTableAdapter
End Class
