<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Validation.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css" rel="stylesheet" integrity="sha256-7s5uDGW3AHqw6xtJmNNtr+OBRJUlgkNJEo78P4b0yRw= sha512-nNo+yCHEyn0smMxSswnf/OnX6/KwJuZTlNZBjauKhTK0c+zT+q5JOCx0UFhXQ6rJR9jg6Es8gPuD2uZcYDLqSw==" crossorigin="anonymous" />
    <title>Validation form</title>
</head>
<body>
    <div class="col-lg-6">
        <div class="well bs-component">
            <form id="formValidation" class="form-horizontal" runat="server">

                <asp:ValidationSummary runat="server" ID="ValidationSummaryMain"
                    DisplayMode="BulletList"
                    ShowMessageBox="False" ShowSummary="True" CssClass="alert alert-danger" />

                <fieldset>
                    <legend>Logon Info</legend>
                    <div class="form-group">
                        <asp:Label runat="server" for="TextBoxUserName" CssClass="col-lg-2 control-label">User Name</asp:Label>
                        <div class="col-lg-6">
                            <asp:TextBox runat="server" CssClass="form-control" ID="TextBoxUserName" placeholder="User Name"
                                ValidationGroup="ValidationGroupLogonInfo" />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidatorUserName" runat="server" Display="Dynamic" ErrorMessage="Username is required!"
                                ControlToValidate="TextBoxUserName" EnableClientScript="false" />
                        </div>
                    </div>

                    <div class="form-group">
                        <asp:Label runat="server" for="TextBoxPassword" CssClass="col-lg-2 control-label">Password</asp:Label>
                        <div class="col-lg-6">
                            <asp:TextBox runat="server" CssClass="form-control" ID="TextBoxPassword" placeholder="Password" TextMode="Password"
                                ValidationGroup="ValidationGroupLogonInfo" />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidatorPassword" runat="server" Display="Dynamic" ErrorMessage="Password is required!"
                                ControlToValidate="TextBoxPassword" EnableClientScript="false" />
                        </div>
                    </div>

                    <div class="form-group">
                        <asp:Label runat="server" for="TextBoxPasswordConfirmPassword" CssClass="col-lg-2 control-label">Confirm Password</asp:Label>
                        <div class="col-lg-6">
                            <asp:TextBox runat="server" CssClass="form-control" ID="TextBoxPasswordConfirmPassword" placeholder="Confirm Password" TextMode="Password"
                                ValidationGroup="ValidationGroupLogonInfo" />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidatorConfirmPassword" runat="server" Display="Dynamic" ErrorMessage="Confirm Password is required!"
                                ControlToValidate="TextBoxPasswordConfirmPassword" EnableClientScript="false" />
                            <asp:CompareValidator ID="CompareValidatorPassword" runat="server" ControlToCompare="TextBoxPasswordConfirmPassword"
                                ControlToValidate="TextBoxPassword" Display="Dynamic" ErrorMessage="Password doesn't match!" EnableClientScript="False" />
                        </div>
                    </div>
                </fieldset>
                <fieldset>
                    <legend>Personal Info</legend>
                    <div class="form-group">
                        <asp:Label runat="server" for="TextBoxFirstName" CssClass="col-lg-2 control-label">First Name</asp:Label>
                        <div class="col-lg-6">
                            <asp:TextBox runat="server" CssClass="form-control" ID="TextBoxFirstName" placeholder="First Name"
                                ValidationGroup="ValidationGroupPersonalInfo" />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidatorFirstName" runat="server" Display="Dynamic" ErrorMessage="First name is required!"
                                ControlToValidate="TextBoxFirstName" EnableClientScript="false" />
                        </div>
                    </div>

                    <div class="form-group">
                        <asp:Label runat="server" for="TextBoxLastName" CssClass="col-lg-2 control-label">Last Name</asp:Label>
                        <div class="col-lg-6">
                            <asp:TextBox runat="server" CssClass="form-control" ID="TextBoxLastName" placeholder="Last Name"
                                ValidationGroup="ValidationGroupPersonalInfo" />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidatorLastName" runat="server" Display="Dynamic" ErrorMessage="Last name is required!"
                                ControlToValidate="TextBoxLastName" EnableClientScript="false" />
                        </div>
                    </div>

                    <div class="form-group">
                        <asp:Label runat="server" for="TextBoxAge" CssClass="col-lg-2 control-label">Age</asp:Label>
                        <div class="col-lg-6">
                            <asp:TextBox runat="server" CssClass="form-control" ID="TextBoxAge" placeholder="Age" TextMode="Number"
                                ValidationGroup="ValidationGroupPersonalInfo" />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidatorAge" runat="server" Display="Dynamic" ErrorMessage="Age is required!"
                                ControlToValidate="TextBoxAge" EnableClientScript="false" />
                            <asp:RangeValidator ID="RangeValidatorAge" runat="server" ErrorMessage="Age should be between 18 and 81"
                                ControlToValidate="TextBoxAge" MinimumValue="18" MaximumValue="81" Type="Integer" EnableClientScript="false" />
                        </div>
                    </div>

                    <div class="form-group">
                        <asp:Label runat="server" for="RadioButtonListGender" CssClass="col-lg-2 control-label">Gender</asp:Label>
                        <div class="col-lg-6">
                            <asp:RadioButtonList runat="server" ID="RadioButtonListGender" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonListGender_SelectedIndexChanged">
                                <asp:ListItem Selected="True">Male</asp:ListItem>
                                <asp:ListItem>Female</asp:ListItem>
                            </asp:RadioButtonList>
                        </div>
                    </div>

                </fieldset>
                <fieldset>
                    <legend>Address Info</legend>
                    <div class="form-group">
                        <asp:Label runat="server" for="TextBoxEmail" CssClass="col-lg-2 control-label">Email</asp:Label>
                        <div class="col-lg-6">
                            <asp:TextBox runat="server" CssClass="form-control" ID="TextBoxEmail" placeholder="Email" TextMode="Email"
                                ValidationGroup="ValidationGroupAddressInfo" />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidatorEmail" runat="server" Display="Dynamic" ErrorMessage="Email is required!"
                                ControlToValidate="TextBoxEmail" EnableClientScript="false" />
                            <asp:RegularExpressionValidator ID="RegularExpressionValidatorEmail" runat="server" Display="Dynamic" ErrorMessage="Email address is incorrect!"
                                ControlToValidate="TextBoxEmail" EnableClientScript="False"
                                ValidationExpression="[a-zA-Z][a-zA-Z0-9\-\.]*[a-zA-Z]@[a-zA-Z][a-zA-Z0-9\-\.]+[a-zA-Z]+\.[a-zA-Z]{2,4}" />

                        </div>
                    </div>

                    <div class="form-group">
                        <asp:Label runat="server" for="TextBoxAddress" CssClass="col-lg-2 control-label">Address</asp:Label>
                        <div class="col-lg-6">
                            <asp:TextBox runat="server" CssClass="form-control" ID="TextBoxAddress" placeholder="Address" TextMode="MultiLine"
                                ValidationGroup="ValidationGroupAddressInfo" />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidatorAddress" runat="server" Display="Dynamic" ErrorMessage="Address is required!"
                                ControlToValidate="TextBoxAddress" EnableClientScript="false" />
                        </div>
                    </div>

                    <div class="form-group">
                        <asp:Label runat="server" for="TextBoxPhone" CssClass="col-lg-2 control-label">Phone</asp:Label>
                        <div class="col-lg-6">
                            <asp:TextBox runat="server" CssClass="form-control" ID="TextBoxPhone" placeholder="Phone" TextMode="Phone"
                                ValidationGroup="ValidationGroupAddressInfo" />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidatorPhone" runat="server" Display="Dynamic" ErrorMessage="Phone is required!"
                                ControlToValidate="TextBoxPhone" EnableClientScript="false" />
                            <asp:RegularExpressionValidator ID="RegularExpressionValidatorPhone" runat="server" Display="Dynamic" ErrorMessage="Phone is incorrect!"
                                ControlToValidate="TextBoxPhone" EnableClientScript="False"
                                ValidationExpression="(?:(?:\+?1\s*(?:[.-]\s*)?)?(?:(\s*([2-9]1[02-9]|[2-9][02-8]1|[2-9][02-8][02-9]‌​)\s*)|([2-9]1[02-9]|[2-9][02-8]1|[2-9][02-8][02-9]))\s*(?:[.-]\s*)?)([2-9]1[02-9]‌​|[2-9][02-9]1|[2-9][02-9]{2})\s*(?:[.-]\s*)?([0-9]{4})(?:\s*(?:#|x\.?|ext\.?|extension)\s*(\d+))?$" />
                        </div>
                    </div>
                </fieldset>
                <fieldset>
                    <legend>Interests</legend>
                    <asp:Panel ID="PanelMale" runat="server">
                        <div class="form-group">
                            <asp:Label runat="server" for="CheckBoxListFavouriteMen" CssClass="col-lg-2 control-label">Favourite cars</asp:Label>
                            <div class="col-lg-6">
                                <asp:CheckBoxList ID="CheckBoxListFavouriteMen" runat="server">
                                    <asp:ListItem Value="0">BMW</asp:ListItem>
                                    <asp:ListItem Value="1">Mercedes</asp:ListItem>
                                    <asp:ListItem Value="2">Audi</asp:ListItem>
                                    <asp:ListItem Value="3">Mazda</asp:ListItem>
                                    <asp:ListItem Value="4">Toyota</asp:ListItem>
                                    <asp:ListItem Value="5">Honda</asp:ListItem>
                                </asp:CheckBoxList>
                            </div>
                        </div>
                    </asp:Panel>
                    <asp:Panel ID="PanelFemale" runat="server">
                        <div class="form-group">
                            <asp:Label runat="server" for="DropDownListFavouriteFemale" CssClass="col-lg-2 control-label">Favourite coffee</asp:Label>
                            <div class="col-lg-6">
                                <asp:DropDownList ID="DropDownListFavouriteFemale" runat="server">
                                    <asp:ListItem Value="0">Lavazza</asp:ListItem>
                                    <asp:ListItem Value="1">New Brazil</asp:ListItem>
                                    <asp:ListItem Value="2">Chibbo</asp:ListItem>
                                    <asp:ListItem Value="3">Arabica</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>
                    </asp:Panel>
                    <br />
                    <div class="col-lg-10 col-lg-offset-2">
                        <asp:Button runat="server" ID="ButtonSubmit" type="submit" class="btn btn-primary" Text="Submit" />
                    </div>
                </fieldset>
            </form>
        </div>
    </div>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/js/bootstrap.min.js" integrity="sha256-KXn5puMvxCw+dAYznun+drMdG1IFl3agK0p/pqT9KAo= sha512-2e8qq0ETcfWRI4HJBzQiA3UoyFk6tbNyG+qSaIBZLyW9Xf3sWZHN/lxe9fTh1U45DpPf07yj94KsUHHWe4Yk1A==" crossorigin="anonymous"></script>
</body>
</html>
