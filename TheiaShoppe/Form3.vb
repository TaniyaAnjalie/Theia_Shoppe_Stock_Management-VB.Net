Imports System.Buffers
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class Form3
    Public Sub SearchClear()
        cboItemCode.SelectedIndex = -1
    End Sub

    Public Sub ItemClear()
        txtItemCode.Text = ""
        txtName.Text = ""
        cboMaterial.SelectedIndex = -1
        txtPrice.Text = ""
        txtStock.Text = ""
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

    Dim Connection As New SqlConnection("Data Source=DESKTOP-464VDBT;Initial Catalog=TheiaShoppe;Integrated Security=True")

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub btnItem_Click(sender As Object, e As EventArgs) Handles btnItem.Click
        Me.Show()
    End Sub

    Private Sub btnInvoice_Click(sender As Object, e As EventArgs) Handles btnInvoice.Click
        Form5.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim Duplicatesql As String

        Duplicatesql = "Select Item_Code from Item where Item_Code = @Item_Code"
        Connection.Open()
        Dim ReadCommand As New SqlCommand(Duplicatesql, Connection)
        ReadCommand.Parameters.AddWithValue("@Item_Code", txtItemCode.Text)

        Dim myreader As SqlDataReader
        myreader = ReadCommand.ExecuteReader()

        If (myreader.Read()) Then
            Connection.Close()
            MsgBox("Duplicate Item Code")

        ElseIf txtItemCode.Text = "" Or txtName.Text = "" Or txtPrice.Text = "" Or txtStock.Text = "" Or cboMaterial.SelectedIndex = -1 Then
            MsgBox("Enter details")

        Else
            Connection.Close()

            Dim Stringsql As String

            Stringsql = "Insert into Item values(@Item_Code,@Item_Name,@Stock, @Material, @Price)"
            Dim AddCommand As New SqlCommand(Stringsql, Connection)

            AddCommand.Parameters.AddWithValue("@Item_Code", txtItemCode.Text)
            AddCommand.Parameters.AddWithValue("@Item_Name", txtName.Text)
            AddCommand.Parameters.AddWithValue("@Stock", txtStock.Text)
            AddCommand.Parameters.AddWithValue("@Material", cboItemCode.Text)
            AddCommand.Parameters.AddWithValue("@Price", txtPrice.Text)


            Connection.Open()
            AddCommand.ExecuteNonQuery()
            Connection.Close()
            MsgBox("Item Insert")
            FillItem()
            DisplayItem()
            ItemClear()
        End If

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If MsgBox("Are you sure?", MessageBoxButtons.YesNo = DialogResult.Yes) Then

            Dim Deletesql As String

            Deletesql = "Delete from Item where Item_Code = @Item_Code"

            Dim DeleteCommand As New SqlCommand(Deletesql, Connection)
            DeleteCommand.Parameters.AddWithValue("@Item_Code", txtItemCode.Text)
            Connection.Open()
            DeleteCommand.ExecuteNonQuery()
            MsgBox("Item is deleted")
            txtItemCode.Clear()

        End If

        Connection.Close()
        DisplayItem()
        ItemClear()

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillItem()
        DisplayItem()
        ItemClear()
        SearchClear()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        Dim Updateesql As String = "Update Item set Item_Name = @Item_Name, Stock = @Stock, Material = @Material, Price = @Price where Item_Code = @Item_Code"
        Dim UpdateCommand As New SqlCommand(Updateesql, Connection)
        UpdateCommand.Parameters.AddWithValue("@Item_Code", txtItemCode.Text)
        UpdateCommand.Parameters.AddWithValue("@Item_Name", txtName.Text)
        UpdateCommand.Parameters.AddWithValue("@Stock", txtStock.Text)
        UpdateCommand.Parameters.AddWithValue("@Material", cboMaterial.Text)
        UpdateCommand.Parameters.AddWithValue("@Price", txtPrice.Text)

        Connection.Open()
        UpdateCommand.ExecuteNonQuery()
        Connection.Close()
        MsgBox("Item is Updated")

        DisplayItem()
        ItemClear()
    End Sub

    Private Sub gvItemList_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles gvItemList.CellMouseDoubleClick
        Dim SelectRow As DataGridViewRow = gvItemList.Rows(e.RowIndex)

        txtItemCode.Text = SelectRow.Cells(0).Value.ToString
        txtName.Text = SelectRow.Cells(1).Value.ToString
        txtStock.Text = SelectRow.Cells(2).Value.ToString
        cboMaterial.SelectedItem = SelectRow.Cells(3).Value.ToString
        txtPrice.Text = SelectRow.Cells(4).Value.ToString

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
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

        SearchClear()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ItemClear()
        DisplayItem()
    End Sub

    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click
        Me.Hide()
        Form6.Show()
    End Sub
End Class