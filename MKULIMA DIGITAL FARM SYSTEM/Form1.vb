Public Class Login

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        'Dim mainmenu As New MAIN_MENU
        MAINMENU2.Show()
        Me.Hide()

    End Sub

    Private Sub lblSignup_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblSignup.LinkClicked

        SIGN_UP.Show()

    End Sub
End Class
