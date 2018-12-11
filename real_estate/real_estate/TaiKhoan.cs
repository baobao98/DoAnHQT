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
namespace real_estate
{
    public partial class TaiKhoan : Form
    {
        bool Them = false;
        public TaiKhoan()
        {
            InitializeComponent();
        }

        private void TaiKhoan_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            cbType.DataSource = TaiKhoanBAL.GetAllTypeAcc();
            cbType.DisplayMember = "NameOfTypeAcc";
            cbType.ValueMember = "id";
            dgvTK.DataSource = TaiKhoanBAL.GetAllAcc();
            dgvTK_CellClick(null, null);
            cboTypeAcc.ResetText();
            txtMa.ResetText();
            txtPass.ResetText();
            txtTen.ResetText();
            // Không cho thao tác trên các nút Lưu / Hủy 
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            panel.Enabled = false;
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát 
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            bthThoat.Enabled = true;
        }

        private void dgvTK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cboTypeAcc.DataSource = TaiKhoanBAL.GetAllTypeAcc();
            cboTypeAcc.DisplayMember = "NameOfTypeAcc";
            cboTypeAcc.ValueMember = "id";
            ///////////////////////////
            int r = dgvTK.CurrentCell.RowIndex;
            txtMa.Text = dgvTK.Rows[r].Cells[0].Value.ToString();
            txtTen.Text = dgvTK.Rows[r].Cells[1].Value.ToString();
            cboTypeAcc.SelectedValue= int.Parse(dgvTK.Rows[r].Cells[2].Value.ToString());
            txtPass.Text = dgvTK.Rows[r].Cells[3].Value.ToString();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;
            cboTypeAcc.ResetText();
            txtMa.ResetText();
            txtPass.ResetText();
            txtTen.ResetText();
            txtMa.Enabled = false;
            // Xóa trống các đối tượng trong Panel 
            // Cho thao tác trên các nút Lưu / Hủy / Panel 
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            panel.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát 
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            bthThoat.Enabled = false;
            txtTen.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMa.Text != "")
                {
                    account acc = new account();
                    acc.id = txtMa.Text;
                    acc.nameAcc = txtTen.Text;
                    acc.pass = txtPass.Text;
                    acc.type_ac = int.Parse(cboTypeAcc.SelectedValue.ToString());
                    TaiKhoanBAL.DelAcc(acc);
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Mã tài khoản Không Được Điền!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch { MessageBox.Show("Không Thể Thực Hiện Thao Tác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void bthThoat_Click(object sender, EventArgs e)
        {
            // Khai báo biến traloi 
            DialogResult traloi;
            // Hiện hộp thoại hỏi đáp 
            traloi = MessageBox.Show("Chắc không?", "Trả lời",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            // Kiểm tra có nhắp chọn nút Ok không? 
            if (traloi == DialogResult.OK) this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kích hoạt biến Sửa
            Them = false;
            dgvTK_CellClick(null, null);
            //dgvKH_CellClick(null, null);
            // Cho phép thao tác trên Panel 
            panel.Enabled = true;
            // Cho thao tác trên các nút Lưu / Hủy / Panel 
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát 
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            bthThoat.Enabled = false;
            // Đưa con trỏ đến TextField txtTenNV         
            txtMa.Enabled = false;
            txtTen.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
            if (Them)
            {
                
               
                int type = int.Parse(cboTypeAcc.SelectedValue.ToString());
                TaiKhoanBAL.InsertAcc(txtTen.Text, type, txtPass.Text);
                LoadData();
                // Thông báo 
                MessageBox.Show("Đã thêm xong!");
            }
            else
            {
                //account acc = new account();
                //acc.id = txtMa.Text;
                //acc.nameAcc = txtTen.Text;
                //acc.pass = txtPass.Text;
                //acc.type_ac = int.Parse(cboTypeAcc.SelectedValue.ToString());
                
                //// MaKH hiện hành 
                
                //TaiKhoanBAL.UpdateAcc(acc);
                //LoadData();
                //// Thông báo 
                //MessageBox.Show("Đã sửa xong!");
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng trong Panel 
            cboTypeAcc.ResetText();
            txtMa.ResetText();
            txtPass.ResetText();
            txtTen.ResetText();
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát 
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            bthThoat.Enabled = true;
            // Không cho thao tác trên các nút Lưu / Hủy / Panel 
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            panel.Enabled = false;
        }
    }
}
