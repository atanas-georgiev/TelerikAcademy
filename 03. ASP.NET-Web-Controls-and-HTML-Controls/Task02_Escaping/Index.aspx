<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Task02_Escaping.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Html Escaping</title>
</head>
<body>
    <form id="formEscaping" runat="server">    
        <asp:Label ID="LabelInputText" runat="server" Text="Enter some text: "></asp:Label>
        <asp:TextBox ID="TextBoxInput" runat="server"></asp:TextBox>
        <asp:Button ID="ButtonEscape" runat="server" Text="Button" OnClick="ButtonEscape_Click" />
        <br/>
        <asp:Label ID="LabelOutput" runat="server" Text="Escaped html: "></asp:Label>
        <asp:TextBox ID="TextBoxOutput" runat="server" ReadOnly="True"></asp:TextBox>
        <br/>
        Escaped text: <%: this.TextBoxInput.Text %>
    </form>
</body>
</html>
