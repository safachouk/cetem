using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CetemLibrary
{
    public class Utilisateur
    {



        public int  id;
        public string nom;
        public string prenom;
        public string email;
        public string password;
        public string type;
       

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public int Id { get => id; set => id = value; }

       

        public Utilisateur(string nm,string prenm,string mail,string pass,string type12, int id)
        {
           
            Nom = nm;
            Prenom = prenm;
            Email = mail;
            Password = pass;
            type = type12; 
            Id = id;
          
        }
         public Utilisateur()
        {

           

        }



    }
}
