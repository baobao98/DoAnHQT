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
            dataGridView.DataSource = cus.GetCustomer();
        }
    

        private void btnAdd_Click(object sender, EventArgs e)
        {
         
            cus.CreateCustomer(txtName.Text, txtEmail.Text, txtPhone.Text, dateTimeBirthDay.Value.Date);
            ShowCustomer();
            MessageBox.Show("Add thành công!!");
            txtName.ResetText();
            txtEmail.ResetText();
            txtPhone.ResetText();
            dateTimeBirthDay.ResetText();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try {
                int r = dataGridView.CurrentCell.RowIndex;
                 string strID =dataGridView.Rows[r].Cells[0].Value.ToString();
                cus.DeleteCustomer(strID);
            }
            catch
            {
              //  cus.DeleteCustomer(txtID.Text);
                ShowCustomer();
                MessageBox.Show("Delete thành công!!");
            }
         
      
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
          
            txtName.ResetText();
            txtEmail.ResetText();
            txtPhone.ResetText();
            dateTimeBirthDay.ResetText();
        }


       

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            try {
                int r = dataGridView.CurrentCell.RowIndex;
                string strID = dataGridView.Rows[r].Cells[0].Value.ToString();
                cus.UpdateCustomer(strID, txtName.Text, txtEmail.Text, txtPhone.Text, dateTimeBirthDay.Value.Date);
            }
            catch
            {
                ShowCustomer();
                MessageBox.Show("Update thành công!!");

            }
        }

        private void Save_Click(object sender, EventArgs e)
        {

        }
    }
}
