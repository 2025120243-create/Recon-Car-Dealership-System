Imports System.Data.SqlClient

Public Class frmConfirmDetails
    Private Sub frmConfirmDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblBrand.Text = frmRegistration.lblBrand.Text
        lblCarModel.Text = frmRegistration.lblCarModel.Text
        lblCarPlate.Text = frmRegistration.lblCarPlate.Text
        lblCarPrice.Text = frmRegistration.lblCarPrice.Text
        lblYear.Text = frmRegistration.lblYear.Text
        lblName.Text = frmRegistration.txtName.Text
        lblICNum.Text = frmRegistration.txtICNum.Text
        lblLicenseNum.Text = frmRegistration.txtLicenseNum.Text
        lblPhoneNum.Text = frmRegistration.txtPhoneNum.Text
        lblEmail.Text = frmRegistration.txtEmail.Text
        lblAddress.Text = frmRegistration.txtAddress.Text
        lblEngineCap.Text = frmRegistration.lblEngineCap.Text
        lblRoadTax.Text = "RM " & frmBuyPage.RoadTax

    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click

        MessageBox.Show("Thank You For Buying From Us.", "THANK YOU", MessageBoxButtons.OK, MessageBoxIcon.None)

        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        'delete car after bought by customer'
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\GroupProject\GroupProject\car.mdf;Integrated Security=True"
        con.Open()
        cmd = New SqlCommand("DELETE FROM Car WHERE Plate = '" & lblCarPlate.Text & "'", con)
        cmd.ExecuteNonQuery()
        con.Close()
        frmRegistration.txtName.Text = String.Empty
        frmRegistration.txtICNum.Text = String.Empty
        frmRegistration.txtLicenseNum.Text = String.Empty
        frmRegistration.txtEmail.Text = String.Empty
        frmRegistration.txtAddress.Text = String.Empty
        frmRegistration.txtPhoneNum.Text = String.Empty


        frmRegistration.txtName.Focus()
        pdRegistration.Print()
        Me.Close()
        frmMain.Show()


    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()

        frmRegistration.Show()


    End Sub

    Private Sub pdRegistration_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles pdRegistration.PrintPage

        'company info'
        e.Graphics.DrawString("PARUH RAJAWALI RECON CAR DEALERSHIP", New Font("Times New Roman", 20, FontStyle.Bold), Brushes.Black, 100, 10)
        e.Graphics.DrawString("Chendering, Taman Permint Jaya, Terengganu, 21080 Kuala Terengganu", New Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, 100, 40)
        e.Graphics.DrawString("Phone: 09-858-4848", New Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, 100, 70)
        e.Graphics.DrawString("Email: ParuhRajawali@gmail.com", New Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, 100, 100)

        'car info'
        e.Graphics.DrawString("CAR INFORMATION", New Font("Times New Roman", 16, FontStyle.Bold), Brushes.Black, 100, 140)

        e.Graphics.DrawString("Plate : " & lblCarPlate.Text, New Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, 100, 170)
        e.Graphics.DrawString("Brand : " & lblBrand.Text, New Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, 100, 200)
        e.Graphics.DrawString("Model : " & lblCarModel.Text, New Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, 100, 230)
        e.Graphics.DrawString("Year : " & lblYear.Text, New Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, 100, 260)
        e.Graphics.DrawString("Engine Capacity (Liter) : " & lblEngineCap.Text, New Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, 100, 290)
        e.Graphics.DrawString("Price : " & lblCarPrice.Text, New Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, 100, 320)

        'cust info'
        e.Graphics.DrawString("CUSTOMER INFORMATION", New Font("Times New Roman", 16, FontStyle.Bold), Brushes.Black, 100, 360)

        ' Draw the customer information details
        e.Graphics.DrawString("Name : " & frmRegistration.strName, New Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, 100, 390)
        e.Graphics.DrawString("IC Number : " & frmRegistration.strIcNum, New Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, 100, 420)
        e.Graphics.DrawString("License Number : " & frmRegistration.strLicenseNum, New Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, 100, 450)
        e.Graphics.DrawString("Phone Number : " & frmRegistration.strPhoneNum, New Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, 100, 480)
        e.Graphics.DrawString("Email Address : " & frmRegistration.strEmail, New Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, 100, 510)
        e.Graphics.DrawString("Address : " & frmRegistration.strAddress, New Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, 100, 540)

        e.Graphics.DrawString("PAYMENT DETAILS", New Font("Times New Roman", 16, FontStyle.Bold), Brushes.Black, 100, 580)
        If frmLoanCalculator.blnLoan = True Then
            'loan buyer'
            Dim strDownPayment = frmLoanCalculator.txtDownPayment.Text
            Dim dblDwnPaymnt = Double.Parse(strDownPayment)
            Dim dblroadtax As Double = frmBuyPage.RoadTax
            Dim dbltotal As Double = dblDwnPaymnt + dblroadtax

            e.Graphics.DrawString("Down Payment : RM" & frmLoanCalculator.txtDownPayment.Text, New Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, 100, 610)
            e.Graphics.DrawString("Road Tax : " & lblRoadTax.Text, New Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, 100, 640)
            e.Graphics.DrawString("Monthly Payment for " & frmLoanCalculator.txtLoanDuration.Text & " Years : RM" & frmLoanCalculator.dblMonthlyPayment.ToString("F2"), New Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, 100, 670)
            e.Graphics.DrawString("Total Amount : RM" & dbltotal, New Font("Times New Roman", 16, FontStyle.Bold), Brushes.Black, 100, 700)
        Else
            'cash buyer'
            Dim dblroadtax As Double = frmBuyPage.RoadTax
            Dim dblCarprice As Double = frmBuyPage.CarPrice
            Dim dbltotal As Double = dblCarprice + dblroadtax

            e.Graphics.DrawString("Payment : " & lblCarPrice.Text, New Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, 100, 610)
            e.Graphics.DrawString("Road Tax : " & lblRoadTax.Text, New Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, 100, 640)
            e.Graphics.DrawString("Total Amount : RM" & dbltotal, New Font("Times New Roman", 16, FontStyle.Bold), Brushes.Black, 100, 670)
        End If
        'date and time'
        Dim strDateTime As String = "Printed on: " & DateTime.Now.ToString("MMMM dd, yyyy - hh:mm tt")
        Dim fontDateTime As New Font("Times New Roman", 12, FontStyle.Italic)
        Dim yPosDateTime As Single = e.MarginBounds.Bottom - fontDateTime.GetHeight(e.Graphics)
        Dim rectDateTime As New RectangleF(e.MarginBounds.Left, yPosDateTime, e.MarginBounds.Width, e.MarginBounds.Bottom - yPosDateTime)
        e.Graphics.DrawString(strDateTime, fontDateTime, Brushes.Black, rectDateTime)

    End Sub
End Class