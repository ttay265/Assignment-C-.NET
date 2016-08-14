using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSQLManagement
{
    public partial class OrderDetailsForm : Form
    {
        TSQLFundamentals2008Entities Entity = new TSQLFundamentals2008Entities();
        public OrderDetailsForm()
        {
            InitializeComponent();
            loadCombox();

        }
        void loadCombox()
        {
            cbOrderId.DataSource = Entity.Orders.ToList();
            cbOrderId.DisplayMember = "orderid";

            cbProductId.DataSource = Entity.Products.ToList();
            cbProductId.DisplayMember= "productid";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbProductId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void cbOrderId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {

        }
    }
}
