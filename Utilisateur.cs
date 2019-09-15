using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CetemLibrary
{
    public class Utilisateur
    {
        public static Utilisateur utiliSelection;
        
        int id; 
      
        string nom;
        string prenom;
        string email;
        string password;
   
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public int Id { get => id; set => id = value; }

        public Utilisateur(string nm,string prenm,string mail)
        {
            
        
            Nom = nm;
            Prenom = prenm;
            Email = mail;
        }
            //reader.GetString("matricule"),
            //                reader.GetString("nom_technicien"),
            //                reader.GetString("prenom_technicien"),
            //                reader.GetString("poste"),
            //                reader.GetString("email")
    }
}
