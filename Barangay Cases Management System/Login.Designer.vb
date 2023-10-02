<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Login))
        img_loading = New PictureBox()
        pnl_login = New Panel()
        Label7 = New Label()
        btn_temp = New Button()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        img_show_hide_password = New PictureBox()
        btn_rfid_login = New LinkLabel()
        Label6 = New Label()
        btn_login = New Button()
        check_remember_me = New CheckBox()
        txt_password = New TextBox()
        Label5 = New Label()
        txt_username = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Timer1 = New Timer(components)
        CType(img_loading, ComponentModel.ISupportInitialize).BeginInit()
        pnl_login.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(img_show_hide_password, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' img_loading
        ' 
        img_loading.Dock = DockStyle.Fill
        img_loading.Image = CType(resources.GetObject("img_loading.Image"), Image)
        img_loading.Location = New Point(0, 0)
        img_loading.Name = "img_loading"
        img_loading.Size = New Size(534, 661)
        img_loading.SizeMode = PictureBoxSizeMode.CenterImage
        img_loading.TabIndex = 0
        img_loading.TabStop = False
        ' 
        ' pnl_login
        ' 
        pnl_login.Controls.Add(Label7)
        pnl_login.Controls.Add(btn_temp)
        pnl_login.Controls.Add(Label1)
        pnl_login.Controls.Add(PictureBox1)
        pnl_login.Controls.Add(Panel1)
        pnl_login.Location = New Point(32, 12)
        pnl_login.Name = "pnl_login"
        pnl_login.Size = New Size(470, 637)
        pnl_login.TabIndex = 1
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = Color.FromArgb(CByte(1), CByte(41), CByte(112))
        Label7.Location = New Point(82, 170)
        Label7.Name = "Label7"
        Label7.Size = New Size(307, 33)
        Label7.TabIndex = 4
        Label7.Text = "Management System"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btn_temp
        ' 
        btn_temp.Location = New Point(42, 662)
        btn_temp.Name = "btn_temp"
        btn_temp.Size = New Size(75, 23)
        btn_temp.TabIndex = 3
        btn_temp.Text = "Button1"
        btn_temp.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(1), CByte(41), CByte(112))
        Label1.Location = New Point(113, 137)
        Label1.Name = "Label1"
        Label1.Size = New Size(244, 33)
        Label1.TabIndex = 2
        Label1.Text = "Barangay Cases"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(185, 34)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(100, 100)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(img_show_hide_password)
        Panel1.Controls.Add(btn_rfid_login)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(btn_login)
        Panel1.Controls.Add(check_remember_me)
        Panel1.Controls.Add(txt_password)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(txt_username)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(40, 216)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(390, 386)
        Panel1.TabIndex = 0
        ' 
        ' img_show_hide_password
        ' 
        img_show_hide_password.BackColor = Color.Transparent
        img_show_hide_password.Cursor = Cursors.Hand
        img_show_hide_password.Image = CType(resources.GetObject("img_show_hide_password.Image"), Image)
        img_show_hide_password.Location = New Point(348, 215)
        img_show_hide_password.Name = "img_show_hide_password"
        img_show_hide_password.Size = New Size(18, 18)
        img_show_hide_password.SizeMode = PictureBoxSizeMode.StretchImage
        img_show_hide_password.TabIndex = 13
        img_show_hide_password.TabStop = False
        ' 
        ' btn_rfid_login
        ' 
        btn_rfid_login.AutoSize = True
        btn_rfid_login.BackColor = Color.Transparent
        btn_rfid_login.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btn_rfid_login.LinkBehavior = LinkBehavior.NeverUnderline
        btn_rfid_login.Location = New Point(169, 348)
        btn_rfid_login.Name = "btn_rfid_login"
        btn_rfid_login.Size = New Size(133, 20)
        btn_rfid_login.TabIndex = 4
        btn_rfid_login.TabStop = True
        btn_rfid_login.Text = "Login using &RFID"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(20, 348)
        Label6.Name = "Label6"
        Label6.Size = New Size(155, 20)
        Label6.TabIndex = 11
        Label6.Text = "Got you RFID Card?"
        ' 
        ' btn_login
        ' 
        btn_login.BackColor = Color.FromArgb(CByte(13), CByte(110), CByte(253))
        btn_login.Cursor = Cursors.Hand
        btn_login.FlatAppearance.BorderColor = Color.FromArgb(CByte(13), CByte(110), CByte(253))
        btn_login.FlatAppearance.BorderSize = 0
        btn_login.FlatStyle = FlatStyle.Flat
        btn_login.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btn_login.ForeColor = Color.White
        btn_login.Location = New Point(20, 288)
        btn_login.Name = "btn_login"
        btn_login.Size = New Size(350, 42)
        btn_login.TabIndex = 3
        btn_login.Text = "&Login"
        btn_login.UseVisualStyleBackColor = False
        ' 
        ' check_remember_me
        ' 
        check_remember_me.AutoSize = True
        check_remember_me.BackColor = Color.Transparent
        check_remember_me.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        check_remember_me.Location = New Point(20, 243)
        check_remember_me.Name = "check_remember_me"
        check_remember_me.Size = New Size(133, 24)
        check_remember_me.TabIndex = 2
        check_remember_me.Text = "R&emember Me"
        check_remember_me.UseVisualStyleBackColor = False
        ' 
        ' txt_password
        ' 
        txt_password.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txt_password.Location = New Point(20, 211)
        txt_password.MaxLength = 30
        txt_password.Name = "txt_password"
        txt_password.Size = New Size(350, 26)
        txt_password.TabIndex = 1
        txt_password.UseSystemPasswordChar = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(20, 188)
        Label5.Name = "Label5"
        Label5.Size = New Size(78, 20)
        Label5.TabIndex = 7
        Label5.Text = "Password"
        ' 
        ' txt_username
        ' 
        txt_username.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txt_username.Location = New Point(20, 145)
        txt_username.Name = "txt_username"
        txt_username.Size = New Size(350, 26)
        txt_username.TabIndex = 0
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(20, 122)
        Label4.Name = "Label4"
        Label4.Size = New Size(83, 20)
        Label4.TabIndex = 5
        Label4.Text = "Username"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.ControlText
        Label3.Location = New Point(65, 77)
        Label3.Name = "Label3"
        Label3.Size = New Size(259, 16)
        Label3.TabIndex = 4
        Label3.Text = "For Administrator and Employees use only"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(1), CByte(41), CByte(112))
        Label2.Location = New Point(67, 38)
        Label2.Name = "Label2"
        Label2.Size = New Size(257, 29)
        Label2.TabIndex = 3
        Label2.Text = "Login To Your Account"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Timer1
        ' 
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(246), CByte(249), CByte(255))
        ClientSize = New Size(534, 661)
        Controls.Add(pnl_login)
        Controls.Add(img_loading)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MinimumSize = New Size(550, 700)
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Administrator Login"
        CType(img_loading, ComponentModel.ISupportInitialize).EndInit()
        pnl_login.ResumeLayout(False)
        pnl_login.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(img_show_hide_password, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents img_loading As PictureBox
    Friend WithEvents pnl_login As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_username As TextBox
    Friend WithEvents txt_password As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents check_remember_me As CheckBox
    Friend WithEvents btn_login As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_rfid_login As LinkLabel
    Friend WithEvents img_show_hide_password As PictureBox
    Friend WithEvents btn_temp As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label7 As Label
End Class
