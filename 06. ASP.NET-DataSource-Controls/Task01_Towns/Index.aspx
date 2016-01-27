<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Task01_Towns.Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <div class="panel panel-default">
        <div class="panel-heading">Continents</div>
        <div class="panel-body">
            <div class="row">
                <div class="col-md-6">
                    <asp:ListBox CssClass="form-control" runat="server" ID="ListBoxContinents" DataValueField="Name" SelectMethod="ListBoxContinents_Select" AutoPostBack="True" OnSelectedIndexChanged="ListBoxContinents_OnSelectedIndexChanged" />
                </div>
                <div class="col-md-6">
                    <asp:Button CssClass="btn btn-danger" runat="server" ID="ButtonDeleteContinent" Text="Remove Selected" OnClick="ButtonDeleteContinent_OnClick" />
                </div>
            </div>
            <br />
            <div class="row">
                <div class="col-md-6">
                    <asp:TextBox runat="server" ID="TextBoxAddContinent"></asp:TextBox>
                    <asp:Button CssClass="btn btn-info" runat="server" ID="ButtonAddContinent" Text="Add" OnClick="ButtonAddContinent_OnClick" />
                </div>
            </div>
        </div>
    </div>

    <div class="panel panel-default">
        <div class="panel-heading">Countries</div>
        <div class="panel-body">
            <div class="row">
                <div class="col-md-12">
                    <asp:GridView runat="server" AutoGenerateColumns="False" AllowSorting="True" ID="GridViewCountries"
                        SelectMethod="GridViewCountries_Select" UpdateMethod="GridViewCountries_UpdateItem"
                        ItemType="Task01_Towns.Data.Country" DeleteMethod="GridViewCountries_DeleteItem">
                        <Columns>
                            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                            <asp:BoundField DataField="Continent.Name" HeaderText="Continent" />
                            <asp:BoundField DataField="Language" HeaderText="Language" SortExpression="Language" />
                            <asp:BoundField DataField="Population" HeaderText="Population" SortExpression="Population" />
                            <asp:ImageField DataImageUrlField="Id"></asp:ImageField>
                            <asp:CommandField ShowEditButton="true" ShowDeleteButton="true" ShowSelectButton="True" />
                        </Columns>


                        <EmptyDataTemplate>
                            No countries in <%#: this.ListBoxContinents.SelectedValue %>, please add some!    
                        </EmptyDataTemplate>
                    </asp:GridView>
                </div>
            </div>
            <div class="row">
                Name:
                <asp:TextBox CssClass="form-control" runat="server" ID="TextBoxAddCountryName"></asp:TextBox>
                Language:
                <asp:TextBox CssClass="form-control" runat="server" ID="TextBoxAddCountryLanguage"></asp:TextBox>
                Population:
                <asp:TextBox CssClass="form-control" runat="server" ID="TextBoxAddCountryPopulation"></asp:TextBox>
                Flag:
                <asp:FileUpload CssClass="form-control" ID="FileUploadFlagData" runat="server" />
                Country:
                <asp:DropDownList CssClass="form-control" runat="server" ID="DropDownListContinents" DataValueField="Name" SelectMethod="ListBoxContinents_Select" />
                <asp:Button CssClass="btn btn-info" runat="server" ID="ButtonAddCountry" Text="Add" OnClick="ButtonAddCountry_OnClick" />
            </div>
            <br />
            <div class="row">
            </div>
        </div>
    </div>

    <div class="panel panel-default">
        <div class="panel-heading">Towns</div>
        <div class="panel-body">
            <div class="row">
                <div class="col-md-12">
                    <asp:ListView runat="server" ID="ListViewTowns"
                        ItemType="Task01_Towns.Data.Town"
                        SelectMethod="ListViewTowns_SelectItem"
                        InsertMethod="ListViewTowns_InsertItem"
                        DeleteMethod="ListViewTowns_DeleteItem"
                        UpdateMethod="ListViewTowns_UpdateItem"
                        DataKeyNames="Id"
                        InsertItemPosition="LastItem">

                        <LayoutTemplate>
                            <asp:LinkButton runat="server" CssClass="btn btn-default" ID="ButtonSortbyName" Text="Sort by Name" CommandName="Sort" CommandArgument="Name" />
                            <div runat="server" id="itemPlaceholder"></div>
                        </LayoutTemplate>

                        <EmptyDataTemplate>
                            <div class="row">
                                <h3>No towns! Please add some.</h3>
                                <br />
                            </div>
                        </EmptyDataTemplate>

                        <ItemTemplate>
                            <div class="panel panel-default">
                                <div class="row">
                                    <div class="col-md-6">Name: <%#: Item.Name %></div>
                                </div>
                                <div class="row">
                                    <div class="col-md-6">Population: <%#: Item.Population %></div>
                                </div>
                                <div class="row">
                                    <div class="col-md-6">Country: <%#: Item.Country.Name %></div>
                                </div>
                                <asp:LinkButton runat="server" ID="ButtonEdit" Text="Edit" CssClass="btn btn-info" CommandName="Edit" CausesValidation="false" />
                                <asp:LinkButton runat="server" ID="LinkButton1" Text="Delete" CssClass="btn btn-danger" CommandName="Delete" CausesValidation="false" />
                            </div>
                        </ItemTemplate>

                        <EditItemTemplate>
                            <div class="panel panel-default">
                                <div class="row">
                                    <div class="col-md-6">
                                        Name:
                                        <asp:TextBox runat="server" ID="TextBoxEditName" Text="<%# BindItem.Name %>" CssClass="form-control" />
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-md-6">
                                        Population:
                                        <asp:TextBox runat="server" ID="TextBoxEditBody" Text="<%# BindItem.Population %>" CssClass="form-control" />
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-md-6">
                                        Category:
                                        <asp:DropDownList runat="server" ID="DropDownListCountries" DataValueField="Name" SelectMethod="GridViewCountries_Select" />
                                    </div>
                                </div>

                                <asp:LinkButton runat="server" ID="ButtonEdit" Text="Save" CssClass="btn btn-success" CommandName="Update" ValidationGroup="EditCategory" CausesValidation="true" />
                                <asp:LinkButton runat="server" ID="LinkButtonCancel" Text="Cancel" CssClass="btn btn-danger" CommandName="Cancel" CausesValidation="false" />
                            </div>
                        </EditItemTemplate>

                        <InsertItemTemplate>
                            <div class="row">
                                <div class="panel panel-default">
                                    <div class="row">
                                        <div class="col-md-6">
                                            Name:
                        <asp:TextBox runat="server" ID="TextBoxAddName" Text="<%# BindItem.Name %>" CssClass="form-control" />
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-md-6">
                                            Population:
                        <asp:TextBox runat="server" ID="TextBoxAddPopulation" Text="<%# BindItem.Population %>" CssClass="form-control" />
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-md-6">
                                            Country:
                        <asp:DropDownList runat="server" ID="DropDownListAddCountries" DataValueField="Name" SelectMethod="GridViewCountries_Select" />
                                        </div>
                                    </div>

                                    <asp:LinkButton runat="server" ID="ButtonEdit" Text="Insert" CssClass="btn btn-info" CommandName="Insert" CausesValidation="true" ValidationGroup="InsertCategory" />
                                    <asp:LinkButton runat="server" ID="ButtonCancel" Text="Cancel" CssClass="btn btn-danger" CommandName="Cancel" />
                                </div>
                        </InsertItemTemplate>
                    </asp:ListView>

                    <div class="row">
                        <asp:DataPager runat="server" ID="DataPagerTowns" PagedControlID="ListViewTowns" PageSize="5">
                            <Fields>
                                <asp:NextPreviousPagerField ShowNextPageButton="false" ShowPreviousPageButton="true" />
                                <asp:NumericPagerField />
                                <asp:NextPreviousPagerField ShowNextPageButton="true" ShowPreviousPageButton="false" />
                            </Fields>
                        </asp:DataPager>
                    </div>

                </div>
            </div>

        </div>
    </div>

</asp:Content>
