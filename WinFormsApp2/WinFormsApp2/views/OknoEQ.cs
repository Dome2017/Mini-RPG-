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
    public partial class OknoEQ : Form
    {
        private Postac postac;
        private Form2 form2;
        public OknoEQ(Postac postac, Form2 form2)
        {
            InitializeComponent();
        }

        private void OknoEQ_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox46_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
