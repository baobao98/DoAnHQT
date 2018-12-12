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
    public partial class VIP : Form
    {
        BALCustomer cus = new BALCustomer();
        public VIP()
        {
            InitializeComponent();
        }

        private void VIP_Load(object sender, EventArgs e)
        {
            ShowCustomerVip();
        }
        void ShowCustomerVip()
        {
            dgvVip.DataSource = cus.GetCustomerVip();
            dgvVip.AutoResizeColumns();
        }

        private void dgvVip_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ptnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
