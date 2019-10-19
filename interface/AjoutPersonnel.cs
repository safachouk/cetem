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
    public partial class AjoutPersonnel : Form
    {
        public AjoutPersonnel()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            if (textBox4.Text == "")
            {
                MessageBox.Show("Vous devez donner le nom du personnel.", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textBox5.Text == "")
            {
                MessageBox.Show("Vous devez donner le prenom du personnel.", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textBox1.Text == "")
            {
                MessageBox.Show("Vous devez donner un email correct.", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
             
            if (textBox2.Text == "")
            {
                MessageBox.Show("Vous devez donner un mot de passe .", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }


            MessageBox.Show(
                Databaseconnection.Ajouter_intervenant(textBox4.Text, textBox5.Text, textBox1.Text, textBox2.Text) ?
                "Personnel ajouté avec succée" :
                "Problem d'ajout de personnel");
        }


    }
}
