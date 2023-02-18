<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="loginForm.aspx.cs" Inherits="WebApplication1.loginForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lbusername" runat="server" Text="user name"></asp:Label>
        <asp:TextBox ID="txtuser" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lbPswd" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="txtPswd" TextMode="Password" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label1" runat="server" Enabled="False" Text="Label"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnLogin" runat="server" Text="Login" Width="242px" OnClick="btnLogin_Click" />
        </p>
    </form>
</body>
</html>
