<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblSignup = New System.Windows.Forms.LinkLabel()
        Me.BunifuElipse1 = New ns1.BunifuElipse(Me.components)
        Me.Mkulima_digitalDataSet = New MKULIMA_DIGITAL_FARM_SYSTEM.mkulima_digitalDataSet()
        Me.USERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.USERTableAdapter = New MKULIMA_DIGITAL_FARM_SYSTEM.mkulima_digitalDataSetTableAdapters.USERTableAdapter()
        Me.TableAdapterManager = New MKULIMA_DIGITAL_FARM_SYSTEM.mkulima_digitalDataSetTableAdapters.TableAdapterManager()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.GunaCircleButton2 = New Guna.UI.WinForms.GunaCircleButton()
        Me.GunaCircleButton1 = New Guna.UI.WinForms.GunaCircleButton()
        CType(Me.Mkulima_digitalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.USERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(129, 70)
        Me.lblUsername.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(131, 24)
        Me.lblUsername.TabIndex = 2
        Me.lblUsername.Text = "USERNAME:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(129, 116)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "PASSWORD:"
        '
        'lblSignup
        '
        Me.lblSignup.AutoSize = True
        Me.lblSignup.BackColor = System.Drawing.Color.Transparent
        Me.lblSignup.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSignup.LinkColor = System.Drawing.Color.GhostWhite
        Me.lblSignup.Location = New System.Drawing.Point(129, 310)
        Me.lblSignup.Name = "lblSignup"
        Me.lblSignup.Size = New System.Drawing.Size(112, 31)
        Me.lblSignup.TabIndex = 4
        Me.lblSignup.TabStop = True
        Me.lblSignup.Text = "Sign up"
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
        'UsernameTextBox
        '
        Me.UsernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.USERBindingSource, "Username", True))
        Me.UsernameTextBox.Location = New System.Drawing.Point(307, 70)
        Me.UsernameTextBox.Multiline = True
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(246, 24)
        Me.UsernameTextBox.TabIndex = 7
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.USERBindingSource, "Password", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(307, 116)
        Me.PasswordTextBox.Multiline = True
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(120)
        Me.PasswordTextBox.Size = New System.Drawing.Size(246, 24)
        Me.PasswordTextBox.TabIndex = 9
        '
        'GunaCircleButton2
        '
        Me.GunaCircleButton2.AnimationHoverSpeed = 0.07!
        Me.GunaCircleButton2.AnimationSpeed = 0.03!
        Me.GunaCircleButton2.BackColor = System.Drawing.Color.Transparent
        Me.GunaCircleButton2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaCircleButton2.BorderColor = System.Drawing.Color.Black
        Me.GunaCircleButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaCircleButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaCircleButton2.Font = New System.Drawing.Font("Segoe UI", 25.0!, System.Drawing.FontStyle.Bold)
        Me.GunaCircleButton2.ForeColor = System.Drawing.Color.White
        Me.GunaCircleButton2.Image = Nothing
        Me.GunaCircleButton2.ImageSize = New System.Drawing.Size(52, 52)
        Me.GunaCircleButton2.Location = New System.Drawing.Point(398, 205)
        Me.GunaCircleButton2.Name = "GunaCircleButton2"
        Me.GunaCircleButton2.OnHoverBaseColor = System.Drawing.Color.Red
        Me.GunaCircleButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaCircleButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaCircleButton2.OnHoverImage = Nothing
        Me.GunaCircleButton2.OnPressedColor = System.Drawing.Color.Red
        Me.GunaCircleButton2.Size = New System.Drawing.Size(206, 66)
        Me.GunaCircleButton2.TabIndex = 18
        Me.GunaCircleButton2.Text = "QUIT"
        '
        'GunaCircleButton1
        '
        Me.GunaCircleButton1.AnimationHoverSpeed = 0.07!
        Me.GunaCircleButton1.AnimationSpeed = 0.03!
        Me.GunaCircleButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaCircleButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaCircleButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaCircleButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaCircleButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaCircleButton1.Font = New System.Drawing.Font("Segoe UI", 25.0!, System.Drawing.FontStyle.Bold)
        Me.GunaCircleButton1.ForeColor = System.Drawing.Color.White
        Me.GunaCircleButton1.Image = Nothing
        Me.GunaCircleButton1.ImageSize = New System.Drawing.Size(52, 52)
        Me.GunaCircleButton1.Location = New System.Drawing.Point(77, 205)
        Me.GunaCircleButton1.Name = "GunaCircleButton1"
        Me.GunaCircleButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GunaCircleButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaCircleButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaCircleButton1.OnHoverImage = Nothing
        Me.GunaCircleButton1.OnPressedColor = System.Drawing.Color.Lime
        Me.GunaCircleButton1.Size = New System.Drawing.Size(206, 66)
        Me.GunaCircleButton1.TabIndex = 17
        Me.GunaCircleButton1.Text = "LOGIN"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(681, 368)
        Me.Controls.Add(Me.GunaCircleButton2)
        Me.Controls.Add(Me.GunaCircleButton1)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.lblSignup)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblUsername)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LOGIN"
        CType(Me.Mkulima_digitalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.USERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblSignup As System.Windows.Forms.LinkLabel
    Friend WithEvents BunifuElipse1 As ns1.BunifuElipse
    Friend WithEvents USERBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Mkulima_digitalDataSet As MKULIMA_DIGITAL_FARM_SYSTEM.mkulima_digitalDataSet
    Friend WithEvents USERTableAdapter As MKULIMA_DIGITAL_FARM_SYSTEM.mkulima_digitalDataSetTableAdapters.USERTableAdapter
    Friend WithEvents TableAdapterManager As MKULIMA_DIGITAL_FARM_SYSTEM.mkulima_digitalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GunaCircleButton2 As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents GunaCircleButton1 As Guna.UI.WinForms.GunaCircleButton
End Class
