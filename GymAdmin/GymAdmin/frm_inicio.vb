Public Class frm_inicio

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ConsultaIndividualToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaIndividualToolStripMenuItem.Click
        frm_ClienteconsultaIndividual.Show()
    End Sub

    Private Sub ConsultaGeneralToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaGeneralToolStripMenuItem.Click
        frm_ClienteconsultaGeneral.Show()
    End Sub

    Private Sub ReporteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReporteToolStripMenuItem.Click
        frm_ClienteReporte.Show()
    End Sub

    Private Sub ConsultaIndividualToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaIndividualToolStripMenuItem1.Click
        frm_UtileriaConsultaIndividual.Show()
    End Sub

    Private Sub ConsultaGeneralToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaGeneralToolStripMenuItem1.Click
        frm_UtileriaConsultaGeneral.Show()
    End Sub

    Private Sub ReporteToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReporteToolStripMenuItem1.Click
        frm_UtileriaReporte.Show()
    End Sub

    Private Sub ConsultaIndividualToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaIndividualToolStripMenuItem2.Click
        frm_PagosConsultaIndividual.Show()
    End Sub

    Private Sub ConsultaGeneralToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaGeneralToolStripMenuItem2.Click
        frm_PagosConsultaGeneral.Show()

    End Sub

    Private Sub ReporteToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReporteToolStripMenuItem2.Click
        frm_PagosReporte.Show()
    End Sub

    Private Sub ManualDeUsuarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManualDeUsuarioToolStripMenuItem.Click
        frm_Manual.Show()
    End Sub

    Private Sub SobreNosotrosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SobreNosotrosToolStripMenuItem.Click
        frm_SobreNosotros.Show()
    End Sub
End Class
