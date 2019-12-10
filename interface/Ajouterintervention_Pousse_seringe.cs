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
    public partial class Ajouterintervention_Pousse_seringe : Form
{
    public Ajouterintervention_Pousse_seringe()
    {
        InitializeComponent();
            ajoutintervenant();
            ajoutdemande();
            
        }


        private void ajoutintervenant()
        {
            comboBox3.Items.Clear();
            comboBox3.Items.AddRange(Databaseconnection.getintervenant());
        }

        private void ajoutdemande()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(Databaseconnection.getdemandepousse());
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
                MessageBox.Show("Vous devez spécifier l'etat de l'équipement.", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!radioButton11.Checked && !radioButton12.Checked)
            {
                MessageBox.Show("Vous devez spécifier l'etat de la sécurite électrique.", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!radioButton7.Checked && !radioButton8.Checked)
            {
                MessageBox.Show("Vous devez spécifier l'etat de test prémier voie.", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!radioButton9.Checked && !radioButton10.Checked)
            {
                MessageBox.Show("Vous devez spécifier l'etat de test déuxieme voie.", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string etatintervention1 = radioButton1.Checked ? radioButton1.Text : radioButton2.Text;
            string etatequipement1 = radioButton3.Checked ? radioButton3.Text : radioButton4.Text;
            string etatsecurite1 = radioButton11.Checked ? radioButton11.Text : radioButton12.Text;
            string testpremiervoie = radioButton7.Checked ? radioButton7.Text : radioButton8.Text;
            string testdeuxiemevoie = radioButton9.Checked ? radioButton9.Text : radioButton10.Text;




            var result = Databaseconnection.intervention_pousse_seringe(textBox3.Text, dateTimePicker1.Text, etatintervention1, comboBox3.Text, etatsecurite1, testpremiervoie, testdeuxiemevoie, richTextBox1.Text, comboBox1.Text, etatequipement1, comboBox2.Text , comboBox4.Text);
            
            if (result)
            {
                MessageBox.Show("Pousse seringue ajouté avec succée");
                this.Close();
            }
            else
                MessageBox.Show("Problem d'ajout de Pousse seringue");


        }

        private void ajouttypepousse(object sender, EventArgs e)
        {
            comboBox4.Items.Clear();
            comboBox4.Items.AddRange(Databaseconnection.getmodelepousse(comboBox1.SelectedItem.ToString()));

        }

        private void Ajoutseriepousse(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(Databaseconnection.getseriepousse(comboBox4.SelectedItem.ToString()));

        }

      
    }
}
