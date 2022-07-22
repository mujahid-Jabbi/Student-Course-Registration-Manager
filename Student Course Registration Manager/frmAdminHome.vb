Public Class frmAdminHome
    Private Sub btnStuInfo_Click(sender As Object, e As EventArgs) Handles btnStuInfo.Click
        frmAdminStudInfo.Show()
        Hide()
    End Sub

    Private Sub btnAdminManager_Click(sender As Object, e As EventArgs) Handles btnAdminManager.Click
        frmAdminManager.Show()
        Hide()
    End Sub

    Private Sub btnLogOff_Click(sender As Object, e As EventArgs) Handles btnLogOff.Click
        frmLogin.Show()
        frmAdminManager.Dispose()
        frmAdminStudInfo.Dispose()
        Close()
    End Sub

    Private Sub btnCourses_Click(sender As Object, e As EventArgs) Handles btnCourses.Click
        frmCourses.Show()
        Hide()
    End Sub

    Private Sub btnDepart_Click(sender As Object, e As EventArgs) Handles btnDepart.Click
        frmCourseProgDeptmt.Show()
        Hide()
    End Sub

    Private Sub frmAdminHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class