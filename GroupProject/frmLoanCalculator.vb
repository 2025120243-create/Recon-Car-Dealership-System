Public Class frmLoanCalculator
    Dim dblcarPrice As Decimal
    Dim dblInterestRate As Double
    Public dblMonthlyPayment As Double
    Public dblMonthlyInterest As Double
    Public blnLoan As Boolean = False

    Private Sub frmLoanCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCarPriceLoan.Text = "RM " & frmBuyPage.CarPrice
        dblcarPrice = frmBuyPage.CarPrice
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim dblDownPayment As Double
        Dim intYears As Integer
        Dim intMonths As Integer
        Dim dblLoan As Double
        Dim dblInterest As Double
        Dim dblMonthlyIncome As Double
        Dim percentageincome As Double
        Dim blnInputOK As Boolean = True

        If Not Double.TryParse(txtDownPayment.Text, dblDownPayment) Then
            lblMessage.Text = "Please Input A Valid Down Payment"
            blnInputOK = False
        End If
        If Not Double.TryParse(txtLoanDuration.Text, intYears) Then
            lblMessage.Text = "Please Input A Valid Loan Duration"
            blnInputOK = False
        End If

        If Not Double.TryParse(txtMontlyIncome.Text, dblMonthlyIncome) Then
            lblMessage.Text = "Please Input A Valid Monthly Income"
            blnInputOK = False
        End If
        If lstAnnualRate.SelectedIndex = -1 Then
            lblMessage.Text = "Please Select An Annual Interest Rate"
            blnInputOK = False
        End If

        If Double.TryParse(txtDownPayment.Text, dblDownPayment) AndAlso dblDownPayment > frmBuyPage.CarPrice Then
            lblMessage.Text = "Down Payment cannot exceed the Car Price."
            blnInputOK = False
        End If


        If blnInputOK = True Then
            lblMessage.Text = String.Empty
            intMonths = intYears * 12
            Double.TryParse(lstAnnualRate.SelectedItem.ToString, dblInterestRate)
            dblInterest = dblInterestRate / 100 * dblcarPrice * intYears
            dblMonthlyInterest = dblInterest / (intYears * 12)

            dblLoan = dblcarPrice - dblDownPayment
            dblMonthlyPayment = (dblLoan + dblInterest) / (intYears * 12)

            percentageincome = dblMonthlyPayment / dblMonthlyIncome * 100
            If percentageincome > 30 Then
                MessageBox.Show("You are not applicable for this loan since the monthly payment is more than 30% of your income.Please make a new one.", "LOAN IS NOT APPLICABLE", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If vbOK Then
                    txtDownPayment.Text = String.Empty
                    txtLoanDuration.Text = String.Empty
                    lstAnnualRate.SelectedIndex = -1
                    lblMessage.Text = String.Empty
                    txtMontlyIncome.Text = String.Empty
                    txtDownPayment.Focus()
                    dblMonthlyPayment = 0
                    dblMonthlyInterest = 0
                End If


            Else
                lblMessage.Text = "Monthly Payment : RM " & dblMonthlyPayment.ToString("F2") & " Monthly Interest : RM " & dblMonthlyInterest.ToString("F2")


            End If


        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtDownPayment.Text = String.Empty
        txtLoanDuration.Text = String.Empty
        lstAnnualRate.SelectedIndex = -1
        lblMessage.Text = String.Empty
        txtMontlyIncome.Text = String.Empty
        txtDownPayment.Focus()
        dblMonthlyPayment = 0
        dblMonthlyInterest = 0

    End Sub





    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        frmBuyPage.Show()
        Me.Hide()

    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        If dblMonthlyPayment = 0 Then
            MessageBox.Show("PLEASE MAKE YOUR LOAN FIRST", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            blnLoan = True
            frmRegistration.ShowDialog()
            Me.Hide()
        End If
    End Sub

End Class