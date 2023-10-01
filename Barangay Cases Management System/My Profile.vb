Imports System.Drawing.Drawing2D

Public Class My_Profile
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

    Private Sub btn_overview_Click(sender As Object, e As EventArgs) Handles btn_overview.Click
        With btn_overview
            .BackColor = Color.FromArgb(246, 249, 255)
            .ForeColor = Color.Blue
            .FlatAppearance.MouseOverBackColor = .BackColor
        End With

        With btn_update_profile
            .ForeColor = Color.Black
            .BackColor = Color.White
        End With

        Overview.BringToFront()

        Main.btn_temp.Focus()
    End Sub

    Private Sub btn_update_profile_Click(sender As Object, e As EventArgs) Handles btn_update_profile.Click
        With btn_update_profile
            .BackColor = Color.FromArgb(246, 249, 255)
            .ForeColor = Color.Blue
            .FlatAppearance.MouseOverBackColor = .BackColor
        End With

        With btn_overview
            .ForeColor = Color.Black
            .BackColor = Color.White
        End With

        Update_Profile.BringToFront()

        Main.btn_temp.Focus()
    End Sub

    Private Sub img_user_Paint(sender As Object, e As PaintEventArgs) Handles img_user.Paint
        Rounded_Image(img_user)
    End Sub

    Private Sub My_Profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Center_Object(lbl_user_details_full_name)
        Center_Object(lbl_user_details_position)
        Center_Object(img_user)
    End Sub

    Private Sub My_Profile_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        Dim ratio As Double = 350 / 1046

        pnl_user_details_and_image.Width = ratio * Me.Width

        Center_Object(lbl_user_details_full_name)
        Center_Object(lbl_user_details_position)
        Center_Object(img_user)
    End Sub

    Private Sub btn_overview_MouseEnter(sender As Object, e As EventArgs) Handles btn_overview.MouseEnter
        With btn_overview
            .FlatAppearance.MouseOverBackColor = .BackColor
            .FlatAppearance.MouseDownBackColor = .BackColor
        End With
    End Sub

    Private Sub btn_update_profile_MouseEnter(sender As Object, e As EventArgs) Handles btn_update_profile.MouseEnter
        With btn_update_profile
            .FlatAppearance.MouseOverBackColor = .BackColor
            .FlatAppearance.MouseDownBackColor = .BackColor
        End With
    End Sub
End Class
