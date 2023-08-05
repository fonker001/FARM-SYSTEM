Public Class CROP_REPORT

    Private Sub CROPBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.CROPBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Mkulima_digitalDataSet)

    End Sub

    Private Sub CROP_REPORT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Mkulima_digitalDataSet.CROP' table. You can move, or remove it, as needed.
        Me.CROPTableAdapter.Fill(Me.Mkulima_digitalDataSet.CROP)

    End Sub

    Private Sub btnCloseForm_Click(sender As Object, e As EventArgs) Handles btnCloseForm.Click
        Me.Close()

    End Sub
End Class