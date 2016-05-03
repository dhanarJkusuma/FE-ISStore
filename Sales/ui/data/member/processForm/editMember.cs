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
    public partial class editMember : Form
    {
        List<Sales.model.Region.Provinces> provinces;
        List<Sales.model.Region.Regencies> regencies;
        List<Sales.model.Region.Districts> districts;
        List<Sales.model.Region.Villages> villages;
        private BaseForm home;

        private Member currentMember;

        internal Member CurrentMember
        {
            get { return currentMember; }
            set { currentMember = value; }
        }
        
        public editMember(BaseForm home)
        {
            InitializeComponent();
            this.home = home;
            
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
                cReg.SelectedItem = regencies.Find(regency => regency.Code == CurrentMember.RegCode).Name;  
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
                cDis.SelectedItem = districts.Find(district => district.Code == CurrentMember.DisCode).Name;
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
                cVill.SelectedItem = villages.Find(village => village.Code == CurrentMember.VillCode).Name;

            }
        }

        private void cVill_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void editMember_Load(object sender, EventArgs e)
        {
            getInitalData();
        }

        private void getInitalData()
        {
            tNo.Text = CurrentMember.Id.ToString();
            tName.Text = CurrentMember.Name;
            tTelp.Text = CurrentMember.Telp;
            tAddress.Text = CurrentMember.Address;
            //Give Value to combobox provinces
            provinces = Sales.model.Region.FillProvinces(cProv);
            //Default Selected Item to first selection
            if (CurrentMember != null) 
            {
                cProv.SelectedItem = provinces.Find(prov => prov.Code == CurrentMember.ProvCode).Name;   
            }
         
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            CurrentMember.Id = Convert.ToInt64(tNo.Text);
            CurrentMember.Name = tName.Text;
            CurrentMember.Telp = tTelp.Text;
            CurrentMember.Address = tAddress.Text;
            CurrentMember.ProvCode = provinces[cProv.SelectedIndex].Code;
            CurrentMember.RegCode = regencies[cReg.SelectedIndex].Code;
            CurrentMember.DisCode = districts[cDis.SelectedIndex].Code;
            CurrentMember.VillCode = villages[cVill.SelectedIndex].Code;
            CurrentMember.Update();
            this.Dispose();
            home.refreshData();
        }
    }
}
