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
    public partial class Modifier_demande : Form
{
    public Modifier_demande()
    {
        InitializeComponent();
            
            ajouterregion();
            ajouterhopital();
        }

        private void ajouterhopital()
        {
            comboBox8.Items.Clear();
            comboBox8.Items.AddRange(Databaseconnection.gethopital());
        }

        private void ajouterregion()
        {
            comboBox9.Items.Clear();
            comboBox9.Items.AddRange(Databaseconnection.GetRegions());
        }

        Demande_class demm;
        public void setdemande(int id)
        {
            demm = Databaseconnection.getdemande(id);
            textBox2.Text= demm.Nombre_Respirateur_anesthesie ;
            textBox1.Text = demm.Date_Demande;
            comboBox6.Text = demm.Etat_demande;
            textBox8.Text = demm.Numero_demande;
            comboBox9.Text = demm.region_demande;
            comboBox8.Text = demm.Hopital_demande;
            textBox3.Text = demm.Nombre_respirateur_reanimation;
            textBox5.Text = demm.nombre_pousse_seringe;
            textBox6.Text = demm.nombre_defibrillateur;
            textBox4.Text = demm.Nombre_respirateur_transport;
            textBox7.Text = demm.Nombre_bistouri ;

        }

        private void Button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
         Databaseconnection.Modifier_Demande(textBox2.Text ,textBox1.Text, comboBox6.Text, textBox8.Text, comboBox9.Text, comboBox8.Text, textBox3.Text , textBox5.Text , textBox6.Text , textBox4.Text , textBox7.Text , demm.ID_DEMANDE) ?
          "demande Modifier avec succée" :
          "Problem de modification de la demande ");
        }

        private void Modifier_demande_Load(object sender, EventArgs e)
        {

        }
    }
}
