<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="A8.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>App Demo</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Public Page</h1>
        </div>
        <div>
            <asp:Button ID="Button1" runat="server" Text="Members Page" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="Staff Page 1" OnClick="Button2_Click" />
            <asp:Button ID="Button3" runat="server" Text="Staff Page 2" OnClick="Button3_Click" />
        </div>
        <br /><br />
        <div>
            <asp:Button ID="Button4" runat="server" Text="Members Login" OnClick="Button4_Click" />
            <asp:Button ID="Button5" runat="server" Text="Members Register" OnClick="Button5_Click" />
        </div>
        <br />
        <div>
            <asp:Button ID="Button6" runat="server" Text="Staff Page 1 Login" OnClick="Button6_Click" />
            <asp:Button ID="Button7" runat="server" Text="Staff Page 2 Login" OnClick="Button7_Click" />
        </div>
        <div>
            <p> The system will take a set of int numbers and perform an analysis for the user.
                Data will be written into a text file through manual input from user. After the data has been inserted into the system, the user can perform different analysis tasks such as calculation of mean, median, mode of the data. The result can be exported as a text file on the server to view/download.</p>
            <br />
            <p> Users must first sign up to use the services located at the member page. Staff Pages can only
                be accessed by specific user staff1 and staff2. The crediential for staff is listed on the staff
                login page.
            </p>
        </div>

         <style type="text/css">
        .auto-style1 {
            width: 245px;
        }
        .auto-style2 {
            width: 217px;
        }
        .auto-style3 {
            width: 90px;
        }
        .auto-style4 {
            width: 207px;
        }
        .auto-style5 {
            width: 243px;
        }
        .auto-style6 {
            width: 400px;
        }
    </style>
    <style>
        table, th, td {
         border: 2px solid black;
         border-collapse: collapse;
}
    </style>
    <br /><br /><br />



    </form>
</body>
</html>
