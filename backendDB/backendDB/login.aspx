<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="login.aspx.vb" Inherits="backendDB.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Timesheet Login</title>
    <link rel="stylesheet" type="text/css" href="http://webhomework.geekkidconsulting.com/iit-timesheet/Screen.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Please enter your username:<br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        Please enter your password:<br />
        <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Login" />
        <br />
        <br />
    
    </div>
        <asp:Button ID="Button2" runat="server" Text="Create test account" />
    </form>
</body>
</html>
