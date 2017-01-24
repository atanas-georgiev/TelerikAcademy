<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Task04_ViewStateDeletion.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <script src="https://code.jquery.com/jquery-2.2.0.min.js"></script>
    <form id="formVSDelete" runat="server">
    Enter some text here:
    <asp:TextBox ID="TextBoxInput" runat="server"></asp:TextBox>
    <br/>
    <asp:Button ID="ButtonDeleteViewState" runat="server" Text="Delete View State and do Postback" OnClientClick="(function() { $('.aspNetHidden').remove(); })();"/>
    </form>
</body>
</html>
