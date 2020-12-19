<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="A8.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Must Login First</h1>
        </div>
        <div>
            <asp:Button ID="Button1" runat="server" Text="Member Login" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="Staff Page 1 Login" OnClick="Button2_Click" />
            <asp:Button ID="Button3" runat="server" Text="Staff Page 2 Login" OnClick="Button3_Click" />
        </div>
    </form>
</body>
</html>
