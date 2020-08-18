Public Class frmDecimalConversion
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
    Friend WithEvents txtDecimal As System.Windows.Forms.TextBox
    Friend WithEvents cmdConvert As System.Windows.Forms.Button
    Friend WithEvents lblConversion As System.Windows.Forms.Label
    Friend WithEvents grpNumberSystem As System.Windows.Forms.GroupBox
    Friend WithEvents rdoBinary As System.Windows.Forms.RadioButton
    Friend WithEvents rdoOctal As System.Windows.Forms.RadioButton
    Friend WithEvents rdoHexadecimal As System.Windows.Forms.RadioButton
    Friend WithEvents cmdClear As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents lblDecimal As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtDecimal = New System.Windows.Forms.TextBox
        Me.cmdConvert = New System.Windows.Forms.Button
        Me.lblConversion = New System.Windows.Forms.Label
        Me.grpNumberSystem = New System.Windows.Forms.GroupBox
        Me.rdoHexadecimal = New System.Windows.Forms.RadioButton
        Me.rdoOctal = New System.Windows.Forms.RadioButton
        Me.rdoBinary = New System.Windows.Forms.RadioButton
        Me.cmdClear = New System.Windows.Forms.Button
        Me.cmdExit = New System.Windows.Forms.Button
        Me.lblDecimal = New System.Windows.Forms.Label
        Me.grpNumberSystem.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtDecimal
        '
        Me.txtDecimal.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDecimal.Location = New System.Drawing.Point(104, 16)
        Me.txtDecimal.MaxLength = 10
        Me.txtDecimal.Name = "txtDecimal"
        Me.txtDecimal.Size = New System.Drawing.Size(168, 32)
        Me.txtDecimal.TabIndex = 0
        Me.txtDecimal.Text = ""
        Me.txtDecimal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmdConvert
        '
        Me.cmdConvert.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdConvert.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmdConvert.Location = New System.Drawing.Point(24, 200)
        Me.cmdConvert.Name = "cmdConvert"
        Me.cmdConvert.Size = New System.Drawing.Size(104, 32)
        Me.cmdConvert.TabIndex = 6
        Me.cmdConvert.Text = "&CONVERT"
        '
        'lblConversion
        '
        Me.lblConversion.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConversion.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblConversion.Location = New System.Drawing.Point(24, 248)
        Me.lblConversion.Name = "lblConversion"
        Me.lblConversion.Size = New System.Drawing.Size(328, 24)
        Me.lblConversion.TabIndex = 9
        Me.lblConversion.Text = "Resulting conversion appears here"
        Me.lblConversion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpNumberSystem
        '
        Me.grpNumberSystem.Controls.Add(Me.rdoHexadecimal)
        Me.grpNumberSystem.Controls.Add(Me.rdoOctal)
        Me.grpNumberSystem.Controls.Add(Me.rdoBinary)
        Me.grpNumberSystem.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpNumberSystem.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.grpNumberSystem.Location = New System.Drawing.Point(104, 80)
        Me.grpNumberSystem.Name = "grpNumberSystem"
        Me.grpNumberSystem.Size = New System.Drawing.Size(168, 104)
        Me.grpNumberSystem.TabIndex = 2
        Me.grpNumberSystem.TabStop = False
        Me.grpNumberSystem.Text = "Number System"
        '
        'rdoHexadecimal
        '
        Me.rdoHexadecimal.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoHexadecimal.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rdoHexadecimal.Location = New System.Drawing.Point(16, 72)
        Me.rdoHexadecimal.Name = "rdoHexadecimal"
        Me.rdoHexadecimal.Size = New System.Drawing.Size(144, 24)
        Me.rdoHexadecimal.TabIndex = 5
        Me.rdoHexadecimal.Text = "Hexadecimal"
        '
        'rdoOctal
        '
        Me.rdoOctal.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoOctal.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rdoOctal.Location = New System.Drawing.Point(16, 48)
        Me.rdoOctal.Name = "rdoOctal"
        Me.rdoOctal.Size = New System.Drawing.Size(144, 24)
        Me.rdoOctal.TabIndex = 4
        Me.rdoOctal.Text = "Octal"
        '
        'rdoBinary
        '
        Me.rdoBinary.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoBinary.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rdoBinary.Location = New System.Drawing.Point(16, 24)
        Me.rdoBinary.Name = "rdoBinary"
        Me.rdoBinary.Size = New System.Drawing.Size(144, 24)
        Me.rdoBinary.TabIndex = 3
        Me.rdoBinary.Text = "Binary"
        '
        'cmdClear
        '
        Me.cmdClear.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClear.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmdClear.Location = New System.Drawing.Point(136, 200)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(104, 32)
        Me.cmdClear.TabIndex = 7
        Me.cmdClear.Text = "C&LEAR"
        '
        'cmdExit
        '
        Me.cmdExit.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmdExit.Location = New System.Drawing.Point(248, 200)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(104, 32)
        Me.cmdExit.TabIndex = 8
        Me.cmdExit.Text = "E&XIT"
        '
        'lblDecimal
        '
        Me.lblDecimal.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDecimal.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblDecimal.Location = New System.Drawing.Point(8, 48)
        Me.lblDecimal.Name = "lblDecimal"
        Me.lblDecimal.Size = New System.Drawing.Size(360, 24)
        Me.lblDecimal.TabIndex = 1
        Me.lblDecimal.Text = "Enter a number (between 0 to 2147483647 only)"
        Me.lblDecimal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmDecimalConversion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ClientSize = New System.Drawing.Size(384, 282)
        Me.Controls.Add(Me.lblDecimal)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.grpNumberSystem)
        Me.Controls.Add(Me.lblConversion)
        Me.Controls.Add(Me.cmdConvert)
        Me.Controls.Add(Me.txtDecimal)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDecimalConversion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DECIMAL CONVERSION"
        Me.grpNumberSystem.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub cmdConvert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConvert.Click
        Dim ctr, temp As Integer 'ctr serves as the index counter of array(), while temp serve as the storage of the integer division operation. 
        Dim num, array(32), remainder As String
        ctr = 0
        remainder = 0
        num = Val(txtDecimal.Text)
        lblConversion.Text = ""
        If (rdoBinary.Checked = False) And (rdoOctal.Checked = False) And (rdoHexadecimal.Checked = False) Then
            MsgBox("Please select any Number System!!!", MsgBoxStyle.Exclamation, "Decimal Conversion Program")
            Beep()
        ElseIf (num < 2147483648) Then
            If (rdoBinary.Checked = True) Then
                While (num >= 2)
                    remainder = num Mod 2 'this operation gets the remainder when num is divided by 2
                    array(ctr) = remainder 'the value of remainder is stored in array(ctr)
                    temp = num \ 2 'temp stores the integer division of num divided by 2
                    num = temp 'num is now equal to temp
                    ctr += 1 'increment ctr by 1
                End While
                array(ctr) = num 'After the while statement goes false, then array(maximum index) will store the final value of num  
                While (ctr >= 0) 'This while statement will be performed until the ctr value is not less than 0 
                    lblConversion.Text &= array(ctr) 'Displays the array(ctr) in reverse order from array(highest index) to array(lowest index) 
                    ctr -= 1 'decrement ctr by 1
                End While
            ElseIf (rdoOctal.Checked = True) Then
                While (num >= 8)
                    remainder = num Mod 8
                    array(ctr) = remainder
                    temp = num \ 8
                    num = temp
                    ctr += 1
                End While
                array(ctr) = num
                While (ctr >= 0)
                    lblConversion.Text &= array(ctr)
                    ctr -= 1
                End While
            ElseIf (rdoHexadecimal.Checked = True) Then
                While (num >= 16)
                    remainder = num Mod 16
                    If (remainder = 10) Then
                        remainder = "A"
                    ElseIf (remainder = 11) Then
                        remainder = "B"
                    ElseIf (remainder = 12) Then
                        remainder = "C"
                    ElseIf (remainder = 13) Then
                        remainder = "D"
                    ElseIf (remainder = 14) Then
                        remainder = "E"
                    ElseIf (remainder = 15) Then
                        remainder = "F"
                    End If
                    array(ctr) = remainder
                    temp = num \ 16
                    num = temp
                    ctr += 1
                End While
                If (num = 10) Then
                    num = "A"
                ElseIf (num = 11) Then
                    num = "B"
                ElseIf (num = 12) Then
                    num = "C"
                ElseIf (num = 13) Then
                    num = "D"
                ElseIf (num = 14) Then
                    num = "E"
                ElseIf (num = 15) Then
                    num = "F"
                End If
                array(ctr) = num
                While (ctr >= 0)
                    lblConversion.Text &= array(ctr)
                    ctr -= 1
                End While
            End If
        Else
            MsgBox("Value is out of reach.", MsgBoxStyle.Exclamation, "Decimal Conversion Program")
            Beep()
        End If
    End Sub

    Private Sub txtDecimal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDecimal.TextChanged
        If (IsNumeric(txtDecimal.Text) = True) Then
        Else
            txtDecimal.Clear()
        End If
    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        txtDecimal.Clear()
        txtDecimal.Focus()
        lblConversion.Text = "Resulting conversion appears here"
        rdoBinary.Checked = False
        rdoOctal.Checked = False
        rdoHexadecimal.Checked = False
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Dim reply As DialogResult
        reply = MsgBox("Are you sure you want to exit the Decimal Conversion Program?", MsgBoxStyle.OKCancel + MsgBoxStyle.Question, "Decimal Conversion Program")
        If reply = DialogResult.OK Then
            End
        End If
    End Sub
End Class