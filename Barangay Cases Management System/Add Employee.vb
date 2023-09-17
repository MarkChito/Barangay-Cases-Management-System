Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Net.Http

Public Class Add_Employee
    Private Sub Rounded_Image(image As PictureBox)
        Dim path As New GraphicsPath()

        path.AddEllipse(New Rectangle(0, 0, image.Width - 1, image.Height - 1))

        image.Region = New Region(path)
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

    Private Async Sub UploadImageToServerAsync(ByVal imagePath As String, ByVal uploadUrl As String)
        Try
            Dim client As New HttpClient()

            Using content As New MultipartFormDataContent()
                Dim imageBytes As Byte() = File.ReadAllBytes(imagePath)
                content.Add(New ByteArrayContent(imageBytes), "file", Path.GetFileName(imagePath))

                Dim response As HttpResponseMessage = Await client.PostAsync(uploadUrl, content)

                If response.IsSuccessStatusCode Then
                    Dim imageStream As New MemoryStream(imageBytes)
                    Dim image As Image = Image.FromStream(imageStream)

                    img_user.Image = image
                Else
                    MessageBox.Show("Error uploading file. Status code: " & response.StatusCode.ToString())
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub btn_submit_Paint(sender As Object, e As PaintEventArgs) Handles btn_submit.Paint
        Design_Button(btn_submit)
    End Sub

    Private Sub btn_close_Paint(sender As Object, e As PaintEventArgs) Handles btn_close.Paint
        Design_Button(btn_close)
    End Sub

    Private Sub img_user_Paint(sender As Object, e As PaintEventArgs) Handles img_user.Paint
        Rounded_Image(img_user)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif|All Files|*.*"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim imagePath As String = openFileDialog.FileName
            Dim uploadUrl As String = connection_type & "barangaycasesmanagement.ssystem.online/server/upload_image_from_desktop_app"
            UploadImageToServerAsync(imagePath, uploadUrl)
        End If
    End Sub
End Class