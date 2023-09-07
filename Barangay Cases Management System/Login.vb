Imports System.IO

Public Class Login
    Private password_hidden As Boolean = True
    Private file_path = "session/login/Session.txt"

    Private Sub Open_File()
        If Not File.Exists(file_path) Then
            Try
                Dim fileStream As FileStream = File.Open(file_path, FileMode.Create, FileAccess.Write)

                Dim writer As New StreamWriter(fileStream)

                writer.Close()
                fileStream.Close()
            Catch ex As Exception
                ' Ignore Error
            End Try
        End If
    End Sub

    Public Sub Write_File(data As String)
        If File.Exists(file_path) Then
            Try
                Dim fileStream As FileStream = File.Open(file_path, FileMode.Open, FileAccess.ReadWrite)

                Dim writer As New StreamWriter(fileStream)

                writer.WriteLine(data)

                writer.Close()
                fileStream.Close()
            Catch ex As Exception
                ' Ignore Error
            End Try
        End If
    End Sub

    Private Sub CenterPanel()
        Dim centerX As Integer = Me.ClientSize.Width \ 2 - pnl_login.Width \ 2
        Dim centerY As Integer = Me.ClientSize.Height \ 2 - pnl_login.Height \ 2

        pnl_login.Location = New Point(centerX, centerY)
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterPanel()
        Database_Open()
        Open_File()
    End Sub

    Private Sub Login_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        CenterPanel()
    End Sub

    Private Sub btn_login_Paint(sender As Object, e As PaintEventArgs) Handles btn_login.Paint
        Dim path As New Drawing2D.GraphicsPath()
        Dim cornerRadius As Integer = &B10100

        path.AddArc(0, 0, cornerRadius * 2, cornerRadius * 2, 180, 90)
        path.AddArc(btn_login.Width - (cornerRadius * 2), 0, cornerRadius * 2, cornerRadius * 2, 270, 90)
        path.AddArc(btn_login.Width - (cornerRadius * 2), btn_login.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 0, 90)
        path.AddArc(0, btn_login.Height - (cornerRadius * 2), cornerRadius * 2, cornerRadius * 2, 90, 90)
        path.CloseFigure()

        btn_login.Region = New Region(path)
    End Sub

    Private Sub img_show_hide_password_Click(sender As Object, e As EventArgs) Handles img_show_hide_password.Click
        If password_hidden Then
            txt_password.UseSystemPasswordChar = False
            img_show_hide_password.Image = Image.FromFile("dist/img/password_hide.png")

            password_hidden = False
        Else
            txt_password.UseSystemPasswordChar = True
            img_show_hide_password.Image = Image.FromFile("dist/img/password_show.png")

            password_hidden = True
        End If
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        btn_temp.Focus()

        If String.IsNullOrWhiteSpace(txt_username.Text) Then
            MessageBox.Show("Please fill in the Username field.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_username.Focus()
        ElseIf String.IsNullOrWhiteSpace(txt_password.Text) Then
            MessageBox.Show("Please fill in the Password field.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_password.Focus()
        Else
            txt_username.Enabled = False
            txt_password.Enabled = False
            img_show_hide_password.Enabled = False
            check_remember_me.Enabled = False
            btn_rfid_login.Enabled = False

            With btn_login
                .Text = "Checking Credentials..."
                .Enabled = False
            End With

            Dim results = Authenticate(txt_username.Text, txt_password.Text)

            Dim response_code = results("response_code")

            If response_code = 200 Then
                With img_loading
                    .Visible = True
                    .BringToFront()
                End With

                primary_key = results("primary_key")

                Load_All_Images()
                Me.Hide()

                txt_username.Enabled = True
                txt_password.Enabled = True
                img_show_hide_password.Enabled = True
                check_remember_me.Enabled = True
                btn_rfid_login.Enabled = True

                With btn_login
                    .Enabled = True
                    .Text = "Login"
                End With

                With img_loading
                    .Visible = False
                    .SendToBack()
                End With

                With Me
                    If Not .check_remember_me.Checked Then
                        .txt_username.Clear()
                        .txt_password.Clear()
                        .check_remember_me.Checked = False
                    End If

                    password_hidden = True
                    .txt_password.UseSystemPasswordChar = True
                    .img_show_hide_password.Image = Image.FromFile("dist/img/password_show.png")
                    .txt_username.Focus()
                End With
            Else
                txt_username.Enabled = True
                txt_password.Enabled = True
                img_show_hide_password.Enabled = True
                check_remember_me.Enabled = True
                btn_rfid_login.Enabled = True

                With btn_login
                    .Enabled = True
                    .Text = "Login"
                End With

                With img_loading
                    .Visible = False
                    .SendToBack()
                End With

                MessageBox.Show("Invalid Username or Password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub txt_username_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_username.KeyDown
        If e.KeyCode = Keys.Enter Then
            With txt_password
                .Clear()
                .Focus()
            End With
        End If
    End Sub

    Private Sub txt_password_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_password.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_login.PerformClick()
        End If
    End Sub

    Private Sub btn_rfid_login_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btn_rfid_login.LinkClicked
        With RFID_Login
            .ShowDialog()
            .txt_rfid_number.Focus()
        End With
    End Sub
End Class
