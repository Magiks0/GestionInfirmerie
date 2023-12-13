using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace InfirmerieDAL
{
    public class StatistiqueDAO
    {
        public static Dictionary<string, int> GetNbVisitesEtNbEleves()
        {
            // Dictionnaire pour garder nos valeurs
            Dictionary<string, int> resultDictionary = new Dictionary<string, int>
            {
                { "NbTotalVisites", -1 },
                { "NbTotalEleves", -1 }
            };

            // Connexion à la BD
            using (SqlConnection maConnexion = DbConnection.GetConnexionBD().GetSqlConnexion())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = maConnexion;
                // select pour avoir le nombre total de visite dans la première colonne, puis le nombre total d'élèves dans la seconde
                cmd.CommandText = "SELECT (SELECT COUNT([id_visite]) FROM [GestionInfirmerie].[dbo].[Visite]) AS NbTotalVisites, (SELECT COUNT([id_eleve]) FROM [GestionInfirmerie].[dbo].[Eleve]) AS NbTotalEleves;";

                SqlDataReader monReader = cmd.ExecuteReader();

                // Remplissage du dictionnaire
                while (monReader.Read())
                {
                    resultDictionary["NbTotalVisites"] = Int32.Parse(monReader["NbTotalVisites"].ToString());
                    resultDictionary["NbTotalEleves"] = Int32.Parse(monReader["NbTotalEleves"].ToString());
                }
            }

            return resultDictionary;
        }

        public static Dictionary<string, float> GetInfoVisiteParPeriode(DateTime dateDebut, DateTime dateFin)
        {
            Dictionary<string, float> resultDictionary = new Dictionary<string, float>
            {
                { "NbTotalVisitesSurPeriode", -1 },
                { "NbTotalMedicamentsParVisiteSurPeriode", -1 },
                { "DureeAvgParVisiteSurPeriode", -1 },
                { "NbVisitesMoyenParEleveParVisiteSurPeriode", -1 },
                { "MbAvgMedicParVisiteSurPeriode", -1 }
            };

            // Connexion à la BD
            using (SqlConnection connection = DbConnection.GetConnexionBD().GetSqlConnexion())
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = @"
                    SELECT 
                        (SELECT COUNT([id_visite]) FROM [GestionInfirmerie].[dbo].[Visite] WHERE [date_visite] > @DateDebut AND [date_visite] < @DateFin) AS NbTotalVisitesSurPeriode,
                        (SELECT SUM(quantite_medicament_visite) FROM [GestionInfirmerie].[dbo].[Visite] WHERE [date_visite] > @DateDebut AND [date_visite] < @DateFin) AS NbTotalMedicamentsParVisiteSurPeriode,
                        (SELECT AVG(DATEDIFF(MINUTE, v.heure_debut_visite, v.heure_fin_visite)) FROM Visite v WHERE [date_visite] > @DateDebut AND [date_visite] < @DateFin) AS DureeAvgParVisiteSurPeriode,
                        (SELECT (CAST(COUNT(*) AS DECIMAL) / CAST((SELECT COUNT(*) FROM Eleve) AS DECIMAL)) FROM Visite WHERE [date_visite] > @DateDebut AND [date_visite] < @DateFin) AS NbVisitesMoyenParEleveParVisiteSurPeriode,
                        (SELECT AVG(quantite_medicament_visite) FROM Visite WHERE [date_visite] > @DateDebut AND [date_visite] < @DateFin) AS MbAvgMedicParVisiteSurPeriode;
                ";

                // ajout des paramètres pour parametrer notre requête
                command.Parameters.AddWithValue("@DateDebut", dateDebut);
                command.Parameters.AddWithValue("@DateFin", dateFin);

                SqlDataReader reader = command.ExecuteReader();

                // Remplisage du dictionnaire
                while (reader.Read())
                {
                    resultDictionary["NbTotalVisitesSurPeriode"] = Convert.ToInt32(reader["NbTotalVisitesSurPeriode"]);
                    resultDictionary["NbTotalMedicamentsParVisiteSurPeriode"] = Convert.ToInt32(reader["NbTotalMedicamentsParVisiteSurPeriode"]);
                    resultDictionary["DureeAvgParVisiteSurPeriode"] = Convert.ToInt32(reader["DureeAvgParVisiteSurPeriode"]);
                    resultDictionary["NbVisitesMoyenParEleveParVisiteSurPeriode"] = (float)Convert.ToDecimal(reader["NbVisitesMoyenParEleveParVisiteSurPeriode"]);
                    resultDictionary["MbAvgMedicParVisiteSurPeriode"] = (float)Convert.ToDecimal(reader["MbAvgMedicParVisiteSurPeriode"]);
                }
            }
            return resultDictionary;
        }

        public static Dictionary<string, int> GetNbMoisParAnnee(int annee)
        {
            Dictionary<string, int> resultDictionary = new Dictionary<string, int>
            {
                { "Janvier", -1 },
                { "Fevrier", -1 },
                { "Mars", -1 },
                { "Avril", -1 },
                { "Mai", -1 },
                { "Juin", -1 },
                { "Juillet", -1 },
                { "Aout", -1 },
                { "Septembre", -1 },
                { "Octobre", -1 },
                { "Novembre", -1 },
                { "Decembre", -1 }
            };

            // Connexion à la BD
            using (SqlConnection connection = DbConnection.GetConnexionBD().GetSqlConnexion())
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = @"
                    SELECT 
                        (SELECT COUNT(id_visite) FROM Visite WHERE YEAR(date_visite) = @Annee AND MONTH(date_visite) = 1) AS Janvier,
                        (SELECT COUNT(id_visite) FROM Visite WHERE YEAR(date_visite) = @Annee AND MONTH(date_visite) = 2) AS Fevrier,
                        (SELECT COUNT(id_visite) FROM Visite WHERE YEAR(date_visite) = @Annee AND MONTH(date_visite) = 3) AS Mars,
                        (SELECT COUNT(id_visite) FROM Visite WHERE YEAR(date_visite) = @Annee AND MONTH(date_visite) = 4) AS Avril,
                        (SELECT COUNT(id_visite) FROM Visite WHERE YEAR(date_visite) = @Annee AND MONTH(date_visite) = 5) AS Mai,
                        (SELECT COUNT(id_visite) FROM Visite WHERE YEAR(date_visite) = @Annee AND MONTH(date_visite) = 6) AS Juin,
                        (SELECT COUNT(id_visite) FROM Visite WHERE YEAR(date_visite) = @Annee AND MONTH(date_visite) = 7) AS Juillet,
                        (SELECT COUNT(id_visite) FROM Visite WHERE YEAR(date_visite) = @Annee AND MONTH(date_visite) = 8) AS Aout,
                        (SELECT COUNT(id_visite) FROM Visite WHERE YEAR(date_visite) = @Annee AND MONTH(date_visite) = 9) AS Septembre,
                        (SELECT COUNT(id_visite) FROM Visite WHERE YEAR(date_visite) = @Annee AND MONTH(date_visite) = 10) AS Octobre,
                        (SELECT COUNT(id_visite) FROM Visite WHERE YEAR(date_visite) = @Annee AND MONTH(date_visite) = 11) AS Novembre,
                        (SELECT COUNT(id_visite) FROM Visite WHERE YEAR(date_visite) = @Annee AND MONTH(date_visite) = 12) AS Decembre;
                ";

                // ajout des paramètres pour parametrer notre requête
                command.Parameters.AddWithValue("@Annee", annee);

                SqlDataReader reader = command.ExecuteReader();

                // Remplissage du dictionnaire
                while (reader.Read())
                {
                    resultDictionary["Janvier"] = Convert.ToInt32(reader["Janvier"]);
                    resultDictionary["Fevrier"] = Convert.ToInt32(reader["Fevrier"]);
                    resultDictionary["Mars"] = Convert.ToInt32(reader["Mars"]);
                    resultDictionary["Avril"] = Convert.ToInt32(reader["Avril"]);
                    resultDictionary["Mai"] = Convert.ToInt32(reader["Mai"]);
                    resultDictionary["Juin"] = Convert.ToInt32(reader["Juin"]);
                    resultDictionary["Juillet"] = Convert.ToInt32(reader["Juillet"]);
                    resultDictionary["Aout"] = Convert.ToInt32(reader["Aout"]);
                    resultDictionary["Septembre"] = Convert.ToInt32(reader["Septembre"]);
                    resultDictionary["Octobre"] = Convert.ToInt32(reader["Octobre"]);
                    resultDictionary["Novembre"] = Convert.ToInt32(reader["Novembre"]);
                    resultDictionary["Decembre"] = Convert.ToInt32(reader["Decembre"]);
                }
            }
            return resultDictionary;
        }
    }
}
