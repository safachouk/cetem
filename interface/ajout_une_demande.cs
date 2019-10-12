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
    public partial class ajout_une_demande : Form
    {
        public ajout_une_demande()
        {
            InitializeComponent();
        }

        private void Ajout_une_demande_Load(object sender, EventArgs e)
        {

        }

        

        private void Button10_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(
        Databaseconnection.Ajouter_demande(textBox2.Text , textBox3.Text , textBox5.Text , textBox6.Text , textBox4.Text , textBox7.Text , textBox1.Text , comboBox6.Text , textBox8.Text , comboBox9.Text , comboBox8.Text) ?
         "Demande ajouté avec succée" :
         "Problem d'ajout de la demande");
            UpdateLists();
        }

        private void UpdateLists()
        {
            //throw new NotImplementedException();
          //  listView1.Items.Clear();
           // listView1.Items.Add(new ListViewItem());
        }

        private void Label22_Click(object sender, EventArgs e)
        {

        }
    }
}

