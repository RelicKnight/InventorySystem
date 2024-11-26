Imports System.Configuration
Imports Microsoft.Data.SqlClient

Public Class InventoryManagementForm
    ' Connection string to the database
    Dim connectionString As String = ConfigurationManager.ConnectionStrings("InventoryDB").ConnectionString

    ' Use the currentUser variable from LoginForm to populate "Added By"
    Private Sub InventoryManagementForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Automatically populate the "Added By" label with the logged-in user (currentUser)
        lblAddedBy.Text = LoginForm.currentUser

        LoadInventory() ' Load data into the DataGridView
    End Sub

    ' Method to load inventory data into DataGridView
    Private Sub LoadInventory()
        Using conn As New SqlConnection(connectionString)
            Dim query As String = "SELECT ItemID, ItemName, Quantity, Price, AddedBy FROM Inventory"
            Dim cmd As New SqlCommand(query, conn)

            Try
                conn.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                Dim dt As New DataTable()
                dt.Load(reader)

                dgvInventory.DataSource = dt
            Catch ex As Exception
                MessageBox.Show("Error loading inventory: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Add new inventory item
    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        ' Check for valid input before adding item
        If Not IsNumeric(txtQuantity.Text) Then
            MessageBox.Show("Please enter a valid number for Quantity.")
            Return
        End If

        If Not IsNumeric(txtPrice.Text) Then
            MessageBox.Show("Please enter a valid number for Price.")
            Return
        End If

        ' SQL query to insert new inventory item
        Using conn As New SqlConnection(connectionString)
            Dim query As String = "INSERT INTO Inventory (ItemName, Quantity, Price, AddedBy) VALUES (@ItemName, @Quantity, @Price, @AddedBy)"
            Dim cmd As New SqlCommand(query, conn)

            ' Add parameters
            cmd.Parameters.AddWithValue("@ItemName", txtItemName.Text)
            cmd.Parameters.AddWithValue("@Quantity", txtQuantity.Text)
            cmd.Parameters.AddWithValue("@Price", txtPrice.Text)
            cmd.Parameters.AddWithValue("@AddedBy", LoginForm.currentUser) ' Use currentUser to fill AddedBy

            Try
                conn.Open()
                cmd.ExecuteNonQuery()

                ' After adding, refresh the DataGridView
                LoadInventory()

                ' Clear textboxes after adding item
                txtItemName.Clear()
                txtQuantity.Clear()
                txtPrice.Clear()
                lblAddedBy.Text = "" ' Clear the AddedBy label (optional)
            Catch ex As Exception
                MessageBox.Show("Error adding item: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Update inventory item
    Private Sub btnUpdateItem_Click(sender As Object, e As EventArgs) Handles btnUpdateItem.Click
        ' Validate inputs for quantity and price
        If Not IsNumeric(txtQuantity.Text) Then
            MessageBox.Show("Please enter a valid number for Quantity.")
            Return
        End If

        If Not IsNumeric(txtPrice.Text) Then
            MessageBox.Show("Please enter a valid number for Price.")
            Return
        End If

        ' SQL query to update inventory item
        Using conn As New SqlConnection(connectionString)
            Dim query As String = "UPDATE Inventory SET ItemName = @ItemName, Quantity = @Quantity, Price = @Price, AddedBy = @AddedBy WHERE ItemID = @ItemID"
            Dim cmd As New SqlCommand(query, conn)

            ' Add parameters
            cmd.Parameters.AddWithValue("@ItemID", lblitemID.Text)
            cmd.Parameters.AddWithValue("@ItemName", txtItemName.Text)
            cmd.Parameters.AddWithValue("@Quantity", txtQuantity.Text)
            cmd.Parameters.AddWithValue("@Price", txtPrice.Text)
            cmd.Parameters.AddWithValue("@AddedBy", LoginForm.currentUser) ' Use currentUser to fill AddedBy

            Try
                conn.Open()
                cmd.ExecuteNonQuery()

                ' After updating, refresh the DataGridView
                LoadInventory()

                ' Clear textboxes after updating item
                txtItemName.Clear()
                txtQuantity.Clear()
                txtPrice.Clear()
                lblAddedBy.Text = "" ' Clear the AddedBy label (optional)
            Catch ex As Exception
                MessageBox.Show("Error updating item: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Handle clicks on the DataGridView to populate the textboxes for updating
    Private Sub dgvInventory_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInventory.CellClick
        If e.RowIndex >= 0 Then
            ' Populate the textboxes based on the selected row
            Dim row As DataGridViewRow = dgvInventory.Rows(e.RowIndex)
            lblitemID.Text = row.Cells("ItemID").Value.ToString() ' Set Item ID label
            txtItemName.Text = row.Cells("ItemName").Value.ToString()
            txtQuantity.Text = row.Cells("Quantity").Value.ToString()
            txtPrice.Text = row.Cells("Price").Value.ToString()
            lblAddedBy.Text = row.Cells("AddedBy").Value.ToString() ' You can leave this editable or fill it with current user
        End If
    End Sub

    ' Prevent invalid characters in Quantity and Price textboxes
    Private Sub txtQuantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQuantity.KeyPress
        ' Allow only numeric input and control characters like backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrice.KeyPress
        ' Allow only numeric input and control characters like backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If
    End Sub

    ' Handle the delete item button click event
    Private Sub btnDeleteItem_Click(sender As Object, e As EventArgs) Handles btnDeleteItem.Click
        ' Check if an item has been selected in the DataGridView
        If lblitemID.Text = "" Then
            MessageBox.Show("Please select an item to delete.")
            Return
        End If

        ' Ask the user for confirmation before deleting
        Dim confirmResult = MessageBox.Show("Are you sure you want to delete this item?", "Confirm Delete", MessageBoxButtons.YesNo)
        If confirmResult = DialogResult.Yes Then
            ' SQL query to delete the inventory item
            Using conn As New SqlConnection(connectionString)
                Dim query As String = "DELETE FROM Inventory WHERE ItemID = @ItemID"
                Dim cmd As New SqlCommand(query, conn)

                ' Add parameters to avoid SQL injection
                cmd.Parameters.AddWithValue("@ItemID", lblitemID.Text)

                Try
                    conn.Open()
                    cmd.ExecuteNonQuery()  ' Execute the delete query

                    ' After deletion, refresh the DataGridView
                    LoadInventory()

                    ' Clear any selected item info
                    lblitemID.Text = ""
                    txtItemName.Clear()
                    txtQuantity.Clear()
                    txtPrice.Clear()
                    lblAddedBy.Text = ""
                Catch ex As Exception
                    MessageBox.Show("Error deleting item: " & ex.Message)
                End Try
            End Using
        End If
    End Sub
End Class

