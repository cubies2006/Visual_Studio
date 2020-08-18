Public Class frmRockScissorPaper
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
    Friend WithEvents cmdAnalyze As System.Windows.Forms.Button
    Friend WithEvents listRockScissorPaper As System.Windows.Forms.ListBox
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents cmdClear As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents imgUser As System.Windows.Forms.PictureBox
    Friend WithEvents imgPC As System.Windows.Forms.PictureBox
    Friend WithEvents grpUserChoice As System.Windows.Forms.GroupBox
    Friend WithEvents grpPCChoice As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmdAnalyze = New System.Windows.Forms.Button()
        Me.listRockScissorPaper = New System.Windows.Forms.ListBox()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.imgUser = New System.Windows.Forms.PictureBox()
        Me.imgPC = New System.Windows.Forms.PictureBox()
        Me.grpUserChoice = New System.Windows.Forms.GroupBox()
        Me.grpPCChoice = New System.Windows.Forms.GroupBox()
        CType(Me.imgUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgPC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdAnalyze
        '
        Me.cmdAnalyze.BackColor = System.Drawing.Color.SkyBlue
        Me.cmdAnalyze.Font = New System.Drawing.Font("Transformers Movie", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAnalyze.Location = New System.Drawing.Point(69, 107)
        Me.cmdAnalyze.Name = "cmdAnalyze"
        Me.cmdAnalyze.Size = New System.Drawing.Size(90, 39)
        Me.cmdAnalyze.TabIndex = 1
        Me.cmdAnalyze.Text = "&ANALYZE"
        Me.cmdAnalyze.UseVisualStyleBackColor = False
        '
        'listRockScissorPaper
        '
        Me.listRockScissorPaper.Font = New System.Drawing.Font("Transformers Movie", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listRockScissorPaper.ItemHeight = 21
        Me.listRockScissorPaper.Items.AddRange(New Object() {"Rock", "Scissor", "Paper"})
        Me.listRockScissorPaper.Location = New System.Drawing.Point(140, 20)
        Me.listRockScissorPaper.Name = "listRockScissorPaper"
        Me.listRockScissorPaper.Size = New System.Drawing.Size(184, 67)
        Me.listRockScissorPaper.TabIndex = 0
        '
        'lblResult
        '
        Me.lblResult.Font = New System.Drawing.Font("Transformers Movie", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.ForeColor = System.Drawing.Color.White
        Me.lblResult.Location = New System.Drawing.Point(28, 408)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(419, 32)
        Me.lblResult.TabIndex = 6
        Me.lblResult.Text = "Result appears here"
        Me.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdClear
        '
        Me.cmdClear.BackColor = System.Drawing.Color.SkyBlue
        Me.cmdClear.Font = New System.Drawing.Font("Transformers Movie", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClear.Location = New System.Drawing.Point(184, 107)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(90, 39)
        Me.cmdClear.TabIndex = 2
        Me.cmdClear.Text = "&CLEAR"
        Me.cmdClear.UseVisualStyleBackColor = False
        '
        'cmdExit
        '
        Me.cmdExit.BackColor = System.Drawing.Color.SkyBlue
        Me.cmdExit.Font = New System.Drawing.Font("Transformers Movie", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.Location = New System.Drawing.Point(300, 107)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(90, 39)
        Me.cmdExit.TabIndex = 3
        Me.cmdExit.Text = "E&XIT"
        Me.cmdExit.UseVisualStyleBackColor = False
        '
        'imgUser
        '
        Me.imgUser.Location = New System.Drawing.Point(36, 189)
        Me.imgUser.Name = "imgUser"
        Me.imgUser.Size = New System.Drawing.Size(188, 194)
        Me.imgUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgUser.TabIndex = 7
        Me.imgUser.TabStop = False
        '
        'imgPC
        '
        Me.imgPC.Location = New System.Drawing.Point(253, 189)
        Me.imgPC.Name = "imgPC"
        Me.imgPC.Size = New System.Drawing.Size(193, 194)
        Me.imgPC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgPC.TabIndex = 8
        Me.imgPC.TabStop = False
        '
        'grpUserChoice
        '
        Me.grpUserChoice.Font = New System.Drawing.Font("Transformers Movie", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpUserChoice.ForeColor = System.Drawing.Color.White
        Me.grpUserChoice.Location = New System.Drawing.Point(28, 165)
        Me.grpUserChoice.Name = "grpUserChoice"
        Me.grpUserChoice.Size = New System.Drawing.Size(198, 228)
        Me.grpUserChoice.TabIndex = 4
        Me.grpUserChoice.TabStop = False
        Me.grpUserChoice.Text = "User Choice"
        '
        'grpPCChoice
        '
        Me.grpPCChoice.Font = New System.Drawing.Font("Transformers Movie", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPCChoice.ForeColor = System.Drawing.Color.White
        Me.grpPCChoice.Location = New System.Drawing.Point(245, 165)
        Me.grpPCChoice.Name = "grpPCChoice"
        Me.grpPCChoice.Size = New System.Drawing.Size(203, 228)
        Me.grpPCChoice.TabIndex = 5
        Me.grpPCChoice.TabStop = False
        Me.grpPCChoice.Text = "PC Choice"
        '
        'frmRockScissorPaper
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Indigo
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.imgPC)
        Me.Controls.Add(Me.imgUser)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.listRockScissorPaper)
        Me.Controls.Add(Me.cmdAnalyze)
        Me.Controls.Add(Me.grpUserChoice)
        Me.Controls.Add(Me.grpPCChoice)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRockScissorPaper"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ROCK SCISSOR PAPER"
        CType(Me.imgUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgPC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim userinput, pcinput As String

    Private Sub cmdAnalyze_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAnalyze.Click
        If (listRockScissorPaper.SelectedItem = "") Then
            MsgBox("Please select a choice.", MsgBoxStyle.Critical, "Rock Scissor Paper Program")
            cmdClear_Click(sender, e)
        ElseIf (listRockScissorPaper.SelectedItem = "Rock") Then
            Reveal()
            userinput = "Rock"
            imgUser.Image = Image.FromFile("D:\POST-COLYMPIC_ERA\Important_Stuff\Computer-Related\Programming_Projects\Visual_Studio\RockScissorPaper\images\Rock.jpg")
        ElseIf (listRockScissorPaper.SelectedItem = "Scissor") Then
            Reveal()
            userinput = "Scissor"
            imgUser.Image = Image.FromFile("D:\POST-COLYMPIC_ERA\Important_Stuff\Computer-Related\Programming_Projects\Visual_Studio\RockScissorPaper\images\Scissor.jpg")
        ElseIf (listRockScissorPaper.SelectedItem = "Paper") Then
            Reveal()
            userinput = "Paper"
            imgUser.Image = Image.FromFile("D:\POST-COLYMPIC_ERA\Important_Stuff\Computer-Related\Programming_Projects\Visual_Studio\RockScissorPaper\images\Paper.jpg")
        End If
        If (listRockScissorPaper.SelectedItem <> "") Then
            pcinput = CStr(Int(Rnd() * 3))
            Select Case (pcinput)
                Case "0" : pcinput = "Rock"
                Case "1" : pcinput = "Scissor"
                Case "2" : pcinput = "Paper"
            End Select
            If (userinput = pcinput) Then
                Reveal()
                imgPC.Image = imgUser.Image
                lblResult.Text = "DRAW"
            ElseIf (userinput = "Rock" And pcinput = "Scissor") Or (userinput = "Scissor" And pcinput = "Paper") Or (userinput = "Paper" And pcinput = "Rock") Then
                Reveal()
                Select Case (pcinput)
                    Case "Rock" : imgPC.Image = Image.FromFile("D:\POST-COLYMPIC_ERA\Important_Stuff\Computer-Related\Programming_Projects\Visual_Studio\RockScissorPaper\images\Rock.jpg")
                    Case "Scissor" : imgPC.Image = Image.FromFile("D:\POST-COLYMPIC_ERA\Important_Stuff\Computer-Related\Programming_Projects\Visual_Studio\RockScissorPaper\images\Scissor.jpg")
                    Case "Paper" : imgPC.Image = Image.FromFile("D:\POST-COLYMPIC_ERA\Important_Stuff\Computer-Related\Programming_Projects\Visual_Studio\RockScissorPaper\images\Paper.jpg")
                End Select
                lblResult.Text = "WON"
            ElseIf (pcinput = "Rock" And userinput = "Scissor") Or (pcinput = "Scissor" And userinput = "Paper") Or (pcinput = "Paper" And userinput = "Rock") Then
                Reveal()
                Select Case (pcinput)
                    Case "Rock" : imgPC.Image = Image.FromFile("D:\POST-COLYMPIC_ERA\Important_Stuff\Computer-Related\Programming_Projects\Visual_Studio\RockScissorPaper\images\Rock.jpg")
                    Case "Scissor" : imgPC.Image = Image.FromFile("D:\POST-COLYMPIC_ERA\Important_Stuff\Computer-Related\Programming_Projects\Visual_Studio\RockScissorPaper\images\Scissor.jpg")
                    Case "Paper" : imgPC.Image = Image.FromFile("D:\POST-COLYMPIC_ERA\Important_Stuff\Computer-Related\Programming_Projects\Visual_Studio\RockScissorPaper\images\Paper.jpg")
                End Select
                lblResult.Text = "LOSE"
            End If
        End If
    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        listRockScissorPaper.ClearSelected()
        listRockScissorPaper.Focus()
        imgUser.Hide()
        imgPC.Hide()
        lblResult.Text = "Result appears here"
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Dim reply As DialogResult
        reply = MsgBox("Are you sure you want to exit the Rock Scissor Paper Program?", MsgBoxStyle.OKCancel + MsgBoxStyle.Question, "Rock Scissor Paper Program")
        If reply = DialogResult.OK Then
            End
        End If
    End Sub

    Private Sub cmdAnalyze_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAnalyze.MouseEnter
        cmdAnalyze.BackColor = Color.Green
        cmdAnalyze.ForeColor = Color.White
    End Sub

    Private Sub cmdAnalyze_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAnalyze.MouseLeave
        cmdAnalyze.BackColor = Color.SkyBlue
        cmdAnalyze.ForeColor = Color.Black
    End Sub

    Private Sub cmdClear_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdClear.MouseEnter
        cmdClear.BackColor = Color.SaddleBrown
        cmdClear.ForeColor = Color.White
    End Sub

    Private Sub cmdClear_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdClear.MouseLeave
        cmdClear.BackColor = Color.SkyBlue
        cmdClear.ForeColor = Color.Black
    End Sub

    Private Sub cmdExit_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdExit.MouseEnter
        cmdExit.BackColor = Color.Red
        cmdExit.ForeColor = Color.White
    End Sub

    Private Sub cmdExit_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdExit.MouseLeave
        cmdExit.BackColor = Color.SkyBlue
        cmdExit.ForeColor = Color.Black
    End Sub

    Private Sub Reveal()
        imgUser.Show()
        imgPC.Show()
    End Sub
End Class