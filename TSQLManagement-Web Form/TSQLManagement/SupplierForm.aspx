﻿<%@ page language="C#"  autoeventwireup="true" codebehind="SupplierForm.aspx.cs" inherits="TSQLManagement.SupplierForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 68%;
            height: 498px;
        }
    </style>
</head>

<body>
    <form id="form1" runat="server">
        <%--<div style="display: inline-block">--%>

            <table class="auto-style1">
                <tr>
                    <td>CompanyName:</td>
                    <td>
                        <asp:textbox id="txtCompanyName" runat="server" width="245px"></asp:textbox>
                    </td>
                </tr>
                <tr>
                    <td>ContactName:</td>
                    <td>
                        <asp:textbox id="txtContactName" runat="server" width="245px"></asp:textbox>
                    </td>
                </tr>
                <tr>
                    <td>ContactTitle:</td>
                    <td>
                        <asp:textbox id="txtContactTitle" runat="server" width="240px"></asp:textbox>
                    </td>
                </tr>
                <tr>
                    <td>Address:</td>
                    <td>
                        <asp:textbox id="txtAddress" runat="server" width="237px"></asp:textbox>
                    </td>
                </tr>
                <tr>
                    <td>City:</td>
                    <td>
                        <asp:textbox id="txtCity" runat="server" maxlength="15" width="240px"></asp:textbox>
                    </td>
                </tr>
                <tr>
                    <td>Region:</td>
                    <td>
                        <asp:textbox id="txtRegion" runat="server" maxlength="15" width="238px"></asp:textbox>
                    </td>
                </tr>
                <tr>
                    <td>Postal Code:</td>
                    <td>
                        <asp:textbox id="txtPostalCode" runat="server" maxlength="10" width="238px"></asp:textbox>
                    </td>
                </tr>
                <tr>
                    <td>Country:</td>
                    <td>
                        <asp:dropdownlist id="cbCountry" runat="server" width="170px">
                        <asp:ListItem Selected="True" Value="-1">Select a national</asp:ListItem>
                        <asp:ListItem>USA</asp:ListItem>
                        <asp:ListItem>UK</asp:ListItem>
                        <asp:ListItem>Canada</asp:ListItem>
                        <asp:ListItem>French</asp:ListItem>
                        <asp:ListItem>Thailand</asp:ListItem>
                        <asp:ListItem>Japan</asp:ListItem>
                        <asp:ListItem>Cuba</asp:ListItem>
                    </asp:dropdownlist>
                    </td>
                </tr>
                <tr>
                    <td>Phone:</td>
                    <td>
                        <asp:textbox id="txtPhone" runat="server" width="233px"></asp:textbox>
                    </td>
                </tr>
                <tr>
                    <td>Fax:</td>
                    <td>
                        <asp:textbox id="txtFax" runat="server" width="233px"></asp:textbox>
                    </td>
                </tr>
            </table>

        </div>
        <div style="display: inline-block">
            <asp:button id="btnNew" runat="server" text="New" OnClick="btnNew_Click" />
            <asp:button id="btnAdd" runat="server" onclick="btnAdd_Click" text="Add" />
            <asp:Label ID="lblStatus" runat="server" ForeColor="#FF3300"></asp:Label>
            <asp:gridview id="GridView1" runat="server" height="288px" width="937px" autogenerateselectbutton="True" AutoGenerateDeleteButton="True" OnRowDeleting="GridView1_RowDeleting" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        </asp:gridview>
        </div>

    </form>
</body>
</html>
