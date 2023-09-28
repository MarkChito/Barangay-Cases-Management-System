<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RFID_Login
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(RFID_Login))
        Panel1 = New Panel()
        lbl_title = New Label()
        img_rfid = New PictureBox()
        txt_rfid_number = New TextBox()
        Panel4 = New Panel()
        btn_close = New Button()
        Panel2 = New Panel()
        Panel1.SuspendLayout()
        CType(img_rfid, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(lbl_title)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(400, 45)
        Panel1.TabIndex = 0
        ' 
        ' lbl_title
        ' 
        lbl_title.AutoSize = True
        lbl_title.BackColor = Color.Transparent
        lbl_title.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_title.Location = New Point(102, 9)
        lbl_title.Name = "lbl_title"
        lbl_title.Size = New Size(195, 24)
        lbl_title.TabIndex = 0
        lbl_title.Text = "Tap your RFID Card"
        ' 
        ' img_rfid
        ' 
        img_rfid.Dock = DockStyle.Fill
        img_rfid.Image = CType(resources.GetObject("img_rfid.Image"), Image)
        img_rfid.Location = New Point(0, 0)
        img_rfid.Name = "img_rfid"
        img_rfid.Size = New Size(398, 408)
        img_rfid.SizeMode = PictureBoxSizeMode.CenterImage
        img_rfid.TabIndex = 0
        img_rfid.TabStop = False
        ' 
        ' txt_rfid_number
        ' 
        txt_rfid_number.Location = New Point(176, 602)
        txt_rfid_number.Name = "txt_rfid_number"
        txt_rfid_number.Size = New Size(100, 23)
        txt_rfid_number.TabIndex = 0
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.White
        Panel4.BorderStyle = BorderStyle.FixedSingle
        Panel4.Controls.Add(btn_close)
        Panel4.Dock = DockStyle.Bottom
        Panel4.Location = New Point(0, 455)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(400, 45)
        Panel4.TabIndex = 3
        ' 
        ' btn_close
        ' 
        btn_close.BackColor = Color.FromArgb(CByte(220), CByte(53), CByte(69))
        btn_close.Cursor = Cursors.Hand
        btn_close.FlatStyle = FlatStyle.Flat
        btn_close.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btn_close.ForeColor = Color.White
        btn_close.Location = New Point(304, 4)
        btn_close.Name = "btn_close"
        btn_close.Size = New Size(83, 34)
        btn_close.TabIndex = 99
        btn_close.Text = "&Close"
        btn_close.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(img_rfid)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 45)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(400, 410)
        Panel2.TabIndex = 4
        ' 
        ' RFID_Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(400, 500)
        ControlBox = False
        Controls.Add(Panel2)
        Controls.Add(Panel4)
        Controls.Add(txt_rfid_number)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "RFID_Login"
        ShowIcon = False
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(img_rfid, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_title As Label
    Friend WithEvents img_rfid As PictureBox
    Friend WithEvents txt_rfid_number As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btn_close As Button
    Friend WithEvents Panel2 As Panel
End Class
