Imports System.Text.RegularExpressions

Public Class Employee_Account_Settings
    Public old_rfid_number As String
    Public old_username As String
    Public old_password As String

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

    Private Sub btn_submit_Paint(sender As Object, e As PaintEventArgs) Handles btn_submit.Paint
        Design_Button(btn_submit)
    End Sub

    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click
        Main.btn_temp.Focus()

        Dim password As String

        btn_submit.Text = "Processing..."
        btn_submit.Enabled = False

        If String.IsNullOrWhiteSpace(txt_password.Text) Then
            password = old_password
        Else
            password = Password_Hash(txt_password.Text)
        End If

        If Not String.IsNullOrWhiteSpace(txt_username.Text) And Not String.IsNullOrWhiteSpace(txt_rfid_number.Text) Then
            Dim errors As Integer = 0

            If Not Check_Username(txt_username.Text, old_username) Then
                MsgBox("Username already exists!", MsgBoxStyle.Critical, "Error")
                txt_username.Focus()

                errors += 1
            End If

            If Not Check_RFID_Number(txt_rfid_number.Text, old_rfid_number) Then
                MsgBox("RFID Number already exists!", MsgBoxStyle.Critical, "Error")
                txt_rfid_number.Focus()

                errors += 1
            End If

            If Verify_Password(txt_password.Text, txt_confirm_password.Text) And errors = 0 Then
                Update_Account(txt_rfid_number.Text, txt_username.Text, password, lbl_primary_key.Text)

                MsgBox("Employee account is successfully updated!", MsgBoxStyle.Information, "Success")
            End If
        Else
            MsgBox("Please complete all the required details!", MsgBoxStyle.Critical, "Error")
        End If

        btn_submit.Enabled = True
        btn_submit.Text = "&Submit Changes"

        Main.btn_temp.Focus()
    End Sub
End Class
