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
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
            LoadEmpoyeeInfo();
            dgvDataList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        TSQLFundamentals2008Entities entity = new TSQLFundamentals2008Entities();
        void LoadEmpoyeeInfo()
        {
            dgvDataList.DataSource = entity.Employees.ToList();
            for (int i = 0; i < dgvDataList.Columns.Count; i++ )
            {
                if(new string [] {"Employees1", "Employee1", "Orders"}.Contains(dgvDataList.Columns[i].HeaderText))
                {
                    dgvDataList.Columns[i].Visible = false;
                }
            }
        }

        private void dgvDataList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Employee em = new Employee();
            em.empid = (Int32)dgvDataList.SelectedRows[0].Cells[0].Value;
            em.lastname = (string)dgvDataList.SelectedRows[0].Cells[1].Value;
            em.firstname = (string)dgvDataList.SelectedRows[0].Cells[2].Value;
            em.title = (string)dgvDataList.SelectedRows[0].Cells[3].Value;
            em.titleofcourtesy = (string)dgvDataList.SelectedRows[0].Cells[4].Value;
            em.birthdate = (DateTime)dgvDataList.SelectedRows[0].Cells[5].Value;
            em.hiredate = (DateTime)dgvDataList.SelectedRows[0].Cells[6].Value;
            em.address = (string)dgvDataList.SelectedRows[0].Cells[7].Value;
            em.city = (string)dgvDataList.SelectedRows[0].Cells[8].Value;
            em.region = (string)dgvDataList.SelectedRows[0].Cells[9].Value;
            em.postalcode = (string)dgvDataList.SelectedRows[0].Cells[10].Value;
            em.country = (string)dgvDataList.SelectedRows[0].Cells[11].Value;
            em.phone = (string)dgvDataList.SelectedRows[0].Cells[12].Value; 
            em.mgrid = (Int32)dgvDataList.SelectedRows[0].Cells[13].Value;

            txtlastname.Text = em.lastname;
            txtfirstname.Text = em.firstname;
            txttitle.Text = em.title;
            txttiteofcourtesy.Text = em.titleofcourtesy;
            dtpbirthday.Text = em.birthdate.ToString();
            dtphiredate.Text = em.hiredate.ToString();
            txtaddress2.Text = em.address;
            txtcity2.Text = em.city;
            txtregion.Text = em.region;
            txtpostalcode.Text = em.postalcode;
            txtcountry.Text = em.country;
            txtphone.Text = em.phone;
            txtmgrid.Text = em.mgrid.ToString();

        }

        bool validateInput()
        {
            bool bError = false;

            string lastname = txtlastname.Text;
            if (lastname.Length == 0)
            {
                errorProvider1.SetError(txtlastname, "Please enter Lastname");
                bError = true;
            }
            string firstname = txtfirstname.Text;
            if (firstname.Length == 0)
            {
                errorProvider2.SetError(txtfirstname, "Please enter FirstName");
                bError = true;
            }
            string title = txttitle.Text;
            if (title.Length == 0)
            {
                errorProvider3.SetError(txttitle, "Please enter Title");
                bError = true;
            }
            string titleofcourtesy = txttiteofcourtesy.Text;
            if (titleofcourtesy.Length == 0)
            {
                errorProvider4.SetError(txttiteofcourtesy, "Please enter Title of Courtesy");
                bError = true;
            }
            //DateTime currDate = DateTime.Now;
            //int currYear = currDate.Year;
            //DateTime dateOfBirth = dtpbirthday.Value;
            //int birthYear = dateOfBirth.Year;

            //if (currYear - birthYear < 18)
            //{
            //    errorProvider6.SetError(dtpbirthday, "Age must be greater than 18 or equal 18");
            //    bError = true;
            //}
            //string hiredate = dtphiredate.Text;
            //if ()
            //{
            //    errorProvider7.SetError(dtphiredate, "I");
            //    bError = true;
            //}
            string address = txtaddress2.Text;
            if (address.Length == 0)
            {
                errorProvider5.SetError(txtaddress, "Please enter Address");
                bError = true;
            }
            string city = txtcity2.Text;
            if (city.Length == 0)
            {
                errorProvider6.SetError(txtcity, "Please enter City");
                bError = true;
            }
            string region = txtregion.Text;
            if (region.Length == 0)
            {
                errorProvider9.SetError(txtregion, "Please enter");   // Allow Null
                bError = true;
            }
            string postalcode = txtpostalcode.Text;
            if (postalcode.Length == 0)
            {
                errorProvider10.SetError(txtpostalcode, "Please enter");  // Allow Null
                bError = true;
            }
            string country = txtcountry.Text;
            if (country.Length == 0)
            {
                errorProvider7.SetError(txtcountry, "Please enter ountry");
                bError = true;
            }
            if (txtphone.MaskCompleted == false)
            {
                errorProvider8.SetError(txtphone, "Please enter phone number !");
                bError = true;
            }
            string mgrid = txtmgrid.Text;
            if (mgrid.Length == 0)
            {
                errorProvider11.SetError(txtmgrid, "Id manager is only digit");  // Allow Null
                bError = true;
            }

            if (bError == true)
            {
                return false;
            }

            return true;
        }
        void addEmploee()
        {
            Employee emp = new Employee();
            emp.lastname = txtlastname.Text;
            emp.firstname = txtfirstname.Text;
            emp.title = txttitle.Text;
            emp.titleofcourtesy = txttiteofcourtesy.Text;
            emp.birthdate = dtpbirthday.Value;
            emp.hiredate = dtphiredate.Value;
            emp.address = txtaddress2.Text;
            emp.city = txtcity2.Text;
            emp.region = txtregion.Text;
            emp.postalcode = txtpostalcode.Text;
            emp.country = txtcountry.Text;
            emp.phone = txtphone.Text;
            emp.mgrid = Int32.Parse(txtmgrid.Text);

            entity.Employees.Add(emp);
            entity.SaveChanges();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(validateInput() == false)
            {
                return;
            }
            try
            {
                addEmploee();
                LoadEmpoyeeInfo();
                MessageBox.Show("Add Employee Successful !!!");
            }
            catch (Exception)
            {
                MessageBox.Show("Add Employee Fail !!!");
            }
        }


        void updateEmployee()
        {
            DataGridViewRow r = dgvDataList.SelectedRows[0];
            Employee emp = null;
            foreach(Employee e in entity.Employees)
            {
                if (e.empid == (int)r.Cells[0].Value)
                {
                    emp = e;
                    break;
                }
            }
            if(emp != null)
            {
                emp.lastname = txtlastname.Text;
                emp.firstname = txtfirstname.Text;
                emp.title = txttitle.Text;
                emp.titleofcourtesy = txttiteofcourtesy.Text;
                emp.birthdate = dtpbirthday.Value;
                emp.hiredate = dtphiredate.Value;
                emp.address = txtaddress2.Text;
                emp.city = txtcity2.Text;
                emp.region = txtregion.Text;
                emp.postalcode = txtpostalcode.Text;
                emp.country = txtcountry.Text;
                emp.phone = txtphone.Text;
                emp.mgrid = Int32.Parse(txtmgrid.Text);

                entity.SaveChanges();
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
                updateEmployee();
                LoadEmpoyeeInfo();
                MessageBox.Show("Update Employee Succesfull !!!");
            }
            catch (Exception)
            {
                MessageBox.Show("Update Employee Fail !!!");
            }
        }
        void deleteEmployee()
        {
            if(dgvDataList.SelectedRows.Count > 0)
            {
                DataGridViewRow r = dgvDataList.SelectedRows[0];
                Employee em = null;
                foreach(Employee e in entity.Employees)
                {
                    if(e.empid == (int)r.Cells[0].Value)
                    {
                        em = e;
                        break;
                    }
                }
                entity.Employees.Remove(em);
                entity.SaveChanges();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                deleteEmployee();
                LoadEmpoyeeInfo();
                MessageBox.Show("Delete Employee Successful !!!");
            }
            catch (Exception)
            {
                MessageBox.Show("Delete Fail !!!");
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtlastname.Text = "";
            txtfirstname.Text = "";
            txttitle.Text = "";
            txttiteofcourtesy.Text = "";
            dtpbirthday.Text = "";
            dtphiredate.Text = "";
            txtaddress2.Text = "";
            txtcity2.Text = "";
            txtregion.Text = "";
            txtpostalcode.Text = "";
            txtcountry.Text = "";
            txtphone.Text = "";
            txtmgrid.Text = "";
        }

      
    }
}
