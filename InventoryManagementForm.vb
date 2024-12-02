Imports System.Configuration
Imports Microsoft.Data.SqlClient

Public Class InventoryManagementForm
    ' Connection string to the database
    Dim connectionString As String = ConfigurationManager.ConnectionStrings("InventoryDB").ConnectionString
    Private userRole As String ' Store the role of the logged-in user

    ' Constructor accepting the user role
    Public Sub New(role As String)
        InitializeComponent()
        userRole = role
    End Sub

    ' On Form Load
    Private Sub InventoryManagementForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadInventoryList() ' Load the inventory list when the form loads

        ' Set the user role in the label to display the logged-in role
        lblUserRole.Text = "Logged in as: " & userRole

    End Sub

    ' Back Button Logic
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If userRole = "Admin" Then
            ' Redirect to Admin Dashboard
            Dim adminDashboard As New AdminDashboardForm()
            adminDashboard.Show()
        ElseIf userRole = "Staff" Then
            ' Redirect to Staff Dashboard
            Dim staffDashboard As New LoginForm()
            staffDashboard.Show()
        End If

        ' Close the current form
        Me.Close()
    End Sub

    ' Load Items into DataGridView
    Private Sub LoadInventoryList()
        ' Declare the query string
        Dim query As String = "SELECT ItemID, ItemName, Quantity, Price FROM Inventory WHERE ItemName LIKE @Search"

        Using conn As New SqlConnection(connectionString)
            ' Initialize the SqlCommand with the query and connection
            Dim cmd As New SqlCommand(query, conn)

            ' Add the parameter for the search term
            cmd.Parameters.AddWithValue("@Search", "%" & txtSearch.Text & "%")

            Try
                conn.Open()
                ' Execute the command and load data into the DataGridView
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                Dim dt As New DataTable()
                dt.Load(reader)

                dgvInventoryList.DataSource = dt ' Load data into DataGridView
            Catch ex As Exception
                MessageBox.Show("Error loading inventory list: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Add Item Button Logic
    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        ' Validate the inputs
        If String.IsNullOrWhiteSpace(txtItemName.Text) OrElse String.IsNullOrWhiteSpace(txtQuantity.Text) OrElse String.IsNullOrWhiteSpace(txtPrice.Text) Then
            MessageBox.Show("Please enter all item details.")
            Return
        End If

        ' Validate Quantity as Integer
        Dim quantity As Integer
        If Not Integer.TryParse(txtQuantity.Text, quantity) Then
            MessageBox.Show("Please enter a valid quantity (whole number).")
            Return
        End If

        ' Validate Price as Decimal
        Dim price As Decimal
        If Not Decimal.TryParse(txtPrice.Text, price) Then
            MessageBox.Show("Please enter a valid price (numeric value).")
            Return
        End If

        ' SQL query to insert a new item
        Using conn As New SqlConnection(connectionString)
            Dim query As String = "INSERT INTO Inventory (ItemName, Quantity, Price) VALUES (@ItemName, @Quantity, @Price)"
            Dim cmd As New SqlCommand(query, conn)

            ' Add parameters to the command
            cmd.Parameters.AddWithValue("@ItemName", txtItemName.Text)
            cmd.Parameters.AddWithValue("@Quantity", quantity)
            cmd.Parameters.AddWithValue("@Price", price)

            Try
                conn.Open()
                cmd.ExecuteNonQuery() ' Execute the insert query
                LoadInventoryList() ' Refresh the inventory list
                MessageBox.Show("Item added successfully.")
                ClearFields() ' Reset the form fields after adding a new item
            Catch ex As Exception
                MessageBox.Show("Error adding item: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Update Item Button Logic
    Private Sub btnUpdateItem_Click(sender As Object, e As EventArgs) Handles btnUpdateItem.Click
        ' Validate the inputs
        If String.IsNullOrWhiteSpace(txtItemName.Text) OrElse String.IsNullOrWhiteSpace(txtQuantity.Text) OrElse String.IsNullOrWhiteSpace(txtPrice.Text) Then
            MessageBox.Show("Please enter all item details.")
            Return
        End If

        ' Validate Quantity as Integer
        Dim quantity As Integer
        If Not Integer.TryParse(txtQuantity.Text, quantity) Then
            MessageBox.Show("Please enter a valid quantity (whole number).")
            Return
        End If

        ' Validate Price as Decimal
        Dim price As Decimal
        If Not Decimal.TryParse(txtPrice.Text, price) Then
            MessageBox.Show("Please enter a valid price (numeric value).")
            Return
        End If

        ' SQL query to update item details
        Using conn As New SqlConnection(connectionString)
            Dim query As String = "UPDATE Inventory SET ItemName = @ItemName, Quantity = @Quantity, Price = @Price WHERE ItemID = @ItemID"
            Dim cmd As New SqlCommand(query, conn)

            ' Add parameters to the command
            cmd.Parameters.AddWithValue("@ItemID", lblitemID.Text) ' Assuming you have a label for the selected item ID
            cmd.Parameters.AddWithValue("@ItemName", txtItemName.Text)
            cmd.Parameters.AddWithValue("@Quantity", quantity)
            cmd.Parameters.AddWithValue("@Price", price)

            Try
                conn.Open()
                cmd.ExecuteNonQuery() ' Execute the update query
                LoadInventoryList() ' Refresh the inventory list
                MessageBox.Show("Item updated successfully.")
                ClearFields() ' Clear the fields after update
            Catch ex As Exception
                MessageBox.Show("Error updating item: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Delete Item Button Logic
    Private Sub btnDeleteItem_Click(sender As Object, e As EventArgs) Handles btnDeleteItem.Click
        ' Check if an item has been selected
        If lblitemID.Text = "" Then
            MessageBox.Show("Please select an item to delete.")
            Return
        End If

        ' Confirm deletion
        Dim confirmResult = MessageBox.Show("Are you sure you want to delete this item?", "Confirm Delete", MessageBoxButtons.YesNo)
        If confirmResult = DialogResult.Yes Then
            ' SQL query to delete the item
            Using conn As New SqlConnection(connectionString)
                Dim query As String = "DELETE FROM Inventory WHERE ItemID = @ItemID"
                Dim cmd As New SqlCommand(query, conn)

                ' Add parameters to the command
                cmd.Parameters.AddWithValue("@ItemID", lblitemID.Text) ' Assuming you have a label for the selected item ID

                Try
                    conn.Open()
                    cmd.ExecuteNonQuery() ' Execute the delete query
                    LoadInventoryList() ' Refresh the inventory list
                    MessageBox.Show("Item deleted successfully.")
                    ClearFields() ' Reset the form fields after adding a new item
                Catch ex As Exception
                    MessageBox.Show("Error deleting item: " & ex.Message)
                End Try
            End Using
        End If
    End Sub

    ' Search Functionality
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadInventoryList() ' Reload inventory list when the search text changes
    End Sub

    ' Handle item selection from the DataGridView for updating or deleting
    Private Sub dgvInventoryList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInventoryList.CellClick
        If e.RowIndex >= 0 AndAlso dgvInventoryList.Rows(e.RowIndex).Cells("ItemID").Value IsNot DBNull.Value Then
            ' Populate the textboxes based on the selected row
            Dim row As DataGridViewRow = dgvInventoryList.Rows(e.RowIndex)
            lblitemID.Text = row.Cells("ItemID").Value.ToString() ' Set Item ID label correctly
            txtItemName.Text = row.Cells("ItemName").Value.ToString()
            txtQuantity.Text = row.Cells("Quantity").Value.ToString()
            txtPrice.Text = row.Cells("Price").Value.ToString()

            ' Enable Update button and disable Add button if a row is selected
            btnUpdateItem.Enabled = True
            btnAddItem.Enabled = False
        Else
            ' If no valid row is selected (empty row), reset everything for Add operation
            ClearFields()
            btnAddItem.Enabled = True
            btnUpdateItem.Enabled = False ' Disable Update button if no item is selected
        End If
    End Sub

    ' Reset the fields to prepare for a new item addition
    Private Sub ClearFields()
        lblitemID.Text = "Auto Incremented"
        txtItemName.Clear()
        txtQuantity.Clear()
        txtPrice.Clear()
        txtSearch.Clear()
        ' Enable the Add Item button after clearing the fields
        btnAddItem.Enabled = True
        btnUpdateItem.Enabled = False ' Disable Update button if no item is selected
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Reset the form fields to their initial state
        ClearFields()
    End Sub
End Class
