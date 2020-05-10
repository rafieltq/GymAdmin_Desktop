Public Class frm_Manual

    Private Sub frm_Manual_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnUrl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUrl.Click
        Try
            System.Diagnostics.Process.Start("https://www.flipsnack.com/R4FI3L/gym-admin.html")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDownload.Click
        Try
            System.Diagnostics.Process.Start("http://www.mediafire.com/file/2nba1t3iboyvixh/GYM_ADMIN.pdf/file")
        Catch ex As Exception

        End Try
    End Sub
End Class