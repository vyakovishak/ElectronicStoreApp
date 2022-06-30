
namespace ElectronicStoreApp
{
    partial class InventoryWin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.backward_btn = new System.Windows.Forms.Button();
            this.forward_btn = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.GetDatabase_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Location = new System.Drawing.Point(31, 210);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1292, 659);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_CellBeginEdit);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(1318, 875);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(35, 15);
            this.panel2.TabIndex = 43;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(1318, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(35, 15);
            this.panel1.TabIndex = 43;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel3.Location = new System.Drawing.Point(0, 875);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(35, 15);
            this.panel3.TabIndex = 43;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(35, 15);
            this.panel4.TabIndex = 44;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel5.Controls.Add(this.backward_btn);
            this.panel5.Controls.Add(this.forward_btn);
            this.panel5.Location = new System.Drawing.Point(1329, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(24, 864);
            this.panel5.TabIndex = 45;
            // 
            // backward_btn
            // 
            this.backward_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backward_btn.BackgroundImage = global::ElectronicStoreApp.Properties.Resources.left_arrow;
            this.backward_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backward_btn.FlatAppearance.BorderSize = 0;
            this.backward_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backward_btn.Location = new System.Drawing.Point(-96, 1225);
            this.backward_btn.Name = "backward_btn";
            this.backward_btn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.backward_btn.Size = new System.Drawing.Size(33, 25);
            this.backward_btn.TabIndex = 0;
            this.backward_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.backward_btn.UseVisualStyleBackColor = true;
            // 
            // forward_btn
            // 
            this.forward_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.forward_btn.BackgroundImage = global::ElectronicStoreApp.Properties.Resources.right_arrow;
            this.forward_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.forward_btn.FlatAppearance.BorderSize = 0;
            this.forward_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forward_btn.Location = new System.Drawing.Point(-33, 1225);
            this.forward_btn.Name = "forward_btn";
            this.forward_btn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.forward_btn.Size = new System.Drawing.Size(31, 25);
            this.forward_btn.TabIndex = 1;
            this.forward_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.forward_btn.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel6.Controls.Add(this.button1);
            this.panel6.Controls.Add(this.button2);
            this.panel6.Location = new System.Drawing.Point(31, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1292, 12);
            this.panel6.TabIndex = 46;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackgroundImage = global::ElectronicStoreApp.Properties.Resources.left_arrow;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(450, 1181);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(33, 25);
            this.button1.TabIndex = 0;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackgroundImage = global::ElectronicStoreApp.Properties.Resources.right_arrow;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(513, 1181);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button2.Size = new System.Drawing.Size(31, 25);
            this.button2.TabIndex = 1;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel7.Controls.Add(this.button3);
            this.panel7.Controls.Add(this.button4);
            this.panel7.Location = new System.Drawing.Point(0, 12);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(24, 864);
            this.panel7.TabIndex = 47;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.BackgroundImage = global::ElectronicStoreApp.Properties.Resources.left_arrow;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(-184, 1607);
            this.button3.Name = "button3";
            this.button3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button3.Size = new System.Drawing.Size(33, 25);
            this.button3.TabIndex = 0;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.BackgroundImage = global::ElectronicStoreApp.Properties.Resources.right_arrow;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(-121, 1607);
            this.button4.Name = "button4";
            this.button4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button4.Size = new System.Drawing.Size(31, 25);
            this.button4.TabIndex = 1;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel8.Controls.Add(this.button5);
            this.panel8.Controls.Add(this.button6);
            this.panel8.Location = new System.Drawing.Point(31, 878);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1292, 24);
            this.panel8.TabIndex = 48;
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button5.BackgroundImage = global::ElectronicStoreApp.Properties.Resources.left_arrow;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(450, 1187);
            this.button5.Name = "button5";
            this.button5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button5.Size = new System.Drawing.Size(33, 25);
            this.button5.TabIndex = 0;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button6.BackgroundImage = global::ElectronicStoreApp.Properties.Resources.right_arrow;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(513, 1187);
            this.button6.Name = "button6";
            this.button6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button6.Size = new System.Drawing.Size(31, 25);
            this.button6.TabIndex = 1;
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(498, 122);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(82, 42);
            this.Update.TabIndex = 49;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(353, 122);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(92, 42);
            this.button7.TabIndex = 51;
            this.button7.Text = "Delete";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "TVs",
            "Computers",
            "Laptops",
            "Homeaudio",
            "Desktops",
            "Homeaudio"});
            this.checkedListBox1.Location = new System.Drawing.Point(99, 40);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(138, 94);
            this.checkedListBox1.TabIndex = 52;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // GetDatabase_btn
            // 
            this.GetDatabase_btn.Location = new System.Drawing.Point(99, 141);
            this.GetDatabase_btn.Name = "GetDatabase_btn";
            this.GetDatabase_btn.Size = new System.Drawing.Size(138, 23);
            this.GetDatabase_btn.TabIndex = 53;
            this.GetDatabase_btn.Text = "Get Database";
            this.GetDatabase_btn.UseVisualStyleBackColor = true;
            this.GetDatabase_btn.Click += new System.EventHandler(this.GetDatabase_btn_Click);
            // 
            // InventoryWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1354, 888);
            this.Controls.Add(this.GetDatabase_btn);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "InventoryWin";
            this.Text = "InventoryWin";
            this.Load += new System.EventHandler(this.InventoryWin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button backward_btn;
        private System.Windows.Forms.Button forward_btn;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button GetDatabase_btn;
    }
}