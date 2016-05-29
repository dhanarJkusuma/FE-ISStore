namespace Sales.ui.transaction.incoming_item
{
    partial class editPrice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editPrice));
            this.tBarcode = new System.Windows.Forms.TextBox();
            this.tHarga = new System.Windows.Forms.TextBox();
            this.tNama = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tBarcode
            // 
            this.tBarcode.Enabled = false;
            this.tBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBarcode.Location = new System.Drawing.Point(13, 13);
            this.tBarcode.Name = "tBarcode";
            this.tBarcode.Size = new System.Drawing.Size(327, 21);
            this.tBarcode.TabIndex = 0;
            // 
            // tHarga
            // 
            this.tHarga.Location = new System.Drawing.Point(68, 73);
            this.tHarga.Name = "tHarga";
            this.tHarga.Size = new System.Drawing.Size(271, 20);
            this.tHarga.TabIndex = 1;
            this.tHarga.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tHarga_KeyDown);
            this.tHarga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tHarga_KeyPress);
            // 
            // tNama
            // 
            this.tNama.Enabled = false;
            this.tNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tNama.Location = new System.Drawing.Point(12, 40);
            this.tNama.Name = "tNama";
            this.tNama.Size = new System.Drawing.Size(327, 26);
            this.tNama.TabIndex = 0;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(13, 99);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(327, 29);
            this.btnSimpan.TabIndex = 2;
            this.btnSimpan.Text = "Save";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Harga";
            // 
            // editPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 140);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.tHarga);
            this.Controls.Add(this.tNama);
            this.Controls.Add(this.tBarcode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "editPrice";
            this.Text = "Edit Price";
            this.Load += new System.EventHandler(this.editPrice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBarcode;
        private System.Windows.Forms.TextBox tHarga;
        private System.Windows.Forms.TextBox tNama;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Label label1;
    }
}