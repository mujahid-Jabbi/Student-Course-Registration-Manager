Imports MySql.Data.MySqlClient

Public Class frmStudInfo


    Public conDB As New MySqlConnection("database=scremdb; password=1234; port=3306; user id=root; server=localhost")
    Public aca, sem, level As String


    Sub chkIfAlreadyRegd()
        Dim conCommand As New MySqlCommand
        Dim conReader As MySqlDataReader
        conDB.Close()
        conDB.Open()
        conCommand = New MySqlCommand("SELECT  academ,sem,level,depart,prog,sid FROM tblregcourses WHERE academ=@academ AND sem=@sem AND 
            level=@level AND depart=@depart AND prog=@prog AND sid=@sid", conDB)
        With conCommand.Parameters
            .AddWithValue("@academ", txtAY.Text)
            .AddWithValue("@level", txtLevel.Text)
            .AddWithValue("@sem", txtSem.Text)
            .AddWithValue("@depart", txtdpmt.Text)
            .AddWithValue("@prog", txtprogm.Text)
            .AddWithValue("@sid", txtMainID.Text)
        End With
        conReader = conCommand.ExecuteReader
        If (conReader.Read() = False) Then
            pnlAlready.Visible = False
        Else
            pnlAlready.Visible = True
        End If
        conDB.Close()
    End Sub


    Sub selectIntoAvailGrid()
        Dim conCommand As New MySqlCommand
        Dim conReader As MySqlDataReader
        Dim conAdapter As New MySqlDataAdapter
        Dim picTable As New DataTable
        Dim dset As New DataSet
        Dim dbtable As New DataTable
        Try
            conDB.Close()
            conDB.Open()

            conCommand = New MySqlCommand("SELECT ccode,cname,cchr FROM tblcourses WHERE academ=@academ AND csem=@csem AND 
            clevel=@clevel AND depart=@depart AND prog=@prog", conDB)
            With conCommand.Parameters
                .AddWithValue("@academ", txtAY.Text)
                .AddWithValue("@clevel", txtLevel.Text)
                .AddWithValue("@csem", txtSem.Text)
                .AddWithValue("@depart", txtdpmt.Text)
                .AddWithValue("@prog", txtprogm.Text)
            End With

            conReader = conCommand.ExecuteReader(CommandBehavior.CloseConnection)
            dgvHAvail.Rows.Clear()
            While conReader.Read
                dgvHAvail.Rows.Add("Add", conReader("ccode"), conReader("cname"), conReader("cchr"))
            End While

            For Each row As DataGridViewRow In dgvHAvail.Rows
                If Not row.IsNewRow Then
                    Dim ccode = row.Cells(1).Value
                    Dim cname = row.Cells(2).Value
                    Dim cchr = row.Cells(3).Value

                    conCommand = New MySqlCommand("INSERT INTO tbltempcourse(sid,ccode,cname,cchr)VALUES(@sid,@ccode,@cname,@cchr)", conDB)
                    With conCommand.Parameters
                        .AddWithValue("@sid", txtMainID.Text)
                        .AddWithValue("@ccode", ccode)
                        .AddWithValue("@cname", cname)
                        .AddWithValue("@cchr", cchr)
                    End With
                    conDB.Close()
                    conDB.Open()
                    conCommand.ExecuteNonQuery()
                End If
            Next

            'If conCommand.ExecuteNonQuery() Then
            'removeFromAvail()
            fillAvailGrid()
            'End If
        Catch ex As Exception
            MsgBox(ex.Message)
            conDB.Close()
        Finally
            conDB.Close()
        End Try
    End Sub

    Sub fillAvailGrid()
        Dim conCommand As New MySqlCommand
        Dim conReader As MySqlDataReader
        Dim conAdapter As New MySqlDataAdapter
        Dim picTable As New DataTable
        Dim dset As New DataSet
        Dim dbtable As New DataTable
        Try
            conDB.Close()
            conDB.Open()

            conCommand = New MySqlCommand("SELECT ccode,cname,cchr FROM tbltempcourse WHERE sid=@sid", conDB)
            conCommand.Parameters.AddWithValue("@sid", txtMainID.Text)

            conReader = conCommand.ExecuteReader(CommandBehavior.CloseConnection)
            dgvAC.Rows.Clear()
            While conReader.Read
                dgvAC.Rows.Add("Add -->", conReader("ccode"), conReader("cname"), conReader("cchr"))
            End While

            For i = 0 To dgvAC.Rows.Count - 1
                dgvAC.Rows(i).Height = 50
            Next
            conDB.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conDB.Close()
        Finally
            conDB.Close()
        End Try
    End Sub

    Sub removeFromAvail()
        Dim conCommand As New MySqlCommand
        Dim conReader As MySqlDataReader
        Dim conAdapter As New MySqlDataAdapter
        Dim picTable As New DataTable
        Dim dset As New DataSet
        Dim dbtable As New DataTable
        conDB.Close()
        conDB.Open()
        conCommand = New MySqlCommand("DELETE FROM tbltempcourse WHERE sid=@sid AND ccode=@ccode ", conDB)

        With conCommand.Parameters
            .AddWithValue("@sid", txtMainID.Text)
            .AddWithValue("@ccode", txthccode.Text)
        End With
        conCommand.ExecuteNonQuery()
        fillSelectedGrid()
        fillAvailGrid()
        conDB.Close()
    End Sub

    Sub selectIntoSelectedGrid()
        Dim conCommand As New MySqlCommand
        Dim conReader As MySqlDataReader
        Dim conAdapter As New MySqlDataAdapter
        Dim picTable As New DataTable
        Dim dset As New DataSet
        Dim dbtable As New DataTable
        Try
            conDB.Close()
            conDB.Open()

            conCommand = New MySqlCommand("SELECT ccode,cname,cchr FROM tbltempcourse WHERE sid=@sid AND ccode=@ccode", conDB)
            With conCommand.Parameters
                .AddWithValue("@sid", txtMainID.Text)
                .AddWithValue("@ccode", txthccode.Text)
            End With
            conCommand.Connection = conDB
            conAdapter.SelectCommand = conCommand
            conAdapter.Fill(dbtable)
            Dim ccode = dbtable.Rows(0).Item(0).ToString
            Dim cname = dbtable.Rows(0).Item(1).ToString
            Dim cchr = dbtable.Rows(0).Item(2).ToString


            conCommand = New MySqlCommand("INSERT INTO tbltempselected(sid,ccode,cname,cchr,academ,sem,level,depart,prog) 
                        VALUES(@sid,@ccode,@cname,@cchr,@academ,@sem,@level,@depart,@prog)", conDB)
            With conCommand.Parameters
                .AddWithValue("@sid", txtMainID.Text)
                .AddWithValue("@ccode", ccode)
                .AddWithValue("@cname", cname)
                .AddWithValue("@cchr", cchr)
                .AddWithValue("@academ", txtAY.Text)
                .AddWithValue("@sem", txtSem.Text)
                .AddWithValue("@level", txtLevel.Text)
                .AddWithValue("@depart", txtdpmt.Text)
                .AddWithValue("@prog", txtprogm.Text)
            End With

            conDB.Close()
            conDB.Open()
            If conCommand.ExecuteNonQuery() Then
                fillSelectedGrid()
                conDB.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            conDB.Close()
        Finally
            conDB.Close()
        End Try
    End Sub



    Sub fillSelectedGrid()
        Dim conCommand As New MySqlCommand
        Dim conReader As MySqlDataReader
        Dim conAdapter As New MySqlDataAdapter
        Dim picTable As New DataTable
        Dim dset As New DataSet
        Dim dbtable As New DataTable
        Try
            conCommand = New MySqlCommand("SELECT ccode,cname,cchr FROM tbltempselected", conDB)
            conDB.Close()
            conDB.Open()
            conReader = conCommand.ExecuteReader(CommandBehavior.CloseConnection)
            dgvSC.Rows.Clear()
            While conReader.Read
                dgvSC.Rows.Add("<--- Remove", conReader("ccode"), conReader("cname"), conReader("cchr"))
            End While

            conDB.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conDB.Close()
        Finally
            conDB.Close()
        End Try
    End Sub


    Sub moveToAvail()
        Dim conCommand As New MySqlCommand
        Dim conReader As MySqlDataReader
        Dim conAdapter As New MySqlDataAdapter
        Dim picTable As New DataTable
        Dim dset As New DataSet
        Dim dbtable As New DataTable
        conDB.Close()
        conDB.Open()
        conCommand = New MySqlCommand("INSERT INTO tbltempcourse(sid,ccode,cname,cchr)(SELECT sid,ccode,cname,cchr FROM tbltempselected WHERE sid=@sid AND ccode=@ccode)", conDB)
        With conCommand.Parameters
            .AddWithValue("@sid", txtMainID.Text)
            .AddWithValue("@ccode", txthccode.Text)
        End With
        If conCommand.ExecuteNonQuery() Then
            removeFromSelected()
            fillSelectedGrid()
            fillAvailGrid()
            conDB.Close()
        End If
    End Sub

    Sub removeFromSelected()
        Dim conCommand As New MySqlCommand
        Dim conReader As MySqlDataReader
        Dim conAdapter As New MySqlDataAdapter
        Dim picTable As New DataTable
        Dim dset As New DataSet
        Dim dbtable As New DataTable
        conDB.Close()
        conDB.Open()
        conCommand = New MySqlCommand("DELETE FROM tbltempselected WHERE sid=@sid AND ccode=@ccode ", conDB)

        With conCommand.Parameters
            .AddWithValue("@sid", txtMainID.Text)
            .AddWithValue("@ccode", txthccode.Text)
        End With
        conCommand.ExecuteNonQuery()
        fillSelectedGrid()
        fillAvailGrid()
        conDB.Close()
    End Sub


    Public Sub getYear_Sem()
        Dim conCommand As New MySqlCommand
        Dim conReader As MySqlDataReader
        Dim conAdapter As New MySqlDataAdapter
        Dim picTable As New DataTable
        Dim dset As New DataSet
        Dim dbtable As New DataTable
        Try
            conDB.Close()
            conDB.Open()
            conCommand = New MySqlCommand("SELECT MAX(academ), MAX(csem) FROM tblcourses", conDB)
            conCommand.Connection = conDB
            conAdapter.SelectCommand = conCommand
            conAdapter.Fill(dbtable)

            txtAY.Text = dbtable.Rows(0).Item(0).ToString
            txtSem.Text = dbtable.Rows(0).Item(1).ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conDB.Close()
        End Try
    End Sub

    Public Sub viewDetails()
        Dim conCommand As New MySqlCommand
        Dim conReader As MySqlDataReader
        Dim conAdapter As New MySqlDataAdapter
        Dim picTable As New DataTable
        Dim dset As New DataSet
        Dim dbtable As New DataTable

        Try
            conDB.Close()
            conDB.Open()
            conCommand = New MySqlCommand("SELECT * FROM tblstudinfo WHERE sid = @sid", conDB)

            conCommand.Parameters.AddWithValue("@sid", txtMainID.Text)

            conCommand.Connection = conDB
            conAdapter.SelectCommand = conCommand
            conAdapter.Fill(dbtable)

            txtID.Text = dbtable.Rows(0).Item(0).ToString
            Dim fname = dbtable.Rows(0).Item(1).ToString
            Dim mname = dbtable.Rows(0).Item(2).ToString
            Dim sname = dbtable.Rows(0).Item(3).ToString
            txtMainName.Text = fname & "   " & mname & "   " & sname
            txtFullName.Text = fname & "   " & mname & "   " & sname
            txtGend.Text = dbtable.Rows(0).Item(4)
            txtBD.Text = dbtable.Rows(0).Item(5)
            txtTel.Text = dbtable.Rows(0).Item(6)
            Dim dad = dbtable.Rows(0).Item(7).ToString()
            Dim dam = dbtable.Rows(0).Item(8).ToString
            Dim day = dbtable.Rows(0).Item(9).ToString
            txtDA.Text = dad & " " & dam & ", " & day
            txtLA.Text = dbtable.Rows(0).Item(10).ToString
            txtCL.Text = dbtable.Rows(0).Item(11).ToString
            txtLevel.Text = dbtable.Rows(0).Item(11).ToString
            txtCD.Text = dbtable.Rows(0).Item(12).ToString
            txtProg.Text = dbtable.Rows(0).Item(13).ToString
            txtprogm.Text = dbtable.Rows(0).Item(13).ToString
            txtdpmt.Text = dbtable.Rows(0).Item(14).ToString
            txtDepart.Text = dbtable.Rows(0).Item(14).ToString

            conDB.Close()
            conDB.Open()
            conCommand = New MySqlCommand("SELECT pic FROM tblpic WHERE sid=@sid", conDB)
            conCommand.Parameters.AddWithValue("@sid", txtMainID.Text)
            conCommand.Connection = conDB
            conAdapter.SelectCommand = conCommand
            conAdapter.Fill(picTable)
            Dim arrImage() As Byte
            arrImage = picTable.Rows(0).Item(0)
            Dim mstream As New System.IO.MemoryStream(arrImage)
            pbxPic.Image = Image.FromStream(mstream)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conDB.Close()
        End Try
    End Sub

    Private Sub frmStudInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlHistory.Visible = False
        pnlReg.Visible = False
        pnlInfo.Visible = False

    End Sub

    Private Sub btnPI_Click(sender As Object, e As EventArgs) Handles btnPI.Click
        btnPI.BackColor = Color.DimGray
        btnCRH.BackColor = Color.NavajoWhite
        btnCR.BackColor = Color.NavajoWhite
        btnPI.ForeColor = Color.White
        btnCRH.ForeColor = Color.Black
        btnCR.ForeColor = Color.Black
        pnlHistory.Visible = False
        pnlReg.Visible = False
        pnlInfo.Visible = True
    End Sub

    Private Sub btnCR_Click(sender As Object, e As EventArgs) Handles btnCR.Click
        chkIfAlreadyRegd()
        btnPI.BackColor = Color.NavajoWhite
        btnCRH.BackColor = Color.NavajoWhite
        btnCR.BackColor = Color.DarkCyan
        btnPI.ForeColor = Color.Black
        btnCRH.ForeColor = Color.Black
        btnCR.ForeColor = Color.White
        pnlHistory.Visible = False
        pnlHistory.Visible = False
        pnlReg.Visible = True
        pnlInfo.Visible = False
    End Sub

    Private Sub btnCRH_Click(sender As Object, e As EventArgs) Handles btnCRH.Click
        viewHistory()
        btnPI.BackColor = Color.NavajoWhite
        btnCRH.BackColor = Color.DarkSlateGray
        btnCR.BackColor = Color.NavajoWhite
        btnPI.ForeColor = Color.Black
        btnCRH.ForeColor = Color.White
        btnCR.ForeColor = Color.Black
        pnlHistory.Visible = False
        pnlHistory.Visible = True
        pnlReg.Visible = False
        pnlInfo.Visible = False
    End Sub

    Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnLogOff_Click(sender As Object, e As EventArgs) Handles btnLogOff.Click
        Close()
        frmLogin.Show()
    End Sub

    Private Sub frmStudInfo_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        viewDetails()
        getYear_Sem()
    End Sub

    Private Sub dgvAC_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAC.CellContentClick
        Try
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = dgvAC.Rows(e.RowIndex)
                txthccode.Text = row.Cells(1).Value
                selectIntoSelectedGrid()
                removeFromAvail()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnload_Click(sender As Object, e As EventArgs) Handles btnload.Click
        selectIntoAvailGrid()
    End Sub

    Private Sub dgvSC_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSC.CellContentClick
        Try
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = dgvSC.Rows(e.RowIndex)
                txthccode.Text = row.Cells(1).Value
                moveToAvail()
                removeFromSelected()
                fillSelectedGrid()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnProceed_Click(sender As Object, e As EventArgs) Handles btnProceed.Click
        frmRegCourseConfirm.ShowDialog()
    End Sub

    Private Sub dgvSC_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgvSC.RowsAdded
        If dgvSC.RowCount > 0 Then
            btnProceed.Enabled = True
        Else
            btnProceed.Enabled = False
        End If
    End Sub

    Private Sub dgvSC_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgvSC.RowsRemoved
        If dgvSC.RowCount > 0 Then
            btnProceed.Enabled = True
        Else
            btnProceed.Enabled = False
        End If
    End Sub

    Private Sub dgvAC_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgvAC.RowsAdded
        If dgvAC.RowCount > 0 Then
            btnload.Enabled = True
        Else
            btnload.Enabled = False
        End If
    End Sub

    Private Sub dgvAC_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgvAC.RowsRemoved
        If dgvAC.RowCount > 0 Then
            btnload.Enabled = True
        Else
            btnload.Enabled = False
        End If
    End Sub

    Sub viewHistory()
        Dim conCommand As New MySqlCommand
        Dim conReader As MySqlDataReader
        Try
            conCommand = New MySqlCommand("SELECT DISTINCT(academ),sem,level FROM tblregcourses WHERE sid=@sid ORDER BY academ ASC", conDB)
            conCommand.Parameters.AddWithValue("@sid", txtMainID.Text)
            conDB.Close()
            conDB.Open()
            conReader = conCommand.ExecuteReader(CommandBehavior.CloseConnection)
            dgvHistory.Rows.Clear()
            While conReader.Read
                dgvHistory.Rows.Add("View", conReader("academ"), conReader("sem"), conReader("level"))
            End While

            conDB.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conDB.Close()
        Finally
            conDB.Close()
        End Try
    End Sub

    Sub viewDetailsGrid()
        Dim conCommand As New MySqlCommand
        Dim conReader As MySqlDataReader
        Dim conAdapter As New MySqlDataAdapter
        Dim dbtable As New DataTable
        Try
            conCommand = New MySqlCommand("SELECT * FROM tblregcourses WHERE academ=@academ AND sem=@sem AND level=@level AND sid=@sid", conDB)
            With conCommand.Parameters
                With conCommand.Parameters
                    .AddWithValue("@sid", txtMainID.Text)
                    .AddWithValue("@academ", aca)
                    .AddWithValue("@sem", sem)
                    .AddWithValue("@level", level)
                End With
            End With
            conDB.Close()
            conDB.Open()
            conReader = conCommand.ExecuteReader(CommandBehavior.CloseConnection)
            dgvHist.Rows.Clear()
            While conReader.Read
                dgvHist.Rows.Add(conReader("ccode"), conReader("cname"), conReader("cchr"))
            End While

            conDB.Close()
            conDB.Open()
            conCommand.Connection = conDB
            conAdapter.SelectCommand = conCommand
            conAdapter.Fill(dbtable)

            txtAYH.Text = dbtable.Rows(0).Item(5).ToString
            txtSemH.Text = dbtable.Rows(0).Item(6).ToString
            txtLevH.Text = dbtable.Rows(0).Item(7).ToString
            conDB.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conDB.Close()
        Finally
            conDB.Close()
        End Try
    End Sub

    Private Sub dgvHistory_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvHistory.CellContentClick
        Try
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = dgvHistory.Rows(e.RowIndex)
                aca = row.Cells(1).Value
                sem = row.Cells(2).Value
                level = row.Cells(3).Value
                viewDetailsGrid()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class