Public Class frmPalindrome
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
    Friend WithEvents lblPalindrome As System.Windows.Forms.Label
    Friend WithEvents cmdAnalyze As System.Windows.Forms.Button
    Friend WithEvents txtPalindrome As System.Windows.Forms.TextBox
    Friend WithEvents cmdClear As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtPalindrome = New System.Windows.Forms.TextBox
        Me.lblPalindrome = New System.Windows.Forms.Label
        Me.cmdAnalyze = New System.Windows.Forms.Button
        Me.cmdClear = New System.Windows.Forms.Button
        Me.cmdExit = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'txtPalindrome
        '
        Me.txtPalindrome.BackColor = System.Drawing.Color.Black
        Me.txtPalindrome.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtPalindrome.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPalindrome.ForeColor = System.Drawing.Color.White
        Me.txtPalindrome.Location = New System.Drawing.Point(8, 32)
        Me.txtPalindrome.MaxLength = 50
        Me.txtPalindrome.Name = "txtPalindrome"
        Me.txtPalindrome.Size = New System.Drawing.Size(408, 30)
        Me.txtPalindrome.TabIndex = 0
        Me.txtPalindrome.Text = ""
        Me.txtPalindrome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPalindrome
        '
        Me.lblPalindrome.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPalindrome.ForeColor = System.Drawing.Color.White
        Me.lblPalindrome.Location = New System.Drawing.Point(8, 136)
        Me.lblPalindrome.Name = "lblPalindrome"
        Me.lblPalindrome.Size = New System.Drawing.Size(408, 40)
        Me.lblPalindrome.TabIndex = 1
        Me.lblPalindrome.Text = "String analysis appears here"
        Me.lblPalindrome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdAnalyze
        '
        Me.cmdAnalyze.BackColor = System.Drawing.Color.RoyalBlue
        Me.cmdAnalyze.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAnalyze.ForeColor = System.Drawing.Color.White
        Me.cmdAnalyze.Location = New System.Drawing.Point(8, 96)
        Me.cmdAnalyze.Name = "cmdAnalyze"
        Me.cmdAnalyze.Size = New System.Drawing.Size(136, 24)
        Me.cmdAnalyze.TabIndex = 2
        Me.cmdAnalyze.Text = "&ANALYZE"
        '
        'cmdClear
        '
        Me.cmdClear.BackColor = System.Drawing.Color.RoyalBlue
        Me.cmdClear.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClear.ForeColor = System.Drawing.Color.White
        Me.cmdClear.Location = New System.Drawing.Point(144, 96)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(136, 24)
        Me.cmdClear.TabIndex = 3
        Me.cmdClear.Text = "&CLEAR"
        '
        'cmdExit
        '
        Me.cmdExit.BackColor = System.Drawing.Color.RoyalBlue
        Me.cmdExit.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.ForeColor = System.Drawing.Color.White
        Me.cmdExit.Location = New System.Drawing.Point(280, 96)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(136, 24)
        Me.cmdExit.TabIndex = 4
        Me.cmdExit.Text = "E&XIT"
        '
        'frmPalindrome
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.DarkBlue
        Me.ClientSize = New System.Drawing.Size(424, 192)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.cmdAnalyze)
        Me.Controls.Add(Me.lblPalindrome)
        Me.Controls.Add(Me.txtPalindrome)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPalindrome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PALINDROME"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub cmdAnalyze_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAnalyze.Click
        Dim intPosition As Integer
        Dim strText As String
        Dim strResult As String
        If (txtPalindrome.Text = "") Then
            MsgBox("You had NOT input a string!!!", MsgBoxStyle.Exclamation, "Palindrome Program")
        Else
            strText = LCase(txtPalindrome.Text) 'converts to lowercase
            While (intPosition <= Len(strText))
                intPosition += 1
                strResult = Mid(strText, intPosition, 1) & strResult
            End While
            If (strResult = strText) Then
                lblPalindrome.Text = "Palindrome"
            Else
                lblPalindrome.Text = "Not A Palindrome"
            End If
        End If
    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        txtPalindrome.Clear()
        txtPalindrome.Focus()
        lblPalindrome.Text = "String analysis appears here"
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Dim reply As DialogResult
        reply = MsgBox("Are you sure you want to exit the Palindrome Program?", MsgBoxStyle.OKCancel + MsgBoxStyle.Question, "Palindrome Program")
        If reply = DialogResult.OK Then
            End
        End If
    End Sub
End Class