using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using MySql.Data.MySqlClient;

namespace TP2
{ 
    public class DbProvider
    {
        private static String connectionString = "Server=127.0.0.1;Uid=root;Pwd=root;Database=conversion;";

        public static bool readLogin(Connexion c)
        {
                MySqlConnection cnx = new MySqlConnection();
                cnx.ConnectionString = connectionString; //"Server=127.0.0.1;Uid=root;Pwd=root;Database=conversion;";
                        cnx.Open();
                        MySqlCommand cmd = new MySqlCommand(); //Ou : MySqlCommand cmd = cnx.CreateCommand();
                        cmd.CommandText = "user";
                        cmd.Connection = cnx;
                        cmd.CommandType = CommandType.TableDirect;
                        MySqlDataReader dr = cmd.ExecuteReader();
                                
                        while (dr.Read())
                        {//get a list of all users 
                            // compare to data sent 
                            Connexion c2 = new Connexion();
                            c2.setUserName((dr.GetString("username")));
                            c2.setPassword((dr.GetString("password")));
                            if (c.getUsername().Equals(c2.getUsername()))
                                if (c.getPassword().Equals(c2.getPassword()))
                            {
                                return true; cnx.Close();
                            }
                            
                        }
                        return false;
        }
    
        public static bool create(Connexion c)
        {
            MySqlConnection cnx = new MySqlConnection();
            cnx.ConnectionString = connectionString;//"Server=127.0.0.1;Uid=root;Pwd=root;Database=conversion;";
            try
            {
                cnx.Open();
                MySqlCommand cmd = new MySqlCommand(); //Ou : MySqlCommand cmd = cnx.CreateCommand();
                cmd.CommandText = "INSERT INTO user (username,password) VALUES (@username,@password)";
                cmd.Parameters.AddWithValue("username", c.getUsername());
                cmd.Parameters.AddWithValue("password", c.getPassword());
                cmd.Connection = cnx;
                int n = cmd.ExecuteNonQuery();
                cnx.Close();
                return n > 0;
            }
            catch (Exception exp)
            {
                return false;
            }
        }
         
        /*public static Conversion find(String Monnaie)
        {
            MySqlConnection cnx = new MySqlConnection();
            cnx.ConnectionString = connectionString;//"Server=127.0.0.1;Uid=root;Pwd=root;Database=magasin;";
            try
            {
                cnx.Open();
                MySqlCommand cmd = new MySqlCommand(); //Ou : MySqlCommand cmd = cnx.CreateCommand();
                cmd.CommandText = "INSERT INTO produit (ID,DESIGNATION,PRIXUNIT) VALUES (@id,@designation,@prix)";
                cmd.Parameters("id", p.getId());
                cmd.Parameters.AddWithValue("designation", p.getDesignation());
                cmd.Parameters.AddWithValue("prix", p.getPrixUnit());
                cmd.Connection = cnx;
                int n = cmd.ExecuteNonQuery();
                cnx.Close();
                return n > 0;
            }
            catch (Exception exp)
            {
                return false;
            }
        }*/
        /*public static Conversion find(String nomMonnaie)
        {
            Conversion laMonnaie;
            MySqlConnection cnx = new MySqlConnection();
            cnx.ConnectionString = connectionString; //"Server=127.0.0.1;Uid=root;Pwd=root;Database=magasin;";

            cnx.Open();

            MySqlCommand cmd = new MySqlCommand(); //Ou : MySqlCommand cmd = cnx.CreateCommand();
            cmd.CommandText = "SELECT * FROM monnaie WHERE monnaie = 'nomMonnaie' " ;
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.TableDirect;
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                produit = new Produit();
                produit.setId(dr.GetString("ID"));
                produit.setDesignation(dr.GetString("DESIGNATION"));
                produit.setPrixUnit(dr.GetDouble("PRIXUNIT"));
                liste.Add(produit);
            }
            cnx.Close();
            return liste;
        }*/

        public static List<Conversion> findAll()
        {
            List<Conversion> listeMonnaie = new List<Conversion>();
            Conversion conversion;
            MySqlConnection cnx = new MySqlConnection();
            cnx.ConnectionString = connectionString; //"Server=127.0.0.1;Uid=root;Pwd=root;Database=magasin;";

            cnx.Open();

            MySqlCommand cmd = new MySqlCommand(); //Ou : MySqlCommand cmd = cnx.CreateCommand();
            cmd.CommandText = "taux";
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.TableDirect;
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                conversion = new Conversion();
                conversion.nom = (dr.GetString("monnaie")); 
                conversion.valeur = (dr.GetFloat("valeur"));
                listeMonnaie.Add(conversion);
            }
            cnx.Close();
            return listeMonnaie;
        }
    
    }
}