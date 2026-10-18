Imports System.Data.SqlClient

Public Class frmSellPage
    Public CarPlateNum As String
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        frmMain.Show()

    End Sub

    Private Sub frmSellPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FilterData("")

    End Sub
    Public Sub FilterData(SearchValue As String)
        Dim connection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\GroupProject\GroupProject\car.mdf;Integrated Security=True")
        Dim searchQuery As String = "SELECT * From Car  WHERE CONCAT(Plate, Brand, Model, Transmission, Color, Condition, Year, Mileage, Price, Engine_Capacity) like '%" & SearchValue & "%'"
        Dim command As New SqlCommand(searchQuery, connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)
        dgvCarData.DataSource = table


    End Sub

    Private Sub btnDeleteCar_Click(sender As Object, e As EventArgs) Handles btnDeleteCar.Click
        If dgvCarData.SelectedRows.Count > 0 Then
            Dim selectedCarPlate As String = dgvCarData.SelectedRows(0).Cells("Plate").Value.ToString()

            Dim con As New SqlConnection
            Dim cmd As New SqlCommand

            ' Delete car 
            con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\GroupProject\GroupProject\car.mdf;Integrated Security=True"
            con.Open()

            cmd = New SqlCommand("DELETE FROM Car WHERE Plate = '" & selectedCarPlate & "'", con)
            cmd.ExecuteNonQuery()

            con.Close()

            ' Remove the deleted row from the DataGridView
            dgvCarData.Rows.RemoveAt(dgvCarData.SelectedRows(0).Index)

            Dim result As DialogResult = MessageBox.Show("Do you want to stay in this form?", "SUCCESSFULLY DELETED", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

            If result = DialogResult.No Then
                ' User chose to close the form and show frmMain
                Me.Close()
                frmMain.Show()
            End If

        Else
            MessageBox.Show("Please Select The Car That You Want To Delete.")
        End If


    End Sub

    Private Sub dgvCarData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCarData.CellContentClick
        If dgvCarData.SelectedRows.Count > 0 Then
            Dim selectedCarPLate As String = (dgvCarData.SelectedRows(0).Cells("Plate").Value)
            CarPlateNum = selectedCarPLate

        End If
    End Sub

    Private Sub btnAddCar_Click(sender As Object, e As EventArgs) Handles btnAddCar.Click

        Me.Close()
        frmAddCar.Show()
    End Sub

    Private Sub btnUpdateCar_Click(sender As Object, e As EventArgs) Handles btnUpdateCar.Click
        Me.Close()
        frmUpdateCar.ShowDialog()
    End Sub

    Private Sub btnSearchCar_Click(sender As Object, e As EventArgs) Handles btnSearchCar.Click
        FilterData(txtSearchCar.Text)

    End Sub

    Private Sub btnClearSearch_Click(sender As Object, e As EventArgs) Handles btnClearSearch.Click
        txtSearchCar.Clear()
        FilterData("")

    End Sub
End Class