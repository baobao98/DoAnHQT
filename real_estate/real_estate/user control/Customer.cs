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
            txtID.Enabled = true;
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
            try { cus.DeleteCustomer(txtID.Text); }
            catch
            {
              //  cus.DeleteCustomer(txtID.Text);
                ShowCustomer();
                MessageBox.Show("Delete thành công!!");
            }
            txtID.ResetText();
      
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            txtID.ResetText();
            txtName.ResetText();
            txtEmail.ResetText();
            txtPhone.ResetText();
            dateTimeBirthDay.ResetText();
        }

        //private void btnUpdate_Click(object sender, EventArgs e)
        //{
        //    cus.UpdateCustomer(txtID.Text, txtName.Text, txtEmail.Text, txtPhone.Text, dateTimeBirthDay.Value.Date);
        //    ShowCustomer();
        //    MessageBox.Show("Update Thành công!!");
        //}
    }
}
