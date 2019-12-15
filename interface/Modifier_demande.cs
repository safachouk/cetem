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
    public partial class Modifier_demande : Form
    {
        public Modifier_demande()
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

        Demande_class demm;
        public void setdemande(int id)
        {
            demm = Databaseconnection.getdemande(id);
            textBox8.Text = demm.Nombre_Respirateur_anesthesie;
            textBox1.Text = demm.Date_Demande;
            textBox2.Text = demm.Etat_demande;
            textBox1.Text = demm.Numero_demande;
            comboBox9.Text = demm.region_demande;
            comboBox8.Text = demm.Hopital_demande;
            textBox9.Text = demm.Nombre_respirateur_reanimation;
            textBox11.Text = demm.nombre_pousse_seringe;
            textBox12.Text = demm.nombre_defibrillateur;
            textBox10.Text = demm.Nombre_respirateur_transport;
            textBox13.Text = demm.Nombre_bistouri;
            getdemandes();

        }
        void getdemandes()
        {
            var eqs = Databaseconnection.getDemandeEquipements(demm.ID_DEMANDE.ToString());

            eqs.ForEach(e => dataGridView1.Rows.Add(e));
            dataGridView1.Refresh();
            dataGridView1.Update();
        }
        private void Button10_Click(object sender, EventArgs e)
        {
            int nbr_respAnest;
            var rowlist = dataGridView1.Rows.Cast<DataGridViewRow>().Select(r => r.Cells).ToList();
            var test = rowlist.Where(c => c[0].FormattedValue.ToString().Trim() == "Respirateur Anesthésie").Count();
            if (int.TryParse(textBox8.Text, out nbr_respAnest) && (nbr_respAnest != test))
            {

                System.Windows.Forms.MessageBox.Show("Vous devez verifié le nombre de réspirateur d'anésthesie ajouter dans la liste.", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int nbr_resprea;
            var rowlist1 = dataGridView1.Rows.Cast<DataGridViewRow>().Select(r => r.Cells).ToList();
            var test1 = rowlist1.Where(c => c[0].FormattedValue.ToString().Trim() == "Respirateur Réanimation").Count();
            if (int.TryParse(textBox9.Text, out nbr_resprea) && (nbr_resprea != test1))
            {

                System.Windows.Forms.MessageBox.Show("Vous devez verifié le nombre de réspirateur de réanimation  ajouter dans la liste.", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int nbr_resprespt;
            var rowlist3 = dataGridView1.Rows.Cast<DataGridViewRow>().Select(r => r.Cells).ToList();
            var test3 = rowlist3.Where(c => c[0].FormattedValue.ToString().Trim() == "Respirateur Transport").Count();
            if (int.TryParse(textBox10.Text, out nbr_resprespt) && (nbr_resprespt != test3))
            {

                System.Windows.Forms.MessageBox.Show("Vous devez verifié le nombre de réspirateur de transport ajouter dans la liste.", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int nbr_Pouss;
            var rowlist4 = dataGridView1.Rows.Cast<DataGridViewRow>().Select(r => r.Cells).ToList();
            var test4 = rowlist4.Where(c => c[0].FormattedValue.ToString().Trim() == "Pousse Seringue").Count();
            if (int.TryParse(textBox11.Text, out nbr_Pouss) && (nbr_Pouss != test4))
            {

                System.Windows.Forms.MessageBox.Show("Vous devez verifié le nombre de Pousse seringue ajouter dans la liste.", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            int nbr_defib;
            var rowlist5 = dataGridView1.Rows.Cast<DataGridViewRow>().Select(r => r.Cells).ToList();
            var test5 = rowlist5.Where(c => c[0].FormattedValue.ToString().Trim() == "Défibrillateur").Count();
            if (int.TryParse(textBox12.Text, out nbr_defib) && (nbr_defib != test5))
            {

                System.Windows.Forms.MessageBox.Show("Vous devez verifié le nombre de défibrillateur ajouter dans la liste.", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            int nbr_Bistouri;
            var rowlist6 = dataGridView1.Rows.Cast<DataGridViewRow>().Select(r => r.Cells).ToList();
            var test6 = rowlist6.Where(c => c[0].FormattedValue.ToString().Trim() == "Bistouri").Count();
            if (int.TryParse(textBox13.Text, out nbr_Bistouri) && (nbr_Bistouri != test6))
            {

                System.Windows.Forms.MessageBox.Show("Vous devez verifié le nombre de Bistouri ajouter dans la liste.", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            var result = Databaseconnection.Modifier_Demande(textBox8.Text, dateTimePicker1.Text, textBox2.Text, textBox1.Text, comboBox9.Text, comboBox8.Text, textBox9.Text, textBox11.Text, textBox12.Text, textBox10.Text, textBox13.Text, rowlist.Select(r => r[3].FormattedValue.ToString()).ToList() , demm.ID_DEMANDE);
         
         
            if (result)
            {
                MessageBox.Show("demande Modifier avec succée" );
                this.Close();

            }
            else
                MessageBox.Show("Problem de modification de la demande ");
        }

       

        private void UpdateDemande(object sender, EventArgs e)
        {
             if (sender is ComboBox c)
            {
                var name = c.Text;
                if (string.IsNullOrEmpty(name.Trim()))
                    name = "%";
                comboBox8.Items.Clear();
                comboBox8.Items.AddRange(Databaseconnection.gethopital(name));
            }
        }

        private void UpdateMarque(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(Databaseconnection.GetMarqueByType(comboBox1.SelectedItem.ToString()));

        }

        private void getserialbymodel(object sender, EventArgs e)
        {
            comboBox4.Items.Clear();
            comboBox4.Items.AddRange(Databaseconnection.GetnumserieByModel(comboBox3.SelectedItem.ToString()));
        }

        private void getmodelbymarque(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();
            comboBox3.Items.AddRange(Databaseconnection.GetModeleByMarque(comboBox2.SelectedItem.ToString()));
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox4.SelectedItem == null ? "" : comboBox4.SelectedItem.ToString().Trim()))
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
    }
}
