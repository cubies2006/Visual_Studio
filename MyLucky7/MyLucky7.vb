Public Class frmLucky7
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
    Friend WithEvents cmdSpin As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents lblSeven1 As System.Windows.Forms.Label
    Friend WithEvents lblSeven2 As System.Windows.Forms.Label
    Friend WithEvents lblSeven3 As System.Windows.Forms.Label
    Friend WithEvents lblLucky7 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lblSeven1 = New System.Windows.Forms.Label
        Me.lblSeven2 = New System.Windows.Forms.Label
        Me.lblSeven3 = New System.Windows.Forms.Label
        Me.cmdSpin = New System.Windows.Forms.Button
        Me.cmdExit = New System.Windows.Forms.Button
        Me.lblLucky7 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lblSeven1
        '
        Me.lblSeven1.Font = New System.Drawing.Font("Transformers Movie", 71.99999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeven1.ForeColor = System.Drawing.Color.Yellow
        Me.lblSeven1.Location = New System.Drawing.Point(72, 56)
        Me.lblSeven1.Name = "lblSeven1"
        Me.lblSeven1.Size = New System.Drawing.Size(100, 112)
        Me.lblSeven1.TabIndex = 0
        Me.lblSeven1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSeven2
        '
        Me.lblSeven2.Font = New System.Drawing.Font("Transformers Movie", 71.99999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeven2.ForeColor = System.Drawing.Color.ForestGreen
        Me.lblSeven2.Location = New System.Drawing.Point(192, 56)
        Me.lblSeven2.Name = "lblSeven2"
        Me.lblSeven2.Size = New System.Drawing.Size(100, 112)
        Me.lblSeven2.TabIndex = 1
        Me.lblSeven2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSeven3
        '
        Me.lblSeven3.Font = New System.Drawing.Font("Transformers Movie", 71.99999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeven3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblSeven3.Location = New System.Drawing.Point(312, 56)
        Me.lblSeven3.Name = "lblSeven3"
        Me.lblSeven3.Size = New System.Drawing.Size(100, 112)
        Me.lblSeven3.TabIndex = 2
        Me.lblSeven3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdSpin
        '
        Me.cmdSpin.BackColor = System.Drawing.Color.RoyalBlue
        Me.cmdSpin.Font = New System.Drawing.Font("Transformers Movie", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSpin.Location = New System.Drawing.Point(144, 184)
        Me.cmdSpin.Name = "cmdSpin"
        Me.cmdSpin.Size = New System.Drawing.Size(80, 32)
        Me.cmdSpin.TabIndex = 1
        Me.cmdSpin.Text = "&SPIN"
        '
        'cmdExit
        '
        Me.cmdExit.BackColor = System.Drawing.Color.Wheat
        Me.cmdExit.Font = New System.Drawing.Font("Transformers Movie", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.Location = New System.Drawing.Point(264, 184)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(80, 32)
        Me.cmdExit.TabIndex = 2
        Me.cmdExit.Text = "&END"
        '
        'lblLucky7
        '
        Me.lblLucky7.Font = New System.Drawing.Font("Transformers Movie", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLucky7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblLucky7.Location = New System.Drawing.Point(72, 232)
        Me.lblLucky7.Name = "lblLucky7"
        Me.lblLucky7.Size = New System.Drawing.Size(344, 48)
        Me.lblLucky7.TabIndex = 5
        Me.lblLucky7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmLucky7
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(484, 312)
        Me.Controls.Add(Me.lblLucky7)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdSpin)
        Me.Controls.Add(Me.lblSeven3)
        Me.Controls.Add(Me.lblSeven2)
        Me.Controls.Add(Me.lblSeven1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLucky7"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LUCKY 7 PROGRAM"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Dim reply As DialogResult
        reply = MsgBox("Are you sure you want to exit the My Lucky 7 Program?", MsgBoxStyle.OKCancel + MsgBoxStyle.Question, "My Lucky 7 Program")
        If reply = DialogResult.OK Then
            End
        End If
    End Sub

    Private Sub cmdSpin_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSpin.Click
        lblSeven1.Text = CStr(Int(Rnd() * 10)) ' pick numbers
        lblSeven2.Text = CStr(Int(Rnd() * 10))
        lblSeven3.Text = CStr(Int(Rnd() * 10))
        ' if any number is 7 display picture and beep
        If (lblSeven1.Text = "7") Or (lblSeven2.Text = "7") Or (lblSeven3.Text = "7") Then
            lblLucky7.Text = "Lucky Seven"
            Beep()
        Else
            lblLucky7.Text = "Try Again"
        End If
    End Sub
	
    Private Sub cmdSpin_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSpin.MouseHover
        cmdSpin.BackColor = Color.SlateBlue
    End Sub

    Private Sub cmdSpin_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmdSpin.MouseMove
        cmdSpin.BackColor = Color.RoyalBlue
    End Sub

    Private Sub cmdExit_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdExit.MouseHover
        cmdExit.BackColor = Color.LemonChiffon
    End Sub

    Private Sub cmdExit_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmdExit.MouseMove
        cmdExit.BackColor = Color.Wheat
    End Sub
End Class