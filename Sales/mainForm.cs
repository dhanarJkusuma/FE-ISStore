using Sales.libs;
using Sales.model;
using Sales.report_model;
using Sales.ui.data.member;
using Sales.ui.data.supplier;
using Sales.ui.inventory.category;
using Sales.ui.inventory.master_item;
using Sales.ui.inventory.master_stock;
using Sales.ui.inventory.stock_alert;
using Sales.ui.inventory.unit;
using Sales.ui.report;
using Sales.ui.report.down10;
using Sales.ui.report.incoming_item;
using Sales.ui.report.payment;
using Sales.ui.report.profit;
using Sales.ui.report.top10;
using Sales.ui.setting;
using Sales.ui.transaction.draft_incoming_item;
using Sales.ui.transaction.incoming_item;
using Sales.ui.transaction.payment;
using Sales.ui.users.auth;
using Sales.ui.users.group;
using Sales.ui.users.users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sales
{
    public partial class mainForm : Form
    {
        private List<Sales.model.SalesMenu.CompareRole> role;
        private List<Sales.model.SalesMenu.CompareRole> roleLv2;
        
        public mainForm()
        {
            InitializeComponent();
            tName.Text = VariableBuilder.Session.userLogged.Name;
            role = SalesMenu.getAuth(VariableBuilder.Session.userLogged.Group, 0);
            
            settingMenu();
            settingBtn();
            timer.Start();
            setChart();

        }

        private void btnUnit_Click(object sender, EventArgs e)
        {
            unitForm unit = new unitForm();
            Helper.Forms.startForm(unit);
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            categoryForm category = new categoryForm();
            Helper.Forms.startForm(category);
        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            itemForm item = new itemForm();
            Helper.Forms.startForm(item);
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            stockForm stock = new stockForm();
            Helper.Forms.startForm(stock);
        }

        private void btnAlert_Click(object sender, EventArgs e)
        {
            alertForm alert = new alertForm();
            Helper.Forms.startForm(alert);
        }

        private void btnIncomeItem_Click(object sender, EventArgs e)
        {
            incomeItemForm incomingItem = new incomeItemForm();
            Helper.Forms.startForm(incomingItem);
        }

        private void btnGroup_Click(object sender, EventArgs e)
        {
            groupForm group = new groupForm();
            Helper.Forms.startForm(group);
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            usersForm users = new usersForm();
            Helper.Forms.startForm(users);
        }

        private void btnListIncome_Click(object sender, EventArgs e)
        {
            listIncomingItem listIncome = new listIncomingItem();
            Helper.Forms.startForm(listIncome);
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            memberForm member = new memberForm();
            Helper.Forms.startForm(member);
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            supplierForm supplier = new supplierForm();
            Helper.Forms.startForm(supplier);
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            paymentForm payment = new paymentForm();
            Helper.Forms.startForm(payment);
        }

        private void setValueMenu(String root) 
        {
            if (roleLv2 != null)
            {
                roleLv2.Clear();
                roleLv2 = SalesMenu.getAuth(VariableBuilder.Session.userLogged.Group, 1, root);
            }
            else 
            {
                roleLv2 = SalesMenu.getAuth(VariableBuilder.Session.userLogged.Group, 1, root);
            }
        }

        private void settingBtn() 
        {
            setValueMenu("T001");
            Sales.model.SalesMenu.CompareRole rlz;
            rlz = roleLv2.Find(rl => rl.MenuID == "T001B1");
            if (rlz.isActived == 1)
            {
                btnGroup.Enabled = true;
            }
            else 
            {
                btnGroup.Enabled = false;
            }

            rlz = roleLv2.Find(rl => rl.MenuID == "T001B2");
            if (rlz.isActived == 1)
            {
                btnUser.Enabled = true;
            }
            else
            {
                btnUser.Enabled = false;
            }

            rlz = roleLv2.Find(rl => rl.MenuID == "T001B3");
            if (rlz.isActived == 1)
            {
                btnAuth.Enabled = true;
            }
            else
            {
                btnAuth.Enabled = false;
            }

            setValueMenu("T002");
            rlz = roleLv2.Find(rl => rl.MenuID == "T002B1");
            if (rlz.isActived == 1)
            {
                btnMember.Enabled = true;
            }
            else
            {
                btnMember.Enabled = false;
            }

            rlz = roleLv2.Find(rl => rl.MenuID == "T002B2");
            if (rlz.isActived == 1)
            {
                btnSupplier.Enabled = true;
            }
            else
            {
                btnSupplier.Enabled = false;
            }

            setValueMenu("T003");
            rlz = roleLv2.Find(rl => rl.MenuID == "T003B1");
            if (rlz.isActived == 1)
            {
                btnUnit.Enabled = true;
            }
            else
            {
                btnUnit.Enabled = false;
            }

            rlz = roleLv2.Find(rl => rl.MenuID == "T003B2");
            if (rlz.isActived == 1)
            {
                btnCategory.Enabled = true;
            }
            else
            {
                btnCategory.Enabled = false;
            }
            rlz = roleLv2.Find(rl => rl.MenuID == "T003B3");
            if (rlz.isActived == 1)
            {
                btnItem.Enabled = true;
            }
            else
            {
                btnItem.Enabled = false;
            }

            rlz = roleLv2.Find(rl => rl.MenuID == "T003B4");
            if (rlz.isActived == 1)
            {
                btnStock.Enabled = true;
            }
            else
            {
                btnStock.Enabled = false;
            }
            rlz = roleLv2.Find(rl => rl.MenuID == "T003B5");
            if (rlz.isActived == 1)
            {
                btnAlert.Enabled = true;
            }
            else
            {
                btnAlert.Enabled = false;
            }

            setValueMenu("T004");
            rlz = roleLv2.Find(rl => rl.MenuID == "T004B1");
            if (rlz.isActived == 1)
            {
                btnIncomeItem.Enabled = true;
            }
            else
            {
                btnIncomeItem.Enabled = false;
            }

            rlz = roleLv2.Find(rl => rl.MenuID == "T004B2");
            if (rlz.isActived == 1)
            {
                btnListIncome.Enabled = true;
            }
            else
            {
                btnListIncome.Enabled = false;
            }
            rlz = roleLv2.Find(rl => rl.MenuID == "T004B3");
            if (rlz.isActived == 1)
            {
                btnPayment.Enabled = true;
            }
            else
            {
                btnPayment.Enabled = false;
            }

        }

        private void settingMenu() 
        {
            
            foreach (TabPage page in tabMenu.TabPages)
            {
                switch (page.Name)
                {
                    case "tabUser":
                        if (role.Find(r => r.MenuID == "T001").isActived == 1)
                        {
                            foreach (Control ctl in page.Controls)
                            {
                                ctl.Enabled = true;
                            }
                        }
                        else
                        {
                            foreach (Control ctl in page.Controls)
                            {
                                ctl.Enabled = false;
                            }
                        }
                        break;

                    case "tabData":
                        if (role.Find(r => r.MenuID == "T002").isActived == 1)
                        {
                            foreach (Control ctl in page.Controls)
                            {
                                ctl.Enabled = true;
                            }
                        }
                        else
                        {
                            foreach (Control ctl in page.Controls)
                            {
                                ctl.Enabled = false;
                            }
                        }
                        break;
                    case "tabInventory":
                        if (role.Find(r => r.MenuID == "T003").isActived == 1)
                        {
                            foreach (Control ctl in page.Controls)
                            {
                                ctl.Enabled = true;
                            }
                        }
                        else
                        {
                            foreach (Control ctl in page.Controls)
                            {
                                ctl.Enabled = false;
                            }
                        }
                        break;
                    case "tabTransaction":
                        if (role.Find(r => r.MenuID == "T004").isActived == 1)
                        {
                            foreach (Control ctl in page.Controls)
                            {
                                ctl.Enabled = true;
                            }
                        }
                        else
                        {
                            foreach (Control ctl in page.Controls)
                            {
                                ctl.Enabled = false;
                            }
                        }
                        break;
                }
            }                
                    
            
            
                
                
            
        }

        private void btnAuth_Click(object sender, EventArgs e)
        {
            authForm auth = new authForm();
            Helper.Forms.startForm(auth);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to Log Out?", "Dialog Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void tabMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnStockRep_Click(object sender, EventArgs e)
        {
            stockReport stockRep = new stockReport();
            Helper.Forms.startForm(stockRep);
        }

        private void btnProfitReport_Click(object sender, EventArgs e)
        {
            profitForm profitRep = new profitForm();
            Helper.Forms.startForm(profitRep);
        }

        private void btnTop_Click(object sender, EventArgs e)
        {
            topItemForm topItem = new topItemForm();
            Helper.Forms.startForm(topItem);
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            downItemForm downItem = new downItemForm();
            Helper.Forms.startForm(downItem);
        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            incomingRpt incomeRp = new incomingRpt();
            Helper.Forms.startForm(incomeRp);
        }

        private void btnPaymentRpt_Click(object sender, EventArgs e)
        {
            paymentList paymentRp = new paymentList();
            Helper.Forms.startForm(paymentRp);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            ltime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void setChart() 
        {
            int SecondMonth = Convert.ToInt32(DateTime.Now.ToString("MM"));
            int FirstMonth = Convert.ToInt32(DateTime.Now.ToString("MM"))-10;
            if (SecondMonth < FirstMonth) 
            {
                FirstMonth = FirstMonth * -1;
            }
            int FirstYear = Convert.ToInt32(DateTime.Now.ToString("yyyy"));
            int SecondYear = (SecondMonth < FirstMonth) ? FirstYear - 1 : FirstYear;

            profitChart.DataSource = Profit.getData(FirstMonth, SecondMonth, FirstYear, SecondYear);
            profitChart.Series["profit"].XValueMember = "dateMonth";
            profitChart.Series["profit"].YValueMembers = "dprofit";
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            Setting setting = new Setting();
            Helper.Forms.startForm(setting);
        }
    }
}
