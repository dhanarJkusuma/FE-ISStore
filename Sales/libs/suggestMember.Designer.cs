namespace Sales.libs
{
    partial class suggestMember
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
            this.memberGrid = new System.Windows.Forms.DataGridView();
            this.tBindGrid = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.memberGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // memberGrid
            // 
            this.memberGrid.AllowUserToAddRows = false;
            this.memberGrid.AllowUserToDeleteRows = false;
            this.memberGrid.AllowUserToResizeColumns = false;
            this.memberGrid.AllowUserToResizeRows = false;
            this.memberGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.memberGrid.Location = new System.Drawing.Point(12, 54);
            this.memberGrid.MultiSelect = false;
            this.memberGrid.Name = "memberGrid";
            this.memberGrid.RowHeadersVisible = false;
            this.memberGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.memberGrid.Size = new System.Drawing.Size(376, 399);
            this.memberGrid.TabIndex = 0;
            // 
            // tBindGrid
            // 
            this.tBindGrid.Location = new System.Drawing.Point(13, 28);
            this.tBindGrid.Name = "tBindGrid";
            this.tBindGrid.Size = new System.Drawing.Size(224, 20);
            this.tBindGrid.TabIndex = 1;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(12, 460);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(119, 47);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "Select";
            this.btnSelect.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(137, 460);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 47);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // suggestMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 519);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.tBindGrid);
            this.Controls.Add(this.memberGrid);
            this.Name = "suggestMember";
            this.Text = "suggestMember";
            ((System.ComponentModel.ISupportInitialize)(this.memberGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView memberGrid;
        private System.Windows.Forms.TextBox tBindGrid;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnCancel;
    }
}