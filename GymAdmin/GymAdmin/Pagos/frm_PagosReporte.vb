Public Class frm_PagosReporte

    Private Sub frm_PagosReporte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'GymDataDataSet.Pagos' Puede moverla o quitarla según sea necesario.
        Me.PagosTableAdapter.Fill(Me.GymDataDataSet.Pagos)
        'TODO: esta línea de código carga datos en la tabla 'GymDataDataSet.Cliente' Puede moverla o quitarla según sea necesario.
        Me.ClienteTableAdapter.Fill(Me.GymDataDataSet.Cliente)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class