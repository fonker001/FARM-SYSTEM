Public Class MAIN_MENU

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        Me.Close()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ' Update the label with the current date and time
        lblTime.Text = DateTime.Now.ToString()
    End Sub

    Private Sub MAIN_MENU_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Start the timer when the form loads
        Timer1.Start()
    End Sub
End Class