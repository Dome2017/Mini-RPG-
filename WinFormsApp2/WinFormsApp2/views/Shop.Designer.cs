namespace WinFormsApp2
{
    partial class Shop
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
            button_exit = new Button();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            label_defense = new Label();
            label_attack = new Label();
            label_hp = new Label();
            label_gold = new Label();
            pictureBox3 = new PictureBox();
            label_name = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // button_exit
            // 
            button_exit.BackColor = SystemColors.GradientActiveCaption;
            button_exit.Location = new Point(713, 12);
            button_exit.Name = "button_exit";
            button_exit.Size = new Size(75, 23);
            button_exit.TabIndex = 0;
            button_exit.Text = "Wyjście";
            button_exit.UseVisualStyleBackColor = false;
            button_exit.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.sword32x32pack;
            pictureBox1.Location = new Point(371, 361);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(352, 399);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label_defense
            // 
            label_defense.AutoSize = true;
            label_defense.BackColor = SystemColors.GradientActiveCaption;
            label_defense.Location = new Point(21, 140);
            label_defense.Name = "label_defense";
            label_defense.Size = new Size(78, 15);
            label_defense.TabIndex = 14;
            label_defense.Text = "label_defense";
            // 
            // label_attack
            // 
            label_attack.AutoSize = true;
            label_attack.BackColor = SystemColors.GradientActiveCaption;
            label_attack.Location = new Point(21, 112);
            label_attack.Name = "label_attack";
            label_attack.Size = new Size(69, 15);
            label_attack.TabIndex = 13;
            label_attack.Text = "label_attack";
            // 
            // label_hp
            // 
            label_hp.AutoSize = true;
            label_hp.BackColor = SystemColors.GradientActiveCaption;
            label_hp.Location = new Point(21, 85);
            label_hp.Name = "label_hp";
            label_hp.Size = new Size(51, 15);
            label_hp.TabIndex = 12;
            label_hp.Text = "label_hp";
            // 
            // label_gold
            // 
            label_gold.AutoSize = true;
            label_gold.BackColor = SystemColors.GradientActiveCaption;
            label_gold.Location = new Point(50, 19);
            label_gold.Name = "label_gold";
            label_gold.Size = new Size(61, 15);
            label_gold.TabIndex = 11;
            label_gold.Text = "label_gold";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.coin_04;
            pictureBox3.Location = new Point(12, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 32);
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            // 
            // label_name
            // 
            label_name.AutoSize = true;
            label_name.BackColor = SystemColors.GradientActiveCaption;
            label_name.Location = new Point(21, 56);
            label_name.Name = "label_name";
            label_name.Size = new Size(67, 15);
            label_name.TabIndex = 9;
            label_name.Text = "label_name";
            // 
            // Shop
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.shop_background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label_defense);
            Controls.Add(label_attack);
            Controls.Add(label_hp);
            Controls.Add(label_gold);
            Controls.Add(pictureBox3);
            Controls.Add(label_name);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(button_exit);
            DoubleBuffered = true;
            Name = "Shop";
            Text = "Form3";
            Load += Shop_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_exit;
        private PictureBox pictureBox1;
        private Button button1;
        private Label label_defense;
        private Label label_attack;
        private Label label_hp;
        private Label label_gold;
        private PictureBox pictureBox3;
        private Label label_name;
    }
}