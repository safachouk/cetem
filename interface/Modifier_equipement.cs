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
            comboBox5.Items.Clear();
            comboBox5.Items.AddRange(Databaseconnection.getservice());
        }

        private void ajouterregion()
        {
            comboBox7.Items.Clear();
            comboBox7.Items.AddRange(Databaseconnection.GetRegions());
        }

        private void ajouthopital()
        {
            comboBox6.Items.Clear();
            comboBox6.Items.AddRange(Databaseconnection.gethopital());
        }

        Dispositifsbiomedicale elem; 
        public void setEquipement(int id)
        {
            elem = Databaseconnection.getEquipement(id);
            comboBox7.Text = elem.Nom_region1;
            comboBox8.Text = elem.Type1;
            comboBox6.Text = elem.Nom_hopital1;
            comboBox5.Text = elem.Nom_service1;
            textBox5.Text = elem.Marque1;
            textBox2.Text = elem.modele1;
            textBox3.Text = elem.Numero_serie1;
            




        }
    private void Modifier_equipement_Load(object sender, EventArgs e)
    {

    }

        private void Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
           Databaseconnection.Modifier_equipmement(textBox5.Text, comboBox8.Text, textBox2.Text, textBox3.Text, comboBox6.Text, comboBox5.Text, comboBox7.Text, elem.Id)?
            "équipement Modifier avec succée" :
            "Problem de modification de l'équipement");
        }
    }
}
