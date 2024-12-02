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
        ' Create a new instance of InventoryManagementForm and pass the role
        Dim inventoryManagement As New InventoryManagementForm("Admin")
        inventoryManagement.Show() ' Show the Inventory Management form
        Me.Hide() ' Hide Admin Dashboard
    End Sub

    ' Button click event for User Management 
    Private Sub btnManageUsers_Click(sender As Object, e As EventArgs) Handles btnManageUsers.Click
        ' Create an instance of the UserManagementForm
        Dim userManagement As New UserManagementForm("Admin") ' Pass the role "Admin" to the UserManagementForm
        userManagement.Show() ' Show the UserManagementForm
        Me.Hide() ' Hide Admin Dashboard
    End Sub

End Class
