namespace WinFormsApp2
{
    partial class Form2
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
            label_name = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label_gold = new Label();
            label_hp = new Label();
            label_attack = new Label();
            label_defense = new Label();
            button4 = new Button();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label_name
            // 
            label_name.AutoSize = true;
            label_name.BackColor = SystemColors.GradientActiveCaption;
            label_name.Location = new Point(12, 51);
            label_name.Name = "label_name";
            label_name.Size = new Size(67, 15);
            label_name.TabIndex = 0;
            label_name.Text = "label_name";
            label_name.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(362, 181);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Walka";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(362, 268);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Sklep";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(362, 358);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 3;
            button3.Text = "Wyjście";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label_gold
            // 
            label_gold.AutoSize = true;
            label_gold.BackColor = SystemColors.GradientActiveCaption;
            label_gold.Location = new Point(50, 12);
            label_gold.Name = "label_gold";
            label_gold.Size = new Size(61, 15);
            label_gold.TabIndex = 5;
            label_gold.Text = "label_gold";
            label_gold.Click += label2_Click;
            // 
            // label_hp
            // 
            label_hp.AutoSize = true;
            label_hp.BackColor = SystemColors.GradientActiveCaption;
            label_hp.Location = new Point(12, 80);
            label_hp.Name = "label_hp";
            label_hp.Size = new Size(51, 15);
            label_hp.TabIndex = 6;
            label_hp.Text = "label_hp";
            // 
            // label_attack
            // 
            label_attack.AutoSize = true;
            label_attack.BackColor = SystemColors.GradientActiveCaption;
            label_attack.Location = new Point(12, 107);
            label_attack.Name = "label_attack";
            label_attack.Size = new Size(69, 15);
            label_attack.TabIndex = 7;
            label_attack.Text = "label_attack";
            // 
            // label_defense
            // 
            label_defense.AutoSize = true;
            label_defense.BackColor = SystemColors.GradientActiveCaption;
            label_defense.Location = new Point(12, 135);
            label_defense.Name = "label_defense";
            label_defense.Size = new Size(78, 15);
            label_defense.TabIndex = 8;
            label_defense.Text = "label_defense";
            // 
            // button4
            // 
            button4.Location = new Point(12, 162);
            button4.Name = "button4";
            button4.Size = new Size(78, 23);
            button4.TabIndex = 9;
            button4.Text = "Ekwipunek";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.coin_04;
            pictureBox3.Location = new Point(12, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 32);
            pictureBox3.TabIndex = 16;
            pictureBox3.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.menu_background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox3);
            Controls.Add(button4);
            Controls.Add(label_defense);
            Controls.Add(label_attack);
            Controls.Add(label_hp);
            Controls.Add(label_gold);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label_name);
            DoubleBuffered = true;
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_name;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label_gold;
        private Label label_hp;
        private Label label_attack;
        private Label label_defense;
        private Label label6;
        private Button button4;
        private PictureBox pictureBox3;
    }
}