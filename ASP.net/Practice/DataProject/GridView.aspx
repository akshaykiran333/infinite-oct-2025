<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GridView.aspx.cs" Inherits="DataProject.GridView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="EmpId" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                    <asp:BoundField DataField="EmpId" HeaderText="EmpId" ReadOnly="True" SortExpression="EmpId" />
                    <asp:BoundField DataField="EmpName" HeaderText="EmpName" SortExpression="EmpName" />
                    <asp:BoundField DataField="DeptId" HeaderText="DeptId" SortExpression="DeptId" />
                    <asp:BoundField DataField="ManagerId" HeaderText="ManagerId" SortExpression="ManagerId" />
                    <asp:BoundField DataField="JoinDate" HeaderText="JoinDate" SortExpression="JoinDate" />
                    <asp:BoundField DataField="Salary" HeaderText="Salary" SortExpression="Salary" />
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
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:infinite2025ConnectionString %>" SelectCommand="SELECT * FROM [Employees]"></asp:SqlDataSource>
            <br />
            <br />
            <asp:DetailsView ID="DetailsView1" runat="server" CellPadding="4" DataSourceID="SqlDataSource2" ForeColor="#333333" GridLines="None" Height="50px" Width="125px">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <CommandRowStyle BackColor="#E2DED6" Font-Bold="True" />
                <EditRowStyle BackColor="#999999" />
                <FieldHeaderStyle BackColor="#E9ECF1" Font-Bold="True" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            </asp:DetailsView>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:infinite2025ConnectionString2 %>" ProviderName="<%$ ConnectionStrings:infinite2025ConnectionString2.ProviderName %>" SelectCommand="SELECT [EmpId], [Salary] FROM [Employees] WHERE ([EmpId] = @EmpId)">
                <SelectParameters>
                    <asp:ControlParameter ControlID="GridView1" Name="EmpId" PropertyName="SelectedValue" Type="Int32" />
                </SelectParameters>
            </asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
