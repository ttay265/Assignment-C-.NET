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
            dgvDataList.MaximumSize = new Size(660, 300);
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
                MessageBox.Show("Add Thanh cong");

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
            pro.unitprice = Int32.Parse(txtUnitprice.Text);
            if (cbDiscon.Checked)
            {
                pro.discontinued = true;
            }
            else
            {
                pro.discontinued = false;
            }

        }

        bool validateInput()
        {
            bool bError = false;

            String productname = txtProductName.Text;
            if (productname.Length== 0)
            {
                error.Text = "pls enter you product name";
                txtProductName.Select();
                bError = true;
            }

            try
            {
                int supplierid = Int32.Parse(txtSupplierId.Text);
            }
            catch (Exception)
            {
                error.Text = "Supplier id is number !!";
                txtSupplierId.Select();
                bError = true;
            }

            try
            {
                int categoryid = Int32.Parse(txtCategoryId.Text);
            }
            catch (Exception)
            {
                error.Text = "Category Id is number !!!";
                txtCategoryId.Select();
                bError = true;
            }

            try
            {
                Decimal unitprice = Decimal.Parse(txtUnitprice.Text);
            }
            catch (Exception)
            {
                error.Text = "Unitprice is number !!";
                txtUnitprice.Select();
                bError = true;
            }


            if (bError == true)
            {
                return false;

            }
            else
            {
                error.Text = "";

            }
            return true;
        }

        private void loadProductInfo()
        {
            
            dgvDataList.DataSource = Entity.Products.ToList();
           // dgvDataList.Columns[2].Visible = false;
            for (int i = 0; i < dgvDataList.Columns.Count; i++)
            {
                if (new String []{"Category","Supplier"}
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
            if (dgvDataList.SelectedRows.Count>0)
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
            if (validateInput()== false)
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
                if (p.productid== (int)r.Cells[0].Value)
                {
                    pro = p;
                    break;
                }
            }
            if (pro!=null)
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
        }

        private void deleteProduct()
        {
            if (dgvDataList.SelectedRows.Count>0)
            {
                DataGridViewRow dr = dgvDataList.SelectedRows[0];
                Product pro = null;
                foreach (Product p in Entity.Products)
                {
                    if (p.productid == (int)dr.Cells[0].Value)
                    {
                        pro = p;
                        break;
                    }
                }
                Entity.Products.Remove(pro);
                Entity.SaveChanges();
            }
        }
    }
}
