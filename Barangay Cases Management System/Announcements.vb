Imports System.Globalization

Public Class Announcements
    Private Sub Search_Announcements_Data(inputted_data As String)
        Dim results As DataTable = Get_Search_Announcements_Data(inputted_data)

        listview_employees.Items.Clear()

        For Each row As DataRow In results.Rows
            Dim lvi As ListViewItem
            Dim parsedTime As DateTime
            Dim inputDateandTime = row("date_and_time").ToString()

            DateTime.TryParseExact(inputDateandTime, "yyyy-MM-dd HH:mm:ss", Nothing, DateTimeStyles.None, parsedTime)

            Dim formattedDate As String = parsedTime.ToString("MMMM d, yyyy")
            Dim formattedTime As String = parsedTime.ToString("hh:mm tt")

            lvi = listview_employees.Items.Add(row("primary_key").ToString())
            lvi.SubItems.Add(formattedDate)
            lvi.SubItems.Add(formattedTime)
            lvi.SubItems.Add(row("title").ToString())
            lvi.SubItems.Add(row("body").ToString())
        Next
    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        With Main
            .Mouse_Click(.btn_dashboard)
            .Hide_Account_Details()
            .Hide_Notification()
        End With
    End Sub

    Private Sub listview_employees_SizeChanged(sender As Object, e As EventArgs) Handles listview_employees.SizeChanged
        For i As Integer = 1 To listview_employees.Columns.Count - 1
            listview_employees.Columns(i).Width = (listview_employees.Width - listview_employees.Columns(0).Width) / (listview_employees.Columns.Count - 1)
        Next

        listview_employees.Columns(0).Width = 0
    End Sub

    Private Sub btn_new_employee_Click(sender As Object, e As EventArgs) Handles btn_new_employee.Click
        Add_Announcement.ShowDialog()
    End Sub

    Private Sub listview_employees_Click(sender As Object, e As EventArgs) Handles listview_employees.Click
        With View_Announcements
            .lbl_announcement_date_and_time.Text = listview_employees.SelectedItems(0).SubItems(1).Text & " " & listview_employees.SelectedItems(0).SubItems(2).Text
            .lbl_announcement_title.Text = listview_employees.SelectedItems(0).SubItems(3).Text
            .lbl_announcement_body.Text = listview_employees.SelectedItems(0).SubItems(4).Text
            .ShowDialog()
        End With
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        If Not txt_search.Text = Nothing Then
            Search_Announcements_Data(txt_search.Text)
        Else
            Main.Load_Announcements_Data()
        End If
    End Sub
End Class
