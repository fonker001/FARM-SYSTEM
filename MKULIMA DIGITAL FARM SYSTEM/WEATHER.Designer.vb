<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WEATHER
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
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.WeatherLabel = New System.Windows.Forms.Label()
        Me.FetchWeatherButton = New Guna.UI.WinForms.GunaCircleButton()
        Me.GunaLinePanel1 = New Guna.UI.WinForms.GunaLinePanel()
        Me.btnCloseForm = New Guna.UI.WinForms.GunaCircleButton()
        Me.GunaLinePanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 50
        Me.BunifuElipse1.TargetControl = Me
        '
        'CityTextBox
        '
        Me.CityTextBox.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CityTextBox.Location = New System.Drawing.Point(283, 68)
        Me.CityTextBox.Multiline = True
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(244, 38)
        Me.CityTextBox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Black", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(78, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 37)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CITY NAME"
        '
        'WeatherLabel
        '
        Me.WeatherLabel.AutoSize = True
        Me.WeatherLabel.Font = New System.Drawing.Font("Segoe UI Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WeatherLabel.Location = New System.Drawing.Point(27, 22)
        Me.WeatherLabel.Name = "WeatherLabel"
        Me.WeatherLabel.Size = New System.Drawing.Size(0, 37)
        Me.WeatherLabel.TabIndex = 2
        '
        'FetchWeatherButton
        '
        Me.FetchWeatherButton.AnimationHoverSpeed = 0.07!
        Me.FetchWeatherButton.AnimationSpeed = 0.03!
        Me.FetchWeatherButton.BackColor = System.Drawing.Color.Transparent
        Me.FetchWeatherButton.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FetchWeatherButton.BorderColor = System.Drawing.Color.Black
        Me.FetchWeatherButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.FetchWeatherButton.FocusedColor = System.Drawing.Color.Empty
        Me.FetchWeatherButton.Font = New System.Drawing.Font("Segoe UI Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FetchWeatherButton.ForeColor = System.Drawing.Color.White
        Me.FetchWeatherButton.Image = Nothing
        Me.FetchWeatherButton.ImageSize = New System.Drawing.Size(52, 52)
        Me.FetchWeatherButton.Location = New System.Drawing.Point(139, 155)
        Me.FetchWeatherButton.Name = "FetchWeatherButton"
        Me.FetchWeatherButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FetchWeatherButton.OnHoverBorderColor = System.Drawing.Color.Black
        Me.FetchWeatherButton.OnHoverForeColor = System.Drawing.Color.White
        Me.FetchWeatherButton.OnHoverImage = Nothing
        Me.FetchWeatherButton.OnPressedColor = System.Drawing.Color.Black
        Me.FetchWeatherButton.Size = New System.Drawing.Size(287, 80)
        Me.FetchWeatherButton.TabIndex = 4
        Me.FetchWeatherButton.Text = "CHECK WEATHER"
        '
        'GunaLinePanel1
        '
        Me.GunaLinePanel1.Controls.Add(Me.WeatherLabel)
        Me.GunaLinePanel1.LineColor = System.Drawing.Color.Black
        Me.GunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaLinePanel1.Location = New System.Drawing.Point(23, 288)
        Me.GunaLinePanel1.Name = "GunaLinePanel1"
        Me.GunaLinePanel1.Size = New System.Drawing.Size(801, 108)
        Me.GunaLinePanel1.TabIndex = 5
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
        Me.btnCloseForm.Location = New System.Drawing.Point(405, 429)
        Me.btnCloseForm.Name = "btnCloseForm"
        Me.btnCloseForm.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCloseForm.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnCloseForm.OnHoverForeColor = System.Drawing.Color.White
        Me.btnCloseForm.OnHoverImage = Nothing
        Me.btnCloseForm.OnPressedColor = System.Drawing.Color.Black
        Me.btnCloseForm.Size = New System.Drawing.Size(180, 67)
        Me.btnCloseForm.TabIndex = 11
        Me.btnCloseForm.Text = "CLOSE"
        '
        'WEATHER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.ClientSize = New System.Drawing.Size(850, 508)
        Me.Controls.Add(Me.btnCloseForm)
        Me.Controls.Add(Me.GunaLinePanel1)
        Me.Controls.Add(Me.FetchWeatherButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CityTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "WEATHER"
        Me.Text = "WEATHER"
        Me.GunaLinePanel1.ResumeLayout(False)
        Me.GunaLinePanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BunifuElipse1 As ns1.BunifuElipse
    Friend WithEvents WeatherLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FetchWeatherButton As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents GunaLinePanel1 As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents btnCloseForm As Guna.UI.WinForms.GunaCircleButton
End Class
