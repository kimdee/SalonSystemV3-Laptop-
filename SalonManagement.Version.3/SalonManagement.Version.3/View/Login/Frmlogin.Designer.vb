<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frmlogin
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.txtuserName = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(744, 176)
        Me.Panel1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Location = New System.Drawing.Point(176, 115)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(413, 320)
        Me.Panel3.TabIndex = 2
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.SalonManagement.Version._3.My.Resources.Resources.avatar_icon
        Me.PictureBox2.Location = New System.Drawing.Point(336, 63)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(122, 99)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.SalonManagement.Version._3.My.Resources.Resources.x_button11
        Me.PictureBox1.Location = New System.Drawing.Point(707, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(25, 21)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.LinkLabel1)
        Me.Panel2.Controls.Add(Me.PictureBox6)
        Me.Panel2.Controls.Add(Me.btnLogin)
        Me.Panel2.Controls.Add(Me.PictureBox5)
        Me.Panel2.Controls.Add(Me.PictureBox4)
        Me.Panel2.Controls.Add(Me.txtpass)
        Me.Panel2.Controls.Add(Me.txtuserName)
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(176, 115)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(413, 346)
        Me.Panel2.TabIndex = 1
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.LinkLabel1.Location = New System.Drawing.Point(101, 281)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(92, 20)
        Me.LinkLabel1.TabIndex = 9
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Attendance"
        '
        'PictureBox6
        '
        Me.PictureBox6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox6.Image = Global.SalonManagement.Version._3.My.Resources.Resources.settings_blue_
        Me.PictureBox6.Location = New System.Drawing.Point(295, 272)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(30, 29)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 8
        Me.PictureBox6.TabStop = False
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(105, 217)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(220, 38)
        Me.btnLogin.TabIndex = 7
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.SalonManagement.Version._3.My.Resources.Resources.passkey_blue_
        Me.PictureBox5.Location = New System.Drawing.Point(53, 161)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(46, 35)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 6
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.SalonManagement.Version._3.My.Resources.Resources.username_Blue_
        Me.PictureBox4.Location = New System.Drawing.Point(53, 99)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(46, 35)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        '
        'txtpass
        '
        Me.txtpass.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.txtpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpass.Location = New System.Drawing.Point(105, 161)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpass.Size = New System.Drawing.Size(220, 35)
        Me.txtpass.TabIndex = 5
        '
        'txtuserName
        '
        Me.txtuserName.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.txtuserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuserName.Location = New System.Drawing.Point(105, 99)
        Me.txtuserName.Name = "txtuserName"
        Me.txtuserName.Size = New System.Drawing.Size(220, 35)
        Me.txtuserName.TabIndex = 4
        Me.txtuserName.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.SalonManagement.Version._3.My.Resources.Resources.avatar_icon1
        Me.PictureBox3.Location = New System.Drawing.Point(160, -52)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(122, 99)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 3
        Me.PictureBox3.TabStop = False
        '
        'Frmlogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(744, 511)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frmlogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents txtpass As TextBox
    Friend WithEvents txtuserName As TextBox
End Class
