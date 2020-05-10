Public Class frm_UtileriaReporte

    Private Sub frm_UtileriaReporte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'GymDataDataSet.Utileria' Puede moverla o quitarla según sea necesario.
        Me.UtileriaTableAdapter.Fill(Me.GymDataDataSet.Utileria)
        'TODO: esta línea de código carga datos en la tabla 'GymDataDataSet.Pagos' Puede moverla o quitarla según sea necesario.
        Me.PagosTableAdapter.Fill(Me.GymDataDataSet.Pagos)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportViewer1.Load

    End Sub
End Class