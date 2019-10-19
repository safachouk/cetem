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
    public partial class Pages : Form
{
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }
        public Pages()
    {
            InitializeComponent();
            remplirMonCompte();
            UpdateListsEquipement();
            UpdateListsPersonnel();
            UpdateListsdemande();
            UpdateListsinterventionresp();
            UpdateListsinterventionbist();
            UpdateListsinterventionpouss();
            UpdateListsinterventiondefib();
           
          

        }

       

      
      

      

        public void remplirMonCompte()
        {
            if (Databaseconnection.Utilisateur_courant != null)
            {
                textBox4.Text = Databaseconnection.Utilisateur_courant.Nom;
                textBox5.Text = Databaseconnection.Utilisateur_courant.Prenom;
                textBox3.Text = Databaseconnection.Utilisateur_courant.Email;
            }

        }
        private void Button3_Click(object sender, EventArgs e)
        {
            Ajouter_equipement  Aequipement = new Ajouter_equipement();
            Aequipement.Tag = this;
            Aequipement.Show(this);
            //Aequipement.FormClosing;
            UpdateListsEquipement();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                var selectedrow = dataGridView1.SelectedRows[0];

                Modifier_equipement Mequipement = new Modifier_equipement();
                Mequipement.setEquipement((int)selectedrow.Cells[0].Value);
                
                Mequipement.Tag = this;
                Mequipement.Show(this);

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

        private void Button9_Click(object sender, EventArgs e)
        {
            AjoutPersonnel Apers = new AjoutPersonnel();
            Apers.Tag = this;
            Apers.Show(this);
            UpdateListsPersonnel();
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
            Databaseconnection.Ajouter_Hopital(comboBox5.Text , textBox7.Text) ?
             "Hopital ajouté avec succée" :
             "Problem d'ajout de l'hopital");
        }

        private void VScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void VScrollBar1_Scroll_1(object sender, ScrollEventArgs e)
        {

        }

        private void ComboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void DomainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void TabPage2_Click(object sender, EventArgs e)
        {

        }

        private void TabPage2_Click_1(object sender, EventArgs e)
        {

        }

        private void Pages_Load(object sender, EventArgs e)
        {

        }

        private void Button4_Click_1(object sender, EventArgs e)
        {
            AjouterIntervention_Respirateur Aresp = new AjouterIntervention_Respirateur();
            Aresp.Tag = this;
            Aresp.Show(this);
            UpdateListsinterventionresp();

        }

        private void Button6_Click_1(object sender, EventArgs e)
        {

        }

        private void Button7_Click_1(object sender, EventArgs e)
        {

        }

        private void Button18_Click(object sender, EventArgs e)
        {

        }

        public  void ComboBox29_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TabPage7_Click(object sender, EventArgs e)
        {

        }

        private void Label22_Click(object sender, EventArgs e)
        {

        }

       

        private void UpdateListsEquipement()
        {
            
            dataGridView1.DataSource = Databaseconnection.fillEquipement();

        }

        private void UpdateListsPersonnel()
        {

            dataGridView2.DataSource = Databaseconnection.fillpersonnel();
        }

        private void UpdateListsdemande()
        {
            dataGridView3.DataSource = Databaseconnection.filldemande();
        }
      private void UpdateListsinterventionresp()
        {

            dataGridView4.DataSource = Databaseconnection.fillinterventionresp();
        }

      public void  UpdateListsinterventionbist()
        {
            dataGridView5.DataSource = Databaseconnection.fillinterventbistouri();

        }

        public void UpdateListsinterventionpouss()
        {
            dataGridView7.DataSource = Databaseconnection.fillinterventpousseseringue();

        }
        public void UpdateListsinterventiondefib()
        {

            dataGridView6.DataSource = Databaseconnection.fillinterventdefibrillateur();
        }

        private void Button10_Click_1(object sender, EventArgs e)
        {
            ajout_une_demande Adem = new ajout_une_demande();
            Adem.Tag = this;
            Adem.Show(this);
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
                result = Databaseconnection.supprime_demande((int)selectedrow3.Cells[0].Value);
            }
            else
            {
                MessageBox.Show("Veuillez selectionnez une ligne entiére.");
            }
            if (result.HasValue)
            {
                MessageBox.Show(result.Value ? "Demande supprimé." : "erreur de suppression de la demande.");
            }

        }

        private void TabPage5_Click(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
          Databaseconnection.Modifier_mon_compte(textBox4.Text , textBox5.Text , textBox3.Text , maskedTextBox1.Text,Databaseconnection.Utilisateur_courant.Id) ?
           "personnelle modifié avec succée" :
           "Problem de modification");

        }

        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button4_Click_2(object sender, EventArgs e)
        {
            AjouterIntervention_Respirateur Arespir = new AjouterIntervention_Respirateur();
            Arespir.Tag = this;
            Arespir.Show(this);
            UpdateListsinterventionresp();
        }

        private void Button7_Click_2(object sender, EventArgs e)
        {
            bool? result = null;
            if (dataGridView4.SelectedRows.Count == 1)
            {
                var selectedrow7 = dataGridView4.SelectedRows[0];
                result = Databaseconnection.supprimer_interv_respirateur((int)selectedrow7.Cells[0].Value);
            }
            else
            {
                MessageBox.Show("Veuillez selectionnez une ligne entiére.");
            }
            if (result.HasValue)
                MessageBox.Show(result.Value ? "Respirateur supprimé." : "erreur de suppression de respirateur.");
        }

        private void Button6_Click_2(object sender, EventArgs e)
        {
            if (dataGridView4.SelectedRows.Count == 1)
            {
                var selectedrow = dataGridView4.SelectedRows[0];

                Modifier_interv_resp Mresp = new Modifier_interv_resp();
                Mresp.setResp((int)selectedrow.Cells[0].Value);

                Mresp.Tag = this;
                Mresp.Show(this);

            }
            else
            {
                MessageBox.Show("Veuillez selectionnez une ligne entiére.");
            }
        }

        private void Button20_Click(object sender, EventArgs e)
        {
            Ajouterintervention_bistouri Abist = new Ajouterintervention_bistouri();
            Abist.Tag = this;
            Abist.Show(this);
            UpdateListsinterventionbist();
        }

        private void Button25_Click(object sender, EventArgs e)
        {
            bool? result = null;
            if (dataGridView5.SelectedRows.Count == 1)
            {
                var selectedrow9 = dataGridView5.SelectedRows[0];
                result = Databaseconnection.supprimer_interv_bistouri((int)selectedrow9.Cells[0].Value);
            }
            else
            {
                MessageBox.Show("Veuillez selectionnez une ligne entiére.");
            }
            if (result.HasValue)
                MessageBox.Show(result.Value ? "Bistouri supprimé." : "erreur de suppression de bistouri.");
        }

     

        private void Button22_Click(object sender, EventArgs e)
        {
            if (dataGridView5.SelectedRows.Count == 1)
            {
                var selectedrow = dataGridView5.SelectedRows[0];

                Modifier_inter_Bist Mbistr = new Modifier_inter_Bist();
                Mbistr.setbistouri((int)selectedrow.Cells[0].Value);

                Mbistr.Tag = this;
                Mbistr.Show(this);

            }
            else
            {
                MessageBox.Show("Veuillez selectionnez une ligne entiére.");
            }
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            Ajouterintervention_Pousse_seringe Apoussser = new Ajouterintervention_Pousse_seringe();
            Apoussser.Tag = this;
            Apoussser.Show(this);
            UpdateListsinterventionpouss();
        }

        private void Button26_Click(object sender, EventArgs e)
        {
            bool? result = null;
            if (dataGridView7.SelectedRows.Count == 1)
            {
                var selectedrow9 = dataGridView7.SelectedRows[0];
                result = Databaseconnection.supprimer_interv_pousse_seringue((int)selectedrow9.Cells[0].Value);
            }
            else
            {
                MessageBox.Show("Veuillez selectionnez une ligne entiére.");
            }
            if (result.HasValue)
                MessageBox.Show(result.Value ? "Pousse seringue supprimé." : "erreur de suppression du pousse seringue.");
        }

        private void Button23_Click(object sender, EventArgs e)
        {

            if (dataGridView7.SelectedRows.Count == 1)
            {
                var selectedrow = dataGridView7.SelectedRows[0];

                Modifier_pousse_seringue mpoussseri = new Modifier_pousse_seringue ();
                mpoussseri.setpousseseringue((int)selectedrow.Cells[0].Value);

                mpoussseri.Tag = this;
                mpoussseri.Show(this);

            }
            else
            {
                MessageBox.Show("Veuillez selectionnez une ligne entiére.");
            }
        }

        private void Button18_Click_1(object sender, EventArgs e)
        {
            Ajouterintervention_defibrillateur Adefib = new Ajouterintervention_defibrillateur();
            Adefib.Tag = this;
            Adefib.Show(this);
            UpdateListsinterventiondefib();
        }

        private void Button27_Click(object sender, EventArgs e)
        {
            bool? result = null;
            if (dataGridView6.SelectedRows.Count == 1)
            {
                var selectedrow10 = dataGridView6.SelectedRows[0];
                result = Databaseconnection.supprimer_interv_defibrillateur((int)selectedrow10.Cells[0].Value);
            }
            else
            {
                MessageBox.Show("Veuillez selectionnez une ligne entiére.");
            }
            if (result.HasValue)
                MessageBox.Show(result.Value ? "défibrillateur supprimé." : "erreur de suppression du défibrillateur.");

        }

        private void Button21_Click(object sender, EventArgs e)
        {
            if (dataGridView6.SelectedRows.Count == 1)
            {
                var selectedrow = dataGridView6.SelectedRows[0];

                Modifier_interv_defibr mdefib = new Modifier_interv_defibr();
                mdefib.setdefibrillateur((int)selectedrow.Cells[0].Value);

                mdefib.Tag = this;
                mdefib.Show(this);

            }
            else
            {
                MessageBox.Show("Veuillez selectionnez une ligne entiére.");
            }
        }

        private void filtreAgain(object sender, EventArgs e)
        {

        }

      
    }
}