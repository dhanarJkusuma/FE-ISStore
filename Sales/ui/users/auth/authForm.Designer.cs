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
            this.btnSave = new System.Windows.Forms.Button();
            this.cGroup = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // authTree
            // 
            this.authTree.CheckBoxes = true;
            this.authTree.Location = new System.Drawing.Point(14, 54);
            this.authTree.Name = "authTree";
            this.authTree.Size = new System.Drawing.Size(311, 362);
            this.authTree.TabIndex = 0;
            this.authTree.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.authTree_AfterCheck);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 422);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(138, 44);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save Auth";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cGroup
            // 
            this.cGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cGroup.FormattingEnabled = true;
            this.cGroup.Location = new System.Drawing.Point(14, 23);
            this.cGroup.Name = "cGroup";
            this.cGroup.Size = new System.Drawing.Size(311, 21);
            this.cGroup.TabIndex = 2;
            this.cGroup.SelectedIndexChanged += new System.EventHandler(this.cGroup_SelectedIndexChanged);
            // 
            // authForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 475);
            this.Controls.Add(this.cGroup);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.authTree);
            this.Name = "authForm";
            this.Text = "authForm";
            this.Load += new System.EventHandler(this.authForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView authTree;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cGroup;

    }
}