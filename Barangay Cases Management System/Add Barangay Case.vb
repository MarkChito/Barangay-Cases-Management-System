Imports System.Text.RegularExpressions

Public Class Add_Barangay_Case
    Private Function Verify_Mobile_Number(phoneNumber As String) As Boolean
        Dim regexPattern As String = "^(09)\d{9}$"
        Dim regex As New Regex(regexPattern)

        Return regex.IsMatch(phoneNumber) AndAlso phoneNumber.Length = 11
    End Function

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

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        With Main
            .Mouse_Click(.btn_dashboard)
            .Hide_Account_Details()
            .Hide_Notification()
        End With
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        With Main
            .Mouse_Click(.btn_barangay_cases)
            .Hide_Account_Details()
            .Hide_Notification()
        End With
    End Sub

    Private Sub btn_next_Paint(sender As Object, e As PaintEventArgs) Handles btn_next.Paint
        Design_Button(btn_next)
    End Sub

    Private Sub pnl_parent_SizeChanged(sender As Object, e As EventArgs) Handles pnl_parent.SizeChanged
        pnl_full_name.Width = pnl_parent.Width / 2
        pnl_mobile_number.Width = pnl_parent.Width / 2
    End Sub

    Private Sub btn_next_Click(sender As Object, e As EventArgs) Handles btn_next.Click
        If Not String.IsNullOrWhiteSpace(txt_full_name.Text) And Not String.IsNullOrWhiteSpace(txt_mobile_number.Text) And Not String.IsNullOrWhiteSpace(txt_address.Text) And Not String.IsNullOrWhiteSpace(txt_nature_of_complaint.Text) And Not String.IsNullOrWhiteSpace(txt_description.Text) Then
            If Not Verify_Mobile_Number(txt_mobile_number.Text) Then
                MsgBox("Mobile Number is not valid!", MsgBoxStyle.Critical, "Error")

                txt_mobile_number.Focus()
            Else
                With Main
                    .Mouse_Click(btn_next)
                    .Hide_Account_Details()
                    .Hide_Notification()
                End With
            End If
        Else
            Main.btn_temp.Focus()

            MsgBox("Please complete all the required details!", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub txt_mobile_number_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_mobile_number.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class
