<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuyPage
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvCarList = New System.Windows.Forms.DataGridView()
        Me.txtSearchCar = New System.Windows.Forms.TextBox()
        Me.btnSearchCar = New System.Windows.Forms.Button()
        Me.btnCash = New System.Windows.Forms.Button()
        Me.btnLoanCalculator = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnClearSearch = New System.Windows.Forms.Button()
        Me.btnCarInfo = New System.Windows.Forms.Button()
        CType(Me.dgvCarList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Perpetua Titling MT", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 33)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "CAR LIST"
        '
        'dgvCarList
        '
        Me.dgvCarList.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvCarList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCarList.Location = New System.Drawing.Point(18, 93)
        Me.dgvCarList.Name = "dgvCarList"
        Me.dgvCarList.RowHeadersWidth = 51
        Me.dgvCarList.RowTemplate.Height = 24
        Me.dgvCarList.Size = New System.Drawing.Size(1285, 291)
        Me.dgvCarList.TabIndex = 5
        '
        'txtSearchCar
        '
        Me.txtSearchCar.Location = New System.Drawing.Point(18, 58)
        Me.txtSearchCar.Name = "txtSearchCar"
        Me.txtSearchCar.Size = New System.Drawing.Size(246, 22)
        Me.txtSearchCar.TabIndex = 6
        '
        'btnSearchCar
        '
        Me.btnSearchCar.BackColor = System.Drawing.SystemColors.Control
        Me.btnSearchCar.Location = New System.Drawing.Point(270, 51)
        Me.btnSearchCar.Name = "btnSearchCar"
        Me.btnSearchCar.Size = New System.Drawing.Size(95, 36)
        Me.btnSearchCar.TabIndex = 7
        Me.btnSearchCar.Text = "Search"
        Me.btnSearchCar.UseVisualStyleBackColor = False
        '
        'btnCash
        '
        Me.btnCash.BackColor = System.Drawing.SystemColors.Control
        Me.btnCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCash.Location = New System.Drawing.Point(18, 391)
        Me.btnCash.Name = "btnCash"
        Me.btnCash.Size = New System.Drawing.Size(625, 58)
        Me.btnCash.TabIndex = 8
        Me.btnCash.Text = "BUY WITH CASH"
        Me.btnCash.UseVisualStyleBackColor = False
        '
        'btnLoanCalculator
        '
        Me.btnLoanCalculator.BackColor = System.Drawing.SystemColors.Control
        Me.btnLoanCalculator.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoanCalculator.Location = New System.Drawing.Point(673, 388)
        Me.btnLoanCalculator.Name = "btnLoanCalculator"
        Me.btnLoanCalculator.Size = New System.Drawing.Size(630, 58)
        Me.btnLoanCalculator.TabIndex = 9
        Me.btnLoanCalculator.Text = "BUY WITH LOAN"
        Me.btnLoanCalculator.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.Control
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(673, 452)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(630, 58)
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnClearSearch
        '
        Me.btnClearSearch.BackColor = System.Drawing.SystemColors.Control
        Me.btnClearSearch.Location = New System.Drawing.Point(371, 51)
        Me.btnClearSearch.Name = "btnClearSearch"
        Me.btnClearSearch.Size = New System.Drawing.Size(134, 36)
        Me.btnClearSearch.TabIndex = 11
        Me.btnClearSearch.Text = "Clear Search"
        Me.btnClearSearch.UseVisualStyleBackColor = False
        '
        'btnCarInfo
        '
        Me.btnCarInfo.BackColor = System.Drawing.SystemColors.Control
        Me.btnCarInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCarInfo.Location = New System.Drawing.Point(18, 452)
        Me.btnCarInfo.Name = "btnCarInfo"
        Me.btnCarInfo.Size = New System.Drawing.Size(625, 58)
        Me.btnCarInfo.TabIndex = 12
        Me.btnCarInfo.Text = "VIEW CAR INFO"
        Me.btnCarInfo.UseVisualStyleBackColor = False
        '
        'frmBuyPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.GroupProject.My.Resources.Resources.photo_2024_01_10_23_12_16
        Me.ClientSize = New System.Drawing.Size(1315, 522)
        Me.Controls.Add(Me.btnCarInfo)
        Me.Controls.Add(Me.btnClearSearch)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnLoanCalculator)
        Me.Controls.Add(Me.btnCash)
        Me.Controls.Add(Me.btnSearchCar)
        Me.Controls.Add(Me.txtSearchCar)
        Me.Controls.Add(Me.dgvCarList)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmBuyPage"
        Me.Text = "BUY PAGE"
        CType(Me.dgvCarList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgvCarList As DataGridView
    Friend WithEvents txtSearchCar As TextBox
    Friend WithEvents btnSearchCar As Button
    Friend WithEvents btnCash As Button
    Friend WithEvents btnLoanCalculator As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnClearSearch As Button
    Friend WithEvents btnCarInfo As Button
End Class
