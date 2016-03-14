Public Class _default
    Inherits System.Web.UI.Page
    Dim punchdate As Date
    Dim in1 As String
    Dim in2 As String
    Dim in3 As String
    Dim in4 As String
    Dim out1 As String
    Dim out2 As String
    Dim out3 As String
    Dim out4 As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        punchdate = Request.QueryString("date")
        in1 = Request.QueryString("in1")
        in2 = Request.QueryString("in2")
        in3 = Request.QueryString("in3")
        in4 = Request.QueryString("in4")
        out1 = Request.QueryString("out1")
        out2 = Request.QueryString("out2")
        out3 = Request.QueryString("out3")
        out4 = Request.QueryString("out4")
    End Sub
    Protected Sub process_save()

    End Sub

End Class