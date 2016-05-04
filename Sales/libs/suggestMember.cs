using Sales.model;
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
                                        Member.Columns[0] + " as ID",
                                        Member.Columns[1] + " as Name"
                                    };

        BaseFormSuggest form;
        public suggestMember(Point point, BaseFormSuggest form)
        {
            InitializeComponent();
            setData();
            this.Location = point;
            this.form = form;
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
            this.Dispose();
        }
    }
}
