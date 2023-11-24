using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfirmerieBO;
using System.Data.SqlClient;

namespace InfirmerieDAL
{
    public class MedicamentDAO
    {
        static MedicamentDAO unMedicamentDAO;

        // Accesseur en lecture, renvoie une instance
        public static MedicamentDAO GetunMedicament()
        {
            if (unMedicamentDAO == null)
            {
                unMedicamentDAO = new MedicamentDAO();
            }
            return unMedicamentDAO;
        }

        // Cette méthode retourne une List contenant les objets Eleves contenus dans la table Identification
        public static List<Medicament> GetMedicaments()
        {
            int id;
            string nom;
            Medicament unMedicament;

            // Connexion à la BD
            SqlConnection maConnexion = DbConnection.GetConnexionBD().GetSqlConnexion();

            // Création d'une liste vide d'objets Eleves
            List<Medicament> lesMedicaments = new List<Medicament>();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            // select pour avoir toute les informations d'Eleve ainsi que le nom de sa classe (pour la création d'objet classe)
            cmd.CommandText = "SELECT * FROM Medicament";

            SqlDataReader monReader = cmd.ExecuteReader();



            // Remplissage de la liste
            while (monReader.Read())
            {
                id = Int32.Parse(monReader["id_medicament"].ToString());
                nom = monReader["nom_medicament"].ToString();
                unMedicament = new Medicament(id, nom);
                lesMedicaments.Add(unMedicament);
            }

            // Fermeture de la connexion
            maConnexion.Close();

            return lesMedicaments;
        }

        public static int InsertMedicament(Medicament unMedicament)
        {
            int nbLignes;

            try
            {
                using (SqlConnection maConnexion = DbConnection.GetConnexionBD().GetSqlConnexion())
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = maConnexion;
                    cmd.CommandText = "INSERT INTO Medicament (nom_medicament) " +
                                      "VALUES (@nom)";

                    // Use parameters to avoid SQL injection
                    cmd.Parameters.AddWithValue("@nom", unMedicament.Nom);

                    nbLignes = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                return 0;
            }

            return nbLignes;
        }

        public static int UpdateMedicament(Medicament unMedicament)
        {
            int nbLignes;

            try
            {
                using (SqlConnection maConnexion = DbConnection.GetConnexionBD().GetSqlConnexion())
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = maConnexion;
                    cmd.CommandText = "UPDATE Medicament SET nom_medicament = @nom WHERE id_medicament = @id";
                    // Use parameters to avoid SQL injection
                    cmd.Parameters.AddWithValue("@nom", unMedicament.Nom);
                    cmd.Parameters.AddWithValue("@id", unMedicament.Id);
                    nbLignes = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                return 0;
            }

            return nbLignes;
        }

        public static int DeleteMedicament(Medicament unMedicament)
        {
            int nbLignes;

            try
            {
                using (SqlConnection maConnexion = DbConnection.GetConnexionBD().GetSqlConnexion())
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = maConnexion;
                    cmd.CommandText = "DELETE FROM Medicament WHERE id_medicament = @id";

                    // Use parameters to avoid SQL injection
                    cmd.Parameters.AddWithValue("@id", unMedicament.Id);

                    nbLignes = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                return 0;
            }

            return nbLignes;
        }


    }

}
