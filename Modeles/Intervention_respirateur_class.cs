using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CetemLibrary.Modeles
{
   public  class Intervention_respirateur_class
    {
        public string Numero_intervention;
        public string Date_intervention;
        public string Intervenant;
        public string Numero_demande;
        public string type_equip;
        public string num_ser_interv;
        public string Etat_intervention;
        public string test_securite_electrique;
        public string test_vc;
        public string Etat_equip;
        public string test_oxygene;
        public string test_pc;
        public string test_vac;
        public string Commentaire;
        public int ID_intervention_resp;
        public Intervention_respirateur_class (string nure , string datere , string intre , string numre , string tyres , string seriere , string etatre , string tsere , string vcre , string etatres , string oxyres , string pcre , string vacre , string comre , int idresp)
        {
            Numero_intervention = nure;
            Date_intervention = datere;
            Intervenant = intre;
            Numero_demande = numre;
            type_equip = tyres;
            num_ser_interv = seriere;
            Etat_intervention = etatre;
            test_securite_electrique = tsere;
            test_vc = vcre;
            Etat_equip = etatres;
            test_oxygene = oxyres;
            test_pc = pcre;
            test_vac = vacre;
            Commentaire = comre;
            ID_intervention_resp = idresp; 

        }
    }
}
