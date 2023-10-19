<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Connect_to_Mobile_App
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Connect_to_Mobile_App))
        Panel4 = New Panel()
        btn_close = New Button()
        Panel1 = New Panel()
        lbl_title = New Label()
        Panel2 = New Panel()
        txt_ipaddress = New TextBox()
        Label7 = New Label()
        Label8 = New Label()
        PictureBox1 = New PictureBox()
        Label5 = New Label()
        Label6 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel4.SuspendLayout()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.White
        Panel4.BorderStyle = BorderStyle.FixedSingle
        Panel4.Controls.Add(btn_close)
        Panel4.Dock = DockStyle.Bottom
        Panel4.Location = New Point(0, 433)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(374, 45)
        Panel4.TabIndex = 5
        ' 
        ' btn_close
        ' 
        btn_close.BackColor = Color.FromArgb(CByte(220), CByte(53), CByte(69))
        btn_close.Cursor = Cursors.Hand
        btn_close.FlatStyle = FlatStyle.Flat
        btn_close.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btn_close.ForeColor = Color.White
        btn_close.Location = New Point(278, 4)
        btn_close.Name = "btn_close"
        btn_close.Size = New Size(83, 34)
        btn_close.TabIndex = 99
        btn_close.Text = "&Close"
        btn_close.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(lbl_title)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(374, 45)
        Panel1.TabIndex = 4
        ' 
        ' lbl_title
        ' 
        lbl_title.AutoSize = True
        lbl_title.BackColor = Color.Transparent
        lbl_title.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_title.Location = New Point(45, 9)
        lbl_title.Name = "lbl_title"
        lbl_title.Size = New Size(282, 24)
        lbl_title.TabIndex = 0
        lbl_title.Text = "Connect to your Mobile App?"
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(txt_ipaddress)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Label1)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 45)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(374, 388)
        Panel2.TabIndex = 6
        ' 
        ' txt_ipaddress
        ' 
        txt_ipaddress.BackColor = Color.White
        txt_ipaddress.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txt_ipaddress.Location = New Point(86, 349)
        txt_ipaddress.Name = "txt_ipaddress"
        txt_ipaddress.ReadOnly = True
        txt_ipaddress.Size = New Size(275, 26)
        txt_ipaddress.TabIndex = 9
        txt_ipaddress.Text = "192.168.0.1"
        txt_ipaddress.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(83, 296)
        Label7.Name = "Label7"
        Label7.Size = New Size(270, 40)
        Label7.TabIndex = 8
        Label7.Text = "Enter the IP Address below if second" & vbCrLf & "option is selected."
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(10, 296)
        Label8.Name = "Label8"
        Label8.Size = New Size(67, 20)
        Label8.TabIndex = 7
        Label8.Text = "Step 4:"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(136, 183)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(100, 100)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(83, 130)
        Label5.Name = "Label5"
        Label5.Size = New Size(278, 40)
        Label5.TabIndex = 5
        Label5.Text = "Scan the QR Code below if first option" & vbCrLf & "is selected."
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(10, 130)
        Label6.Name = "Label6"
        Label6.Size = New Size(67, 20)
        Label6.TabIndex = 4
        Label6.Text = "Step 3:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(83, 60)
        Label4.Name = "Label4"
        Label4.Size = New Size(271, 60)
        Label4.TabIndex = 3
        Label4.Text = "Click ""Scan QR Code"" or ""Enter IP " & vbCrLf & "Address Manually"" if second option is" & vbCrLf & "selected."
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(10, 60)
        Label3.Name = "Label3"
        Label3.Size = New Size(67, 20)
        Label3.TabIndex = 2
        Label3.Text = "Step 2:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(83, 10)
        Label2.Name = "Label2"
        Label2.Size = New Size(285, 40)
        Label2.TabIndex = 1
        Label2.Text = "Open your Mobile App and click ""Online" & vbCrLf & "Connection"" or ""Offline Connection"""
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(10, 10)
        Label1.Name = "Label1"
        Label1.Size = New Size(67, 20)
        Label1.TabIndex = 0
        Label1.Text = "Step 1:"
        ' 
        ' Connect_to_Mobile_App
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(374, 478)
        Controls.Add(Panel2)
        Controls.Add(Panel4)
        Controls.Add(Panel1)
        Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.None
        Name = "Connect_to_Mobile_App"
        ShowIcon = False
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Panel4.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel4 As Panel
    Friend WithEvents btn_close As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_title As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_ipaddress As TextBox
End Class
