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
        public static void   DBConnect()
        {
            // Connection String.
            String connectionString = "SERVER=" + host + ";" + "DATABASE=" +
        database + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";
            //connString = "Server=" + host + ";Database=" + database
            // + ";port=" + port + ";User Id=" + username + ";password=" + password;

            conn = new MySqlConnection(connectionString);
                   
        }
        public static bool se_connecter(string mat,string pass)
        {
            if (conn == null)
                DBConnect();
            try
            {
                conn.Open();
                var cmd = new MySqlCommand("SELECT * FROM techniciens WHERE matricule=@mat AND password=@pass", conn);
                cmd.Parameters.AddWithValue("@mat", mat);
                cmd.Parameters.AddWithValue("@pass", pass);
                cmd.Prepare();
                var reader = cmd.ExecuteReader();
                if(reader.HasRows)
                {
                    while(reader.Read())
                    {
                        Utilisateur_courant = new Utilisateur(reader.GetString("matricule"),
                            reader.GetString("nom_technicien"),
                            reader.GetString("prenom_technicen"),
                            reader.GetString("poste"),
                            reader.GetString("e_mail"));
                        return true;
                    }
                }
                conn.Close();
            }
            catch(Exception e)
            { 
                conn.Close();
                return false;
            }
            return false;
        }


        public static bool Ajouter_equipement(string marq,string Ty,string nu,string nahop,string naserv,string nareg)
        {

            if (conn == null)
                DBConnect();
            try
            {
                conn.Open();
                var aequip = new MySqlCommand("INSERT INTO equipements (marque,type,num_serie,nom_de_hopital , nom_de_service,nom_region)"+"VALUES(@marque, @type, @num_serie, @nom_de_hopital, @nom_de_service, @nom_region)",conn);
                aequip.Parameters.AddWithValue("@marque",marq);
                aequip.Parameters.AddWithValue("@type", Ty);
                aequip.Parameters.AddWithValue("@num_serie", nu);
                aequip.Parameters.AddWithValue("@nom_de_hopital", nahop);
                aequip.Parameters.AddWithValue("@nom_de_service", naserv);
                aequip.Parameters.AddWithValue("@nom_region", nareg);
                aequip.Parameters.AddWithValue("@nom_de_hopital", nahop);

                
                int rowCount = aequip.ExecuteNonQuery();
                MessageBox.Show("Row Count affected = " + rowCount);
                conn.Close();
                return rowCount == 1;


            }
            catch (Exception e)
            {
                return false;
            }
        }


        public static bool  Modifier_equipmement (string marq1, string Ty1, string nu1, string nahop1, string naserv1, string nareg1)
        {
            if (conn == null)
                DBConnect();
            try
            {

                conn.Open();
                var Mequip = new MySqlCommand("update equipements set marque=@marq ,type=@typ,num_serie= @numero ,nom_de_hopital=@hopital , nom_de_service=@service , nom_region=@region where ID_EQUIPEMENT= @id", conn);

                Mequip.Parameters.AddWithValue("@marq",marq1);
                Mequip.Parameters.AddWithValue("@typ", Ty1);
                Mequip.Parameters.AddWithValue("@numero", nu1);
                Mequip.Parameters.AddWithValue("@hopital",nahop1);
                Mequip.Parameters.AddWithValue("@service",naserv1);
                Mequip.Parameters.AddWithValue("@region", nareg1);
                Mequip.Parameters.AddWithValue("@id", 5);//e.id
                int rowCount = Mequip.ExecuteNonQuery();
                MessageBox.Show("Row Count affected = " + rowCount);
                conn.Close();
                return rowCount == 1;


            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static bool supprimer_equipement(int id)
        {
            if (conn == null)
                DBConnect();
            try
            {
                conn.Open();
                var Dequip = new MySqlCommand("delete from equipements where ID_EQUIPEMENT= @id", conn);
                Dequip.Parameters.AddWithValue("@id",id);
                int rowCount = Dequip.ExecuteNonQuery();
                MessageBox.Show("Row Count affected = " + rowCount);
                conn.Close();
                return rowCount == 1;


            }
            catch (Exception e)
            {
                return false;
            }
        }










    }
}
