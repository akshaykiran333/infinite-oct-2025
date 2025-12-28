<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewBill.aspx.cs" Inherits="ElectricityMiniPrj.ViewBill" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body {
    margin: 0;
    padding: 0;
    background-color: #f4f6f9;
    font-family: Arial, Helvetica, sans-serif;
}

/* Page heading */
h2 {
    text-align: center;
    margin: 30px 0 20px;
    color: #333;
}

/* Table (input section) */
table {
    width: 450px;
    margin: 0 auto 20px;
    background: #ffffff;
    padding: 20px;
    border-radius: 6px;
    box-shadow: 0 3px 8px rgba(0,0,0,0.1);
    border-collapse: collapse;
}


/* Textbox */
input[type="text"] {
    padding: 8px;
    font-size: 13px;
    border: 1px solid #ccc;
    border-radius: 4px;
}

input[type="text"]:focus {
    outline: none;
    border-color: #007bff;
}

/* Button */
input[type="submit"],
input[type="button"] {
        border-style: none;
            border-color: inherit;
            border-width: medium;
            padding: 9px;
            font-size: 14px;
            background-color: #007bff;
            color: #ffffff;
            border-radius: 4px;
            cursor: pointer;
}


        .auto-style1 {
            width: 318px;
        }
        .auto-style2 {
            width: 406px;
        }


    </style>
</head>
<body>
    <form id="form1" runat="server">
               <h2>Retrieve Last 'N' Electricity Bills</h2>
        <table>
            <tr>
                <td class="auto-style1">Enter Number of Bills to Retrieve:</td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtNumberOfBills" runat="server" Width="157px"></asp:TextBox> <asp:RequiredFieldValidator ID="rfvNumberOfBills" runat="server" ControlToValidate="txtNumberOfBills" ErrorMessage="Number of bills is required." CssClass="error" Display="Dynamic" /> 
                    <asp:RangeValidator ID="rangeNumberOfBills" runat="server" ControlToValidate="txtNumberOfBills" MinimumValue="1" MaximumValue="100" Type="Integer" ErrorMessage="Enter a valid number between 1 and 100." CssClass="error" Display="Dynamic" />
                    <asp:RegularExpressionValidator ID="revNumberOfBills" runat="server" ControlToValidate="txtNumberOfBills" ValidationExpression="^\d+$" ErrorMessage="Only numeric input is allowed." CssClass="error"
Display="Dynamic" />
                </td>
            </tr>
            <tr>
                <td colspan="2" style="padding-top:10px;">
                    <asp:Button ID="btnRetrieve" runat="server" Text="Retrieve Bills" OnClick="btnRetrieve_Click" Width="108px" />
                </td>
            </tr>
        </table>

        <asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="error" HeaderText="Please fix the following errors:" />

        <hr />

        <asp:GridView ID="gvBills" runat="server" AutoGenerateColumns="False" Visible="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="gvBills_SelectedIndexChanged">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField DataField="ConsumerNumber" HeaderText="Consumer Number" />
                <asp:BoundField DataField="ConsumerName" HeaderText="Consumer Name" />
                <asp:BoundField DataField="Units" HeaderText="Units Consumed" />
                <asp:BoundField DataField="BillAmount" HeaderText="Bill Amount (Rs.)" />

            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>

        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

        <asp:Label ID="lblMsg" runat="server" ForeColor="Red"></asp:Label>
    </form>
</body>
</html>
