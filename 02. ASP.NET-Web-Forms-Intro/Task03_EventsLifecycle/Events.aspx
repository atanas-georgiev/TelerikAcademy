<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Events.aspx.cs" Inherits="Task03_EventsLifecycle.Events" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Events</title>
</head>
<body>
    <form id="formEvents" runat="server">
    <div>
    
    </div>
        <asp:Label ID="LabelTest" runat="server" OnDataBinding="LabelTest_DataBinding" OnDisposed="LabelTest_Disposed" OnInit="LabelTest_Init" OnLoad="LabelTest_Load" OnPreRender="LabelTest_PreRender" OnUnload="LabelTest_Unload" Text="Test Label"></asp:Label>
    </form>
</body>
</html>
