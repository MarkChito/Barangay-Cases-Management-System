<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class View_Barangay_Case
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(View_Barangay_Case))
        Panel2 = New Panel()
        btn_close = New Button()
        Panel1 = New Panel()
        lbl_title = New Label()
        Panel3 = New Panel()
        lbl_address = New Label()
        lbl_mobile_number = New Label()
        lbl_nature_of_complaint = New Label()
        lbl_description = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        lbl_name = New Label()
        Label2 = New Label()
        lbl_date_and_time = New Label()
        img_barangay_case_image = New PictureBox()
        lbl_barangay_news_title = New Label()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        CType(img_barangay_case_image, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(btn_close)
        Panel2.Dock = DockStyle.Bottom
        Panel2.Location = New Point(0, 655)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(850, 45)
        Panel2.TabIndex = 10
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
        Panel1.TabIndex = 9
        ' 
        ' lbl_title
        ' 
        lbl_title.AutoSize = True
        lbl_title.BackColor = Color.Transparent
        lbl_title.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_title.Location = New Point(315, 9)
        lbl_title.Name = "lbl_title"
        lbl_title.Size = New Size(218, 24)
        lbl_title.TabIndex = 1
        lbl_title.Text = "Barangay Case Details"
        ' 
        ' Panel3
        ' 
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(lbl_address)
        Panel3.Controls.Add(lbl_mobile_number)
        Panel3.Controls.Add(lbl_nature_of_complaint)
        Panel3.Controls.Add(lbl_description)
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(lbl_name)
        Panel3.Controls.Add(Label2)
        Panel3.Controls.Add(lbl_date_and_time)
        Panel3.Controls.Add(img_barangay_case_image)
        Panel3.Controls.Add(lbl_barangay_news_title)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(0, 45)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(850, 610)
        Panel3.TabIndex = 11
        ' 
        ' lbl_address
        ' 
        lbl_address.AutoSize = True
        lbl_address.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lbl_address.Location = New Point(191, 448)
        lbl_address.Name = "lbl_address"
        lbl_address.Size = New Size(238, 20)
        lbl_address.TabIndex = 17
        lbl_address.Text = "Brgy. San Jose, Montalban Rizal"
        ' 
        ' lbl_mobile_number
        ' 
        lbl_mobile_number.AutoSize = True
        lbl_mobile_number.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lbl_mobile_number.Location = New Point(191, 408)
        lbl_mobile_number.Name = "lbl_mobile_number"
        lbl_mobile_number.Size = New Size(108, 20)
        lbl_mobile_number.TabIndex = 16
        lbl_mobile_number.Text = "09123456789"
        ' 
        ' lbl_nature_of_complaint
        ' 
        lbl_nature_of_complaint.AutoSize = True
        lbl_nature_of_complaint.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lbl_nature_of_complaint.Location = New Point(191, 488)
        lbl_nature_of_complaint.Name = "lbl_nature_of_complaint"
        lbl_nature_of_complaint.Size = New Size(110, 20)
        lbl_nature_of_complaint.TabIndex = 15
        lbl_nature_of_complaint.Text = "Animal Cruelty"
        ' 
        ' lbl_description
        ' 
        lbl_description.BackColor = Color.White
        lbl_description.BorderStyle = BorderStyle.None
        lbl_description.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lbl_description.Location = New Point(191, 528)
        lbl_description.Multiline = True
        lbl_description.Name = "lbl_description"
        lbl_description.ReadOnly = True
        lbl_description.Size = New Size(646, 75)
        lbl_description.TabIndex = 14
        lbl_description.Text = " Nangagat ng Aso!"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(11, 528)
        Label6.Name = "Label6"
        Label6.Size = New Size(105, 20)
        Label6.TabIndex = 13
        Label6.Text = "Description:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(11, 488)
        Label5.Name = "Label5"
        Label5.Size = New Size(174, 20)
        Label5.TabIndex = 12
        Label5.Text = "Nature of Complaint:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(11, 448)
        Label4.Name = "Label4"
        Label4.Size = New Size(80, 20)
        Label4.TabIndex = 11
        Label4.Text = "Address:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(11, 408)
        Label3.Name = "Label3"
        Label3.Size = New Size(133, 20)
        Label3.TabIndex = 10
        Label3.Text = "Mobile Number:"
        ' 
        ' lbl_name
        ' 
        lbl_name.AutoSize = True
        lbl_name.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lbl_name.Location = New Point(191, 368)
        lbl_name.Name = "lbl_name"
        lbl_name.Size = New Size(118, 20)
        lbl_name.TabIndex = 9
        lbl_name.Text = "Juan Dela Cruz"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(11, 368)
        Label2.Name = "Label2"
        Label2.Size = New Size(94, 20)
        Label2.TabIndex = 8
        Label2.Text = "Full Name:"
        ' 
        ' lbl_date_and_time
        ' 
        lbl_date_and_time.AutoSize = True
        lbl_date_and_time.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lbl_date_and_time.Location = New Point(191, 328)
        lbl_date_and_time.Name = "lbl_date_and_time"
        lbl_date_and_time.Size = New Size(195, 20)
        lbl_date_and_time.TabIndex = 7
        lbl_date_and_time.Text = "October 2, 2023 11:43 AM"
        ' 
        ' img_barangay_case_image
        ' 
        img_barangay_case_image.BorderStyle = BorderStyle.FixedSingle
        img_barangay_case_image.Image = CType(resources.GetObject("img_barangay_case_image.Image"), Image)
        img_barangay_case_image.Location = New Point(11, 5)
        img_barangay_case_image.Name = "img_barangay_case_image"
        img_barangay_case_image.Size = New Size(826, 300)
        img_barangay_case_image.SizeMode = PictureBoxSizeMode.StretchImage
        img_barangay_case_image.TabIndex = 6
        img_barangay_case_image.TabStop = False
        ' 
        ' lbl_barangay_news_title
        ' 
        lbl_barangay_news_title.AutoSize = True
        lbl_barangay_news_title.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_barangay_news_title.Location = New Point(11, 328)
        lbl_barangay_news_title.Name = "lbl_barangay_news_title"
        lbl_barangay_news_title.Size = New Size(131, 20)
        lbl_barangay_news_title.TabIndex = 4
        lbl_barangay_news_title.Text = "Date and Time:"
        ' 
        ' View_Barangay_Case
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
        Name = "View_Barangay_Case"
        ShowIcon = False
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Panel2.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(img_barangay_case_image, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_close As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_title As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents img_barangay_case_image As PictureBox
    Friend WithEvents lbl_barangay_news_title As Label
    Friend WithEvents lbl_date_and_time As Label
    Friend WithEvents lbl_name As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lbl_address As Label
    Friend WithEvents lbl_mobile_number As Label
    Friend WithEvents lbl_nature_of_complaint As Label
    Friend WithEvents lbl_description As TextBox
End Class
