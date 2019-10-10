using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CetemLibrary.Modeles
{
   public  class Equipement_class
    {
        public string MARQUE;
        public string TYPE;
        public string Modéle;
        public string NUM_SERIE;
        public string nom_de_hopital;
        public string Nom_de_service;
        public string Nom_region;



        public Equipement_class (string marqueq , string typequi , string modeequip , string serieequi , string hopiteq , string serviequi , string regionequi)
        {
            MARQUE = marqueq;
            TYPE = typequi;
            Modéle = modeequip;
            NUM_SERIE = serieequi;
            nom_de_hopital = hopiteq;
            Nom_de_service = serviequi;
            Nom_region = regionequi; 

        }


    }
}
