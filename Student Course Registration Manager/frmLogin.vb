
Imports System.Data.Mysql
Imports System.IO
Imports System.Management
Imports MySql.Data.MySqlClient

Public Class frmLogin
    Public conDB As New MySqlConnection("database=scremdb; password=1234; port=3306; user id=root; server=localhost")
    Dim conCommand As MySqlCommand
    Dim conReader As MySqlDataReader
    Dim da As New MySqlDataAdapter
    Dim dbtable As New DataTable


    Public Sub login_clear()
        Try
            cmbUType.Text = "---Click to Select---"
            txtUID.Clear()
            txtPword.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Sub studLogin()

        conDB.Close()
        conDB.Open()
        conCommand = New MySqlCommand("SELECT * FROM tblstudlogin WHERE uid =@uid AND pword = @pword AND utype=@utype", conDB)
        conCommand.Parameters.AddWithValue("@uid", txtUID.Text)
        conCommand.Parameters.AddWithValue("@pword", txtPword.Text)
        conCommand.Parameters.AddWithValue("@utype", cmbUType.Text)


        conReader = conCommand.ExecuteReader
        If (conReader.Read() = True) Then
            frmStudInfo.Show()
            frmStudInfo.txtMainID.Text = txtUID.Text
            login_clear()
            Hide()
        Else
            MessageBox.Show("Invalid username or password!")
            conDB.Close()
        End If
    End Sub

    Sub adminLogin()

        conDB.Close()
        conDB.Open()
        conCommand = New MySqlCommand("SELECT * FROM tbladminlogin WHERE uid =@uid AND pword = @pword AND utype=@utype", conDB)
        conCommand.Parameters.AddWithValue("@uid", txtUID.Text)
        conCommand.Parameters.AddWithValue("@pword", txtPword.Text)
        conCommand.Parameters.AddWithValue("@utype", cmbUType.Text)


        conReader = conCommand.ExecuteReader
        If (conReader.Read() = True) Then
            frmAdminHome.Show()
            frmAdminHome.lbluid.Text = txtUID.Text
            login_clear()
            Hide()
        Else
            MessageBox.Show("Invalid username or password!")
            conDB.Close()
        End If
    End Sub


    Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnExit.Click, PictureBox1.Click
        Dispose()
        Application.Exit()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            If txtUID.Text.Length = 0 Or txtPword.Text.Length = 0 Or cmbUType.SelectedIndex = -1 Or
                cmbUType.Text = "---Click To Select---" Then
                MsgBox("Account Type / UserName or Password is Required")
            Else
                If cmbUType.Text = "Admin/Lecturer" Then
                    adminLogin()
                ElseIf cmbUType.Text = "Student"
                    studLogin()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbUType.SelectedIndex = 1
    End Sub

    Private Sub lblcreate_Click(sender As Object, e As EventArgs) Handles lblcreate.Click
        frmSignUp.Show()
        Close()
    End Sub
End Class