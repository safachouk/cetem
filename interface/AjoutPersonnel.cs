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

           
             if (!((textBox1.Text.EndsWith("@gmail.com") ) || (textBox1.Text.EndsWith("@yahoo.fr")) || (textBox1.Text.EndsWith("@hotmail.fr"))))


            {
                MessageBox.Show("Vous devez inserer un mail qui se termine par @gmail.com ou @yahoo.fr ou @hotmail.fr .", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
             
            if (maskedTextBox1.Text == "")
            {
                MessageBox.Show("Vous devez donner un mot de passe .", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }



            var result = Databaseconnection.Ajouter_intervenant(textBox4.Text, textBox5.Text, textBox1.Text, maskedTextBox1.Text);
                
            if (result)
            {
                MessageBox.Show("Personnel ajouté avec succée");
                this.Close();

            }
            else
                MessageBox.Show("Problem d'ajout de personnel");
        }


    }
}
