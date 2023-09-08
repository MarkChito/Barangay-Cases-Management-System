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
        img_close = New PictureBox()
        lbl_title = New Label()
        Panel2 = New Panel()
        img_rfid = New PictureBox()
        txt_rfid_number = New TextBox()
        Panel1.SuspendLayout()
        CType(img_close, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(img_rfid, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(img_close)
        Panel1.Controls.Add(lbl_title)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(424, 45)
        Panel1.TabIndex = 0
        ' 
        ' img_close
        ' 
        img_close.BackColor = Color.Transparent
        img_close.Cursor = Cursors.Hand
        img_close.Image = CType(resources.GetObject("img_close.Image"), Image)
        img_close.Location = New Point(389, 6)
        img_close.Name = "img_close"
        img_close.Size = New Size(32, 32)
        img_close.SizeMode = PictureBoxSizeMode.CenterImage
        img_close.TabIndex = 1
        img_close.TabStop = False
        ' 
        ' lbl_title
        ' 
        lbl_title.AutoSize = True
        lbl_title.Font = New Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_title.Location = New Point(84, 7)
        lbl_title.Name = "lbl_title"
        lbl_title.Size = New Size(277, 31)
        lbl_title.TabIndex = 0
        lbl_title.Text = "Tap your RFID Card"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(img_rfid)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 45)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(424, 493)
        Panel2.TabIndex = 1
        ' 
        ' img_rfid
        ' 
        img_rfid.Dock = DockStyle.Fill
        img_rfid.Image = CType(resources.GetObject("img_rfid.Image"), Image)
        img_rfid.Location = New Point(0, 0)
        img_rfid.Name = "img_rfid"
        img_rfid.Size = New Size(424, 493)
        img_rfid.SizeMode = PictureBoxSizeMode.StretchImage
        img_rfid.TabIndex = 0
        img_rfid.TabStop = False
        ' 
        ' txt_rfid_number
        ' 
        txt_rfid_number.Location = New Point(176, 602)
        txt_rfid_number.Name = "txt_rfid_number"
        txt_rfid_number.Size = New Size(100, 23)
        txt_rfid_number.TabIndex = 2
        ' 
        ' RFID_Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(424, 538)
        ControlBox = False
        Controls.Add(txt_rfid_number)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "RFID_Login"
        ShowIcon = False
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(img_close, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        CType(img_rfid, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_title As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents img_rfid As PictureBox
    Friend WithEvents img_close As PictureBox
    Friend WithEvents txt_rfid_number As TextBox
End Class
