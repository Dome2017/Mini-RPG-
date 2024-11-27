using WinFormsApp2.models;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string imie = textBox2.Text;

            var postac = new Postac(imie, gold: 100, hp: 200, attack: 50, defense: 10);

            Form2 noweOkno = new Form2(postac);

            this.Hide();
            noweOkno.FormClosed += (s, args) => this.Show();
            noweOkno.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}