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
            DBConnection db = new DBConnection();
            var ud = db.getUserdata(obj.username);
            
            WelcomeLabel_btn.Text = "Welcome, " + obj.username;
            RMW_FirstName_txtBox.Text = (string)ud[0]["FirstName"];
            RMW_LastName_txtBox.Text = (string)ud[0]["LastName"];
            RMW_Address_txtBox.Text = (string)ud[0]["Address"];
            RMW_State_txtBox.Text = (string)ud[0]["State"];
            RMW_Zip_txtBox.Text = (string)ud[0]["Zip"];

        }

        private void UW_Back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu MM = new MainMenu();
            MM.Show();
        }
    }
}
