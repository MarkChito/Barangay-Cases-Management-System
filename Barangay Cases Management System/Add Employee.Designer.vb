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
        Button1 = New Button()
        CType(img_user, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' img_user
        ' 
        img_user.Image = CType(resources.GetObject("img_user.Image"), Image)
        img_user.Location = New Point(524, 6)
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
        Panel2.Location = New Point(0, 755)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1200, 45)
        Panel2.TabIndex = 3
        ' 
        ' btn_close
        ' 
        btn_close.BackColor = Color.FromArgb(CByte(220), CByte(53), CByte(69))
        btn_close.Cursor = Cursors.Hand
        btn_close.FlatStyle = FlatStyle.Flat
        btn_close.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btn_close.ForeColor = Color.White
        btn_close.Location = New Point(955, 4)
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
        btn_submit.Location = New Point(1044, 4)
        btn_submit.Name = "btn_submit"
        btn_submit.Size = New Size(143, 34)
        btn_submit.TabIndex = 6
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
        Panel1.Size = New Size(1200, 45)
        Panel1.TabIndex = 2
        ' 
        ' lbl_title
        ' 
        lbl_title.AutoSize = True
        lbl_title.BackColor = Color.Transparent
        lbl_title.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_title.Location = New Point(496, 9)
        lbl_title.Name = "lbl_title"
        lbl_title.Size = New Size(206, 24)
        lbl_title.TabIndex = 1
        lbl_title.Text = "Update your Account"
        ' 
        ' Panel3
        ' 
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(Button1)
        Panel3.Controls.Add(img_user)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(0, 45)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1200, 710)
        Panel3.TabIndex = 4
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(13), CByte(110), CByte(253))
        Button1.Cursor = Cursors.Hand
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(524, 162)
        Button1.Name = "Button1"
        Button1.Size = New Size(150, 35)
        Button1.TabIndex = 1
        Button1.Text = "Choose File"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Add_Employee
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1200, 800)
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
End Class
