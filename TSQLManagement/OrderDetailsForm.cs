using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSQLManagement
{
    public partial class OrderDetailsForm : Form
    {
   //     decimal unitPrice  finish unitprice
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
            cbProductId_TextChanged(sender, e);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (validateInput() == false)
            {
                return;
            }

            try
            {
                addOrder();
                commend.Text = "Saved Successfully!";
                LoadOrderDetail();
            }
            catch (Exception)
            {

            }
        }
        private void addOrder()
        {

            Entity.OrderDetails.Add(CurrentDetail);
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
            dgvDataList.RowHeadersVisible = false;
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
                    switch (i)
                    {
                        case 0:
                            dgvDataList.Columns[i].HeaderText = "Order ID";
                            break;

                        case 1:
                            dgvDataList.Columns[i].HeaderText = "Product ID";
                            break;
                        case 2:
                            dgvDataList.Columns[i].HeaderText = "Unit Price";
                            break;
                        case 3:
                            dgvDataList.Columns[i].HeaderText = "Quantity";
                            break;
                        case 4:
                            dgvDataList.Columns[i].HeaderText = "Discount";
                            break;
                        default:
                            dgvDataList.Columns[i].Visible = false;
                            break;
                    }
                }
            }
            var BriefProducts = from Product in Entity.Products
                                where Product.productid == -1 && Product.discontinued == false
                                select Product;
            dgvProducts.DataSource = BriefProducts.ToList();
            dgvProducts.AutoSize = true;
            dgvProducts.MaximumSize = new Size(383, 101);

            for (int i = 0; i < dgvProducts.Columns.Count; i++)
            {
                switch (i)
                {
                    case 0:
                        dgvProducts.Columns[i].Width = 95;
                        dgvProducts.Columns[i].HeaderText = "Product ID";
                        break;

                    case 1:
                        dgvProducts.Columns[i].Width = 195;
                        dgvProducts.Columns[i].HeaderText = "Product Name";
                        break;
                    case 4:
                        dgvProducts.Columns[i].Width = 95;
                        dgvProducts.Columns[i].HeaderText = "Unit Price";
                        break;
                    default:
                        dgvProducts.Columns[i].Visible = false;
                        break;
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
            btnSave.Text = "Add";
            txtQuantity.Text = "";
            txtDiscount.Text = "";
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
            if (cbProductId.Focused)
            {

                if (string.IsNullOrEmpty(cbProductId.Text))
                {
                    var BriefProducts = from Product in Entity.Products
                                        where Product.discontinued == false
                                        select Product;
                    dgvProducts.DataSource = BriefProducts.ToList();

                }
                else
                {
                    int ProductID;
                    if (int.TryParse(cbProductId.Text, out ProductID))
                    {
                        var BriefProducts = from Product in Entity.Products
                                            where Product.productid == ProductID && Product.discontinued == false
                                            select Product;
                        dgvProducts.DataSource = BriefProducts.ToList();
                        dgvProducts.AutoSize = true;
                        dgvProducts.MaximumSize = new Size(383, 101);
                    }
                    for (int i = 0; i < dgvProducts.Columns.Count; i++)
                    {
                        switch (i)
                        {
                            case 0:
                                dgvProducts.Columns[i].Width = 95;
                                dgvProducts.Columns[i].HeaderText = "Product ID";
                                break;

                            case 1:
                                dgvProducts.Columns[i].Width = 195;
                                dgvProducts.Columns[i].HeaderText = "Product Name";
                                break;
                            case 4:
                                dgvProducts.Columns[i].Width = 95;
                                dgvProducts.Columns[i].HeaderText = "Unit Price";
                                break;
                            default:
                                dgvProducts.Columns[i].Visible = false;
                                break;
                        }
                    }
                }
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void commend_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void txtQuickProduct_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtQuickProduct.Text))
            {
                var BriefProducts = from Product in Entity.Products
                                    where Product.productname == txtQuickProduct.Text && Product.discontinued == false
                                    select Product;
                dgvProducts.DataSource = BriefProducts.ToList();

            }
            else
            {
                var BriefProducts = from Product in Entity.Products
                                    where Product.productname.Contains(txtQuickProduct.Text) && Product.discontinued == false
                                    select Product;
                dgvProducts.DataSource = BriefProducts.ToList();
                dgvProducts.AutoSize = true;
                dgvProducts.MaximumSize = new Size(383, 101);
                for (int i = 0; i < dgvProducts.Columns.Count; i++)
                {
                    switch (i)
                    {
                        case 0:
                            dgvProducts.Columns[i].HeaderText = "Product ID";
                            break;

                        case 1:
                            dgvProducts.Columns[i].HeaderText = "Product Name";
                            break;
                        case 4:
                            dgvProducts.Columns[i].HeaderText = "Unit Price";
                            break;
                        default:
                            dgvProducts.Columns[i].Visible = false;
                            break;
                    }
                }
            }
        }

        private void dgvProducts_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dgvDataList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSave.Text = "Update";
            if (dgvDataList.SelectedRows.Count > 0)
            {
                DataGridViewRow dr = dgvDataList.SelectedRows[0];
                cbOrderId.Text = dr.Cells[0].Value.ToString();
                cbProductId.Text = dr.Cells[1].Value.ToString();
                txtQuantity.Text = dr.Cells[3].Value.ToString();
                txtDiscount.Text = dr.Cells[4].Value.ToString();
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            short Quantity;
            if (short.TryParse(txtQuantity.Text, out Quantity))
            {
                txtQuantity.ForeColor = Color.Black;
                CurrentDetail.qty = Quantity;

            } else
            {
                txtQuantity.ForeColor = Color.Red;
            }
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            decimal Discount;
            if (decimal.TryParse(txtDiscount.Text, out Discount))
            {
                txtDiscount.ForeColor = Color.Black;
                CurrentDetail.discount = Discount;
            }
            else
            {
                txtDiscount.ForeColor = Color.Red;
            }
        }
    }
}
