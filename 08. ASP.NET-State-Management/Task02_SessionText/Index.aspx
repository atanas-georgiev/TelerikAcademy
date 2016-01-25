<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Task02_SessionText.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Enter text:
        <asp:TextBox ID="TextBoxInput" runat="server"></asp:TextBox>
        <asp:Button ID="ButtonInput" runat="server" OnClick="ButtonInput_Click" Text="Enter" />
        <br />
        <br />
        <asp:Label ID="LabelResult" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Label ID="LabelSessionResult" runat="server" Text="Texts in the session:"></asp:Label>
        <asp:ListView ID="ListViewSessionResult" runat="server" ItemType="System.String" SelectMethod="Select">
            <EmptyDataTemplate>
                No data yet!
            </EmptyDataTemplate>        
            <LayoutTemplate>
                <ul>
                    <asp:PlaceHolder runat="server" ID="itemPlaceHolder" />
                </ul>
            </LayoutTemplate>    
            <ItemTemplate>
                <li>
                    <%# Item %>                    
                </li>
            </ItemTemplate>
        </asp:ListView>
    
    </div>
    </form>
</body>
</html>
