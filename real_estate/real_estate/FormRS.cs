using real_estate.user_control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace real_estate
{
    public partial class FormRS : Form
    {
        public FormRS()
        {
            InitializeComponent();
        }


        void LoadGiaoDien()
        {

        }

        private void tbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEmp_Click(object sender, EventArgs e)
        {
            employee2.BringToFront();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            customer2.BringToFront();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            products1.BringToFront();
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
        }

        private void btnProject_Click(object sender, EventArgs e)
        {
           projects1.BringToFront();
        }

    }
}
