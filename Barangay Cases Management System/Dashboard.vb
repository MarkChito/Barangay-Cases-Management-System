Public Class Dashboard
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
        Main.btn_temp.Focus()

        btn_announcements.BackColor = Color.FromArgb(246, 249, 255)
        btn_barangay_news.BackColor = Color.White

        With lbl_title
            .Text = "Anouncements"
        End With

        Center_Object(lbl_title)
    End Sub

    Private Sub btn_barangay_announcements_Click(sender As Object, e As EventArgs) Handles btn_barangay_news.Click
        Main.btn_temp.Focus()

        btn_announcements.BackColor = Color.White
        btn_barangay_news.BackColor = Color.FromArgb(246, 249, 255)

        With lbl_title
            .Text = "Barangay News"
        End With

        Center_Object(lbl_title)
    End Sub

    Private Sub listview_employees_SizeChanged(sender As Object, e As EventArgs) Handles listview_employees.SizeChanged
        For i As Integer = 1 To listview_employees.Columns.Count - 1
            listview_employees.Columns(i).Width = (listview_employees.Width - listview_employees.Columns(0).Width) / (listview_employees.Columns.Count - 1)
        Next

        listview_employees.Columns(0).Width = 0
    End Sub

    Private Sub pnl_title_SizeChanged(sender As Object, e As EventArgs) Handles pnl_title.SizeChanged
        Center_Object(lbl_title)
    End Sub
End Class
