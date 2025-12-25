<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DetailForm.aspx.cs" Inherits="ValidationsAssign.DetailForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-family: Georgia, 'Times New Roman', Times, serif; background-color: #DDF1F4">
            Insert your details :<br />
            <br />
            <br />
            Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Name cannot be empty" ForeColor="Red" ControlToValidate="TextName">*</asp:RequiredFieldValidator>
            <br />
            <br />
            Family Name:&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextFam" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Family Name cannot be empty" ForeColor="Red" ControlToValidate="TextFam">*</asp:RequiredFieldValidator>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextName" ControlToValidate="TextFam" ErrorMessage="differs from name" Display="Dynamic" Operator="NotEqual"></asp:CompareValidator>
            <br />
            <br />
            Address:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextAddress" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Address cannot be empty" ForeColor="Red" ControlToValidate="TextAddress">*</asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextAddress" ErrorMessage="at least 2 chars" ValidationExpression="^.{2,}$"></asp:RegularExpressionValidator>
            <br />
            <br />
            City:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextCity" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="city is must" ForeColor="Red" ControlToValidate="TextCity">*</asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextCity" ErrorMessage="at least 2 chars" ValidationExpression="^[A-Za-z\s]{2,}$"></asp:RegularExpressionValidator>
            <br />
            <br />
            Zip Code:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextZip" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="zip code cannot be empty" ForeColor="Red" ControlToValidate="TextZip">*</asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="TextZip" ErrorMessage="(xxxxx)" ValidationExpression="^[1-9][0-9]{5}$"></asp:RegularExpressionValidator>
            <br />
            <br />
            Phone:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextPhone" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="phone number is must" ForeColor="Red" ControlToValidate="TextPhone">*</asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ControlToValidate="TextPhone" ErrorMessage="(xx-xxxxxx/xxxxxxxxx)" Display="Dynamic" ValidationExpression="^(?:\+91|91)?[6-9][0-9]{9}$"></asp:RegularExpressionValidator>
            <br />
            <br />
            E-Mail:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextMail" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="E-mail cannot be empty" ForeColor="Red" ControlToValidate="TextMail">*</asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="TextMail" ErrorMessage="example@example.com" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Check" />
            <br />

            

            <br />
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" HeaderText="Validation Sum" ShowMessageBox="True" />

            

        </div>
    </form>
</body>
</html>
