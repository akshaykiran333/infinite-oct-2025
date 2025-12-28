<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master"
    AutoEventWireup="true" CodeBehind="Default.aspx.cs"
    Inherits="ElectricityMiniPrj._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
         <style>
        body {
            background-color: #f4f6f9;
            font-family: Arial, Helvetica, sans-serif;
        }

        main {
            margin-top: 40px;
        }

        #pageTitle {
            text-align: center;
            font-size: 32px;
            font-weight: bold;
            color: #333;
        }

    </style>
        <section class="row" aria-labelledby="pageTitle">
            <h1 id="pageTitle">Electricity Board Billing</h1>

            <p class="lead">
                Welcome Admin
            </p>
        </section>

        <div class="row">
            <section class="col-md-4">
                <h2>Add Bill</h2>
                <p>
                    <a href="AddBill.aspx" class="btn btn-success">Add Bill
                    </a>
                </p>
            </section>

            <section class="col-md-4">
                <h2>View Bills</h2>
                <p>
                    <a href="ViewBill.aspx" class="btn btn-info">View Bills
                    </a>
                </p>
            </section>

            <section class="col-md-4">
                <h2>Logout</h2>
                <p>
                    <a href="LoginForm.aspx" class="btn btn-danger">Logout
                    </a>
                </p>
            </section>
        </div>
    </main>


</asp:Content>
