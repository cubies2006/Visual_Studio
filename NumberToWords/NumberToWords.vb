Public Class frmNumberToWords
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
    Friend WithEvents txtNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtResult As System.Windows.Forms.TextBox
    Friend WithEvents cmdConvert As System.Windows.Forms.Button
    Friend WithEvents grpNumber As System.Windows.Forms.GroupBox
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents cmdClear As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtNumber = New System.Windows.Forms.TextBox
        Me.cmdConvert = New System.Windows.Forms.Button
        Me.txtResult = New System.Windows.Forms.TextBox
        Me.grpNumber = New System.Windows.Forms.GroupBox
        Me.cmdClear = New System.Windows.Forms.Button
        Me.cmdExit = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'txtNumber
        '
        Me.txtNumber.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNumber.BackColor = System.Drawing.Color.Lavender
        Me.txtNumber.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumber.Location = New System.Drawing.Point(40, 32)
        Me.txtNumber.MaxLength = 15
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(320, 26)
        Me.txtNumber.TabIndex = 0
        Me.txtNumber.Text = ""
        Me.txtNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmdConvert
        '
        Me.cmdConvert.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmdConvert.Font = New System.Drawing.Font("Transformers Movie", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdConvert.ForeColor = System.Drawing.Color.Moccasin
        Me.cmdConvert.Location = New System.Drawing.Point(40, 80)
        Me.cmdConvert.Name = "cmdConvert"
        Me.cmdConvert.Size = New System.Drawing.Size(80, 23)
        Me.cmdConvert.TabIndex = 1
        Me.cmdConvert.Text = "&CONVERT"
        '
        'txtResult
        '
        Me.txtResult.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtResult.BackColor = System.Drawing.Color.Lavender
        Me.txtResult.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResult.Location = New System.Drawing.Point(8, 120)
        Me.txtResult.Multiline = True
        Me.txtResult.Name = "txtResult"
        Me.txtResult.ReadOnly = True
        Me.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtResult.Size = New System.Drawing.Size(384, 96)
        Me.txtResult.TabIndex = 4
        Me.txtResult.Text = ""
        Me.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grpNumber
        '
        Me.grpNumber.Font = New System.Drawing.Font("Transformers Movie", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpNumber.ForeColor = System.Drawing.Color.Moccasin
        Me.grpNumber.Location = New System.Drawing.Point(8, 8)
        Me.grpNumber.Name = "grpNumber"
        Me.grpNumber.Size = New System.Drawing.Size(384, 56)
        Me.grpNumber.TabIndex = 3
        Me.grpNumber.TabStop = False
        Me.grpNumber.Text = "Enter a number (0 to 999999999999999 only)"
        '
        'cmdClear
        '
        Me.cmdClear.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmdClear.Font = New System.Drawing.Font("Transformers Movie", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClear.ForeColor = System.Drawing.Color.Moccasin
        Me.cmdClear.Location = New System.Drawing.Point(160, 80)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(80, 23)
        Me.cmdClear.TabIndex = 2
        Me.cmdClear.Text = "C&LEAR"
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmdExit.Font = New System.Drawing.Font("Transformers Movie", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.ForeColor = System.Drawing.Color.Moccasin
        Me.cmdExit.Location = New System.Drawing.Point(280, 80)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(80, 23)
        Me.cmdExit.TabIndex = 3
        Me.cmdExit.Text = "E&XIT"
        '
        'frmNumberToWords
        '
        Me.AcceptButton = Me.cmdConvert
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.DarkGreen
        Me.ClientSize = New System.Drawing.Size(400, 226)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.cmdConvert)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.grpNumber)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNumberToWords"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NUMBER TO WORDS"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub cmdConvert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConvert.Click
        If (txtNumber.Text = "") Then
            MsgBox("Please enter a number!!!", MsgBoxStyle.Critical, "Number To Words Program")
        ElseIf (Val(txtNumber.Text) < 0) Then
            MsgBox("Negative numbers are not allowed!!!", MsgBoxStyle.Critical, "Number To Words Program")
        Else
            txtResult.Text = NumberToString(CDbl(txtNumber.Text))
        End If
    End Sub

    ' Return a word representation of the whole number value.
    Private Function NumberToString(ByVal num As Double) As String
        ' Remove any fractional part.
        num = Int(num)

        ' If the number is 0, return zero.
        If num = 0 Then Return "Zero"

        Static groups() As String = {"", "Thousand", "Million", "Billion", "Trillion", "Quadrillion", "?", "??", "???", "????"}
        Dim result As String = ""

        ' Process the groups, smallest first.
        Dim quotient As Double
        Dim remainder As Integer
        Dim group_num As Integer = 0
        Do While num > 0
            ' Get the next group of three digits.
            quotient = Int(num / 1000)
            remainder = CInt(num - quotient * 1000)
            num = quotient

            ' Convert the group into words.
            result = GroupToWords(remainder) & _
                " " & groups(group_num) & " " & _
                result

            ' Get ready for the next group.
            group_num += 1
        Loop

        ' Remove the trailing ", ".
        If result.EndsWith(", ") Then
            result = result.Substring(0, result.Length - 2)
        End If

        Return result.Trim()
    End Function

    ' Convert a number between 0 and 999 into words.
    Private Function GroupToWords(ByVal num As Integer) As String
        Static one_to_nineteen() As String = {"Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"}
        Static multiples_of_ten() As String = {"Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"}

        ' If the number is 0, return an empty string.
        If num = 0 Then Return ""

        ' Handle the hundreds digit.
        Dim digit As Integer
        Dim result As String = ""
        If num > 99 Then
            digit = num \ 100
            num = num Mod 100
            result = one_to_nineteen(digit) & " Hundred"
        End If

        ' If num = 0, we have hundreds only.
        If num = 0 Then Return result.Trim()

        ' See if the rest is less than 20.
        If num < 20 Then
            ' Look up the correct name.
            result &= " " & one_to_nineteen(num)
        Else
            ' Handle the tens digit.
            digit = num \ 10
            num = num Mod 10
            result &= " " & multiples_of_ten(digit - 2)

            ' Handle the final digit.
            If num > 0 Then
                result &= " " & one_to_nineteen(num)
            End If
        End If

        Return result.Trim()
    End Function

    Private Sub txtNumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumber.TextChanged
        If (IsNumeric(txtNumber.Text)) Then
        Else
            txtNumber.Clear()
        End If
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Dim reply As DialogResult
        reply = MsgBox("Are you sure you want to exit the Number To Words Program?", MsgBoxStyle.OKCancel + MsgBoxStyle.Question, "Number To Words Program")
        If reply = DialogResult.OK Then
            End
        End If
    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        txtNumber.Clear()
        txtNumber.Focus()
        txtResult.Clear()
    End Sub
End Class