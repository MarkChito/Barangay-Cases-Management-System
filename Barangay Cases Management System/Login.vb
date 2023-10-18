Imports System.IO
Imports System.Net

Public Class Login
    Public password_hidden As Boolean = True
    Private file_path As String = "session/login/Session.txt"
    Public is_loading As Boolean = False

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
        If Not is_loading Then
            If password_hidden Then
                txt_password.UseSystemPasswordChar = False
                img_show_hide_password.Image = Image.FromFile("dist/img/password_hide.png")

                password_hidden = False
            Else
                txt_password.UseSystemPasswordChar = True
                img_show_hide_password.Image = Image.FromFile("dist/img/password_show.png")

                password_hidden = True
            End If
        End If
    End Sub

    Private Sub txt_username_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_username.KeyDown
        If Not is_loading Then
            If e.KeyCode = Keys.Enter Then
                With txt_password
                    .Clear()
                    .Focus()
                End With
            End If
        End If
    End Sub

    Private Sub txt_password_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_password.KeyDown
        If Not is_loading Then
            If e.KeyCode = Keys.Enter Then
                btn_login.Text = "Checking Credentials..."
                check_remember_me.Enabled = False

                btn_temp.Focus()

                Timer1.Start()
            End If
        End If
    End Sub

    Private Sub btn_rfid_login_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btn_rfid_login.LinkClicked
        If Not is_loading Then
            With RFID_Login
                .ShowDialog()
                .txt_rfid_number.Focus()
            End With
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Not is_loading Then
            If String.IsNullOrWhiteSpace(txt_username.Text) Then
                btn_login.Text = "Login"
                check_remember_me.Enabled = True

                Timer1.Stop()

                MessageBox.Show("Please fill in the Username field.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)

                txt_username.Focus()
            ElseIf String.IsNullOrWhiteSpace(txt_password.Text) Then
                btn_login.Text = "Login"
                check_remember_me.Enabled = True

                Timer1.Stop()

                MessageBox.Show("Please fill in the Password field.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)

                txt_password.Focus()
            Else
                is_loading = True

                Dim results = Authenticate(txt_username.Text, txt_password.Text)

                Dim response_code = results("response_code")

                If response_code = 200 Then
                    With img_loading
                        .Visible = True
                        .BringToFront()
                    End With

                    primary_key = results("primary_key")

                    Load_All_Images()
                Else
                    is_loading = False

                    btn_login.Text = "Login"
                    check_remember_me.Enabled = True

                    Timer1.Stop()

                    MessageBox.Show("Invalid Username or Password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub

    Private Sub btn_login_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_login.MouseDown
        btn_login.Text = "Checking Credentials..."
        check_remember_me.Enabled = False

        btn_temp.Focus()

        Timer1.Start()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterPanel()
        'Open_File()
    End Sub

    Private Sub Login_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Splash_Screen.Close()
    End Sub
End Class
