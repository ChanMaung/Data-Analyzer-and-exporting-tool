<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MemberPage.aspx.cs" Inherits="A8.Member.MemberPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>This is member page</h1>
        </div>
        <div>
            <% Response.Write("Hello " + Context.User.Identity.Name); %>
        </div>
        <div>
            <asp:Button ID="Button1" runat="server" Text="Sign Out" OnClick="Button1_Click" />
        </div><br />

        <div>
            <p>Step 1: Enter Number to Analyze</p>
            <asp:TextBox ID="TextBox1" runat="server" Width="194px">Enter Number Here</asp:TextBox>           
        <p>
            <asp:Button ID="Button2" runat="server" Text="Add to list" Width="118px" OnClick="Button2_Click"  />
            <asp:Button ID="Button3" runat="server" Text="Remove from list" Width="145px" OnClick="Button3_Click"  />
            <asp:Button ID="Button4" runat="server" Text="Reset" Width="146px" OnClick="Button4_Click"/>
        </p>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Display data string here" Visible="True"></asp:Label>
        </p><p>step 2: Perform Math Fuctions</p>
        </div>

        <div>
             
        <p>
            <asp:Button ID="Button5" runat="server" Text="Get Min" Width="181px" OnClick="Button5_Click"  />
            <asp:Button ID="Button6" runat="server" Text="Get Max" Width="181px" OnClick="Button6_Click"  />
        </p>
        <p>
             <asp:Button ID="Button7" runat="server" Text="Get Mean" Width="181px" OnClick="Button7_Click"  />
            <asp:Button ID="Button8" runat="server" Text="Get Median" Width="181px" OnClick="Button8_Click"  />
            <asp:Button ID="Button9" runat="server" Text="Get Mode" Width="181px"  style="height: 29px" OnClick="Button9_Click" />
        </p>


        <p>
            <asp:Label ID="Label2" runat="server" Text="Display Result Here"></asp:Label>
        </p>

            <p>step 3: Export results as text file to view/download</p>
        </div>

        <div>
            <p> <asp:TextBox ID="TextBox2" runat="server" Width="194px">Enter File name to create with .txt at the end.</asp:TextBox></p>
            <asp:Button ID="Button10" runat="server" Text="Create Text File with Results" Width="228px" OnClick="Button10_Click" />

            <p>
            <asp:Label ID="Label3" runat="server" Text="Display URL Here"></asp:Label>
        </p>
        </div>
        <div>
            <asp:Button ID="Button11" runat="server" Text="Sign Out" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
