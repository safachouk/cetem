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
            textBox8.Text= demm.Nombre_Respirateur_anesthesie ;
            textBox1.Text = demm.Date_Demande;
            textBox2.Text = demm.Etat_demande;
            textBox1.Text = demm.Numero_demande;
            comboBox9.Text = demm.region_demande;
            comboBox8.Text = demm.Hopital_demande;
            textBox9.Text = demm.Nombre_respirateur_reanimation;
            textBox11.Text = demm.nombre_pousse_seringe;
            textBox12.Text = demm.nombre_defibrillateur;
            textBox10.Text = demm.Nombre_respirateur_transport;
            textBox13.Text = demm.Nombre_bistouri ;

        }

        private void Button10_Click(object sender, EventArgs e)
        {

            var result = Databaseconnection.Modifier_Demande(textBox8.Text, dateTimePicker1.Text, textBox2.Text, textBox1.Text, comboBox9.Text, comboBox8.Text, textBox9.Text, textBox11.Text, textBox12.Text, textBox10.Text, textBox13.Text, demm.ID_DEMANDE);
         
         
            if (result)
            {
                MessageBox.Show("demande Modifier avec succée" );
                this.Close();

            }
            else
                MessageBox.Show("Problem de modification de la demande ");
        }

        private void Modifier_demande_Load(object sender, EventArgs e)
        {

        }

        private void UpdateDemande(object sender, EventArgs e)
        {
             if (sender is ComboBox c)
            {
                var name = c.Text;
                if (string.IsNullOrEmpty(name.Trim()))
                    name = "%";
                comboBox8.Items.Clear();
                comboBox8.Items.AddRange(Databaseconnection.gethopital(name));
            }
        }
    }
}
