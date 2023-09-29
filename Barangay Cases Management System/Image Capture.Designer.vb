<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Image_Capture
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Image_Capture))
        Panel1 = New Panel()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel5 = New Panel()
        Panel4 = New Panel()
        Panel3 = New Panel()
        btn_next = New Button()
        Panel6 = New Panel()
        Panel2 = New Panel()
        Label6 = New Label()
        Label5 = New Label()
        Panel7 = New Panel()
        pnl_parent = New Panel()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
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
        Label4.Size = New Size(131, 16)
        Label4.TabIndex = 11
        Label4.Text = "/ Barangay Cases"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.FromArgb(CByte(81), CByte(103), CByte(172))
        Label3.Location = New Point(239, 57)
        Label3.Name = "Label3"
        Label3.Size = New Size(157, 16)
        Label3.TabIndex = 2
        Label3.Text = "/ New Barangay Case"
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
        Label1.Size = New Size(249, 29)
        Label1.TabIndex = 0
        Label1.Text = "New Barangay Case"
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
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.Controls.Add(btn_next)
        Panel3.Dock = DockStyle.Bottom
        Panel3.Location = New Point(30, 621)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(986, 50)
        Panel3.TabIndex = 17
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
        btn_next.Location = New Point(875, 8)
        btn_next.Name = "btn_next"
        btn_next.Padding = New Padding(15, 0, 15, 0)
        btn_next.Size = New Size(105, 35)
        btn_next.TabIndex = 6
        btn_next.Text = "&Next"
        btn_next.TextAlign = ContentAlignment.MiddleLeft
        btn_next.UseVisualStyleBackColor = False
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.FromArgb(CByte(246), CByte(249), CByte(255))
        Panel6.Dock = DockStyle.Bottom
        Panel6.Location = New Point(30, 618)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(986, 3)
        Panel6.TabIndex = 18
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label5)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(30, 100)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(986, 50)
        Panel2.TabIndex = 19
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.ForeColor = Color.Gray
        Label6.Location = New Point(142, 12)
        Label6.Name = "Label6"
        Label6.Size = New Size(158, 25)
        Label6.TabIndex = 1
        Label6.Text = "(Use WebCam)"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = Color.FromArgb(CByte(1), CByte(41), CByte(112))
        Label5.Location = New Point(5, 12)
        Label5.Name = "Label5"
        Label5.Size = New Size(144, 25)
        Label5.TabIndex = 0
        Label5.Text = "Upload Image"
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.FromArgb(CByte(246), CByte(249), CByte(255))
        Panel7.Dock = DockStyle.Top
        Panel7.Location = New Point(30, 150)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(986, 3)
        Panel7.TabIndex = 20
        ' 
        ' pnl_parent
        ' 
        pnl_parent.BackColor = Color.White
        pnl_parent.Dock = DockStyle.Fill
        pnl_parent.Location = New Point(30, 153)
        pnl_parent.Name = "pnl_parent"
        pnl_parent.Size = New Size(986, 465)
        pnl_parent.TabIndex = 21
        ' 
        ' Image_Capture
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(246), CByte(249), CByte(255))
        Controls.Add(pnl_parent)
        Controls.Add(Panel7)
        Controls.Add(Panel2)
        Controls.Add(Panel6)
        Controls.Add(Panel3)
        Controls.Add(Panel5)
        Controls.Add(Panel4)
        Controls.Add(Panel1)
        MinimumSize = New Size(1046, 671)
        Name = "Image_Capture"
        Size = New Size(1046, 671)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    'Friend WithEvents btn_new_employee As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    'Friend WithEvents btn_next As Button
    Friend WithEvents btn_next As Button
    Friend WithEvents Panel6 As Panel
    'Friend WithEvents Button2 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel7 As Panel
    'Friend WithEvents Button3 As Button
    'Friend WithEvents Button4 As Button
    Friend WithEvents pnl_parent As Panel
    Friend WithEvents Label6 As Label
End Class
