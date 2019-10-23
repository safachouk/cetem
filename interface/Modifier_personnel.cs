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
    public partial class Modifier_personnel : Form
{
    public Modifier_personnel()
    {
        InitializeComponent();
    }

        Utilisateur pers; 
        public void setPersonnel(int id )
        {
            pers  = Databaseconnection.getPersonnel(id);
            textBox1.Text = pers.Nom;
            textBox2.Text = pers.Prenom;
            textBox3.Text = pers.Email;
            maskedTextBox1.Text = pers.Password; 
        }

    

        private void Button1_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show(
          Databaseconnection.Modifier_Personnel(textBox1.Text , textBox2.Text, textBox3.Text , maskedTextBox1.Text, pers.Id) ?
           "Personnel Modifier avec succée" :
           "Problem de modification du personnel");
        }

        private void Modifier_personnel_Load(object sender, EventArgs e)
        {

        }
    }
}
