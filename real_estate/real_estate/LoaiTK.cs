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
    public partial class LoaiTK : Form
    {
        TaiKhoanBAL tk = new TaiKhoanBAL();
        public LoaiTK()
        {
            InitializeComponent();
           
        }

        private void dgvLoaiTK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void LoaiTK_Load(object sender, EventArgs e)
        {
            //   dgvLoaiTK.DataSource = TaiKhoanBAL.GetLoaiTK();
            //ShowTK();
           dgvLoaiTK.DataSource= tk.GetLoaiTK();

        }
        void ShowTK()
        {
           
        }
    
    }
}
