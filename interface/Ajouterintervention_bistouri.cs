﻿using CetemLibrary;
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
    public partial class Ajouterintervention_bistouri : Form
{
    public Ajouterintervention_bistouri()
    {
            InitializeComponent();
            AjoutPersonnel();
            ajoudemande();
            ajoutserie();
        }

        private void ajoutserie()
        {
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(Databaseconnection.getserie());
        }

        private void ajoudemande()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(Databaseconnection.getdemande());
        }

        private void AjoutPersonnel()
        {
            comboBox3.Items.Clear();
            comboBox3.Items.AddRange(Databaseconnection.getintervenant());
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Text=="")
            {
                MessageBox.Show("Vous devez donner le numéro d'intervention.", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (!radioButton1.Checked && !radioButton2.Checked)
            {
                MessageBox.Show("Vous devez spécifier l'etat d'intervention.", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!radioButton3.Checked && !radioButton4.Checked)
            {
                MessageBox.Show("Vous devez spécifier l'etat de l'équipement.", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (!radioButton5.Checked && !radioButton6.Checked)
            {
                MessageBox.Show("Vous devez spécifier l'etat de test séurite électrique.", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            if (!radioButton7.Checked && !radioButton8.Checked)
            {
                MessageBox.Show("Vous devez spécifier l'etat de test des modes.", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (!radioButton9.Checked && !radioButton10.Checked)
            {
                MessageBox.Show("Vous devez spécifier l'etat test fuite partie active.", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (!radioButton13.Checked && !radioButton14.Checked)
            {
                MessageBox.Show("Vous devez spécifier l'etat test fuite partie neutre.", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string etatintervention3 = radioButton1.Checked ? radioButton1.Text : radioButton2.Text;
            string etatequipement3 = radioButton3.Checked ? radioButton3.Text : radioButton4.Text;
            string securitelectrique4 = radioButton5.Checked ? radioButton5.Text : radioButton6.Text;
            string testmodes = radioButton7.Checked ? radioButton7.Text : radioButton8.Text;
            string testfuitepartieactive = radioButton9.Checked ? radioButton9.Text : radioButton10.Text;
            string testfuitepartieneutre = radioButton13.Checked ? radioButton13.Text : radioButton14.Text;


            var result = Databaseconnection.ajout_boustri(dateTimePicker1.Text, textBox1.Text, etatintervention3, comboBox3.Text, textBox3.Text, securitelectrique4, testmodes, richTextBox1.Text, comboBox1.Text, testfuitepartieactive, testfuitepartieneutre, etatequipement3, comboBox2.Text); 
           
            if(result)
            {
                MessageBox.Show("Bistouri ajouté avec succée");
                this.Close();
            }
            else
                MessageBox.Show("Problem d'ajout de Bistouri");

         
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Ajouterintervention_bistouri_Load(object sender, EventArgs e)
        {

        }
    }
}
