using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TSQLWEB
{
    public partial class ProductForm : System.Web.UI.Page
    {
        TSQLFundamentals2008Entities Entity = new TSQLFundamentals2008Entities();
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("<script language='javascript'>$('#alert').alert('close')</script>");
            if (!IsPostBack)
            {
                LoadProInfo();
            }
        }

        private void LoadProInfo()
        {
            GridView1.DataSource = Entity.Products.ToList();
            GridView1.DataBind();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAdd.Text = "Update";
            btnAdd.CssClass = "btn btn-info";
            GridViewRow gv = GridView1.SelectedRow;
            txtProductId.Text = gv.Cells[1].Text;
            txtProductName.Text = gv.Cells[2].Text;

            txtSupp.Text = gv.Cells[3].Text;
            txtCate.Text = gv.Cells[4].Text;
            txtUnitprice.Text = gv.Cells[5].Text;
            cbDis.Checked = (gv.Cells[6].Controls[0] as CheckBox).Checked;

        }

        protected void btnNew_Click(object sender, EventArgs e)
        {
            txtProductId.Text = "";
            txtProductName.Text = "";
            txtSupp.Text = "";
            txtCate.Text = "";
            txtUnitprice.Text = "";
            cbDis.Checked = false;
            btnAdd.Text = "Add";
            btnAdd.CssClass = "btn btn-success";

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {

            switch (btnAdd.Text)
            {
                case "Add":
                    {
                        try
                        {
                            bool done = addPro();
                            LoadProInfo();
                            if (done)
                            {

                                AlertSuccess("Add");
                            }
                            else
                            {
                                AlertFailed("Add");
                            }
                        }
                        catch (Exception)
                        {
                             AlertFailed("Add");
                        }
                        break;
                    }
                case "Update":
                    {
                        try
                        {
                            bool doo = updatePro();
                            LoadProInfo();
                            if (doo)
                            {
                                AlertSuccess("Update");

                            }
                            else
                            {
                                AlertFailed("Update");
                            }

                        }
                        catch (Exception)
                        {
                            AlertFailed("Update");
                        }
                        break;
                    }
                default: break;

            }


        }

        private bool updatePro()
        {
            GridViewRow r = GridView1.SelectedRow;
            Product pro = null;
            foreach (Product p in Entity.Products)
            {
                if (p.productid == Int32.Parse(r.Cells[1].Text))
                {
                    pro = p;
                    break;
                }
            }
            if (pro != null)
            {
                pro.productname = txtProductName.Text;
                pro.supplierid = Int32.Parse(txtSupp.Text);
                pro.categoryid = Int32.Parse(txtCate.Text);
                pro.unitprice = Decimal.Parse(txtUnitprice.Text);
                if (cbDis.Checked)
                {
                    pro.discontinued = true;
                }
                else
                {
                    pro.discontinued = false;
                }
                Entity.SaveChanges();
                return true;
            }
            return false;
        }

        private bool addPro()
        {
            try
            {
                Product pro = new Product();
                pro.productname = txtProductName.Text;
                pro.supplierid = Int32.Parse(txtSupp.Text);
                pro.categoryid = Int32.Parse(txtCate.Text);
                pro.unitprice = Decimal.Parse(txtUnitprice.Text);
                pro.productname = txtProductName.Text;
                if (cbDis.Checked)
                {
                    pro.discontinued = true;

                }
                else
                {
                    pro.discontinued = false;
                }
                Entity.Products.Add(pro);
                Entity.SaveChanges();
                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }

        //private bool validatePro()
        //{
        //    // check pro
        //    if (txtProductName.Text == "")
        //    {
        //        lblError.Text = "Product name is not null!!!";
        //        return false;
        //    }
        //    //check supp
        //    try
        //    {
        //        if (txtSupp.Text == "")
        //        {
        //            lblError.Text = "Supplier is not null";
        //            return false;
        //        }
        //        Int32 supp = Int32.Parse(txtSupp.Text);
        //        return false;
        //    }
        //    catch (Exception)
        //    {
        //        lblError.Text = "Supplier is number !!!";
        //    }
        //    //check cate
        //    try
        //    {
        //        if (txtCate.Text == "")
        //        {
        //            lblError.Text = "Category  is not null";
        //            return false;
        //        }
        //        Int32 cate = Int32.Parse(txtSupp.Text);
        //        return false;
        //    }
        //    catch (Exception)
        //    {
        //        lblError.Text = "Category  is number !!!";
        //    }
        //    // check unit
        //    try
        //    {
        //        if (txtUnitprice.Text == "")
        //        {
        //            lblError.Text = "Unitprice is not null";
        //            return false;
        //        }
        //        Decimal unit = Decimal.Parse(txtCate.Text);
        //        return false;
        //    }
        //    catch (Exception)
        //    {
        //        lblError.Text = "unitprice is number !!!";
        //    }

        //    return true;
        //}

        protected void txtProductName_TextChanged(object sender, EventArgs e)
        {

        }

        void AlertSuccess(string progress)
        {

            Response.Write("<script language='javascript'>alert('Succcessfull! " + progress + " ')</script>");
        }

        void AlertFailed(string error)
        {
            Response.Write("<script language='javascript'>alert('Failed! " + error + " ')</script>");
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            deletePro(e);
            LoadProInfo();
        }

         bool deletePro(GridViewDeleteEventArgs e)
        {
            GridViewRow dr = GridView1.Rows[e.RowIndex];
            Product pro = new Product();
            foreach (Product p in Entity.Products)
            {
                if (p.productid == int.Parse(dr.Cells[1].Text))
                {
                    pro = p;
                    break;
                }
            }

            try
            {
                Entity.Products.Remove(pro);
                Entity.SaveChanges();
                AlertSuccess("Delete");
                return true;
            }
            catch (Exception)
            {
                AlertFailed("Delete");
                return false;
            }
        }
    }
}