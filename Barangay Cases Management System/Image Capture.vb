Imports AForge.Video
Imports AForge.Video.DirectShow
Imports System.IO
Imports System.Net.Http
Imports System.Security.Cryptography
Imports System.Text

Public Class Image_Capture
    Private videoSource As VideoCaptureDevice
    Private capturedImage As Bitmap
    Private selected_image As String
    Private uploadUrl As String = connection_type & "barangaycasesmanagement.ssystem.online/server/upload_image_from_desktop_app"

    Private Function Video_Initialize()
        Dim videoDevices As FilterInfoCollection = New FilterInfoCollection(FilterCategory.VideoInputDevice)

        If videoDevices.Count > 0 Then
            videoSource = New VideoCaptureDevice(videoDevices(0).MonikerString)

            Return True
        Else
            Return False
        End If
    End Function

    Private Sub VideoSource_NewFrame(sender As Object, eventArgs As NewFrameEventArgs)
        With img_live_camera
            .SizeMode = PictureBoxSizeMode.StretchImage
            .Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)
        End With
    End Sub

    Private Sub Start_Camera()
        With img_live_camera
            .SizeMode = PictureBoxSizeMode.CenterImage
            .Image = Image.FromFile("dist/img/loading.gif")
        End With

        If videoSource IsNot Nothing Then
            AddHandler videoSource.NewFrame, AddressOf VideoSource_NewFrame

            videoSource.Start()
        Else
            img_live_camera.Image = Nothing
        End If
    End Sub

    Public Sub Stop_Camera()
        If videoSource IsNot Nothing AndAlso videoSource.IsRunning Then
            videoSource.SignalToStop()

            With btn_start_webcam
                .Enabled = True
                .Cursor = Cursors.Hand
            End With

            With btn_stop_webcam
                .Enabled = False
                .Cursor = Cursors.No
            End With

            With btn_capture_image
                .Enabled = False
                .Cursor = Cursors.No
            End With

            img_live_camera.Image = Nothing

            lbl_camera_is_off.Show()
        End If
    End Sub

    Private Async Sub UploadImageToServerAsync(ByVal imagePath As String, ByVal uploadUrl As String)
        Dim errors As Integer = 0
        Dim user_image As String = "default_image.png"

        If errors = 0 Then
            If Not selected_image = "" Then
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
                            MsgBox("Error uploading file. Status code: " & response.StatusCode.ToString(), MsgBoxStyle.Critical, "Error")

                            errors += 1
                        End If
                    End Using
                Catch ex As Exception
                    MsgBox("An error occurred: " & ex.Message, MsgBoxStyle.Critical, "Error")

                    errors += 1
                End Try
            End If

            If errors = 0 Then
                If Not is_edit_pending_case Then
                    With Main.Add_Barangay_Case
                        Add_A_Barangay_Case(.txt_full_name.Text, .txt_mobile_number.Text, .txt_address.Text, .txt_nature_of_complaint.Text, .txt_description.Text, user_image)

                        .txt_full_name.Clear()
                        .txt_mobile_number.Clear()
                        .txt_address.Clear()
                        .txt_nature_of_complaint.Text = Nothing
                        .txt_description.Clear()
                    End With
                Else
                    is_edit_pending_case = False

                    With Main.Edit_Barangay_Case
                        Update_A_Barangay_Case(.txt_full_name.Text, .txt_mobile_number.Text, .txt_address.Text, .txt_nature_of_complaint.Text, .txt_description.Text, user_image, "4", .lbl_primary_key.Text)

                        .txt_full_name.Clear()
                        .txt_mobile_number.Clear()
                        .txt_address.Clear()
                        .txt_nature_of_complaint.Text = Nothing
                        .txt_description.Clear()
                    End With
                End If

                Stop_Camera()

                img_captured_image.Image = Nothing
                lbl_no_image.Show()

                btn_reject.Hide()

                With btn_submit
                    .Enabled = True
                    .Location = New Point(.Location.X + 40, .Location.Y)
                    .Width = 122
                    .Text = "&Submit"
                End With

                With btn_previous
                    .Show()
                    .Location = New Point(btn_submit.Location.X - 138, .Location.Y)
                End With

                Main.Mouse_Click(Main.btn_barangay_cases)

                If Not is_edit_pending_case Then
                    MsgBox("You've successfully added a barangay case.", MsgBoxStyle.Information, "Success")
                Else
                    MsgBox("You've successfully approved a barangay case.", MsgBoxStyle.Information, "Success")
                End If
            End If
        End If
    End Sub

    Private Sub Center_Object(parent_obj As Object, child_obj As Object)
        Dim centerX As Integer = (parent_obj.Width - child_obj.width) / 2
        Dim centerY As Integer = parent_obj.Height / 2

        child_obj.Location = New Point(centerX, centerY)
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

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles lbl_barangay_pending_case.Click
        If is_edit_pending_case Then
            Main.Mouse_Click(Main.btn_pending_cases)
        Else
            Main.Mouse_Click(Main.btn_barangay_cases)
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lbl_dashboard.Click
        Main.Mouse_Click(Main.btn_dashboard)
    End Sub

    Private Sub btn_submit_Paint(sender As Object, e As PaintEventArgs) Handles btn_submit.Paint
        Design_Button(btn_submit)
    End Sub

    Private Sub btn_previous_Paint(sender As Object, e As PaintEventArgs) Handles btn_previous.Paint
        Design_Button(btn_previous)
    End Sub

    Private Sub btn_reject_Paint(sender As Object, e As PaintEventArgs) Handles btn_reject.Paint
        Design_Button(btn_reject)
    End Sub

    Private Sub btn_previous_Click(sender As Object, e As EventArgs) Handles btn_previous.Click
        btn_stop_webcam.PerformClick()

        Main.Mouse_Click(btn_previous)
    End Sub

    Private Sub Image_Capture_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        pnl_webcam_preview.Width = (pnl_parent.Width / 2) - 3
        pnl_capture_image.Width = (pnl_parent.Width / 2) - 3

        btn_start_webcam.Width = (pnl_camera_buttons.Width / 2) - 10

        With btn_stop_webcam
            .Width = (pnl_camera_buttons.Width / 2) - 10
            .Location = New Point(.Width + 14, btn_start_webcam.Location.Y)
        End With

        Center_Object(img_live_camera, lbl_camera_is_off)
        Center_Object(img_captured_image, lbl_no_image)
    End Sub

    Private Sub btn_start_webcam_Click(sender As Object, e As EventArgs) Handles btn_start_webcam.Click
        Main.btn_temp.Focus()

        If Video_Initialize() Then
            Start_Camera()

            With btn_start_webcam
                .Enabled = False
                .Cursor = Cursors.No
            End With

            With btn_stop_webcam
                .Enabled = True
                .Cursor = Cursors.Hand
            End With

            With btn_capture_image
                .Enabled = True
                .Cursor = Cursors.Hand
            End With

            lbl_camera_is_off.Hide()
        Else
            MsgBox("No Camera Detected! Make sure your camera is properly inserted and try again.", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub btn_stop_webcam_Click(sender As Object, e As EventArgs) Handles btn_stop_webcam.Click
        Stop_Camera()
    End Sub

    Private Sub btn_capture_image_Click(sender As Object, e As EventArgs) Handles btn_capture_image.Click
        Main.btn_temp.Focus()

        If videoSource IsNot Nothing AndAlso videoSource.IsRunning Then
            capturedImage = DirectCast(img_live_camera.Image.Clone(), Bitmap)

            img_captured_image.Image = capturedImage

            lbl_no_image.Visible = False
        End If
    End Sub

    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click
        Dim errors As Integer = 0

        btn_previous.Hide()
        btn_reject.Hide()

        With btn_submit
            .Location = New Point(.Location.X - 40, .Location.Y)
            .Width = 162
            .Text = "Processing..."
            .Enabled = False
        End With

        If capturedImage IsNot Nothing Then
            Try
                Dim fileName As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")

                Using md5 As MD5 = MD5.Create()
                    Dim inputBytes As Byte() = Encoding.UTF8.GetBytes(fileName)
                    Dim hashBytes As Byte() = md5.ComputeHash(inputBytes)

                    Dim sb As StringBuilder = New StringBuilder()

                    For Each b As Byte In hashBytes
                        sb.Append(b.ToString("x2"))
                    Next

                    Dim filePath As String = "temp/" & sb.ToString() & ".jpg"

                    capturedImage.Save(filePath, Imaging.ImageFormat.Jpeg)

                    selected_image = filePath
                End Using
            Catch ex As Exception
                MsgBox("Error saving the image: " & ex.Message, MsgBoxStyle.Critical, "Error")

                errors += 1
            End Try
        End If

        If errors = 0 Then
            UploadImageToServerAsync(selected_image, uploadUrl)
        End If
    End Sub

    Private Sub btn_reject_Click(sender As Object, e As EventArgs) Handles btn_reject.Click
        Dim errors As Integer = 0

        btn_previous.Hide()
        btn_submit.Hide()

        With btn_reject
            .Location = New Point(.Location.X + 92, .Location.Y)
            .Width = 162
            .Text = "Processing..."
            .Enabled = False
        End With

        is_edit_pending_case = False

        With Main.Edit_Barangay_Case
            Update_A_Barangay_Case(.txt_full_name.Text, .txt_mobile_number.Text, .txt_address.Text, .txt_nature_of_complaint.Text, .txt_description.Text, "default_user_image.png", "3", .lbl_primary_key.Text)

            .txt_full_name.Clear()
            .txt_mobile_number.Clear()
            .txt_address.Clear()
            .txt_nature_of_complaint.Text = Nothing
            .txt_description.Clear()
        End With

        Stop_Camera()

        img_captured_image.Image = Nothing
        lbl_no_image.Show()

        btn_submit.Show()

        With btn_previous
            .Show()
            .Location = New Point(btn_submit.Location.X - 138, .Location.Y)
        End With

        With btn_reject
            .Enabled = True
            .Width = 116
            .Text = "&Reject"
            .Hide()
        End With

        Main.Mouse_Click(Main.btn_pending_cases)

        MsgBox("You've successfully rejected a barangay case.", MsgBoxStyle.Information, "Success")
    End Sub
End Class
