Public Class frmOrderingSystem
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
    Friend WithEvents grpFoodMenu As System.Windows.Forms.GroupBox
    Friend WithEvents grpDiscount As System.Windows.Forms.GroupBox
    Friend WithEvents rdoNoDiscount As System.Windows.Forms.RadioButton
    Friend WithEvents rdo5Discount As System.Windows.Forms.RadioButton
    Friend WithEvents rdo10Discount As System.Windows.Forms.RadioButton
    Friend WithEvents rdo20Discount As System.Windows.Forms.RadioButton
    Friend WithEvents txtHamburger As System.Windows.Forms.TextBox
    Friend WithEvents txtFrenchFries As System.Windows.Forms.TextBox
    Friend WithEvents txtSundae As System.Windows.Forms.TextBox
    Friend WithEvents txtFriedChicken As System.Windows.Forms.TextBox
    Friend WithEvents chkHamburger As System.Windows.Forms.CheckBox
    Friend WithEvents chkFrenchFries As System.Windows.Forms.CheckBox
    Friend WithEvents chkSundae As System.Windows.Forms.CheckBox
    Friend WithEvents chkSpaghetti As System.Windows.Forms.CheckBox
    Friend WithEvents chkFriedChicken As System.Windows.Forms.CheckBox
    Friend WithEvents cmdCompute As System.Windows.Forms.Button
    Friend WithEvents cmdReset As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents txtTotalAmt As System.Windows.Forms.TextBox
    Friend WithEvents txtSpaghetti As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalAmt As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.grpFoodMenu = New System.Windows.Forms.GroupBox
        Me.txtFriedChicken = New System.Windows.Forms.TextBox
        Me.txtSpaghetti = New System.Windows.Forms.TextBox
        Me.txtSundae = New System.Windows.Forms.TextBox
        Me.txtFrenchFries = New System.Windows.Forms.TextBox
        Me.txtHamburger = New System.Windows.Forms.TextBox
        Me.chkFriedChicken = New System.Windows.Forms.CheckBox
        Me.chkSpaghetti = New System.Windows.Forms.CheckBox
        Me.chkSundae = New System.Windows.Forms.CheckBox
        Me.chkFrenchFries = New System.Windows.Forms.CheckBox
        Me.chkHamburger = New System.Windows.Forms.CheckBox
        Me.grpDiscount = New System.Windows.Forms.GroupBox
        Me.rdo20Discount = New System.Windows.Forms.RadioButton
        Me.rdo10Discount = New System.Windows.Forms.RadioButton
        Me.rdo5Discount = New System.Windows.Forms.RadioButton
        Me.rdoNoDiscount = New System.Windows.Forms.RadioButton
        Me.lblTotalAmt = New System.Windows.Forms.Label
        Me.txtTotalAmt = New System.Windows.Forms.TextBox
        Me.cmdCompute = New System.Windows.Forms.Button
        Me.cmdReset = New System.Windows.Forms.Button
        Me.cmdExit = New System.Windows.Forms.Button
        Me.grpFoodMenu.SuspendLayout()
        Me.grpDiscount.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpFoodMenu
        '
        Me.grpFoodMenu.Controls.Add(Me.txtFriedChicken)
        Me.grpFoodMenu.Controls.Add(Me.txtSpaghetti)
        Me.grpFoodMenu.Controls.Add(Me.txtSundae)
        Me.grpFoodMenu.Controls.Add(Me.txtFrenchFries)
        Me.grpFoodMenu.Controls.Add(Me.txtHamburger)
        Me.grpFoodMenu.Controls.Add(Me.chkFriedChicken)
        Me.grpFoodMenu.Controls.Add(Me.chkSpaghetti)
        Me.grpFoodMenu.Controls.Add(Me.chkSundae)
        Me.grpFoodMenu.Controls.Add(Me.chkFrenchFries)
        Me.grpFoodMenu.Controls.Add(Me.chkHamburger)
        Me.grpFoodMenu.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpFoodMenu.Location = New System.Drawing.Point(8, 24)
        Me.grpFoodMenu.Name = "grpFoodMenu"
        Me.grpFoodMenu.Size = New System.Drawing.Size(280, 192)
        Me.grpFoodMenu.TabIndex = 0
        Me.grpFoodMenu.TabStop = False
        Me.grpFoodMenu.Text = "Food Menu"
        '
        'txtFriedChicken
        '
        Me.txtFriedChicken.Enabled = False
        Me.txtFriedChicken.Location = New System.Drawing.Point(184, 152)
        Me.txtFriedChicken.MaxLength = 5
        Me.txtFriedChicken.Name = "txtFriedChicken"
        Me.txtFriedChicken.Size = New System.Drawing.Size(88, 22)
        Me.txtFriedChicken.TabIndex = 9
        Me.txtFriedChicken.Text = "0"
        Me.txtFriedChicken.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSpaghetti
        '
        Me.txtSpaghetti.Enabled = False
        Me.txtSpaghetti.Location = New System.Drawing.Point(184, 120)
        Me.txtSpaghetti.MaxLength = 5
        Me.txtSpaghetti.Name = "txtSpaghetti"
        Me.txtSpaghetti.Size = New System.Drawing.Size(88, 22)
        Me.txtSpaghetti.TabIndex = 8
        Me.txtSpaghetti.Text = "0"
        Me.txtSpaghetti.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSundae
        '
        Me.txtSundae.Enabled = False
        Me.txtSundae.Location = New System.Drawing.Point(184, 88)
        Me.txtSundae.MaxLength = 5
        Me.txtSundae.Name = "txtSundae"
        Me.txtSundae.Size = New System.Drawing.Size(88, 22)
        Me.txtSundae.TabIndex = 7
        Me.txtSundae.Text = "0"
        Me.txtSundae.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFrenchFries
        '
        Me.txtFrenchFries.Enabled = False
        Me.txtFrenchFries.Location = New System.Drawing.Point(184, 56)
        Me.txtFrenchFries.MaxLength = 5
        Me.txtFrenchFries.Name = "txtFrenchFries"
        Me.txtFrenchFries.Size = New System.Drawing.Size(88, 22)
        Me.txtFrenchFries.TabIndex = 6
        Me.txtFrenchFries.Text = "0"
        Me.txtFrenchFries.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtHamburger
        '
        Me.txtHamburger.Enabled = False
        Me.txtHamburger.Location = New System.Drawing.Point(184, 24)
        Me.txtHamburger.MaxLength = 5
        Me.txtHamburger.Name = "txtHamburger"
        Me.txtHamburger.Size = New System.Drawing.Size(88, 22)
        Me.txtHamburger.TabIndex = 5
        Me.txtHamburger.Text = "0"
        Me.txtHamburger.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chkFriedChicken
        '
        Me.chkFriedChicken.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFriedChicken.Location = New System.Drawing.Point(8, 152)
        Me.chkFriedChicken.Name = "chkFriedChicken"
        Me.chkFriedChicken.Size = New System.Drawing.Size(168, 24)
        Me.chkFriedChicken.TabIndex = 4
        Me.chkFriedChicken.Text = "Fried Chicken (Php 45.00)"
        '
        'chkSpaghetti
        '
        Me.chkSpaghetti.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSpaghetti.Location = New System.Drawing.Point(8, 120)
        Me.chkSpaghetti.Name = "chkSpaghetti"
        Me.chkSpaghetti.Size = New System.Drawing.Size(168, 24)
        Me.chkSpaghetti.TabIndex = 3
        Me.chkSpaghetti.Text = "Spaghetti (Php 38.50)"
        '
        'chkSundae
        '
        Me.chkSundae.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSundae.Location = New System.Drawing.Point(8, 88)
        Me.chkSundae.Name = "chkSundae"
        Me.chkSundae.Size = New System.Drawing.Size(168, 24)
        Me.chkSundae.TabIndex = 2
        Me.chkSundae.Text = "Sundae (Php 18.25)"
        '
        'chkFrenchFries
        '
        Me.chkFrenchFries.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFrenchFries.Location = New System.Drawing.Point(8, 56)
        Me.chkFrenchFries.Name = "chkFrenchFries"
        Me.chkFrenchFries.Size = New System.Drawing.Size(168, 24)
        Me.chkFrenchFries.TabIndex = 1
        Me.chkFrenchFries.Text = "French Fries (Php 26.75)"
        '
        'chkHamburger
        '
        Me.chkHamburger.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkHamburger.Location = New System.Drawing.Point(8, 24)
        Me.chkHamburger.Name = "chkHamburger"
        Me.chkHamburger.Size = New System.Drawing.Size(168, 24)
        Me.chkHamburger.TabIndex = 0
        Me.chkHamburger.Text = "Hamburger (Php 20.00)"
        '
        'grpDiscount
        '
        Me.grpDiscount.Controls.Add(Me.rdo20Discount)
        Me.grpDiscount.Controls.Add(Me.rdo10Discount)
        Me.grpDiscount.Controls.Add(Me.rdo5Discount)
        Me.grpDiscount.Controls.Add(Me.rdoNoDiscount)
        Me.grpDiscount.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDiscount.Location = New System.Drawing.Point(296, 48)
        Me.grpDiscount.Name = "grpDiscount"
        Me.grpDiscount.Size = New System.Drawing.Size(128, 128)
        Me.grpDiscount.TabIndex = 1
        Me.grpDiscount.TabStop = False
        Me.grpDiscount.Text = "Discount"
        '
        'rdo20Discount
        '
        Me.rdo20Discount.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdo20Discount.Location = New System.Drawing.Point(8, 88)
        Me.rdo20Discount.Name = "rdo20Discount"
        Me.rdo20Discount.TabIndex = 13
        Me.rdo20Discount.Text = "20% Discount"
        '
        'rdo10Discount
        '
        Me.rdo10Discount.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdo10Discount.Location = New System.Drawing.Point(8, 64)
        Me.rdo10Discount.Name = "rdo10Discount"
        Me.rdo10Discount.TabIndex = 12
        Me.rdo10Discount.Text = "10% Discount"
        '
        'rdo5Discount
        '
        Me.rdo5Discount.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdo5Discount.Location = New System.Drawing.Point(8, 40)
        Me.rdo5Discount.Name = "rdo5Discount"
        Me.rdo5Discount.TabIndex = 11
        Me.rdo5Discount.Text = "5% Discount"
        '
        'rdoNoDiscount
        '
        Me.rdoNoDiscount.Checked = True
        Me.rdoNoDiscount.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoNoDiscount.Location = New System.Drawing.Point(8, 16)
        Me.rdoNoDiscount.Name = "rdoNoDiscount"
        Me.rdoNoDiscount.TabIndex = 10
        Me.rdoNoDiscount.TabStop = True
        Me.rdoNoDiscount.Text = "No Discount"
        '
        'lblTotalAmt
        '
        Me.lblTotalAmt.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAmt.Location = New System.Drawing.Point(32, 232)
        Me.lblTotalAmt.Name = "lblTotalAmt"
        Me.lblTotalAmt.Size = New System.Drawing.Size(128, 24)
        Me.lblTotalAmt.TabIndex = 2
        Me.lblTotalAmt.Text = "Total Amount Due Php:"
        '
        'txtTotalAmt
        '
        Me.txtTotalAmt.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalAmt.Location = New System.Drawing.Point(160, 232)
        Me.txtTotalAmt.Name = "txtTotalAmt"
        Me.txtTotalAmt.ReadOnly = True
        Me.txtTotalAmt.Size = New System.Drawing.Size(248, 22)
        Me.txtTotalAmt.TabIndex = 3
        Me.txtTotalAmt.Text = "0"
        Me.txtTotalAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmdCompute
        '
        Me.cmdCompute.BackColor = System.Drawing.Color.LightGray
        Me.cmdCompute.Font = New System.Drawing.Font("Transformers Movie", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCompute.Location = New System.Drawing.Point(48, 272)
        Me.cmdCompute.Name = "cmdCompute"
        Me.cmdCompute.Size = New System.Drawing.Size(88, 24)
        Me.cmdCompute.TabIndex = 14
        Me.cmdCompute.Text = "&COMPUTE"
        '
        'cmdReset
        '
        Me.cmdReset.BackColor = System.Drawing.Color.LightGray
        Me.cmdReset.Font = New System.Drawing.Font("Transformers Movie", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReset.Location = New System.Drawing.Point(160, 272)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(88, 24)
        Me.cmdReset.TabIndex = 15
        Me.cmdReset.Text = "&RESET"
        '
        'cmdExit
        '
        Me.cmdExit.BackColor = System.Drawing.Color.LightGray
        Me.cmdExit.Font = New System.Drawing.Font("Transformers Movie", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.Location = New System.Drawing.Point(272, 272)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(88, 24)
        Me.cmdExit.TabIndex = 16
        Me.cmdExit.Text = "E&XIT"
        '
        'frmOrderingSystem
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Orange
        Me.ClientSize = New System.Drawing.Size(432, 322)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdReset)
        Me.Controls.Add(Me.cmdCompute)
        Me.Controls.Add(Me.txtTotalAmt)
        Me.Controls.Add(Me.lblTotalAmt)
        Me.Controls.Add(Me.grpDiscount)
        Me.Controls.Add(Me.grpFoodMenu)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmOrderingSystem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ORDERING SYSTEM"
        Me.grpFoodMenu.ResumeLayout(False)
        Me.grpDiscount.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub cmdCompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCompute.Click
        Dim hamburger, frenchfries, sundae, spaghetti, friedchicken, totalamt, discount As Decimal
        If chkHamburger.Checked = True Then
            hamburger = Val(txtHamburger.Text) * 20.0
        Else
            hamburger = 0
        End If
        If chkFrenchFries.Checked = True Then
            frenchfries = Val(txtFrenchFries.Text) * 26.75
        Else
            frenchfries = 0
        End If
        If chkSundae.Checked = True Then
            sundae = Val(txtSundae.Text) * 18.25
        Else
            sundae = 0
        End If
        If chkSpaghetti.Checked = True Then
            spaghetti = Val(txtSpaghetti.Text) * 38.5
        Else
            spaghetti = 0
        End If
        If chkFriedChicken.Checked = True Then
            friedchicken = Val(txtFriedChicken.Text) * 45.0
        Else
            friedchicken = 0
        End If
        totalamt = hamburger + frenchfries + sundae + spaghetti + friedchicken
        If (rdoNoDiscount.Checked = True) Then
            discount = 0
        ElseIf (rdo5Discount.Checked = True) Then
            discount = 0.05
        ElseIf (rdo10Discount.Checked = True) Then
            discount = 0.1
        ElseIf (rdo20Discount.Checked = True) Then
            discount = 0.2
        End If
        totalamt -= (totalamt * discount)
        txtTotalAmt.Text = totalamt
    End Sub

    Private Sub cmdReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReset.Click
        chkHamburger.Checked = False
        chkFrenchFries.Checked = False
        chkSundae.Checked = False
        chkSpaghetti.Checked = False
        chkFriedChicken.Checked = False
        txtHamburger.Text = 0
        txtHamburger.Enabled = False
        txtFrenchFries.Text = 0
        txtFrenchFries.Enabled = False
        txtSundae.Text = 0
        txtSundae.Enabled = False
        txtSpaghetti.Text = 0
        txtSpaghetti.Enabled = False
        txtFriedChicken.Text = 0
        txtFriedChicken.Enabled = False
        txtTotalAmt.Text = 0
        rdoNoDiscount.Checked = True
        rdo5Discount.Checked = False
        rdo10Discount.Checked = False
        rdo20Discount.Checked = False
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Dim reply As DialogResult
        reply = MsgBox("Are you sure you want to exit the Ordering System Program?", MsgBoxStyle.OKCancel + MsgBoxStyle.Question, "Ordering System Program")
        If reply = DialogResult.OK Then
            End
        End If
    End Sub

    Private Sub txtHamburger_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHamburger.TextChanged
        If (IsNumeric(txtHamburger.Text) = True) Then
        Else
            txtHamburger.Clear()
        End If
    End Sub

    Private Sub txtFrenchFries_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFrenchFries.TextChanged
        If (IsNumeric(txtFrenchFries.Text) = True) Then
        Else
            txtFrenchFries.Clear()
        End If
    End Sub

    Private Sub txtSundae_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSundae.TextChanged
        If (IsNumeric(txtSundae.Text) = True) Then
        Else
            txtSundae.Clear()
        End If
    End Sub

    Private Sub txtFriedChicken_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFriedChicken.TextChanged
        If (IsNumeric(txtFriedChicken.Text) = True) Then
        Else
            txtFriedChicken.Clear()
        End If
    End Sub

    Private Sub txtSpaghetti_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSpaghetti.TextChanged
        If (IsNumeric(txtSpaghetti.Text) = True) Then
        Else
            txtSpaghetti.Clear()
        End If
    End Sub

    Private Sub chkHamburger_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkHamburger.CheckStateChanged
        If (chkHamburger.CheckState = CheckState.Checked) Then
            txtHamburger.Enabled = True
        ElseIf (chkHamburger.CheckState = CheckState.Unchecked) Then
            txtHamburger.Enabled = False
        End If
    End Sub

    Private Sub chkFrenchFries_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkFrenchFries.CheckStateChanged
        If (chkFrenchFries.CheckState = CheckState.Checked) Then
            txtFrenchFries.Enabled = True
        ElseIf (chkFrenchFries.CheckState = CheckState.Unchecked) Then
            txtFrenchFries.Enabled = False
        End If
    End Sub

    Private Sub chkFriedChicken_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkFriedChicken.CheckStateChanged
        If (chkFriedChicken.CheckState = CheckState.Checked) Then
            txtFriedChicken.Enabled = True
        ElseIf (chkFriedChicken.CheckState = CheckState.Unchecked) Then
            txtFriedChicken.Enabled = False
        End If
    End Sub

    Private Sub chkSpaghetti_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkSpaghetti.CheckStateChanged
        If (chkSpaghetti.CheckState = CheckState.Checked) Then
            txtSpaghetti.Enabled = True
        ElseIf (chkSpaghetti.CheckState = CheckState.Unchecked) Then
            txtSpaghetti.Enabled = False
        End If
    End Sub

    Private Sub chkSundae_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkSundae.CheckStateChanged
        If (chkSundae.CheckState = CheckState.Checked) Then
            txtSundae.Enabled = True
        ElseIf (chkSundae.CheckState = CheckState.Unchecked) Then
            txtSundae.Enabled = False
        End If
    End Sub
End Class