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
        

        public MainMenu()
        {
            InitializeComponent();
        }

        private bool Computer_btn_isCollapsed = true;
        private bool MyAccount_btn_isCollapsed = true;
        private bool Audio_btn_isCollapsed = true;
        private bool Tablets_btn_isCollapsed = true;
        private bool TVs_btn_isCollapsed = true;

        public void show_hide_menu(Panel mainPanel, Button button, string tabName)
        {

            if (tabName == "Computers")
            {
                
                if (Computer_btn_isCollapsed)
                {
                    button.Image = Resources.arrow_up_small;
                    mainPanel.Height += 10;
                    
                    if (mainPanel.Size == mainPanel.MaximumSize)
                    {
                        ComputerTimer.Stop();
                        Computer_btn_isCollapsed = false;
                        

                    }
                }
                else
                {
                   
                    button.Image = Resources.download_icon_bottom_chevron_chevrondowncircle_circle_down_icon_icon_1320185732544666525_16;
                    mainPanel.Height -= 10;
                    if (mainPanel.Size == mainPanel.MinimumSize)
                    {
                        
                        ComputerTimer.Stop();
                        Computer_btn_isCollapsed = true;

                    }
                }

            }
            else if (tabName == "Account")
            {
                if (MyAccount_btn_isCollapsed)
                {
                    button.Image = Resources.arrow_up_small;
                    mainPanel.Height += 10;
                    if (mainPanel.Size == mainPanel.MaximumSize)
                    {
                        AccounterTimer.Stop();
                        MyAccount_btn_isCollapsed = false;
                    }

                }
                else
                {
                    button.Image = Resources.download_icon_bottom_chevron_chevrondowncircle_circle_down_icon_icon_1320185732544666525_16;
                    mainPanel.Height -= 10;
                    if (mainPanel.Size == mainPanel.MinimumSize)
                    {
                        AccounterTimer.Stop();
                        MyAccount_btn_isCollapsed = true;
                    }
                }
            }
            else if (tabName == "Audio")
            {
                if (Audio_btn_isCollapsed)
                {
                    button.Image = Resources.arrow_up_small;
                    mainPanel.Height += 10;
                    if (mainPanel.Size == mainPanel.MaximumSize)
                    {
                        AudioTimer.Stop();
                        Audio_btn_isCollapsed = false;
                    }

                }
                else
                {
                    button.Image = Resources.download_icon_bottom_chevron_chevrondowncircle_circle_down_icon_icon_1320185732544666525_16;
                    mainPanel.Height -= 10;
                    if (mainPanel.Size == mainPanel.MinimumSize)
                    {
                        AudioTimer.Stop();
                        Audio_btn_isCollapsed = true;
                    }
                }
            }
            else if (tabName == "Tablets")
            {
                if (Tablets_btn_isCollapsed)
                {
                    button.Image = Resources.arrow_up_small;
                    mainPanel.Height += 10;
                    if (mainPanel.Size == mainPanel.MaximumSize)
                    {
                        TabletsTimer.Stop();
                        Tablets_btn_isCollapsed = false;
                    }

                }
                else
                {
                    button.Image = Resources.download_icon_bottom_chevron_chevrondowncircle_circle_down_icon_icon_1320185732544666525_16;
                    mainPanel.Height -= 10;
                    if (mainPanel.Size == mainPanel.MinimumSize)
                    {
                        TabletsTimer.Stop();
                        Tablets_btn_isCollapsed = true;
                    }
                }
            }
            else if (tabName == "TV")
            {
                if (TVs_btn_isCollapsed)
                {
                    button.Image = Resources.arrow_up_small;
                    mainPanel.Height += 10;
                    if (mainPanel.Size == mainPanel.MaximumSize)
                    {
                        TVtimer.Stop();
                        TVs_btn_isCollapsed = false;
                    }

                }
                else
                {
                    button.Image = Resources.download_icon_bottom_chevron_chevrondowncircle_circle_down_icon_icon_1320185732544666525_16;
                    mainPanel.Height -= 10;
                    if (mainPanel.Size == mainPanel.MinimumSize)
                    {
                        TVtimer.Stop();
                        TVs_btn_isCollapsed = true;
                    }
                }
            }

        }

        private void Computer_btn_Click(object sender, EventArgs e)
        {
            ComputerTimer.Start();
            show_hide_menu(ComputerPanel, Computer_btn, "Computers");
        }

        private void MyAccount_btn_Click(object sender, EventArgs e)
        {
           
            Customer obj = loginWin.clientObj;
            if (obj.adminRights == 1)
            {
                Inventory_btn.Visible = true;
                CustumersData_btn.Visible = true;
                MyAcountPanel.MaximumSize = new System.Drawing.Size(182, 261);

            }
            
            AccounterTimer.Start();
            show_hide_menu(MyAcountPanel, MyAccount_btn, "Account");
        }

        private void Audio_btn_Click(object sender, EventArgs e)
        {
            AudioTimer.Start();
            show_hide_menu(AudioPanel, Audio_btn, "Audio");
        }

        private void Tablets_btn_Click(object sender, EventArgs e)
        {
            TabletsTimer.Start();
            show_hide_menu(TabletPanel, Tablets_btn, "Tablets");
        }

        private void TVs_btn_Click(object sender, EventArgs e)
        {
            TVtimer.Start();
            show_hide_menu(TVpanel, TVs_btn, "TV");
        }


        private void CustumersData_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerWin CW = new CustomerWin();
            CW.Show();
        }
    }

} 

