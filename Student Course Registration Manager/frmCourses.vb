Imports MySql.Data.MySqlClient


Public Class frmCourses

    Dim conCommand, conCommand2 As New MySqlCommand
    Dim conReader As MySqlDataReader
    Dim conAdapter As New MySqlDataAdapter
    Dim picPath As String
    Dim picArr() As Byte

    Dim dset As New DataSet

    Public conDB As New MySqlConnection("database=scremdb; password=1234; port=3306; user id=root; server=localhost")

    Private Sub btnstopSave_Click(sender As Object, e As EventArgs) Handles btnstopSave.Click
        disenable_BTN("btnAdd", "", "", "", False)
        clearthem()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        disenable_BTN("btnStopEdit", "btnUpdate", "btnAdd", "", True)
    End Sub

    Private Sub dgv1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellContentClick
        Try
            clearthem()
            disenable_BTN("btnDelete", "btnEdit", "btnAdd", "", False)
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                'cmbClassAdmit.DataSource = ""
                row = dgv1.Rows(e.RowIndex)
                txtccode.Text = row.Cells(1).Value
                txthcode.Text = row.Cells(1).Value
                viewDetails()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnStopEdit_Click(sender As Object, e As EventArgs) Handles btnStopEdit.Click
        disenable_BTN("btnDelete", "btnEdit", "btnAdd", "", False)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MessageBox.Show("Do you really want to Remove the record?", "Record Removal", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Dim conCommand As New MySqlCommand
            conDB.Close()
            conDB.Open()
            conCommand = New MySqlCommand("DELETE FROM tblcourses WHERE ccode = @ccode", conDB)
            conCommand.Parameters.AddWithValue("@ccode", txtccode.Text)
            conCommand.ExecuteNonQuery()
            fillgrid()
            MessageBox.Show("Record Removed Successfully")
            clearthem()
        End If
    End Sub




    Public Sub viewDetails()
        Dim dbtable, picTable As New DataTable
        Try
            conDB.Close()
            conDB.Open()
            conCommand = New MySqlCommand("SELECT * FROM tblcourses WHERE ccode = @ccode", conDB)

            conCommand.Parameters.AddWithValue("@ccode", txtccode.Text)

            conCommand.Connection = conDB
            conAdapter.SelectCommand = conCommand
            conAdapter.Fill(dbtable)

            txthcode.Text = dbtable.Rows(0).Item(0).ToString
            txtcname.Text = dbtable.Rows(0).Item(1).ToString
            txtCyear.Text = dbtable.Rows(0).Item(2).ToString
            cmbclevel.Text = dbtable.Rows(0).Item(3).ToString
            cmbcsem.Text = dbtable.Rows(0).Item(4)
            txtcchour.Text = dbtable.Rows(0).Item(5)
            cmbdepart.Text = dbtable.Rows(0).Item(6)
            cmbprog.Text = dbtable.Rows(0).Item(7).ToString

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conDB.Close()
        End Try
    End Sub


    Private Sub btnhome_Click(sender As Object, e As EventArgs) Handles btnhome.Click
        Close()
        frmAdminHome.Show()
    End Sub


    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            conCommand = New MySqlCommand("UPDATE tblcourses Set ccode=@ccode,cname=@cname,academ=@academ,clevel=@clevel,csem=@csem,
            cchr=@cchr,depart=@depart,prog=@prog WHERE ccode =@hccode", conDB)
            conDB.Close()
            conDB.Open()
            With conCommand.Parameters
                .AddWithValue("@hccode", txthcode.Text)
                .AddWithValue("@ccode", txtccode.Text)
                .AddWithValue("@cname", txtcname.Text)
                .AddWithValue("@academ", txtCyear.Text)
                .AddWithValue("@clevel", cmbclevel.Text)
                .AddWithValue("@csem", cmbcsem.Text)
                .AddWithValue("@cchr", txtcchour.Text)
                .AddWithValue("@depart", cmbdepart.Text)
                .AddWithValue("@prog", cmbprog.Text)
            End With

            If conCommand.ExecuteNonQuery() Then
                MessageBox.Show("Changes Successfully Made To Record", "Record Update", MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
                fillgrid()
                disenable_BTN("btnDelete", "btnEdit", "btnAdd", "", False)
            Else
                MessageBox.Show("Sorry, Record could Not be Updated", "Record Updating", MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conDB.Close()
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        clearthem()
        disenable_BTN("btnstopSave", "btnSave", "btnClear", "", True)
    End Sub

    Private Sub frmAdminStudInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grpInfo.Enabled = False
    End Sub

    Sub disenable_BTN(btn1 As String, btn2 As String, btn3 As String, btn4 As String, enableGRP As Boolean)
        For Each btn As Control In grpAction.Controls
            If btn.Name IsNot btn1 AndAlso btn.Name IsNot btn2 AndAlso btn.Name IsNot btn3 AndAlso btn.Name IsNot btn4 Then
                btn.Enabled = False
            Else
                btn.Enabled = True
            End If
        Next
        btnLoad.Enabled = True
        grpInfo.Enabled = enableGRP
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        fillgrid()
    End Sub



    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clearthem()
    End Sub

    Sub back2back()
        For Each txt In grpInfo.Controls.OfType(Of TextBox)()
            txt.BackColor = Color.White
        Next
        For Each cmb In grpInfo.Controls.OfType(Of ComboBox)()
            cmb.BackColor = Color.White
        Next
    End Sub

    Public Sub clearthem()
        back2back()
        For Each txt In grpInfo.Controls.OfType(Of TextBox)()
            txt.Text = ""
        Next

        For Each cmb In grpInfo.Controls.OfType(Of ComboBox)()
            cmb.SelectedIndex = -1
        Next
    End Sub

    Sub fillgrid()
        Try
            conDB.Close()
            conDB.Open()
            conCommand = New MySqlCommand("Select ccode,cname,academ FROM tblcourses ", conDB)
            conReader = conCommand.ExecuteReader(CommandBehavior.CloseConnection)
            dgv1.Rows.Clear()
            While conReader.Read
                dgv1.Rows.Add("View", conReader("ccode"), conReader("cname"), conReader("academ"))
            End While

            For i = 0 To dgv1.Rows.Count - 1
                dgv1.Rows(i).Height = 50
            Next
            conDB.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conDB.Close()
        Finally
            conDB.Close()
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim EmptyTxt As Boolean = False

        'Try
        For Each ctl As Control In grpInfo.Controls
                If ctl.Text.Length = 0 And ctl.Tag <> "Middlename" And TypeOf ctl IsNot Button And TypeOf ctl IsNot PictureBox Then
                    ctl.BackColor = Color.DarkRed
                    EmptyTxt = True
                End If
            Next

            If EmptyTxt = True Then
                MessageBox.Show("One or More REQUIRED Field(s) is Empty" & vbCrLf & "Check and Try Again", "The Welfare Manager __________ Saving Error", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error)
            Else
                conDB.Close()
                conDB.Open()
                conCommand = New MySqlCommand("SELECT ccode FROM tblcourses WHERE ccode =@ccode", conDB)
                conCommand.Parameters.AddWithValue("@ccode", txtccode.Text)

                conReader = conCommand.ExecuteReader
            If (conReader.Read() = True) Then
                MessageBox.Show("Course Already Exist" & vbNewLine & "Check Your Entries", "Warning", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning)
            Else
                conCommand = New MySqlCommand("INSERT INTO tblcourses(ccode,cname,academ,clevel,csem,cchr,depart,prog)
                    VALUES(@ccode,@cname,@academ,@clevel,@csem,@cchr,@depart,@prog)", conDB)

                With conCommand.Parameters
                    .AddWithValue("@ccode", txtccode.Text)
                    .AddWithValue("@cname", txtcname.Text)
                        .AddWithValue("@academ", txtCyear.Text)
                        .AddWithValue("@clevel", cmbclevel.Text)
                        .AddWithValue("@csem", cmbcsem.Text)
                        .AddWithValue("@cchr", txtcchour.Text)
                        .AddWithValue("@depart", cmbdepart.Text)
                        .AddWithValue("@prog", cmbprog.Text)
                    End With
                    conDB.Close()
                    conDB.Open()
                    conCommand.ExecuteNonQuery()
                    fillgrid()
                    clearthem()
                MessageBox.Show("Course Added Successfull")
                fillgrid()
                    disenable_BTN("btnAdd", "", "", "", False)
                End If
            End If
        'Catch ex As Exception
        '    If MsgBox(ex.Message) = True Then
        '        MessageBox.Show(ex.InnerException.Message)
        '    End If
        'Finally
        '    conDB.Close()
        'End Try
    End Sub

    Private Sub cmbdepart_DropDown(sender As Object, e As EventArgs) Handles cmbdepart.DropDown
        Dim dbtable As New DataTable
        Try
            conDB.Close()
            conDB.Open()
        conCommand = New MySqlCommand("SELECT DISTINCT(depart) FROM tblprocoursdepart", conDB)
        conReader = conCommand.ExecuteReader(CommandBehavior.CloseConnection)
        cmbdepart.Items.Clear()

        While conReader.Read
            cmbdepart.Items.Add(conReader("depart"))
        End While
        Catch ex As Exception
        MsgBox(ex.Message)
        Finally
        conDB.Close()
        End Try
    End Sub

    Private Sub cmbprog_DropDown(sender As Object, e As EventArgs) Handles cmbprog.DropDown
        Dim dbtable As New DataTable
        Try
            conDB.Close()
            conDB.Open()
            conCommand = New MySqlCommand("SELECT DISTINCT(prog) FROM tblprocoursdepart", conDB)
            conReader = conCommand.ExecuteReader(CommandBehavior.CloseConnection)
            cmbprog.Items.Clear()

            While conReader.Read
                cmbprog.Items.Add(conReader("prog"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conDB.Close()
        End Try
    End Sub

    Private Sub txtCyear_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCyear.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = Convert.ToChar(Keys.Back) Or e.KeyChar = Convert.ToChar(Keys.Tab) Or
             e.KeyChar = Convert.ToChar("/") Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtcchour_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcchour.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = Convert.ToChar(Keys.Back) Or e.KeyChar = Convert.ToChar(Keys.Tab) Or
            e.KeyChar = Convert.ToChar(".") Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btnLogOff_Click(sender As Object, e As EventArgs) Handles btnLogOff.Click
        Hide()
        frmLogin.Show()
    End Sub


End Class