using CetemLibrary;
using CetemLibrary.Modeles;
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
    public partial class Modifier_equipement : Form
{
    public Modifier_equipement()
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

        private void ajouterregion()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(Databaseconnection.GetRegions());
        }

        private void ajouthopital()
        {
            comboBox3.Items.Clear();
            comboBox3.Items.AddRange(Databaseconnection.gethopital());
        }

        Dispositifsbiomedicale elem; 
        public void setEquipement(int id)
        {
            elem = Databaseconnection.getEquipement(id);
            comboBox1.Text = elem.Nom_region1;
            comboBox2.Text = elem.Type1;
            comboBox3.Text = elem.Nom_hopital1;
            comboBox4.Text = elem.Nom_service1;
            textBox3.Text = elem.Marque1;
            textBox5.Text = elem.modele1;
            textBox1.Text = elem.Numero_serie1;
            




        }
    private void Modifier_equipement_Load(object sender, EventArgs e)
    {

    }

        private void Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
           Databaseconnection.Modifier_equipmement(textBox3.Text, comboBox2.Text, textBox5.Text, textBox1.Text, comboBox3.Text, comboBox4.Text, comboBox1.Text, elem.Id)?
            "équipement Modifier avec succée" :
            "Problem de modification de l'équipement");
        }
    }
}
