using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace ElectronicStoreApp
{
   
    public partial class loginWin : Form
    {
        
        public loginWin()
        {
            InitializeComponent();
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public static Customer clientObj;

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationMenuWin RMW = new RegistrationMenuWin();
            {
                RMW.ShowDialog();
            }
        }

        private void loginWin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            DBConnection dbService = new DBConnection();
            string clientUsernameInput = txtBoxUsername.Text;
            string clientPasswordInput = txtBoxPassword.Text;
            bool quearyStatus =  dbService.Login(clientUsernameInput,  clientPasswordInput);
           if (quearyStatus)
            {
                clientObj = new Customer(clientUsernameInput, 1, null);
                this.Hide();
                MainMenu MM = new MainMenu();
                MM.Show();
            }

        }

        private void Exit_btn_TextChanged(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
