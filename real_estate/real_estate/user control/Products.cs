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
using DAL;
using System.IO;
//using excel = Microsoft.Office.Interop.Excel;
using excel = Microsoft.Office.Interop.Excel.Application;
namespace real_estate.user_control
{
    public partial class Products : UserControl
    {
        BALRealEstate prop = new BALRealEstate();
        RealEstateEntities db = new RealEstateEntities();
        public Products()
        {
            InitializeComponent();
        }
        void load()
        {
            try
            {
                dgvRealEstate.AutoGenerateColumns = false;
                // var res = prop.getProperty();
                var res = prop.getAllProp();
                var listTown = prop.getTown();
                var listArea = prop.getArea();
                var listDistrict = prop.getDistrict();
                var listRealEstateType = prop.getRealEstateType();
                var listProject = prop.getProject();
             
                // Đưa dữ liệu lên ComboBox trong DataGridView 
                (dgvRealEstate.Columns["cbTypeProp"] as DataGridViewComboBoxColumn).DataSource = listRealEstateType;
                (dgvRealEstate.Columns["cbTypeProp"] as DataGridViewComboBoxColumn).DisplayMember = "name";
                (dgvRealEstate.Columns["cbTypeProp"] as DataGridViewComboBoxColumn).ValueMember = "id";
                // Đưa dữ liệu lên ComboBox trong DataGridView 
                (dgvRealEstate.Columns["cbTown"] as DataGridViewComboBoxColumn).DataSource = listTown;
                (dgvRealEstate.Columns["cbTown"] as DataGridViewComboBoxColumn).DisplayMember = "name";
                (dgvRealEstate.Columns["cbTown"] as DataGridViewComboBoxColumn).ValueMember = "id";
                (dgvRealEstate.Columns["cbTown"] as DataGridViewComboBoxColumn).DataPropertyName = "id_town_region";
                // Đưa dữ liệu lên ComboBox trong DataGridView 
                (dgvRealEstate.Columns["cbArea"] as DataGridViewComboBoxColumn).DataSource = listArea;
                (dgvRealEstate.Columns["cbArea"] as DataGridViewComboBoxColumn).DisplayMember = "name";
                (dgvRealEstate.Columns["cbArea"] as DataGridViewComboBoxColumn).ValueMember = "id";

                // Đưa dữ liệu lên ComboBox trong DataGridView 
                (dgvRealEstate.Columns["cbDistrict"] as DataGridViewComboBoxColumn).DataSource = listDistrict;
                (dgvRealEstate.Columns["cbDistrict"] as DataGridViewComboBoxColumn).DisplayMember = "name";
                (dgvRealEstate.Columns["cbDistrict"] as DataGridViewComboBoxColumn).ValueMember = "id";
                //  Đưa dữ liệu lên ComboBox trong DataGridView
                (dgvRealEstate.Columns["cbProject"] as DataGridViewComboBoxColumn).DataSource = listProject;
                (dgvRealEstate.Columns["cbProject"] as DataGridViewComboBoxColumn).DisplayMember = "name_project";
                (dgvRealEstate.Columns["cbProject"] as DataGridViewComboBoxColumn).ValueMember = "id_proj";

                dgvRealEstate.DataSource = res;


                txtId.Text = dgvRealEstate.CurrentRow.Cells["id_prop"].Value.ToString();
                txtName.Text = dgvRealEstate.CurrentRow.Cells["name"].Value.ToString();

                txtFloor.Text = dgvRealEstate.CurrentRow.Cells["floor"].Value.ToString();

                txtRoom.Text = dgvRealEstate.CurrentRow.Cells["room"].Value.ToString();

                txtPrice.Text = dgvRealEstate.CurrentRow.Cells["price"].Value.ToString();

                txtCreate_date.Text = dgvRealEstate.CurrentRow.Cells["create_date"].Value.ToString();

                txtStatus.Text = dgvRealEstate.CurrentRow.Cells["status"].Value.ToString();
                pcImage.Image = ConverBinaryToImage((byte[])dgvRealEstate.CurrentRow.Cells["avatar"].Value);
                // real estate type
                cbRealEstateBind.DataSource = listRealEstateType;
                cbRealEstateBind.DisplayMember = "name";
                cbRealEstateBind.ValueMember = "id";
                //project 
                cbProjectBind.DataSource = listProject;
                cbProjectBind.DisplayMember = "name_project";
                cbProjectBind.ValueMember = "id_proj";
                //town
                cbTownRegionBind.DataSource = listTown;
                cbTownRegionBind.DisplayMember = "name";
                cbTownRegionBind.ValueMember = "id";
                int idTown = (int)dgvRealEstate.CurrentRow.Cells["cbTown"].Value;
                var res1 = prop.getAreaByIdTown(idTown);
                //area
                cbAreaBind.DataSource = res1;
                cbAreaBind.DisplayMember = "name";
                cbAreaBind.ValueMember = "id";
                int idArea = (int)dgvRealEstate.CurrentRow.Cells["cbArea"].Value;
                var res2 = prop.getDistrictByIdArea(idArea);
                //district
                cbDisTrictBind.DataSource = res2;
                cbDisTrictBind.DisplayMember = "name";
                cbDisTrictBind.ValueMember = "id";

                txtId.Enabled = false;
                txtName.Enabled = false;
                txtFloor.Enabled = false;
                txtRoom.Enabled = false;
                txtPrice.Enabled = false;
                txtStatus.Enabled = false;
                cbAreaBind.Enabled = false;
                cbDisTrictBind.Enabled = false;
                cbProjectBind.Enabled = false;
                cbRealEstateBind.Enabled = false;
                cbTownRegionBind.Enabled = false;
                


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
       
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            prop.DeleteCustomer(id);
            load();
            MessageBox.Show("Delete success");
        }

        private void Products_Load(object sender, EventArgs e)
        {
            txtCreate_date.Enabled = false;
            load();
            loadSearch();

            //    string anh = dgvRealEstate.Rows[r].Cells[11].Value.ToString();

            //     string pathstring = System.IO.Path.Combine(anh);

            //  pcImage.Image = Image.FromFile(pathstring);
        }
        string err = "";
        string pro = "";
        bool add;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            add = true;
            txtId.Enabled = false ;
            txtName.Enabled = true;
            txtFloor.Enabled = true;
            txtRoom.Enabled = true;
            txtPrice.Enabled = true;
            txtStatus.Enabled = true;
            cbAreaBind.Enabled = true;
            cbDisTrictBind.Enabled = true;
            cbProjectBind.Enabled = true;
            cbRealEstateBind.Enabled = true;
            cbTownRegionBind.Enabled = true;

            txtId.ResetText();
            txtName.ResetText();
            txtFloor.ResetText();
            txtPrice.ResetText();
            txtRoom.ResetText();
            txtStatus.ResetText();
            txtCreate_date.ResetText();
            dgvRealEstate.Rows[dgvRealEstate.Rows.Count - 1].Selected = true;

        }

        private void dgvRealEstate_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            bool validClick = (e.RowIndex != -1 && e.ColumnIndex != -1); //Make sure the clicked row/column is valid.
            var datagridview = sender as DataGridView;

            // Check to make sure the cell clicked is the cell containing the combobox 
            if (datagridview.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn && validClick)
            {
                datagridview.BeginEdit(true);
                ((ComboBox)datagridview.EditingControl).DroppedDown = true;
            }
        }



        private void dgvRealEstate_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            // dgvRealEstate.CommitEdit(DataGridViewDataErrorContexts.Commit);
            if (this.dgvRealEstate.IsCurrentCellDirty)
            {
                // This fires the cell value changed handler below
                dgvRealEstate.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }


        private void dgvRealEstate_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {


            //if (e.RowIndex == -1)
            //    return;
            //DataGridViewComboBoxCell cb = (DataGridViewComboBoxCell)dgvRealEstate.Rows[e.RowIndex].Cells[8];
            //if (cb.Value != null)
            //{
            //    // do stuff
            //    // dgvRealEstate.Invalidate();
            //    int id = (int)cb.Value;
            //    var res1 = prop.getAreaByIdTown(id);


            //    cbArea.DataSource = res1;
            //    cbArea.DisplayMember = "name";
            //    cbArea.ValueMember = "id";
            //    dgvRealEstate.Refresh();

            //}
        }

        private void dgvRealEstate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRealEstate.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvRealEstate.CurrentRow.Selected = true;
                //get id
                int idRealEstateType = (int)dgvRealEstate.CurrentRow.Cells["cbTypeProp"].Value;
                string idProject = dgvRealEstate.CurrentRow.Cells["cbProject"].Value.ToString();
                int idTown = (int)dgvRealEstate.CurrentRow.Cells["cbTown"].Value;
                int idArea = (int)dgvRealEstate.CurrentRow.Cells["cbArea"].Value;
                int idDistrict = (int)dgvRealEstate.CurrentRow.Cells["cbDistrict"].Value;
                txtId.Text= dgvRealEstate.CurrentRow.Cells["id_prop"].Value.ToString();
                txtName.Text = dgvRealEstate.CurrentRow.Cells["name"].Value.ToString();
                
                
                txtFloor.Text = dgvRealEstate.CurrentRow.Cells["floor"].Value.ToString();

                txtRoom.Text = dgvRealEstate.CurrentRow.Cells["room"].Value.ToString();

                txtPrice.Text = dgvRealEstate.CurrentRow.Cells["price"].Value.ToString();

                txtCreate_date.Text = dgvRealEstate.CurrentRow.Cells["create_date"].Value.ToString();

                txtStatus.Text = dgvRealEstate.CurrentRow.Cells["status"].Value.ToString();
                pcImage.Image = ConverBinaryToImage((byte [])dgvRealEstate.CurrentRow.Cells["avatar"].Value);
                

                         //get list 
                         var listRealEstateType = prop.getRealEstateType();
                var listProject = prop.getProject();
                var listTown = prop.getTown();
                var listArea = prop.getArea();
                var listDistrict = prop.getDistrict();
                //real estate type
                cbRealEstateBind.DataSource = listRealEstateType;
                cbRealEstateBind.DisplayMember = "name";
                cbRealEstateBind.ValueMember = "id";
                cbRealEstateBind.SelectedValue = idRealEstateType;
                //project
                cbProjectBind.DataSource = listProject;
                cbProjectBind.DisplayMember = "name_project";
                cbProjectBind.ValueMember = "id_proj";
                cbProjectBind.SelectedValue = idProject;
                //town region
                cbTownRegionBind.DataSource = listTown;
                cbTownRegionBind.DisplayMember = "name";
                cbTownRegionBind.ValueMember = "id";
                cbTownRegionBind.SelectedValue = idTown;
                //area
                cbAreaBind.DataSource = listArea;
                cbAreaBind.DisplayMember = "name";
                cbAreaBind.ValueMember = "id";
                cbAreaBind.SelectedValue = idArea;
                //district
                cbDisTrictBind.DataSource = listDistrict;
                cbDisTrictBind.DisplayMember = "name";
                cbDisTrictBind.ValueMember = "id";
                cbDisTrictBind.SelectedValue = idDistrict;
                //
                
            }
        }

        private void cbTownRegionBind_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id;
                Int32.TryParse(cbTownRegionBind.SelectedValue.ToString(), out id);

                var res1 = prop.getAreaByIdTown(id);


                cbAreaBind.DataSource = res1;
                cbAreaBind.DisplayMember = "name";
                cbAreaBind.ValueMember = "id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void cbAreaBind_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {


                int id;
                int.TryParse(cbAreaBind.SelectedValue.ToString(), out id);


                var res1 = prop.getDistrictByIdArea(id);
                cbDisTrictBind.DataSource = res1;
                cbDisTrictBind.DisplayMember = "name";
                cbDisTrictBind.ValueMember = "id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }

        }
        string filename;
        Image ConverBinaryToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }
        byte[] CovertImageToBinary(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
        private void btnBrowser_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    filename = ofd.FileName;
              

                    pcImage.Image = Image.FromFile(filename);
                }
            }
        }
      

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (add)
            {
                if (!prop.insertProp(ref err, ref pro, (int)cbRealEstateBind.SelectedValue, cbProjectBind.SelectedValue.ToString(), int.Parse(txtFloor.Text), int.Parse(txtRoom.Text), float.Parse(txtPrice.Text), (int)cbTownRegionBind.SelectedValue, (int)cbAreaBind.SelectedValue, (int)cbDisTrictBind.SelectedValue, txtName.Text, txtStatus.Text, CovertImageToBinary(pcImage.Image)))
                    MessageBox.Show(err);
                else
                    MessageBox.Show("insert success");
            }
            if (!add)
            {
            //  property obj= new property{id_prop=txtId.Text, id_real_estate_type= (int)cbRealEstateBind.SelectedValue ,id_project= cbProjectBind.SelectedValue.ToString() ,floor= int.Parse(txtFloor.Text) ,room= int.Parse(txtRoom.Text) ,price= float.Parse(txtPrice.Text) ,id_town_region= (int)cbTownRegionBind.SelectedValue ,id_area = (int)cbAreaBind.SelectedValue ,id_district= (int)cbDisTrictBind.SelectedValue ,name= txtName.Text ,status= txtStatus.Text ,avatar= CovertImageToBinary(pcImage.Image) };
                if (!prop.Update(ref err, ref pro,  txtId.Text, (int)cbRealEstateBind.SelectedValue, cbProjectBind.SelectedValue.ToString(), int.Parse(txtFloor.Text), int.Parse(txtRoom.Text), float.Parse(txtPrice.Text), (int)cbTownRegionBind.SelectedValue, (int)cbAreaBind.SelectedValue, (int)cbDisTrictBind.SelectedValue, txtName.Text, txtStatus.Text, CovertImageToBinary(pcImage.Image)))
                    MessageBox.Show(err);
                  else
                    MessageBox.Show("update success");
            }

            load();
        }

        private void txtEdit_Click(object sender, EventArgs e)
        {
            add = false;
            txtName.Enabled = true;
            txtFloor.Enabled = true;
            txtRoom.Enabled = true;
            txtPrice.Enabled = true;
            txtStatus.Enabled = true;
            cbAreaBind.Enabled = true;
            cbDisTrictBind.Enabled = true;
            cbProjectBind.Enabled = true;
            cbRealEstateBind.Enabled = true;
            cbTownRegionBind.Enabled = true;

           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtId.Enabled = false;
            txtName.Enabled = false;
            txtFloor.Enabled = false;
            txtRoom.Enabled = false;
            txtPrice.Enabled = false;
            txtStatus.Enabled = false;
            cbAreaBind.Enabled = false;
            cbDisTrictBind.Enabled = false;
            cbProjectBind.Enabled = false;
            cbRealEstateBind.Enabled = false;
            cbTownRegionBind.Enabled = false;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            
        }
        private void export(DataGridView dgv, string duongdan, string namefile)
        {
            // create object excel
            excel obj = new excel();
            //create workbooks(bảng tính)

            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;
            //create worksheet
            //lưu trữ vào Sheet1
            // lấy các tên cột
            for (int i = 1; i < dgv.Columns.Count + 1; i++)
            {
                obj.Cells[1, i] = dgv.Columns[i - 1].HeaderText;
            }
            //đọc từ datagridview
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                for (int j = 0; j < dgv.Columns.Count; j++)
                {
                    if (dgv.Rows[i].Cells[j].Value != null)
                    {
                        obj.Cells[i + 2, j + 1] = dgv.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            //lưu vào đường dẫn
            obj.ActiveWorkbook.SaveCopyAs(duongdan + namefile + ".xlsx");
            obj.ActiveWorkbook.Saved = true;
        }
        private void btnExport_Click(object sender, EventArgs e)
        {
           export(dgvRealEstate, @"D:\", "property");
            MessageBox.Show("Đã xuất file mời bạn kiểm tra. ");
        }
        private void loadSearch()
        {
            //town
            var listTown = prop.getTown();
            cbSearchTown.DataSource = listTown;
            cbSearchTown.DisplayMember = "name";
            cbSearchTown.ValueMember = "id";
            int id;
            int.TryParse(cbSearchTown.SelectedValue.ToString(), out id);
           
            var res1 = prop.getAreaByIdTown(id);
            //area
            cbSearchArea.DataSource = res1;
            cbSearchArea.DisplayMember = "name";
            cbSearchArea.ValueMember = "id";
            int idArea;
            int.TryParse(cbSearchArea.SelectedValue.ToString(), out idArea);
            var res2 = prop.getDistrictByIdArea(idArea);
            //district
            cbSearchDistrict.DataSource = res2;
            cbSearchDistrict.DisplayMember = "name";
            cbSearchDistrict.ValueMember = "id";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cbSearchTown_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id;
                Int32.TryParse(cbSearchTown.SelectedValue.ToString(), out id);

                var res1 = prop.getAreaByIdTown(id);


                cbSearchArea.DataSource = res1;
                cbSearchArea.DisplayMember = "name";
                cbSearchArea.ValueMember = "id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }

        }

        private void cbSearchArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {


                int id;
                int.TryParse(cbSearchArea.SelectedValue.ToString(), out id);


                var res1 = prop.getDistrictByIdArea(id);
                cbSearchDistrict.DataSource = res1;
                cbSearchDistrict.DisplayMember = "name";
                cbSearchDistrict.ValueMember = "id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            int idTown;
            int.TryParse(cbSearchTown.SelectedValue.ToString(), out idTown);
            int idArea;
            int.TryParse(cbSearchArea.SelectedValue.ToString(), out idArea);
            int idDistrict;
            int.TryParse(cbSearchDistrict.SelectedValue.ToString(), out idDistrict);
            var res = prop.searchPropertyByPlace(idTown, idArea, idDistrict);
            dgvRealEstate.DataSource = res;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            load();
        }
    }
}
