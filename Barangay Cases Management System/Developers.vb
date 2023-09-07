Public Class Developers
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start(url)
    End Sub

    Private Sub img_close_Click(sender As Object, e As EventArgs) Handles img_close.Click
        Me.Close()
    End Sub
End Class