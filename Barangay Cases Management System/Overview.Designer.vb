<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Overview
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
        Label1 = New Label()
        Label2 = New Label()
        lbl_full_name = New Label()
        lbl_position = New Label()
        Label5 = New Label()
        lbl_mobile_number = New Label()
        Label7 = New Label()
        lbl_email = New Label()
        Label9 = New Label()
        lbl_address = New Label()
        Label11 = New Label()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(1), CByte(41), CByte(135))
        Label1.Location = New Point(23, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(122, 24)
        Label1.TabIndex = 0
        Label1.Text = "Profile Details"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(103), CByte(127), CByte(169))
        Label2.Location = New Point(23, 69)
        Label2.Name = "Label2"
        Label2.Size = New Size(80, 20)
        Label2.TabIndex = 1
        Label2.Text = "Full Name"
        ' 
        ' lbl_full_name
        ' 
        lbl_full_name.AutoSize = True
        lbl_full_name.BackColor = Color.Transparent
        lbl_full_name.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lbl_full_name.ForeColor = Color.Black
        lbl_full_name.Location = New Point(0, 69)
        lbl_full_name.Name = "lbl_full_name"
        lbl_full_name.Size = New Size(150, 20)
        lbl_full_name.TabIndex = 2
        lbl_full_name.Text = "Super Administrator"
        ' 
        ' lbl_position
        ' 
        lbl_position.AutoSize = True
        lbl_position.BackColor = Color.Transparent
        lbl_position.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lbl_position.ForeColor = Color.Black
        lbl_position.Location = New Point(0, 109)
        lbl_position.Name = "lbl_position"
        lbl_position.Size = New Size(130, 20)
        lbl_position.TabIndex = 4
        lbl_position.Text = "Not Yet Available"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = Color.FromArgb(CByte(103), CByte(127), CByte(169))
        Label5.Location = New Point(23, 109)
        Label5.Name = "Label5"
        Label5.Size = New Size(65, 20)
        Label5.TabIndex = 3
        Label5.Text = "Position"
        ' 
        ' lbl_mobile_number
        ' 
        lbl_mobile_number.AutoSize = True
        lbl_mobile_number.BackColor = Color.Transparent
        lbl_mobile_number.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lbl_mobile_number.ForeColor = Color.Black
        lbl_mobile_number.Location = New Point(0, 149)
        lbl_mobile_number.Name = "lbl_mobile_number"
        lbl_mobile_number.Size = New Size(130, 20)
        lbl_mobile_number.TabIndex = 6
        lbl_mobile_number.Text = "Not Yet Available"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.ForeColor = Color.FromArgb(CByte(103), CByte(127), CByte(169))
        Label7.Location = New Point(23, 149)
        Label7.Name = "Label7"
        Label7.Size = New Size(115, 20)
        Label7.TabIndex = 5
        Label7.Text = "Mobile Number"
        ' 
        ' lbl_email
        ' 
        lbl_email.AutoSize = True
        lbl_email.BackColor = Color.Transparent
        lbl_email.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lbl_email.ForeColor = Color.Black
        lbl_email.Location = New Point(0, 189)
        lbl_email.Name = "lbl_email"
        lbl_email.Size = New Size(130, 20)
        lbl_email.TabIndex = 8
        lbl_email.Text = "Not Yet Available"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.ForeColor = Color.FromArgb(CByte(103), CByte(127), CByte(169))
        Label9.Location = New Point(23, 189)
        Label9.Name = "Label9"
        Label9.Size = New Size(48, 20)
        Label9.TabIndex = 7
        Label9.Text = "Email"
        ' 
        ' lbl_address
        ' 
        lbl_address.AutoSize = True
        lbl_address.BackColor = Color.Transparent
        lbl_address.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lbl_address.ForeColor = Color.Black
        lbl_address.Location = New Point(0, 229)
        lbl_address.Name = "lbl_address"
        lbl_address.Size = New Size(130, 20)
        lbl_address.TabIndex = 10
        lbl_address.Text = "Not Yet Available"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.ForeColor = Color.FromArgb(CByte(103), CByte(127), CByte(169))
        Label11.Location = New Point(23, 229)
        Label11.Name = "Label11"
        Label11.Size = New Size(68, 20)
        Label11.TabIndex = 9
        Label11.Text = "Address"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label11)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label9)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(250, 521)
        Panel1.TabIndex = 19
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(lbl_full_name)
        Panel2.Controls.Add(lbl_position)
        Panel2.Controls.Add(lbl_address)
        Panel2.Controls.Add(lbl_mobile_number)
        Panel2.Controls.Add(lbl_email)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(250, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(371, 521)
        Panel2.TabIndex = 20
        ' 
        ' Overview
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Name = "Overview"
        Size = New Size(621, 521)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_full_name As Label
    Friend WithEvents lbl_position As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_mobile_number As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl_email As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lbl_address As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
End Class
