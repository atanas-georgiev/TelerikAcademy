<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FileUploader.aspx.cs" Inherits="TxtUploader.FileUploader" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:FileUpload ID="FileUploadZipData" runat="server" />
    
    </div>
        <p>
            <asp:Button ID="ButtonUpload" runat="server" OnClick="ButtonUpload_Click" Text="Upload" />
        </p>
        <asp:Literal ID="LiteralResult" runat="server"></asp:Literal>
    </form>
</body>
</html>
