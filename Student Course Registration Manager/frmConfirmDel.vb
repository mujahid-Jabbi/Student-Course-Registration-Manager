Imports MySql.Data.MySqlClient

Public Class frmConfirmDel
    Public conDB As New MySqlConnection("database=scremdb; password=1234; port=3306; user id=root; server=localhost")
    Dim conCommand As New MySqlCommand

    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        Try
            conDB.Close()
            conDB.Open()
            conCommand = New MySqlCommand("DELETE FROM tblstudinfo WHERE sid=@sid ", conDB)

            conCommand.Parameters.AddWithValue("@sid", txtID.Text)

            If conCommand.ExecuteNonQuery() Then
                MsgBox("                Record Successfully deleted")
                frmAdminStudInfo.disenable_BTN("btnAdd", "", "", "", False)
                frmAdminStudInfo.clearthem()
                frmAdminStudInfo.fillgrid()
                Me.Close()
                Dispose()
            Else
                MsgBox("           Data Could Not be deleted")
                Me.Close()
                Me.Dispose()
            End If
            conDB.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conDB.Close()
            Me.Close()
            Me.Dispose()
        End Try
    End Sub

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        Dispose()
    End Sub
End Class