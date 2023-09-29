Public Class Image_Capture
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        With Main
            .Mouse_Click(.btn_barangay_cases)
            .Hide_Account_Details()
            .Hide_Notification()
        End With
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        With Main
            .Mouse_Click(.btn_dashboard)
            .Hide_Account_Details()
            .Hide_Notification()
        End With
    End Sub
End Class
