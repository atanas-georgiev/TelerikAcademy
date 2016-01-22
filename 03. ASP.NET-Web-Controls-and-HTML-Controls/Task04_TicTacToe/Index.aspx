<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Task04_TicTacToe.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="formTicTacToe" runat="server">
        <asp:Button ID="ButtonNewGame" runat="server" OnClick="ButtonNewGame_Click" Text="New Game" />
        <br/>
        <asp:Button ID="Button1_1" runat="server" Text="" OnClick="Button1_1_Click" />        
        <asp:Button ID="Button1_2" runat="server" Text="" OnClick="Button1_2_Click" />
        <asp:Button ID="Button1_3" runat="server" Text="" OnClick="Button1_3_Click" />
        <br/>
        <asp:Button ID="Button2_1" runat="server" Text="" OnClick="Button2_1_Click" />
        <asp:Button ID="Button2_2" runat="server" Text="" OnClick="Button2_2_Click" />
        <asp:Button ID="Button2_3" runat="server" Text="" OnClick="Button2_3_Click" />
        <br/>
        <asp:Button ID="Button3_1" runat="server" Text="" OnClick="Button3_1_Click" />
        <asp:Button ID="Button3_2" runat="server" Text="" OnClick="Button3_2_Click" />
        <asp:Button ID="Button3_3" runat="server" Text="" OnClick="Button3_3_Click" />     
        <br/>   
        <asp:Literal ID="LiteralResult" runat="server"></asp:Literal>        
    </form>
</body>
</html>
