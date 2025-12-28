<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="LoginForm.aspx.cs"
    Inherits="ElectricityMiniPrj.LoginForm" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Admin Login</title>

    <style>
        body {
            margin: 0;
            height: 100vh;
            font-family: Arial, Helvetica, sans-serif;
            background-color: #e5e5e5;
            display: flex;
            align-items: center;
            justify-content: center;
        }

        form {
            width: 300px;
            margin: 60px auto;
            background: #ffffff;
            padding: 25px 30px;
            border-radius: 6px;
            box-shadow: 0 4px 12px rgba(0,0,0,0.1);
        }

        h2 {
            text-align: center;
            font-size: 30px;
            margin-bottom: 20px;
            color: #000;
        }

        #form1 {
            margin-bottom: 15px;
        }

        label {
            font-size: 12px;
            color: #333;
            display: block;
            margin-bottom: 5px;
        }

        .txt {
            width: 100%;
            padding: 9px;
            font-size: 13px;
            border: 1px solid #ccc;
            border-radius: 3px;
            background-color: #e0e0e0;
        }

        #btnLogin {
            width: 35%;
            padding: 10px;
            font-size: 14px;
            background-color: #d4aa00;
            color: #000;
            border: none;
            border-radius: 3px;
            cursor: pointer;
        }

            #btnLogin:hover {
                background-color: #c49b00;
            }

        #lblMsg {
            margin-top: 10px;
            text-align: center;
            font-size: 12px;
            color: red;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">

        <h2>Admin Login</h2>

        Username:
    <asp:TextBox ID="txtUser" runat="server"></asp:TextBox><br />
        <br />

        Password:&nbsp;
    <asp:TextBox ID="txtPass" runat="server" TextMode="Password"></asp:TextBox><br />
        <br />

        <asp:Button ID="btnLogin" runat="server"
            Text="Login"
            OnClick="btnLogin_Click" />

        <br />
        <br />

        <asp:Label ID="lblMsg" runat="server" ForeColor="Red"></asp:Label>

    </form>
</body>
</html>
