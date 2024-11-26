Imports System.Configuration
Imports Microsoft.Data.SqlClient

Public Class AdminDashboardForm
    ' Initialize the connection string from App.config
    Dim connectionString As String = ConfigurationManager.ConnectionStrings("InventoryDB").ConnectionString

    ' Button click event for logging out
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        ' Show the login form and hide the current admin dashboard
        LoginForm.Show()
        Me.Hide() ' Hide Admin Dashboard
    End Sub

    ' Button click event for Inventory Management
    Private Sub btnManageInventory_Click(sender As Object, e As EventArgs) Handles btnManageInventory.Click
        ' Show the Inventory Management form
        InventoryManagementForm.Show()
        Me.Hide() ' Hide Admin Dashboard
    End Sub

    ' Button click event for User Management (Staff)
    Private Sub btnManageUsers_Click(sender As Object, e As EventArgs) Handles btnManageUsers.Click
        ' Show the User Management form
        UserManagementForm.Show()
        Me.Hide() ' Hide Admin Dashboard
    End Sub

    ' Button click event for Registering New Staff
    Private Sub btnRegisterStaff_Click(sender As Object, e As EventArgs) Handles btnRegisterStaff.Click
        ' Show the Register Staff form
        RegisterStaffForm.Show()
        Me.Hide() ' Hide Admin Dashboard
    End Sub
End Class
