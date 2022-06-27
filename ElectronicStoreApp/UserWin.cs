using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ElectronicStoreApp
{
    public partial class UserWin : Form
    {
        public UserWin()
        {
            InitializeComponent();
        }

        private void UserWin_Load(object sender, EventArgs e)
        {
            Customer obj = loginWin.clientObj;
            MessageBox.Show(obj.username);
        }
    }
}
