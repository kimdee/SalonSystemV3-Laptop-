<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddPosition
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtOT = New System.Windows.Forms.TextBox()
        Me.txtStandardPay = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtBasicPays = New System.Windows.Forms.TextBox()
        Me.Panel2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.TabControl1)
        Me.Panel2.Location = New System.Drawing.Point(176, 47)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(389, 432)
        Me.Panel2.TabIndex = 2
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(3, 2)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(384, 427)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Panel3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage1.Size = New System.Drawing.Size(376, 398)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Position Information"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.btnClose)
        Me.Panel3.Controls.Add(Me.btnSave)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.txtOT)
        Me.Panel3.Controls.Add(Me.txtStandardPay)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.txtName)
        Me.Panel3.Controls.Add(Me.txtBasicPays)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 2)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(370, 394)
        Me.Panel3.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.White
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnClose.Location = New System.Drawing.Point(187, 326)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(163, 39)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "Close"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSave.Location = New System.Drawing.Point(19, 326)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(163, 39)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Add"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(3, 11)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(17, 22)
        Me.Label11.TabIndex = 47
        Me.Label11.Text = "*"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(3, 87)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(17, 22)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(13, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(177, 35)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Position Name"
        '
        'txtOT
        '
        Me.txtOT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOT.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.txtOT.ForeColor = System.Drawing.Color.Black
        Me.txtOT.Location = New System.Drawing.Point(19, 202)
        Me.txtOT.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtOT.Name = "txtOT"
        Me.txtOT.Size = New System.Drawing.Size(330, 39)
        Me.txtOT.TabIndex = 53
        Me.txtOT.Text = "0"
        '
        'txtStandardPay
        '
        Me.txtStandardPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStandardPay.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.txtStandardPay.ForeColor = System.Drawing.Color.Black
        Me.txtStandardPay.Location = New System.Drawing.Point(19, 126)
        Me.txtStandardPay.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtStandardPay.Name = "txtStandardPay"
        Me.txtStandardPay.Size = New System.Drawing.Size(330, 39)
        Me.txtStandardPay.TabIndex = 49
        Me.txtStandardPay.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(13, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(274, 35)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Standard  Pay (Per Day)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(13, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(162, 35)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Overtime Pay"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(13, 244)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(226, 35)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Basic Pay (15 Days)"
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.txtName.ForeColor = System.Drawing.Color.Black
        Me.txtName.Location = New System.Drawing.Point(19, 46)
        Me.txtName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(330, 39)
        Me.txtName.TabIndex = 46
        '
        'txtBasicPays
        '
        Me.txtBasicPays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBasicPays.Enabled = False
        Me.txtBasicPays.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.txtBasicPays.ForeColor = System.Drawing.Color.Black
        Me.txtBasicPays.Location = New System.Drawing.Point(19, 282)
        Me.txtBasicPays.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBasicPays.Name = "txtBasicPays"
        Me.txtBasicPays.Size = New System.Drawing.Size(330, 39)
        Me.txtBasicPays.TabIndex = 51
        Me.txtBasicPays.Text = "0"
        '
        'frmAddPosition
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1360, 674)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "frmAddPosition"
        Me.Text = "frmAddPosition"
        Me.Panel2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtOT As System.Windows.Forms.TextBox
    Friend WithEvents txtStandardPay As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtBasicPays As System.Windows.Forms.TextBox
End Class
