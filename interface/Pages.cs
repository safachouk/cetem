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

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Ajouter_equipement Mequipement = new Ajouter_equipement();
            Mequipement.Tag = this;
            Mequipement.Show(this);

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            bool? result = null;
            if (Dispositifsbiomedicale.DispositifSelectionne != null)
                result = Databaseconnection.supprimer_equipement(Dispositifsbiomedicale.DispositifSelectionne.Id);
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
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            /*AjoutPersonnel Mpers = new AjoutPersonnel();
            Mpers.Tag = this;
            Mpers.Show(this);*/
        }

        private void Button11_Click(object sender, EventArgs e)
        {
           bool? result = null;
            if (Utilisateur.utiliSelection != null)
                result = Databaseconnection.supprimer_personnel(Utilisateur.utiliSelection.Id);
            if (result.HasValue)
                MessageBox.Show(result.Value ? "Personnel supprimé." : "erreur de suppression de personnel.");
                
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
            if (comboBox29.Text  == "Respirateur d'anesthésie" || comboBox29.Text == "Respirateur de réanimation" || comboBox29.Text == "Respirateur de transport")
            { 

                AjouterIntervention_Respirateur ajresp = new AjouterIntervention_Respirateur();
                ajresp.Tag = this;
                ajresp.Show(this);

            }

             else if (comboBox29.Text.Equals("Bistouri"))
            {

                Ajouterintervention_bistouri ajbist = new Ajouterintervention_bistouri();
                ajbist.Tag = this;
                ajbist.Show(this);
            }
            else if (comboBox29.Text == "Pousse seringe")
            {

                Ajouterintervention_Pousse_seringe ajpouss = new Ajouterintervention_Pousse_seringe();
                ajpouss.Tag = this;
                ajpouss.Show(this);

            }
            else if  (comboBox29.Text == "Défibrillateur")
            {

                Ajouterintervention_defibrillateur ajdef = new Ajouterintervention_defibrillateur();
                ajdef.Tag = this;
                ajdef.Show(this);

            }
            else if (comboBox29.Text.Equals("Bistouri"))
            {

                Ajouterintervention_bistouri ajbist = new Ajouterintervention_bistouri();
                ajbist.Tag = this;
                ajbist.Show(this);
            }
            
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

       

        private void UpdateLists()
        {
            //throw new NotImplementedException();
            listView1.Items.Clear();
            listView1.Items.Add(new ListViewItem());
        }

        private void Button10_Click_1(object sender, EventArgs e)
        {
            ajout_une_demande Adem = new ajout_une_demande();
            Adem.Tag = this;
            Adem.Show(this);

        }

        private void Button13_Click(object sender, EventArgs e)
        {
            ajout_une_demande Mdem = new ajout_une_demande();
            Mdem.Tag = this;
            Mdem.Show(this);
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            bool? result = null;
            if (Demande_class.demandecetem != null)
                result = Databaseconnection.supprimer_demande(Demande_class.demandecetem.ID_DEMANDE);
            if (result.HasValue)
                MessageBox.Show(result.Value ? "Demande supprimé avec succes ." : "erreur de suppression de la demande.");
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
    }
}