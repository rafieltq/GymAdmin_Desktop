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
End Class