using CetemLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace @interface

    {  
    public partial class Pages : Form
{
    public Pages()
    {
            InitializeComponent();

    }

        private void Button3_Click(object sender, EventArgs e)
        {
            AjoutEquipemnt equip = new AjoutEquipemnt();
            equip.Show();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            AjoutEquipemnt Modifi = new AjoutEquipemnt();
            Modifi.Show();

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            var supp = Databaseconnection.supprimer_equipement(comboBox1.Text , comboBox2.Text , comboBox3.Text , comboBox4.Text);
        }
    }
}