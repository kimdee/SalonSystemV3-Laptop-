<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.panelMain = New System.Windows.Forms.Panel()
        Me.panelContainer = New System.Windows.Forms.Panel()
        Me.panelGv = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.gvView = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.pnlviewTask = New System.Windows.Forms.Panel()
        Me.pnlVwCollct = New System.Windows.Forms.Panel()
        Me.btnVwCollect = New System.Windows.Forms.Button()
        Me.pnlVwCustmr = New System.Windows.Forms.Panel()
        Me.btnVwCustmr = New System.Windows.Forms.Button()
        Me.pnlVwAbsnt = New System.Windows.Forms.Panel()
        Me.btnVwAbsnt = New System.Windows.Forms.Button()
        Me.pnlVwLeave = New System.Windows.Forms.Panel()
        Me.btnVwLeave = New System.Windows.Forms.Button()
        Me.pnlVwPresnt = New System.Windows.Forms.Panel()
        Me.btnVwPresnt = New System.Windows.Forms.Button()
        Me.pnlVwEmploy = New System.Windows.Forms.Panel()
        Me.btnVwEmploy = New System.Windows.Forms.Button()
        Me.panelMain.SuspendLayout()
        Me.panelContainer.SuspendLayout()
        Me.panelGv.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.gvView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.pnlviewTask.SuspendLayout()
        Me.pnlVwCollct.SuspendLayout()
        Me.pnlVwCustmr.SuspendLayout()
        Me.pnlVwAbsnt.SuspendLayout()
        Me.pnlVwLeave.SuspendLayout()
        Me.pnlVwPresnt.SuspendLayout()
        Me.pnlVwEmploy.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelMain
        '
        Me.panelMain.Controls.Add(Me.panelContainer)
        Me.panelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelMain.Location = New System.Drawing.Point(0, 0)
        Me.panelMain.Name = "panelMain"
        Me.panelMain.Size = New System.Drawing.Size(1085, 700)
        Me.panelMain.TabIndex = 3
        '
        'panelContainer
        '
        Me.panelContainer.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.panelContainer.Controls.Add(Me.panelGv)
        Me.panelContainer.Controls.Add(Me.Panel1)
        Me.panelContainer.Controls.Add(Me.Panel6)
        Me.panelContainer.Controls.Add(Me.pnlviewTask)
        Me.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelContainer.Location = New System.Drawing.Point(0, 0)
        Me.panelContainer.Name = "panelContainer"
        Me.panelContainer.Size = New System.Drawing.Size(1085, 700)
        Me.panelContainer.TabIndex = 2
        '
        'panelGv
        '
        Me.panelGv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelGv.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panelGv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelGv.Controls.Add(Me.Panel7)
        Me.panelGv.Controls.Add(Me.gvView)
        Me.panelGv.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panelGv.Location = New System.Drawing.Point(12, 239)
        Me.panelGv.Margin = New System.Windows.Forms.Padding(2)
        Me.panelGv.Name = "panelGv"
        Me.panelGv.Size = New System.Drawing.Size(801, 449)
        Me.panelGv.TabIndex = 32
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.White
        Me.Panel7.Controls.Add(Me.Label14)
        Me.Panel7.Controls.Add(Me.Panel11)
        Me.Panel7.Controls.Add(Me.Label13)
        Me.Panel7.Controls.Add(Me.Panel10)
        Me.Panel7.Controls.Add(Me.Label12)
        Me.Panel7.Controls.Add(Me.Panel9)
        Me.Panel7.Controls.Add(Me.Label10)
        Me.Panel7.Controls.Add(Me.Panel8)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel7.Location = New System.Drawing.Point(0, 412)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(799, 35)
        Me.Panel7.TabIndex = 29
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(27, 8)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(58, 21)
        Me.Label14.TabIndex = 7
        Me.Label14.Text = "Absent"
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.White
        Me.Panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel11.Location = New System.Drawing.Point(9, 8)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(15, 20)
        Me.Panel11.TabIndex = 6
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(273, 7)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(39, 21)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "Late"
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.OrangeRed
        Me.Panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel10.Location = New System.Drawing.Point(255, 8)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(15, 20)
        Me.Panel10.TabIndex = 4
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(191, 7)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 21)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Leave"
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel9.Location = New System.Drawing.Point(173, 8)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(15, 20)
        Me.Panel9.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(109, 7)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 21)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Absent"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Crimson
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Location = New System.Drawing.Point(91, 8)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(15, 20)
        Me.Panel8.TabIndex = 0
        '
        'gvView
        '
        Me.gvView.AllowUserToAddRows = False
        Me.gvView.AllowUserToDeleteRows = False
        Me.gvView.AllowUserToResizeColumns = False
        Me.gvView.AllowUserToResizeRows = False
        Me.gvView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gvView.BackgroundColor = System.Drawing.Color.White
        Me.gvView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gvView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.gvView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.gvView.ColumnHeadersHeight = 60
        Me.gvView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.gvView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column2, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11, Me.Column12, Me.Column13, Me.Column14})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gvView.DefaultCellStyle = DataGridViewCellStyle1
        Me.gvView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gvView.EnableHeadersVisualStyles = False
        Me.gvView.Location = New System.Drawing.Point(0, 0)
        Me.gvView.Margin = New System.Windows.Forms.Padding(2)
        Me.gvView.Name = "gvView"
        Me.gvView.ReadOnly = True
        Me.gvView.RowHeadersVisible = False
        Me.gvView.RowTemplate.Height = 24
        Me.gvView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gvView.Size = New System.Drawing.Size(799, 447)
        Me.gvView.TabIndex = 28
        '
        'Column1
        '
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column3.HeaderText = "No."
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column3.Width = 35
        '
        'Column4
        '
        Me.Column4.HeaderText = "Name"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column5.HeaderText = "Date"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Morning Time In"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Morning Time Out"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "Afternoon Time In"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.HeaderText = "Afternoon Time Out"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.HeaderText = "Official Hours Work"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Visible = False
        '
        'Column10
        '
        Me.Column10.HeaderText = "Hours Work"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Visible = False
        '
        'Column11
        '
        Me.Column11.HeaderText = "Overtime Work"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        Me.Column11.Visible = False
        '
        'Column12
        '
        Me.Column12.HeaderText = "Undertime Work"
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        Me.Column12.Visible = False
        '
        'Column13
        '
        Me.Column13.HeaderText = "tag"
        Me.Column13.Name = "Column13"
        Me.Column13.ReadOnly = True
        Me.Column13.Visible = False
        '
        'Column14
        '
        Me.Column14.HeaderText = ""
        Me.Column14.Name = "Column14"
        Me.Column14.ReadOnly = True
        Me.Column14.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(818, 239)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(256, 265)
        Me.Panel1.TabIndex = 31
        '
        'Panel6
        '
        Me.Panel6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel6.BackColor = System.Drawing.Color.Transparent
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.Label9)
        Me.Panel6.Controls.Add(Me.lblDate)
        Me.Panel6.Controls.Add(Me.lblTime)
        Me.Panel6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel6.Location = New System.Drawing.Point(818, 510)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(255, 178)
        Me.Panel6.TabIndex = 30
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(0, 131)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(255, 42)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "                ©2019, Axiscode" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Western Mindanao State University"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Segoe UI Semibold", 19.0!, System.Drawing.FontStyle.Bold)
        Me.lblDate.ForeColor = System.Drawing.Color.White
        Me.lblDate.Location = New System.Drawing.Point(4, 78)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(245, 36)
        Me.lblDate.TabIndex = 1
        Me.lblDate.Text = "November 07, 2019"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Segoe UI Semibold", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.White
        Me.lblTime.Location = New System.Drawing.Point(3, 24)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(246, 54)
        Me.lblTime.TabIndex = 0
        Me.lblTime.Text = "12:32:00 PM"
        '
        'pnlviewTask
        '
        Me.pnlviewTask.BackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.pnlviewTask.Controls.Add(Me.pnlVwCollct)
        Me.pnlviewTask.Controls.Add(Me.pnlVwCustmr)
        Me.pnlviewTask.Controls.Add(Me.pnlVwAbsnt)
        Me.pnlviewTask.Controls.Add(Me.pnlVwLeave)
        Me.pnlviewTask.Controls.Add(Me.pnlVwPresnt)
        Me.pnlviewTask.Controls.Add(Me.pnlVwEmploy)
        Me.pnlviewTask.Location = New System.Drawing.Point(12, 12)
        Me.pnlviewTask.Name = "pnlviewTask"
        Me.pnlviewTask.Size = New System.Drawing.Size(1061, 221)
        Me.pnlviewTask.TabIndex = 1
        '
        'pnlVwCollct
        '
        Me.pnlVwCollct.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.pnlVwCollct.Controls.Add(Me.btnVwCollect)
        Me.pnlVwCollct.Location = New System.Drawing.Point(877, 19)
        Me.pnlVwCollct.Name = "pnlVwCollct"
        Me.pnlVwCollct.Size = New System.Drawing.Size(156, 186)
        Me.pnlVwCollct.TabIndex = 1
        '
        'btnVwCollect
        '
        Me.btnVwCollect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVwCollect.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVwCollect.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnVwCollect.Image = Global.SalonManagement.Version._3.My.Resources.Resources.collection
        Me.btnVwCollect.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnVwCollect.Location = New System.Drawing.Point(3, 3)
        Me.btnVwCollect.Name = "btnVwCollect"
        Me.btnVwCollect.Size = New System.Drawing.Size(150, 180)
        Me.btnVwCollect.TabIndex = 1
        Me.btnVwCollect.Text = "#1 Collection"
        Me.btnVwCollect.UseVisualStyleBackColor = True
        '
        'pnlVwCustmr
        '
        Me.pnlVwCustmr.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.pnlVwCustmr.Controls.Add(Me.btnVwCustmr)
        Me.pnlVwCustmr.Location = New System.Drawing.Point(705, 19)
        Me.pnlVwCustmr.Name = "pnlVwCustmr"
        Me.pnlVwCustmr.Size = New System.Drawing.Size(156, 186)
        Me.pnlVwCustmr.TabIndex = 1
        '
        'btnVwCustmr
        '
        Me.btnVwCustmr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVwCustmr.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVwCustmr.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnVwCustmr.Image = Global.SalonManagement.Version._3.My.Resources.Resources.customer
        Me.btnVwCustmr.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnVwCustmr.Location = New System.Drawing.Point(3, 3)
        Me.btnVwCustmr.Name = "btnVwCustmr"
        Me.btnVwCustmr.Size = New System.Drawing.Size(150, 180)
        Me.btnVwCustmr.TabIndex = 3
        Me.btnVwCustmr.Text = "#1 Customer"
        Me.btnVwCustmr.UseVisualStyleBackColor = True
        '
        'pnlVwAbsnt
        '
        Me.pnlVwAbsnt.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.pnlVwAbsnt.Controls.Add(Me.btnVwAbsnt)
        Me.pnlVwAbsnt.Location = New System.Drawing.Point(533, 19)
        Me.pnlVwAbsnt.Name = "pnlVwAbsnt"
        Me.pnlVwAbsnt.Size = New System.Drawing.Size(156, 186)
        Me.pnlVwAbsnt.TabIndex = 1
        '
        'btnVwAbsnt
        '
        Me.btnVwAbsnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVwAbsnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVwAbsnt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnVwAbsnt.Image = Global.SalonManagement.Version._3.My.Resources.Resources.absent
        Me.btnVwAbsnt.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnVwAbsnt.Location = New System.Drawing.Point(3, 3)
        Me.btnVwAbsnt.Name = "btnVwAbsnt"
        Me.btnVwAbsnt.Size = New System.Drawing.Size(150, 180)
        Me.btnVwAbsnt.TabIndex = 2
        Me.btnVwAbsnt.Text = "#1 Absent"
        Me.btnVwAbsnt.UseVisualStyleBackColor = True
        '
        'pnlVwLeave
        '
        Me.pnlVwLeave.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.pnlVwLeave.Controls.Add(Me.btnVwLeave)
        Me.pnlVwLeave.Location = New System.Drawing.Point(361, 19)
        Me.pnlVwLeave.Name = "pnlVwLeave"
        Me.pnlVwLeave.Size = New System.Drawing.Size(156, 186)
        Me.pnlVwLeave.TabIndex = 1
        '
        'btnVwLeave
        '
        Me.btnVwLeave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVwLeave.Font = New System.Drawing.Font("Microsoft Sans Serif", 23.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVwLeave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnVwLeave.Image = Global.SalonManagement.Version._3.My.Resources.Resources.position1
        Me.btnVwLeave.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnVwLeave.Location = New System.Drawing.Point(3, 3)
        Me.btnVwLeave.Name = "btnVwLeave"
        Me.btnVwLeave.Size = New System.Drawing.Size(150, 179)
        Me.btnVwLeave.TabIndex = 1
        Me.btnVwLeave.Text = "#1 Leave"
        Me.btnVwLeave.UseVisualStyleBackColor = True
        '
        'pnlVwPresnt
        '
        Me.pnlVwPresnt.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.pnlVwPresnt.Controls.Add(Me.btnVwPresnt)
        Me.pnlVwPresnt.Location = New System.Drawing.Point(189, 19)
        Me.pnlVwPresnt.Name = "pnlVwPresnt"
        Me.pnlVwPresnt.Size = New System.Drawing.Size(156, 186)
        Me.pnlVwPresnt.TabIndex = 1
        '
        'btnVwPresnt
        '
        Me.btnVwPresnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVwPresnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVwPresnt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnVwPresnt.Image = Global.SalonManagement.Version._3.My.Resources.Resources.attendance
        Me.btnVwPresnt.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnVwPresnt.Location = New System.Drawing.Point(3, 3)
        Me.btnVwPresnt.Name = "btnVwPresnt"
        Me.btnVwPresnt.Size = New System.Drawing.Size(150, 180)
        Me.btnVwPresnt.TabIndex = 1
        Me.btnVwPresnt.Text = "#1 Present"
        Me.btnVwPresnt.UseVisualStyleBackColor = True
        '
        'pnlVwEmploy
        '
        Me.pnlVwEmploy.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.pnlVwEmploy.Controls.Add(Me.btnVwEmploy)
        Me.pnlVwEmploy.Location = New System.Drawing.Point(17, 19)
        Me.pnlVwEmploy.Name = "pnlVwEmploy"
        Me.pnlVwEmploy.Size = New System.Drawing.Size(156, 186)
        Me.pnlVwEmploy.TabIndex = 0
        '
        'btnVwEmploy
        '
        Me.btnVwEmploy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVwEmploy.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVwEmploy.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnVwEmploy.Image = Global.SalonManagement.Version._3.My.Resources.Resources.employee1
        Me.btnVwEmploy.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnVwEmploy.Location = New System.Drawing.Point(3, 3)
        Me.btnVwEmploy.Name = "btnVwEmploy"
        Me.btnVwEmploy.Size = New System.Drawing.Size(150, 180)
        Me.btnVwEmploy.TabIndex = 0
        Me.btnVwEmploy.Text = "#1 Employee"
        Me.btnVwEmploy.UseVisualStyleBackColor = True
        '
        'frmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1085, 700)
        Me.Controls.Add(Me.panelMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "frmDashboard"
        Me.panelMain.ResumeLayout(False)
        Me.panelContainer.ResumeLayout(False)
        Me.panelGv.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        CType(Me.gvView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.pnlviewTask.ResumeLayout(False)
        Me.pnlVwCollct.ResumeLayout(False)
        Me.pnlVwCustmr.ResumeLayout(False)
        Me.pnlVwAbsnt.ResumeLayout(False)
        Me.pnlVwLeave.ResumeLayout(False)
        Me.pnlVwPresnt.ResumeLayout(False)
        Me.pnlVwEmploy.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelMain As Panel
    Friend WithEvents panelContainer As Panel
    Friend WithEvents pnlviewTask As Panel
    Friend WithEvents pnlVwCollct As Panel
    Friend WithEvents btnVwCollect As Button
    Friend WithEvents pnlVwCustmr As Panel
    Friend WithEvents btnVwCustmr As Button
    Friend WithEvents pnlVwAbsnt As Panel
    Friend WithEvents btnVwAbsnt As Button
    Friend WithEvents pnlVwLeave As Panel
    Friend WithEvents btnVwLeave As Button
    Friend WithEvents pnlVwPresnt As Panel
    Friend WithEvents btnVwPresnt As Button
    Friend WithEvents pnlVwEmploy As Panel
    Friend WithEvents btnVwEmploy As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents panelGv As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents gvView As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents Column14 As DataGridViewLinkColumn
End Class
