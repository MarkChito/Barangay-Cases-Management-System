Public Class Barangay_Cases
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        With Main
            .Mouse_Click(.btn_dashboard)
            .Hide_Account_Details()
            .Hide_Notification()
        End With
    End Sub

    Private Sub listview_employees_SizeChanged(sender As Object, e As EventArgs) Handles listview_employees.SizeChanged
        Dim visible_columns() As Integer = {1, 2, 3, 5, 6}
        Dim non_visible_columns() As Integer = {0, 4, 7, 8}

        Dim listview_width As Integer = listview_employees.Width

        listview_employees.Columns(0).Width = 0
        listview_employees.Columns(1).Width = listview_width * 0.15
        listview_employees.Columns(2).Width = listview_width * 0.1
        listview_employees.Columns(3).Width = listview_width * 0.2
        listview_employees.Columns(4).Width = 0
        listview_employees.Columns(5).Width = listview_width * 0.25
        listview_employees.Columns(6).Width = listview_width * 0.3
        listview_employees.Columns(7).Width = 0
        listview_employees.Columns(8).Width = 0
    End Sub

    Private Sub btn_new_case_Click(sender As Object, e As EventArgs) Handles btn_new_case.Click
        With Main
            .Mouse_Click(btn_new_case)
            .Hide_Account_Details()
            .Hide_Notification()
        End With
    End Sub

    Private Sub listview_employees_Click(sender As Object, e As EventArgs) Handles listview_employees.Click
        With View_Barangay_Case
            .lbl_date_and_time.Text = listview_employees.SelectedItems(0).SubItems(1).Text & " " & listview_employees.SelectedItems(0).SubItems(2).Text
            .lbl_name.Text = listview_employees.SelectedItems(0).SubItems(3).Text
            .lbl_mobile_number.Text = listview_employees.SelectedItems(0).SubItems(4).Text
            .lbl_address.Text = listview_employees.SelectedItems(0).SubItems(5).Text
            .lbl_nature_of_complaint.Text = listview_employees.SelectedItems(0).SubItems(6).Text
            .lbl_description.Text = " " & listview_employees.SelectedItems(0).SubItems(7).Text
            .img_barangay_case_image.Image = Image.FromFile("dist/img/user_upload/" & listview_employees.SelectedItems(0).SubItems(8).Text)
            .ShowDialog()
        End With
    End Sub
End Class
