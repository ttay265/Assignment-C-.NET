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
            this.txtSearchValue = new System.Windows.Forms.TextBox();
            this.cbSearchFilter = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Bang_Hien_Thi)).BeginInit();
            this.Form_Search.SuspendLayout();
            this.SuspendLayout();
            // 
            // Bang_Hien_Thi
            // 
            this.Bang_Hien_Thi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Bang_Hien_Thi.Location = new System.Drawing.Point(303, 99);
            this.Bang_Hien_Thi.Name = "Bang_Hien_Thi";
            this.Bang_Hien_Thi.Size = new System.Drawing.Size(344, 281);
            this.Bang_Hien_Thi.TabIndex = 0;
            // 
            // Form_Dien_vao
            // 
            this.Form_Dien_vao.Location = new System.Drawing.Point(12, 12);
            this.Form_Dien_vao.Name = "Form_Dien_vao";
            this.Form_Dien_vao.Size = new System.Drawing.Size(285, 368);
            this.Form_Dien_vao.TabIndex = 1;
            // 
            // Form_Search
            // 
            this.Form_Search.Controls.Add(this.btnSearch);
            this.Form_Search.Controls.Add(this.cbSearchFilter);
            this.Form_Search.Controls.Add(this.txtSearchValue);
            this.Form_Search.Location = new System.Drawing.Point(303, 12);
            this.Form_Search.Name = "Form_Search";
            this.Form_Search.Size = new System.Drawing.Size(344, 81);
            this.Form_Search.TabIndex = 2;
            this.Form_Search.Paint += new System.Windows.Forms.PaintEventHandler(this.Form_Search_Paint);
            // 
            // txtSearchValue
            // 
            this.txtSearchValue.Location = new System.Drawing.Point(17, 16);
            this.txtSearchValue.Name = "txtSearchValue";
            this.txtSearchValue.Size = new System.Drawing.Size(176, 20);
            this.txtSearchValue.TabIndex = 0;
            // 
            // cbSearchFilter
            // 
            this.cbSearchFilter.FormattingEnabled = true;
            this.cbSearchFilter.Location = new System.Drawing.Point(17, 42);
            this.cbSearchFilter.Name = "cbSearchFilter";
            this.cbSearchFilter.Size = new System.Drawing.Size(121, 21);
            this.cbSearchFilter.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(218, 13);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // Order_Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 389);
            this.Controls.Add(this.Form_Search);
            this.Controls.Add(this.Form_Dien_vao);
            this.Controls.Add(this.Bang_Hien_Thi);
            this.Name = "Order_Sales";
            this.Text = "Orders";
            ((System.ComponentModel.ISupportInitialize)(this.Bang_Hien_Thi)).EndInit();
            this.Form_Search.ResumeLayout(false);
            this.Form_Search.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Bang_Hien_Thi;
        private System.Windows.Forms.Panel Form_Dien_vao;
        private System.Windows.Forms.Panel Form_Search;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbSearchFilter;
        private System.Windows.Forms.TextBox txtSearchValue;
    }
}