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
    public partial class Transaction : UserControl
    {
        BALTransaction trans = new BALTransaction();
        public Transaction()
        {
            InitializeComponent();
            loadData();
        }
        void loadData()
        {
            var list = trans.getListTrans();
            dgvTransaction.DataSource = list;
            dgvTransaction.AutoGenerateColumns = false;
        }
    }
}
