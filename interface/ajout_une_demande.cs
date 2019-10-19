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
    public partial class ajout_une_demande : Form
    {
        public ajout_une_demande()
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

        private void Ajout_une_demande_Load(object sender, EventArgs e)
        {

        }

        

        private void Button10_Click_1(object sender, EventArgs e)
        {

            if (comboBox9.Text =="")
            {
                MessageBox.Show("Vous devez choisir la région.", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(comboBox8.Text=="")
            {

                MessageBox.Show("Vous devez donner le nom de l'hopital.", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textBox8.Text =="")
            {
                MessageBox.Show("Vous devez donner le numéro de la demande.", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textBox1.Text =="")
            {
                MessageBox.Show("la date de la demande est AAAA-MM-JJ.", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            if(comboBox6.Text == "")
            {

                MessageBox.Show("Vous devez donner  l'etat de la demande.", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textBox2.Text =="")
            {

                MessageBox.Show("Vous devez donner le nombre de réspirateur d'anésthesie.", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textBox3.Text=="")
            {
                MessageBox.Show("Vous devez donner le nombre de réspirateur de réanimation.", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textBox4.Text =="")
            {
                MessageBox.Show("Vous devez donner le nombre de réspirateur de transport.", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textBox5.Text =="")
            {
                MessageBox.Show("Vous devez donner le nombre des pousses seringues.", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textBox6.Text=="")
            {
                MessageBox.Show("Vous devez donner le nombre des défibrillateurs .", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            if(textBox7.Text=="")
            {

                MessageBox.Show("Vous devez donner le nombre des bistouris .", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show(
        Databaseconnection.Ajouter_demande(textBox2.Text , textBox3.Text , textBox5.Text , textBox6.Text , textBox4.Text , textBox7.Text , textBox1.Text , comboBox6.Text , textBox8.Text , comboBox9.Text , comboBox8.Text) ?
         "Demande ajouté avec succée" :
         "Problem d'ajout de la demande");
            UpdateLists();
        }

        private void UpdateLists()
        {
            //throw new NotImplementedException();
          //  listView1.Items.Clear();
           // listView1.Items.Add(new ListViewItem());
        }

        private void Label22_Click(object sender, EventArgs e)
        {

        }
    }
}

