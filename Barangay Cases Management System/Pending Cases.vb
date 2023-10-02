Public Class Pending_Cases
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

    Private Sub listview_employees_Click(sender As Object, e As EventArgs) Handles listview_employees.Click
        is_edit_pending_case = True

        With Main.Edit_Barangay_Case
            .lbl_primary_key.Text = listview_employees.SelectedItems(0).Text
            .txt_full_name.Text = listview_employees.SelectedItems(0).SubItems(3).Text
            .txt_mobile_number.Text = listview_employees.SelectedItems(0).SubItems(4).Text
            .txt_address.Text = listview_employees.SelectedItems(0).SubItems(5).Text
            .txt_nature_of_complaint.Text = listview_employees.SelectedItems(0).SubItems(6).Text
            .txt_description.Text = listview_employees.SelectedItems(0).SubItems(7).Text
        End With

        Main.Mouse_Click(btn_edit_case)
    End Sub
End Class
