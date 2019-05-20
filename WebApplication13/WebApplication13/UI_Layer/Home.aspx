<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="WebApplication13.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script>
        function preventBack() { window.history.forward(); }
        setTimeout("preventBack()", 0);
        window.onunload = function () { null };
    </script>
</head>
<body bgcolor="aqua">
    <form id="form1" runat="server">
        <center>
        <div>

            <asp:Button ID="Button1" runat="server" Text="SignIn" OnClick="Button1_Click" />
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" Text="SignUp" OnClick="Button2_Click" />
            <br />
            <br />
            <asp:Button ID="Button3" runat="server" Text="GuestRequest" OnClick="Button3_Click" />
            <br />
               <br />
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click1" Text="check" />
            <br />
               <br />
        </div>
             </center>
    </form>
</body>
</html>
