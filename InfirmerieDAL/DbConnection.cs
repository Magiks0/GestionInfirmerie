using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace InfirmerieDAL
{
    public class DbConnection
    { 
            private SqlConnection maConnexion;
            private static DbConnection uneConnexionBD; // instance d'une connexion
            private string chaineConnexion; // chaîne de connexion à la BD

            // Accesseur en lecture de la chaîne de connexion
            public string GetchaineConnexion()
            {
                return chaineConnexion;
            }

            // Accesseur en écriture de la chaîne de connexion
            public void SetchaineConnexion(string ch)
            {
                chaineConnexion = ch;
            }

            // Accesseur en lecture, renvoi une instance de connexion
            public static DbConnection GetConnexionBD()
            {
                if (uneConnexionBD == null)
                {
                    uneConnexionBD = new DbConnection();
                }
                return uneConnexionBD;
            }

            // Constructeur privé
            private DbConnection()
            {
            }

            // Accesseur en lecture, renvoi une instance de SqlConnection
            public SqlConnection GetSqlConnexion()
            {
                if (maConnexion == null)
                {
                    maConnexion = new SqlConnection();
                }

                maConnexion.ConnectionString = chaineConnexion;
                // Si la connexion est fermée, on l’ouvre
                if (maConnexion.State == System.Data.ConnectionState.Closed)
                {
                     maConnexion.Open();
                }
                return maConnexion;
            }

            //Fermeture de la connexion
            public void CloseConnexion()
            {
                // Si la connexion est ouverte, on la ferme
                if (this.maConnexion != null && this.maConnexion.State != System.Data.ConnectionState.Closed)
                {
                    this.maConnexion.Close();
                }
            }
    }
}
