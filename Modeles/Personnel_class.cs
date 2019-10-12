using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CetemLibrary.Modeles
{
   public  class Personnel_class
    {
        public static Personnel_class personnctem; 
        public string Nom_technicien;
        public string prenom_technicen;
        public string e_mail;
        public string password;
        public int ID_Tech; 

        public Personnel_class ( string Nom , string prenom , string mail , string password1 , int idtecht)
        {

            Nom_technicien = Nom;
            prenom_technicen = prenom;
            e_mail = mail;
            password = password1;
            ID_Tech = idtecht; 



        }



    }
}
