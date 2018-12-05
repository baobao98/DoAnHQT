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
namespace real_estate
{
    public partial class Appointmentt : Form
    {
        BALAppointment appo = new BALAppointment();
        BALCustomer cus = new BALCustomer();
        static string idcus;
        public int id_app { get; set; }
        public bool check { get; set; }
        public Appointmentt()
        {
            InitializeComponent();
        }
        public Appointmentt(string id_cus)
        {
            idcus = id_cus;
        }

        private void Appointmentt_Load(object sender, EventArgs e)
        {
           
            Loadcombo();
           
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void comboBoxIDCus_SelectedIndexChanged(object sender, EventArgs e)
        {       
        }

        private void comboBoxIDCus_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBoxIDCus_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }
        void Loadcombo()
        {
            comboBoxIDCus.DataSource = cus.GetCustomer();
            comboBoxIDCus.DisplayMember = "name_cus";
            comboBoxIDCus.ValueMember = "id_cus";
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (check)
            {
                //create
                appo.CreateAppo(txtDes.Text, txtStatus.Text, comboBoxIDCus.SelectedValue.ToString(), dateTimeAppo.Value.Date);
                MessageBox.Show("Create Thành Công !!");
            }
            else
            {//update
                SetAppointment set = new SetAppointment();
                appo.UpdateAppo(id_app, txtDes.Text, txtStatus.Text, comboBoxIDCus.SelectedValue.ToString(), dateTimeAppo.Value.Date);
                MessageBox.Show("Update thành công!!");
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtDes.ResetText();
            txtStatus.ResetText();
            dateTimeAppo.ResetText();
        }
    }

}
