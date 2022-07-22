<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCourseProgDeptmt
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.grpAction = New System.Windows.Forms.GroupBox()
        Me.btnStopEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnstopSave = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.grpInfo = New System.Windows.Forms.GroupBox()
        Me.txtprog = New System.Windows.Forms.TextBox()
        Me.txtdepart = New System.Windows.Forms.TextBox()
        Me.txtcname = New System.Windows.Forms.TextBox()
        Me.txtccode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnhome = New System.Windows.Forms.PictureBox()
        Me.btnLogOff = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txthcode = New System.Windows.Forms.TextBox()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column15 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grpAction.SuspendLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpInfo.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.btnhome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnLogOff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpAction
        '
        Me.grpAction.Controls.Add(Me.btnStopEdit)
        Me.grpAction.Controls.Add(Me.btnDelete)
        Me.grpAction.Controls.Add(Me.btnUpdate)
        Me.grpAction.Controls.Add(Me.btnstopSave)
        Me.grpAction.Controls.Add(Me.btnSave)
        Me.grpAction.Controls.Add(Me.btnEdit)
        Me.grpAction.Controls.Add(Me.btnClear)
        Me.grpAction.Controls.Add(Me.btnAdd)
        Me.grpAction.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpAction.ForeColor = System.Drawing.SystemColors.WindowText
        Me.grpAction.Location = New System.Drawing.Point(380, 61)
        Me.grpAction.Name = "grpAction"
        Me.grpAction.Size = New System.Drawing.Size(289, 102)
        Me.grpAction.TabIndex = 15
        Me.grpAction.TabStop = False
        Me.grpAction.Text = "Actions"
        '
        'btnStopEdit
        '
        Me.btnStopEdit.BackColor = System.Drawing.Color.SeaGreen
        Me.btnStopEdit.Enabled = False
        Me.btnStopEdit.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnStopEdit.FlatAppearance.BorderSize = 2
        Me.btnStopEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnStopEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStopEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStopEdit.ForeColor = System.Drawing.Color.White
        Me.btnStopEdit.Location = New System.Drawing.Point(99, 47)
        Me.btnStopEdit.Name = "btnStopEdit"
        Me.btnStopEdit.Size = New System.Drawing.Size(86, 23)
        Me.btnStopEdit.TabIndex = 6
        Me.btnStopEdit.Text = "Stop Edit"
        Me.btnStopEdit.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.SeaGreen
        Me.btnDelete.Enabled = False
        Me.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnDelete.FlatAppearance.BorderSize = 2
        Me.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(99, 76)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(86, 23)
        Me.btnDelete.TabIndex = 6
        Me.btnDelete.Text = "Remove"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.SeaGreen
        Me.btnUpdate.Enabled = False
        Me.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnUpdate.FlatAppearance.BorderSize = 2
        Me.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(191, 46)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(86, 23)
        Me.btnUpdate.TabIndex = 6
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnstopSave
        '
        Me.btnstopSave.BackColor = System.Drawing.Color.SeaGreen
        Me.btnstopSave.Enabled = False
        Me.btnstopSave.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnstopSave.FlatAppearance.BorderSize = 2
        Me.btnstopSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnstopSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnstopSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnstopSave.ForeColor = System.Drawing.Color.White
        Me.btnstopSave.Location = New System.Drawing.Point(99, 17)
        Me.btnstopSave.Name = "btnstopSave"
        Me.btnstopSave.Size = New System.Drawing.Size(86, 23)
        Me.btnstopSave.TabIndex = 6
        Me.btnstopSave.Text = "Stop Add"
        Me.btnstopSave.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.SeaGreen
        Me.btnSave.Enabled = False
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSave.FlatAppearance.BorderSize = 2
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(191, 17)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(86, 23)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.SeaGreen
        Me.btnEdit.Enabled = False
        Me.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnEdit.FlatAppearance.BorderSize = 2
        Me.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(7, 47)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(86, 23)
        Me.btnEdit.TabIndex = 6
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.SeaGreen
        Me.btnClear.Enabled = False
        Me.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnClear.FlatAppearance.BorderSize = 2
        Me.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(7, 76)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(86, 23)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.SeaGreen
        Me.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnAdd.FlatAppearance.BorderSize = 2
        Me.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(7, 17)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(86, 23)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "Add New"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnLoad
        '
        Me.btnLoad.BackColor = System.Drawing.Color.Moccasin
        Me.btnLoad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoad.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoad.Location = New System.Drawing.Point(507, 188)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(76, 23)
        Me.btnLoad.TabIndex = 6
        Me.btnLoad.Tag = "load"
        Me.btnLoad.Text = "Load List"
        Me.btnLoad.UseVisualStyleBackColor = False
        '
        'dgv1
        '
        Me.dgv1.AllowUserToAddRows = False
        Me.dgv1.AllowUserToDeleteRows = False
        Me.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dgv1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgv1.BackgroundColor = System.Drawing.Color.White
        Me.dgv1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Column15, Me.Column1, Me.Column6, Me.Column14, Me.Column5})
        Me.dgv1.GridColor = System.Drawing.Color.Cornsilk
        Me.dgv1.Location = New System.Drawing.Point(8, 216)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.ReadOnly = True
        Me.dgv1.RowHeadersVisible = False
        Me.dgv1.Size = New System.Drawing.Size(661, 255)
        Me.dgv1.TabIndex = 16
        '
        'grpInfo
        '
        Me.grpInfo.Controls.Add(Me.txtprog)
        Me.grpInfo.Controls.Add(Me.txtdepart)
        Me.grpInfo.Controls.Add(Me.txtcname)
        Me.grpInfo.Controls.Add(Me.txtccode)
        Me.grpInfo.Controls.Add(Me.Label2)
        Me.grpInfo.Controls.Add(Me.Label7)
        Me.grpInfo.Controls.Add(Me.Label8)
        Me.grpInfo.Controls.Add(Me.Label4)
        Me.grpInfo.Enabled = False
        Me.grpInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpInfo.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.grpInfo.Location = New System.Drawing.Point(8, 52)
        Me.grpInfo.Name = "grpInfo"
        Me.grpInfo.Size = New System.Drawing.Size(366, 158)
        Me.grpInfo.TabIndex = 14
        Me.grpInfo.TabStop = False
        Me.grpInfo.Text = "Info"
        '
        'txtprog
        '
        Me.txtprog.Location = New System.Drawing.Point(114, 59)
        Me.txtprog.Name = "txtprog"
        Me.txtprog.Size = New System.Drawing.Size(241, 23)
        Me.txtprog.TabIndex = 2
        '
        'txtdepart
        '
        Me.txtdepart.Location = New System.Drawing.Point(114, 22)
        Me.txtdepart.Name = "txtdepart"
        Me.txtdepart.Size = New System.Drawing.Size(241, 23)
        Me.txtdepart.TabIndex = 2
        '
        'txtcname
        '
        Me.txtcname.Location = New System.Drawing.Point(114, 121)
        Me.txtcname.Name = "txtcname"
        Me.txtcname.Size = New System.Drawing.Size(241, 23)
        Me.txtcname.TabIndex = 2
        '
        'txtccode
        '
        Me.txtccode.Location = New System.Drawing.Point(114, 88)
        Me.txtccode.Name = "txtccode"
        Me.txtccode.Size = New System.Drawing.Size(241, 23)
        Me.txtccode.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkRed
        Me.Label2.Location = New System.Drawing.Point(14, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Course Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkRed
        Me.Label7.Location = New System.Drawing.Point(14, 94)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 17)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Course Code"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkRed
        Me.Label8.Location = New System.Drawing.Point(14, 59)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 17)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Programme"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkRed
        Me.Label4.Location = New System.Drawing.Point(14, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 17)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Department"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Controls.Add(Me.btnhome)
        Me.Panel1.Controls.Add(Me.btnLogOff)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(8, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(661, 39)
        Me.Panel1.TabIndex = 13
        '
        'btnhome
        '
        Me.btnhome.BackColor = System.Drawing.Color.Transparent
        Me.btnhome.BackgroundImage = Global.Student_Course_Registration_Manager.My.Resources.Resources.home3
        Me.btnhome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnhome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnhome.ErrorImage = Global.Student_Course_Registration_Manager.My.Resources.Resources.nopic3
        Me.btnhome.InitialImage = Global.Student_Course_Registration_Manager.My.Resources.Resources.nopic3
        Me.btnhome.Location = New System.Drawing.Point(541, 1)
        Me.btnhome.Name = "btnhome"
        Me.btnhome.Size = New System.Drawing.Size(46, 36)
        Me.btnhome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnhome.TabIndex = 3
        Me.btnhome.TabStop = False
        '
        'btnLogOff
        '
        Me.btnLogOff.BackColor = System.Drawing.Color.Black
        Me.btnLogOff.BackgroundImage = Global.Student_Course_Registration_Manager.My.Resources.Resources.power
        Me.btnLogOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnLogOff.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogOff.ErrorImage = Global.Student_Course_Registration_Manager.My.Resources.Resources.nopic3
        Me.btnLogOff.InitialImage = Global.Student_Course_Registration_Manager.My.Resources.Resources.nopic3
        Me.btnLogOff.Location = New System.Drawing.Point(608, 1)
        Me.btnLogOff.Name = "btnLogOff"
        Me.btnLogOff.Size = New System.Drawing.Size(46, 36)
        Me.btnLogOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnLogOff.TabIndex = 2
        Me.btnLogOff.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(199, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(266, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Course Management"
        '
        'txthcode
        '
        Me.txthcode.Location = New System.Drawing.Point(127, 76)
        Me.txthcode.Name = "txthcode"
        Me.txthcode.Size = New System.Drawing.Size(241, 20)
        Me.txthcode.TabIndex = 17
        '
        'Column2
        '
        Me.Column2.HeaderText = "id"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Visible = False
        Me.Column2.Width = 23
        '
        'Column15
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SaddleBrown
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SandyBrown
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Maroon
        Me.Column15.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column15.HeaderText = "DETAILS"
        Me.Column15.Name = "Column15"
        Me.Column15.ReadOnly = True
        Me.Column15.Width = 65
        '
        'Column1
        '
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column1.HeaderText = "Department"
        Me.Column1.MinimumWidth = 200
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 200
        '
        'Column6
        '
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.Column6.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column6.HeaderText = "Programme"
        Me.Column6.MinimumWidth = 200
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 200
        '
        'Column14
        '
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        Me.Column14.DefaultCellStyle = DataGridViewCellStyle5
        Me.Column14.HeaderText = "Course Code"
        Me.Column14.MinimumWidth = 80
        Me.Column14.Name = "Column14"
        Me.Column14.ReadOnly = True
        Me.Column14.Width = 96
        '
        'Column5
        '
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle6
        Me.Column5.HeaderText = "Course Name"
        Me.Column5.MinimumWidth = 50
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 98
        '
        'frmCourseProgDeptmt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(678, 483)
        Me.ControlBox = False
        Me.Controls.Add(Me.grpAction)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.grpInfo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.txthcode)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmCourseProgDeptmt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCourseProgDeptmt"
        Me.grpAction.ResumeLayout(False)
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpInfo.ResumeLayout(False)
        Me.grpInfo.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.btnhome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnLogOff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpAction As GroupBox
    Friend WithEvents btnStopEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnstopSave As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnLoad As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents dgv1 As DataGridView
    Friend WithEvents grpInfo As GroupBox
    Friend WithEvents txtprog As TextBox
    Friend WithEvents txtdepart As TextBox
    Friend WithEvents txtcname As TextBox
    Friend WithEvents txtccode As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnhome As PictureBox
    Friend WithEvents btnLogOff As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txthcode As TextBox
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column15 As DataGridViewButtonColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column14 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
End Class
