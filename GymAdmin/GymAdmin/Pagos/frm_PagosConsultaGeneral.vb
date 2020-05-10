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

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click

        Nombre_ClienteTextBox.Enabled = True
        FechaDateTimePicker.Enabled = True
        TipoTextBox.Enabled = True
        MontoTextBox.Enabled = True
        btnBorrar.Enabled = False
        btnEditar.Enabled = False
        btnActualizar.Enabled = False
        btnGuardar.Enabled = True
        btnBorrar.Enabled = False
        'Habilitar nuevo registro
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        'Configuración para error de guardado
        On Error GoTo ErrorGuardar
        'Guardar y Actualizar campos
        PagosBindingSource.EndEdit()
        PagosTableAdapter.Update(GymDataDataSet.Pagos)
        PagosTableAdapter.Fill(GymDataDataSet.Pagos)
        MessageBox.Show("Guardado")
        btnBorrar.Enabled = True
        btnEditar.Enabled = True
        btnActualizar.Enabled = True
        btnGuardar.Enabled = False
        btnBorrar.Enabled = True

        Nombre_ClienteTextBox.Enabled = True
        FechaDateTimePicker.Enabled = True
        TipoTextBox.Enabled = True
        MontoTextBox.Enabled = True
ErrorGuardar:
    End Sub

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
        'Borrar el registro actual
        PagosBindingSource.RemoveCurrent()
        MsgBox("Registro eliminado correctamente", MsgBoxStyle.Information)
        'Refrescar la tabla después del borrado
        PagosTableAdapter.Update(GymDataDataSet.Pagos)
    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        btnGuardar.Enabled = True
        Nombre_ClienteTextBox.Enabled = True
        FechaDateTimePicker.Enabled = True
        TipoTextBox.Enabled = True
        MontoTextBox.Enabled = True
    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        'Mostrar todos los registros
        PagosTableAdapter.Fill(GymDataDataSet.Pagos)
        MsgBox("Datos actualizados", MsgBoxStyle.Information)
    End Sub
End Class