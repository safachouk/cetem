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
    public partial class Modifier_inter_Bist : Form
{
    public Modifier_inter_Bist()
    {
            InitializeComponent();
            AjoutPersonnel();
            ajoudemande();
            ajoutserie();
        }

        private void ajoudemande()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(Databaseconnection.getdemande());
        }

        private void ajoutserie()
        {
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(Databaseconnection.getserie());
        }

        private void AjoutPersonnel()
        {
            comboBox3.Items.Clear();
            comboBox3.Items.AddRange(Databaseconnection.getintervenant());
        }

        Intervention_bistouri x; 
       public void setbistouri(int id)
        {
            x = Databaseconnection.getbistouri(id);
            textBox1.Text = x.Numero_intervention;
            textBox2.Text = x.Date_intervention;
          
            switch (x.Etat_intervention)
            {
                case "En cours":
                    radioButton1.Select();
                    break;
                default:
                    radioButton2.Select(); break;
            }
            comboBox3.Text = x.Intervenant;
            textBox3.Text = x.typ_equipement;
        
            switch (x.Test_securit_electrique)
            {
                case "Bon":
                    radioButton6.Select();
                    break;
                default:
                    radioButton5.Select(); break;
            }
         
            switch (x.Test_des_modes)
            {
                case "Bon":
                    radioButton8.Select();
                    break;
                default:
                    radioButton7.Select(); break;
            }
            richTextBox1.Text = x.Commentaire;
            comboBox1.Text = x.Numero_demande;
          
            switch (x.test_fuite_partie_active)
            {
                case "Bon":
                    radioButton10.Select();
                    break;
                default:
                    radioButton9.Select(); break;
            }
          
            switch (x.test_fuite_partie_neutre)
            {
                case "Bon":
                    radioButton14.Select();
                    break;
                default:
                    radioButton13.Select(); break;
            }
         
            switch (x.etat_equip)
            {
                case "Bonne":
                    radioButton3.Select();
                    break;
                default:
                    radioButton4.Select(); break;
            }
            comboBox2.Text = x.numero_serie_bistouri;

        }
        private void Button1_Click(object sender, EventArgs e)
        {
            string etatintervention33 = radioButton1.Checked ? radioButton1.Text : radioButton2.Text;
            string etatequipement33 = radioButton3.Checked ? radioButton3.Text : radioButton4.Text;
            string securitelectrique44 = radioButton5.Checked ? radioButton5.Text : radioButton6.Text;
            string testmodes1 = radioButton7.Checked ? radioButton7.Text : radioButton8.Text;
            string testfuitepartieactive1 = radioButton9.Checked ? radioButton9.Text : radioButton10.Text;
            string testfuitepartieneutre1 = radioButton13.Checked ? radioButton13.Text : radioButton14.Text;

            MessageBox.Show(
          Databaseconnection.Modifier_interv_bistouri(textBox1.Text, textBox2.Text, etatintervention33, comboBox3.Text, textBox3.Text , securitelectrique44, testmodes1, richTextBox1.Text, comboBox1.Text , testfuitepartieactive1, testfuitepartieneutre1, etatequipement33, comboBox2.Text , x.idintervention) ?
           "Bistouri modifié avec succée" :
           "Problem de modification de Bistouri");


        }


    }
}
