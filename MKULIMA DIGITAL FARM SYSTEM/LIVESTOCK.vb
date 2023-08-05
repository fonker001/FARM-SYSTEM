Public Class LIVESTOCK

    Private Sub btnCloseForm_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()

    End Sub

    Private Sub LIVESTOCKBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.LIVESTOCKBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Mkulima_digitalDataSet)

    End Sub

    Private Sub LIVESTOCK_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Mkulima_digitalDataSet.LIVESTOCK' table. You can move, or remove it, as needed.
        Me.LIVESTOCKTableAdapter.Fill(Me.Mkulima_digitalDataSet.LIVESTOCK)

    End Sub

    Private Sub btnAddrecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddrecord.Click
        LIVESTOCKBindingSource.AddNew()
    End Sub

    Private Sub btnDeleterecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleterecord.Click
        LIVESTOCKBindingSource.RemoveCurrent()
        TableAdapterManager.UpdateAll(Mkulima_digitalDataSet)
        MsgBox("Current record deleted successfully")

    End Sub

    Private Sub btnSaverecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaverecord.Click
        Try
            LIVESTOCKBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(Mkulima_digitalDataSet)
            MsgBox("SUCCESS")

        Catch ex As Exception
            MsgBox("Error! Please recheck fields and try again")

        End Try
    End Sub

    Private Sub btnNextrecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNextrecord.Click
        LIVESTOCKBindingSource.MoveNext()

    End Sub

    Private Sub btnPreviousrecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreviousrecord.Click
        LIVESTOCKBindingSource.MovePrevious()
    End Sub

    Private Sub btnCloseForm_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCloseForm.Click
        Me.Close()

    End Sub
End Class