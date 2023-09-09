<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Account_Settings
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
        Panel1 = New Panel()
        lbl_title = New Label()
        Panel2 = New Panel()
        btn_close = New Button()
        btn_submit = New Button()
        Panel3 = New Panel()
        txt_confirm_password = New TextBox()
        Label5 = New Label()
        txt_password = New TextBox()
        Label4 = New Label()
        txt_username = New TextBox()
        Label3 = New Label()
        txt_rfid_number = New TextBox()
        Label2 = New Label()
        txt_fullname = New TextBox()
        Label1 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(lbl_title)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(374, 45)
        Panel1.TabIndex = 0
        ' 
        ' lbl_title
        ' 
        lbl_title.AutoSize = True
        lbl_title.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_title.Location = New Point(83, 9)
        lbl_title.Name = "lbl_title"
        lbl_title.Size = New Size(206, 24)
        lbl_title.TabIndex = 1
        lbl_title.Text = "Update your Account"
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(btn_close)
        Panel2.Controls.Add(btn_submit)
        Panel2.Dock = DockStyle.Bottom
        Panel2.Location = New Point(0, 396)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(374, 45)
        Panel2.TabIndex = 1
        ' 
        ' btn_close
        ' 
        btn_close.BackColor = Color.FromArgb(CByte(220), CByte(53), CByte(69))
        btn_close.Cursor = Cursors.Hand
        btn_close.FlatStyle = FlatStyle.Flat
        btn_close.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btn_close.ForeColor = Color.White
        btn_close.Location = New Point(129, 4)
        btn_close.Name = "btn_close"
        btn_close.Size = New Size(83, 34)
        btn_close.TabIndex = 5
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
        btn_submit.Location = New Point(218, 4)
        btn_submit.Name = "btn_submit"
        btn_submit.Size = New Size(143, 34)
        btn_submit.TabIndex = 6
        btn_submit.Text = "&Submit Changes"
        btn_submit.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(txt_confirm_password)
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(txt_password)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(txt_username)
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(txt_rfid_number)
        Panel3.Controls.Add(Label2)
        Panel3.Controls.Add(txt_fullname)
        Panel3.Controls.Add(Label1)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(0, 45)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(374, 351)
        Panel3.TabIndex = 2
        ' 
        ' txt_confirm_password
        ' 
        txt_confirm_password.BackColor = Color.White
        txt_confirm_password.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txt_confirm_password.ForeColor = Color.Gray
        txt_confirm_password.Location = New Point(24, 297)
        txt_confirm_password.Name = "txt_confirm_password"
        txt_confirm_password.Size = New Size(324, 26)
        txt_confirm_password.TabIndex = 4
        txt_confirm_password.Text = "Password is hidden for security"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(24, 274)
        Label5.Name = "Label5"
        Label5.Size = New Size(137, 20)
        Label5.TabIndex = 8
        Label5.Text = "Confirm Password"
        ' 
        ' txt_password
        ' 
        txt_password.BackColor = Color.White
        txt_password.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txt_password.ForeColor = Color.Gray
        txt_password.Location = New Point(24, 235)
        txt_password.Name = "txt_password"
        txt_password.Size = New Size(324, 26)
        txt_password.TabIndex = 3
        txt_password.Text = "Password is hidden for security"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(24, 212)
        Label4.Name = "Label4"
        Label4.Size = New Size(78, 20)
        Label4.TabIndex = 6
        Label4.Text = "Password"
        ' 
        ' txt_username
        ' 
        txt_username.BackColor = Color.White
        txt_username.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txt_username.Location = New Point(24, 173)
        txt_username.Name = "txt_username"
        txt_username.Size = New Size(324, 26)
        txt_username.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(24, 150)
        Label3.Name = "Label3"
        Label3.Size = New Size(83, 20)
        Label3.TabIndex = 4
        Label3.Text = "Username"
        ' 
        ' txt_rfid_number
        ' 
        txt_rfid_number.BackColor = Color.White
        txt_rfid_number.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txt_rfid_number.Location = New Point(24, 111)
        txt_rfid_number.Name = "txt_rfid_number"
        txt_rfid_number.Size = New Size(324, 26)
        txt_rfid_number.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(24, 88)
        Label2.Name = "Label2"
        Label2.Size = New Size(108, 20)
        Label2.TabIndex = 2
        Label2.Text = "RFID Number"
        ' 
        ' txt_fullname
        ' 
        txt_fullname.BackColor = Color.White
        txt_fullname.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txt_fullname.Location = New Point(24, 49)
        txt_fullname.Name = "txt_fullname"
        txt_fullname.ReadOnly = True
        txt_fullname.Size = New Size(324, 26)
        txt_fullname.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(24, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(80, 20)
        Label1.TabIndex = 0
        Label1.Text = "Full Name"
        ' 
        ' Account_Settings
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(374, 441)
        ControlBox = False
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.None
        Name = "Account_Settings"
        ShowIcon = False
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_title As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_submit As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btn_close As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_fullname As TextBox
    Friend WithEvents txt_rfid_number As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_confirm_password As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_password As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_username As TextBox
    Friend WithEvents Label3 As Label
End Class
