Imports MySql.Data.MySqlClient

Public Class frmRegCourseConfirm
    Dim conCommand As New MySqlCommand
    Dim conReader As MySqlDataReader
    Dim conAdapter As New MySqlDataAdapter
    Dim picPath As String
    Dim picArr() As Byte
    Dim picTable As New DataTable
    Dim dset As New DataSet

    Public conDB As New MySqlConnection("database=scremdb; password=1234; port=3306; user id=root; server=localhost")


    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        Close()
        Dispose()
    End Sub

    Sub removeAvail()
        Dim conCommand As New MySqlCommand
        conDB.Close()
        conDB.Open()
        conCommand = New MySqlCommand("DELETE FROM tbltempcourse WHERE sid=@sid", conDB)
        conCommand.Parameters.AddWithValue("@sid", frmStudInfo.txtMainID.Text)
        conCommand.ExecuteNonQuery()
        frmStudInfo.fillAvailGrid()
        conDB.Dispose()
        frmStudInfo.btnload.Enabled = False
    End Sub

    Sub removeSelected()
        Dim conCommand As New MySqlCommand
        conDB.Close()
        conDB.Open()
        conCommand = New MySqlCommand("DELETE FROM tbltempselected WHERE sid=@sid", conDB)
        conCommand.Parameters.AddWithValue("@sid", frmStudInfo.txtMainID.Text)
        conCommand.ExecuteNonQuery()
        frmStudInfo.fillSelectedGrid()
        conDB.Dispose()
    End Sub

    Sub fillSelectedGrid()
        Dim dbtable As New DataTable
        Try
            conDB.Close()
            conDB.Open()

            conCommand = New MySqlCommand("SELECT ccode,cname,cchr FROM tbltempselected WHERE sid=@sid", conDB)
            With conCommand.Parameters
                .AddWithValue("@sid", frmStudInfo.txtMainID.Text)
                '.AddWithValue("@ccode", frmStudInfo.txthccode.Text)
            End With

            conReader = conCommand.ExecuteReader(CommandBehavior.CloseConnection)
            dgvSC.Rows.Clear()
            While conReader.Read
                dgvSC.Rows.Add(conReader("ccode"), conReader("cname"), conReader("cchr"))
            End While

            For i = 0 To dgvSC.Rows.Count - 1
                dgvSC.Rows(i).Height = 50
            Next
            conDB.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conDB.Close()
        Finally
            conDB.Close()
        End Try
    End Sub

    Private Sub frmRegCourseConfirm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fillSelectedGrid()
    End Sub

    Sub moveToFinal()
        Try
            conDB.Close()
            conDB.Open()
            conCommand = New MySqlCommand("INSERT INTO tblregcourses(sid,ccode,cname,cchr,academ,sem,level,depart,prog)
                            (SELECT sid,ccode,cname,cchr,academ,sem,level,depart,prog FROM tbltempselected WHERE sid=@sid)", conDB)
            conCommand.Parameters.AddWithValue("@sid", frmStudInfo.txtMainID.Text)
            If conCommand.ExecuteNonQuery() Then
                MessageBox.Show("Course(s) Succesfully Registered, You May View in the History")
                frmStudInfo.chkIfAlreadyRegd()
                Dispose()
                removeSelected()
                removeAvail()
                conDB.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conDB.Close()
        End Try
    End Sub

    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        moveToFinal()
    End Sub
End Class