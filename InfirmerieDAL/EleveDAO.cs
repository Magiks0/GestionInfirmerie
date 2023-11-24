using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using InfirmerieBO;

namespace InfirmerieDAL
{
    public class EleveDAO
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
            string prenom;
            DateTime dateNaissance;
            string telEleve;
            Classe classe;
            string telParent;
            bool tiersTemps;
            string commentaire;
            Eleve unEleve;

            // Connexion à la BD
            SqlConnection maConnexion = DbConnection.GetConnexionBD().GetSqlConnexion();

            // Création d'une liste vide d'objets Eleves
            List<Eleve> lesEleves = new List<Eleve>();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            // select pour avoir toute les informations d'Eleve ainsi que le nom de sa classe (pour la création d'objet classe)
            cmd.CommandText = "SELECT * FROM Eleve E, Classe C WHERE E.id_classe_eleve = C.id_classe";

            SqlDataReader monReader = cmd.ExecuteReader();

            

            // Remplissage de la liste
            while (monReader.Read())
            {
                id = Int32.Parse(monReader["id_eleve"].ToString());
                nom = monReader["nom_eleve"].ToString();
                prenom = monReader["prenom_eleve"].ToString();
                // Use GetDateTime to retrieve the date_naissance_eleve as DateTime
                dateNaissance = monReader.GetDateTime(monReader.GetOrdinal("date_naissance_eleve"));
                telEleve = monReader["tel_portable_eleve"].ToString();
                // creation d'un objet classe à partir du numéro de classe dans eleve, et du libelle associé à ce dernier
                classe = new Classe(Int32.Parse(monReader["id_classe_eleve"].ToString()), monReader["nom_classe"].ToString());
                telParent = monReader["tel_parent_eleve"].ToString();
                tiersTemps = bool.Parse(monReader["tiers_temps_eleve"].ToString());
                commentaire = monReader["commentaire_sante_eleve"].ToString();
                unEleve = new Eleve(id, nom, prenom, dateNaissance, telEleve, classe, telParent, tiersTemps, commentaire) ;
                lesEleves.Add(unEleve);
            }

            // Fermeture de la connexion
            maConnexion.Close();

            return lesEleves;
        }

        // Cette méthode insère un nouvel Eleve passé en paramètre dans la BD
        public static int InsertEleve(Eleve unEleve)
        {
            int nbLignes;

            try
            {
                using (SqlConnection maConnexion = DbConnection.GetConnexionBD().GetSqlConnexion())
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = maConnexion;
                    cmd.CommandText = "INSERT INTO Eleve (nom_eleve, prenom_eleve, date_naissance_eleve, tel_portable_eleve, id_classe_eleve, tel_parent_eleve, tiers_temps_eleve, commentaire_sante_eleve) " +
                                      "VALUES (@nom, @prenom, @dateNaissance, @telEleve, @idClasse, @telParent, @tiersTemps, @commentaire)";

                    // Use parameters to avoid SQL injection
                    cmd.Parameters.AddWithValue("@nom", unEleve.Lastname); ;
                    cmd.Parameters.AddWithValue("@prenom", unEleve.Firstname);
                    cmd.Parameters.AddWithValue("@dateNaissance", unEleve.Birthdate);
                    cmd.Parameters.AddWithValue("@telEleve", unEleve.Phone);
                    // Bien prendre l'id de l'objet classe!
                    cmd.Parameters.AddWithValue("@idClasse", unEleve.ClassNumber.GetId());
                    cmd.Parameters.AddWithValue("@telParent", unEleve.ParentsPhone);
                    cmd.Parameters.AddWithValue("@tiersTemps", unEleve.ExtraTime);
                    cmd.Parameters.AddWithValue("@commentaire", unEleve.Comment);

                    nbLignes = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                return 0;
            }

            return nbLignes;
        }

        public static int UpdateEleve(Eleve unEleve)
        {
            int nbLignes;

            try
            {
                using (SqlConnection maConnexion = DbConnection.GetConnexionBD().GetSqlConnexion())
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = maConnexion;
                    cmd.CommandText = "UPDATE Eleve SET nom_eleve = @nom, prenom_eleve = @prenom, date_naissance_eleve = @dateNaissance, " +
                                      "tel_portable_eleve = @telEleve, id_classe_eleve = @idClasse, tel_parent_eleve = @telParent, " +
                                      "tiers_temps_eleve = @tiersTemps, commentaire_sante_eleve = @commentaire " +
                                      "WHERE id_eleve = @id";

                    // Use parameters to avoid SQL injection
                    cmd.Parameters.AddWithValue("@nom", unEleve.Lastname); ;
                    cmd.Parameters.AddWithValue("@prenom", unEleve.Firstname);
                    cmd.Parameters.AddWithValue("@dateNaissance", unEleve.Birthdate);
                    cmd.Parameters.AddWithValue("@telEleve", unEleve.Phone);
                    // Bien prendre l'id de l'objet classe!
                    cmd.Parameters.AddWithValue("@idClasse", unEleve.ClassNumber.GetId());
                    cmd.Parameters.AddWithValue("@telParent", unEleve.ParentsPhone);
                    cmd.Parameters.AddWithValue("@tiersTemps", unEleve.ExtraTime);
                    cmd.Parameters.AddWithValue("@commentaire", unEleve.Comment);
                    cmd.Parameters.AddWithValue("@id", unEleve.Id);

                    nbLignes = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                return 0;
            }

            return nbLignes;
        }

        public static int DeleteEleve(Eleve unEleve)
        {
            int nbLignes;

                using (SqlConnection maConnexion = DbConnection.GetConnexionBD().GetSqlConnexion())
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = maConnexion;
                    cmd.CommandText = "DELETE FROM Eleve WHERE id_eleve = @id";

                    // Use parameters to avoid SQL injection
                    cmd.Parameters.AddWithValue("@id", unEleve.Id);

                    nbLignes = cmd.ExecuteNonQuery();
                }

                // A AJOUTER GESTION EXCEPTION IMPOSsible de supprimer quand liée à une visite
            return nbLignes;
        }

    }
}