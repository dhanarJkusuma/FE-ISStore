﻿using Sales.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sales.libs
{
    public partial class suggestMember : Form
    {
        private String[] sColumns = {
                                        "CAST(" + Member.Columns[0] + " as VARCHAR(255)) as ID ",
                                        Member.Columns[1] + " as Name"
                                    };

        BaseFormSuggest form;
        public suggestMember(BaseFormSuggest form)
        {
            InitializeComponent();
            setData();
            this.form = form;
            rID.Checked = true;
        }

        private void setData() 
        {
            memberGrid.DataSource = Member.Get(sColumns);
            memberGrid.ReadOnly = true;
            memberGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (memberGrid.SelectedRows.Count == 1) 
            {
                Member member = Member.Find(Convert.ToInt64(memberGrid.SelectedRows[0].Cells[0].Value));
                form.populateMember(member);
                this.Dispose();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void tBindGrid_TextChanged(object sender, EventArgs e)
        {
            if (rID.Checked)
            {
                Helper.Data.setBinding(memberGrid, "ID", tBindGrid.Text);
            }
            else
            {
                Helper.Data.setBinding(memberGrid, "Name", tBindGrid.Text);
            }
        }

        private void tBindGrid_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
    }
}
