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
    public partial class TypeAccount : Form
    {
        bool Them = false;
        public TypeAccount()
        {
            InitializeComponent();
        }

        public void TypeAccount_Load(object sender, EventArgs e)
        {
           
            LoadData();
        }
        public void LoadData()
        {
            dgvTypeAcc.DataSource = TaiKhoanBAL.GetAllTypeAcc();
            //dgvKH.AutoResizeColumns();
            // Xóa trống các đối tượng trong Panel 
            txtMa.ResetText();
            txtTen.ResetText();
            // Không cho thao tác trên các nút Lưu / Hủy 
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            //panel.Enabled = false;
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát 
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            bthThoat.Enabled = true;
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thứ tự record hiện hành 
                int r = dgvTypeAcc.CurrentCell.RowIndex;

                string strMA =
                dgvTypeAcc.Rows[r].Cells[0].Value.ToString();
                int id = int.Parse(strMA);
                TaiKhoanBAL.DelTypeAcc(id);
                LoadData();
                dgvTypeAcc_CellClick(null, null);
                MessageBox.Show("Đã xóa xong!");
            }
            catch
            {
                MessageBox.Show("Không được phép xóa");
            }
        }

        private void dgvTypeAcc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Thứ tự dòng hiện hành
            int r = dgvTypeAcc.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel 
            txtMa.Text = dgvTypeAcc.Rows[r].Cells[0].Value.ToString();
            txtTen.Text = dgvTypeAcc.Rows[r].Cells[1].Value.ToString();
           
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;
            txtMa.ResetText();
            txtTen.ResetText();
            txtMa.Enabled = false;
            // Xóa trống các đối tượng trong Panel 
            // Cho thao tác trên các nút Lưu / Hủy / Panel 
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            //panel.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát 
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            bthThoat.Enabled = false;
            txtTen.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kích hoạt biến Sửa
            Them = false;
            dgvTypeAcc_CellClick(null, null);
            //dgvKH_CellClick(null, null);
            // Cho phép thao tác trên Panel 
            //panel.Enabled = true;
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
                TaiKhoanBAL.InsertTypeAcc(txtTen.Text);
                LoadData();
                // Thông báo 
                MessageBox.Show("Đã thêm xong!");
            }
            else
            {
                int r = dgvTypeAcc.CurrentCell.RowIndex;
                // MaKH hiện hành 
                string strMa=
                dgvTypeAcc.Rows[r].Cells[0].Value.ToString();
                int id = int.Parse(strMa);
                TaiKhoanBAL.UpTypeAcc(id, txtTen.Text);
                LoadData();
                // Thông báo 
                MessageBox.Show("Đã sửa xong!");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng trong Panel 
            txtMa.ResetText();
            txtTen.ResetText();
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát 
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            bthThoat.Enabled = true;
            // Không cho thao tác trên các nút Lưu / Hủy / Panel 
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            //panel.Enabled = false;
        }
    }
}
