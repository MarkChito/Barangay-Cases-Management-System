Imports System.Drawing.Drawing2D
Imports System.Globalization

Public Class Main
    Private sidebar_visible = True
    Private pnl_account_details_visible = False
    Private pnl_account_notification_visible = False
    Private loading_timer As Integer = 0
    Private current_tab As String = ""
    Private employee_primary_key As String = ""

    Public Sub Load_Employees_Data()
        Dim results As DataTable = Get_Employee_Data(primary_key)

        Employees.listview_employees.Items.Clear()

        For Each row As DataRow In results.Rows
            Dim fullname As String = ""

            If String.IsNullOrWhiteSpace(row("middle_name")) Then
                fullname = row("first_name") & " " & row("last_name")
            Else
                fullname = row("first_name") & " " & row("middle_name")(0) & ". " & row("last_name")
            End If

            With Employees
                Dim lvi As ListViewItem

                lvi = .listview_employees.Items.Add(row("primary_key").ToString())
                lvi.SubItems.Add(fullname)
                lvi.SubItems.Add(row("position").ToString())
                lvi.SubItems.Add(row("mobile_number").ToString())
                lvi.SubItems.Add(row("email").ToString())
                lvi.SubItems.Add(row("address").ToString())
            End With
        Next
    End Sub

    Public Sub Load_Pending_Cases_Data()
        Dim results As DataTable = Get_Pending_Cases_Data()

        Pending_Cases.listview_employees.Items.Clear()

        For Each row As DataRow In results.Rows

            With Pending_Cases
                Dim lvi As ListViewItem

                lvi = .listview_employees.Items.Add(row("primary_key").ToString())
                lvi.SubItems.Add(row("date").ToString())
                lvi.SubItems.Add(row("time").ToString())
                lvi.SubItems.Add(row("name").ToString())
                lvi.SubItems.Add(row("address").ToString())
                lvi.SubItems.Add(row("nature_of_complaint").ToString())
            End With
        Next
    End Sub

    Public Sub Load_Barangay_Cases_Data()
        Dim results As DataTable = Get_Barangay_Cases_Data()

        Barangay_Cases.listview_employees.Items.Clear()

        For Each row As DataRow In results.Rows
            With Barangay_Cases
                Dim lvi As ListViewItem

                lvi = .listview_employees.Items.Add(row("primary_key").ToString())
                lvi.SubItems.Add(row("date").ToString())
                lvi.SubItems.Add(row("time").ToString())
                lvi.SubItems.Add(row("name").ToString())
                lvi.SubItems.Add(row("address").ToString())
                lvi.SubItems.Add(row("nature_of_complaint").ToString())
            End With
        Next
    End Sub

    Public Sub Load_News_Data()
        Dim results As DataTable = Get_Barangay_News_Data()

        Barangay_News.listview_employees.Items.Clear()

        For Each row As DataRow In results.Rows
            With Barangay_News
                Dim lvi As ListViewItem
                Dim parsedTime As DateTime
                Dim inputDate = row("date").ToString()
                Dim inputTime = row("time").ToString()

                DateTime.TryParseExact(inputDate, "yyyy-MM-dd", Nothing, DateTimeStyles.None, parsedTime)
                DateTime.TryParseExact(inputTime, "HH:mm:ss", Nothing, DateTimeStyles.None, parsedTime)

                Dim formattedDate As String = parsedTime.ToString("MMMM d, yyyy")
                Dim formattedTime As String = parsedTime.ToString("hh:mm tt")

                lvi = .listview_employees.Items.Add(row("primary_key").ToString())
                lvi.SubItems.Add(formattedDate)
                lvi.SubItems.Add(formattedTime)
                lvi.SubItems.Add(row("title").ToString())
                lvi.SubItems.Add(row("body").ToString())
            End With
        Next
    End Sub

    Public Sub Load_Announcements_Data()
        Dim results As DataTable = Get_Announcements_Data()

        Announcements.listview_employees.Items.Clear()

        For Each row As DataRow In results.Rows
            With Announcements
                Dim lvi As ListViewItem
                Dim parsedTime As DateTime
                Dim inputDateandTime = row("date_and_time").ToString()

                DateTime.TryParseExact(inputDateandTime, "yyyy-MM-dd HH:mm:ss", Nothing, DateTimeStyles.None, parsedTime)

                Dim formattedDate As String = parsedTime.ToString("MMMM d, yyyy")
                Dim formattedTime As String = parsedTime.ToString("hh:mm tt")

                lvi = .listview_employees.Items.Add(row("primary_key").ToString())
                lvi.SubItems.Add(formattedDate)
                lvi.SubItems.Add(formattedTime)
                lvi.SubItems.Add(row("title").ToString())
                lvi.SubItems.Add(row("body").ToString())
            End With
        Next
    End Sub

    Private Function Format_Name(ByVal first_name As String) As String
        Dim nameParts() As String = first_name.Split(" "c)
        Dim firstNameInitials As String = ""

        For Each namePart As String In nameParts
            firstNameInitials &= namePart(0).ToString().ToUpper() & ". "
        Next

        Return firstNameInitials
    End Function

    Private Sub Rounded_Image(image As PictureBox)
        Dim path As New GraphicsPath()

        path.AddEllipse(New Rectangle(0, 0, image.Width - 1, image.Height - 1))

        image.Region = New Region(path)
    End Sub

    Public Sub Load_My_Profile_Data()
        Dim result = Get_User_Data(employee_primary_key)
        Dim fullname As String = ""
        Dim user_image As String

        If Not result("image") = "" Then
            user_image = result("image")
        Else
            user_image = "default_user_image.png"
        End If

        If String.IsNullOrWhiteSpace(result("middle_name")) Then
            fullname = result("first_name") & " " & result("last_name")
        Else
            fullname = result("first_name") & " " & result("middle_name")(0) & ". " & result("last_name")
        End If

        With My_Profile
            .img_user.Image = Image.FromFile("dist/img/user_upload/" & user_image)
            .lbl_user_details_full_name.Text = fullname
            .lbl_user_details_position.Text = result("position")

            With .Overview
                .lbl_full_name.Text = fullname

                If Not result("position") = "" Then
                    .lbl_position.Text = result("position")
                End If

                If Not result("mobile_number") = "" Then
                    .lbl_mobile_number.Text = result("mobile_number")
                End If

                If Not result("email") = "" Then
                    .lbl_email.Text = result("email")
                End If

                If Not result("address") = "" Then
                    .lbl_address.Text = result("address")
                End If
            End With

            With .Update_Profile
                .old_image = user_image
                .selected_image = user_image
                .lbl_primary_key.Text = result("primary_key")
                .txt_first_name.Text = result("first_name")
                .txt_middle_name.Text = result("middle_name")
                .txt_last_name.Text = result("last_name")
                .txt_position.Text = result("position")
                .txt_mobile_number.Text = result("mobile_number")
                .txt_email.Text = result("email")
                .txt_address.Text = result("address")
                .img_user.Image = Image.FromFile("dist/img/user_upload/" & user_image)

                .Center_Object(.img_user)
            End With

            .Center_Object(.lbl_user_details_full_name)
            .Center_Object(.lbl_user_details_position)
            .Center_Object(.img_user)
        End With
    End Sub

    Public Sub Load_Employee_Data()
        Dim result = Get_User_Data(employee_primary_key)
        Dim fullname As String = ""
        Dim user_image As String

        If Not result("image") = "" Then
            user_image = result("image")
        Else
            user_image = "default_user_image.png"
        End If

        If String.IsNullOrWhiteSpace(result("middle_name")) Then
            fullname = result("first_name") & " " & result("last_name")
        Else
            fullname = result("first_name") & " " & result("middle_name")(0) & ". " & result("last_name")
        End If

        With Profile
            .img_user.Image = Image.FromFile("dist/img/user_upload/" & user_image)
            .lbl_user_details_full_name.Text = fullname
            .lbl_user_details_position.Text = result("position")

            With .Overview
                .lbl_full_name.Text = fullname

                If Not result("position") = "" Then
                    .lbl_position.Text = result("position")
                End If

                If Not result("mobile_number") = "" Then
                    .lbl_mobile_number.Text = result("mobile_number")
                End If

                If Not result("email") = "" Then
                    .lbl_email.Text = result("email")
                End If

                If Not result("address") = "" Then
                    .lbl_address.Text = result("address")
                End If
            End With

            With .Update_Profile
                .old_image = user_image
                .selected_image = user_image
                .lbl_primary_key.Text = result("primary_key")
                .txt_first_name.Text = result("first_name")
                .txt_middle_name.Text = result("middle_name")
                .txt_last_name.Text = result("last_name")
                .txt_position.Text = result("position")
                .txt_mobile_number.Text = result("mobile_number")
                .txt_email.Text = result("email")
                .txt_address.Text = result("address")
                .img_user.Image = Image.FromFile("dist/img/user_upload/" & user_image)

                .Center_Object(.img_user)
            End With

            With .Employee_Account_Settings
                .lbl_primary_key.Text = result("primary_key")
                .txt_rfid_number.Text = result("rfid_number")
                .txt_username.Text = result("username")

                .old_rfid_number = result("rfid_number")
                .old_username = result("username")
                .old_password = result("password")
            End With

            .Center_Object(.lbl_user_details_full_name)
            .Center_Object(.lbl_user_details_position)
            .Center_Object(.img_user)
        End With
    End Sub

    Public Sub Mouse_Click(btn_name As Object, Optional initial_data As String = "")
        current_tab = btn_name.Name

        btn_pending_cases.BackColor = Color.Transparent
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

        btn_name.BackColor = Color.FromArgb(246, 249, 255)

        With img_loading
            .Visible = True
            .BringToFront()
        End With

        employee_primary_key = initial_data

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

    Public Sub Load_User_Data()
        Dim result = Get_User_Data(primary_key)
        Dim user_image As String = ""

        If Not result("user_type") = "admin" Then
            pnl_spacer_btn_employees.Visible = False
            btn_employees.Visible = False
        Else
            pnl_spacer_btn_employees.Visible = True
            btn_employees.Visible = True
        End If

        btn_account.Text = Format_Name(result("first_name")) & result("last_name")

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

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_temp.Focus()
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
        If sidebar_visible Then
            pnl_sidebar.Visible = False
            sidebar_visible = False
            pnl_banner.Visible = True
        Else
            pnl_sidebar.Visible = True
            sidebar_visible = True
            pnl_banner.Visible = False
        End If

        Hide_Account_Details()
        Hide_Notification()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        'Process.Start(url)
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

        btn_temp.Focus()
    End Sub

    Private Sub Main_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
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

            If current_tab = "btn_dashboard" Then
                Timer1.Stop()

                loading_timer = 0

                Dashboard.BringToFront()
            End If

            If current_tab = "btn_pending_cases" Then
                Load_Cases_Images()
                Load_Pending_Cases_Data()

                Timer1.Stop()

                loading_timer = 0

                Pending_Cases.BringToFront()
            End If

            If current_tab = "btn_barangay_cases" Then
                Load_Cases_Images()
                Load_Barangay_Cases_Data()

                Timer1.Stop()

                loading_timer = 0

                Barangay_Cases.BringToFront()
            End If

            If current_tab = "btn_employees" Then
                Load_Employee_Images()
                Load_Employees_Data()

                Timer1.Stop()

                loading_timer = 0
                Employees.BringToFront()
            End If

            If current_tab = "btn_announcements" Then
                Load_Announcements_Data()

                Timer1.Stop()

                loading_timer = 0
                Announcements.BringToFront()
            End If

            If current_tab = "btn_barangay_news" Then
                Load_News_Images()
                Load_News_Data()

                Timer1.Stop()

                loading_timer = 0
                Barangay_News.BringToFront()
            End If

            If current_tab = "btn_my_profile" Then
                Load_My_Profile_Data()

                My_Profile.BringToFront()
                Timer1.Stop()
                loading_timer = 0
            End If

            If current_tab = "listview_employees" Then
                Load_Employee_Data()

                Profile.BringToFront()
                Timer1.Stop()
                loading_timer = 0
            End If
        End If

        loading_timer += 1
    End Sub

    Private Sub btn_logout_2_Click(sender As Object, e As EventArgs) Handles btn_logout_2.Click
        btn_temp.Focus()

        Hide_Account_Details()
        Hide_Notification()

        Me.Hide()

        MsgBox("You've been successfully signed out", MsgBoxStyle.Information, "Success!")

        With Login
            .Show()
            .txt_username.Focus()
        End With
    End Sub

    Private Sub btn_developers_Click(sender As Object, e As EventArgs) Handles btn_developers.Click
        Hide_Account_Details()
        Hide_Notification()

        Developers.ShowDialog()
    End Sub

    Private Sub btn_account_settings_Click(sender As Object, e As EventArgs) Handles btn_account_settings.Click
        Dim result = Get_User_Data(primary_key)

        Hide_Account_Details()
        Hide_Notification()

        Dim fullname As String = ""

        If String.IsNullOrWhiteSpace(result("middle_name")) Then
            fullname = result("first_name") & " " & result("last_name")
        Else
            fullname = result("first_name") & " " & result("middle_name")(0) & ". " & result("last_name")
        End If

        With Account_Settings
            .txt_fullname.Text = fullname
            .txt_rfid_number.Text = result("rfid_number")
            .txt_username.Text = result("username")

            .old_rfid_number = result("rfid_number")
            .old_username = result("username")
            .old_password = result("password")

            .ShowDialog()
        End With
    End Sub

    Private Sub btn_my_profile_Click(sender As Object, e As EventArgs) Handles btn_my_profile.Click
        Mouse_Click(btn_my_profile, primary_key)
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
                .Location = New Point(img_notification.Location.X - pnl_notification.Width + (5 * 5), pnl_header.Location.Y + 5)
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

    Private Sub btn_pending_cases_Click(sender As Object, e As EventArgs) Handles btn_pending_cases.Click
        Mouse_Click(btn_pending_cases)
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
        btn_temp.Focus()

        primary_key = Nothing

        Me.Hide()

        MsgBox("You have successfully signed out!", MsgBoxStyle.Information, "Success")

        With Login
            .Show()
            .txt_username.Focus()
        End With
    End Sub
End Class