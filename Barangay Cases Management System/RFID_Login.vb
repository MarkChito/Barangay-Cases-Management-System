Public Class RFID_Login
    Private Sub img_close_Click(sender As Object, e As EventArgs) Handles img_close.Click
        Me.Close()
    End Sub

    Private Sub txt_rfid_number_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_rfid_number.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Not String.IsNullOrWhiteSpace(txt_rfid_number.Text) Then
                With img_rfid
                    .SizeMode = PictureBoxSizeMode.CenterImage
                    .Image = Image.FromFile("dist/img/loading.gif")
                End With

                Dim results = RFID_Authenticate(txt_rfid_number.Text)

                Dim response_code = results("response_code")

                If response_code = 200 Then
                    primary_key = results("primary_key")

                    Me.Hide()

                    With Login
                        .txt_username.Enabled = False
                        .txt_password.Enabled = False
                        .img_show_hide_password.Enabled = False
                        .check_remember_me.Enabled = False
                        .btn_rfid_login.Enabled = False

                        With .btn_login
                            .Text = "Checking Credentials..."
                            .Enabled = False
                        End With

                        With .img_loading
                            .Visible = True
                            .BringToFront()
                        End With
                    End With

                    Load_All_Images()

                    Main.Show()

                    With Login
                        .Hide()
                        .txt_username.Enabled = True
                        .txt_password.Enabled = True
                        .img_show_hide_password.Enabled = True
                        .check_remember_me.Enabled = True
                        .btn_rfid_login.Enabled = True

                        With .btn_login
                            .Enabled = True
                            .Text = "Login"
                        End With

                        With .img_loading
                            .Visible = False
                            .SendToBack()
                        End With
                    End With

                    With img_rfid
                        .SizeMode = PictureBoxSizeMode.StretchImage
                        .Image = Image.FromFile("dist/img/scan_rfid_gif.gif")
                    End With

                    Me.Close()
                Else
                    With img_rfid
                        .SizeMode = PictureBoxSizeMode.StretchImage
                        .Image = Image.FromFile("dist/img/scan_rfid_gif.gif")
                    End With

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
    End Sub
End Class