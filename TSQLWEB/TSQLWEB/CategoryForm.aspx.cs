using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TSQLWEB
{
    public partial class CategoryForm : System.Web.UI.Page
    {
        TSQLFundamentals2008Entities Entity = new TSQLFundamentals2008Entities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadCategoryInfo();
            }
        }
        void LoadCategoryInfo()
        {
            GridView1.DataSource = Entity.Categories.ToList();
            GridView1.DataBind();
        }
        protected void btnNew_Click(object sender, EventArgs e)
        {

            txtCategory.Text = "";
            txtDes.Text = "";
            btnAdd.Text = "Add";
            btnAdd.CssClass = "btn btn-success";
        }
        bool ValidateInput()
        {
            if (txtCategory.Text == "")
            {
                lblStatus.Text = "Invalid Category name";

                return false;
            }

            if (txtDes.Text == "")
            {
                lblStatus.Text = "Invalid description";
                return false;
            }
            return true;
        }
        bool AddCategory()
        {
            try
            {
                Category cat = new Category();
                cat.categoryname = txtCategory.Text;
                cat.description = txtDes.Text;
                Entity.Categories.Add(cat);
                Entity.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                switch (btnAdd.Text)
                {
                    case "Add":
                        {
                            try
                            {
                                bool done = AddCategory();
                                LoadCategoryInfo();
                                if (done)
                                {
                                    lblStatus.Text = "Added";
                                }
                                else
                                {
                                    lblStatus.Text = "Add Failed!";
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
                                bool result = updateCategory();
                                LoadCategoryInfo();
                                if (result)
                                {
                                    lblStatus.Text = "Updated";
                                }
                                else
                                {
                                    lblStatus.Text = "Update Failed!";
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
            else
            {
                //string msgScript = "<script>alert('Invalid Input');</script>";
                //Response.Write(msgScript);
                return;
            }
        }
        bool updateCategory()
        {

            GridViewRow r = GridView1.SelectedRow;
            Category cat = new Category();
            foreach (Category c in Entity.Categories)
            {
                if (c.categoryid == int.Parse(r.Cells[1].Text))
                {
                    cat = c;
                    break;
                }
            }

            if (cat != null)
            {
                cat.categoryname = txtCategory.Text;
                cat.description = txtDes.Text;

                Entity.SaveChanges();
                return true;
            }
            return false;
        }
        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            
        }
        bool deleteCategory(GridViewDeleteEventArgs e)
        {

            GridViewRow r = GridView1.Rows[e.RowIndex];
            Category cat = new Category();
            foreach (Category c in Entity.Categories)
            {
                if (c.categoryid == int.Parse(r.Cells[1].Text))
                {
                    cat = c;
                    break;
                }
            }
            try
            {
                Entity.Categories.Remove(cat);
                Entity.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                string msgScript = "<script>alert('Can't delete this people');</script>";
                Response.Write(msgScript);
                return false;
            }

        }

        protected void GridView1_RowDeleting1(object sender, GridViewDeleteEventArgs e)
        {
            deleteCategory(e);
            LoadCategoryInfo();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAdd.Text = "Update";
            btnAdd.CssClass = "btn btn-info";
            GridViewRow r = GridView1.SelectedRow;
            txtCategory.Text = r.Cells[2].Text;
            txtDes.Text = r.Cells[3].Text;

        }
    }
}