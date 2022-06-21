using ElectronicStoreApp.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ElectronicStoreApp
{
    
    public partial class MainMenu : Form
    {
        private bool isCollapsed;
        public MainMenu()
        {
            InitializeComponent();
        }

        public void show_hide_menu(Panel mainPanel, Button button){

            if (isCollapsed)
            {
                button.Image = Resources.download_icon_bottom_chevron_chevrondowncircle_circle_down_icon_icon_1320185732544666525_16;
                ComputerPanel.Height += 10;
                if(mainPanel.Size == mainPanel.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }

            }else
            {
                button.Image = Resources.arrow_up_small;
                mainPanel.Height -= 10;
                if (mainPanel.Size == mainPanel.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void Computer_btn_Click(object sender, EventArgs e)
        {
            Inventory_btn.Visible = true;
            timer1.Tick += (s, ee) => show_hide_menu(ComputerPanel, Computer_btn);
        }

        private void MyAccount_btn_Click(object sender, EventArgs e)
        {

            int adminRights = loginWin.clientObj.adminRights;
            if (adminRights == 1)
            {
                Inventory_btn.Visible = true;
                timer1.Tick += (s, ee) => show_hide_menu(MyAcountPanel, MyAccount_btn);
            }
        }

        private void Audio_btn_Click(object sender, EventArgs e)
        {
            Inventory_btn.Visible = true;
            timer1.Tick += (s, ee) => show_hide_menu(AudioPanel, Audio_btn);
        }

        private void Tablets_btn_Click(object sender, EventArgs e)
        {
            Inventory_btn.Visible = true;
            timer1.Tick += (s, ee) => show_hide_menu(TabletPanel, Tablets_btn);
        }

        private void TVs_btn_Click(object sender, EventArgs e)
        {
            Inventory_btn.Visible = true;
            timer1.Tick += (s, ee) => show_hide_menu(TVpanel, TVs_btn);
        }
    }
}
