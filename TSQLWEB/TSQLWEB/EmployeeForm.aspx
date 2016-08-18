<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EmployeeForm.aspx.cs" Inherits="TSQLWEB.EmployeeForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Stylesheets" runat="server">
    <%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
    <script>
        newaction();
        function newaction() {
            var textboxlist = document.getElementsByClassName('form-control');
            var i;
            for (i = 0; i < textboxlist.length; i++) {
                textboxlist[i].value = "";
            }
        }
    </script>
    <style type="text/css">
        .button {
            padding: 15px;
        }
        .form_left {
            width: 50%;
            padding-left: 30px;
        }
         .form_right {
            float: right;
            width: 50%;
            margin-right: 250px;
        }
         .popup_icon {
             display: inline;
         }
    </style>


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="panel panel-info">
        <div class="panel-heading">
          <h3 class="panel-title">Employee Form</h3>
        </div>
        <div class="panel-body">
          <table cellpadding="10px" border="0" style="width: 100%">
        <tr>
            <td class="form_left">
                <asp:Label ID="Label1" runat="server" Text="Lastname : " /> 
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Input Lastname" ControlToValidate="txtlastname" ForeColor="Red"/>
                <asp:Textbox cssClass="form-control" ID="txtlastname" runat="server"></asp:TextBox>
                
            </td>
            <td class="form_right">
                <asp:Label ID="Label8" runat="server" Text="TitleOfCourt :"></asp:Label>
                <asp:RequiredFieldValidator  ID="RequiredFieldValidator3" runat="server" ErrorMessage="Input Title of court" ControlToValidate="txttitleofcourt" ForeColor="Red"/>
                <asp:Textbox cssClass="form-control" ID="txttitleofcourt" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="form_left">
                <asp:Label ID="Label2" runat="server" Text="Firstname : "></asp:Label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Input Firstname" ControlToValidate="txtfirstname" ForeColor="Red"/>
                <asp:Textbox cssClass="form-control" ID="txtfirstname" runat="server"></asp:TextBox>
            </td>
            <td class="form_right">
                <asp:Label ID="Label9" runat="server" Text="BirthDate : "></asp:Label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Input Birthdate" ControlToValidate="txtBirthDate" ForeColor="Red"/>
                <asp:Textbox cssClass="form-control" ID="txtBirthDate" runat="server" />
                    <div>
                <img ID="CalendarPopUp" Class="img-rounded popup_icon" src="image/calendar.png" />
                <ajaxToolkit:CalendarExtender ID="txtBirthDate_CalendarExtender" runat="server" TargetControlID="txtBirthDate" PopupButtonID="CalendarPopUp"/>
                   </div>
            </td>
        </tr>
        <tr>
            <td class="form_left">
                <asp:Label ID="Label3" runat="server" Text="Title : "></asp:Label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Input Title" ControlToValidate="txttitle" ForeColor="Red"/>
                <asp:Textbox cssClass="form-control" ID="txttitle" runat="server"></asp:TextBox>
            </td>
            <td class="form_right">
                <asp:Label ID="Label10" runat="server" Text="HireDate :"></asp:Label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Input Hiredate" ControlToValidate="txtHireDate" ForeColor="Red"/>
                 <asp:Textbox cssClass="form-control" ID="txtHireDate" runat="server" />
                    <div>
                <img ID="CalendarPopUp" Class="img-rounded popup_icon" src="image/calendar.png" />
                <ajaxToolkit:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="txtHireDate" PopupButtonID="CalendarPopUp"/>
                   </div>
            </td>
        </tr>
        <tr>
            <td class="form_left">&nbsp;</td>
            <td class="form_right">&nbsp;</td>
        </tr>
        <tr>
            <td class="form_left">
                <asp:Label ID="Label4" runat="server" Text="Address : "></asp:Label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="Input Address" ControlToValidate="txtaddress" ForeColor="Red"/>
                <asp:Textbox cssClass="form-control" ID="txtaddress" runat="server"></asp:TextBox>
            </td>
            <td class="form_right">
                <asp:Label ID="Label11" runat="server" Text="Country : "></asp:Label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ErrorMessage="Input Country" ControlToValidate="txtcountry" ForeColor="Red"/>
                <asp:Textbox cssClass="form-control" ID="txtcountry" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="form_left">
                <asp:Label ID="Label5" runat="server" Text="City : "></asp:Label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ErrorMessage="Input City" ControlToValidate="txtcity" ForeColor="Red"/>
                <asp:Textbox cssClass="form-control" ID="txtcity" runat="server"></asp:TextBox>
            </td>
            <td class="form_right">
                <asp:Label ID="Label12" runat="server" Text="Phone :"></asp:Label>
                &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ErrorMessage="Input Phone" ControlToValidate="txtphone" ForeColor="Red"/>
                <asp:Textbox cssClass="form-control" ID="txtphone" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="form_left">
                <asp:Label ID="Label6" runat="server" Text="Region : "></asp:Label>
                <asp:Textbox cssClass="form-control" ID="txtregion" runat="server"></asp:TextBox>
            </td>
            <td class="form_right">
                <asp:Label ID="Label13" runat="server" Text="MrgId :"></asp:Label>
                <asp:Textbox cssClass="form-control" ID="txtmrgid" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="form_left">
                <asp:Label ID="Label7" runat="server" Text="PostalCode : "></asp:Label>
                <asp:Textbox cssClass="form-control" ID="txtpostal" runat="server"></asp:TextBox>
            </td>
            <td class="form_right">&nbsp;</td>
        </tr>
        <tr>
            <td class="form_left">&nbsp;</td>
            <td class="form_right">&nbsp;</td>
        </tr>
    </table>
</div>
<input ID="btnnew"  type="button"  Class="btn btn-default button"  Value="New" OnClick="newaction()" />
<asp:Button ID="btnadd" CssClass="btn btn-success button" runat="server" Text="Add" OnClick="btnadd_Click" />
<asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
    <AlternatingRowStyle BackColor="White" />
    <Columns>
        <asp:CommandField ShowSelectButton="True" />
        <asp:CommandField ButtonType="Button" ShowDeleteButton="True" />
    </Columns>
    <EditRowStyle BackColor="#2461BF" />
    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
    <RowStyle BackColor="#EFF3FB" />
    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
    <SortedAscendingCellStyle BackColor="#F5F7FB" />
    <SortedAscendingHeaderStyle BackColor="#6D95E1" />
    <SortedDescendingCellStyle BackColor="#E9EBEF" />
    <SortedDescendingHeaderStyle BackColor="#4870BE" />
</asp:GridView>
&nbsp;




    </div>
</asp:Content>
