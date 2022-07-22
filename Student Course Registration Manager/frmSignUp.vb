Imports MySql.Data.MySqlClient

Public Class frmSignUp

    Public conDB As New MySqlConnection("database=scremdb; password=1234; port=3306; user id=root; server=localhost")
    Dim conCommand As MySqlCommand
    Dim conReader As MySqlDataReader
    Dim da As New MySqlDataAdapter
    Dim dbtable As New DataTable


    Public Sub login_clear()
        cmbUType.SelectedIndex = 1
        txtUID.Clear()
        txtPword.Clear()
    End Sub

    Sub adminSignUP()
        conDB.Close()
        conDB.Open()
        conCommand = New MySqlCommand("SELECT * FROM tbladminlogin WHERE uid =@uid", conDB)
        conCommand.Parameters.AddWithValue("@uid", txtUID.Text)
        'conCommand.Parameters.AddWithValue("@pword", txtPword.Text)
        'conCommand.Parameters.AddWithValue("@utype", cmbUType.Text)


        conReader = conCommand.ExecuteReader
        If (conReader.Read() = True) Then
            MessageBox.Show("Sorry, User " & txtUID.Text & "is Already Signed Up" & vbNewLine & "Review Your Entries or Login")
        Else
            conDB.Close()
            conDB.Open()
            conCommand = New MySqlCommand("SELECT sid FROM tbladmin WHERE sid =@sid", conDB)
            conCommand.Parameters.AddWithValue("@sid", txtUID.Text)
            conReader = conCommand.ExecuteReader
            If (conReader.Read() = True) Then
                conDB.Close()
                conCommand = New MySqlCommand("INSERT INTO tbladminlogin(uid,utype,pword) VALUES(@uid,@utype,@pword)", conDB)

                With conCommand.Parameters
                    .AddWithValue("@uid", txtUID.Text)
                    .AddWithValue("@utype", cmbUType.Text)
                    .AddWithValue("@pword", txtPword.Text)
                End With
                conDB.Close()
                conDB.Open()
                conCommand.ExecuteNonQuery()
                MessageBox.Show("Account Created, Successfull" & vbNewLine & "Login to Access your Account")
                login_clear()
                frmLogin.Show()
                Close()
            Else
                MessageBox.Show("Sorry, User " & txtUID.Text & "  Does Not Exist" & vbNewLine & "Review Your Entries and Retry")
            End If
        End If
    End Sub


    Sub studSignUP()
        conDB.Close()
        conDB.Open()
        conCommand = New MySqlCommand("SELECT * FROM tblstudlogin WHERE uid =@uid", conDB)
        conCommand.Parameters.AddWithValue("@uid", txtUID.Text)
        'conCommand.Parameters.AddWithValue("@pword", txtPword.Text)
        'conCommand.Parameters.AddWithValue("@utype", cmbUType.Text)


        conReader = conCommand.ExecuteReader
        If (conReader.Read() = True) Then
            MessageBox.Show("Sorry, User " & txtUID.Text & "is Already Signed Up" & vbNewLine & "Review Your Entries or Login")
        Else
            conDB.Close()
            conDB.Open()
            conCommand = New MySqlCommand("SELECT sid FROM tblstudinfo WHERE sid =@sid", conDB)
            conCommand.Parameters.AddWithValue("@sid", txtUID.Text)
            conReader = conCommand.ExecuteReader
            If (conReader.Read() = True) Then
                conDB.Close()
                conCommand = New MySqlCommand("INSERT INTO tblstudlogin(uid,utype,pword) VALUES(@uid,@utype,@pword)", conDB)

                With conCommand.Parameters
                    .AddWithValue("@uid", txtUID.Text)
                    .AddWithValue("@utype", cmbUType.Text)
                    .AddWithValue("@pword", txtPword.Text)
                End With
                conDB.Close()
                conDB.Open()
                conCommand.ExecuteNonQuery()
                MessageBox.Show("Account Created, Successfull" & vbNewLine & "Login to Access your Account")
                login_clear()
                frmLogin.Show()
                Close()
            Else
                MessageBox.Show("Sorry, User " & txtUID.Text & "  Does Not Exist" & vbNewLine & "Review Your Entries and Retry")
            End If
        End If
    End Sub


    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        frmLogin.Show()
        Close()
    End Sub


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub frmSignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbUType.SelectedIndex = 1
    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        Try
            If txtUID.Text.Length = 0 Or txtPword.Text.Length = 0 Or cmbUType.SelectedIndex = -1 Or
                cmbUType.Text = "" Then
                MsgBox("Account Type / UserName or Password is Required")
            Else
                If cmbUType.Text = "Student" Then
                    studSignUP()
                ElseIf cmbUType.Text = "Admin/Lecturer"
                    adminSignUP()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtPword_TextChanged(sender As Object, e As EventArgs) Handles txtPword.TextChanged, txtrepeat.TextChanged
        If txtPword.Text <> txtrepeat.Text Then
            btnSignUp.Enabled = False
            lblmis.Visible = True
        Else
            btnSignUp.Enabled = True
            lblmis.Visible = False
        End If
    End Sub
End Class