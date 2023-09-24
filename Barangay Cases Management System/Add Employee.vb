Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Net.Http
Imports System.Text.RegularExpressions

Public Class Add_Employee
    Private selected_image As String
    Private uploadUrl As String = connection_type & "barangaycasesmanagement.ssystem.online/server/upload_image_from_desktop_app"

    Private Function Verify_Password(password As String, confirm_password As String)
        Dim errorCount As Integer = 0

        btn_submit.Enabled = True
        btn_submit.Text = "&Submit Changes"

        If Not password = "" Or Not confirm_password = "" Then
            If password <> confirm_password Then
                ' Passwords do not match
                MsgBox("Passwords do not match", MsgBoxStyle.Critical, "Error")

                errorCount += 1

            ElseIf password.Length < 8 Then
                ' Password must be at least 8 characters long
                MsgBox("Password must be at least 8 characters long", MsgBoxStyle.Critical, "Error")

                errorCount += 1

            ElseIf Not Regex.IsMatch(password, "[A-Z]") Then
                ' Password must have at least one uppercase letter (A-Z)
                MsgBox("Password must have at least one uppercase letter (A-Z)", MsgBoxStyle.Critical, "Error")

                errorCount += 1

            ElseIf Not Regex.IsMatch(password, "[a-z]") Then
                ' Password must have at least one lowercase letter (a-z)
                MsgBox("Password must have at least one lowercase letter (a-z)", MsgBoxStyle.Critical, "Error")

                errorCount += 1

            ElseIf Not Regex.IsMatch(password, "[0-9]") Then
                ' Password must have at least one digit (0-9)
                MsgBox("Password must have at least one digit (0-9)", MsgBoxStyle.Critical, "Error")

                errorCount += 1

            ElseIf Not Regex.IsMatch(password, "[!@#$%^&*()_+\-=[\]{};':|,.<>/]") Then
                ' Password must have at least one special character
                MsgBox("Password must have at least one special character (e.g., !@#$%^&*()_+-=[]{};':|,.<>/?)", MsgBoxStyle.Critical, "Error")

                errorCount += 1
            End If
        End If

        If errorCount = 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function Verify_Mobile_Number(phoneNumber As String) As Boolean
        ' Regular expression for a valid Philippine mobile number
        Dim regexPattern As String = "^(09)\d{9}$"
        Dim regex As New Regex(regexPattern)
        Return regex.IsMatch(phoneNumber) AndAlso phoneNumber.Length = 11
    End Function

    Private Function Verify_Email(emailAddress As String) As Boolean
        ' Regular expression for a simple email address validation
        Dim regexPattern As String = "^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}$"
        Dim regex As New Regex(regexPattern)
        Return regex.IsMatch(emailAddress)
    End Function

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
        Dim errors As Integer = 0
        Dim user_image As String = "default_user_image.png"

        Main.btn_temp.Focus()

        btn_close.Visible = False
        btn_submit.Text = "Processing..."
        btn_submit.Enabled = False

        If Verify_Password(txt_password.Text, txt_confirm_password.Text) Then
            If Not Verify_Email(txt_email.Text) Then
                MsgBox("Email address is not valid!", MsgBoxStyle.Critical, "Error")

                txt_email.Focus()

                errors += 1

            ElseIf Not Verify_Mobile_Number(txt_mobile_number.Text) Then
                MsgBox("Mobile Number is not valid!", MsgBoxStyle.Critical, "Error")

                txt_mobile_number.Focus()

                errors += 1

            ElseIf Not Add_Employee_Check_Username(txt_username.Text) Then
                MsgBox("Username already exists!", MsgBoxStyle.Critical, "Error")

                txt_username.Focus()

                errors += 1

            ElseIf Not Add_Employee_Check_RFID_Number(txt_rfid_number.Text) Then
                MsgBox("RFID Number already exists!", MsgBoxStyle.Critical, "Error")

                txt_rfid_number.Focus()

                errors += 1
            End If

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
                    Add_An_Employee(txt_first_name.Text, txt_middle_name.Text, txt_last_name.Text, txt_rfid_number.Text, txt_position.Text, txt_mobile_number.Text, txt_email.Text, txt_address.Text, txt_username.Text, txt_password.Text, user_image)

                    Main.Load_Employees_Data()

                    txt_first_name.Clear()
                    txt_middle_name.Clear()
                    txt_last_name.Clear()
                    txt_rfid_number.Clear()
                    txt_mobile_number.Clear()
                    txt_email.Clear()
                    txt_position.Text = Nothing
                    txt_address.Clear()
                    txt_username.Clear()
                    txt_password.Clear()
                    txt_confirm_password.Clear()
                    img_user.Image = Image.FromFile("dist/img/user_upload/default_user_image.png")

                    selected_image = ""

                    Me.Hide()

                    MsgBox("Successfully Added an Employee", MsgBoxStyle.Information, "Success")

                    Me.Close()
                End If
            End If
        End If

        btn_close.Visible = True
        btn_submit.Enabled = True
        btn_submit.Text = "&Submit Changes"

        Main.btn_temp.Focus()
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

            selected_image = imagePath

            img_user.Image = Image.FromFile(imagePath)
        End If
    End Sub

    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click
        If Not String.IsNullOrWhiteSpace(txt_first_name.Text) And Not String.IsNullOrWhiteSpace(txt_last_name.Text) And Not String.IsNullOrWhiteSpace(txt_rfid_number.Text) And Not String.IsNullOrWhiteSpace(txt_mobile_number.Text) And Not String.IsNullOrWhiteSpace(txt_email.Text) And Not String.IsNullOrWhiteSpace(txt_position.Text) And Not String.IsNullOrWhiteSpace(txt_address.Text) And Not String.IsNullOrWhiteSpace(txt_username.Text) And Not String.IsNullOrWhiteSpace(txt_password.Text) And Not String.IsNullOrWhiteSpace(txt_confirm_password.Text) Then
            UploadImageToServerAsync(selected_image, uploadUrl)
        Else
            MsgBox("Please complete all the required fields", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub txt_rfid_number_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_rfid_number.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_mobile_number_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_mobile_number.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class