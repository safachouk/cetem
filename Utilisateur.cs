using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CetemLibrary
{
    public class Utilisateur
    {
        string matricule;
        string poste;
        string nom;
        string prenom;
        string email;
        string password;
        public string Matricule { get => matricule; set => matricule = value; }
        public string Poste { get => poste; set => poste = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }

        public Utilisateur(string mat,string nm,string prenm,string post,string mail)
        {
            Matricule = mat;
            Nom = nm;
            Prenom = prenm;
            Poste = post;
            Email = mail;
        }
            //reader.GetString("matricule"),
            //                reader.GetString("nom_technicien"),
            //                reader.GetString("prenom_technicien"),
            //                reader.GetString("poste"),
            //                reader.GetString("email")
    }
}
