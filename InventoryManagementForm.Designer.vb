<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InventoryManagementForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        btnAddItem = New Button()
        btnUpdateItem = New Button()
        btnDeleteItem = New Button()
        lblitemID = New Label()
        txtItemName = New TextBox()
        txtQuantity = New TextBox()
        txtPrice = New TextBox()
        Label8 = New Label()
        dgvInventoryList = New DataGridView()
        btnBack = New Button()
        btnClear = New Button()
        Button2 = New Button()
        txtSearch = New TextBox()
        lblUserRole = New Label()
        Label6 = New Label()
        CType(dgvInventoryList, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(286, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(162, 20)
        Label1.TabIndex = 0
        Label1.Text = "Inventory Management"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(38, 130)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 20)
        Label2.TabIndex = 1
        Label2.Text = "Item Id:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(38, 170)
        Label3.Name = "Label3"
        Label3.Size = New Size(86, 20)
        Label3.TabIndex = 2
        Label3.Text = "Item Name:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(38, 210)
        Label4.Name = "Label4"
        Label4.Size = New Size(68, 20)
        Label4.TabIndex = 2
        Label4.Text = "Quantity:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(38, 250)
        Label5.Name = "Label5"
        Label5.Size = New Size(44, 20)
        Label5.TabIndex = 3
        Label5.Text = "Price:"
        ' 
        ' btnAddItem
        ' 
        btnAddItem.Location = New Point(38, 294)
        btnAddItem.Name = "btnAddItem"
        btnAddItem.Size = New Size(94, 38)
        btnAddItem.TabIndex = 4
        btnAddItem.Text = "Add Item"
        btnAddItem.UseVisualStyleBackColor = True
        ' 
        ' btnUpdateItem
        ' 
        btnUpdateItem.Location = New Point(150, 294)
        btnUpdateItem.Name = "btnUpdateItem"
        btnUpdateItem.Size = New Size(122, 38)
        btnUpdateItem.TabIndex = 4
        btnUpdateItem.Text = "Update Item"
        btnUpdateItem.UseVisualStyleBackColor = True
        ' 
        ' btnDeleteItem
        ' 
        btnDeleteItem.Location = New Point(290, 294)
        btnDeleteItem.Name = "btnDeleteItem"
        btnDeleteItem.Size = New Size(139, 38)
        btnDeleteItem.TabIndex = 4
        btnDeleteItem.Text = "Delete Item"
        btnDeleteItem.UseVisualStyleBackColor = True
        ' 
        ' lblitemID
        ' 
        lblitemID.AutoSize = True
        lblitemID.Location = New Point(150, 130)
        lblitemID.Name = "lblitemID"
        lblitemID.Size = New Size(59, 20)
        lblitemID.TabIndex = 5
        lblitemID.Text = "Item Id:"
        ' 
        ' txtItemName
        ' 
        txtItemName.Location = New Point(150, 167)
        txtItemName.Name = "txtItemName"
        txtItemName.Size = New Size(271, 27)
        txtItemName.TabIndex = 6
        ' 
        ' txtQuantity
        ' 
        txtQuantity.Location = New Point(150, 207)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(159, 27)
        txtQuantity.TabIndex = 7
        ' 
        ' txtPrice
        ' 
        txtPrice.Location = New Point(150, 247)
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(159, 27)
        txtPrice.TabIndex = 8
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(300, 366)
        Label8.Name = "Label8"
        Label8.Size = New Size(148, 20)
        Label8.TabIndex = 10
        Label8.Text = "Current Inventory List"
        ' 
        ' dgvInventoryList
        ' 
        dgvInventoryList.AllowUserToAddRows = False
        dgvInventoryList.AllowUserToDeleteRows = False
        dgvInventoryList.AllowUserToResizeColumns = False
        dgvInventoryList.AllowUserToResizeRows = False
        dgvInventoryList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvInventoryList.Location = New Point(8, 462)
        dgvInventoryList.MultiSelect = False
        dgvInventoryList.Name = "dgvInventoryList"
        dgvInventoryList.ReadOnly = True
        dgvInventoryList.RowHeadersWidth = 51
        dgvInventoryList.Size = New Size(698, 270)
        dgvInventoryList.TabIndex = 11
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(448, 294)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(94, 38)
        btnBack.TabIndex = 12
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(38, 340)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(94, 38)
        btnClear.TabIndex = 13
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(38, 413)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 14
        Button2.Text = "Search"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(150, 413)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(271, 27)
        txtSearch.TabIndex = 15
        ' 
        ' lblUserRole
        ' 
        lblUserRole.AutoSize = True
        lblUserRole.Location = New Point(171, 81)
        lblUserRole.Name = "lblUserRole"
        lblUserRole.Size = New Size(38, 20)
        lblUserRole.TabIndex = 16
        lblUserRole.Text = "User"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(38, 81)
        Label6.Name = "Label6"
        Label6.Size = New Size(99, 20)
        Label6.TabIndex = 17
        Label6.Text = "Logged in As:"
        ' 
        ' InventoryManagementForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(718, 744)
        Controls.Add(lblUserRole)
        Controls.Add(Label6)
        Controls.Add(txtSearch)
        Controls.Add(Button2)
        Controls.Add(btnClear)
        Controls.Add(btnBack)
        Controls.Add(dgvInventoryList)
        Controls.Add(Label8)
        Controls.Add(Label1)
        Controls.Add(txtPrice)
        Controls.Add(txtQuantity)
        Controls.Add(txtItemName)
        Controls.Add(lblitemID)
        Controls.Add(btnDeleteItem)
        Controls.Add(btnUpdateItem)
        Controls.Add(btnAddItem)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Name = "InventoryManagementForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Inventory Management"
        CType(dgvInventoryList, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnAddItem As Button
    Friend WithEvents btnUpdateItem As Button
    Friend WithEvents btnDeleteItem As Button
    Friend WithEvents lblitemID As Label
    Friend WithEvents txtItemName As TextBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents dgvInventoryList As DataGridView
    Friend WithEvents btnBack As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lblUserRole As Label
    Friend WithEvents Label6 As Label
End Class
