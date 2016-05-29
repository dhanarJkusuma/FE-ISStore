namespace Sales
{
    partial class mainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabMenu = new System.Windows.Forms.TabControl();
            this.tabUser = new System.Windows.Forms.TabPage();
            this.btnAuth = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnGroup = new System.Windows.Forms.Button();
            this.tabData = new System.Windows.Forms.TabPage();
            this.btnGift = new System.Windows.Forms.Button();
            this.btnSupplier = new System.Windows.Forms.Button();
            this.btnMember = new System.Windows.Forms.Button();
            this.tabInventory = new System.Windows.Forms.TabPage();
            this.btnAlert = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnItem = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnUnit = new System.Windows.Forms.Button();
            this.tabTransaction = new System.Windows.Forms.TabPage();
            this.btnListIncome = new System.Windows.Forms.Button();
            this.btnExc = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnIncomeItem = new System.Windows.Forms.Button();
            this.tabReport = new System.Windows.Forms.TabPage();
            this.btnPaymentRpt = new System.Windows.Forms.Button();
            this.btnIncome = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnTop = new System.Windows.Forms.Button();
            this.btnProfitReport = new System.Windows.Forms.Button();
            this.btnStockRep = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.ltime = new System.Windows.Forms.TextBox();
            this.profitChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tName = new System.Windows.Forms.TextBox();
            this.tStore = new System.Windows.Forms.TextBox();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.tFullName = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.amToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabMenu.SuspendLayout();
            this.tabUser.SuspendLayout();
            this.tabData.SuspendLayout();
            this.tabInventory.SuspendLayout();
            this.tabTransaction.SuspendLayout();
            this.tabReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profitChart)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMenu
            // 
            this.tabMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMenu.Controls.Add(this.tabUser);
            this.tabMenu.Controls.Add(this.tabData);
            this.tabMenu.Controls.Add(this.tabInventory);
            this.tabMenu.Controls.Add(this.tabTransaction);
            this.tabMenu.Controls.Add(this.tabReport);
            this.tabMenu.Font = new System.Drawing.Font("Leelawadee UI Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMenu.Location = new System.Drawing.Point(13, 393);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 0;
            this.tabMenu.Size = new System.Drawing.Size(886, 175);
            this.tabMenu.TabIndex = 0;
            this.tabMenu.SelectedIndexChanged += new System.EventHandler(this.tabMenu_SelectedIndexChanged);
            // 
            // tabUser
            // 
            this.tabUser.Controls.Add(this.btnAuth);
            this.tabUser.Controls.Add(this.btnUser);
            this.tabUser.Controls.Add(this.btnGroup);
            this.tabUser.Location = new System.Drawing.Point(4, 26);
            this.tabUser.Name = "tabUser";
            this.tabUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabUser.Size = new System.Drawing.Size(878, 145);
            this.tabUser.TabIndex = 0;
            this.tabUser.Text = "Users";
            this.tabUser.UseVisualStyleBackColor = true;
            // 
            // btnAuth
            // 
            this.btnAuth.Font = new System.Drawing.Font("Leelawadee UI Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuth.Image = ((System.Drawing.Image)(resources.GetObject("btnAuth.Image")));
            this.btnAuth.Location = new System.Drawing.Point(239, 7);
            this.btnAuth.Name = "btnAuth";
            this.btnAuth.Size = new System.Drawing.Size(110, 133);
            this.btnAuth.TabIndex = 2;
            this.btnAuth.Text = "Authorization";
            this.btnAuth.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnAuth.UseVisualStyleBackColor = true;
            this.btnAuth.Click += new System.EventHandler(this.btnAuth_Click);
            // 
            // btnUser
            // 
            this.btnUser.Font = new System.Drawing.Font("Leelawadee UI Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.Image = ((System.Drawing.Image)(resources.GetObject("btnUser.Image")));
            this.btnUser.Location = new System.Drawing.Point(123, 7);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(110, 133);
            this.btnUser.TabIndex = 1;
            this.btnUser.Text = "Users";
            this.btnUser.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnGroup
            // 
            this.btnGroup.Font = new System.Drawing.Font("Leelawadee UI Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGroup.Image = ((System.Drawing.Image)(resources.GetObject("btnGroup.Image")));
            this.btnGroup.Location = new System.Drawing.Point(7, 7);
            this.btnGroup.Name = "btnGroup";
            this.btnGroup.Size = new System.Drawing.Size(110, 133);
            this.btnGroup.TabIndex = 0;
            this.btnGroup.Text = "Groups";
            this.btnGroup.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnGroup.UseVisualStyleBackColor = true;
            this.btnGroup.Click += new System.EventHandler(this.btnGroup_Click);
            // 
            // tabData
            // 
            this.tabData.Controls.Add(this.btnGift);
            this.tabData.Controls.Add(this.btnSupplier);
            this.tabData.Controls.Add(this.btnMember);
            this.tabData.Location = new System.Drawing.Point(4, 26);
            this.tabData.Name = "tabData";
            this.tabData.Size = new System.Drawing.Size(878, 145);
            this.tabData.TabIndex = 3;
            this.tabData.Text = "Data";
            this.tabData.UseVisualStyleBackColor = true;
            // 
            // btnGift
            // 
            this.btnGift.Image = ((System.Drawing.Image)(resources.GetObject("btnGift.Image")));
            this.btnGift.Location = new System.Drawing.Point(240, 7);
            this.btnGift.Name = "btnGift";
            this.btnGift.Size = new System.Drawing.Size(110, 133);
            this.btnGift.TabIndex = 2;
            this.btnGift.Text = "Gift";
            this.btnGift.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnGift.UseVisualStyleBackColor = true;
            this.btnGift.Click += new System.EventHandler(this.btnGift_Click);
            // 
            // btnSupplier
            // 
            this.btnSupplier.Image = ((System.Drawing.Image)(resources.GetObject("btnSupplier.Image")));
            this.btnSupplier.Location = new System.Drawing.Point(124, 7);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(110, 133);
            this.btnSupplier.TabIndex = 1;
            this.btnSupplier.Text = "Supplier";
            this.btnSupplier.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnSupplier.UseVisualStyleBackColor = true;
            this.btnSupplier.Click += new System.EventHandler(this.btnSupplier_Click);
            // 
            // btnMember
            // 
            this.btnMember.Font = new System.Drawing.Font("Leelawadee UI Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMember.Image = ((System.Drawing.Image)(resources.GetObject("btnMember.Image")));
            this.btnMember.Location = new System.Drawing.Point(8, 7);
            this.btnMember.Name = "btnMember";
            this.btnMember.Size = new System.Drawing.Size(110, 133);
            this.btnMember.TabIndex = 0;
            this.btnMember.Text = "Member";
            this.btnMember.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnMember.UseVisualStyleBackColor = true;
            this.btnMember.Click += new System.EventHandler(this.btnMember_Click);
            // 
            // tabInventory
            // 
            this.tabInventory.Controls.Add(this.btnAlert);
            this.tabInventory.Controls.Add(this.btnStock);
            this.tabInventory.Controls.Add(this.btnItem);
            this.tabInventory.Controls.Add(this.btnCategory);
            this.tabInventory.Controls.Add(this.btnUnit);
            this.tabInventory.Location = new System.Drawing.Point(4, 26);
            this.tabInventory.Name = "tabInventory";
            this.tabInventory.Padding = new System.Windows.Forms.Padding(3);
            this.tabInventory.Size = new System.Drawing.Size(878, 145);
            this.tabInventory.TabIndex = 1;
            this.tabInventory.Text = "Inventory";
            this.tabInventory.UseVisualStyleBackColor = true;
            // 
            // btnAlert
            // 
            this.btnAlert.Image = ((System.Drawing.Image)(resources.GetObject("btnAlert.Image")));
            this.btnAlert.Location = new System.Drawing.Point(471, 7);
            this.btnAlert.Name = "btnAlert";
            this.btnAlert.Size = new System.Drawing.Size(110, 133);
            this.btnAlert.TabIndex = 4;
            this.btnAlert.Text = "Stock Alert";
            this.btnAlert.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnAlert.UseVisualStyleBackColor = true;
            this.btnAlert.Click += new System.EventHandler(this.btnAlert_Click);
            // 
            // btnStock
            // 
            this.btnStock.Image = ((System.Drawing.Image)(resources.GetObject("btnStock.Image")));
            this.btnStock.Location = new System.Drawing.Point(355, 7);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(110, 133);
            this.btnStock.TabIndex = 3;
            this.btnStock.Text = "Master Stock";
            this.btnStock.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnItem
            // 
            this.btnItem.Image = ((System.Drawing.Image)(resources.GetObject("btnItem.Image")));
            this.btnItem.Location = new System.Drawing.Point(239, 7);
            this.btnItem.Name = "btnItem";
            this.btnItem.Size = new System.Drawing.Size(110, 133);
            this.btnItem.TabIndex = 2;
            this.btnItem.Text = "Master Item";
            this.btnItem.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnItem.UseVisualStyleBackColor = true;
            this.btnItem.Click += new System.EventHandler(this.btnItem_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnCategory.Image")));
            this.btnCategory.Location = new System.Drawing.Point(123, 7);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(110, 133);
            this.btnCategory.TabIndex = 1;
            this.btnCategory.Text = "Category";
            this.btnCategory.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnCategory.UseVisualStyleBackColor = true;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnUnit
            // 
            this.btnUnit.Image = ((System.Drawing.Image)(resources.GetObject("btnUnit.Image")));
            this.btnUnit.Location = new System.Drawing.Point(7, 7);
            this.btnUnit.Name = "btnUnit";
            this.btnUnit.Size = new System.Drawing.Size(110, 133);
            this.btnUnit.TabIndex = 0;
            this.btnUnit.Text = "Unit";
            this.btnUnit.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnUnit.UseVisualStyleBackColor = true;
            this.btnUnit.Click += new System.EventHandler(this.btnUnit_Click);
            // 
            // tabTransaction
            // 
            this.tabTransaction.Controls.Add(this.btnListIncome);
            this.tabTransaction.Controls.Add(this.btnExc);
            this.tabTransaction.Controls.Add(this.btnPayment);
            this.tabTransaction.Controls.Add(this.btnIncomeItem);
            this.tabTransaction.Location = new System.Drawing.Point(4, 26);
            this.tabTransaction.Name = "tabTransaction";
            this.tabTransaction.Size = new System.Drawing.Size(878, 145);
            this.tabTransaction.TabIndex = 2;
            this.tabTransaction.Text = "Transaction";
            this.tabTransaction.UseVisualStyleBackColor = true;
            // 
            // btnListIncome
            // 
            this.btnListIncome.Image = ((System.Drawing.Image)(resources.GetObject("btnListIncome.Image")));
            this.btnListIncome.Location = new System.Drawing.Point(123, 7);
            this.btnListIncome.Name = "btnListIncome";
            this.btnListIncome.Size = new System.Drawing.Size(110, 133);
            this.btnListIncome.TabIndex = 1;
            this.btnListIncome.Text = "Draft Incoming Item";
            this.btnListIncome.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnListIncome.UseVisualStyleBackColor = true;
            this.btnListIncome.Click += new System.EventHandler(this.btnListIncome_Click);
            // 
            // btnExc
            // 
            this.btnExc.Image = ((System.Drawing.Image)(resources.GetObject("btnExc.Image")));
            this.btnExc.Location = new System.Drawing.Point(355, 7);
            this.btnExc.Name = "btnExc";
            this.btnExc.Size = new System.Drawing.Size(110, 133);
            this.btnExc.TabIndex = 3;
            this.btnExc.Text = "Point Exchange";
            this.btnExc.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnExc.UseVisualStyleBackColor = true;
            this.btnExc.Click += new System.EventHandler(this.btnExc_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.Image = ((System.Drawing.Image)(resources.GetObject("btnPayment.Image")));
            this.btnPayment.Location = new System.Drawing.Point(239, 7);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(110, 133);
            this.btnPayment.TabIndex = 2;
            this.btnPayment.Text = "Payment";
            this.btnPayment.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnIncomeItem
            // 
            this.btnIncomeItem.Image = ((System.Drawing.Image)(resources.GetObject("btnIncomeItem.Image")));
            this.btnIncomeItem.Location = new System.Drawing.Point(7, 7);
            this.btnIncomeItem.Name = "btnIncomeItem";
            this.btnIncomeItem.Size = new System.Drawing.Size(110, 133);
            this.btnIncomeItem.TabIndex = 0;
            this.btnIncomeItem.Text = "New Incoming Item";
            this.btnIncomeItem.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnIncomeItem.UseVisualStyleBackColor = true;
            this.btnIncomeItem.Click += new System.EventHandler(this.btnIncomeItem_Click);
            // 
            // tabReport
            // 
            this.tabReport.Controls.Add(this.btnPaymentRpt);
            this.tabReport.Controls.Add(this.btnIncome);
            this.tabReport.Controls.Add(this.btnDown);
            this.tabReport.Controls.Add(this.btnTop);
            this.tabReport.Controls.Add(this.btnProfitReport);
            this.tabReport.Controls.Add(this.btnStockRep);
            this.tabReport.Location = new System.Drawing.Point(4, 26);
            this.tabReport.Name = "tabReport";
            this.tabReport.Size = new System.Drawing.Size(878, 145);
            this.tabReport.TabIndex = 4;
            this.tabReport.Text = "Report";
            this.tabReport.UseVisualStyleBackColor = true;
            // 
            // btnPaymentRpt
            // 
            this.btnPaymentRpt.Font = new System.Drawing.Font("Leelawadee UI Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaymentRpt.Image = ((System.Drawing.Image)(resources.GetObject("btnPaymentRpt.Image")));
            this.btnPaymentRpt.Location = new System.Drawing.Point(587, 7);
            this.btnPaymentRpt.Name = "btnPaymentRpt";
            this.btnPaymentRpt.Size = new System.Drawing.Size(110, 133);
            this.btnPaymentRpt.TabIndex = 5;
            this.btnPaymentRpt.Text = "Payment Transaction";
            this.btnPaymentRpt.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnPaymentRpt.UseVisualStyleBackColor = true;
            this.btnPaymentRpt.Click += new System.EventHandler(this.btnPaymentRpt_Click);
            // 
            // btnIncome
            // 
            this.btnIncome.Font = new System.Drawing.Font("Leelawadee UI Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncome.Image = ((System.Drawing.Image)(resources.GetObject("btnIncome.Image")));
            this.btnIncome.Location = new System.Drawing.Point(471, 7);
            this.btnIncome.Name = "btnIncome";
            this.btnIncome.Size = new System.Drawing.Size(110, 133);
            this.btnIncome.TabIndex = 4;
            this.btnIncome.Text = "Incoming Item Transaction";
            this.btnIncome.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnIncome.UseVisualStyleBackColor = true;
            this.btnIncome.Click += new System.EventHandler(this.btnIncome_Click);
            // 
            // btnDown
            // 
            this.btnDown.Font = new System.Drawing.Font("Leelawadee UI Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDown.Image = ((System.Drawing.Image)(resources.GetObject("btnDown.Image")));
            this.btnDown.Location = new System.Drawing.Point(355, 7);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(110, 133);
            this.btnDown.TabIndex = 3;
            this.btnDown.Text = "Down Item";
            this.btnDown.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnTop
            // 
            this.btnTop.Font = new System.Drawing.Font("Leelawadee UI Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTop.Image = ((System.Drawing.Image)(resources.GetObject("btnTop.Image")));
            this.btnTop.Location = new System.Drawing.Point(239, 7);
            this.btnTop.Name = "btnTop";
            this.btnTop.Size = new System.Drawing.Size(110, 133);
            this.btnTop.TabIndex = 2;
            this.btnTop.Text = "Top Item";
            this.btnTop.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnTop.UseVisualStyleBackColor = true;
            this.btnTop.Click += new System.EventHandler(this.btnTop_Click);
            // 
            // btnProfitReport
            // 
            this.btnProfitReport.Font = new System.Drawing.Font("Leelawadee UI Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfitReport.Image = ((System.Drawing.Image)(resources.GetObject("btnProfitReport.Image")));
            this.btnProfitReport.Location = new System.Drawing.Point(123, 7);
            this.btnProfitReport.Name = "btnProfitReport";
            this.btnProfitReport.Size = new System.Drawing.Size(110, 133);
            this.btnProfitReport.TabIndex = 1;
            this.btnProfitReport.Text = "Profit Report";
            this.btnProfitReport.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnProfitReport.UseVisualStyleBackColor = true;
            this.btnProfitReport.Click += new System.EventHandler(this.btnProfitReport_Click);
            // 
            // btnStockRep
            // 
            this.btnStockRep.Font = new System.Drawing.Font("Leelawadee UI Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockRep.Image = ((System.Drawing.Image)(resources.GetObject("btnStockRep.Image")));
            this.btnStockRep.Location = new System.Drawing.Point(7, 7);
            this.btnStockRep.Name = "btnStockRep";
            this.btnStockRep.Size = new System.Drawing.Size(110, 133);
            this.btnStockRep.TabIndex = 0;
            this.btnStockRep.Text = "Stock Report";
            this.btnStockRep.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnStockRep.UseVisualStyleBackColor = true;
            this.btnStockRep.Click += new System.EventHandler(this.btnStockRep_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // ltime
            // 
            this.ltime.Enabled = false;
            this.ltime.Font = new System.Drawing.Font("Meiryo UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltime.Location = new System.Drawing.Point(12, 158);
            this.ltime.Name = "ltime";
            this.ltime.Size = new System.Drawing.Size(303, 33);
            this.ltime.TabIndex = 2;
            // 
            // profitChart
            // 
            this.profitChart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.profitChart.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(72)))), ((int)(((byte)(0)))));
            this.profitChart.BorderSkin.BackColor = System.Drawing.SystemColors.GrayText;
            this.profitChart.BorderSkin.BorderColor = System.Drawing.Color.White;
            this.profitChart.BorderSkin.PageColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(72)))), ((int)(((byte)(0)))));
            chartArea3.BorderColor = System.Drawing.Color.White;
            chartArea3.Name = "ChartArea1";
            this.profitChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.profitChart.Legends.Add(legend3);
            this.profitChart.Location = new System.Drawing.Point(18, 244);
            this.profitChart.Name = "profitChart";
            this.profitChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "profit";
            this.profitChart.Series.Add(series3);
            this.profitChart.Size = new System.Drawing.Size(771, 143);
            this.profitChart.TabIndex = 3;
            this.profitChart.Text = "profitChart";
            // 
            // tName
            // 
            this.tName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tName.Enabled = false;
            this.tName.Location = new System.Drawing.Point(12, 131);
            this.tName.Name = "tName";
            this.tName.Size = new System.Drawing.Size(492, 21);
            this.tName.TabIndex = 4;
            // 
            // tStore
            // 
            this.tStore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tStore.Enabled = false;
            this.tStore.Font = new System.Drawing.Font("Meiryo UI", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tStore.Location = new System.Drawing.Point(12, 32);
            this.tStore.Name = "tStore";
            this.tStore.Size = new System.Drawing.Size(492, 62);
            this.tStore.TabIndex = 6;
            // 
            // btnSetting
            // 
            this.btnSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.ForeColor = System.Drawing.Color.White;
            this.btnSetting.Image = ((System.Drawing.Image)(resources.GetObject("btnSetting.Image")));
            this.btnSetting.Location = new System.Drawing.Point(766, 13);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(62, 55);
            this.btnSetting.TabIndex = 1;
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(834, 13);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(62, 55);
            this.btnExit.TabIndex = 1;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tFullName
            // 
            this.tFullName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tFullName.Enabled = false;
            this.tFullName.Location = new System.Drawing.Point(12, 104);
            this.tFullName.Name = "tFullName";
            this.tFullName.Size = new System.Drawing.Size(492, 21);
            this.tFullName.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.amToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(914, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // amToolStripMenuItem
            // 
            this.amToolStripMenuItem.Name = "amToolStripMenuItem";
            this.amToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.amToolStripMenuItem.Text = "About";
            this.amToolStripMenuItem.Click += new System.EventHandler(this.amToolStripMenuItem_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(914, 581);
            this.Controls.Add(this.tStore);
            this.Controls.Add(this.tFullName);
            this.Controls.Add(this.tName);
            this.Controls.Add(this.profitChart);
            this.Controls.Add(this.ltime);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tabMenu);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Meiryo UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimizeBox = false;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sales :: Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabMenu.ResumeLayout(false);
            this.tabUser.ResumeLayout(false);
            this.tabData.ResumeLayout(false);
            this.tabInventory.ResumeLayout(false);
            this.tabTransaction.ResumeLayout(false);
            this.tabReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profitChart)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabMenu;
        private System.Windows.Forms.TabPage tabUser;
        private System.Windows.Forms.TabPage tabInventory;
        private System.Windows.Forms.Button btnUnit;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnItem;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnAlert;
        private System.Windows.Forms.TabPage tabTransaction;
        private System.Windows.Forms.Button btnIncomeItem;
        private System.Windows.Forms.Button btnGroup;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnListIncome;
        private System.Windows.Forms.TabPage tabData;
        private System.Windows.Forms.Button btnMember;
        private System.Windows.Forms.Button btnSupplier;
        private System.Windows.Forms.Button btnAuth;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TabPage tabReport;
        private System.Windows.Forms.Button btnStockRep;
        private System.Windows.Forms.Button btnProfitReport;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnTop;
        private System.Windows.Forms.Button btnIncome;
        private System.Windows.Forms.Button btnPaymentRpt;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox ltime;
        private System.Windows.Forms.DataVisualization.Charting.Chart profitChart;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.TextBox tName;
        private System.Windows.Forms.TextBox tStore;
        private System.Windows.Forms.Button btnGift;
        private System.Windows.Forms.Button btnExc;
        private System.Windows.Forms.TextBox tFullName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem amToolStripMenuItem;


    }
}

