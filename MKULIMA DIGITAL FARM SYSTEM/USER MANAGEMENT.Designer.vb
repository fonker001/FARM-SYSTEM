<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class USER_MANAGEMENT
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
        Me.BunifuElipse1 = New ns1.BunifuElipse(Me.components)
        Me.Mkulima_digitalDataSet = New MKULIMA_DIGITAL_FARM_SYSTEM.mkulima_digitalDataSet()
        Me.USERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.USERTableAdapter = New MKULIMA_DIGITAL_FARM_SYSTEM.mkulima_digitalDataSetTableAdapters.USERTableAdapter()
        Me.TableAdapterManager = New MKULIMA_DIGITAL_FARM_SYSTEM.mkulima_digitalDataSetTableAdapters.TableAdapterManager()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.lblAnimaltype = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblBirthdate = New System.Windows.Forms.Label()
        Me.btnCloseForm = New Guna.UI.WinForms.GunaCircleButton()
        Me.btnPreviousrecord = New Guna.UI.WinForms.GunaCircleButton()
        Me.btnNextrecord = New Guna.UI.WinForms.GunaCircleButton()
        Me.btnDeleterecord = New Guna.UI.WinForms.GunaCircleButton()
        Me.btnSaverecord = New Guna.UI.WinForms.GunaCircleButton()
        Me.btnAddrecord = New Guna.UI.WinForms.GunaCircleButton()
        CType(Me.Mkulima_digitalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.USERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 50
        Me.BunifuElipse1.TargetControl = Me
        '
        'Mkulima_digitalDataSet
        '
        Me.Mkulima_digitalDataSet.DataSetName = "mkulima_digitalDataSet"
        Me.Mkulima_digitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CROPTableAdapter = Nothing
        Me.TableAdapterManager.LIVESTOCKTableAdapter = Nothing
        Me.TableAdapterManager.ORDER_ITEMTableAdapter = Nothing
        Me.TableAdapterManager.ORDERTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = MKULIMA_DIGITAL_FARM_SYSTEM.mkulima_digitalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.USERTableAdapter = Me.USERTableAdapter
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.USERBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(245, 193)
        Me.EmailTextBox.Multiline = True
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(261, 37)
        Me.EmailTextBox.TabIndex = 2
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.USERBindingSource, "Username", True))
        Me.UsernameTextBox.Location = New System.Drawing.Point(245, 59)
        Me.UsernameTextBox.Multiline = True
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(261, 37)
        Me.UsernameTextBox.TabIndex = 4
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.USERBindingSource, "Password", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(245, 126)
        Me.PasswordTextBox.Multiline = True
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(120)
        Me.PasswordTextBox.Size = New System.Drawing.Size(261, 37)
        Me.PasswordTextBox.TabIndex = 6
        '
        'lblAnimaltype
        '
        Me.lblAnimaltype.AutoSize = True
        Me.lblAnimaltype.BackColor = System.Drawing.Color.Transparent
        Me.lblAnimaltype.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblAnimaltype.ForeColor = System.Drawing.Color.Red
        Me.lblAnimaltype.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblAnimaltype.Location = New System.Drawing.Point(60, 56)
        Me.lblAnimaltype.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.lblAnimaltype.Name = "lblAnimaltype"
        Me.lblAnimaltype.Size = New System.Drawing.Size(171, 37)
        Me.lblAnimaltype.TabIndex = 20
        Me.lblAnimaltype.Text = "USERNAME:"
        Me.lblAnimaltype.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.BackColor = System.Drawing.Color.Transparent
        Me.lblGender.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblGender.ForeColor = System.Drawing.Color.Red
        Me.lblGender.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblGender.Location = New System.Drawing.Point(125, 190)
        Me.lblGender.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(106, 37)
        Me.lblGender.TabIndex = 18
        Me.lblGender.Text = "EMAIL:"
        Me.lblGender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblBirthdate
        '
        Me.lblBirthdate.AutoSize = True
        Me.lblBirthdate.BackColor = System.Drawing.Color.Transparent
        Me.lblBirthdate.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblBirthdate.ForeColor = System.Drawing.Color.Red
        Me.lblBirthdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblBirthdate.Location = New System.Drawing.Point(58, 123)
        Me.lblBirthdate.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.lblBirthdate.Name = "lblBirthdate"
        Me.lblBirthdate.Size = New System.Drawing.Size(173, 37)
        Me.lblBirthdate.TabIndex = 17
        Me.lblBirthdate.Text = "PASSWORD:"
        Me.lblBirthdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.btnCloseForm.Location = New System.Drawing.Point(266, 376)
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
        Me.btnPreviousrecord.Location = New System.Drawing.Point(599, 376)
        Me.btnPreviousrecord.Name = "btnPreviousrecord"
        Me.btnPreviousrecord.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPreviousrecord.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnPreviousrecord.OnHoverForeColor = System.Drawing.Color.White
        Me.btnPreviousrecord.OnHoverImage = Nothing
        Me.btnPreviousrecord.OnPressedColor = System.Drawing.Color.Black
        Me.btnPreviousrecord.Size = New System.Drawing.Size(180, 67)
        Me.btnPreviousrecord.TabIndex = 38
        Me.btnPreviousrecord.Text = "PREVIOUS USER"
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
        Me.btnNextrecord.Location = New System.Drawing.Point(599, 280)
        Me.btnNextrecord.Name = "btnNextrecord"
        Me.btnNextrecord.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnNextrecord.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnNextrecord.OnHoverForeColor = System.Drawing.Color.White
        Me.btnNextrecord.OnHoverImage = Nothing
        Me.btnNextrecord.OnPressedColor = System.Drawing.Color.Black
        Me.btnNextrecord.Size = New System.Drawing.Size(180, 67)
        Me.btnNextrecord.TabIndex = 37
        Me.btnNextrecord.Text = "NEXT USER"
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
        Me.btnDeleterecord.Location = New System.Drawing.Point(599, 96)
        Me.btnDeleterecord.Name = "btnDeleterecord"
        Me.btnDeleterecord.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDeleterecord.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnDeleterecord.OnHoverForeColor = System.Drawing.Color.White
        Me.btnDeleterecord.OnHoverImage = Nothing
        Me.btnDeleterecord.OnPressedColor = System.Drawing.Color.Black
        Me.btnDeleterecord.Size = New System.Drawing.Size(180, 67)
        Me.btnDeleterecord.TabIndex = 36
        Me.btnDeleterecord.Text = "DELETE USER"
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
        Me.btnSaverecord.Location = New System.Drawing.Point(599, 187)
        Me.btnSaverecord.Name = "btnSaverecord"
        Me.btnSaverecord.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSaverecord.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnSaverecord.OnHoverForeColor = System.Drawing.Color.White
        Me.btnSaverecord.OnHoverImage = Nothing
        Me.btnSaverecord.OnPressedColor = System.Drawing.Color.Black
        Me.btnSaverecord.Size = New System.Drawing.Size(180, 67)
        Me.btnSaverecord.TabIndex = 35
        Me.btnSaverecord.Text = "SAVE USER"
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
        Me.btnAddrecord.Location = New System.Drawing.Point(599, 13)
        Me.btnAddrecord.Name = "btnAddrecord"
        Me.btnAddrecord.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAddrecord.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnAddrecord.OnHoverForeColor = System.Drawing.Color.White
        Me.btnAddrecord.OnHoverImage = Nothing
        Me.btnAddrecord.OnPressedColor = System.Drawing.Color.Black
        Me.btnAddrecord.Size = New System.Drawing.Size(180, 67)
        Me.btnAddrecord.TabIndex = 34
        Me.btnAddrecord.Text = "ADD USER"
        '
        'USER_MANAGEMENT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LawnGreen
        Me.ClientSize = New System.Drawing.Size(885, 510)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCloseForm)
        Me.Controls.Add(Me.btnPreviousrecord)
        Me.Controls.Add(Me.btnNextrecord)
        Me.Controls.Add(Me.btnDeleterecord)
        Me.Controls.Add(Me.btnSaverecord)
        Me.Controls.Add(Me.btnAddrecord)
        Me.Controls.Add(Me.lblAnimaltype)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.lblBirthdate)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.EmailTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "USER_MANAGEMENT"
        Me.Text = "USER_MANAGEMENT"
        CType(Me.Mkulima_digitalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.USERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As ns1.BunifuElipse
    Friend WithEvents USERBindingSource As BindingSource
    Friend WithEvents Mkulima_digitalDataSet As mkulima_digitalDataSet
    Friend WithEvents USERTableAdapter As mkulima_digitalDataSetTableAdapters.USERTableAdapter
    Friend WithEvents TableAdapterManager As mkulima_digitalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents lblAnimaltype As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lblBirthdate As Label
    Friend WithEvents btnCloseForm As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents btnPreviousrecord As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents btnNextrecord As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents btnDeleterecord As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents btnSaverecord As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents btnAddrecord As Guna.UI.WinForms.GunaCircleButton
End Class
