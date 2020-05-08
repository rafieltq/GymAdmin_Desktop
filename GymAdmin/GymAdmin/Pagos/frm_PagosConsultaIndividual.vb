Public Class frm_PagosConsultaIndividual

    Private Sub PagosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PagosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PagosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GymDataDataSet)

    End Sub

    Private Sub frm_PagosConsultaIndividual_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'GymDataDataSet.Pagos' Puede moverla o quitarla según sea necesario.
        Me.PagosTableAdapter.Fill(Me.GymDataDataSet.Pagos)

    End Sub

    Private Sub TxtBuscarPago_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtBuscarPago.KeyPress
        Me.PagosTableAdapter.FillSearch(Me.GymDataDataSet.Pagos, TxtBuscarPago.Text)
    End Sub
End Class