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
            this.cPassword = new System.Windows.Forms.CheckBox();
            this.cName = new System.Windows.Forms.CheckBox();
            this.gName = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tName = new System.Windows.Forms.TextBox();
            this.gPassword = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tConfirm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tOldPassword = new System.Windows.Forms.TextBox();
            this.tabSystem = new System.Windows.Forms.TabPage();
            this.cSystem = new System.Windows.Forms.CheckBox();
            this.gSystem = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tIncrement = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tStore = new System.Windows.Forms.TextBox();
            this.tAddress = new System.Windows.Forms.TextBox();
            this.tPhone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tabSettings.SuspendLayout();
            this.tabUser.SuspendLayout();
            this.gName.SuspendLayout();
            this.gPassword.SuspendLayout();
            this.tabSystem.SuspendLayout();
            this.gSystem.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.tabUser);
            this.tabSettings.Controls.Add(this.tabSystem);
            this.tabSettings.Location = new System.Drawing.Point(33, 26);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.SelectedIndex = 0;
            this.tabSettings.Size = new System.Drawing.Size(414, 501);
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
            this.tabUser.Size = new System.Drawing.Size(406, 475);
            this.tabUser.TabIndex = 0;
            this.tabUser.Text = "User Setting";
            this.tabUser.UseVisualStyleBackColor = true;
            // 
            // cPassword
            // 
            this.cPassword.AutoSize = true;
            this.cPassword.Location = new System.Drawing.Point(6, 223);
            this.cPassword.Name = "cPassword";
            this.cPassword.Size = new System.Drawing.Size(111, 17);
            this.cPassword.TabIndex = 2;
            this.cPassword.Text = "change Password";
            this.cPassword.UseVisualStyleBackColor = true;
            this.cPassword.CheckedChanged += new System.EventHandler(this.cPassword_CheckedChanged);
            // 
            // cName
            // 
            this.cName.AutoSize = true;
            this.cName.Location = new System.Drawing.Point(6, 61);
            this.cName.Name = "cName";
            this.cName.Size = new System.Drawing.Size(93, 17);
            this.cName.TabIndex = 2;
            this.cName.Text = "change Name";
            this.cName.UseVisualStyleBackColor = true;
            this.cName.CheckedChanged += new System.EventHandler(this.cName_CheckedChanged);
            // 
            // gName
            // 
            this.gName.Controls.Add(this.label1);
            this.gName.Controls.Add(this.tName);
            this.gName.Location = new System.Drawing.Point(22, 79);
            this.gName.Name = "gName";
            this.gName.Size = new System.Drawing.Size(368, 96);
            this.gName.TabIndex = 1;
            this.gName.TabStop = false;
            this.gName.Text = "Name";
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
            // tName
            // 
            this.tName.Location = new System.Drawing.Point(19, 43);
            this.tName.Name = "tName";
            this.tName.Size = new System.Drawing.Size(331, 20);
            this.tName.TabIndex = 0;
            // 
            // gPassword
            // 
            this.gPassword.Controls.Add(this.label4);
            this.gPassword.Controls.Add(this.tConfirm);
            this.gPassword.Controls.Add(this.label3);
            this.gPassword.Controls.Add(this.tPassword);
            this.gPassword.Controls.Add(this.label2);
            this.gPassword.Controls.Add(this.tOldPassword);
            this.gPassword.Location = new System.Drawing.Point(22, 246);
            this.gPassword.Name = "gPassword";
            this.gPassword.Size = new System.Drawing.Size(368, 175);
            this.gPassword.TabIndex = 0;
            this.gPassword.TabStop = false;
            this.gPassword.Text = "Password";
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
            // tConfirm
            // 
            this.tConfirm.Location = new System.Drawing.Point(19, 143);
            this.tConfirm.Name = "tConfirm";
            this.tConfirm.PasswordChar = '*';
            this.tConfirm.Size = new System.Drawing.Size(331, 20);
            this.tConfirm.TabIndex = 0;
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
            // tPassword
            // 
            this.tPassword.Location = new System.Drawing.Point(19, 95);
            this.tPassword.Name = "tPassword";
            this.tPassword.PasswordChar = '*';
            this.tPassword.Size = new System.Drawing.Size(331, 20);
            this.tPassword.TabIndex = 0;
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
            // tOldPassword
            // 
            this.tOldPassword.Location = new System.Drawing.Point(19, 46);
            this.tOldPassword.Name = "tOldPassword";
            this.tOldPassword.PasswordChar = '*';
            this.tOldPassword.Size = new System.Drawing.Size(331, 20);
            this.tOldPassword.TabIndex = 0;
            // 
            // tabSystem
            // 
            this.tabSystem.Controls.Add(this.cSystem);
            this.tabSystem.Controls.Add(this.gSystem);
            this.tabSystem.Location = new System.Drawing.Point(4, 22);
            this.tabSystem.Name = "tabSystem";
            this.tabSystem.Padding = new System.Windows.Forms.Padding(3);
            this.tabSystem.Size = new System.Drawing.Size(406, 475);
            this.tabSystem.TabIndex = 1;
            this.tabSystem.Text = "System Setting";
            this.tabSystem.UseVisualStyleBackColor = true;
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
            // gSystem
            // 
            this.gSystem.Controls.Add(this.groupBox2);
            this.gSystem.Controls.Add(this.groupBox1);
            this.gSystem.Location = new System.Drawing.Point(25, 28);
            this.gSystem.Name = "gSystem";
            this.gSystem.Size = new System.Drawing.Size(350, 441);
            this.gSystem.TabIndex = 2;
            this.gSystem.TabStop = false;
            this.gSystem.Text = "System";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tIncrement);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(15, 325);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(317, 100);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transaction Setting";
            // 
            // tIncrement
            // 
            this.tIncrement.Location = new System.Drawing.Point(33, 48);
            this.tIncrement.Name = "tIncrement";
            this.tIncrement.Size = new System.Drawing.Size(264, 20);
            this.tIncrement.TabIndex = 4;
            this.tIncrement.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tIncrement_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Increment Point per Transaction";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tStore);
            this.groupBox1.Controls.Add(this.tAddress);
            this.groupBox1.Controls.Add(this.tPhone);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(15, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 300);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Store Setting";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Store Name ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Address";
            // 
            // tStore
            // 
            this.tStore.Location = new System.Drawing.Point(28, 51);
            this.tStore.Name = "tStore";
            this.tStore.Size = new System.Drawing.Size(264, 20);
            this.tStore.TabIndex = 2;
            // 
            // tAddress
            // 
            this.tAddress.Location = new System.Drawing.Point(28, 150);
            this.tAddress.Multiline = true;
            this.tAddress.Name = "tAddress";
            this.tAddress.Size = new System.Drawing.Size(264, 129);
            this.tAddress.TabIndex = 2;
            // 
            // tPhone
            // 
            this.tPhone.Location = new System.Drawing.Point(28, 100);
            this.tPhone.Name = "tPhone";
            this.tPhone.Size = new System.Drawing.Size(264, 20);
            this.tPhone.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Phone";
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(238, 533);
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
            this.btnSave.Location = new System.Drawing.Point(142, 533);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 73);
            this.btnSave.TabIndex = 1;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 618);
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
            this.gName.ResumeLayout(false);
            this.gName.PerformLayout();
            this.gPassword.ResumeLayout(false);
            this.gPassword.PerformLayout();
            this.tabSystem.ResumeLayout(false);
            this.tabSystem.PerformLayout();
            this.gSystem.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tIncrement;
        private System.Windows.Forms.Label label8;
    }
}