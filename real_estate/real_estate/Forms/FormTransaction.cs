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
    public partial class FormTransaction : Form
    {
        public string id_cus { get; set; }
        public string id_prop { get; set; }

        BALTransaction tran = new BALTransaction();
        //public FormTransaction()
        //{
        //    InitializeComponent();
        //    //load();
        //}
        public FormTransaction(string id_cus, string id_prop)
        {
            InitializeComponent();
            this.id_cus = id_cus;
            this.id_prop = id_prop;
            load();
        }

        void load()
        {
            RealEstateEntities dbs = new RealEstateEntities();

            this.lbIdCus.Text = id_cus;
            this.lbIdProp.Text = id_prop;
            //t.customer
            var cus = tran.getCustomer(id_cus).ToList();
            var prop = tran.getProperty(id_prop).ToList();

            this.lbName.Text = cus[0].name_cus;
            this.lbDate.Text = cus[0].create_date.ToString();
            this.lbPhone.Text = cus[0].phone_cus;
            lbRoom.Text = prop[0].room.ToString();
            lbPrice.Text = prop[0].price.ToString();
        }

        private void FormTransaction_Load(object sender, EventArgs e)
        {
            load();
        }
    }
}
