<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit_Barangay_Case
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Edit_Barangay_Case))
        Panel1 = New Panel()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel5 = New Panel()
        Panel4 = New Panel()
        Panel2 = New Panel()
        Label5 = New Label()
        Panel3 = New Panel()
        lbl_primary_key = New Label()
        btn_next = New Button()
        Panel7 = New Panel()
        Panel6 = New Panel()
        pnl_parent = New Panel()
        Panel9 = New Panel()
        pnl_mobile_number = New Panel()
        Label7 = New Label()
        txt_mobile_number = New TextBox()
        pnl_full_name = New Panel()
        Label6 = New Label()
        txt_full_name = New TextBox()
        Label10 = New Label()
        txt_description = New TextBox()
        Label9 = New Label()
        txt_nature_of_complaint = New ComboBox()
        Label8 = New Label()
        txt_address = New TextBox()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        pnl_parent.SuspendLayout()
        Panel9.SuspendLayout()
        pnl_mobile_number.SuspendLayout()
        pnl_full_name.SuspendLayout()
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
        Label4.Size = New Size(121, 16)
        Label4.TabIndex = 11
        Label4.Text = "/ Pending Cases"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.FromArgb(CByte(81), CByte(103), CByte(172))
        Label3.Location = New Point(229, 57)
        Label3.Name = "Label3"
        Label3.Size = New Size(154, 16)
        Label3.TabIndex = 2
        Label3.Text = "/ Edit Barangay Case"
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
        Label1.Size = New Size(242, 29)
        Label1.TabIndex = 0
        Label1.Text = "Edit Barangay Case"
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
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(Label5)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(30, 100)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(986, 50)
        Panel2.TabIndex = 18
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = Color.FromArgb(CByte(1), CByte(41), CByte(112))
        Label5.Location = New Point(5, 12)
        Label5.Name = "Label5"
        Label5.Size = New Size(177, 25)
        Label5.TabIndex = 0
        Label5.Text = "Basic Information"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.Controls.Add(lbl_primary_key)
        Panel3.Controls.Add(btn_next)
        Panel3.Dock = DockStyle.Bottom
        Panel3.Location = New Point(30, 621)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(986, 50)
        Panel3.TabIndex = 17
        ' 
        ' lbl_primary_key
        ' 
        lbl_primary_key.AutoSize = True
        lbl_primary_key.Location = New Point(30, 17)
        lbl_primary_key.Name = "lbl_primary_key"
        lbl_primary_key.Size = New Size(84, 15)
        lbl_primary_key.TabIndex = 10
        lbl_primary_key.Text = "Do Not Delete"
        lbl_primary_key.Visible = False
        ' 
        ' btn_next
        ' 
        btn_next.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btn_next.BackColor = Color.FromArgb(CByte(13), CByte(110), CByte(253))
        btn_next.Cursor = Cursors.Hand
        btn_next.FlatStyle = FlatStyle.Flat
        btn_next.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btn_next.ForeColor = Color.White
        btn_next.Image = CType(resources.GetObject("btn_next.Image"), Image)
        btn_next.ImageAlign = ContentAlignment.MiddleRight
        btn_next.Location = New Point(851, 8)
        btn_next.Name = "btn_next"
        btn_next.Padding = New Padding(15, 0, 15, 0)
        btn_next.Size = New Size(105, 35)
        btn_next.TabIndex = 6
        btn_next.Text = "&Next"
        btn_next.TextAlign = ContentAlignment.MiddleLeft
        btn_next.UseVisualStyleBackColor = False
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
        ' Panel6
        ' 
        Panel6.BackColor = Color.FromArgb(CByte(246), CByte(249), CByte(255))
        Panel6.Dock = DockStyle.Bottom
        Panel6.Location = New Point(30, 615)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(986, 6)
        Panel6.TabIndex = 19
        ' 
        ' pnl_parent
        ' 
        pnl_parent.BackColor = Color.White
        pnl_parent.Controls.Add(Panel9)
        pnl_parent.Controls.Add(Label10)
        pnl_parent.Controls.Add(txt_description)
        pnl_parent.Controls.Add(Label9)
        pnl_parent.Controls.Add(txt_nature_of_complaint)
        pnl_parent.Controls.Add(Label8)
        pnl_parent.Controls.Add(txt_address)
        pnl_parent.Dock = DockStyle.Fill
        pnl_parent.Location = New Point(30, 156)
        pnl_parent.Name = "pnl_parent"
        pnl_parent.Size = New Size(986, 459)
        pnl_parent.TabIndex = 21
        ' 
        ' Panel9
        ' 
        Panel9.Controls.Add(pnl_mobile_number)
        Panel9.Controls.Add(pnl_full_name)
        Panel9.Dock = DockStyle.Top
        Panel9.Location = New Point(0, 0)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(986, 72)
        Panel9.TabIndex = 29
        ' 
        ' pnl_mobile_number
        ' 
        pnl_mobile_number.Controls.Add(Label7)
        pnl_mobile_number.Controls.Add(txt_mobile_number)
        pnl_mobile_number.Dock = DockStyle.Left
        pnl_mobile_number.Location = New Point(493, 0)
        pnl_mobile_number.Name = "pnl_mobile_number"
        pnl_mobile_number.Size = New Size(493, 72)
        pnl_mobile_number.TabIndex = 1
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(13, 13)
        Label7.Name = "Label7"
        Label7.Size = New Size(115, 20)
        Label7.TabIndex = 22
        Label7.Text = "Mobile Number"
        ' 
        ' txt_mobile_number
        ' 
        txt_mobile_number.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txt_mobile_number.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txt_mobile_number.Location = New Point(13, 36)
        txt_mobile_number.Name = "txt_mobile_number"
        txt_mobile_number.Size = New Size(450, 26)
        txt_mobile_number.TabIndex = 1
        ' 
        ' pnl_full_name
        ' 
        pnl_full_name.Controls.Add(Label6)
        pnl_full_name.Controls.Add(txt_full_name)
        pnl_full_name.Dock = DockStyle.Left
        pnl_full_name.Location = New Point(0, 0)
        pnl_full_name.Name = "pnl_full_name"
        pnl_full_name.Size = New Size(493, 72)
        pnl_full_name.TabIndex = 0
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(30, 13)
        Label6.Name = "Label6"
        Label6.Size = New Size(80, 20)
        Label6.TabIndex = 20
        Label6.Text = "Full Name"
        ' 
        ' txt_full_name
        ' 
        txt_full_name.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txt_full_name.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txt_full_name.Location = New Point(30, 36)
        txt_full_name.Name = "txt_full_name"
        txt_full_name.Size = New Size(450, 26)
        txt_full_name.TabIndex = 0
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(30, 305)
        Label10.Name = "Label10"
        Label10.Size = New Size(89, 20)
        Label10.TabIndex = 28
        Label10.Text = "Description"
        ' 
        ' txt_description
        ' 
        txt_description.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txt_description.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txt_description.Location = New Point(30, 328)
        txt_description.Multiline = True
        txt_description.Name = "txt_description"
        txt_description.Size = New Size(926, 127)
        txt_description.TabIndex = 4
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(30, 241)
        Label9.Name = "Label9"
        Label9.Size = New Size(150, 20)
        Label9.TabIndex = 26
        Label9.Text = "Nature of Complaint"
        ' 
        ' txt_nature_of_complaint
        ' 
        txt_nature_of_complaint.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txt_nature_of_complaint.BackColor = Color.White
        txt_nature_of_complaint.DropDownStyle = ComboBoxStyle.DropDownList
        txt_nature_of_complaint.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txt_nature_of_complaint.FormattingEnabled = True
        txt_nature_of_complaint.Items.AddRange(New Object() {"Accident                                        ", "Curfew Violation", "Harassment or Threats (Blotter)Noise Disturbance", "Illegal Dumping and Garbage", "Public Health and Sanitation", "Vandalism and Graffiti", "Public Safety Concerns", "Traffic Violations", "Property Disputes", "Public Nuisance", "Business Permits and Licenses", "Environmental Concerns", "Animal Control", "Disputes and Conflict Resolution", "Social Welfare and Assistance", "Other (Write the details in the description box)"})
        txt_nature_of_complaint.Location = New Point(30, 264)
        txt_nature_of_complaint.Name = "txt_nature_of_complaint"
        txt_nature_of_complaint.Size = New Size(926, 28)
        txt_nature_of_complaint.TabIndex = 3
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(30, 75)
        Label8.Name = "Label8"
        Label8.Size = New Size(68, 20)
        Label8.TabIndex = 24
        Label8.Text = "Address"
        ' 
        ' txt_address
        ' 
        txt_address.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txt_address.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txt_address.Location = New Point(30, 98)
        txt_address.Multiline = True
        txt_address.Name = "txt_address"
        txt_address.Size = New Size(926, 130)
        txt_address.TabIndex = 2
        ' 
        ' Edit_Barangay_Case
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(246), CByte(249), CByte(255))
        Controls.Add(pnl_parent)
        Controls.Add(Panel7)
        Controls.Add(Panel6)
        Controls.Add(Panel2)
        Controls.Add(Panel3)
        Controls.Add(Panel5)
        Controls.Add(Panel4)
        Controls.Add(Panel1)
        Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Name = "Edit_Barangay_Case"
        Size = New Size(1046, 671)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        pnl_parent.ResumeLayout(False)
        pnl_parent.PerformLayout()
        Panel9.ResumeLayout(False)
        pnl_mobile_number.ResumeLayout(False)
        pnl_mobile_number.PerformLayout()
        pnl_full_name.ResumeLayout(False)
        pnl_full_name.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel3 As Panel
    'Friend WithEvents btn_next As Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents pnl_parent As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents pnl_mobile_number As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_mobile_number As TextBox
    Friend WithEvents pnl_full_name As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_full_name As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_description As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_nature_of_complaint As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_address As TextBox
    Friend WithEvents btn_next As Button
    Friend WithEvents lbl_primary_key As Label
End Class
