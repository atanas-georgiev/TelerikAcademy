<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Task02_TodoList.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    

        <ef:entitydatasource ID="EntityDataSourceCategories" runat="server" ConnectionString="name=TodosEntities" 
            DefaultContainerName="TodosEntities" EnableDelete="True" EnableFlattening="False" EnableInsert="True" EnableUpdate="True" EntitySetName="Categories">
        </ef:entitydatasource>
    </div>
        <asp:GridView ID="GridViewCategories" runat="server" CellPadding="4" AutoGenerateColumns="False" DataSourceID="EntityDataSourceCategories" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px">
            <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
            <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
            <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
            <RowStyle BackColor="White" ForeColor="#003399" />
            <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
            <SortedAscendingCellStyle BackColor="#EDF6F6" />
            <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
            <SortedDescendingCellStyle BackColor="#D6DFDF" />
            <SortedDescendingHeaderStyle BackColor="#002876" />
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:CommandField ShowEditButton="True" />
                <asp:CommandField ShowDeleteButton="True" />
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
            </Columns>
        </asp:GridView>

         <asp:ListView ID="ListViewCategories" runat="server" 
                    DataSourceID="EntityDataSourceCategories" 
                    ItemType="Task02_TodoList.Category"
                    InsertItemPosition="None">
             
            <ItemTemplate></ItemTemplate>
             
            <InsertItemTemplate>
                <div class="insertItem">
                    <asp:TextBox ID="TextBoxName" runat="server" Text='<%#: BindItem.Name %>' />
                    <br />
                
                    <asp:Button ID="ButtonInsert" runat="server" CommandName="Insert" Text="Insert" />
                    <asp:Button ID="ButtonCancel" runat="server" CommandName="Cancel" Text="Clear" />
                </div>
            </InsertItemTemplate>
        </asp:ListView>
    </form>
</body>
</html>
