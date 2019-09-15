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
    public partial class Ajouter_equipement : Form
{
    public Ajouter_equipement()
    {
            InitializeComponent();
    }

        private void Button2_Click(object sender, EventArgs e)
  
        {

            MessageBox.Show(
            Databaseconnection.Ajouter_equipement(comboBox2.Text , textBox2.Text , textBox3.Text , textBox1.Text , comboBox1.Text , comboBox3.Text , comboBox4.Text) ?
             "équipement ajouté avec succée" :
             "Problem d'ajout de l'équipement");
       


        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
