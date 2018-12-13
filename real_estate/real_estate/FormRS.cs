﻿using real_estate.user_control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace real_estate
{
    public partial class FormRS : Form
    {
        public FormRS()
        {
            InitializeComponent();
            bell.Visible = false;
            //timer.Start();
        }


        void LoadGiaoDien()
        {

        }
        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Release the mouse capture started by the mouse down.
                panel3.Capture = false;

                // Create and send a WM_NCLBUTTONDOWN message.
                const int WM_NCLBUTTONDOWN = 0x00A1;
                const int HTCAPTION = 2;
                Message msg =
                    Message.Create(this.Handle, WM_NCLBUTTONDOWN,
                        new IntPtr(HTCAPTION), IntPtr.Zero);
                this.DefWndProc(ref msg);
            }
        }
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Release the mouse capture started by the mouse down.
                panel2.Capture = false;

                // Create and send a WM_NCLBUTTONDOWN message.
                const int WM_NCLBUTTONDOWN = 0x00A1;
                const int HTCAPTION = 2;
                Message msg =
                    Message.Create(this.Handle, WM_NCLBUTTONDOWN,
                        new IntPtr(HTCAPTION), IntPtr.Zero);
                this.DefWndProc(ref msg);
            }
        }
        //private void picBell_Click(object sender, EventArgs e)
        //{
        //    if (check == true)
        //    {
        //        bell1.Visible = true;
        //        bell1.BringToFront();

        //        check = false;
        //    }
        //    else
        //    {
        //        bell1.Visible = false;
        //        check = true;
        //    }
        //}
        //private void timer_Tick(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        RealEstateEntities dbs = new RealEstateEntities();
        //        var kq = (from d in dbs.contacts
        //                  where d.status == 1
        //                  select d).Count();
        //        lbBellNumber.Text = kq.ToString();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}   
        private void tbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEmp_Click(object sender, EventArgs e)
        {
            employee2.BringToFront();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            customer2.BringToFront();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            products1.BringToFront();
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            transaction.BringToFront();
        }

        private void btnProject_Click(object sender, EventArgs e)
        {
           projects1.BringToFront();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            dashboard.BringToFront();   
        }

        private void picBell_Click(object sender, EventArgs e)
        {

        }
    }
}
