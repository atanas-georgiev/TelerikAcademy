<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Task02_Employes_GridView.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="GridViewEmployees" runat="server" AutoGenerateColumns="False" DataSourceID="EntityDataSourceNW" OnSelectedIndexChanged="GridViewEmployees_SelectedIndexChanged">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="LastName" HeaderText="LastName" ReadOnly="True" SortExpression="LastName" />
                <asp:BoundField DataField="FirstName" HeaderText="FirstName" ReadOnly="True" SortExpression="FirstName" />
                <asp:BoundField DataField="Title" HeaderText="Title" ReadOnly="True" SortExpression="Title" />
                <asp:BoundField DataField="TitleOfCourtesy" HeaderText="TitleOfCourtesy" ReadOnly="True" SortExpression="TitleOfCourtesy" />
                <asp:BoundField DataField="BirthDate" HeaderText="BirthDate" ReadOnly="True" SortExpression="BirthDate" />
                <asp:BoundField DataField="HireDate" HeaderText="HireDate" ReadOnly="True" SortExpression="HireDate" />
                <asp:BoundField DataField="Address" HeaderText="Address" ReadOnly="True" SortExpression="Address" />
                <asp:BoundField DataField="City" HeaderText="City" ReadOnly="True" SortExpression="City" />
                <asp:BoundField DataField="Region" HeaderText="Region" ReadOnly="True" SortExpression="Region" />
                <asp:BoundField DataField="PostalCode" HeaderText="PostalCode" ReadOnly="True" SortExpression="PostalCode" />
                <asp:BoundField DataField="Country" HeaderText="Country" ReadOnly="True" SortExpression="Country" />
                <asp:BoundField DataField="HomePhone" HeaderText="HomePhone" ReadOnly="True" SortExpression="HomePhone" />
                <asp:BoundField DataField="Extension" HeaderText="Extension" ReadOnly="True" SortExpression="Extension" />
                <asp:BoundField DataField="ReportsTo" HeaderText="ReportsTo" ReadOnly="True" SortExpression="ReportsTo" />
                <asp:BoundField DataField="PhotoPath" HeaderText="PhotoPath" ReadOnly="True" SortExpression="PhotoPath" />
            </Columns>
        </asp:GridView>
    <div>
    
    </div>
        <asp:EntityDataSource ID="EntityDataSourceNW" runat="server" ConnectionString="name=NORTHWNDEntities" DefaultContainerName="NORTHWNDEntities" EnableFlattening="False" EntitySetName="Employees" Select="it.[LastName], it.[FirstName], it.[Title], it.[TitleOfCourtesy], it.[BirthDate], it.[HireDate], it.[Address], it.[City], it.[Region], it.[PostalCode], it.[Country], it.[HomePhone], it.[Extension], it.[Photo], it.[ReportsTo], it.[PhotoPath]">
        </asp:EntityDataSource>
    </form>
</body>
</html>
