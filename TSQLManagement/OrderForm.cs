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
        Order CurrentOrder = new Order();
        public OrderForm()
        {
            InitializeComponent();
            CurrentOrder.orderdate = dtpOrderDate.Value;
            CurrentOrder.requireddate = dtpRequiredDate.Value;

            var ShipCountries = from Order in entities.Orders
                              select Order.shipcountry;
            ShipCountries = ShipCountries.Distinct();
            cbShipCountry.DataSource = ShipCountries.ToList();
           AutoCompleteStringCollection ShipCountryList = new AutoCompleteStringCollection();
            foreach (var country in ShipCountries)
            {
                ShipCountryList.Add(country);
            }
            cbShipCountry.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbShipCountry.AutoCompleteCustomSource = ShipCountryList;
            cbShipCountry.AutoCompleteSource = AutoCompleteSource.CustomSource;
            var CustomerIDs = from Customer in entities.Customers
                              select Customer.custid;
            List<int> CustomerIDList = new List<int>();
            foreach (var x in CustomerIDs)
            {
                CustomerIDList.Add(x);
            }
            CustomerIDList.Sort();
            cbCustomerID.DataSource = CustomerIDList;
            var EmployeeIDs = from Employee in entities.Employees
                              select Employee.empid;
            List<int> EmployeeIDList = new List<int>();
            foreach (var x in EmployeeIDs)
            {
                EmployeeIDList.Add(x);
            }
            EmployeeIDList.Sort();
            cbEmployeeID.DataSource = EmployeeIDList;
            var ShipperIDs = from Shipper in entities.Shippers
                              select Shipper.shipperid;
            List<int> ShipperIDList = new List<int>();
            foreach (var x in ShipperIDs)
            {
                ShipperIDList.Add(x);
            }
            ShipperIDList.Sort();
            cbShipperID.DataSource = ShipperIDList;
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

        private void txtShipName_TextChanged(object sender, EventArgs e)
        {
            CurrentOrder.shipname = txtShipName.Text;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtFreight_TextChanged(object sender, EventArgs e)
        {
            decimal freight;
            if (txtFreight.Text.Equals("."))
            {
                txtFreight.Text ="0.";
                txtFreight.SelectionStart = 2;
                txtFreight.SelectionLength = 0;
            }
            if (decimal.TryParse(txtFreight.Text, out freight))
            {
                txtFreight.ForeColor = Color.Black;
            }
            else
            {
                txtFreight.ForeColor = Color.Red;
            }
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

        private void txtShipPostalCode_TextChanged(object sender, EventArgs e)
        {
            
        }

        bool ValidateOrder()
        {
            foreach (Control control in groupBox1.Controls)
            {
                if (control.ForeColor == Color.Red || string.IsNullOrEmpty(control.Text))
                {
                    MessageBox.Show(dtpShippedDate.Text);
                    return false;
                }
            }
            foreach (Control control in groupBox2.Controls)
            {
                if (control.ForeColor == Color.Red || string.IsNullOrEmpty(control.Text))
                {
                    MessageBox.Show(dtpShippedDate.Text);
                    return false;
                }
            }
            foreach (Control control in groupBox3.Controls)
            {
                if (control.ForeColor == Color.Red || string.IsNullOrEmpty(control.Text))
                {
                    MessageBox.Show(dtpShippedDate.Text);
                    return false;
                }
            }
            return true;
        }

        private void cbCustomerID_TextChanged(object sender, EventArgs e)
        {
            int CustomerID;
            if (int.TryParse(cbCustomerID.Text, out CustomerID))
            {
                CurrentOrder.custid = CustomerID;
            }
        }

        private void cbEmployeeID_TextChanged(object sender, EventArgs e)
        {
            int EmployeeID;
            if (int.TryParse(cbCustomerID.Text, out EmployeeID))
            {
                CurrentOrder.empid = EmployeeID;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ValidateOrder();
        }

        private void dtpOrderDate_ValueChanged(object sender, EventArgs e)
        {
            CurrentOrder.orderdate = dtpOrderDate.Value;
        }

        private void dtpRequiredDate_ValueChanged(object sender, EventArgs e)
        {
            CurrentOrder.requireddate = dtpRequiredDate.Value;
        }

        private void dtpShippedDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpShippedDate.Checked)
            {
                CurrentOrder.shippeddate = dtpShippedDate.Value;
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            CurrentOrder.shipaddress = txtShipAddress.Text;
        }

       

        private void cbShipCountry_TextChanged(object sender, EventArgs e)
        {
            CurrentOrder.shipcountry = cbShipCountry.Text;
            cbShipCity.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            AutoCompleteStringCollection CityList = new AutoCompleteStringCollection();
            var ShipCityFilterByCountry = from Order in entities.Orders
                                          where Order.shipcountry == cbShipCountry.Text
                                          select Order.shipcity;
            ShipCityFilterByCountry = ShipCityFilterByCountry.Distinct();
            cbShipCity.DataSource = ShipCityFilterByCountry.ToList();
            foreach (var city in ShipCityFilterByCountry)
            {
                CityList.Add(city);
            }
            cbShipCity.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cbShipCity.AutoCompleteCustomSource = CityList;
        }
    }
}
