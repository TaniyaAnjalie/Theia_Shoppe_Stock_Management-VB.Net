Imports System.Collections.ObjectModel
Imports System.ComponentModel.Design.ObjectSelectorEditor
Imports System.Data.Common
Imports System.Data.SqlClient
Imports System.Windows.Forms.Design
Imports System.Windows.Forms.VisualStyles

Public Class Form5

    Public Sub SearchClear()
        cboItemCode.SelectedIndex = -1
    End Sub

    Public Sub ItemClear()
        txtItemCode.Text = ""
        txtName.Text = ""
        cboMaterial.SelectedIndex = -1
        txtPrice.Text = ""
        txtStock.Text = ""
        txtQty.Text = ""
    End Sub

    Public Sub FillItem()
        Connection.Open()
        Dim FillCommand = New SqlCommand("Select * from Item", Connection)
        Dim FillAdapter = New SqlDataAdapter(FillCommand)
        Dim Table = New DataTable()
        FillAdapter.Fill(Table)
        cboItemCode.DataSource = Table
        cboItemCode.DisplayMember = "Item_Code"
        cboItemCode.ValueMember = "Item_Code"
        Connection.Close()
    End Sub

    Public Sub DisplayItem() 'Display data in a data grid
        Dim Loadsql As String = "Select * from Item"
        Dim CommandLoad = New SqlCommand(Loadsql, Connection)
        Connection.Open()
        CommandLoad.ExecuteNonQuery()
        Dim DataTbl = New DataTable() 'Data set
        Dim DisplayAdapter = New SqlDataAdapter(CommandLoad) 'Data adapter
        DisplayAdapter.Fill(DataTbl)
        gvItemList.DataSource = DataTbl
        Connection.Close()
    End Sub

    Public Sub FilterByItem() 'Display item code's data in a data grid
        Dim Searchsql As String = "Select * from Item where Item_Code = @Item_Code"
        Dim SearchCommand As New SqlCommand(Searchsql, Connection)
        SearchCommand.Parameters.AddWithValue("@Item_Code", cboItemCode.Text)
        Connection.Open()
        SearchCommand.ExecuteNonQuery()
        Dim data As New DataTable()
        Dim datadap As New SqlDataAdapter(SearchCommand)
        datadap.Fill(data)
        gvItemList.DataSource = data
        Connection.Close()
    End Sub

    Dim Connection As New SqlConnection("Data Source=DESKTOP-464VDBT;Initial Catalog=TheiaShoppe;Integrated Security=True")

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub btnItem_Click(sender As Object, e As EventArgs) Handles btnItem.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub btnInvoice_Click(sender As Object, e As EventArgs) Handles btnInvoice.Click
        Me.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillItem()
        DisplayItem()
        ItemClear()
        SearchClear()
    End Sub

    Dim itemName As String


    Private Sub gvItemList_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles gvItemList.CellMouseDoubleClick
        Dim SelectRow As DataGridViewRow = gvItemList.Rows(e.RowIndex)

        txtItemCode.Text = SelectRow.Cells(0).Value.ToString
        txtName.Text = SelectRow.Cells(1).Value.ToString
        txtStock.Text = SelectRow.Cells(2).Value.ToString
        cboMaterial.Text = SelectRow.Cells(3).Value.ToString
        txtPrice.Text = SelectRow.Cells(4).Value.ToString
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        FilterByItem()
        SearchClear()
    End Sub

    Dim itemprice = 0, qty = 0, total = 0, amount = 0, discount = 0, totalam = 0

    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click
        Me.Hide()
        Form6.Show()
    End Sub

    Private Sub PrintDocument1_PrintPage_1(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString("Theia Shoppe", New Font("Arial", 30), Brushes.DarkBlue, 310, 35)
        e.Graphics.DrawString("Invoice", New Font("Arial", 30), Brushes.DarkBlue, 350, 80)
        e.Graphics.DrawString("-----------------------------------------------------------", New Font("Arial", 30), Brushes.DarkBlue, 0, 100)

        'Dim bm As New Bitmap(Me.lvItems.Width, Me.lvItems.Height)
        'lvItems.DrawToBitmap(bm, New Rectangle(0, 0, Me.lvItems.Width, Me.lvItems.Height))
        'e.Graphics.DrawImage(bm, 0, 90)

        e.Graphics.DrawString("Amount          :" + total.ToString(), New Font("Arial", 25), Brushes.Black, 300, 150)
        e.Graphics.DrawString("Discount         :" + discount.ToString(), New Font("Arial", 25), Brushes.Black, 300, 180)
        e.Graphics.DrawString("Total Amount  :" + totalam.ToString(), New Font("Arial", 25), Brushes.Black, 300, 220)
        e.Graphics.DrawString("----------Thanks You----------", New Font("Arial", 20), Brushes.DarkBlue, 285, 280)
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If txtAmount.Text = "" Or txtTotalAmount.Text = "" Then
            MsgBox("Enter Total Button")

        Else

            Dim Stringsql As String

            Stringsql = "Insert into Invoice values(@Date,@Amount,@Discount, @TotalAmount)"
            Dim AddCommand As New SqlCommand(Stringsql, Connection)

            AddCommand.Parameters.AddWithValue("@Date", DateAndTime.Today)
            AddCommand.Parameters.AddWithValue("@Amount", txtAmount.Text)
            AddCommand.Parameters.AddWithValue("@Discount", txtDiscount.Text)
            AddCommand.Parameters.AddWithValue("@TotalAmount", txtTotalAmount.Text)


            Connection.Open()
            AddCommand.ExecuteNonQuery()
            Connection.Close()
            MsgBox("Invoice Saved")
            FillItem()
            DisplayItem()
            ItemClear()
            PrintPreviewDialog1.Show()
        End If
    End Sub

    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
        If amount < 1000 Then
            discount = 0
        ElseIf amount < 5000 Then
            discount = amount * 0.1
        Else
            discount = amount * 0.2
        End If

        totalam = amount - discount

        txtAmount.Text = amount
        txtDiscount.Text = discount
        txtTotalAmount.Text = totalam

        ItemClear()
        FillItem()
        SearchClear()
    End Sub

    Private Sub btnAddToBill_Click(sender As Object, e As EventArgs) Handles btnAddToBill.Click
        itemprice = Val(txtPrice.Text)
        qty = Val(txtQty.Text)
        total = itemprice * qty
        amount = amount + total

        'Dim Updateesql As String = "Update Item set  Stock = @Stock  where Item_Code = @Item_Code"
        'Dim UpdateCommand As New SqlCommand(Updateesql, Connection)
        'UpdateCommand.Parameters.AddWithValue("@Stock", txtStock.Text)

        'Connection.Open()
        'UpdateCommand.ExecuteNonQuery()
        'Connection.Close()
        'MsgBox("Item is Updated")



        Dim detail As ListViewItem

        detail = lvItems.Items.Add(txtItemCode.Text)
        detail.SubItems.Add(txtName.Text)
        detail.SubItems.Add(txtPrice.Text)
        detail.SubItems.Add(txtQty.Text)
        detail.SubItems.Add(total)

        ItemClear()
        FillItem()
        SearchClear()
    End Sub
End Class