<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form5
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.pnlTheiaName = New System.Windows.Forms.Panel()
        Me.lblTheiaShoppe = New System.Windows.Forms.Label()
        Me.pnlMenu = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnInvoice = New System.Windows.Forms.Button()
        Me.btnItem = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.lblInvoice = New System.Windows.Forms.Label()
        Me.pnlInvoice = New System.Windows.Forms.Panel()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblQty = New System.Windows.Forms.Label()
        Me.gvItemList = New System.Windows.Forms.DataGridView()
        Me.btnTotal = New System.Windows.Forms.Button()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.pnlInvoiceDisplay = New System.Windows.Forms.Panel()
        Me.txtTotalAmount = New System.Windows.Forms.TextBox()
        Me.txtDiscount = New System.Windows.Forms.TextBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.lblTQ = New System.Windows.Forms.Label()
        Me.lblTotalAmount = New System.Windows.Forms.Label()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.lblInvoiceDisplay = New System.Windows.Forms.Label()
        Me.lvItems = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader()
        Me.cboMaterial = New System.Windows.Forms.ComboBox()
        Me.btnAddToBill = New System.Windows.Forms.Button()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.txtItemCode = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblStock = New System.Windows.Forms.Label()
        Me.lblMaterial = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblItems = New System.Windows.Forms.Label()
        Me.grpSearch = New System.Windows.Forms.GroupBox()
        Me.cboItemCode = New System.Windows.Forms.ComboBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.lblSearchItemCode = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.btnUser = New System.Windows.Forms.Button()
        Me.pnlTheiaName.SuspendLayout()
        Me.pnlMenu.SuspendLayout()
        Me.pnlInvoice.SuspendLayout()
        CType(Me.gvItemList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlInvoiceDisplay.SuspendLayout()
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
        Me.pnlTheiaName.TabIndex = 1
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
        Me.pnlMenu.TabIndex = 2
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
        'lblInvoice
        '
        Me.lblInvoice.AutoSize = True
        Me.lblInvoice.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblInvoice.ForeColor = System.Drawing.Color.White
        Me.lblInvoice.Location = New System.Drawing.Point(161, 83)
        Me.lblInvoice.Name = "lblInvoice"
        Me.lblInvoice.Size = New System.Drawing.Size(98, 27)
        Me.lblInvoice.TabIndex = 4
        Me.lblInvoice.Text = "Invoice"
        '
        'pnlInvoice
        '
        Me.pnlInvoice.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.pnlInvoice.Controls.Add(Me.btnSave)
        Me.pnlInvoice.Controls.Add(Me.lblQty)
        Me.pnlInvoice.Controls.Add(Me.gvItemList)
        Me.pnlInvoice.Controls.Add(Me.btnTotal)
        Me.pnlInvoice.Controls.Add(Me.txtQty)
        Me.pnlInvoice.Controls.Add(Me.pnlInvoiceDisplay)
        Me.pnlInvoice.Controls.Add(Me.lvItems)
        Me.pnlInvoice.Controls.Add(Me.cboMaterial)
        Me.pnlInvoice.Controls.Add(Me.btnAddToBill)
        Me.pnlInvoice.Controls.Add(Me.txtPrice)
        Me.pnlInvoice.Controls.Add(Me.txtStock)
        Me.pnlInvoice.Controls.Add(Me.txtItemCode)
        Me.pnlInvoice.Controls.Add(Me.txtName)
        Me.pnlInvoice.Controls.Add(Me.Label1)
        Me.pnlInvoice.Controls.Add(Me.lblStock)
        Me.pnlInvoice.Controls.Add(Me.lblMaterial)
        Me.pnlInvoice.Controls.Add(Me.Label2)
        Me.pnlInvoice.Controls.Add(Me.lblName)
        Me.pnlInvoice.Controls.Add(Me.lblItems)
        Me.pnlInvoice.Controls.Add(Me.grpSearch)
        Me.pnlInvoice.Location = New System.Drawing.Point(161, 123)
        Me.pnlInvoice.Name = "pnlInvoice"
        Me.pnlInvoice.Size = New System.Drawing.Size(1166, 576)
        Me.pnlInvoice.TabIndex = 5
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.AliceBlue
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSave.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnSave.Location = New System.Drawing.Point(492, 524)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(174, 37)
        Me.btnSave.TabIndex = 47
        Me.btnSave.Text = "Save and Print"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'lblQty
        '
        Me.lblQty.AutoSize = True
        Me.lblQty.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblQty.Location = New System.Drawing.Point(388, 211)
        Me.lblQty.Name = "lblQty"
        Me.lblQty.Size = New System.Drawing.Size(88, 28)
        Me.lblQty.TabIndex = 45
        Me.lblQty.Text = "Quantity"
        '
        'gvItemList
        '
        Me.gvItemList.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.gvItemList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.MidnightBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.MidnightBlue
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gvItemList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.gvItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.MidnightBlue
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gvItemList.DefaultCellStyle = DataGridViewCellStyle2
        Me.gvItemList.GridColor = System.Drawing.Color.LightSkyBlue
        Me.gvItemList.Location = New System.Drawing.Point(705, 20)
        Me.gvItemList.Name = "gvItemList"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gvItemList.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.gvItemList.RowHeadersWidth = 51
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        Me.gvItemList.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.gvItemList.RowTemplate.Height = 29
        Me.gvItemList.Size = New System.Drawing.Size(445, 222)
        Me.gvItemList.TabIndex = 42
        '
        'btnTotal
        '
        Me.btnTotal.BackColor = System.Drawing.Color.AliceBlue
        Me.btnTotal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTotal.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnTotal.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnTotal.Location = New System.Drawing.Point(365, 524)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(111, 37)
        Me.btnTotal.TabIndex = 46
        Me.btnTotal.Text = "Total"
        Me.btnTotal.UseVisualStyleBackColor = False
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(482, 215)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(200, 27)
        Me.txtQty.TabIndex = 44
        '
        'pnlInvoiceDisplay
        '
        Me.pnlInvoiceDisplay.BackColor = System.Drawing.Color.AliceBlue
        Me.pnlInvoiceDisplay.Controls.Add(Me.txtTotalAmount)
        Me.pnlInvoiceDisplay.Controls.Add(Me.txtDiscount)
        Me.pnlInvoiceDisplay.Controls.Add(Me.txtAmount)
        Me.pnlInvoiceDisplay.Controls.Add(Me.lblTQ)
        Me.pnlInvoiceDisplay.Controls.Add(Me.lblTotalAmount)
        Me.pnlInvoiceDisplay.Controls.Add(Me.lblDiscount)
        Me.pnlInvoiceDisplay.Controls.Add(Me.lblAmount)
        Me.pnlInvoiceDisplay.Controls.Add(Me.lblInvoiceDisplay)
        Me.pnlInvoiceDisplay.Location = New System.Drawing.Point(722, 254)
        Me.pnlInvoiceDisplay.Name = "pnlInvoiceDisplay"
        Me.pnlInvoiceDisplay.Size = New System.Drawing.Size(417, 302)
        Me.pnlInvoiceDisplay.TabIndex = 18
        '
        'txtTotalAmount
        '
        Me.txtTotalAmount.Location = New System.Drawing.Point(194, 198)
        Me.txtTotalAmount.Name = "txtTotalAmount"
        Me.txtTotalAmount.Size = New System.Drawing.Size(199, 27)
        Me.txtTotalAmount.TabIndex = 40
        Me.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDiscount
        '
        Me.txtDiscount.Location = New System.Drawing.Point(194, 132)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(199, 27)
        Me.txtDiscount.TabIndex = 39
        Me.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(194, 78)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(199, 27)
        Me.txtAmount.TabIndex = 38
        Me.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTQ
        '
        Me.lblTQ.AutoSize = True
        Me.lblTQ.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTQ.Location = New System.Drawing.Point(122, 266)
        Me.lblTQ.Name = "lblTQ"
        Me.lblTQ.Size = New System.Drawing.Size(183, 23)
        Me.lblTQ.TabIndex = 23
        Me.lblTQ.Text = "****** Thank You ******"
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.AutoSize = True
        Me.lblTotalAmount.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTotalAmount.Location = New System.Drawing.Point(30, 198)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(130, 28)
        Me.lblTotalAmount.TabIndex = 19
        Me.lblTotalAmount.Text = "Total Amount"
        '
        'lblDiscount
        '
        Me.lblDiscount.AutoSize = True
        Me.lblDiscount.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblDiscount.Location = New System.Drawing.Point(30, 132)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(89, 28)
        Me.lblDiscount.TabIndex = 13
        Me.lblDiscount.Text = "Discount"
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblAmount.Location = New System.Drawing.Point(30, 77)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(83, 28)
        Me.lblAmount.TabIndex = 1
        Me.lblAmount.Text = "Amount"
        '
        'lblInvoiceDisplay
        '
        Me.lblInvoiceDisplay.AutoSize = True
        Me.lblInvoiceDisplay.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblInvoiceDisplay.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblInvoiceDisplay.Location = New System.Drawing.Point(165, 15)
        Me.lblInvoiceDisplay.Name = "lblInvoiceDisplay"
        Me.lblInvoiceDisplay.Size = New System.Drawing.Size(98, 27)
        Me.lblInvoiceDisplay.TabIndex = 15
        Me.lblInvoiceDisplay.Text = "Invoice"
        '
        'lvItems
        '
        Me.lvItems.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lvItems.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lvItems.Location = New System.Drawing.Point(27, 308)
        Me.lvItems.Name = "lvItems"
        Me.lvItems.Size = New System.Drawing.Size(655, 210)
        Me.lvItems.TabIndex = 43
        Me.lvItems.UseCompatibleStateImageBehavior = False
        Me.lvItems.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Item Code"
        Me.ColumnHeader1.Width = 130
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name"
        Me.ColumnHeader2.Width = 170
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Price"
        Me.ColumnHeader3.Width = 100
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Qty"
        Me.ColumnHeader4.Width = 100
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Total"
        Me.ColumnHeader5.Width = 120
        '
        'cboMaterial
        '
        Me.cboMaterial.FormattingEnabled = True
        Me.cboMaterial.Items.AddRange(New Object() {"Matte", "Shine"})
        Me.cboMaterial.Location = New System.Drawing.Point(135, 214)
        Me.cboMaterial.Name = "cboMaterial"
        Me.cboMaterial.Size = New System.Drawing.Size(228, 28)
        Me.cboMaterial.TabIndex = 41
        '
        'btnAddToBill
        '
        Me.btnAddToBill.BackColor = System.Drawing.Color.AliceBlue
        Me.btnAddToBill.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAddToBill.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnAddToBill.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnAddToBill.Location = New System.Drawing.Point(544, 254)
        Me.btnAddToBill.Name = "btnAddToBill"
        Me.btnAddToBill.Size = New System.Drawing.Size(138, 37)
        Me.btnAddToBill.TabIndex = 40
        Me.btnAddToBill.Text = "Add To Bill"
        Me.btnAddToBill.UseVisualStyleBackColor = False
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(454, 168)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(228, 27)
        Me.txtPrice.TabIndex = 38
        '
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(454, 127)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(228, 27)
        Me.txtStock.TabIndex = 37
        '
        'txtItemCode
        '
        Me.txtItemCode.Location = New System.Drawing.Point(135, 165)
        Me.txtItemCode.Name = "txtItemCode"
        Me.txtItemCode.Size = New System.Drawing.Size(228, 27)
        Me.txtItemCode.TabIndex = 36
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(135, 123)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(228, 27)
        Me.txtName.TabIndex = 35
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(388, 164)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 28)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Price"
        '
        'lblStock
        '
        Me.lblStock.AutoSize = True
        Me.lblStock.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblStock.Location = New System.Drawing.Point(388, 123)
        Me.lblStock.Name = "lblStock"
        Me.lblStock.Size = New System.Drawing.Size(60, 28)
        Me.lblStock.TabIndex = 33
        Me.lblStock.Text = "Stock"
        '
        'lblMaterial
        '
        Me.lblMaterial.AutoSize = True
        Me.lblMaterial.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblMaterial.Location = New System.Drawing.Point(27, 210)
        Me.lblMaterial.Name = "lblMaterial"
        Me.lblMaterial.Size = New System.Drawing.Size(84, 28)
        Me.lblMaterial.TabIndex = 32
        Me.lblMaterial.Text = "Material"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(27, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 28)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Item Code"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblName.Location = New System.Drawing.Point(27, 119)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(64, 28)
        Me.lblName.TabIndex = 30
        Me.lblName.Text = "Name"
        '
        'lblItems
        '
        Me.lblItems.AutoSize = True
        Me.lblItems.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblItems.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblItems.Location = New System.Drawing.Point(27, 269)
        Me.lblItems.Name = "lblItems"
        Me.lblItems.Size = New System.Drawing.Size(98, 27)
        Me.lblItems.TabIndex = 24
        Me.lblItems.Text = "Item list"
        '
        'grpSearch
        '
        Me.grpSearch.BackColor = System.Drawing.Color.AliceBlue
        Me.grpSearch.Controls.Add(Me.cboItemCode)
        Me.grpSearch.Controls.Add(Me.btnSearch)
        Me.grpSearch.Controls.Add(Me.lblSearchItemCode)
        Me.grpSearch.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.grpSearch.Location = New System.Drawing.Point(12, 13)
        Me.grpSearch.Name = "grpSearch"
        Me.grpSearch.Size = New System.Drawing.Size(608, 92)
        Me.grpSearch.TabIndex = 0
        Me.grpSearch.TabStop = False
        Me.grpSearch.Text = "Search"
        '
        'cboItemCode
        '
        Me.cboItemCode.FormattingEnabled = True
        Me.cboItemCode.Location = New System.Drawing.Point(165, 30)
        Me.cboItemCode.Name = "cboItemCode"
        Me.cboItemCode.Size = New System.Drawing.Size(228, 36)
        Me.cboItemCode.TabIndex = 6
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(437, 33)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(129, 37)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'lblSearchItemCode
        '
        Me.lblSearchItemCode.AutoSize = True
        Me.lblSearchItemCode.Location = New System.Drawing.Point(15, 33)
        Me.lblSearchItemCode.Name = "lblSearchItemCode"
        Me.lblSearchItemCode.Size = New System.Drawing.Size(102, 28)
        Me.lblSearchItemCode.TabIndex = 1
        Me.lblSearchItemCode.Text = "Item Code"
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'btnUser
        '
        Me.btnUser.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUser.Font = New System.Drawing.Font("Century Gothic", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnUser.ForeColor = System.Drawing.Color.White
        Me.btnUser.Location = New System.Drawing.Point(22, 234)
        Me.btnUser.Name = "btnUser"
        Me.btnUser.Size = New System.Drawing.Size(94, 33)
        Me.btnUser.TabIndex = 9
        Me.btnUser.Text = "User"
        Me.btnUser.UseVisualStyleBackColor = False
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(1339, 711)
        Me.Controls.Add(Me.pnlInvoice)
        Me.Controls.Add(Me.lblInvoice)
        Me.Controls.Add(Me.pnlMenu)
        Me.Controls.Add(Me.pnlTheiaName)
        Me.Name = "Form5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Invoice"
        Me.pnlTheiaName.ResumeLayout(False)
        Me.pnlTheiaName.PerformLayout()
        Me.pnlMenu.ResumeLayout(False)
        Me.pnlInvoice.ResumeLayout(False)
        Me.pnlInvoice.PerformLayout()
        CType(Me.gvItemList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlInvoiceDisplay.ResumeLayout(False)
        Me.pnlInvoiceDisplay.PerformLayout()
        Me.grpSearch.ResumeLayout(False)
        Me.grpSearch.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlTheiaName As Panel
    Friend WithEvents lblTheiaShoppe As Label
    Friend WithEvents pnlMenu As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnInvoice As Button
    Friend WithEvents btnItem As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents lblInvoice As Label
    Friend WithEvents pnlInvoice As Panel
    Friend WithEvents lblInvoiceDisplay As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents grpSearch As GroupBox
    Friend WithEvents lblSearchItemCode As Label
    Friend WithEvents pnlInvoiceDisplay As Panel
    Friend WithEvents lblTQ As Label
    Friend WithEvents lblTotalAmount As Label
    Friend WithEvents lblDiscount As Label
    Friend WithEvents lblAmount As Label
    Friend WithEvents cboItemCode As ComboBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents lblItems As Label
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents cboMaterial As ComboBox
    Friend WithEvents btnAddToBill As Button
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtStock As TextBox
    Friend WithEvents txtItemCode As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblStock As Label
    Friend WithEvents lblMaterial As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblName As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents gvItemList As DataGridView
    Friend WithEvents lvItems As ListView
    Friend WithEvents lblQty As Label
    Friend WithEvents txtQty As TextBox
    Friend WithEvents btnTotal As Button
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents txtTotalAmount As TextBox
    Friend WithEvents txtDiscount As TextBox
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents btnSave As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents btnUser As Button
End Class
