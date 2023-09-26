<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class View_Barangay_News
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(View_Barangay_News))
        Panel3 = New Panel()
        img_barangay_news_image = New PictureBox()
        lbl_barangay_news_date_and_time = New Label()
        lbl_barangay_news_body = New RichTextBox()
        lbl_barangay_news_title = New Label()
        Panel2 = New Panel()
        btn_close = New Button()
        Panel1 = New Panel()
        lbl_title = New Label()
        Panel3.SuspendLayout()
        CType(img_barangay_news_image, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel3
        ' 
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(img_barangay_news_image)
        Panel3.Controls.Add(lbl_barangay_news_date_and_time)
        Panel3.Controls.Add(lbl_barangay_news_body)
        Panel3.Controls.Add(lbl_barangay_news_title)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(0, 45)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(850, 610)
        Panel3.TabIndex = 9
        ' 
        ' img_barangay_news_image
        ' 
        img_barangay_news_image.BorderStyle = BorderStyle.FixedSingle
        img_barangay_news_image.Image = CType(resources.GetObject("img_barangay_news_image.Image"), Image)
        img_barangay_news_image.Location = New Point(11, 5)
        img_barangay_news_image.Name = "img_barangay_news_image"
        img_barangay_news_image.Size = New Size(826, 300)
        img_barangay_news_image.SizeMode = PictureBoxSizeMode.StretchImage
        img_barangay_news_image.TabIndex = 6
        img_barangay_news_image.TabStop = False
        ' 
        ' lbl_barangay_news_date_and_time
        ' 
        lbl_barangay_news_date_and_time.AutoSize = True
        lbl_barangay_news_date_and_time.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_barangay_news_date_and_time.ForeColor = Color.FromArgb(CByte(158), CByte(158), CByte(158))
        lbl_barangay_news_date_and_time.Location = New Point(11, 318)
        lbl_barangay_news_date_and_time.Name = "lbl_barangay_news_date_and_time"
        lbl_barangay_news_date_and_time.Size = New Size(202, 15)
        lbl_barangay_news_date_and_time.TabIndex = 3
        lbl_barangay_news_date_and_time.Text = "September 26, 2023 12:59 PM"
        ' 
        ' lbl_barangay_news_body
        ' 
        lbl_barangay_news_body.BackColor = Color.White
        lbl_barangay_news_body.BorderStyle = BorderStyle.None
        lbl_barangay_news_body.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lbl_barangay_news_body.Location = New Point(11, 371)
        lbl_barangay_news_body.Name = "lbl_barangay_news_body"
        lbl_barangay_news_body.ReadOnly = True
        lbl_barangay_news_body.Size = New Size(826, 232)
        lbl_barangay_news_body.TabIndex = 5
        lbl_barangay_news_body.Text = "Barangay News Body"
        ' 
        ' lbl_barangay_news_title
        ' 
        lbl_barangay_news_title.AutoSize = True
        lbl_barangay_news_title.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_barangay_news_title.Location = New Point(11, 343)
        lbl_barangay_news_title.Name = "lbl_barangay_news_title"
        lbl_barangay_news_title.Size = New Size(172, 20)
        lbl_barangay_news_title.TabIndex = 4
        lbl_barangay_news_title.Text = "Barangay News Title"
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(btn_close)
        Panel2.Dock = DockStyle.Bottom
        Panel2.Location = New Point(0, 655)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(850, 45)
        Panel2.TabIndex = 8
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
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(lbl_title)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(850, 45)
        Panel1.TabIndex = 7
        ' 
        ' lbl_title
        ' 
        lbl_title.AutoSize = True
        lbl_title.BackColor = Color.Transparent
        lbl_title.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_title.Location = New Point(347, 9)
        lbl_title.Name = "lbl_title"
        lbl_title.Size = New Size(155, 24)
        lbl_title.TabIndex = 1
        lbl_title.Text = "Barangay News"
        ' 
        ' View_Barangay_News
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(850, 700)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.None
        Name = "View_Barangay_News"
        ShowIcon = False
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(img_barangay_news_image, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents lbl_barangay_news_date_and_time As Label
    Friend WithEvents lbl_barangay_news_body As RichTextBox
    Friend WithEvents lbl_barangay_news_title As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_close As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_title As Label
    Friend WithEvents img_barangay_news_image As PictureBox
End Class
