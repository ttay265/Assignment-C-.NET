using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TSQLWEB
{
    public partial class SupplierForm : System.Web.UI.Page
    {
        TSQLFundamentals2008Entities Entity = new TSQLFundamentals2008Entities();
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("<script language='javascript'>$('#alert').alert('close')</script>");
            if (!IsPostBack)
            {
                LoadSupInfo();
            }
        }
        void LoadSupInfo()
        {
            GridView1.DataSource = Entity.Suppliers.ToList();
            GridView1.DataBind();
        }

        protected void btnNew_Click(object sender, EventArgs e)
        {

            txtCompanyName.Text = "";
            txtContactName.Text = "";
            txtContactTitle.Text = "";
            cbCountry.SelectedIndex = -1;
            txtPhone.Text = "";
            txtRegion.Text = "";
            txtPostalCode.Text = "";
            txtFax.Text = "";
            txtAddress.Text = "";
            txtCity.Text = "";
            btnAdd.Text = "Add";
            btnAdd.CssClass = "btn btn-success";
        }
        bool ValidateInput()
        {
            if (txtCompanyName.Text == "")
            {
                AlertFailed("Invalid company name");

                return false;
            }

            if (txtContactName.Text == "")
            {
                AlertFailed("Invalid contact name");
                return false;
            }

            if (txtContactTitle.Text == "")
            {
                AlertFailed("Invalid contact title");
                return false;
            }
            if (txtAddress.Text == "")
            {
                AlertFailed("Invalid Address");
                return false;
            }
            if (txtCity.Text == "")
            {
                AlertFailed("Invalid City");
                return false;
            }

            if (txtPostalCode.Text == "")
            {
                AlertFailed("Invalid Postal code");
                return false;
            }
            if (txtPhone.Text == "")
            {
                AlertFailed("Invalid phone");
                return false;
            }
            if (cbCountry.SelectedValue == "-1")
            {
                AlertFailed("Invalid National");
                return false;
            }

            return true;
        }

        bool AddSup()
        {
            try
            {
                Supplier sup = new Supplier();
                sup.companyname = txtCompanyName.Text;
                sup.contactname = txtContactName.Text;
                sup.contacttitle = txtContactTitle.Text;
                sup.country = cbCountry.Text;
                sup.phone = txtPhone.Text;
                sup.region = txtRegion.Text;
                sup.postalcode = txtPostalCode.Text;
                sup.fax = txtFax.Text;
                sup.address = txtAddress.Text;
                sup.city = txtCity.Text;
                Entity.Suppliers.Add(sup);
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
            //Alert.Visible = true;
            //Alert.CssClass="alert alert-success";
            //lblStrong.Text = "Success!fully!";
            Response.Write("<script language='javascript'>$('#alert').alert()</script>");
        }

        void AlertFailed(string error)
        {
            //Alert.Visible = true;
            //Alert.CssClass = "alert alert-danger";
            //lblStrong.Text = "Failed!";
            //lblMessage.Text = error + " !";
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
                                bool done = AddSup();
                                LoadSupInfo();
                                if (done)
                                {
                                    AlertSuccess("Added");
                                }
                                else
                                {
                                    AlertFailed("Add Failed!");
                                }

                            }
                            catch (Exception)
                            {
                            }
                            break;
                        }
                    case "Update":
                        {
                            try
                            {
                                bool result = updateSup();
                                LoadSupInfo();
                                if (result)
                                {
                                    AlertSuccess("Updating");
                                }
                                else
                                {
                                    AlertFailed("Update Failed!");
                                }
                            }
                            catch (Exception)
                            {
                                string msgScript = "<script>alert('Update failed');</script>";
                                Response.Write(msgScript);
                            }

                            break;
                        }
                    default:
                        break;
                }
            }
            else
            {
                //string msgScript = "<script>alert('Invalid Input');</script>";
                //Response.Write(msgScript);
                return;
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAdd.Text = "Update";
            btnAdd.CssClass = "btn btn-info";
            GridViewRow r = GridView1.SelectedRow;
            txtCompanyName.Text = r.Cells[2].Text;
            txtContactName.Text = r.Cells[3].Text;
            txtContactTitle.Text = r.Cells[4].Text;
            txtAddress.Text = r.Cells[5].Text;
            txtCity.Text = r.Cells[6].Text;
            if (r.Cells[7].Text != "&nbsp;")
            {
                txtRegion.Text = r.Cells[7].Text;
                txtRegion.Text.Trim();
            }

            else
            {
                txtRegion.Text = "";
            }
            txtPostalCode.Text = r.Cells[8].Text;
            cbCountry.Text = r.Cells[9].Text;
            txtPhone.Text = r.Cells[10].Text;

            if (r.Cells[11].Text != "&nbsp;")
            {
                txtFax.Text = r.Cells[11].Text;
            }

            else
            {
                txtFax.Text = String.Empty;
            }

        }

        bool updateSup()
        {

            GridViewRow r = GridView1.SelectedRow;
            Supplier sup = new Supplier();
            foreach (Supplier e in Entity.Suppliers)
            {
                if (e.supplierid == int.Parse(r.Cells[1].Text))
                {
                    sup = e;
                    break;
                }
            }

            if (sup != null)
            {
                sup.companyname = txtCompanyName.Text;
                sup.contactname = txtContactName.Text;
                sup.contacttitle = txtContactTitle.Text;
                sup.country = cbCountry.Text;
                sup.phone = txtPhone.Text;
                sup.region = txtRegion.Text;
                sup.postalcode = txtPostalCode.Text;
                sup.fax = txtFax.Text;
                sup.address = txtAddress.Text;
                sup.city = txtCity.Text;

                Entity.SaveChanges();
                return true;
            }
            return false;
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            deleteSup(e);
            LoadSupInfo();
        }
        bool deleteSup(GridViewDeleteEventArgs e)
        {

            GridViewRow r = GridView1.Rows[e.RowIndex];
            Supplier sup = new Supplier();
            foreach (Supplier SupLo in Entity.Suppliers)
            {
                if (SupLo.supplierid == int.Parse(r.Cells[1].Text))
                {
                    sup = SupLo;
                    break;
                }
            }
            try
            {
                Entity.Suppliers.Remove(sup);
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