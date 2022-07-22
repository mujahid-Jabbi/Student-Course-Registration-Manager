<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminHome
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbluid = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnCourses = New System.Windows.Forms.Button()
        Me.btnAdminManager = New System.Windows.Forms.Button()
        Me.btnStuInfo = New System.Windows.Forms.Button()
        Me.btnDepart = New System.Windows.Forms.Button()
        Me.btnLogOff = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        CType(Me.btnLogOff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(229, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(306, 46)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Welcome Home"
        '
        'lbluid
        '
        Me.lbluid.AutoSize = True
        Me.lbluid.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbluid.ForeColor = System.Drawing.Color.White
        Me.lbluid.Location = New System.Drawing.Point(332, 87)
        Me.lbluid.Name = "lbluid"
        Me.lbluid.Size = New System.Drawing.Size(133, 31)
        Me.lbluid.TabIndex = 1
        Me.lbluid.Text = "Welcome "
        Me.lbluid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(50, 182)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(600, 2)
        Me.TextBox2.TabIndex = 5
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(50, 350)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(600, 2)
        Me.TextBox1.TabIndex = 5
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(645, 182)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(5, 171)
        Me.TextBox3.TabIndex = 5
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(50, 182)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(5, 171)
        Me.TextBox4.TabIndex = 5
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(255, 181)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(5, 171)
        Me.TextBox5.TabIndex = 5
        '
        'btnCourses
        '
        Me.btnCourses.BackColor = System.Drawing.Color.MediumTurquoise
        Me.btnCourses.BackgroundImage = Global.Student_Course_Registration_Manager.My.Resources.Resources.courses
        Me.btnCourses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCourses.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCourses.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnCourses.FlatAppearance.BorderSize = 5
        Me.btnCourses.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCourses.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCourses.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnCourses.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCourses.Location = New System.Drawing.Point(567, 211)
        Me.btnCourses.Name = "btnCourses"
        Me.btnCourses.Size = New System.Drawing.Size(124, 103)
        Me.btnCourses.TabIndex = 7
        Me.btnCourses.Text = "Course Manager"
        Me.btnCourses.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCourses.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip1.SetToolTip(Me.btnCourses, "Add,View,Edit,Delete  Courses")
        Me.btnCourses.UseVisualStyleBackColor = False
        '
        'btnAdminManager
        '
        Me.btnAdminManager.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btnAdminManager.BackgroundImage = Global.Student_Course_Registration_Manager.My.Resources.Resources.admin3
        Me.btnAdminManager.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAdminManager.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdminManager.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAdminManager.FlatAppearance.BorderSize = 5
        Me.btnAdminManager.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnAdminManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdminManager.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdminManager.ForeColor = System.Drawing.Color.White
        Me.btnAdminManager.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAdminManager.Location = New System.Drawing.Point(382, 211)
        Me.btnAdminManager.Name = "btnAdminManager"
        Me.btnAdminManager.Size = New System.Drawing.Size(124, 103)
        Me.btnAdminManager.TabIndex = 7
        Me.btnAdminManager.Text = "Admin Manager"
        Me.btnAdminManager.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAdminManager.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip1.SetToolTip(Me.btnAdminManager, "Add,View,Edit,Delete Admin Information")
        Me.btnAdminManager.UseVisualStyleBackColor = False
        '
        'btnStuInfo
        '
        Me.btnStuInfo.BackColor = System.Drawing.Color.MediumTurquoise
        Me.btnStuInfo.BackgroundImage = Global.Student_Course_Registration_Manager.My.Resources.Resources.studpic2
        Me.btnStuInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnStuInfo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStuInfo.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnStuInfo.FlatAppearance.BorderSize = 5
        Me.btnStuInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnStuInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStuInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStuInfo.ForeColor = System.Drawing.Color.White
        Me.btnStuInfo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnStuInfo.Location = New System.Drawing.Point(12, 211)
        Me.btnStuInfo.Name = "btnStuInfo"
        Me.btnStuInfo.Size = New System.Drawing.Size(124, 103)
        Me.btnStuInfo.TabIndex = 7
        Me.btnStuInfo.Text = "Student Info"
        Me.btnStuInfo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnStuInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip1.SetToolTip(Me.btnStuInfo, "Add,View,Edit,Delete Student Information")
        Me.btnStuInfo.UseVisualStyleBackColor = False
        '
        'btnDepart
        '
        Me.btnDepart.BackColor = System.Drawing.SystemColors.MenuText
        Me.btnDepart.BackgroundImage = Global.Student_Course_Registration_Manager.My.Resources.Resources.depart
        Me.btnDepart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnDepart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDepart.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnDepart.FlatAppearance.BorderSize = 5
        Me.btnDepart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnDepart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDepart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDepart.ForeColor = System.Drawing.Color.White
        Me.btnDepart.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnDepart.Location = New System.Drawing.Point(197, 211)
        Me.btnDepart.Name = "btnDepart"
        Me.btnDepart.Size = New System.Drawing.Size(124, 103)
        Me.btnDepart.TabIndex = 9
        Me.btnDepart.Text = "Department"
        Me.btnDepart.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDepart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip1.SetToolTip(Me.btnDepart, "Add,View,Edit,Delete Admin Information")
        Me.btnDepart.UseVisualStyleBackColor = False
        '
        'btnLogOff
        '
        Me.btnLogOff.BackColor = System.Drawing.Color.Black
        Me.btnLogOff.BackgroundImage = Global.Student_Course_Registration_Manager.My.Resources.Resources.power
        Me.btnLogOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnLogOff.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogOff.Location = New System.Drawing.Point(658, 3)
        Me.btnLogOff.Name = "btnLogOff"
        Me.btnLogOff.Size = New System.Drawing.Size(46, 36)
        Me.btnLogOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnLogOff.TabIndex = 8
        Me.btnLogOff.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Student_Course_Registration_Manager.My.Resources.Resources.home3
        Me.PictureBox1.Location = New System.Drawing.Point(12, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(124, 115)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(441, 181)
        Me.TextBox6.Multiline = True
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(5, 171)
        Me.TextBox6.TabIndex = 5
        '
        'frmAdminHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(705, 407)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnDepart)
        Me.Controls.Add(Me.btnLogOff)
        Me.Controls.Add(Me.btnCourses)
        Me.Controls.Add(Me.btnAdminManager)
        Me.Controls.Add(Me.btnStuInfo)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.lbluid)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmAdminHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAdminHome"
        CType(Me.btnLogOff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbluid As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents btnStuInfo As Button
    Friend WithEvents btnAdminManager As Button
    Friend WithEvents btnCourses As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents btnLogOff As PictureBox
    Friend WithEvents btnDepart As Button
    Friend WithEvents TextBox6 As TextBox
End Class
