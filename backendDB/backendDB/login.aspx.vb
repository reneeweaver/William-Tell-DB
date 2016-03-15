Imports System.Security.Cryptography
Public Class login
    Inherits System.Web.UI.Page
    Dim dbpath As String = "C:\NewDBs\IIT-Homework\my_iit_timesheet\"
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Not My.Computer.FileSystem.DirectoryExists(dbpath & Me.TextBox1.Text) Then
            My.Computer.FileSystem.CreateDirectory(dbpath & Me.TextBox1.Text)
        End If
    End Sub

    Private Function GetHash(ByVal password As String) As String
        Dim sha As New SHA1CryptoServiceProvider
        Dim bytesToHash() As Byte

        bytesToHash = System.Text.Encoding.ASCII.GetBytes(password)

        bytesToHash = sha.ComputeHash(bytesToHash)

        Dim encPassword As String = ""

        For Each b As Byte In bytesToHash
            encPassword += b.ToString("x2")
        Next

        bytesToHash = System.Text.Encoding.ASCII.GetBytes(encPassword)

        bytesToHash = sha.ComputeHash(bytesToHash)

        Dim encPasswordx2 As String = ""
        For Each b As Byte In bytesToHash
            encPasswordx2 += b.ToString("x2")
        Next

        Return encPasswordx2
    End Function

End Class