<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MemberRegPage.aspx.cs" Inherits="A8.Member.MemberRegPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Member Register Page</h1>
        </div>
        <div>
            <asp:Label ID="Label1" runat="server" Text="User Name : "></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Label ID="Label3" runat="server" Text="Label" Visible="False"></asp:Label>
        </div>
        <div>
            <asp:Label ID="Label2" runat="server" Text="Password : "></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="Button1" runat="server" Text="Register" OnClick="Button1_Click" Width="120px" />          
        </div>
        <div>
             <asp:Button ID="Button2" runat="server" Text="Member Login Page" OnClick="Button2_Click" />
            <asp:Button ID="Button3" runat="server" Text="Public Page" OnClick="Button3_Click" />
        </div>
    </form>
</body>
</html>
