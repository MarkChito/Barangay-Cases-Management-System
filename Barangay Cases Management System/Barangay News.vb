Imports System.Globalization

Public Class Barangay_News
    Private Sub Search_News_Data(inputted_data As String)
        Dim results As DataTable = Get_Search_Barangay_News_Data(inputted_data)

        listview_employees.Items.Clear()

        For Each row As DataRow In results.Rows
            Dim lvi As ListViewItem
            Dim parsedTime As DateTime
            Dim inputDate = row("date").ToString()
            Dim inputTime = row("time").ToString()

            DateTime.TryParseExact(inputDate, "yyyy-MM-dd", Nothing, DateTimeStyles.None, parsedTime)
            DateTime.TryParseExact(inputTime, "HH:mm:ss", Nothing, DateTimeStyles.None, parsedTime)

            Dim formattedDate As String = parsedTime.ToString("MMMM d, yyyy")
            Dim formattedTime As String = parsedTime.ToString("hh:mm tt")

            lvi = listview_employees.Items.Add(row("primary_key").ToString())
            lvi.SubItems.Add(formattedDate)
            lvi.SubItems.Add(formattedTime)
            lvi.SubItems.Add(row("title").ToString())
            lvi.SubItems.Add(row("body").ToString())
            lvi.SubItems.Add(row("image").ToString())
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
        Dim visibleColumnCount As Integer = listview_employees.Columns.Count - 2

        If visibleColumnCount > 0 Then
            Dim columnWidth As Integer = listview_employees.Width / visibleColumnCount

            For i As Integer = 1 To listview_employees.Columns.Count - 2
                listview_employees.Columns(i).Width = columnWidth
            Next
        End If

        listview_employees.Columns(0).Width = 0
        listview_employees.Columns(listview_employees.Columns.Count - 1).Width = 0
    End Sub

    Private Sub btn_new_employee_Click(sender As Object, e As EventArgs) Handles btn_new_employee.Click
        Add_Barangay_News.ShowDialog()
    End Sub

    Private Sub listview_employees_Click(sender As Object, e As EventArgs) Handles listview_employees.Click
        With View_Barangay_News
            .lbl_barangay_news_date_and_time.Text = listview_employees.SelectedItems(0).SubItems(1).Text & " " & listview_employees.SelectedItems(0).SubItems(2).Text
            .lbl_barangay_news_title.Text = listview_employees.SelectedItems(0).SubItems(3).Text
            .lbl_barangay_news_body.Text = listview_employees.SelectedItems(0).SubItems(4).Text
            .img_barangay_news_image.Image = Image.FromFile("dist/img/user_upload/" & listview_employees.SelectedItems(0).SubItems(5).Text)
            .ShowDialog()
        End With
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        If Not txt_search.Text = Nothing Then
            Search_News_Data(txt_search.Text)
        Else
            Main.Load_News_Data()
        End If
    End Sub
End Class
