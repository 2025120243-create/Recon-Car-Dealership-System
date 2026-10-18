Imports System.Data.SqlClient

Public Class frmAddCar
    Private Sub btnAddCar_Click(sender As Object, e As EventArgs) Handles btnAddCar.Click
        Try
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\GroupProject\GroupProject\car.mdf;Integrated Security=True"
            con.Open()
            cmd.Connection = con
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT  * FROM Car WHERE Plate ='" & txtPlate.Text & "' "
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                MessageBox.Show("The Car Is Already In The List.")
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
                cmd = New SqlCommand("INSERT INTO Car VALUES('" & txtPlate.Text & "','" & txtBrand.Text & "','" & txtModel.Text & "','" & txtTransmission.Text & "','" & txtColor.Text & "','" & txtCondition.Text & "','" & txtYear.Text & "','" & txtMileage.Text & "','" & txtPrice.Text & "','" & txtEngineCap.Text & "')", con)

                If txtColor.Text = "" Or txtBrand.Text = "" Or txtCondition.Text = "" Or txtMileage.Text = "" Or txtModel.Text = "" Or txtPrice.Text = "" Or txtTransmission.Text = "" Or txtYear.Text = "" Or txtEngineCap.Text = "" Then
                    MessageBox.Show("Please Insert A Valid Data.")

                ElseIf txtPlate.Text = "" Then
                    MessageBox.Show("Please Insert A Valid Plate Number.")

                Else
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("The Car Has Successfully Added.")
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
                    frmSellPage.ShowDialog()

                End If
                con.Close()


            End If
            con.Close()

        Catch ex As Exception
            MessageBox.Show("Error")
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        frmSellPage.Show()

    End Sub
End Class