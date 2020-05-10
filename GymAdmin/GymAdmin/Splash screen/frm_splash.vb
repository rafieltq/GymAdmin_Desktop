Public Class frm_splash

    Private Sub Tiempo_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tiempo.Tick
        Try
            Barra.Width += 1
            If (Barra.Width >= 564) Then
                Tiempo.Stop()
                frm_inicio.Show()
                Me.Hide()
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class