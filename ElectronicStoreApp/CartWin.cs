using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ElectronicStoreApp
{
    public partial class CartWin : Form
    {
        public CartWin()
        {
            InitializeComponent();
        }

        private void Pricelb1_Click(object sender, EventArgs e)
        {

        }

        private void ProductCartDisplay_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CartWin_Load(object sender, EventArgs e)
        {
            int x = 0;

            for (int y = 0; y < 5; y++)
            {
                //Next, add a row.  Only do this when once, when creating the first column
                if (x == 0)
                {
                    CartTable.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                }

                //Create the control, in this case we will add a button


                CartTable.Controls.Add(getP(),x,y);
            }

        }

        private TableLayoutPanel getP()
        {

            TableLayoutPanel prodictPanelName;
            prodictPanelName = new System.Windows.Forms.TableLayoutPanel();
            prodictPanelName.SuspendLayout();

            ProductCartDisplay.ColumnCount = 3;
            ProductCartDisplay.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            ProductCartDisplay.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 739F));
            ProductCartDisplay.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 175F));
            ProductCartDisplay.Controls.Add(tableLayoutPanel3, 0, 0);
            ProductCartDisplay.Controls.Add(panel4, 1, 0);
            ProductCartDisplay.Controls.Add(tableLayoutPanel25, 2, 0);
            ProductCartDisplay.Location = new Point(3, 733);
            ProductCartDisplay.Name = "ProductCartDisplay1";
            ProductCartDisplay.RowCount = 1;
            ProductCartDisplay.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            ProductCartDisplay.RowStyles.Add(new RowStyle(SizeType.Absolute, 122F));
            ProductCartDisplay.Size = new Size(1209, 122);
            ProductCartDisplay.TabIndex = 1;
            ProductCartDisplay.Paint += new PaintEventHandler(ProductCartDisplay_Paint);

            return prodictPanelName;
        }


    }
}

