<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="OrderForm.aspx.cs" Inherits="TSQLWEB.OrderForm" %>

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
                    <td class="form_left">Order No. </td>
                </tr>
                <tr>
                    <td class="form_left">Customer:
                        <asp:TextBox ID="txtEmployee" CssClass="form-control" runat="server" Width="206px" Height="180px" MaxLength="200" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtEmployee" ErrorMessage="Invalid Employee!" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                
                    <td class="form_right">Employee:
                        <asp:TextBox ID="TextBox1" CssClass="form-control" runat="server" Width="206px" MaxLength="15" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtCustomerID" ErrorMessage="Invalid Customer Name!" ForeColor="Red"></asp:RequiredFieldValidator>
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
                    <td style="width: 20%; text-align: right">Customer:</td>
                    <td style="width: 70%">
                        <asp:TextBox ID="TextBox2" CssClass="form-control" runat="server" Width="206px" MaxLength="15" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtCustomerID" ErrorMessage="Invalid Customer Name!" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td style="width: 20%; text-align: right">Customer:</td>
                    <td style="width: 70%">
                        <asp:TextBox ID="TextBox3" CssClass="form-control" runat="server" Width="206px" MaxLength="15" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtCustomerID" ErrorMessage="Invalid Customer Name!" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
            </table>

        </div>
    </div>
    <div class="panel panel-warning">
        <div class="panel-heading">
            <h3 class="panel-title">Order Form</h3>
        </div>
        <div class="panel-body">
            <table cellpadding="5px">
                <tr>
                    <td style="width: 20%; text-align: right">Customer:</td>
                    <td style="width: 70%">
                        <asp:TextBox ID="TextBox5" CssClass="form-control" runat="server" Width="206px" MaxLength="15" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtCustomerID" ErrorMessage="Invalid Customer Name!" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td style="width: 20%; text-align: right">Customer:</td>
                    <td style="width: 70%">
                        <asp:TextBox ID="TextBox6" CssClass="form-control" runat="server" Width="206px" MaxLength="15" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txtCustomerID" ErrorMessage="Invalid Customer Name!" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
	<td style="width: 20%; text-align:right">Employee:</td>
	<td style="width: 70%"><asp:TextBox ID="TextBox4" cssClass="form-control" runat="server" Width="206px" Height="180px" MaxLength="200"/>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtEmployee" ErrorMessage="Invalid Employee!" ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
	</tr>

                <tr>
	<td style="width: 20%; text-align:right">Employee:</td>
	<td style="width: 70%"><asp:TextBox ID="TextBox7" cssClass="form-control" runat="server" Width="206px" Height="180px" MaxLength="200"/>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="txtEmployee" ErrorMessage="Invalid Employee!" ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
	</tr>
<tr>
	<td style="width: 20%; text-align:right">Employee:</td>
	<td style="width: 70%"><asp:TextBox ID="TextBox8" cssClass="form-control" runat="server" Width="206px" Height="180px" MaxLength="200"/>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="txtEmployee" ErrorMessage="Invalid Employee!" ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
	</tr>
<tr>
	<td style="width: 20%; text-align:right">Employee:</td>
	<td style="width: 70%"><asp:TextBox ID="TextBox9" cssClass="form-control" runat="server" Width="206px" Height="180px" MaxLength="200"/>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="txtEmployee" ErrorMessage="Invalid Employee!" ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
	</tr>
<tr>
	<td style="width: 20%; text-align:right">Employee:</td>
	<td style="width: 70%"><asp:TextBox ID="TextBox10" cssClass="form-control" runat="server" Width="206px" Height="180px" MaxLength="200"/>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ControlToValidate="txtEmployee" ErrorMessage="Invalid Employee!" ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
	</tr>

            </table>

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
