Public Class Barangay_Cases
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        With Main
            .Mouse_Click(.btn_dashboard)
            .Hide_Account_Details()
            .Hide_Notification()
        End With
    End Sub

    Private Sub listview_employees_SizeChanged(sender As Object, e As EventArgs) Handles listview_employees.SizeChanged
        Dim columnWidth As Integer = listview_employees.Width / (listview_employees.Columns.Count - 4)
        Dim visible_columns() As Integer = {1, 2, 3, 5, 6}
        Dim non_visible_columns() As Integer = {0, 4, 7, 8}

        For Each visible_column As Integer In visible_columns
            listview_employees.Columns(visible_column).Width = columnWidth
        Next

        For Each non_visible_column As Integer In non_visible_columns
            listview_employees.Columns(non_visible_column).Width = 0
        Next
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
