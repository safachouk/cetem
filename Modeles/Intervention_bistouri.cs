using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CetemLibrary.Modeles
{
    public  class Intervention_bistouri
    {
        public string Numero_intervention ;
        public string Date_intervention; 
        public string Etat_intervention;
        public string Intervenant;
        public string typ_equipement;
        public string Test_securit_electrique;
        public string Test_des_modes;
        public string Commentaire;
        public string Numero_demande;
        public string test_fuite_partie_active;
        public string test_fuite_partie_neutre;
        public string etat_equip;
        public string numero_serie_bistouri;

        public int idintervention;

        public Intervention_bistouri()
        {
        }

        public Intervention_bistouri (string numb , string datb , string etatb , string intb , string typb , string tseb , string tmb , string cb , string ndb , string tfpab , string tfpnb , string etb ,string nuseb ,  int idinterv)
        {
            Numero_intervention = numb;
            Date_intervention = datb;
            Etat_intervention = etatb;
            Intervenant = intb;
            typ_equipement = typb;
            Test_securit_electrique = tseb;
            Test_des_modes = tmb;
            Commentaire = cb;
            Numero_demande = ndb;
            test_fuite_partie_active = tfpab;
            test_fuite_partie_neutre = tfpnb;
            etat_equip = etb;
            numero_serie_bistouri = nuseb; 
            idintervention = idinterv; 


        }




    }
}
