<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Todos.aspx.cs" Inherits="Task02_Todos.Categories" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ListView runat="server" ID="ListViewCategories"
        ItemType="Task02_Todos.Data.Category"
        SelectMethod="ListViewCategories_SelectItem"
        InsertMethod="ListViewCategories_InsertItem"
        DeleteMethod="ListViewCategories_DeleteItem"
        UpdateMethod="ListViewCategories_UpdateItem"
        DataKeyNames="Id"
        InsertItemPosition="LastItem">

        <LayoutTemplate>
            <br />
            <br />
            <div class="panel panel-default">
                <div class="panel-heading">Categories</div>
                <div class="panel-body">
                    <div runat="server" id="itemPlaceholder"></div>
                </div>
            </div>
        </LayoutTemplate>

        <EmptyDataTemplate>
            <div class="row">
                <h3>No categories! Please add some.</h3>
                <br />
            </div>
        </EmptyDataTemplate>

        <ItemTemplate>
            <div class="row">
                <div class="col-md-3"><%#: Item.Name %></div>
                <asp:LinkButton runat="server" ID="ButtonEdit" Text="Edit" CssClass="btn btn-info" CommandName="Edit" CausesValidation="false" />
                <asp:LinkButton runat="server" ID="LinkButton1" Text="Delete" CssClass="btn btn-danger" CommandName="Delete" CausesValidation="false" />
            </div>
        </ItemTemplate>

        <EditItemTemplate>
            <div class="row">
                <div class="col-md-3">
                    <asp:TextBox runat="server" ID="TextBoxCategoryName" Text="<%# BindItem.Name %>" />
                </div>
                <asp:LinkButton runat="server" ID="ButtonEdit" Text="Save" CssClass="btn btn-success" CommandName="Update" ValidationGroup="EditCategory" CausesValidation="true" />
                <asp:LinkButton runat="server" ID="LinkButtonCancel" Text="Cancel" CssClass="btn btn-danger" CommandName="Cancel" CausesValidation="false" />
            </div>
        </EditItemTemplate>

        <InsertItemTemplate>
            <div class="row">
                <div class="col-md-3">
                    <asp:TextBox runat="server" ID="TextBoxCategoryName" Text="<%#: BindItem.Name %>" />
                </div>
                <asp:LinkButton runat="server" ID="ButtonEdit" Text="Insert" CssClass="btn btn-info" CommandName="Insert" CausesValidation="true" ValidationGroup="InsertCategory" />
                <asp:LinkButton runat="server" ID="ButtonCancel" Text="Cancel" CssClass="btn btn-danger" CommandName="Cancel" />
            </div>
        </InsertItemTemplate>
    </asp:ListView>


    <asp:ListView runat="server" ID="ListViewTodo"
        ItemType="Task02_Todos.Data.Todo"        
        SelectMethod="ListViewTodos_SelectItem"
        InsertMethod="ListViewTodos_InsertItem"
        DeleteMethod="ListViewTodos_DeleteItem"
        UpdateMethod="ListViewTodos_UpdateItem"
        DataKeyNames="Id"
        InsertItemPosition="LastItem">

        <LayoutTemplate>
            <br />
            <br />
            <div class="panel panel-default">
                <div class="panel-heading">Todos</div>
                <div class="panel-body">
                    <div runat="server" id="itemPlaceholder"></div>
                </div>
            </div>
        </LayoutTemplate>

        <EmptyDataTemplate>
            <div class="row">
                <h3>No todos! Please add some.</h3>
                <br />
            </div>
        </EmptyDataTemplate>

        <ItemTemplate>
            <div class="panel panel-default">
                <div class="row">
                    <div class="col-md-6">Title: <%#: Item.Title %></div>
                </div>
                <div class="row">
                    <div class="col-md-6">Body: <%#: Item.Body %></div>
                </div>
                <div class="row">
                    <div class="col-md-6">Last changed: <%#: Item.DateChanged %></div>
                </div>
                <div class="row">
                    <div class="col-md-6">Category: <%#: Item.Category.Name %></div>
                </div>
                <asp:LinkButton runat="server" ID="ButtonEdit" Text="Edit" CssClass="btn btn-info" CommandName="Edit" CausesValidation="false" />
                <asp:LinkButton runat="server" ID="LinkButton1" Text="Delete" CssClass="btn btn-danger" CommandName="Delete" CausesValidation="false" />
            </div>
        </ItemTemplate>

        <EditItemTemplate>
            <div class="panel panel-default">
                <div class="row">
                    <div class="col-md-6">Title:
                        <asp:TextBox runat="server" ID="TextBoxEditTitle" Text="<%# BindItem.Title %>" CssClass="form-control" /></div>
                </div>
                <div class="row">
                    <div class="col-md-6">Body:
                        <asp:TextBox runat="server" ID="TextBoxEditBody" Text="<%# BindItem.Body %>" TextMode="MultiLine" CssClass="form-control" /></div>
                </div>
                <div class="row">
                    <div class="col-md-6">Last changed: <%#: Item.DateChanged %></div>
                </div>
                <div class="row">
                    <div class="col-md-6">
                        Category:
                        <asp:DropDownList runat="server" id="DropDownListCategories" DataValueField="Name" SelectMethod="ListViewCategories_SelectItem"/>
                    </div>
                </div>                               

                <asp:LinkButton runat="server" ID="ButtonEdit" Text="Save" CssClass="btn btn-success" CommandName="Update" ValidationGroup="EditCategory" CausesValidation="true" />
                <asp:LinkButton runat="server" ID="LinkButtonCancel" Text="Cancel" CssClass="btn btn-danger" CommandName="Cancel" CausesValidation="false" />
            </div>
        </EditItemTemplate>

        <InsertItemTemplate>
            <div class="row">
                 <div class="panel panel-default">
                <div class="row">
                    <div class="col-md-6">Title:
                        <asp:TextBox runat="server" ID="TextBoxAddTitle" Text="<%# BindItem.Title %>" CssClass="form-control" /></div>
                </div>
                <div class="row">
                    <div class="col-md-6">Body:
                        <asp:TextBox runat="server" ID="TextBoxAddBody" Text="<%# BindItem.Body %>" TextMode="MultiLine" CssClass="form-control" /></div>
                </div>                
                <div class="row">
                    <div class="col-md-6">
                        Category:
                        <asp:DropDownList runat="server" id="DropDownAddCategories" DataValueField="Name" SelectMethod="ListViewCategories_SelectItem"/>
                    </div>
                </div>                               
                
                <asp:LinkButton runat="server" ID="ButtonEdit" Text="Insert" CssClass="btn btn-info" CommandName="Insert" CausesValidation="true" ValidationGroup="InsertCategory" />
                <asp:LinkButton runat="server" ID="ButtonCancel" Text="Cancel" CssClass="btn btn-danger" CommandName="Cancel" />
            </div>
        </InsertItemTemplate>
    </asp:ListView>

</asp:Content>
