using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ElectronicStoreApp
{
    public partial class CustomerWin : Form
    {
        public CustomerWin()
        {
            InitializeComponent();
        }

        private void CustomerWin_Load(object sender, EventArgs e)
        {
            DBConnection db = new DBConnection();
            DataTable dt = db.getCustomerDatabase("Customer");
            dataGridView1.DataSource = dt;
        }
    }
}
