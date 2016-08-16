using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TSQLManagement
{
    public partial class SupplierForm : System.Web.UI.Page
    {
        
        TSQLFundamentals2008Entities1 Entity = new TSQLFundamentals2008Entities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadSupInfo();
        }
        void LoadSupInfo()
        {
            GridView1.DataSource = Entity.Suppliers.ToList();
            GridView1.DataBind();
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
                            AddSup();
                            LoadSupInfo();
                            lblStatus.Text = "Adding successful";
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
                            lblStatus.Text = "Updating successful";
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
        bool ValidateInput()
        {
            if (txtCompanyName.Text == "")
            {
                lblStatus.Text = "Invalid company name";
              
                    return false;
            }

            if (txtContactName.Text == "")
            {
                lblStatus.Text = "Invalid contact name";
                return false;
            }

            if (txtContactTitle.Text == "")
            {
                lblStatus.Text = "Invalid contact title";
                return false;
            }
            if (txtAddress.Text == "")
            {
                lblStatus.Text = "Invalid Address";
                return false;
            }
            if (txtCity.Text == "")
            {
                lblStatus.Text = "Invalid City";
                return false;
            }
           
            if (txtPostalCode.Text == "")
            {
                lblStatus.Text = "Invalid Postal code";
                return false; 
            }
            if (txtPhone.Text == "")
            {
                lblStatus.Text = "Invalid phone";
                return false;
            }
            if (cbCountry.SelectedValue == "-1")
            {
                lblStatus.Text = "Invalid National";
                return false;
            }
            
            return true;
        }
        void AddSup()
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

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAdd.Text = "Update";
            GridViewRow r = GridView1.SelectedRow;
            txtCompanyName.Text = r.Cells[2].Text;
            txtContactName.Text = r.Cells[3].Text;
            txtContactTitle.Text = r.Cells[4].Text;
            txtAddress.Text = r.Cells[5].Text;
            txtCity.Text = r.Cells[6].Text;
            if (r.Cells[7].Text != null)
            {
                txtRegion.Text = r.Cells[7].Text;
            }

            else
            {
                txtRegion.Text = "";
            }
            txtPostalCode.Text = r.Cells[8].Text;
            cbCountry.Text = r.Cells[9].Text;
            txtPhone.Text = r.Cells[10].Text;

            if (r.Cells[11].Text != null)
            {
                txtFax.Text = r.Cells[11].Text;
            }

            else
            {
                txtFax.Text = "";
            }


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

      

    }
}