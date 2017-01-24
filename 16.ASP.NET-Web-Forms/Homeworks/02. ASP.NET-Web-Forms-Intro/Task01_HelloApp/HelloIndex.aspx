<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HelloIndex.aspx.cs" Inherits="Task01_HelloApp.HelloIndex" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="formHello" runat="server">
        Enter your name:
        <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="ButtonHello" runat="server" Text="Say hello!" OnClick="ButtonHello_Click" />
        <br />
        <br />
        <asp:Label ID="LabelResult" runat="server" Text=""></asp:Label>
        <br />
    </form>
</body>
</html>
