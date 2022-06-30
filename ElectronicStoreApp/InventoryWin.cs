using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ElectronicStoreApp
{
    public partial class InventoryWin : Form
    {
        public InventoryWin()
        {
            InitializeComponent();
        }
        string checkedItem;
        private void InventoryWin_Load(object sender, EventArgs e)
        {

        }

        private void GetDatabase_btn_Click(object sender, EventArgs e)
        {
            string checkedItem = checkedListBox1.CheckedItems[0].ToString();
            DBConnection db = new DBConnection();
            DataTable dt = db.getProductDatabase(checkedItem);
            dataGridView1.DataSource = dt;
            

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = checkedListBox1.SelectedIndex;
            int count = checkedListBox1.Items.Count;
            for (int x = 0; x < count; x++)
            {
                if (index != x)
                {
                    checkedListBox1.SetItemCheckState(x, CheckState.Unchecked);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DBConnection db = new DBConnection();
            db.deleteProdoct(checkedItem);
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if ((dataGridView1.Rows.Count > 1) &&
             (e.ColumnIndex == 0))
                    {
                        dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value
              = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().ToUpper();
                    }
            }
    }
}
