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
            txtReqiredDate.Text 
        }

    }
}