Public Class frmCelsiusConversion
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents txtCelsius As System.Windows.Forms.TextBox
    Friend WithEvents grpTemperatures As System.Windows.Forms.GroupBox
    Friend WithEvents rdoFahrenheit As System.Windows.Forms.RadioButton
    Friend WithEvents rdoKelvin As System.Windows.Forms.RadioButton
    Friend WithEvents lblCelsius As System.Windows.Forms.Label
    Friend WithEvents txtTemperature As System.Windows.Forms.TextBox
    Friend WithEvents lblTemperature As System.Windows.Forms.Label
    Friend WithEvents cmdConvert As System.Windows.Forms.Button
    Friend WithEvents cmdReset As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtCelsius = New System.Windows.Forms.TextBox
        Me.lblCelsius = New System.Windows.Forms.Label
        Me.grpTemperatures = New System.Windows.Forms.GroupBox
        Me.rdoKelvin = New System.Windows.Forms.RadioButton
        Me.rdoFahrenheit = New System.Windows.Forms.RadioButton
        Me.txtTemperature = New System.Windows.Forms.TextBox
        Me.lblTemperature = New System.Windows.Forms.Label
        Me.cmdConvert = New System.Windows.Forms.Button
        Me.cmdReset = New System.Windows.Forms.Button
        Me.cmdExit = New System.Windows.Forms.Button
        Me.grpTemperatures.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCelsius
        '
        Me.txtCelsius.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCelsius.Location = New System.Drawing.Point(64, 16)
        Me.txtCelsius.MaxLength = 15
        Me.txtCelsius.Name = "txtCelsius"
        Me.txtCelsius.Size = New System.Drawing.Size(200, 27)
        Me.txtCelsius.TabIndex = 0
        Me.txtCelsius.Text = ""
        Me.txtCelsius.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCelsius
        '
        Me.lblCelsius.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCelsius.ForeColor = System.Drawing.Color.Yellow
        Me.lblCelsius.Location = New System.Drawing.Point(56, 48)
        Me.lblCelsius.Name = "lblCelsius"
        Me.lblCelsius.Size = New System.Drawing.Size(216, 24)
        Me.lblCelsius.TabIndex = 1
        Me.lblCelsius.Text = "Enter number in Celsius:"
        Me.lblCelsius.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpTemperatures
        '
        Me.grpTemperatures.Controls.Add(Me.rdoKelvin)
        Me.grpTemperatures.Controls.Add(Me.rdoFahrenheit)
        Me.grpTemperatures.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpTemperatures.ForeColor = System.Drawing.Color.Yellow
        Me.grpTemperatures.Location = New System.Drawing.Point(24, 80)
        Me.grpTemperatures.Name = "grpTemperatures"
        Me.grpTemperatures.Size = New System.Drawing.Size(160, 96)
        Me.grpTemperatures.TabIndex = 2
        Me.grpTemperatures.TabStop = False
        Me.grpTemperatures.Text = "Temperatures"
        '
        'rdoKelvin
        '
        Me.rdoKelvin.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoKelvin.ForeColor = System.Drawing.Color.Yellow
        Me.rdoKelvin.Location = New System.Drawing.Point(16, 64)
        Me.rdoKelvin.Name = "rdoKelvin"
        Me.rdoKelvin.Size = New System.Drawing.Size(128, 16)
        Me.rdoKelvin.TabIndex = 4
        Me.rdoKelvin.Text = "Kelvin"
        '
        'rdoFahrenheit
        '
        Me.rdoFahrenheit.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoFahrenheit.ForeColor = System.Drawing.Color.Yellow
        Me.rdoFahrenheit.Location = New System.Drawing.Point(16, 24)
        Me.rdoFahrenheit.Name = "rdoFahrenheit"
        Me.rdoFahrenheit.Size = New System.Drawing.Size(128, 24)
        Me.rdoFahrenheit.TabIndex = 3
        Me.rdoFahrenheit.Text = "Fahrenheit"
        '
        'txtTemperature
        '
        Me.txtTemperature.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTemperature.Location = New System.Drawing.Point(64, 200)
        Me.txtTemperature.Name = "txtTemperature"
        Me.txtTemperature.ReadOnly = True
        Me.txtTemperature.Size = New System.Drawing.Size(200, 27)
        Me.txtTemperature.TabIndex = 8
        Me.txtTemperature.Text = ""
        Me.txtTemperature.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTemperature
        '
        Me.lblTemperature.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTemperature.ForeColor = System.Drawing.Color.Yellow
        Me.lblTemperature.Location = New System.Drawing.Point(32, 232)
        Me.lblTemperature.Name = "lblTemperature"
        Me.lblTemperature.Size = New System.Drawing.Size(264, 24)
        Me.lblTemperature.TabIndex = 9
        Me.lblTemperature.Text = "Result appears here"
        Me.lblTemperature.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdConvert
        '
        Me.cmdConvert.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdConvert.ForeColor = System.Drawing.Color.Yellow
        Me.cmdConvert.Location = New System.Drawing.Point(208, 88)
        Me.cmdConvert.Name = "cmdConvert"
        Me.cmdConvert.Size = New System.Drawing.Size(88, 24)
        Me.cmdConvert.TabIndex = 5
        Me.cmdConvert.Text = "&CONVERT"
        '
        'cmdReset
        '
        Me.cmdReset.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReset.ForeColor = System.Drawing.Color.Yellow
        Me.cmdReset.Location = New System.Drawing.Point(208, 120)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(88, 24)
        Me.cmdReset.TabIndex = 6
        Me.cmdReset.Text = "&RESET"
        '
        'cmdExit
        '
        Me.cmdExit.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.ForeColor = System.Drawing.Color.Yellow
        Me.cmdExit.Location = New System.Drawing.Point(208, 152)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(88, 24)
        Me.cmdExit.TabIndex = 7
        Me.cmdExit.Text = "E&XIT"
        '
        'frmCelsiusConversion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(324, 266)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdReset)
        Me.Controls.Add(Me.cmdConvert)
        Me.Controls.Add(Me.lblTemperature)
        Me.Controls.Add(Me.txtTemperature)
        Me.Controls.Add(Me.grpTemperatures)
        Me.Controls.Add(Me.lblCelsius)
        Me.Controls.Add(Me.txtCelsius)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCelsiusConversion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CELSIUS CONVERSION"
        Me.grpTemperatures.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub txtCelsius_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCelsius.TextChanged
        If (IsNumeric(txtCelsius.Text) = True) Then
        Else
            txtCelsius.Text = ""
        End If
    End Sub

    Private Sub cmdConvert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConvert.Click
        Dim Celsius, Fahrenheit, Kelvin As Decimal
        Celsius = Val(txtCelsius.Text)
        If (rdoFahrenheit.Checked = False And rdoKelvin.Checked = False) Then
            MsgBox("Please choose a unit of temperature (either Fahrenheit or Kelvin) )in the group box!!!", MsgBoxStyle.Exclamation, "Celsius Conversion Program")
            Beep()
        ElseIf (rdoFahrenheit.Checked = True) Then
            Fahrenheit = (Celsius * 9) / 5 + 32
            txtTemperature.Text = Fahrenheit
            lblTemperature.Text = "Result in Fahrenheit"
        ElseIf (rdoKelvin.Checked = True) Then
            Kelvin = Celsius + 273.15
            txtTemperature.Text = Kelvin
            lblTemperature.Text = "Result in Kelvin"
        End If
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Dim reply As DialogResult
        reply = MsgBox("Are you sure you want to exit the Celsius Conversion Program?", MsgBoxStyle.OKCancel + MsgBoxStyle.Question, "Celsius Conversion Program")
        If reply = DialogResult.OK Then
            End
        End If
    End Sub

    Private Sub cmdReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReset.Click
        txtCelsius.Text = ""
        rdoFahrenheit.Checked = False
        rdoKelvin.Checked = False
        txtTemperature.Text = ""
        lblTemperature.Text = "Result appears here"
    End Sub
End Class
