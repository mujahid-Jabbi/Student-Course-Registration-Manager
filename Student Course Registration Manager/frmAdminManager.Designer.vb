<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminManager
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
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.Column15 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grpAction = New System.Windows.Forms.GroupBox()
        Me.btnStopEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnstopSave = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.grpInfo = New System.Windows.Forms.GroupBox()
        Me.txtbd = New System.Windows.Forms.TextBox()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dtpBD = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbDep = New System.Windows.Forms.ComboBox()
        Me.cmbDA = New System.Windows.Forms.ComboBox()
        Me.cmbMA = New System.Windows.Forms.ComboBox()
        Me.cmbYA = New System.Windows.Forms.ComboBox()
        Me.cmbLA = New System.Windows.Forms.ComboBox()
        Me.cmbProg = New System.Windows.Forms.ComboBox()
        Me.cmbGend = New System.Windows.Forms.ComboBox()
        Me.txtSn = New System.Windows.Forms.TextBox()
        Me.txtCL = New System.Windows.Forms.TextBox()
        Me.txtCD = New System.Windows.Forms.TextBox()
        Me.txtMn = New System.Windows.Forms.TextBox()
        Me.txtFn = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lablel = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pbxPic = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnhome = New System.Windows.Forms.PictureBox()
        Me.btnLogOff = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txthid = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpAction.SuspendLayout()
        Me.grpInfo.SuspendLayout()
        CType(Me.pbxPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.btnhome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnLogOff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv1
        '
        Me.dgv1.AllowUserToAddRows = False
        Me.dgv1.AllowUserToDeleteRows = False
        Me.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dgv1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgv1.BackgroundColor = System.Drawing.Color.SlateGray
        Me.dgv1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column15, Me.Column14, Me.Column2, Me.Column5, Me.Column6})
        Me.dgv1.GridColor = System.Drawing.Color.Cornsilk
        Me.dgv1.Location = New System.Drawing.Point(501, 59)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.ReadOnly = True
        Me.dgv1.RowHeadersVisible = False
        Me.dgv1.Size = New System.Drawing.Size(317, 215)
        Me.dgv1.TabIndex = 8
        '
        'Column15
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.SaddleBrown
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.SandyBrown
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Maroon
        Me.Column15.DefaultCellStyle = DataGridViewCellStyle11
        Me.Column15.HeaderText = "DETAILS"
        Me.Column15.Name = "Column15"
        Me.Column15.ReadOnly = True
        Me.Column15.Width = 65
        '
        'Column14
        '
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column14.DefaultCellStyle = DataGridViewCellStyle12
        Me.Column14.HeaderText = "ID"
        Me.Column14.MinimumWidth = 80
        Me.Column14.Name = "Column14"
        Me.Column14.ReadOnly = True
        Me.Column14.Width = 80
        '
        'Column2
        '
        Me.Column2.HeaderText = "FULLNAME"
        Me.Column2.MinimumWidth = 200
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 200
        '
        'Column5
        '
        Me.Column5.HeaderText = "GENDER"
        Me.Column5.MinimumWidth = 50
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 84
        '
        'Column6
        '
        Me.Column6.HeaderText = "LEVEL"
        Me.Column6.MinimumWidth = 100
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'grpAction
        '
        Me.grpAction.Controls.Add(Me.btnStopEdit)
        Me.grpAction.Controls.Add(Me.btnDelete)
        Me.grpAction.Controls.Add(Me.btnUpdate)
        Me.grpAction.Controls.Add(Me.btnstopSave)
        Me.grpAction.Controls.Add(Me.btnSave)
        Me.grpAction.Controls.Add(Me.btnEdit)
        Me.grpAction.Controls.Add(Me.btnLoad)
        Me.grpAction.Controls.Add(Me.btnClear)
        Me.grpAction.Controls.Add(Me.btnAdd)
        Me.grpAction.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpAction.ForeColor = System.Drawing.Color.White
        Me.grpAction.Location = New System.Drawing.Point(3, 280)
        Me.grpAction.Name = "grpAction"
        Me.grpAction.Size = New System.Drawing.Size(815, 85)
        Me.grpAction.TabIndex = 7
        Me.grpAction.TabStop = False
        Me.grpAction.Text = "Actions"
        '
        'btnStopEdit
        '
        Me.btnStopEdit.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnStopEdit.Enabled = False
        Me.btnStopEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnStopEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStopEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStopEdit.Location = New System.Drawing.Point(7, 50)
        Me.btnStopEdit.Name = "btnStopEdit"
        Me.btnStopEdit.Size = New System.Drawing.Size(86, 23)
        Me.btnStopEdit.TabIndex = 6
        Me.btnStopEdit.Text = "Stop Edit"
        Me.btnStopEdit.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnDelete.Enabled = False
        Me.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(255, 50)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(86, 23)
        Me.btnDelete.TabIndex = 6
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnUpdate.Enabled = False
        Me.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(131, 50)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(86, 23)
        Me.btnUpdate.TabIndex = 6
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnstopSave
        '
        Me.btnstopSave.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnstopSave.Enabled = False
        Me.btnstopSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnstopSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnstopSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnstopSave.Location = New System.Drawing.Point(131, 17)
        Me.btnstopSave.Name = "btnstopSave"
        Me.btnstopSave.Size = New System.Drawing.Size(86, 23)
        Me.btnstopSave.TabIndex = 6
        Me.btnstopSave.Text = "Stop Add"
        Me.btnstopSave.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnSave.Enabled = False
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(255, 17)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(86, 23)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnEdit.Enabled = False
        Me.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(379, 17)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(86, 23)
        Me.btnEdit.TabIndex = 6
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnLoad
        '
        Me.btnLoad.BackColor = System.Drawing.Color.Transparent
        Me.btnLoad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoad.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoad.Location = New System.Drawing.Point(717, 10)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(76, 23)
        Me.btnLoad.TabIndex = 6
        Me.btnLoad.Tag = "load"
        Me.btnLoad.Text = "Load List"
        Me.btnLoad.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnClear.Enabled = False
        Me.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(379, 50)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(86, 23)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(7, 17)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(86, 23)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "Add New"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'grpInfo
        '
        Me.grpInfo.Controls.Add(Me.cmbGend)
        Me.grpInfo.Controls.Add(Me.txtFn)
        Me.grpInfo.Controls.Add(Me.txtbd)
        Me.grpInfo.Controls.Add(Me.txtTel)
        Me.grpInfo.Controls.Add(Me.Button2)
        Me.grpInfo.Controls.Add(Me.Button1)
        Me.grpInfo.Controls.Add(Me.dtpBD)
        Me.grpInfo.Controls.Add(Me.Label14)
        Me.grpInfo.Controls.Add(Me.Label13)
        Me.grpInfo.Controls.Add(Me.Label12)
        Me.grpInfo.Controls.Add(Me.Label11)
        Me.grpInfo.Controls.Add(Me.Label10)
        Me.grpInfo.Controls.Add(Me.Label9)
        Me.grpInfo.Controls.Add(Me.cmbDep)
        Me.grpInfo.Controls.Add(Me.cmbDA)
        Me.grpInfo.Controls.Add(Me.cmbMA)
        Me.grpInfo.Controls.Add(Me.cmbYA)
        Me.grpInfo.Controls.Add(Me.cmbLA)
        Me.grpInfo.Controls.Add(Me.cmbProg)
        Me.grpInfo.Controls.Add(Me.txtSn)
        Me.grpInfo.Controls.Add(Me.txtCL)
        Me.grpInfo.Controls.Add(Me.txtCD)
        Me.grpInfo.Controls.Add(Me.txtMn)
        Me.grpInfo.Controls.Add(Me.txtID)
        Me.grpInfo.Controls.Add(Me.Label8)
        Me.grpInfo.Controls.Add(Me.Label7)
        Me.grpInfo.Controls.Add(Me.Label15)
        Me.grpInfo.Controls.Add(Me.Label6)
        Me.grpInfo.Controls.Add(Me.Label3)
        Me.grpInfo.Controls.Add(Me.lablel)
        Me.grpInfo.Controls.Add(Me.Label17)
        Me.grpInfo.Controls.Add(Me.Label16)
        Me.grpInfo.Controls.Add(Me.Label4)
        Me.grpInfo.Controls.Add(Me.Label5)
        Me.grpInfo.Controls.Add(Me.Label2)
        Me.grpInfo.Controls.Add(Me.pbxPic)
        Me.grpInfo.Enabled = False
        Me.grpInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpInfo.ForeColor = System.Drawing.Color.White
        Me.grpInfo.Location = New System.Drawing.Point(3, 50)
        Me.grpInfo.Name = "grpInfo"
        Me.grpInfo.Size = New System.Drawing.Size(472, 224)
        Me.grpInfo.TabIndex = 6
        Me.grpInfo.TabStop = False
        Me.grpInfo.Text = "Info"
        '
        'txtbd
        '
        Me.txtbd.BackColor = System.Drawing.Color.White
        Me.txtbd.Location = New System.Drawing.Point(248, 160)
        Me.txtbd.Name = "txtbd"
        Me.txtbd.ReadOnly = True
        Me.txtbd.Size = New System.Drawing.Size(123, 23)
        Me.txtbd.TabIndex = 8
        '
        'txtTel
        '
        Me.txtTel.Location = New System.Drawing.Point(202, 193)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(196, 23)
        Me.txtTel.TabIndex = 7
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(15, 142)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(86, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "- Remove"
        Me.Button2.UseVisualStyleBackColor = False
        Me.Button2.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(15, 118)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "+Add Pic"
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'dtpBD
        '
        Me.dtpBD.CalendarMonthBackground = System.Drawing.Color.Turquoise
        Me.dtpBD.CalendarTitleBackColor = System.Drawing.Color.MediumSpringGreen
        Me.dtpBD.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpBD.Location = New System.Drawing.Point(249, 160)
        Me.dtpBD.Name = "dtpBD"
        Me.dtpBD.Size = New System.Drawing.Size(149, 23)
        Me.dtpBD.TabIndex = 5
        Me.dtpBD.Value = New Date(1950, 1, 1, 0, 0, 0, 0)
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(7, 398)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(82, 17)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Department"
        '
        'Label13
        '
        Me.Label13.AutoEllipsis = True
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(7, 346)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 34)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Course/" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Program"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(276, 240)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 34)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Level " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Admitted"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(7, 288)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 34)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Current" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Level"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(261, 285)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 34)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Completion" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Date"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(7, 239)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 34)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Date" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Admitted"
        '
        'cmbDep
        '
        Me.cmbDep.BackColor = System.Drawing.Color.White
        Me.cmbDep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDep.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbDep.FormattingEnabled = True
        Me.cmbDep.Items.AddRange(New Object() {"", "Male", "Female"})
        Me.cmbDep.Location = New System.Drawing.Point(104, 395)
        Me.cmbDep.Name = "cmbDep"
        Me.cmbDep.Size = New System.Drawing.Size(361, 24)
        Me.cmbDep.TabIndex = 3
        '
        'cmbDA
        '
        Me.cmbDA.BackColor = System.Drawing.Color.White
        Me.cmbDA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbDA.FormattingEnabled = True
        Me.cmbDA.Items.AddRange(New Object() {"", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.cmbDA.Location = New System.Drawing.Point(83, 245)
        Me.cmbDA.Name = "cmbDA"
        Me.cmbDA.Size = New System.Drawing.Size(38, 24)
        Me.cmbDA.TabIndex = 3
        '
        'cmbMA
        '
        Me.cmbMA.BackColor = System.Drawing.Color.White
        Me.cmbMA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbMA.FormattingEnabled = True
        Me.cmbMA.Items.AddRange(New Object() {"", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cmbMA.Location = New System.Drawing.Point(120, 245)
        Me.cmbMA.Name = "cmbMA"
        Me.cmbMA.Size = New System.Drawing.Size(68, 24)
        Me.cmbMA.TabIndex = 3
        '
        'cmbYA
        '
        Me.cmbYA.BackColor = System.Drawing.Color.White
        Me.cmbYA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbYA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbYA.FormattingEnabled = True
        Me.cmbYA.Items.AddRange(New Object() {"", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030", "2031", "2032", "2033", "2034", "2035", "2036", "2037", "2038", "2039", "2040", "2041", "2042", "2043", "2044", "2045", "2046", "2047", "2048", "2049", "2050", "2051", "2052", "2053", "2054", "2055", "2056", "2057", "2058", "2059", "2060", "2061", "2062", "2063", "2064", "2065", "2066", "2067", "2068", "2069", "2070", "2071", "2072", "2073", "2074", "2075", "2076", "2077", "2078", "2079", "2080", "2081", "2082", "2083", "2084", "2085", "2086", "2087", "2088", "2089", "2090", "2091", "2092", "2093", "2094", "2095", "2096", "2097", "2098", "2099", "2100", "2101", "2102", "2103", "2104", "2105", "2106", "2107", "2108", "2109", "2110", "2111", "2112", "2113", "2114", "2115", "2116", "2117", "2118", "2119", "2120", "2121", "2122", "2123", "2124", "2125", "2126", "2127", "2128", "2129", "2130", "2131", "2132", "2133", "2134", "2135", "2136", "2137", "2138", "2139", "2140", "2141", "2142", "2143", "2144", "2145", "2146", "2147", "2148", "2149", "2150", "2151", "2152", "2153", "2154", "2155", "2156", "2157", "2158", "2159", "2160", "2161", "2162", "2163", "2164", "2165", "2166", "2167", "2168", "2169", "2170", "2171", "2172", "2173", "2174", "2175", "2176", "2177", "2178"})
        Me.cmbYA.Location = New System.Drawing.Point(185, 245)
        Me.cmbYA.Name = "cmbYA"
        Me.cmbYA.Size = New System.Drawing.Size(60, 24)
        Me.cmbYA.TabIndex = 3
        '
        'cmbLA
        '
        Me.cmbLA.BackColor = System.Drawing.Color.White
        Me.cmbLA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbLA.FormattingEnabled = True
        Me.cmbLA.Items.AddRange(New Object() {"", "Level 100", "Level 200", "Level 300", "Level 400", "Level 500", "Level 600", "Level 700", "Level 800"})
        Me.cmbLA.Location = New System.Drawing.Point(337, 245)
        Me.cmbLA.Name = "cmbLA"
        Me.cmbLA.Size = New System.Drawing.Size(128, 24)
        Me.cmbLA.TabIndex = 3
        '
        'cmbProg
        '
        Me.cmbProg.BackColor = System.Drawing.Color.White
        Me.cmbProg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbProg.FormattingEnabled = True
        Me.cmbProg.Items.AddRange(New Object() {"", "Male", "Female"})
        Me.cmbProg.Location = New System.Drawing.Point(83, 346)
        Me.cmbProg.Name = "cmbProg"
        Me.cmbProg.Size = New System.Drawing.Size(382, 24)
        Me.cmbProg.TabIndex = 3
        '
        'cmbGend
        '
        Me.cmbGend.BackColor = System.Drawing.Color.White
        Me.cmbGend.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGend.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbGend.FormattingEnabled = True
        Me.cmbGend.Items.AddRange(New Object() {"", "Male", "Female"})
        Me.cmbGend.Location = New System.Drawing.Point(66, 162)
        Me.cmbGend.Name = "cmbGend"
        Me.cmbGend.Size = New System.Drawing.Size(136, 24)
        Me.cmbGend.TabIndex = 3
        '
        'txtSn
        '
        Me.txtSn.Location = New System.Drawing.Point(288, 113)
        Me.txtSn.Name = "txtSn"
        Me.txtSn.Size = New System.Drawing.Size(110, 23)
        Me.txtSn.TabIndex = 2
        '
        'txtCL
        '
        Me.txtCL.Location = New System.Drawing.Point(83, 292)
        Me.txtCL.Name = "txtCL"
        Me.txtCL.Size = New System.Drawing.Size(162, 23)
        Me.txtCL.TabIndex = 2
        '
        'txtCD
        '
        Me.txtCD.Location = New System.Drawing.Point(337, 292)
        Me.txtCD.Name = "txtCD"
        Me.txtCD.Size = New System.Drawing.Size(128, 23)
        Me.txtCD.TabIndex = 2
        '
        'txtMn
        '
        Me.txtMn.Location = New System.Drawing.Point(177, 113)
        Me.txtMn.Name = "txtMn"
        Me.txtMn.Size = New System.Drawing.Size(110, 23)
        Me.txtMn.TabIndex = 2
        Me.txtMn.Tag = "Middlename"
        '
        'txtFn
        '
        Me.txtFn.Location = New System.Drawing.Point(66, 113)
        Me.txtFn.Name = "txtFn"
        Me.txtFn.Size = New System.Drawing.Size(110, 23)
        Me.txtFn.TabIndex = 2
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(114, 43)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(234, 23)
        Me.txtID.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(290, 146)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 17)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Birth Date"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(182, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(125, 17)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Admin /Lecturer ID"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(102, 198)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(76, 17)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "Telephone"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(114, 146)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 17)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Gender"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(90, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(283, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "                          FullName                            "
        '
        'lablel
        '
        Me.lablel.AutoSize = True
        Me.lablel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablel.ForeColor = System.Drawing.Color.Black
        Me.lablel.Location = New System.Drawing.Point(314, 99)
        Me.lablel.Name = "lablel"
        Me.lablel.Size = New System.Drawing.Size(49, 13)
        Me.lablel.TabIndex = 1
        Me.lablel.Text = "Surname"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(197, 233)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(35, 13)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "YYYY"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(146, 233)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(25, 13)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "MM"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(93, 233)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "DD"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(96, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "FirstName"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(199, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "MiddleName"
        '
        'pbxPic
        '
        Me.pbxPic.BackgroundImage = Global.Student_Course_Registration_Manager.My.Resources.Resources.picfile
        Me.pbxPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbxPic.ErrorImage = Global.Student_Course_Registration_Manager.My.Resources.Resources.picfile
        Me.pbxPic.InitialImage = Global.Student_Course_Registration_Manager.My.Resources.Resources.picfile
        Me.pbxPic.Location = New System.Drawing.Point(10, 23)
        Me.pbxPic.Name = "pbxPic"
        Me.pbxPic.Size = New System.Drawing.Size(100, 93)
        Me.pbxPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxPic.TabIndex = 0
        Me.pbxPic.TabStop = False
        Me.pbxPic.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Controls.Add(Me.btnhome)
        Me.Panel1.Controls.Add(Me.btnLogOff)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(815, 39)
        Me.Panel1.TabIndex = 5
        '
        'btnhome
        '
        Me.btnhome.BackColor = System.Drawing.Color.Transparent
        Me.btnhome.BackgroundImage = Global.Student_Course_Registration_Manager.My.Resources.Resources.home3
        Me.btnhome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnhome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnhome.ErrorImage = Global.Student_Course_Registration_Manager.My.Resources.Resources.nopic3
        Me.btnhome.InitialImage = Global.Student_Course_Registration_Manager.My.Resources.Resources.nopic3
        Me.btnhome.Location = New System.Drawing.Point(695, 1)
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
        Me.btnLogOff.Location = New System.Drawing.Point(747, 1)
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
        Me.Label1.Location = New System.Drawing.Point(311, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Admin Info"
        '
        'txthid
        '
        Me.txthid.Location = New System.Drawing.Point(188, 55)
        Me.txthid.Name = "txthid"
        Me.txthid.Size = New System.Drawing.Size(234, 20)
        Me.txthid.TabIndex = 9
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frmAdminManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GrayText
        Me.ClientSize = New System.Drawing.Size(824, 375)
        Me.ControlBox = False
        Me.Controls.Add(Me.grpAction)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.grpInfo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txthid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmAdminManager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin Manager"
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpAction.ResumeLayout(False)
        Me.grpInfo.ResumeLayout(False)
        Me.grpInfo.PerformLayout()
        CType(Me.pbxPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.btnhome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnLogOff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv1 As DataGridView
    Friend WithEvents Column15 As DataGridViewButtonColumn
    Friend WithEvents Column14 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
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
    Friend WithEvents grpInfo As GroupBox
    Friend WithEvents txtbd As TextBox
    Friend WithEvents txtTel As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents dtpBD As DateTimePicker
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbDep As ComboBox
    Friend WithEvents cmbDA As ComboBox
    Friend WithEvents cmbMA As ComboBox
    Friend WithEvents cmbYA As ComboBox
    Friend WithEvents cmbLA As ComboBox
    Friend WithEvents cmbProg As ComboBox
    Friend WithEvents cmbGend As ComboBox
    Friend WithEvents txtSn As TextBox
    Friend WithEvents txtCL As TextBox
    Friend WithEvents txtCD As TextBox
    Friend WithEvents txtMn As TextBox
    Friend WithEvents txtFn As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lablel As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents pbxPic As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnLogOff As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnhome As PictureBox
    Friend WithEvents txthid As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
