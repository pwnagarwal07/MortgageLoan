<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication13.Login" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <script>
        function preventBack() { window.history.forward(); }
        setTimeout("preventBack()", 0);
        window.onunload = function () { null };
    </script>
    <style type="text/css">
        .auto-style1 {
            width: 268px;
            height: 151px;
             font-family: verdana,arial,sans-serif;

                font-size:20px;

                color: black;

                border-width: 1px;

                border-color:pink;

                border-collapse: collapse;

                background: pink;
        }
    </style>
</head>
<body bgcolor="aqua">                                                                   
    <form id="form1" runat="server">
        <p>
            <asp:Button ID="Button2" runat="server" Text="Logout" Height="35px" Width="100px" style="float:right" OnClick="Button2_Click" Font-Bold="True" ForeColor="#3333FF"></asp:Button>
        </p>
        <div><center>
            <br />
            <br />
            <br />
            <table class="auto-style1">
                <tr><td colspan="2">Login</td></tr>
                <tr><td><asp:Label ID="Label1" runat="server" Text="Email_Id"></asp:Label></td><td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td></tr>
                <tr><td><asp:Label ID="Label2" runat="server" Text="Passwrd"></asp:Label></td><td><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td></tr>
                <tr><td colspan="2"><asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" BackColor="#FF66CC" BorderColor="#66FF99" CssClass="auto-style1" Font-Bold="True" Font-Names="Arial" Font-Size="Medium" ForeColor="Black" Height="40px"></asp:Button></td></tr>
         </table>
            </center>
        </div>
    </form>
</body>
</html>

