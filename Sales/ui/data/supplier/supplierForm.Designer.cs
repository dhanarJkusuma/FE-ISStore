namespace Sales.ui.data.supplier
{
    partial class supplierForm
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
            this.supplierGrid = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.supplierGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // supplierGrid
            // 
            this.supplierGrid.AllowUserToAddRows = false;
            this.supplierGrid.AllowUserToDeleteRows = false;
            this.supplierGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.supplierGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supplierGrid.Location = new System.Drawing.Point(12, 107);
            this.supplierGrid.Name = "supplierGrid";
            this.supplierGrid.ReadOnly = true;
            this.supplierGrid.RowHeadersVisible = false;
            this.supplierGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.supplierGrid.Size = new System.Drawing.Size(696, 384);
            this.supplierGrid.TabIndex = 5;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(248, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 72);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete Supplier";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(130, 12);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(112, 72);
            this.editBtn.TabIndex = 3;
            this.editBtn.Text = "Edit Supplier";
            this.editBtn.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(12, 12);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(112, 72);
            this.btnNew.TabIndex = 4;
            this.btnNew.Text = "New Supplier";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // supplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 522);
            this.Controls.Add(this.supplierGrid);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.btnNew);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "supplierForm";
            this.Text = "supplierForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.supplierGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView supplierGrid;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button btnNew;
    }
}