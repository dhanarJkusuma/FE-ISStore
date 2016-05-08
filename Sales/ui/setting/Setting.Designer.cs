namespace Sales.ui.setting
{
    partial class Setting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setting));
            this.tabSettings = new System.Windows.Forms.TabControl();
            this.tabUser = new System.Windows.Forms.TabPage();
            this.tabSystem = new System.Windows.Forms.TabPage();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gPassword = new System.Windows.Forms.GroupBox();
            this.gName = new System.Windows.Forms.GroupBox();
            this.gSystem = new System.Windows.Forms.GroupBox();
            this.cName = new System.Windows.Forms.CheckBox();
            this.cPassword = new System.Windows.Forms.CheckBox();
            this.tOldPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tConfirm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tStore = new System.Windows.Forms.TextBox();
            this.tAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tPhone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cSystem = new System.Windows.Forms.CheckBox();
            this.tabSettings.SuspendLayout();
            this.tabUser.SuspendLayout();
            this.tabSystem.SuspendLayout();
            this.gPassword.SuspendLayout();
            this.gName.SuspendLayout();
            this.gSystem.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.tabUser);
            this.tabSettings.Controls.Add(this.tabSystem);
            this.tabSettings.Location = new System.Drawing.Point(33, 26);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.SelectedIndex = 0;
            this.tabSettings.Size = new System.Drawing.Size(300, 376);
            this.tabSettings.TabIndex = 0;
            // 
            // tabUser
            // 
            this.tabUser.Controls.Add(this.cPassword);
            this.tabUser.Controls.Add(this.cName);
            this.tabUser.Controls.Add(this.gName);
            this.tabUser.Controls.Add(this.gPassword);
            this.tabUser.Location = new System.Drawing.Point(4, 22);
            this.tabUser.Name = "tabUser";
            this.tabUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabUser.Size = new System.Drawing.Size(292, 350);
            this.tabUser.TabIndex = 0;
            this.tabUser.Text = "User Setting";
            this.tabUser.UseVisualStyleBackColor = true;
            // 
            // tabSystem
            // 
            this.tabSystem.Controls.Add(this.cSystem);
            this.tabSystem.Controls.Add(this.gSystem);
            this.tabSystem.Location = new System.Drawing.Point(4, 22);
            this.tabSystem.Name = "tabSystem";
            this.tabSystem.Padding = new System.Windows.Forms.Padding(3);
            this.tabSystem.Size = new System.Drawing.Size(292, 350);
            this.tabSystem.TabIndex = 1;
            this.tabSystem.Text = "System Setting";
            this.tabSystem.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(174, 415);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 73);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(78, 416);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 73);
            this.btnSave.TabIndex = 1;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gPassword
            // 
            this.gPassword.Controls.Add(this.label4);
            this.gPassword.Controls.Add(this.tConfirm);
            this.gPassword.Controls.Add(this.label3);
            this.gPassword.Controls.Add(this.tPassword);
            this.gPassword.Controls.Add(this.label2);
            this.gPassword.Controls.Add(this.tOldPassword);
            this.gPassword.Location = new System.Drawing.Point(22, 169);
            this.gPassword.Name = "gPassword";
            this.gPassword.Size = new System.Drawing.Size(242, 175);
            this.gPassword.TabIndex = 0;
            this.gPassword.TabStop = false;
            this.gPassword.Text = "Password";
            // 
            // gName
            // 
            this.gName.Controls.Add(this.label1);
            this.gName.Controls.Add(this.tName);
            this.gName.Location = new System.Drawing.Point(22, 24);
            this.gName.Name = "gName";
            this.gName.Size = new System.Drawing.Size(242, 96);
            this.gName.TabIndex = 1;
            this.gName.TabStop = false;
            this.gName.Text = "Name";
            // 
            // gSystem
            // 
            this.gSystem.Controls.Add(this.label6);
            this.gSystem.Controls.Add(this.tAddress);
            this.gSystem.Controls.Add(this.label7);
            this.gSystem.Controls.Add(this.tPhone);
            this.gSystem.Controls.Add(this.label5);
            this.gSystem.Controls.Add(this.tStore);
            this.gSystem.Location = new System.Drawing.Point(25, 28);
            this.gSystem.Name = "gSystem";
            this.gSystem.Size = new System.Drawing.Size(242, 294);
            this.gSystem.TabIndex = 2;
            this.gSystem.TabStop = false;
            this.gSystem.Text = "System";
            // 
            // cName
            // 
            this.cName.AutoSize = true;
            this.cName.Location = new System.Drawing.Point(6, 6);
            this.cName.Name = "cName";
            this.cName.Size = new System.Drawing.Size(93, 17);
            this.cName.TabIndex = 2;
            this.cName.Text = "change Name";
            this.cName.UseVisualStyleBackColor = true;
            this.cName.CheckedChanged += new System.EventHandler(this.cName_CheckedChanged);
            // 
            // cPassword
            // 
            this.cPassword.AutoSize = true;
            this.cPassword.Location = new System.Drawing.Point(6, 146);
            this.cPassword.Name = "cPassword";
            this.cPassword.Size = new System.Drawing.Size(111, 17);
            this.cPassword.TabIndex = 2;
            this.cPassword.Text = "change Password";
            this.cPassword.UseVisualStyleBackColor = true;
            this.cPassword.CheckedChanged += new System.EventHandler(this.cPassword_CheckedChanged);
            // 
            // tOldPassword
            // 
            this.tOldPassword.Location = new System.Drawing.Point(19, 46);
            this.tOldPassword.Name = "tOldPassword";
            this.tOldPassword.PasswordChar = '*';
            this.tOldPassword.Size = new System.Drawing.Size(205, 20);
            this.tOldPassword.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Old Password";
            // 
            // tPassword
            // 
            this.tPassword.Location = new System.Drawing.Point(19, 95);
            this.tPassword.Name = "tPassword";
            this.tPassword.PasswordChar = '*';
            this.tPassword.Size = new System.Drawing.Size(205, 20);
            this.tPassword.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "New Password";
            // 
            // tConfirm
            // 
            this.tConfirm.Location = new System.Drawing.Point(19, 143);
            this.tConfirm.Name = "tConfirm";
            this.tConfirm.PasswordChar = '*';
            this.tConfirm.Size = new System.Drawing.Size(205, 20);
            this.tConfirm.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "New Password Confirm";
            // 
            // tName
            // 
            this.tName.Location = new System.Drawing.Point(19, 43);
            this.tName.Name = "tName";
            this.tName.Size = new System.Drawing.Size(205, 20);
            this.tName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Store Name ";
            // 
            // tStore
            // 
            this.tStore.Location = new System.Drawing.Point(26, 56);
            this.tStore.Name = "tStore";
            this.tStore.Size = new System.Drawing.Size(205, 20);
            this.tStore.TabIndex = 2;
            // 
            // tAddress
            // 
            this.tAddress.Location = new System.Drawing.Point(26, 155);
            this.tAddress.Multiline = true;
            this.tAddress.Name = "tAddress";
            this.tAddress.Size = new System.Drawing.Size(205, 129);
            this.tAddress.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Address";
            // 
            // tPhone
            // 
            this.tPhone.Location = new System.Drawing.Point(26, 105);
            this.tPhone.Name = "tPhone";
            this.tPhone.Size = new System.Drawing.Size(205, 20);
            this.tPhone.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Phone";
            // 
            // cSystem
            // 
            this.cSystem.AutoSize = true;
            this.cSystem.Location = new System.Drawing.Point(11, 8);
            this.cSystem.Name = "cSystem";
            this.cSystem.Size = new System.Drawing.Size(99, 17);
            this.cSystem.TabIndex = 3;
            this.cSystem.Text = "change System";
            this.cSystem.UseVisualStyleBackColor = true;
            this.cSystem.CheckedChanged += new System.EventHandler(this.cSystem_CheckedChanged);
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 500);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tabSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Setting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales :: Setting";
            this.tabSettings.ResumeLayout(false);
            this.tabUser.ResumeLayout(false);
            this.tabUser.PerformLayout();
            this.tabSystem.ResumeLayout(false);
            this.tabSystem.PerformLayout();
            this.gPassword.ResumeLayout(false);
            this.gPassword.PerformLayout();
            this.gName.ResumeLayout(false);
            this.gName.PerformLayout();
            this.gSystem.ResumeLayout(false);
            this.gSystem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabSettings;
        private System.Windows.Forms.TabPage tabUser;
        private System.Windows.Forms.TabPage tabSystem;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox gName;
        private System.Windows.Forms.GroupBox gPassword;
        private System.Windows.Forms.GroupBox gSystem;
        private System.Windows.Forms.CheckBox cName;
        private System.Windows.Forms.CheckBox cPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tConfirm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tOldPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tStore;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tPhone;
        private System.Windows.Forms.CheckBox cSystem;
    }
}