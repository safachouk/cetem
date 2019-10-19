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
            ajouterregion();
            ajouthopital();
            ajoutservice();


    }

        private void ajoutservice()
        {
            comboBox4.Items.Clear();
            comboBox4.Items.AddRange(Databaseconnection.getservice());
        }

        private void ajouthopital()
        {
            comboBox3.Items.Clear();
            comboBox3.Items.AddRange(Databaseconnection.gethopital());
        }

        private void ajouterregion()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(Databaseconnection.GetRegions());
        }

        private void Button2_Click(object sender, EventArgs e)
  
        {

            if (comboBox1.Text == "")
            {
                MessageBox.Show("Vous devez donner la région.", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (comboBox3.Text =="")
            {

                MessageBox.Show("Vous devez donner le nom de l'hopital.", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (comboBox4.Text =="")
            {
                MessageBox.Show("Vous devez donner le service.", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            if (comboBox2.Text=="")
            {

                MessageBox.Show("Vous devez choisir le type de l'équipement.", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textBox2.Text =="")
            {
                MessageBox.Show("Vous devez donner la marque de l'équipement.", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        
            if (textBox3.Text =="")
            {

                MessageBox.Show("Vous devez donner le modéle de l'équipement.", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(textBox1.Text=="")
            {

                MessageBox.Show("Vous devez donner le numéro de série de l'équipement.", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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
