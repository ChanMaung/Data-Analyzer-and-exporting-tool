<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StaffPage2Login.aspx.cs" Inherits="A8.Staff.StaffPage2Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1> Staff Page 2 Login</h1>
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
            <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
        </div>
        <div>
            <p> Staff 2 page credential:</p>
            <p>User Name = staff2</p>
            <p>Password = 456</p>
        </div>
    </form>
</body>
</html>
