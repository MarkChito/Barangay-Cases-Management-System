Imports System.Text.RegularExpressions

Public Class Account_Settings
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

    Private Sub btn_submit_Paint(sender As Object, e As PaintEventArgs) Handles btn_submit.Paint
        Design_Button(btn_submit)
    End Sub

    Private Sub btn_close_Paint(sender As Object, e As PaintEventArgs) Handles btn_close.Paint
        Design_Button(btn_close)
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub txt_password_GotFocus(sender As Object, e As EventArgs) Handles txt_password.GotFocus
        If txt_password.Text = "Password is hidden for security" Then
            With txt_password
                .UseSystemPasswordChar = True
                .Text = ""
                .ForeColor = Color.Black
            End With
        End If
    End Sub

    Private Sub txt_password_LostFocus(sender As Object, e As EventArgs) Handles txt_password.LostFocus
        If String.IsNullOrWhiteSpace(txt_password.Text) Then
            With txt_password
                .UseSystemPasswordChar = False
                .Text = "Password is hidden for security"
                .ForeColor = Color.Gray
            End With
        End If
    End Sub

    Private Sub txt_confirm_password_GotFocus(sender As Object, e As EventArgs) Handles txt_confirm_password.GotFocus
        If txt_confirm_password.Text = "Password is hidden for security" Then
            With txt_confirm_password
                .UseSystemPasswordChar = True
                .Text = ""
                .ForeColor = Color.Black
            End With
        End If
    End Sub

    Private Sub txt_confirm_password_LostFocus(sender As Object, e As EventArgs) Handles txt_confirm_password.LostFocus
        If String.IsNullOrWhiteSpace(txt_confirm_password.Text) Then
            With txt_confirm_password
                .UseSystemPasswordChar = False
                .Text = "Password is hidden for security"
                .ForeColor = Color.Gray
            End With
        End If
    End Sub

    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click
        Main.btn_temp.Focus()

        Dim password As String

        btn_close.Visible = False
        btn_submit.Text = "Processing..."
        btn_submit.Enabled = False

        If String.IsNullOrWhiteSpace(txt_password.Text) Or txt_password.Text = "Password is hidden for security" Then
            password = old_password
        Else
            password = Password_Hash(txt_password.Text)
        End If

        If Not String.IsNullOrWhiteSpace(txt_username.Text) And Not String.IsNullOrWhiteSpace(txt_rfid_number.Text) Then
            If Verify_Password(txt_password.Text, txt_confirm_password.Text) Then
                Update_Account(txt_rfid_number.Text, txt_username.Text, password, primary_key)

                Me.Hide()

                MsgBox("Your account is successfully updated!", MsgBoxStyle.Information, "Success")

                Me.Close()
            End If
        Else
            MsgBox("Please complete all the required details!", MsgBoxStyle.Critical, "Error")
        End If

        btn_close.Visible = True
        btn_submit.Enabled = True
        btn_submit.Text = "&Submit Changes"

        Main.btn_temp.Focus()
    End Sub

    Private Function Verify_Password(password As String, confirm_password As String)
        Dim errorCount As Integer = 0

        If Not password = "Password is hidden for security" Or Not confirm_password = "Password is hidden for security" Then
            If Not Regex.IsMatch(password, "[A-Z]") Then
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

            ElseIf password.Length < 8 Then
                ' Password must be at least 8 characters long
                MsgBox("Password must be at least 8 characters long", MsgBoxStyle.Critical, "Error")

                errorCount += 1

            ElseIf password <> confirm_password Then
                ' Passwords do not match
                MsgBox("Passwords do not match", MsgBoxStyle.Critical, "Error")

                errorCount += 1
            End If
        End If

        If errorCount = 0 Then
            Return True
        Else
            Return False
        End If
    End Function
End Class