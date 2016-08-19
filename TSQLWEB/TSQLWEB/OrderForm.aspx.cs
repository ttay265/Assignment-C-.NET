using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TSQLWEB
{
    public partial class OrderForm : System.Web.UI.Page
    {
        TSQLFundamentals2008Entities entities = new TSQLFundamentals2008Entities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                LoadOrderInfo();
            }
        }

        void LoadOrderInfo()
        {
            GridView1.DataSource = entities.Orders.ToList();
            GridView1.DataBind();
        }
        protected void btnnew_Click(object sender, EventArgs e)
        {
            cbCustomer.Text = "";
            cbEmployeeID.Text = "";
            txtOrderDate.Text = "";
            txtReqiredDate.Text = "";
            txtShippedDate.Text = "";
            cbShipperID.Text = "";
            txtFreight.Text = "";
            txtShipperName.Text = "";
            txtShipAddress.Text = "";
            txtShipCity.Text = "";
            txtShipRegion.Text = "";
            txtShipPostalCode.Text = "";
            cbShipCountry.Text = "";
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow SelectedRow = GridView1.SelectedRow;
            cbCustomer.Text = SelectedRow.Cells[2].Text;
            cbCustomer.Text = SelectedRow.Cells[3].Text;
            txtOrderDate.Text = SelectedRow.Cells[4].Text;
        }
        void AlertSuccess(string progress)
        {
            Response.Write("<script language='javascript'>alert('Successful!" + progress + "')</script>");
        }

        void AlertFailed(string error)
        {
            Response.Write("<script language='javascript'>alert('Failed! " + error + " ')</script>");
        }
        
        bool addOrder() {

        }

        bool updateOrder()
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {

            switch (btnAdd.Text)
            {
                case "Add":
                    {
                        try
                        {
                            bool done = addOrder();
                            LoadOrderInfo();
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
                            bool result = updateOrder();
                            LoadOrderInfo();
                            if (result)
                            {
                                AlertSuccess("Updated");
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

    }
}