using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CetemLibrary;

namespace @interface
{
    public partial class loginpage : Form
    {
        public loginpage()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void Button1_Click(object sender, EventArgs e)
        {

            var result = Databaseconnection.se_connecter(textBox1.Text, textBox2.Text);
            if (result)
            {
                Pages form2 = new Pages();
                form2.Tag = this;
                form2.Show(this);
                Hide();
            }
        }

        private void Loginpage_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

      

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Panel5_Paint(object sender, PaintEventArgs e)
        {





        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
