
namespace ElectronicStoreApp
{
    partial class menuWin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Prodoct_Tittle_1 = new System.Windows.Forms.Label();
            this.PriceTag_1 = new System.Windows.Forms.Label();
            this.Description_1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(97, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 550);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.Prodoct_Tittle_1);
            this.groupBox1.Controls.Add(this.PriceTag_1);
            this.groupBox1.Controls.Add(this.Description_1);
            this.groupBox1.Location = new System.Drawing.Point(15, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(892, 162);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 142);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(811, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Prodoct_Tittle_1
            // 
            this.Prodoct_Tittle_1.AutoSize = true;
            this.Prodoct_Tittle_1.Location = new System.Drawing.Point(187, 14);
            this.Prodoct_Tittle_1.Name = "Prodoct_Tittle_1";
            this.Prodoct_Tittle_1.Size = new System.Drawing.Size(38, 15);
            this.Prodoct_Tittle_1.TabIndex = 4;
            this.Prodoct_Tittle_1.Text = "label1";
            // 
            // PriceTag_1
            // 
            this.PriceTag_1.AutoSize = true;
            this.PriceTag_1.Location = new System.Drawing.Point(736, 37);
            this.PriceTag_1.Name = "PriceTag_1";
            this.PriceTag_1.Size = new System.Drawing.Size(38, 15);
            this.PriceTag_1.TabIndex = 12;
            this.PriceTag_1.Text = "label9";
            // 
            // Description_1
            // 
            this.Description_1.AutoSize = true;
            this.Description_1.Location = new System.Drawing.Point(187, 37);
            this.Description_1.Name = "Description_1";
            this.Description_1.Size = new System.Drawing.Size(38, 15);
            this.Description_1.TabIndex = 5;
            this.Description_1.Text = "label2";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(968, 638);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 692);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Name = "menuWin";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label PriceTag_1;
        private System.Windows.Forms.Label Description_1;
        private System.Windows.Forms.Label Prodoct_Tittle_1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
    }
}