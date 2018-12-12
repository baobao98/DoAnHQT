using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;
using real_estate.Forms;
using DAL;

namespace real_estate.user_control
{
    public partial class Transaction : UserControl
    {
        BALTransaction trans = new BALTransaction();
        RealEstateEntities dbs = new RealEstateEntities();
       

        public Transaction()
        {
            InitializeComponent();
            loadData();
        }
        void loadData()
        {
            try
            {
                var list = trans.getListTrans();
                dgvTransaction.DataSource = list;
                dgvTransaction.AutoGenerateColumns = false;
                Loadcombo();
            }
            catch (Exception)
            {

            }
        }

        private void dgvTransaction_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int status = Int32.Parse(dgvTransaction.CurrentRow.Cells[4].Value.ToString());
            if (status == 1)
            {
                string id_prop = dgvTransaction.CurrentRow.Cells[1].Value.ToString();
                string id_cus = dgvTransaction.CurrentRow.Cells[2].Value.ToString();
                string create_date = dgvTransaction.CurrentRow.Cells[6].Value.ToString();
                FormTransaction frm = new FormTransaction(id_cus, id_prop, create_date);
                frm.id_prop = id_prop;
                frm.id_cus = id_cus;
                frm.Show();
            }
            else
                MessageBox.Show("Chưa accept");
        }
        void Loadcombo()
        {
            var cus = (from c in dbs.customers
                       select c);
            cbCustomer.DataSource = cus.ToList();
            cbCustomer.DisplayMember = "name_cus";
            cbCustomer.ValueMember = "id_cus";
        }
        private void btnProp_Click(object sender, EventArgs e)
        {
            FormProperty pro = new FormProperty(cbCustomer.SelectedValue.ToString(),txtPayment.Text);
            pro.Show();
            loadData();
        }


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string id = txtSearch.Text;
            dgvTransaction.DataSource = trans.searcCusTrans(id);
            if (txtSearch.Text == "")
                loadData();
        }
    }
}
