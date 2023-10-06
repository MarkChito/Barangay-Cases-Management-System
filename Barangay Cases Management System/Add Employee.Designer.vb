<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_Employee
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Add_Employee))
        img_user = New PictureBox()
        Panel2 = New Panel()
        btn_close = New Button()
        btn_submit = New Button()
        Panel1 = New Panel()
        lbl_title = New Label()
        Panel3 = New Panel()
        Label9 = New Label()
        Label10 = New Label()
        txt_confirm_password = New TextBox()
        txt_password = New TextBox()
        txt_username = New TextBox()
        Label11 = New Label()
        txt_address = New TextBox()
        Label8 = New Label()
        txt_position = New ComboBox()
        Label6 = New Label()
        txt_email = New TextBox()
        Label7 = New Label()
        Label5 = New Label()
        txt_mobile_number = New TextBox()
        txt_rfid_number = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        txt_last_name = New TextBox()
        txt_middle_name = New TextBox()
        txt_first_name = New TextBox()
        Label1 = New Label()
        Button1 = New Button()
        btn_temp = New Button()
        CType(img_user, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' img_user
        ' 
        img_user.BorderStyle = BorderStyle.FixedSingle
        img_user.Image = CType(resources.GetObject("img_user.Image"), Image)
        img_user.Location = New Point(424, 6)
        img_user.Name = "img_user"
        img_user.Size = New Size(150, 150)
        img_user.SizeMode = PictureBoxSizeMode.StretchImage
        img_user.TabIndex = 0
        img_user.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(btn_close)
        Panel2.Controls.Add(btn_submit)
        Panel2.Dock = DockStyle.Bottom
        Panel2.Location = New Point(0, 655)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1000, 45)
        Panel2.TabIndex = 3
        ' 
        ' btn_close
        ' 
        btn_close.BackColor = Color.FromArgb(CByte(220), CByte(53), CByte(69))
        btn_close.Cursor = Cursors.Hand
        btn_close.FlatStyle = FlatStyle.Flat
        btn_close.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btn_close.ForeColor = Color.White
        btn_close.Location = New Point(755, 4)
        btn_close.Name = "btn_close"
        btn_close.Size = New Size(83, 34)
        btn_close.TabIndex = 12
        btn_close.Text = "&Close"
        btn_close.UseVisualStyleBackColor = False
        ' 
        ' btn_submit
        ' 
        btn_submit.BackColor = Color.FromArgb(CByte(13), CByte(110), CByte(253))
        btn_submit.Cursor = Cursors.Hand
        btn_submit.FlatStyle = FlatStyle.Flat
        btn_submit.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btn_submit.ForeColor = Color.White
        btn_submit.Location = New Point(844, 4)
        btn_submit.Name = "btn_submit"
        btn_submit.Size = New Size(143, 34)
        btn_submit.TabIndex = 13
        btn_submit.Text = "&Submit"
        btn_submit.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(lbl_title)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1000, 45)
        Panel1.TabIndex = 2
        ' 
        ' lbl_title
        ' 
        lbl_title.AutoSize = True
        lbl_title.BackColor = Color.Transparent
        lbl_title.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_title.Location = New Point(405, 9)
        lbl_title.Name = "lbl_title"
        lbl_title.Size = New Size(188, 24)
        lbl_title.TabIndex = 1
        lbl_title.Text = "Update your Profile"
        ' 
        ' Panel3
        ' 
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(btn_temp)
        Panel3.Controls.Add(Label9)
        Panel3.Controls.Add(Label10)
        Panel3.Controls.Add(txt_confirm_password)
        Panel3.Controls.Add(txt_password)
        Panel3.Controls.Add(txt_username)
        Panel3.Controls.Add(Label11)
        Panel3.Controls.Add(txt_address)
        Panel3.Controls.Add(Label8)
        Panel3.Controls.Add(txt_position)
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(txt_email)
        Panel3.Controls.Add(Label7)
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(txt_mobile_number)
        Panel3.Controls.Add(txt_rfid_number)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(Label2)
        Panel3.Controls.Add(txt_last_name)
        Panel3.Controls.Add(txt_middle_name)
        Panel3.Controls.Add(txt_first_name)
        Panel3.Controls.Add(Label1)
        Panel3.Controls.Add(Button1)
        Panel3.Controls.Add(img_user)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(0, 45)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1000, 610)
        Panel3.TabIndex = 4
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(675, 538)
        Label9.Name = "Label9"
        Label9.Size = New Size(137, 20)
        Label9.TabIndex = 62
        Label9.Text = "Confirm Password"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(347, 538)
        Label10.Name = "Label10"
        Label10.Size = New Size(78, 20)
        Label10.TabIndex = 61
        Label10.Text = "Password"
        ' 
        ' txt_confirm_password
        ' 
        txt_confirm_password.BackColor = Color.White
        txt_confirm_password.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txt_confirm_password.Location = New Point(675, 561)
        txt_confirm_password.Name = "txt_confirm_password"
        txt_confirm_password.Size = New Size(304, 26)
        txt_confirm_password.TabIndex = 10
        txt_confirm_password.UseSystemPasswordChar = True
        ' 
        ' txt_password
        ' 
        txt_password.BackColor = Color.White
        txt_password.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txt_password.Location = New Point(347, 561)
        txt_password.Name = "txt_password"
        txt_password.Size = New Size(304, 26)
        txt_password.TabIndex = 9
        txt_password.UseSystemPasswordChar = True
        ' 
        ' txt_username
        ' 
        txt_username.BackColor = Color.White
        txt_username.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txt_username.Location = New Point(19, 561)
        txt_username.Name = "txt_username"
        txt_username.Size = New Size(304, 26)
        txt_username.TabIndex = 8
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.Location = New Point(19, 538)
        Label11.Name = "Label11"
        Label11.Size = New Size(83, 20)
        Label11.TabIndex = 58
        Label11.Text = "Username"
        ' 
        ' txt_address
        ' 
        txt_address.BackColor = Color.White
        txt_address.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txt_address.Location = New Point(19, 467)
        txt_address.Multiline = True
        txt_address.Name = "txt_address"
        txt_address.Size = New Size(960, 48)
        txt_address.TabIndex = 7
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(19, 444)
        Label8.Name = "Label8"
        Label8.Size = New Size(68, 20)
        Label8.TabIndex = 56
        Label8.Text = "Address"
        ' 
        ' txt_position
        ' 
        txt_position.BackColor = Color.White
        txt_position.DropDownStyle = ComboBoxStyle.DropDownList
        txt_position.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txt_position.FormattingEnabled = True
        txt_position.Items.AddRange(New Object() {"Barangay Captain", "Barangay Kagawad", "SK Chairman", "Barangay Secretary", "Barangay Treasurer", "Barangay Health Worker", "Barangay Tanod", "Barangay Health Officer"})
        txt_position.Location = New Point(514, 395)
        txt_position.Name = "txt_position"
        txt_position.Size = New Size(465, 28)
        txt_position.TabIndex = 6
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(514, 372)
        Label6.Name = "Label6"
        Label6.Size = New Size(65, 20)
        Label6.TabIndex = 15
        Label6.Text = "Position"
        ' 
        ' txt_email
        ' 
        txt_email.BackColor = Color.White
        txt_email.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txt_email.Location = New Point(19, 395)
        txt_email.Name = "txt_email"
        txt_email.Size = New Size(468, 26)
        txt_email.TabIndex = 5
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(19, 372)
        Label7.Name = "Label7"
        Label7.Size = New Size(48, 20)
        Label7.TabIndex = 13
        Label7.Text = "Email"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(511, 300)
        Label5.Name = "Label5"
        Label5.Size = New Size(115, 20)
        Label5.TabIndex = 11
        Label5.Text = "Mobile Number"
        ' 
        ' txt_mobile_number
        ' 
        txt_mobile_number.BackColor = Color.White
        txt_mobile_number.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txt_mobile_number.Location = New Point(511, 323)
        txt_mobile_number.Name = "txt_mobile_number"
        txt_mobile_number.Size = New Size(468, 26)
        txt_mobile_number.TabIndex = 4
        ' 
        ' txt_rfid_number
        ' 
        txt_rfid_number.BackColor = Color.White
        txt_rfid_number.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txt_rfid_number.Location = New Point(19, 323)
        txt_rfid_number.Name = "txt_rfid_number"
        txt_rfid_number.Size = New Size(468, 26)
        txt_rfid_number.TabIndex = 3
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(19, 300)
        Label4.Name = "Label4"
        Label4.Size = New Size(108, 20)
        Label4.TabIndex = 9
        Label4.Text = "RFID Number"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(675, 228)
        Label3.Name = "Label3"
        Label3.Size = New Size(86, 20)
        Label3.TabIndex = 7
        Label3.Text = "Last Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(347, 228)
        Label2.Name = "Label2"
        Label2.Size = New Size(101, 20)
        Label2.TabIndex = 6
        Label2.Text = "Middle Name"
        ' 
        ' txt_last_name
        ' 
        txt_last_name.BackColor = Color.White
        txt_last_name.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txt_last_name.Location = New Point(675, 251)
        txt_last_name.Name = "txt_last_name"
        txt_last_name.Size = New Size(304, 26)
        txt_last_name.TabIndex = 2
        ' 
        ' txt_middle_name
        ' 
        txt_middle_name.BackColor = Color.White
        txt_middle_name.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txt_middle_name.Location = New Point(347, 251)
        txt_middle_name.Name = "txt_middle_name"
        txt_middle_name.Size = New Size(304, 26)
        txt_middle_name.TabIndex = 1
        ' 
        ' txt_first_name
        ' 
        txt_first_name.BackColor = Color.White
        txt_first_name.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txt_first_name.Location = New Point(19, 251)
        txt_first_name.Name = "txt_first_name"
        txt_first_name.Size = New Size(304, 26)
        txt_first_name.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(19, 228)
        Label1.Name = "Label1"
        Label1.Size = New Size(86, 20)
        Label1.TabIndex = 3
        Label1.Text = "First Name"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(13), CByte(110), CByte(253))
        Button1.Cursor = Cursors.Hand
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(424, 162)
        Button1.Name = "Button1"
        Button1.Size = New Size(150, 35)
        Button1.TabIndex = 11
        Button1.Text = "Choose &File"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' btn_temp
        ' 
        btn_temp.Location = New Point(103, -84)
        btn_temp.Name = "btn_temp"
        btn_temp.Size = New Size(75, 23)
        btn_temp.TabIndex = 63
        btn_temp.Text = "Button2"
        btn_temp.UseVisualStyleBackColor = True
        ' 
        ' Add_Employee
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1000, 700)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.None
        Name = "Add_Employee"
        ShowIcon = False
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        CType(img_user, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents img_user As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_close As Button
    Friend WithEvents btn_submit As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_title As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents txt_last_name As TextBox
    Friend WithEvents txt_middle_name As TextBox
    Friend WithEvents txt_first_name As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_mobile_number As TextBox
    Friend WithEvents txt_rfid_number As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_email As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_position As ComboBox
    Friend WithEvents txt_address As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_confirm_password As TextBox
    Friend WithEvents txt_password As TextBox
    Friend WithEvents txt_username As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btn_temp As Button
End Class
