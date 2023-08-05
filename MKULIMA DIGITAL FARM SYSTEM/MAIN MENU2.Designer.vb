<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MAINMENU
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MAINMENU))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GunaCircleButton1 = New Guna.UI.WinForms.GunaCircleButton()
        Me.btnOrderReceipt = New Guna.UI.WinForms.GunaCircleButton()
        Me.btnLivestockReport = New Guna.UI.WinForms.GunaCircleButton()
        Me.btnCrop = New Guna.UI.WinForms.GunaCircleButton()
        Me.btnCropReport = New Guna.UI.WinForms.GunaCircleButton()
        Me.btnWeather = New Guna.UI.WinForms.GunaCircleButton()
        Me.lblResourceOrder = New Guna.UI.WinForms.GunaCircleButton()
        Me.btnLivestock = New Guna.UI.WinForms.GunaCircleButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblLogo = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnQuit = New Guna.UI.WinForms.GunaCircleButton()
        Me.Mkulima_digitalDataSet = New MKULIMA_DIGITAL_FARM_SYSTEM.mkulima_digitalDataSet()
        Me.LIVESTOCKBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LIVESTOCKTableAdapter = New MKULIMA_DIGITAL_FARM_SYSTEM.mkulima_digitalDataSetTableAdapters.LIVESTOCKTableAdapter()
        Me.TableAdapterManager = New MKULIMA_DIGITAL_FARM_SYSTEM.mkulima_digitalDataSetTableAdapters.TableAdapterManager()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Mkulima_digitalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LIVESTOCKBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.GunaCircleButton1)
        Me.Panel1.Controls.Add(Me.btnOrderReceipt)
        Me.Panel1.Controls.Add(Me.btnLivestockReport)
        Me.Panel1.Controls.Add(Me.btnCrop)
        Me.Panel1.Controls.Add(Me.btnCropReport)
        Me.Panel1.Controls.Add(Me.btnWeather)
        Me.Panel1.Controls.Add(Me.lblResourceOrder)
        Me.Panel1.Controls.Add(Me.btnLivestock)
        Me.Panel1.Location = New System.Drawing.Point(12, 114)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(267, 592)
        Me.Panel1.TabIndex = 0
        '
        'GunaCircleButton1
        '
        Me.GunaCircleButton1.AnimationHoverSpeed = 0.07!
        Me.GunaCircleButton1.AnimationSpeed = 0.03!
        Me.GunaCircleButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaCircleButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaCircleButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaCircleButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaCircleButton1.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaCircleButton1.ForeColor = System.Drawing.Color.White
        Me.GunaCircleButton1.Image = Nothing
        Me.GunaCircleButton1.ImageSize = New System.Drawing.Size(52, 52)
        Me.GunaCircleButton1.Location = New System.Drawing.Point(27, 292)
        Me.GunaCircleButton1.Name = "GunaCircleButton1"
        Me.GunaCircleButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaCircleButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaCircleButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaCircleButton1.OnHoverImage = Nothing
        Me.GunaCircleButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaCircleButton1.Size = New System.Drawing.Size(206, 66)
        Me.GunaCircleButton1.TabIndex = 32
        Me.GunaCircleButton1.Text = "USER MANAGEMENT"
        '
        'btnOrderReceipt
        '
        Me.btnOrderReceipt.AnimationHoverSpeed = 0.07!
        Me.btnOrderReceipt.AnimationSpeed = 0.03!
        Me.btnOrderReceipt.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnOrderReceipt.BorderColor = System.Drawing.Color.Black
        Me.btnOrderReceipt.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnOrderReceipt.FocusedColor = System.Drawing.Color.Empty
        Me.btnOrderReceipt.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrderReceipt.ForeColor = System.Drawing.Color.White
        Me.btnOrderReceipt.Image = Nothing
        Me.btnOrderReceipt.ImageSize = New System.Drawing.Size(52, 52)
        Me.btnOrderReceipt.Location = New System.Drawing.Point(27, 508)
        Me.btnOrderReceipt.Name = "btnOrderReceipt"
        Me.btnOrderReceipt.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnOrderReceipt.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnOrderReceipt.OnHoverForeColor = System.Drawing.Color.White
        Me.btnOrderReceipt.OnHoverImage = Nothing
        Me.btnOrderReceipt.OnPressedColor = System.Drawing.Color.Black
        Me.btnOrderReceipt.Size = New System.Drawing.Size(206, 66)
        Me.btnOrderReceipt.TabIndex = 31
        Me.btnOrderReceipt.Text = "ORDER RECEIPT"
        '
        'btnLivestockReport
        '
        Me.btnLivestockReport.AnimationHoverSpeed = 0.07!
        Me.btnLivestockReport.AnimationSpeed = 0.03!
        Me.btnLivestockReport.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnLivestockReport.BorderColor = System.Drawing.Color.Black
        Me.btnLivestockReport.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnLivestockReport.FocusedColor = System.Drawing.Color.Empty
        Me.btnLivestockReport.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLivestockReport.ForeColor = System.Drawing.Color.White
        Me.btnLivestockReport.Image = Nothing
        Me.btnLivestockReport.ImageSize = New System.Drawing.Size(52, 52)
        Me.btnLivestockReport.Location = New System.Drawing.Point(27, 436)
        Me.btnLivestockReport.Name = "btnLivestockReport"
        Me.btnLivestockReport.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnLivestockReport.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnLivestockReport.OnHoverForeColor = System.Drawing.Color.White
        Me.btnLivestockReport.OnHoverImage = Nothing
        Me.btnLivestockReport.OnPressedColor = System.Drawing.Color.Black
        Me.btnLivestockReport.Size = New System.Drawing.Size(206, 66)
        Me.btnLivestockReport.TabIndex = 30
        Me.btnLivestockReport.Text = "LIVESTOCK REPORT"
        '
        'btnCrop
        '
        Me.btnCrop.AnimationHoverSpeed = 0.07!
        Me.btnCrop.AnimationSpeed = 0.03!
        Me.btnCrop.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCrop.BorderColor = System.Drawing.Color.Black
        Me.btnCrop.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnCrop.FocusedColor = System.Drawing.Color.Empty
        Me.btnCrop.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrop.ForeColor = System.Drawing.Color.White
        Me.btnCrop.Image = Nothing
        Me.btnCrop.ImageSize = New System.Drawing.Size(52, 52)
        Me.btnCrop.Location = New System.Drawing.Point(27, 78)
        Me.btnCrop.Name = "btnCrop"
        Me.btnCrop.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCrop.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnCrop.OnHoverForeColor = System.Drawing.Color.White
        Me.btnCrop.OnHoverImage = Nothing
        Me.btnCrop.OnPressedColor = System.Drawing.Color.Black
        Me.btnCrop.Size = New System.Drawing.Size(206, 66)
        Me.btnCrop.TabIndex = 26
        Me.btnCrop.Text = "CROP"
        '
        'btnCropReport
        '
        Me.btnCropReport.AnimationHoverSpeed = 0.07!
        Me.btnCropReport.AnimationSpeed = 0.03!
        Me.btnCropReport.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCropReport.BorderColor = System.Drawing.Color.Black
        Me.btnCropReport.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnCropReport.FocusedColor = System.Drawing.Color.Empty
        Me.btnCropReport.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCropReport.ForeColor = System.Drawing.Color.White
        Me.btnCropReport.Image = Nothing
        Me.btnCropReport.ImageSize = New System.Drawing.Size(52, 52)
        Me.btnCropReport.Location = New System.Drawing.Point(27, 364)
        Me.btnCropReport.Name = "btnCropReport"
        Me.btnCropReport.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCropReport.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnCropReport.OnHoverForeColor = System.Drawing.Color.White
        Me.btnCropReport.OnHoverImage = Nothing
        Me.btnCropReport.OnPressedColor = System.Drawing.Color.Black
        Me.btnCropReport.Size = New System.Drawing.Size(206, 66)
        Me.btnCropReport.TabIndex = 29
        Me.btnCropReport.Text = "CROP REPORT"
        '
        'btnWeather
        '
        Me.btnWeather.AnimationHoverSpeed = 0.07!
        Me.btnWeather.AnimationSpeed = 0.03!
        Me.btnWeather.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnWeather.BorderColor = System.Drawing.Color.Black
        Me.btnWeather.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnWeather.FocusedColor = System.Drawing.Color.Empty
        Me.btnWeather.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWeather.ForeColor = System.Drawing.Color.White
        Me.btnWeather.Image = Nothing
        Me.btnWeather.ImageSize = New System.Drawing.Size(52, 52)
        Me.btnWeather.Location = New System.Drawing.Point(27, 222)
        Me.btnWeather.Name = "btnWeather"
        Me.btnWeather.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnWeather.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnWeather.OnHoverForeColor = System.Drawing.Color.White
        Me.btnWeather.OnHoverImage = Nothing
        Me.btnWeather.OnPressedColor = System.Drawing.Color.Black
        Me.btnWeather.Size = New System.Drawing.Size(206, 66)
        Me.btnWeather.TabIndex = 28
        Me.btnWeather.Text = "WEATHER"
        '
        'lblResourceOrder
        '
        Me.lblResourceOrder.AnimationHoverSpeed = 0.07!
        Me.lblResourceOrder.AnimationSpeed = 0.03!
        Me.lblResourceOrder.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblResourceOrder.BorderColor = System.Drawing.Color.Black
        Me.lblResourceOrder.DialogResult = System.Windows.Forms.DialogResult.None
        Me.lblResourceOrder.FocusedColor = System.Drawing.Color.Empty
        Me.lblResourceOrder.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResourceOrder.ForeColor = System.Drawing.Color.White
        Me.lblResourceOrder.Image = Nothing
        Me.lblResourceOrder.ImageSize = New System.Drawing.Size(52, 52)
        Me.lblResourceOrder.Location = New System.Drawing.Point(27, 150)
        Me.lblResourceOrder.Name = "lblResourceOrder"
        Me.lblResourceOrder.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblResourceOrder.OnHoverBorderColor = System.Drawing.Color.Black
        Me.lblResourceOrder.OnHoverForeColor = System.Drawing.Color.White
        Me.lblResourceOrder.OnHoverImage = Nothing
        Me.lblResourceOrder.OnPressedColor = System.Drawing.Color.Black
        Me.lblResourceOrder.Size = New System.Drawing.Size(206, 66)
        Me.lblResourceOrder.TabIndex = 27
        Me.lblResourceOrder.Text = "RESOURCE ORDER"
        '
        'btnLivestock
        '
        Me.btnLivestock.AnimationHoverSpeed = 0.07!
        Me.btnLivestock.AnimationSpeed = 0.03!
        Me.btnLivestock.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnLivestock.BorderColor = System.Drawing.Color.Black
        Me.btnLivestock.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnLivestock.FocusedColor = System.Drawing.Color.Empty
        Me.btnLivestock.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLivestock.ForeColor = System.Drawing.Color.White
        Me.btnLivestock.Image = Nothing
        Me.btnLivestock.ImageSize = New System.Drawing.Size(52, 52)
        Me.btnLivestock.Location = New System.Drawing.Point(27, 6)
        Me.btnLivestock.Name = "btnLivestock"
        Me.btnLivestock.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnLivestock.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnLivestock.OnHoverForeColor = System.Drawing.Color.White
        Me.btnLivestock.OnHoverImage = Nothing
        Me.btnLivestock.OnPressedColor = System.Drawing.Color.Black
        Me.btnLivestock.Size = New System.Drawing.Size(206, 66)
        Me.btnLivestock.TabIndex = 25
        Me.btnLivestock.Text = "LIVESTOCK"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.lblLogo)
        Me.Panel2.Location = New System.Drawing.Point(324, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(801, 80)
        Me.Panel2.TabIndex = 0
        '
        'lblLogo
        '
        Me.lblLogo.AutoSize = True
        Me.lblLogo.Font = New System.Drawing.Font("Algerian", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogo.Location = New System.Drawing.Point(17, 13)
        Me.lblLogo.Name = "lblLogo"
        Me.lblLogo.Size = New System.Drawing.Size(781, 54)
        Me.lblLogo.TabIndex = 0
        Me.lblLogo.Text = "MKULIMA DIGITAL FARM SYSTEM"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Location = New System.Drawing.Point(305, 120)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1005, 565)
        Me.Panel3.TabIndex = 1
        '
        'btnQuit
        '
        Me.btnQuit.AnimationHoverSpeed = 0.07!
        Me.btnQuit.AnimationSpeed = 0.03!
        Me.btnQuit.BackColor = System.Drawing.Color.Transparent
        Me.btnQuit.BaseColor = System.Drawing.Color.Red
        Me.btnQuit.BorderColor = System.Drawing.Color.Black
        Me.btnQuit.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnQuit.FocusedColor = System.Drawing.Color.Empty
        Me.btnQuit.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.ForeColor = System.Drawing.Color.White
        Me.btnQuit.Image = Nothing
        Me.btnQuit.ImageSize = New System.Drawing.Size(52, 52)
        Me.btnQuit.Location = New System.Drawing.Point(1125, 691)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnQuit.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnQuit.OnHoverForeColor = System.Drawing.Color.White
        Me.btnQuit.OnHoverImage = Nothing
        Me.btnQuit.OnPressedColor = System.Drawing.Color.Black
        Me.btnQuit.Size = New System.Drawing.Size(185, 67)
        Me.btnQuit.TabIndex = 7
        Me.btnQuit.Text = "QUIT"
        '
        'Mkulima_digitalDataSet
        '
        Me.Mkulima_digitalDataSet.DataSetName = "mkulima_digitalDataSet"
        Me.Mkulima_digitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LIVESTOCKBindingSource
        '
        Me.LIVESTOCKBindingSource.DataMember = "LIVESTOCK"
        Me.LIVESTOCKBindingSource.DataSource = Me.Mkulima_digitalDataSet
        '
        'LIVESTOCKTableAdapter
        '
        Me.LIVESTOCKTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CROPTableAdapter = Nothing
        Me.TableAdapterManager.LIVESTOCKTableAdapter = Me.LIVESTOCKTableAdapter
        Me.TableAdapterManager.ORDER_ITEMTableAdapter = Nothing
        Me.TableAdapterManager.ORDERTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = MKULIMA_DIGITAL_FARM_SYSTEM.mkulima_digitalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.USERTableAdapter = Nothing
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Black", 17.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(289, 715)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 31)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Label1"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'MAINMENU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1386, 788)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MAINMENU"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MAINMENU"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Mkulima_digitalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LIVESTOCKBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblLogo As System.Windows.Forms.Label
    Friend WithEvents btnQuit As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents Mkulima_digitalDataSet As MKULIMA_DIGITAL_FARM_SYSTEM.mkulima_digitalDataSet
    Friend WithEvents LIVESTOCKBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LIVESTOCKTableAdapter As MKULIMA_DIGITAL_FARM_SYSTEM.mkulima_digitalDataSetTableAdapters.LIVESTOCKTableAdapter
    Friend WithEvents TableAdapterManager As MKULIMA_DIGITAL_FARM_SYSTEM.mkulima_digitalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents btnLivestock As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents btnLivestockReport As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents btnCrop As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents btnOrderReceipt As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents lblResourceOrder As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents btnWeather As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents btnCropReport As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents GunaCircleButton1 As Guna.UI.WinForms.GunaCircleButton
End Class
