using CetemLibrary;
using Ext.Net;
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
            adataaaa();


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

        private void adataaaa()
        {
            DataGridViewComboBoxColumn combo = new DataGridViewComboBoxColumn();
            combo.HeaderText = "Type Equipement";
            List<string> param = new List<string>();
            param.AddRange(new string[] { " Respirateur anesthésie", "Respirateur de réanimation", "Respirateur de tarnsport", "défibrillateur", "Bistouri", "Pousse seringue" });
            combo.Items.AddRange(param.ToArray());
            dataGridView1.Columns.Add(combo);


            DataGridViewComboBoxColumn combo1 = new DataGridViewComboBoxColumn();
             combo1.HeaderText = "Marque";
             combo1.Items.AddRange(Databaseconnection.GetMarque());
            dataGridView1.Columns.Add(combo1);
            DataGridViewComboBoxColumn combo2 = new DataGridViewComboBoxColumn();
            combo2.HeaderText = "Modele";
            combo2.Items.AddRange(Databaseconnection.GetModele());
            dataGridView1.Columns.Add(combo2);
            DataGridViewComboBoxColumn combo3 = new DataGridViewComboBoxColumn();
            combo3.HeaderText = "Modele";
            combo3.Items.AddRange(Databaseconnection.Getnumserie());
            dataGridView1.Columns.Add(combo3);



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

        private void UpdateHospital(object sender, EventArgs e)
        {
            if (sender is System.Windows.Forms.ComboBox c)
            {
                var name = c.Text;
                if (string.IsNullOrEmpty(name.Trim()))
                    name = "%";
                comboBox8.Items.Clear();
                comboBox8.Items.AddRange(Databaseconnection.gethopital(name));
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var result = Databaseconnection.Ajouter_listequip(dataGridView1.Columns[0].ToString(), dataGridView1.Columns[1].ToString(), dataGridView1.Columns[2].ToString(), dataGridView1.Columns[3].ToString());
       
        }
        
        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button10_Click(object sender, EventArgs e)
        {
            if (comboBox9.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Vous devez choisir la région.", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (comboBox8.Text == "")
            {

                System.Windows.Forms.MessageBox.Show("Vous devez donner le nom de l'hopital.", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textBox8.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Vous devez donner le numéro de la demande.", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            if (comboBox6.Text == "")
            {

                System.Windows.Forms.MessageBox.Show("Vous devez donner  l'etat de la demande.", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textBox2.Text == "")
            {

                System.Windows.Forms.MessageBox.Show("Vous devez donner le nombre de réspirateur d'anésthesie.", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textBox3.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Vous devez donner le nombre de réspirateur de réanimation.", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textBox4.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Vous devez donner le nombre de réspirateur de transport.", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textBox5.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Vous devez donner le nombre des pousses seringues.", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textBox6.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Vous devez donner le nombre des défibrillateurs .", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            if (textBox7.Text == "")
            {

                System.Windows.Forms.MessageBox.Show("Vous devez donner le nombre des bistouris .", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var result = Databaseconnection.Ajouter_demande(textBox2.Text, textBox3.Text, textBox5.Text, textBox6.Text, textBox4.Text, textBox7.Text, dateTimePicker1.Text, comboBox6.Text, textBox8.Text, comboBox9.Text, comboBox8.Text);
            if (result)
            {
                System.Windows.Forms.MessageBox.Show("Demande ajouté avec succée");
                this.Close();
            }
            else
                System.Windows.Forms.MessageBox.Show("Problem d'ajout de la demande");
        }
    }
}

