using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TSQLWEB
{
    public partial class ShipperForm : System.Web.UI.Page
    {
        TSQLFundamentals2008Entities Entity = new TSQLFundamentals2008Entities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadShipperInfo();
            }
        }
        void LoadShipperInfo()
        {
            GridView1.DataSource = Entity.Shippers.ToList();
            GridView1.DataBind();
        }
        protected void btnNew_Click(object sender, EventArgs e)
        {
            txtCompanyName.Text = "";
            txtPhone.Text = "";
            btnAdd.Text = "Add";
            btnAdd.CssClass = "btn btn-success";
        }
        bool ValidateInput()
        {
            if (txtCompanyName.Text == "")
            {
                lblStatus.Text = "Invalid company name";

                return false;
            }

            if (txtPhone.Text == "")
            {
                lblStatus.Text = "Invalid phone";
                return false;
            }
            return true;
        }
        bool AddCategory()
        {
            try
            {
                Shipper shi = new Shipper();
                shi.companyname = txtCompanyName.Text;
                shi.phone = txtPhone.Text;
                Entity.Shippers.Add(shi);
                Entity.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
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
                                bool done = AddCategory();
                                LoadShipperInfo();
                                if (done)
                                {
                                    lblStatus.Text = "Added";
                                }
                                else
                                {
                                    lblStatus.Text = "Add Failed!";
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
                                bool result = updateCategory();
                                LoadShipperInfo();
                                if (result)
                                {
                                    lblStatus.Text = "Updated";
                                }
                                else
                                {
                                    lblStatus.Text = "Update Failed!";
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
        bool updateCategory()
        {

            GridViewRow r = GridView1.SelectedRow;
            Shipper shi = new Shipper();
            foreach (Shipper s in Entity.Shippers)
            {
                if (s.shipperid == int.Parse(r.Cells[1].Text))
                {
                    shi = s;
                    break;
                }
            }

            if (shi != null)
            {
                shi.companyname = txtCompanyName.Text;
                shi.phone = txtPhone.Text;

                Entity.SaveChanges();
                return true;
            }
            return false;
        }
        bool deleteShipper(GridViewDeleteEventArgs e)
        {

            GridViewRow r = GridView1.Rows[e.RowIndex];
            Shipper shi = new Shipper();
            foreach (Shipper s in Entity.Shippers)
            {
                if (s.shipperid == int.Parse(r.Cells[1].Text))
                {
                    shi = s;
                    break;
                }
            }
            try
            {
                Entity.Shippers.Remove(shi);
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

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            deleteShipper(e);
            LoadShipperInfo();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAdd.Text = "Update";
            btnAdd.CssClass = "btn btn-info";
            GridViewRow r = GridView1.SelectedRow;
            txtCompanyName.Text = r.Cells[2].Text;
            txtPhone.Text = r.Cells[3].Text;
        }

    }
}