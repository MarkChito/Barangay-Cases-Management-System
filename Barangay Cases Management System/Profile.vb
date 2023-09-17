Imports System.Drawing.Drawing2D

Public Class Profile
    Private Sub Rounded_Image(image As PictureBox)
        Dim path As New GraphicsPath()

        path.AddEllipse(New Rectangle(0, 0, image.Width - 1, image.Height - 1))

        image.Region = New Region(path)
    End Sub

    Public Sub Center_Object(obj_name As Object)
        Dim panelWidth As Integer = pnl_user_details.Width
        Dim labelWidth As Integer = obj_name.Width
        Dim centerX As Integer = (panelWidth - labelWidth) / 2

        obj_name.Location = New Point(centerX, obj_name.Location.Y)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        With Main
            .Mouse_Click(.btn_dashboard)
            .Hide_Account_Details()
            .Hide_Notification()
        End With
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        With Main
            .Mouse_Click(.btn_employees)
            .Hide_Account_Details()
            .Hide_Notification()
        End With
    End Sub

    Private Sub btn_overview_Click(sender As Object, e As EventArgs) Handles btn_overview.Click
        btn_overview.ForeColor = Color.Blue
        btn_update_profile.ForeColor = Color.Black
        btn_acount_settings.ForeColor = Color.Black

        Overview.BringToFront()

        Main.btn_temp.Focus()
    End Sub

    Private Sub btn_update_profile_Click(sender As Object, e As EventArgs) Handles btn_update_profile.Click
        btn_overview.ForeColor = Color.Black
        btn_update_profile.ForeColor = Color.Blue
        btn_acount_settings.ForeColor = Color.Black

        Update_Profile.BringToFront()

        Main.btn_temp.Focus()
    End Sub

    Private Sub btn_acount_settings_Click(sender As Object, e As EventArgs) Handles btn_acount_settings.Click
        btn_overview.ForeColor = Color.Black
        btn_update_profile.ForeColor = Color.Black
        btn_acount_settings.ForeColor = Color.Blue

        Employee_Account_Settings.BringToFront()

        Main.btn_temp.Focus()
    End Sub

    Private Sub img_user_Paint(sender As Object, e As PaintEventArgs) Handles img_user.Paint
        Rounded_Image(img_user)
    End Sub

    Private Sub Profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Center_Object(lbl_user_details_full_name)
        Center_Object(lbl_user_details_position)
        Center_Object(img_user)
    End Sub

    Private Sub Profile_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        Dim ratio As Double = 350 / 1046

        pnl_user_details_and_image.Width = ratio * Me.Width

        Center_Object(lbl_user_details_full_name)
        Center_Object(lbl_user_details_position)
        Center_Object(img_user)
    End Sub
End Class
