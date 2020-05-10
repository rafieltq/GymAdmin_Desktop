Public Class frm_UtileriaConsultaIndividual
    Dim consultaUtileria As String
    Private Sub UtileriaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UtileriaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UtileriaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GymDataDataSet)

    End Sub

    Private Sub frm_UtileriaConsultaIndividual_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'GymDataDataSet.Utileria' Puede moverla o quitarla según sea necesario.
        Me.UtileriaTableAdapter.Fill(Me.GymDataDataSet.Utileria)

    End Sub

    Private Sub TxtBuscarUtileria_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtBuscarUtileria.KeyPress
        If (consultaUtileria = "Nombre") Then
            Me.UtileriaTableAdapter.FillSearch(Me.GymDataDataSet.Utileria, TxtBuscarUtileria.Text)
        ElseIf (consultaUtileria = "Categoria") Then
            Me.UtileriaTableAdapter.FillSearchCategoria(Me.GymDataDataSet.Utileria, TxtBuscarUtileria.Text)
        End If
    End Sub

    Private Sub BtnNombre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNombre.Click
        consultaUtileria = "Nombre"
    End Sub

    Private Sub BtnCategoria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCategoria.Click
        consultaUtileria = "Categoria"
    End Sub
End Class