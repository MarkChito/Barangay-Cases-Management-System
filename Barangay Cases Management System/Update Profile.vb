Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Net.Http

Public Class Update_Profile
    Public selected_image As String
    Private uploadUrl As String = connection_type & "barangaycasesmanagement.ssystem.online/server/upload_image_from_desktop_app"
    Public old_image As String

    Private Async Sub UploadImageToServerAsync(ByVal imagePath As String, ByVal uploadUrl As String)
        Dim user_image As String = old_image
        Dim errors As Integer = 0

        With btn_submit
            .Text = "Processing Request..."
            .Enabled = False
        End With

        If Not old_image = selected_image Then
            Try
                Dim client As New HttpClient()

                Using content As New MultipartFormDataContent()
                    Dim imageBytes As Byte() = File.ReadAllBytes(imagePath)
                    content.Add(New ByteArrayContent(imageBytes), "file", Path.GetFileName(imagePath))

                    Dim response As HttpResponseMessage = Await client.PostAsync(uploadUrl, content)

                    If response.IsSuccessStatusCode Then
                        Dim image_name As String = Await response.Content.ReadAsStringAsync()

                        File.Copy(imagePath, "dist/img/user_upload/" + image_name)

                        user_image = image_name
                    Else
                        errors += 1

                        MsgBox("Error uploading file. Status code: " & response.StatusCode.ToString(), MsgBoxStyle.Critical, "Error")
                    End If
                End Using
            Catch ex As Exception
                errors += 1

                MsgBox("An error occurred: " & ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        Else
            user_image = old_image
        End If

        If errors = 0 Then
            Update_Profile_Information(txt_first_name.Text, txt_middle_name.Text, txt_last_name.Text, txt_position.Text, txt_mobile_number.Text, txt_email.Text, txt_address.Text, user_image, lbl_primary_key.Text)

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
        End If

        With btn_submit
            .Text = "&Submit Changes"
            .Enabled = True
        End With
    End Sub

    Private Sub Rounded_Image(image As PictureBox)
        Dim path As New GraphicsPath()

        path.AddEllipse(New Rectangle(0, 0, image.Width - 1, image.Height - 1))

        image.Region = New Region(path)
    End Sub

    Public Sub Center_Object(obj_name As Object)
        Dim panelWidth As Integer = pnl_profile_image.Width
        Dim labelWidth As Integer = obj_name.Width
        Dim centerX As Integer = (panelWidth - labelWidth) / 2

        obj_name.Location = New Point(centerX, obj_name.Location.Y)
    End Sub

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
        UploadImageToServerAsync(selected_image, uploadUrl)
    End Sub

    Private Sub img_user_Paint(sender As Object, e As PaintEventArgs) Handles img_user.Paint
        Rounded_Image(img_user)
    End Sub

    Private Sub Update_Profile_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        Center_Object(img_user)
    End Sub

    Private Sub img_user_Click(sender As Object, e As EventArgs) Handles img_user.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif|All Files|*.*"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim imagePath As String = openFileDialog.FileName

            selected_image = imagePath

            img_user.Image = Image.FromFile(imagePath)
        End If
    End Sub
End Class
