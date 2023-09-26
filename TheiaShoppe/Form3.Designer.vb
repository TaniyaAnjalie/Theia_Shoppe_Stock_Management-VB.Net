<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlTheiaName = New System.Windows.Forms.Panel()
        Me.lblTheiaShoppe = New System.Windows.Forms.Label()
        Me.lblItem = New System.Windows.Forms.Label()
        Me.pnlMenu = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnInvoice = New System.Windows.Forms.Button()
        Me.btnItem = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.pnlInvoice = New System.Windows.Forms.Panel()
        Me.cboMaterial = New System.Windows.Forms.ComboBox()
        Me.gvItemList = New System.Windows.Forms.DataGridView()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.txtItemCode = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblStock = New System.Windows.Forms.Label()
        Me.lblMaterial = New System.Windows.Forms.Label()
        Me.lblItemCode = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.grpSearch = New System.Windows.Forms.GroupBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.cboItemCode = New System.Windows.Forms.ComboBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.lblSearchItemCode = New System.Windows.Forms.Label()
        Me.lblItemList = New System.Windows.Forms.Label()
        Me.btnUser = New System.Windows.Forms.Button()
        Me.pnlTheiaName.SuspendLayout()
        Me.pnlMenu.SuspendLayout()
        Me.pnlInvoice.SuspendLayout()
        CType(Me.gvItemList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSearch.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTheiaName
        '
        Me.pnlTheiaName.BackColor = System.Drawing.Color.White
        Me.pnlTheiaName.Controls.Add(Me.lblTheiaShoppe)
        Me.pnlTheiaName.Location = New System.Drawing.Point(1, 1)
        Me.pnlTheiaName.Name = "pnlTheiaName"
        Me.pnlTheiaName.Size = New System.Drawing.Size(1338, 69)
        Me.pnlTheiaName.TabIndex = 2
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
        'lblItem
        '
        Me.lblItem.AutoSize = True
        Me.lblItem.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblItem.ForeColor = System.Drawing.Color.White
        Me.lblItem.Location = New System.Drawing.Point(161, 83)
        Me.lblItem.Name = "lblItem"
        Me.lblItem.Size = New System.Drawing.Size(63, 27)
        Me.lblItem.TabIndex = 5
        Me.lblItem.Text = "Item"
        '
        'pnlMenu
        '
        Me.pnlMenu.BackColor = System.Drawing.Color.AliceBlue
        Me.pnlMenu.Controls.Add(Me.btnUser)
        Me.pnlMenu.Controls.Add(Me.btnLogout)
        Me.pnlMenu.Controls.Add(Me.btnInvoice)
        Me.pnlMenu.Controls.Add(Me.btnItem)
        Me.pnlMenu.Controls.Add(Me.btnHome)
        Me.pnlMenu.Location = New System.Drawing.Point(1, 69)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(145, 647)
        Me.pnlMenu.TabIndex = 6
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.AliceBlue
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogout.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnLogout.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnLogout.Location = New System.Drawing.Point(22, 590)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(94, 40)
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
        'pnlInvoice
        '
        Me.pnlInvoice.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.pnlInvoice.Controls.Add(Me.cboMaterial)
        Me.pnlInvoice.Controls.Add(Me.gvItemList)
        Me.pnlInvoice.Controls.Add(Me.btnAdd)
        Me.pnlInvoice.Controls.Add(Me.btnEdit)
        Me.pnlInvoice.Controls.Add(Me.txtPrice)
        Me.pnlInvoice.Controls.Add(Me.txtStock)
        Me.pnlInvoice.Controls.Add(Me.txtItemCode)
        Me.pnlInvoice.Controls.Add(Me.txtName)
        Me.pnlInvoice.Controls.Add(Me.lblPrice)
        Me.pnlInvoice.Controls.Add(Me.lblStock)
        Me.pnlInvoice.Controls.Add(Me.lblMaterial)
        Me.pnlInvoice.Controls.Add(Me.lblItemCode)
        Me.pnlInvoice.Controls.Add(Me.lblName)
        Me.pnlInvoice.Controls.Add(Me.btnDelete)
        Me.pnlInvoice.Controls.Add(Me.grpSearch)
        Me.pnlInvoice.Controls.Add(Me.lblItemList)
        Me.pnlInvoice.Location = New System.Drawing.Point(161, 123)
        Me.pnlInvoice.Name = "pnlInvoice"
        Me.pnlInvoice.Size = New System.Drawing.Size(1166, 576)
        Me.pnlInvoice.TabIndex = 7
        '
        'cboMaterial
        '
        Me.cboMaterial.FormattingEnabled = True
        Me.cboMaterial.Items.AddRange(New Object() {"Matte", "Shine"})
        Me.cboMaterial.Location = New System.Drawing.Point(514, 132)
        Me.cboMaterial.Name = "cboMaterial"
        Me.cboMaterial.Size = New System.Drawing.Size(228, 28)
        Me.cboMaterial.TabIndex = 28
        '
        'gvItemList
        '
        Me.gvItemList.AllowUserToResizeRows = False
        Me.gvItemList.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.gvItemList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.MidnightBlue
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.MidnightBlue
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gvItemList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.gvItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.MidnightBlue
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gvItemList.DefaultCellStyle = DataGridViewCellStyle6
        Me.gvItemList.GridColor = System.Drawing.Color.LightSkyBlue
        Me.gvItemList.Location = New System.Drawing.Point(12, 259)
        Me.gvItemList.Name = "gvItemList"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gvItemList.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.gvItemList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
        Me.gvItemList.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.gvItemList.RowTemplate.Height = 29
        Me.gvItemList.Size = New System.Drawing.Size(1139, 302)
        Me.gvItemList.TabIndex = 7
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.AliceBlue
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdd.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnAdd.Location = New System.Drawing.Point(812, 177)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(94, 37)
        Me.btnAdd.TabIndex = 27
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.AliceBlue
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEdit.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnEdit.Location = New System.Drawing.Point(933, 177)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(94, 37)
        Me.btnEdit.TabIndex = 26
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(923, 133)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(228, 27)
        Me.txtPrice.TabIndex = 25
        '
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(514, 177)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(228, 27)
        Me.txtStock.TabIndex = 24
        '
        'txtItemCode
        '
        Me.txtItemCode.Location = New System.Drawing.Point(139, 177)
        Me.txtItemCode.Name = "txtItemCode"
        Me.txtItemCode.Size = New System.Drawing.Size(228, 27)
        Me.txtItemCode.TabIndex = 22
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(139, 133)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(228, 27)
        Me.txtName.TabIndex = 21
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblPrice.Location = New System.Drawing.Point(812, 132)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(54, 28)
        Me.lblPrice.TabIndex = 20
        Me.lblPrice.Text = "Price"
        '
        'lblStock
        '
        Me.lblStock.AutoSize = True
        Me.lblStock.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblStock.Location = New System.Drawing.Point(410, 173)
        Me.lblStock.Name = "lblStock"
        Me.lblStock.Size = New System.Drawing.Size(60, 28)
        Me.lblStock.TabIndex = 19
        Me.lblStock.Text = "Stock"
        '
        'lblMaterial
        '
        Me.lblMaterial.AutoSize = True
        Me.lblMaterial.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblMaterial.Location = New System.Drawing.Point(410, 133)
        Me.lblMaterial.Name = "lblMaterial"
        Me.lblMaterial.Size = New System.Drawing.Size(84, 28)
        Me.lblMaterial.TabIndex = 18
        Me.lblMaterial.Text = "Material"
        '
        'lblItemCode
        '
        Me.lblItemCode.AutoSize = True
        Me.lblItemCode.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblItemCode.Location = New System.Drawing.Point(12, 173)
        Me.lblItemCode.Name = "lblItemCode"
        Me.lblItemCode.Size = New System.Drawing.Size(102, 28)
        Me.lblItemCode.TabIndex = 17
        Me.lblItemCode.Text = "Item Code"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblName.Location = New System.Drawing.Point(12, 133)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(64, 28)
        Me.lblName.TabIndex = 16
        Me.lblName.Text = "Name"
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.AliceBlue
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDelete.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnDelete.Location = New System.Drawing.Point(1057, 177)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(94, 37)
        Me.btnDelete.TabIndex = 12
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'grpSearch
        '
        Me.grpSearch.BackColor = System.Drawing.Color.AliceBlue
        Me.grpSearch.Controls.Add(Me.btnClear)
        Me.grpSearch.Controls.Add(Me.cboItemCode)
        Me.grpSearch.Controls.Add(Me.btnSearch)
        Me.grpSearch.Controls.Add(Me.lblSearchItemCode)
        Me.grpSearch.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.grpSearch.Location = New System.Drawing.Point(12, 13)
        Me.grpSearch.Name = "grpSearch"
        Me.grpSearch.Size = New System.Drawing.Size(1139, 101)
        Me.grpSearch.TabIndex = 0
        Me.grpSearch.TabStop = False
        Me.grpSearch.Text = "Search"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(621, 43)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(94, 37)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'cboItemCode
        '
        Me.cboItemCode.FormattingEnabled = True
        Me.cboItemCode.Location = New System.Drawing.Point(167, 44)
        Me.cboItemCode.Name = "cboItemCode"
        Me.cboItemCode.Size = New System.Drawing.Size(228, 36)
        Me.cboItemCode.TabIndex = 6
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(490, 43)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(94, 37)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'lblSearchItemCode
        '
        Me.lblSearchItemCode.AutoSize = True
        Me.lblSearchItemCode.Location = New System.Drawing.Point(26, 47)
        Me.lblSearchItemCode.Name = "lblSearchItemCode"
        Me.lblSearchItemCode.Size = New System.Drawing.Size(102, 28)
        Me.lblSearchItemCode.TabIndex = 1
        Me.lblSearchItemCode.Text = "Item Code"
        '
        'lblItemList
        '
        Me.lblItemList.AutoSize = True
        Me.lblItemList.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblItemList.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblItemList.Location = New System.Drawing.Point(471, 229)
        Me.lblItemList.Name = "lblItemList"
        Me.lblItemList.Size = New System.Drawing.Size(103, 27)
        Me.lblItemList.TabIndex = 15
        Me.lblItemList.Text = "Item List"
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
        Me.btnUser.TabIndex = 10
        Me.btnUser.Text = "User"
        Me.btnUser.UseVisualStyleBackColor = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(1339, 711)
        Me.Controls.Add(Me.pnlInvoice)
        Me.Controls.Add(Me.pnlMenu)
        Me.Controls.Add(Me.lblItem)
        Me.Controls.Add(Me.pnlTheiaName)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Items"
        Me.pnlTheiaName.ResumeLayout(False)
        Me.pnlTheiaName.PerformLayout()
        Me.pnlMenu.ResumeLayout(False)
        Me.pnlInvoice.ResumeLayout(False)
        Me.pnlInvoice.PerformLayout()
        CType(Me.gvItemList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSearch.ResumeLayout(False)
        Me.grpSearch.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlTheiaName As Panel
    Friend WithEvents lblTheiaShoppe As Label
    Friend WithEvents lblItem As Label
    Friend WithEvents pnlMenu As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnInvoice As Button
    Friend WithEvents btnItem As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents pnlInvoice As Panel
    Friend WithEvents lblItemList As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents grpSearch As GroupBox
    Friend WithEvents cboItemCode As ComboBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents lblSearchItemCode As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtStock As TextBox
    Friend WithEvents txtItemCode As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblStock As Label
    Friend WithEvents lblMaterial As Label
    Friend WithEvents lblItemCode As Label
    Friend WithEvents lblName As Label
    Friend WithEvents gvItemList As DataGridView
    Friend WithEvents cboMaterial As ComboBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnUser As Button
End Class
