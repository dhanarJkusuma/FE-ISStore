namespace Sales.ui.report.profit
{
    partial class profitForm
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
            this.rTrans = new System.Windows.Forms.RadioButton();
            this.rMonth = new System.Windows.Forms.RadioButton();
            this.secondDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.firstDate = new System.Windows.Forms.DateTimePicker();
            this.getProfitTrans = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.transGroup = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.getProfitMonth = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cFirstDate = new System.Windows.Forms.ComboBox();
            this.cSecondDate = new System.Windows.Forms.ComboBox();
            this.cEndYear = new System.Windows.Forms.ComboBox();
            this.cFirstYear = new System.Windows.Forms.ComboBox();
            this.monthGroup = new System.Windows.Forms.GroupBox();
            this.transGroup.SuspendLayout();
            this.monthGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // rTrans
            // 
            this.rTrans.AutoSize = true;
            this.rTrans.Location = new System.Drawing.Point(13, 12);
            this.rTrans.Name = "rTrans";
            this.rTrans.Size = new System.Drawing.Size(14, 13);
            this.rTrans.TabIndex = 4;
            this.rTrans.TabStop = true;
            this.rTrans.UseVisualStyleBackColor = true;
            this.rTrans.CheckedChanged += new System.EventHandler(this.rTrans_CheckedChanged);
            // 
            // rMonth
            // 
            this.rMonth.AutoSize = true;
            this.rMonth.Location = new System.Drawing.Point(16, 185);
            this.rMonth.Name = "rMonth";
            this.rMonth.Size = new System.Drawing.Size(14, 13);
            this.rMonth.TabIndex = 4;
            this.rMonth.TabStop = true;
            this.rMonth.UseVisualStyleBackColor = true;
            this.rMonth.CheckedChanged += new System.EventHandler(this.rMonth_CheckedChanged);
            // 
            // secondDate
            // 
            this.secondDate.Location = new System.Drawing.Point(39, 124);
            this.secondDate.Name = "secondDate";
            this.secondDate.Size = new System.Drawing.Size(200, 20);
            this.secondDate.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "End Date";
            // 
            // firstDate
            // 
            this.firstDate.Location = new System.Drawing.Point(39, 49);
            this.firstDate.Name = "firstDate";
            this.firstDate.Size = new System.Drawing.Size(200, 20);
            this.firstDate.TabIndex = 0;
            // 
            // getProfitTrans
            // 
            this.getProfitTrans.Location = new System.Drawing.Point(276, 49);
            this.getProfitTrans.Name = "getProfitTrans";
            this.getProfitTrans.Size = new System.Drawing.Size(95, 95);
            this.getProfitTrans.TabIndex = 2;
            this.getProfitTrans.Text = "Get Data";
            this.getProfitTrans.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.getProfitTrans.UseVisualStyleBackColor = true;
            this.getProfitTrans.Click += new System.EventHandler(this.getProfitTrans_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Date";
            // 
            // transGroup
            // 
            this.transGroup.Controls.Add(this.label1);
            this.transGroup.Controls.Add(this.getProfitTrans);
            this.transGroup.Controls.Add(this.firstDate);
            this.transGroup.Controls.Add(this.label2);
            this.transGroup.Controls.Add(this.secondDate);
            this.transGroup.Location = new System.Drawing.Point(33, 12);
            this.transGroup.Name = "transGroup";
            this.transGroup.Size = new System.Drawing.Size(397, 167);
            this.transGroup.TabIndex = 3;
            this.transGroup.TabStop = false;
            this.transGroup.Text = "Transaction Profit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "End Month";
            // 
            // getProfitMonth
            // 
            this.getProfitMonth.Location = new System.Drawing.Point(273, 45);
            this.getProfitMonth.Name = "getProfitMonth";
            this.getProfitMonth.Size = new System.Drawing.Size(95, 95);
            this.getProfitMonth.TabIndex = 2;
            this.getProfitMonth.Text = "Get Data";
            this.getProfitMonth.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.getProfitMonth.UseVisualStyleBackColor = true;
            this.getProfitMonth.Click += new System.EventHandler(this.getProfitMonth_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "First Month";
            // 
            // cFirstDate
            // 
            this.cFirstDate.BackColor = System.Drawing.Color.White;
            this.cFirstDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cFirstDate.FormattingEnabled = true;
            this.cFirstDate.Location = new System.Drawing.Point(27, 54);
            this.cFirstDate.Name = "cFirstDate";
            this.cFirstDate.Size = new System.Drawing.Size(148, 21);
            this.cFirstDate.TabIndex = 3;
            // 
            // cSecondDate
            // 
            this.cSecondDate.BackColor = System.Drawing.Color.White;
            this.cSecondDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cSecondDate.FormattingEnabled = true;
            this.cSecondDate.Location = new System.Drawing.Point(27, 119);
            this.cSecondDate.Name = "cSecondDate";
            this.cSecondDate.Size = new System.Drawing.Size(148, 21);
            this.cSecondDate.TabIndex = 3;
            // 
            // cEndYear
            // 
            this.cEndYear.BackColor = System.Drawing.Color.White;
            this.cEndYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cEndYear.FormattingEnabled = true;
            this.cEndYear.Location = new System.Drawing.Point(181, 119);
            this.cEndYear.Name = "cEndYear";
            this.cEndYear.Size = new System.Drawing.Size(73, 21);
            this.cEndYear.TabIndex = 3;
            // 
            // cFirstYear
            // 
            this.cFirstYear.BackColor = System.Drawing.Color.White;
            this.cFirstYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cFirstYear.FormattingEnabled = true;
            this.cFirstYear.Location = new System.Drawing.Point(181, 54);
            this.cFirstYear.Name = "cFirstYear";
            this.cFirstYear.Size = new System.Drawing.Size(73, 21);
            this.cFirstYear.TabIndex = 3;
            // 
            // monthGroup
            // 
            this.monthGroup.Controls.Add(this.cFirstYear);
            this.monthGroup.Controls.Add(this.cEndYear);
            this.monthGroup.Controls.Add(this.cSecondDate);
            this.monthGroup.Controls.Add(this.cFirstDate);
            this.monthGroup.Controls.Add(this.label3);
            this.monthGroup.Controls.Add(this.getProfitMonth);
            this.monthGroup.Controls.Add(this.label4);
            this.monthGroup.Location = new System.Drawing.Point(36, 185);
            this.monthGroup.Name = "monthGroup";
            this.monthGroup.Size = new System.Drawing.Size(394, 167);
            this.monthGroup.TabIndex = 3;
            this.monthGroup.TabStop = false;
            this.monthGroup.Text = "Month Profit";
            // 
            // profitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 380);
            this.Controls.Add(this.rTrans);
            this.Controls.Add(this.rMonth);
            this.Controls.Add(this.monthGroup);
            this.Controls.Add(this.transGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "profitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales :: Report :: Profit";
            this.Load += new System.EventHandler(this.profitForm_Load);
            this.transGroup.ResumeLayout(false);
            this.transGroup.PerformLayout();
            this.monthGroup.ResumeLayout(false);
            this.monthGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rTrans;
        private System.Windows.Forms.RadioButton rMonth;
        private System.Windows.Forms.DateTimePicker secondDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker firstDate;
        private System.Windows.Forms.Button getProfitTrans;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox transGroup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button getProfitMonth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cFirstDate;
        private System.Windows.Forms.ComboBox cSecondDate;
        private System.Windows.Forms.ComboBox cEndYear;
        private System.Windows.Forms.ComboBox cFirstYear;
        private System.Windows.Forms.GroupBox monthGroup;

    }
}