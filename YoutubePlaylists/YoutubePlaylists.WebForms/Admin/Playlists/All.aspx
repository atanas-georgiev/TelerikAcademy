<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="All.aspx.cs" Inherits="YoutubePlaylists.WebForms.Admin.Playlists.All" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br/>   

<div class="search-button">
                <div class="form-search">
                    <div class="input-append">
                        <asp:TextBox runat="server" ID="TextBoxSearchParam" type="text" name="q" class="col-md-3 search-query" placeholder="Search by playlist name / description ..."></asp:TextBox>
                        <asp:LinkButton runat="server" ID="LinkButtonSearch" OnClick="LinkButtonSearch_Click" CssClass="btn  btn-primary" Text="Search"></asp:LinkButton>
                    </div>
                </div>
            </div>

 <asp:ListView runat="server" ID="ListViewPlaylists"
        ItemType="YoutubePlaylists.Data.Models.Playlist"
        DataKeyNames="Id"
        SelectMethod="ListViewPlaylists_SelectData">
        <LayoutTemplate>
            <asp:HyperLink NavigateUrl="?orderBy=Title" Text="Sort by Title" runat="server" CssClass="btn btn-md-2 btn-default" />
            <asp:HyperLink NavigateUrl="?orderBy=CreationDate" Text="Sort by Date" runat="server" CssClass="btn btn-md-2 btn-default" />
            <asp:HyperLink NavigateUrl="?orderBy=Rating" Text="Sort by Rating" runat="server" CssClass="btn btn-md-2 btn-default" />
            <table class="table">
                <tr>
                    <th>Name</th>
                    <th>Category</th>
                    <th>Creator</th>
                    <th>Number of videos</th>
                </tr>
                <div runat="server" id="itemPlaceholder"></div>
            <asp:Button Text="Add new playlist" runat="server" ID="ButtonNewPlaylist" OnClick="ButtonNewPlaylist_OnClick" CssClass="btn btn-info pull-right" />
            </table>
            <br />
            <br />
            <asp:DataPager runat="server" PageSize="10">
                <Fields>
                    <asp:NextPreviousPagerField ShowPreviousPageButton="true" ShowNextPageButton="false" ButtonCssClass="btn btn-success" />
                    <asp:NumericPagerField />
                    <asp:NextPreviousPagerField ShowPreviousPageButton="false" ShowNextPageButton="true" ButtonCssClass="btn btn-success" />
                </Fields>
            </asp:DataPager>
        </LayoutTemplate>
        <ItemTemplate>
            <tr>
                <td><%#: Item.Title %></td>
                <td><asp:LinkButton runat="server" NavigateUrl='?categoty=<%# Item.Category.Name %>' Text="<%#: Item.Category.Name %>"></asp:LinkButton>
                <td><%#: Item.User.UserName %></td>
                <td><%#: GetNumberOfVideosPerPlaylistId(Item.Id) %></td>
            </tr>
        </ItemTemplate>
       
       
    </asp:ListView>
</asp:Content>
