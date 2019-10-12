using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CetemLibrary.Modeles
{
   public class Demande_class
    {
        public static Demande_class demandecetem; 
        public int Nombre_Respirateur_anesthesie;
        public string Date_Demande;
        public string Etat_demande;
        public string Numéro_demande;
        public string  region_demande;
        public string Hopital_demande;
        public int Nombre_respirateur_réanimation;
        public int nombre_pousse_seringe;
        public int nombre_defibrillateur;
        public int Nombre_respirateur_transport;
        public int Nombre_bistouri ;
        public int ID_DEMANDE; 

        public Demande_class(int nra, string date, string etat, string num, string region_dema , string hopital_de , int nrr , int nps , int nd , int nrt , int nb , int iddem)
        {
            Nombre_Respirateur_anesthesie = nra;
            Date_Demande = date ;
            Etat_demande = etat ;
            Numéro_demande = num ;
            region_demande = region_dema ;
            Hopital_demande = hopital_de ;
            Nombre_respirateur_réanimation = nrr ;
            nombre_pousse_seringe = nps ;
            nombre_defibrillateur = nd ;
            Nombre_respirateur_transport = nrt;
            Nombre_bistouri = nb ;
            ID_DEMANDE = iddem; 


        }








    }


}
