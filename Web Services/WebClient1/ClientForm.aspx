<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ClientForm.aspx.cs" Inherits="WebClient1.ClientForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter User Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
            <br />
            <br />
            Enter a Decimal Number:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtfnum" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Butnhello" runat="server" Text="Hello world" OnClick="Butnhello_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Btnsayhello" runat="server" Text="Say Helho" OnClick="Btnsayhello_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Btnsqu" runat="server" Text="For Square" OnClick="Btnsqu_Click" />
            <br />
            <br />
            <asp:Label ID="Lbl" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
