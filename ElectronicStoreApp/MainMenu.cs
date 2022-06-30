using ElectronicStoreApp.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Web;
using Windows.UI.Xaml.Media.Imaging;

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
        private string ActiveCategory = "Laptops";
        private int ActivePageNum = 1 ;
        private string subCategory = null;
        private List<Dictionary<string, object>> data;
        private Customer clientObj;
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

        private void Inventory_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            InventoryWin IW = new InventoryWin();
            IW.Show();
        }

        private void PersonalInfo_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserWin UW = new UserWin();
            UW.Show();
        }

        private void Security_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SecurityWin SW = new SecurityWin();
            SW.Show();
        }

        private void Laptop_btn_Click(object sender, EventArgs e)
        {
            ActiveCategory = "Laptops";
            ActivePageNum = 1;
            fillPageWithProdocts("Laptops", ActivePageNum, null);
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            clientObj = loginWin.clientObj;
            MessageBox.Show(clientObj.adminRights.ToString());
            if (clientObj.adminRights == 1)
            {
                Inventory_btn.Visible = true;
                CustumersData_btn.Visible = true;
                MyAcountPanel.MaximumSize = new Size(182, 261);

            }
            ActiveCategory = "Laptops";
            ActiveTab_label.Text = ActiveCategory;
            welcomeUsername.Text = "Welcome, " + clientObj.username + "!";
            fillPageWithProdocts("Laptops", ActivePageNum, null);
        }

        private void Desktop_btn_Click(object sender, EventArgs e)
        {
            ActiveCategory = "Desktops";
            ActivePageNum = 1;
            fillPageWithProdocts("Desktops", ActivePageNum,null);
        }

        private void fillPageWithProdocts(string TableName, int pageNum, string prodoctName=null)
        {
            
            DBConnection db = new DBConnection();
            data = db.Prodocts(TableName, prodoctName, pageNum);
            
            List<Label> listOfTittles = new List<Label>();
            listOfTittles.Add(TittleLabel1);
            listOfTittles.Add(TittleLabel2);
            listOfTittles.Add(TittleLabel3);

            List<Label> listOfrate = new List<Label>();
            listOfrate.Add(RateLabel1);
            listOfrate.Add(RateLabel2);
            listOfrate.Add(RateLabel3);

            List<TextBox> listOfBoxes = new List<TextBox>();
            listOfBoxes.Add(DesBox1);
            listOfBoxes.Add(DesBox2);
            listOfBoxes.Add(DesBox3);

            List<Label> listOfPriceLb = new List<Label>();
            listOfPriceLb.Add(Pricelb1);
            listOfPriceLb.Add(Pricelb2);
            listOfPriceLb.Add(Pricelb3);

            List<PictureBox> listOfImg = new List<PictureBox>();
            listOfImg.Add(imageBox1);
            listOfImg.Add(imageBox2);
            listOfImg.Add(imageBox3);

            foreach (var img in listOfImg)
            {

                img.Image = (Image)data[img.TabIndex]["bImage"] ;
            }

            foreach (var price in listOfPriceLb)
            {
                price.Text = "$"+data[price.TabIndex]["regularPrice"].ToString();
            }

            foreach (var box in listOfBoxes)
            {
                box.Text = data[box.TabIndex]["longDescription"].ToString();
            }

            foreach (var rate in listOfrate)
            {
                rate.Text = "Average Review:" + data[rate.TabIndex]["customerReviewAverage"].ToString();
            }

            foreach (var lable in listOfTittles)
            {
                lable.Text = data[lable.TabIndex]["name"].ToString();
            }

        }

        private void Headphones_btn_Click(object sender, EventArgs e)
        {
            ActiveCategory = "Headphones";
            ActivePageNum = 1;
            fillPageWithProdocts("Headphones", ActivePageNum, null);
        }

        private void HomeAduio_btn_Click(object sender, EventArgs e)
        {
            ActiveCategory = "Homeaudio";
            ActivePageNum = 1;
            fillPageWithProdocts("Homeaudio", ActivePageNum,null);
        }

        private void Ipad_btn_Click(object sender, EventArgs e)
        {
            ActiveCategory = "Tablets";
            subCategory = "Apple";
            ActivePageNum = 1;
            fillPageWithProdocts("Tablets", ActivePageNum, subCategory);
        }

        private void forward_btn_Click(object sender, EventArgs e)
        {
            ActivePageNum = ActivePageNum +1;
            pageNum.Text = ActivePageNum.ToString();
            fillPageWithProdocts(ActiveCategory, ActivePageNum, subCategory);
        }

        private void SamsungTV_btn_Click(object sender, EventArgs e)
        {
            ActiveCategory = "TVs";
            subCategory = "Samsung";
            ActivePageNum = 1;
            fillPageWithProdocts("TVs", ActivePageNum, subCategory);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void cart_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CartWin CW= new CartWin();
            CW.Show();
        }

        private void AddToCart1_btn_Click(object sender, EventArgs e)
        {
            DBConnection db = new DBConnection();
            db.AddToCart(data[0]["sku"].ToString(),clientObj.username);
        }

        private void AddToCart2_btn_Click(object sender, EventArgs e)
        {
            DBConnection db = new DBConnection();
            db.AddToCart(data[1]["sku"].ToString(), clientObj.username);
        }

        private void AddToCart3_btn_Click(object sender, EventArgs e)
        {
            DBConnection db = new DBConnection();
            db.AddToCart(data[2]["sku"].ToString(), clientObj.username);
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SignOut_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginWin lw = new loginWin();
            lw.Show();
        }

        private void Samsung_btn_Click(object sender, EventArgs e)
        {
            ActiveCategory = "Tablets";
            subCategory = "Samsung";
            ActivePageNum = 1;
            fillPageWithProdocts("Tablets", ActivePageNum, subCategory);
        }

        private void SonyTV_btn_Click(object sender, EventArgs e)
        {
            ActiveCategory = "TVs";
            subCategory = "Sony";
            ActivePageNum = 1;
            fillPageWithProdocts("TVs", ActivePageNum, subCategory);
        }
    }

} 

