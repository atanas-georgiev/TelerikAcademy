<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="YoutubePlaylists.WebForms.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Welcome to Youtube Playlists!</h1>
    <h2>Most Popular Playlists</h2>
        <div class="row">
            <asp:Repeater runat="server" ID="RepeaterPlaylists"
                ItemType="YoutubePlaylists.Data.Models.Playlist"
                SelectMethod="RepeaterPlaylists_GetData">
                <ItemTemplate>
                    <div class="panel panel-default col-md-4">
                        <div class="panel-heading"><a href="Playlists/Details.aspx?id=<%# Item.Id %>"><%#: Item.Title %></a></div>
                            <div class="panel-body">
                               by  <i><%#: Item.Category.Name %></i>
                               in category <a href="Admin/Playlists/All.aspx?category=<%# Item.Category.Name %>"><%#: Item.Category.Name %></a> 
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
</asp:Content>
