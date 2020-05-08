Public Class frm_ClienteconsultaGeneral

    Private Sub ClienteBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClienteBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ClienteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GymDataDataSet)

    End Sub

    Private Sub frm_ClienteconsultaGeneral_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'GymDataDataSet.Cliente' Puede moverla o quitarla según sea necesario.
        Me.ClienteTableAdapter.Fill(Me.GymDataDataSet.Cliente)
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        IdTextBox.Enabled = True
        NombreTextBox.Enabled = True
        ApellidoTextBox.Enabled = True
        CedulaTextBox.Enabled = True
        EdadTextBox.Enabled = True
        btnBorrar.Enabled = False
        btnEditar.Enabled = False
        btnActualizar.Enabled = False
        btnGuardar.Enabled = True
        btnBorrar.Enabled = False
        'Habilitar nuevo registro

        ClienteBindingSource.AddNew()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        'Configuración para error de guardado
        On Error GoTo ErrorGuardar
        'Guardar y Actualizar campos
        ClienteBindingSource.EndEdit()
        ClienteTableAdapter.Update(GymDataDataSet.Cliente)
        ClienteTableAdapter.Fill(GymDataDataSet.Cliente)
        MessageBox.Show("Guardado")
        btnBorrar.Enabled = True
        btnEditar.Enabled = True
        btnActualizar.Enabled = True
        btnGuardar.Enabled = False
        btnBorrar.Enabled = True
        IdTextBox.Enabled = True
        NombreTextBox.Enabled = True
        ApellidoTextBox.Enabled = True
        EdadTextBox.Enabled = True
ErrorGuardar:
    End Sub

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
        'Borrar el registro actual
        ClienteBindingSource.RemoveCurrent()
        'Refrescar la tabla después del borrado
        ClienteTableAdapter.Update(GymDataDataSet.Cliente)
    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        'Activar los campos de registros
        IdTextBox.Enabled = True
        NombreTextBox.Enabled = True
        ApellidoTextBox.Enabled = True
        CedulaTextBox.Enabled = True
        EdadTextBox.Enabled = True
    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        'Mostrar todos los registros
        ClienteTableAdapter.Fill(GymDataDataSet.Cliente)
    End Sub
End Class