<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Update_Profile
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Update_Profile))
        Label2 = New Label()
        Label1 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Panel1 = New Panel()
        Label8 = New Label()
        lbl_primary_key = New Label()
        Panel10 = New Panel()
        pnl_profile_image = New Panel()
        img_user = New PictureBox()
        pnl_profile_details = New Panel()
        btn_submit = New Button()
        Panel11 = New Panel()
        txt_address = New TextBox()
        Panel9 = New Panel()
        txt_email = New TextBox()
        Panel8 = New Panel()
        txt_mobile_number = New TextBox()
        Panel7 = New Panel()
        txt_position = New ComboBox()
        Panel6 = New Panel()
        txt_last_name = New TextBox()
        Panel5 = New Panel()
        txt_middle_name = New TextBox()
        Panel4 = New Panel()
        txt_first_name = New TextBox()
        Panel3 = New Panel()
        ToolTip1 = New ToolTip(components)
        Panel1.SuspendLayout()
        pnl_profile_image.SuspendLayout()
        CType(img_user, ComponentModel.ISupportInitialize).BeginInit()
        pnl_profile_details.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(103), CByte(127), CByte(169))
        Label2.Location = New Point(23, 137)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 20)
        Label2.TabIndex = 2
        Label2.Text = "First Name"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(103), CByte(127), CByte(169))
        Label1.Location = New Point(23, 183)
        Label1.Name = "Label1"
        Label1.Size = New Size(101, 20)
        Label1.TabIndex = 4
        Label1.Text = "Middle Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = Color.FromArgb(CByte(103), CByte(127), CByte(169))
        Label3.Location = New Point(23, 229)
        Label3.Name = "Label3"
        Label3.Size = New Size(86, 20)
        Label3.TabIndex = 6
        Label3.Text = "Last Name"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.FromArgb(CByte(103), CByte(127), CByte(169))
        Label4.Location = New Point(23, 275)
        Label4.Name = "Label4"
        Label4.Size = New Size(65, 20)
        Label4.TabIndex = 8
        Label4.Text = "Position"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = Color.FromArgb(CByte(103), CByte(127), CByte(169))
        Label5.Location = New Point(23, 323)
        Label5.Name = "Label5"
        Label5.Size = New Size(115, 20)
        Label5.TabIndex = 11
        Label5.Text = "Mobile Number"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.ForeColor = Color.FromArgb(CByte(103), CByte(127), CByte(169))
        Label6.Location = New Point(23, 369)
        Label6.Name = "Label6"
        Label6.Size = New Size(48, 20)
        Label6.TabIndex = 13
        Label6.Text = "Email"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.ForeColor = Color.FromArgb(CByte(103), CByte(127), CByte(169))
        Label7.Location = New Point(23, 415)
        Label7.Name = "Label7"
        Label7.Size = New Size(68, 20)
        Label7.TabIndex = 15
        Label7.Text = "Address"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(lbl_primary_key)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label6)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(250, 521)
        Panel1.TabIndex = 18
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.ForeColor = Color.FromArgb(CByte(103), CByte(127), CByte(169))
        Label8.Location = New Point(23, 47)
        Label8.Name = "Label8"
        Label8.Size = New Size(102, 20)
        Label8.TabIndex = 17
        Label8.Text = "Profile Image"
        ' 
        ' lbl_primary_key
        ' 
        lbl_primary_key.AutoSize = True
        lbl_primary_key.Location = New Point(63, 493)
        lbl_primary_key.Name = "lbl_primary_key"
        lbl_primary_key.Size = New Size(110, 15)
        lbl_primary_key.TabIndex = 16
        lbl_primary_key.Text = "Do Not Delete This"
        lbl_primary_key.Visible = False
        ' 
        ' Panel10
        ' 
        Panel10.Dock = DockStyle.Right
        Panel10.Location = New Point(596, 0)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(25, 521)
        Panel10.TabIndex = 16
        ' 
        ' pnl_profile_image
        ' 
        pnl_profile_image.Controls.Add(img_user)
        pnl_profile_image.Dock = DockStyle.Top
        pnl_profile_image.Location = New Point(0, 0)
        pnl_profile_image.Name = "pnl_profile_image"
        pnl_profile_image.Size = New Size(346, 114)
        pnl_profile_image.TabIndex = 33
        ' 
        ' img_user
        ' 
        img_user.BorderStyle = BorderStyle.FixedSingle
        img_user.Cursor = Cursors.Hand
        img_user.Image = CType(resources.GetObject("img_user.Image"), Image)
        img_user.Location = New Point(123, 7)
        img_user.Name = "img_user"
        img_user.Size = New Size(100, 100)
        img_user.SizeMode = PictureBoxSizeMode.StretchImage
        img_user.TabIndex = 0
        img_user.TabStop = False
        ToolTip1.SetToolTip(img_user, "Update Profile Image")
        ' 
        ' pnl_profile_details
        ' 
        pnl_profile_details.Controls.Add(btn_submit)
        pnl_profile_details.Controls.Add(Panel11)
        pnl_profile_details.Controls.Add(txt_address)
        pnl_profile_details.Controls.Add(Panel9)
        pnl_profile_details.Controls.Add(txt_email)
        pnl_profile_details.Controls.Add(Panel8)
        pnl_profile_details.Controls.Add(txt_mobile_number)
        pnl_profile_details.Controls.Add(Panel7)
        pnl_profile_details.Controls.Add(txt_position)
        pnl_profile_details.Controls.Add(Panel6)
        pnl_profile_details.Controls.Add(txt_last_name)
        pnl_profile_details.Controls.Add(Panel5)
        pnl_profile_details.Controls.Add(txt_middle_name)
        pnl_profile_details.Controls.Add(Panel4)
        pnl_profile_details.Controls.Add(txt_first_name)
        pnl_profile_details.Controls.Add(Panel3)
        pnl_profile_details.Controls.Add(pnl_profile_image)
        pnl_profile_details.Dock = DockStyle.Fill
        pnl_profile_details.Location = New Point(250, 0)
        pnl_profile_details.Name = "pnl_profile_details"
        pnl_profile_details.Size = New Size(346, 521)
        pnl_profile_details.TabIndex = 20
        ' 
        ' btn_submit
        ' 
        btn_submit.BackColor = Color.FromArgb(CByte(13), CByte(110), CByte(253))
        btn_submit.Cursor = Cursors.Hand
        btn_submit.Dock = DockStyle.Top
        btn_submit.FlatStyle = FlatStyle.Flat
        btn_submit.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btn_submit.ForeColor = Color.White
        btn_submit.Location = New Point(0, 480)
        btn_submit.Name = "btn_submit"
        btn_submit.Size = New Size(346, 42)
        btn_submit.TabIndex = 65
        btn_submit.Text = "&Submit Changes"
        btn_submit.UseVisualStyleBackColor = False
        ' 
        ' Panel11
        ' 
        Panel11.Dock = DockStyle.Top
        Panel11.Location = New Point(0, 460)
        Panel11.Name = "Panel11"
        Panel11.Size = New Size(346, 20)
        Panel11.TabIndex = 64
        ' 
        ' txt_address
        ' 
        txt_address.Dock = DockStyle.Top
        txt_address.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txt_address.Location = New Point(0, 412)
        txt_address.Multiline = True
        txt_address.Name = "txt_address"
        txt_address.Size = New Size(346, 48)
        txt_address.TabIndex = 56
        ' 
        ' Panel9
        ' 
        Panel9.Dock = DockStyle.Top
        Panel9.Location = New Point(0, 392)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(346, 20)
        Panel9.TabIndex = 63
        ' 
        ' txt_email
        ' 
        txt_email.Dock = DockStyle.Top
        txt_email.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txt_email.Location = New Point(0, 366)
        txt_email.Name = "txt_email"
        txt_email.Size = New Size(346, 26)
        txt_email.TabIndex = 55
        ' 
        ' Panel8
        ' 
        Panel8.Dock = DockStyle.Top
        Panel8.Location = New Point(0, 346)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(346, 20)
        Panel8.TabIndex = 62
        ' 
        ' txt_mobile_number
        ' 
        txt_mobile_number.Dock = DockStyle.Top
        txt_mobile_number.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txt_mobile_number.Location = New Point(0, 320)
        txt_mobile_number.Name = "txt_mobile_number"
        txt_mobile_number.Size = New Size(346, 26)
        txt_mobile_number.TabIndex = 54
        ' 
        ' Panel7
        ' 
        Panel7.Dock = DockStyle.Top
        Panel7.Location = New Point(0, 300)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(346, 20)
        Panel7.TabIndex = 61
        ' 
        ' txt_position
        ' 
        txt_position.BackColor = Color.White
        txt_position.Dock = DockStyle.Top
        txt_position.DropDownStyle = ComboBoxStyle.DropDownList
        txt_position.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txt_position.FormattingEnabled = True
        txt_position.Items.AddRange(New Object() {"Barangay Captain", "Barangay Kagawad", "SK Chairman", "Barangay Secretary", "Barangay Treasurer", "Barangay Health Worker", "Barangay Tanod", "Barangay Health Officer"})
        txt_position.Location = New Point(0, 272)
        txt_position.Name = "txt_position"
        txt_position.Size = New Size(346, 28)
        txt_position.TabIndex = 53
        ' 
        ' Panel6
        ' 
        Panel6.Dock = DockStyle.Top
        Panel6.Location = New Point(0, 252)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(346, 20)
        Panel6.TabIndex = 60
        ' 
        ' txt_last_name
        ' 
        txt_last_name.Dock = DockStyle.Top
        txt_last_name.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txt_last_name.Location = New Point(0, 226)
        txt_last_name.Name = "txt_last_name"
        txt_last_name.Size = New Size(346, 26)
        txt_last_name.TabIndex = 52
        ' 
        ' Panel5
        ' 
        Panel5.Dock = DockStyle.Top
        Panel5.Location = New Point(0, 206)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(346, 20)
        Panel5.TabIndex = 59
        ' 
        ' txt_middle_name
        ' 
        txt_middle_name.Dock = DockStyle.Top
        txt_middle_name.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txt_middle_name.Location = New Point(0, 180)
        txt_middle_name.Name = "txt_middle_name"
        txt_middle_name.Size = New Size(346, 26)
        txt_middle_name.TabIndex = 51
        ' 
        ' Panel4
        ' 
        Panel4.Dock = DockStyle.Top
        Panel4.Location = New Point(0, 160)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(346, 20)
        Panel4.TabIndex = 58
        ' 
        ' txt_first_name
        ' 
        txt_first_name.Dock = DockStyle.Top
        txt_first_name.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txt_first_name.Location = New Point(0, 134)
        txt_first_name.Name = "txt_first_name"
        txt_first_name.Size = New Size(346, 26)
        txt_first_name.TabIndex = 50
        ' 
        ' Panel3
        ' 
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(0, 114)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(346, 20)
        Panel3.TabIndex = 57
        ' 
        ' Update_Profile
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        Controls.Add(pnl_profile_details)
        Controls.Add(Panel10)
        Controls.Add(Panel1)
        Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Name = "Update_Profile"
        Size = New Size(621, 521)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        pnl_profile_image.ResumeLayout(False)
        CType(img_user, ComponentModel.ISupportInitialize).EndInit()
        pnl_profile_details.ResumeLayout(False)
        pnl_profile_details.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents lbl_primary_key As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents pnl_profile_image As Panel
    Friend WithEvents img_user As PictureBox
    Friend WithEvents pnl_profile_details As Panel
    Friend WithEvents btn_submit As Button
    Friend WithEvents Panel11 As Panel
    Friend WithEvents txt_address As TextBox
    Friend WithEvents Panel9 As Panel
    Friend WithEvents txt_email As TextBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents txt_mobile_number As TextBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents txt_position As ComboBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents txt_last_name As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txt_middle_name As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txt_first_name As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ToolTip1 As ToolTip
End Class
