Public Class frmCarInfo
    Dim carpic As String
    Private Sub frmCarInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        lblBrand.Text = frmBuyPage.CarBrand
        lblModel.Text = frmBuyPage.CarModel
        lblColor.Text = frmBuyPage.CarColor
        lblCondition.Text = frmBuyPage.CarCondition
        lblMileage.Text = frmBuyPage.CarMileage
        lblPlate.Text = frmBuyPage.CarPLate
        lblTrans.Text = frmBuyPage.CarTrans
        lblYear.Text = frmBuyPage.CarYear
        lblEngineCap.Text = frmBuyPage.CarEngineCap
        lblPrice.Text = "RM " & frmBuyPage.CarPrice
        lblRoadTax.Text = "RM " & frmBuyPage.RoadTax


    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        frmBuyPage.Show()

    End Sub

End Class