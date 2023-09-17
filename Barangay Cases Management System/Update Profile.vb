Public Class Update_Profile
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

    Private Sub btn_submit_Paint(sender As Object, e As PaintEventArgs) Handles btn_submit.Paint
        Design_Button(btn_submit)
    End Sub

    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click
        With btn_submit
            .Text = "Processing Request..."
            .Enabled = False
        End With

        Update_Profile_Information(txt_first_name.Text, txt_middle_name.Text, txt_last_name.Text, txt_position.Text, txt_mobile_number.Text, txt_email.Text, txt_address.Text, lbl_primary_key.Text)

        With Main
            If lbl_primary_key.Text = "1" Then
                .Load_User_Data()
                .Load_My_Profile_Data()

                With .My_Profile
                    .Center_Object(.lbl_user_details_full_name)
                    .Center_Object(.lbl_user_details_position)
                    .Center_Object(.img_user)
                End With
            Else
                .Load_Employees_Data()
                .Load_Employee_Data()

                With .Profile
                    .Center_Object(.lbl_user_details_full_name)
                    .Center_Object(.lbl_user_details_position)
                    .Center_Object(.img_user)
                End With
            End If
        End With

        With btn_submit
            .Text = "&Submit Changes"
            .Enabled = True
        End With

        MsgBox("Your profile is successfully updated!", MsgBoxStyle.Information, "Success")
    End Sub
End Class
