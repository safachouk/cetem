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
    public partial class Modifier_interv_resp : Form
    {
        public Modifier_interv_resp()
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

        private void ajoutdemande()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(Databaseconnection.getdemande());
        }

        private void ajoutintervenant()
        {
            comboBox3.Items.Clear();
            comboBox3.Items.AddRange(Databaseconnection.getintervenant());
        }

        Intervention_respirateur_class respmo; 
        public void setResp(int id)
        {
            respmo= Databaseconnection.getrespirateur(id);
            textBox1.Text = respmo.Numero_intervention;
            dateTimePicker1.Text = respmo.Date_intervention;
            comboBox3.Text = respmo.Intervenant;
            comboBox1.Text = respmo.Numero_demande;
            comboBox29.Text =  respmo.type_equip;
            comboBox2.Text = respmo.num_ser_interv;
         
            switch (respmo.Etat_intervention)
            {
                case "En cours":
                    radioButton1.Select();
                    break;
                default:
                    radioButton2.Select(); break;
            }

            switch (respmo.test_securite_electrique)
            {
                case "Bon":
                    radioButton5.Select();
                    break;
                default:
                    radioButton6.Select(); break;
            }
        
            switch (respmo.test_vc)
            {
                case "Bon":
                    radioButton8.Select();
                    break;
                case "Mauvais":
                    radioButton7.Select();
                    break;
                default:
                    radioButton9.Select(); break;
            }

            switch (respmo.Etat_equip)
            {
                case "Bonne":
                    radioButton3.Select();
                    break;
                default:
                    radioButton4.Select(); break;
            }
         
            switch (respmo.test_oxygene)
            {
                case "Bon":
                    radioButton18.Select();
                    break;
                case "Mauvais":
                    radioButton17.Select();
                    break;
                default:
                    radioButton16.Select(); break;
            }
          
            switch (respmo.test_pc)
            {
                case "Bon":
                    radioButton12.Select();
                    break;
                case "Mauvais":
                    radioButton11.Select();
                    break;
                default:
                    radioButton10.Select(); break;
            }
      
            switch (respmo.test_vac)
            {
                case "Bon":
                    radioButton15.Select();
                    break;
                case "Mauvais":
                    radioButton14.Select();
                    break;
                default:
                    radioButton13.Select(); break;
            }
            richTextBox1.Text = respmo.Commentaire;


        }
        

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string etatintervention1 = radioButton1.Checked ? radioButton1.Text : radioButton2.Text;
            string etatequipement1 = radioButton3.Checked ? radioButton3.Text : radioButton4.Text;
            string etatsecurite1 = radioButton5.Checked ? radioButton5.Text : radioButton6.Text;


            string etatvc1;
            if (radioButton8.Checked == false)

                etatvc1 = radioButton7.Checked ? radioButton7.Text : radioButton9.Text;

            else
                etatvc1 = radioButton8.Text;

            string etatvac1;
            if (radioButton15.Checked == false)
                etatvac1 = radioButton14.Checked ? radioButton14.Text : radioButton13.Text;
            else
                etatvac1 = radioButton15.Text;

            string etatpress1;
            if (radioButton12.Checked == false)
                etatpress1 = radioButton11.Checked ? radioButton11.Text : radioButton10.Text;
            else
                etatpress1 = radioButton12.Text;


            string etatoxyg1;
            if (radioButton18.Checked == false)
                etatoxyg1 = radioButton17.Checked ? radioButton17.Text : radioButton16.Text;
            else
                etatoxyg1 = radioButton18.Text;


            var result = Databaseconnection.Modifier_interv_respirateur(textBox1.Text, dateTimePicker1.Text, comboBox3.Text, comboBox1.Text, comboBox29.Text, comboBox2.Text, etatintervention1, etatsecurite1, etatvc1, etatequipement1, etatoxyg1, etatpress1, etatvac1, richTextBox1.Text, respmo.ID_intervention_resp);
            if (result)
            {
                MessageBox.Show("Respirateur modifié avec succée");
                this.Close();

            }
            else
                MessageBox.Show("Problem de modification de Respirateur");




        }

        private void Modifier_interv_resp_Load(object sender, EventArgs e)
        {
            
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void GroupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}
