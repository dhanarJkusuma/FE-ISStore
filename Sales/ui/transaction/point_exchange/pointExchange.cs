using Sales.libs;
using Sales.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sales.ui.transaction.point_exchange
{
    public partial class pointExchange : Form
    {

        private Member member;
        public pointExchange()
        {
            InitializeComponent();
            Helper.Forms.setPlaceHolder(tIdMember, "ID MEMBER");
            

            itemGrid.DataSource = Gift.All();
            itemGrid.ReadOnly = true;
            itemGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            itemGrid.Columns[0].Visible = false;
            itemGrid.Columns[3].Visible = false;
            itemGrid.Columns[4].Visible = false;
        }

        private void tIdMember_Enter(object sender, EventArgs e)
        {
            Helper.Forms.setFocusPlaceHolder(tIdMember, "ID MEMBER", false);
        }

        private void tIdMember_Leave(object sender, EventArgs e)
        {
            Helper.Forms.setLeavePlaceholder(tIdMember, "ID MEMBER", false);
        }

        private void tIdMember_TextChanged(object sender, EventArgs e)
        {
            
            int memberId;
            if (int.TryParse(tIdMember.Text, out memberId)) 
            {
                member = Member.Find(Convert.ToInt64(tIdMember.Text));
                if (member != null)
                {
                    tName.Text = member.Name;
                    tPoint.Text = member.Point.ToString();
                }
            }
            
            
            
        }

        private void tbind_TextChanged(object sender, EventArgs e)
        {
            Helper.Data.setBinding(itemGrid, "item_name", tbind.Text);
        }

        private void tbind_Enter(object sender, EventArgs e)
        {
         
        }

        private void tbind_Leave(object sender, EventArgs e)
        {
         
        }

        private void btnExchange_Click(object sender, EventArgs e)
        {
            if (itemGrid.SelectedRows.Count == 1) 
            {
                Int64 total = Convert.ToInt64(itemGrid.SelectedRows[0].Cells[2].Value) * Convert.ToInt32(tQty.Text);
                Gift gift = Gift.Find(itemGrid.SelectedRows[0].Cells[0].Value.ToString());
                Int64 check = member.Point - total;
                if (check >= 0)
                {

                    member.Point = check;
                    Int32 stock = gift.Item_stock;
                    gift.Item_stock = stock - Convert.ToInt32(tQty.Text);
                    member.UpdateSilence();
                    gift.UpdateSilence();
                    MessageBox.Show("Exchange Point success");
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Don't enough point.");
                }
            }
        }

        private void pointExchange_Load(object sender, EventArgs e)
        {

        }
    }
}


