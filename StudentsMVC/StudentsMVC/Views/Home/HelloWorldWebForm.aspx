﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HelloWorldWebForm.aspx.cs" Inherits="StudentsMVC.Views.Home.HelloWorldWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Calendar ID="calender1" runat="server"></asp:Calendar>
            <asp:Label ID="lblName" runat="server"><%=Session["name"].ToString()%></asp:Label>
        </div>
    </form>
</body>
</html>
