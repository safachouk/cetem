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
    public partial class Ajouterintervention_defibrillateur : Form
{
    public Ajouterintervention_defibrillateur()
    {
        InitializeComponent();
            ajoutintervenant();
            ajoutdemande();
            ajoutserie();
    }

        private void ajoutserie()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(Databaseconnection.getseriedefib());
        }

        private void ajoutdemande()
        {
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(Databaseconnection.getdemande());
        }

        private void ajoutintervenant()
        {
            comboBox3.Items.Clear();
            comboBox3.Items.AddRange(Databaseconnection.getintervenant());
        }

        private void Button1_Click(object sender, EventArgs e)
    {


            if (!radioButton1.Checked && !radioButton2.Checked)
            {
                MessageBox.Show("Vous devez spécifier l'etat d'intervention.", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!radioButton3.Checked && !radioButton4.Checked)
            {
                MessageBox.Show("Vous devez spécifier l'état de l'équipement.", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!radioButton11.Checked && !radioButton12.Checked)
            {
                MessageBox.Show("Vous devez spécifier l'etat de test sécurite électrique.", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!radioButton5.Checked && !radioButton6.Checked)
            {
                MessageBox.Show("Vous devez spécifier l'etat de test indicateur synchro.", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!radioButton17.Checked && !radioButton18.Checked)
            {
                MessageBox.Show("Vous devez spécifier l'etat de test de moniteur et module ECG.", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!radioButton9.Checked && !radioButton10.Checked)
            {
                MessageBox.Show("Vous devez spécifier l'etat de test d'énergie.", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!radioButton7.Checked && !radioButton8.Checked)
            {
                MessageBox.Show("Vous devez spécifier l'etat de test de temps de charge.", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!radioButton15.Checked && !radioButton16.Checked)
            {
                MessageBox.Show("Vous devez spécifier l'etat de test d'indicateur normale.", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!radioButton19.Checked && !radioButton20.Checked)
            {
                MessageBox.Show("Vous devez spécifier l'etat de test de enregistrement papier.", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string etatintervention566 = radioButton1.Checked ? radioButton1.Text : radioButton2.Text; 
            string etatequipement566 = radioButton3.Checked ? radioButton3.Text : radioButton4.Text;
            string testsecuriteelectrique556 = radioButton11.Checked ? radioButton11.Text : radioButton12.Text;
            string testindicateursynchro = radioButton5.Checked ? radioButton5.Text : radioButton6.Text;
            string testmoniteur = radioButton17.Checked ? radioButton17.Text : radioButton18.Text;
            string testenergie = radioButton9.Checked ? radioButton9.Text : radioButton10.Text;
            string testtempscharge = radioButton7.Checked ? radioButton7.Text : radioButton8.Text;
            string indicateurnormale = radioButton15.Checked ? radioButton15.Text : radioButton16.Text;
            string enregistrementpapier = radioButton19.Checked ? radioButton19.Text : radioButton20.Text;
            string tauxperte = radioButton13.Checked ? radioButton13.Text : radioButton14.Text;



            var result = Databaseconnection.ajout_defibrillateur(textBox6.Text, textBox3.Text, etatintervention566, comboBox3.Text, testsecuriteelectrique556, testindicateursynchro, indicateurnormale, testtempscharge, testenergie, tauxperte, testmoniteur, enregistrementpapier, richTextBox1.Text, comboBox2.Text, textBox5.Text, etatequipement566);
          if (result)
            {
                MessageBox.Show("Défibrillateur ajouté avec succée");
                this.Close();
            }
          else
                MessageBox.Show("Problem d'ajout de Défibrillateur");






        }

        private void Ajouterintervention_defibrillateur_Load(object sender, EventArgs e)
        {

        }

        private void DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
