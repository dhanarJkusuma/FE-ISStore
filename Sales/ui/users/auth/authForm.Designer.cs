namespace Sales.ui.users.auth
{
    partial class authForm
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
            this.authTree = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // authTree
            // 
            this.authTree.CheckBoxes = true;
            this.authTree.Location = new System.Drawing.Point(12, 12);
            this.authTree.Name = "authTree";
            this.authTree.Size = new System.Drawing.Size(323, 357);
            this.authTree.TabIndex = 0;
            this.authTree.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.authTree_AfterCheck);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 427);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // authForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 478);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.authTree);
            this.Name = "authForm";
            this.Text = "authForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView authTree;
        private System.Windows.Forms.Button button1;

    }
}