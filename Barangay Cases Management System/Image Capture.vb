﻿Public Class Image_Capture
    Private Sub Design_Button(button_name As Object)
        Dim path As New Drawing2D.GraphicsPath()
        Dim cornerRadius As Integer = &B10100

        path.AddArc(0, 0, cornerRadius * 2, cornerRadius * 2, 180, 90)
        path.AddArc(button_name.Width - (cornerRadius * 2), 0, cornerRadius * 2, cornerRadius * 2, 270, 90)
        path.AddArc(button_name.Width - (cornerRadius * 2), button_name.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 0, 90)
        path.AddArc(0, button_name.Height - (cornerRadius * 2), cornerRadius * 2, cornerRadius * 2, 90, 90)
        path.CloseFigure()

        button_name.Region = New Region(path)
    End Sub

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

    Private Sub btn_submit_Paint(sender As Object, e As PaintEventArgs) Handles btn_submit.Paint
        Design_Button(btn_submit)
    End Sub

    Private Sub btn_previous_Paint(sender As Object, e As PaintEventArgs) Handles btn_previous.Paint
        Design_Button(btn_previous)
    End Sub

    Private Sub btn_previous_Click(sender As Object, e As EventArgs) Handles btn_previous.Click
        Main.Mouse_Click(btn_previous)
    End Sub
End Class
