<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Task05_Calculator.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: left;
        }
        .auto-style2 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="formCalculator" runat="server">
        <asp:Panel ID="Panel1" runat="server" BorderStyle="Double" Height="300px" Width="300px">
            <div class="auto-style2">
                <br/>
                <asp:TextBox ID="TextBoxCalculator" runat="server" style="text-align: center" Width="200px" ReadOnly="True"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="Button1" runat="server" Width="40px" Height="40px" Text="1" OnClick="Button1_Click" />
                <asp:Button ID="Button2" runat="server" Width="40px" Height="40px" Text="2" OnClick="Button2_Click" />
                <asp:Button ID="Button3" runat="server" Width="40px" Height="40px" Text="3" OnClick="Button3_Click" />
                <asp:Button ID="ButtonPlus" runat="server" Width="40px" Height="40px" Text="+" OnClick="ButtonPlus_Click" />
                <br />                                  
                <asp:Button ID="Button4" runat="server" Width="40px" Height="40px" Text="4" OnClick="Button4_Click" />
                <asp:Button ID="Button5" runat="server" Width="40px" Height="40px" Text="5" OnClick="Button5_Click" />
                <asp:Button ID="Button6" runat="server" Width="40px" Height="40px" Text="6" OnClick="Button6_Click" />
                <asp:Button ID="ButtonMinus" runat="server" Width="40px" Height="40px" Text="-" OnClick="ButtonMinus_Click" />
                <br />                                  
                <asp:Button ID="Button7" runat="server" Width="40px" Height="40px" Text="7" OnClick="Button7_Click" />
                <asp:Button ID="Button8" runat="server" Width="40px" Height="40px" Text="8" OnClick="Button8_Click" />
                <asp:Button ID="Button9" runat="server" Width="40px" Height="40px" Text="9" OnClick="Button9_Click" />
                <asp:Button ID="ButtonMultiply" runat="server" Width="40px" Height="40px" Text="X" OnClick="ButtonMultiply_Click" />
                <br />                                   
                <asp:Button ID="ButtonClear" runat="server" Width="40px" Height="40px" Text="C" OnClick="ButtonClear_Click" />
                <asp:Button ID="Button0" runat="server" Width="40px" Height="40px" Text="0" OnClick="Button0_Click" />
                <asp:Button ID="ButtonDevide" runat="server" Width="40px" Height="40px" Text="/" OnClick="ButtonDevide_Click" />
                <asp:Button ID="ButtonSquare" runat="server" Width="40px" Height="40px" Text="√" OnClick="ButtonSquare_Click" />
                <br />
                <br />
                <asp:Button ID="ButtonResult" runat="server" Width="200px" Height="40px" Text="=" OnClick="ButtonResult_Click" />
            </div>
        </asp:Panel>
    </form>
</body>
</html>
