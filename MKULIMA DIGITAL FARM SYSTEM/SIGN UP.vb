Public Class SIGN_UP

    
    Private Sub USERBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.USERBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Mkulima_digitalDataSet)

    End Sub

    Private Sub SIGN_UP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Mkulima_digitalDataSet.USER' table. You can move, or remove it, as needed.
        Me.USERTableAdapter.Fill(Me.Mkulima_digitalDataSet.USER)

        UsernameTextBox.Clear()
        EmailTextBox.Clear()
        PasswordTextBox.Clear()
        TextBox1.Clear()


    End Sub

    Private Sub GunaCircleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaCircleButton1.Click

        Try
            USERBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(Mkulima_digitalDataSet)
            MsgBox("ACCOUNT CREATED SUCCESSFULLY")

            MAINMENU.Show()
            Login.Close()
            Me.Close()

        Catch ex As Exception
            MsgBox("Error! Please recheck fields and try again")
        End Try



    End Sub

    Private Sub GunaCircleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaCircleButton2.Click
        Login.Show()
        Me.Close()

    End Sub

End Class