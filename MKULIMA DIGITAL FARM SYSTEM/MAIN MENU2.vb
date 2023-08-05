Public Class MAINMENU





    Private Sub ShowFormInPanel(ByVal newForm As Form)
        ' Hide the current form (if any)
        Dim currentForm As Form = Nothing
        If Panel3.Controls.Count > 0 Then
            currentForm = TryCast(Panel3.Controls(0), Form)
            currentForm.Hide()
        End If

        ' Clear the panel and add the new form
        Panel3.Controls.Clear()
        newForm.TopLevel = False
        newForm.FormBorderStyle = FormBorderStyle.None
        newForm.Dock = DockStyle.Fill
        Panel3.Controls.Add(newForm)
        newForm.Show()
    End Sub

    Private Sub GunaCircleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnQuit.Click
        Me.Close()

    End Sub

    Private Sub btnLivestockreport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ShowFormInPanel(LIVESTOCK_REPORT)
        Panel1.BackColor = Color.Red
        Me.BackColor = Color.Coral
        'Me.BackgroundImage = Image.FromFile(imagePath)

    End Sub

    Private Sub LIVESTOCKBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.LIVESTOCKBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Mkulima_digitalDataSet)

    End Sub

    Private Sub MAINMENU2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Mkulima_digitalDataSet.LIVESTOCK' table. You can move, or remove it, as needed.
        Me.LIVESTOCKTableAdapter.Fill(Me.Mkulima_digitalDataSet.LIVESTOCK)

    End Sub

    Private Sub GunaCircleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLivestock.Click

        ShowFormInPanel(LIVESTOCK)
        Panel1.BackColor = Color.Yellow
        Me.BackColor = Color.Green
        'Me.BackgroundImage = Image.FromFile(imagePath)

    End Sub

    Private Sub GunaCircleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCrop.Click

        ShowFormInPanel(CROP)
        Panel1.BackColor = Color.Green
        Me.BackColor = Color.GreenYellow
        'Me.BackgroundImage = Image.FromFile(imagePath)

    End Sub

    Private Sub lblResourceOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblResourceOrder.Click
        ShowFormInPanel(ORDER)
        Panel1.BackColor = Color.DimGray
        Me.BackColor = Color.CadetBlue
        'Me.BackgroundImage = Image.FromFile(imagePath)
    End Sub

    Private Sub GunaCircleButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLivestockReport.Click
        ShowFormInPanel(LIVESTOCK_REPORT)
        Panel1.BackColor = Color.Blue
        Me.BackColor = Color.CornflowerBlue
        'Me.BackgroundImage = Image.FromFile(imagePath)
    End Sub

    Private Sub btnCropReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCropReport.Click
        ShowFormInPanel(CROP_REPORT)
        Panel1.BackColor = Color.Tan
        Me.BackColor = Color.CornflowerBlue
        'Me.BackgroundImage = Image.FromFile(imagePath)
    End Sub

    Private Sub btnOrderReceipt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrderReceipt.Click
        ShowFormInPanel(ORDER_RECEIPT)
        Panel1.BackColor = Color.Aqua
        Me.BackColor = Color.CornflowerBlue
        'Me.BackgroundImage = Image.FromFile(imagePath)
    End Sub

    Private Sub GunaCircleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWeather.Click
        ShowFormInPanel(WEATHER)
        Panel1.BackColor = Color.Thistle
        Me.BackColor = Color.CornflowerBlue
        'Me.BackgroundImage = Image.FromFile(imagePath)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label1.Text = DateTime.Now.ToString()
    End Sub

    Private Sub GunaCircleButton1_Click_2(sender As Object, e As EventArgs) Handles GunaCircleButton1.Click
        ShowFormInPanel(USER_MANAGEMENT)
        Panel1.BackColor = Color.LawnGreen
        Me.BackColor = Color.AliceBlue
    End Sub
End Class