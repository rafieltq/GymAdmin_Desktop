Public Class frm_ClienteconsultaIndividual

    Private Sub ClienteBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClienteBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ClienteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GymDataDataSet)

    End Sub

    Private Sub frm_ClienteconsultaIndividual_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'GymDataDataSet.Cliente' Puede moverla o quitarla según sea necesario.
        Me.ClienteTableAdapter.Fill(Me.GymDataDataSet.Cliente)

    End Sub

    Private Sub TxtBuscarCliente_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtBuscarCliente.KeyUp
        'Barra de busqueda, se busca el cliente por su nombre'
        Me.ClienteTableAdapter.FillSearch(Me.GymDataDataSet.Cliente, TxtBuscarCliente.Text)
    End Sub
End Class