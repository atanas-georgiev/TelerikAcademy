<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Categories.aspx.cs" Inherits="YoutubePlaylists.WebForms.Admin.Categories" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br/>   
    <div class="panel panel-default">
        <div class="panel-heading">Categories</div>
        <div class="panel-body">
            <div class="row">
                <div class="col-md-12">
                    <asp:ValidationSummary runat="server" ValidationGroup="InsertCategory"
                            DisplayMode="BulletList" ShowMessageBox="False" ShowSummary="True" CssClass="alert alert-danger" />
                    <asp:ValidationSummary runat="server" ValidationGroup="EditCategory"
                            DisplayMode="BulletList" ShowMessageBox="False" ShowSummary="True" CssClass="alert alert-danger" />
                    <asp:CustomValidator runat="server" ID="CustomValidator" ValidationGroup="EditCategory"/>
                    <asp:GridView runat="server" ID="GridViewCategories"
                        ItemType="TestExam.Data.Models.Category"
                        DataKeyNames="Id"        
                        AutoGenerateColumns="false"
                        AllowPaging="true"
                        PageSize="5"
                        AllowSorting="true"
                        SelectMethod="GridViewCategories_SelectItem"
                        UpdateMethod="GridViewCategories_UpdateItem"
                        DeleteMethod="GridViewCategories_DeleteItem">
                        <Columns>
                            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                            <asp:CommandField ShowEditButton="true" ControlStyle-CssClass="btn btn-info" />
                            <asp:CommandField ShowDeleteButton="true" ControlStyle-CssClass="btn btn-danger" />
                        </Columns>
                            <EmptyDataTemplate>
                                No categories!    
                            </EmptyDataTemplate>
                    </asp:GridView>
                    <asp:RequiredFieldValidator ErrorMessage="Category name is mandatory!" ControlToValidate="TextBoxNewCategory" runat="server" ValidationGroup="InsertCategory" />
                    <br />
                    <asp:TextBox runat="server" ID="TextBoxNewCategory" />
                    <asp:Button Text="Insert" ID="ButtonInsertCategory" runat="server" OnClick="ButtonInsertCategory_OnClick" CssClass="btn btn-info" />
                    <asp:Button Text="Cancel" ID="ButtonCancel" runat="server" OnClick="ButtonCancel_OnClick" CssClass="btn btn-danger" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
