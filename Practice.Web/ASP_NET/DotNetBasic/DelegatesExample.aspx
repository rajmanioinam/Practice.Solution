<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DelegatesExample.aspx.cs" Inherits="Practice.Web.ASP_NET.DotNetBasic.DelegatesExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td><asp:TextBox ID="Num1" runat="server"></asp:TextBox></td>
                    <td><asp:DropDownList ID="ddlOperation" runat="server">
                        <asp:ListItem Value="1" Text="Add"></asp:ListItem>
                        <asp:ListItem Value="2" Text="Subtract"></asp:ListItem>
                        <asp:ListItem Value="3" Text="Multiply"></asp:ListItem>
                        </asp:DropDownList></td>
                    <td><asp:TextBox ID="Num2" runat="server"></asp:TextBox></td>
                    <td>
                        <asp:Label runat="server" ID="lblResult"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td colspan="4">
                        <asp:Button id="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click"/>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
