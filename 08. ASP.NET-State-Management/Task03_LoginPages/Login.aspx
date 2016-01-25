<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Task03_LoginPages.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Please login with some username:
        <br/>
        <asp:TextBox ID="TextBoxInput" runat="server"></asp:TextBox>
        <br/>
        <asp:Button ID="ButtonLogin" runat="server" Text="Login" OnClick="ButtonLogin_OnClick" />
    
    </div>
    </form>
</body>
</html>
