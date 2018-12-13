using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using real_estate.user_control;
using BAL;
namespace real_estate.Forms
{
    public partial class FormProperty : Form
    {
        RealEstateEntities dbs = new RealEstateEntities();
        BALTransaction trans = new BALTransaction();
        public string sId_cus { get; set; }
        public string sPayment { get; set; }

        //public FormProperty()
        //{
        //    InitializeComponent();
        //    load();
        //}
        public FormProperty(string id_cus, string payment)
        {
            InitializeComponent();
            this.sId_cus = id_cus;
            this.sPayment = payment;
            load();
        }
        void load()
        {
            var prop = (from pro in dbs.properties
                        select pro );
            dgvProperty.AutoGenerateColumns = false;
            dgvProperty.DataSource = prop.ToList();
            
            //Transaction trans = new Transaction();
            //trans.sAmount = float.Parse(dgvProperty.CurrentCell.Value.ToString());
            //trans.sId_prop = dgvProperty.CurrentCell.Value.ToString();
            //this.Close();
        }

        private void FormProperty_Load(object sender, EventArgs e)
        {
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            float amou = float.Parse(dgvProperty.CurrentRow.Cells[3].Value.ToString());
            string idProp = dgvProperty.CurrentRow.Cells[0].Value.ToString();
            try
            {
                //trans.spinsertTrans(idProp, sId_cus, amou, sPayment);
                trans.spinsertTrans(idProp, sId_cus, amou, sPayment);
                MessageBox.Show("Insert Done !!");
                Transaction t= new Transaction();
                t.Show();
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
