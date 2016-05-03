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

namespace Sales.ui.data.supplier.processForm
{
    public partial class editSupplier : Form
    {
        List<Sales.model.Region.Provinces> provinces;
        List<Sales.model.Region.Regencies> regencies;
        List<Sales.model.Region.Districts> districts;
        List<Sales.model.Region.Villages> villages;
        BaseForm home;
        private Supplier currentSupplier;

     

        internal Supplier CurrentSupplier
        {
            get { return currentSupplier; }
            set { currentSupplier = value; }
        }
        public editSupplier(BaseForm home)
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
                cReg.SelectedItem = regencies.Find(regency => regency.Code == CurrentSupplier.RegCode).Name;
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
                cDis.SelectedItem = districts.Find(district => district.Code == CurrentSupplier.DisCode).Name;
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
                cVill.SelectedItem = villages.Find(village => village.Code == CurrentSupplier.VillCode).Name;

            }
        }


        private void getInitalData()
        {
            tNo.Text = CurrentSupplier.No;
            tName.Text = CurrentSupplier.Name;
            tDesc.Text = CurrentSupplier.Desc;
            tTelp.Text = CurrentSupplier.Telp;
            tAddress.Text = CurrentSupplier.Address;
            //Give Value to combobox provinces
            provinces = Sales.model.Region.FillProvinces(cProv);
            //Default Selected Item to first selection
            if (CurrentSupplier != null)
            {
                cProv.SelectedItem = provinces.Find(prov => prov.Code == CurrentSupplier.ProvCode).Name;
            }

        }

        private void editSuppliercs_Load(object sender, EventArgs e)
        {
            getInitalData();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            CurrentSupplier.No = tNo.Text;
            CurrentSupplier.Name = tName.Text;
            CurrentSupplier.Desc = tDesc.Text;
            CurrentSupplier.Telp = tTelp.Text;
            CurrentSupplier.Address = tAddress.Text;
            CurrentSupplier.ProvCode = provinces[cProv.SelectedIndex].Code;
            CurrentSupplier.RegCode = regencies[cReg.SelectedIndex].Code;
            CurrentSupplier.DisCode = districts[cDis.SelectedIndex].Code;
            CurrentSupplier.VillCode = villages[cVill.SelectedIndex].Code;
            CurrentSupplier.Update();
            this.Dispose();
            home.refreshData();
        }

    }
}
