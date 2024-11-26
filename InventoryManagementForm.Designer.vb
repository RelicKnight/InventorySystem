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
        Label6 = New Label()
        btnAddItem = New Button()
        btnUpdateItem = New Button()
        btnDeleteItem = New Button()
        lblitemID = New Label()
        txtItemName = New TextBox()
        txtQuantity = New TextBox()
        txtPrice = New TextBox()
        Label8 = New Label()
        dgvInventory = New DataGridView()
        lblAddedBy = New Label()
        CType(dgvInventory, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(197, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(162, 20)
        Label1.TabIndex = 0
        Label1.Text = "Inventory Management"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(46, 79)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 20)
        Label2.TabIndex = 1
        Label2.Text = "Item Id:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(46, 119)
        Label3.Name = "Label3"
        Label3.Size = New Size(86, 20)
        Label3.TabIndex = 2
        Label3.Text = "Item Name:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(46, 159)
        Label4.Name = "Label4"
        Label4.Size = New Size(68, 20)
        Label4.TabIndex = 2
        Label4.Text = "Quantity:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(46, 199)
        Label5.Name = "Label5"
        Label5.Size = New Size(44, 20)
        Label5.TabIndex = 3
        Label5.Text = "Price:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(46, 239)
        Label6.Name = "Label6"
        Label6.Size = New Size(77, 20)
        Label6.TabIndex = 3
        Label6.Text = "Added By:"
        ' 
        ' btnAddItem
        ' 
        btnAddItem.Location = New Point(38, 290)
        btnAddItem.Name = "btnAddItem"
        btnAddItem.Size = New Size(94, 29)
        btnAddItem.TabIndex = 4
        btnAddItem.Text = "Add Item"
        btnAddItem.UseVisualStyleBackColor = True
        ' 
        ' btnUpdateItem
        ' 
        btnUpdateItem.Location = New Point(150, 290)
        btnUpdateItem.Name = "btnUpdateItem"
        btnUpdateItem.Size = New Size(122, 29)
        btnUpdateItem.TabIndex = 4
        btnUpdateItem.Text = "Update Item"
        btnUpdateItem.UseVisualStyleBackColor = True
        ' 
        ' btnDeleteItem
        ' 
        btnDeleteItem.Location = New Point(290, 290)
        btnDeleteItem.Name = "btnDeleteItem"
        btnDeleteItem.Size = New Size(139, 29)
        btnDeleteItem.TabIndex = 4
        btnDeleteItem.Text = "Delete Item"
        btnDeleteItem.UseVisualStyleBackColor = True
        ' 
        ' lblitemID
        ' 
        lblitemID.AutoSize = True
        lblitemID.Location = New Point(158, 79)
        lblitemID.Name = "lblitemID"
        lblitemID.Size = New Size(59, 20)
        lblitemID.TabIndex = 5
        lblitemID.Text = "Item Id:"
        ' 
        ' txtItemName
        ' 
        txtItemName.Location = New Point(158, 116)
        txtItemName.Name = "txtItemName"
        txtItemName.Size = New Size(271, 27)
        txtItemName.TabIndex = 6
        ' 
        ' txtQuantity
        ' 
        txtQuantity.Location = New Point(158, 156)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(159, 27)
        txtQuantity.TabIndex = 7
        ' 
        ' txtPrice
        ' 
        txtPrice.Location = New Point(158, 196)
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(159, 27)
        txtPrice.TabIndex = 8
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(188, 347)
        Label8.Name = "Label8"
        Label8.Size = New Size(148, 20)
        Label8.TabIndex = 10
        Label8.Text = "Current Inventory List"
        ' 
        ' dgvInventory
        ' 
        dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvInventory.Location = New Point(38, 406)
        dgvInventory.Name = "dgvInventory"
        dgvInventory.RowHeadersWidth = 51
        dgvInventory.Size = New Size(497, 270)
        dgvInventory.TabIndex = 11
        ' 
        ' lblAddedBy
        ' 
        lblAddedBy.AutoSize = True
        lblAddedBy.Location = New Point(158, 239)
        lblAddedBy.Name = "lblAddedBy"
        lblAddedBy.Size = New Size(77, 20)
        lblAddedBy.TabIndex = 3
        lblAddedBy.Text = "Added By:"
        ' 
        ' InventoryManagementForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(566, 688)
        Controls.Add(dgvInventory)
        Controls.Add(Label8)
        Controls.Add(Label1)
        Controls.Add(txtPrice)
        Controls.Add(txtQuantity)
        Controls.Add(txtItemName)
        Controls.Add(lblitemID)
        Controls.Add(btnDeleteItem)
        Controls.Add(btnUpdateItem)
        Controls.Add(btnAddItem)
        Controls.Add(lblAddedBy)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Name = "InventoryManagementForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Inventory Management"
        CType(dgvInventory, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnAddItem As Button
    Friend WithEvents btnUpdateItem As Button
    Friend WithEvents btnDeleteItem As Button
    Friend WithEvents lblitemID As Label
    Friend WithEvents txtItemName As TextBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents dgvInventory As DataGridView
    Friend WithEvents lblAddedBy As Label
End Class
