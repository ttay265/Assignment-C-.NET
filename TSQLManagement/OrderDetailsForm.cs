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
        int InitOderId = -1;
        OrderDetail CurrentDetail = new OrderDetail();
        TSQLFundamentals2008Entities Entity = new TSQLFundamentals2008Entities();
        public OrderDetailsForm()
        {
            InitializeComponent();
            LoadCombobox();
            LoadOrderDetail();
            dgvDataList.AutoSize = true;
            dgvDataList.MaximumSize = new Size(660, 255);
            this.AutoSize = true;
        }
        public OrderDetailsForm(int OrderID)
        {
            InitOderId = OrderID;
            InitializeComponent();
            LoadOrderDetail();
            dgvDataList.AutoSize = true;
            dgvDataList.MaximumSize = new Size(660, 255);
            this.AutoSize = true;
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
            if (validateInput() == false)
            {
                return;
            }

            try
            {
                addOrder();
                commend.Text = "add successfully !!!!";
                LoadOrderDetail();
            }
            catch (Exception)
            {

            }
        }
        private void addOrder()
        {
            OrderDetail od = new OrderDetail();
            od.orderid = Int32.Parse(cbOrderId.Text);
            od.productid = Int32.Parse(cbProductId.Text);
            od.qty = Int16.Parse(txtQuantity.Text);
            od.discount = Decimal.Parse(txtDiscount.Text);

            Entity.OrderDetails.Add(od);
            Entity.SaveChanges();
        }
        void LoadCombobox()
        {
            var OrderIDs = from OrderDetail in Entity.OrderDetails
                           select OrderDetail.orderid;
            OrderIDs = OrderIDs.Distinct();
            List<int> OrderIDList = OrderIDs.ToList();
            cbOrderId.DataSource = OrderIDList;
            cbOrderId.Text = OrderIDList[0].ToString();
            if (InitOderId > -1)
            {
                cbOrderId.SelectedValue = InitOderId;
            }
        }

        private void LoadOrderDetail()
        {
            List<OrderDetail> OrderDetailList = new List<OrderDetail>();
            int OrderID;
            if (int.TryParse(cbOrderId.Text, out OrderID))
            {
                var OrderDetails = from OrderDetail in Entity.OrderDetails
                                   where OrderDetail.orderid == OrderID
                                   select OrderDetail;
                foreach (var OrderDetailItem in OrderDetails)
                {
                    OrderDetailList.Add(OrderDetailItem);
                }
                dgvDataList.DataSource = OrderDetailList;
                var productIDs = from Product in Entity.Products
                                 select Product.productid;

                cbProductId.DataSource = productIDs.ToList();
                for (int i = 0; i < dgvDataList.Columns.Count; i++)
                {
                    if (new String[] { "Product", "Order" }
                        .Contains(dgvDataList.Columns[i].HeaderText))
                    {
                        dgvDataList.Columns[i].Visible = false;
                    }
                }
            }


        }

        private bool validateInput()
        {
            if (cbOrderId.Text == "")
            {
                error.Text = "Order id not null !!!";
                return true;
            }

            if (cbProductId.Text == "")
            {
                error.Text = "Product id not null !!!";
                return true;
            }

            try
            {
            }
            catch (Exception)
            {
                error.Text = "unitprice is number !!!!";
                return true;
            }

            try
            {
                Int16 quatity = Int16.Parse(txtQuantity.Text);

            }
            catch (Exception)
            {
                error.Text = "quantity is number !!! ";
                txtQuantity.Select();
                return true;
            }

            try
            {
                Decimal discount = Decimal.Parse(txtDiscount.Text);
            }
            catch (Exception)
            {
                error.Text = "discount is number !!!!";
                txtDiscount.Select();
                return true;
            }

            error.Text = "";
            return true;
        }

        private void cbOrderId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtQuantity.Text = "";
            txtDiscount.Text = "";
            cbOrderId.Text = "";
            cbProductId.Text = "";

        }

        private void OrderDetailsForm_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (validateInput() == false)
            {
                return;
            }

            try
            {
                updateOrderDetails();
                commend.Text = "update thanh cong";
                LoadOrderDetail();
            }
            catch (Exception)
            {
            }
        }

        private void updateOrderDetails()
        {

            DataGridViewRow dr = dgvDataList.SelectedRows[0];
            OrderDetail od = null;
            foreach (OrderDetail o in Entity.OrderDetails)
            {
                if (o.productid == (int)dr.Cells[0].Value)
                {
                    od = o;
                    break;

                }
            }
            if (od != null)
            {
                od.orderid = Int32.Parse(cbOrderId.Text);
                od.productid = Int32.Parse(cbProductId.Text);
                od.qty = Int16.Parse(txtQuantity.Text);
                od.discount = Decimal.Parse(txtDiscount.Text);

                Entity.SaveChanges();

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteOrderDetails();
            commend.Text = "delete thanh cong";
            LoadOrderDetail();
        }

        private void deleteOrderDetails()
        {
            if (dgvDataList.SelectedRows.Count > 0)
            {
                DataGridViewRow dr = dgvDataList.SelectedRows[0];
                Product pro = null;
                foreach (Product p in Entity.Products)
                {
                    if (p.productid == (Int32)dr.Cells[0].Value)
                    {
                        pro = p;
                        break;
                    }
                }

                try
                {
                    Entity.Products.Remove(pro);
                    Entity.SaveChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("can not delete order");

                }

            }
        }

        private void dgvDataList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDataList.SelectedRows.Count > 0)
            {
                DataGridViewRow dr = dgvDataList.SelectedRows[0];
                cbOrderId.Text = dr.Cells[0].Value.ToString();
                cbProductId.Text = dr.Cells[1].Value.ToString();
                txtQuantity.Text = dr.Cells[3].Value.ToString();
                txtDiscount.Text = dr.Cells[4].Value.ToString();


            }
        }

        private void cbOrderId_TextChanged(object sender, EventArgs e)
        {
            LoadOrderDetail();
            if (!string.IsNullOrEmpty(cbOrderId.Text))
            {
                int OrderID;
                if (int.TryParse(cbOrderId.Text, out OrderID))
                {
                    if (((List<int>)cbOrderId.DataSource).Contains(OrderID))
                    {
                        cbOrderId.ForeColor = Color.Black;
                        CurrentDetail.orderid = OrderID;
                        return;
                    }
                }
            }
            cbOrderId.ForeColor = Color.Red;
        }

        private void cbProductId_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbProductId.Text))
            {
                var BriefProducts = from Product in Entity.Products
                                    select Product;
                dgvProducts.DataSource = BriefProducts.ToList();

            }
            else
            {
                int ProductID;
                if (int.TryParse(cbProductId.Text, out ProductID))
                {
                    var BriefProducts = from Product in Entity.Products
                                        where Product.productid == ProductID
                                        select Product;
                    dgvProducts.DataSource = BriefProducts.ToList();
                        for (int i = 0; i < dgvProducts.Columns.Count; i++)
                {
                    if (new String[] { "Product ID", "Order" }
                        .Contains(dgvDataList.Columns[i].HeaderText))
                    {
                        dgvDataList.Columns[i].Visible = false;
                    }
                }
                }
            }

        }


    }
}
