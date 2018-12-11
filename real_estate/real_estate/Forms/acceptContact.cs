using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;
using DAL;

namespace real_estate.Forms
{
    public partial class acceptContact : Form
    {
        public string name { get; set; }
        public string phone { get; set; }
        public string id_prop { get; set; }
        BALTransaction trans = new BALTransaction();
        RealEstateEntities dbs = new RealEstateEntities();
        //public acceptContact()
        //{
        //    InitializeComponent();
        //    load();
        //}
        public acceptContact(string name,string phone, string id_prop)
        {
            this.name = name;
            this.phone = phone;
            this.id_prop = id_prop;
            InitializeComponent();
            load();
        }
        void load()
        {
            
            lbName.Text = name;
            lbPhone.Text = phone;

            var address = trans.getAdress(id_prop).ToList();

            lbCity.Text = address[0].name_town;
            lbDistrict.Text = address[0].name_district;
            lbArea.Text = address[0].name_area;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                trans.updateContact(id_prop,phone);
                MessageBox.Show("Cuộc hẹn đã được chấp nhận !!");
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAcc_Click(object sender, EventArgs e)
        {
            try
            {
                trans.updateContact(id_prop, phone);
                MessageBox.Show("Cuộc hẹn đã được chấp nhận !!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
