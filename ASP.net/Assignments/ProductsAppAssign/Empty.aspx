<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Empty.aspx.cs" Inherits="ProductsAppAssign.Empty" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" style="font-family: Bahnschrift; background-color: #DAE9E2">
        
            <h1>Select the Product </h1>
        
        <asp:DropDownList ID="Dproducts" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True">
        </asp:DropDownList> 

    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
            <br />
&nbsp;&nbsp;&nbsp;<asp:Image ID="Image1" runat="server"  Width="200px" Height="200px"/>

            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Get Price" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server"  ></asp:Label>

    </form>
</body>
</html>
