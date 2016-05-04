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
            this.tabMenu = new System.Windows.Forms.TabControl();
            this.tabUser = new System.Windows.Forms.TabPage();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnGroup = new System.Windows.Forms.Button();
            this.tabData = new System.Windows.Forms.TabPage();
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
            this.button3 = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnIncomeItem = new System.Windows.Forms.Button();
            this.tabMenu.SuspendLayout();
            this.tabUser.SuspendLayout();
            this.tabData.SuspendLayout();
            this.tabInventory.SuspendLayout();
            this.tabTransaction.SuspendLayout();
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
            this.tabMenu.Location = new System.Drawing.Point(12, 260);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 0;
            this.tabMenu.Size = new System.Drawing.Size(662, 162);
            this.tabMenu.TabIndex = 0;
            // 
            // tabUser
            // 
            this.tabUser.Controls.Add(this.btnUser);
            this.tabUser.Controls.Add(this.btnGroup);
            this.tabUser.Location = new System.Drawing.Point(4, 22);
            this.tabUser.Name = "tabUser";
            this.tabUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabUser.Size = new System.Drawing.Size(654, 136);
            this.tabUser.TabIndex = 0;
            this.tabUser.Text = "Users";
            this.tabUser.UseVisualStyleBackColor = true;
            // 
            // btnUser
            // 
            this.btnUser.Location = new System.Drawing.Point(115, 6);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(103, 124);
            this.btnUser.TabIndex = 1;
            this.btnUser.Text = "Users";
            this.btnUser.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnGroup
            // 
            this.btnGroup.Location = new System.Drawing.Point(6, 6);
            this.btnGroup.Name = "btnGroup";
            this.btnGroup.Size = new System.Drawing.Size(103, 124);
            this.btnGroup.TabIndex = 0;
            this.btnGroup.Text = "Groups";
            this.btnGroup.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnGroup.UseVisualStyleBackColor = true;
            this.btnGroup.Click += new System.EventHandler(this.btnGroup_Click);
            // 
            // tabData
            // 
            this.tabData.Controls.Add(this.btnSupplier);
            this.tabData.Controls.Add(this.btnMember);
            this.tabData.Location = new System.Drawing.Point(4, 22);
            this.tabData.Name = "tabData";
            this.tabData.Size = new System.Drawing.Size(654, 136);
            this.tabData.TabIndex = 3;
            this.tabData.Text = "Data";
            this.tabData.UseVisualStyleBackColor = true;
            // 
            // btnSupplier
            // 
            this.btnSupplier.Location = new System.Drawing.Point(115, 6);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(103, 124);
            this.btnSupplier.TabIndex = 1;
            this.btnSupplier.Text = "Supplier";
            this.btnSupplier.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnSupplier.UseVisualStyleBackColor = true;
            this.btnSupplier.Click += new System.EventHandler(this.btnSupplier_Click);
            // 
            // btnMember
            // 
            this.btnMember.Location = new System.Drawing.Point(6, 6);
            this.btnMember.Name = "btnMember";
            this.btnMember.Size = new System.Drawing.Size(103, 124);
            this.btnMember.TabIndex = 1;
            this.btnMember.Text = "Member";
            this.btnMember.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
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
            this.tabInventory.Location = new System.Drawing.Point(4, 22);
            this.tabInventory.Name = "tabInventory";
            this.tabInventory.Padding = new System.Windows.Forms.Padding(3);
            this.tabInventory.Size = new System.Drawing.Size(654, 136);
            this.tabInventory.TabIndex = 1;
            this.tabInventory.Text = "Inventory";
            this.tabInventory.UseVisualStyleBackColor = true;
            // 
            // btnAlert
            // 
            this.btnAlert.Location = new System.Drawing.Point(442, 6);
            this.btnAlert.Name = "btnAlert";
            this.btnAlert.Size = new System.Drawing.Size(103, 124);
            this.btnAlert.TabIndex = 4;
            this.btnAlert.Text = "Stock Alert";
            this.btnAlert.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnAlert.UseVisualStyleBackColor = true;
            this.btnAlert.Click += new System.EventHandler(this.btnAlert_Click);
            // 
            // btnStock
            // 
            this.btnStock.Location = new System.Drawing.Point(333, 6);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(103, 124);
            this.btnStock.TabIndex = 3;
            this.btnStock.Text = "Master Stock";
            this.btnStock.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnItem
            // 
            this.btnItem.Location = new System.Drawing.Point(224, 6);
            this.btnItem.Name = "btnItem";
            this.btnItem.Size = new System.Drawing.Size(103, 124);
            this.btnItem.TabIndex = 2;
            this.btnItem.Text = "Master Item";
            this.btnItem.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnItem.UseVisualStyleBackColor = true;
            this.btnItem.Click += new System.EventHandler(this.btnItem_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.Location = new System.Drawing.Point(115, 6);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(103, 124);
            this.btnCategory.TabIndex = 1;
            this.btnCategory.Text = "Category";
            this.btnCategory.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnCategory.UseVisualStyleBackColor = true;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnUnit
            // 
            this.btnUnit.Location = new System.Drawing.Point(6, 6);
            this.btnUnit.Name = "btnUnit";
            this.btnUnit.Size = new System.Drawing.Size(103, 124);
            this.btnUnit.TabIndex = 0;
            this.btnUnit.Text = "Unit";
            this.btnUnit.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnUnit.UseVisualStyleBackColor = true;
            this.btnUnit.Click += new System.EventHandler(this.btnUnit_Click);
            // 
            // tabTransaction
            // 
            this.tabTransaction.Controls.Add(this.btnListIncome);
            this.tabTransaction.Controls.Add(this.button3);
            this.tabTransaction.Controls.Add(this.btnPayment);
            this.tabTransaction.Controls.Add(this.btnIncomeItem);
            this.tabTransaction.Location = new System.Drawing.Point(4, 22);
            this.tabTransaction.Name = "tabTransaction";
            this.tabTransaction.Size = new System.Drawing.Size(654, 136);
            this.tabTransaction.TabIndex = 2;
            this.tabTransaction.Text = "Transaction";
            this.tabTransaction.UseVisualStyleBackColor = true;
            // 
            // btnListIncome
            // 
            this.btnListIncome.Location = new System.Drawing.Point(115, 6);
            this.btnListIncome.Name = "btnListIncome";
            this.btnListIncome.Size = new System.Drawing.Size(103, 124);
            this.btnListIncome.TabIndex = 1;
            this.btnListIncome.Text = "Draft Incoming Item";
            this.btnListIncome.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnListIncome.UseVisualStyleBackColor = true;
            this.btnListIncome.Click += new System.EventHandler(this.btnListIncome_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(333, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 124);
            this.button3.TabIndex = 1;
            this.button3.Text = "Draft Payment";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnPayment
            // 
            this.btnPayment.Location = new System.Drawing.Point(224, 6);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(103, 124);
            this.btnPayment.TabIndex = 1;
            this.btnPayment.Text = "Payment";
            this.btnPayment.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnIncomeItem
            // 
            this.btnIncomeItem.Location = new System.Drawing.Point(6, 6);
            this.btnIncomeItem.Name = "btnIncomeItem";
            this.btnIncomeItem.Size = new System.Drawing.Size(103, 124);
            this.btnIncomeItem.TabIndex = 1;
            this.btnIncomeItem.Text = "New Incoming Item";
            this.btnIncomeItem.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnIncomeItem.UseVisualStyleBackColor = true;
            this.btnIncomeItem.Click += new System.EventHandler(this.btnIncomeItem_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 434);
            this.Controls.Add(this.tabMenu);
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
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabPage tabData;
        private System.Windows.Forms.Button btnMember;
        private System.Windows.Forms.Button btnSupplier;


    }
}

