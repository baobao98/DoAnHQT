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
namespace real_estate.user_control
{
    public partial class Employee : UserControl
    {
        bool add = true;
        //string err;
        string id;
        BALNV nv = new BALNV();
        public Employee()
        {
            InitializeComponent();
        }
        void load()
        {
            try
            {
                //dataGridView1.DataSource = nv.getEmployee();
                dataGridView1.DataSource = nv.getEmployees();
                dataGridView1.AutoResizeColumns();
                //pnThuocTinh.Enabled = false;
                btnSave.Enabled = false;
                btnAdd.Enabled = true;
                btnEdit.Enabled = true;
                btnDelete.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table Employee. Lỗi rồi!!!");
            }
        }
        void textreset()
        {
            //txtId.ResetText();
            txtName.ResetText();
            txtEmail.ResetText();
            txtPhone.ResetText();
            textBox1.ResetText();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            add = true;
            textreset();
           // txtId.Enabled = false   ;
            //pnThuocTinh.Enabled = true;
            btnSave.Enabled = true;
            btnAdd.Enabled = false;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (add)
            {
                try
                {
                    //BALNV nv = new BALNV();
                    //string date = DateTime.Now.ToString();
                    if (txtName.Text == "")
                        txtName.Text = null;
                    //MessageBox.Show(txtName.Text);
                    nv.addEmployee(txtName.Text, txtEmail.Text, txtPhone.Text,Convert.ToDateTime(dateTimePicker1.Text), textBox1.Text);
                    load();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    nv.updateEmployee(id, this.txtName.Text, this.txtEmail.Text, this.txtPhone.Text, Convert.ToDateTime(dateTimePicker1.Text));
                    load();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            add = false;
            //pnThuocTinh.Enabled = true;
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int r = dataGridView1.CurrentCell.RowIndex;
                DialogResult traloi;
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    nv.deleteEmployee(dataGridView1.Rows[r].Cells[0].Value.ToString());
                    // Thông báo
                    load();
                    MessageBox.Show("Đã xóa xong!");
                }
                else
                {
                    // Thông báo
                    MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
                }
            }
            catch
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            load();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            load();
        }

        private void Employee_Load_1(object sender, EventArgs e)
        {
            load();
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridView1.CurrentCell.RowIndex;
            id = dataGridView1.Rows[r].Cells[0].Value.ToString();
            for (int i = 0; i < 7; i++)
                if (dataGridView1.Rows[r].Cells[i].Value == null)
                {
                    dataGridView1.Rows[r].Cells[i].Value = "";
                }
            txtName.Text = dataGridView1.Rows[r].Cells[1].Value.ToString();
            txtEmail.Text = dataGridView1.Rows[r].Cells[2].Value.ToString();
            txtPhone.Text = dataGridView1.Rows[r].Cells[3].Value.ToString();
            textBox1.Text = dataGridView1.Rows[r].Cells[6].Value.ToString();
            if(dataGridView1.Rows[r].Cells[4].Value !=null)
                dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[r].Cells[4].Value.ToString());
            if (id != "")
                btnDelete.Enabled = true;
            else
                btnDelete.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = nv.searchEmployee(txtsearch.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pnThuocTinh_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
