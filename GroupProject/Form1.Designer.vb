<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnSellCar = New System.Windows.Forms.Button()
        Me.btnBuyCar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSellCar
        '
        Me.btnSellCar.BackColor = System.Drawing.SystemColors.Control
        Me.btnSellCar.Font = New System.Drawing.Font("Momcake", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSellCar.Location = New System.Drawing.Point(11, 289)
        Me.btnSellCar.Name = "btnSellCar"
        Me.btnSellCar.Size = New System.Drawing.Size(379, 66)
        Me.btnSellCar.TabIndex = 1
        Me.btnSellCar.Text = "MANAGE CAR"
        Me.btnSellCar.UseVisualStyleBackColor = False
        '
        'btnBuyCar
        '
        Me.btnBuyCar.BackColor = System.Drawing.SystemColors.Control
        Me.btnBuyCar.Font = New System.Drawing.Font("Momcake", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuyCar.Location = New System.Drawing.Point(408, 289)
        Me.btnBuyCar.Name = "btnBuyCar"
        Me.btnBuyCar.Size = New System.Drawing.Size(379, 66)
        Me.btnBuyCar.TabIndex = 2
        Me.btnBuyCar.Text = "Buy A Car"
        Me.btnBuyCar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Perpetua Titling MT", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(60, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(674, 33)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "PARUH RAJAWALI RECON CAR DEALERSHIP"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.Control
        Me.btnExit.Font = New System.Drawing.Font("Momcake", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(206, 361)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(379, 66)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.BackColor = System.Drawing.Color.Transparent
        Me.LogoPictureBox.BackgroundImage = Global.GroupProject.My.Resources.Resources.photo_2024_01_10_22_47_52_removebg_preview
        Me.LogoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LogoPictureBox.Location = New System.Drawing.Point(263, 45)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(242, 230)
        Me.LogoPictureBox.TabIndex = 6
        Me.LogoPictureBox.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BackgroundImage = Global.GroupProject.My.Resources.Resources.HD_wallpaper_nissan_drift_drifting_cars_cars_drift_tires_smoke
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(800, 451)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBuyCar)
        Me.Controls.Add(Me.btnSellCar)
        Me.DoubleBuffered = True
        Me.Name = "frmMain"
        Me.Text = "MAIN PAGE"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSellCar As Button
    Friend WithEvents btnBuyCar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents LogoPictureBox As PictureBox
End Class
