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
    public partial class Projects : UserControl
    {
        bool add;
        string id;
        BALPROJ prj = new BALPROJ();
        public Projects()
        {
            InitializeComponent();
        }
        void load()
        {
            try
            {
                dataGridView1.DataSource = prj.getpro();
                pnRich.Visible = true;
                groupBox1.Visible = false;
                dataGridView1_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table project. Lỗi rồi!!!");
            }
        }
        void textreset()
        {
            txtName.ResetText();
            txtAddress.ResetText();
            txtLicense.ResetText();
            rtbInfor.ResetText();
        }

        private void Projects_Load(object sender, EventArgs e)
        {
            load();
        }
        void addrich(int r)
        {
            int[] x=new int[6];
            for (int ii = 0; ii < 6; ii++)
                if (dataGridView1.Rows[r].Cells[ii].Value == null)
                {
                    dataGridView1.Rows[r].Cells[ii].Value = "";
                    x[ii] += dataGridView1.Rows[r].Cells[ii].Value.ToString().Length;
                }
                else
                    x[ii] += dataGridView1.Rows[r].Cells[ii].Value.ToString().Length;
            //text of richtextbox
            richTextBox1.Text = dataGridView1.Rows[r].Cells[1].Value.ToString()+"\n"+ "License Number: " + dataGridView1.Rows[r].Cells[3].Value.ToString()+"\n";
            richTextBox1.Text += "Address: " + dataGridView1.Rows[r].Cells[2].Value.ToString()+"\n"+ "Date: "+dataGridView1.Rows[r].Cells[4].Value.ToString()+"\n\n";
            richTextBox1.Text += dataGridView1.Rows[r].Cells[5].Value.ToString();

            //design tital
            richTextBox1.SelectionStart = 0;
            richTextBox1.SelectionLength = x[1]; //End of first word
            richTextBox1.SelectionFont = new System.Drawing.Font("Microsoft Sans Serif", 15);
            richTextBox1.SelectionColor = Color.Blue;
            //design License Number:
            designname(x[1], 15);
            //design address:
            designname(x[1] + 15 + 1 + + x[3]+1, 8);
            //design date:
            designname(x[1] + 15 + 1 + + x[3] + 1 + 8 + x[2] +1, 5);


        }
        void designname(int start,int lenght)
        {
            richTextBox1.SelectionStart = start + 1;
            richTextBox1.SelectionLength = lenght; //End of first word
            richTextBox1.SelectionFont = new System.Drawing.Font("Microsoft Sans Serif", 9);
            richTextBox1.SelectionColor = Color.Blue;
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Underline);
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridView1.CurrentCell.RowIndex;
            id = dataGridView1.Rows[r].Cells[0].Value.ToString();
            for (int ii = 0; ii < 6; ii++)
                if (dataGridView1.Rows[r].Cells[ii].Value == null)
                    dataGridView1.Rows[r].Cells[ii].Value = "";
            txtName.Text = dataGridView1.Rows[r].Cells[1].Value.ToString();
            txtAddress.Text = dataGridView1.Rows[r].Cells[2].Value.ToString();
            txtLicense.Text = dataGridView1.Rows[r].Cells[3].Value.ToString();
            if (dataGridView1.Rows[r].Cells[4].Value.ToString() != "")
                dtpkDateOfIssue.Value =Convert.ToDateTime(dataGridView1.Rows[r].Cells[4].Value);
            rtbInfor.Text = dataGridView1.Rows[r].Cells[5].Value.ToString();
            richTextBox1.Clear();
            addrich(r);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            add = true;
            btnSave.Enabled = true;
            btnAdd.Enabled = false;
            //pnThuocTinh.Visible = true;
            groupBox1.Visible = true;  
            textreset();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            add = false;
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
            //pnThuocTinh.Visible = true;
            groupBox1.Visible = true;
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
                    prj.deleteProject(dataGridView1.Rows[r].Cells[0].Value.ToString());
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (add)
            {
                try
                {
                    prj.addProject(txtName.Text, txtAddress.Text, txtLicense.Text, Convert.ToDateTime(dtpkDateOfIssue.Text),rtbInfor.Text);
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
                    prj.updateProject(id, txtName.Text, txtAddress.Text, txtLicense.Text, Convert.ToDateTime(dtpkDateOfIssue.Text), rtbInfor.Text);
                    load();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            load();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            load();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
