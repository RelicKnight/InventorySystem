Imports System.Configuration
Imports Microsoft.Data.SqlClient

Public Class UserManagementForm
    Dim connectionString As String = ConfigurationManager.ConnectionStrings("InventoryDB").ConnectionString

    ' On Form Load
    Private Sub UserManagementForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblLoggedInAdmin.Text = LoginForm.currentUser ' Display logged-in admin
        LoadUserList() ' Load the user list
    End Sub

    ' Load Users into DataGridView with password column
    Private Sub LoadUserList()
        Using conn As New SqlConnection(connectionString)
            ' Include Password in the SELECT statement
            Dim query As String = "SELECT UserID, Username, Password, Role FROM Users WHERE Username LIKE @Search"
            Dim cmd As New SqlCommand(query, conn)

            ' Use parameterized query to prevent SQL injection
            cmd.Parameters.AddWithValue("@Search", "%" & txtSearch.Text & "%") ' Adds the search term to the query

            Try
                conn.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                Dim dt As New DataTable()
                dt.Load(reader)
                dgvUserList.DataSource = dt ' Load the filtered data into DataGridView

                ' Check the DataGridView columns
                For Each column As DataGridViewColumn In dgvUserList.Columns
                    ' If you don't want the password to be shown in the DataGridView, you can hide it like this:
                    If column.Name = "Password" Then
                        column.Visible = True ' Ensure password column is visible
                    End If
                Next
            Catch ex As Exception
                MessageBox.Show("Error loading user list: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Add User
    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        ' Ensure UserID is not part of the add query
        If String.IsNullOrWhiteSpace(txtUsername.Text) OrElse String.IsNullOrWhiteSpace(txtPassword.Text) OrElse String.IsNullOrWhiteSpace(cmbRole.Text) Then
            MessageBox.Show("Please fill in all fields to add a user.")
            Return
        End If

        Using conn As New SqlConnection(connectionString)
            Dim query As String = "INSERT INTO Users (Username, Password, Role) VALUES (@Username, @Password, @Role)"
            Dim cmd As New SqlCommand(query, conn)

            ' Add parameters
            cmd.Parameters.AddWithValue("@Username", txtUsername.Text)
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text) ' Include password
            cmd.Parameters.AddWithValue("@Role", cmbRole.Text)

            Try
                conn.Open()
                cmd.ExecuteNonQuery()
                MessageBox.Show("User added successfully!")
                LoadUserList()
            Catch ex As Exception
                MessageBox.Show("Error adding user: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Update User
    Private Sub btnUpdateUser_Click(sender As Object, e As EventArgs) Handles btnUpdateUser.Click
        If lblUserID.Text = "New" OrElse String.IsNullOrWhiteSpace(lblUserID.Text) Then
            MessageBox.Show("Please select a user to update.")
            Return
        End If

        ' Ensure that the user has filled in the required fields
        If String.IsNullOrWhiteSpace(txtUsername.Text) OrElse String.IsNullOrWhiteSpace(txtPassword.Text) OrElse String.IsNullOrWhiteSpace(cmbRole.Text) Then
            MessageBox.Show("Please fill in all fields to update the user.")
            Return
        End If

        Using conn As New SqlConnection(connectionString)
            Dim query As String = "UPDATE Users SET Username = @Username, Password = @Password, Role = @Role WHERE UserID = @UserID"
            Dim cmd As New SqlCommand(query, conn)

            ' Add parameters
            cmd.Parameters.AddWithValue("@UserID", lblUserID.Text)
            cmd.Parameters.AddWithValue("@Username", txtUsername.Text)
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text) ' Include password
            cmd.Parameters.AddWithValue("@Role", cmbRole.Text)

            Try
                conn.Open()
                cmd.ExecuteNonQuery()
                MessageBox.Show("User updated successfully!")
                LoadUserList()
            Catch ex As Exception
                MessageBox.Show("Error updating user: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Delete User
    Private Sub btnDeleteUser_Click(sender As Object, e As EventArgs) Handles btnDeleteUser.Click
        If lblUserID.Text = "New" OrElse String.IsNullOrWhiteSpace(lblUserID.Text) Then
            MessageBox.Show("Please select a user to delete.")
            Return
        End If

        If MessageBox.Show("Are you sure you want to delete this user?", "Confirm", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Using conn As New SqlConnection(connectionString)
                Dim query As String = "DELETE FROM Users WHERE UserID = @UserID"
                Dim cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@UserID", lblUserID.Text)
                Try
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("User deleted successfully!")
                    LoadUserList()
                Catch ex As Exception
                    MessageBox.Show("Error deleting user: " & ex.Message)
                End Try
            End Using
        End If
    End Sub

    ' Populate User Details on Row Click
    Private Sub dgvUserList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUserList.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvUserList.Rows(e.RowIndex)
            lblUserID.Text = row.Cells("UserID").Value.ToString()
            txtUsername.Text = row.Cells("Username").Value.ToString()
            txtPassword.Text = row.Cells("Password").Value.ToString() ' Display password for editing
            cmbRole.Text = row.Cells("Role").Value.ToString()
        End If
    End Sub
End Class
