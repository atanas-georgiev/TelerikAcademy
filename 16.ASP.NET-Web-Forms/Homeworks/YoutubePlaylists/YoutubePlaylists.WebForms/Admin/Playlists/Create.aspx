<%@ Page Title="Create playlist" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Create.aspx.cs" Inherits="YoutubePlaylists.WebForms.Admin.Playlists.Create" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <h2><%: Title %>.</h2>
    <p class="text-danger">
        <asp:Literal runat="server" ID="ErrorMessage" />
    </p>

    <div class="form-horizontal">
        <h4>Create a new playlist</h4>
        <hr />
        <asp:ValidationSummary runat="server" CssClass="text-danger" />
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="TextBoxTitle" CssClass="col-md-2 control-label">Title</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="TextBoxTitle" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="TextBoxTitle"
                    CssClass="text-danger" ErrorMessage="The title field is required." />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="TextBoxDescription" CssClass="col-md-2 control-label">Description</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="TextBoxDescription" CssClass="form-control" TextMode="MultiLine"/>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="TextBoxDescription"
                    CssClass="text-danger" ErrorMessage="The description field is required." />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="TextBoxDescription" CssClass="col-md-2 control-label">Description</asp:Label>
            <div class="col-md-10">
                <asp:DropDownList runat="server" ID="DropDownListCategory" CssClass="form-control" 
                    ItemType="YoutubePlaylists.Data.Models.Category" DataTextField="Name" SelectMethod="DropDownListCategory_Select"/>
            </div>
        </div>

        <div class="panel panel-default">
            <div class="panel-heading">Videos</div>
            <div class="panel-body">
         
                <div class="form-group">
                    <asp:Repeater ID="RepeaterUrls" ItemType="System.String" runat="server" SelectMethod="RepeaterUrls_Select">
                        <HeaderTemplate>
                            <ul>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <li>
                                <%#: Item %>
                            </li>
                        </ItemTemplate>
                        <FooterTemplate>
                            </ul>
                        </FooterTemplate>
                    </asp:Repeater>
                </div>
       
                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="TextBoxDescription" CssClass="col-md-2 control-label">Video Url</asp:Label>
                    <div class="col-md-10">
                        <asp:TextBox runat="server" ID="TextBoxAddUrl" CssClass="form-control" TextMode="Url"/>
<%--                        <asp:RequiredFieldValidator runat="server" ControlToValidate="TextBoxDescription"--%>
<%--                            CssClass="text-danger" ErrorMessage="The description field is required." />--%>
                    </div>
                </div>
            
                <div class="form-group">
                    <div class="col-md-offset-2 col-md-10">
                        <asp:Button OnClick="OnAddUrlClick" runat="server" Text="Add video url" CssClass="btn btn-default" />
                    </div>
                </div>  
            </div>  
        </div>  

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Button runat="server" ID="ButtonCreate" OnClick="ButtonCreate_OnClick" Text="Create new list" CssClass="btn btn-default" />
            </div>
        </div>

    </div>
</asp:Content>
