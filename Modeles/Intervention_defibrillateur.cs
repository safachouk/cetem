using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CetemLibrary.Modeles
{
  public   class Intervention_defibrillateur
    {
        public string Numero_intervention6 ;
        public string Date_intervention;
        public string Etat_intervention;
        public string Intervenant;
        public string Test_securit_electrique;
        public string Test_indicateur_mode_synchro;
        public string Test_indicateur_mode_normale;
        public string Test_temps_charge;
        public string Testmesureenergie;
        public string Test_taux_de_perte;
        public string Testmoniteurecg;
        public string Testenregistrementpapier;
        public string Commentaire;
        public string Numero_demande10;
        public string type_equip2;
        public string etat_equip25;
        public string numser;
        public int id_defib;

        public Intervention_defibrillateur()
        {
        }

        public Intervention_defibrillateur(string nud, string dated , string etatd , string interd , string tsed , string timsd , string timnd , string ttcd , string tmed , string tpd , string mond , string tepd , string cd , string nmd , string teqd , string eeqd , string numdefibr ,  int iddefb)
        {

            Numero_intervention6 = nud;
            Date_intervention = dated;
            Etat_intervention = etatd;
            Intervenant = interd;
            Test_securit_electrique = tsed;
            Test_indicateur_mode_synchro = timsd;
            Test_indicateur_mode_normale = timnd;
            Test_temps_charge = ttcd;
            Testmesureenergie = tmed;
            Test_taux_de_perte = tpd;
            Testmoniteurecg = mond;
            Testenregistrementpapier = tepd;
            Commentaire = cd;
            Numero_demande10 = nmd;
            type_equip2 = teqd;
            etat_equip25 = eeqd;
            numser = numdefibr;
            id_defib = iddefb; 



        }

    }
}
