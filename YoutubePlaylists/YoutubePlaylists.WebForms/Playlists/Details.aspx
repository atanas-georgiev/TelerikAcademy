<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="YoutubePlaylists.WebForms.Playlists.Details" %>
<%@ Register src="../Controls/RatingControl.ascx" tagname="RatingControl" tagprefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:FormView runat="server" ID="FormViewPlaylistDetails" ItemType="YoutubePlaylists.Data.Models.Playlist" SelectMethod="FormViewPlaylistDetails_SelectData">
        <ItemTemplate>
            <header>
                <h1><%: Title %></h1>
                <p><asp:Button runat="server" ID="ButtonDelete" OnClick="ButtonDelete_OnClick" Text="Remove" Visible=<%# IsAuthor(Item.UserId) %>/></p>
                <p>Rate: <uc:RatingControl ID="RatingControlPlaylist" runat="server" OnRate="RatingControlPlaylist_OnRate"/></p>
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
                                <asp:Button runat="server" Text="Remove" CommandName="Delete" CommandArgument="<%# Item.Id %>" OnCommand="OnCommand" Visible=<%# IsAuthor(Item.Playlist.UserId) %>/>
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
