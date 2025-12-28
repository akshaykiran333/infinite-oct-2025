<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddBill.aspx.cs" Inherits="ElectricityMiniPrj.AddBill" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add Electricity Bill</title>
    <style>
        body {
            margin: 0;
            padding: 0;
            background-color: #f4f6f9;
            font-family: Arial, Helvetica, sans-serif;
        }

        
        form {
            width: 420px;
            margin: 60px auto;
            background: #ffffff;
            padding: 25px 30px;
            border-radius: 6px;
            box-shadow: 0 4px 12px rgba(0,0,0,0.1);
        }

        /* Heading */
        h2 {
            text-align: center;
            margin-bottom: 10px;
            color: #333;
        }

        /* Table layout */
/*        table {
            width: 100%;
            border-collapse: collapse;
        }

        td {
            padding: 8px 4px;
            vertical-align: top;
            font-size: 14px;
            color: #333;
        }*/

        /* Inputs */
        /*input[type="text"],
        input[type="password"] {
            width: 100%;
            padding: 8px;
            font-size: 13px;
            border: 1px solid #ccc;
            border-radius: 4px;
        }

            input[type="text"]:focus {
                outline: none;
                border-color: #007bff;
            }*/

        /* Button */
        input[type="submit"],
        input[type="button"] {
            width: 35%;
            padding: 10px;
            font-size: 14px;
            background-color: #28a745;
            color: #ffffff;
            border: none;
            border-radius: 4px;
            cursor: pointer;
        }

            input[type="submit"]:hover {
                background-color: #218838;
            }

        /* Validation styles */
        .error {
            color: #dc3545;
            font-size: 12px;
            display: block;
            margin-top: 4px;
        }

        .success {
            color: #28a745;
            font-size: 13px;
        }

        /* Validation summary */
        #ValidationSummary1 {
            margin-top: 15px;
            font-size: 13px;
            color: #dc3545;
        }

        /* Horizontal line */
        hr {
            border: none;
            height: 1px;
            background-color: #ddd;
            margin-bottom: 20px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Add Electricity Bill</h2>
        <hr />
        <table>
            <tr>
                <td>Consumer Number:</td>
                <td>
                    <asp:TextBox ID="txtConsumerNo" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtConsumerNo" ErrorMessage="Consumer name cannot be empty" ForeColor="Red" Font-Names="Arial" Font-Size="Smaller"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Consumer Name:</td>
                <td>
                    <asp:TextBox ID="txtConsumerName" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvConsumerName" runat="server" ControlToValidate="txtConsumerName" ErrorMessage="Consumer Name is required." CssClass="error" Display="Dynamic"> </asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Units Consumed:</td>
                <td>
                    <asp:TextBox ID="txtUnits" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvUnits" runat="server" ControlToValidate="txtUnits" ErrorMessage="Units Consumed is required." CssClass="error" Display="Dynamic"> </asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="rangeUnits" runat="server" ControlToValidate="txtUnits" MinimumValue="0" MaximumValue="100000" Type="Integer" ErrorMessage="Units Consumed must be 0 or greater." CssClass="error" Display="Dynamic"> </asp:RangeValidator>

                    <asp:RegularExpressionValidator ID="revUnitsNumeric" runat="server" ControlToValidate="txtUnits" ValidationExpression="^\d+$" ErrorMessage="Units must be a number." CssClass="error" Display="Dynamic"> </asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td colspan="2" style="padding-top: 15px;">
                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                </td>
            </tr>
            <tr>
                <td colspan="2" style="padding-top: 10px;">

                    <asp:Label ID="lblMsg" runat="server" CssClass="error"></asp:Label>
                </td>
            </tr>
        </table>

        <asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="error" HeaderText="Please fix the following errors:" />

    </form>
</body>
</html>
