Public Class frm_PagosConsultaIndividual
    Dim consultaPago As String
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
        If (consultaPago = "Nombre") Then
            Me.PagosTableAdapter.FillSearch(Me.GymDataDataSet.Pagos, TxtBuscarPago.Text)
        End If
    End Sub

    Private Sub BtnNombre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNombre.Click
        consultaPago = "Nombre"
    End Sub

    Private Sub DtpBuscarFecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DtpBuscarFecha.ValueChanged
        Me.PagosTableAdapter.FillSearchFecha(Me.GymDataDataSet.Pagos, DtpBuscarFecha.Text)
    End Sub
End Class