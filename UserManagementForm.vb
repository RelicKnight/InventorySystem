Imports System.Configuration
Imports Microsoft.Data.SqlClient

Public Class UserManagementForm
    ' Connection string to the database
    Dim connectionString As String = ConfigurationManager.ConnectionStrings("InventoryDB").ConnectionString
    Private userRole As String ' Store the role of the logged-in user

    ' Constructor accepting the user role
    Public Sub New(role As String)
        InitializeComponent()
        userRole = role
    End Sub

    ' On Form Load
    Private Sub UserManagementForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblLoggedInAdmin.Text = "Role: " & userRole ' Display the role of the logged-in user

        LoadUserList() ' Load the user list into DataGridView

        ' Populate the ComboBox with predefined roles
        cmbRole.Items.AddRange(New String() {"Admin", "Staff"})
        cmbRole.SelectedIndex = 0 ' Set default to "Admin"
        lblUserID.Text = "Auto Incremented"
    End Sub

    ' Back Button Logic
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If userRole = "Admin" Then
            Dim adminDashboard As New AdminDashboardForm() ' Ensure this matches the constructor of AdminDashboardForm
            adminDashboard.Show()
        ElseIf userRole = "Staff" Then
            ' If InventoryManagementForm requires arguments, pass them here
            Dim inventoryDashboard As New InventoryManagementForm(userRole) ' Adjust the constructor call based on the form's requirements
            inventoryDashboard.Show()
        End If

        ' Close the current form
        Me.Close()
    End Sub



    ' Load Users into DataGridView
    Private Sub LoadUserList()
        Dim query As String = "SELECT UserID, Username, Password, Role FROM Users WHERE Username LIKE @Search"
        Using conn As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@Search", "%" & txtSearch.Text & "%")

            Try
                conn.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                Dim dt As New DataTable()
                dt.Load(reader)

                dgvUserList.DataSource = dt
            Catch ex As Exception
                MessageBox.Show("Error loading user list: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Add User Logic
    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        If String.IsNullOrWhiteSpace(txtUsername.Text) OrElse String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MessageBox.Show("Please fill out all fields.")
            Return
        End If

        Using conn As New SqlConnection(connectionString)
            Dim query As String = "INSERT INTO Users (Username, Password, Role) VALUES (@Username, @Password, @Role)"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@Username", txtUsername.Text)
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text)
            cmd.Parameters.AddWithValue("@Role", cmbRole.SelectedItem.ToString())

            Try
                conn.Open()
                cmd.ExecuteNonQuery()
                MessageBox.Show("User added successfully.")
                LoadUserList()
                ClearFields()
            Catch ex As Exception
                MessageBox.Show("Error adding user: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Update User Logic
    Private Sub btnUpdateUser_Click(sender As Object, e As EventArgs) Handles btnUpdateUser.Click
        If String.IsNullOrWhiteSpace(txtUsername.Text) OrElse String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MessageBox.Show("Please fill out all fields.")
            Return
        End If

        Using conn As New SqlConnection(connectionString)
            Dim query As String = "UPDATE Users SET Username = @Username, Password = @Password, Role = @Role WHERE UserID = @UserID"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@UserID", lblUserID.Text)
            cmd.Parameters.AddWithValue("@Username", txtUsername.Text)
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text)
            cmd.Parameters.AddWithValue("@Role", cmbRole.SelectedItem.ToString())

            Try
                conn.Open()
                cmd.ExecuteNonQuery()
                MessageBox.Show("User updated successfully.")
                LoadUserList()
                ClearFields()
            Catch ex As Exception
                MessageBox.Show("Error updating user: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Delete User Logic
    Private Sub btnDeleteUser_Click(sender As Object, e As EventArgs) Handles btnDeleteUser.Click
        If lblUserID.Text = "" Then
            MessageBox.Show("Please select a user to delete.")
            Return
        End If

        Dim confirm = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Deletion", MessageBoxButtons.YesNo)
        If confirm = DialogResult.Yes Then
            Using conn As New SqlConnection(connectionString)
                Dim query As String = "DELETE FROM Users WHERE UserID = @UserID"
                Dim cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@UserID", lblUserID.Text)

                Try
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("User deleted successfully.")
                    LoadUserList()
                Catch ex As Exception
                    MessageBox.Show("Error deleting user: " & ex.Message)
                End Try
            End Using
        End If
    End Sub

    ' Clear Fields
    Private Sub ClearFields()
        lblUserID.Text = "Auto Incremented"
        txtUsername.Clear()
        txtPassword.Clear()
        txtSearch.Clear()
        cmbRole.SelectedIndex = -1
        btnAddUser.Enabled = True
        btnUpdateUser.Enabled = False
    End Sub

    ' Handle User Selection
    Private Sub dgvUserList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUserList.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvUserList.Rows(e.RowIndex)
            lblUserID.Text = row.Cells("UserID").Value.ToString()
            txtUsername.Text = row.Cells("Username").Value.ToString()
            txtPassword.Text = row.Cells("Password").Value.ToString()
            cmbRole.SelectedItem = row.Cells("Role").Value.ToString()

            btnAddUser.Enabled = False
            btnUpdateUser.Enabled = True
        End If
    End Sub

    ' Handle Search
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadUserList()
    End Sub


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Reset the form fields to their initial state
        ClearFields()
    End Sub
End Class
