using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using InfirmerieBO;

namespace InfirmerieDAL
{
    class EleveDAO
    {
        static EleveDAO unEleveDAO;

        // Accesseur en lecture, renvoie une instance
        public static EleveDAO GetunEleveDAO()
        {
            if (unEleveDAO == null)
            {
                unEleveDAO = new EleveDAO();
            }
            return unEleveDAO;
        }

        // Cette méthode retourne une List contenant les objets Eleves contenus dans la table Identification
        public static List<Eleve> GetEleves()
        {
            int id;
            string nom;
            Eleve unEleve;

            // Connexion à la BD
            SqlConnection maConnexion = DbConnection.GetConnexionBD().GetSqlConnexion();

            // Création d'une liste vide d'objets Eleves
            List<Eleve> lesEleves = new List<Eleve>();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM T_Identification";

            SqlDataReader monReader = cmd.ExecuteReader();

            // Remplissage de la liste
            while (monReader.Read())
            {
                id = Int32.Parse(monReader["Id_Eleve"].ToString());

                if (monReader["Nom_Eleve"] == DBNull.Value)
                {
                    nom = default(string);
                }
                else
                {
                    nom = monReader["Nom_utilisateur"].ToString();
                }

                unEleve = new Eleve(id, nom);
                lesEleves.Add(unEleve);
            }

            // Fermeture de la connexion
            maConnexion.Close();

            return lesEleves;
        }

        // Cette méthode insère un nouvel Eleve passé en paramètre dans la BD
        public static int AjoutEleve(Eleve unEleve)
        {
            int nbEnr;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "INSERT INTO T_Identification VALUES('" + unEleve.GetNom() + "')";
            nbEnr = cmd.ExecuteNonQuery();

            // Fermeture de la connexion
            maConnexion.Close();

            return nbEnr;
        }

        // Cette méthode modifie un Eleve passé en paramètre dans la BD
        public static int UpdateEleve(Eleve unEleve)
        {
            int nbEnr;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "UPDATE T_Identification SET Nom_utilisateur = '" + unEleve.GetNom() + "' WHERE Id_utilisateur = " + unEleve.GetId();
            nbEnr = cmd.ExecuteNonQuery();

            // Fermeture de la connexion
            maConnexion.Close();

            return nbEnr;
        }

        // Cette méthode supprime de la BD un Eleve dont l'id est passé en paramètre
        public static int DeleteEleve(int id)
        {
            int nbEnr;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "DELETE FROM T_Identification WHERE Id_utilisateur = " + id;
            nbEnr = cmd.ExecuteNonQuery();

            // Fermeture de la connexion
            maConnexion.Close();

            return nbEnr;
        }
    }
}