<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Task03_TweetsAggregator.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br/>
    <br/>
    <div class="row">
        Tweet user: <asp:TextBox runat="server" ID="TextBoxTweeterUser" CssClass="form-control"/>
        <br/>
        <asp:Button runat="server" id="ButtonTweets" Text="Search"/>
        
    
    </div>
</asp:Content>
