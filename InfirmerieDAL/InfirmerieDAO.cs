using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace InfirmerieDAL
{
    public class InfirmerieDAO
    {

        //Méthode d'authentification qui vérifie la conformité des données et renvoie un booléen en fonctions
        public static bool Authentification(string login, string mdp)
        {
            // Obtenir une connexion à la base de données en utilisant votre classe DbConnection
            SqlConnection maConnexion = DbConnection.GetConnexionBD().GetSqlConnexion();

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = maConnexion;
                cmd.CommandText = "SELECT * FROM Utilisateur WHERE nom_utilisateur = @login AND mot_de_passe_utilisateur = @mdp";
                cmd.Parameters.AddWithValue("@login", login);
                cmd.Parameters.AddWithValue("@mdp", mdp);

                SqlDataReader monReader = cmd.ExecuteReader();

                // Vérifier si une ligne correspondante a été trouvée
                if (monReader.Read())
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Gérer les exceptions en conséquence (journalisation, gestion des erreurs, etc.)
                Console.WriteLine("Erreur lors de l'authentification : " + ex.Message);
            }
            finally
            {
                // Fermer la connexion dans le bloc finally pour s'assurer qu'elle est toujours fermée, même en cas d'exception
                maConnexion.Close();
            }

            return false;
        }
    }
}