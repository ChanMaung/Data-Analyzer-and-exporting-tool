<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MemberLoginPage.aspx.cs" Inherits="A8.Member.MemberLoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Member Login Page</h1>
        </div>
        <div>
            <asp:Label ID="Label1" runat="server" Text="User Name : "></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label2" runat="server" Text="Password : "></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label3" runat="server" Text="Wrong Password" Visible="False"></asp:Label> 
            
        </div>
        <div>
            <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
        </div>
        <div>
            <asp:TextBox ID="TextBox3" runat="server" Text="Verify String"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
        </div>
        <div>
            <asp:Button ID="Button2" runat="server" Text="Registeration Page" OnClick="Button2_Click" />
            <asp:Button ID="Button3" runat="server" Text="Public Page" OnClick="Button3_Click" />
        </div>
    </form>
</body>
</html>
