using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CetemLibrary
{
   public  class Dispositifsbiomedicale
    {
        public static Dispositifsbiomedicale DispositifSelectionne;

        int id;
        string Marque;
        string Type;
        string Numero_serie;
        string Nom_hopital;
        string Nom_service;
        string Nom_region;

        public string Marque1 { get => Marque; set => Marque = value; }
        public string Type1 { get => Type; set => Type = value; }
        public string Numero_serie1 { get => Numero_serie; set => Numero_serie = value; }
        public string Nom_hopital1 { get => Nom_hopital; set => Nom_hopital = value; }
        public string Nom_service1 { get => Nom_service; set => Nom_service = value; }
        public string Nom_region1 { get => Nom_region; set => Nom_region = value; }
        public int Id { get => id; set => id = value; }

        public Dispositifsbiomedicale(string typ , string marq , string numse, string hop , string serv,string reg , int id)
        {
            Marque1 = marq;
            Type1 = typ;
            Numero_serie1 = numse;
            Nom_hopital1 = hop;
            Nom_service1 = serv;
            Nom_region1 = reg;
            Id = id;

        }
    }
}
