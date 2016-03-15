Imports System.Security.Cryptography
Public Class login
    Inherits System.Web.UI.Page
    Dim dbpath As String = "C:\NewDBs\IIT-Homework\my_iit_timesheet\"

    Dim iitcookiename As String = ("372fd75847c64826d41b24ac512d11803834447a")
    Dim redirectsites As ArrayList
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        redirectsites = New ArrayList
        redirectsites.Add("http://ducksarethebest.com/")
        redirectsites.Add("http://www.trypap.com/")
        redirectsites.Add("http://randomcolour.com/")
        redirectsites.Add("http://cat-bounce.com/")
        redirectsites.Add("http://chrismckenzie.com/")
        redirectsites.Add("http://www.rrrgggbbb.com/")
        redirectsites.Add("http://www.fallingfalling.com")
        redirectsites.Add("http://ihasabucket.com/")
        redirectsites.Add("http://www.wwwdotcom.com/")
        redirectsites.Add("http://www.ouaismaisbon.ch/")
        redirectsites.Add("http://salmonofcapistrano.com/")
        redirectsites.Add("http://www.nelson-haha.com/")
        redirectsites.Add("http://www.patience-is-a-virtue.org/")
        redirectsites.Add("http://corndogoncorndog.com/")
        redirectsites.Add("http://www.baconsizzling.com/")
        redirectsites.Add("http://minecraftstal.com/")
        redirectsites.Add("http://tomsdog.com/")
        redirectsites.Add("http://dogs.are.the.most.moe/")
        redirectsites.Add("http://pixelsfighting.com/")
        redirectsites.Add("http://www.biglongnow.com/")
        redirectsites.Add("http://eelslap.com/")
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Not My.Computer.FileSystem.DirectoryExists(dbpath & Me.TextBox1.Text) Then
            My.Computer.FileSystem.CreateDirectory(dbpath & Me.TextBox1.Text)
        End If
        My.Computer.FileSystem.WriteAllText((dbpath & Me.TextBox1.Text & "\passhash.txt"), GetHash(Me.TextBox2.Text), False)
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

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not Me.TextBox1.Text = "" Then
            If My.Computer.FileSystem.FileExists(dbpath & Me.TextBox1.Text & "\passhash.txt") Then
                If (My.Computer.FileSystem.ReadAllText(dbpath & Me.TextBox1.Text & "\passhash.txt") = GetHash(Me.TextBox2.Text)) Then
                    Dim authcookie As HttpCookie = New HttpCookie(iitcookiename)
                    authcookie.Values.Add("user", Me.TextBox1.Text)
                    authcookie.Values.Add("token", GetHash(Me.TextBox1.Text & Me.TextBox2.Text & Me.TextBox1.Text & "asdfghjkl;'"))
                    authcookie.Expires = (My.Computer.Clock.LocalTime.AddMinutes(15))
                    Response.Cookies.Add(authcookie)
                Else
                    Response.Redirect(redirectsites.Item(GetRandom(0, 20)))
                End If
            End If
        End If

    End Sub
    Public Function GetRandom(ByVal min As Integer, ByVal max As Integer) As Integer

        Static Generator As System.Random = New System.Random()
        Return Generator.Next(min, max)

    End Function
End Class