<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ORDER
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
        Me.lblOrderdate = New System.Windows.Forms.Label()
        Me.lblDeliverydate = New System.Windows.Forms.Label()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.lblItemname = New System.Windows.Forms.Label()
        Me.btnPreviousrecord = New Guna.UI.WinForms.GunaCircleButton()
        Me.btnNextrecord = New Guna.UI.WinForms.GunaCircleButton()
        Me.btnDeleterecord = New Guna.UI.WinForms.GunaCircleButton()
        Me.btnSaverecord = New Guna.UI.WinForms.GunaCircleButton()
        Me.btnAddrecord = New Guna.UI.WinForms.GunaCircleButton()
        Me.btnCloseForm = New Guna.UI.WinForms.GunaCircleButton()
        Me.Mkulima_digitalDataSet = New MKULIMA_DIGITAL_FARM_SYSTEM.mkulima_digitalDataSet()
        Me.ORDERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ORDERTableAdapter = New MKULIMA_DIGITAL_FARM_SYSTEM.mkulima_digitalDataSetTableAdapters.ORDERTableAdapter()
        Me.TableAdapterManager = New MKULIMA_DIGITAL_FARM_SYSTEM.mkulima_digitalDataSetTableAdapters.TableAdapterManager()
        Me.ItemNameTextBox = New System.Windows.Forms.TextBox()
        Me.OrderDateTextBox = New System.Windows.Forms.TextBox()
        Me.CostTextBox = New System.Windows.Forms.TextBox()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.DeliveryDateTextBox = New System.Windows.Forms.TextBox()
        Me.BunifuElipse1 = New ns1.BunifuElipse(Me.components)
        Me.USERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.USERTableAdapter = New MKULIMA_DIGITAL_FARM_SYSTEM.mkulima_digitalDataSetTableAdapters.USERTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OrderIDTextBox = New System.Windows.Forms.TextBox()
        CType(Me.Mkulima_digitalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ORDERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.USERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblOrderdate
        '
        Me.lblOrderdate.AutoSize = True
        Me.lblOrderdate.BackColor = System.Drawing.Color.Transparent
        Me.lblOrderdate.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblOrderdate.ForeColor = System.Drawing.Color.Red
        Me.lblOrderdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblOrderdate.Location = New System.Drawing.Point(43, 111)
        Me.lblOrderdate.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.lblOrderdate.Name = "lblOrderdate"
        Me.lblOrderdate.Size = New System.Drawing.Size(188, 37)
        Me.lblOrderdate.TabIndex = 16
        Me.lblOrderdate.Text = "ORDER DATE:"
        Me.lblOrderdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDeliverydate
        '
        Me.lblDeliverydate.AutoSize = True
        Me.lblDeliverydate.BackColor = System.Drawing.Color.Transparent
        Me.lblDeliverydate.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblDeliverydate.ForeColor = System.Drawing.Color.Red
        Me.lblDeliverydate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblDeliverydate.Location = New System.Drawing.Point(43, 391)
        Me.lblDeliverydate.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.lblDeliverydate.Name = "lblDeliverydate"
        Me.lblDeliverydate.Size = New System.Drawing.Size(221, 37)
        Me.lblDeliverydate.TabIndex = 15
        Me.lblDeliverydate.Text = "DELIVERY DATE:"
        Me.lblDeliverydate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.BackColor = System.Drawing.Color.Transparent
        Me.lblCost.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblCost.ForeColor = System.Drawing.Color.Red
        Me.lblCost.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblCost.Location = New System.Drawing.Point(43, 322)
        Me.lblCost.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(92, 37)
        Me.lblCost.TabIndex = 14
        Me.lblCost.Text = "COST:"
        Me.lblCost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.BackColor = System.Drawing.Color.Transparent
        Me.lblQuantity.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblQuantity.ForeColor = System.Drawing.Color.Red
        Me.lblQuantity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblQuantity.Location = New System.Drawing.Point(43, 255)
        Me.lblQuantity.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(161, 37)
        Me.lblQuantity.TabIndex = 13
        Me.lblQuantity.Text = "QUANTITY:"
        Me.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblItemname
        '
        Me.lblItemname.AutoSize = True
        Me.lblItemname.BackColor = System.Drawing.Color.Transparent
        Me.lblItemname.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblItemname.ForeColor = System.Drawing.Color.Red
        Me.lblItemname.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblItemname.Location = New System.Drawing.Point(43, 186)
        Me.lblItemname.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.lblItemname.Name = "lblItemname"
        Me.lblItemname.Size = New System.Drawing.Size(176, 37)
        Me.lblItemname.TabIndex = 12
        Me.lblItemname.Text = "ITEM NAME:"
        Me.lblItemname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.btnPreviousrecord.Location = New System.Drawing.Point(747, 408)
        Me.btnPreviousrecord.Name = "btnPreviousrecord"
        Me.btnPreviousrecord.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPreviousrecord.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnPreviousrecord.OnHoverForeColor = System.Drawing.Color.White
        Me.btnPreviousrecord.OnHoverImage = Nothing
        Me.btnPreviousrecord.OnPressedColor = System.Drawing.Color.Black
        Me.btnPreviousrecord.Size = New System.Drawing.Size(180, 67)
        Me.btnPreviousrecord.TabIndex = 37
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
        Me.btnNextrecord.Location = New System.Drawing.Point(747, 312)
        Me.btnNextrecord.Name = "btnNextrecord"
        Me.btnNextrecord.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnNextrecord.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnNextrecord.OnHoverForeColor = System.Drawing.Color.White
        Me.btnNextrecord.OnHoverImage = Nothing
        Me.btnNextrecord.OnPressedColor = System.Drawing.Color.Black
        Me.btnNextrecord.Size = New System.Drawing.Size(180, 67)
        Me.btnNextrecord.TabIndex = 36
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
        Me.btnDeleterecord.Location = New System.Drawing.Point(747, 128)
        Me.btnDeleterecord.Name = "btnDeleterecord"
        Me.btnDeleterecord.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDeleterecord.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnDeleterecord.OnHoverForeColor = System.Drawing.Color.White
        Me.btnDeleterecord.OnHoverImage = Nothing
        Me.btnDeleterecord.OnPressedColor = System.Drawing.Color.Black
        Me.btnDeleterecord.Size = New System.Drawing.Size(180, 67)
        Me.btnDeleterecord.TabIndex = 35
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
        Me.btnSaverecord.Location = New System.Drawing.Point(747, 219)
        Me.btnSaverecord.Name = "btnSaverecord"
        Me.btnSaverecord.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSaverecord.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnSaverecord.OnHoverForeColor = System.Drawing.Color.White
        Me.btnSaverecord.OnHoverImage = Nothing
        Me.btnSaverecord.OnPressedColor = System.Drawing.Color.Black
        Me.btnSaverecord.Size = New System.Drawing.Size(180, 67)
        Me.btnSaverecord.TabIndex = 34
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
        Me.btnAddrecord.Location = New System.Drawing.Point(747, 34)
        Me.btnAddrecord.Name = "btnAddrecord"
        Me.btnAddrecord.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAddrecord.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnAddrecord.OnHoverForeColor = System.Drawing.Color.White
        Me.btnAddrecord.OnHoverImage = Nothing
        Me.btnAddrecord.OnPressedColor = System.Drawing.Color.Black
        Me.btnAddrecord.Size = New System.Drawing.Size(180, 67)
        Me.btnAddrecord.TabIndex = 33
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
        Me.btnCloseForm.Location = New System.Drawing.Point(382, 456)
        Me.btnCloseForm.Name = "btnCloseForm"
        Me.btnCloseForm.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCloseForm.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnCloseForm.OnHoverForeColor = System.Drawing.Color.White
        Me.btnCloseForm.OnHoverImage = Nothing
        Me.btnCloseForm.OnPressedColor = System.Drawing.Color.Black
        Me.btnCloseForm.Size = New System.Drawing.Size(180, 67)
        Me.btnCloseForm.TabIndex = 38
        Me.btnCloseForm.Text = "CLOSE"
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
        'Me.TableAdapterManager.RESOURCETableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = MKULIMA_DIGITAL_FARM_SYSTEM.mkulima_digitalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.USERTableAdapter = Nothing
        '
        'ItemNameTextBox
        '
        Me.ItemNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ORDERBindingSource, "ItemName", True))
        Me.ItemNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemNameTextBox.Location = New System.Drawing.Point(233, 186)
        Me.ItemNameTextBox.Multiline = True
        Me.ItemNameTextBox.Name = "ItemNameTextBox"
        Me.ItemNameTextBox.Size = New System.Drawing.Size(270, 37)
        Me.ItemNameTextBox.TabIndex = 40
        '
        'OrderDateTextBox
        '
        Me.OrderDateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ORDERBindingSource, "OrderDate", True))
        Me.OrderDateTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderDateTextBox.Location = New System.Drawing.Point(245, 111)
        Me.OrderDateTextBox.Multiline = True
        Me.OrderDateTextBox.Name = "OrderDateTextBox"
        Me.OrderDateTextBox.Size = New System.Drawing.Size(279, 37)
        Me.OrderDateTextBox.TabIndex = 41
        '
        'CostTextBox
        '
        Me.CostTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ORDERBindingSource, "Cost", True))
        Me.CostTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CostTextBox.Location = New System.Drawing.Point(149, 322)
        Me.CostTextBox.Multiline = True
        Me.CostTextBox.Name = "CostTextBox"
        Me.CostTextBox.Size = New System.Drawing.Size(256, 37)
        Me.CostTextBox.TabIndex = 42
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ORDERBindingSource, "Quantity", True))
        Me.QuantityTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantityTextBox.Location = New System.Drawing.Point(218, 255)
        Me.QuantityTextBox.Multiline = True
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(252, 37)
        Me.QuantityTextBox.TabIndex = 43
        '
        'DeliveryDateTextBox
        '
        Me.DeliveryDateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ORDERBindingSource, "DeliveryDate", True))
        Me.DeliveryDateTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeliveryDateTextBox.Location = New System.Drawing.Point(278, 391)
        Me.DeliveryDateTextBox.Multiline = True
        Me.DeliveryDateTextBox.Name = "DeliveryDateTextBox"
        Me.DeliveryDateTextBox.Size = New System.Drawing.Size(256, 37)
        Me.DeliveryDateTextBox.TabIndex = 44
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 50
        Me.BunifuElipse1.TargetControl = Me
        '
        'USERBindingSource
        '
        Me.USERBindingSource.DataMember = "USER"
        Me.USERBindingSource.DataSource = Me.Mkulima_digitalDataSet
        '
        'USERTableAdapter
        '
        Me.USERTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(43, 44)
        Me.Label1.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 37)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "USERNAME:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'OrderIDTextBox
        '
        Me.OrderIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ORDERBindingSource, "OrderID", True))
        Me.OrderIDTextBox.Location = New System.Drawing.Point(245, 48)
        Me.OrderIDTextBox.Name = "OrderIDTextBox"
        Me.OrderIDTextBox.Size = New System.Drawing.Size(279, 29)
        Me.OrderIDTextBox.TabIndex = 46
        '
        'ORDER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(975, 555)
        Me.Controls.Add(Me.OrderIDTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DeliveryDateTextBox)
        Me.Controls.Add(Me.QuantityTextBox)
        Me.Controls.Add(Me.CostTextBox)
        Me.Controls.Add(Me.OrderDateTextBox)
        Me.Controls.Add(Me.ItemNameTextBox)
        Me.Controls.Add(Me.btnCloseForm)
        Me.Controls.Add(Me.btnPreviousrecord)
        Me.Controls.Add(Me.btnNextrecord)
        Me.Controls.Add(Me.btnDeleterecord)
        Me.Controls.Add(Me.btnSaverecord)
        Me.Controls.Add(Me.btnAddrecord)
        Me.Controls.Add(Me.lblOrderdate)
        Me.Controls.Add(Me.lblDeliverydate)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.lblItemname)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "ORDER"
        Me.Text = "ORDER"
        CType(Me.Mkulima_digitalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ORDERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.USERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblOrderdate As System.Windows.Forms.Label
    Friend WithEvents lblDeliverydate As System.Windows.Forms.Label
    Friend WithEvents lblCost As System.Windows.Forms.Label
    Friend WithEvents lblQuantity As System.Windows.Forms.Label
    Friend WithEvents lblItemname As System.Windows.Forms.Label
    Friend WithEvents btnPreviousrecord As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents btnNextrecord As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents btnDeleterecord As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents btnSaverecord As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents btnAddrecord As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents btnCloseForm As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents Mkulima_digitalDataSet As MKULIMA_DIGITAL_FARM_SYSTEM.mkulima_digitalDataSet
    Friend WithEvents ORDERBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ORDERTableAdapter As MKULIMA_DIGITAL_FARM_SYSTEM.mkulima_digitalDataSetTableAdapters.ORDERTableAdapter
    Friend WithEvents TableAdapterManager As MKULIMA_DIGITAL_FARM_SYSTEM.mkulima_digitalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ItemNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OrderDateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CostTextBox As System.Windows.Forms.TextBox
    Friend WithEvents QuantityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DeliveryDateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BunifuElipse1 As ns1.BunifuElipse
    Friend WithEvents USERBindingSource As BindingSource
    Friend WithEvents USERTableAdapter As mkulima_digitalDataSetTableAdapters.USERTableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents OrderIDTextBox As TextBox
End Class
