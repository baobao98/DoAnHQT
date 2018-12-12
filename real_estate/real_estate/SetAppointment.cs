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
    public partial class SetAppointment : Form
    {
        BALAppointment appo = new BALAppointment();
        private void panel4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public SetAppointment()
        {
            InitializeComponent();
        }
        public void SetAppointment_Load(object sender, EventArgs e)
        {
            ShowAppo();
        }
        void ShowAppo()
        {
            dgvSetAppo.DataSource = appo.GetAllAppo();
           
        }
        private void dgvSetAppo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public int IDstr()
        {
            int r = dgvSetAppo.CurrentCell.RowIndex;
            string strID = dgvSetAppo.Rows[r].Cells[0].Value.ToString();
            int id = Int32.Parse(strID);
            return id;
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            int r = dgvSetAppo.CurrentCell.RowIndex;
            int id = int.Parse(dgvSetAppo.Rows[r].Cells[0].Value.ToString());
            Appointmentt fm = new Appointmentt();
            fm.check = false;
            fm.id_app = id;
            fm.ShowDialog();
            ShowAppo();

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int r = dgvSetAppo.CurrentCell.RowIndex;
            int strID = Int32.Parse(dgvSetAppo.Rows[r].Cells[0].Value.ToString());
            appo.DeleteAppo(strID);
            ShowAppo();
            MessageBox.Show("Delete Thành công!", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); 
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Appointmentt fm = new Appointmentt();
            fm.check = true;
            fm.ShowDialog();
            ShowAppo();
        }
    }
}
