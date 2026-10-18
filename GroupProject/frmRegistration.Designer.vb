<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistration
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
        Me.lblCarPrice = New System.Windows.Forms.Label()
        Me.lblCarModel = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblBrand = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtICNum = New System.Windows.Forms.TextBox()
        Me.txtLicenseNum = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPhoneNum = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblCarPlate = New System.Windows.Forms.Label()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblEngineCap = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblRoadTax = New System.Windows.Forms.Label()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCarPrice
        '
        Me.lblCarPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCarPrice.Location = New System.Drawing.Point(180, 221)
        Me.lblCarPrice.Name = "lblCarPrice"
        Me.lblCarPrice.Size = New System.Drawing.Size(671, 23)
        Me.lblCarPrice.TabIndex = 0
        '
        'lblCarModel
        '
        Me.lblCarModel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCarModel.Location = New System.Drawing.Point(180, 94)
        Me.lblCarModel.Name = "lblCarModel"
        Me.lblCarModel.Size = New System.Drawing.Size(671, 23)
        Me.lblCarModel.TabIndex = 1
        '
        'lblYear
        '
        Me.lblYear.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblYear.Location = New System.Drawing.Point(180, 190)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(671, 23)
        Me.lblYear.TabIndex = 2
        '
        'lblBrand
        '
        Me.lblBrand.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBrand.Location = New System.Drawing.Point(180, 61)
        Me.lblBrand.Name = "lblBrand"
        Me.lblBrand.Size = New System.Drawing.Size(671, 23)
        Me.lblBrand.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(88, 226)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Car Price :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(83, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 18)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Car Brand :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(81, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Car Model :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(92, 195)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 18)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Car Year :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Perpetua Titling MT", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(312, 33)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "CUSTOMER DETAILS"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(180, 287)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(671, 22)
        Me.txtName.TabIndex = 9
        '
        'txtICNum
        '
        Me.txtICNum.Location = New System.Drawing.Point(180, 315)
        Me.txtICNum.Name = "txtICNum"
        Me.txtICNum.Size = New System.Drawing.Size(671, 22)
        Me.txtICNum.TabIndex = 10
        '
        'txtLicenseNum
        '
        Me.txtLicenseNum.Location = New System.Drawing.Point(180, 343)
        Me.txtLicenseNum.Name = "txtLicenseNum"
        Me.txtLicenseNum.Size = New System.Drawing.Size(671, 22)
        Me.txtLicenseNum.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(110, 291)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 18)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Name :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(79, 319)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 18)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "IC Number :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(42, 347)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(124, 18)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "License Number :"
        '
        'txtPhoneNum
        '
        Me.txtPhoneNum.Location = New System.Drawing.Point(180, 371)
        Me.txtPhoneNum.Name = "txtPhoneNum"
        Me.txtPhoneNum.Size = New System.Drawing.Size(671, 22)
        Me.txtPhoneNum.TabIndex = 15
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(180, 399)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(671, 22)
        Me.txtEmail.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(50, 375)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(116, 18)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Phone Number :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(55, 403)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(111, 18)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Email Address :"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(180, 427)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(671, 22)
        Me.txtAddress.TabIndex = 19
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(96, 431)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 18)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Address :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(88, 132)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(77, 18)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Car Plate :"
        '
        'lblCarPlate
        '
        Me.lblCarPlate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCarPlate.Location = New System.Drawing.Point(180, 127)
        Me.lblCarPlate.Name = "lblCarPlate"
        Me.lblCarPlate.Size = New System.Drawing.Size(671, 23)
        Me.lblCarPlate.TabIndex = 23
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.SystemColors.Control
        Me.btnRegister.Font = New System.Drawing.Font("Momcake", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.Location = New System.Drawing.Point(9, 483)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(179, 55)
        Me.btnRegister.TabIndex = 25
        Me.btnRegister.Text = "NEXT"
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.Control
        Me.btnClear.Font = New System.Drawing.Font("Momcake", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(194, 483)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(179, 55)
        Me.btnClear.TabIndex = 26
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.Control
        Me.btnCancel.Font = New System.Drawing.Font("Momcake", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(379, 483)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(179, 55)
        Me.btnCancel.TabIndex = 27
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 165)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(159, 18)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Engine Capacity (liter) :"
        '
        'lblEngineCap
        '
        Me.lblEngineCap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEngineCap.Location = New System.Drawing.Point(180, 160)
        Me.lblEngineCap.Name = "lblEngineCap"
        Me.lblEngineCap.Size = New System.Drawing.Size(671, 23)
        Me.lblEngineCap.TabIndex = 28
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(88, 262)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 18)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "Road Tax :"
        '
        'lblRoadTax
        '
        Me.lblRoadTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRoadTax.Location = New System.Drawing.Point(180, 257)
        Me.lblRoadTax.Name = "lblRoadTax"
        Me.lblRoadTax.Size = New System.Drawing.Size(671, 23)
        Me.lblRoadTax.TabIndex = 30
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.BackColor = System.Drawing.Color.Transparent
        Me.LogoPictureBox.BackgroundImage = Global.GroupProject.My.Resources.Resources.jpj_2021_logo_6C947AFF28_seeklogo_com
        Me.LogoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LogoPictureBox.Location = New System.Drawing.Point(762, 455)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(99, 86)
        Me.LogoPictureBox.TabIndex = 74
        Me.LogoPictureBox.TabStop = False
        '
        'frmRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.GroupProject.My.Resources.Resources.photo_2024_01_10_23_12_16
        Me.ClientSize = New System.Drawing.Size(873, 550)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.lblRoadTax)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lblEngineCap)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lblCarPlate)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtPhoneNum)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtLicenseNum)
        Me.Controls.Add(Me.txtICNum)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblBrand)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblCarModel)
        Me.Controls.Add(Me.lblCarPrice)
        Me.Name = "frmRegistration"
        Me.Text = "CUSTOMER DETAILS "
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCarPrice As Label
    Friend WithEvents lblCarModel As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents lblBrand As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtICNum As TextBox
    Friend WithEvents txtLicenseNum As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtPhoneNum As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblCarPlate As Label
    Friend WithEvents btnRegister As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents lblEngineCap As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lblRoadTax As Label
    Friend WithEvents LogoPictureBox As PictureBox
End Class
