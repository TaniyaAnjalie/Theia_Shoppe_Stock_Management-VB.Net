<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlMenu = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnInvoice = New System.Windows.Forms.Button()
        Me.btnItem = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.pnlTheiaName = New System.Windows.Forms.Panel()
        Me.lblTheiaShoppe = New System.Windows.Forms.Label()
        Me.btnUser = New System.Windows.Forms.Button()
        Me.pnlMenu.SuspendLayout()
        Me.pnlTheiaName.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlMenu
        '
        Me.pnlMenu.BackColor = System.Drawing.Color.MidnightBlue
        Me.pnlMenu.Controls.Add(Me.btnUser)
        Me.pnlMenu.Controls.Add(Me.btnLogout)
        Me.pnlMenu.Controls.Add(Me.btnInvoice)
        Me.pnlMenu.Controls.Add(Me.btnItem)
        Me.pnlMenu.Controls.Add(Me.btnHome)
        Me.pnlMenu.Location = New System.Drawing.Point(1, 65)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(145, 647)
        Me.pnlMenu.TabIndex = 2
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogout.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnLogout.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnLogout.Location = New System.Drawing.Point(25, 582)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(94, 42)
        Me.btnLogout.TabIndex = 11
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnInvoice
        '
        Me.btnInvoice.BackColor = System.Drawing.Color.AliceBlue
        Me.btnInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnInvoice.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnInvoice.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnInvoice.Location = New System.Drawing.Point(25, 153)
        Me.btnInvoice.Name = "btnInvoice"
        Me.btnInvoice.Size = New System.Drawing.Size(94, 33)
        Me.btnInvoice.TabIndex = 10
        Me.btnInvoice.Text = "Invoice"
        Me.btnInvoice.UseVisualStyleBackColor = False
        '
        'btnItem
        '
        Me.btnItem.BackColor = System.Drawing.Color.AliceBlue
        Me.btnItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnItem.Font = New System.Drawing.Font("Century Gothic", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnItem.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnItem.Location = New System.Drawing.Point(25, 89)
        Me.btnItem.Name = "btnItem"
        Me.btnItem.Size = New System.Drawing.Size(94, 33)
        Me.btnItem.TabIndex = 9
        Me.btnItem.Text = "Item"
        Me.btnItem.UseVisualStyleBackColor = False
        '
        'btnHome
        '
        Me.btnHome.BackColor = System.Drawing.Color.AliceBlue
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnHome.Font = New System.Drawing.Font("Century Gothic", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnHome.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnHome.Location = New System.Drawing.Point(25, 22)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(94, 33)
        Me.btnHome.TabIndex = 8
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = False
        '
        'pnlTheiaName
        '
        Me.pnlTheiaName.BackColor = System.Drawing.Color.White
        Me.pnlTheiaName.Controls.Add(Me.lblTheiaShoppe)
        Me.pnlTheiaName.Location = New System.Drawing.Point(1, 1)
        Me.pnlTheiaName.Name = "pnlTheiaName"
        Me.pnlTheiaName.Size = New System.Drawing.Size(1338, 69)
        Me.pnlTheiaName.TabIndex = 3
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
        'btnUser
        '
        Me.btnUser.BackColor = System.Drawing.Color.AliceBlue
        Me.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUser.Font = New System.Drawing.Font("Century Gothic", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnUser.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnUser.Location = New System.Drawing.Point(25, 226)
        Me.btnUser.Name = "btnUser"
        Me.btnUser.Size = New System.Drawing.Size(94, 33)
        Me.btnUser.TabIndex = 10
        Me.btnUser.Text = "User"
        Me.btnUser.UseVisualStyleBackColor = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(1339, 711)
        Me.Controls.Add(Me.pnlTheiaName)
        Me.Controls.Add(Me.pnlMenu)
        Me.DoubleBuffered = True
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        Me.pnlMenu.ResumeLayout(False)
        Me.pnlTheiaName.ResumeLayout(False)
        Me.pnlTheiaName.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlMenu As Panel
    Friend WithEvents pnlTheiaName As Panel
    Friend WithEvents lblTheiaShoppe As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnInvoice As Button
    Friend WithEvents btnItem As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents btnUser As Button
End Class
