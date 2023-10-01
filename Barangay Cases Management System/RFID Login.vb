Public Class RFID_Login
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

    Private Sub txt_rfid_number_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_rfid_number.KeyDown
        If Not Login.is_loading Then
            If e.KeyCode = Keys.Enter Then
                If Not String.IsNullOrWhiteSpace(txt_rfid_number.Text) Then
                    With img_rfid
                        .Image = Image.FromFile("dist/img/loading.gif")
                    End With

                    Login.is_loading = True

                    Dim results = RFID_Authenticate(txt_rfid_number.Text)

                    Dim response_code = results("response_code")

                    If response_code = 200 Then
                        primary_key = results("primary_key")

                        Me.Hide()

                        With Login
                            With .img_loading
                                .Visible = True
                                .BringToFront()
                            End With
                        End With

                        Load_All_Images()
                    Else
                        Login.is_loading = False

                        img_rfid.Image = Image.FromFile("dist/img/scan_rfid_gif.gif")

                        MessageBox.Show("Invalid RFID Card!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)

                        With txt_rfid_number
                            .Clear()
                            .Focus()
                        End With
                    End If
                Else
                    With txt_rfid_number
                        .Clear()
                        .Focus()
                    End With
                End If
            End If
        End If
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        With txt_rfid_number
            .Clear()
            .Focus()
        End With

        Me.Close()
    End Sub

    Private Sub btn_close_Paint(sender As Object, e As PaintEventArgs) Handles btn_close.Paint
        Design_Button(btn_close)
    End Sub

    Private Sub RFID_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With txt_rfid_number
            .Clear()
            .Focus()
        End With
    End Sub

    Private Sub RFID_Login_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        With txt_rfid_number
            .Clear()
            .Focus()
        End With
    End Sub

    Private Sub btn_close_GotFocus(sender As Object, e As EventArgs) Handles btn_close.GotFocus
        With txt_rfid_number
            .Clear()
            .Focus()
        End With
    End Sub
End Class