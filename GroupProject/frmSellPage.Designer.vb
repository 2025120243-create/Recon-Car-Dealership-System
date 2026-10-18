<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSellPage
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
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnAddCar = New System.Windows.Forms.Button()
        Me.btnUpdateCar = New System.Windows.Forms.Button()
        Me.btnDeleteCar = New System.Windows.Forms.Button()
        Me.dgvCarData = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSearchCar = New System.Windows.Forms.TextBox()
        Me.btnSearchCar = New System.Windows.Forms.Button()
        Me.btnClearSearch = New System.Windows.Forms.Button()
        CType(Me.dgvCarData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.Control
        Me.btnCancel.Font = New System.Drawing.Font("Momcake", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(840, 400)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(179, 55)
        Me.btnCancel.TabIndex = 26
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnAddCar
        '
        Me.btnAddCar.BackColor = System.Drawing.SystemColors.Control
        Me.btnAddCar.Font = New System.Drawing.Font("Momcake", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddCar.Location = New System.Drawing.Point(12, 323)
        Me.btnAddCar.Name = "btnAddCar"
        Me.btnAddCar.Size = New System.Drawing.Size(269, 71)
        Me.btnAddCar.TabIndex = 27
        Me.btnAddCar.Text = "ADD A NEW CAR"
        Me.btnAddCar.UseVisualStyleBackColor = False
        '
        'btnUpdateCar
        '
        Me.btnUpdateCar.BackColor = System.Drawing.SystemColors.Control
        Me.btnUpdateCar.Font = New System.Drawing.Font("Momcake", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateCar.Location = New System.Drawing.Point(287, 323)
        Me.btnUpdateCar.Name = "btnUpdateCar"
        Me.btnUpdateCar.Size = New System.Drawing.Size(406, 71)
        Me.btnUpdateCar.TabIndex = 28
        Me.btnUpdateCar.Text = "UPDATE CAR INFORMATION"
        Me.btnUpdateCar.UseVisualStyleBackColor = False
        '
        'btnDeleteCar
        '
        Me.btnDeleteCar.BackColor = System.Drawing.SystemColors.Control
        Me.btnDeleteCar.Font = New System.Drawing.Font("Momcake", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteCar.Location = New System.Drawing.Point(699, 323)
        Me.btnDeleteCar.Name = "btnDeleteCar"
        Me.btnDeleteCar.Size = New System.Drawing.Size(320, 71)
        Me.btnDeleteCar.TabIndex = 29
        Me.btnDeleteCar.Text = "DELETE CAR"
        Me.btnDeleteCar.UseVisualStyleBackColor = False
        '
        'dgvCarData
        '
        Me.dgvCarData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCarData.Location = New System.Drawing.Point(12, 82)
        Me.dgvCarData.Name = "dgvCarData"
        Me.dgvCarData.RowHeadersWidth = 51
        Me.dgvCarData.RowTemplate.Height = 24
        Me.dgvCarData.Size = New System.Drawing.Size(1007, 235)
        Me.dgvCarData.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Perpetua Titling MT", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(222, 33)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "MANAGE CAR"
        '
        'txtSearchCar
        '
        Me.txtSearchCar.Location = New System.Drawing.Point(12, 54)
        Me.txtSearchCar.Name = "txtSearchCar"
        Me.txtSearchCar.Size = New System.Drawing.Size(246, 22)
        Me.txtSearchCar.TabIndex = 32
        '
        'btnSearchCar
        '
        Me.btnSearchCar.BackColor = System.Drawing.SystemColors.Control
        Me.btnSearchCar.Location = New System.Drawing.Point(264, 48)
        Me.btnSearchCar.Name = "btnSearchCar"
        Me.btnSearchCar.Size = New System.Drawing.Size(95, 28)
        Me.btnSearchCar.TabIndex = 33
        Me.btnSearchCar.Text = "Search"
        Me.btnSearchCar.UseVisualStyleBackColor = False
        '
        'btnClearSearch
        '
        Me.btnClearSearch.BackColor = System.Drawing.SystemColors.Control
        Me.btnClearSearch.Location = New System.Drawing.Point(365, 48)
        Me.btnClearSearch.Name = "btnClearSearch"
        Me.btnClearSearch.Size = New System.Drawing.Size(134, 28)
        Me.btnClearSearch.TabIndex = 34
        Me.btnClearSearch.Text = "Clear Search"
        Me.btnClearSearch.UseVisualStyleBackColor = False
        '
        'frmSellPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.GroupProject.My.Resources.Resources.photo_2024_01_10_23_12_16
        Me.ClientSize = New System.Drawing.Size(1031, 536)
        Me.Controls.Add(Me.btnClearSearch)
        Me.Controls.Add(Me.btnSearchCar)
        Me.Controls.Add(Me.txtSearchCar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvCarData)
        Me.Controls.Add(Me.btnDeleteCar)
        Me.Controls.Add(Me.btnUpdateCar)
        Me.Controls.Add(Me.btnAddCar)
        Me.Controls.Add(Me.btnCancel)
        Me.Name = "frmSellPage"
        Me.Text = "MANAGE CAR"
        CType(Me.dgvCarData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancel As Button
    Friend WithEvents btnAddCar As Button
    Friend WithEvents btnUpdateCar As Button
    Friend WithEvents btnDeleteCar As Button
    Friend WithEvents dgvCarData As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSearchCar As TextBox
    Friend WithEvents btnSearchCar As Button
    Friend WithEvents btnClearSearch As Button
End Class
