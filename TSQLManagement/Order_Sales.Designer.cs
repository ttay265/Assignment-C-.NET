namespace TSQLManagement
{
    partial class Order_Sales
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Bang_Hien_Thi = new System.Windows.Forms.DataGridView();
            this.Form_Dien_vao = new System.Windows.Forms.Panel();
            this.Form_Search = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbSearchFilter = new System.Windows.Forms.ComboBox();
            this.txtSearchValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbOrderId = new System.Windows.Forms.ComboBox();
            this.cbProductId = new System.Windows.Forms.ComboBox();
            this.txtUnitprice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Bang_Hien_Thi)).BeginInit();
            this.Form_Dien_vao.SuspendLayout();
            this.Form_Search.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Bang_Hien_Thi
            // 
            this.Bang_Hien_Thi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Bang_Hien_Thi.Location = new System.Drawing.Point(303, 107);
            this.Bang_Hien_Thi.Name = "Bang_Hien_Thi";
            this.Bang_Hien_Thi.Size = new System.Drawing.Size(344, 303);
            this.Bang_Hien_Thi.TabIndex = 0;
            // 
            // Form_Dien_vao
            // 
            this.Form_Dien_vao.Controls.Add(this.flowLayoutPanel1);
            this.Form_Dien_vao.Controls.Add(this.txtDiscount);
            this.Form_Dien_vao.Controls.Add(this.txtQuantity);
            this.Form_Dien_vao.Controls.Add(this.txtUnitprice);
            this.Form_Dien_vao.Controls.Add(this.cbProductId);
            this.Form_Dien_vao.Controls.Add(this.cbOrderId);
            this.Form_Dien_vao.Controls.Add(this.label5);
            this.Form_Dien_vao.Controls.Add(this.label4);
            this.Form_Dien_vao.Controls.Add(this.label3);
            this.Form_Dien_vao.Controls.Add(this.label2);
            this.Form_Dien_vao.Controls.Add(this.label1);
            this.Form_Dien_vao.Location = new System.Drawing.Point(12, 13);
            this.Form_Dien_vao.Name = "Form_Dien_vao";
            this.Form_Dien_vao.Size = new System.Drawing.Size(285, 396);
            this.Form_Dien_vao.TabIndex = 1;
            // 
            // Form_Search
            // 
            this.Form_Search.Controls.Add(this.btnSearch);
            this.Form_Search.Controls.Add(this.cbSearchFilter);
            this.Form_Search.Controls.Add(this.txtSearchValue);
            this.Form_Search.Location = new System.Drawing.Point(303, 13);
            this.Form_Search.Name = "Form_Search";
            this.Form_Search.Size = new System.Drawing.Size(344, 87);
            this.Form_Search.TabIndex = 2;
            this.Form_Search.Paint += new System.Windows.Forms.PaintEventHandler(this.Form_Search_Paint);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(218, 14);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 25);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // cbSearchFilter
            // 
            this.cbSearchFilter.FormattingEnabled = true;
            this.cbSearchFilter.Location = new System.Drawing.Point(17, 45);
            this.cbSearchFilter.Name = "cbSearchFilter";
            this.cbSearchFilter.Size = new System.Drawing.Size(121, 22);
            this.cbSearchFilter.TabIndex = 1;
            // 
            // txtSearchValue
            // 
            this.txtSearchValue.Location = new System.Drawing.Point(17, 17);
            this.txtSearchValue.Name = "txtSearchValue";
            this.txtSearchValue.Size = new System.Drawing.Size(176, 20);
            this.txtSearchValue.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "Product Id";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "Unitprice";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 14);
            this.label4.TabIndex = 0;
            this.label4.Text = "Quantity";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 14);
            this.label5.TabIndex = 0;
            this.label5.Text = "Discount";
            this.label5.Click += new System.EventHandler(this.label2_Click);
            // 
            // cbOrderId
            // 
            this.cbOrderId.FormattingEnabled = true;
            this.cbOrderId.Location = new System.Drawing.Point(87, 11);
            this.cbOrderId.Name = "cbOrderId";
            this.cbOrderId.Size = new System.Drawing.Size(121, 22);
            this.cbOrderId.TabIndex = 1;
            // 
            // cbProductId
            // 
            this.cbProductId.FormattingEnabled = true;
            this.cbProductId.Location = new System.Drawing.Point(87, 50);
            this.cbProductId.Name = "cbProductId";
            this.cbProductId.Size = new System.Drawing.Size(121, 22);
            this.cbProductId.TabIndex = 1;
            // 
            // txtUnitprice
            // 
            this.txtUnitprice.Location = new System.Drawing.Point(87, 87);
            this.txtUnitprice.Name = "txtUnitprice";
            this.txtUnitprice.Size = new System.Drawing.Size(121, 20);
            this.txtUnitprice.TabIndex = 2;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(87, 131);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(121, 20);
            this.txtQuantity.TabIndex = 2;
            this.txtQuantity.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(87, 169);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(121, 20);
            this.txtDiscount.TabIndex = 2;
            this.txtDiscount.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnNew);
            this.flowLayoutPanel1.Controls.Add(this.btnAdd);
            this.flowLayoutPanel1.Controls.Add(this.btnUpdate);
            this.flowLayoutPanel1.Controls.Add(this.btnDelete);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(45, 229);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(163, 66);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(3, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 25);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(84, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 25);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(3, 34);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 25);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(84, 34);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 25);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // Order_Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 419);
            this.Controls.Add(this.Form_Search);
            this.Controls.Add(this.Form_Dien_vao);
            this.Controls.Add(this.Bang_Hien_Thi);
            this.Name = "Order_Sales";
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.Order_Sales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Bang_Hien_Thi)).EndInit();
            this.Form_Dien_vao.ResumeLayout(false);
            this.Form_Dien_vao.PerformLayout();
            this.Form_Search.ResumeLayout(false);
            this.Form_Search.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Bang_Hien_Thi;
        private System.Windows.Forms.Panel Form_Dien_vao;
        private System.Windows.Forms.Panel Form_Search;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbSearchFilter;
        private System.Windows.Forms.TextBox txtSearchValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtUnitprice;
        private System.Windows.Forms.ComboBox cbProductId;
        private System.Windows.Forms.ComboBox cbOrderId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}