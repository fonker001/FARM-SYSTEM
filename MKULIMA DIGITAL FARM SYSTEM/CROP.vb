Public Class CROP

    Private Sub GunaCircleButton5_Click(sender As Object, e As EventArgs) Handles btnCloseForm.Click
        Me.Close()
    End Sub

    Private Sub CROPBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.CROPBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Mkulima_digitalDataSet)

    End Sub

    Private Sub CROP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Mkulima_digitalDataSet.CROP' table. You can move, or remove it, as needed.
        Me.CROPTableAdapter.Fill(Me.Mkulima_digitalDataSet.CROP)

    End Sub

    Private Sub btnPreviousrecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreviousrecord.Click
        CROPBindingSource.AddNew()

    End Sub

    Private Sub btnNextrecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNextrecord.Click
        CROPBindingSource.MoveNext()
    End Sub

    Private Sub btnAddrecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddrecord.Click
        CROPBindingSource.AddNew()
    End Sub

    Private Sub btnDeleterecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleterecord.Click
        CROPBindingSource.RemoveCurrent()
        TableAdapterManager.UpdateAll(Mkulima_digitalDataSet)
        MsgBox("CURRENT RECORD DELETED")

    End Sub

    Private Sub btnSaverecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaverecord.Click
        Try
            CROPBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(Mkulima_digitalDataSet)
            MsgBox("Success")
        Catch ex As Exception
            MsgBox("Error! Please recheck fields and try again")
        End Try
        
    End Sub
End Class