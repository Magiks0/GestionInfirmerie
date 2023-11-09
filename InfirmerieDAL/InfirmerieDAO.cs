using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using InfirmerieBO;

namespace InfirmerieDAL
{
    class InfirmerieDAO
    {
        public static bool Authentification(string login,string mdp)
        {
            //connexion BDD
            SqlConnection maConnexion = DbConnection.GetConnexionBD().GetSqlConnexion();


            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM Utilisateur";
            SqlDataReader monReader = cmd.ExecuteReader();

            while (monReader.Read())
            {
                string verifLogin = monReader["nom_utilisateur"].ToString();

                if (monReader["nom_Utilisateur"] == verifLogin)
                {
                    string verifmdp = monReader["mot_de_passe_utilisateur"].ToString();

                    if (monReader["mot_de_passe_utilisateur"] == mdp)
                    {
                        return true;
                    }
                }
            }

            return false;

            // Fermeture de la connexion
            maConnexion.Close();

        }

        //-- Autres methodes --

    }
}
