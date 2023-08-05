<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LIVESTOCK
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
        Me.lblAnimaltype = New System.Windows.Forms.Label()
        Me.lblHarvestdate = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblBirthdate = New System.Windows.Forms.Label()
        Me.Mkulima_digitalDataSet = New MKULIMA_DIGITAL_FARM_SYSTEM.mkulima_digitalDataSet()
        Me.LIVESTOCKBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LIVESTOCKTableAdapter = New MKULIMA_DIGITAL_FARM_SYSTEM.mkulima_digitalDataSetTableAdapters.LIVESTOCKTableAdapter()
        Me.TableAdapterManager = New MKULIMA_DIGITAL_FARM_SYSTEM.mkulima_digitalDataSetTableAdapters.TableAdapterManager()
        Me.AnimalTypeTextBox = New System.Windows.Forms.TextBox()
        Me.BirthDateTextBox = New System.Windows.Forms.TextBox()
        Me.GenderTextBox = New System.Windows.Forms.TextBox()
        Me.PestControlDateTextBox = New System.Windows.Forms.TextBox()
        Me.btnPreviousrecord = New Guna.UI.WinForms.GunaCircleButton()
        Me.btnNextrecord = New Guna.UI.WinForms.GunaCircleButton()
        Me.btnDeleterecord = New Guna.UI.WinForms.GunaCircleButton()
        Me.btnSaverecord = New Guna.UI.WinForms.GunaCircleButton()
        Me.btnAddrecord = New Guna.UI.WinForms.GunaCircleButton()
        Me.btnCloseForm = New Guna.UI.WinForms.GunaCircleButton()
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.BunifuFormFadeTransition1 = New ns1.BunifuFormFadeTransition(Me.components)
        CType(Me.Mkulima_digitalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LIVESTOCKBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblAnimaltype
        '
        Me.lblAnimaltype.AutoSize = True
        Me.lblAnimaltype.BackColor = System.Drawing.Color.Transparent
        Me.lblAnimaltype.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblAnimaltype.ForeColor = System.Drawing.Color.Red
        Me.lblAnimaltype.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblAnimaltype.Location = New System.Drawing.Point(28, 44)
        Me.lblAnimaltype.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.lblAnimaltype.Name = "lblAnimaltype"
        Me.lblAnimaltype.Size = New System.Drawing.Size(203, 37)
        Me.lblAnimaltype.TabIndex = 16
        Me.lblAnimaltype.Text = "ANIMAL TYPE:"
        Me.lblAnimaltype.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblHarvestdate
        '
        Me.lblHarvestdate.AutoSize = True
        Me.lblHarvestdate.BackColor = System.Drawing.Color.Transparent
        Me.lblHarvestdate.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblHarvestdate.ForeColor = System.Drawing.Color.Red
        Me.lblHarvestdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblHarvestdate.Location = New System.Drawing.Point(33, 253)
        Me.lblHarvestdate.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.lblHarvestdate.Name = "lblHarvestdate"
        Me.lblHarvestdate.Size = New System.Drawing.Size(293, 37)
        Me.lblHarvestdate.TabIndex = 14
        Me.lblHarvestdate.Text = "PEST CONTROL DATE:"
        Me.lblHarvestdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.BackColor = System.Drawing.Color.Transparent
        Me.lblGender.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblGender.ForeColor = System.Drawing.Color.Red
        Me.lblGender.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblGender.Location = New System.Drawing.Point(33, 178)
        Me.lblGender.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(130, 37)
        Me.lblGender.TabIndex = 13
        Me.lblGender.Text = "GENDER:"
        Me.lblGender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblBirthdate
        '
        Me.lblBirthdate.AutoSize = True
        Me.lblBirthdate.BackColor = System.Drawing.Color.Transparent
        Me.lblBirthdate.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblBirthdate.ForeColor = System.Drawing.Color.Red
        Me.lblBirthdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblBirthdate.Location = New System.Drawing.Point(33, 111)
        Me.lblBirthdate.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.lblBirthdate.Name = "lblBirthdate"
        Me.lblBirthdate.Size = New System.Drawing.Size(178, 37)
        Me.lblBirthdate.TabIndex = 12
        Me.lblBirthdate.Text = "BIRTH DATE:"
        Me.lblBirthdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'Me.TableAdapterManager.RESOURCETableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = MKULIMA_DIGITAL_FARM_SYSTEM.mkulima_digitalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.USERTableAdapter = Nothing
        '
        'AnimalTypeTextBox
        '
        Me.AnimalTypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LIVESTOCKBindingSource, "AnimalType", True))
        Me.AnimalTypeTextBox.Location = New System.Drawing.Point(248, 44)
        Me.AnimalTypeTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.AnimalTypeTextBox.Multiline = True
        Me.AnimalTypeTextBox.Name = "AnimalTypeTextBox"
        Me.AnimalTypeTextBox.Size = New System.Drawing.Size(261, 37)
        Me.AnimalTypeTextBox.TabIndex = 24
        '
        'BirthDateTextBox
        '
        Me.BirthDateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LIVESTOCKBindingSource, "BirthDate", True))
        Me.BirthDateTextBox.Location = New System.Drawing.Point(228, 111)
        Me.BirthDateTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.BirthDateTextBox.Multiline = True
        Me.BirthDateTextBox.Name = "BirthDateTextBox"
        Me.BirthDateTextBox.Size = New System.Drawing.Size(261, 37)
        Me.BirthDateTextBox.TabIndex = 25
        '
        'GenderTextBox
        '
        Me.GenderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LIVESTOCKBindingSource, "Gender", True))
        Me.GenderTextBox.Location = New System.Drawing.Point(180, 178)
        Me.GenderTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.GenderTextBox.Multiline = True
        Me.GenderTextBox.Name = "GenderTextBox"
        Me.GenderTextBox.Size = New System.Drawing.Size(261, 37)
        Me.GenderTextBox.TabIndex = 26
        '
        'PestControlDateTextBox
        '
        Me.PestControlDateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LIVESTOCKBindingSource, "PestControlDate", True))
        Me.PestControlDateTextBox.Location = New System.Drawing.Point(343, 253)
        Me.PestControlDateTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.PestControlDateTextBox.Multiline = True
        Me.PestControlDateTextBox.Name = "PestControlDateTextBox"
        Me.PestControlDateTextBox.Size = New System.Drawing.Size(262, 37)
        Me.PestControlDateTextBox.TabIndex = 27
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
        Me.btnPreviousrecord.Location = New System.Drawing.Point(772, 407)
        Me.btnPreviousrecord.Name = "btnPreviousrecord"
        Me.btnPreviousrecord.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPreviousrecord.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnPreviousrecord.OnHoverForeColor = System.Drawing.Color.White
        Me.btnPreviousrecord.OnHoverImage = Nothing
        Me.btnPreviousrecord.OnPressedColor = System.Drawing.Color.Black
        Me.btnPreviousrecord.Size = New System.Drawing.Size(180, 67)
        Me.btnPreviousrecord.TabIndex = 32
        Me.btnPreviousrecord.Text = "PREVIOUS RECORD"
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
        Me.btnNextrecord.Location = New System.Drawing.Point(772, 311)
        Me.btnNextrecord.Name = "btnNextrecord"
        Me.btnNextrecord.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnNextrecord.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnNextrecord.OnHoverForeColor = System.Drawing.Color.White
        Me.btnNextrecord.OnHoverImage = Nothing
        Me.btnNextrecord.OnPressedColor = System.Drawing.Color.Black
        Me.btnNextrecord.Size = New System.Drawing.Size(180, 67)
        Me.btnNextrecord.TabIndex = 31
        Me.btnNextrecord.Text = "NEXT RECORD"
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
        Me.btnDeleterecord.Location = New System.Drawing.Point(772, 127)
        Me.btnDeleterecord.Name = "btnDeleterecord"
        Me.btnDeleterecord.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDeleterecord.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnDeleterecord.OnHoverForeColor = System.Drawing.Color.White
        Me.btnDeleterecord.OnHoverImage = Nothing
        Me.btnDeleterecord.OnPressedColor = System.Drawing.Color.Black
        Me.btnDeleterecord.Size = New System.Drawing.Size(180, 67)
        Me.btnDeleterecord.TabIndex = 30
        Me.btnDeleterecord.Text = "DELETE RECORD"
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
        Me.btnSaverecord.Location = New System.Drawing.Point(772, 218)
        Me.btnSaverecord.Name = "btnSaverecord"
        Me.btnSaverecord.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSaverecord.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnSaverecord.OnHoverForeColor = System.Drawing.Color.White
        Me.btnSaverecord.OnHoverImage = Nothing
        Me.btnSaverecord.OnPressedColor = System.Drawing.Color.Black
        Me.btnSaverecord.Size = New System.Drawing.Size(180, 67)
        Me.btnSaverecord.TabIndex = 29
        Me.btnSaverecord.Text = "SAVE RECORD"
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
        Me.btnAddrecord.Location = New System.Drawing.Point(772, 44)
        Me.btnAddrecord.Name = "btnAddrecord"
        Me.btnAddrecord.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAddrecord.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnAddrecord.OnHoverForeColor = System.Drawing.Color.White
        Me.btnAddrecord.OnHoverImage = Nothing
        Me.btnAddrecord.OnPressedColor = System.Drawing.Color.Black
        Me.btnAddrecord.Size = New System.Drawing.Size(180, 67)
        Me.btnAddrecord.TabIndex = 28
        Me.btnAddrecord.Text = "ADD RECORD"
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
        Me.btnCloseForm.Location = New System.Drawing.Point(380, 422)
        Me.btnCloseForm.Name = "btnCloseForm"
        Me.btnCloseForm.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCloseForm.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnCloseForm.OnHoverForeColor = System.Drawing.Color.White
        Me.btnCloseForm.OnHoverImage = Nothing
        Me.btnCloseForm.OnPressedColor = System.Drawing.Color.Black
        Me.btnCloseForm.Size = New System.Drawing.Size(180, 67)
        Me.btnCloseForm.TabIndex = 33
        Me.btnCloseForm.Text = "CLOSE"
        '
        'GunaElipse1
        '
        Me.GunaElipse1.Radius = 30
        Me.GunaElipse1.TargetControl = Me
        '
        'BunifuFormFadeTransition1
        '
        Me.BunifuFormFadeTransition1.Delay = 5
        '
        'LIVESTOCK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Yellow
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(975, 523)
        Me.Controls.Add(Me.btnCloseForm)
        Me.Controls.Add(Me.btnPreviousrecord)
        Me.Controls.Add(Me.btnNextrecord)
        Me.Controls.Add(Me.btnDeleterecord)
        Me.Controls.Add(Me.btnSaverecord)
        Me.Controls.Add(Me.btnAddrecord)
        Me.Controls.Add(Me.PestControlDateTextBox)
        Me.Controls.Add(Me.GenderTextBox)
        Me.Controls.Add(Me.BirthDateTextBox)
        Me.Controls.Add(Me.AnimalTypeTextBox)
        Me.Controls.Add(Me.lblAnimaltype)
        Me.Controls.Add(Me.lblHarvestdate)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.lblBirthdate)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "LIVESTOCK"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LIVESTOCK"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Mkulima_digitalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LIVESTOCKBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAnimaltype As System.Windows.Forms.Label
    Friend WithEvents lblHarvestdate As System.Windows.Forms.Label
    Friend WithEvents lblGender As System.Windows.Forms.Label
    Friend WithEvents lblBirthdate As System.Windows.Forms.Label
    Friend WithEvents Mkulima_digitalDataSet As MKULIMA_DIGITAL_FARM_SYSTEM.mkulima_digitalDataSet
    Friend WithEvents LIVESTOCKBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LIVESTOCKTableAdapter As MKULIMA_DIGITAL_FARM_SYSTEM.mkulima_digitalDataSetTableAdapters.LIVESTOCKTableAdapter
    Friend WithEvents TableAdapterManager As MKULIMA_DIGITAL_FARM_SYSTEM.mkulima_digitalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AnimalTypeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BirthDateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GenderTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PestControlDateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnPreviousrecord As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents btnNextrecord As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents btnDeleterecord As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents btnSaverecord As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents btnAddrecord As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents btnCloseForm As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents BunifuFormFadeTransition1 As ns1.BunifuFormFadeTransition
End Class
