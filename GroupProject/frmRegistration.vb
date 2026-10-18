Imports System.Data.SqlClient

Public Class frmRegistration
    Public strName As String
    Public strIcNum As String
    Public strLicenseNum As String
    Public strPhoneNum As String
    Public strEmail As String
    Public strAddress As String


    Private Sub frmRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCarPrice.Text = "RM " & frmBuyPage.CarPrice
        lblCarModel.Text = frmBuyPage.CarModel
        lblBrand.Text = frmBuyPage.CarBrand
        lblYear.Text = frmBuyPage.CarYear
        lblCarPlate.Text = frmBuyPage.CarPLate
        lblEngineCap.Text = frmBuyPage.CarEngineCap
        lblRoadTax.Text = "RM " & frmBuyPage.RoadTax


    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        If txtName.Text = "" Or txtICNum.Text = "" Or txtLicenseNum.Text = "" Or txtPhoneNum.Text = "" Or txtEmail.Text = "" Or txtAddress.Text = "" Then
            MessageBox.Show("PLEASE FILL IN ALL THE INFORMATION !", "Important", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim result As DialogResult = MessageBox.Show("ARE YOU SURE TO BUY THIS CAR ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                strName = txtName.Text
                strIcNum = txtICNum.Text
                strLicenseNum = txtLicenseNum.Text
                strPhoneNum = txtPhoneNum.Text
                strEmail = txtEmail.Text
                strAddress = txtAddress.Text

                frmConfirmDetails.Show()
                Me.Hide()

            End If
        End If

    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtName.Text = String.Empty
        txtICNum.Text = String.Empty
        txtLicenseNum.Text = String.Empty
        txtEmail.Text = String.Empty
        txtAddress.Text = String.Empty
        txtPhoneNum.Text = String.Empty


        txtName.Focus()


    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        frmBuyPage.Show()

    End Sub
End Class


