<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StaffPage2.aspx.cs" Inherits="A8.Staff.StaffPage2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>This is Staff Page 2</h1>
        </div>
        <div>
            <% Response.Write("Hello " + Context.User.Identity.Name); %>
        </div>
        <div>
            <asp:Button ID="Button1" runat="server" Text="Sign Out" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
