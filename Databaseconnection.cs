using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CetemLibrary
{
    public class Databaseconnection
    {
        static MySqlConnection conn;
        static Utilisateur Utilisateur_courant = null;

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
                            reader.GetString("e_mail"));
                        reader.Close();
                        conn.Close();

                        return true;
                    }
                }
                else
                {
                    MessageBox.Show("Erreur de connexion \nVeuillez vérifier votre matricule/Mot de pass", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                var aequip = new MySqlCommand("INSERT INTO equipements (MARQUE,TYPE,Modéle,NUM_SERIE,nom_de_hopital ,Nom_de_service,Nom_region)" + "VALUES(@marque, @type,@modele, @num_serie, @nom_de_hopital, @nom_de_service, @nom_region)", conn);
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


        public static bool Ajouter_demande(string numbane, string numrea, string numpouss, string numdef, string numtranspo, string numbistou, string dattt, string etatt, string numerooo, string nomregionnn, string nomhopitalll)
        {

            if (conn == null)
                DBConnect();
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                var ademand = new MySqlCommand("INSERT INTO demandes (Nombre_Respirateur_anesthesie,Nombre_respirateur_réanimation,nombre_pousse_seringe,nombre_defibrillateur,Nombre_respirateur_transport,Nombre_bistouri,Date_Demande ,Etat_demande , Numéro_demande , region_demande , Hopital_demande)" + "VALUES(@numberanest,@numberrea,@numberpouss,@numberdef,@numbertranspo,@numberbist, @Date , @Etat, @num, @nomregion, @nomhopital)", conn);
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
                var aintervrpouss = new MySqlCommand("INSERT INTO  intervention_pousse_seringe(numéro_intervention , date_intervention , Etat_intervention , Intervenant , Test_sécurit_électrique , Test_performance_prémiere_voie , Test_performance_déuxieme_voie , Commentaire , Numero_demande , etat_equip , num_ser_equip )" + "VALUES(@numéro_intervention , @date_intervention , @Etat_intervention , @Intervenant , @Test_sécurit_électrique , @Test_performance_prémiere_voie , @Test_performance_déuxieme_voie , @Commentaire , @Numero_demande , @etat_equip  , @num_ser_equip)", conn); 
               aintervrpouss.Parameters.AddWithValue("@numéro_intervention", numintervention1);
                aintervrpouss.Parameters.AddWithValue("@date_intervention", dateintervent1);
                aintervrpouss.Parameters.AddWithValue("@Etat_intervention", etatinterv1);
                aintervrpouss.Parameters.AddWithValue("@Intervenant", intervenant12);
                aintervrpouss.Parameters.AddWithValue("@Test_sécurit_électrique", testsecu1);
                aintervrpouss.Parameters.AddWithValue("@Test_performance_prémiere_voie", testvoie1);
                aintervrpouss.Parameters.AddWithValue("@Test_performance_déuxieme_voie", testvoie2);
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
        

        public static bool ajout_boustri (string numintervention2 , string dateintervent2 , string etatinterv2 , string intervenant2 , string typequip222 , string testsecuritu2 , string testmod2 , string comme2 , string numdemand2 , string testfuiteactive , string testfuiteneutre , string etat_equip2)
        {

            if (conn == null)
                DBConnect();
            try
            
            {

                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                var aintervrbistouri = new MySqlCommand("INSERT INTO intervention_bistouri(Numero_intervention , Date_intervention , 	Etat_intervention , Intervenant , typ_equipement , Test_securit_electrique , Test_des_modes , Commentaire , Numero_demande , test_fuite_partie_active , test_fuite_partie_neutre , etat_equip )" + "VALUES(@Numero_intervention2 , @Date_intervention2 , @Etat_intervention2 , @Intervenant2 , @typ_equipement2  , @Test_securit_electrique2 , @Test_des_modes2 , @Commentaire2 , @Numero_demande2 , @test_fuite_partie_active2 , @test_fuite_partie_neutre2 , @etat_equip2 )", conn);
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

                aintervrbistouri.Parameters.AddWithValue("@Numero_intervention2", numintervention2);



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




























    }
    }
    










































    

    

