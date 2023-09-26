Imports System.Data.SqlClient
Imports System.Text

Public Class Form6

    Public Function Encrypt(ByRef encryption As String) As String

        Dim msg As String = String.Empty
        Dim encode As Byte() = New Byte(encryption.Length - 1) {}
        encode = Encoding.UTF8.GetBytes(encryption)
        msg = Convert.ToBase64String(encode)
        Return msg

    End Function

    Dim Connection As New SqlConnection("Data Source=DESKTOP-464VDBT;Initial Catalog=TheiaShoppe;Integrated Security=True")

    Public Sub Clear()
        txtUserName.Text = ""
        txtPassword.Text = ""
        txtRePassword.Text = ""
    End Sub
    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click
        Me.Show()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If txtPassword.Text <> txtRePassword.Text Then
                MsgBox("Re-type Password did Not Match", vbExclamation)

            Else
                Connection.Open()
                Dim query = "insert into Users values('" & txtUserName.Text & "','" & Encrypt(txtPassword.Text) & "')"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Connection)
                cmd.ExecuteNonQuery()
                MsgBox("Recorde has been Successfully Added")
                Connection.Close()
                Clear()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Clear()
    End Sub
End Class