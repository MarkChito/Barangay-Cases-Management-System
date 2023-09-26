<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_Announcement
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
        txt_announcement_body = New TextBox()
        Label2 = New Label()
        txt_announcement_title = New TextBox()
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
        Panel1.Size = New Size(700, 45)
        Panel1.TabIndex = 1
        ' 
        ' lbl_title
        ' 
        lbl_title.AutoSize = True
        lbl_title.BackColor = Color.Transparent
        lbl_title.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_title.Location = New Point(251, 9)
        lbl_title.Name = "lbl_title"
        lbl_title.Size = New Size(197, 24)
        lbl_title.TabIndex = 1
        lbl_title.Text = "Add Announcement"
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(btn_close)
        Panel2.Controls.Add(btn_submit)
        Panel2.Dock = DockStyle.Bottom
        Panel2.Location = New Point(0, 455)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(700, 45)
        Panel2.TabIndex = 2
        ' 
        ' btn_close
        ' 
        btn_close.BackColor = Color.FromArgb(CByte(220), CByte(53), CByte(69))
        btn_close.Cursor = Cursors.Hand
        btn_close.FlatStyle = FlatStyle.Flat
        btn_close.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btn_close.ForeColor = Color.White
        btn_close.Location = New Point(455, 4)
        btn_close.Name = "btn_close"
        btn_close.Size = New Size(83, 34)
        btn_close.TabIndex = 2
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
        btn_submit.Location = New Point(544, 4)
        btn_submit.Name = "btn_submit"
        btn_submit.Size = New Size(143, 34)
        btn_submit.TabIndex = 3
        btn_submit.Text = "&Submit Changes"
        btn_submit.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(txt_announcement_body)
        Panel3.Controls.Add(Label2)
        Panel3.Controls.Add(txt_announcement_title)
        Panel3.Controls.Add(Label1)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(0, 45)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(700, 410)
        Panel3.TabIndex = 3
        ' 
        ' txt_announcement_body
        ' 
        txt_announcement_body.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txt_announcement_body.Location = New Point(11, 97)
        txt_announcement_body.Multiline = True
        txt_announcement_body.Name = "txt_announcement_body"
        txt_announcement_body.Size = New Size(676, 306)
        txt_announcement_body.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(11, 74)
        Label2.Name = "Label2"
        Label2.Size = New Size(158, 20)
        Label2.TabIndex = 2
        Label2.Text = "Announcement Body"
        ' 
        ' txt_announcement_title
        ' 
        txt_announcement_title.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txt_announcement_title.Location = New Point(11, 35)
        txt_announcement_title.Name = "txt_announcement_title"
        txt_announcement_title.Size = New Size(676, 26)
        txt_announcement_title.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(11, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(151, 20)
        Label1.TabIndex = 0
        Label1.Text = "Announcement Title"
        ' 
        ' Add_Announcement
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(700, 500)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.None
        Name = "Add_Announcement"
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
    Friend WithEvents btn_close As Button
    Friend WithEvents btn_submit As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_announcement_title As TextBox
    Friend WithEvents txt_announcement_body As TextBox
    Friend WithEvents Label2 As Label
End Class
