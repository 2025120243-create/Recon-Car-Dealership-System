Imports System.Data.SqlClient
Imports System.Data

Public Class login

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\GroupProject\GroupProject\Login.mdf;Integrated Security=True"

        Dim objcon As SqlConnection = Nothing
        Dim objcmd As SqlCommand = Nothing

        Try
            objcon = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\GroupProject\GroupProject\Login.mdf;Integrated Security=True")
            objcon.Open()
            Dim stmt As String = "SELECT * FROM [User] WHERE Username ='" & txtUsername.Text & "'AND Password ='" & txtPassword.Text & "' "

            objcmd = New SqlCommand(stmt, objcon)
            Dim reader As SqlDataReader = objcmd.ExecuteReader
            If reader.Read Then
                MessageBox.Show("Login Successfully!")
                Me.Hide()
                frmMain.ShowDialog()
            Else
                MessageBox.Show("Invalid Login! Please Try Again.")
                txtPassword.Clear()
                txtUsername.Clear()
            End If
        Catch ex As Exception
            MessageBox.Show("Connection Error!")
        End Try

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Sub chkShowPass_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPass.CheckedChanged
        If (Me.chkShowPass.Checked = True) Then
            Me.txtPassword.PasswordChar = ""
        Else
            Me.txtPassword.PasswordChar = "*"c
        End If
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
