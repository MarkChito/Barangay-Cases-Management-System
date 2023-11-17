Imports System.Globalization

Public Class Pending_Cases
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

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        If Not txt_search.Text = Nothing Then
            Search_Pending_Case_Data(txt_search.Text)
        Else
            Main.Load_Pending_Cases_Data()
        End If
    End Sub

    Private Sub Search_Pending_Case_Data(inputted_data As String)
        Dim results As DataTable = Get_Search_Pending_Case_Data(inputted_data)

        listview_employees.Items.Clear()

        For Each row As DataRow In results.Rows
            Dim lvi As ListViewItem
            Dim parsedDate As DateTime

            Dim inputDate = row("date").ToString()

            DateTime.TryParseExact(inputDate, "yyyy-MM-dd", Nothing, DateTimeStyles.None, parsedDate)

            Dim formattedDate As String = parsedDate.ToString("MMMM d, yyyy")

            lvi = listview_employees.Items.Add(row("primary_key").ToString())
            lvi.SubItems.Add(formattedDate)
            lvi.SubItems.Add(row("time").ToString())
            lvi.SubItems.Add(row("name").ToString())
            lvi.SubItems.Add(row("mobile_number").ToString())
            lvi.SubItems.Add(row("address").ToString())
            lvi.SubItems.Add(row("nature_of_complaint").ToString())
            lvi.SubItems.Add(row("description").ToString())
            lvi.SubItems.Add(row("image").ToString())
        Next
    End Sub
End Class
