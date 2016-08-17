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
        int InitOderId = -1;
        OrderDetail CurrentDetail = new OrderDetail();
        TSQLFundamentals2008Entities Entity = new TSQLFundamentals2008Entities();
        public OrderDetailsForm()
        {

            InitializeComponent();
            LoadCombobox();
            LoadOrderDetail();
            MessageBox.Show(cbProductId.Text);
            CurrentDetail.orderid = int.Parse(cbOrderId.Text);
            dgvDataList.AutoSize = true;
            dgvDataList.MaximumSize = new Size(660, 255);
            this.AutoSize = true;
        }
        public OrderDetailsForm(int OrderID)
        {
            InitOderId = OrderID;
            InitializeComponent();
            CurrentDetail.orderid = OrderID;
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
            if (btnSave.Text == "Add")
            {
                addOrder();
                commend.Text = "Saved Successfully!";
                LoadOrderDetail();
            }
            else
            {
                updateOrderDetails();
            }
            LoadOrderDetail();
        }
        private void addOrder()
        {
            foreach (OrderDetail detail in ((List<OrderDetail>)dgvDataList.DataSource))
            {
                if (detail.productid == CurrentDetail.Product.productid)
                {
                    detail.qty += short.Parse(txtQuantity.Text);
                    Entity.SaveChanges();
                    return;
                }
            }
            OrderDetail NewDetail = new OrderDetail();
            NewDetail.orderid = int.Parse(cbOrderId.Text);
            NewDetail.productid = CurrentDetail.Product.productid;
            NewDetail.unitprice = CurrentDetail.Product.unitprice;
            NewDetail.qty = short.Parse(txtQuantity.Text);
            NewDetail.discount = Decimal.Parse(txtDiscount.Text) / 100;
            Entity.OrderDetails.Add(NewDetail);
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
            if (cbOrderId.Text == "" || cbOrderId.ForeColor == Color.Red)
            {
                lblError.Text = "Order Invalid!!!";
                return false;
            }
            if (CurrentDetail.Product == null || string.IsNullOrEmpty(CurrentDetail.Product.productname))
            {
                lblError.Text = "Product Invalid!!!";
                return false;
            }

            if (cbProductId.Text == "" || cbProductId.ForeColor == Color.Red)
            {
                lblError.Text = "Product Invalid!!!";
                return false;
            }
            if (txtQuantity.ForeColor == Color.Red)
            {
                lblError.Text = "Quantity Invalid!!!";
                return false;
            }
            if (txtDiscount.ForeColor == Color.Red)
            {
                lblError.Text = "Quantity Invalid!!!";
                return false;
            }
            lblError.Text = "";
            return true;
        }

        private void cbOrderId_SelectedIndexChanged(object sender, EventArgs e)
        {
            int OrderID;
            if (int.TryParse(cbOrderId.Text, out OrderID))
            {
                CurrentDetail.orderid = OrderID;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Text = "Add";
            txtQuantity.Text = "1";
            txtDiscount.Text = "00";
            cbProductId.SelectedIndex = 1;
            txtQuickProduct.Enabled = true;
            cbProductId.Enabled = true;
        }

        private void OrderDetailsForm_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
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
            OrderDetail OrderDetail = new OrderDetail();
            foreach (OrderDetail o in Entity.OrderDetails)
            {
                if (o.productid == (int)dr.Cells[1].Value && o.orderid == (int)dr.Cells[0].Value)
                {
                    OrderDetail = o;
                    break;
                }
            }
            if (OrderDetail != null)
            {
                OrderDetail.orderid = Int32.Parse(cbOrderId.Text);
                OrderDetail.productid = Int32.Parse(cbProductId.Text);
                OrderDetail.qty = Int16.Parse(txtQuantity.Text);
                OrderDetail.discount = Decimal.Parse(txtDiscount.Text) / 100;
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
                foreach (OrderDetail de in Entity.OrderDetails)
                {
                    if (de.orderid == int.Parse(cbOrderId.Text) && de.productid == (int)dr.Cells[1].Value)
                    {
                        try
                        {
                            Entity.OrderDetails.Remove(de);
                            Entity.SaveChanges();
                            commend.Text = "Delete successfully!";
                            return;
                        }
                        catch (Exception)
                        {
                            lblError.Text = "Delete Failed!";
                            return;
                        }
                    }
                }
            }
        }

        private void dgvDataList_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void cbOrderId_TextChanged(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(cbOrderId.Text))
            {
                LoadOrderDetail();
                int OrderID;
                if (int.TryParse(cbOrderId.Text, out OrderID))
                {
                    cbOrderId.DropDownStyle = ComboBoxStyle.DropDown;
                    cbOrderId.ForeColor = Color.Black;
                    if (((List<int>)cbOrderId.DataSource).Contains(OrderID))
                    {
                        cbOrderId.ForeColor = Color.Black;
                        CurrentDetail.orderid = OrderID;
                        return;
                    }
                }
                else
                {
                    cbOrderId.DropDownStyle = ComboBoxStyle.Simple;
                    cbOrderId.ForeColor = Color.Red;
                }
            }
            else
            {
                cbOrderId.DropDownStyle = ComboBoxStyle.DropDown;
                cbOrderId.ForeColor = Color.Black;
            }
        }

        private void cbProductId_TextChanged(object sender, EventArgs e)
        {
            if (cbProductId.Focused)
            {
                if (string.IsNullOrEmpty(cbProductId.Text))
                {
                    cbProductId.DropDownStyle = ComboBoxStyle.DropDown;
                    cbProductId.ForeColor = Color.Black;
                }
                else
                {
                    int ProductID;
                    if (int.TryParse(cbProductId.Text, out ProductID))
                    {
                        cbProductId.DropDownStyle = ComboBoxStyle.DropDown;
                        cbProductId.ForeColor = Color.Black;
                        var BriefProducts = from Product in Entity.Products
                                            where Product.productid == ProductID && Product.discontinued == false
                                            select Product;
                        if (BriefProducts.ToList().Count > 0)
                        {
                            dgvProducts.DataSource = BriefProducts.ToList();
                            dgvProducts.AutoSize = true;
                            dgvProducts.MaximumSize = new Size(383, 101);
                            cbProductId.DropDownStyle = ComboBoxStyle.DropDown;
                            cbProductId.ForeColor = Color.Black;
                        }
                        else
                        {
                            cbProductId.DropDownStyle = ComboBoxStyle.Simple;
                            cbProductId.ForeColor = Color.Red;
                        }

                    }
                    else
                    {
                        cbProductId.DropDownStyle = ComboBoxStyle.Simple;
                        cbProductId.ForeColor = Color.Red;
                    }
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
            txtQuantity.Text = "1";
            int SelectedRowsCount = dgvProducts.SelectedRows.Count;
            dgvProducts.MultiSelect = false;
            if (SelectedRowsCount > 0)
            {
                int productid = (int)dgvProducts.SelectedRows[0].Cells[0].Value;
                CurrentDetail.Product = Entity.Products.Find(productid);
                cbProductId.Text = productid.ToString();
            }
        }

        private void dgvDataList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtQuickProduct.Enabled = false;
            cbProductId.Enabled = false;
            btnSave.Text = "Update";
            if (dgvDataList.SelectedRows.Count > 0)
            {
                DataGridViewRow dr = dgvDataList.SelectedRows[0];
                cbOrderId.Text = dr.Cells[0].Value.ToString();
                cbProductId.Text = dr.Cells[1].Value.ToString();
                txtQuantity.Text = dr.Cells[3].Value.ToString();
                decimal a = ((decimal)dr.Cells[4].Value) * 100;
                txtDiscount.Text = ((int)a).ToString();
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            short Quantity;
            if (short.TryParse(txtQuantity.Text, out Quantity))
            {
                txtQuantity.ForeColor = Color.Black;
                CurrentDetail.qty = Quantity;

            }
            else
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

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvProducts_SelectionChanged(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            short quantity = 0;
            if (short.TryParse(txtQuantity.Text, out quantity) && quantity > 1)
            {
                quantity--;
                txtQuantity.Text = quantity.ToString();
                CurrentDetail.qty = quantity;
            }
            else
            {
                txtQuantity.Text = "1";
                CurrentDetail.qty = 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            short quantity;
            if (short.TryParse(txtQuantity.Text, out quantity))
            {
                quantity++;
                txtQuantity.Text = quantity.ToString();
                CurrentDetail.qty = quantity;
            }
            else
            {
                txtQuantity.Text = "1";
                CurrentDetail.qty = 1;
            }
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbOrderId_DropDown(object sender, EventArgs e)
        {
            //////cbOrderId.ForeColor = Color.Black;
        }

        private void cbProductId_DropDown(object sender, EventArgs e)
        {
            cbProductId.ForeColor = Color.Black;

        }
    }
}
