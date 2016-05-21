using Sales.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sales.ui.users.auth
{
    public partial class authForm : Form
    {
        private List<Group> listGroup;
        private List<Sales.model.SalesMenu.Role> roleList;
        public authForm()
        {
            InitializeComponent();
            listGroup = Group.FillComboBox(cGroup);

        }

        private void authTree_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Checked)
            {
                roleList.Find(role => role.MenuID == e.Node.Name).IsActived = 1;
                    
                    List<Sales.model.SalesMenu.Role> child = roleList.FindAll(role => role.RootMenu == e.Node.Name);
                    for (int i = 0; i < child.Count; i++)
                    {
                            e.Node.Nodes[i].Checked = true;
                    }
                
            }
            else 
            {
                roleList.Find(role => role.MenuID == e.Node.Name).IsActived = 0;
                    
                        List<Sales.model.SalesMenu.Role> child = roleList.FindAll(role => role.RootMenu == e.Node.Name);
                        for (int i = 0; i < child.Count; i++)
                        {
                            e.Node.Nodes[i].Checked = false;
                        }
                    
                
            }
              
        }

        private void authForm_Load(object sender, EventArgs e)
        {
            cGroup.SelectedIndex = 0;
         //       roleList=SalesMenu.fillTreeView(authTree, listGroup[cGroup.SelectedIndex].Id);
            
        }

        private void cGroup_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (roleList != null) { roleList.Clear(); authTree.Nodes.Clear(); }
                roleList = SalesMenu.fillTreeView(authTree, listGroup[cGroup.SelectedIndex].Id);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < roleList.Count; i++) 
            {
                roleList[i].Update();
                this.Dispose();
            }
        }
    }
}
