namespace Sales.libs
{
    partial class suggestItem
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
            this.gridSuggest = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridSuggest)).BeginInit();
            this.SuspendLayout();
            // 
            // gridSuggest
            // 
            this.gridSuggest.AllowUserToAddRows = false;
            this.gridSuggest.AllowUserToDeleteRows = false;
            this.gridSuggest.AllowUserToResizeColumns = false;
            this.gridSuggest.AllowUserToResizeRows = false;
            this.gridSuggest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridSuggest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSuggest.Location = new System.Drawing.Point(13, 13);
            this.gridSuggest.Name = "gridSuggest";
            this.gridSuggest.RowHeadersVisible = false;
            this.gridSuggest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridSuggest.Size = new System.Drawing.Size(687, 303);
            this.gridSuggest.TabIndex = 0;
            this.gridSuggest.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridSuggest_KeyDown);
            this.gridSuggest.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gridSuggest_KeyPress);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClose.Location = new System.Drawing.Point(13, 322);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(108, 70);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // suggestItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(712, 404);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gridSuggest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "suggestItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "suggestItem";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.gridSuggest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridSuggest;
        private System.Windows.Forms.Button btnClose;
    }
}