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
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Type Equipement";
            dataGridView1.Columns[1].Name = "Marque";
            dataGridView1.Columns[2].Name = "Modele";
            dataGridView1.Columns[3].Name = "Numero serie";



        }
       

      

        private void UpdateLists()
        {

            comboBox2.Items.AddRange(Databaseconnection.GetMarque());
            comboBox3.Items.AddRange(Databaseconnection.GetModele());
            comboBox4.Items.AddRange(Databaseconnection.Getnumserie());

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
            //if (comboBox9.Text == "")
            //{
            //    System.Windows.Forms.MessageBox.Show("Vous devez choisir la région.", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //if (comboBox8.Text == "")
            //{

            //    System.Windows.Forms.MessageBox.Show("Vous devez donner le nom de l'hopital.", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //if (textBox8.Text == "")
            //{
            //    System.Windows.Forms.MessageBox.Show("Vous devez donner le numéro de la demande.", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}



            //if (comboBox6.Text == "")
            //{

            //    System.Windows.Forms.MessageBox.Show("Vous devez donner  l'etat de la demande.", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //if (textBox2.Text == "")
            //{

            //    System.Windows.Forms.MessageBox.Show("Vous devez donner le nombre de réspirateur d'anésthesie.", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            int nbr_respAnest;
            var rowlist = dataGridView1.Rows.Cast<DataGridViewRow>().Select(r => r.Cells).ToList();
            var test = rowlist.Where(c => c[0].FormattedValue.ToString().Trim() == "Respirateur Anesthésie").Count();
            if (int.TryParse(textBox2.Text, out nbr_respAnest) && (nbr_respAnest != test))
            {

                System.Windows.Forms.MessageBox.Show("Vous devez verifié le nombre de réspirateur d'anésthesie ajouter dans la liste.", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int nbr_resprea;
            var rowlist1 = dataGridView1.Rows.Cast<DataGridViewRow>().Select(r => r.Cells).ToList();
            var test1 = rowlist1.Where(c => c[0].FormattedValue.ToString().Trim() == "Respirateur Réanimation").Count();
            if (int.TryParse(textBox3.Text, out nbr_resprea) && (nbr_resprea != test1))
            {

                System.Windows.Forms.MessageBox.Show("Vous devez verifié le nombre de réspirateur de réanimation  ajouter dans la liste.", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int nbr_resprespt;
            var rowlist3 = dataGridView1.Rows.Cast<DataGridViewRow>().Select(r => r.Cells).ToList();
            var test3 = rowlist3.Where(c => c[0].FormattedValue.ToString().Trim() == "Respirateur Transport").Count();
            if (int.TryParse(textBox1.Text, out nbr_resprespt) && (nbr_resprespt != test3))
            {

                System.Windows.Forms.MessageBox.Show("Vous devez verifié le nombre de réspirateur de transport ajouter dans la liste.", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int nbr_Pouss;
            var rowlist4 = dataGridView1.Rows.Cast<DataGridViewRow>().Select(r => r.Cells).ToList();
            var test4 = rowlist4.Where(c => c[0].FormattedValue.ToString().Trim() == "Pousse Seringue").Count();
            if (int.TryParse(textBox4.Text, out nbr_Pouss) && (nbr_Pouss != test4))
            {

                System.Windows.Forms.MessageBox.Show("Vous devez verifié le nombre de Pousse seringue ajouter dans la liste.", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            int nbr_defib;
            var rowlist5 = dataGridView1.Rows.Cast<DataGridViewRow>().Select(r => r.Cells).ToList();
            var test5 = rowlist5.Where(c => c[0].FormattedValue.ToString().Trim() == "Défibrillateur").Count();
            if (int.TryParse(textBox5.Text, out nbr_defib) && (nbr_defib != test5))
            {

                System.Windows.Forms.MessageBox.Show("Vous devez verifié le nombre de défibrillateur ajouter dans la liste.", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            int nbr_Bistouri;
            var rowlist6 = dataGridView1.Rows.Cast<DataGridViewRow>().Select(r => r.Cells).ToList();
            var test6 = rowlist6.Where(c => c[0].FormattedValue.ToString().Trim() == "Bistouri").Count();
            if (int.TryParse(textBox6.Text, out nbr_Bistouri) && (nbr_Bistouri != test6))
            {

                System.Windows.Forms.MessageBox.Show("Vous devez verifié le nombre de Bistouri ajouter dans la liste.", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textBox3.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Vous devez donner le nombre de réspirateur de réanimation.", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textBox1.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Vous devez donner le nombre de réspirateur de transport.", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textBox4.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Vous devez donner le nombre des pousses seringues.", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textBox5.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Vous devez donner le nombre des défibrillateurs .", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            if (textBox6.Text == "")
            {

                System.Windows.Forms.MessageBox.Show("Vous devez donner le nombre des bistouris .", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            var result = Databaseconnection.Ajouter_demande(textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox1.Text, textBox6.Text, dateTimePicker1.Text, textBox7.Text, textBox8.Text, comboBox9.Text, comboBox8.Text,rowlist.Select(r=> r[3].FormattedValue.ToString()).ToList());

            if (result)
            {
                System.Windows.Forms.MessageBox.Show("Demande ajouté avec succée");
                this.Close();
            }
            else
                System.Windows.Forms.MessageBox.Show("Problem d'ajout de la demande");
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox4.SelectedItem.ToString().Trim()))
                return;
            var eq = Databaseconnection.getEquipementBySerial(comboBox4.SelectedItem.ToString());
            string[] row = new string[4];
            row[0] = eq.Type1;
            row[1] = eq.Marque1;
            row[2] = eq.modele1;
            row[3] = eq.Numero_serie1;

            dataGridView1.Rows.Add(row);
            dataGridView1.Refresh();
            dataGridView1.Update();

        }

        private void UpdateMarque(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(Databaseconnection.GetMarqueByType(comboBox1.SelectedItem.ToString()));
        }

        private void GetModelByMarque(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();
            comboBox3.Items.AddRange(Databaseconnection.GetModeleByMarque(comboBox2.SelectedItem.ToString()));
        }

        private void GetSNbyMarque(object sender, EventArgs e)
        {
            comboBox4.Items.Clear();
            comboBox4.Items.AddRange(Databaseconnection.GetnumserieByModel(comboBox3.SelectedItem.ToString()));
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

