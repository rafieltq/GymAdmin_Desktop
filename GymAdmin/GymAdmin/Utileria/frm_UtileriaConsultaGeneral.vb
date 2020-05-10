Public Class frm_UtileriaConsultaGeneral

    Private Sub UtileriaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UtileriaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UtileriaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GymDataDataSet)

    End Sub

    Private Sub frm_UtileriaConsultaGeneral_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'GymDataDataSet.Utileria' Puede moverla o quitarla según sea necesario.
        Me.UtileriaTableAdapter.Fill(Me.GymDataDataSet.Utileria)

    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click

        NombreTextBox.Enabled = True
        CategoriaTextBox.Enabled = True
        CantidadTextBox.Enabled = True
        btnBorrar.Enabled = False
        btnEditar.Enabled = False
        btnActualizar.Enabled = False
        btnGuardar.Enabled = True
        btnBorrar.Enabled = False
        'Habilitar nuevo registro

        UtileriaBindingSource.AddNew()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        'Configuración para error de guardado
        On Error GoTo ErrorGuardar
        'Guardar y Actualizar campos
        UtileriaBindingSource.EndEdit()
        UtileriaTableAdapter.Update(GymDataDataSet.Utileria)
        UtileriaTableAdapter.Fill(GymDataDataSet.Utileria)
        MessageBox.Show("Guardado")
        btnBorrar.Enabled = True
        btnEditar.Enabled = True
        btnActualizar.Enabled = True
        btnGuardar.Enabled = False
        btnBorrar.Enabled = True

        NombreTextBox.Enabled = True
        CantidadTextBox.Enabled = True
        CategoriaTextBox.Enabled = True
ErrorGuardar:
    End Sub

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
        'Borrar el registro actual
        UtileriaBindingSource.RemoveCurrent()
        MsgBox("Registro eliminado correctamente", MsgBoxStyle.Information)
        'Refrescar la tabla después del borrado
        UtileriaTableAdapter.Update(GymDataDataSet.Utileria)
    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        'Activar los campos de registros
        btnGuardar.Enabled = True
        NombreTextBox.Enabled = True
        CategoriaTextBox.Enabled = True
        CantidadTextBox.Enabled = True
    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        'Mostrar todos los registros
        UtileriaTableAdapter.Fill(GymDataDataSet.Utileria)
        MsgBox("Datos actualizados", MsgBoxStyle.Information)
    End Sub
End Class