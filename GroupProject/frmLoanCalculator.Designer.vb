<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoanCalculator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblCarPriceLoan = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtMontlyIncome = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtLoanDuration = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDownPayment = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lstAnnualRate = New System.Windows.Forms.ListBox()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblCarPriceLoan
        '
        Me.lblCarPriceLoan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCarPriceLoan.Location = New System.Drawing.Point(188, 24)
        Me.lblCarPriceLoan.Name = "lblCarPriceLoan"
        Me.lblCarPriceLoan.Size = New System.Drawing.Size(179, 23)
        Me.lblCarPriceLoan.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtMontlyIncome)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtLoanDuration)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtDownPayment)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblCarPriceLoan)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(382, 148)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "LOAN INFORMATION"
        '
        'txtMontlyIncome
        '
        Me.txtMontlyIncome.Location = New System.Drawing.Point(188, 106)
        Me.txtMontlyIncome.Name = "txtMontlyIncome"
        Me.txtMontlyIncome.Size = New System.Drawing.Size(179, 22)
        Me.txtMontlyIncome.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(58, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Monthly Income :"
        '
        'txtLoanDuration
        '
        Me.txtLoanDuration.Location = New System.Drawing.Point(188, 79)
        Me.txtLoanDuration.Name = "txtLoanDuration"
        Me.txtLoanDuration.Size = New System.Drawing.Size(179, 22)
        Me.txtLoanDuration.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Loan Duration (Years) :"
        '
        'txtDownPayment
        '
        Me.txtDownPayment.Location = New System.Drawing.Point(188, 52)
        Me.txtDownPayment.Name = "txtDownPayment"
        Me.txtDownPayment.Size = New System.Drawing.Size(179, 22)
        Me.txtDownPayment.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(61, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Down Payment :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(96, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Car Price :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Perpetua Titling MT", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(317, 33)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "LOAN CALCULATOR"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lstAnnualRate)
        Me.GroupBox2.Location = New System.Drawing.Point(412, 56)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(376, 148)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ANNUAL INTEREST RATE(%)"
        '
        'lstAnnualRate
        '
        Me.lstAnnualRate.BackColor = System.Drawing.SystemColors.Control
        Me.lstAnnualRate.FormattingEnabled = True
        Me.lstAnnualRate.ItemHeight = 16
        Me.lstAnnualRate.Items.AddRange(New Object() {"2.0", "2.5", "3.0", "3.5", "4.0", "4.5", "5.0"})
        Me.lstAnnualRate.Location = New System.Drawing.Point(7, 22)
        Me.lstAnnualRate.Name = "lstAnnualRate"
        Me.lstAnnualRate.ScrollAlwaysVisible = True
        Me.lstAnnualRate.Size = New System.Drawing.Size(261, 84)
        Me.lstAnnualRate.TabIndex = 0
        '
        'lblMessage
        '
        Me.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMessage.Location = New System.Drawing.Point(12, 207)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(775, 37)
        Me.lblMessage.TabIndex = 8
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.SystemColors.Control
        Me.btnCalculate.Font = New System.Drawing.Font("Momcake", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(15, 332)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(379, 55)
        Me.btnCalculate.TabIndex = 9
        Me.btnCalculate.Text = "CALCULATE"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.Control
        Me.btnClear.Font = New System.Drawing.Font("Momcake", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(401, 332)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(387, 55)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.Control
        Me.btnCancel.Font = New System.Drawing.Font("Momcake", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(15, 393)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(379, 55)
        Me.btnCancel.TabIndex = 12
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.SystemColors.Control
        Me.btnConfirm.Font = New System.Drawing.Font("Momcake", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.Location = New System.Drawing.Point(401, 393)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(384, 55)
        Me.btnConfirm.TabIndex = 13
        Me.btnConfirm.Text = "CONFIRM"
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'frmLoanCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.GroupProject.My.Resources.Resources.photo_2024_01_10_23_12_16
        Me.ClientSize = New System.Drawing.Size(800, 461)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmLoanCalculator"
        Me.Text = "LOAN CALCULATOR"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCarPriceLoan As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDownPayment As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtLoanDuration As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lstAnnualRate As ListBox
    Friend WithEvents lblMessage As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnConfirm As Button
    Friend WithEvents txtMontlyIncome As TextBox
    Friend WithEvents Label5 As Label
End Class
