Public Class frmTransmutationGrade
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
    Friend WithEvents lblGrade As System.Windows.Forms.Label
    Friend WithEvents grpTransmutationGrade As System.Windows.Forms.GroupBox
    Friend WithEvents lblTransmutationGrade As System.Windows.Forms.Label
    Friend WithEvents cmdConvert As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents txtGrade As System.Windows.Forms.TextBox
    Friend WithEvents cmdClear As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtGrade = New System.Windows.Forms.TextBox
        Me.lblGrade = New System.Windows.Forms.Label
        Me.grpTransmutationGrade = New System.Windows.Forms.GroupBox
        Me.lblTransmutationGrade = New System.Windows.Forms.Label
        Me.cmdConvert = New System.Windows.Forms.Button
        Me.cmdExit = New System.Windows.Forms.Button
        Me.cmdClear = New System.Windows.Forms.Button
        Me.grpTransmutationGrade.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtGrade
        '
        Me.txtGrade.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrade.Location = New System.Drawing.Point(160, 16)
        Me.txtGrade.MaxLength = 3
        Me.txtGrade.Name = "txtGrade"
        Me.txtGrade.Size = New System.Drawing.Size(112, 26)
        Me.txtGrade.TabIndex = 0
        Me.txtGrade.Text = ""
        Me.txtGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblGrade
        '
        Me.lblGrade.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrade.ForeColor = System.Drawing.SystemColors.Control
        Me.lblGrade.Location = New System.Drawing.Point(96, 48)
        Me.lblGrade.Name = "lblGrade"
        Me.lblGrade.Size = New System.Drawing.Size(232, 24)
        Me.lblGrade.TabIndex = 1
        Me.lblGrade.Text = "Enter a Grade (0 - 100 only)"
        Me.lblGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpTransmutationGrade
        '
        Me.grpTransmutationGrade.Controls.Add(Me.lblTransmutationGrade)
        Me.grpTransmutationGrade.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpTransmutationGrade.ForeColor = System.Drawing.SystemColors.Control
        Me.grpTransmutationGrade.Location = New System.Drawing.Point(16, 96)
        Me.grpTransmutationGrade.Name = "grpTransmutationGrade"
        Me.grpTransmutationGrade.Size = New System.Drawing.Size(392, 56)
        Me.grpTransmutationGrade.TabIndex = 2
        Me.grpTransmutationGrade.TabStop = False
        Me.grpTransmutationGrade.Text = "Equivalent Transmutation Grade"
        '
        'lblTransmutationGrade
        '
        Me.lblTransmutationGrade.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransmutationGrade.ForeColor = System.Drawing.SystemColors.Control
        Me.lblTransmutationGrade.Location = New System.Drawing.Point(16, 16)
        Me.lblTransmutationGrade.Name = "lblTransmutationGrade"
        Me.lblTransmutationGrade.Size = New System.Drawing.Size(368, 32)
        Me.lblTransmutationGrade.TabIndex = 0
        Me.lblTransmutationGrade.Text = "Equivalent Transmutation Grade appears here"
        Me.lblTransmutationGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdConvert
        '
        Me.cmdConvert.BackColor = System.Drawing.Color.DarkOrange
        Me.cmdConvert.Font = New System.Drawing.Font("London Olympics 2012", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdConvert.Location = New System.Drawing.Point(16, 168)
        Me.cmdConvert.Name = "cmdConvert"
        Me.cmdConvert.Size = New System.Drawing.Size(120, 32)
        Me.cmdConvert.TabIndex = 3
        Me.cmdConvert.Text = "&CONVERT"
        '
        'cmdExit
        '
        Me.cmdExit.BackColor = System.Drawing.Color.LightGreen
        Me.cmdExit.Font = New System.Drawing.Font("London Olympics 2012", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.Location = New System.Drawing.Point(288, 168)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(120, 32)
        Me.cmdExit.TabIndex = 4
        Me.cmdExit.Text = "E&XIT"
        '
        'cmdClear
        '
        Me.cmdClear.BackColor = System.Drawing.Color.Chartreuse
        Me.cmdClear.Font = New System.Drawing.Font("London Olympics 2012", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClear.Location = New System.Drawing.Point(152, 168)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(120, 32)
        Me.cmdClear.TabIndex = 5
        Me.cmdClear.Text = "C&LEAR"
        '
        'frmTransmutationGrade
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Purple
        Me.ClientSize = New System.Drawing.Size(424, 217)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdConvert)
        Me.Controls.Add(Me.grpTransmutationGrade)
        Me.Controls.Add(Me.lblGrade)
        Me.Controls.Add(Me.txtGrade)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTransmutationGrade"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TRANSMUTATION GRADE"
        Me.grpTransmutationGrade.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Dim reply As DialogResult
        reply = MsgBox("Are you sure you want to exit the Transmutation Grade Program?", MsgBoxStyle.OKCancel + MsgBoxStyle.Question, "Transmutation Grade Program")
        If reply = DialogResult.OK Then
            End
        End If
    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        txtGrade.Clear()
        txtGrade.Focus()
        lblTransmutationGrade.Text = "Equivalent Transmutation Grade appears here"
    End Sub

    Private Sub cmdConvert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConvert.Click
        Dim grade As Integer
        grade = Val(txtGrade.Text)
        If (grade > 100) Then
            MsgBox("Invalid Grade!!!", MsgBoxStyle.Critical, "Transmutation Grade Program")
            Beep()
            lblTransmutationGrade.Text = "Equivalent Transmutation Grade appears here"
        ElseIf (grade >= 96) And (grade <= 100) Then
            lblTransmutationGrade.Text = "1.00"
        ElseIf (grade >= 92) And (grade <= 95) Then
            lblTransmutationGrade.Text = "1.25"
        ElseIf (grade >= 90) And (grade <= 93) Then
            lblTransmutationGrade.Text = "1.50"
        ElseIf (grade >= 87) And (grade <= 91) Then
            lblTransmutationGrade.Text = "1.75"
        ElseIf (grade >= 85) And (grade <= 88) Then
            lblTransmutationGrade.Text = "2.00"
        ElseIf (grade >= 82) And (grade <= 86) Then
            lblTransmutationGrade.Text = "2.25"
        ElseIf (grade >= 80) And (grade <= 83) Then
            lblTransmutationGrade.Text = "2.50"
        ElseIf (grade >= 77) And (grade <= 81) Then
            lblTransmutationGrade.Text = "2.75"
        ElseIf (grade >= 75) And (grade <= 78) Then
            lblTransmutationGrade.Text = "3.00"
        ElseIf (grade < 75) Then
            lblTransmutationGrade.Text = "5.00"
        End If
    End Sub

    Private Sub txtGrade_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGrade.TextChanged
        If IsNumeric(txtGrade.Text) = True Then
        Else
            txtGrade.Clear()
        End If
    End Sub
End Class