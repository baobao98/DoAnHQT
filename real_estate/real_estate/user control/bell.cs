using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using real_estate.Forms;
using BAL;

namespace real_estate.user_control
{
    public partial class bell : UserControl
    {
        BALTransaction tran = new BALTransaction();
        public bell()
        {
            InitializeComponent();
            dgvContacts.AdvancedCellBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
            dgvContacts.AdvancedCellBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;
            dgvContacts.RowHeadersVisible = false;
            //this.dgvContacts.Columns[0].HeaderText = "";
            //this.dgvContacts.Columns[1].HeaderText = "";
            //this.dgvContacts.Columns[2].HeaderText = "";
            dgvContacts.AutoGenerateColumns = false;
            dgvContacts.RowTemplate.Height = 30;
            //dgvContacts.rows[0].Height = 1;
            try
            {
                //RealEstateEntities dbs = new RealEstateEntities();
                //var c = (from cus in dbs.contacts
                //         where cus.status == 1
                //         select cus);

                //dgvContacts.DataSource = c.ToList();
                dgvContacts.DataSource = tran.getContact().ToList();
                timer.Start();
            }
            catch (Exception)
            {
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //RealEstateEntities dbs = new RealEstateEntities();
            //var c = (from cus in dbs.contacts
            //         where cus.status == 1
            //         select cus);
            //dgvContacts.DataSource = c.ToList();
            dgvContacts.DataSource = tran.getContact().ToList();
        }

        private void dgvContacts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //acceptContact acc = new acceptContact();
            //acc.id_prop = dgvContacts.CurrentRow.Cells[2].Value.ToString();
            //acc.phone = dgvContacts.CurrentRow.Cells[1].Value.ToString();
            //acc.name = dgvContacts.CurrentRow.Cells[0].Value.ToString();

            string id_prop = dgvContacts.CurrentRow.Cells[2].Value.ToString();
            string phone = dgvContacts.CurrentRow.Cells[1].Value.ToString();
            string name = dgvContacts.CurrentRow.Cells[0].Value.ToString();
            acceptContact acc = new acceptContact(name,phone,id_prop);

            acc.Show();
        }
    }
}
