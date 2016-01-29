<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="YoutubePlaylists.WebForms.Playlists.Details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:FormView runat="server" ID="FormViewPlaylistDetails" ItemType="YoutubePlaylists.Data.Models.Playlist" SelectMethod="FormViewPlaylistDetails_SelectData">
        <ItemTemplate>
            <header>
                <h1><%: Title %></h1>
                <p>Title: <%#: Item.Title %></p>
                <p>Description: <%#: Item.Description %></p>
                <p>Category: <%#: Item.Category.Name %></p>
                <p>Rading: <%#: 0 %></p>
                <p>Creator: <%#: Item.User.FirstName + " " + Item.User.LastName %></p>
                <p>Created: <%#: Item.CreationDate %></p>
                <p> Videos: </p>
                <p>
                    <asp:Repeater runat="server" ID="RepeaterVideos" ItemType="YoutubePlaylists.Data.Models.Video" SelectMethod="RepeaterVideos_SelectData">
                        <HeaderTemplate>
                            <ul>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <li>
                                <a href="<%#: Item.Url %>" target="_blank"><%#: Item.Url %></a>
                            </li>
                        </ItemTemplate>
                        <FooterTemplate>
                            </ul>
                        </FooterTemplate>
                    </asp:Repeater>
                </p>
            </header>
        </ItemTemplate>
    </asp:FormView>
</asp:Content>
