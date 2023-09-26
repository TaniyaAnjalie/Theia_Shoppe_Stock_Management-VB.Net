Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class Form2

    Public Sub Clear()
        txtUserName.Text = ""
        txtPassword.Text = ""
    End Sub

    Private tripleDes As New TripleDESCryptoServiceProvider

    Public Function EncryptData(ByVal plaintext As String) As String
        Dim plaintextbytes() As Byte = System.Text.Encoding.Unicode.GetBytes(plaintext)
        Dim ms As New System.IO.MemoryStream
        Dim encstream As New CryptoStream(ms, tripleDes.CreateEncryptor(), System.Security.Cryptography.CryptoStreamMode.Write)

        encstream.Write(plaintextbytes, 0, plaintextbytes.Length)
        encstream.FlushFinalBlock()

        Return Convert.ToBase64String(ms.ToArray)
    End Function


    'Public Function Decrypt(ByRef encryptedtext As String) As String
    'Dim decrypttext As String = String.Empty
    'Dim encodetext As New UTF8Encoding()
    'Dim decode As Decoder = encodetext.GetDecoder()
    'Dim code_byte As Byte() = Convert.FromBase64String(encryptedtext)
    'Dim charcount As Integer = decode.GetCharCount(code_byte, 0, code_byte.Length)
    'Dim decode_char As Char() = New Char(charcount - 1) {}
    'decode.GetChars(code_byte, 0, code_byte.Length, decode_char, 0)
    'decrypttext = New String(decode_char)
    'Return decrypttext

    'End Function

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide()
        End
    End Sub

    Dim Connection As New SqlConnection("Data Source=DESKTOP-464VDBT;Initial Catalog=TheiaShoppe;Integrated Security=True")

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUserName.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Enter UserName and Password")
        ElseIf txtUserName.Text = "Admin" And txtPassword.Text = "1234" Then
            Form3.Show()
            Me.Hide()
        Else
            MsgBox("Wrong UserName or Password")
            Clear()
        End If
    End Sub

    Private Sub pnlLogin_Paint(sender As Object, e As PaintEventArgs) Handles pnlLogin.Paint

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Clear()
    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click

        Connection.Open()
        Dim sql = "Insert into Users values ((Select ISNULL (MAX(Id)+1,1) from Users),'" + txtUserName.Text.ToString() + "','" + EncryptData(txtPassword.Text.ToString()) + "')"
        '"insert into MemberTbl values((Select ISNULL (MAX(id)+1,1) from log3),'" & txtUserName.Text & "','EncryptData(txtPwrd.Text.ToString())')"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(sql, Connection)

        cmd.ExecuteNonQuery()
        MsgBox("User Added")
        Connection.Close()
        Clear()

    End Sub
End Class