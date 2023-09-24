<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pending_Cases
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
        Panel2 = New Panel()
        Panel3 = New Panel()
        Label4 = New Label()
        txt_search = New TextBox()
        listview_employees = New ListView()
        primary_key = New ColumnHeader()
        case_date = New ColumnHeader()
        case_time = New ColumnHeader()
        case_name = New ColumnHeader()
        case_address = New ColumnHeader()
        case_nature_of_complaint = New ColumnHeader()
        Panel5 = New Panel()
        Panel6 = New Panel()
        Panel4 = New Panel()
        Panel1 = New Panel()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Panel3)
        Panel2.Controls.Add(Panel5)
        Panel2.Controls.Add(Panel6)
        Panel2.Controls.Add(Panel4)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 100)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1046, 571)
        Panel2.TabIndex = 5
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(txt_search)
        Panel3.Controls.Add(listview_employees)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(30, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(986, 541)
        Panel3.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(674, 23)
        Label4.Name = "Label4"
        Label4.Size = New Size(64, 20)
        Label4.TabIndex = 4
        Label4.Text = "Search:"
        ' 
        ' txt_search
        ' 
        txt_search.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txt_search.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txt_search.Location = New Point(744, 20)
        txt_search.Name = "txt_search"
        txt_search.Size = New Size(242, 26)
        txt_search.TabIndex = 3
        ' 
        ' listview_employees
        ' 
        listview_employees.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        listview_employees.BackColor = Color.White
        listview_employees.BorderStyle = BorderStyle.None
        listview_employees.Columns.AddRange(New ColumnHeader() {primary_key, case_date, case_time, case_name, case_address, case_nature_of_complaint})
        listview_employees.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        listview_employees.FullRowSelect = True
        listview_employees.GridLines = True
        listview_employees.HeaderStyle = ColumnHeaderStyle.Nonclickable
        listview_employees.Location = New Point(0, 63)
        listview_employees.MultiSelect = False
        listview_employees.Name = "listview_employees"
        listview_employees.Size = New Size(986, 478)
        listview_employees.TabIndex = 1
        listview_employees.UseCompatibleStateImageBehavior = False
        listview_employees.View = View.Details
        ' 
        ' primary_key
        ' 
        primary_key.Text = ""
        primary_key.Width = 0
        ' 
        ' case_date
        ' 
        case_date.Text = "Date"
        case_date.Width = 150
        ' 
        ' case_time
        ' 
        case_time.Text = "Time"
        case_time.Width = 150
        ' 
        ' case_name
        ' 
        case_name.Text = "Name"
        case_name.Width = 150
        ' 
        ' case_address
        ' 
        case_address.Text = "Address"
        case_address.Width = 150
        ' 
        ' case_nature_of_complaint
        ' 
        case_nature_of_complaint.Text = "Nature of Compliant"
        case_nature_of_complaint.Width = 150
        ' 
        ' Panel5
        ' 
        Panel5.Dock = DockStyle.Right
        Panel5.Location = New Point(1016, 0)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(30, 541)
        Panel5.TabIndex = 6
        ' 
        ' Panel6
        ' 
        Panel6.Dock = DockStyle.Bottom
        Panel6.Location = New Point(30, 541)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(1016, 30)
        Panel6.TabIndex = 5
        ' 
        ' Panel4
        ' 
        Panel4.Dock = DockStyle.Left
        Panel4.Location = New Point(0, 0)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(30, 571)
        Panel4.TabIndex = 3
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1046, 100)
        Panel1.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.FromArgb(CByte(81), CByte(103), CByte(172))
        Label3.Location = New Point(110, 57)
        Label3.Name = "Label3"
        Label3.Size = New Size(121, 16)
        Label3.TabIndex = 2
        Label3.Text = "/ Pending Cases"
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
        Label1.Size = New Size(190, 29)
        Label1.TabIndex = 0
        Label1.Text = "Pending Cases"
        ' 
        ' Pending_Cases
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = Color.FromArgb(CByte(246), CByte(249), CByte(255))
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        MinimumSize = New Size(1046, 671)
        Name = "Pending_Cases"
        Size = New Size(1046, 671)
        Panel2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents listview_employees As ListView
    Friend WithEvents primary_key As ColumnHeader
    Friend WithEvents case_date As ColumnHeader
    Friend WithEvents case_time As ColumnHeader
    Friend WithEvents case_name As ColumnHeader
    Friend WithEvents case_address As ColumnHeader
    Friend WithEvents case_nature_of_complaint As ColumnHeader
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_search As TextBox
End Class
