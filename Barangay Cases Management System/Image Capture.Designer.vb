<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Image_Capture
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Image_Capture))
        Panel1 = New Panel()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel5 = New Panel()
        Panel4 = New Panel()
        Panel3 = New Panel()
        btn_previous = New Button()
        btn_submit = New Button()
        Panel6 = New Panel()
        Panel2 = New Panel()
        Label6 = New Label()
        Label5 = New Label()
        Panel7 = New Panel()
        pnl_parent = New Panel()
        pnl_capture_image = New Panel()
        lbl_no_image = New Label()
        img_captured_image = New PictureBox()
        Panel15 = New Panel()
        Panel12 = New Panel()
        Panel14 = New Panel()
        btn_capture_image = New Button()
        Panel13 = New Panel()
        Label8 = New Label()
        Panel9 = New Panel()
        pnl_webcam_preview = New Panel()
        lbl_camera_is_off = New Label()
        img_live_camera = New PictureBox()
        Panel11 = New Panel()
        Panel8 = New Panel()
        pnl_camera_buttons = New Panel()
        btn_stop_webcam = New Button()
        btn_start_webcam = New Button()
        Panel10 = New Panel()
        Label7 = New Label()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        pnl_parent.SuspendLayout()
        pnl_capture_image.SuspendLayout()
        CType(img_captured_image, ComponentModel.ISupportInitialize).BeginInit()
        Panel14.SuspendLayout()
        Panel13.SuspendLayout()
        pnl_webcam_preview.SuspendLayout()
        CType(img_live_camera, ComponentModel.ISupportInitialize).BeginInit()
        pnl_camera_buttons.SuspendLayout()
        Panel10.SuspendLayout()
        SuspendLayout()
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
        Label4.Location = New Point(110, 57)
        Label4.Name = "Label4"
        Label4.Size = New Size(131, 16)
        Label4.TabIndex = 11
        Label4.Text = "/ Barangay Cases"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.FromArgb(CByte(81), CByte(103), CByte(172))
        Label3.Location = New Point(239, 57)
        Label3.Name = "Label3"
        Label3.Size = New Size(157, 16)
        Label3.TabIndex = 2
        Label3.Text = "/ New Barangay Case"
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
        Label1.Size = New Size(249, 29)
        Label1.TabIndex = 0
        Label1.Text = "New Barangay Case"
        ' 
        ' Panel5
        ' 
        Panel5.Dock = DockStyle.Right
        Panel5.Location = New Point(1016, 100)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(30, 571)
        Panel5.TabIndex = 16
        ' 
        ' Panel4
        ' 
        Panel4.Dock = DockStyle.Left
        Panel4.Location = New Point(0, 100)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(30, 571)
        Panel4.TabIndex = 15
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.Controls.Add(btn_previous)
        Panel3.Controls.Add(btn_submit)
        Panel3.Dock = DockStyle.Bottom
        Panel3.Location = New Point(30, 621)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(986, 50)
        Panel3.TabIndex = 17
        ' 
        ' btn_previous
        ' 
        btn_previous.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btn_previous.BackColor = Color.FromArgb(CByte(13), CByte(110), CByte(253))
        btn_previous.Cursor = Cursors.Hand
        btn_previous.FlatStyle = FlatStyle.Flat
        btn_previous.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btn_previous.ForeColor = Color.White
        btn_previous.Image = CType(resources.GetObject("btn_previous.Image"), Image)
        btn_previous.ImageAlign = ContentAlignment.MiddleLeft
        btn_previous.Location = New Point(720, 8)
        btn_previous.Name = "btn_previous"
        btn_previous.Padding = New Padding(15, 0, 15, 0)
        btn_previous.Size = New Size(132, 35)
        btn_previous.TabIndex = 7
        btn_previous.Text = "&Previous"
        btn_previous.TextAlign = ContentAlignment.MiddleRight
        btn_previous.UseVisualStyleBackColor = False
        ' 
        ' btn_submit
        ' 
        btn_submit.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btn_submit.BackColor = Color.FromArgb(CByte(25), CByte(135), CByte(84))
        btn_submit.Cursor = Cursors.Hand
        btn_submit.FlatStyle = FlatStyle.Flat
        btn_submit.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btn_submit.ForeColor = Color.White
        btn_submit.Image = CType(resources.GetObject("btn_submit.Image"), Image)
        btn_submit.ImageAlign = ContentAlignment.MiddleLeft
        btn_submit.Location = New Point(858, 8)
        btn_submit.Name = "btn_submit"
        btn_submit.Padding = New Padding(15, 0, 15, 0)
        btn_submit.Size = New Size(122, 35)
        btn_submit.TabIndex = 6
        btn_submit.Text = "&Submit"
        btn_submit.TextAlign = ContentAlignment.MiddleRight
        btn_submit.UseVisualStyleBackColor = False
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.FromArgb(CByte(246), CByte(249), CByte(255))
        Panel6.Dock = DockStyle.Bottom
        Panel6.Location = New Point(30, 615)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(986, 6)
        Panel6.TabIndex = 18
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label5)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(30, 100)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(986, 50)
        Panel2.TabIndex = 19
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.ForeColor = Color.Gray
        Label6.Location = New Point(142, 12)
        Label6.Name = "Label6"
        Label6.Size = New Size(158, 25)
        Label6.TabIndex = 1
        Label6.Text = "(Use WebCam)"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = Color.FromArgb(CByte(1), CByte(41), CByte(112))
        Label5.Location = New Point(6, 12)
        Label5.Name = "Label5"
        Label5.Size = New Size(144, 25)
        Label5.TabIndex = 0
        Label5.Text = "Upload Image"
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.FromArgb(CByte(246), CByte(249), CByte(255))
        Panel7.Dock = DockStyle.Top
        Panel7.Location = New Point(30, 150)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(986, 6)
        Panel7.TabIndex = 20
        ' 
        ' pnl_parent
        ' 
        pnl_parent.BackColor = Color.White
        pnl_parent.Controls.Add(pnl_capture_image)
        pnl_parent.Controls.Add(Panel9)
        pnl_parent.Controls.Add(pnl_webcam_preview)
        pnl_parent.Dock = DockStyle.Fill
        pnl_parent.Location = New Point(30, 156)
        pnl_parent.Name = "pnl_parent"
        pnl_parent.Size = New Size(986, 459)
        pnl_parent.TabIndex = 21
        ' 
        ' pnl_capture_image
        ' 
        pnl_capture_image.Controls.Add(lbl_no_image)
        pnl_capture_image.Controls.Add(img_captured_image)
        pnl_capture_image.Controls.Add(Panel15)
        pnl_capture_image.Controls.Add(Panel12)
        pnl_capture_image.Controls.Add(Panel14)
        pnl_capture_image.Controls.Add(Panel13)
        pnl_capture_image.Dock = DockStyle.Right
        pnl_capture_image.Location = New Point(496, 0)
        pnl_capture_image.Name = "pnl_capture_image"
        pnl_capture_image.Size = New Size(490, 459)
        pnl_capture_image.TabIndex = 2
        ' 
        ' lbl_no_image
        ' 
        lbl_no_image.AutoSize = True
        lbl_no_image.Font = New Font("Microsoft Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_no_image.ForeColor = Color.Gray
        lbl_no_image.Location = New Point(125, 202)
        lbl_no_image.Name = "lbl_no_image"
        lbl_no_image.Size = New Size(241, 55)
        lbl_no_image.TabIndex = 6
        lbl_no_image.Text = "No Image"
        ' 
        ' img_captured_image
        ' 
        img_captured_image.Dock = DockStyle.Fill
        img_captured_image.Location = New Point(0, 53)
        img_captured_image.Name = "img_captured_image"
        img_captured_image.Size = New Size(490, 353)
        img_captured_image.SizeMode = PictureBoxSizeMode.StretchImage
        img_captured_image.TabIndex = 5
        img_captured_image.TabStop = False
        ' 
        ' Panel15
        ' 
        Panel15.BackColor = Color.FromArgb(CByte(246), CByte(249), CByte(255))
        Panel15.Dock = DockStyle.Bottom
        Panel15.Location = New Point(0, 406)
        Panel15.Name = "Panel15"
        Panel15.Size = New Size(490, 3)
        Panel15.TabIndex = 4
        ' 
        ' Panel12
        ' 
        Panel12.BackColor = Color.FromArgb(CByte(246), CByte(249), CByte(255))
        Panel12.Dock = DockStyle.Top
        Panel12.Location = New Point(0, 50)
        Panel12.Name = "Panel12"
        Panel12.Size = New Size(490, 3)
        Panel12.TabIndex = 3
        ' 
        ' Panel14
        ' 
        Panel14.Controls.Add(btn_capture_image)
        Panel14.Dock = DockStyle.Bottom
        Panel14.Location = New Point(0, 409)
        Panel14.Name = "Panel14"
        Panel14.Size = New Size(490, 50)
        Panel14.TabIndex = 2
        ' 
        ' btn_capture_image
        ' 
        btn_capture_image.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btn_capture_image.BackColor = Color.FromArgb(CByte(13), CByte(110), CByte(253))
        btn_capture_image.Cursor = Cursors.No
        btn_capture_image.Enabled = False
        btn_capture_image.FlatStyle = FlatStyle.Flat
        btn_capture_image.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btn_capture_image.ForeColor = Color.White
        btn_capture_image.Location = New Point(6, 8)
        btn_capture_image.Name = "btn_capture_image"
        btn_capture_image.Padding = New Padding(15, 0, 15, 0)
        btn_capture_image.Size = New Size(478, 35)
        btn_capture_image.TabIndex = 8
        btn_capture_image.Text = "&Capture Image"
        btn_capture_image.UseVisualStyleBackColor = False
        ' 
        ' Panel13
        ' 
        Panel13.Controls.Add(Label8)
        Panel13.Dock = DockStyle.Top
        Panel13.Location = New Point(0, 0)
        Panel13.Name = "Panel13"
        Panel13.Size = New Size(490, 50)
        Panel13.TabIndex = 1
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.ForeColor = Color.FromArgb(CByte(121), CByte(142), CByte(196))
        Label8.Location = New Point(6, 15)
        Label8.Name = "Label8"
        Label8.Size = New Size(124, 20)
        Label8.TabIndex = 0
        Label8.Text = "Captured Image"
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = Color.FromArgb(CByte(246), CByte(249), CByte(255))
        Panel9.Dock = DockStyle.Left
        Panel9.Location = New Point(490, 0)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(6, 459)
        Panel9.TabIndex = 1
        ' 
        ' pnl_webcam_preview
        ' 
        pnl_webcam_preview.Controls.Add(lbl_camera_is_off)
        pnl_webcam_preview.Controls.Add(img_live_camera)
        pnl_webcam_preview.Controls.Add(Panel11)
        pnl_webcam_preview.Controls.Add(Panel8)
        pnl_webcam_preview.Controls.Add(pnl_camera_buttons)
        pnl_webcam_preview.Controls.Add(Panel10)
        pnl_webcam_preview.Dock = DockStyle.Left
        pnl_webcam_preview.Location = New Point(0, 0)
        pnl_webcam_preview.Name = "pnl_webcam_preview"
        pnl_webcam_preview.Size = New Size(490, 459)
        pnl_webcam_preview.TabIndex = 0
        ' 
        ' lbl_camera_is_off
        ' 
        lbl_camera_is_off.AutoSize = True
        lbl_camera_is_off.Font = New Font("Microsoft Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_camera_is_off.ForeColor = Color.Gray
        lbl_camera_is_off.Location = New Point(79, 202)
        lbl_camera_is_off.Name = "lbl_camera_is_off"
        lbl_camera_is_off.Size = New Size(332, 55)
        lbl_camera_is_off.TabIndex = 5
        lbl_camera_is_off.Text = "Camera is Off"
        ' 
        ' img_live_camera
        ' 
        img_live_camera.Dock = DockStyle.Fill
        img_live_camera.Location = New Point(0, 53)
        img_live_camera.Name = "img_live_camera"
        img_live_camera.Size = New Size(490, 353)
        img_live_camera.SizeMode = PictureBoxSizeMode.StretchImage
        img_live_camera.TabIndex = 4
        img_live_camera.TabStop = False
        ' 
        ' Panel11
        ' 
        Panel11.BackColor = Color.FromArgb(CByte(246), CByte(249), CByte(255))
        Panel11.Dock = DockStyle.Bottom
        Panel11.Location = New Point(0, 406)
        Panel11.Name = "Panel11"
        Panel11.Size = New Size(490, 3)
        Panel11.TabIndex = 3
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.FromArgb(CByte(246), CByte(249), CByte(255))
        Panel8.Dock = DockStyle.Top
        Panel8.Location = New Point(0, 50)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(490, 3)
        Panel8.TabIndex = 2
        ' 
        ' pnl_camera_buttons
        ' 
        pnl_camera_buttons.Controls.Add(btn_stop_webcam)
        pnl_camera_buttons.Controls.Add(btn_start_webcam)
        pnl_camera_buttons.Dock = DockStyle.Bottom
        pnl_camera_buttons.Location = New Point(0, 409)
        pnl_camera_buttons.Name = "pnl_camera_buttons"
        pnl_camera_buttons.Size = New Size(490, 50)
        pnl_camera_buttons.TabIndex = 1
        ' 
        ' btn_stop_webcam
        ' 
        btn_stop_webcam.BackColor = Color.FromArgb(CByte(220), CByte(53), CByte(69))
        btn_stop_webcam.Cursor = Cursors.No
        btn_stop_webcam.Enabled = False
        btn_stop_webcam.FlatStyle = FlatStyle.Flat
        btn_stop_webcam.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btn_stop_webcam.ForeColor = Color.White
        btn_stop_webcam.Location = New Point(249, 8)
        btn_stop_webcam.Name = "btn_stop_webcam"
        btn_stop_webcam.Padding = New Padding(15, 0, 15, 0)
        btn_stop_webcam.Size = New Size(235, 35)
        btn_stop_webcam.TabIndex = 9
        btn_stop_webcam.Text = "S&top Webcam"
        btn_stop_webcam.UseVisualStyleBackColor = False
        ' 
        ' btn_start_webcam
        ' 
        btn_start_webcam.BackColor = Color.FromArgb(CByte(13), CByte(110), CByte(253))
        btn_start_webcam.Cursor = Cursors.Hand
        btn_start_webcam.FlatStyle = FlatStyle.Flat
        btn_start_webcam.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btn_start_webcam.ForeColor = Color.White
        btn_start_webcam.Location = New Point(6, 8)
        btn_start_webcam.Name = "btn_start_webcam"
        btn_start_webcam.Padding = New Padding(15, 0, 15, 0)
        btn_start_webcam.Size = New Size(235, 35)
        btn_start_webcam.TabIndex = 8
        btn_start_webcam.Text = "Start &Webcam"
        btn_start_webcam.UseVisualStyleBackColor = False
        ' 
        ' Panel10
        ' 
        Panel10.Controls.Add(Label7)
        Panel10.Dock = DockStyle.Top
        Panel10.Location = New Point(0, 0)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(490, 50)
        Panel10.TabIndex = 0
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.ForeColor = Color.FromArgb(CByte(121), CByte(142), CByte(196))
        Label7.Location = New Point(6, 15)
        Label7.Name = "Label7"
        Label7.Size = New Size(130, 20)
        Label7.TabIndex = 0
        Label7.Text = "Webcam Preview"
        ' 
        ' Image_Capture
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(246), CByte(249), CByte(255))
        Controls.Add(pnl_parent)
        Controls.Add(Panel7)
        Controls.Add(Panel2)
        Controls.Add(Panel6)
        Controls.Add(Panel3)
        Controls.Add(Panel5)
        Controls.Add(Panel4)
        Controls.Add(Panel1)
        MinimumSize = New Size(1046, 671)
        Name = "Image_Capture"
        Size = New Size(1046, 671)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        pnl_parent.ResumeLayout(False)
        pnl_capture_image.ResumeLayout(False)
        pnl_capture_image.PerformLayout()
        CType(img_captured_image, ComponentModel.ISupportInitialize).EndInit()
        Panel14.ResumeLayout(False)
        Panel13.ResumeLayout(False)
        Panel13.PerformLayout()
        pnl_webcam_preview.ResumeLayout(False)
        pnl_webcam_preview.PerformLayout()
        CType(img_live_camera, ComponentModel.ISupportInitialize).EndInit()
        pnl_camera_buttons.ResumeLayout(False)
        Panel10.ResumeLayout(False)
        Panel10.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    'Friend WithEvents btn_new_employee As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    'Friend WithEvents btn_next As Button
    Friend WithEvents btn_submit As Button
    Friend WithEvents Panel6 As Panel
    'Friend WithEvents Button2 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_previous As Button
    Friend WithEvents pnl_parent As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents pnl_webcam_preview As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents pnl_camera_buttons As Panel
    Friend WithEvents btn_start_webcam As Button
    Friend WithEvents btn_stop_webcam As Button
    Friend WithEvents pnl_capture_image As Panel
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel14 As Panel
    'Friend WithEvents Button3 As Button
    Friend WithEvents btn_capture_image As Button
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel15 As Panel
    Friend WithEvents Panel12 As Panel
    Friend WithEvents img_live_camera As PictureBox
    Friend WithEvents lbl_camera_is_off As Label
    Friend WithEvents img_captured_image As PictureBox
    Friend WithEvents lbl_no_image As Label
End Class
