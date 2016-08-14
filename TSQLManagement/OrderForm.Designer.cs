namespace TSQLManagement
{
    partial class OrderForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtShipCountry = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtFreight = new System.Windows.Forms.TextBox();
            this.txtShipPostalCode = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtShipName = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpShippedDate = new System.Windows.Forms.DateTimePicker();
            this.dtpRequiredDate = new System.Windows.Forms.DateTimePicker();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblShippedDate = new System.Windows.Forms.Label();
            this.dgvDataList = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewOrderDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.orderToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.orderDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suppliersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shippersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shipperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbEmployeeID = new TSQLManagement.TComboBox();
            this.cbCustomerID = new TSQLManagement.TComboBox();
            this.cbShipperID = new TSQLManagement.TComboBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataList)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbShipperID);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtShipCountry);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtFreight);
            this.groupBox2.Controls.Add(this.txtShipPostalCode);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtShipName);
            this.groupBox2.Controls.Add(this.textBox12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.textBox10);
            this.groupBox2.Controls.Add(this.textBox11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(464, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(730, 122);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Shipping Detail";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Shipper ID:";
            // 
            // txtShipCountry
            // 
            this.txtShipCountry.AutoCompleteCustomSource.AddRange(new string[] {
            "Vietnam",
            "Finland",
            "USA",
            "Italy",
            "Brazil",
            "Germany",
            "Switzerland",
            "Mexico",
            "Sweden",
            "Argentina",
            "Austria",
            "UK",
            "Poland",
            "Canada",
            "Ireland",
            "Norway",
            "France",
            "Belgium",
            "Spain",
            "Venezuela",
            "Denmark",
            "Portugal"});
            this.txtShipCountry.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtShipCountry.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtShipCountry.Location = new System.Drawing.Point(547, 94);
            this.txtShipCountry.Name = "txtShipCountry";
            this.txtShipCountry.Size = new System.Drawing.Size(172, 20);
            this.txtShipCountry.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Freight:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(458, 97);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 13);
            this.label15.TabIndex = 31;
            this.label15.Text = "Ship Country:";
            // 
            // txtFreight
            // 
            this.txtFreight.Location = new System.Drawing.Point(93, 55);
            this.txtFreight.Name = "txtFreight";
            this.txtFreight.Size = new System.Drawing.Size(99, 20);
            this.txtFreight.TabIndex = 16;
            this.txtFreight.TextChanged += new System.EventHandler(this.txtFreight_TextChanged);
            // 
            // txtShipPostalCode
            // 
            this.txtShipPostalCode.Location = new System.Drawing.Point(547, 68);
            this.txtShipPostalCode.Name = "txtShipPostalCode";
            this.txtShipPostalCode.Size = new System.Drawing.Size(172, 20);
            this.txtShipPostalCode.TabIndex = 30;
            this.txtShipPostalCode.TextChanged += new System.EventHandler(this.txtShipPostalCode_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Ship Name:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(458, 71);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "Ship Postal Code:";
            // 
            // txtShipName
            // 
            this.txtShipName.Location = new System.Drawing.Point(93, 91);
            this.txtShipName.Name = "txtShipName";
            this.txtShipName.Size = new System.Drawing.Size(157, 20);
            this.txtShipName.TabIndex = 17;
            this.txtShipName.TextChanged += new System.EventHandler(this.txtShipName_TextChanged);
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(547, 42);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(172, 20);
            this.textBox12.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(254, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Ship Address:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(458, 45);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Ship Region:";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(257, 42);
            this.textBox10.Multiline = true;
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(195, 72);
            this.textBox10.TabIndex = 18;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(547, 16);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(172, 20);
            this.textBox11.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(458, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Ship City:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpShippedDate);
            this.groupBox1.Controls.Add(this.dtpRequiredDate);
            this.groupBox1.Controls.Add(this.dtpOrderDate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblShippedDate);
            this.groupBox1.Location = new System.Drawing.Point(225, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 122);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Date Detail";
            // 
            // dtpShippedDate
            // 
            this.dtpShippedDate.Checked = false;
            this.dtpShippedDate.CustomFormat = "dd/MM/yyyy";
            this.dtpShippedDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpShippedDate.Location = new System.Drawing.Point(96, 88);
            this.dtpShippedDate.Name = "dtpShippedDate";
            this.dtpShippedDate.ShowCheckBox = true;
            this.dtpShippedDate.Size = new System.Drawing.Size(127, 20);
            this.dtpShippedDate.TabIndex = 15;
            // 
            // dtpRequiredDate
            // 
            this.dtpRequiredDate.CustomFormat = "dd/MM/yyyy";
            this.dtpRequiredDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRequiredDate.Location = new System.Drawing.Point(96, 52);
            this.dtpRequiredDate.Name = "dtpRequiredDate";
            this.dtpRequiredDate.Size = new System.Drawing.Size(127, 20);
            this.dtpRequiredDate.TabIndex = 14;
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.CustomFormat = "dd/MM/yyyy";
            this.dtpOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpOrderDate.Location = new System.Drawing.Point(96, 16);
            this.dtpOrderDate.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dtpOrderDate.MinDate = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(127, 20);
            this.dtpOrderDate.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Order Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Required Date:";
            // 
            // lblShippedDate
            // 
            this.lblShippedDate.AutoSize = true;
            this.lblShippedDate.Location = new System.Drawing.Point(6, 94);
            this.lblShippedDate.Name = "lblShippedDate";
            this.lblShippedDate.Size = new System.Drawing.Size(75, 13);
            this.lblShippedDate.TabIndex = 15;
            this.lblShippedDate.Text = "Shipped Date:";
            // 
            // dgvDataList
            // 
            this.dgvDataList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvDataList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataList.Location = new System.Drawing.Point(12, 246);
            this.dgvDataList.MultiSelect = false;
            this.dgvDataList.Name = "dgvDataList";
            this.dgvDataList.ReadOnly = true;
            this.dgvDataList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvDataList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDataList.Size = new System.Drawing.Size(1182, 275);
            this.dgvDataList.TabIndex = 1;
            this.dgvDataList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataList_CellContentClick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnNew);
            this.flowLayoutPanel1.Controls.Add(this.btnAdd);
            this.flowLayoutPanel1.Controls.Add(this.btnUpdate);
            this.flowLayoutPanel1.Controls.Add(this.btnDelete);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(530, 179);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(163, 61);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(3, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(84, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(3, 32);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(84, 32);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbEmployeeID);
            this.groupBox3.Controls.Add(this.cbCustomerID);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(12, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(207, 122);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Basic Information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Customer ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Employee ID:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox15);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(78, 179);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 61);
            this.panel1.TabIndex = 0;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(13, 36);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(172, 20);
            this.textBox15.TabIndex = 8;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 11);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(74, 13);
            this.label16.TabIndex = 7;
            this.label16.Text = "Search Value:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(210, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderToolStripMenuItem,
            this.employeeToolStripMenuItem,
            this.customerToolStripMenuItem,
            this.supplierToolStripMenuItem,
            this.shipperToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1229, 24);
            this.menuStrip1.TabIndex = 38;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewOrdersToolStripMenuItem,
            this.viewOrderDetailToolStripMenuItem});
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.orderToolStripMenuItem.Text = "Action";
            // 
            // viewOrdersToolStripMenuItem
            // 
            this.viewOrdersToolStripMenuItem.Name = "viewOrdersToolStripMenuItem";
            this.viewOrdersToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.viewOrdersToolStripMenuItem.Text = "View Orders";
            // 
            // viewOrderDetailToolStripMenuItem
            // 
            this.viewOrderDetailToolStripMenuItem.Name = "viewOrderDetailToolStripMenuItem";
            this.viewOrderDetailToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.viewOrderDetailToolStripMenuItem.Text = "View Order Detail";
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordersToolStripMenuItem,
            this.orderDetailToolStripMenuItem,
            this.employeesToolStripMenuItem,
            this.customersToolStripMenuItem,
            this.suppliersToolStripMenuItem,
            this.shippersToolStripMenuItem});
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.employeeToolStripMenuItem.Text = "View";
            this.employeeToolStripMenuItem.Click += new System.EventHandler(this.employeeToolStripMenuItem_Click);
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordersToolStripMenuItem1,
            this.orderToolStripMenuItem1});
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.ordersToolStripMenuItem.Text = "Orders";
            // 
            // ordersToolStripMenuItem1
            // 
            this.ordersToolStripMenuItem1.Name = "ordersToolStripMenuItem1";
            this.ordersToolStripMenuItem1.Size = new System.Drawing.Size(109, 22);
            this.ordersToolStripMenuItem1.Text = "Orders";
            // 
            // orderToolStripMenuItem1
            // 
            this.orderToolStripMenuItem1.Name = "orderToolStripMenuItem1";
            this.orderToolStripMenuItem1.Size = new System.Drawing.Size(109, 22);
            this.orderToolStripMenuItem1.Text = "Order";
            // 
            // orderDetailToolStripMenuItem
            // 
            this.orderDetailToolStripMenuItem.Name = "orderDetailToolStripMenuItem";
            this.orderDetailToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.orderDetailToolStripMenuItem.Text = "Order Detail";
            // 
            // employeesToolStripMenuItem
            // 
            this.employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            this.employeesToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.employeesToolStripMenuItem.Text = "Employees";
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.customersToolStripMenuItem.Text = "Customers";
            // 
            // suppliersToolStripMenuItem
            // 
            this.suppliersToolStripMenuItem.Name = "suppliersToolStripMenuItem";
            this.suppliersToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.suppliersToolStripMenuItem.Text = "Suppliers";
            // 
            // shippersToolStripMenuItem
            // 
            this.shippersToolStripMenuItem.Name = "shippersToolStripMenuItem";
            this.shippersToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.shippersToolStripMenuItem.Text = "Shippers";
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.customerToolStripMenuItem.Text = "Customers";
            // 
            // supplierToolStripMenuItem
            // 
            this.supplierToolStripMenuItem.Name = "supplierToolStripMenuItem";
            this.supplierToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.supplierToolStripMenuItem.Text = "Suppliers";
            // 
            // shipperToolStripMenuItem
            // 
            this.shipperToolStripMenuItem.Name = "shipperToolStripMenuItem";
            this.shipperToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.shipperToolStripMenuItem.Text = "Shippers";
            // 
            // cbEmployeeID
            // 
            this.cbEmployeeID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbEmployeeID.BackColor = System.Drawing.Color.White;
            this.cbEmployeeID.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbEmployeeID.DropDownHeight = 100;
            this.cbEmployeeID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbEmployeeID.DropDownWidth = 20;
            this.cbEmployeeID.FormattingEnabled = true;
            this.cbEmployeeID.IntegralHeight = false;
            this.cbEmployeeID.Location = new System.Drawing.Point(96, 79);
            this.cbEmployeeID.Name = "cbEmployeeID";
            this.cbEmployeeID.Size = new System.Drawing.Size(99, 21);
            this.cbEmployeeID.Sorted = true;
            this.cbEmployeeID.TabIndex = 12;
            this.cbEmployeeID.Tag = "Customer ID";
            // 
            // cbCustomerID
            // 
            this.cbCustomerID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCustomerID.BackColor = System.Drawing.Color.White;
            this.cbCustomerID.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbCustomerID.DropDownHeight = 100;
            this.cbCustomerID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbCustomerID.DropDownWidth = 20;
            this.cbCustomerID.FormattingEnabled = true;
            this.cbCustomerID.IntegralHeight = false;
            this.cbCustomerID.Location = new System.Drawing.Point(96, 27);
            this.cbCustomerID.Name = "cbCustomerID";
            this.cbCustomerID.Size = new System.Drawing.Size(99, 21);
            this.cbCustomerID.Sorted = true;
            this.cbCustomerID.TabIndex = 11;
            this.cbCustomerID.Tag = "Customer ID";
            this.cbCustomerID.DropDown += new System.EventHandler(this.cbCustomerID_DropDown);
            this.cbCustomerID.DropDownClosed += new System.EventHandler(this.cbCustomerID_DropDownClosed);
            this.cbCustomerID.TextChanged += new System.EventHandler(this.cbCustomerID_TextChanged);
            // 
            // cbShipperID
            // 
            this.cbShipperID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbShipperID.BackColor = System.Drawing.Color.White;
            this.cbShipperID.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbShipperID.DropDownHeight = 100;
            this.cbShipperID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbShipperID.DropDownWidth = 20;
            this.cbShipperID.FormattingEnabled = true;
            this.cbShipperID.IntegralHeight = false;
            this.cbShipperID.Location = new System.Drawing.Point(93, 19);
            this.cbShipperID.Name = "cbShipperID";
            this.cbShipperID.Size = new System.Drawing.Size(99, 21);
            this.cbShipperID.Sorted = true;
            this.cbShipperID.TabIndex = 16;
            this.cbShipperID.Tag = "Customer ID";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1229, 558);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvDataList);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "OrderForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Order_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataList)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDataList;
        private System.Windows.Forms.TextBox txtShipName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtFreight;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblShippedDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtShipCountry;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtShipPostalCode;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button1;
        private TComboBox cbCustomerID;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shipperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewOrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewOrderDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem orderDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suppliersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shippersToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dtpShippedDate;
        private System.Windows.Forms.DateTimePicker dtpRequiredDate;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private TComboBox cbShipperID;
        private TComboBox cbEmployeeID;
    }
}

