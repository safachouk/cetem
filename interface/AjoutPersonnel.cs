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
            MessageBox.Show(
                Databaseconnection.Ajouter_intervenant(textBox4.Text, textBox5.Text, textBox1.Text, textBox2.Text) ?
                "Personnel ajouté avec succée" :
                "Problem d'ajout de personnel");
        }


    }
}
