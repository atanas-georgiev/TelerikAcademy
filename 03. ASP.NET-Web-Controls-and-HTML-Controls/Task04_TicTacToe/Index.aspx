<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Task04_TicTacToe.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="GridViewGame" runat="server" OnSelectedIndexChanged="GridViewGame_SelectedIndexChanged" OnSelectedIndexChanging="GridViewGame_SelectedIndexChanging">
        </asp:GridView>
    </form>
</body>
</html>
