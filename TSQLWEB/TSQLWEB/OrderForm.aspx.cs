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

    }
}