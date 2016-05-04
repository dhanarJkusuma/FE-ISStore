namespace Sales.libs
{
    partial class suggestSupplier
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.tBindGrid = new System.Windows.Forms.TextBox();
            this.supplierGrid = new System.Windows.Forms.DataGridView();
            this.rName = new System.Windows.Forms.RadioButton();
            this.rID = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.supplierGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(153, 451);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 47);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(28, 451);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(119, 47);
            this.btnSelect.TabIndex = 6;
            this.btnSelect.Text = "Select";
            this.btnSelect.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // tBindGrid
            // 
            this.tBindGrid.Location = new System.Drawing.Point(20, 16);
            this.tBindGrid.Name = "tBindGrid";
            this.tBindGrid.Size = new System.Drawing.Size(224, 20);
            this.tBindGrid.TabIndex = 4;
            this.tBindGrid.TextChanged += new System.EventHandler(this.tBindGrid_TextChanged);
            this.tBindGrid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBindGrid_KeyPress);
            // 
            // supplierGrid
            // 
            this.supplierGrid.AllowUserToAddRows = false;
            this.supplierGrid.AllowUserToDeleteRows = false;
            this.supplierGrid.AllowUserToResizeColumns = false;
            this.supplierGrid.AllowUserToResizeRows = false;
            this.supplierGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supplierGrid.Location = new System.Drawing.Point(28, 70);
            this.supplierGrid.MultiSelect = false;
            this.supplierGrid.Name = "supplierGrid";
            this.supplierGrid.RowHeadersVisible = false;
            this.supplierGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.supplierGrid.Size = new System.Drawing.Size(376, 375);
            this.supplierGrid.TabIndex = 3;
            // 
            // rName
            // 
            this.rName.AutoSize = true;
            this.rName.Location = new System.Drawing.Point(302, 19);
            this.rName.Name = "rName";
            this.rName.Size = new System.Drawing.Size(53, 17);
            this.rName.TabIndex = 7;
            this.rName.TabStop = true;
            this.rName.Text = "Name";
            this.rName.UseVisualStyleBackColor = true;
            // 
            // rID
            // 
            this.rID.AutoSize = true;
            this.rID.Location = new System.Drawing.Point(260, 19);
            this.rID.Name = "rID";
            this.rID.Size = new System.Drawing.Size(36, 17);
            this.rID.TabIndex = 7;
            this.rID.TabStop = true;
            this.rID.Text = "ID";
            this.rID.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rName);
            this.groupBox1.Controls.Add(this.rID);
            this.groupBox1.Controls.Add(this.tBindGrid);
            this.groupBox1.Location = new System.Drawing.Point(28, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 52);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter By";
            // 
            // suggestSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 515);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.supplierGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "suggestSupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "suggestSupplier";
            ((System.ComponentModel.ISupportInitialize)(this.supplierGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox tBindGrid;
        private System.Windows.Forms.DataGridView supplierGrid;
        private System.Windows.Forms.RadioButton rName;
        private System.Windows.Forms.RadioButton rID;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}