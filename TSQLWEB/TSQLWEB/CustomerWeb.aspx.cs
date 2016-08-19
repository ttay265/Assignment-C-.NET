using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TSQLWEB
{
    public partial class CustomerWeb : System.Web.UI.Page
    {
        TSQLFundamentals2008Entities Entity = new TSQLFundamentals2008Entities();
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("<script language='javascript'>$('#alert').alert('close')</script>");
            if (!IsPostBack)
            {
                LoadCustomerInfo();
            }
        }
        void LoadCustomerInfo()
        {
            dgvDataList.DataSource = Entity.Customers.ToList();
            dgvDataList.DataBind();
        }
        protected void btnNew_Click(object sender, EventArgs e)
        {
            txtCompanyName.Text = "";
            txtContactName.Text = "";
            txtContactTitle.Text = "";
            txtAddress.Text = "";
            txtCity.Text = "";
            txtRegion.Text = "";
            txtPostalCode.Text = "";
            txtCountry.Text = "";
            txtPhone.Text = "";
            txtFax.Text = "";
            btnAdd.Text = "Add";
            btnAdd.CssClass = "btn btn-success";

        }
        bool ValidateInput()
        {
            if(txtCompanyName.Text == "")
            {
                AlertFail("Invalid company name");
                return false;
            }
            if(txtContactName.Text=="")
            {
                AlertFail("Invalid contact name");
                return false;
            }
            if(txtContactTitle.Text=="")
            {
                AlertFail("Invalid contact tittle");
                return false;
            }
            if(txtAddress.Text=="")
            {
                AlertFail("Invalid Address");
                return false;
            }
            if(txtCity.Text=="")
            {
                AlertFail("Invalid City");
                return false;
            }
            if(txtRegion.Text=="")
            {
                AlertFail("Invalid Region");
                return false;
            }
            if(txtPostalCode.Text=="")
            {
                AlertFail("Invalid Postal Code");
                return false;
            }
            if(txtCountry.Text=="")
            {
                AlertFail("Invalid Country");
                return false;
            }
            if(txtPhone.Text=="")
            {
                AlertFail("Invalid phone");
                return false;
            }
            if(txtFax.Text=="")
            {
                AlertFail("Invalid phone");
                return false;
            }
            return true;
        }
        bool AddCus()
        {
            try
            {
                Customer cus = new Customer();
                cus.companyname = txtCompanyName.Text;
                cus.contactname = txtContactName.Text;
                cus.contacttitle = txtContactTitle.Text;
                cus.address = txtAddress.Text;
                cus.city = txtCity.Text;
                cus.region = txtRegion.Text;
                cus.postalcode = txtPostalCode.Text;
                cus.country = txtCountry.Text;
                cus.phone = txtPhone.Text;
                cus.fax = txtFax.Text;
                Entity.Customers.Add(cus);
                Entity.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        void AlertSuccess(string progress)
        {
            Response.Write("<script language='javascript'>$('#alert').alert()</script>");
        }
        void AlertFail(string error)
        {
            Response.Write("<script language='javascript'>alert('Failed! " + error + " ')</script>");
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                switch (btnAdd.Text)
                {
                    case "Add":
                        {
                            try
                            {
                                bool done = AddCus();
                                LoadCustomerInfo();
                                if(done)
                                {
                                    AlertSuccess("Add");
                                }
                                else
                                {
                                    AlertFail("Add Faild");
                                }
                            }
                            catch(Exception)
                            {

                            }
                            break;
                        }
                    case "Update":
                            {
                                try
                                {
                                    bool result = updateCus();
                                    LoadCustomerInfo();
                                    if(result)
                                    {
                                        AlertSuccess("Updating");
                                    }else
                                    {
                                        AlertFail("Update Fail");
                                    }
                                }
                                catch (Exception)
                                {
                                    string mgsScript = "<script>alert('Update failed');</script>";
                                    Response.Write(mgsScript);
                                }
                                break;
                            }
                    default:
                        break;
                }
            }
            else
            {
                return;
            }
        }

        protected void dgvDataList_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAdd.Text = "Update";
            btnAdd.CssClass = "btn btn-info";
            GridViewRow r = dgvDataList.SelectedRow;
            txtCompanyName.Text = Server.HtmlDecode(r.Cells[2].Text);
            txtContactName.Text = Server.HtmlDecode(r.Cells[3].Text);
            txtContactTitle.Text = Server.HtmlDecode(r.Cells[4].Text);
            txtAddress.Text = Server.HtmlDecode(r.Cells[5].Text);
            txtCity.Text = Server.HtmlDecode(r.Cells[6].Text);
            txtRegion.Text = Server.HtmlDecode(r.Cells[7].Text);
            txtPostalCode.Text = Server.HtmlDecode(r.Cells[8].Text);
            txtCountry.Text = Server.HtmlDecode(r.Cells[9].Text);
            txtPhone.Text = Server.HtmlDecode(r.Cells[10].Text);
            txtFax.Text = Server.HtmlDecode(r.Cells[11].Text);
        }
        bool updateCus()
        {
            GridViewRow r = dgvDataList.SelectedRow;
            Customer cus = new Customer();
            foreach (Customer c in Entity.Customers)
            {
                if (c.custid == int.Parse(r.Cells[1].Text))
                {
                    cus = c;
                    break;
                }
            }
            if (cus != null)
            {
                cus.companyname = txtCompanyName.Text;
                cus.contactname= txtContactName.Text;
                cus.contacttitle=txtContactTitle.Text;
                cus.address= txtAddress.Text;
                cus.city=txtCity.Text;
                cus.region=txtRegion.Text;
                cus.postalcode=txtPostalCode.Text;
                cus.country=txtCountry.Text;
                cus.phone=txtPhone.Text;
                cus.fax=txtFax.Text;
                Entity.SaveChanges();
                return true;
            }
            return false;
        }

        protected void dgvDataList_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            deleteCus(e);
            LoadCustomerInfo();
        }
        bool deleteCus(GridViewDeleteEventArgs e)
        {
            GridViewRow r = dgvDataList.Rows[e.RowIndex];
            Customer cus = new Customer();
            foreach (Customer Custo in Entity.Customers)
            {
                if(Custo.custid == int.Parse(r.Cells[1].Text))
                {
                    cus = Custo;
                    break;
                }
                
            }try
            {
                Entity.Customers.Remove(cus);
                Entity.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                string msgScript = "<script>alert('Can't delete this people');</script>";
                Response.Write(msgScript);
                return false;
            }
        }

    }
}