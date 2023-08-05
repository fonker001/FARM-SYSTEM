<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LIVESTOCK_REPORT
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.LivestockIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnimalTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BirthDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PestControlDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LIVESTOCKBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Mkulima_digitalDataSet1 = New MKULIMA_DIGITAL_FARM_SYSTEM.mkulima_digitalDataSet1()
        Me.LIVESTOCKTableAdapter = New MKULIMA_DIGITAL_FARM_SYSTEM.mkulima_digitalDataSet1TableAdapters.LIVESTOCKTableAdapter()
        Me.PrintDialog = New System.Windows.Forms.PrintDialog()
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.btnCloseForm = New Guna.UI.WinForms.GunaCircleButton()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LIVESTOCKBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mkulima_digitalDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Blue
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LivestockIDDataGridViewTextBoxColumn, Me.AnimalTypeDataGridViewTextBoxColumn, Me.BirthDateDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.PestControlDateDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.LIVESTOCKBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(41, 38)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(6)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(924, 356)
        Me.DataGridView1.TabIndex = 0
        '
        'LivestockIDDataGridViewTextBoxColumn
        '
        Me.LivestockIDDataGridViewTextBoxColumn.DataPropertyName = "LivestockID"
        Me.LivestockIDDataGridViewTextBoxColumn.HeaderText = "LivestockID"
        Me.LivestockIDDataGridViewTextBoxColumn.Name = "LivestockIDDataGridViewTextBoxColumn"
        Me.LivestockIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.LivestockIDDataGridViewTextBoxColumn.Width = 150
        '
        'AnimalTypeDataGridViewTextBoxColumn
        '
        Me.AnimalTypeDataGridViewTextBoxColumn.DataPropertyName = "AnimalType"
        Me.AnimalTypeDataGridViewTextBoxColumn.HeaderText = "AnimalType"
        Me.AnimalTypeDataGridViewTextBoxColumn.Name = "AnimalTypeDataGridViewTextBoxColumn"
        Me.AnimalTypeDataGridViewTextBoxColumn.ReadOnly = True
        Me.AnimalTypeDataGridViewTextBoxColumn.Width = 150
        '
        'BirthDateDataGridViewTextBoxColumn
        '
        Me.BirthDateDataGridViewTextBoxColumn.DataPropertyName = "BirthDate"
        Me.BirthDateDataGridViewTextBoxColumn.HeaderText = "BirthDate"
        Me.BirthDateDataGridViewTextBoxColumn.Name = "BirthDateDataGridViewTextBoxColumn"
        Me.BirthDateDataGridViewTextBoxColumn.ReadOnly = True
        Me.BirthDateDataGridViewTextBoxColumn.Width = 150
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "Gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "Gender"
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        Me.GenderDataGridViewTextBoxColumn.ReadOnly = True
        Me.GenderDataGridViewTextBoxColumn.Width = 150
        '
        'PestControlDateDataGridViewTextBoxColumn
        '
        Me.PestControlDateDataGridViewTextBoxColumn.DataPropertyName = "PestControlDate"
        Me.PestControlDateDataGridViewTextBoxColumn.HeaderText = "PestControlDate"
        Me.PestControlDateDataGridViewTextBoxColumn.Name = "PestControlDateDataGridViewTextBoxColumn"
        Me.PestControlDateDataGridViewTextBoxColumn.ReadOnly = True
        Me.PestControlDateDataGridViewTextBoxColumn.Width = 150
        '
        'LIVESTOCKBindingSource
        '
        Me.LIVESTOCKBindingSource.DataMember = "LIVESTOCK"
        Me.LIVESTOCKBindingSource.DataSource = Me.Mkulima_digitalDataSet1
        '
        'Mkulima_digitalDataSet1
        '
        Me.Mkulima_digitalDataSet1.DataSetName = "mkulima_digitalDataSet1"
        Me.Mkulima_digitalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LIVESTOCKTableAdapter
        '
        Me.LIVESTOCKTableAdapter.ClearBeforeFill = True
        '
        'PrintDialog
        '
        Me.PrintDialog.UseEXDialog = True
        '
        'GunaElipse1
        '
        Me.GunaElipse1.Radius = 50
        Me.GunaElipse1.TargetControl = Me
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
        Me.btnCloseForm.Location = New System.Drawing.Point(429, 434)
        Me.btnCloseForm.Name = "btnCloseForm"
        Me.btnCloseForm.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCloseForm.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnCloseForm.OnHoverForeColor = System.Drawing.Color.White
        Me.btnCloseForm.OnHoverImage = Nothing
        Me.btnCloseForm.OnPressedColor = System.Drawing.Color.Black
        Me.btnCloseForm.Size = New System.Drawing.Size(180, 67)
        Me.btnCloseForm.TabIndex = 40
        Me.btnCloseForm.Text = "CLOSE"
        '
        'LIVESTOCK_REPORT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Blue
        Me.ClientSize = New System.Drawing.Size(1052, 546)
        Me.Controls.Add(Me.btnCloseForm)
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "LIVESTOCK_REPORT"
        Me.Text = "LIVESTOCK_REPORT"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LIVESTOCKBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mkulima_digitalDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Mkulima_digitalDataSet1 As MKULIMA_DIGITAL_FARM_SYSTEM.mkulima_digitalDataSet1
    Friend WithEvents LIVESTOCKBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LIVESTOCKTableAdapter As MKULIMA_DIGITAL_FARM_SYSTEM.mkulima_digitalDataSet1TableAdapters.LIVESTOCKTableAdapter
    Friend WithEvents LivestockIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AnimalTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BirthDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PestControlDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrintDialog As System.Windows.Forms.PrintDialog
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents btnCloseForm As Guna.UI.WinForms.GunaCircleButton
End Class
