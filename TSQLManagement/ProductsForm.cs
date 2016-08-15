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
    public partial class ProductsForm : Form
    {
        TSQLFundamentals2008Entities Entity = new TSQLFundamentals2008Entities();
        public ProductsForm()
        {
            InitializeComponent();

            dgvDataList.AutoSize = true;
            dgvDataList.MaximumSize = new Size(660, 255);
            this.AutoSize = true;

            loadProductInfo();
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void OrderDetailsForm_Load(object sender, EventArgs e)
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

                addProduct();

                loadProductInfo();

            }
            catch (Exception)
            {

            }
        }

        private void addProduct()
        {
            Product pro = new Product();

            pro.productname = txtProductName.Text;
            pro.supplierid = Int32.Parse(txtSupplierId.Text);
            pro.categoryid = Int32.Parse(txtCategoryId.Text);
            pro.unitprice = Decimal.Parse(txtUnitprice.Text);


            if (cbDiscon.Checked)
            {
                pro.discontinued = true;
            }
            else
            {
                pro.discontinued = false;
            }

            Entity.Products.Add(pro);
            Entity.SaveChanges();
        }

        bool validateInput()
        {


            string productname = txtProductName.Text;
            if (productname.Length == 0)
            {
                label8.Text = "pls enter you product name";
                txtProductName.Select();
                return true;
            }

            try
            {
                Int32 supplierid = Int32.Parse(txtSupplierId.Text);
            }
            catch (Exception)
            {
                label8.Text = "Supplier id is number !!";
                txtSupplierId.Select();
                return true;
            }


            try
            {
                Int32 categoryid = Int32.Parse(txtCategoryId.Text);
            }
            catch (Exception)
            {
                label8.Text = "Category Id is number !!!";
                txtCategoryId.Select();
                return true;
            }

            try
            {
                Decimal unitprice = Decimal.Parse(txtUnitprice.Text);
            }
            catch (Exception)
            {
                label8.Text = "Unitprice is number !!";
                txtUnitprice.Select();
                return true;
            }


            label8.Text = "";
            return true;
        }

        private void loadProductInfo()
        {

            dgvDataList.DataSource = Entity.Products.ToList();
            // dgvDataList.Columns[2].Visible = false;
            for (int i = 0; i < dgvDataList.Columns.Count; i++)
            {
                if (new String[] { "Category", "Supplier" }
                    .Contains(dgvDataList.Columns[i].HeaderText))
                {
                    dgvDataList.Columns[i].Visible = false;
                }
            }
        }

        private void dgvDataList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDataList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDataList.SelectedRows.Count > 0)
            {
                DataGridViewRow r = dgvDataList.SelectedRows[0];

                txtProductid.Text = r.Cells[0].Value.ToString();
                txtProductName.Text = r.Cells[1].Value.ToString();
                txtSupplierId.Text = r.Cells[2].Value.ToString();
                txtCategoryId.Text = r.Cells[3].Value.ToString();
                txtUnitprice.Text = r.Cells[4].Value.ToString();

                cbDiscon.Checked = (Boolean)r.Cells[5].Value;

            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtProductid.Text = "";
            txtProductName.Text = "";
            txtSupplierId.Text = "";
            txtCategoryId.Text = "";
            txtUnitprice.Text = "";
            if (cbDiscon.Checked)
            {
                cbDiscon.Checked = false;
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (validateInput() == false)
            {
                return;
            }
            try
            {
                updateProduct();
                MessageBox.Show("Update Thanh cong");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void updateProduct()
        {
            DataGridViewRow r = dgvDataList.SelectedRows[0];
            Product pro = null;
            foreach (Product p in Entity.Products)
            {
                if (p.productid == (Int32)r.Cells[0].Value)
                {
                    pro = p;
                    break;
                }
            }
            if (pro != null)
            {
                pro.productname = txtProductName.Text;
                pro.supplierid = Int32.Parse(txtSupplierId.Text);
                pro.categoryid = Int32.Parse(txtCategoryId.Text);
                pro.unitprice = Decimal.Parse(txtUnitprice.Text);
                if (cbDiscon.Checked)
                {
                    pro.discontinued = true;

                }
                else
                {
                    pro.discontinued = false;
                }
                Entity.SaveChanges();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteProduct();
            loadProductInfo();
        }

        private void deleteProduct()
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
                }
                catch (Exception)
                {

                    MessageBox.Show("can not delete");
                }
                Entity.SaveChanges();
            }
        }
    }
}
