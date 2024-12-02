Imports System.Configuration
Imports Microsoft.Data.SqlClient

Public Class LoginForm
    ' Retrieve connection string from App.config
    Dim connectionString As String = ConfigurationManager.ConnectionStrings("InventoryDB").ConnectionString

    ' Variable to hold the current user's username
    Public Shared currentUser As String

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        ' Get username and password input from textboxes
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text
        Dim role As String = ""

        ' Query to check username and password
        Using conn As New SqlConnection(connectionString)
            ' SQL query to check if the user exists and get their role
            Dim query As String = "SELECT Role FROM Users WHERE Username = @Username AND Password = @Password COLLATE Latin1_General_BIN"
            Dim cmd As New SqlCommand(query, conn)

            ' Add parameters to prevent SQL injection
            cmd.Parameters.AddWithValue("@Username", username)
            cmd.Parameters.AddWithValue("@Password", password)

            Try
                conn.Open()
                ' Execute the query
                Dim reader As SqlDataReader = cmd.ExecuteReader()

                ' If the reader returns a result, check the role
                If reader.Read() Then
                    role = reader("Role").ToString()
                End If
            Catch ex As Exception
                MessageBox.Show("Error connecting to the database: " & ex.Message)
                ClearLoginFields() ' Clear the fields on error
                Return ' Exit the method if there's an error
            End Try
        End Using

        ' Check if the user exists and determine the role
        If role = "Admin" Then
            MessageBox.Show("Welcome, Admin!")
            ' Store the username in the shared variable
            currentUser = txtUsername.Text
            ' Redirect to AdminDashboardForm
            Me.Hide() ' Hide the login form
            AdminDashboardForm.Show() ' Show the Admin dashboard form
            ClearLoginFields() ' Clear fields after successful login
        ElseIf role = "Staff" Then
            MessageBox.Show("Welcome, Staff!")
            ' Store the username in the shared variable
            currentUser = txtUsername.Text
            ' Redirect to InventoryManagementForm directly for staff
            Me.Hide() ' Hide the login form
            Dim inventoryForm As New InventoryManagementForm(role)
            inventoryForm.Show() ' Show the Inventory Management form
            ClearLoginFields() ' Clear fields after successful login
        Else
            MessageBox.Show("Invalid username or password.")
            ClearLoginFields() ' Clear fields after failed login
        End If
    End Sub

    ' Method to clear the login fields
    Private Sub ClearLoginFields()
        txtUsername.Clear()
        txtPassword.Clear()
    End Sub


End Class
