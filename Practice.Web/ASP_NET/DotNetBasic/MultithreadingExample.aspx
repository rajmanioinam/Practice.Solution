<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MultithreadingExample.aspx.cs" Inherits="Practice.Web.ASP_NET.DotNetBasic.MultithreadingExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnDoWork" runat="server" Text="Do Work" OnClick="btnDoWork_Click"/>
            <asp:Button ID="btnDoAnotherWork" runat="server" Text="Do Another work" OnClick="btnDoAnotherWork_Click"/><br />
            
        </div>
    </form>
</body>
</html>
