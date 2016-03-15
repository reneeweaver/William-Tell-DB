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
    Dim amin1 As String
    Dim amin2 As String
    Dim amin3 As String
    Dim amin4 As String
    Dim amout1 As String
    Dim amout2 As String
    Dim amout3 As String
    Dim amout4 As String

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
        inh1 = Me.TextBox2.Text.Split(":").GetValue(0)
        inm1 = Me.TextBox2.Text.Split(":").GetValue(1)

        inh2 = Me.TextBox4.Text.Split(":").GetValue(0)
        inm2 = Me.TextBox4.Text.Split(":").GetValue(1)

        inh3 = Me.TextBox6.Text.Split(":").GetValue(0)
        inm3 = Me.TextBox6.Text.Split(":").GetValue(1)

        inh4 = Me.TextBox8.Text.Split(":").GetValue(0)
        inm4 = Me.TextBox8.Text.Split(":").GetValue(1)
    End Sub
End Class