using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace ElectronicStoreApp
{
    public partial class RegistrationMenuWin : Form
    {
        public RegistrationMenuWin()
        {
            InitializeComponent();
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Bakc_From_R_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginWin loginWin = new loginWin();
            {
                loginWin.ShowDialog();
            }
        }

        private void RNW_register_btn_Click(object sender, EventArgs e)
        {
            StoreService sService = new StoreService();
            DBConnection dbService = new DBConnection();

            IDictionary<string, string> userInputs = new Dictionary<string, string>();

            string FM         = RMW_FirstName_txtBox.Text;
            string FL         = RMW_LastName_txtBox.Text;
            string UN         = RMW_Username_txtbox.Text;
            string PW         = RMW_Password_txtbox.Text;
            string Address    = RMW_Address_txtBox.Text;
            string State      = RMW_State_txtBox.Text;
            string ZIP        = RMW_Zip_txtBox.Text;

            userInputs.Add("First Name", FM);
            userInputs.Add("Last Name", FL);
            userInputs.Add("Username", UN);
            userInputs.Add("Password", PW);
            userInputs.Add("Address", Address);
            userInputs.Add("State", State);
            userInputs.Add("Zip", ZIP);

            List<string> userInputStatus = sService.CheckValues((Dictionary<string, string>)userInputs);

            if (userInputStatus.Count != 0)
            {
                foreach (var item in userInputStatus)
                {
                    Highlight_Wrong_Box(item);
                }
            }
            else
            {
                
                bool queryStatus = dbService.Register(FM, FL, UN, PW, Address, State, ZIP);
                if (queryStatus == true)
                {
                    MessageBox.Show("Account was created!!");
                    this.Hide();
                    loginWin lw = new loginWin();
                    lw.Show();
                }
            }

        }
        private void Highlight_Wrong_Box(String failedTextBox)
        {
            IDictionary<string, object> textBoxes = new Dictionary<string, object>
            {
                { "First Name", RMW_FirstName_txtBox },
                { "Last Name", RMW_LastName_txtBox },
                { "Address", RMW_Address_txtBox },
                { "State", RMW_State_txtBox },
                { "Zip", RMW_Zip_txtBox },
            };

            foreach (var name in textBoxes)
            {
                if (name.Key.ToString() == failedTextBox)
                {
                    TextBox failedBox = (TextBox)name.Value;
                    failedBox.BackColor = Color.Red;
                }
            }
        }

        private void RMW_FirstName_txtBox_TextChanged(object sender, EventArgs e)
        {
            RMW_FirstName_txtBox.BackColor = Color.White;
        }

        private void RMW_LastName_txtBox_TextChanged(object sender, EventArgs e)
        {
            RMW_LastName_txtBox.BackColor = Color.White;
        }


        private void RMW_Address_txtBox_TextChanged(object sender, EventArgs e)
        {
            RMW_Address_txtBox.BackColor = Color.White;
        }

        private void RMW_State_txtBox_TextChanged(object sender, EventArgs e)
        {
            RMW_State_txtBox.BackColor = Color.White;
        }

        private void RMW_Zip_txtBox_TextChanged(object sender, EventArgs e)
        {
            RMW_Zip_txtBox.BackColor = Color.White;
        }

        private void RegistrationMenuWin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
    }
}
