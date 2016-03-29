Imports System.Security.Cryptography
Public Class _default
    Inherits System.Web.UI.Page
    Dim dbpath As String = "C:\NewDBs\IIT-Homework\my_iit_timesheet\"
    Dim iitcookiename As String = ("372fd75847c64826d41b24ac512d11803834447a")
    Dim usr As String

    Dim punchdate As String = ""
    Dim inh1 As String = ""
    Dim inh2 As String = ""
    Dim inh3 As String = ""
    Dim inh4 As String = ""
    Dim inm1 As String = ""
    Dim inm2 As String = ""
    Dim inm3 As String = ""
    Dim inm4 As String = ""
    Dim outh1 As String = ""
    Dim outh2 As String = ""
    Dim outh3 As String = ""
    Dim outh4 As String = ""
    Dim outm1 As String = ""
    Dim outm2 As String = ""
    Dim outm3 As String = ""
    Dim outm4 As String = ""
    Dim amin1 As String = ""
    Dim amin2 As String = ""
    Dim amin3 As String = ""
    Dim amin4 As String = ""
    Dim amout1 As String = ""
    Dim amout2 As String = ""
    Dim amout3 As String = ""
    Dim amout4 As String = ""

    Dim path As String = ""

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'authenticate to page
        If (Request.Cookies(iitcookiename) IsNot Nothing) Then
            If (Request.Cookies(iitcookiename)("user") IsNot Nothing) Then
                usr = Request.Cookies(iitcookiename)("user")
                Dim token As String
                If (Request.Cookies(iitcookiename)("token") IsNot Nothing) Then
                    token = Request.Cookies(iitcookiename)("token")
                    If Not (token = GetHash(usr & My.Computer.FileSystem.ReadAllText(dbpath & usr & "\passhash.txt") & usr & "asdfghjkl;'")) Then
                        Response.Redirect("login.aspx")
                    End If
                Else
                    Response.Redirect("login.aspx")
                End If
            Else
                Response.Redirect("login.aspx")
            End If
        Else
            Response.Redirect("login.aspx")
        End If



        If Request.QueryString("action") = "pull" Then
            senddata()
        Else
            getdata()
        End If



    End Sub
    Private Sub getdata()
        MsgBox("get")
        punchdate = Request.QueryString("date")
        inh1 = Request.QueryString("inh1")
        inh2 = Request.QueryString("inh2")
        inh3 = Request.QueryString("inh3")
        inh4 = Request.QueryString("inh4")
        inm1 = Request.QueryString("inm1")
        inm2 = Request.QueryString("inm2")
        inm3 = Request.QueryString("inm3")
        inm4 = Request.QueryString("inm4")
        outh1 = Request.QueryString("outh1")
        outh2 = Request.QueryString("outh2")
        outh3 = Request.QueryString("outh3")
        outh4 = Request.QueryString("outh4")
        outm1 = Request.QueryString("outm1")
        outm2 = Request.QueryString("outm2")
        outm3 = Request.QueryString("outm3")
        outm4 = Request.QueryString("outm4")
        amin1 = Request.QueryString("amin1")
        amin2 = Request.QueryString("amin2")
        amin3 = Request.QueryString("amin3")
        amin4 = Request.QueryString("amin4")
        amout1 = Request.QueryString("amout1")
        amout2 = Request.QueryString("amout2")
        amout3 = Request.QueryString("amout3")
        amout4 = Request.QueryString("amout4")
        If Not punchdate = "" Then
            process_save()
        End If
    End Sub
    Private Sub senddata()
        MsgBox("send")
        Me.TextBox1.Text = "asdfhasjklfdhsadljkfhdslajkf"
        path = (dbpath & usr & "\" & punchdate & "\")
        If My.Computer.FileSystem.DirectoryExists(path) Then
            Dim placeholdnum As Integer

            placeholdnum = read("inh1")
            If placeholdnum < 12 Then
                inh1 = (placeholdnum - 12)
                amin1 = False
            Else
                inh1 = placeholdnum
                amin1 = True
            End If

            placeholdnum = read("inh2")
            If placeholdnum < 12 Then
                inh2 = (placeholdnum - 12)
                amin2 = False
            Else
                inh2 = placeholdnum
                amin2 = True
            End If

            placeholdnum = read("inh3")
            If placeholdnum < 12 Then
                inh3 = (placeholdnum - 12)
                amin3 = False
            Else
                inh3 = placeholdnum
                amin3 = True
            End If

            placeholdnum = read("inh4")
            If placeholdnum < 12 Then
                inh4 = (placeholdnum - 12)
                amin4 = False
            Else
                inh4 = placeholdnum
                amin4 = True
            End If


            placeholdnum = read("outh1")
            If placeholdnum < 12 Then
                outh1 = (placeholdnum - 12)
                amout1 = False
            Else
                outh1 = placeholdnum
                amout1 = True
            End If

            placeholdnum = read("outh2")
            If placeholdnum < 12 Then
                outh2 = (placeholdnum - 12)
                amout2 = False
            Else
                outh2 = placeholdnum
                amout2 = True
            End If

            placeholdnum = read("outh3")
            If placeholdnum < 12 Then
                outh3 = (placeholdnum - 12)
                amout3 = False
            Else
                outh3 = placeholdnum
                amout3 = True
            End If

            placeholdnum = read("outh4")
            If placeholdnum < 12 Then
                outh4 = (placeholdnum - 12)
                amout4 = False
            Else
                outh4 = placeholdnum
                amout4 = True
            End If


            inm1 = read("inm1")
            inm2 = read("inm2")
            inm3 = read("inm3")
            inm4 = read("inm4")

            outm1 = read("outm1")
            outm2 = read("outm2")
            outm3 = read("outm3")
            outm4 = read("outm4")

        Else
            inh1 = "00"
            inh2 = "00"
            inh3 = "00"
            inh4 = "00"
            inm1 = "00"
            inm2 = "00"
            inm3 = "00"
            inm4 = "00"
            amin1 = "True"
            amin2 = "True"
            amin3 = "True"
            amin4 = "True"
            outh1 = "00"
            outh2 = "00"
            outh3 = "00"
            outh4 = "00"
            outm1 = "00"
            outm2 = "00"
            outm3 = "00"
            outm4 = "00"
            amout1 = "True"
            amout2 = "True"
            amout3 = "True"
            amout4 = "True"
        End If

        Dim datacookie As HttpCookie = New HttpCookie(punchdate)
        datacookie.Values.Add("inh1", inh1)
        datacookie.Values.Add("inh2", inh2)
        datacookie.Values.Add("inh3", inh3)
        datacookie.Values.Add("inh4", inh4)
        datacookie.Values.Add("inm1", inm1)
        datacookie.Values.Add("inm2", inm2)
        datacookie.Values.Add("inm3", inm3)
        datacookie.Values.Add("inm4", inm4)
        datacookie.Values.Add("inam1", amin1)
        datacookie.Values.Add("inam2", amin2)
        datacookie.Values.Add("inam3", amin3)
        datacookie.Values.Add("inam4", amin4)
        datacookie.Values.Add("outh1", outh1)
        datacookie.Values.Add("outh2", outh2)
        datacookie.Values.Add("outh3", outh3)
        datacookie.Values.Add("outh4", outh4)
        datacookie.Values.Add("outm1", outm1)
        datacookie.Values.Add("outm2", outm2)
        datacookie.Values.Add("outm3", outm3)
        datacookie.Values.Add("outm4", outm4)
        datacookie.Values.Add("outam1", amout1)
        datacookie.Values.Add("outam2", amout2)
        datacookie.Values.Add("outam3", amout3)
        datacookie.Values.Add("outam4", amout4)


        datacookie.Domain = (".geekkidconsulting.com")
        datacookie.Expires = (My.Computer.Clock.LocalTime.AddMinutes(1))
        Response.Cookies.Add(datacookie)
        Response.Redirect("http://webhomework.geekkidconsulting.com/iit-timesheet/index.php?date=" & punchdate)
    End Sub
    Private Function read(ByVal file As String)
        Return My.Computer.FileSystem.ReadAllText(path & file)
    End Function
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
    Protected Sub process_save()
        Dim savedate As Date = punchdate
        path = (dbpath & usr & "\" & punchdate & "\")
        If Not My.Computer.FileSystem.DirectoryExists(path) Then
            My.Computer.FileSystem.CreateDirectory(path)
        End If
        write("date", (savedate.Month & "-" & savedate.Day & "-" & savedate.Year))
        Dim placeholdnum As Integer
        If amin1 = "False" Then
            If Not inh1 = "" Then
                placeholdnum = inh1
                placeholdnum += 12
                inh1 = placeholdnum
            End If
        End If
        If amin2 = "False" Then
            If Not inh2 = "" Then
                placeholdnum = inh2
                placeholdnum += 12
                inh2 = placeholdnum
            End If
        End If
        If amin3 = "False" Then
            If Not inh3 = "" Then
                placeholdnum = inh3
                placeholdnum += 12
                inh3 = placeholdnum
            End If
        End If
        If amin4 = "False" Then
            If Not inh4 = "" Then
                placeholdnum = inh4
                placeholdnum += 12
                inh4 = placeholdnum
            End If
        End If
        If amout1 = "False" Then
            If Not outh1 = "" Then
                placeholdnum = outh1
                placeholdnum += 12
                outh1 = placeholdnum
            End If
        End If


        If amout2 = "False" Then
            If Not outh2 = "" Then
                placeholdnum = outh2
                placeholdnum += 12
                outh2 = placeholdnum
            End If
        End If
        If amout3 = "False" Then
            If Not outh3 = "" Then
                placeholdnum = outh3
                placeholdnum += 12
                outh3 = placeholdnum
            End If
        End If
        If amout4 = "False" Then
            If Not outh4 = "" Then
                placeholdnum = outh4
                placeholdnum += 12
                outh4 = placeholdnum
            End If
        End If

        write("inh1", inh1)
        write("inh2", inh2)
        write("inh3", inh3)
        write("inh4", inh4)
        write("outh1", outh1)
        write("outh2", outh2)
        write("outh3", outh3)
        write("outh4", outh4)
        write("inm1", inm1)
        write("inm2", inm2)
        write("inm3", inm3)
        write("inm4", inm4)
        write("outm1", outm1)
        write("outm2", outm2)
        write("outm3", outm3)
        write("outm4", outm4)
        Response.Redirect("default.aspx?action=pull&date=" & punchdate)
    End Sub
    Protected Sub write(ByVal file As String, ByVal value As String)
        My.Computer.FileSystem.WriteAllText((path & file), value, False)
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        punchdate = Me.TextBox1.Text
        If Not Me.TextBox2.Text = "" Then
            inh1 = Me.TextBox2.Text.Split(":").GetValue(0)
            inm1 = Me.TextBox2.Text.Split(":").GetValue(1)
        End If


        If Not Me.TextBox4.Text = "" Then
            inh2 = Me.TextBox4.Text.Split(":").GetValue(0)
            inm2 = Me.TextBox4.Text.Split(":").GetValue(1)
        End If

        If Not Me.TextBox6.Text = "" Then
            inh3 = Me.TextBox6.Text.Split(":").GetValue(0)
            inm3 = Me.TextBox6.Text.Split(":").GetValue(1)
        End If

        If Not Me.TextBox8.Text = "" Then
            inh4 = Me.TextBox8.Text.Split(":").GetValue(0)
            inm4 = Me.TextBox8.Text.Split(":").GetValue(1)
        End If

        If Not Me.TextBox3.Text = "" Then
            outh1 = Me.TextBox3.Text.Split(":").GetValue(0)
            outm1 = Me.TextBox3.Text.Split(":").GetValue(1)
        End If

        If Not Me.TextBox5.Text = "" Then
            outh2 = Me.TextBox5.Text.Split(":").GetValue(0)
            outm2 = Me.TextBox5.Text.Split(":").GetValue(1)
        End If

        If Not Me.TextBox7.Text = "" Then
            outh3 = Me.TextBox7.Text.Split(":").GetValue(0)
            outm3 = Me.TextBox7.Text.Split(":").GetValue(1)
        End If

        If Not Me.TextBox9.Text = "" Then
            outh4 = Me.TextBox9.Text.Split(":").GetValue(0)
            outm4 = Me.TextBox9.Text.Split(":").GetValue(1)
        End If


        If Me.DropDownList1.SelectedIndex = 0 Then
            amin1 = "True"
        Else
            amin1 = "False"
        End If

        If Me.DropDownList3.SelectedIndex = 0 Then
            amin2 = "True"
        Else
            amin2 = "False"
        End If

        If Me.DropDownList5.SelectedIndex = 0 Then
            amin3 = "True"
        Else
            amin3 = "False"
        End If

        If Me.DropDownList7.SelectedIndex = 0 Then
            amin4 = "True"
        Else
            amin4 = "False"
        End If

        If Me.DropDownList2.SelectedIndex = 0 Then
            amout1 = "True"
        Else
            amout1 = "False"
        End If

        If Me.DropDownList4.SelectedIndex = 0 Then
            amout2 = "True"
        Else
            amout2 = "False"
        End If

        If Me.DropDownList6.SelectedIndex = 0 Then
            amout3 = "True"
        Else
            amout3 = "False"
        End If

        If Me.DropDownList8.SelectedIndex = 0 Then
            amout4 = "True"
        Else
            amout4 = "False"
        End If
        If Not punchdate = "" Then
            process_save()
        End If
    End Sub
End Class