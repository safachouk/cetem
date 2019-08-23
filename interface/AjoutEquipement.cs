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
    public partial class AjoutEquipemnt : Form
{
    public AjoutEquipemnt()
    {
        InitializeComponent();
    }

        private void Button2_Click(object sender, EventArgs e)
        {
            var add = Databaseconnection.Ajouter_equipement (textBox2.Text, comboBox2.Text, textBox1.Text, comboBox3.Text, comboBox4.Text, comboBox1.Text);
            var modifi = Databaseconnection.Modifier_equipmement(textBox2.Text, comboBox2.Text, textBox1.Text, comboBox3.Text, comboBox4.Text, comboBox1.Text);

        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
