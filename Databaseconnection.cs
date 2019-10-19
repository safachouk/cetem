using CetemLibrary.Modeles;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CetemLibrary
{
    public class Databaseconnection
    {
        static MySqlConnection conn;
        public static Utilisateur Utilisateur_courant = null;

        static string host = "localhost";
        static int port = 3306;
        static string database = "ctm_bh_application";
        static string username = "root";
        static string password = "";

        

        public static void DBConnect()
        {
            // Connection String.
            String connectionString = "SERVER=" + host + ";" + "DATABASE=" +
        database + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";
            //connString = "Server=" + host + ";Database=" + database
            // + ";port=" + port + ";User Id=" + username + ";password=" + password;

            conn = new MySqlConnection(connectionString);

        }

        public static string[] getserresp()
        {
            if (conn == null)
                DBConnect();
            try
            {
                conn.Open();
                var numserie = new List<string>();
                var cmd11 = new MySqlCommand("SELECT  NUM_SERIE FROM equipements where 	TYPE = 'Respirateur anesthésie' || TYPE = 'Respirateur de réanimation' || TYPE = 'Respirateur de transport' ", conn);
                var reader = cmd11.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        numserie.Add(reader.GetString("NUM_SERIE"));
                    }
                }
                else
                {
                    MessageBox.Show("Erreur pas de Hopitaux trouvé.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                reader.Close();
                conn.Close();
                return numserie.ToArray();
            }
            catch (Exception ex)
            {
                conn.Close();
                return null;
            }
            return null;
        }

        public static string[] getseriedefib()
        {
            if (conn == null)
                DBConnect();
            try
            {
                conn.Open();
                var numserie = new List<string>();
                var cmd11 = new MySqlCommand("SELECT  NUM_SERIE FROM equipements where 	TYPE = 'Défibrillateur' ", conn);
                var reader = cmd11.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        numserie.Add(reader.GetString("NUM_SERIE"));
                    }
                }
                else
                {
                    MessageBox.Show("Erreur pas de Hopitaux trouvé.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                reader.Close();
                conn.Close();
                return numserie.ToArray();
            }
            catch (Exception ex)
            {
                conn.Close();
                return null;
            }
            return null;
        }

        public static string[] getseriepouss()
        {
            if (conn == null)
                DBConnect();
            try
            {
                conn.Open();
                var numserie = new List<string>();
                var cmd11 = new MySqlCommand("SELECT  NUM_SERIE FROM equipements where 	TYPE = 'Pousse Seringue' ", conn);
                var reader = cmd11.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        numserie.Add(reader.GetString("NUM_SERIE"));
                    }
                }
                else
                {
                    MessageBox.Show("Erreur pas de Hopitaux trouvé.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                reader.Close();
                conn.Close();
                return numserie.ToArray();
            }
            catch (Exception ex)
            {
                conn.Close();
                return null;
            }
            return null;
        }

        public static string[] getserie()
        {
            if (conn == null)
                DBConnect();
            try
            {
                conn.Open();
                var numserie = new List<string>();
                var cmd11 = new MySqlCommand("SELECT  NUM_SERIE FROM equipements where 	TYPE = 'Bistouri' ", conn);
                var reader = cmd11.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        numserie.Add(reader.GetString("NUM_SERIE"));
                    }
                }
                else
                {
                    MessageBox.Show("Erreur pas de Hopitaux trouvé.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                reader.Close();
                conn.Close();
                return numserie.ToArray();
            }
            catch (Exception ex)
            {
                conn.Close();
                return null;
            }
            return null;
        }

        public static string[] getdemande()
        {
            if (conn == null)
                DBConnect();
            try
            {
                conn.Open();
                var demand = new List<string>();
                var cmd10 = new MySqlCommand("SELECT  Numero_demande FROM demandes", conn);
                var reader = cmd10.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        demand.Add(reader.GetString("Numero_demande"));
                    }
                }
                else
                {
                    MessageBox.Show("Erreur pas de Hopitaux trouvé.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                reader.Close();
                conn.Close();
                return demand.ToArray();
            }
            catch (Exception ex)
            {
                conn.Close();
                return null;
            }
            return null;
        }

        public static string[] getintervenant()
        {
            if (conn == null)
                DBConnect();
            try
            {
                conn.Open();
                var intervenants = new List<string>();
                var cmd9 = new MySqlCommand("SELECT  Nom_technicien FROM techniciens", conn);
                var reader = cmd9.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        intervenants.Add(reader.GetString("Nom_technicien"));
                    }
                }
                else
                {
                    MessageBox.Show("Erreur pas de Hopitaux trouvé.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                reader.Close();
                conn.Close();
                return intervenants.ToArray();
            }
            catch (Exception ex)
            {
                conn.Close();
                return null;
            }
            return null;
        }

        public static string[] gethopital()
        {
            if (conn == null)
                DBConnect();
            try
            {
                conn.Open();
                var hopitals = new List<string>();
                var cmd5 = new MySqlCommand("SELECT  NOM_HOPITAL FROM hopitaux", conn);
                var reader = cmd5.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        hopitals.Add(reader.GetString("NOM_HOPITAL"));
                    }
                }
                else
                {
                    MessageBox.Show("Erreur pas de Hopitaux trouvé.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                reader.Close();
                conn.Close();
                return hopitals.ToArray();
            }
            catch (Exception ex)
            {
                conn.Close();
                return null;
            }
            return null;
        }

       

        public static string[] getEquipement()
        {
            if (conn == null)
                DBConnect();
            try
            {
                conn.Open();
                var equipements = new List<string>();
                var cmd8 = new MySqlCommand("SELECT  TYPE FROM equipements", conn);
                var reader = cmd8.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        equipements.Add(reader.GetString("TYPE"));
                    }
                }
                else
                {
                    MessageBox.Show("Erreur pas de équipement trouvé.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                reader.Close();
                conn.Close();
                return equipements.ToArray();
            }
            catch (Exception ex)
            {
                conn.Close();
                return null;
            }
            return null;

        }

        public static string[] getservice()
        {
            if (conn == null)
                DBConnect();
            try
            {
                conn.Open();
                var services = new List<string>();
                var cmd6 = new MySqlCommand("SELECT Nom_service FROM service", conn);
                var reader = cmd6.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        services.Add(reader.GetString("Nom_service"));
                    }
                }
                else
                {
                    MessageBox.Show("Erreur pas de service trouvé.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                reader.Close();
                conn.Close();
                return services.ToArray();
            }
            catch (Exception ex)
            {
                conn.Close();
                return null;
            }
            return null;
        }

        public static string[] GetRegions()
        {
            if (conn == null)
                DBConnect();
            try
            {
                conn.Open();
                var regions = new List<string>();
                var cmd = new MySqlCommand("SELECT  NOM_REGION FROM region", conn);
                var reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        regions.Add(reader.GetString("NOM_REGION"));
                    }
                }
                else
                {
                    MessageBox.Show("Erreur pas de regions trouvé.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                reader.Close();
                conn.Close();
                return regions.ToArray();
            }
            catch (Exception ex)
            {
                conn.Close();
                return null;
            }
            return null;
        }

        public static bool se_connecter(string nom, string pass)
        {
            if (conn == null)
                DBConnect();
            try
            {
                conn.Open();
                var cmd = new MySqlCommand("SELECT * FROM techniciens WHERE Nom_technicien=@mat AND password=@pass", conn);
                cmd.Parameters.AddWithValue("@mat", nom);
                cmd.Parameters.AddWithValue("@pass", pass);
                cmd.Prepare();
                var reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Utilisateur_courant = new Utilisateur(
                            reader.GetString("nom_technicien"),
                            reader.GetString("prenom_technicen"),
                            reader.GetString("e_mail"),
                            reader.GetString("password"),
                            reader.GetInt32("id_tech"));
                        reader.Close();
                        conn.Close();

                        return true;
                    }
                }
                else
                {
                    MessageBox.Show("Erreur de connexion \nVeuillez verifier votre matricule/Mot de pass", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                conn.Close();

            }
            catch (Exception ex)
            {
                conn.Close();
                return false;
            }
            return false;
        }


        public static bool Ajouter_equipement(string Ty, string marq, string mod, string nu, string nareg, string nahop, string naserv)
        {

            if (conn == null)
                DBConnect();
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                var aequip = new MySqlCommand("INSERT INTO equipements (MARQUE,TYPE,Modele,NUM_SERIE,nom_de_hopital ,Nom_de_service,Nom_region)" + "VALUES(@marque, @type,@modele, @num_serie, @nom_de_hopital, @nom_de_service, @nom_region)", conn);
                aequip.Parameters.AddWithValue("@type", Ty);
                aequip.Parameters.AddWithValue("@marque", marq);
                aequip.Parameters.AddWithValue("@modele", mod);
                aequip.Parameters.AddWithValue("@num_serie", nu);
                aequip.Parameters.AddWithValue("@nom_region", nareg);
                aequip.Parameters.AddWithValue("@nom_de_hopital", nahop);
                aequip.Parameters.AddWithValue("@nom_de_service", naserv);



                int rowCount = aequip.ExecuteNonQuery();

                conn.Close();
                return rowCount == 1;
            }
            catch (Exception ex)
            {
                conn.Close();
                return false;
            }

        }
        public static Dispositifsbiomedicale getEquipement(int id)
        {
            if (conn == null)
                DBConnect();
            try
            {
                var dbm = new Dispositifsbiomedicale();
                conn.Open();
                var cmd = new MySqlCommand("SELECT type As 'Type' , marque As 'Marque' , NUM_SERIE As 'Numéro série' , nom_de_hopital As 'Hopital' , Nom_de_service As 'service'  , Nom_Region As 'region' , Modele As 'Modéle'  , id_equipement As 'Identifiant' FROM equipements WHERE id_equipement=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Prepare();
                var reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dbm = new Dispositifsbiomedicale(
                            reader.GetString("type"),
                            reader.GetString("marque"),
                            reader.GetString("NUM_SERIE"),
                            reader.GetString("nom_de_hopital"),
                            reader.GetString("Nom_de_service"),
                            reader.GetString("Nom_Region"),
                            reader.GetString("Modele"),
                            reader.GetInt32("id_equipement"));
                        reader.Close();
                        conn.Close();

                        return dbm;
                    }
                }
                else
                {
                    MessageBox.Show("Erreur dispositif introuvable", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                conn.Close();
                
            }
            catch (Exception ex)
            {
                conn.Close();
                return null;
            }
            return null;

        }


        public static Utilisateur getPersonnel(int id)
        {

            if (conn == null)
                DBConnect();
            try
            {
                var dbp = new Utilisateur();
                conn.Open();
                var cmp = new MySqlCommand("SELECT * FROM techniciens WHERE ID_Tech=@id", conn);
                cmp.Parameters.AddWithValue("@id", id);
                cmp.Prepare();
                var reader = cmp.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                       
                        dbp = new Utilisateur(
                            reader.GetString("Nom_technicien"),
                            reader.GetString("prenom_technicen"),
                            reader.GetString("e_mail"),
                            reader.GetString("password"),
                            reader.GetInt32("ID_Tech"));
                        reader.Close();
                        conn.Close();

                        return dbp;
                    }
                }
                else
                {
                    MessageBox.Show("Erreur dispositif introuvable", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                conn.Close();

            }
            catch (Exception ex)
            {
                conn.Close();
                return null;
            }
            return null;

        }


        public static Demande_class getdemande(int id)
        {
            if (conn == null)
                DBConnect();
            try
            {
                var dbd = new Demande_class();
                conn.Open();
                var cmd1 = new MySqlCommand("SELECT * FROM demandes WHERE ID_DEMANDE=@id", conn);
                cmd1.Parameters.AddWithValue("@id", id);
                cmd1.Prepare();
                var reader = cmd1.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        dbd = new Demande_class(
                            reader.GetString("Nombre_Respirateur_anesthesie"),
                            reader.GetString("Date_Demande"),
                            reader.GetString("Etat_demande"),
                            reader.GetString("Numero_demande"),
                            reader.GetString("region_demande"),
                            reader.GetString("Hopital_demande"),
                            reader.GetString("Nombre_respirateur_reanimation"),
                            reader.GetString("nombre_pousse_seringe"),
                            reader.GetString("nombre_defibrillateur"),
                            reader.GetString("Nombre_respirateur_transport"),
                            reader.GetString("Nombre_bistouri"),
                            reader.GetInt32("ID_DEMANDE"));
                        reader.Close();
                        conn.Close();
                    

                        return dbd;
                    }
                }
                else
                {
                    MessageBox.Show("Erreur demande introuvable", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                conn.Close();

            }
            catch (Exception ex)
            {
                conn.Close();
                return null;
            }
            return null;
        }



       public static Intervention_respirateur_class getrespirateur (int id)
        {
            if (conn == null)
                DBConnect();
            try
            {
                var dbresp = new Intervention_respirateur_class();
                conn.Open();
                var cmresp = new MySqlCommand("SELECT * FROM intervention_respirateur WHERE ID_intervention_resp=@id", conn);
                cmresp.Parameters.AddWithValue("@id", id);
                cmresp.Prepare();
                var reader = cmresp.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dbresp = new Intervention_respirateur_class(
                            reader.GetString("Numero_intervention"),
                            reader.GetString("Date_intervention"),
                            reader.GetString("Intervenant"),
                            reader.GetString("Numero_demande"),
                            reader.GetString("type_equip"),
                            reader.GetString("num_ser_interv"),
                            reader.GetString("Etat_intervention"),
                            reader.GetString("test_securite_electrique"),
                            reader.GetString("test_vc"),
                            reader.GetString("Etat_equip"),
                            reader.GetString("test_oxygene"),
                            reader.GetString("test_pc"),
                            reader.GetString("test_vac"),
                            reader.GetString("Commentaire"),
                            reader.GetInt32("ID_intervention_resp"));
                        reader.Close();
                        conn.Close();

                        return dbresp;
                    }
                }
                else
                {
                    MessageBox.Show("Erreur dispositif introuvable", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                conn.Close();

            }
            catch (Exception ex)
            {
                conn.Close();
                return null;
            }
            return null;
        }

       public static Intervention_bistouri getbistouri (int id)
        {
            if (conn == null)
                DBConnect();
            try
            {
                var dbbist = new Intervention_bistouri();
                conn.Open();
                var cmbist = new MySqlCommand("SELECT * FROM intervention_bistouri WHERE id_intervention=@id", conn);
                cmbist.Parameters.AddWithValue("@id", id);
                cmbist.Prepare();
                var reader = cmbist.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dbbist = new Intervention_bistouri(
                            reader.GetString("Numero_intervention"),
                            reader.GetString("Date_intervention"),
                            reader.GetString("Etat_intervention"),
                            reader.GetString("Intervenant"),
                            reader.GetString("typ_equipement"),
                            reader.GetString("Test_securit_electrique"),
                            reader.GetString("Test_des_modes"),
                            reader.GetString("Commentaire"),
                            reader.GetString("Numero_demande"),
                            reader.GetString("test_fuite_partie_active"),
                            reader.GetString("test_fuite_partie_neutre"),
                            reader.GetString("etat_equip"),
                            reader.GetString("numero_serie_bistouri"),
                            reader.GetInt32("id_intervention"));
                        reader.Close();
                        conn.Close();

                        return dbbist;
                    }
                }
                else
                {
                    MessageBox.Show("Erreur dispositif introuvable", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                conn.Close();

            }
            catch (Exception ex)
            {
                conn.Close();
                return null;
            }
            return null;


        }


        public static Intervention_pousse_seringue getPousse (int id)
        {

            if (conn == null)
                DBConnect();
            try
            {
                var dbpouss = new Intervention_pousse_seringue();
                conn.Open();
                var cmbpouss = new MySqlCommand("SELECT * FROM intervention_pousse_seringe WHERE id_pousse=@id", conn);
                cmbpouss.Parameters.AddWithValue("@id", id);
                cmbpouss.Prepare();
                var reader = cmbpouss.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dbpouss = new Intervention_pousse_seringue(
                            reader.GetString("numero_intervention"),
                            reader.GetString("date_intervention"),
                            reader.GetString("Etat_intervention"),
                            reader.GetString("Intervenant"),
                            reader.GetString("Test_securit_electrique"),
                            reader.GetString("Test_performance_premiere_voie"),
                            reader.GetString("Test_performance_deuxieme_voie"),
                            reader.GetString("Commentaire"),
                            reader.GetString("Numero_demande"),
                            reader.GetString("etat_equip"),
                            reader.GetString("num_ser_equip"),
                            reader.GetInt32("id_pousse"));
                        reader.Close();
                        conn.Close();

                        return dbpouss;
                    }
                }
                else
                {
                    MessageBox.Show("Erreur dispositif introuvable", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                conn.Close();

            }
            catch (Exception ex)
            {
                conn.Close();
                return null;
            }
            return null;


        }


       public static Intervention_defibrillateur getdefibrillateur (int id)
        {

            if (conn == null)
                DBConnect();
            try
            {
                var dbdefib = new Intervention_defibrillateur();
                conn.Open();
                var cmbdefib = new MySqlCommand("SELECT * FROM intervention_defibrillateur WHERE id_defib=@id", conn);
                cmbdefib.Parameters.AddWithValue("@id", id);
                cmbdefib.Prepare();
                var reader = cmbdefib.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dbdefib = new Intervention_defibrillateur(
                            reader.GetString("Numero_intervention6"),
                            reader.GetString("Date_intervention"),
                            reader.GetString("Etat_intervention"),
                            reader.GetString("Intervenant"),
                            reader.GetString("Test_securit_electrique"),
                            reader.GetString("Test_indicateur_mode_synchro"),
                            reader.GetString("Test_indicateur_mode_normale"),
                            reader.GetString("Test_temps_charge"),
                            reader.GetString("Testmesureenergie"),
                            reader.GetString("Test_taux_de_perte"),
                            reader.GetString("Testmoniteurecg"),
                            reader.GetString("Testenregistrementpapier"),
                            reader.GetString("Commentaire"),
                            reader.GetString("Numero_demande10"),
                            reader.GetString("type_equip2"),
                            reader.GetString("etat_equip25"),
                            reader.GetInt32("id_defib"));
                        reader.Close();
                        conn.Close();

                        return dbdefib;
                    }
                }
                else
                {
                    MessageBox.Show("Erreur dispositif introuvable", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                conn.Close();

            }
            catch (Exception ex)
            {
                conn.Close();
                return null;
            }
            return null;

        }


        public static bool Ajouter_demande(string numbane, string numrea, string numpouss, string numdef, string numtranspo, string numbistou, string dattt, string etatt, string numerooo, string nomregionnn, string nomhopitalll)
        {

            if (conn == null)
                DBConnect();
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                var ademand = new MySqlCommand("INSERT INTO demandes (Nombre_Respirateur_anesthesie,Nombre_respirateur_reanimation,nombre_pousse_seringe,nombre_defibrillateur,Nombre_respirateur_transport,Nombre_bistouri,Date_Demande ,Etat_demande , Numero_demande , region_demande , Hopital_demande)" + "VALUES(@numberanest,@numberrea,@numberpouss,@numberdef,@numbertranspo,@numberbist, @Date , @Etat, @num, @nomregion, @nomhopital)", conn);
                ademand.Parameters.AddWithValue("@numberanest", numbane);
                ademand.Parameters.AddWithValue("@numberrea", numrea);
                ademand.Parameters.AddWithValue("@numberpouss", numpouss);
                ademand.Parameters.AddWithValue("@numberdef", numdef);
                ademand.Parameters.AddWithValue("@numbertranspo", numtranspo);
                ademand.Parameters.AddWithValue("@numberbist", numbistou);
                ademand.Parameters.AddWithValue("@Date", dattt);
                ademand.Parameters.AddWithValue("@Etat", etatt);
                ademand.Parameters.AddWithValue("@num", numerooo);
                ademand.Parameters.AddWithValue("@nomregion", nomregionnn);
                ademand.Parameters.AddWithValue("@nomhopital", nomhopitalll);
                int rowCount = ademand.ExecuteNonQuery();

                conn.Close();
                return rowCount == 1;

            }
            catch

            {

                conn.Close();
                return false;

            }

        }

        public static bool Ajouter_intervenant(string nom, string prenom, string email, string password)
        {

            if (conn == null)
                DBConnect();
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                var ajpers = new MySqlCommand("INSERT INTO  techniciens (Nom_technicien,prenom_technicen,e_mail,password)" + "VALUES(@nomtech , @prenomtech , @mail , @pass)", conn);
                ajpers.Parameters.AddWithValue("@nomtech", nom);
                ajpers.Parameters.AddWithValue("@prenomtech", prenom);
                ajpers.Parameters.AddWithValue("@mail", email);
                ajpers.Parameters.AddWithValue("@pass", password);
                int rowCount = ajpers.ExecuteNonQuery();

                conn.Close();
                return rowCount == 1;

            }
            catch (Exception ex)
            {

                conn.Close();
                return false;


            }
        }


        public static bool Ajouter_Hopital(string Nomregion, string nomHopital)
        {

            if (conn == null)
                DBConnect();
            try

            {

                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                var aequip = new MySqlCommand("INSERT INTO hopitaux (NOM_HOPITAL,NOM_REGION)" + "VALUES(@nom_de_hopital, @nom_de_region)", conn);
                aequip.Parameters.AddWithValue("@nom_de_hopital", nomHopital);
                aequip.Parameters.AddWithValue("@nom_de_region", Nomregion);


                int rowCount = aequip.ExecuteNonQuery();

                conn.Close();
                return rowCount == 1;


            }
            catch (Exception ex)
            {
                conn.Close();
                return false;
            }
        }

        public static bool intervention_respirateur(string numintervention, string dateintervent, string intervena , string numdemand, string typequip, string numser, string etatinterv, string testsecrurti, string tetstvc, string testetatequip, string testoxyg, string testpc, string tetsvac, string comm)
        {
            if (conn == null)
                DBConnect();
            try

            {

                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                var aintervresp = new MySqlCommand("INSERT INTO intervention_respirateur(Numero_intervention, Date_intervention, Intervenant,Numero_demande,type_equip , num_ser_interv ,Etat_intervention, test_securite_electrique,test_vc,Etat_equip,test_oxygene,test_pc ,test_vac,Commentaire )" + "VALUES(@numinterv,@datinterv,@interven,@numdeman,@typequip,@numserie,@etatintrev,@testsec,@testvc,@tetsetatequip ,@testoxy,@testpc,@testvac,@comm)", conn);
                aintervresp.Parameters.AddWithValue("@numinterv", numintervention);
                aintervresp.Parameters.AddWithValue("@datinterv", dateintervent);
                aintervresp.Parameters.AddWithValue("@interven", intervena);
                aintervresp.Parameters.AddWithValue("@numdeman", numdemand);
                aintervresp.Parameters.AddWithValue("@typequip", typequip);
                aintervresp.Parameters.AddWithValue("@numserie", numser);
                aintervresp.Parameters.AddWithValue("@etatintrev", etatinterv);
                aintervresp.Parameters.AddWithValue("@testsec", testsecrurti);
                aintervresp.Parameters.AddWithValue("@testvc", tetstvc);
                aintervresp.Parameters.AddWithValue("@tetsetatequip", testetatequip);
                aintervresp.Parameters.AddWithValue("@testoxy", testoxyg);
                aintervresp.Parameters.AddWithValue("@testpc", testpc);
                aintervresp.Parameters.AddWithValue("@testvac", tetsvac);
                aintervresp.Parameters.AddWithValue("@comm", comm);
                int rowCount = aintervresp.ExecuteNonQuery();

                conn.Close();
                return rowCount == 1;


            }
            catch (Exception ex)
            {
                conn.Close();
                return false;
            }
        }



        public static bool intervention_pousse_seringe( string numintervention1 , string dateintervent1 , string etatinterv1 , string intervenant12 , string testsecu1 , string testvoie1 , string testvoie2 , string comme1 , string numdemand1 , string etatequip1 , string num_ser_equip1)
        {

            if (conn == null)
                DBConnect();
            try
                
            {

                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                var aintervrpouss = new MySqlCommand("INSERT INTO  intervention_pousse_seringe(numero_intervention , date_intervention , Etat_intervention , Intervenant , Test_securit_electrique , Test_performance_premiere_voie , Test_performance_deuxieme_voie , Commentaire , Numero_demande , etat_equip , num_ser_equip )" + "VALUES(@numero_intervention , @date_intervention , @Etat_intervention , @Intervenant , @Test_securit_electrique , @Test_performance_premiere_voie , @Test_performance_deuxieme_voie , @Commentaire , @Numero_demande , @etat_equip  , @num_ser_equip)", conn); 
               aintervrpouss.Parameters.AddWithValue("@numero_intervention", numintervention1);
                aintervrpouss.Parameters.AddWithValue("@date_intervention", dateintervent1);
                aintervrpouss.Parameters.AddWithValue("@Etat_intervention", etatinterv1);
                aintervrpouss.Parameters.AddWithValue("@Intervenant", intervenant12);
                aintervrpouss.Parameters.AddWithValue("@Test_securit_electrique", testsecu1);
                aintervrpouss.Parameters.AddWithValue("@Test_performance_premiere_voie", testvoie1);
                aintervrpouss.Parameters.AddWithValue("@Test_performance_deuxieme_voie", testvoie2);
                aintervrpouss.Parameters.AddWithValue("@Commentaire", comme1);
                aintervrpouss.Parameters.AddWithValue("@Numero_demande", numdemand1);
                aintervrpouss.Parameters.AddWithValue("@etat_equip", etatequip1);
                aintervrpouss.Parameters.AddWithValue("@num_ser_equip", num_ser_equip1);
                int rowCount = aintervrpouss.ExecuteNonQuery();

                conn.Close();
                return rowCount == 1;


            }
            catch (Exception ex)
            {
                conn.Close();
                return false;
            }
        }
        

        public static bool ajout_boustri (string numintervention2 , string dateintervent2 , string etatinterv2 , string intervenant2 , string typequip222 , string testsecuritu2 , string testmod2 , string comme2 , string numdemand2 , string testfuiteactive , string testfuiteneutre , string etat_equip2 ,string numdema)
        {

            if (conn == null)
                DBConnect();
            try
            
            {

                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                var aintervrbistouri = new MySqlCommand("INSERT INTO intervention_bistouri(Numero_intervention , Date_intervention ,Etat_intervention , Intervenant , typ_equipement , Test_securit_electrique , Test_des_modes , Commentaire , Numero_demande , test_fuite_partie_active , test_fuite_partie_neutre , etat_equip , numero_serie_bistouri )" + "VALUES(@Numero_intervention2 , @Date_intervention2 , @Etat_intervention2 , @Intervenant2 , @typ_equipement2  , @Test_securit_electrique2 , @Test_des_modes2 , @Commentaire2 , @Numero_demande2 , @test_fuite_partie_active2 , @test_fuite_partie_neutre2 , @etat_equip2 , @numbist )", conn);

                aintervrbistouri.Parameters.AddWithValue("@Numero_intervention2", numintervention2);
                aintervrbistouri.Parameters.AddWithValue("@Date_intervention2", dateintervent2);
                aintervrbistouri.Parameters.AddWithValue("@Etat_intervention2", etatinterv2);
                aintervrbistouri.Parameters.AddWithValue("@Intervenant2", intervenant2);
                aintervrbistouri.Parameters.AddWithValue("@typ_equipement2", typequip222);
                aintervrbistouri.Parameters.AddWithValue("@Test_securit_electrique2", testsecuritu2);
                aintervrbistouri.Parameters.AddWithValue("@Test_des_modes2", testmod2);
                aintervrbistouri.Parameters.AddWithValue("@Commentaire2", comme2);
                aintervrbistouri.Parameters.AddWithValue("@Numero_demande2", numdemand2);
                aintervrbistouri.Parameters.AddWithValue("@test_fuite_partie_active2", testfuiteactive);
                aintervrbistouri.Parameters.AddWithValue("@test_fuite_partie_neutre2", testfuiteneutre);
                aintervrbistouri.Parameters.AddWithValue("@etat_equip2", etat_equip2);
                aintervrbistouri.Parameters.AddWithValue("@numbist", numdema);
                int rowCount = aintervrbistouri.ExecuteNonQuery();

                conn.Close();
                return rowCount == 1;


            }
            catch (Exception ex)
            {
                conn.Close();
                return false;
            }






        }
            
        
        public static bool ajout_defibrillateur(string numintervention5 , string dateintervention5 , string etatintervention5 , string intervenant5 , string testsecuriteelectrique5 , string testmodesynchro , string testmodenormale , string testtempscharge , string testmesureenergie , string testtauxperte , string testmoniteuretecg , string testenrgipapier , string commentaire6 , string numdemand6 , string typequip6 , string etatequip6 )
        {

            if (conn == null)
                DBConnect();
            try

            {

                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                var aintervrdefib = new MySqlCommand("INSERT INTO  intervention_defibrillateur(Numero_intervention6 , Date_intervention , Etat_intervention , Intervenant , Test_securit_electrique , Test_indicateur_mode_synchro , Test_indicateur_mode_normale , Test_temps_charge , Testmesureenergie , Test_taux_de_perte , Testmoniteurecg , Testenregistrementpapier , Commentaire , 	Numero_demande10 , type_equip2 , etat_equip25  )" + "VALUES(@Numero_intervention6 , @Date_intervention6 , @Etat_intervention6 , @Intervenant6 , @Test_securit_electrique6 , @Test_indicateur_mode_synchro , @Test_indicateur_mode_normale , @Test_temps_charge , @Test_mesure_energie , @Testtauxperte , @Testmoniteurecg , @Testenregistrementpapier , @Commentaire6 , @Numero_demande6 , @type_equip6 , @etat_equip6)", conn);

                aintervrdefib.Parameters.AddWithValue("@Numero_intervention6",numintervention5);
                aintervrdefib.Parameters.AddWithValue("@Date_intervention6", dateintervention5);
                aintervrdefib.Parameters.AddWithValue("@Etat_intervention6", etatintervention5);
                aintervrdefib.Parameters.AddWithValue("@Intervenant6", intervenant5);
                aintervrdefib.Parameters.AddWithValue("@Test_securit_electrique6", testsecuriteelectrique5);
                aintervrdefib.Parameters.AddWithValue("@Test_indicateur_mode_synchro", testmodesynchro);
                aintervrdefib.Parameters.AddWithValue("@Test_indicateur_mode_normale", testmodenormale);
                aintervrdefib.Parameters.AddWithValue("@Test_temps_charge", testtempscharge);
                aintervrdefib.Parameters.AddWithValue("@Test_mesure_energie", testmesureenergie);
                aintervrdefib.Parameters.AddWithValue("@Testtauxperte", testtauxperte);
                aintervrdefib.Parameters.AddWithValue("@Testmoniteurecg", testmoniteuretecg);
                aintervrdefib.Parameters.AddWithValue("@Testenregistrementpapier", testenrgipapier);
                aintervrdefib.Parameters.AddWithValue("@Commentaire6", commentaire6);
                aintervrdefib.Parameters.AddWithValue("@Numero_demande6", numdemand6);
                aintervrdefib.Parameters.AddWithValue("@type_equip6", typequip6);
                aintervrdefib.Parameters.AddWithValue("@etat_equip6", etatequip6);
                int rowCount = aintervrdefib.ExecuteNonQuery();
                conn.Close();
                return rowCount == 1;


            }
            catch (Exception ex)
            {
                conn.Close();
                return false;
            }
        }


        public static bool Modifier_equipmement(string marq1, string Ty1, string mod1, string numserie1 , string hopital2 , string nomservice1 , string region1 , int id )
        {
            if (conn == null)
                DBConnect();
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                var Mequip = new MySqlCommand("update equipements set MARQUE=@marqeq , TYPE=@typeq , Modele = @modeq , NUM_SERIE = @serieequ , nom_de_hopital = @nohopeq , Nom_de_service = @nservequ , Nom_region = @nregeq  where ID_EQUIPEMENT= @id", conn);

                Equipement_class e; 

                Mequip.Parameters.AddWithValue("@marqeq", marq1);
                Mequip.Parameters.AddWithValue("@typeq", Ty1);
                Mequip.Parameters.AddWithValue("@modeq", mod1);
                Mequip.Parameters.AddWithValue("@serieequ", numserie1);
                Mequip.Parameters.AddWithValue("@nohopeq", hopital2);
                Mequip.Parameters.AddWithValue("@nservequ", nomservice1);
                Mequip.Parameters.AddWithValue("@nregeq", region1);
                Mequip.Parameters.AddWithValue("@id", id);//e.id
                int rowCount = Mequip.ExecuteNonQuery();

                conn.Close();
                return rowCount == 1;


            }
            catch (Exception ex)
            {
                conn.Close();
                return false;
            }
        }




        public static bool supprimer_equipement(int id)
        {
            if (conn == null)
                DBConnect();
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                var Dequip = new MySqlCommand("delete from equipements where ID_EQUIPEMENT= @id", conn);
                Dequip.Parameters.AddWithValue("@id", id);
                int rowCount = Dequip.ExecuteNonQuery();

                conn.Close();
                return rowCount == 1;


            }
            catch (Exception ex)
            {
                conn.Close();
                return false;
            }
        }


            public static bool Modifier_Personnel(string nomtech12, string prenomtech123 , string @mail23 , string password123 , int id )

        {


            if (conn == null)
                DBConnect();
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                var Mpersonn = new MySqlCommand("update techniciens set Nom_technicien=@nomtech1 , prenom_technicen=@prenomtech1 , e_mail = @mail23 , password = @password123 where ID_Tech= @id", conn);

                
                Mpersonn.Parameters.AddWithValue("@nomtech1", nomtech12);
                Mpersonn.Parameters.AddWithValue("@prenomtech1", prenomtech123);
                Mpersonn.Parameters.AddWithValue("@mail23", @mail23);
                Mpersonn.Parameters.AddWithValue("@password123", password123);
                Mpersonn.Parameters.AddWithValue("@id", id);
                int rowCount = Mpersonn.ExecuteNonQuery();

                conn.Close();
                return rowCount == 1;


            }
            catch (Exception ex)
            {
                conn.Close();
                return false;
            }

        }




        public static bool supprimer_personnel(int id)
        {
            if (conn == null)
                DBConnect();
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                var Dpersonn = new MySqlCommand("delete from techniciens where ID_Tech= @id", conn);
                Dpersonn.Parameters.AddWithValue("@id", id);
                int rowCount = Dpersonn.ExecuteNonQuery();

                conn.Close();
                return rowCount == 1;


            }
            catch (Exception ex)
            {
                conn.Close();
                return false;
            }
        }



        public static bool Modifier_Demande(string nresan, string datedem, string etatdem, string numdemand, string regdeman, string hopdeman, string nrerea, string nbrpou, string nbrdeb, string nbrresptra, string nbrbist, int id)

        {


            if (conn == null)
                DBConnect();
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
             
                    conn.Open();

                    var Mdemand = new MySqlCommand("update demandes set Nombre_Respirateur_anesthesie = @nran , Date_Demande = @dateres , Etat_demande = @etatdem , Numero_demande = @numdem , region_demande = @regideman , 	Hopital_demande = @hopidem , Nombre_respirateur_reanimation = @nrr , nombre_pousse_seringe = @nps , 	nombre_defibrillateur = @npd , 	Nombre_respirateur_transport = @nrt , Nombre_bistouri = @nbs where ID_DEMANDE= @id", conn);
                    Mdemand.Parameters.AddWithValue("@nran", nresan);
                    Mdemand.Parameters.AddWithValue("@dateres", datedem);
                    Mdemand.Parameters.AddWithValue("@etatdem", etatdem);
                    Mdemand.Parameters.AddWithValue("@numdem", numdemand);
                    Mdemand.Parameters.AddWithValue("@regideman", regdeman);
                    Mdemand.Parameters.AddWithValue("@hopidem", hopdeman);
                    Mdemand.Parameters.AddWithValue("@nrr", nrerea);
                    Mdemand.Parameters.AddWithValue("@nps", nbrpou);
                    Mdemand.Parameters.AddWithValue("@npd", nbrdeb);
                    Mdemand.Parameters.AddWithValue("@nrt", nbrresptra);
                    Mdemand.Parameters.AddWithValue("@nbs", nbrbist);
                    Mdemand.Parameters.AddWithValue("@id", id);
                    int rowCount = Mdemand.ExecuteNonQuery();
                    conn.Close();
                    return rowCount == 1;


                }


                catch (Exception ex)
            {
                conn.Close();
                return false;
            }

      
        }


        public static bool supprime_demande (int id)
        {
            if (conn == null)
                DBConnect();
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                var Ddemande = new MySqlCommand("delete from demandes where ID_DEMANDE = @id", conn);
                Ddemande.Parameters.AddWithValue("@id",id);
                int rowCount = Ddemande.ExecuteNonQuery();

                conn.Close();
                return rowCount == 1;


            }
            catch (Exception ex)
            {
                conn.Close();
                return false;
            }
        }




        public static bool Modifier_interv_bistouri(string numintbi , string datinb , string etatintb , string interb , string typb1 , string tseb2 , string tsm , string commbstri , string numdem , string tspa , string tpn , string etbost ,string numbistou, int id)

        {
            if (conn == null)
                DBConnect();
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                var Minterbi = new MySqlCommand("update intervention_bistouri set Numero_intervention=@numinterven , Date_intervention=@datintb , Etat_intervention = @etatinterb , Intervenant = @interb , typ_equipement =@typb , Test_securit_electrique=@tseb , Test_des_modes=@tsm1 , Commentaire =@combstr , Numero_demande =@nudemab , test_fuite_partie_active = @tfab , 	test_fuite_partie_neutre=@tfpnb , etat_equip=@etb , numero_serie_bistouri=@numbistr  where id_intervention= @id", conn);


                Minterbi.Parameters.AddWithValue("@numinterven", numintbi);
                Minterbi.Parameters.AddWithValue("@datintb", datinb);
                Minterbi.Parameters.AddWithValue("@etatinterb", etatintb);
                Minterbi.Parameters.AddWithValue("@interb", interb);
                Minterbi.Parameters.AddWithValue("@typb", typb1);
                Minterbi.Parameters.AddWithValue("@tseb", tseb2);
                Minterbi.Parameters.AddWithValue("@tsm1", tsm);
                Minterbi.Parameters.AddWithValue("@combstr", commbstri);
                Minterbi.Parameters.AddWithValue("@nudemab", numdem);
                Minterbi.Parameters.AddWithValue("@tfab", tspa);
                Minterbi.Parameters.AddWithValue("@tfpnb", tpn);
                Minterbi.Parameters.AddWithValue("@etb", etbost);
                Minterbi.Parameters.AddWithValue("@numbistr", numbistou);
                Minterbi.Parameters.AddWithValue("@id", id);

                int rowCount = Minterbi.ExecuteNonQuery();

                conn.Close();
                return rowCount == 1;


            }
            catch (Exception ex)
            {
                conn.Close();
                return false;
            }

        }



        public static bool supprimer_interv_bistouri(int id)
        {
            if (conn == null)
                DBConnect();
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                Intervention_bistouri x; 
                var Dinb = new MySqlCommand("delete from intervention_bistouri where id_intervention= @id", conn);
                Dinb.Parameters.AddWithValue("@id", id);
                int rowCount = Dinb.ExecuteNonQuery();

                conn.Close();
                return rowCount == 1;


            }
            catch (Exception ex)
            {
                conn.Close();
                return false;
            }
        }


        public static bool Modifier_interv_defibrillateur(string numinterdef , string datedef , string etatdef , string intdef , string tsedef , string timsddef , string timnddef , string ttcddef , string tmeddef , string ttpddef , string tmecgddef , string tepddef , string comdef , string nmdeddef , string typdef , string etaadef , int id)

        {
            if (conn == null)
                DBConnect();
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
             
                var Minterde = new MySqlCommand("update intervention_defibrillateur set Numero_intervention6=@nintd , Date_intervention=@dated , Etat_intervention=@etatd , Intervenant=@intde , Test_securit_electrique =@tsed , Test_indicateur_mode_synchro =@timsd1 , Test_indicateur_mode_normale=@timnd , Test_temps_charge =@ttcd , Testmesureenergie =@tmed , Test_taux_de_perte=@ttpd , Testmoniteurecg=@tmecgd , Testenregistrementpapier=@tepd , Commentaire=@comd , Numero_demande10=@nmded , type_equip2=@tydef , etat_equip25=@etdef where id_defib= @id", conn);
                Intervention_bistouri IB;

                Minterde.Parameters.AddWithValue("@nintd", numinterdef);
                Minterde.Parameters.AddWithValue("@dated", datedef);
                Minterde.Parameters.AddWithValue("@etatd", etatdef);
                Minterde.Parameters.AddWithValue("@intde", intdef);
                Minterde.Parameters.AddWithValue("@tsed", tsedef);
                Minterde.Parameters.AddWithValue("@timsd1", timsddef);
                Minterde.Parameters.AddWithValue("@timnd", timnddef);
                Minterde.Parameters.AddWithValue("@ttcd", ttcddef);
                Minterde.Parameters.AddWithValue("@tmed", tmeddef);
                Minterde.Parameters.AddWithValue("@ttpd", ttpddef);
                Minterde.Parameters.AddWithValue("@tmecgd", tmecgddef);
                Minterde.Parameters.AddWithValue("@tepd", tepddef);
                Minterde.Parameters.AddWithValue("@comd", comdef);
                Minterde.Parameters.AddWithValue("@nmded", nmdeddef);
                Minterde.Parameters.AddWithValue("@tydef", typdef);
                Minterde.Parameters.AddWithValue("@etdef", etaadef);
                Minterde.Parameters.AddWithValue("@id", id);

                int rowCount = Minterde.ExecuteNonQuery();

                conn.Close();
                return rowCount == 1;


            }
            catch (Exception ex)
            {
                conn.Close();
                return false;
            }

        }


        public static bool supprimer_interv_defibrillateur(int id)
        {
            if (conn == null)
                DBConnect();
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                Intervention_defibrillateur Interdef;
                var Dind = new MySqlCommand("delete from intervention_defibrillateur where id_defib= @id", conn);
                Dind.Parameters.AddWithValue("@id", id);
                int rowCount = Dind.ExecuteNonQuery();

                conn.Close();
                return rowCount == 1;


            }
            catch (Exception ex)
            {
                conn.Close();
                return false;
            }
        }



        public static bool Modifier_interv_pousse_seringue(string numpousse , string datepousse1 , string etatpouss1 , string iterpouss1 , string tspouss1 , string tspvpou1 , string tsp2pouss1 , string compouss1 , string numpousse1 , string etatequip , string seriepouss1 , int id)

        {
            if (conn == null)
                DBConnect();
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
              

                var Minterpouss = new MySqlCommand("update intervention_pousse_seringe set numero_intervention=@nintpous , date_intervention=@datpouss , Etat_intervention=@etatpouss , Intervenant=@intervpouss , Test_securit_electrique=@tsepouss , Test_performance_premiere_voie=@tspvpou , Test_performance_deuxieme_voie=@tsp2pouss , Commentaire=@compouss , Numero_demande=@numpouss , etat_equip=@etatequip , num_ser_equip=@seriepouss where id_pousse= @id", conn);
              

                Minterpouss.Parameters.AddWithValue("@nintpous", numpousse);
                Minterpouss.Parameters.AddWithValue("@datpouss", datepousse1);
                Minterpouss.Parameters.AddWithValue("@etatpouss", etatpouss1);
                Minterpouss.Parameters.AddWithValue("@intervpouss", iterpouss1);
                Minterpouss.Parameters.AddWithValue("@tsepouss", tspouss1);
                Minterpouss.Parameters.AddWithValue("@tspvpou", tspvpou1);
                Minterpouss.Parameters.AddWithValue("@tsp2pouss", tsp2pouss1);
                Minterpouss.Parameters.AddWithValue("@compouss", compouss1);
                Minterpouss.Parameters.AddWithValue("@numpouss", numpousse1);
                Minterpouss.Parameters.AddWithValue("@etatequip", etatequip);
                Minterpouss.Parameters.AddWithValue("@seriepouss", seriepouss1);
                Minterpouss.Parameters.AddWithValue("@id", id);


                int rowCount = Minterpouss.ExecuteNonQuery();

                conn.Close();
                return rowCount == 1;


            }
            catch (Exception ex)
            {
                conn.Close();
                return false;
            }

        }


        public static bool supprimer_interv_pousse_seringue(int id)
        {
            if (conn == null)
                DBConnect();
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                Intervention_pousse_seringue inpser;
                var Dpouss = new MySqlCommand("delete from intervention_pousse_seringe where id_pousse= @id", conn);
                Dpouss.Parameters.AddWithValue("@id", id);
                int rowCount = Dpouss.ExecuteNonQuery();

                conn.Close();
                return rowCount == 1;


            }
            catch (Exception ex)
            {
                conn.Close();
                return false;
            }
        }


        public static bool Modifier_interv_respirateur( string numresp , string datresp , string interresp1 , string numresp123 , string typresp , string numinresp1 , string etatresp1 , string testresp1 , string vcresp , string etatequipresp1 , string oxygresp , string pcresp , string vacresp , string comresp , int id)

        {
            if (conn == null)
                DBConnect();
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                var Minterresp = new MySqlCommand("update  intervention_respirateur set Numero_intervention=@nintresp , Date_intervention=@datresp , Intervenant=@interresp , Numero_demande=@numdresp , type_equip=@typres , num_ser_interv=@numinresp , Etat_intervention=@etatresp , test_securite_electrique=@teresp ,test_vc=@vcresp , Etat_equip=@etatequiresp , test_oxygene=@oxygresp , test_pc=@pcresp , test_vac=@vacresp , Commentaire=@comresp where ID_intervention_resp= @id", conn);

                Minterresp.Parameters.AddWithValue("@nintresp", numresp);
                Minterresp.Parameters.AddWithValue("@datresp", datresp);
                Minterresp.Parameters.AddWithValue("@interresp", interresp1);
                Minterresp.Parameters.AddWithValue("@numdresp", numresp123);
                Minterresp.Parameters.AddWithValue("@typres", typresp);
                Minterresp.Parameters.AddWithValue("@numinresp", numinresp1);
                Minterresp.Parameters.AddWithValue("@etatresp", etatresp1);
                Minterresp.Parameters.AddWithValue("@teresp", testresp1);
                Minterresp.Parameters.AddWithValue("@vcresp", vcresp);
                Minterresp.Parameters.AddWithValue("@etatequiresp", etatequipresp1);
                Minterresp.Parameters.AddWithValue("@oxygresp", oxygresp);
                Minterresp.Parameters.AddWithValue("@pcresp", pcresp);
                Minterresp.Parameters.AddWithValue("@vacresp", vacresp);
                Minterresp.Parameters.AddWithValue("@comresp", comresp);
                Minterresp.Parameters.AddWithValue("@id", id);
                int rowCount = Minterresp.ExecuteNonQuery();

                conn.Close();
                return rowCount == 1;


            }
            catch (Exception ex)
            {
                conn.Close();
                return false;
            }

        }


        public static bool supprimer_interv_respirateur(int id)
        {
            if (conn == null)
                DBConnect();
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                Intervention_respirateur_class respx;

                var Dresp = new MySqlCommand("delete from intervention_respirateur where ID_intervention_resp= @id", conn);
                Dresp.Parameters.AddWithValue("@id", id);
                int rowCount = Dresp.ExecuteNonQuery();

                conn.Close();
                return rowCount == 1;


            }
            catch (Exception ex)
            {
                conn.Close();
                return false;
            }
        }




        public static bool Modifier_mon_compte( string nomtech12123 , string prenomtech12312356 , string mail2389654 , string password123145238, int id )

        {

            if (conn == null)
                DBConnect();
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                string query = "update techniciens set ";
                List<string> parameters = new List<string>() ;
                if (!string.IsNullOrEmpty(nomtech12123.Trim()))
                    parameters.Add("Nom_technicien=@nomtech2 ");
                if (!string.IsNullOrEmpty(prenomtech12312356.Trim()))
                    parameters.Add("prenom_technicen=@prenomtech2 ");
                if (!string.IsNullOrEmpty(mail2389654.Trim()))
                    parameters.Add("e_mail = @mail59867 ");
                if (!string.IsNullOrEmpty(password123145238.Trim()))
                    parameters.Add("password = @passwor89754632 ");
                query += parameters.Aggregate((i, j) => i + " , " + j) + " where ID_Tech= @id";
                
                var Mcompte = new MySqlCommand(query, conn);

                Mcompte.Parameters.AddWithValue("@nomtech2", nomtech12123);
                Mcompte.Parameters.AddWithValue("@prenomtech2", prenomtech12312356);
                Mcompte.Parameters.AddWithValue("@mail59867", mail2389654);
                Mcompte.Parameters.AddWithValue("@passwor89754632", password123145238);
                Mcompte.Parameters.AddWithValue("@id", id);
                int rowCount = Mcompte.ExecuteNonQuery();

                conn.Close();
                return rowCount == 1;

            }
            catch (Exception ex)
            {
                conn.Close();
                return false;
            }

        }
        public static DataTable fillEquipement()
        {
            var dt = new DataTable();
            if (conn == null)
                DBConnect();
            try
            {
                conn.Open();
                MySqlDataAdapter msd = new MySqlDataAdapter("SELECT * FROM equipements", conn);
                msd.SelectCommand.CommandType = CommandType.Text;
                msd.Fill(dt);
                conn.Close();

            }
            catch (Exception ex)
            {
                conn.Close();
            }
            return dt;
        }



        public static DataTable fillpersonnel()
        {
            var dp = new DataTable();
            if (conn == null)
                DBConnect();
            try
            {
                conn.Open();
                MySqlDataAdapter msp = new MySqlDataAdapter("SELECT * FROM techniciens", conn);
                msp.SelectCommand.CommandType = CommandType.Text;
                msp.Fill(dp);
                conn.Close();

            }
            catch (Exception ex)
            {
                conn.Close();
            }
            return dp;
        }

        public static DataTable filldemande()
        {
            var dd = new DataTable();
            if (conn == null)
                DBConnect();
            try
            {
                conn.Open();
                MySqlDataAdapter msd = new MySqlDataAdapter("SELECT * FROM demandes", conn);
                msd.SelectCommand.CommandType = CommandType.Text;
                msd.Fill(dd);
                conn.Close();

            }
            catch (Exception ex)
            {
                conn.Close();
            }
            return dd;
        }


        public static DataTable fillinterventionresp()
        {
            var dresp = new DataTable();
            if (conn == null)
                DBConnect();
            try
            {
                conn.Open();
                MySqlDataAdapter msresp = new MySqlDataAdapter("SELECT * FROM intervention_respirateur", conn);
                msresp.SelectCommand.CommandType = CommandType.Text;
                msresp.Fill(dresp);
                conn.Close();

            }
            catch (Exception ex)
            {
                conn.Close();
            }
            return dresp;

        }

        public static DataTable fillinterventbistouri()
        {
            var dbistrou = new DataTable();
            if (conn == null)
                DBConnect();
            try
            {
                conn.Open();
                MySqlDataAdapter mbistrour = new MySqlDataAdapter("SELECT * FROM  intervention_bistouri", conn);
                mbistrour.SelectCommand.CommandType = CommandType.Text;
                mbistrour.Fill(dbistrou);
                conn.Close();

            }
            catch (Exception ex)
            {
                conn.Close();
            }
            return dbistrou;

        }


        public static DataTable fillinterventpousseseringue()
        {
            var dbpouss = new DataTable();
            if (conn == null)
                DBConnect();
            try
            {
                conn.Open();
                MySqlDataAdapter mpouss = new MySqlDataAdapter("SELECT * FROM intervention_pousse_seringe", conn);
                mpouss.SelectCommand.CommandType = CommandType.Text;
                mpouss.Fill(dbpouss);
                conn.Close();

            }
            catch (Exception ex)
            {
                conn.Close();
            }
            return dbpouss;


        }

        public static DataTable fillinterventdefibrillateur()
        {
            var dbdefib = new DataTable();
            if (conn == null)
                DBConnect();
            try
            {
                conn.Open();
                MySqlDataAdapter mdefib = new MySqlDataAdapter("SELECT * FROM intervention_defibrillateur", conn);
                mdefib.SelectCommand.CommandType = CommandType.Text;
                mdefib.Fill(dbdefib);
                conn.Close();

            }
            catch (Exception ex)
            {
                conn.Close();
            }
            return dbdefib;

        }



    }





}
    










































    

    

