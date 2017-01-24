<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RandomHtml.aspx.cs" Inherits="Task01_Random.Random" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Random HTML controls</title>
    <style type="text/css">
        #TextHtmlRandomFirst {
            width: 50px;
        }
        #TextHtmlRandomSecond {
            width: 50px;
        }
    </style>
</head>
<body>    
    <h3>HTML Controls</h3>
    <form id="formRandomHtml" runat="server">              
        <label for="TextHtmlRandomFirst">Random number from: </label>
        <input id="TextHtmlRandomFirst" type="number" runat="server"/>
        <label for="TextHtmlRandomSecond"> to: </label>
        <input id="TextHtmlRandomSecond" type="number" runat="server"/>
        <button id="ButtonRandom" runat="server" OnServerClick="ButtonRandom_OnServerClick">Generate</button>
        <br/>
        <label id="labelResult" runat="server"></label>
    </form>         
</body>
</html>
