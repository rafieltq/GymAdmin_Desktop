Public Class frm_ClienteconsultaIndividual
    Dim consulta As String
    Private Sub ClienteBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClienteBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ClienteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GymDataDataSet)

    End Sub

    Private Sub frm_ClienteconsultaIndividual_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'GymDataDataSet.Cliente' Puede moverla o quitarla según sea necesario.
        Me.ClienteTableAdapter.Fill(Me.GymDataDataSet.Cliente)

    End Sub

    Private Sub TxtBuscarCliente_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtBuscar.KeyUp
        'Barra de busqueda, se busca el cliente por uno de sus datos'
        If (consulta = "Nombre") Then
            Me.ClienteTableAdapter.FillSearch(Me.GymDataDataSet.Cliente, TxtBuscar.Text)
        ElseIf (consulta = "Apellido") Then
            Me.ClienteTableAdapter.FillSeachLastName(Me.GymDataDataSet.Cliente, TxtBuscar.Text)
        ElseIf (consulta = "Cedula") Then
            Me.ClienteTableAdapter.FillSeachByCedula(Me.GymDataDataSet.Cliente, TxtBuscar.Text)
        End If
    End Sub

    Private Sub BtnNombre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNombre.Click
        consulta = "Nombre"
    End Sub

    Private Sub BtnApellido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnApellido.Click
        consulta = "Apellido"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        consulta = "Cedula"
    End Sub

End Class