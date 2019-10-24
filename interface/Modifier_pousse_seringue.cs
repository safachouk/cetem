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
    }
        Intervention_pousse_seringue ps;
       public void setpousseseringue(int id )
        {
            ps = Databaseconnection.getPousse(id);

            textBox3.Text = ps.numero_intervention;
            textBox2.Text = ps.date_intervention;
       
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


        }

        private void Button1_Click(object sender, EventArgs e)
        {

            string etatintervention11 = radioButton1.Checked ? radioButton1.Text : radioButton2.Text;
            string etatequipement11 = radioButton3.Checked ? radioButton3.Text : radioButton4.Text;
            string etatsecurite11 = radioButton11.Checked ? radioButton11.Text : radioButton12.Text;
            string testpremiervoie1 = radioButton7.Checked ? radioButton7.Text : radioButton8.Text;
            string testdeuxiemevoie1 = radioButton9.Checked ? radioButton9.Text : radioButton10.Text;




            var result = Databaseconnection.Modifier_interv_pousse_seringue(textBox3.Text, dateTimePicker1.Text, etatintervention11, comboBox3.Text, etatsecurite11, testpremiervoie1, testdeuxiemevoie1, richTextBox1.Text, comboBox1.Text, etatequipement11, comboBox2.Text, ps.id_pousse);
            if(result)
            {
                MessageBox.Show("Pousse seringue modifié avec succée");
                this.Close();

            }
            else
                MessageBox.Show("Problem de modification de Pousse seringue");
        }

        private void Modifier_pousse_seringue_Load(object sender, EventArgs e)
        {

        }

        private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }


}
