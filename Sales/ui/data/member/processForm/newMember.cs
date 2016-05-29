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


namespace Sales.ui.data.member.processForm
{
    public partial class newMember : Form
    {
        List<Sales.model.Region.Provinces> provinces;
        List<Sales.model.Region.Regencies> regencies;
        List<Sales.model.Region.Districts> districts;
        List<Sales.model.Region.Villages> villages;
        private BaseForm home;
        public newMember(BaseForm home)
        {
            InitializeComponent();
            getInitalData();
            this.home = home;
        }

        private void newMember_Load(object sender, EventArgs e)
        {

        }

        private void getInitalData() 
        {
            //Give Value to combobox provinces
            provinces = Sales.model.Region.FillProvinces(cProv);
            //Default Selected Item to first selection
            cProv.SelectedIndex = 0;
        }

        private void cProv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (regencies != null) 
            {
                //clear value dan combo box text
                regencies.Clear();
                cReg.Items.Clear();
                //fill combo box regencies
                regencies = Sales.model.Region.FillRegencies(provinces[cProv.SelectedIndex], cReg);
                //Default Selected Item to first selection
                cReg.SelectedIndex = 0;
            }
            else 
            {
                //fill combo box regencies
                regencies = Sales.model.Region.FillRegencies(provinces[cProv.SelectedIndex], cReg);
                //Default Selected Item to first selection
                cReg.SelectedIndex = 0;
            }
            
        }

        private void cReg_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (districts != null)
            {
                districts.Clear();
                cDis.Items.Clear();
                districts = Sales.model.Region.FillDistricts(regencies[cReg.SelectedIndex], cDis);
                cDis.SelectedIndex = 0;

            }
            else 
            {
                districts = Sales.model.Region.FillDistricts(regencies[cReg.SelectedIndex], cDis);
                cDis.SelectedIndex = 0;
            }
        }

        private void cDis_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (villages != null)
            {
                villages.Clear();
                cVill.Items.Clear();
                villages = Sales.model.Region.FillVillages(districts[cDis.SelectedIndex], cVill);
                cVill.SelectedIndex = 0;
            }
            else 
            {
                villages = Sales.model.Region.FillVillages(districts[cDis.SelectedIndex], cVill);
                cVill.SelectedIndex = 0;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Member member = new Member();
            member.Id = Convert.ToInt64(tNo.Text);
            member.Name = tName.Text;
            member.Telp = tTelp.Text;
            member.Address = tAddress.Text;
            member.ProvCode = provinces[cProv.SelectedIndex].Code;
            member.RegCode = regencies[cReg.SelectedIndex].Code;
            member.DisCode = districts[cDis.SelectedIndex].Code;
            member.VillCode = villages[cVill.SelectedIndex].Code;
            member.Insert();
            this.Dispose();
            home.refreshData();

        }
    }
}
