<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class View_Announcements
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
        lbl_announcement_date_and_time = New Label()
        lbl_announcement_title = New Label()
        lbl_announcement_body = New RichTextBox()
        Panel3 = New Panel()
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
        Panel1.Size = New Size(850, 45)
        Panel1.TabIndex = 1
        ' 
        ' lbl_title
        ' 
        lbl_title.AutoSize = True
        lbl_title.BackColor = Color.Transparent
        lbl_title.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_title.Location = New Point(343, 9)
        lbl_title.Name = "lbl_title"
        lbl_title.Size = New Size(163, 24)
        lbl_title.TabIndex = 1
        lbl_title.Text = "Announcements"
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(btn_close)
        Panel2.Dock = DockStyle.Bottom
        Panel2.Location = New Point(0, 555)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(850, 45)
        Panel2.TabIndex = 2
        ' 
        ' btn_close
        ' 
        btn_close.BackColor = Color.FromArgb(CByte(220), CByte(53), CByte(69))
        btn_close.Cursor = Cursors.Hand
        btn_close.FlatStyle = FlatStyle.Flat
        btn_close.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btn_close.ForeColor = Color.White
        btn_close.Location = New Point(754, 4)
        btn_close.Name = "btn_close"
        btn_close.Size = New Size(83, 34)
        btn_close.TabIndex = 5
        btn_close.Text = "&Close"
        btn_close.UseVisualStyleBackColor = False
        ' 
        ' lbl_announcement_date_and_time
        ' 
        lbl_announcement_date_and_time.AutoSize = True
        lbl_announcement_date_and_time.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_announcement_date_and_time.ForeColor = Color.FromArgb(CByte(158), CByte(158), CByte(158))
        lbl_announcement_date_and_time.Location = New Point(11, 12)
        lbl_announcement_date_and_time.Name = "lbl_announcement_date_and_time"
        lbl_announcement_date_and_time.Size = New Size(202, 15)
        lbl_announcement_date_and_time.TabIndex = 3
        lbl_announcement_date_and_time.Text = "September 26, 2023 12:59 PM"
        ' 
        ' lbl_announcement_title
        ' 
        lbl_announcement_title.AutoSize = True
        lbl_announcement_title.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_announcement_title.Location = New Point(11, 37)
        lbl_announcement_title.Name = "lbl_announcement_title"
        lbl_announcement_title.Size = New Size(169, 20)
        lbl_announcement_title.TabIndex = 4
        lbl_announcement_title.Text = "Announcement Title"
        ' 
        ' lbl_announcement_body
        ' 
        lbl_announcement_body.BackColor = Color.White
        lbl_announcement_body.BorderStyle = BorderStyle.None
        lbl_announcement_body.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lbl_announcement_body.Location = New Point(11, 75)
        lbl_announcement_body.Name = "lbl_announcement_body"
        lbl_announcement_body.ReadOnly = True
        lbl_announcement_body.Size = New Size(826, 428)
        lbl_announcement_body.TabIndex = 5
        lbl_announcement_body.Text = "Announcement Body"
        ' 
        ' Panel3
        ' 
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(lbl_announcement_date_and_time)
        Panel3.Controls.Add(lbl_announcement_body)
        Panel3.Controls.Add(lbl_announcement_title)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(0, 45)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(850, 510)
        Panel3.TabIndex = 6
        ' 
        ' View_Announcements
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(850, 600)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.None
        Name = "View_Announcements"
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
    Friend WithEvents lbl_announcement_date_and_time As Label
    Friend WithEvents lbl_announcement_title As Label
    Friend WithEvents lbl_announcement_body As RichTextBox
    Friend WithEvents Panel3 As Panel
End Class
