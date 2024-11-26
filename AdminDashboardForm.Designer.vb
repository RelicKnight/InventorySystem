<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminDashboardForm
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
        btnManageUsers = New Button()
        btnManageInventory = New Button()
        btnRegisterStaff = New Button()
        btnLogout = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(147, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(130, 20)
        Label1.TabIndex = 0
        Label1.Text = "Admin Dashboard"
        ' 
        ' btnManageUsers
        ' 
        btnManageUsers.Location = New Point(40, 136)
        btnManageUsers.Name = "btnManageUsers"
        btnManageUsers.Size = New Size(162, 29)
        btnManageUsers.TabIndex = 2
        btnManageUsers.Text = "Manage Users"
        btnManageUsers.UseVisualStyleBackColor = True
        ' 
        ' btnManageInventory
        ' 
        btnManageInventory.Location = New Point(230, 136)
        btnManageInventory.Name = "btnManageInventory"
        btnManageInventory.Size = New Size(162, 29)
        btnManageInventory.TabIndex = 3
        btnManageInventory.Text = "Manage Inventory"
        btnManageInventory.UseVisualStyleBackColor = True
        ' 
        ' btnRegisterStaff
        ' 
        btnRegisterStaff.Location = New Point(40, 200)
        btnRegisterStaff.Name = "btnRegisterStaff"
        btnRegisterStaff.Size = New Size(162, 29)
        btnRegisterStaff.TabIndex = 5
        btnRegisterStaff.Text = "Register Staff"
        btnRegisterStaff.UseVisualStyleBackColor = True
        ' 
        ' btnLogout
        ' 
        btnLogout.Location = New Point(298, 276)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(94, 29)
        btnLogout.TabIndex = 7
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' AdminDashboardForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(449, 368)
        Controls.Add(btnLogout)
        Controls.Add(btnRegisterStaff)
        Controls.Add(btnManageInventory)
        Controls.Add(btnManageUsers)
        Controls.Add(Label1)
        Name = "AdminDashboardForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Admin Dashboard"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnManageUsers As Button
    Friend WithEvents btnManageInventory As Button
    Friend WithEvents btnRegisterStaff As Button
    Friend WithEvents btnLogout As Button


End Class
