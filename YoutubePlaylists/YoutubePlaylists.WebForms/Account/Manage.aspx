<%@ Page Title="Manage Account" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Manage.aspx.cs" Inherits="YoutubePlaylists.WebForms.Account.Manage" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">

    <h2><%: Title %>.</h2>
    <p class="text-danger">
        <asp:Literal runat="server" ID="ErrorMessage"/>
    </p>

    <asp:FormView runat="server" ID="FormViewUserDetails" ItemType="YoutubePlaylists.Data.Models.User" SelectMethod="FormViewUserDetails_SelectData">
        <ItemTemplate>
            <div class="col-lg-12">
                <div class="form-horizontal">
                    <h4>Edit account</h4>
                    <hr/>
                    <img src="<%#: Item.ImageUrl %>" alt="Image url"/>
                    <hr/>
                    <asp:ValidationSummary runat="server" CssClass="text-danger"/>
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="TextBoxFirstName" CssClass="col-md-2 control-label">First name</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="TextBoxFirstName" CssClass="form-control" Text="<%#: Item.FirstName %>"/>
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="TextBoxFirstName"
                                                        CssClass="text-danger" ErrorMessage="The first name field is required."/>
                        </div>
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="TextBoxLastName" CssClass="col-md-2 control-label">Last name</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="TextBoxLastName" CssClass="form-control" Text="<%#: Item.LastName %>"/>
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="TextBoxLastName"
                                                        CssClass="text-danger" ErrorMessage="The last name field is required."/>
                        </div>
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="TextBoxImageUrl" CssClass="col-md-2 control-label">Image url (optional)</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="TextBoxImageUrl" CssClass="form-control" TextMode="Url" Text="<%#: Item.ImageUrl %>"/>
                        </div>
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="TextBoxFacebookUrl" CssClass="col-md-2 control-label">Facebook url (optional)</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="TextBoxFacebookUrl" CssClass="form-control" TextMode="Url" Text="<%#: Item.FacebookUrl %>"/>
                        </div>
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="TextBoxYoutubeUrl" CssClass="col-md-2 control-label">Youtube url (optional)</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="TextBoxYoutubeUrl" CssClass="form-control" TextMode="Url" Text="<%#: Item.FacebookUrl %>"/>
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-md-offset-2 col-md-10">
                            <asp:Button runat="server" OnClick="ButtonUpdate_OnClick" ID="ButtonUpdate" Text="Update" CssClass="btn btn-default"/>
                        </div>
                    </div>
                </div>
            </div>
        </ItemTemplate>
    </asp:FormView>

</asp:Content>
