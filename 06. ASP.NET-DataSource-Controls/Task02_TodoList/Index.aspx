<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Task02_TodoList.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="formTodos" runat="server">
        <asp:ListView runat="server" ID="ListViewTodos" GroupItemCount="3" ItemType="Task02_TodoList.Data.Todo" SelectMethod="SelectAllData" UpdateMethod="Update">
            <EmptyDataTemplate>
                No items!
            </EmptyDataTemplate>

            <GroupTemplate>
                <div class="row">
                    <asp:PlaceHolder runat="server" ID="itemPlaceHolder"></asp:PlaceHolder>
                </div>
            </GroupTemplate>

            <ItemTemplate>
                <div class="col-md-4">
                    <h2><%#: Item.Title %></h2>
                    <p><%#: Item.Body %></p>
                    <p>Changed: <%#: Item.DateChanged %></p>
                    <asp:LinkButton ID="LBEdit" runat="server" CausesValidation="False" CommandName="Edit" Text="Edit"></asp:LinkButton>
                </div>
            </ItemTemplate>
            
            <EditItemTemplate>
                <div class="col-md-4">
                    <h2><asp:TextBox runat="server" ID="TextBoxEditTitle" Text="<%#: BindItem.Title %>"></asp:TextBox></h2>
                    <p><asp:TextBox runat="server" ID="TextBoxEditBody" Text="<%#: BindItem.Body %>" TextMode="MultiLine"></asp:TextBox></p>                
                </div>
            </EditItemTemplate>

        </asp:ListView>
    </form>
</body>
</html>
