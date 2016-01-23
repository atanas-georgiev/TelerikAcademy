<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Task01_CarLibrary.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        Make:
        <asp:DropDownList ID="DropDownListProducers" runat="server" DataTextField="Name" DataValueField="Name" AutoPostBack="True" OnSelectedIndexChanged="DropDownListProducers_SelectedIndexChanged">
        </asp:DropDownList>
        <br />
        Model
        <asp:DropDownList ID="DropDownListModels" runat="server" AutoPostBack="True">
        </asp:DropDownList>
        <br />
        Extras:
        <asp:CheckBoxList ID="CheckBoxListExtras" runat="server" DataTextField="Name" DataValueField="Id" AutoPostBack="True">
        </asp:CheckBoxList>
        <br />
        Engine:
        <asp:RadioButtonList ID="RadioButtonListEngine" runat="server" AutoPostBack="True">
        </asp:RadioButtonList>
        <br />
        <br />
        Selected car and options:<br />
        <asp:Literal ID="LiteralSelected" runat="server"></asp:Literal>
    </form>
</body>
</html>
