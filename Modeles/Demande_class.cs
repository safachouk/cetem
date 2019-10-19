using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CetemLibrary.Modeles
{
   public class Demande_class
    {
    
        public string Nombre_Respirateur_anesthesie;
        public string Date_Demande;
        public string Etat_demande;
        public string Numero_demande;
        public string  region_demande;
        public string Hopital_demande;
        public string Nombre_respirateur_reanimation;
        public string nombre_pousse_seringe;
        public string nombre_defibrillateur;
        public string Nombre_respirateur_transport;
        public string Nombre_bistouri ;
        public int ID_DEMANDE;
        public Demande_class()
        {

        }

        public Demande_class(string nra, string date, string etat, string num, string region_dema , string hopital_de , string nrr , string nps , string nd , string nrt , string nb , int iddem)
        {
            Nombre_Respirateur_anesthesie = nra;
            Date_Demande = date ;
            Etat_demande = etat ;
            Numero_demande = num ;
            region_demande = region_dema ;
            Hopital_demande = hopital_de ;
            Nombre_respirateur_reanimation = nrr ;
            nombre_pousse_seringe = nps ;
            nombre_defibrillateur = nd ;
            Nombre_respirateur_transport = nrt;
            Nombre_bistouri = nb ;
            ID_DEMANDE = iddem; 


        }








    }


}
