using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CetemLibrary.Modeles
{
  public class Intervention_pousse_seringue

    {
        public string numéro_intervention;
        public string date_intervention;
        public string Etat_intervention;
        public string Intervenant;
        public string Test_sécurit_électrique;
        public string Test_performance_prémiere_voie;
        public string Test_performance_déuxieme_voie;
        public string Commentaire;
        public string Numero_demande;
        public string etat_equip;
        public string num_ser_equip; 

        public Intervention_pousse_seringue (string numps , string dateps , string etatps , string interps , string tseps , string tppvps , string tpdvps , string cps , string ndps , string etps , string sps)
        {
            numéro_intervention = numps;
            date_intervention = dateps;
            Etat_intervention = etatps;
            Intervenant = interps;
            Test_sécurit_électrique = tseps;
            Test_performance_prémiere_voie = tppvps;
            Test_performance_déuxieme_voie = tpdvps;
            Commentaire = cps;
            Numero_demande = ndps;
            etat_equip = etps;
            num_ser_equip = sps;


        }



    }
}
