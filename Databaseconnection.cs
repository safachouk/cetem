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


        public static bool Ajouter_equipement(string Ty, string marq,string mod, string nu, string nareg, string nahop, string naserv)
        {

            if (conn == null)
                DBConnect();
            try
            {
                if(conn.State != System.Data.ConnectionState.Open)
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


        public static bool Ajouter_demande(string numbane,string numrea,string numpouss, string  numdef , string numtranspo , string numbistou , string dattt , string etatt , string numerooo , string nomregionnn , string nomhopitalll)
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


            public static bool Ajouter_Hopital(string Nomregion , string nomHopital)
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



        public static bool Ajouter_intervention_pousse_seringe ()
        {
            if (conn == null)
                DBConnect();
            try

            {

                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                var ajpoussse = new MySqlCommand("INSERT INTO intervention_pousse_seringe ()" + "VALUES(@nom_de_hopital, @nom_de_region)", conn);












            }








        }





































    }
    










































    

    

