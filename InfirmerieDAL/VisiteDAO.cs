using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using InfirmerieBO;

namespace InfirmerieDAL
{
    public class VisiteDAO
    {
        static VisiteDAO uneVisiteDAO;
        public static VisiteDAO GetuneVisiteDAO()
        {
            if (uneVisiteDAO == null)
            {
                uneVisiteDAO = new VisiteDAO();
            }
            return uneVisiteDAO;
        }

        public static List<Visite> GetVisites()
        {
            int id;
            Eleve eleve;
            DateTime dateVisite;
            TimeSpan heureDebutVisite;
            TimeSpan heureFinVisite;
            string motifVisite;
            string commentaireVisite;
            bool renvoiDomicile;
            bool hospitalisation;
            bool parentsPrevenus;
            Medicament medicament;
            string quantiteMeidcament;
            Visite uneVisite;

            // Connexion à la BD
            SqlConnection maConnexion = DbConnection.GetConnexionBD().GetSqlConnexion();

            // Création d'une liste vide d'objets Visites
            List<Visite> lesVisites = new List<Visite>();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            // select pour avoir toute les informations de Visite ainsi que le nom de sa classe (pour la création d'objet classe)
            cmd.CommandText = "SELECT * FROM Visite V, Eleve E, Medicament M WHERE V.id_eleve_visite = E.id_eleve AND V.id_medicament_visite = M.id_medicament";

            SqlDataReader monReader = cmd.ExecuteReader();



            // Remplissage de la liste
            while (monReader.Read())
            {
                id = Int32.Parse(monReader["id_visite"].ToString());
                //VRAIMENT PAS SUR JE TROUVE CA INUTILE D'APPELER TOUT CA LA DEDANS
                eleve = new Eleve (monReader["nom_eleve"].ToString(), monReader["prenom_eleve"].ToString(), monReader.GetDateTime(monReader.GetOrdinal("date_naissance_eleve")), monReader["tel_portable_eleve"].ToString(), new Classe(Int32.Parse(monReader["id_classe_eleve"].ToString())), monReader["tel_parent_eleve"].ToString(), bool.Parse(monReader["tiers_temps_eleve"].ToString()), monReader["commentaire_sante_eleve"].ToString());
                dateVisite = monReader.GetDateTime(monReader.GetOrdinal("date_visite"));
                heureDebutVisite = monReader.GetTimeSpan(monReader.GetOrdinal("heure_debut_visite"));
                heureFinVisite = monReader.GetTimeSpan(monReader.GetOrdinal("heure_fin_visite"));
                motifVisite = monReader["motif_visite"].ToString();
                commentaireVisite = monReader["commentaires_visite"].ToString();
                renvoiDomicile = bool.Parse(monReader["renvoi_domicile_visite"].ToString());
                hospitalisation = bool.Parse(monReader["hospitalisation_visite"].ToString());
                parentsPrevenus = bool.Parse(monReader["parents_prevenus_visite"].ToString());
                medicament = new Medicament(Int32.Parse(monReader["id_medicament_visite"].ToString()), monReader["nom_medicament"].ToString());
                quantiteMeidcament = monReader["quantite_medicament_visite"].ToString();
                uneVisite = new Visite(id, eleve, dateVisite, heureDebutVisite, heureFinVisite, motifVisite, commentaireVisite, renvoiDomicile, hospitalisation, parentsPrevenus, medicament, quantiteMeidcament);
                lesVisites.Add(uneVisite);
            }

            // Fermeture de la connexion
            maConnexion.Close();

            return lesVisites;
        }

        // Cette méthode insère un nouvel Eleve passé en paramètre dans la BD
        public static int InsertVisite(Visite uneVisite)
        {
            int nbLignes;

            try
            {
                using (SqlConnection maConnexion = DbConnection.GetConnexionBD().GetSqlConnexion())
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = maConnexion;
                    cmd.CommandText = "INSERT INTO Visite (id_eleve_visite, date_visite, heure_debut_visite, heure_fin_visite, motif_visite, commentaires_visite, renvoi_domicile_visite, hospitalisation_visite, parents_prevenus_visite, id_medicament_visite, quantite_medicament_visite) " +
                                      "VALUES (@idEleve, @dateVisite, @heureDebutVisite, @heureFinVisite, @motifVisite, @commentaireVisite, @renvoiDomicile, @hospitalisation, @parentsPrevenus, @medicament, @quantiteMedicament)";

                    // Use parameters to avoid SQL injection
                    cmd.Parameters.AddWithValue("@idEleve", uneVisite.Eleve.GetId()); ;
                    cmd.Parameters.AddWithValue("@dateVisite", uneVisite.DateVisite);
                    cmd.Parameters.AddWithValue("@heureDebutVisite", uneVisite.HeureDebutVisite);
                    cmd.Parameters.AddWithValue("@heureFinVisite", uneVisite.HeureFinVisite);
                    cmd.Parameters.AddWithValue("@motifVisite", uneVisite.MotifVisite);
                    cmd.Parameters.AddWithValue("@commentaireVisite", uneVisite.CommentaireVisite);
                    cmd.Parameters.AddWithValue("@renvoiDomicile", uneVisite.RenvoiDomicile);
                    cmd.Parameters.AddWithValue("@hospitalisation", uneVisite.Hospitalisation);
                    cmd.Parameters.AddWithValue("@parentsPrevenus", uneVisite.ParentsPrevenus);
                    cmd.Parameters.AddWithValue("@idMedicament", uneVisite.Medicament.GetId());
                    cmd.Parameters.AddWithValue("@quantiteMedicament", uneVisite.QuantiteMedicament);

                    nbLignes = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                return 0;
            }

            return nbLignes;
        }

        public static int UpdateVisite(Visite uneVisite)
        {
            int nbLignes;

            try
            {
                using (SqlConnection maConnexion = DbConnection.GetConnexionBD().GetSqlConnexion())
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = maConnexion;
                    cmd.CommandText = "UPDATE Visite SET date_visite = @dateVisite, heure_debut_visite = @heureDebutVisite, heure_fin_visite = @heureFinVisite," +
                                      "motif_visite = @motifVisite, commentaires_visite = @commentaireVisite, renvoi_domicile_visite = @renvoiDomicile," +
                                      "hospitalisation_visite = @hospitalisation, parents_prevenus_visite = @parentsPrevenus, id_medicament_visite = @medicament," +
                                      "quantite_medicament_visite = @quantiteMedicament WHERE id_eleve_visite = @idEleve";

                    // Use parameters to avoid SQL injection
                    cmd.Parameters.AddWithValue("@idEleve", uneVisite.Eleve.GetId()); ;
                    cmd.Parameters.AddWithValue("@dateVisite", uneVisite.DateVisite);
                    cmd.Parameters.AddWithValue("@heureDebutVisite", uneVisite.HeureDebutVisite);
                    cmd.Parameters.AddWithValue("@heureFinVisite", uneVisite.HeureFinVisite);
                    cmd.Parameters.AddWithValue("@motifVisite", uneVisite.MotifVisite);
                    cmd.Parameters.AddWithValue("@commentaireVisite", uneVisite.CommentaireVisite);
                    cmd.Parameters.AddWithValue("@renvoiDomicile", uneVisite.RenvoiDomicile);
                    cmd.Parameters.AddWithValue("@hospitalisation", uneVisite.Hospitalisation);
                    cmd.Parameters.AddWithValue("@parentsPrevenus", uneVisite.ParentsPrevenus);
                    cmd.Parameters.AddWithValue("@idMedicament", uneVisite.Medicament.GetId());
                    cmd.Parameters.AddWithValue("@quantiteMedicament", uneVisite.QuantiteMedicament);

                    nbLignes = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                return 0;
            }

            return nbLignes;
        }

        public static int DeleteVisite(Visite uneVisite)
        {
            int nbLignes;

            using (SqlConnection maConnexion = DbConnection.GetConnexionBD().GetSqlConnexion())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = maConnexion;
                cmd.CommandText = "DELETE FROM Visite WHERE id_visite = @id";

                // Use parameters to avoid SQL injection
                cmd.Parameters.AddWithValue("@id", uneVisite.Id);

                nbLignes = cmd.ExecuteNonQuery();
            }
            return nbLignes;
        }

    }
}
