<%@ Page Title="" Language="C#" MasterPageFile="~/layout.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="MasterProject.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainPlaceHolder" runat="server">
    <asp:Calendar ID="Calender1" runat ="server"></asp:Calendar>
    <br />
    <asp:TextBox ID="txtdata" runat="server"></asp:TextBox>
    <asp:Button ID="btnClick" runat ="server" Text="click" />
</asp:Content>
