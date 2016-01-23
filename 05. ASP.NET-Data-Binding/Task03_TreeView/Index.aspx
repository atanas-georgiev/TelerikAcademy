<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Task03_TreeView.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="width: 319px">
    
        <asp:TreeView ID="TreeViewData" runat="server" DataSourceID="XmlDataSourceData" ShowLines="True" OnSelectedNodeChanged="TreeViewData_SelectedNodeChanged">
        </asp:TreeView>
        <asp:Label ID="LabelSelected" runat="server"></asp:Label>
        <asp:XmlDataSource ID="XmlDataSourceData" runat="server" DataFile="~/data.xml"></asp:XmlDataSource>
    
    </div>
    </form>
</body>
</html>
