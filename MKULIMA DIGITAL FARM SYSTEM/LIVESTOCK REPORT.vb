Public Class LIVESTOCK_REPORT

    Private Sub LIVESTOCK_REPORT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Mkulima_digitalDataSet1.LIVESTOCK' table. You can move, or remove it, as needed.
        Me.LIVESTOCKTableAdapter.Fill(Me.Mkulima_digitalDataSet1.LIVESTOCK)

    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim printDialog As New PrintDialog()
        If printDialog.ShowDialog() = DialogResult.OK Then
            ' The user clicked OK in the PrintDialog.
            ' You can perform the printing operation here using the PrintDocument class.
        End If


    End Sub

    Private Sub btnCloseForm_Click(sender As Object, e As EventArgs) Handles btnCloseForm.Click
        Me.Close()

    End Sub
End Class