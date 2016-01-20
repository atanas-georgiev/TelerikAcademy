<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sumator.aspx.cs" Inherits="Task02_SumatorWebForms.Sumator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sumator</title>
</head>
<body>
    <form id="formSumator" runat="server">
        <div>
            First Number:
        <asp:TextBox ID="TextBoxFirst" runat="server"></asp:TextBox>
            <br />
            Second Number:
        <asp:TextBox ID="TextBoxSecond" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="ButtonSum" runat="server" Text="Sum" OnClick="ButtonSum_Click" />
            <br />
            Result:
            <asp:TextBox ID="TextBoxResult" runat="server" ReadOnly="True"></asp:TextBox>
        </div>
    </form>
</body>
</html>
