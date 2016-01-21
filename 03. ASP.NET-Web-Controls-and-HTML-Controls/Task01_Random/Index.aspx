<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Task01_Random.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Random numbers</title>
</head>
<body>
    <form id="formRandom" runat="server">
        <asp:Button ID="ButtonHtmlRandom" runat="server" Text="Goto Html Random Controls" OnClick="ButtonHtmlRandom_Click" />
        <br/>
        <asp:Button ID="ButtonAspRandom" runat="server" Text="Goto Asp Random Controls" OnClick="ButtonAspRandom_Click" />
    </form>
</body>
</html>
