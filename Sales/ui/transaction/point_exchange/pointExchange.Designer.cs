namespace Sales.ui.transaction.point_exchange
{
    partial class pointExchange
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
            this.itemGrid = new System.Windows.Forms.DataGridView();
            this.tIdMember = new System.Windows.Forms.TextBox();
            this.tName = new System.Windows.Forms.TextBox();
            this.tQty = new System.Windows.Forms.TextBox();
            this.tPoint = new System.Windows.Forms.TextBox();
            this.btnExchange = new System.Windows.Forms.Button();
            this.tbind = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.itemGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // itemGrid
            // 
            this.itemGrid.AllowUserToAddRows = false;
            this.itemGrid.AllowUserToDeleteRows = false;
            this.itemGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemGrid.Location = new System.Drawing.Point(12, 126);
            this.itemGrid.MultiSelect = false;
            this.itemGrid.Name = "itemGrid";
            this.itemGrid.ReadOnly = true;
            this.itemGrid.RowHeadersVisible = false;
            this.itemGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.itemGrid.Size = new System.Drawing.Size(347, 298);
            this.itemGrid.TabIndex = 0;
            // 
            // tIdMember
            // 
            this.tIdMember.Location = new System.Drawing.Point(12, 13);
            this.tIdMember.Name = "tIdMember";
            this.tIdMember.Size = new System.Drawing.Size(347, 20);
            this.tIdMember.TabIndex = 1;
            this.tIdMember.TextChanged += new System.EventHandler(this.tIdMember_TextChanged);
            this.tIdMember.Enter += new System.EventHandler(this.tIdMember_Enter);
            this.tIdMember.Leave += new System.EventHandler(this.tIdMember_Leave);
            // 
            // tName
            // 
            this.tName.Enabled = false;
            this.tName.Location = new System.Drawing.Point(12, 39);
            this.tName.Name = "tName";
            this.tName.Size = new System.Drawing.Size(347, 20);
            this.tName.TabIndex = 1;
            // 
            // tQty
            // 
            this.tQty.Location = new System.Drawing.Point(85, 440);
            this.tQty.Name = "tQty";
            this.tQty.Size = new System.Drawing.Size(274, 20);
            this.tQty.TabIndex = 1;
            // 
            // tPoint
            // 
            this.tPoint.Enabled = false;
            this.tPoint.Location = new System.Drawing.Point(12, 65);
            this.tPoint.Name = "tPoint";
            this.tPoint.Size = new System.Drawing.Size(347, 20);
            this.tPoint.TabIndex = 1;
            // 
            // btnExchange
            // 
            this.btnExchange.Location = new System.Drawing.Point(13, 476);
            this.btnExchange.Name = "btnExchange";
            this.btnExchange.Size = new System.Drawing.Size(349, 41);
            this.btnExchange.TabIndex = 2;
            this.btnExchange.Text = "Exchange";
            this.btnExchange.UseVisualStyleBackColor = true;
            this.btnExchange.Click += new System.EventHandler(this.btnExchange_Click);
            // 
            // tbind
            // 
            this.tbind.Location = new System.Drawing.Point(85, 100);
            this.tbind.Name = "tbind";
            this.tbind.Size = new System.Drawing.Size(274, 20);
            this.tbind.TabIndex = 1;
            this.tbind.TextChanged += new System.EventHandler(this.tbind_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search";
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Location = new System.Drawing.Point(9, 443);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(46, 13);
            this.Quantity.TabIndex = 4;
            this.Quantity.Text = "Quantity";
            // 
            // pointExchange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 529);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExchange);
            this.Controls.Add(this.tQty);
            this.Controls.Add(this.tbind);
            this.Controls.Add(this.tPoint);
            this.Controls.Add(this.tName);
            this.Controls.Add(this.tIdMember);
            this.Controls.Add(this.itemGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "pointExchange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales :: Transaction :: Point Exchange";
            this.Load += new System.EventHandler(this.pointExchange_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView itemGrid;
        private System.Windows.Forms.TextBox tIdMember;
        private System.Windows.Forms.TextBox tName;
        private System.Windows.Forms.TextBox tQty;
        private System.Windows.Forms.TextBox tPoint;
        private System.Windows.Forms.Button btnExchange;
        private System.Windows.Forms.TextBox tbind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Quantity;
    }
}