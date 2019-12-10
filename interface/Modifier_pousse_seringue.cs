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
    public partial class Modifier_pousse_seringue : Form


    {
    public Modifier_pousse_seringue()

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
        Intervention_pousse_seringue ps;
       public void setpousseseringue(int id )
        {
            ps = Databaseconnection.getPousse(id);

            textBox3.Text = ps.numero_intervention;
            dateTimePicker1.Text = ps.date_intervention;
       
            switch (ps.Etat_intervention)
            {
                case "En cours":
                    radioButton1.Select();
                    break;
                default:
                    radioButton2.Select(); break;
            }
            comboBox3.Text = ps.Intervenant;
      
            switch (ps.Test_sécurit_électrique)
            {
                case "Bon":
                    radioButton12.Select();
                    break;
                default:
                    radioButton11.Select(); break;
            }
         

            switch (ps.Test_performance_prémiere_voie)
            {
                case "Bon":
                    radioButton8.Select();
                    break;
                default:
                    radioButton7.Select(); break;
            }
         
            switch (ps.Test_performance_déuxieme_voie)
            {
                case "Bon":
                    radioButton10.Select();
                    break;
                default:
                    radioButton9.Select(); break;
            }
            richTextBox1.Text = ps.Commentaire;
            comboBox1.Text = ps.Numero_demande;
          
            switch (ps.etat_equip)
            {
                case "Bonne":
                    radioButton3.Select();
                    break;
                default:
                    radioButton4.Select(); break;
            }
            comboBox2.Text = ps.num_ser_equip;
            comboBox4.Text = ps.typeequipement;

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            string etatintervention11 = radioButton1.Checked ? radioButton1.Text : radioButton2.Text;
            string etatequipement11 = radioButton3.Checked ? radioButton3.Text : radioButton4.Text;
            string etatsecurite11 = radioButton11.Checked ? radioButton11.Text : radioButton12.Text;
            string testpremiervoie1 = radioButton7.Checked ? radioButton7.Text : radioButton8.Text;
            string testdeuxiemevoie1 = radioButton9.Checked ? radioButton9.Text : radioButton10.Text;
            //string numpousse , string datepousse1 , string etatpouss1 , string iterpouss1 , string tspouss1 , string tspvpou1 , string tsp2pouss1 , string compouss1 , string numpousse1 , string etatequip , string seriepouss1 , string typeequip , int id



            var result = Databaseconnection.Modifier_interv_pousse_seringue(textBox3.Text, dateTimePicker1.Text, etatintervention11, comboBox3.Text, etatsecurite11, testpremiervoie1, testdeuxiemevoie1, richTextBox1.Text, comboBox1.Text, etatequipement11, comboBox2.Text, comboBox4.Text , ps.id_pousse);
            if(result)
            {
                MessageBox.Show("Pousse seringue modifié avec succée");
                this.Close();

            }
            else
                MessageBox.Show("Problem de modification de Pousse seringue");
        }

        private void Updatemarquepousse(object sender, EventArgs e)
        {
            comboBox4.Items.Clear();
            comboBox4.Items.AddRange(Databaseconnection.getmodelepousse(comboBox1.SelectedItem.ToString()));

        }

        private void updatenumeropousse(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(Databaseconnection.getseriepousse(comboBox4.SelectedItem.ToString()));
        }
    }


}
