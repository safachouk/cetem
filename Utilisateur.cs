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


        public int Id; 
        string nom;
        string prenom;
        string email;
        string password;
   
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
      

        public Utilisateur(string nm,string prenm,string mail, int id)
        {
            
        
            Nom = nm;
            Prenom = prenm;
            Email = mail;
            Id = id;
          
        }
    }
}
