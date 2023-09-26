<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Profile
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Profile))
        Panel2 = New Panel()
        Panel4 = New Panel()
        pnl_overview_and_update_profile = New Panel()
        Panel8 = New Panel()
        Overview = New Overview()
        Update_Profile = New Update_Profile()
        Employee_Account_Settings = New Employee_Account_Settings()
        Panel7 = New Panel()
        btn_acount_settings = New Button()
        btn_update_profile = New Button()
        btn_overview = New Button()
        Panel5 = New Panel()
        Panel3 = New Panel()
        pnl_user_details_and_image = New Panel()
        pnl_user_details = New Panel()
        lbl_user_details_position = New Label()
        lbl_user_details_full_name = New Label()
        img_user = New PictureBox()
        Panel10 = New Panel()
        Panel1 = New Panel()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel2.SuspendLayout()
        Panel4.SuspendLayout()
        pnl_overview_and_update_profile.SuspendLayout()
        Panel8.SuspendLayout()
        Panel7.SuspendLayout()
        pnl_user_details_and_image.SuspendLayout()
        pnl_user_details.SuspendLayout()
        CType(img_user, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Panel4)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 100)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1046, 571)
        Panel2.TabIndex = 9
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(pnl_overview_and_update_profile)
        Panel4.Controls.Add(Panel5)
        Panel4.Controls.Add(Panel3)
        Panel4.Controls.Add(pnl_user_details_and_image)
        Panel4.Controls.Add(Panel10)
        Panel4.Dock = DockStyle.Fill
        Panel4.Location = New Point(0, 0)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(1046, 571)
        Panel4.TabIndex = 1
        ' 
        ' pnl_overview_and_update_profile
        ' 
        pnl_overview_and_update_profile.BackColor = Color.Transparent
        pnl_overview_and_update_profile.Controls.Add(Panel8)
        pnl_overview_and_update_profile.Controls.Add(Panel7)
        pnl_overview_and_update_profile.Dock = DockStyle.Fill
        pnl_overview_and_update_profile.Location = New Point(400, 0)
        pnl_overview_and_update_profile.Name = "pnl_overview_and_update_profile"
        pnl_overview_and_update_profile.Size = New Size(621, 571)
        pnl_overview_and_update_profile.TabIndex = 21
        ' 
        ' Panel8
        ' 
        Panel8.Controls.Add(Overview)
        Panel8.Controls.Add(Update_Profile)
        Panel8.Controls.Add(Employee_Account_Settings)
        Panel8.Dock = DockStyle.Fill
        Panel8.Location = New Point(0, 50)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(621, 521)
        Panel8.TabIndex = 2
        ' 
        ' Overview
        ' 
        Overview.BackColor = Color.White
        Overview.Dock = DockStyle.Fill
        Overview.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Overview.Location = New Point(0, 0)
        Overview.Name = "Overview"
        Overview.Size = New Size(621, 521)
        Overview.TabIndex = 0
        ' 
        ' Update_Profile
        ' 
        Update_Profile.BackColor = Color.White
        Update_Profile.Dock = DockStyle.Fill
        Update_Profile.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Update_Profile.Location = New Point(0, 0)
        Update_Profile.Name = "Update_Profile"
        Update_Profile.Size = New Size(621, 521)
        Update_Profile.TabIndex = 1
        ' 
        ' Employee_Account_Settings
        ' 
        Employee_Account_Settings.BackColor = Color.White
        Employee_Account_Settings.Dock = DockStyle.Fill
        Employee_Account_Settings.Location = New Point(0, 0)
        Employee_Account_Settings.Name = "Employee_Account_Settings"
        Employee_Account_Settings.Size = New Size(621, 521)
        Employee_Account_Settings.TabIndex = 2
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.White
        Panel7.Controls.Add(btn_acount_settings)
        Panel7.Controls.Add(btn_update_profile)
        Panel7.Controls.Add(btn_overview)
        Panel7.Dock = DockStyle.Top
        Panel7.Location = New Point(0, 0)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(621, 50)
        Panel7.TabIndex = 1
        ' 
        ' btn_acount_settings
        ' 
        btn_acount_settings.BackColor = Color.Transparent
        btn_acount_settings.Cursor = Cursors.Hand
        btn_acount_settings.Dock = DockStyle.Left
        btn_acount_settings.FlatAppearance.BorderSize = 0
        btn_acount_settings.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(246), CByte(249), CByte(255))
        btn_acount_settings.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(246), CByte(249), CByte(255))
        btn_acount_settings.FlatStyle = FlatStyle.Flat
        btn_acount_settings.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btn_acount_settings.ForeColor = Color.Black
        btn_acount_settings.ImageAlign = ContentAlignment.MiddleLeft
        btn_acount_settings.Location = New Point(300, 0)
        btn_acount_settings.Name = "btn_acount_settings"
        btn_acount_settings.Size = New Size(150, 50)
        btn_acount_settings.TabIndex = 14
        btn_acount_settings.Text = "&Account Settings"
        btn_acount_settings.UseVisualStyleBackColor = False
        ' 
        ' btn_update_profile
        ' 
        btn_update_profile.BackColor = Color.Transparent
        btn_update_profile.Cursor = Cursors.Hand
        btn_update_profile.Dock = DockStyle.Left
        btn_update_profile.FlatAppearance.BorderSize = 0
        btn_update_profile.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(246), CByte(249), CByte(255))
        btn_update_profile.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(246), CByte(249), CByte(255))
        btn_update_profile.FlatStyle = FlatStyle.Flat
        btn_update_profile.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btn_update_profile.ForeColor = Color.Black
        btn_update_profile.ImageAlign = ContentAlignment.MiddleLeft
        btn_update_profile.Location = New Point(150, 0)
        btn_update_profile.Name = "btn_update_profile"
        btn_update_profile.Size = New Size(150, 50)
        btn_update_profile.TabIndex = 13
        btn_update_profile.Text = "&Update Profile"
        btn_update_profile.UseVisualStyleBackColor = False
        ' 
        ' btn_overview
        ' 
        btn_overview.BackColor = Color.Transparent
        btn_overview.Cursor = Cursors.Hand
        btn_overview.Dock = DockStyle.Left
        btn_overview.FlatAppearance.BorderSize = 0
        btn_overview.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(246), CByte(249), CByte(255))
        btn_overview.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(246), CByte(249), CByte(255))
        btn_overview.FlatStyle = FlatStyle.Flat
        btn_overview.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btn_overview.ForeColor = Color.Blue
        btn_overview.ImageAlign = ContentAlignment.MiddleLeft
        btn_overview.Location = New Point(0, 0)
        btn_overview.Name = "btn_overview"
        btn_overview.Size = New Size(150, 50)
        btn_overview.TabIndex = 12
        btn_overview.Text = "&Overview"
        btn_overview.UseVisualStyleBackColor = False
        ' 
        ' Panel5
        ' 
        Panel5.Dock = DockStyle.Right
        Panel5.Location = New Point(1021, 0)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(25, 571)
        Panel5.TabIndex = 20
        ' 
        ' Panel3
        ' 
        Panel3.Dock = DockStyle.Left
        Panel3.Location = New Point(375, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(25, 571)
        Panel3.TabIndex = 19
        ' 
        ' pnl_user_details_and_image
        ' 
        pnl_user_details_and_image.BackColor = Color.Transparent
        pnl_user_details_and_image.Controls.Add(pnl_user_details)
        pnl_user_details_and_image.Dock = DockStyle.Left
        pnl_user_details_and_image.Location = New Point(25, 0)
        pnl_user_details_and_image.Name = "pnl_user_details_and_image"
        pnl_user_details_and_image.Size = New Size(350, 571)
        pnl_user_details_and_image.TabIndex = 18
        ' 
        ' pnl_user_details
        ' 
        pnl_user_details.BackColor = Color.White
        pnl_user_details.Controls.Add(lbl_user_details_position)
        pnl_user_details.Controls.Add(lbl_user_details_full_name)
        pnl_user_details.Controls.Add(img_user)
        pnl_user_details.Dock = DockStyle.Top
        pnl_user_details.Location = New Point(0, 0)
        pnl_user_details.Name = "pnl_user_details"
        pnl_user_details.Size = New Size(350, 247)
        pnl_user_details.TabIndex = 0
        ' 
        ' lbl_user_details_position
        ' 
        lbl_user_details_position.AutoSize = True
        lbl_user_details_position.BackColor = Color.Transparent
        lbl_user_details_position.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lbl_user_details_position.ForeColor = Color.Black
        lbl_user_details_position.Location = New Point(107, 182)
        lbl_user_details_position.Name = "lbl_user_details_position"
        lbl_user_details_position.Size = New Size(136, 20)
        lbl_user_details_position.TabIndex = 2
        lbl_user_details_position.Text = "Barangay Captain"
        ' 
        ' lbl_user_details_full_name
        ' 
        lbl_user_details_full_name.AutoSize = True
        lbl_user_details_full_name.BackColor = Color.Transparent
        lbl_user_details_full_name.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_user_details_full_name.ForeColor = Color.Black
        lbl_user_details_full_name.Location = New Point(65, 157)
        lbl_user_details_full_name.Name = "lbl_user_details_full_name"
        lbl_user_details_full_name.Size = New Size(220, 25)
        lbl_user_details_full_name.TabIndex = 1
        lbl_user_details_full_name.Text = "Super Administrator"
        ' 
        ' img_user
        ' 
        img_user.BorderStyle = BorderStyle.FixedSingle
        img_user.Image = CType(resources.GetObject("img_user.Image"), Image)
        img_user.Location = New Point(125, 49)
        img_user.Name = "img_user"
        img_user.Size = New Size(100, 100)
        img_user.SizeMode = PictureBoxSizeMode.StretchImage
        img_user.TabIndex = 0
        img_user.TabStop = False
        ' 
        ' Panel10
        ' 
        Panel10.Dock = DockStyle.Left
        Panel10.Location = New Point(0, 0)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(25, 571)
        Panel10.TabIndex = 17
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1046, 100)
        Panel1.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Cursor = Cursors.Hand
        Label4.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.FromArgb(CByte(137), CByte(155), CByte(195))
        Label4.Location = New Point(108, 57)
        Label4.Name = "Label4"
        Label4.Size = New Size(94, 16)
        Label4.TabIndex = 3
        Label4.Text = "/ Employees"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.FromArgb(CByte(81), CByte(103), CByte(172))
        Label3.Location = New Point(198, 57)
        Label3.Name = "Label3"
        Label3.Size = New Size(85, 16)
        Label3.TabIndex = 2
        Label3.Text = "/ My Profile"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Cursor = Cursors.Hand
        Label2.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(137), CByte(155), CByte(195))
        Label2.Location = New Point(28, 57)
        Label2.Name = "Label2"
        Label2.Size = New Size(84, 16)
        Label2.TabIndex = 1
        Label2.Text = "Dashboard"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(1), CByte(41), CByte(112))
        Label1.Location = New Point(25, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(90, 29)
        Label1.TabIndex = 0
        Label1.Text = "Profile"
        ' 
        ' Profile
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(246), CByte(249), CByte(255))
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Name = "Profile"
        Size = New Size(1046, 671)
        Panel2.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        pnl_overview_and_update_profile.ResumeLayout(False)
        Panel8.ResumeLayout(False)
        Panel7.ResumeLayout(False)
        pnl_user_details_and_image.ResumeLayout(False)
        pnl_user_details.ResumeLayout(False)
        pnl_user_details.PerformLayout()
        CType(img_user, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents pnl_overview_and_update_profile As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Overview As Overview
    Friend WithEvents Update_Profile As Update_Profile
    Friend WithEvents Panel7 As Panel
    Friend WithEvents btn_update_profile As Button
    Friend WithEvents btn_overview As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents pnl_user_details_and_image As Panel
    Friend WithEvents pnl_user_details As Panel
    Friend WithEvents lbl_user_details_position As Label
    Friend WithEvents lbl_user_details_full_name As Label
    Friend WithEvents img_user As PictureBox
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_acount_settings As Button
    Friend WithEvents Employee_Account_Settings As Employee_Account_Settings
End Class
