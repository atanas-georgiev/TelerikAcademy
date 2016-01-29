<%@ Page Title="Register" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="YoutubePlaylists.WebForms.Account.Register" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h2><%: Title %>.</h2>
    <p class="text-danger">
        <asp:Literal runat="server" ID="ErrorMessage" />
    </p>

    <div class="form-horizontal">
        <h4>Create a new account</h4>
        <hr />
        <asp:ValidationSummary runat="server" CssClass="text-danger" />
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Email" CssClass="col-md-2 control-label">Email</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Email" CssClass="form-control" TextMode="Email" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Email"
                    CssClass="text-danger" ErrorMessage="The email field is required." />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Password" CssClass="col-md-2 control-label">Password</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Password" TextMode="Password" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Password"
                    CssClass="text-danger" ErrorMessage="The password field is required." />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="ConfirmPassword" CssClass="col-md-2 control-label">Confirm password</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="ConfirmPassword" TextMode="Password" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="ConfirmPassword"
                    CssClass="text-danger" Display="Dynamic" ErrorMessage="The confirm password field is required." />
                <asp:CompareValidator runat="server" ControlToCompare="Password" ControlToValidate="ConfirmPassword"
                    CssClass="text-danger" Display="Dynamic" ErrorMessage="The password and confirmation password do not match." />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="TextBoxFirstName" CssClass="col-md-2 control-label">First name</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="TextBoxFirstName" CssClass="form-control"/>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="TextBoxFirstName"
                    CssClass="text-danger" ErrorMessage="The first name field is required." />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="TextBoxLastName" CssClass="col-md-2 control-label">Last name</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="TextBoxLastName" CssClass="form-control"/>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="TextBoxLastName"
                    CssClass="text-danger" ErrorMessage="The last name field is required." />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="TextBoxImageUrl" CssClass="col-md-2 control-label">Image url (optional)</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="TextBoxImageUrl" CssClass="form-control" TextMode="Url"/>
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="TextBoxFacebookUrl" CssClass="col-md-2 control-label">Facebook url (optional)</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="TextBoxFacebookUrl" CssClass="form-control" TextMode="Url"/>
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="TextBoxYoutubeUrl" CssClass="col-md-2 control-label">Youtube url (optional)</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="TextBoxYoutubeUrl" CssClass="form-control" TextMode="Url"/>
            </div>
        </div>
        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Button runat="server" OnClick="CreateUser_Click" Text="Register" CssClass="btn btn-default" />
            </div>
        </div>
    </div>
</asp:Content>
