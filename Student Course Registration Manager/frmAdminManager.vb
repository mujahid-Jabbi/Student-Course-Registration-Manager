Imports MySql.Data.MySqlClient


Public Class frmAdminManager

        Dim conCommand, conCommand2 As New MySqlCommand
        Dim conReader As MySqlDataReader
        Dim conAdapter As New MySqlDataAdapter
        Dim picPath As String
        Dim picArr() As Byte

        Dim dset As New DataSet

        Public conDB As New MySqlConnection("database=scremdb; password=1234; port=3306; user id=root; server=localhost")
        Dim bd, bdday, bdmonth, bdyear, dj, djday, djmonth, djyear, fullname, sname, mname, fname As String

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
                    txtID.Text = row.Cells(1).Value
                    txthid.Text = row.Cells(1).Value
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
            frmConfirmDel.pbxPic.Image = pbxPic.Image
            frmConfirmDel.txtID.Text = txtID.Text
            frmConfirmDel.txtFullName.Text = txtFn.Text & "  " & txtMn.Text & "  " & txtSn.Text
            frmConfirmDel.ShowDialog()
        End Sub


    'Public Sub search()
    '    clearthem()
    '    disenable_BTN("btnDelete", "btnEdit", "btnAdd", "", False)
    '    Dim dbtable, picTable As New DataTable
    '    Try
    '        conDB.Close()
    '        conDB.Open()
    '        conCommand = New MySqlCommand("SELECT * FROM tbladmin WHERE sid=@sid OR sname=@sid", conDB)

    '        conCommand.Parameters.AddWithValue("@sid", txtsearch.Text)

    '        conCommand.Connection = conDB
    '        conAdapter.SelectCommand = conCommand
    '        conAdapter.Fill(dbtable)
    '        txtID.Text = dbtable.Rows(0).Item(0).ToString
    '        txthid.Text = dbtable.Rows(0).Item(0).ToString
    '        txtFn.Text = dbtable.Rows(0).Item(1).ToString
    '        txtMn.Text = dbtable.Rows(0).Item(2).ToString
    '        txtSn.Text = dbtable.Rows(0).Item(3).ToString
    '        cmbGend.Text = dbtable.Rows(0).Item(4)
    '        txtbd.Text = dbtable.Rows(0).Item(5)
    '        txtTel.Text = dbtable.Rows(0).Item(6)
    '        'cmbClassAdmit.ValueMember = dbtable.Rows(0).Item(8).ToString
    '        'cmbCurrentClass.ValueMember = dbtable.Rows(0).Item(9).ToString
    '        cmbDA.Text = dbtable.Rows(0).Item(7).ToString
    '        cmbMA.Text = dbtable.Rows(0).Item(8).ToString
    '        cmbYA.Text = dbtable.Rows(0).Item(9).ToString
    '        cmbLA.Text = dbtable.Rows(0).Item(10).ToString
    '        txtCL.Text = dbtable.Rows(0).Item(11).ToString
    '        txtCD.Text = dbtable.Rows(0).Item(12).ToString
    '        cmbProg.Text = dbtable.Rows(0).Item(13).ToString
    '        cmbDep.Text = dbtable.Rows(0).Item(14).ToString

    '        conDB.Close()
    '        conDB.Open()
    '        conCommand = New MySqlCommand("SELECT pic FROM tblpic WHERE sid=@sid", conDB)
    '        conCommand.Parameters.AddWithValue("@sid", txtID.Text)
    '        conCommand.Connection = conDB
    '        conAdapter.SelectCommand = conCommand
    '        conAdapter.Fill(picTable)
    '        Dim arrImage() As Byte
    '        arrImage = picTable.Rows(0).Item(0)
    '        Dim mstream As New System.IO.MemoryStream(arrImage)
    '        pbxPic.Image = Image.FromStream(mstream)
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    Finally
    '        conDB.Close()
    '    End Try
    'End Sub


    Public Sub viewDetails()
            Dim dbtable, picTable As New DataTable
            Try
                conDB.Close()
                conDB.Open()
            conCommand = New MySqlCommand("SELECT * FROM tbladmin WHERE sid = @sid", conDB)

            conCommand.Parameters.AddWithValue("@sid", txtID.Text)

                conCommand.Connection = conDB
                'Dim arrImage() As Byte
                conAdapter.SelectCommand = conCommand
                conAdapter.Fill(dbtable)

                txthid.Text = dbtable.Rows(0).Item(0).ToString
                txtFn.Text = dbtable.Rows(0).Item(1).ToString
                txtMn.Text = dbtable.Rows(0).Item(2).ToString
                txtSn.Text = dbtable.Rows(0).Item(3).ToString
                cmbGend.Text = dbtable.Rows(0).Item(4)
                txtbd.Text = dbtable.Rows(0).Item(5)
                txtTel.Text = dbtable.Rows(0).Item(6)
                'cmbClassAdmit.ValueMember = dbtable.Rows(0).Item(8).ToString
                'cmbCurrentClass.ValueMember = dbtable.Rows(0).Item(9).ToString
                cmbDA.Text = dbtable.Rows(0).Item(7).ToString
                cmbMA.Text = dbtable.Rows(0).Item(8).ToString
                cmbYA.Text = dbtable.Rows(0).Item(9).ToString
                cmbLA.Text = dbtable.Rows(0).Item(10).ToString
                txtCL.Text = dbtable.Rows(0).Item(11).ToString
                txtCD.Text = dbtable.Rows(0).Item(12).ToString
                cmbProg.Text = dbtable.Rows(0).Item(13).ToString
                cmbDep.Text = dbtable.Rows(0).Item(14).ToString

            'conDB.Close()
            'conDB.Open()
            'conCommand = New MySqlCommand("SELECT pic FROM tblpic WHERE sid=@sid", conDB)
            'conCommand.Parameters.AddWithValue("@sid", txtID.Text)
            'conCommand.Connection = conDB
            'conAdapter.SelectCommand = conCommand
            'conAdapter.Fill(picTable)
            'Dim arrImage() As Byte
            'arrImage = picTable.Rows(0).Item(0)
            'Dim mstream As New System.IO.MemoryStream(arrImage)
            'pbxPic.Image = Image.FromStream(mstream)
        Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conDB.Close()
            End Try
        End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    Try
    '        OpenFileDialog1.Filter = "image file (*.jpg, * .jpeg, * .bmp, * .png) | *.jpg; *.jpeg; *.bmp; *.png"
    '        If OpenFileDialog1.ShowDialog <> DialogResult.Cancel Then
    '            pbxPic.Image = Image.FromFile(OpenFileDialog1.FileName)
    '            'txtpicname.Text = OpenFileDialog1.FileName '.Substring(
    '            'OpenFileDialog1.FileName.LastIndexOf("\") + 1,
    '            '(OpenFileDialog1.FileName.IndexOf(".", 0) - (OpenFileDialog1.FileName.LastIndexOf("\") + 1)))
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    'Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    '        pbxPic.Image = My.Resources.picfile
    '    End Sub

    Private Sub btnhome_Click(sender As Object, e As EventArgs) Handles btnhome.Click
        Close()
        frmAdminHome.Show()
    End Sub


    'Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
    '    If txtsearch.Text.Length > 0 Then
    '        btnSearch.Enabled = True
    '    Else
    '        btnSearch.Enabled = False
    '    End If
    'End Sub

    'Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
    '    search()
    'End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
            Try

            'Dim mstream As New System.IO.MemoryStream()
            'Dim bmpimage As New Bitmap(pbxPic.Image)
            'bmpimage.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            'Dim picData As Byte() = mstream.GetBuffer()

            conCommand = New MySqlCommand("UPDATE tbladmin Set sid=@sid,fname=fname,mname=@mname,sname=@sname,gend=@gend,
            dob=@dob,tel=@tel,dad=@dad,dam=@dam,day=@day,la=@la,cl=@cl,cd=@cd,course=@course,depart=@depart WHERE sid =@hid", conDB)
            conDB.Close()
                conDB.Open()
                With conCommand.Parameters
                    .AddWithValue("@hid", txthid.Text)
                    .AddWithValue("@sid", txtID.Text)
                    .AddWithValue("@fname", txtFn.Text)
                    .AddWithValue("@mname", txtMn.Text)
                    .AddWithValue("@sname", txtSn.Text)
                    .AddWithValue("@gend", cmbGend.Text)
                    .AddWithValue("@dob", txtbd.Text)
                    .AddWithValue("@tel", txtTel.Text)
                    .AddWithValue("@dad", cmbDA.Text)
                    .AddWithValue("@dam", cmbMA.Text)
                    .AddWithValue("@day", cmbYA.Text)
                    .AddWithValue("@la", cmbLA.Text)
                    .AddWithValue("@cl", txtCL.Text)
                    .AddWithValue("@cd", txtCD.Text)
                    .AddWithValue("@course", cmbProg.Text)
                    .AddWithValue("@depart", cmbDep.Text)
                End With

                If conCommand.ExecuteNonQuery() Then

                'Dim mstream As New System.IO.MemoryStream()
                'Dim bmpimage As New Bitmap(pbxPic.Image)
                'bmpimage.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                'Dim picData As Byte() = mstream.GetBuffer()

                'conDB.Close()
                'conDB.Open()
                'conCommand2 = New MySqlCommand("UPDATE tblpic SET pic=@pic WHERE sid =@sid", conDB)
                'With conCommand2.Parameters
                '    '.AddWithValue("@hid", txthid.Text)
                '    .AddWithValue("@sid", txtID.Text)
                '    .AddWithValue("@pic", picData)
                'End With
                'conCommand2.ExecuteNonQuery()

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

        Private Sub dtpBD_ValueChanged(sender As Object, e As EventArgs) Handles dtpBD.ValueChanged
            txtbd.Text = dtpBD.Text
        End Sub

        Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
            clearthem()
        End Sub

        Sub back2back()
            dtpBD.Value = "1/01/1950"
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
                cmb.ResetText()
            Next


            pbxPic.Image = My.Resources.picfile
        End Sub

        Sub fillgrid()
            Try
                conDB.Close()
                conDB.Open()
            conCommand = New MySqlCommand("Select sid,fname,mname,sname,gend,cl FROM tbladmin WHERE sname <> 'n/a'", conDB)
            conReader = conCommand.ExecuteReader(CommandBehavior.CloseConnection)
                dgv1.Rows.Clear()
                While conReader.Read
                    sname = conReader("sname")
                    mname = conReader("mname")
                    fname = conReader("fname")
                    fullname = fname & " " & mname & " " & sname

                    dgv1.Rows.Add("View", conReader("sid"), fullname, conReader("gend"), bd, conReader("cl"))
                End While

                For i = 0 To dgv1.Rows.Count - 1
                    dgv1.Rows(i).Height = 50
                Next
                conDB.Close()

                'countMembers()

            Catch ex As Exception
                MsgBox(ex.Message)
                conDB.Close()
            Finally
                conDB.Close()
            End Try
        End Sub

        Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
            Dim EmptyTxt As Boolean = False

            Try
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
                conCommand = New MySqlCommand("SELECT sid,sname FROM tbladmin WHERE sid =@sid AND sname = @sname ", conDB)
                conCommand.Parameters.AddWithValue("@sid", txtID.Text)
                    conCommand.Parameters.AddWithValue("@sname", lablel.Text)

                    conReader = conCommand.ExecuteReader
                    If (conReader.Read() = True) Then
                        MessageBox.Show("Member Already Exist" & vbNewLine & "Check Your Entries", "Warning", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning)
                    Else
                        conDB.Close()
                        conDB.Open()

                    conCommand = New MySqlCommand("INSERT INTO tbladmin(sid,fname,mname,sname,gend,dob,tel,dad,dam,day,la,cl,cd,course,depart)
                    VALUES(@sid,@fname,@mname,@sname,@gend,@dob,@tel,@dad,@dam,@day,@la,@cl,@cd,@course,@depart)", conDB)

                    With conCommand.Parameters
                        .AddWithValue("@sid", txtID.Text)
                        .AddWithValue("@fname", txtFn.Text)
                        .AddWithValue("@mname", txtMn.Text)
                        .AddWithValue("@sname", txtSn.Text)
                        .AddWithValue("@gend", cmbGend.Text)
                        .AddWithValue("@dob", txtbd.Text)
                        .AddWithValue("@tel", txtTel.Text)
                        .AddWithValue("@dad", cmbDA.Text)
                        .AddWithValue("@dam", cmbMA.Text)
                        .AddWithValue("@day", cmbYA.Text)
                        .AddWithValue("@la", cmbLA.Text)
                        .AddWithValue("@cl", txtCL.Text)
                        .AddWithValue("@cd", txtCD.Text)
                        .AddWithValue("@course", cmbProg.Text)
                        .AddWithValue("@depart", cmbDep.Text)
                    End With
                    conDB.Close()
                        conDB.Open()
                        conCommand.ExecuteNonQuery()


                    'conDB.Close()
                    'conDB.Open()
                    'conCommand = New MySqlCommand("INSERT INTO tblpic(sid,pic) VALUES(@sid,@pic)", conDB)
                    'Dim mstream As New System.IO.MemoryStream()
                    'Dim bmpimage As New Bitmap(pbxPic.Image)
                    'bmpimage.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                    'Dim picData As Byte() = mstream.GetBuffer()
                    'With conCommand.Parameters
                    '    .AddWithValue("@sid", txtID.Text)
                    '    .AddWithValue("@pic", picData)
                    'End With
                    'conCommand.ExecuteNonQuery()

                    fillgrid()
                        clearthem()
                        MessageBox.Show("Data Saved Successfull")
                        fillgrid()
                        disenable_BTN("btnAdd", "", "", "", False)
                    End If
                End If
            Catch ex As Exception
                If MsgBox(ex.Message) = True Then
                    MessageBox.Show(ex.InnerException.Message)
                End If
            Finally
                conDB.Close()
            End Try
        End Sub

        Private Sub btnLogOff_Click(sender As Object, e As EventArgs) Handles btnLogOff.Click
            Hide()
            frmLogin.Show()
        End Sub


End Class