Public Class frmArabicToRomanConversion
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
    Friend WithEvents cmdRoman As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents cmdClear As System.Windows.Forms.Button
    Friend WithEvents txtArabic As System.Windows.Forms.TextBox
    Friend WithEvents lblRoman As System.Windows.Forms.Label
    Friend WithEvents grpArabic As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmdRoman = New System.Windows.Forms.Button()
        Me.txtArabic = New System.Windows.Forms.TextBox()
        Me.lblRoman = New System.Windows.Forms.Label()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.grpArabic = New System.Windows.Forms.GroupBox()
        Me.grpArabic.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdRoman
        '
        Me.cmdRoman.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRoman.Location = New System.Drawing.Point(8, 96)
        Me.cmdRoman.Name = "cmdRoman"
        Me.cmdRoman.Size = New System.Drawing.Size(80, 24)
        Me.cmdRoman.TabIndex = 1
        Me.cmdRoman.Text = "&ROMAN"
        '
        'txtArabic
        '
        Me.txtArabic.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArabic.Location = New System.Drawing.Point(8, 24)
        Me.txtArabic.MaxLength = 4
        Me.txtArabic.Name = "txtArabic"
        Me.txtArabic.Size = New System.Drawing.Size(256, 35)
        Me.txtArabic.TabIndex = 0
        Me.txtArabic.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblRoman
        '
        Me.lblRoman.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoman.Location = New System.Drawing.Point(8, 128)
        Me.lblRoman.Name = "lblRoman"
        Me.lblRoman.Size = New System.Drawing.Size(272, 64)
        Me.lblRoman.TabIndex = 4
        Me.lblRoman.Text = "Result appears here"
        Me.lblRoman.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdExit
        '
        Me.cmdExit.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.Location = New System.Drawing.Point(200, 96)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(80, 24)
        Me.cmdExit.TabIndex = 3
        Me.cmdExit.Text = "E&XIT"
        '
        'cmdClear
        '
        Me.cmdClear.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClear.Location = New System.Drawing.Point(104, 96)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(80, 24)
        Me.cmdClear.TabIndex = 2
        Me.cmdClear.Text = "&CLEAR"
        '
        'grpArabic
        '
        Me.grpArabic.Controls.Add(Me.txtArabic)
        Me.grpArabic.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpArabic.Location = New System.Drawing.Point(8, 8)
        Me.grpArabic.Name = "grpArabic"
        Me.grpArabic.Size = New System.Drawing.Size(272, 64)
        Me.grpArabic.TabIndex = 5
        Me.grpArabic.TabStop = False
        Me.grpArabic.Text = "Enter an Arabic Number here"
        '
        'frmArabicToRomanConversion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(288, 202)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.lblRoman)
        Me.Controls.Add(Me.cmdRoman)
        Me.Controls.Add(Me.grpArabic)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmArabicToRomanConversion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ARABIC TO ROMAN CONVERSION"
        Me.grpArabic.ResumeLayout(False)
        Me.grpArabic.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim RomanNumber, SecondNumber, ThirdNumber, FourNumber, FiveNumber As String
    ''' <summary>
    ''' Convert number to Roman figure:e.g 5 to V
    ''' </summary>
    ''' <param name="NumberToConvert">The number you want to convert, any number from 1 to 9999</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function ToRomanFigure(ByVal NumberToConvert As Int32) As String

        Select Case NumberToConvert
            Case 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 200, 300, 400, 500, 600, 700, 800, 900, 1000, 2000, 3000, 4000, 5000, 6000, 7000, 8000, 9000, 10000
                If NumberToConvert = 20 Then
                    RomanNumber = "XX"
                ElseIf NumberToConvert = 30 Then
                    RomanNumber = "XXX"
                ElseIf NumberToConvert = 40 Then
                    RomanNumber = "XL"
                ElseIf NumberToConvert = 50 Then
                    RomanNumber = "L"
                ElseIf NumberToConvert = 60 Then
                    RomanNumber = "LX"
                ElseIf NumberToConvert = 70 Then
                    RomanNumber = "LXX"
                ElseIf NumberToConvert = 80 Then
                    RomanNumber = "LXXX"
                ElseIf NumberToConvert = 90 Then
                    RomanNumber = "XC"
                ElseIf NumberToConvert = 100 Then
                    RomanNumber = "C"
                ElseIf NumberToConvert = 200 Then
                    RomanNumber = "CC"
                ElseIf NumberToConvert = 300 Then
                    RomanNumber = "CCC"
                ElseIf NumberToConvert = 400 Then
                    RomanNumber = "CD"
                ElseIf NumberToConvert = 500 Then
                    RomanNumber = "D"
                ElseIf NumberToConvert = 600 Then
                    RomanNumber = "DC"
                ElseIf NumberToConvert = 700 Then
                    RomanNumber = "DCC"
                ElseIf NumberToConvert = 800 Then
                    RomanNumber = "DCCC"
                ElseIf NumberToConvert = 900 Then
                    RomanNumber = "CM"
                ElseIf NumberToConvert = 1000 Then
                    RomanNumber = "M"
                ElseIf NumberToConvert = 2000 Then
                    RomanNumber = "MM"
                ElseIf NumberToConvert = 3000 Then
                    RomanNumber = "MMM"
                ElseIf NumberToConvert = 4000 Then
                    RomanNumber = "MMMM"
                ElseIf NumberToConvert = 5000 Then
                    RomanNumber = "MMMMM"
                ElseIf NumberToConvert = 6000 Then
                    RomanNumber = "MMMMMM"
                ElseIf NumberToConvert = 7000 Then
                    RomanNumber = "MMMMMMM"
                ElseIf NumberToConvert = 8000 Then
                    RomanNumber = "MMMMMMMM"
                ElseIf NumberToConvert = 9000 Then
                    RomanNumber = "MMMMMMMMM"
                ElseIf NumberToConvert = 10000 Then
                    RomanNumber = "MMMMMMMMMM"
                Else
                    RomanNumber = "X"
                End If
            Case 1
                RomanNumber = "I"
            Case 2
                RomanNumber = "II"
            Case 3
                RomanNumber = "III"
            Case 4
                RomanNumber = "IV"
            Case 5
                RomanNumber = "V"
            Case 6
                RomanNumber = "VI"
            Case 7
                RomanNumber = "VII"
            Case 8
                RomanNumber = "VIII"
            Case 9
                RomanNumber = "IX"
            Case 11 To 19
                SecondNumber = NumberToConvert.ToString
                SecondNumber = SecondNumber.Substring(1, 1)
                RomanNumber = "X" & ToRomanFigure(CInt(SecondNumber))
            Case 21 To 29
                SecondNumber = NumberToConvert.ToString
                SecondNumber = SecondNumber.Substring(1, 1)
                RomanNumber = "XX" & ToRomanFigure(CInt(SecondNumber))
            Case 31 To 39
                SecondNumber = NumberToConvert.ToString
                SecondNumber = SecondNumber.Substring(1, 1)
                RomanNumber = "XXX" & ToRomanFigure(CInt(SecondNumber))
            Case 41 To 49
                SecondNumber = NumberToConvert.ToString
                SecondNumber = SecondNumber.Substring(1, 1)
                RomanNumber = "XL" & ToRomanFigure(CInt(SecondNumber))
            Case 51 To 59
                SecondNumber = NumberToConvert.ToString
                SecondNumber = SecondNumber.Substring(1, 1)
                RomanNumber = "L" & ToRomanFigure(CInt(SecondNumber))
            Case 61 To 69
                SecondNumber = NumberToConvert.ToString
                SecondNumber = SecondNumber.Substring(1, 1)
                RomanNumber = "LX" & ToRomanFigure(CInt(SecondNumber))
            Case 71 To 79
                SecondNumber = NumberToConvert.ToString
                SecondNumber = SecondNumber.Substring(1, 1)
                RomanNumber = "LXX" & ToRomanFigure(CInt(SecondNumber))
            Case 81 To 89
                SecondNumber = NumberToConvert.ToString
                SecondNumber = SecondNumber.Substring(1, 1)
                RomanNumber = "LXX" & ToRomanFigure(CInt(SecondNumber))
            Case 91 To 99
                SecondNumber = NumberToConvert.ToString
                SecondNumber = SecondNumber.Substring(1, 1)
                RomanNumber = "XC" & ToRomanFigure(CInt(SecondNumber))
            Case 101 To 199
                ThirdNumber = NumberToConvert.ToString
                ThirdNumber = ThirdNumber.Substring(1, 2)
                RomanNumber = "C" & ToRomanFigure(CInt(ThirdNumber))
            Case 201 To 299
                ThirdNumber = NumberToConvert.ToString
                ThirdNumber = ThirdNumber.Substring(1, 2)
                RomanNumber = "CC" & ToRomanFigure(CInt(ThirdNumber))
            Case 301 To 399
                ThirdNumber = NumberToConvert.ToString
                ThirdNumber = ThirdNumber.Substring(1, 2)
                RomanNumber = "CCC" & ToRomanFigure(CInt(ThirdNumber))
            Case 401 To 499
                ThirdNumber = NumberToConvert.ToString
                ThirdNumber = ThirdNumber.Substring(1, 2)
                RomanNumber = "CD" & ToRomanFigure(CInt(ThirdNumber))
            Case 501 To 599
                ThirdNumber = NumberToConvert.ToString
                ThirdNumber = ThirdNumber.Substring(1, 2)
                RomanNumber = "D" & ToRomanFigure(CInt(ThirdNumber))
            Case 601 To 699
                ThirdNumber = NumberToConvert.ToString
                ThirdNumber = ThirdNumber.Substring(1, 2)
                RomanNumber = "DC" & ToRomanFigure(CInt(ThirdNumber))
            Case 701 To 799
                ThirdNumber = NumberToConvert.ToString
                ThirdNumber = ThirdNumber.Substring(1, 2)
                RomanNumber = "DCC" & ToRomanFigure(CInt(ThirdNumber))
            Case 801 To 899
                ThirdNumber = NumberToConvert.ToString
                ThirdNumber = ThirdNumber.Substring(1, 2)
                RomanNumber = "DCCC" & ToRomanFigure(CInt(ThirdNumber))
            Case 901 To 999
                ThirdNumber = NumberToConvert.ToString
                ThirdNumber = ThirdNumber.Substring(1, 2)
                RomanNumber = "CM" & ToRomanFigure(CInt(ThirdNumber))
            Case 1001 To 1999
                FourNumber = NumberToConvert.ToString
                FourNumber = FourNumber.Substring(1, 3)
                RomanNumber = "M" & ToRomanFigure(CInt(FourNumber))
            Case 2001 To 2999
                FourNumber = NumberToConvert.ToString
                FourNumber = FourNumber.Substring(1, 3)
                RomanNumber = "MM" & ToRomanFigure(CInt(FourNumber))
            Case 3001 To 3999
                FourNumber = NumberToConvert.ToString
                FourNumber = FourNumber.Substring(1, 3)
                RomanNumber = "MMM" & ToRomanFigure(CInt(FourNumber))
            Case 4001 To 4999
                FourNumber = NumberToConvert.ToString
                FourNumber = FourNumber.Substring(1, 3)
                RomanNumber = "MMMM" & ToRomanFigure(CInt(FourNumber))
            Case 5001 To 5999
                FourNumber = NumberToConvert.ToString
                FourNumber = FourNumber.Substring(1, 3)
                RomanNumber = "MMMMM" & ToRomanFigure(CInt(FourNumber))
            Case 6001 To 6999
                FourNumber = NumberToConvert.ToString
                FourNumber = FourNumber.Substring(1, 3)
                RomanNumber = "MMMMMM" & ToRomanFigure(CInt(FourNumber))
            Case 7001 To 7999
                FourNumber = NumberToConvert.ToString
                FourNumber = FourNumber.Substring(1, 3)
                RomanNumber = "MMMMMMM" & ToRomanFigure(CInt(FourNumber))
            Case 8001 To 8999
                FourNumber = NumberToConvert.ToString
                FourNumber = FourNumber.Substring(1, 3)
                RomanNumber = "MMMMMMMM" & ToRomanFigure(CInt(FourNumber))
            Case 9001 To 9999
                FourNumber = NumberToConvert.ToString
                FourNumber = FourNumber.Substring(1, 3)
                RomanNumber = "MMMMMMMMM" & ToRomanFigure(CInt(FourNumber))
            Case 10001 To 99999
                FiveNumber = NumberToConvert.ToString
                FiveNumber = FiveNumber.Substring(1, 4)
                RomanNumber = "MMMMMMMMMM" & ToRomanFigure(CInt(FiveNumber))
        End Select

        Return RomanNumber
    End Function

    Private Sub cmdRoman_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRoman.Click
        If (txtArabic.Text = "" Or Val(txtArabic.Text) = 0) Then
            MsgBox("Please enter any value greater than 0", MsgBoxStyle.Critical, "Arabic To Roman Conversion Program")
            cmdClear_Click(sender, e)
        Else
            lblRoman.Text = ToRomanFigure(Val(txtArabic.Text))
        End If
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Dim reply As DialogResult
        reply = MsgBox("Are you sure you want to exit the Arabic To Roman Conversion Program?", MsgBoxStyle.OKCancel + MsgBoxStyle.Question, "Arabic To Roman Conversion Program")
        If reply = DialogResult.OK Then
            End
        End If
    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        txtArabic.Clear()
        txtArabic.Focus()
        lblRoman.Text = "Result appears here"
    End Sub

    Private Sub txtArabic_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtArabic.TextChanged
        If (IsNumeric(txtArabic.Text) = True) Then
        Else
            txtArabic.Text = ""
        End If
    End Sub
End Class