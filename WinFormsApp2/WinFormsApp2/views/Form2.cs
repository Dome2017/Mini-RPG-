using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp2.models;

namespace WinFormsApp2
{
    public partial class Form2 : Form
    {
        private Postac postac; // Zmienna klasy przechowująca obiekt Postac

        public Form2(Postac postac)
        {
            InitializeComponent();
            this.postac = postac; // Przypisanie przekazanej postaci do zmiennej klasy

            // Wyświetlenie informacji o postaci
            label_name.Text = postac.Imie;
            label_gold.Text = $"Gold: {postac.Gold}";
            label_hp.Text = $"HP: {postac.HP}";
            label_attack.Text = $"Attack: {postac.Attack}";
            label_defense.Text = $"Defense: {postac.Defense}";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Załóżmy, że masz już instancję `postac` w `Form2`
            Shop shopOkno = new Shop(postac, this);
            OknoEQ oknoEQ = new OknoEQ(postac, this);
            
            oknoEQ.Show();
            // Ukryj `Form2` i pokaż `Shop`
            this.Hide();
            shopOkno.FormClosed += (s, args) => this.Show();
            shopOkno.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            OknoEQ oknoEQ = new OknoEQ(postac, this);
            oknoEQ.FormClosed += (s, args) => this.Show();
            oknoEQ.Show();
        }
    }
}
