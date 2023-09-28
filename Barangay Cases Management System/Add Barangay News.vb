Imports System.IO
Imports System.Net.Http

Public Class Add_Barangay_News
    Private selected_image As String
    Private uploadUrl As String = connection_type & "barangaycasesmanagement.ssystem.online/server/upload_image_from_desktop_app"

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

    Private Async Sub UploadImageToServerAsync(ByVal imagePath As String, ByVal uploadUrl As String)
        Dim errors As Integer = 0
        Dim user_image As String = "default_user_image.png"

        Main.btn_temp.Focus()

        btn_close.Visible = False
        btn_submit.Text = "Processing..."
        btn_submit.Enabled = False

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
                Add_A_Barangay_News(txt_barangay_news_title.Text, txt_barangay_news_body.Text, user_image)

                Main.Load_News_Data()

                txt_barangay_news_title.Clear()
                txt_barangay_news_body.Clear()
                img_barangay_news_image.Image = Image.FromFile("dist/img/user_upload/default_user_image.png")

                selected_image = ""

                Me.Hide()

                MsgBox("Successfully Added a Barangay News", MsgBoxStyle.Information, "Success")

                Me.Close()
            End If
        End If

        btn_close.Visible = True
        btn_submit.Enabled = True
        btn_submit.Text = "&Submit Changes"

        Main.btn_temp.Focus()
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

    Private Sub btn_upload_Click(sender As Object, e As EventArgs) Handles btn_upload.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif|All Files|*.*"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim imagePath As String = openFileDialog.FileName

            selected_image = imagePath

            img_barangay_news_image.Image = Image.FromFile(imagePath)
        End If
    End Sub

    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click
        If Not String.IsNullOrWhiteSpace(txt_barangay_news_title.Text) And Not String.IsNullOrWhiteSpace(txt_barangay_news_body.Text) Then
            UploadImageToServerAsync(selected_image, uploadUrl)
        Else
            MsgBox("Please complete all the required fields", MsgBoxStyle.Critical, "Error")
        End If
    End Sub
End Class