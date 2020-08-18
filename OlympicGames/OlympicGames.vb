Public Class frmOlympicGames
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
    Friend WithEvents lblOlympicYear As System.Windows.Forms.Label
    Friend WithEvents txtOlympicYear As System.Windows.Forms.TextBox
    Friend WithEvents cmdOlympicGames As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents imgSummerOlympics As System.Windows.Forms.PictureBox
    Friend WithEvents cmdClear As System.Windows.Forms.Button
    Friend WithEvents imgWinterOlympics As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lblOlympicYear = New System.Windows.Forms.Label()
        Me.txtOlympicYear = New System.Windows.Forms.TextBox()
        Me.cmdOlympicGames = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.imgSummerOlympics = New System.Windows.Forms.PictureBox()
        Me.imgWinterOlympics = New System.Windows.Forms.PictureBox()
        Me.cmdClear = New System.Windows.Forms.Button()
        CType(Me.imgSummerOlympics, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgWinterOlympics, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblOlympicYear
        '
        Me.lblOlympicYear.BackColor = System.Drawing.Color.Transparent
        Me.lblOlympicYear.Font = New System.Drawing.Font("SF Distant Galaxy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOlympicYear.ForeColor = System.Drawing.Color.Azure
        Me.lblOlympicYear.Location = New System.Drawing.Point(120, 24)
        Me.lblOlympicYear.Name = "lblOlympicYear"
        Me.lblOlympicYear.Size = New System.Drawing.Size(208, 24)
        Me.lblOlympicYear.TabIndex = 0
        Me.lblOlympicYear.Text = "Enter an Olympic year:"
        Me.lblOlympicYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtOlympicYear
        '
        Me.txtOlympicYear.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOlympicYear.Location = New System.Drawing.Point(344, 16)
        Me.txtOlympicYear.MaxLength = 4
        Me.txtOlympicYear.Name = "txtOlympicYear"
        Me.txtOlympicYear.Size = New System.Drawing.Size(120, 38)
        Me.txtOlympicYear.TabIndex = 1
        Me.txtOlympicYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmdOlympicGames
        '
        Me.cmdOlympicGames.BackColor = System.Drawing.Color.LemonChiffon
        Me.cmdOlympicGames.Font = New System.Drawing.Font("Transformers Movie", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOlympicGames.ForeColor = System.Drawing.Color.Black
        Me.cmdOlympicGames.Location = New System.Drawing.Point(32, 72)
        Me.cmdOlympicGames.Name = "cmdOlympicGames"
        Me.cmdOlympicGames.Size = New System.Drawing.Size(170, 40)
        Me.cmdOlympicGames.TabIndex = 2
        Me.cmdOlympicGames.Text = "&OLYMPIC GAMES"
        Me.cmdOlympicGames.UseVisualStyleBackColor = False
        '
        'cmdExit
        '
        Me.cmdExit.BackColor = System.Drawing.Color.CornflowerBlue
        Me.cmdExit.Font = New System.Drawing.Font("Transformers Movie", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.ForeColor = System.Drawing.Color.Black
        Me.cmdExit.Location = New System.Drawing.Point(383, 72)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(170, 40)
        Me.cmdExit.TabIndex = 3
        Me.cmdExit.Text = "E&XIT"
        Me.cmdExit.UseVisualStyleBackColor = False
        '
        'imgSummerOlympics
        '
        Me.imgSummerOlympics.Location = New System.Drawing.Point(32, 128)
        Me.imgSummerOlympics.Name = "imgSummerOlympics"
        Me.imgSummerOlympics.Size = New System.Drawing.Size(248, 416)
        Me.imgSummerOlympics.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgSummerOlympics.TabIndex = 4
        Me.imgSummerOlympics.TabStop = False
        '
        'imgWinterOlympics
        '
        Me.imgWinterOlympics.Location = New System.Drawing.Point(304, 128)
        Me.imgWinterOlympics.Name = "imgWinterOlympics"
        Me.imgWinterOlympics.Size = New System.Drawing.Size(248, 416)
        Me.imgWinterOlympics.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgWinterOlympics.TabIndex = 5
        Me.imgWinterOlympics.TabStop = False
        '
        'cmdClear
        '
        Me.cmdClear.BackColor = System.Drawing.Color.DarkCyan
        Me.cmdClear.Font = New System.Drawing.Font("Transformers Movie", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClear.ForeColor = System.Drawing.Color.Black
        Me.cmdClear.Location = New System.Drawing.Point(207, 72)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(170, 40)
        Me.cmdClear.TabIndex = 6
        Me.cmdClear.Text = "&CLEAR"
        Me.cmdClear.UseVisualStyleBackColor = False
        '
        'frmOlympicGames
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(584, 562)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.imgWinterOlympics)
        Me.Controls.Add(Me.imgSummerOlympics)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdOlympicGames)
        Me.Controls.Add(Me.txtOlympicYear)
        Me.Controls.Add(Me.lblOlympicYear)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmOlympicGames"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OLYMPIC GAMES (Games of the Olympiad & Olympic Winter Games)"
        CType(Me.imgSummerOlympics, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgWinterOlympics, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region

    Dim olympiad As Integer

    Private Sub txtOlympicYear_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOlympicYear.TextChanged
        If (IsNumeric(txtOlympicYear.Text) = True) Then
        Else
            txtOlympicYear.Clear()
        End If
    End Sub

    Private Sub cmdOlympicGames_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOlympicGames.Click
        olympiad = Val(txtOlympicYear.Text)
        If olympiad < 1896 Then
            MsgBox("The year that had entered is NOT an Olympic Year as the Modern Olympic Games has not yet began!!!", MsgBoxStyle.Critical, "Olympic Games Program")
            cmdClear_Click(sender, e)
        ElseIf (olympiad Mod 4 <> 0) And ((olympiad Mod 2 <> 0) Or olympiad < 1994) Then
            MsgBox("The year that had entered is NOT an Olympic Year.", MsgBoxStyle.Critical, "Olympic Games Program")
            cmdClear_Click(sender, e)
        Else
            If (txtOlympicYear.Text = "1896") Then
                OlympicEvent()
                imgSummerOlympics.Image = Image.FromFile("D:\POST-COLYMPIC_ERA\Pictures\Olympic Pictures\Summer Olympic Logos\Summer_Olympic_Logo_1896.jpg")
            ElseIf (txtOlympicYear.Text = "1900") Then
                OlympicEvent()
                imgSummerOlympics.Image = Image.FromFile("D:\POST-COLYMPIC_ERA\Pictures\Olympic Pictures\Summer Olympic Logos\Summer_Olympic_Logo_1900.jpg")
            ElseIf (txtOlympicYear.Text = "1904") Then
                OlympicEvent()
                imgSummerOlympics.Image = Image.FromFile("D:\POST-COLYMPIC_ERA\Pictures\Olympic Pictures\Summer Olympic Logos\Summer_Olympic_Logo_1904.jpg")
            ElseIf (txtOlympicYear.Text = "1908") Then
                OlympicEvent()
                imgSummerOlympics.Image = Image.FromFile("D:\POST-COLYMPIC_ERA\Pictures\Olympic Pictures\Summer Olympic Logos\Summer_Olympic_Logo_1908.jpg")
            ElseIf (txtOlympicYear.Text = "1912") Then
                OlympicEvent()
                imgSummerOlympics.Image = Image.FromFile("D:\POST-COLYMPIC_ERA\Pictures\Olympic Pictures\Summer Olympic Logos\Summer_Olympic_Logo_1912.jpg")
            ElseIf (txtOlympicYear.Text = "1916") Then
                OlympicEvent()
                imgSummerOlympics.Image = Image.FromFile("D:\POST-COLYMPIC_ERA\Pictures\Olympic Pictures\Summer Olympic Logos\Summer_Olympic_Logo_1916.jpg")
            ElseIf (txtOlympicYear.Text = "1920") Then
                OlympicEvent()
                imgSummerOlympics.Image = Image.FromFile("D:\POST-COLYMPIC_ERA\Pictures\Olympic Pictures\Summer Olympic Logos\Summer_Olympic_Logo_1920.jpg")
            ElseIf (txtOlympicYear.Text = "1924") Then
                OlympicEvent()
                imgSummerOlympics.Image = Image.FromFile("D:\POST-COLYMPIC_ERA\Pictures\Olympic Pictures\Summer Olympic Logos\Summer_Olympic_Logo_1924.jpg")
                imgWinterOlympics.Image = Image.FromFile("D:\POST-COLYMPIC_ERA\Pictures\Olympic Pictures\Winter Olympic Logos\Winter_Olympic_Logo_1924.jpg")
            ElseIf (txtOlympicYear.Text = "1928") Then
                OlympicEvent()
                imgSummerOlympics.Image = Image.FromFile("D:\POST-COLYMPIC_ERA\Pictures\Olympic Pictures\Summer Olympic Logos\Summer_Olympic_Logo_1928.jpg")
                imgWinterOlympics.Image = Image.FromFile("D:\POST-COLYMPIC_ERA\Pictures\Olympic Pictures\Winter Olympic Logos\Winter_Olympic_Logo_1928.jpg")
            ElseIf (txtOlympicYear.Text = "1932") Then
                OlympicEvent()
                imgSummerOlympics.Image = Image.FromFile("D:\POST-COLYMPIC_ERA\Pictures\Olympic Pictures\Summer Olympic Logos\Summer_Olympic_Logo_1932.jpg")
                imgWinterOlympics.Image = Image.FromFile("D:\POST-COLYMPIC_ERA\Pictures\Olympic Pictures\Winter Olympic Logos\Winter_Olympic_Logo_1932.jpg")
            ElseIf (txtOlympicYear.Text = "1936") Then
                OlympicEvent()
                imgSummerOlympics.Image = Image.FromFile("D:\POST-COLYMPIC_ERA\Pictures\Olympic Pictures\Summer Olympic Logos\Summer_Olympic_Logo_1936.jpg")
                imgWinterOlympics.Image = Image.FromFile("D:\POST-COLYMPIC_ERA\Pictures\Olympic Pictures\Winter Olympic Logos\Winter_Olympic_Logo_1936.jpg")
            ElseIf (txtOlympicYear.Text = "1940") Then
                OlympicEvent()
                imgSummerOlympics.Image = Image.FromFile("D:\POST-COLYMPIC_ERA\Pictures\Olympic Pictures\Summer Olympic Logos\Summer_Olympic_Logo_1940.jpg")
                imgWinterOlympics.Image = Image.FromFile("D:\POST-COLYMPIC_ERA\Pictures\Olympic Pictures\Winter Olympic Logos\Winter_Olympic_Logo_1940.jpg")
            ElseIf (txtOlympicYear.Text = "1944") Then
                OlympicEvent()
                imgSummerOlympics.Image = Image.FromFile("D:\POST-COLYMPIC_ERA\Pictures\Olympic Pictures\Summer Olympic Logos\Summer_Olympic_Logo_1944.jpg")
                imgWinterOlympics.Image = Image.FromFile("D:\POST-COLYMPIC_ERA\Pictures\Olympic Pictures\Winter Olympic Logos\Winter_Olympic_Logo_1944.jpg")
            ElseIf (txtOlympicYear.Text = "1948") Then
                OlympicEvent()
                imgSummerOlympics.Image = Image.FromFile("D:\POST-COLYMPIC_ERA\Pictures\Olympic Pictures\Summer Olympic Logos\Summer_Olympic_Logo_1948.jpg")
                imgWinterOlympics.Image = Image.FromFile("D:\POST-COLYMPIC_ERA\Pictures\Olympic Pictures\Winter Olympic Logos\Winter_Olympic_Logo_1948.jpg")
            ElseIf (txtOlympicYear.Text = "1952") Then
                OlympicEvent()
                imgSummerOlympics.Image = Image.FromFile("D:\POST-COLYMPIC_ERA\Pictures\Olympic Pictures\Summer Olympic Logos\Summer_Olympic_Logo_1952.jpg")
                imgWinterOlympics.Image = Image.FromFile("D:\POST-COLYMPIC_ERA\Pictures\Olympic Pictures\Winter Olympic Logos\Winter_Olympic_Logo_1952.jpg")
            ElseIf (txtOlympicYear.Text = "1956") Then
                OlympicEvent()
                imgSummerOlympics.Image = Image.FromFile("D:\POST-COLYMPIC_ERA\Pictures\Olympic Pictures\Summer Olympic Logos\Summer_Olympic_Logo_1956.jpg")
                imgWinterOlympics.Image = Image.FromFile("D:\POST-COLYMPIC_ERA\Pictures\Olympic Pictures\Winter Olympic Logos\Winter_Olympic_Logo_1956.jpg")
            ElseIf (txtOlympicYear.Text = "1960") Then
                OlympicEvent()
                imgSummerOlympics.Image = Image.FromFile("D:\POST-COLYMPIC_ERA\Pictures\Olympic Pictures\Summer Olympic Logos\Summer_Olympic_Logo_1960.jpg")
                imgWinterOlympics.Image = Image.FromFile("D:\POST-COLYMPIC_ERA\Pictures\Olympic Pictures\Winter Olympic Logos\Winter_Olympic_Logo_1960.jpg")
            ElseIf (txtOlympicYear.Text = "1964") Then
                OlympicEvent()
                imgSummerOlympics.Image = Image.FromFile("D:\POST-COLYMPIC_ERA\Pictures\Olympic Pictures\Summer Olympic Logos\Summer_Olympic_Logo_1964.jpg")
                imgWinterOlympics.Image = Image.FromFile("D:\POST-COLYMPIC_ERA\Pictures\Olympic Pictures\Winter Olympic Logos\Winter_Olympic_Logo_1964.jpg")
            ElseIf (txtOlympicYear.Text = "1968") Then
                OlympicEvent()
                imgSummerOlympics.Image = Image.FromFile("D:\POST-COLYMPIC_ERA\Pictures\Olympic Pictures\Summer Olympic Logos\Summer_Olympic_Logo_1968.jpg")
                imgWinterOlympics.Image = Image.FromFile("D:\POST-COLYMPIC_ERA\Pictures\Olympic Pictures\Winter Olympic Logos\Winter_Olympic_Logo_1968.jpg")
            ElseIf (txtOlympicYear.Text = "1972") Then
                OlympicEvent()
                imgSummerOlympics.Image = Image.FromFile("D:\POST-COLYMPIC_ERA\Pictures\Olympic Pictures\Summer Olympic Logos\Summer_Olympic_Logo_1972.jpg")
                imgWinterOlympics.Image = Image.FromFile("D:\POST-COLYMPIC_ERA\Pictures\Olympic Pictures\Winter Olympic Logos\Winter_Olympic_Logo_1972.jpg")
            ElseIf (txtOlympicYear.Text = "1976") Then
                OlympicEvent()
                imgSummerOlympics.Image = Image.FromFile("D:\POST-COLYMPIC_ERA\Pictures\Olympic Pictures\Summer Olympic Logos\Summer_Olympic_Logo_1976.jpg")
                imgWinterOlympics.Image = Image.FromFile("D:\POST-COLYMPIC_ERA\Pictures\Olympic Pictures\Winter Olympic Logos\Winter_Olympic_Logo_1976.jpg")
            ElseIf (txtOlympicYear.Text = "1980") Then
                OlympicEvent()
                imgSummerOlympics.Image = Image.FromFile("D:\POST-COLYMPIC_ERA\Pictures\Olympic Pictures\Summer Olympic Logos\Summer_Olympic_Logo_1980.jpg")
                imgWinterOlympics.Image = Image.FromFile("D:\POST-COLYMPIC_ERA\Pictures\Olympic Pictures\Winter Olympic Logos\Winter_Olympic_Logo_1980.jpg")
            ElseIf (txtOlympicYear.Text = "1984") Then
                OlympicEvent()
                imgSummerOlympics.Image = Image.FromFile("D:\POST-COLYMPIC_ERA\Pictures\Olympic Pictures\Summer Olympic Logos\Summer_Olympic_Logo_1984.jpg")
                imgWinterOlympics.Image = Image.FromFile("D:\POST-COLYMPIC_ERA\Pictures\Olympic Pictures\Winter Olympic Logos\Winter_Olympic_Logo_1984.jpg")
            ElseIf (txtOlympicYear.Text = "1988") Then
                OlympicEvent()
                imgSummerOlympics.Image = Image.FromFile("D:\POST-COLYMPIC_ERA\Pictures\Olympic Pictures\Summer Olympic Logos\Summer_Olympic_Logo_1988.jpg")
                imgWinterOlympics.Image = Image.FromFile("D:\POST-COLYMPIC_ERA\Pictures\Olympic Pictures\Winter Olympic Logos\Winter_Olympic_Logo_1988.jpg")
            ElseIf (txtOlympicYear.Text = "1992") Then
                OlympicEvent()
                imgSummerOlympics.Image = Image.FromFile("D:\POST-COLYMPIC_ERA\Pictures\Olympic Pictures\Summer Olympic Logos\Summer_Olympic_Logo_1992.jpg")
                imgWinterOlympics.Image = Image.FromFile("D:\POST-COLYMPIC_ERA\Pictures\Olympic Pictures\Winter Olympic Logos\Winter_Olympic_Logo_1992.jpg")
            ElseIf (txtOlympicYear.Text = "1994") Then
                OlympicEvent()
                imgWinterOlympics.Image = Image.FromFile("D:\POST-COLYMPIC_ERA\Pictures\Olympic Pictures\Winter Olympic Logos\Winter_Olympic_Logo_1994.jpg")
            ElseIf (txtOlympicYear.Text = "1996") Then
                OlympicEvent()
                imgSummerOlympics.Image = Image.FromFile("D:\POST-COLYMPIC_ERA\Pictures\Olympic Pictures\Summer Olympic Logos\Summer_Olympic_Logo_1996.jpg")
            ElseIf (txtOlympicYear.Text = "1998") Then
                OlympicEvent()
                imgWinterOlympics.Image = Image.FromFile("D:\POST-COLYMPIC_ERA\Pictures\Olympic Pictures\Winter Olympic Logos\Winter_Olympic_Logo_1998.jpg")
            ElseIf (txtOlympicYear.Text = "2000") Then
                OlympicEvent()
                imgSummerOlympics.Image = Image.FromFile("D:\POST-COLYMPIC_ERA\Pictures\Olympic Pictures\Summer Olympic Logos\Summer_Olympic_Logo_2000.jpg")
            ElseIf (txtOlympicYear.Text = "2002") Then
                OlympicEvent()
                imgWinterOlympics.Image = Image.FromFile("D:\POST-COLYMPIC_ERA\Pictures\Olympic Pictures\Winter Olympic Logos\Winter_Olympic_Logo_2002.jpg")
            ElseIf (txtOlympicYear.Text = "2004") Then
                OlympicEvent()
                imgSummerOlympics.Image = Image.FromFile("D:\POST-COLYMPIC_ERA\Pictures\Olympic Pictures\Summer Olympic Logos\Summer_Olympic_Logo_2004.jpg")
            ElseIf (txtOlympicYear.Text = "2006") Then
                OlympicEvent()
                imgWinterOlympics.Image = Image.FromFile("D:\POST-COLYMPIC_ERA\Pictures\Olympic Pictures\Winter Olympic Logos\Winter_Olympic_Logo_2006.jpg")
            ElseIf (txtOlympicYear.Text = "2008") Then
                OlympicEvent()
                imgSummerOlympics.Image = Image.FromFile("D:\POST-COLYMPIC_ERA\Pictures\Olympic Pictures\Summer Olympic Logos\Summer_Olympic_Logo_2008.jpg")
            ElseIf (txtOlympicYear.Text = "2010") Then
                OlympicEvent()
                imgWinterOlympics.Image = Image.FromFile("D:\POST-COLYMPIC_ERA\Pictures\Olympic Pictures\Winter Olympic Logos\Winter_Olympic_Logo_2010.jpg")
            ElseIf (txtOlympicYear.Text = "2012") Then
                OlympicEvent()
                imgSummerOlympics.Image = Image.FromFile("D:\POST-COLYMPIC_ERA\Pictures\Olympic Pictures\Summer Olympic Logos\Summer_Olympic_Logo_2012.jpg")
            ElseIf (txtOlympicYear.Text = "2014") Then
                OlympicEvent()
                imgWinterOlympics.Image = Image.FromFile("D:\POST-COLYMPIC_ERA\Pictures\Olympic Pictures\Winter Olympic Logos\Winter_Olympic_Logo_2014.jpg")
            ElseIf (txtOlympicYear.Text = "2016") Then
                OlympicEvent()
                imgSummerOlympics.Image = Image.FromFile("D:\POST-COLYMPIC_ERA\Pictures\Olympic Pictures\Summer Olympic Logos\Summer_Olympic_Logo_2016.jpg")
            ElseIf (txtOlympicYear.Text = "2018") Then
                OlympicEvent()
                imgWinterOlympics.Image = Image.FromFile("D:\POST-COLYMPIC_ERA\Pictures\Olympic Pictures\Winter Olympic Logos\Winter_Olympic_Logo_2018.jpg")
            ElseIf (txtOlympicYear.Text = "2020") Then
                OlympicEvent()
                imgSummerOlympics.Image = Image.FromFile("D:\POST-COLYMPIC_ERA\Pictures\Olympic Pictures\Summer Olympic Logos\Summer_Olympic_Logo_2020.jpg")
            ElseIf (txtOlympicYear.Text = "2022") Then
                OlympicEvent()
                imgWinterOlympics.Image = Image.FromFile("D:\POST-COLYMPIC_ERA\Pictures\Olympic Pictures\Winter Olympic Logos\Winter_Olympic_Logo_2022.jpg")
            ElseIf (txtOlympicYear.Text = "2024") Then
                OlympicEvent()
                imgSummerOlympics.Image = Image.FromFile("D:\POST-COLYMPIC_ERA\Pictures\Olympic Pictures\Summer Olympic Logos\Summer_Olympic_Logo_2024.jpg")
            End If
        End If
    End Sub

    Private Sub cmdOlympicGames_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdOlympicGames.MouseHover
        cmdOlympicGames.BackColor = Color.Gold
    End Sub

    Private Sub cmdOlympicGames_MouseLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmdOlympicGames.MouseMove
        cmdOlympicGames.BackColor = Color.LemonChiffon
    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        txtOlympicYear.Clear()
        txtOlympicYear.Focus()
        imgSummerOlympics.Hide()
        imgWinterOlympics.Hide()
    End Sub

    Private Sub cmdClear_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdClear.MouseHover
        cmdClear.BackColor = Color.Teal
    End Sub

    Private Sub cmdClear_MouseLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmdClear.MouseMove
        cmdClear.BackColor = Color.DarkCyan
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Dim reply As DialogResult
        reply = MsgBox("Are you sure you want to exit the Olympic Games Program?", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, "Olympic Games Program")
        If reply = DialogResult.OK Then
            End
        End If
    End Sub

    Private Sub cmdExit_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdExit.MouseHover
        cmdExit.BackColor = Color.SlateBlue
    End Sub

    Private Sub cmdExit_MouseLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmdExit.MouseMove
        cmdExit.BackColor = Color.CornflowerBlue
    End Sub

    Private Sub OlympicEvent()
        olympiad = Val(txtOlympicYear.Text)
        If (olympiad Mod 4 = 0) Then
            imgSummerOlympics.Show()
            If (olympiad >= 1924 And olympiad <= 1992) Then
                imgWinterOlympics.Show()
            Else
                imgWinterOlympics.Hide()
            End If
        ElseIf (olympiad Mod 4 <> 0) And ((olympiad Mod 2 <> 0) Or olympiad >= 1994) Then
            imgSummerOlympics.Hide()
            imgWinterOlympics.Show()
        End If
    End Sub
End Class
