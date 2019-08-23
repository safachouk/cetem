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

        private void Button1_Click(object sender, EventArgs e)
        {
            var result = Databaseconnection.se_connecter(textBox1.Text, textBox2.Text);
            if (result)
            {
                Pages p = new Pages();
                p.Show();
                //this.Close();
            }
        }
    }
}
