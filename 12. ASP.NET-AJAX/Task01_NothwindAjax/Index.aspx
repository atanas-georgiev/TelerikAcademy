<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Task01_NothwindAjax.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css" rel="stylesheet" integrity="sha256-7s5uDGW3AHqw6xtJmNNtr+OBRJUlgkNJEo78P4b0yRw= sha512-nNo+yCHEyn0smMxSswnf/OnX6/KwJuZTlNZBjauKhTK0c+zT+q5JOCx0UFhXQ6rJR9jg6Es8gPuD2uZcYDLqSw==" crossorigin="anonymous">
</head>
<body>
    <form id="formNW" runat="server">
        <asp:ScriptManager ID="ScriptManager" runat="server" />
        <div class="panel panel-default">
            <div class="panel-heading">Employees</div>
            <div class="panel-body">
                <div class="row">
                    <div class="col-md-12">
                        <asp:GridView runat="server" AutoGenerateColumns="False" AllowSorting="True" ID="GridViewEmployees"
                            SelectMethod="GridViewEmployees_Select" ItemType="Task01_NothwindAjax.Employee" OnSelectedIndexChanged="GridViewEmployees_SelectedIndexChanged">
                            <Columns>
                                <asp:CommandField ShowSelectButton="True" />
                                <asp:BoundField DataField="FirstName" HeaderText="FirstName" />
                                <asp:BoundField DataField="LastName" HeaderText="LastName" />
                                <asp:BoundField DataField="Title" HeaderText="Title" />
                                <asp:BoundField DataField="City" HeaderText="City" />
                            </Columns>
                        </asp:GridView>
                    </div>
                    <asp:UpdateProgress ID="UpdateProgressDemo" runat="server" AssociatedUpdatePanelID="UpdatePanelOrders">
                        <ProgressTemplate>
                            <div id="row">Updating ...</div>
                        </ProgressTemplate>
                    </asp:UpdateProgress>
                </div>
            </div>
        </div>
        <div class="panel panel-default">
            <div class="panel-heading">Employees</div>
            <div class="panel-body">
                <div class="row">
                    <div class="col-md-12">
                        <asp:UpdatePanel ID="UpdatePanelOrders" runat="server">
                            <ContentTemplate>
                                <asp:GridView runat="server" AutoGenerateColumns="False" AllowSorting="True" ID="GridViewOrders"
                                    SelectMethod="GridViewOrders_Select" ItemType="Task01_NothwindAjax.Order">
                                    <Columns>
                                        <asp:CommandField ShowSelectButton="True" />
                                        <asp:BoundField DataField="OrderDate" HeaderText="OrderDate" />
                                        <asp:BoundField DataField="RequiredDate" HeaderText="RequiredDate" />
                                        <asp:BoundField DataField="ShipName" HeaderText="ShipName" />
                                        <asp:BoundField DataField="ShipCity" HeaderText="ShipCity" />
                                    </Columns>
                                </asp:GridView>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </div>
                </div>
            </div>
        </div>
        <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/js/bootstrap.min.js" integrity="sha256-KXn5puMvxCw+dAYznun+drMdG1IFl3agK0p/pqT9KAo= sha512-2e8qq0ETcfWRI4HJBzQiA3UoyFk6tbNyG+qSaIBZLyW9Xf3sWZHN/lxe9fTh1U45DpPf07yj94KsUHHWe4Yk1A==" crossorigin="anonymous"></script>
    </form>
</body>
</html>
