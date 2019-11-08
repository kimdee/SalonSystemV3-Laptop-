<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCollection
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
        Me.panelMain = New System.Windows.Forms.Panel()
        Me.panelContainer = New System.Windows.Forms.Panel()
        Me.panelGv = New System.Windows.Forms.Panel()
        Me.gvView = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.panelbl = New System.Windows.Forms.Panel()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblEmploy = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panelMain.SuspendLayout()
        Me.panelContainer.SuspendLayout()
        Me.panelGv.SuspendLayout()
        CType(Me.gvView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.panelbl.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelMain
        '
        Me.panelMain.Controls.Add(Me.panelContainer)
        Me.panelMain.Controls.Add(Me.Panel2)
        Me.panelMain.Controls.Add(Me.Panel1)
        Me.panelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelMain.Location = New System.Drawing.Point(0, 0)
        Me.panelMain.Name = "panelMain"
        Me.panelMain.Size = New System.Drawing.Size(1447, 880)
        Me.panelMain.TabIndex = 0
        '
        'panelContainer
        '
        Me.panelContainer.Controls.Add(Me.panelGv)
        Me.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelContainer.Location = New System.Drawing.Point(0, 78)
        Me.panelContainer.Name = "panelContainer"
        Me.panelContainer.Size = New System.Drawing.Size(1447, 744)
        Me.panelContainer.TabIndex = 4
        '
        'panelGv
        '
        Me.panelGv.BackColor = System.Drawing.Color.White
        Me.panelGv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelGv.Controls.Add(Me.gvView)
        Me.panelGv.Controls.Add(Me.Panel4)
        Me.panelGv.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.panelGv.Location = New System.Drawing.Point(12, 6)
        Me.panelGv.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.panelGv.Name = "panelGv"
        Me.panelGv.Size = New System.Drawing.Size(1423, 732)
        Me.panelGv.TabIndex = 30
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
        Me.gvView.ColumnHeadersHeight = 35
        Me.gvView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.gvView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column3, Me.Column2, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.gvView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gvView.EnableHeadersVisualStyles = False
        Me.gvView.Location = New System.Drawing.Point(0, 58)
        Me.gvView.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gvView.Name = "gvView"
        Me.gvView.ReadOnly = True
        Me.gvView.RowHeadersVisible = False
        Me.gvView.RowTemplate.Height = 24
        Me.gvView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gvView.Size = New System.Drawing.Size(1421, 672)
        Me.gvView.TabIndex = 57
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
        Me.Column3.Width = 50
        '
        'Column2
        '
        Me.Column2.HeaderText = "Date"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Amount"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column5.HeaderText = "No. Of Customer"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 250
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column6.HeaderText = "No. Of Employee"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 250
        '
        'Column7
        '
        Me.Column7.HeaderText = ""
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.DateTimePicker2)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.DateTimePicker1)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.panelbl)
        Me.Panel4.Controls.Add(Me.txtSearch)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1421, 58)
        Me.Panel4.TabIndex = 26
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CalendarFont = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.DateTimePicker2.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(345, 10)
        Me.DateTimePicker2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(188, 39)
        Me.DateTimePicker2.TabIndex = 55
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(296, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 32)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "To"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.DateTimePicker1.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(101, 10)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(188, 39)
        Me.DateTimePicker1.TabIndex = 54
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(20, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 32)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "From"
        '
        'panelbl
        '
        Me.panelbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelbl.Controls.Add(Me.lblSearch)
        Me.panelbl.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.panelbl.Location = New System.Drawing.Point(1303, 10)
        Me.panelbl.Margin = New System.Windows.Forms.Padding(4)
        Me.panelbl.Name = "panelbl"
        Me.panelbl.Size = New System.Drawing.Size(107, 39)
        Me.panelbl.TabIndex = 45
        '
        'lblSearch
        '
        Me.lblSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSearch.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.lblSearch.Location = New System.Drawing.Point(0, 0)
        Me.lblSearch.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(105, 37)
        Me.lblSearch.TabIndex = 42
        Me.lblSearch.Text = "Search"
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.BackColor = System.Drawing.Color.White
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.txtSearch.ForeColor = System.Drawing.Color.Gray
        Me.txtSearch.Location = New System.Drawing.Point(935, 10)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(367, 39)
        Me.txtSearch.TabIndex = 44
        Me.txtSearch.Text = "Search Customer"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 822)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1447, 58)
        Me.Panel2.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.lblEmploy)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1447, 78)
        Me.Panel1.TabIndex = 2
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox2.Image = Global.SalonManagement.Version._3.My.Resources.Resources.euro
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(85, 78)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'lblEmploy
        '
        Me.lblEmploy.AutoSize = True
        Me.lblEmploy.BackColor = System.Drawing.Color.Transparent
        Me.lblEmploy.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmploy.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.lblEmploy.Location = New System.Drawing.Point(93, 13)
        Me.lblEmploy.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmploy.Name = "lblEmploy"
        Me.lblEmploy.Size = New System.Drawing.Size(215, 52)
        Me.lblEmploy.TabIndex = 5
        Me.lblEmploy.Text = "Collection"
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox1.Image = Global.SalonManagement.Version._3.My.Resources.Resources.exit_door
        Me.PictureBox1.Location = New System.Drawing.Point(1379, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(68, 78)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'FrmCollection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1447, 880)
        Me.Controls.Add(Me.panelMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmCollection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmCollection"
        Me.panelMain.ResumeLayout(False)
        Me.panelContainer.ResumeLayout(False)
        Me.panelGv.ResumeLayout(False)
        CType(Me.gvView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.panelbl.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelMain As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents lblEmploy As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents panelContainer As System.Windows.Forms.Panel
    Friend WithEvents panelGv As System.Windows.Forms.Panel
    Friend WithEvents gvView As System.Windows.Forms.DataGridView
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents panelbl As System.Windows.Forms.Panel
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewLinkColumn

End Class
