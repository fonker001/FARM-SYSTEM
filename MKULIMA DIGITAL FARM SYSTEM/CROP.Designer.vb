<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CROP
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblPlantdate = New System.Windows.Forms.Label()
        Me.lblHarvestdate = New System.Windows.Forms.Label()
        Me.lblPestcontrol = New System.Windows.Forms.Label()
        Me.lblCropname = New System.Windows.Forms.Label()
        Me.lblFarmsize = New System.Windows.Forms.Label()
        Me.btnAddrecord = New Guna.UI.WinForms.GunaCircleButton()
        Me.btnSaverecord = New Guna.UI.WinForms.GunaCircleButton()
        Me.btnDeleterecord = New Guna.UI.WinForms.GunaCircleButton()
        Me.btnNextrecord = New Guna.UI.WinForms.GunaCircleButton()
        Me.btnCloseForm = New Guna.UI.WinForms.GunaCircleButton()
        Me.btnPreviousrecord = New Guna.UI.WinForms.GunaCircleButton()
        Me.Mkulima_digitalDataSet = New MKULIMA_DIGITAL_FARM_SYSTEM.mkulima_digitalDataSet()
        Me.CROPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CROPTableAdapter = New MKULIMA_DIGITAL_FARM_SYSTEM.mkulima_digitalDataSetTableAdapters.CROPTableAdapter()
        Me.TableAdapterManager = New MKULIMA_DIGITAL_FARM_SYSTEM.mkulima_digitalDataSetTableAdapters.TableAdapterManager()
        Me.FarmsizeTextBox = New System.Windows.Forms.TextBox()
        Me.CropNameTextBox = New System.Windows.Forms.TextBox()
        Me.PlantingDateTextBox = New System.Windows.Forms.TextBox()
        Me.HarvestDateTextBox = New System.Windows.Forms.TextBox()
        Me.PestcontrolTextBox = New System.Windows.Forms.TextBox()
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        CType(Me.Mkulima_digitalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CROPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPlantdate
        '
        Me.lblPlantdate.AutoSize = True
        Me.lblPlantdate.BackColor = System.Drawing.Color.Transparent
        Me.lblPlantdate.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblPlantdate.ForeColor = System.Drawing.Color.Red
        Me.lblPlantdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblPlantdate.Location = New System.Drawing.Point(37, 185)
        Me.lblPlantdate.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblPlantdate.Name = "lblPlantdate"
        Me.lblPlantdate.Size = New System.Drawing.Size(235, 37)
        Me.lblPlantdate.TabIndex = 2
        Me.lblPlantdate.Text = "PLANTING DATE:"
        Me.lblPlantdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblHarvestdate
        '
        Me.lblHarvestdate.AutoSize = True
        Me.lblHarvestdate.BackColor = System.Drawing.Color.Transparent
        Me.lblHarvestdate.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblHarvestdate.ForeColor = System.Drawing.Color.Red
        Me.lblHarvestdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblHarvestdate.Location = New System.Drawing.Point(37, 260)
        Me.lblHarvestdate.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblHarvestdate.Name = "lblHarvestdate"
        Me.lblHarvestdate.Size = New System.Drawing.Size(219, 37)
        Me.lblHarvestdate.TabIndex = 3
        Me.lblHarvestdate.Text = "HARVEST DATE:"
        Me.lblHarvestdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPestcontrol
        '
        Me.lblPestcontrol.AutoSize = True
        Me.lblPestcontrol.BackColor = System.Drawing.Color.Transparent
        Me.lblPestcontrol.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblPestcontrol.ForeColor = System.Drawing.Color.Red
        Me.lblPestcontrol.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblPestcontrol.Location = New System.Drawing.Point(37, 331)
        Me.lblPestcontrol.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblPestcontrol.Name = "lblPestcontrol"
        Me.lblPestcontrol.Size = New System.Drawing.Size(293, 37)
        Me.lblPestcontrol.TabIndex = 4
        Me.lblPestcontrol.Text = "PEST CONTROL DATE:"
        Me.lblPestcontrol.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCropname
        '
        Me.lblCropname.AutoSize = True
        Me.lblCropname.BackColor = System.Drawing.Color.Transparent
        Me.lblCropname.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblCropname.ForeColor = System.Drawing.Color.Red
        Me.lblCropname.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblCropname.Location = New System.Drawing.Point(37, 111)
        Me.lblCropname.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblCropname.Name = "lblCropname"
        Me.lblCropname.Size = New System.Drawing.Size(183, 37)
        Me.lblCropname.TabIndex = 0
        Me.lblCropname.Text = "CROP NAME:"
        Me.lblCropname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFarmsize
        '
        Me.lblFarmsize.AutoSize = True
        Me.lblFarmsize.BackColor = System.Drawing.Color.Transparent
        Me.lblFarmsize.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblFarmsize.ForeColor = System.Drawing.Color.Red
        Me.lblFarmsize.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblFarmsize.Location = New System.Drawing.Point(37, 43)
        Me.lblFarmsize.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblFarmsize.Name = "lblFarmsize"
        Me.lblFarmsize.Size = New System.Drawing.Size(161, 37)
        Me.lblFarmsize.TabIndex = 5
        Me.lblFarmsize.Text = "FARM SIZE:"
        Me.lblFarmsize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnAddrecord
        '
        Me.btnAddrecord.AnimationHoverSpeed = 0.07!
        Me.btnAddrecord.AnimationSpeed = 0.03!
        Me.btnAddrecord.BackColor = System.Drawing.Color.Transparent
        Me.btnAddrecord.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAddrecord.BorderColor = System.Drawing.Color.Black
        Me.btnAddrecord.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAddrecord.FocusedColor = System.Drawing.Color.Empty
        Me.btnAddrecord.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnAddrecord.ForeColor = System.Drawing.Color.White
        Me.btnAddrecord.Image = Nothing
        Me.btnAddrecord.ImageSize = New System.Drawing.Size(52, 52)
        Me.btnAddrecord.Location = New System.Drawing.Point(762, 43)
        Me.btnAddrecord.Name = "btnAddrecord"
        Me.btnAddrecord.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAddrecord.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnAddrecord.OnHoverForeColor = System.Drawing.Color.White
        Me.btnAddrecord.OnHoverImage = Nothing
        Me.btnAddrecord.OnPressedColor = System.Drawing.Color.Black
        Me.btnAddrecord.Size = New System.Drawing.Size(180, 67)
        Me.btnAddrecord.TabIndex = 6
        Me.btnAddrecord.Text = "ADD RECORD"
        '
        'btnSaverecord
        '
        Me.btnSaverecord.AnimationHoverSpeed = 0.07!
        Me.btnSaverecord.AnimationSpeed = 0.03!
        Me.btnSaverecord.BackColor = System.Drawing.Color.Transparent
        Me.btnSaverecord.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSaverecord.BorderColor = System.Drawing.Color.Black
        Me.btnSaverecord.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnSaverecord.FocusedColor = System.Drawing.Color.Empty
        Me.btnSaverecord.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnSaverecord.ForeColor = System.Drawing.Color.White
        Me.btnSaverecord.Image = Nothing
        Me.btnSaverecord.ImageSize = New System.Drawing.Size(52, 52)
        Me.btnSaverecord.Location = New System.Drawing.Point(762, 218)
        Me.btnSaverecord.Name = "btnSaverecord"
        Me.btnSaverecord.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSaverecord.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnSaverecord.OnHoverForeColor = System.Drawing.Color.White
        Me.btnSaverecord.OnHoverImage = Nothing
        Me.btnSaverecord.OnPressedColor = System.Drawing.Color.Black
        Me.btnSaverecord.Size = New System.Drawing.Size(180, 67)
        Me.btnSaverecord.TabIndex = 7
        Me.btnSaverecord.Text = "SAVE RECORD"
        '
        'btnDeleterecord
        '
        Me.btnDeleterecord.AnimationHoverSpeed = 0.07!
        Me.btnDeleterecord.AnimationSpeed = 0.03!
        Me.btnDeleterecord.BackColor = System.Drawing.Color.Transparent
        Me.btnDeleterecord.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDeleterecord.BorderColor = System.Drawing.Color.Black
        Me.btnDeleterecord.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnDeleterecord.FocusedColor = System.Drawing.Color.Empty
        Me.btnDeleterecord.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnDeleterecord.ForeColor = System.Drawing.Color.White
        Me.btnDeleterecord.Image = Nothing
        Me.btnDeleterecord.ImageSize = New System.Drawing.Size(52, 52)
        Me.btnDeleterecord.Location = New System.Drawing.Point(762, 127)
        Me.btnDeleterecord.Name = "btnDeleterecord"
        Me.btnDeleterecord.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDeleterecord.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnDeleterecord.OnHoverForeColor = System.Drawing.Color.White
        Me.btnDeleterecord.OnHoverImage = Nothing
        Me.btnDeleterecord.OnPressedColor = System.Drawing.Color.Black
        Me.btnDeleterecord.Size = New System.Drawing.Size(180, 67)
        Me.btnDeleterecord.TabIndex = 8
        Me.btnDeleterecord.Text = "DELETE RECORD"
        '
        'btnNextrecord
        '
        Me.btnNextrecord.AnimationHoverSpeed = 0.07!
        Me.btnNextrecord.AnimationSpeed = 0.03!
        Me.btnNextrecord.BackColor = System.Drawing.Color.Transparent
        Me.btnNextrecord.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnNextrecord.BorderColor = System.Drawing.Color.Black
        Me.btnNextrecord.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnNextrecord.FocusedColor = System.Drawing.Color.Empty
        Me.btnNextrecord.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnNextrecord.ForeColor = System.Drawing.Color.White
        Me.btnNextrecord.Image = Nothing
        Me.btnNextrecord.ImageSize = New System.Drawing.Size(52, 52)
        Me.btnNextrecord.Location = New System.Drawing.Point(762, 311)
        Me.btnNextrecord.Name = "btnNextrecord"
        Me.btnNextrecord.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnNextrecord.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnNextrecord.OnHoverForeColor = System.Drawing.Color.White
        Me.btnNextrecord.OnHoverImage = Nothing
        Me.btnNextrecord.OnPressedColor = System.Drawing.Color.Black
        Me.btnNextrecord.Size = New System.Drawing.Size(180, 67)
        Me.btnNextrecord.TabIndex = 9
        Me.btnNextrecord.Text = "NEXT RECORD"
        '
        'btnCloseForm
        '
        Me.btnCloseForm.AnimationHoverSpeed = 5.07!
        Me.btnCloseForm.AnimationSpeed = 5.03!
        Me.btnCloseForm.BackColor = System.Drawing.Color.Transparent
        Me.btnCloseForm.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCloseForm.BorderColor = System.Drawing.Color.Black
        Me.btnCloseForm.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnCloseForm.FocusedColor = System.Drawing.Color.Empty
        Me.btnCloseForm.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCloseForm.ForeColor = System.Drawing.Color.White
        Me.btnCloseForm.Image = Nothing
        Me.btnCloseForm.ImageSize = New System.Drawing.Size(52, 52)
        Me.btnCloseForm.Location = New System.Drawing.Point(357, 452)
        Me.btnCloseForm.Name = "btnCloseForm"
        Me.btnCloseForm.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCloseForm.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnCloseForm.OnHoverForeColor = System.Drawing.Color.White
        Me.btnCloseForm.OnHoverImage = Nothing
        Me.btnCloseForm.OnPressedColor = System.Drawing.Color.Black
        Me.btnCloseForm.Size = New System.Drawing.Size(180, 67)
        Me.btnCloseForm.TabIndex = 10
        Me.btnCloseForm.Text = "CLOSE"
        '
        'btnPreviousrecord
        '
        Me.btnPreviousrecord.AnimationHoverSpeed = 0.07!
        Me.btnPreviousrecord.AnimationSpeed = 0.03!
        Me.btnPreviousrecord.BackColor = System.Drawing.Color.Transparent
        Me.btnPreviousrecord.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPreviousrecord.BorderColor = System.Drawing.Color.Black
        Me.btnPreviousrecord.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnPreviousrecord.FocusedColor = System.Drawing.Color.Empty
        Me.btnPreviousrecord.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnPreviousrecord.ForeColor = System.Drawing.Color.White
        Me.btnPreviousrecord.Image = Nothing
        Me.btnPreviousrecord.ImageSize = New System.Drawing.Size(52, 52)
        Me.btnPreviousrecord.Location = New System.Drawing.Point(762, 407)
        Me.btnPreviousrecord.Name = "btnPreviousrecord"
        Me.btnPreviousrecord.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPreviousrecord.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnPreviousrecord.OnHoverForeColor = System.Drawing.Color.White
        Me.btnPreviousrecord.OnHoverImage = Nothing
        Me.btnPreviousrecord.OnPressedColor = System.Drawing.Color.Black
        Me.btnPreviousrecord.Size = New System.Drawing.Size(180, 67)
        Me.btnPreviousrecord.TabIndex = 11
        Me.btnPreviousrecord.Text = "PREVIOUS RECORD"
        '
        'Mkulima_digitalDataSet
        '
        Me.Mkulima_digitalDataSet.DataSetName = "mkulima_digitalDataSet"
        Me.Mkulima_digitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CROPBindingSource
        '
        Me.CROPBindingSource.DataMember = "CROP"
        Me.CROPBindingSource.DataSource = Me.Mkulima_digitalDataSet
        '
        'CROPTableAdapter
        '
        Me.CROPTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CROPTableAdapter = Me.CROPTableAdapter
        Me.TableAdapterManager.LIVESTOCKTableAdapter = Nothing
        Me.TableAdapterManager.ORDER_ITEMTableAdapter = Nothing
        Me.TableAdapterManager.ORDERTableAdapter = Nothing
        'Me.TableAdapterManager.RESOURCETableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = MKULIMA_DIGITAL_FARM_SYSTEM.mkulima_digitalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.USERTableAdapter = Nothing
        '
        'FarmsizeTextBox
        '
        Me.FarmsizeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CROPBindingSource, "Farmsize", True))
        Me.FarmsizeTextBox.Location = New System.Drawing.Point(207, 43)
        Me.FarmsizeTextBox.Multiline = True
        Me.FarmsizeTextBox.Name = "FarmsizeTextBox"
        Me.FarmsizeTextBox.Size = New System.Drawing.Size(267, 37)
        Me.FarmsizeTextBox.TabIndex = 13
        '
        'CropNameTextBox
        '
        Me.CropNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CROPBindingSource, "CropName", True))
        Me.CropNameTextBox.Location = New System.Drawing.Point(229, 111)
        Me.CropNameTextBox.Multiline = True
        Me.CropNameTextBox.Name = "CropNameTextBox"
        Me.CropNameTextBox.Size = New System.Drawing.Size(274, 37)
        Me.CropNameTextBox.TabIndex = 15
        '
        'PlantingDateTextBox
        '
        Me.PlantingDateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CROPBindingSource, "PlantingDate", True))
        Me.PlantingDateTextBox.Location = New System.Drawing.Point(281, 185)
        Me.PlantingDateTextBox.Multiline = True
        Me.PlantingDateTextBox.Name = "PlantingDateTextBox"
        Me.PlantingDateTextBox.Size = New System.Drawing.Size(256, 37)
        Me.PlantingDateTextBox.TabIndex = 17
        '
        'HarvestDateTextBox
        '
        Me.HarvestDateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CROPBindingSource, "HarvestDate", True))
        Me.HarvestDateTextBox.Location = New System.Drawing.Point(265, 260)
        Me.HarvestDateTextBox.Multiline = True
        Me.HarvestDateTextBox.Name = "HarvestDateTextBox"
        Me.HarvestDateTextBox.Size = New System.Drawing.Size(256, 37)
        Me.HarvestDateTextBox.TabIndex = 19
        '
        'PestcontrolTextBox
        '
        Me.PestcontrolTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CROPBindingSource, "Pestcontrol", True))
        Me.PestcontrolTextBox.Location = New System.Drawing.Point(339, 331)
        Me.PestcontrolTextBox.Multiline = True
        Me.PestcontrolTextBox.Name = "PestcontrolTextBox"
        Me.PestcontrolTextBox.Size = New System.Drawing.Size(252, 37)
        Me.PestcontrolTextBox.TabIndex = 21
        '
        'GunaElipse1
        '
        Me.GunaElipse1.Radius = 25
        Me.GunaElipse1.TargetControl = Me
        '
        'CROP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(975, 587)
        Me.Controls.Add(Me.PestcontrolTextBox)
        Me.Controls.Add(Me.HarvestDateTextBox)
        Me.Controls.Add(Me.PlantingDateTextBox)
        Me.Controls.Add(Me.CropNameTextBox)
        Me.Controls.Add(Me.FarmsizeTextBox)
        Me.Controls.Add(Me.btnPreviousrecord)
        Me.Controls.Add(Me.btnCloseForm)
        Me.Controls.Add(Me.btnNextrecord)
        Me.Controls.Add(Me.btnDeleterecord)
        Me.Controls.Add(Me.btnSaverecord)
        Me.Controls.Add(Me.btnAddrecord)
        Me.Controls.Add(Me.lblFarmsize)
        Me.Controls.Add(Me.lblPestcontrol)
        Me.Controls.Add(Me.lblHarvestdate)
        Me.Controls.Add(Me.lblPlantdate)
        Me.Controls.Add(Me.lblCropname)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "CROP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CROP"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Mkulima_digitalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CROPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPlantdate As System.Windows.Forms.Label
    Friend WithEvents lblHarvestdate As System.Windows.Forms.Label
    Friend WithEvents lblPestcontrol As System.Windows.Forms.Label
    Friend WithEvents lblCropname As System.Windows.Forms.Label
    Friend WithEvents lblFarmsize As System.Windows.Forms.Label
    Friend WithEvents btnAddrecord As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents btnSaverecord As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents btnDeleterecord As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents btnNextrecord As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents btnCloseForm As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents btnPreviousrecord As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents Mkulima_digitalDataSet As MKULIMA_DIGITAL_FARM_SYSTEM.mkulima_digitalDataSet
    Friend WithEvents CROPBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CROPTableAdapter As MKULIMA_DIGITAL_FARM_SYSTEM.mkulima_digitalDataSetTableAdapters.CROPTableAdapter
    Friend WithEvents TableAdapterManager As MKULIMA_DIGITAL_FARM_SYSTEM.mkulima_digitalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FarmsizeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CropNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PlantingDateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HarvestDateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PestcontrolTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
End Class
