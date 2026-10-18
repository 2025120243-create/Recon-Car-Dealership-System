Imports System.Data.SqlClient
Imports System.Data
Imports System.Xml.Schema

Public Class frmUpdateCar
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\GroupProject\GroupProject\car.mdf;Integrated Security=True"
            con.Open()
            cmd.Connection = con
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT * FROM Car WHERE PLate ='" & txtPlate.Text & "' "
            dr = cmd.ExecuteReader
            If Not dr.HasRows Then
                MessageBox.Show("The Car Is Not Registered Yet. ")
                con.Close()
                txtBrand.Clear()
                txtModel.Clear()
                txtColor.Clear()
                txtCondition.Clear()
                txtMileage.Clear()
                txtPlate.Clear()
                txtPrice.Clear()
                txtTransmission.Clear()
                txtEngineCap.Clear()
                txtYear.Clear()
            Else
                con.Close()
                con.Open()
                cmd = New SqlCommand("UPDATE Car SET Brand = @Brand, Model = @Model, Transmission = @Transmission, Color = @Color, Condition = @Condition, Year = @Year, Mileage = @Mileage, Price = @Price, Engine_Capacity = @EngineCap WHERE Plate = @Plate", con)
                cmd.Parameters.AddWithValue("@Brand", txtBrand.Text)
                cmd.Parameters.AddWithValue("@Model", txtModel.Text)
                cmd.Parameters.AddWithValue("@Transmission", txtTransmission.Text)
                cmd.Parameters.AddWithValue("@Color", txtColor.Text)
                cmd.Parameters.AddWithValue("@Condition", txtCondition.Text)
                cmd.Parameters.AddWithValue("@Year", txtYear.Text)
                cmd.Parameters.AddWithValue("@Mileage", txtMileage.Text)
                cmd.Parameters.AddWithValue("@Price", txtPrice.Text)
                cmd.Parameters.AddWithValue("@EngineCap", txtEngineCap.Text)
                cmd.Parameters.AddWithValue("@Plate", txtPlate.Text)

                If (txtColor.Text = "" Or txtBrand.Text = "" Or txtCondition.Text = "" Or txtMileage.Text = "" Or txtModel.Text = "" Or txtPrice.Text = "" Or txtTransmission.Text = "" Or txtYear.Text = "" Or txtEngineCap.Text = "") Then
                    MessageBox.Show("Please Enter The Car Details.")

                ElseIf (txtPlate.Text.Contains(" ")) Then
                    MessageBox.Show("Please Enter A Valid Plate Number.")
                Else
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("The Car Has Successfully Updated.")
                    txtBrand.Clear()
                    txtModel.Clear()
                    txtColor.Clear()
                    txtCondition.Clear()
                    txtMileage.Clear()
                    txtPlate.Clear()
                    txtPrice.Clear()
                    txtTransmission.Clear()
                    txtEngineCap.Clear()
                    txtYear.Clear()
                    Me.Close()
                    frmSellPage.Show()



                End If
                con.Close()

            End If
            con.Close()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtBrand.Clear()
        txtModel.Clear()
        txtColor.Clear()
        txtCondition.Clear()
        txtMileage.Clear()
        txtPlate.Clear()
        txtPrice.Clear()
        txtTransmission.Clear()
        txtEngineCap.Clear()
        txtYear.Clear()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        frmSellPage.Show()

    End Sub

    Private Sub frmUpdateCar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class