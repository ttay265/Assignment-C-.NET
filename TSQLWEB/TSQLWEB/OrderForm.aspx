<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="OrderForm.aspx.cs" Inherits="TSQLWEB.OrderForm" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Stylesheets" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <div class="panel panel-success">
        <div class="panel-heading">
            <h3 class="panel-title">Basic Information</h3>
        </div>
        <div class="panel-body">
            <table cellpadding="5px">
                <tr>
                    <td class="form_left">Customer:
                     <ajaxToolkit:ComboBox CssClass="form-control" ID="cbCustomer" runat="server"></ajaxToolkit:ComboBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="cbCustomer" ErrorMessage="Invalid Employee!" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>

                    <td class="form_right">Employee:
                     <ajaxToolkit:ComboBox CssClass="form-control" ID="cbEmployeeID" runat="server"></ajaxToolkit:ComboBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="cbEmployeeID" ErrorMessage="Field Empty!" ForeColor="Red"></asp:RequiredFieldValidator>

                    </td>
                </tr>
            </table>
        </div>
    </div>
    <div class="panel panel-info">
        <div class="panel-heading">
            <h3 class="panel-title">Order Form</h3>
        </div>
        <div class="panel-body">
            <table cellpadding="5px">
                <tr>
                    <td class="form_left">Order Date:
                        <asp:TextBox CssClass="form-control" ID="txtOrderDate" runat="server" />
                            <img id="CalendarPopUp1" width="40px" src="image/calendar.png" />
                            <ajaxToolkit:CalendarExtender ID="txtBirthDate_CalendarExtender" runat="server" TargetControlID="txtOrderDate" PopupButtonID="CalendarPopUp1" />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtOrderDate" ErrorMessage="Field Empty!" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                    <td class="form_right">Required Date:
                        <asp:TextBox CssClass="form-control" ID="txtReqiredDate" runat="server" />
                            <img id="CalendarPopUp2" width="40px" src="image/calendar.png" />
                            <ajaxToolkit:CalendarExtender ID="txtRequireDate_CalendarExtender" runat="server" TargetControlID="txtReqiredDate" PopupButtonID="CalendarPopUp2" />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtReqiredDate" ErrorMessage="Field Empty!" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                     <td class="form_left">Required Date:
                        <asp:TextBox CssClass="form-control" ID="txtShippedDate" runat="server" />
                            <img id="CalendarPopUp3" width="40px" src="image/calendar.png" />
                            <ajaxToolkit:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="txtShippedDate" PopupButtonID="CalendarPopUp2" />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtShippedDate" ErrorMessage="Field Empty!" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
            </table>
        </div>
    </div>
    <div class="panel panel-warning">
        <div class="panel-heading">
            <h3 class="panel-title">Shipping Information</h3>
        </div>
        <div class="panel-body">
          <tr>
                    <td class="form_left">Shipper:
                     <ajaxToolkit:ComboBox CssClass="form-control" ID="cbShipperID" runat="server"></ajaxToolkit:ComboBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="cbShipperID" ErrorMessage="Field Empty!" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>

                    <td class="form_right">Freight:
                        <asp:TextBox ID="txtFreight" CssClass="form-control" runat="server" Width="206px" MaxLength="15" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtFreight" ErrorMessage="Field Empty!" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
            <tr>
                 <td class="form_left">Ship Name:
                        <asp:TextBox ID="txtShipperName" CssClass="form-control" runat="server" Width="206px" MaxLength="15" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txtShipperName" ErrorMessage="Field Empty!" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                 <td class="form_right">Ship Address:
                        <asp:TextBox ID="txtShipAddress" CssClass="form-control" runat="server" Width="206px" MaxLength="15" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="txtShipAddress" ErrorMessage="Field Empty!" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
            </tr>
             <tr>
                 <td class="form_left">Ship City:
                        <asp:TextBox ID="txtShipCity" CssClass="form-control" runat="server" Width="206px" MaxLength="15" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="txtShipCity" ErrorMessage="Field Empty!" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                 <td class="form_right">Ship Region:
                        <asp:TextBox ID="txtShipRegion" CssClass="form-control" runat="server" Width="206px" MaxLength="15" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="txtShipRegion" ErrorMessage="Field Empty!" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
            </tr>
             <tr>
                 <td class="form_left">Ship Postal Code:
                        <asp:TextBox ID="txtShipPostalCode" CssClass="form-control" runat="server" Width="206px" MaxLength="15" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ControlToValidate="txtShipPostalCode" ErrorMessage="Field Empty!" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                 <td class="form_right">Ship Country:
                        <ajaxToolkit:ComboBox ID="cbShipCountry" CssClass="form-control" runat="server" Width="206px" MaxLength="15" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" ControlToValidate="cbShipCountry" ErrorMessage="Field Empty!" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
            </tr>

        </div>
    </div>



    <br />
    <div style="margin: auto">
        <asp:Button ID="btnNew" CssClass="btn btn-default" runat="server" Text="New" OnClick="btnNew_Click" />
        <asp:Button ID="btnAdd" CssClass="btn btn-success" runat="server" Text="Add" OnClick="btnAdd_Click" />
    </div>
    <br />
    <script>
    </script>
    <asp:Label ID="lblStatus" runat="server"></asp:Label>
    <%--<div id="alert" class="alert alert-success fade in">
    <a href="#" class="close" data-dismiss="alert" aria-label="close">Close &times;</a>
    <strong>Success!</strong> Add completely! 
    </div>--%>
    <asp:GridView ID="GridView1" CssClass="col-md-3" runat="server" AutoGenerateDeleteButton="True" AutoGenerateSelectButton="True" OnRowDeleting="GridView1_RowDeleting1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="100%" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical">
        <AlternatingRowStyle BackColor="White"></AlternatingRowStyle>

        <FooterStyle BackColor="#CCCC99"></FooterStyle>

        <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White"></HeaderStyle>

        <PagerStyle HorizontalAlign="Right" BackColor="#F7F7DE" ForeColor="Black"></PagerStyle>

        <RowStyle BackColor="#F7F7DE"></RowStyle>

        <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White"></SelectedRowStyle>

        <SortedAscendingCellStyle BackColor="#FBFBF2"></SortedAscendingCellStyle>

        <SortedAscendingHeaderStyle BackColor="#848384"></SortedAscendingHeaderStyle>

        <SortedDescendingCellStyle BackColor="#EAEAD3"></SortedDescendingCellStyle>

        <SortedDescendingHeaderStyle BackColor="#575357"></SortedDescendingHeaderStyle>
    </asp:GridView>

    <br />

</asp:Content>
