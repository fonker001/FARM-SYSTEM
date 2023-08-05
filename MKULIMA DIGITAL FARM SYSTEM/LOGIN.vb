Public Class Login
    Private connectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\FONKER\OneDrive\Documents\MKULIMA DIGITAL FARM SYSTEM\MKULIMA DIGITAL FARM SYSTEM\MKULIMA DIGITAL\MKULIMA DIGITAL FARM SYSTEM\MKULIMA DIGITAL FARM SYSTEM\mkulima_digital.mdb"


    Private Sub lblSignup_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblSignup.LinkClicked
        SIGN_UP.Show()
        USERBindingSource.AddNew()

    End Sub

    Private Sub USERBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.USERBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Mkulima_digitalDataSet)

    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Mkulima_digitalDataSet.USER' table. You can move, or remove it, as needed.
        Me.USERTableAdapter.Fill(Me.Mkulima_digitalDataSet.USER)

        UsernameTextBox.Clear()
        PasswordTextBox.Clear()


    End Sub

    Private Sub GunaCircleButton1_Click(sender As Object, e As EventArgs) Handles GunaCircleButton1.Click
        MAINMENU.Show()
        Me.Close()
    End Sub

    Private Sub GunaCircleButton2_Click(sender As Object, e As EventArgs) Handles GunaCircleButton2.Click
        Me.Close()
    End Sub
End Class
