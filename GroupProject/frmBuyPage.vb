Imports System.Data.SqlClient
Imports System.Data

Public Class frmBuyPage
    Public CarPrice As Decimal
    Public CarModel As String
    Public CarBrand As String
    Public CarYear As Integer
    Public CarPLate As String
    Public CarTrans As String

    Public CarColor As String
    Public CarCondition As String
    Public CarMileage As String
    Public CarEngineCap As Double
    Public RoadTax As Double



    Private Sub frmBuyPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FilterData("")
    End Sub
    Public Sub FilterData(SearchValue As String)
        Dim connection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\GroupProject\GroupProject\car.mdf;Integrated Security=True")
        Dim searchQuery As String = "SELECT * From Car  WHERE CONCAT(Plate, Brand, Model, Transmission, Color, Condition, Year, Mileage, Price, Engine_Capacity) like '%" & SearchValue & "%'"
        Dim command As New SqlCommand(searchQuery, connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)
        dgvCarList.DataSource = table

    End Sub

    Private Sub btnSearchCar_Click(sender As Object, e As EventArgs) Handles btnSearchCar.Click
        FilterData(txtSearchCar.Text)
    End Sub
    Private Sub dgvCarList_SelectionChanged(sender As Object, e As EventArgs) Handles dgvCarList.SelectionChanged
        If dgvCarList.SelectedRows.Count > 0 Then
            ' Get selected car and move data into variable
            Dim selectedCarPrice As Decimal = Convert.ToDecimal(dgvCarList.SelectedRows(0).Cells("Price").Value)
            Dim selectedCarModel As String = (dgvCarList.SelectedRows(0).Cells("Model").Value)
            Dim selectedCarBrand As String = (dgvCarList.SelectedRows(0).Cells("Brand").Value)
            Dim selectedCarYear As Integer = (dgvCarList.SelectedRows(0).Cells("Year").Value)
            Dim selectedCarPlate As String = (dgvCarList.SelectedRows(0).Cells("Plate").Value)
            Dim selectedCarTrans As String = (dgvCarList.SelectedRows(0).Cells("Transmission").Value)
            Dim selectedCarcolor As String = (dgvCarList.SelectedRows(0).Cells("Color").Value)
            Dim selectedCarcondition As String = (dgvCarList.SelectedRows(0).Cells("Condition").Value)
            Dim selectedCarMileage As String = (dgvCarList.SelectedRows(0).Cells("Mileage").Value)
            Dim selectedCarEngineCap As Decimal = Convert.ToDecimal(dgvCarList.SelectedRows(0).Cells("Engine_Capacity").Value)

            ' Store data in Public type variable.'
            CarBrand = selectedCarBrand
            CarYear = selectedCarYear
            CarPrice = selectedCarPrice
            CarModel = selectedCarModel
            CarPLate = selectedCarPlate
            CarTrans = selectedCarTrans

            CarColor = selectedCarcolor
            CarCondition = selectedCarcondition
            CarMileage = selectedCarMileage
            CarEngineCap = selectedCarEngineCap

            'RoadTax Calculation"
            Dim baserate As Double
            Dim progressiverate As Double
            Dim CarCC As Integer
            CarCC = CarEngineCap * 1000
            If CarCC <= 1000 Then
                baserate = 20
                RoadTax = baserate

            ElseIf CarCC > 1000 And CarCC <= 1200 Then
                baserate = 55
                RoadTax = baserate

            ElseIf CarCC > 1200 And CarCC <= 1400 Then
                baserate = 70
                RoadTax = baserate

            ElseIf CarCC > 1400 And CarCC <= 1600 Then
                baserate = 90
                RoadTax = baserate

            ElseIf CarCC > 1600 And CarCC <= 1800 Then
                baserate = 200
                progressiverate = 0.4
                RoadTax = baserate + ((CarCC - 1601) * progressiverate)

            ElseIf CarCC > 1800 And CarCC <= 2000 Then
                baserate = 280
                progressiverate = 0.5
                RoadTax = baserate + ((CarCC - 1801) * progressiverate)

            ElseIf CarCC > 2000 And CarCC <= 2500 Then
                baserate = 380
                progressiverate = 1
                RoadTax = baserate + ((CarCC - 2001) * progressiverate)

            ElseIf CarCC > 2500 And CarCC <= 3000 Then
                baserate = 880
                progressiverate = 2.5
                RoadTax = baserate + ((CarCC - 2501) * progressiverate)

            Else
                baserate = 2130
                progressiverate = 4
                RoadTax = baserate + ((CarCC - 3001) * progressiverate)

            End If


        End If
    End Sub

    Private Sub btnCash_Click(sender As Object, e As EventArgs) Handles btnCash.Click
        If dgvCarList.SelectedRows.Count > 0 Then
            frmRegistration.Show()
            Me.Hide()

        Else
            MessageBox.Show("PLEASE SELECT A CAR TO CONTINUE", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        frmMain.Show()
    End Sub

    Private Sub btnLoanCalculator_Click(sender As Object, e As EventArgs) Handles btnLoanCalculator.Click
        If dgvCarList.SelectedRows.Count > 0 Then
            Me.Hide()
            frmLoanCalculator.ShowDialog()


        Else
            MessageBox.Show("PLEASE SELECT A CAR TO CONTINUE", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnClearSearch_Click(sender As Object, e As EventArgs) Handles btnClearSearch.Click
        txtSearchCar.Text = String.Empty
        FilterData("")
    End Sub

    Private Sub btnCarInfo_Click(sender As Object, e As EventArgs) Handles btnCarInfo.Click
        If dgvCarList.SelectedRows.Count > 0 Then
            frmCarInfo.Show()

        Else
            MessageBox.Show("PLEASE SELECT A CAR TO CONTINUE", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If



    End Sub

    Private Sub dgvCarList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCarList.CellContentClick

    End Sub
End Class