<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Loan_Request.aspx.cs" Inherits="WebApplication13.Loan_Details1" %>

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
        <div>
            <br />
            <br />
            <br />
            <align="center">
            <table >
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Requested_For"></asp:Label></td><td>
                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
                </tr>
                    <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Requested_Amount"></asp:Label></td><td>
                            <asp:TextBox ID="TextBox2" runat="server" Height="22px"></asp:TextBox></td>
                </tr>
                    <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Loan_Description"></asp:Label></td><td>
                            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
                </tr>
                    <tr>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="Email_Id"></asp:Label></td><td>
                            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="Button1" runat="server" Text="submit" OnClick="Button1_Click" /></td>
                </tr>
            </table>
                </align>
        </div>
    </form>
</body>
</html>
