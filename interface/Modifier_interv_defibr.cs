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
    public partial class Modifier_interv_defibr : Form
{
    public Modifier_interv_defibr()
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
            comboBox2.Items.AddRange(Databaseconnection.getdemandedefibrill());
        }

        private void ajoutintervenant()
        {
            comboBox3.Items.Clear();
            comboBox3.Items.AddRange(Databaseconnection.getintervenant());
        }

        Intervention_defibrillateur de;
       public void setdefibrillateur(int id)
        {
            de = Databaseconnection.getdefibrillateur(id);
            textBox1.Text = de.Numero_intervention6;
            dateTimePicker1.Text = de.Date_intervention;
          
            switch(de.Etat_intervention)
            {
                case "En cours": radioButton1.Select();
                    break;
                default:
                    radioButton2.Select(); break;
            }

            comboBox3.Text = de.Intervenant;
           
            switch (de.Test_securit_electrique)
            {
                case "True": radioButton12.Select();
                    break;
                default:
                    radioButton11.Select(); break;
            }
        
            switch (de.Test_indicateur_mode_synchro)
            {
                case "True":
                    radioButton6.Select();
                    break;
                default:
                    radioButton5.Select(); break;
            }
         
            switch (de.Test_indicateur_mode_normale)
            {
                case "True":
                    radioButton16.Select();
                    break;
                default:
                    radioButton15.Select(); break;
            }
         
            switch (de.Test_temps_charge)
            {
                case "True":
                    radioButton8.Select();
                    break;
                default:
                    radioButton7.Select(); break;
            }
         
            switch (de.Testmesureenergie)
            {
                case "True":
                    radioButton10.Select();
                    break;
                default:
                    radioButton9.Select(); break;
            }
        
            switch (de.Test_taux_de_perte)
            {
                case "True":
                    radioButton14.Select();
                    break;
                default:
                    radioButton13.Select(); break;
            }
         
            switch (de.Testmoniteurecg)
            {
                case "True":
                    radioButton18.Select();
                    break;
                default:
                    radioButton17.Select(); break;
            }
         
            switch (de.Testenregistrementpapier)
            {
                case "True":
                    radioButton20.Select();
                    break;
                default:
                    radioButton19.Select(); break;
            }
            richTextBox1.Text = de.Commentaire;
            comboBox2.Text = de.Numero_demande10;
            textBox3.Text = de.type_equip2;
            
            switch (de.etat_equip25)
            {
                case "True": radioButton3.Select();
                    break;
                default:
                    radioButton4.Select();break;
            }




        }

        private void Modifier_interv_defibr_Load(object sender, EventArgs e)
        {

        }

        private void GroupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void GroupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string etatintervention5661 = radioButton1.Checked ? radioButton1.Text : radioButton2.Text;
            string etatequipement5661 = radioButton3.Checked ? radioButton3.Text : radioButton4.Text;
            string testsecuriteelectrique5561 = radioButton11.Checked ? radioButton11.Text : radioButton12.Text;
            string testindicateursynchro1 = radioButton5.Checked ? radioButton5.Text : radioButton6.Text;
            string testmoniteur1 = radioButton17.Checked ? radioButton17.Text : radioButton18.Text;
            string testenergie1 = radioButton9.Checked ? radioButton9.Text : radioButton10.Text;
            string testtempscharge1 = radioButton7.Checked ? radioButton7.Text : radioButton8.Text;
            string indicateurnormale1 = radioButton15.Checked ? radioButton15.Text : radioButton16.Text;
            string enregistrementpapier1 = radioButton19.Checked ? radioButton19.Text : radioButton20.Text;
            string tauxperte1 = radioButton13.Checked ? radioButton13.Text : radioButton14.Text;



            var result = Databaseconnection.Modifier_interv_defibrillateur(textBox1.Text, dateTimePicker1.Text, etatintervention5661, comboBox3.Text, testsecuriteelectrique5561, testindicateursynchro1, indicateurnormale1, testtempscharge1, testenergie1, tauxperte1, testmoniteur1, enregistrementpapier1, richTextBox1.Text, comboBox2.Text, textBox3.Text, etatequipement5661, de.id_defib);
        
            if (result)
            {
                MessageBox.Show("Défibrillateur modifié avec succée");
                this.Close();

            }
            else
                MessageBox.Show("Problem de modification de Défibrillateur");
        }
    }
}
