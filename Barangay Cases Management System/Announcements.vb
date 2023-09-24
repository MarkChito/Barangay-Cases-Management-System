Public Class Announcements
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
End Class
