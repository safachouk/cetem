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
    public partial class AjouterIntervention_Respirateur : Form
{
    public AjouterIntervention_Respirateur()
    {
        InitializeComponent();
            ajoutintervenant();
            ajoutdemande();
            ajoutserresp();

        }

        private void ajoutserresp()
        {
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(Databaseconnection.getserresp());
        }

        private void ajoutintervenant()
        {
            comboBox3.Items.Clear();
            comboBox3.Items.AddRange(Databaseconnection.getintervenant());
        }

        private void ajoutdemande()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(Databaseconnection.getdemande());
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

             if (!radioButton5.Checked && !radioButton6.Checked)
            {
                MessageBox.Show("Vous devez spécifier l'etat de test sécurite électrique.", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }


            if (!radioButton8.Checked && !radioButton7.Checked && !radioButton9.Checked)
            {

                MessageBox.Show("Vous devez spécifier l'etat de volume contrôlée.", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!radioButton15.Checked && !radioButton14.Checked && !radioButton13.Checked)
            {
                MessageBox.Show("Vous devez spécifier l'etat detest volume assisté contrôlée .", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }


            if (!radioButton12.Checked && !radioButton11.Checked && !radioButton10.Checked)
            {

                MessageBox.Show("Vous devez spécifier l'etat de test pression contrôlée.", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            if (!radioButton18.Checked && !radioButton17.Checked && !radioButton16.Checked)
            {

                MessageBox.Show("Vous devez spécifier l'etat de test d'oxygéne.", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }


           /* If(button1.is checked== false
S= button2.checked ? ....
Else
S= button1.text...*/

             string  etatintervention = radioButton1.Checked ? radioButton1.Text : radioButton2.Text;
             string  etatequipement = radioButton3.Checked ? radioButton3.Text : radioButton4.Text;
            string etatsecurite = radioButton5.Checked ? radioButton5.Text : radioButton6.Text;


            string etatvc;
            if (radioButton8.Checked == false)
            
                etatvc = radioButton7.Checked ? radioButton7.Text : radioButton9.Text;
            
            else
                etatvc = radioButton8.Text;

            string etatvac;
            if (radioButton15.Checked == false)
                etatvac = radioButton14.Checked ? radioButton14.Text : radioButton13.Text;
            else
                etatvac = radioButton15.Text;

            string etatpress;
            if (radioButton12.Checked == false)
                etatpress = radioButton11.Checked ? radioButton11.Text : radioButton10.Text;
            else
                etatpress = radioButton12.Text;


            string etatoxyg;
            if (radioButton18.Checked == false)
                etatoxyg = radioButton17.Checked ? radioButton17.Text : radioButton16.Text;
            else
                etatoxyg = radioButton18.Text;




            var result = Databaseconnection.intervention_respirateur(textBox2.Text, dateTimePicker1.Text, comboBox3.Text, comboBox1.Text, comboBox29.Text, comboBox2.Text, etatintervention, etatsecurite, etatvc, etatequipement, etatoxyg, etatpress, etatvac, richTextBox1.Text);
           
            if (result)
            {
                MessageBox.Show("Respirateur ajouté avec succée");
                this.Close();

            }
            else
                MessageBox.Show("Problem d'ajout de Respirateur");


        }

        private void ComboBox29_SelectedIndexChanged(object sender, EventArgs e)
        {
          //  remplirListNumSerie(); select numero serie from equipemen where type equipement = type.text and id_hopital=(select id hopital from demande where num demande = numdemande.text) 

        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AjouterIntervention_Respirateur_Load(object sender, EventArgs e)
        {

        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void GroupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void GroupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void GroupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void GroupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void GroupBox6_Enter(object sender, EventArgs e)
        {

        }
    }
}
