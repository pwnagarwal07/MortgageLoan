<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DashBoard.aspx.cs" Inherits="WebApplication13.DashBoard" %>

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
        <div style="height: 214px">
            <align=center>
            <asp:Button ID="Button1" runat="server" Text="Loan_Request" OnClick="Button1_Click" />
                </align>

            <center>
           <asp:GridView ID="GridView1" runat="server"></asp:GridView>
                </center>
        </div>
    </form>
</body>
</html>
