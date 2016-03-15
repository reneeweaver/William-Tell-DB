Public Class _default
    Inherits System.Web.UI.Page
    Dim punchdate As String
    Dim inh1 As String
    Dim inh2 As String
    Dim inh3 As String
    Dim inh4 As String
    Dim inm1 As String
    Dim inm2 As String
    Dim inm3 As String
    Dim inm4 As String
    Dim outh1 As String
    Dim outh2 As String
    Dim outh3 As String
    Dim outh4 As String
    Dim outm1 As String
    Dim outm2 As String
    Dim outm3 As String
    Dim outm4 As String
    Dim amin1 As Boolean
    Dim amin2 As Boolean
    Dim amin3 As Boolean
    Dim amin4 As Boolean
    Dim amout1 As Boolean
    Dim amout2 As Boolean
    Dim amout3 As Boolean
    Dim amout4 As Boolean

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
    Protected Sub process_save()

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        punchdate = Me.TextBox1.Text
        inh1 = Me.TextBox2.Text.Split(":").GetValue(0)
        inm1 = Me.TextBox2.Text.Split(":").GetValue(1)

        inh2 = Me.TextBox4.Text.Split(":").GetValue(0)
        inm2 = Me.TextBox4.Text.Split(":").GetValue(1)

        inh3 = Me.TextBox6.Text.Split(":").GetValue(0)
        inm3 = Me.TextBox6.Text.Split(":").GetValue(1)

        inh4 = Me.TextBox8.Text.Split(":").GetValue(0)
        inm4 = Me.TextBox8.Text.Split(":").GetValue(1)

        outh1 = Me.TextBox3.Text.Split(":").GetValue(0)
        outm1 = Me.TextBox3.Text.Split(":").GetValue(1)

        outh2 = Me.TextBox5.Text.Split(":").GetValue(0)
        outm2 = Me.TextBox5.Text.Split(":").GetValue(1)

        outh3 = Me.TextBox7.Text.Split(":").GetValue(0)
        outm3 = Me.TextBox7.Text.Split(":").GetValue(1)

        outh4 = Me.TextBox9.Text.Split(":").GetValue(0)
        outm4 = Me.TextBox9.Text.Split(":").GetValue(1)

        If Me.DropDownList1.SelectedIndex = 0 Then
            amin1 = True
        Else
            amin1 = False
        End If

        If Me.DropDownList3.SelectedIndex = 0 Then
            amin2 = True
        Else
            amin2 = False
        End If

        If Me.DropDownList5.SelectedIndex = 0 Then
            amin3 = True
        Else
            amin3 = False
        End If

        If Me.DropDownList7.SelectedIndex = 0 Then
            amin4 = True
        Else
            amin4 = False
        End If

        If Me.DropDownList2.SelectedIndex = 0 Then
            amout1 = True
        Else
            amout1 = False
        End If

        If Me.DropDownList4.SelectedIndex = 0 Then
            amout2 = True
        Else
            amout2 = False
        End If

        If Me.DropDownList6.SelectedIndex = 0 Then
            amout3 = True
        Else
            amout3 = False
        End If

        If Me.DropDownList8.SelectedIndex = 0 Then
            amout4 = True
        Else
            amout4 = False
        End If
        If Not punchdate = "" Then
            process_save()
        End If
    End Sub
End Class