<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Me.pnlInvoice = New System.Windows.Forms.Panel()
        Me.lblRePassword = New System.Windows.Forms.Label()
        Me.txtRePassword = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.pnlMenu = New System.Windows.Forms.Panel()
        Me.btnUser = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnInvoice = New System.Windows.Forms.Button()
        Me.btnItem = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.pnlTheiaName = New System.Windows.Forms.Panel()
        Me.lblTheiaShoppe = New System.Windows.Forms.Label()
        Me.lblUsermanagement = New System.Windows.Forms.Label()
        Me.pnlInvoice.SuspendLayout()
        Me.pnlMenu.SuspendLayout()
        Me.pnlTheiaName.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlInvoice
        '
        Me.pnlInvoice.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.pnlInvoice.Controls.Add(Me.lblRePassword)
        Me.pnlInvoice.Controls.Add(Me.txtRePassword)
        Me.pnlInvoice.Controls.Add(Me.txtPassword)
        Me.pnlInvoice.Controls.Add(Me.lblPassword)
        Me.pnlInvoice.Controls.Add(Me.btnSave)
        Me.pnlInvoice.Controls.Add(Me.txtUserName)
        Me.pnlInvoice.Controls.Add(Me.lblName)
        Me.pnlInvoice.Controls.Add(Me.btnClear)
        Me.pnlInvoice.Location = New System.Drawing.Point(160, 120)
        Me.pnlInvoice.Name = "pnlInvoice"
        Me.pnlInvoice.Size = New System.Drawing.Size(1166, 576)
        Me.pnlInvoice.TabIndex = 8
        '
        'lblRePassword
        '
        Me.lblRePassword.AutoSize = True
        Me.lblRePassword.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblRePassword.Location = New System.Drawing.Point(41, 181)
        Me.lblRePassword.Name = "lblRePassword"
        Me.lblRePassword.Size = New System.Drawing.Size(122, 28)
        Me.lblRePassword.TabIndex = 29
        Me.lblRePassword.Text = "Re-Password"
        '
        'txtRePassword
        '
        Me.txtRePassword.Location = New System.Drawing.Point(199, 185)
        Me.txtRePassword.Name = "txtRePassword"
        Me.txtRePassword.Size = New System.Drawing.Size(228, 27)
        Me.txtRePassword.TabIndex = 28
        Me.txtRePassword.UseSystemPasswordChar = True
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(199, 114)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(228, 27)
        Me.txtPassword.TabIndex = 27
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblPassword.Location = New System.Drawing.Point(41, 110)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(93, 28)
        Me.lblPassword.TabIndex = 26
        Me.lblPassword.Text = "Password"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.AliceBlue
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnSave.Location = New System.Drawing.Point(86, 300)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(94, 37)
        Me.btnSave.TabIndex = 25
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(199, 47)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(228, 27)
        Me.txtUserName.TabIndex = 20
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblName.Location = New System.Drawing.Point(41, 41)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(64, 28)
        Me.lblName.TabIndex = 19
        Me.lblName.Text = "Name"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.AliceBlue
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClear.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnClear.Location = New System.Drawing.Point(258, 300)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(94, 37)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'pnlMenu
        '
        Me.pnlMenu.BackColor = System.Drawing.Color.AliceBlue
        Me.pnlMenu.Controls.Add(Me.btnUser)
        Me.pnlMenu.Controls.Add(Me.btnLogout)
        Me.pnlMenu.Controls.Add(Me.btnInvoice)
        Me.pnlMenu.Controls.Add(Me.btnItem)
        Me.pnlMenu.Controls.Add(Me.btnHome)
        Me.pnlMenu.Location = New System.Drawing.Point(0, 66)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(145, 647)
        Me.pnlMenu.TabIndex = 7
        '
        'btnUser
        '
        Me.btnUser.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUser.Font = New System.Drawing.Font("Century Gothic", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnUser.ForeColor = System.Drawing.Color.White
        Me.btnUser.Location = New System.Drawing.Point(22, 230)
        Me.btnUser.Name = "btnUser"
        Me.btnUser.Size = New System.Drawing.Size(94, 33)
        Me.btnUser.TabIndex = 8
        Me.btnUser.Text = "User"
        Me.btnUser.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.AliceBlue
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogout.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnLogout.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnLogout.Location = New System.Drawing.Point(22, 586)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(94, 44)
        Me.btnLogout.TabIndex = 7
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnInvoice
        '
        Me.btnInvoice.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnInvoice.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnInvoice.ForeColor = System.Drawing.Color.White
        Me.btnInvoice.Location = New System.Drawing.Point(22, 159)
        Me.btnInvoice.Name = "btnInvoice"
        Me.btnInvoice.Size = New System.Drawing.Size(94, 33)
        Me.btnInvoice.TabIndex = 6
        Me.btnInvoice.Text = "Invoice"
        Me.btnInvoice.UseVisualStyleBackColor = False
        '
        'btnItem
        '
        Me.btnItem.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnItem.Font = New System.Drawing.Font("Century Gothic", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnItem.ForeColor = System.Drawing.Color.White
        Me.btnItem.Location = New System.Drawing.Point(22, 95)
        Me.btnItem.Name = "btnItem"
        Me.btnItem.Size = New System.Drawing.Size(94, 33)
        Me.btnItem.TabIndex = 5
        Me.btnItem.Text = "Item"
        Me.btnItem.UseVisualStyleBackColor = False
        '
        'btnHome
        '
        Me.btnHome.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnHome.Font = New System.Drawing.Font("Century Gothic", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnHome.ForeColor = System.Drawing.Color.White
        Me.btnHome.Location = New System.Drawing.Point(22, 28)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(94, 33)
        Me.btnHome.TabIndex = 4
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = False
        '
        'pnlTheiaName
        '
        Me.pnlTheiaName.BackColor = System.Drawing.Color.White
        Me.pnlTheiaName.Controls.Add(Me.lblTheiaShoppe)
        Me.pnlTheiaName.Location = New System.Drawing.Point(0, -2)
        Me.pnlTheiaName.Name = "pnlTheiaName"
        Me.pnlTheiaName.Size = New System.Drawing.Size(1338, 69)
        Me.pnlTheiaName.TabIndex = 6
        '
        'lblTheiaShoppe
        '
        Me.lblTheiaShoppe.AutoSize = True
        Me.lblTheiaShoppe.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTheiaShoppe.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblTheiaShoppe.Location = New System.Drawing.Point(22, 18)
        Me.lblTheiaShoppe.Name = "lblTheiaShoppe"
        Me.lblTheiaShoppe.Size = New System.Drawing.Size(198, 32)
        Me.lblTheiaShoppe.TabIndex = 2
        Me.lblTheiaShoppe.Text = "THEIA Shoppe"
        '
        'lblUsermanagement
        '
        Me.lblUsermanagement.AutoSize = True
        Me.lblUsermanagement.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblUsermanagement.ForeColor = System.Drawing.Color.White
        Me.lblUsermanagement.Location = New System.Drawing.Point(161, 83)
        Me.lblUsermanagement.Name = "lblUsermanagement"
        Me.lblUsermanagement.Size = New System.Drawing.Size(223, 27)
        Me.lblUsermanagement.TabIndex = 26
        Me.lblUsermanagement.Text = "User Management"
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(1339, 711)
        Me.Controls.Add(Me.lblUsermanagement)
        Me.Controls.Add(Me.pnlInvoice)
        Me.Controls.Add(Me.pnlMenu)
        Me.Controls.Add(Me.pnlTheiaName)
        Me.Name = "Form6"
        Me.Text = "Form6"
        Me.pnlInvoice.ResumeLayout(False)
        Me.pnlInvoice.PerformLayout()
        Me.pnlMenu.ResumeLayout(False)
        Me.pnlTheiaName.ResumeLayout(False)
        Me.pnlTheiaName.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlInvoice As Panel
    Friend WithEvents btnSave As Button
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents pnlMenu As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnInvoice As Button
    Friend WithEvents btnItem As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents pnlTheiaName As Panel
    Friend WithEvents lblTheiaShoppe As Label
    Friend WithEvents lblUsermanagement As Label
    Friend WithEvents lblRePassword As Label
    Friend WithEvents txtRePassword As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents btnUser As Button
End Class
