Public Class ORDER_RECEIPT

    Private Sub ORDERBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ORDERBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Mkulima_digitalDataSet)

    End Sub

    Private Sub ORDER_RECEIPT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Mkulima_digitalDataSet.ORDER_ITEM' table. You can move, or remove it, as needed.
        Me.ORDER_ITEMTableAdapter.Fill(Me.Mkulima_digitalDataSet.ORDER_ITEM)
        'TODO: This line of code loads data into the 'Mkulima_digitalDataSet.ORDER_ITEM' table. You can move, or remove it, as needed.
        Me.ORDER_ITEMTableAdapter.Fill(Me.Mkulima_digitalDataSet.ORDER_ITEM)
        'TODO: This line of code loads data into the 'Mkulima_digitalDataSet.ORDER' table. You can move, or remove it, as needed.
        Me.ORDERTableAdapter.Fill(Me.Mkulima_digitalDataSet.ORDER)

    End Sub

    Private Sub btnCloseForm_Click(sender As Object, e As EventArgs) Handles btnCloseForm.Click
        Me.Close()

    End Sub
End Class