
Public Class frmMain
    Private Sub btnBuyCar_Click(sender As Object, e As EventArgs) Handles btnBuyCar.Click
        frmBuyPage.Show()
        Me.Hide()
    End Sub

    Private Sub btnSellCar_Click(sender As Object, e As EventArgs) Handles btnSellCar.Click
        frmSellPage.Show()
        Me.Hide()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim result As DialogResult = MessageBox.Show("Are You Sure Want To Exit?", "Attention!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Close()
        End If

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
