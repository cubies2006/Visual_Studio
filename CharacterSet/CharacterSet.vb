Public Class frmCharacterSet
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
    Friend WithEvents grpString As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblVowel As System.Windows.Forms.Label
    Friend WithEvents lblConsonant As System.Windows.Forms.Label
    Friend WithEvents lblDigit As System.Windows.Forms.Label
    Friend WithEvents lblSpecial As System.Windows.Forms.Label
    Friend WithEvents txtVowel As System.Windows.Forms.TextBox
    Friend WithEvents txtConsonant As System.Windows.Forms.TextBox
    Friend WithEvents txtDigit As System.Windows.Forms.TextBox
    Friend WithEvents txtSpecial As System.Windows.Forms.TextBox
    Friend WithEvents cmdAnalyze As System.Windows.Forms.Button
    Friend WithEvents txtString As System.Windows.Forms.TextBox
    Friend WithEvents cmdClear As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.grpString = New System.Windows.Forms.GroupBox
        Me.txtString = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtSpecial = New System.Windows.Forms.TextBox
        Me.txtDigit = New System.Windows.Forms.TextBox
        Me.txtConsonant = New System.Windows.Forms.TextBox
        Me.txtVowel = New System.Windows.Forms.TextBox
        Me.lblSpecial = New System.Windows.Forms.Label
        Me.lblDigit = New System.Windows.Forms.Label
        Me.lblConsonant = New System.Windows.Forms.Label
        Me.lblVowel = New System.Windows.Forms.Label
        Me.cmdAnalyze = New System.Windows.Forms.Button
        Me.cmdClear = New System.Windows.Forms.Button
        Me.cmdExit = New System.Windows.Forms.Button
        Me.grpString.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpString
        '
        Me.grpString.Controls.Add(Me.txtString)
        Me.grpString.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpString.ForeColor = System.Drawing.Color.MediumBlue
        Me.grpString.Location = New System.Drawing.Point(8, 8)
        Me.grpString.Name = "grpString"
        Me.grpString.Size = New System.Drawing.Size(856, 64)
        Me.grpString.TabIndex = 0
        Me.grpString.TabStop = False
        Me.grpString.Text = "Enter a string here"
        '
        'txtString
        '
        Me.txtString.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtString.ForeColor = System.Drawing.Color.MediumBlue
        Me.txtString.Location = New System.Drawing.Point(16, 24)
        Me.txtString.MaxLength = 100
        Me.txtString.Name = "txtString"
        Me.txtString.Size = New System.Drawing.Size(824, 25)
        Me.txtString.TabIndex = 0
        Me.txtString.Text = ""
        Me.txtString.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtSpecial)
        Me.GroupBox1.Controls.Add(Me.txtDigit)
        Me.GroupBox1.Controls.Add(Me.txtConsonant)
        Me.GroupBox1.Controls.Add(Me.txtVowel)
        Me.GroupBox1.Controls.Add(Me.lblSpecial)
        Me.GroupBox1.Controls.Add(Me.lblDigit)
        Me.GroupBox1.Controls.Add(Me.lblConsonant)
        Me.GroupBox1.Controls.Add(Me.lblVowel)
        Me.GroupBox1.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.MediumBlue
        Me.GroupBox1.Location = New System.Drawing.Point(200, 80)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(336, 144)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Character Set"
        '
        'txtSpecial
        '
        Me.txtSpecial.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSpecial.ForeColor = System.Drawing.Color.MediumBlue
        Me.txtSpecial.Location = New System.Drawing.Point(232, 96)
        Me.txtSpecial.MaxLength = 100
        Me.txtSpecial.Name = "txtSpecial"
        Me.txtSpecial.ReadOnly = True
        Me.txtSpecial.Size = New System.Drawing.Size(80, 25)
        Me.txtSpecial.TabIndex = 7
        Me.txtSpecial.Text = ""
        '
        'txtDigit
        '
        Me.txtDigit.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDigit.ForeColor = System.Drawing.Color.MediumBlue
        Me.txtDigit.Location = New System.Drawing.Point(232, 72)
        Me.txtDigit.MaxLength = 100
        Me.txtDigit.Name = "txtDigit"
        Me.txtDigit.ReadOnly = True
        Me.txtDigit.Size = New System.Drawing.Size(80, 25)
        Me.txtDigit.TabIndex = 6
        Me.txtDigit.Text = ""
        '
        'txtConsonant
        '
        Me.txtConsonant.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConsonant.ForeColor = System.Drawing.Color.MediumBlue
        Me.txtConsonant.Location = New System.Drawing.Point(232, 48)
        Me.txtConsonant.MaxLength = 100
        Me.txtConsonant.Name = "txtConsonant"
        Me.txtConsonant.ReadOnly = True
        Me.txtConsonant.Size = New System.Drawing.Size(80, 25)
        Me.txtConsonant.TabIndex = 5
        Me.txtConsonant.Text = ""
        '
        'txtVowel
        '
        Me.txtVowel.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVowel.ForeColor = System.Drawing.Color.MediumBlue
        Me.txtVowel.Location = New System.Drawing.Point(232, 24)
        Me.txtVowel.MaxLength = 100
        Me.txtVowel.Name = "txtVowel"
        Me.txtVowel.ReadOnly = True
        Me.txtVowel.Size = New System.Drawing.Size(80, 25)
        Me.txtVowel.TabIndex = 4
        Me.txtVowel.Text = ""
        '
        'lblSpecial
        '
        Me.lblSpecial.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpecial.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblSpecial.Location = New System.Drawing.Point(24, 96)
        Me.lblSpecial.Name = "lblSpecial"
        Me.lblSpecial.Size = New System.Drawing.Size(160, 24)
        Me.lblSpecial.TabIndex = 0
        Me.lblSpecial.Text = "Special Characters"
        '
        'lblDigit
        '
        Me.lblDigit.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDigit.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblDigit.Location = New System.Drawing.Point(24, 72)
        Me.lblDigit.Name = "lblDigit"
        Me.lblDigit.Size = New System.Drawing.Size(160, 24)
        Me.lblDigit.TabIndex = 0
        Me.lblDigit.Text = "Digits"
        '
        'lblConsonant
        '
        Me.lblConsonant.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConsonant.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblConsonant.Location = New System.Drawing.Point(24, 48)
        Me.lblConsonant.Name = "lblConsonant"
        Me.lblConsonant.Size = New System.Drawing.Size(160, 24)
        Me.lblConsonant.TabIndex = 0
        Me.lblConsonant.Text = "Consonants"
        '
        'lblVowel
        '
        Me.lblVowel.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVowel.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblVowel.Location = New System.Drawing.Point(24, 24)
        Me.lblVowel.Name = "lblVowel"
        Me.lblVowel.Size = New System.Drawing.Size(160, 24)
        Me.lblVowel.TabIndex = 0
        Me.lblVowel.Text = "Vowels"
        '
        'cmdAnalyze
        '
        Me.cmdAnalyze.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAnalyze.ForeColor = System.Drawing.Color.MediumBlue
        Me.cmdAnalyze.Location = New System.Drawing.Point(568, 96)
        Me.cmdAnalyze.Name = "cmdAnalyze"
        Me.cmdAnalyze.Size = New System.Drawing.Size(96, 24)
        Me.cmdAnalyze.TabIndex = 1
        Me.cmdAnalyze.Text = "&ANALYZE"
        '
        'cmdClear
        '
        Me.cmdClear.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClear.ForeColor = System.Drawing.Color.MediumBlue
        Me.cmdClear.Location = New System.Drawing.Point(568, 136)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(96, 24)
        Me.cmdClear.TabIndex = 2
        Me.cmdClear.Text = "&CLEAR"
        '
        'cmdExit
        '
        Me.cmdExit.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.ForeColor = System.Drawing.Color.MediumBlue
        Me.cmdExit.Location = New System.Drawing.Point(568, 176)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(96, 24)
        Me.cmdExit.TabIndex = 3
        Me.cmdExit.Text = "E&XIT"
        '
        'frmCharacterSet
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Yellow
        Me.ClientSize = New System.Drawing.Size(884, 234)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.cmdAnalyze)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpString)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCharacterSet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CHARACTER SET"
        Me.grpString.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub cmdAnalyze_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAnalyze.Click
        Dim word As String
        Dim x As Char
        Dim ctr, vowels, consonants, digits, specials As Integer
        If (txtString.Text = "") Then
            MsgBox("Please input a string!!!", MsgBoxStyle.Exclamation, "Character Set Program")
            vowels = 0
            consonants = 0
            digits = 0
            specials = 0
        Else
            word = LCase(txtString.Text)
            For ctr = 1 To word.Length
                If (Mid(word, ctr, 1) = "a") Or (Mid(word, ctr, 1) = "e") Or (Mid(word, ctr, 1) = "i") Or (Mid(word, ctr, 1) = "o") Or (Mid(word, ctr, 1) = "u") Then
                    vowels += 1
                ElseIf (Mid(word, ctr, 1) = "b") Or (Mid(word, ctr, 1) = "c") Or (Mid(word, ctr, 1) = "d") Or (Mid(word, ctr, 1) = "f") Or (Mid(word, ctr, 1) = "g") Or (Mid(word, ctr, 1) = "h") Or (Mid(word, ctr, 1) = "j") Or (Mid(word, ctr, 1) = "k") Or (Mid(word, ctr, 1) = "l") Or (Mid(word, ctr, 1) = "m") Or (Mid(word, ctr, 1) = "n") Or (Mid(word, ctr, 1) = "p") Or (Mid(word, ctr, 1) = "q") Or (Mid(word, ctr, 1) = "r") Or (Mid(word, ctr, 1) = "s") Or (Mid(word, ctr, 1) = "t") Or (Mid(word, ctr, 1) = "v") Or (Mid(word, ctr, 1) = "w") Or (Mid(word, ctr, 1) = "x") Or (Mid(word, ctr, 1) = "y") Or (Mid(word, ctr, 1) = "z") Then
                    consonants += 1
                ElseIf (Mid(word, ctr, 1) = "0") Or (Mid(word, ctr, 1) = "1") Or (Mid(word, ctr, 1) = "2") Or (Mid(word, ctr, 1) = "3") Or (Mid(word, ctr, 1) = "4") Or (Mid(word, ctr, 1) = "5") Or (Mid(word, ctr, 1) = "6") Or (Mid(word, ctr, 1) = "7") Or (Mid(word, ctr, 1) = "8") Or (Mid(word, ctr, 1) = "9") Then
                    digits += 1
                Else
                    specials += 1
                End If
            Next
            txtVowel.Text = vowels
            txtConsonant.Text = consonants
            txtDigit.Text = digits
            txtSpecial.Text = specials
        End If
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Dim reply As DialogResult
        reply = MsgBox("Are you sure you want to exit the Character Set Program?", MsgBoxStyle.OKCancel + MsgBoxStyle.Question, "Character Set Program")
        If reply = DialogResult.OK Then
            End
        End If
    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        txtString.Clear()
        txtString.Focus()
        txtVowel.Clear()
        txtConsonant.Clear()
        txtDigit.Clear()
        txtSpecial.Clear()
    End Sub
End Class