<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Task02_Employes_Repeater.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Repeater ID="RepeaterEmployees" runat="server" DataSourceID="EntityDataSourceNW">
            <HeaderTemplate>
                <table>
                    <th>LastName</th>
                    <th>FirstName</th>
                    <th>Title</th>
                    <th>TitleOfCourtesy</th>
                    <th>BirthDate</th>
                    <th>HireDate</th>
                    <th>Address</th>
                    <th>City</th>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td><%#: Eval("LastName") %></td>
                    <td><%#: Eval("FirstName") %></td>
                    <td><%#: Eval("Title") %></td>
                    <td><%#: Eval("TitleOfCourtesy") %></td>
                    <td><%#: Eval("BirthDate") %></td>
                    <td><%#: Eval("HireDate") %></td>
                    <td><%#: Eval("Address") %></td>
                    <td><%#: Eval("City") %></td>
                </tr>
            </ItemTemplate>
            <FooterTemplate>
                </table>
            </FooterTemplate>


       

        </asp:Repeater>
        <asp:EntityDataSource ID="EntityDataSourceNW" runat="server" ConnectionString="name=NORTHWNDEntities" DefaultContainerName="NORTHWNDEntities" EnableFlattening="False" EntitySetName="Employees" Select="it.[EmployeeID], it.[LastName], it.[FirstName], it.[Title], it.[TitleOfCourtesy], it.[BirthDate], it.[HireDate], it.[Address], it.[City], it.[Region], it.[PostalCode], it.[Country], it.[HomePhone], it.[Extension], it.[Photo], it.[ReportsTo], it.[PhotoPath]">
        </asp:EntityDataSource>
        <asp:ListView ID="ListViewEmployees" runat="server" DataKeyNames="EmployeeID" DataSourceID="EntityDataSourceNW2">
            <AlternatingItemTemplate>
                <tr style="background-color:#FFF8DC;">
                    <td>
                        <asp:Label ID="EmployeeIDLabel" runat="server" Text='<%# Eval("EmployeeID") %>' />
                    </td>
                    <td>
                        <asp:Label ID="LastNameLabel" runat="server" Text='<%# Eval("LastName") %>' />
                    </td>
                    <td>
                        <asp:Label ID="FirstNameLabel" runat="server" Text='<%# Eval("FirstName") %>' />
                    </td>
                    <td>
                        <asp:Label ID="TitleLabel" runat="server" Text='<%# Eval("Title") %>' />
                    </td>
                    <td>
                        <asp:Label ID="TitleOfCourtesyLabel" runat="server" Text='<%# Eval("TitleOfCourtesy") %>' />
                    </td>
                    <td>
                        <asp:Label ID="BirthDateLabel" runat="server" Text='<%# Eval("BirthDate") %>' />
                    </td>
                    <td>
                        <asp:Label ID="HireDateLabel" runat="server" Text='<%# Eval("HireDate") %>' />
                    </td>
                    <td>
                        <asp:Label ID="AddressLabel" runat="server" Text='<%# Eval("Address") %>' />
                    </td>
                    <td>
                        <asp:Label ID="CityLabel" runat="server" Text='<%# Eval("City") %>' />
                    </td>
                    <td>
                        <asp:Label ID="RegionLabel" runat="server" Text='<%# Eval("Region") %>' />
                    </td>
                    <td>
                        <asp:Label ID="PostalCodeLabel" runat="server" Text='<%# Eval("PostalCode") %>' />
                    </td>
                    <td>
                        <asp:Label ID="CountryLabel" runat="server" Text='<%# Eval("Country") %>' />
                    </td>
                    <td>
                        <asp:Label ID="HomePhoneLabel" runat="server" Text='<%# Eval("HomePhone") %>' />
                    </td>
                    <td>
                        <asp:Label ID="ExtensionLabel" runat="server" Text='<%# Eval("Extension") %>' />
                    </td>
                    <td>
                        <asp:Label ID="PhotoLabel" runat="server" Text='<%# Eval("Photo") %>' />
                    </td>
                    <td>
                        <asp:Label ID="NotesLabel" runat="server" Text='<%# Eval("Notes") %>' />
                    </td>
                    <td>
                        <asp:Label ID="ReportsToLabel" runat="server" Text='<%# Eval("ReportsTo") %>' />
                    </td>
                    <td>
                        <asp:Label ID="PhotoPathLabel" runat="server" Text='<%# Eval("PhotoPath") %>' />
                    </td>
                    <td>
                        <asp:Label ID="Employees1Label" runat="server" Text='<%# Eval("Employees1") %>' />
                    </td>
                    <td>
                        <asp:Label ID="Employee1Label" runat="server" Text='<%# Eval("Employee1") %>' />
                    </td>
                </tr>
            </AlternatingItemTemplate>
            <EditItemTemplate>
                <tr style="background-color:#008A8C;color: #FFFFFF;">
                    <td>
                        <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Update" />
                        <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel" />
                    </td>
                    <td>
                        <asp:Label ID="EmployeeIDLabel1" runat="server" Text='<%# Eval("EmployeeID") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="LastNameTextBox" runat="server" Text='<%# Bind("LastName") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="FirstNameTextBox" runat="server" Text='<%# Bind("FirstName") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="TitleTextBox" runat="server" Text='<%# Bind("Title") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="TitleOfCourtesyTextBox" runat="server" Text='<%# Bind("TitleOfCourtesy") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="BirthDateTextBox" runat="server" Text='<%# Bind("BirthDate") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="HireDateTextBox" runat="server" Text='<%# Bind("HireDate") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="AddressTextBox" runat="server" Text='<%# Bind("Address") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="CityTextBox" runat="server" Text='<%# Bind("City") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="RegionTextBox" runat="server" Text='<%# Bind("Region") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="PostalCodeTextBox" runat="server" Text='<%# Bind("PostalCode") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="CountryTextBox" runat="server" Text='<%# Bind("Country") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="HomePhoneTextBox" runat="server" Text='<%# Bind("HomePhone") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="ExtensionTextBox" runat="server" Text='<%# Bind("Extension") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="PhotoTextBox" runat="server" Text='<%# Bind("Photo") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="NotesTextBox" runat="server" Text='<%# Bind("Notes") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="ReportsToTextBox" runat="server" Text='<%# Bind("ReportsTo") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="PhotoPathTextBox" runat="server" Text='<%# Bind("PhotoPath") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="Employees1TextBox" runat="server" Text='<%# Bind("Employees1") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="Employee1TextBox" runat="server" Text='<%# Bind("Employee1") %>' />
                    </td>
                </tr>
            </EditItemTemplate>
            <EmptyDataTemplate>
                <table runat="server" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;">
                    <tr>
                        <td>No data was returned.</td>
                    </tr>
                </table>
            </EmptyDataTemplate>
            <InsertItemTemplate>
                <tr style="">
                    <td>
                        <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insert" />
                        <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Clear" />
                    </td>
                    <td>
                        <asp:TextBox ID="EmployeeIDTextBox" runat="server" Text='<%# Bind("EmployeeID") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="LastNameTextBox" runat="server" Text='<%# Bind("LastName") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="FirstNameTextBox" runat="server" Text='<%# Bind("FirstName") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="TitleTextBox" runat="server" Text='<%# Bind("Title") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="TitleOfCourtesyTextBox" runat="server" Text='<%# Bind("TitleOfCourtesy") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="BirthDateTextBox" runat="server" Text='<%# Bind("BirthDate") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="HireDateTextBox" runat="server" Text='<%# Bind("HireDate") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="AddressTextBox" runat="server" Text='<%# Bind("Address") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="CityTextBox" runat="server" Text='<%# Bind("City") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="RegionTextBox" runat="server" Text='<%# Bind("Region") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="PostalCodeTextBox" runat="server" Text='<%# Bind("PostalCode") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="CountryTextBox" runat="server" Text='<%# Bind("Country") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="HomePhoneTextBox" runat="server" Text='<%# Bind("HomePhone") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="ExtensionTextBox" runat="server" Text='<%# Bind("Extension") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="PhotoTextBox" runat="server" Text='<%# Bind("Photo") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="NotesTextBox" runat="server" Text='<%# Bind("Notes") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="ReportsToTextBox" runat="server" Text='<%# Bind("ReportsTo") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="PhotoPathTextBox" runat="server" Text='<%# Bind("PhotoPath") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="Employees1TextBox" runat="server" Text='<%# Bind("Employees1") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="Employee1TextBox" runat="server" Text='<%# Bind("Employee1") %>' />
                    </td>
                </tr>
            </InsertItemTemplate>
            <ItemTemplate>
                <tr style="background-color:#DCDCDC;color: #000000;">
                    <td>
                        <asp:Label ID="EmployeeIDLabel" runat="server" Text='<%# Eval("EmployeeID") %>' />
                    </td>
                    <td>
                        <asp:Label ID="LastNameLabel" runat="server" Text='<%# Eval("LastName") %>' />
                    </td>
                    <td>
                        <asp:Label ID="FirstNameLabel" runat="server" Text='<%# Eval("FirstName") %>' />
                    </td>
                    <td>
                        <asp:Label ID="TitleLabel" runat="server" Text='<%# Eval("Title") %>' />
                    </td>
                    <td>
                        <asp:Label ID="TitleOfCourtesyLabel" runat="server" Text='<%# Eval("TitleOfCourtesy") %>' />
                    </td>
                    <td>
                        <asp:Label ID="BirthDateLabel" runat="server" Text='<%# Eval("BirthDate") %>' />
                    </td>
                    <td>
                        <asp:Label ID="HireDateLabel" runat="server" Text='<%# Eval("HireDate") %>' />
                    </td>
                    <td>
                        <asp:Label ID="AddressLabel" runat="server" Text='<%# Eval("Address") %>' />
                    </td>
                    <td>
                        <asp:Label ID="CityLabel" runat="server" Text='<%# Eval("City") %>' />
                    </td>
                    <td>
                        <asp:Label ID="RegionLabel" runat="server" Text='<%# Eval("Region") %>' />
                    </td>
                    <td>
                        <asp:Label ID="PostalCodeLabel" runat="server" Text='<%# Eval("PostalCode") %>' />
                    </td>
                    <td>
                        <asp:Label ID="CountryLabel" runat="server" Text='<%# Eval("Country") %>' />
                    </td>
                    <td>
                        <asp:Label ID="HomePhoneLabel" runat="server" Text='<%# Eval("HomePhone") %>' />
                    </td>
                    <td>
                        <asp:Label ID="ExtensionLabel" runat="server" Text='<%# Eval("Extension") %>' />
                    </td>
                    <td>
                        <asp:Label ID="PhotoLabel" runat="server" Text='<%# Eval("Photo") %>' />
                    </td>
                    <td>
                        <asp:Label ID="NotesLabel" runat="server" Text='<%# Eval("Notes") %>' />
                    </td>
                    <td>
                        <asp:Label ID="ReportsToLabel" runat="server" Text='<%# Eval("ReportsTo") %>' />
                    </td>
                    <td>
                        <asp:Label ID="PhotoPathLabel" runat="server" Text='<%# Eval("PhotoPath") %>' />
                    </td>
                    <td>
                        <asp:Label ID="Employees1Label" runat="server" Text='<%# Eval("Employees1") %>' />
                    </td>
                    <td>
                        <asp:Label ID="Employee1Label" runat="server" Text='<%# Eval("Employee1") %>' />
                    </td>
                </tr>
            </ItemTemplate>
            <LayoutTemplate>
                <table runat="server">
                    <tr runat="server">
                        <td runat="server">
                            <table id="itemPlaceholderContainer" runat="server" border="1" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;font-family: Verdana, Arial, Helvetica, sans-serif;">
                                <tr runat="server" style="background-color:#DCDCDC;color: #000000;">
                                    <th runat="server">EmployeeID</th>
                                    <th runat="server">LastName</th>
                                    <th runat="server">FirstName</th>
                                    <th runat="server">Title</th>
                                    <th runat="server">TitleOfCourtesy</th>
                                    <th runat="server">BirthDate</th>
                                    <th runat="server">HireDate</th>
                                    <th runat="server">Address</th>
                                    <th runat="server">City</th>
                                    <th runat="server">Region</th>
                                    <th runat="server">PostalCode</th>
                                    <th runat="server">Country</th>
                                    <th runat="server">HomePhone</th>
                                    <th runat="server">Extension</th>
                                    <th runat="server">Photo</th>
                                    <th runat="server">Notes</th>
                                    <th runat="server">ReportsTo</th>
                                    <th runat="server">PhotoPath</th>
                                    <th runat="server">Employees1</th>
                                    <th runat="server">Employee1</th>
                                </tr>
                                <tr id="itemPlaceholder" runat="server">
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr runat="server">
                        <td runat="server" style="text-align: center;background-color: #CCCCCC;font-family: Verdana, Arial, Helvetica, sans-serif;color: #000000;">
                            <asp:DataPager ID="DataPager1" runat="server">
                                <Fields>
                                    <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False" />
                                    <asp:NumericPagerField />
                                    <asp:NextPreviousPagerField ButtonType="Button" ShowLastPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False" />
                                </Fields>
                            </asp:DataPager>
                        </td>
                    </tr>
                </table>
            </LayoutTemplate>
            <SelectedItemTemplate>
                <tr style="background-color:#008A8C;font-weight: bold;color: #FFFFFF;">
                    <td>
                        <asp:Label ID="EmployeeIDLabel" runat="server" Text='<%# Eval("EmployeeID") %>' />
                    </td>
                    <td>
                        <asp:Label ID="LastNameLabel" runat="server" Text='<%# Eval("LastName") %>' />
                    </td>
                    <td>
                        <asp:Label ID="FirstNameLabel" runat="server" Text='<%# Eval("FirstName") %>' />
                    </td>
                    <td>
                        <asp:Label ID="TitleLabel" runat="server" Text='<%# Eval("Title") %>' />
                    </td>
                    <td>
                        <asp:Label ID="TitleOfCourtesyLabel" runat="server" Text='<%# Eval("TitleOfCourtesy") %>' />
                    </td>
                    <td>
                        <asp:Label ID="BirthDateLabel" runat="server" Text='<%# Eval("BirthDate") %>' />
                    </td>
                    <td>
                        <asp:Label ID="HireDateLabel" runat="server" Text='<%# Eval("HireDate") %>' />
                    </td>
                    <td>
                        <asp:Label ID="AddressLabel" runat="server" Text='<%# Eval("Address") %>' />
                    </td>
                    <td>
                        <asp:Label ID="CityLabel" runat="server" Text='<%# Eval("City") %>' />
                    </td>
                    <td>
                        <asp:Label ID="RegionLabel" runat="server" Text='<%# Eval("Region") %>' />
                    </td>
                    <td>
                        <asp:Label ID="PostalCodeLabel" runat="server" Text='<%# Eval("PostalCode") %>' />
                    </td>
                    <td>
                        <asp:Label ID="CountryLabel" runat="server" Text='<%# Eval("Country") %>' />
                    </td>
                    <td>
                        <asp:Label ID="HomePhoneLabel" runat="server" Text='<%# Eval("HomePhone") %>' />
                    </td>
                    <td>
                        <asp:Label ID="ExtensionLabel" runat="server" Text='<%# Eval("Extension") %>' />
                    </td>
                    <td>
                        <asp:Label ID="PhotoLabel" runat="server" Text='<%# Eval("Photo") %>' />
                    </td>
                    <td>
                        <asp:Label ID="NotesLabel" runat="server" Text='<%# Eval("Notes") %>' />
                    </td>
                    <td>
                        <asp:Label ID="ReportsToLabel" runat="server" Text='<%# Eval("ReportsTo") %>' />
                    </td>
                    <td>
                        <asp:Label ID="PhotoPathLabel" runat="server" Text='<%# Eval("PhotoPath") %>' />
                    </td>
                    <td>
                        <asp:Label ID="Employees1Label" runat="server" Text='<%# Eval("Employees1") %>' />
                    </td>
                    <td>
                        <asp:Label ID="Employee1Label" runat="server" Text='<%# Eval("Employee1") %>' />
                    </td>
                </tr>
            </SelectedItemTemplate>
        </asp:ListView>
        <asp:EntityDataSource ID="EntityDataSourceNW2" runat="server" AutoGenerateOrderByClause="True" ConnectionString="name=NORTHWNDEntities" DefaultContainerName="NORTHWNDEntities" EnableFlattening="False" EntitySetName="Employees" OrderBy="">
            <OrderByParameters>
                <asp:Parameter Name="EmployeeId" />
            </OrderByParameters>
        </asp:EntityDataSource>
    </form>
</body>
</html>
