<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="YoutubePlaylists.WebForms.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Welcome to Youtube Playlists!</h1>
    <h2>Most Popular Playlists</h2>
        <div class="row">
            <asp:Repeater runat="server" ID="RepeaterPlaylists"
                ItemType="YoutubePlaylists.Data.Models.Playlist"
                SelectMethod="RepeaterPlaylists_GetData">
                <HeaderTemplate>
                    <table class="table">
                    <tr>
                        <th>Title</th>
                        <th>Author</th>
                        <th>Rating</th>
                        <th>Category</th>
                    </tr>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr>
                        <td><a href="Playlists/Details.aspx?id=<%# Item.Id %>"><%#: Item.Title %></a></td>
                        <td><%#: Item.User.UserName %></td>
                        <td><%#: Item.Ratings.Sum(r => r.Value) %></td>
                        <td><a href="Admin/Playlists/All.aspx?category=<%# Item.Category.Name %>"><%#: Item.Category.Name %></a></td>
                </ItemTemplate>
            </asp:Repeater>
        </div>
</asp:Content>
