using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TSQLWEB
{
    public partial class EmployeeForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("<script language='javascript'>$('#alert').alert('close')</script>");
            if (!IsPostBack)
            {
                LoadEmployeeInfo();

            }
        }
        TSQLFundamentals2008Entities entity = new TSQLFundamentals2008Entities();

        void LoadEmployeeInfo()
        {
            GridView1.DataSource = entity.Employees.ToList();
            GridView1.DataBind();
        }

        protected void btnnew_Click(object sender, EventArgs e)
        {
            txtlastname.Text = "";
            txtfirstname.Text = "";
            txttitle.Text = "";
            txttitleofcourt.Text = "";
            txtBirthDate.Text = "";
            txtHireDate.Text = "";
            txtaddress.Text = "";
            txtcity.Text = "";
            txtregion.Text = "";
            txtpostal.Text = "";
            txtcountry.Text = "";
            txtphone.Text = "";
            txtmrgid.Text = "";
        }
        bool addEmployee()
        {
            try
            {
                Employee emp = new Employee();
                emp.lastname = txtlastname.Text;
                emp.firstname = txtfirstname.Text;
                emp.title = txttitle.Text;
                emp.titleofcourtesy = txttitleofcourt.Text;
                emp.birthdate = DateTime.Parse(txtBirthDate.Text);
                emp.hiredate = DateTime.Parse(txtHireDate.Text);
                emp.address = txtaddress.Text;
                emp.city = txtcity.Text;
                emp.region = txtregion.Text;
                emp.postalcode = txtpostal.Text;
                emp.country = txtcountry.Text;
                emp.phone = txtphone.Text;
                emp.mgrid = int.Parse(txtmrgid.Text);

                entity.Employees.Add(emp);
                entity.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
          
        }
        void AlertSuccess(string progress)
        {
            //Alert.Visible = true;
            //Alert.CssClass="alert alert-success";
            //lblStrong.Text = "Success!fully!";
            Response.Write("<script language='javascript'>$('#alert').alert()</script>");
        }

        void AlertFailed(string error)
        {
            //Alert.Visible = true;
            //Alert.CssClass = "alert alert-danger";
            //lblStrong.Text = "Failed!";
            //lblMessage.Text = error + " !";
            Response.Write("<script language='javascript'>alert('Failed! " + error + " ')</script>");


        }
        protected void btnadd_Click(object sender, EventArgs e)
        {

                switch (btnadd.Text)
                {
                    case "Add":
                        {
                            try
                            {
                                bool done = addEmployee();
                                LoadEmployeeInfo();
                                if (done)
                                {
                                    AlertSuccess("Added");
                                }
                                else
                                {
                                    AlertFailed("Add Failed!");
                                }

                            }
                            catch (Exception)
                            {
                            }
                            break;
                        }
                    case "Update":
                        {
                            try
                            {
                                bool result = updateEmployee();
                                LoadEmployeeInfo();
                                if (result)
                                {
                                    AlertSuccess("Updating");
                                }
                                else
                                {
                                    AlertFailed("Update Failed!");
                                }
                            }
                            catch (Exception)
                            {
                                string msgScript = "<script>alert('Update failed');</script>";
                                Response.Write(msgScript);
                            }

                            break;
                        }
                    default:
                        break;
                }
            }
           

       

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnadd.Text = "Update";
            btnadd.CssClass = "btn btn-info";
            GridViewRow r = GridView1.SelectedRow;
            txtlastname.Text = Server.HtmlDecode(r.Cells[3].Text);
            txtfirstname.Text = Server.HtmlDecode(r.Cells[4].Text);
            txttitle.Text = Server.HtmlDecode(r.Cells[5].Text);
            txttitleofcourt.Text = Server.HtmlDecode(r.Cells[6].Text);
            txtBirthDate.Text = Server.HtmlDecode(r.Cells[7].Text);
            txtHireDate.Text = Server.HtmlDecode(r.Cells[8].Text);
            txtaddress.Text = Server.HtmlDecode(r.Cells[9].Text);
            txtcity.Text = Server.HtmlDecode(r.Cells[10].Text);
            txtregion.Text = Server.HtmlDecode(r.Cells[11].Text);
            txtpostal.Text = Server.HtmlDecode(r.Cells[12].Text);
            txtcountry.Text = Server.HtmlDecode(r.Cells[13].Text);
            txtphone.Text = Server.HtmlDecode(r.Cells[14].Text);
            txtmrgid.Text = Server.HtmlDecode(r.Cells[15].Text);
        }
         bool updateEmployee()
        {

            GridViewRow r = GridView1.SelectedRow;
            Employee emp = new Employee();
            foreach (Employee e in entity.Employees)
            {
                if (e.empid == int.Parse(r.Cells[1].Text))
                {
                    emp = e;
                    break;
                }
            }

            if (emp != null)
            {
                emp.lastname = txtlastname.Text;
                emp.firstname = txtfirstname.Text;
                emp.title = txttitle.Text;
                emp.titleofcourtesy = txttitleofcourt.Text;
                emp.birthdate = DateTime.Parse(txtBirthDate.Text);
                emp.hiredate = DateTime.Parse(txtHireDate.Text);
                emp.address = txtaddress.Text;
                emp.city = txtcity.Text;
                emp.region = txtregion.Text;
                emp.postalcode = txtpostal.Text;
                emp.country = txtcountry.Text;
                emp.phone = txtphone.Text;
                emp.mgrid = int.Parse(txtmrgid.Text);
                entity.SaveChanges();
                return true;
            }
            return false;
        }
         bool deleteSup(GridViewDeleteEventArgs e)
         {

             GridViewRow r = GridView1.Rows[e.RowIndex];
             Employee emp = new Employee();
             foreach (Employee em in entity.Employees)
             {
                 if (em.empid == int.Parse(r.Cells[1].Text))
                 {
                     emp = em;
                     break;
                 }
             }
             try
             {
                 entity.Employees.Remove(emp);
                 entity.SaveChanges();
                 return true;
             }
             catch (Exception)
             {
                 string msgScript = "<script>alert('Can't delete this people');</script>";
                 Response.Write(msgScript);
                 return false;
             }

         }


    }
}