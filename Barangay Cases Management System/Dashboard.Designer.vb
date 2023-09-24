<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Panel1 = New Panel()
        Label2 = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        pnl_title = New Panel()
        lbl_title = New Label()
        listview_employees = New ListView()
        primary_key = New ColumnHeader()
        case_date = New ColumnHeader()
        case_time = New ColumnHeader()
        title = New ColumnHeader()
        body = New ColumnHeader()
        Panel6 = New Panel()
        pnl_sub_header = New Panel()
        btn_barangay_news = New Button()
        btn_announcements = New Button()
        Panel3 = New Panel()
        Panel4 = New Panel()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        pnl_title.SuspendLayout()
        pnl_sub_header.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1046, 100)
        Panel1.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(81), CByte(103), CByte(172))
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
        Label1.Size = New Size(140, 29)
        Label1.TabIndex = 0
        Label1.Text = "Dashboard"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(pnl_title)
        Panel2.Controls.Add(listview_employees)
        Panel2.Controls.Add(Panel6)
        Panel2.Controls.Add(pnl_sub_header)
        Panel2.Controls.Add(Panel3)
        Panel2.Controls.Add(Panel4)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 100)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1046, 571)
        Panel2.TabIndex = 1
        ' 
        ' pnl_title
        ' 
        pnl_title.BackColor = Color.White
        pnl_title.Controls.Add(lbl_title)
        pnl_title.Dock = DockStyle.Top
        pnl_title.Location = New Point(30, 93)
        pnl_title.Name = "pnl_title"
        pnl_title.Size = New Size(986, 50)
        pnl_title.TabIndex = 18
        ' 
        ' lbl_title
        ' 
        lbl_title.AutoSize = True
        lbl_title.Font = New Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_title.Location = New Point(382, 10)
        lbl_title.Name = "lbl_title"
        lbl_title.Size = New Size(223, 31)
        lbl_title.TabIndex = 0
        lbl_title.Text = "Announcements"
        ' 
        ' listview_employees
        ' 
        listview_employees.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        listview_employees.BackColor = Color.White
        listview_employees.BorderStyle = BorderStyle.None
        listview_employees.Columns.AddRange(New ColumnHeader() {primary_key, case_date, case_time, title, body})
        listview_employees.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        listview_employees.FullRowSelect = True
        listview_employees.GridLines = True
        listview_employees.HeaderStyle = ColumnHeaderStyle.Nonclickable
        listview_employees.Location = New Point(30, 143)
        listview_employees.MultiSelect = False
        listview_employees.Name = "listview_employees"
        listview_employees.Size = New Size(986, 398)
        listview_employees.TabIndex = 17
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
        ' title
        ' 
        title.Text = "Title"
        title.Width = 150
        ' 
        ' body
        ' 
        body.Text = "Body"
        body.Width = 150
        ' 
        ' Panel6
        ' 
        Panel6.Dock = DockStyle.Bottom
        Panel6.Location = New Point(30, 541)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(986, 30)
        Panel6.TabIndex = 16
        ' 
        ' pnl_sub_header
        ' 
        pnl_sub_header.Controls.Add(btn_barangay_news)
        pnl_sub_header.Controls.Add(btn_announcements)
        pnl_sub_header.Dock = DockStyle.Top
        pnl_sub_header.Location = New Point(30, 0)
        pnl_sub_header.Name = "pnl_sub_header"
        pnl_sub_header.Size = New Size(986, 93)
        pnl_sub_header.TabIndex = 14
        ' 
        ' btn_barangay_news
        ' 
        btn_barangay_news.BackColor = Color.White
        btn_barangay_news.Cursor = Cursors.Hand
        btn_barangay_news.Dock = DockStyle.Right
        btn_barangay_news.FlatAppearance.BorderSize = 0
        btn_barangay_news.FlatStyle = FlatStyle.Flat
        btn_barangay_news.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point)
        btn_barangay_news.Image = CType(resources.GetObject("btn_barangay_news.Image"), Image)
        btn_barangay_news.ImageAlign = ContentAlignment.TopCenter
        btn_barangay_news.Location = New Point(493, 0)
        btn_barangay_news.Name = "btn_barangay_news"
        btn_barangay_news.Size = New Size(493, 93)
        btn_barangay_news.TabIndex = 1
        btn_barangay_news.Text = "Barangay News"
        btn_barangay_news.TextAlign = ContentAlignment.BottomCenter
        btn_barangay_news.UseVisualStyleBackColor = False
        ' 
        ' btn_announcements
        ' 
        btn_announcements.BackColor = Color.White
        btn_announcements.Cursor = Cursors.Hand
        btn_announcements.Dock = DockStyle.Left
        btn_announcements.FlatAppearance.BorderSize = 0
        btn_announcements.FlatStyle = FlatStyle.Flat
        btn_announcements.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point)
        btn_announcements.Image = CType(resources.GetObject("btn_announcements.Image"), Image)
        btn_announcements.ImageAlign = ContentAlignment.TopCenter
        btn_announcements.Location = New Point(0, 0)
        btn_announcements.Name = "btn_announcements"
        btn_announcements.Size = New Size(493, 93)
        btn_announcements.TabIndex = 0
        btn_announcements.Text = "Announcements"
        btn_announcements.TextAlign = ContentAlignment.BottomCenter
        btn_announcements.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.Dock = DockStyle.Right
        Panel3.Location = New Point(1016, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(30, 571)
        Panel3.TabIndex = 13
        ' 
        ' Panel4
        ' 
        Panel4.Dock = DockStyle.Left
        Panel4.Location = New Point(0, 0)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(30, 571)
        Panel4.TabIndex = 12
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = Color.FromArgb(CByte(246), CByte(249), CByte(255))
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        MinimumSize = New Size(1046, 671)
        Name = "Dashboard"
        Size = New Size(1046, 671)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        pnl_title.ResumeLayout(False)
        pnl_title.PerformLayout()
        pnl_sub_header.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents pnl_sub_header As Panel
    Friend WithEvents btn_barangay_news As Button
    Friend WithEvents btn_announcements As Button
    Friend WithEvents listview_employees As ListView
    Friend WithEvents primary_key As ColumnHeader
    Friend WithEvents case_date As ColumnHeader
    Friend WithEvents case_time As ColumnHeader
    Friend WithEvents title As ColumnHeader
    Friend WithEvents body As ColumnHeader
    Friend WithEvents Panel6 As Panel
    Friend WithEvents pnl_title As Panel
    Friend WithEvents lbl_title As Label
End Class
