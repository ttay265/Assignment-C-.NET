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

    public partial class OrderForm : Form
    {
        TSQLFundamentals2008Entities entities = new TSQLFundamentals2008Entities();
        public OrderForm()
        {
            InitializeComponent();
            var CustomerIDs = from Customer in entities.Customers
                              select Customer.custid;
            List<int> CustomerIDList = new List<int>();
            foreach (var x in CustomerIDs)
            {
                CustomerIDList.Add(x);
            }
            CustomerIDList.Sort();
            cbCustomerID.DataSource = CustomerIDList;
            cbCustomerID.SelectedIndex = -1;
            var EmployeeIDs = from Employee in entities.Employees
                              select Employee.empid;
            List<int> EmployeeIDList = new List<int>();
            foreach (var x in CustomerIDs)
            {
                EmployeeIDList.Add(x);
            }
            EmployeeIDList.Sort();
            cbEmployeeID.DataSource = EmployeeIDList;
            cbEmployeeID.SelectedIndex = -1;
            dgvDataList.AutoSize = true;
            dgvDataList.MaximumSize = new Size(1300, 220);
            dgvDataList.ScrollBars = ScrollBars.Vertical;
            LoadOrderInfo(); 
        }

        void LoadOrderInfo()
        {


            dgvDataList.DataSource = entities.Orders.ToList();
            string[] headers = new string[] {"Order ID", "Customer ID", "Employee ID", "Order Date"
                            , "Required Date", "Shipped Date", "Shipper ID", "Freight", "Ship Name", "Ship Address", "Ship City"
                            , "Ship Region", "Postal Code", "Ship Country"};
            for (int i = 0; i < dgvDataList.Columns.Count; i++)
            {
                if (new string[] { "Employee", "Customer", "OrderDetails", "Shipper" }
                    .Contains(dgvDataList.Columns[i].HeaderText))
                {
                    dgvDataList.Columns[i].Visible = false;
                }
                else
                {
                    dgvDataList.Columns[i].HeaderText = headers[i];
                }
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Order_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvDataList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbCustomerID_DropDown(object sender, EventArgs e)
        {

        }

        private void cbCustomerID_DropDownClosed(object sender, EventArgs e)
        {
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
