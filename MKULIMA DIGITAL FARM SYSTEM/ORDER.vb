Public Class ORDER

    Private Sub btnCloseForm_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()

    End Sub

    Private Sub ORDERBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ORDERBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Mkulima_digitalDataSet)

    End Sub

    Private Sub ORDER_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Mkulima_digitalDataSet.USER' table. You can move, or remove it, as needed.
        Me.USERTableAdapter.Fill(Me.Mkulima_digitalDataSet.USER)
        'TODO: This line of code loads data into the 'Mkulima_digitalDataSet.ORDER' table. You can move, or remove it, as needed.
        Me.ORDERTableAdapter.Fill(Me.Mkulima_digitalDataSet.ORDER)

    End Sub

    Private Sub btnCloseForm_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCloseForm.Click
        Me.Close()

    End Sub

    Private Sub btnAddrecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddrecord.Click
        ORDERBindingSource.AddNew()
    End Sub

    Private Sub btnDeleterecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleterecord.Click
        ORDERBindingSource.RemoveCurrent()
        TableAdapterManager.UpdateAll(Mkulima_digitalDataSet)
        MsgBox("DELETED")
    End Sub

    Private Sub btnSaverecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaverecord.Click
        Try
            ORDERBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(Mkulima_digitalDataSet)
            MsgBox("RECORD SAVED")
        Catch ex As Exception
            MsgBox("Error! PLEASE RECHECK FIELD AND TRY AGAIN")
        End Try
        
    End Sub

    Private Sub btnNextrecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNextrecord.Click
        ORDERBindingSource.MoveNext()
    End Sub

    Private Sub btnPreviousrecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreviousrecord.Click
        ORDERBindingSource.MovePrevious()

    End Sub
End Class