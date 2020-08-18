Public Class frmFlames
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtMale As System.Windows.Forms.TextBox
    Friend WithEvents txtFemale As System.Windows.Forms.TextBox
    Friend WithEvents cmdAnalyze As System.Windows.Forms.Button
    Friend WithEvents lblFlames As System.Windows.Forms.Label
    Friend WithEvents cmdClear As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtFemale = New System.Windows.Forms.TextBox()
        Me.txtMale = New System.Windows.Forms.TextBox()
        Me.cmdAnalyze = New System.Windows.Forms.Button()
        Me.lblFlames = New System.Windows.Forms.Label()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtFemale)
        Me.GroupBox1.Controls.Add(Me.txtMale)
        Me.GroupBox1.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Yellow
        Me.GroupBox1.Location = New System.Drawing.Point(16, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(384, 128)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Soul Mates"
        '
        'txtFemale
        '
        Me.txtFemale.Location = New System.Drawing.Point(32, 80)
        Me.txtFemale.MaxLength = 50
        Me.txtFemale.Name = "txtFemale"
        Me.txtFemale.Size = New System.Drawing.Size(320, 30)
        Me.txtFemale.TabIndex = 1
        Me.txtFemale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMale
        '
        Me.txtMale.Location = New System.Drawing.Point(32, 40)
        Me.txtMale.MaxLength = 50
        Me.txtMale.Name = "txtMale"
        Me.txtMale.Size = New System.Drawing.Size(320, 30)
        Me.txtMale.TabIndex = 0
        Me.txtMale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmdAnalyze
        '
        Me.cmdAnalyze.BackColor = System.Drawing.Color.DimGray
        Me.cmdAnalyze.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAnalyze.ForeColor = System.Drawing.Color.Yellow
        Me.cmdAnalyze.Location = New System.Drawing.Point(16, 208)
        Me.cmdAnalyze.Name = "cmdAnalyze"
        Me.cmdAnalyze.Size = New System.Drawing.Size(104, 32)
        Me.cmdAnalyze.TabIndex = 2
        Me.cmdAnalyze.Text = "&ANALYZE"
        Me.cmdAnalyze.UseVisualStyleBackColor = False
        '
        'lblFlames
        '
        Me.lblFlames.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFlames.ForeColor = System.Drawing.Color.Yellow
        Me.lblFlames.Location = New System.Drawing.Point(16, 160)
        Me.lblFlames.Name = "lblFlames"
        Me.lblFlames.Size = New System.Drawing.Size(384, 32)
        Me.lblFlames.TabIndex = 2
        Me.lblFlames.Text = "Result appears here"
        Me.lblFlames.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdClear
        '
        Me.cmdClear.BackColor = System.Drawing.Color.DimGray
        Me.cmdClear.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClear.ForeColor = System.Drawing.Color.Yellow
        Me.cmdClear.Location = New System.Drawing.Point(160, 208)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(104, 32)
        Me.cmdClear.TabIndex = 3
        Me.cmdClear.Text = "&CLEAR"
        Me.cmdClear.UseVisualStyleBackColor = False
        '
        'cmdExit
        '
        Me.cmdExit.BackColor = System.Drawing.Color.DimGray
        Me.cmdExit.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.ForeColor = System.Drawing.Color.Yellow
        Me.cmdExit.Location = New System.Drawing.Point(296, 208)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(104, 32)
        Me.cmdExit.TabIndex = 4
        Me.cmdExit.Text = "E&XIT"
        Me.cmdExit.UseVisualStyleBackColor = False
        '
        'frmFlames
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.DarkRed
        Me.ClientSize = New System.Drawing.Size(419, 262)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.lblFlames)
        Me.Controls.Add(Me.cmdAnalyze)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmFlames"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FLAMES"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub cmdAnalyze_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAnalyze.Click
        Dim Male, Female As String
        Dim x, y, points, flames As Integer
        Male = LCase(Trim(txtMale.Text))
        Female = LCase(Trim(txtFemale.Text))
        For x = 0 To (Len(Male) - 1)
            For y = 0 To (Len(Female) - 1)
                If (Male.Substring(x, 1) = Female.Substring(y, 1)) Then
                    points += 1
                    Exit For
                End If
            Next
        Next
        If (txtMale.Text = "") Or (txtFemale.Text = "") Then
            MsgBox("Please enter a name on both soulmates!!!", MsgBoxStyle.Exclamation, "Flames Program")
        Else
            flames = points Mod 6
            Select Case (flames)
                Case 1 : lblFlames.Text = "Friends"
                Case 2 : lblFlames.Text = "Lovers"
                Case 3 : lblFlames.Text = "Anger"
                Case 4 : lblFlames.Text = "Married"
                Case 5 : lblFlames.Text = "Engaged"
                Case 0 : lblFlames.Text = "Sweethearts"
            End Select
        End If
    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        txtMale.Clear()
        txtFemale.Clear()
        lblFlames.Text = "Result appears here"
        txtMale.Focus()
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Dim reply As DialogResult
        reply = MsgBox("Are you sure you want to exit the Flames Program?", MsgBoxStyle.OKCancel + MsgBoxStyle.Question, "Flames Program")
        If reply = DialogResult.OK Then
            End
        End If
    End Sub
End Class
