<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Task03_StudentsАndCourses.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="formStudent" runat="server">
        <p>
            First name:
            <asp:TextBox ID="TextBoxFirstName" runat="server"></asp:TextBox>
        </p>
        <p>
            Last name:
            <asp:TextBox ID="TextBoxLastName" runat="server"></asp:TextBox>
        </p>
        <p>
            Facility number:
            <asp:TextBox ID="TextBoxFacilityNumber" runat="server"></asp:TextBox>
        </p>
        <p>
            University:
            <asp:DropDownList ID="DropDownListUniversity" runat="server">
                <asp:ListItem Value="1">Telerik Academy</asp:ListItem>
                <asp:ListItem Value="2">Soft Uni</asp:ListItem>
                <asp:ListItem Value="3">Technical University</asp:ListItem>
                <asp:ListItem Value="4">Sofia University</asp:ListItem>
                <asp:ListItem Value="5">New Bulgarian University</asp:ListItem>
            </asp:DropDownList>
        </p>
        <p>
            Speciality:
            <asp:DropDownList ID="DropDownListSpeciality" runat="server">
                <asp:ListItem Value="1">Programming</asp:ListItem>
                <asp:ListItem Value="2">Some other not interesting thing</asp:ListItem>
            </asp:DropDownList>
        </p>
        <p>
            Courses:
            <asp:CheckBoxList ID="CheckBoxListCourses" runat="server">
                <asp:ListItem Value="1">C#</asp:ListItem>
                <asp:ListItem Value="2">Java Script</asp:ListItem>
                <asp:ListItem Value="3">ASP.NET</asp:ListItem>
            </asp:CheckBoxList>
        </p>
        <asp:Button ID="ButtonSubmit" runat="server" Text="Submit" OnClick="ButtonSubmit_OnClick"/>
    </form>
    <p>
        <asp:Literal runat="server" id="LiteralResult"></asp:Literal>
    </p>
</body>
</html>
