<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Task01_Countries.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
   
        <%--Continents--%>
        <asp:EntityDataSource ID="EntityDataSourceContinents" runat="server" ConnectionString="name=townsEntities" 
            DefaultContainerName="townsEntities" EnableDelete="True" EnableFlattening="False" EnableInsert="True" EnableUpdate="True" EntitySetName="Continents">
        </asp:EntityDataSource>

        <%--Countries--%>
        <asp:EntityDataSource ID="EntityDataSourceCountries" runat="server" 
            ConnectionString="name=townsEntities" 
            DefaultContainerName="townsEntities" EnableDelete="True" EnableFlattening="False" EnableInsert="True" EnableUpdate="True" EntitySetName="Countries" 
            Include="Continent"
            Where="it.ContinentId=@ContId">
            <WhereParameters>
                <asp:ControlParameter Name="ContId" Type="Int32"
                    ControlID="ListBoxContinents" />
            </WhereParameters>
        </asp:EntityDataSource>

        <%--Towns--%>
        <asp:EntityDataSource ID="EntityDataSourceTowns" runat="server" ConnectionString="name=townsEntities" DefaultContainerName="townsEntities" EnableDelete="True" 
            EnableFlattening="False" EnableInsert="True" EnableUpdate="True" 
            Where="it.CountryId=@CountyId"
            EntitySetName="Towns"
            Include="Country">
            <WhereParameters>
                <asp:ControlParameter Name="CountyId" Type="Int32"
                    ControlID="GridViewCountries" />
            </WhereParameters>
        </asp:EntityDataSource>

        <h1>Continents</h1>
        <asp:ListBox ID="ListBoxContinents" runat="server" AutoPostBack="True" DataSourceID="EntityDataSourceContinents" 
            DataTextField="Name" DataValueField="Id" OnSelectedIndexChanged="ListBoxContinents_SelectedIndexChanged" Rows="7"></asp:ListBox>

        <h1>Countries</h1>
        <asp:GridView ID="GridViewCountries" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="EntityDataSourceCountries">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                <asp:BoundField DataField="Language" HeaderText="Language" SortExpression="Language" />
                <asp:BoundField DataField="Population" HeaderText="Population" SortExpression="Population" />
            </Columns>
        </asp:GridView>

        <h1>Towns</h1>
        <asp:ListView ID="ListViewTowns" runat="server" DataSourceID="EntityDataSourceTowns" ItemType="Task01_Countries.Town">
            
            <LayoutTemplate>
                <span runat="server" id="itemPlaceholder" />
                <div class="pagerLine">
                    <asp:Button ID="ButtonInsertTown" Text="Insert" runat="server"/>                    |
                    <asp:DataPager ID="DataPagerTowns" runat="server" PageSize="4">
                        <Fields>
                            <asp:NextPreviousPagerField ShowFirstPageButton="True" 
                                ShowNextPageButton="False" ShowPreviousPageButton="False" />
                            <asp:NumericPagerField />
                            <asp:NextPreviousPagerField ShowLastPageButton="True" 
                                ShowNextPageButton="False" ShowPreviousPageButton="False" />
                        </Fields>
                    </asp:DataPager>
                </div>
            </LayoutTemplate>            

            <EmptyDataTemplate>
                <div> Please select continent and country.</div>
            </EmptyDataTemplate>

            <ItemTemplate>
                <table>
                    <tr style="background-color:#DCDCDC;color: #000000;">
                        <td>
                            <asp:Button ID="EditButton" runat="server" 
                                CommandName="Edit" Text="Edit" />
                        </td>
                        <td><%#: Item.Id %></td>
                        <td><%#: Item.Name %></td>
                        <td><%#: Item.Country.Name %></td>
                        <td><%#: Item.Population %></td>
                    </tr>
                </table>
            </ItemTemplate>

            <EditItemTemplate>
                 <table>
                    <tr style="background-color:#DCDCDC;color: #000000;">
                        <td>
                            <asp:Button ID="ButtonUpdate" runat="server" CommandName="Update" Text="Update" />
                            <asp:Button ID="ButtonCancel" runat="server" CommandName="Cancel" Text="Cancel" />
                        </td>
                        <td><%#: Item.Id %></td>
                        <td><asp:TextBox ID="TextBoxTownName" runat="server" Text='<%# BindItem.Name %>' /></td>
                        <td><asp:TextBox ID="TextBoxCountry" runat="server" Text='<%# BindItem.Country.Name %>' /></td>
                        <td><asp:TextBox ID="TextBoxPopulation" runat="server" Text='<%# BindItem.Population %>' /></td>
                    </tr>
                </table>
              
            </EditItemTemplate>
        </asp:ListView>

    </form>
</body>
</html>
