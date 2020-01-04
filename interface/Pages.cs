using CetemLibrary;
using CetemLibrary.Modeles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace @interface

    {
    public partial class Pages : Form
    {
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }
        public Pages()
        {
            InitializeComponent();
            //remplirMonCompte();
            //UpdateListsEquipement();
            //UpdateListsPersonnel();
            //UpdateListsdemande();
            //setPersonnelVisibility(Databaseconnection.Utilisateur_courant.type == "Admin");

        }
        
        public void remplirMonCompte()
        {
            if (Databaseconnection.Utilisateur_courant != null)
            {
                textBox3.Text = Databaseconnection.Utilisateur_courant.Nom;
                textBox4.Text = Databaseconnection.Utilisateur_courant.Prenom;
                textBox5.Text = Databaseconnection.Utilisateur_courant.Email;
            }

        }
        public void setPersonnelVisibility(bool visible)
        {
            if (visible)
            {
                if (travail.TabCount < 6)
                    travail.TabPages.Add(tabPage6);
            }
            else
            {
                travail.TabPages.Remove(tabPage6);
            }
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            Ajouter_equipement Aequipement = new Ajouter_equipement();
            Aequipement.Tag = this;
            Aequipement.Show(this);
            Aequipement.FormClosed += Aequipement_FormClosed;
            
         
         
        }

        private void Aequipement_FormClosed(object sender, FormClosedEventArgs e)
        {
            UpdateListsEquipement();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                var selectedrow = dataGridView1.SelectedRows[0];

                Modifier_equipement Mequipement = new Modifier_equipement();
                Mequipement.setEquipement(Int32.Parse(selectedrow.Cells[0].Value.ToString()));

                Mequipement.Tag = this;
                Mequipement.Show(this);
                Mequipement.FormClosed += Aequipement_FormClosed;
            }
            else
            {
                MessageBox.Show("Veuillez selectionnez une ligne entiére.");
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            bool? result = null;
            if (dataGridView1.SelectedRows.Count == 1)
            {
                var selectedrow = dataGridView1.SelectedRows[0];
                result = Databaseconnection.supprimer_equipement((int)selectedrow.Cells[0].Value);
            }
            else
            {
                MessageBox.Show("Veuillez selectionnez une ligne entiére.");
            }
            if (result.HasValue)
                MessageBox.Show(result.Value ? "équipement supprimé." : "erreur de suppression de l'equipement.");
            UpdateListsEquipement();
        }

        private void Button4_Click(object sender, EventArgs e)
        {

            /*AjoutIntervention Aintervent = new AjoutIntervention();
            Aintervent.Tag = this;
            Aintervent.Show(this);*/
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            /*AjoutIntervention Mintervent = new AjoutIntervention();
            Mintervent.Tag = this;
            Mintervent.Show(this);*/
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            /* bool? result = null;
             if (intervention.interventionSelectionner != null)
                 result = Databaseconnection.supprimer_intervention(intervention.interventionSelectionner.Id1);
             if (result.HasValue)
                 MessageBox.Show(result.Value ? "Intervention supprimé." : "erreur de supprission de l'intervention.");
                 */
        }

        private void Apers_FormClosed(object sender, FormClosedEventArgs e)
        {
            UpdateListsPersonnel();
        }
        private void Button9_Click(object sender, EventArgs e)
        {
            AjoutPersonnel Apers = new AjoutPersonnel();
            Apers.Tag = this;
            Apers.Show(this);
            Apers.FormClosed += Apers_FormClosed;
          
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 1)
            {
                var selectedrow5 = dataGridView2.SelectedRows[0];

                Modifier_personnel Mpersonnel = new Modifier_personnel();
                Mpersonnel.setPersonnel((int)selectedrow5.Cells[0].Value);

                Mpersonnel.Tag = this;
                Mpersonnel.Show(this);
                Mpersonnel.FormClosed += Apers_FormClosed;

            }
            else
            {
                MessageBox.Show("Veuillez selectionnez une ligne entiére.");
            }
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            bool? result = null;
            if (dataGridView2.SelectedRows.Count == 1)
            {
                var selectedrow1 = dataGridView2.SelectedRows[0];
                result = Databaseconnection.supprimer_personnel((int)selectedrow1.Cells[0].Value);
            }
            else
            {
                MessageBox.Show("Veuillez selectionnez une ligne entiére.");
            }
            if (result.HasValue)
                MessageBox.Show(result.Value ? "Personnel supprimé." : "erreur de suppression du personnel.");
            UpdateListsPersonnel();
        }

        // private void Button14_Click(object sender, EventArgs e)
        // {
        // if ()
        //{
        //  ModifierIntervention Minterventions = new ModifierIntervention();
        //Minterventions.Tag = this;
        //Minterventions.Show(this);
        //}
        //}

        private void Button17_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
            Databaseconnection.Ajouter_Hopital(comboBox5.Text, textBox7.Text) ?
             "Hopital ajouté avec succée" :
             "Problem d'ajout de l'hopital");
        }





        private void UpdateListsEquipement()
        {
            dataGridView1.DataSource = Databaseconnection.fillEquipement();
            dataGridView1.Columns[0].Visible = false;

            dataGridView1.Refresh();
            dataGridView1.Update();
        }

        private void UpdateListsPersonnel()
        {

            dataGridView2.DataSource = Databaseconnection.fillpersonnel();
            dataGridView2.Refresh();
            dataGridView2.Update();
        }

        private void UpdateListsdemande()
        {
            dataGridView3.DataSource = Databaseconnection.filldemande();
            dataGridView3.Refresh();
            dataGridView3.Update();
        }
    
        private void mdim_FormClosed (object sender, FormClosedEventArgs e)
        {
            UpdateListsdemande();

        }
        private void Button13_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count == 1)
            {
                var selectedrow7 = dataGridView3.SelectedRows[0];

                Modifier_demande mdim = new Modifier_demande();
                mdim.setdemande(Int32.Parse(selectedrow7.Cells[0].Value.ToString()));

                mdim.Tag = this;
                mdim.Show(this);
                mdim.FormClosed += mdim_FormClosed;

            }
            else
            {
                MessageBox.Show("Veuillez selectionnez une ligne entiére.");
            }



        }

        private void Button14_Click(object sender, EventArgs e)
        {
            bool? result = null;
            if (dataGridView3.SelectedRows.Count == 1)
            {
                var selectedrow3 = dataGridView3.SelectedRows[0];
                result = Databaseconnection.supprime_demande(Int32.Parse(selectedrow3.Cells[0].Value.ToString()));
            }
            else
            {
                MessageBox.Show("Veuillez selectionnez une ligne entiére.");
            }
            if (result.HasValue)
            {
                MessageBox.Show(result.Value ? "Demande supprimé." : "erreur de suppression de la demande.");
            }
            UpdateListsdemande();
        }

     

        private void Button12_Click(object sender, EventArgs e)
        {
            if (!((textBox5.Text.EndsWith("@gmail.com")) || (textBox5.Text.EndsWith("@yahoo.fr")) || (textBox5.Text.EndsWith("@hotmail.fr"))))


            {
                MessageBox.Show("Vous devez inserer un mail qui se termine par @gmail.com ou @yahoo.fr ou @hotmail.fr .", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            MessageBox.Show(
            Databaseconnection.Modifier_mon_compte(textBox3.Text, textBox4.Text, textBox5.Text, maskedTextBox2.Text, Databaseconnection.Utilisateur_courant.Id) ?
             "personnelle modifié avec succée" :
             "Problem de modification");
            
            


        }

       

        private void Button4_Click_4(object sender, EventArgs e)
        {
            AjouterIntervention_Respirateur Arespir = new AjouterIntervention_Respirateur();
            Arespir.Tag = this;
            Arespir.Show(this);
        }


        private void Aresp_FormClosed(object sender, EventArgs e)
        {
        }

        private void Button4_Click_5(object sender, EventArgs e)
        {
            AjouterIntervention_Respirateur Aresp = new AjouterIntervention_Respirateur();
            Aresp.Tag = this;
            Aresp.Show(this);
            Aresp.FormClosed += Aresp_FormClosed;
           
        }

        

        private void Button18_Click_3(object sender, EventArgs e)
        {
            Ajouterintervention_bistouri Abist = new Ajouterintervention_bistouri();
            Abist.Tag = this;
            Abist.Show(this);
            Abist.FormClosed += Abist_FormClosed;
      
        }

        private void Abist_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
        private void Button24_Click(object sender, EventArgs e)
        {
            Ajouterintervention_Pousse_seringe Apoussser = new Ajouterintervention_Pousse_seringe();
            Apoussser.Tag = this;
            Apoussser.Show(this);
            Apoussser.FormClosed += Apoussser_FormClosed;
            
        }

        private void Apoussser_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        
        private void Button21_Click_2(object sender, EventArgs e)
        {
            Ajouterintervention_defibrillateur Adefib = new Ajouterintervention_defibrillateur();
            Adefib.Tag = this;
            Adefib.Show(this);
            Adefib.FormClosed += Adefib_FormCloesd;
            
        }

        private void Adefib_FormCloesd(object sender, FormClosedEventArgs e)
        {
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            Application.Restart();
        
        }

    

        private void Button10_Click(object sender, EventArgs e)
        {
            ajout_une_demande Adem = new ajout_une_demande();
            Adem.Tag = this;
            Adem.Show(this);
            Adem.FormClosed += mdim_FormClosed;
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PictureBox25_Click(object sender, EventArgs e)
        {
   }

        private void Panel18_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TabPage7_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            var text = textBox1.Text;
            MyWebRequest rq = new MyWebRequest("https://account.snatchbot.me/channels/api/api/id86672/apparwaid/apsarwa?user_id=123456","POST",text);
            listBox1.Items.Add("moi : " + text);
            listBox1.Items.Add("Bot : " + rq.GetResponse());

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}