Imports System.Drawing.Drawing2D

Public Class Main
    Private sidebar_visible = True
    Private pnl_account_details_visible = False
    Private pnl_account_notification_visible = False
    Private loading_timer As Integer = 0
    Private current_tab As String = ""

    Private Sub Rounded_Image(image As PictureBox)
        Dim path As New GraphicsPath()

        path.AddEllipse(New Rectangle(0, 0, image.Width - 1, image.Height - 1))

        image.Region = New Region(path)
    End Sub

    Public Sub Mouse_Click(button As Button)
        current_tab = button.Name

        btn_announcements.BackColor = Color.Transparent
        btn_barangay_cases.BackColor = Color.Transparent
        btn_barangay_news.BackColor = Color.Transparent
        btn_dashboard.BackColor = Color.Transparent
        btn_employees.BackColor = Color.Transparent
        btn_logout.BackColor = Color.Transparent

        btn_my_profile.BackColor = Color.Transparent
        btn_account_settings.BackColor = Color.Transparent
        btn_developers.BackColor = Color.Transparent
        btn_logout_2.BackColor = Color.Transparent

        button.BackColor = Color.FromArgb(246, 249, 255)

        With img_loading
            .Visible = True
            .BringToFront()
        End With

        Timer1.Start()
    End Sub

    Public Sub Hide_Account_Details()
        pnl_account_details_visible = False
        pnl_account_details.Visible = False
    End Sub

    Public Sub Hide_Notification()
        pnl_account_notification_visible = False
        pnl_notification.Visible = False
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim result = Get_User_Data(primary_key)
        Dim user_image As String = ""

        btn_account.Text = result("first_name")(0) & ". " & result("last_name")

        If String.IsNullOrWhiteSpace(result("middle_name")) Then
            lbl_account_name.Text = result("first_name") & " " & result("last_name")
        Else
            lbl_account_name.Text = result("first_name") & " " & result("middle_name")(0) & ". " & result("last_name")
        End If

        lbl_account_position.Text = result("position")

        With lbl_account_name
            pnl_account_details.Width = .Width
            lbl_account_position.Width = .Width
            btn_my_profile.Width = .Width
            btn_account_settings.Width = .Width
            btn_developers.Width = .Width
            btn_logout_2.Width = .Width
        End With

        If String.IsNullOrWhiteSpace(result("image")) Then
            user_image = "default_user_image.png"
        Else
            user_image = result("image")
        End If

        img_user.Image = Image.FromFile("dist/img/user_upload/" & user_image)
    End Sub

    Private Sub txt_search_GotFocus(sender As Object, e As EventArgs) Handles txt_search.GotFocus
        If txt_search.Text = "Search" Then
            txt_search.Text = ""
            txt_search.ForeColor = Color.Black
        End If

        Hide_Account_Details()
        Hide_Notification()
    End Sub

    Private Sub txt_search_LostFocus(sender As Object, e As EventArgs) Handles txt_search.LostFocus
        If String.IsNullOrWhiteSpace(txt_search.Text) Then
            txt_search.Text = "Search"
            txt_search.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dialog_result = MessageBox.Show(Me, "Are you sure?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If dialog_result = DialogResult.No Then
            e.Cancel = True
        Else
            Login.Close()
        End If
    End Sub

    Private Sub btn_toggle_sidebar_Click(sender As Object, e As EventArgs) Handles btn_toggle_sidebar.Click
        Hide_Account_Details()
        Hide_Notification()

        If sidebar_visible Then
            pnl_sidebar.Visible = False

            sidebar_visible = False

            pnl_banner.Visible = True
        Else
            pnl_sidebar.Visible = True

            sidebar_visible = True

            pnl_banner.Visible = False
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start(url)
    End Sub

    Private Sub img_user_Click(sender As Object, e As EventArgs) Handles img_user.Click
        btn_account.PerformClick()
    End Sub

    Private Sub btn_account_Click(sender As Object, e As EventArgs) Handles btn_account.Click
        Hide_Notification()

        If Not pnl_account_details_visible Then
            With pnl_account_details
                .Visible = True
                .Location = New Point(pnl_body.Width - pnl_account_details.Width - 5, btn_account.Location.Y + 5)
                .BringToFront()
            End With

            pnl_account_details_visible = True
        Else
            With pnl_account_details
                .Visible = False
            End With

            pnl_account_details_visible = False
        End If
    End Sub

    Private Sub Main_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Hide_Account_Details()
        Hide_Notification()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Hide_Account_Details()
        Hide_Notification()
    End Sub

    Private Sub pnl_sidebar_Click(sender As Object, e As EventArgs) Handles pnl_sidebar.Click
        Hide_Account_Details()
        Hide_Notification()
    End Sub

    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles pnl_footer_outer.Click
        Hide_Account_Details()
        Hide_Notification()
    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click, LinkLabel1.Click, Label5.Click, Label4.Click, Label2.Click
        Hide_Account_Details()
        Hide_Notification()
    End Sub

    Private Sub pnl_footer_outer_SizeChanged(sender As Object, e As EventArgs) Handles pnl_footer_outer.SizeChanged
        Dim centerX As Integer = (pnl_footer_outer.Width - pnl_footer_inner.Width) / 2
        Dim centerY As Integer = (pnl_footer_outer.Height - pnl_footer_inner.Height) / 2

        pnl_footer_inner.Location = New Point(centerX, centerY)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If loading_timer = 1 Then
            img_loading.Visible = False

            Timer1.Stop()

            loading_timer = 0

            If current_tab = "btn_dashboard" Then
                Dashboard.BringToFront()
            End If

            If current_tab = "btn_barangay_cases" Then
                Barangay_Cases.BringToFront()
            End If

            'If current_tab = "btn_employees" Then
            '    Employees.BringToFront()
            'End If

            'If current_tab = "btn_announcements" Then
            '    Announcements.BringToFront()
            'End If

            'If current_tab = "btn_barangay_news" Then
            '    Barangay_News.BringToFront()
            'End If

            'If current_tab = "btn_my_profile" Then
            '    My_Profile.BringToFront()
            'End If
        End If

        loading_timer = loading_timer + 1
    End Sub

    Private Sub btn_logout_2_Click(sender As Object, e As EventArgs) Handles btn_logout_2.Click
        Hide_Account_Details()
        Hide_Notification()

        Me.Hide()

        MsgBox("You've been successfully signed out", MsgBoxStyle.Information, "Success!")

        Login.Show()
    End Sub

    Private Sub btn_developers_Click(sender As Object, e As EventArgs) Handles btn_developers.Click
        Hide_Account_Details()
        Hide_Notification()

        Developers.ShowDialog()
    End Sub

    Private Sub btn_account_settings_Click(sender As Object, e As EventArgs) Handles btn_account_settings.Click
        Hide_Account_Details()
        Hide_Notification()
    End Sub

    Private Sub btn_my_profile_Click(sender As Object, e As EventArgs) Handles btn_my_profile.Click
        Mouse_Click(btn_my_profile)
        Hide_Account_Details()
        Hide_Notification()
    End Sub

    Private Sub img_user_Paint(sender As Object, e As PaintEventArgs) Handles img_user.Paint
        Rounded_Image(img_user)
    End Sub

    Private Sub img_notification_Click(sender As Object, e As EventArgs) Handles img_notification.Click
        Hide_Account_Details()

        If Not pnl_account_notification_visible Then
            With pnl_notification
                .Visible = True
                .Location = New Point(pnl_body.Width - pnl_notification.Width - 5, pnl_header.Location.Y + 5)
                .BringToFront()
            End With

            pnl_account_notification_visible = True
        Else
            With pnl_notification
                .Visible = False
            End With

            pnl_account_notification_visible = False
        End If
    End Sub

    Private Sub btn_dashboard_Click_1(sender As Object, e As EventArgs) Handles btn_dashboard.Click
        Mouse_Click(btn_dashboard)
        Hide_Account_Details()
        Hide_Notification()
    End Sub

    Private Sub btn_barangay_cases_Click(sender As Object, e As EventArgs) Handles btn_barangay_cases.Click
        Mouse_Click(btn_barangay_cases)
        Hide_Account_Details()
        Hide_Notification()
    End Sub

    Private Sub btn_employees_Click(sender As Object, e As EventArgs) Handles btn_employees.Click
        Mouse_Click(btn_employees)
        Hide_Account_Details()
        Hide_Notification()
    End Sub

    Private Sub btn_announcements_Click(sender As Object, e As EventArgs) Handles btn_announcements.Click
        Mouse_Click(btn_announcements)
        Hide_Account_Details()
        Hide_Notification()
    End Sub

    Private Sub btn_barangay_news_Click(sender As Object, e As EventArgs) Handles btn_barangay_news.Click
        Mouse_Click(btn_barangay_news)
        Hide_Account_Details()
        Hide_Notification()
    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        Me.Hide()

        MsgBox("You've been successfully signed out", MsgBoxStyle.Information, "Success!")

        Login.Show()
    End Sub
End Class