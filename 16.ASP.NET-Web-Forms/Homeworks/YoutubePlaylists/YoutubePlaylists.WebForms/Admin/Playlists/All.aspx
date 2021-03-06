﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="All.aspx.cs" Inherits="YoutubePlaylists.WebForms.Admin.Playlists.All" %>
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

<br/> 
<br/> 

 <asp:ListView runat="server" ID="ListViewPlaylists"
        ItemType="YoutubePlaylists.Data.Models.Playlist"
        DataKeyNames="Id"
        SelectMethod="ListViewPlaylists_SelectData">
        <LayoutTemplate>
            <br/>
            <asp:HyperLink NavigateUrl="?orderBy=Title" Text="Sort by Title" runat="server" CssClass="btn btn-md-2 btn-default" />
            <asp:HyperLink NavigateUrl="?orderBy=CreationDate" Text="Sort by Date" runat="server" CssClass="btn btn-md-2 btn-default" />
            <asp:HyperLink NavigateUrl="?orderBy=Rating" Text="Sort by Rating" runat="server" CssClass="btn btn-md-2 btn-default" />
            <br/>
            <br/>
            <br/>
            <asp:Button Text="Add new playlist" runat="server" ID="ButtonNewPlaylist" OnClick="ButtonNewPlaylist_OnClick" CssClass="btn btn-info" />
            <br/>
            <br/>
            <table class="table">
                <tr>
                    <th>Name</th>
                    <th>Category</th>
                    <th>Creator</th>
                    <th>Number of videos</th>
                    <th>Rating</th>
                </tr>
                <div runat="server" id="itemPlaceholder"></div>
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
                <td><a href="/Playlists/Details.aspx?id=<%# Item.Id %>"><%#: Item.Title %></a></td>
                <td><a href="?category=<%# Item.Category.Name %>"><%#: Item.Category.Name %></a></td>
                <td><%#: Item.User.UserName %></td>
                <td><%#: GetNumberOfVideosPerPlaylistId(Item.Id) %></td>
                <td><%#: Item.Ratings.Sum(r => r.Value) %></td>
            </tr>
        </ItemTemplate>
       
    </asp:ListView>
</asp:Content>
