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
    public partial class Shop : Form
    {
        private Postac postac;
        private Form2 form2;


        public Shop(Postac postac, Form2 form2)
        {
            InitializeComponent();
            this.postac = postac; // Przypisanie przekazanej postaci do zmiennej klasy
            this.form2 = form2;
            // Wyświetlenie informacji o postaci
            label_name.Text = postac.Imie;
            label_gold.Text = $"Gold: {postac.Gold}";
            label_hp.Text = $"HP: {postac.HP}";
            label_attack.Text = $"Attack: {postac.Attack}";
            label_defense.Text = $"Defense: {postac.Defense}";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Ukryj Shop i pokaż Form2 (menu) po zamknięciu
            this.Close();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            form2.Show(); // Pokaż Form2 po zamknięciu Shop
        }

        private void Shop_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
