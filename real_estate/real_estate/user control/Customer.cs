using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using BAL;
using DAL;
namespace real_estate.user_control
{
    public partial class Customer : UserControl
    {
        BALCustomer cus = new BALCustomer();
        public Customer()
        {
            InitializeComponent();
        }
        private void Customer_Load(object sender, EventArgs e)
        {
            ShowCustomer();
        }
        void ShowCustomer()
        {
            try
            {
                dataGridView.DataSource = cus.GetCustomer();
            }
            catch (Exception ex) { }
            //
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                cus.CreateCustomer(txtName.Text, txtEmail.Text, txtPhone.Text, dateTimeBirthDay.Value.Date);
                ShowCustomer();
                MessageBox.Show("Add success !", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtName.ResetText();
                txtEmail.ResetText();
                txtPhone.ResetText();
                dateTimeBirthDay.ResetText();
            }
            catch
            {
                MessageBox.Show("Khách hàng không được trùng nhau!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
              //  MessageBox.Show(ex.Message);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int r = dataGridView.CurrentCell.RowIndex;
                string strID = dataGridView.Rows[r].Cells[0].Value.ToString();
                cus.DeleteCustomer(strID);
                ShowCustomer();
                MessageBox.Show("Delete success!", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch
            {

                MessageBox.Show("Không thể Xóa Vì Đang có cuộc hẹn với Khách Hàng!", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }
        private void Cancel_Click(object sender, EventArgs e)
        {

            txtName.ResetText();
            txtEmail.ResetText();
            txtPhone.ResetText();
            dateTimeBirthDay.ResetText();
            //
            ShowCustomer();
        }
        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                int r = dataGridView.CurrentCell.RowIndex;
                string strID = dataGridView.Rows[r].Cells[0].Value.ToString();
                cus.UpdateCustomer(strID, txtName.Text, txtEmail.Text, txtPhone.Text, dateTimeBirthDay.Value.Date);
                ShowCustomer();
                MessageBox.Show("Update thành công!!", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch
            {
                MessageBox.Show("Khách hàng không được trùng nhau!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnSetAppointment_Click(object sender, EventArgs e)
        {
            Form fm = new SetAppointment();
            fm.ShowDialog();
        }

        private void btnMail_Click(object sender, EventArgs e)
        {
            int r = dataGridView.CurrentCell.RowIndex;
            string mail = dataGridView.Rows[r].Cells[2].Value.ToString();
            Mail fm = new Mail();
            fm.mailtxt = mail;
            fm.ShowDialog();
        }
        private void btnVip_Click(object sender, EventArgs e)
        {
            Form fm = new VIP();
            fm.ShowDialog();
        }
        private void btnExport_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application objexcelapp = new Microsoft.Office.Interop.Excel.Application();
            objexcelapp.Application.Workbooks.Add(Type.Missing);
            objexcelapp.Columns.ColumnWidth = 25;
            for (int i = 1; i < dataGridView.Columns.Count + 1; i++)
            {
                objexcelapp.Cells[1, i] = dataGridView.Columns[i - 1].HeaderText;
            }
            //
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView.Columns.Count; j++)
                {
                    if (dataGridView.Rows[i].Cells[j].Value != null)
                    {
                        objexcelapp.Cells[i + 2, j + 1] = dataGridView.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            MessageBox.Show("Success!!");
            objexcelapp.ActiveWorkbook.SaveCopyAs("D:\\Customer.xlsx");
            objexcelapp.ActiveWorkbook.Saved = true;
        }
       
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            cus.SearchCustomer(txtSearch.Text);
            dataGridView.DataSource = cus.SearchCustomer(txtSearch.Text);
            dataGridView.AutoResizeColumns();
            txtSearch.ResetText();
        }
    }
}

