<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ORDER_RECEIPT
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
        Me.ORDER_ITEMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Mkulima_digitalDataSet = New MKULIMA_DIGITAL_FARM_SYSTEM.mkulima_digitalDataSet()
        Me.ORDERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ORDERTableAdapter = New MKULIMA_DIGITAL_FARM_SYSTEM.mkulima_digitalDataSetTableAdapters.ORDERTableAdapter()
        Me.TableAdapterManager = New MKULIMA_DIGITAL_FARM_SYSTEM.mkulima_digitalDataSetTableAdapters.TableAdapterManager()
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.ORDER_ITEMTableAdapter = New MKULIMA_DIGITAL_FARM_SYSTEM.mkulima_digitalDataSetTableAdapters.ORDER_ITEMTableAdapter()
        Me.ORDERDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ORDER_ITEMBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnCloseForm = New Guna.UI.WinForms.GunaCircleButton()
        CType(Me.ORDER_ITEMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mkulima_digitalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ORDERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ORDERDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ORDER_ITEMBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ORDER_ITEMBindingSource
        '
        Me.ORDER_ITEMBindingSource.DataMember = "ORDER ITEM"
        Me.ORDER_ITEMBindingSource.DataSource = Me.Mkulima_digitalDataSet
        '
        'Mkulima_digitalDataSet
        '
        Me.Mkulima_digitalDataSet.DataSetName = "mkulima_digitalDataSet"
        Me.Mkulima_digitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ORDERBindingSource
        '
        Me.ORDERBindingSource.DataMember = "ORDER"
        Me.ORDERBindingSource.DataSource = Me.Mkulima_digitalDataSet
        '
        'ORDERTableAdapter
        '
        Me.ORDERTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CROPTableAdapter = Nothing
        Me.TableAdapterManager.LIVESTOCKTableAdapter = Nothing
        Me.TableAdapterManager.ORDER_ITEMTableAdapter = Nothing
        Me.TableAdapterManager.ORDERTableAdapter = Me.ORDERTableAdapter
        Me.TableAdapterManager.UpdateOrder = MKULIMA_DIGITAL_FARM_SYSTEM.mkulima_digitalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.USERTableAdapter = Nothing
        '
        'GunaElipse1
        '
        Me.GunaElipse1.Radius = 25
        Me.GunaElipse1.TargetControl = Me
        '
        'ORDER_ITEMTableAdapter
        '
        Me.ORDER_ITEMTableAdapter.ClearBeforeFill = True
        '
        'ORDERDataGridView
        '
        Me.ORDERDataGridView.AllowUserToDeleteRows = False
        Me.ORDERDataGridView.AutoGenerateColumns = False
        Me.ORDERDataGridView.BackgroundColor = System.Drawing.Color.Aqua
        Me.ORDERDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ORDERDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ORDERDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.ORDERDataGridView.DataSource = Me.ORDERBindingSource
        Me.ORDERDataGridView.Location = New System.Drawing.Point(83, 39)
        Me.ORDERDataGridView.Name = "ORDERDataGridView"
        Me.ORDERDataGridView.Size = New System.Drawing.Size(845, 378)
        Me.ORDERDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "OrderID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "OrderID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ItemName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ItemName"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "OrderDate"
        Me.DataGridViewTextBoxColumn4.HeaderText = "OrderDate"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Cost"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Cost"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 150
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Quantity"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Quantity"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "DeliveryDate"
        Me.DataGridViewTextBoxColumn7.HeaderText = "DeliveryDate"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 150
        '
        'ORDER_ITEMBindingSource1
        '
        Me.ORDER_ITEMBindingSource1.DataMember = "ORDERORDER ITEM"
        Me.ORDER_ITEMBindingSource1.DataSource = Me.ORDERBindingSource
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
        Me.btnCloseForm.Location = New System.Drawing.Point(435, 465)
        Me.btnCloseForm.Name = "btnCloseForm"
        Me.btnCloseForm.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCloseForm.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnCloseForm.OnHoverForeColor = System.Drawing.Color.White
        Me.btnCloseForm.OnHoverImage = Nothing
        Me.btnCloseForm.OnPressedColor = System.Drawing.Color.Black
        Me.btnCloseForm.Size = New System.Drawing.Size(180, 67)
        Me.btnCloseForm.TabIndex = 39
        Me.btnCloseForm.Text = "CLOSE"
        '
        'ORDER_RECEIPT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aqua
        Me.ClientSize = New System.Drawing.Size(1055, 569)
        Me.Controls.Add(Me.btnCloseForm)
        Me.Controls.Add(Me.ORDERDataGridView)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "ORDER_RECEIPT"
        Me.Text = "ORDER_RECEIPT"
        CType(Me.ORDER_ITEMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mkulima_digitalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ORDERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ORDERDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ORDER_ITEMBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Mkulima_digitalDataSet As MKULIMA_DIGITAL_FARM_SYSTEM.mkulima_digitalDataSet
    Friend WithEvents ORDERBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ORDERTableAdapter As MKULIMA_DIGITAL_FARM_SYSTEM.mkulima_digitalDataSetTableAdapters.ORDERTableAdapter
    Friend WithEvents TableAdapterManager As MKULIMA_DIGITAL_FARM_SYSTEM.mkulima_digitalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents ORDER_ITEMBindingSource As BindingSource
    Friend WithEvents ORDER_ITEMTableAdapter As mkulima_digitalDataSetTableAdapters.ORDER_ITEMTableAdapter
    Friend WithEvents ORDERDataGridView As DataGridView
    Friend WithEvents ORDER_ITEMBindingSource1 As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents btnCloseForm As Guna.UI.WinForms.GunaCircleButton
End Class
