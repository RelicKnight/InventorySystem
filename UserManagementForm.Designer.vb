<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserManagementForm
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
        Button1 = New Button()
        txtSearch = New TextBox()
        dgvUserList = New DataGridView()
        Label2 = New Label()
        lblLoggedInAdmin = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        lblUserID = New Label()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        cmbRole = New TextBox()
        btnAddUser = New Button()
        btnUpdateUser = New Button()
        btnDeleteUser = New Button()
        CType(dgvUserList, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(300, 41)
        Label1.Name = "Label1"
        Label1.Size = New Size(130, 20)
        Label1.TabIndex = 0
        Label1.Text = "User Management"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(430, 143)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 1
        Button1.Text = "Search"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(224, 145)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(178, 27)
        txtSearch.TabIndex = 2
        ' 
        ' dgvUserList
        ' 
        dgvUserList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvUserList.Location = New Point(21, 188)
        dgvUserList.Name = "dgvUserList"
        dgvUserList.RowHeadersWidth = 51
        dgvUserList.Size = New Size(655, 188)
        dgvUserList.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(75, 93)
        Label2.Name = "Label2"
        Label2.Size = New Size(97, 20)
        Label2.TabIndex = 0
        Label2.Text = "Logged in as:"
        ' 
        ' lblLoggedInAdmin
        ' 
        lblLoggedInAdmin.AutoSize = True
        lblLoggedInAdmin.Location = New Point(224, 93)
        lblLoggedInAdmin.Name = "lblLoggedInAdmin"
        lblLoggedInAdmin.Size = New Size(133, 20)
        lblLoggedInAdmin.TabIndex = 0
        lblLoggedInAdmin.Text = "lblLoggedInAdmin"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(75, 148)
        Label4.Name = "Label4"
        Label4.Size = New Size(56, 20)
        Label4.TabIndex = 0
        Label4.Text = "Search:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(53, 401)
        Label5.Name = "Label5"
        Label5.Size = New Size(91, 20)
        Label5.TabIndex = 0
        Label5.Text = "User Details:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(53, 435)
        Label6.Name = "Label6"
        Label6.Size = New Size(56, 20)
        Label6.TabIndex = 0
        Label6.Text = "UserID:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(53, 468)
        Label7.Name = "Label7"
        Label7.Size = New Size(78, 20)
        Label7.TabIndex = 0
        Label7.Text = "Username:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(53, 501)
        Label8.Name = "Label8"
        Label8.Size = New Size(73, 20)
        Label8.TabIndex = 0
        Label8.Text = "Password:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(53, 534)
        Label9.Name = "Label9"
        Label9.Size = New Size(42, 20)
        Label9.TabIndex = 0
        Label9.Text = "Role:"
        ' 
        ' lblUserID
        ' 
        lblUserID.AutoSize = True
        lblUserID.Location = New Point(177, 435)
        lblUserID.Name = "lblUserID"
        lblUserID.Size = New Size(77, 20)
        lblUserID.TabIndex = 0
        lblUserID.Text = "Read Only"
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(177, 468)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(231, 27)
        txtUsername.TabIndex = 2
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(177, 501)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(231, 27)
        txtPassword.TabIndex = 2
        ' 
        ' cmbRole
        ' 
        cmbRole.Location = New Point(177, 534)
        cmbRole.Name = "cmbRole"
        cmbRole.Size = New Size(231, 27)
        cmbRole.TabIndex = 2
        ' 
        ' btnAddUser
        ' 
        btnAddUser.Location = New Point(430, 443)
        btnAddUser.Name = "btnAddUser"
        btnAddUser.Size = New Size(130, 29)
        btnAddUser.TabIndex = 1
        btnAddUser.Text = "Add User"
        btnAddUser.UseVisualStyleBackColor = True
        ' 
        ' btnUpdateUser
        ' 
        btnUpdateUser.Location = New Point(430, 492)
        btnUpdateUser.Name = "btnUpdateUser"
        btnUpdateUser.Size = New Size(130, 29)
        btnUpdateUser.TabIndex = 1
        btnUpdateUser.Text = "Update"
        btnUpdateUser.UseVisualStyleBackColor = True
        ' 
        ' btnDeleteUser
        ' 
        btnDeleteUser.Location = New Point(430, 541)
        btnDeleteUser.Name = "btnDeleteUser"
        btnDeleteUser.Size = New Size(130, 29)
        btnDeleteUser.TabIndex = 1
        btnDeleteUser.Text = "Delete"
        btnDeleteUser.UseVisualStyleBackColor = True
        ' 
        ' UserManagementForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(713, 628)
        Controls.Add(dgvUserList)
        Controls.Add(cmbRole)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(txtSearch)
        Controls.Add(btnDeleteUser)
        Controls.Add(btnUpdateUser)
        Controls.Add(btnAddUser)
        Controls.Add(Button1)
        Controls.Add(Label4)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(lblUserID)
        Controls.Add(Label5)
        Controls.Add(lblLoggedInAdmin)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "UserManagementForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "User Management(Admin)"
        CType(dgvUserList, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents dgvUserList As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents lblLoggedInAdmin As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblUserID As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents cmbRole As TextBox
    Friend WithEvents btnAddUser As Button
    Friend WithEvents btnUpdateUser As Button
    Friend WithEvents btnDeleteUser As Button
End Class
