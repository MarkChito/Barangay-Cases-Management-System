Public Class Add_Announcement
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

    Private Sub btn_close_Paint(sender As Object, e As PaintEventArgs) Handles btn_close.Paint
        Design_Button(btn_close)
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click
        Main.btn_temp.Focus()

        btn_close.Visible = False
        btn_submit.Text = "Processing..."
        btn_submit.Enabled = False

        If Not String.IsNullOrWhiteSpace(txt_announcement_title.Text) And Not String.IsNullOrWhiteSpace(txt_announcement_body.Text) Then
            Add_An_Announcement(txt_announcement_title.Text, txt_announcement_body.Text)

            Me.Hide()

            Main.Load_Announcements_Data()

            MsgBox("You have successfully added an announcement.", MsgBoxStyle.Information, "Success")

            txt_announcement_title.Clear()
            txt_announcement_body.Clear()

            Me.Close()
        Else
            MsgBox("Please complete all the required details!", MsgBoxStyle.Critical, "Error")
        End If

        btn_close.Visible = True
        btn_submit.Enabled = True
        btn_submit.Text = "&Submit Changes"

        Main.btn_temp.Focus()
    End Sub
End Class