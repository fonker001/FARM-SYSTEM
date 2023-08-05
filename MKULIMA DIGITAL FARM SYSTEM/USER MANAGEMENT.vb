Public Class USER_MANAGEMENT
    Private Sub USERBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.USERBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Mkulima_digitalDataSet)

    End Sub

    Private Sub USER_MANAGEMENT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Mkulima_digitalDataSet.USER' table. You can move, or remove it, as needed.
        Me.USERTableAdapter.Fill(Me.Mkulima_digitalDataSet.USER)

    End Sub

    Private Sub btnPreviousrecord_Click(sender As Object, e As EventArgs) Handles btnPreviousrecord.Click
        USERBindingSource.MovePrevious()

    End Sub

    Private Sub btnNextrecord_Click(sender As Object, e As EventArgs) Handles btnNextrecord.Click
        USERBindingSource.MoveNext()
    End Sub

    Private Sub btnAddrecord_Click(sender As Object, e As EventArgs) Handles btnAddrecord.Click
        USERBindingSource.AddNew()

    End Sub

    Private Sub btnCloseForm_Click(sender As Object, e As EventArgs) Handles btnCloseForm.Click
        Me.Close()

    End Sub

    Private Sub btnSaverecord_Click(sender As Object, e As EventArgs) Handles btnSaverecord.Click
        Try
            USERBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(Mkulima_digitalDataSet)
            MsgBox("SUCCESS")

        Catch ex As Exception
            MsgBox("Error! Please recheck fields and try again")

        End Try
    End Sub

    Private Sub btnDeleterecord_Click(sender As Object, e As EventArgs) Handles btnDeleterecord.Click
        USERBindingSource.RemoveCurrent()
        TableAdapterManager.UpdateAll(Mkulima_digitalDataSet)
        MsgBox("Current record deleted successfully")
    End Sub
End Class