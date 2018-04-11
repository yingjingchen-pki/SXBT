<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="KeyGeneraterWebApp.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="position: absolute; left: 38%; top: 38%;">
            <tr>
                <td>User name:</td>
                <td>
                    <asp:TextBox ID="usernameTextBox" runat="server" Width="300px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:Button ID="generatePassButton" runat="server" Text="Generate Password" OnClick="generatePassButton_Click" />
                </td>
            </tr>
            <tr>
                <td>Password:</td>
                <td>
                    <asp:TextBox ID="passwordTextBox" runat="server" ReadOnly="True" Width="300px"></asp:TextBox>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
