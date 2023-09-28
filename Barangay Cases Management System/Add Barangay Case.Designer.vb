<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_Barangay_Case
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Add_Barangay_Case))
        Panel1 = New Panel()
        Label4 = New Label()
        btn_new_employee = New Button()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel5 = New Panel()
        Panel4 = New Panel()
        Panel3 = New Panel()
        btn_next = New Button()
        Panel2 = New Panel()
        Label5 = New Label()
        Panel6 = New Panel()
        Button1 = New Button()
        Panel7 = New Panel()
        Button2 = New Button()
        Panel8 = New Panel()
        Button3 = New Button()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        Panel6.SuspendLayout()
        Panel7.SuspendLayout()
        Panel8.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(btn_new_employee)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1046, 100)
        Panel1.TabIndex = 7
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
        ' btn_new_employee
        ' 
        btn_new_employee.Anchor = AnchorStyles.Right
        btn_new_employee.AutoSize = True
        btn_new_employee.BackColor = Color.FromArgb(CByte(13), CByte(110), CByte(253))
        btn_new_employee.Cursor = Cursors.Hand
        btn_new_employee.FlatStyle = FlatStyle.Flat
        btn_new_employee.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btn_new_employee.ForeColor = Color.White
        btn_new_employee.Image = CType(resources.GetObject("btn_new_employee.Image"), Image)
        btn_new_employee.ImageAlign = ContentAlignment.MiddleLeft
        btn_new_employee.Location = New Point(1673, 29)
        btn_new_employee.Name = "btn_new_employee"
        btn_new_employee.Size = New Size(189, 42)
        btn_new_employee.TabIndex = 10
        btn_new_employee.Text = "      &New Announcement"
        btn_new_employee.TextAlign = ContentAlignment.MiddleLeft
        btn_new_employee.UseVisualStyleBackColor = False
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
        Panel5.TabIndex = 14
        ' 
        ' Panel4
        ' 
        Panel4.Dock = DockStyle.Left
        Panel4.Location = New Point(0, 100)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(30, 571)
        Panel4.TabIndex = 13
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.Controls.Add(btn_next)
        Panel3.Dock = DockStyle.Bottom
        Panel3.Location = New Point(30, 621)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(986, 50)
        Panel3.TabIndex = 0
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
        btn_next.TabIndex = 4
        btn_next.Text = "&Next"
        btn_next.TextAlign = ContentAlignment.MiddleLeft
        btn_next.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(Label5)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(30, 100)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(986, 50)
        Panel2.TabIndex = 15
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = Color.FromArgb(CByte(1), CByte(41), CByte(112))
        Label5.Location = New Point(5, 12)
        Label5.Name = "Label5"
        Label5.Size = New Size(177, 25)
        Label5.TabIndex = 0
        Label5.Text = "Basic Information"
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.FromArgb(CByte(246), CByte(249), CByte(255))
        Panel6.Controls.Add(Button1)
        Panel6.Dock = DockStyle.Bottom
        Panel6.Location = New Point(30, 618)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(986, 3)
        Panel6.TabIndex = 16
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button1.BackColor = Color.FromArgb(CByte(13), CByte(110), CByte(253))
        Button1.Cursor = Cursors.Hand
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(1624, 7)
        Button1.Name = "Button1"
        Button1.Size = New Size(143, 34)
        Button1.TabIndex = 4
        Button1.Text = "&Next"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.FromArgb(CByte(246), CByte(249), CByte(255))
        Panel7.Controls.Add(Button2)
        Panel7.Dock = DockStyle.Top
        Panel7.Location = New Point(30, 150)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(986, 3)
        Panel7.TabIndex = 17
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button2.BackColor = Color.FromArgb(CByte(13), CByte(110), CByte(253))
        Button2.Cursor = Cursors.Hand
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ForeColor = Color.White
        Button2.Location = New Point(2410, 7)
        Button2.Name = "Button2"
        Button2.Size = New Size(143, 34)
        Button2.TabIndex = 4
        Button2.Text = "&Next"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.White
        Panel8.Controls.Add(Button3)
        Panel8.Dock = DockStyle.Fill
        Panel8.Location = New Point(30, 153)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(986, 465)
        Panel8.TabIndex = 18
        ' 
        ' Button3
        ' 
        Button3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button3.BackColor = Color.FromArgb(CByte(13), CByte(110), CByte(253))
        Button3.Cursor = Cursors.Hand
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.ForeColor = Color.White
        Button3.Location = New Point(2410, 7)
        Button3.Name = "Button3"
        Button3.Size = New Size(143, 34)
        Button3.TabIndex = 4
        Button3.Text = "&Next"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Add_Barangay_Case
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(246), CByte(249), CByte(255))
        Controls.Add(Panel8)
        Controls.Add(Panel7)
        Controls.Add(Panel6)
        Controls.Add(Panel2)
        Controls.Add(Panel3)
        Controls.Add(Panel5)
        Controls.Add(Panel4)
        Controls.Add(Panel1)
        Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        MinimumSize = New Size(1046, 671)
        Name = "Add_Barangay_Case"
        Size = New Size(1046, 671)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel7.ResumeLayout(False)
        Panel8.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_new_employee As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_next As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Button3 As Button
End Class
