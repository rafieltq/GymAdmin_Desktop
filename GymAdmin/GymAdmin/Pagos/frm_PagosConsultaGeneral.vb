Public Class frm_PagosConsultaGeneral

    Private Sub PagosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PagosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PagosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GymDataDataSet)

    End Sub

    Private Sub frm_PagosConsultaGeneral_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'GymDataDataSet.Pagos' Puede moverla o quitarla según sea necesario.
        Me.PagosTableAdapter.Fill(Me.GymDataDataSet.Pagos)

    End Sub
End Class