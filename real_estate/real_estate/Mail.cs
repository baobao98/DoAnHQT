using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace real_estate
{
    public partial class Mail : Form
    {
        public string mailtxt { get; set; }
        public Mail()
        {
            InitializeComponent();
        }

       
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Send_Click(object sender, EventArgs e)
        {
            var message = new MailMessage("sangiaodichbdsgreen@gmail.com", mailtxt);
            message.Subject = txtSubject.Text;
            message.Body = txtBody.Text;
            using (SmtpClient mailer = new SmtpClient("smtp.gmail.com", 587))
            {
                mailer.Credentials = new NetworkCredential("sangiaodichbdsgreen@gmail.com", "khoa2381998");
                mailer.EnableSsl = true;
                mailer.Send(message);
            }
            MessageBox.Show("Thư đã Send!", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            txtSubject.Text = null;
            txtBody.Text = null;
        }

        private void txtRecipient_TextChanged(object sender, EventArgs e)
        {

        }

        private void Mail_Load(object sender, EventArgs e)
        {

        }
    }
}
