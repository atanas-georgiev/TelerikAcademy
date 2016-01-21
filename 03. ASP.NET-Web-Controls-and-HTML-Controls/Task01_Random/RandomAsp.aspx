<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RandomAsp.aspx.cs" Inherits="Task01_Random.RandomAsp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Random Asp Controls</title>
</head>
<body>
    <h3>ASP.NET Controls</h3>
    <form id="formRandomAsp" runat="server">              
        <asp:Label ID="LabelFirstNumber" runat="server" Text="Random number from: "></asp:Label>
        <asp:TextBox ID="TextBoxFirstNumber" runat="server" Width="50px"></asp:TextBox>
        <asp:Label ID="LabelSecondNumber" runat="server" Text=" to: "></asp:Label>
        <asp:TextBox ID="TextBoxSecondNumber" runat="server" Width="50px"></asp:TextBox>
        <asp:Button ID="ButtonAspRandom" runat="server" Text="Generate" OnClick="ButtonAspRandom_Click" Width="83px" />
        <br/>
        <asp:Label ID="LabelAspResult" runat="server" Text=""></asp:Label>
    </form> 
</body>
</html>
