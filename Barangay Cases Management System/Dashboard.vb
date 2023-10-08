Public Class Dashboard
    Private is_announcements As Boolean = False

    Public Sub Center_Object(obj_name As Object)
        Dim panelWidth As Integer = pnl_title.Width
        Dim labelWidth As Integer = obj_name.Width
        Dim centerX As Integer = (panelWidth - labelWidth) / 2

        obj_name.Location = New Point(centerX, obj_name.Location.Y)
    End Sub
    Private Sub pnl_sub_header_SizeChanged(sender As Object, e As EventArgs) Handles pnl_sub_header.SizeChanged
        btn_barangay_news.Width = (pnl_sub_header.Width / 2) - 5
        btn_announcements.Width = (pnl_sub_header.Width / 2) - 5
    End Sub

    Private Sub btn_announcements_Click(sender As Object, e As EventArgs) Handles btn_announcements.Click
        is_announcements = True

        Main.btn_temp.Focus()

        Main.Load_Announcements_Data_2()

        btn_barangay_news.BackColor = Color.White

        With btn_announcements
            .BackColor = Color.FromArgb(246, 249, 255)
            .FlatAppearance.MouseOverBackColor = .BackColor
        End With

        lbl_title.Text = "Anouncements"

        Center_Object(lbl_title)
    End Sub

    Private Sub btn_barangay_news_Click(sender As Object, e As EventArgs) Handles btn_barangay_news.Click
        is_announcements = False

        Main.btn_temp.Focus()

        Main.Load_News_Data_2()

        btn_announcements.BackColor = Color.White

        With btn_barangay_news
            .BackColor = Color.FromArgb(246, 249, 255)
            .FlatAppearance.MouseOverBackColor = .BackColor
        End With

        With lbl_title
            .Text = "Barangay News"
        End With

        Center_Object(lbl_title)
    End Sub

    Private Sub listview_employees_SizeChanged(sender As Object, e As EventArgs) Handles listview_employees.SizeChanged
        Dim listview_width As Integer = listview_employees.Width

        listview_employees.Columns(0).Width = 0
        listview_employees.Columns(1).Width = listview_width * 0.15
        listview_employees.Columns(2).Width = listview_width * 0.1
        listview_employees.Columns(3).Width = listview_width * 0.25
        listview_employees.Columns(4).Width = listview_width * 0.5
        listview_employees.Columns(5).Width = 0
    End Sub

    Private Sub pnl_title_SizeChanged(sender As Object, e As EventArgs) Handles pnl_title.SizeChanged
        Center_Object(lbl_title)
    End Sub

    Private Sub btn_announcements_MouseEnter(sender As Object, e As EventArgs) Handles btn_announcements.MouseEnter
        With btn_announcements
            .FlatAppearance.MouseOverBackColor = .BackColor
            .FlatAppearance.MouseDownBackColor = .BackColor
        End With
    End Sub

    Private Sub btn_barangay_news_MouseEnter(sender As Object, e As EventArgs) Handles btn_barangay_news.MouseEnter
        With btn_barangay_news
            .FlatAppearance.MouseOverBackColor = .BackColor
            .FlatAppearance.MouseDownBackColor = .BackColor
        End With
    End Sub

    Private Sub listview_employees_Click(sender As Object, e As EventArgs) Handles listview_employees.Click
        If is_announcements Then
            With View_Announcements
                .lbl_announcement_date_and_time.Text = listview_employees.SelectedItems(0).SubItems(1).Text & " " & listview_employees.SelectedItems(0).SubItems(2).Text
                .lbl_announcement_title.Text = listview_employees.SelectedItems(0).SubItems(3).Text
                .lbl_announcement_body.Text = listview_employees.SelectedItems(0).SubItems(4).Text
                .ShowDialog()
            End With
        Else
            With View_Barangay_News
                .lbl_barangay_news_date_and_time.Text = listview_employees.SelectedItems(0).SubItems(1).Text & " " & listview_employees.SelectedItems(0).SubItems(2).Text
                .lbl_barangay_news_title.Text = listview_employees.SelectedItems(0).SubItems(3).Text
                .lbl_barangay_news_body.Text = listview_employees.SelectedItems(0).SubItems(4).Text
                .img_barangay_news_image.Image = Image.FromFile("dist/img/user_upload/" & listview_employees.SelectedItems(0).SubItems(5).Text)
                .ShowDialog()
            End With
        End If
    End Sub
End Class
